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

namespace EdinburghQuiz
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

        //private void Smaller_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void Larger_Click_1(object sender, RoutedEventArgs e)
        //{

        //}

        private void Q1_ShowAnswer(object sender, RoutedEventArgs e)
        {
            Q1Answer.Background = Brushes.Green;
        }

        private void Q1_Multiple_Choice(object sender, RoutedEventArgs e)
        {
            if (Q1Multiple.Visibility != Visibility.Visible)
            {
                Q1Multiple.Visibility = Visibility.Visible;
            }
            else
            {
                Q1Multiple.Visibility = Visibility.Hidden;
            }
        }

        private void Q2_ShowAnswer(object sender, RoutedEventArgs e)
        {
            Q2Answer.Background = Brushes.Green;
        }

        private void Q2_Multiple_Choice(object sender, RoutedEventArgs e)
        {
            if (Q2Multiple.Visibility != Visibility.Visible)
            {
                Q2Multiple.Visibility = Visibility.Visible;
            }
            else
            {
                Q2Multiple.Visibility = Visibility.Hidden;
            }
        }

        private void Q3_ShowAnswer(object sender, RoutedEventArgs e)
        {
            Q3Answer.Background = Brushes.Green;
        }

        private void Q3_Multiple_Choice(object sender, RoutedEventArgs e)
        {
            if (Q3Multiple.Visibility != Visibility.Visible)
            {
                Q3Multiple.Visibility = Visibility.Visible;
            }
            else
            {
                Q3Multiple.Visibility = Visibility.Hidden;
            }
        }

        private void Q4_ShowAnswer(object sender, RoutedEventArgs e)
        {
            Q4Answer.Background = Brushes.Green;
        }

        private void Q4_Multiple_Choice(object sender, RoutedEventArgs e)
        {
            if (Q4Multiple.Visibility != Visibility.Visible)
            {
                Q4Multiple.Visibility = Visibility.Visible;
            }
            else
            {
                Q4Multiple.Visibility = Visibility.Hidden;
            }
        }

        private void Q5_ShowAnswer(object sender, RoutedEventArgs e)
        {
            Q5Answer.Background = Brushes.Green;
        }

        private void Q5_Multiple_Choice(object sender, RoutedEventArgs e)
        {
            if (Q5Multiple.Visibility != Visibility.Visible)
            {
                Q5Multiple.Visibility = Visibility.Visible;
            }
            else
            {
                Q5Multiple.Visibility = Visibility.Hidden;
            }
        }

        private void Q6_ShowAnswer(object sender, RoutedEventArgs e)
        {
            Q6Answer.Background = Brushes.Green;
        }

        private void Q6_Multiple_Choice(object sender, RoutedEventArgs e)
        {
            if (Q6Multiple.Visibility != Visibility.Visible)
            {
                Q6Multiple.Visibility = Visibility.Visible;
            }
            else
            {
                Q6Multiple.Visibility = Visibility.Hidden;
            }
        }

        private void Q7_ShowAnswer(object sender, RoutedEventArgs e)
        {
            Q7Answer.Background = Brushes.Green;
        }

        private void Q7_Multiple_Choice(object sender, RoutedEventArgs e)
        {
            if (Q7Multiple.Visibility != Visibility.Visible)
            {
                Q7Multiple.Visibility = Visibility.Visible;
            }
            else
            {
                Q7Multiple.Visibility = Visibility.Hidden;
            }
        }

        private void Q8_ShowAnswer(object sender, RoutedEventArgs e)
        {
            Q8Answer.Background = Brushes.Green;
        }

        private void Q8_Multiple_Choice(object sender, RoutedEventArgs e)
        {
            if (Q8Multiple.Visibility != Visibility.Visible)
            {
                Q8Multiple.Visibility = Visibility.Visible;
            }
            else
            {
                Q8Multiple.Visibility = Visibility.Hidden;
            }
        }

        private void Q9_ShowAnswer(object sender, RoutedEventArgs e)
        {
            Q9Answer.Background = Brushes.Green;
        }

        private void Q9_Multiple_Choice(object sender, RoutedEventArgs e)
        {
            if (Q9Multiple.Visibility != Visibility.Visible)
            {
                Q9Multiple.Visibility = Visibility.Visible;
            }
            else
            {
                Q9Multiple.Visibility = Visibility.Hidden;
            }
        }

        private void Q10_ShowAnswer(object sender, RoutedEventArgs e)
        {
            Q10Answer.Background = Brushes.Green;
        }

        private void Q10_Multiple_Choice(object sender, RoutedEventArgs e)
        {
            if (Q10Multiple.Visibility != Visibility.Visible)
            {
                Q10Multiple.Visibility = Visibility.Visible;
            }
            else
            {
                Q10Multiple.Visibility = Visibility.Hidden;
            }
        }

        private void Q11_ShowAnswer(object sender, RoutedEventArgs e)
        {
            Q11Answer.Background = Brushes.Green;
        }

        private void Q11_Multiple_Choice(object sender, RoutedEventArgs e)
        {
            if (Q11Multiple.Visibility != Visibility.Visible)
            {
                Q11Multiple.Visibility = Visibility.Visible;
            }
            else
            {
                Q11Multiple.Visibility = Visibility.Hidden;
            }
        }

        private void Q12_ShowAnswer(object sender, RoutedEventArgs e)
        {
            Q12Answer.Background = Brushes.Green;
        }

        private void Q12_Multiple_Choice(object sender, RoutedEventArgs e)
        {
            if (Q12Multiple.Visibility != Visibility.Visible)
            {
                Q12Multiple.Visibility = Visibility.Visible;
            }
            else
            {
                Q12Multiple.Visibility = Visibility.Hidden;
            }
        }
        private void Q13_ShowAnswer(object sender, RoutedEventArgs e)
        {
            Q13Answer.Background = Brushes.Green;
        }

        private void Q13_Multiple_Choice(object sender, RoutedEventArgs e)
        {
            if (Q13Multiple.Visibility != Visibility.Visible)
            {
                Q13Multiple.Visibility = Visibility.Visible;
            }
            else
            {
                Q13Multiple.Visibility = Visibility.Hidden;
            }
        }

        private void Q14_ShowAnswer(object sender, RoutedEventArgs e)
        {
            Q14Answer.Visibility = Visibility.Visible;
            Q14Answer.Background = Brushes.Green;
        }

        private void Show_Answer_Buttons(object sender, RoutedEventArgs e)
        {
            Q1ShowAnswerButton.Visibility = Visibility.Visible;
            Q2ShowAnswerButton.Visibility = Visibility.Visible;
            Q3ShowAnswerButton.Visibility = Visibility.Visible;
            Q4ShowAnswerButton.Visibility = Visibility.Visible;
            Q5ShowAnswerButton.Visibility = Visibility.Visible;
            Q6ShowAnswerButton.Visibility = Visibility.Visible;
            Q7ShowAnswerButton.Visibility = Visibility.Visible;
            Q8ShowAnswerButton.Visibility = Visibility.Visible;
            Q9ShowAnswerButton.Visibility = Visibility.Visible;
            Q10ShowAnswerButton.Visibility = Visibility.Visible;
            Q11ShowAnswerButton.Visibility = Visibility.Visible;
            Q12ShowAnswerButton.Visibility = Visibility.Visible;
            Q13ShowAnswerButton.Visibility = Visibility.Visible;
            Q14ShowAnswerButton.Visibility = Visibility.Visible;
            ShowAnswerButtonsButton.Visibility = Visibility.Hidden;
        }
    }
}
