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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GlazerCalcUWP
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

        private void slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            sliderResultBox.Text = slider.Value.ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double width, height, woodLength, glassArea;
            width = double.Parse(widthBox.Text);
            height = double.Parse(heightBox.Text);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width + height);

            woodLengthResult.Text = woodLength.ToString();
            glassAreaResult.Text = glassArea.ToString();
        }

        private void widthBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            double result;
            if (!double.TryParse(widthBox.Text, out result))
            {
                widthBox.Text = String.Empty;
            }
        }

        private void heightBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            double result;
            if (!double.TryParse(heightBox.Text, out result))
            {
                heightBox.Text = String.Empty;
            }
        }
    }
}
