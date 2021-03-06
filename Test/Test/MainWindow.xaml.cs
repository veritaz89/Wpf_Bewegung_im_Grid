﻿using System;
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

namespace Test
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            Testfigure.Visibility = Visibility.Hidden;
        }
        int counterKlicks = 0;
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            int column = Grid.GetColumn(Testfigure);
            int row = Grid.GetRow(Testfigure);
            if (column > 0)
            {
               Grid.SetColumn(Testfigure, column - 1);                
            }
            else
            {
                if (row > 0 )
                {
                    Grid.SetColumn(Testfigure, 3);
                    Grid.SetRow(Testfigure, row - 1);
                }
                else if (row == 0 && column == 0)
                {
                    MessageBox.Show("Sie sind am Ende");
                    Application.Current.Shutdown();
                }
            }
            column = Grid.GetColumn(Testfigure);
            row = Grid.GetRow(Testfigure);
            string c = Convert.ToString(column);
            string r = Convert.ToString(row);
            label1.Content = "Column:"+c;
            label2.Content = "Rows:"+r;
            counterKlicks++;
            label3.Content = "Anzahl der Klicks:"+ Convert.ToString(counterKlicks);
            //MessageBox.Show(c);
            
        }

        private void Btn_Start_Click(object sender, RoutedEventArgs e)
        {
            Grid.SetColumn(Testfigure, 3);
            Grid.SetRow(Testfigure, 2);

            Testfigure.Visibility = Visibility.Visible;
        }

      
    }
}
