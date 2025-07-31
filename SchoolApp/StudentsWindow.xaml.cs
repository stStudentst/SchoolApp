﻿using System;
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
using System.Windows.Shapes;
using System.Data.SqlClient;
using SchoolApp.BL;


namespace SchoolApp
{
    /// <summary>
    /// Interaction logic for StudentsWindow.xaml
    /// </summary>
    public partial class StudentsWindow : Window
    {
        public StudentsWindow()
        {
            DataContext = this;
            //bl = new bl;
            //Students = bl.GetStudents();
            InitializeComponent();
            StudentBL studentbl = new StudentBL();
            StudentsDataGrid.ItemsSource = studentbl.GetAllStudents();
        }
        //public List<Students> Students { get; set; }
    }
}
