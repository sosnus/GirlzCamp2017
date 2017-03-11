using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ListOfObjects
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<Human> ListOfHumans = new List<Human>();

        public MainPage()
        {
            this.InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Human tempHuman = new Human();
            tempHuman.Age = Convert.ToInt32(tbAge.Text);
            tempHuman.Id = (ListOfHumans.Count+1);
            tempHuman.Name = Convert.ToString(tbName.Text);
            tempHuman.Surname = Convert.ToString(tbSurname.Text);

            ListOfHumans.Add(tempHuman);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            cbSelect.Items.Clear();
            foreach (var item in ListOfHumans)
            {
                cbSelect.Items.Add($"{item.Id} - {item.Surname}");
            }
        }

        private void cbSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selected = cbSelect.SelectedIndex;
            if(selected != -1)
                {

            tbAge2.Text = ListOfHumans[selected].Age.ToString();
            tbName2.Text = ListOfHumans[selected].Name.ToString();
            tbSurname2.Text = ListOfHumans[selected].Surname.ToString();
            }


        }
    }

    class Human
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }

}
