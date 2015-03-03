﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
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
using unBand.CloudHelpers;

namespace unBand.Controls
{
    /// <summary>
    /// Interaction logic for WaitingForBand.xaml
    /// </summary>
    public partial class WaitingForMSA : UserControl
    {
        public WaitingForMSA()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            BandCloudManager.Instance.Login();
        }
    }
}
