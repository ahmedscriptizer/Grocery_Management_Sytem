using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void product_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the Cheezform
            Cheez cheezForm = new Cheez();

            // Show the ProductForm
            cheezForm.Show();

            // Close the Menu form
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Custom custom = new Custom();
            custom.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Emp employee = new Emp();
            employee.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales();
            sale.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Promo promo = new Promo();
            promo.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FeedBackcs feedBackcs = new FeedBackcs();
            feedBackcs.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Invent invent = new Invent();
            invent.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.Show();
            this.Close();
        }
    }
}
