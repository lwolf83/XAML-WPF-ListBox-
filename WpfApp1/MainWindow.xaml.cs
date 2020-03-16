using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nameInfecte = NameText.Text.Trim();
            bool addPerson = true;
            foreach(string item in AffichageInfecte.Items)
            {
                if(item == nameInfecte)
                {
                    addPerson = false;
                }
            }

            if (nameInfecte.Length > 0 && addPerson)
            {
                AffichageInfecte.Items.Add(nameInfecte);
                NameText.Text = "";
            }
            else
            {
                MessageBox.Show(nameInfecte + " can't be added to the list");
                NameText.Text = "";
            }
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
