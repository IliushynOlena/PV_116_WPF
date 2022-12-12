using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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

namespace _04__List_Controls_Collection_Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //INotifyCollectionChanged
        ObservableCollection<Person> people = null;
        public MainWindow()
        {
            InitializeComponent();

            people = new ObservableCollection<Person>()
            {
                new Person(){  Name="Bogdan" , SurName="Bogdanovich" , Birth = new DateTime(2000,12,15)},
                new Person(){  Name="Viktoria" , SurName="Ivanchuk" , Birth = new DateTime(1999,7,25)},
                new Person(){  Name="Sasha" , SurName="Marchuk" , Birth = new DateTime(2005,9,01)}
            };

            comboBox.Items.Clear();
            //foreach (var item in people)
            //{
            //    comboBox.Items.Add(item);
            //}
            comboBox.ItemsSource = people;
            comboBox.DisplayMemberPath = nameof(Person.FullName);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newPerson = new Person()
            {
                Name = "New Name",
                SurName = "New Surname",
                Birth = new DateTime(2005, 9, 01)
            };
            people.Add(newPerson);
            //comboBox.Items.Add(newPerson);
         

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(comboBox.SelectedIndex != -1) 
                people.RemoveAt(comboBox.SelectedIndex);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            people.Clear();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(comboBox.SelectedItem != null)
            {
                MessageBox.Show(comboBox.SelectedItem.ToString());
            }

        }
    }
}
