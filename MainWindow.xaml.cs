using HandyControl.Tools;
using System.Windows;

namespace test
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ConfigHelper.Instance.SetLang("zh-cn");
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HandyControl.Controls.MessageBox.Show("Ok");
        }

    }
}
