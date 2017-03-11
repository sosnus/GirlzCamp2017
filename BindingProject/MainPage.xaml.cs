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

namespace BindingProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            InitBinding();
        }

        private void InitBinding()
        {
            Binding binding = new Binding();
        }


        //class Human
        //{
        //    public Human() { }

        //    public Human(int _Id, int _Age, string _Name, string _Surname)
        //    {
        //        Id = _Id;
        //        Age = _Age;
        //        Name = _Name;
        //        Surname = _Surname;
        //    }




        //    public int Id { get; set; }
        //    public int Age { get; set; }
        //    public string Name { get; set; }
        //    public string Surname { get; set; }
        //}



    }

}
