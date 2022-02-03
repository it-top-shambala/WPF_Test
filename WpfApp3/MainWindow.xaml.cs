using System.Windows;

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Clear_OnClick(object sender, RoutedEventArgs e)
        {
            Input_Name.Clear();
            Input_Age.Clear();
        }

        private void Button_Save_OnClick(object sender, RoutedEventArgs e)
        {
            var msg = $"{Input_Name.Text}, {Input_Age.Text}";
            MessageBox.Show(msg);
        }
    }
}