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

namespace Mic.Volo.WPFWebClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyaddBtn_Click(object sender, RoutedEventArgs e)
        {
            ListView conteiner = new ListView()
            {
                Name="myConteiner",
            };
            TextBox textBox = new TextBox()
            {
                Width=600,
                Height=20,
                BorderBrush=Brushes.Red
            };
           // myListBox.Items.Add(textBox);
            conteiner.Items.Add(textBox);
            ProgressBar progressBar = new ProgressBar()
            {
                Value=0,
                Width=600,
                Height=20
            };
            Canvas twpbothbutton = new Canvas()
            {
                Name="mycanv",
                Width=599,
                Height=30,
            };
            // myListBox.Items.Add(progressBar);
            conteiner.Items.Add(progressBar);
            Button button = new Button()
            {
                Content = "Download",
                Width=100,
                Height=30
            };
            //myListBox.Items.Add(button);
            //conteiner.Items.Add(button);
            Button cancel = new Button()
            {
                Content = "Cancel",
                Width = 100,
                Height = 30,
                Margin = new Thickness(120,0,0,10)
            };
            
            twpbothbutton.Children.Add(button);
            twpbothbutton.Children.Add(cancel);
            
            conteiner.Items.Add(twpbothbutton);
            //conteiner.Items.Add(cancel);
            myListBox.Items.Add(conteiner);
            

            

        }
    }
}
