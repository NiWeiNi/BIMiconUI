using BIMicon.BIMiconUI.Models;
using System.Windows;
using System.Windows.Input;

namespace BIMicon.BIMiconUI
{
    /// <summary>
    /// Interaction logic for UserDisplay.xaml
    /// </summary>
    public partial class UserDisplay : Window
    {
        public UserDisplay(Message message)
        {
            InitializeComponent();

            this.Title = message.Type.ToString();
            this.messageTitle.Text = message.Title;
            this.message.Text = message.Content;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
