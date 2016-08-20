using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_Assignment7
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            SelectedTitleTextBox.Text = MovieTitles;
        }

        private string _movieTitle, _movieCategory, _movieCost;
        public SelectionForm selectionForm { get; set; }
        public string MovieTitles
        {
            get { return _movieTitle; }
            set { _movieTitle = value; }
        }
        public string MovieCategory
        {
            get { return _movieCategory; }
            set { _movieCategory = value; }
        }
        public string MovieCost
        {
            get { return _movieCost; }
            set { _movieCost = value; }
        }

        public Image MoviePicture { get; set; }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            selectionForm.Close();
            Application.Exit();
        }

        private void StreamButton_Click(object sender, EventArgs e)
        {
            StreamForm streamForm = new StreamForm();
            streamForm.orderForm = this;
            streamForm.MessageLabel2.Text = GrandTotalTextBox.Text;
            streamForm.MessageLabel3.Text = SelectedTitleTextBox.Text;
            streamForm.Show();
            this.Hide();
        }

        private void CalculateTotal()
        {
            decimal cost = decimal.Parse(CostTextBox2.Text, System.Globalization.NumberStyles.Currency);
            double subTotal = 0;
            double tax = 0.13;
            if (DVDCheckBox.Checked == true)
            {
                OrderAddLabel.Visible = true;
                OrderAddTextBox.Visible = true;

                subTotal = double.Parse(SubTotalTextBox.Text, System.Globalization.NumberStyles.Currency) + 10;
                tax *= (double)subTotal;
                OrderAddTextBox.Text = "$10.00";
                TaxTextBox.Text = string.Format("{0:c}", tax);
                SubTotalTextBox.Text = string.Format("{0:c}", subTotal);
                GrandTotalTextBox.Text = string.Format("{0:c}", (tax + (double)subTotal));
            }
            else
            {
                OrderAddLabel.Visible = false;
                OrderAddTextBox.Visible = false;

                subTotal = (double)cost;
                tax *= (double)subTotal;
                SubTotalTextBox.Text = string.Format("{0:c}", subTotal);
                TaxTextBox.Text = string.Format("{0:c}", tax);
                GrandTotalTextBox.Text = string.Format("{0:c}", (tax + (double)subTotal));
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            SelectedTitleTextBox.Text = _movieTitle;
            SelectedCategoryTextBox.Text = _movieCategory;
            CostTextBox2.Text = _movieCost;
            SelectedMoviePictureBox.Image = MoviePicture;
            CalculateTotal();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order detail will be printed");
        }

        private void streamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamButton_Click(sender, e);
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackButton_Click(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.selectionForm.Show();
            this.Close();
        }

        private void DVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }
    }
}
