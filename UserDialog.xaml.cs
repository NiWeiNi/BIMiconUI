using BIMicon.BIMiconUI.Models;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Input;

namespace BIMicon.BIMiconUI
{
    /// <summary>
    /// Interaction logic for UserDialog.xaml
    /// </summary>
    public partial class UserDialog : Window
    {
        public UserDialog(Message message)
        {
            // Load MaterialDesign libraries as they won't be properly handled by Revit otherwise
            // Code adopted from https://stackoverflow.com/questions/55594443/how-to-include-materialdesignxamltoolkit-to-wpf-class-library
            Assembly.LoadFrom(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "MaterialDesignThemes.Wpf.dll"));
            Assembly.LoadFrom(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "MaterialDesignColors.dll"));

            InitializeComponent();

            Title = message.Type.ToString();
            messageTitle.Text = message.Title;
            messageUser.Text = message.Content;
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
