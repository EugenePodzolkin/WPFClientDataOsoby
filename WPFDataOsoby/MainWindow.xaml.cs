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
using WPFDataOsoby.OperationsService;

namespace WPFDataOsoby
{
    public partial class MainWindow : Window
    {
        DataOperationClient _dataClient;
        FileOperationClient _fileClient;
        List<Osoba> FullArrayOfOsoba = new List<Osoba>();
        List<Osoba> ForAgeArrayOfOsoba = new List<Osoba>();
        List<Osoba> ForCSVArrayOfOsoba = new List<Osoba>();

        public MainWindow()
        {
            InitializeComponent();
            try
            {
                _dataClient = new DataOperationClient("BasicHttpBinding_IDataOperation");
                _fileClient = new FileOperationClient("BasicHttpBinding_IFileOperation");

                FullArrayOfOsoba = _fileClient.GetDataFromXML().ToList();
                list_osoba.ItemsSource = FullArrayOfOsoba;
            }
            catch
            {
                MessageBox.Show("No connection to the service.", "Message");
            }
        }

        private void AgeButton_Click(object sender, RoutedEventArgs e)
        {
            ForAgeArrayOfOsoba.Clear();
            ForCSVArrayOfOsoba.Clear();
            try
            {
                int age = int.Parse(AgeText.Text);
                try
                {
                    ForAgeArrayOfOsoba = _dataClient.GetLessAge(FullArrayOfOsoba.ToArray(), age).ToList();
                }
                catch
                {
                    MessageBox.Show("No connection to the service.", "Message");
                }
                finally
                {
                    list_osoba.ItemsSource = ForAgeArrayOfOsoba;
                }
            }
            catch
            {
                MessageBox.Show("Data entry error.", "Message");
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CheckBox cb = sender as CheckBox;
                Osoba osoba = cb.DataContext as Osoba;
                if (cb.IsChecked.Value)
                {
                    if (ForCSVArrayOfOsoba.Exists(x => x.ID == osoba.ID) == false)
                    {
                        ForCSVArrayOfOsoba.Add(osoba);
                    }
                }
                else
                {
                    if (ForCSVArrayOfOsoba.Exists(x => x.ID == osoba.ID))
                    {
                        ForCSVArrayOfOsoba.Remove(osoba);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Unexpected error. Please contact the administrator.", "Message");
            }
        }

        private void WriteToCSV_Click(object sender, RoutedEventArgs e)
        {
            try{
                if (ForCSVArrayOfOsoba.Count > 0) {
                    _fileClient.WriteDataToCSV(ForCSVArrayOfOsoba.ToArray());
                    MessageBox.Show("Data has been successfully recorded.", "Message");
                }
                else
                {
                    MessageBox.Show("No data to save.", "Message");
                }
            }
            catch
            {
                MessageBox.Show("No connection to the service.", "Message");
            }
        }
        
        private void ReadAllData_Click(object sender, RoutedEventArgs e)
        {
            FullArrayOfOsoba.Clear();
            ForCSVArrayOfOsoba.Clear();
            try
            {
                FullArrayOfOsoba = _fileClient.GetDataFromXML().ToList();
            }
            catch
            {
                MessageBox.Show("No connection to the service.", "Message");
            }
            finally
            {
                list_osoba.ItemsSource = FullArrayOfOsoba;
            }
        }

        private void Close_app(object sender, EventArgs e)
        {
            if(_fileClient != null) _fileClient.Close();
            if(_dataClient != null) _dataClient.Close();
        }

        private void Reconnect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_fileClient != null) _fileClient.Close();
                if (_dataClient != null) _dataClient.Close();
                _dataClient = new DataOperationClient("BasicHttpBinding_IDataOperation");
                _fileClient = new FileOperationClient("BasicHttpBinding_IFileOperation");

                FullArrayOfOsoba = _fileClient.GetDataFromXML().ToList();
                list_osoba.ItemsSource = FullArrayOfOsoba;
                MessageBox.Show("There is a connection.", "Message");
            }
            catch
            {
                MessageBox.Show("No connection to the service.", "Message");
            }
        }
    }
}
