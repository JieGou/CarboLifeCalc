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

namespace CarboLifeUI.UI
{
    /// <summary>
    /// Interaction logic for MaterialEndofLifePicker.xaml
    /// </summary>
    public partial class MaterialEndofLifePicker : Window
    {
        internal bool isAccepted;
        public double Value;
        public string Settings;

        public MaterialEndofLifePicker()
        {
            InitializeComponent();
        }

        public MaterialEndofLifePicker(string settings, double value)
        {
            this.Settings = settings;
            this.Value = value;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txt_Value.Text = Value.ToString();

            string[] settingSplit = Settings.Split(',');

            if (settingSplit.Length > 0)
                //txt_Life.Text = settingSplit[0];
            if (settingSplit.Length > 1)
                //txt_ReplaceValue.Text = settingSplit[1];

            UpdateValue();
        }

        private void UpdateValue()
        {
        }

        private void Btn_Accept_Click(object sender, RoutedEventArgs e)
        {
            isAccepted = true;
            Value = CarboLifeAPI.Utils.ConvertMeToDouble(txt_Value.Text);
            Settings = "Manual Override";
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
