using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using TheoryOfInformation.lab1.Encryptions.Models;

namespace TheoryOfInformation.lab1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool readFromFile;
        private bool encode;
        private IEnumerable<IEncryption> ecncryptions;

        public MainWindow()
        {
            ecncryptions = new List<IEncryption>() { new Casser() };
            InitializeComponent();
            encryptionsBox.ItemsSource = ecncryptions;
            inFileCheck.IsChecked = true;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (inFileCheck.IsChecked.Value)
            {
                fileUnit.Visibility = Visibility.Visible;
                textUnit.Visibility = Visibility.Hidden;
                readFromFile = true;
            }
            else
            {
                fileUnit.Visibility = Visibility.Hidden;
                textUnit.Visibility = Visibility.Visible;
                readFromFile = false;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e) => encode = encCheck.IsChecked.Value;

        private void encryptionsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmb = sender as ComboBox;

            IEncryption selected = cmb.SelectedItem as IEncryption;
            if (selected.HasKey)
            {
                fileUnit.keyBox.Visibility = Visibility.Visible;
                textUnit.keyBox.Visibility = Visibility.Visible;
            }
            else
            {
                fileUnit.keyBox.Visibility = Visibility.Hidden;
                textUnit.keyBox.Visibility = Visibility.Hidden;
            }
        }
    }
}
