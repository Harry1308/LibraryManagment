using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AthName, BookPrc, BookNme, BookId;

            AthName = AuthorTB.Text.ToLower();
            BookPrc = BookPriceTB.Text.ToLower();
            BookNme = BookNameTB.Text.ToLower();
            BookId = BookIDTB.Text.ToLower();


            CollectionLB.Items.Add(AthName + ", " + BookNme + ", " + BookPrc + ", " + BookId);




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CollectionLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteBookBTN_Click(object sender, EventArgs e)
        {
            CollectionLB.Items.RemoveAt(CollectionLB.SelectedIndex);
           
        }
    }
}
