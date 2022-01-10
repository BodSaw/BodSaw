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

namespace RuszGlowa_GraDopasuj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UstawWarunkiGry();
        }

        private void UstawWarunkiGry()
        {
            List<string> zwierzetaEmoji = new List<string>() {
                "🐵", "🐵",
                "🐶", "🐶",
                "🐺", "🐺",
                "🦊", "🦊",
                "🦝", "🦝",
                "🦁", "🦁",
                "🐯", "🐯",
                "🐴", "🐴"
            };

            Random random = new Random();

            // Petla "foreach" przechodzi przez wszystkie pola "TextBlock" znajdujące się w przestrzeni "mainGrid"
            // W pierwszej kolejności jest losowo wybrana liczba od 0 do liczby mniejszej niż liczba elementów w
            // tablicy zwierzętaEmoi, następnie element o wylosowanym ingeksie jest umieszczany w wybranym textBlocku.
            // Ostatni krok to skasowanie z tablicy wybranego elementu
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(zwierzetaEmoji.Count);
                string kolejneEmoi = zwierzetaEmoji[index]; // ta linijka wg. mnie jest niepotrzebna
                textBlock.Text = zwierzetaEmoji[index];
                zwierzetaEmoji.RemoveAt(index);
            }
        }
    }
}
