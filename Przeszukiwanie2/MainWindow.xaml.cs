using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
            //czytanie pliku i wpisanego ciagu
            String Szukane = PoszukiwanyCiag.Text;
            string InputowyText = InputText.Text;

            //zmienne do magii ponizej
            int dlugoscInput = InputowyText.Length;
            int dlugoscSzukane = Szukane.Length;

            //liczenie czasu dzialania
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            if (ChooseAlgorithm.Text == "1") //brute force
            {

                //nie wiem po co mi to nawet
                char[] textArray = InputowyText.ToCharArray();
                char[] patternArray = Szukane.ToCharArray();

                int textIndex = 0;

                int suma = 0;

                //magia ktorej nie rozumiem
                for (textIndex = 0; textIndex < dlugoscInput; textIndex++)
                {
                    int textIndexLocal = textIndex;
                    Boolean match = true;
                    int matchedIndex = textIndex;
                    for (int patternIndex = 0; patternIndex < dlugoscSzukane; patternIndex++)
                    {
                        if (textArray[textIndexLocal] != patternArray[patternIndex])
                        {
                            match = false;
                            break;
                        }
                        textIndexLocal = textIndexLocal + 1;
                    }
                    if (match)
                    {
                        suma++;
                    }

                }

                //wyswietlanie wynikow
                stopwatch.Stop();
                Wynik.Text = suma.ToString();

                WynikCzasowy.Text = stopwatch.Elapsed.ToString();






            }
            else
            {
                if(ChooseAlgorithm.Text == "2") //kmp
                {
                    
                }
                else
                {
                    if(ChooseAlgorithm.Text == "3") //boyer moore
                    {
                        
                    }
                    else
                    {
                        if(ChooseAlgorithm.Text == "4") //rabin karp
                        {
                            
                        }
                        else
                        {
                            //gdy ktos wpisze cos innego, niz 1,2,3 lub 4, to wychodzi blad
                            ChooseAlgorithm.Text = "bledne dane";
                            Wynik.Text = "";
                            WynikCzasowy.Text = "";
                        }

                    }


                }
            }
            























        }
    }

    
}
