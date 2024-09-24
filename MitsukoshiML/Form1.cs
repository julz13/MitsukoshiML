using MitsukoshiML.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SQLite;
using System.Xml.Linq;

namespace MitsukoshiML
{
    public partial class Form1 : Form
    {
        private string _databaseFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Orders.mdb");
        private FileSystemWatcher watcher;
        static string connectionTEMP = null;

        public Form1()
        {
            InitializeComponent();
            GlobarVar.InitializeConfiguration();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            config config = new config();
            config.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close this application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TempDatabase();
            InitializeFileWatcher();
        }

        #region Temp DB
        static void TempDatabase()
        {
            string databaseFileName = "Temp.db";
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, databaseFileName);

            connectionTEMP = $"Data Source={databasePath};Version=3;";

            if (!File.Exists(databasePath))
            {
                CreateDatabase(databasePath);
                MessageBox.Show($"SQLite database '{databaseFileName}' created successfully in the application folder.");
            }

            //string xmlFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "XMLFiles");
            string xmlFolderPath = GlobarVar.XMLPath + "\\";

            if (!Directory.Exists(xmlFolderPath))
            {
                Directory.CreateDirectory(xmlFolderPath);
            }

            string[] xmlFiles = Directory.GetFiles(xmlFolderPath, "*.xml");

            foreach (string xmlFile in xmlFiles)
            {
                try
                {
                    string xmlContent = File.ReadAllText(xmlFile);
                    ParseAndSaveXmlToDatabase(xmlContent, databasePath);

                    string processedFolderPath = Path.Combine(xmlFolderPath, "ProcessedFiles");
                    if (!Directory.Exists(processedFolderPath))
                    {
                        Directory.CreateDirectory(processedFolderPath);
                    }
                    string destinationFilePath = Path.Combine(processedFolderPath, Path.GetFileName(xmlFile));
                    File.Move(xmlFile, destinationFilePath);

                    //MessageBox.Show($"File '{Path.GetFileName(xmlFile)}' processed and moved to 'ProcessedFiles' folder.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error processing file '{xmlFile}': {ex.Message}");
                }
            }
        }
        #endregion

        #region FileSystemWatcher Initialization
        private void InitializeFileWatcher()
        {
            string xmlFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "XMLFiles");

            watcher = new FileSystemWatcher
            {
                Path = xmlFolderPath,
                Filter = "*.xml", // Only monitor XML files
                NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite
            };

            // Event handler for when a new file is created
            watcher.Created += OnNewFileCreated;

