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

namespace ДЗ_3_Timofeev_UTS_21
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

        char[] kirilica = new char[]
        {
            'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И','Й', 'К', 'Л',
            'М', 'Н', 'О', 'П', 'Р', 'С','Т', 'У', 'Ф', 'Х', 'Ц', 'Ч',
            'Ш', 'Щ', 'Ы', 'Ь','Э', 'Ю', 'Я', 'Ё'
        };

        string[] morse = new string[] 
        { 
            ".–", "–...", ".––", "––.","–..", ".", "...–", "––..","..",
            ".–––", "–.–", ".–..", "––", "–.", "–––", ".––.",".–.", "...",
            "–", "..–","..–.", "....", "–.–.","–––.", "––––", "−−.−","−.−−",
            "−..−", "..−..","..−−", ".−.−", "."
        };

        private void btnTranslate_Click_1(object sender, RoutedEventArgs e)
        {
            string input = tbInput.Text;
            input = input.ToUpper();
            string output = "";
            int index;
            foreach (char c in input)
            {
                if (c != ' ')
                {
                    index = Array.IndexOf(kirilica, c);
                    output += morse[index] + " ";
                }
            }
            output = output.Remove(output.Length - 1);
            tbOutput.Text = output;
        }
    }
}
