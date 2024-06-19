using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows.Forms;

namespace db2
{
    public partial class Sales : Form
    {
        private static IMongoClient client = new MongoClient("mongodb://localhost:27017");
        private static IMongoDatabase db = client.GetDatabase("Al_Fatah");
        private static IMongoCollection<Product> productsCollection = db.GetCollection<Product>("products");
        private static IMongoCollection<SalesData> salesCollection = db.GetCollection<SalesData>("sales");

        public Sales()
        {
            InitializeComponent();
            DisplaySalesData();
        }

        public class Product
        {
            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("Product_Name")]
            public string Name { get; set; }

            [BsonElement("Product_Price")]
            public int Price { get; set; }

            [BsonElement("Product_Qty")]
            public int Qty { get; set; }

            [BsonElement("Product_Ctg")]
            public string Category { get; set; }

            [BsonElement("Product_Code")]
            public string Code { get; set; }
        }

        public class SalesData
        {
            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("totalProductsSold")]
            public int TotalProductsSold { get; set; }

            [BsonElement("totalSales")]
            public int TotalSales { get; set; }
        }

        private void DisplaySalesData()
        {
            // Retrieve the products from the database
            var products = productsCollection.Find(_ => true).ToList();

            // Calculate total sales and total products sold
            int totalProductsSold = 0;
            int totalSales = 0;

            foreach (var product in products)
            {
                totalProductsSold += product.Qty;
                totalSales += product.Price * product.Qty;
            }

            // Update the sales collection with the new totals
            var salesData = salesCollection.Find(_ => true).FirstOrDefault();
            if (salesData == null)
            {
                salesData = new SalesData
                {
                    TotalProductsSold = totalProductsSold,
                    TotalSales = totalSales
                };
                salesCollection.InsertOne(salesData);
            }
            else
            {
                var update = Builders<SalesData>.Update
                    .Set(s => s.TotalProductsSold, totalProductsSold)
                    .Set(s => s.TotalSales, totalSales);
                salesCollection.UpdateOne(s => s.Id == salesData.Id, update);
            }

            // Display the results in the text boxes
            txtProductsSold.Text = totalProductsSold.ToString();
            txtTotalSales.Text = totalSales.ToString();
        }

        private void txtProductsSold_TextChanged(object sender, EventArgs e)
        {
            // This method is intentionally left blank
        }

        private void txtTotalSales_TextChanged(object sender, EventArgs e)
        {
            // This method is intentionally left blank
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu backback = new Menu();
            backback.Show();
            this.Close();
        }
    }
}
