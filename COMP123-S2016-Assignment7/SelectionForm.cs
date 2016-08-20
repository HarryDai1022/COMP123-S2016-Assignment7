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
    public partial class SelectionForm : Form
    {
        public IEnumerable<object> Movies { get; private set; }

        public SelectionForm()
        {
            InitializeComponent();
        }

        public void SplashStart()
        {
            Application.Run(new SplashForm());
        }

        private string currentItem;
        public void movieSelection(string movieTitle)
        {
            switch (MovieListBox.SelectedItem.ToString())
            {
                case "Season of the Witch":
                    MoviePictureBox.Image = COMP123_S2016_Assignment7.Properties.Resources.seasonofthewitch;
                    CategoryTextBox.Text = "Sci-Fi";
                    CostTextBox.Text = "$2.99";
                    break;
                case "The Green Hornet":
                    MoviePictureBox.Image = COMP123_S2016_Assignment7.Properties.Resources.thegreenhornet;
                    CategoryTextBox.Text = "Action";
                    CostTextBox.Text = "$2.99";
                    break;
                case "The Dilemma":
                    MoviePictureBox.Image = COMP123_S2016_Assignment7.Properties.Resources.thedilemma;
                    CategoryTextBox.Text = "Comedy";
                    CostTextBox.Text = "$1.99";
                    break;
                case "Death Race 2":
                    MoviePictureBox.Image = COMP123_S2016_Assignment7.Properties.Resources.deathrace2;
                    CategoryTextBox.Text = "Action";
                    CostTextBox.Text = "$2.99";
                    break;
                case "Company Men":
                    MoviePictureBox.Image = COMP123_S2016_Assignment7.Properties.Resources.companymen;
                    CategoryTextBox.Text = "Drama";
                    CostTextBox.Text = "$1.99";
                    break;
                case "No Strings Attached":
                    MoviePictureBox.Image = COMP123_S2016_Assignment7.Properties.Resources.nostringsattached;
                    CategoryTextBox.Text = "Comedy";
                    CostTextBox.Text = "$1.99";
                    break;
                case "The Way Back":
                    MoviePictureBox.Image = COMP123_S2016_Assignment7.Properties.Resources.thewayback;
                    CategoryTextBox.Text = "Drama";
                    CostTextBox.Text = "$1.99";
                    break;
                case "The Mechanic":
                    MoviePictureBox.Image = COMP123_S2016_Assignment7.Properties.Resources.themechanic;
                    CategoryTextBox.Text = "Action";
                    CostTextBox.Text = "$2.99";
                    break;
                case "The Rite":
                    MoviePictureBox.Image = COMP123_S2016_Assignment7.Properties.Resources.therite;
                    CategoryTextBox.Text = "Horror";
                    CostTextBox.Text = "$2.99";
                    break;
                case "Sanctum":
                    MoviePictureBox.Image = COMP123_S2016_Assignment7.Properties.Resources.sanctum;
                    CategoryTextBox.Text = "Action";
                    CostTextBox.Text = "$2.99";
                    break;
                case "The Other Woman":
                    MoviePictureBox.Image = COMP123_S2016_Assignment7.Properties.Resources.theotherwoman;
                    CategoryTextBox.Text = "Action";
                    CostTextBox.Text = "$2.99";
                    break;
                case "The Roommate":
                    MoviePictureBox.Image = COMP123_S2016_Assignment7.Properties.Resources.theroommate;
                    CategoryTextBox.Text = "Thriller";
                    CostTextBox.Text = "$1.99";
                    break;
                case "Waiting for Forever":
                    MoviePictureBox.Image = COMP123_S2016_Assignment7.Properties.Resources.waitingforever;
                    CategoryTextBox.Text = "Drama";
                    CostTextBox.Text = "$1.99";
                    break;
                case "Gnomeo and Juliet":
                    MoviePictureBox.Image = COMP123_S2016_Assignment7.Properties.Resources.gnomeoandjuliet;
                    CategoryTextBox.Text = "Family";
                    CostTextBox.Text = "$0.99";
                    break;
                case "Just Go With It":
                    MoviePictureBox.Image = COMP123_S2016_Assignment7.Properties.Resources.justgowithit;
                    CategoryTextBox.Text = "Comedy";
                    CostTextBox.Text = "$1.99";
                    break;
                case "The Eagle":
                    MoviePictureBox.Image = COMP123_S2016_Assignment7.Properties.Resources.theeagle;
                    CategoryTextBox.Text = "Action";
                    CostTextBox.Text = "$2.99";
                    break;
                case "I am Number Four":
                    MoviePictureBox.Image = COMP123_S2016_Assignment7.Properties.Resources.iamnumberfour;
                    CategoryTextBox.Text = "Sci-Fi";
                    CostTextBox.Text = "$2.99";
                    break;
                case "Footloose":
                    MoviePictureBox.Image = COMP123_S2016_Assignment7.Properties.Resources.footloose;
                    CategoryTextBox.Text = "New Release";
                    CostTextBox.Text = "$4.99";
                    break;
                case "Real Steel":
                    MoviePictureBox.Image = COMP123_S2016_Assignment7.Properties.Resources.realsteel;
                    CategoryTextBox.Text = "New Release";
                    CostTextBox.Text = "$4.99";
                    break;
                case "Cedar Rapids":
                    MoviePictureBox.Image = COMP123_S2016_Assignment7.Properties.Resources.cedarrapids;
                    CategoryTextBox.Text = "Comedy";
                    CostTextBox.Text = "$1.99";
                    break;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.orderformer = this;
            orderForm.SelectedTitleTextBox.Text = TitleTextBox.Text;
            orderForm.SelectedCategoryTextBox.Text = CategoryTextBox.Text;
            orderForm.CostTextBox2.Text = CostTextBox.Text;

            orderForm.Show();
            this.Hide();
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var movie in Movies)
            {
                if (movie.MovieTitle.Equals(MovieListBox.SelectedItem.ToString()))
                {
                    TitleTextBox.Text = movie.MovieTitle;
                    CostTextBox.Text = movie.Cost.ToString();
                    CategoryTextBox.Text = movie.Category;
                    PictureBox.Image = movie.Picture;
                    NextButton.Enabled = true;
                }
            }
        }
    }
}
