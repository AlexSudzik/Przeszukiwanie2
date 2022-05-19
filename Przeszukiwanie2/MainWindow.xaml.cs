using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Przeszukiwanie2
{
    
    
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InputFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new OpenFileDialog();
            
            //otwieranie pliku
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                InputText.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            //deklaracja zmiennych
            String Szukane = PoszukiwanyCiag.Text;
            string InputowyText = InputText.Text;

            string wynik = "";
            string wynikCzasowy = "";
            

            if(ChooseAlgorithm.Text == "1")
            {
                //brute force
            }
            else
            {
                if(ChooseAlgorithm.Text == "2")
                {
                    //kmp
                }
                else
                {
                    if(ChooseAlgorithm.Text == "3")
                    {
                        //boyer moore
                    }
                    else
                    {
                        if(ChooseAlgorithm.Text == "4")
                        {
                            //rabin karp
                        }
                        else
                        {
                            //gdy ktos wpisze cos innego, niz 1,2,3 lub 4, to wychodzi blad
                            ChooseAlgorithm.Text = "bledne dane";
                        }

                    }


                }
            }
            























        }
    }

    
}
