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

namespace BMI_Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var weight =Convert.ToDecimal(textBox1.Text);
            var height = Convert.ToDecimal(textBox3.Text);

            var bmi = weight / (height * height);
            var bmi1 = String.Format("{0:0.00}", bmi);
            textBox5.Text = bmi1;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
        }
    }
}
