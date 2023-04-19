﻿using DataProvider;
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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Person> persons = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            foreach (var person in new PersonRepository().GetAll())
            {
                persons.Add(person);
            }

            myListBox.ItemsSource = persons;
        }
    }
}
