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

namespace DrerriesTuin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DierentuinDataContext db;
        DrerriesController dc;
        dieren SelectedDier;
        public MainWindow()
        {
            InitializeComponent();
            db = new DierentuinDataContext();
            SetData();
        }

        private void SetData()
        {
            dc = new DrerriesController(db);
            dgDrerrie.ItemsSource = dc.allLocaties();
            cbLocatie.ItemsSource = dc.allLocaties();
            cbLocatie.DisplayMemberPath = "LocatieNaam";
            dgDrerrieDieren.ItemsSource = dc.allDieren();
            dgDrerrieHistory.ItemsSource = dc.allHistory();

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtNaam.Text == "" || cbLocatie.SelectedItem == null)
            {
                MessageBox.Show("Vull alle gegevens in.");
            }
            else
            {
                dc.addDieren(txtNaam.Text, (locatie)cbLocatie.SelectedItem);

                txtNaam.Text = "";
                cbLocatie.SelectedItem = null;
                SetData();
            }
        }

        private void btnSaveLocatie_Click(object sender, RoutedEventArgs e)
        {
            if (txtLocatienaam.Text.Equals(""))
            {
                MessageBox.Show("Vull alle gegevens in.");
            }
            else
            {
                dc.addLocatie(txtLocatienaam.Text);

                txtLocatienaam.Text = "";
                SetData();
            }
            
        }

        private void btnLocaties_Click(object sender, RoutedEventArgs e)
        {
            dgDrerrieDieren.Visibility = Visibility.Hidden;
            dgDrerrieHistory.Visibility = Visibility.Hidden;
            dgDrerrie.Visibility = Visibility.Visible;
        }

        private void btnDieren_Click(object sender, RoutedEventArgs e)
        {
            dgDrerrie.Visibility = Visibility.Hidden;
            dgDrerrieHistory.Visibility = Visibility.Hidden;
            dgDrerrieDieren.Visibility = Visibility.Visible;
        }

        private void btnHistory_Click(object sender, RoutedEventArgs e)
        {
            dgDrerrie.Visibility = Visibility.Hidden;
            dgDrerrieDieren.Visibility = Visibility.Hidden;
            dgDrerrieHistory.Visibility = Visibility.Visible;
        }

        private void dgDrerrieDieren_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(dgDrerrieDieren.SelectedItem != null)
            {
                SelectedDier = (dieren)dgDrerrieDieren.SelectedItem;
                txtNaam.Text = SelectedDier.Naam;
                cbLocatie.SelectedItem = SelectedDier.locatie;

                btnSave.Visibility = Visibility.Hidden;
                btnEdit.Visibility = Visibility.Visible;
                btnCancel.Visibility = Visibility.Visible;
                btnDelete.Visibility = Visibility.Visible;
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (txtNaam.Text == "" || cbLocatie.SelectedItem == null)
            {
                MessageBox.Show("Vull alle gegevens in.");
            }
            else
            {
                dc.editDieren(SelectedDier.ID, txtNaam.Text, (locatie)cbLocatie.SelectedItem);

                txtNaam.Text = "";
                cbLocatie.SelectedItem = null;
                btnEdit.Visibility = Visibility.Hidden;
                btnCancel.Visibility = Visibility.Hidden;
                btnDelete.Visibility = Visibility.Hidden;
                btnSave.Visibility = Visibility.Visible;
                SetData();
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            txtNaam.Text = "";
            cbLocatie.SelectedItem = null;
            
            btnEdit.Visibility = Visibility.Hidden;
            btnCancel.Visibility = Visibility.Hidden;
            btnDelete.Visibility = Visibility.Hidden;
            btnSave.Visibility = Visibility.Visible;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var hetDierLocatie = (dieren)dgDrerrie.SelectedItem;
            dc.deleteDieren(hetDierLocatie);
        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            dgDrerrie.ItemsSource = dc.ZoekItem(txtFilter.Text);
        }
    }
}