            watcher.EnableRaisingEvents = true; // Start monitoring
            //MessageBox.Show($"Monitoring '{xmlFolderPath}' for new XML files.");
        }

        private void OnNewFileCreated(object sender, FileSystemEventArgs e)
        {
            // Wait for the file to be fully written before processing
            System.Threading.Thread.Sleep(1000);

            try
            {
                string xmlContent = File.ReadAllText(e.FullPath);
                string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Temp.db");

                ParseAndSaveXmlToDatabase(xmlContent, databasePath);

                // Move the processed file to the "ProcessedFiles" folder
                string processedFolderPath = Path.Combine(Path.GetDirectoryName(e.FullPath), "ProcessedFiles");
                if (!Directory.Exists(processedFolderPath))
                {
                    Directory.CreateDirectory(processedFolderPath);
                }
                string destinationFilePath = Path.Combine(processedFolderPath, Path.GetFileName(e.FullPath));
                File.Move(e.FullPath, destinationFilePath);

                //MessageBox.Show($"New file '{Path.GetFileName(e.FullPath)}' processed and moved to 'ProcessedFiles' folder.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing new file: {ex.Message}");
            }
        }
        #endregion

        #region CreateDatabase
        static void CreateDatabase(string path)
        {
            SQLiteConnection.CreateFile(path);

            using (var connection = new SQLiteConnection($"Data Source={path};Version=3;"))
            {
                connection.Open();

                string createOrderTable = @"CREATE TABLE IF NOT EXISTS Orders (
                OrderNo TEXT PRIMARY KEY,
                StoreName TEXT,
                Subtotal REAL,
                Tips REAL,
                ServiceCharge REAL,
                Total REAL,
                Void INTEGER,
                AccDate TEXT,
                SalesType INTEGER
            );";

                string createDiscountTable = @"CREATE TABLE IF NOT EXISTS Discounts (
                OrderNo TEXT,
                Type TEXT,
                Value REAL,
                FOREIGN KEY (OrderNo) REFERENCES Orders(OrderNo)
            );";

                string createTaxTable = @"CREATE TABLE IF NOT EXISTS Taxes (
                OrderNo TEXT,
                Type TEXT,
                Name TEXT,
                Amount REAL,
                FOREIGN KEY (OrderNo) REFERENCES Orders(OrderNo)
            );";

                string createItemTable = @"CREATE TABLE IF NOT EXISTS Items (
                OrderNo TEXT,
                SeqNo INTEGER,
                MenuKey TEXT,
                MenuNo TEXT,
                MenuName TEXT,
                Qty INTEGER,
                PriceBefDisc REAL,
                PriceAftDisc REAL,
                DiscCode TEXT,
                DiscName TEXT,
                DiscAmount REAL,
                TaxCode TEXT,
                TotalTax REAL,
                Discount REAL,
                Price REAL,
                Disc_Per REAL,
                FOREIGN KEY (OrderNo) REFERENCES Orders(OrderNo)
            );";

                string createPaymentTable = @"CREATE TABLE IF NOT EXISTS Payments (
                OrderNo TEXT,
                Type TEXT,
                Name TEXT,
                Amount REAL,
                FOREIGN KEY (OrderNo) REFERENCES Orders(OrderNo)
            );";

                var command = connection.CreateCommand();
                command.CommandText = createOrderTable;
                command.ExecuteNonQuery();

                command.CommandText = createDiscountTable;
                command.ExecuteNonQuery();

                command.CommandText = createTaxTable;
                command.ExecuteNonQuery();

                command.CommandText = createItemTable;
                command.ExecuteNonQuery();

                command.CommandText = createPaymentTable;
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region SavetoDatabase
        static void ParseAndSaveXmlToDatabase(string xmlContent, string databasePath)
        {
            XDocument doc = XDocument.Parse(xmlContent);
            XElement orderElement = doc.Element("Order");

            if (orderElement != null)
            {
                // Extract Order details (same as your original code)
                string orderNo = orderElement.Attribute("orderNo")?.Value;
                string storeName = orderElement.Attribute("storename")?.Value;
                decimal subtotal = decimal.Parse(orderElement.Attribute("subtotal")?.Value ?? "0");
                decimal tips = decimal.Parse(orderElement.Attribute("tips")?.Value ?? "0");
                decimal serviceCharge = decimal.Parse(orderElement.Attribute("serviceCharge")?.Value ?? "0");
                decimal total = decimal.Parse(orderElement.Attribute("total")?.Value ?? "0");
                int voided = int.Parse(orderElement.Attribute("void")?.Value ?? "0");
                string accDate = orderElement.Attribute("accDate")?.Value;
                int salesType = int.Parse(orderElement.Attribute("salestype")?.Value ?? "0");

                using (var connection = new SQLiteConnection($"Data Source={databasePath};Version=3;"))
                {
                    connection.Open();
                    var transaction = connection.BeginTransaction();

                    var command = connection.CreateCommand();
                    command.CommandText = @"INSERT INTO Orders (OrderNo, StoreName, Subtotal, Tips, ServiceCharge, Total, Void, AccDate, SalesType) 
                                            VALUES (@OrderNo, @StoreName, @Subtotal, @Tips, @ServiceCharge, @Total, @Void, @AccDate, @SalesType)";

                    command.Parameters.AddWithValue("@OrderNo", orderNo);
                    command.Parameters.AddWithValue("@StoreName", storeName);
                    command.Parameters.AddWithValue("@Subtotal", subtotal);
                    command.Parameters.AddWithValue("@Tips", tips);
                    command.Parameters.AddWithValue("@ServiceCharge", serviceCharge);
                    command.Parameters.AddWithValue("@Total", total);
                    command.Parameters.AddWithValue("@Void", voided);
                    command.Parameters.AddWithValue("@AccDate", accDate);
                    command.Parameters.AddWithValue("@SalesType", salesType);
                    command.ExecuteNonQuery();

                    // Process Discounts, Taxes, Items, Payments (same logic as original)
                    // Insert Discounts
                    foreach (XElement discount in orderElement.Element("Discounts").Elements("Discount"))
                    {
                        command.CommandText = @"INSERT INTO Discounts (OrderNo, Type, Value) VALUES (@OrderNo, @Type, @Value)";
                        command.Parameters.AddWithValue("@Type", discount.Attribute("type")?.Value);
                        command.Parameters.AddWithValue("@Value", decimal.Parse(discount.Attribute("value")?.Value ?? "0"));
                        command.ExecuteNonQuery();
                    }

                    // Insert Taxes
                    foreach (XElement tax in orderElement.Element("Taxes").Elements("Tax"))
                    {
                        command.CommandText = @"INSERT INTO Taxes (OrderNo, Type, Name, Amount) VALUES (@OrderNo, @Type, @Name, @Amount)";
                        command.Parameters.AddWithValue("@Type", tax.Attribute("type")?.Value);
                        command.Parameters.AddWithValue("@Name", tax.Attribute("name")?.Value);
                        command.Parameters.AddWithValue("@Amount", decimal.Parse(tax.Attribute("amount")?.Value ?? "0"));
                        command.ExecuteNonQuery();
                    }

                    // Insert Items
                    foreach (XElement item in orderElement.Element("Items").Elements("Item"))
                    {
                        command.CommandText = @"INSERT INTO Items (OrderNo, SeqNo, MenuKey, MenuNo, MenuName, Qty, PriceBefDisc, PriceAftDisc, DiscCode, DiscName, DiscAmount, TaxCode, TotalTax, Discount, Price, Disc_Per) 
                                            VALUES (@OrderNo, @SeqNo, @MenuKey, @MenuNo, @MenuName, @Qty, @PriceBefDisc, @PriceAftDisc, @DiscCode, @DiscName, @DiscAmount, @TaxCode, @TotalTax, @Discount, @Price, @Disc_Per)";
                        command.Parameters.AddWithValue("@SeqNo", int.Parse(item.Attribute("SeqNo")?.Value ?? "0"));
                        command.Parameters.AddWithValue("@MenuKey", item.Attribute("MenuKey")?.Value);
                        command.Parameters.AddWithValue("@MenuNo", item.Attribute("MenuNo")?.Value);
                        command.Parameters.AddWithValue("@MenuName", item.Attribute("MenuName")?.Value);
                        command.Parameters.AddWithValue("@Qty", int.Parse(item.Attribute("Qty")?.Value ?? "0"));
                        command.Parameters.AddWithValue("@PriceBefDisc", decimal.Parse(item.Attribute("PriceBefDisc")?.Value ?? "0"));
                        command.Parameters.AddWithValue("@PriceAftDisc", decimal.Parse(item.Attribute("PriceAftDisc")?.Value ?? "0"));
                        command.Parameters.AddWithValue("@DiscCode", item.Attribute("DiscCode")?.Value);
                        command.Parameters.AddWithValue("@DiscName", item.Attribute("DiscName")?.Value);
                        command.Parameters.AddWithValue("@DiscAmount", decimal.Parse(item.Attribute("DiscAmount")?.Value ?? "0"));
                        command.Parameters.AddWithValue("@TaxCode", item.Attribute("TaxCode")?.Value);
                        command.Parameters.AddWithValue("@TotalTax", decimal.Parse(item.Attribute("TotalTax")?.Value ?? "0"));
                        command.Parameters.AddWithValue("@Discount", decimal.Parse(item.Attribute("Discount")?.Value ?? "0"));
                        command.Parameters.AddWithValue("@Price", decimal.Parse(item.Attribute("Price")?.Value ?? "0"));
                        command.Parameters.AddWithValue("@Disc_Per", decimal.Parse(item.Attribute("Disc_Per")?.Value ?? "0"));
                        command.ExecuteNonQuery();
                    }

                    // Insert Payments
                    foreach (XElement payment in orderElement.Element("Payments").Elements("Payment"))
                    {
                        command.CommandText = @"INSERT INTO Payments (OrderNo, Type, Name, Amount) 
                                            VALUES (@OrderNo, @Type, @Name, @Amount)";
                        command.Parameters.AddWithValue("@Type", payment.Attribute("type")?.Value);
                        command.Parameters.AddWithValue("@Name", payment.Attribute("name")?.Value);
                        command.Parameters.AddWithValue("@Amount", decimal.Parse(payment.Attribute("amount")?.Value ?? "0"));
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
            }
        }
        #endregion
    }
}