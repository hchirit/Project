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
using System.Windows.Shapes;

namespace PL_UI2
{
    /// <summary>
    /// Logique d'interaction pour update_employer.xaml
    /// </summary>
    public partial class update_employer : Window
    {

        BE.Employer employer;
        BL.IBL bl;
        public update_employer(BL.IBL Bl)
        {
            this.bl = Bl;
            InitializeComponent();
            employer = new BE.Employer();
            this.DataContext = employer;

            bl = BL.FactoryBL.GetBL();
            showDataGridView();
            this.disciplineComboBox.ItemsSource = Enum.GetValues(typeof(BE.discipline));
            foreach (int id in bl.return_names_id_employer())
            {
                comboBox.Items.Add(id);
            }
        }
        private void showDataGridView()
        {
            try
            {
                DataGrid_s.ItemsSource = null;
                DataGrid_s.ItemsSource = bl.AllEmployer();

            }
            catch (Exception)
            {
                MessageBox.Show("שגיאה", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            int ID;
            int.TryParse(comboBox.SelectedItem.ToString(), out ID);
            try
            {
                employer.companyID = ID;
                bl.uptdateEmployer(employer);
                employer = new BE.Employer();
                this.DataContext = employer;
                showDataGridView();
            }
            catch (Exception ex)
            {
                showDataGridView();
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int ID; 
            int.TryParse(comboBox.SelectedItem.ToString(), out ID);
            employer = bl.searchId_find_employer(ID);
            this.DataContext = employer;
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            int Employer_ID;
            try
            {
                int.TryParse(comboBox.SelectedItem.ToString(), out Employer_ID);
                bl.removeEmployer(Employer_ID);
                showDataGridView();
            }
            catch (Exception ex)
            {
                showDataGridView();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
