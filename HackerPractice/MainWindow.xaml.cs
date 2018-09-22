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
using HackerPractice.CodeWars;
using HackerPractice.Easy;
using HackerPractice.Medium;
using HackerPractice.Examples;
using HackerPractice.CodingChallenge;
using HackerPractice.Model;

namespace HackerPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //*
            IProblem tester = new Template1();
            var test = 3;

            switch (test)
            {
                case 1:
                    tester = new Template1();
                    break;
                case 2:
                    tester = new Template2();
                    break;
                case 3:
                    tester = new Template3();
                    break;
                case 4:
                    tester = new Template4();
                    break;
                case 5:
                    tester = new Template5();
                    break;
                case 6:
                    tester = new CountBits_();
                    break;
                case 7:
                    tester = new AppendAndDelete();
                    break;
            }

            tester.RunTest();

            /*/
            var tester = new  CamelChase();
            tester.RunTest();
            //*/
        }
    }
}

//  output = Foo(Utilities.GetIntArray("2 5 -4 11 0 8 22 67 51 6"));
