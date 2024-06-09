using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {

        BitmapFrame a = BitmapFrame.Create(new Uri(@"https://avatanplus.com/files/resources/original/5a8adfef1dc0e161ae7abe12.png"));
        BitmapFrame b = BitmapFrame.Create(new Uri(@"https://static.wikia.nocookie.net/minecraft_ru_gamepedia/images/d/d1/%D0%A2%D1%80%D0%BE%D0%BF%D0%B8%D1%87%D0%B5%D1%81%D0%BA%D0%B0%D1%8F_%D1%80%D1%8B%D0%B1%D0%B0.png/revision/latest?cb=20180824074848"));
        BitmapFrame c = BitmapFrame.Create(new Uri(@"https://static.wikia.nocookie.net/minecraft_ru_gamepedia/images/8/8f/%D0%97%D0%BE%D0%BB%D0%BE%D1%82%D0%BE%D0%B5_%D1%8F%D0%B1%D0%BB%D0%BE%D0%BA%D0%BE_JE2_BE2.png/revision/latest?cb=20190424163743"));
        BitmapFrame d = BitmapFrame.Create(new Uri(@"https://static.wikia.nocookie.net/minecraft_ru_gamepedia/images/0/03/%D0%9C%D0%B8%D1%81%D0%BA%D0%B0_JE2_BE2.png/revision/latest?cb=20191116055457"));
        BitmapFrame e = BitmapFrame.Create(new Uri(@"https://static.wikia.nocookie.net/minecraft_ru_gamepedia/images/a/ac/%D0%A7%D1%91%D1%80%D0%BD%D0%BE-%D0%B1%D0%B5%D0%BB%D0%B0%D1%8F_%D0%BA%D0%BE%D1%88%D0%BA%D0%B0.png/revision/latest?cb=20220327172345"));


        int food = 50;
        int happy = 50;
        public MainWindow()
        {
            InitializeComponent();

            textLabelOne.Text = $"Food: {food}%";
            textLabelTwo.Text = $"Happy: {happy}%";

            buttonThreeImage.Source = a;
            buttonTwoImage.Source = b;
            buttonFourImage.Source = c;
            buttonImage.Source = d;
            mainImage.Source = e;
            windowName.Icon = e;

            offButtons();
        }

        public void onButtons()
        {
            buttonTwo.Visibility = Visibility.Visible;
            buttonThree.Visibility = Visibility.Visible;
        }

        public void offButtons()
        {
            buttonTwo.Visibility = Visibility.Hidden;
            buttonThree.Visibility = Visibility.Hidden;
        }
        private void buttonClick(object sender, RoutedEventArgs e)
        {
            if(food == 100 || food == 90)
            {
                MessageBox.Show("Он не голоден", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            if(buttonTwo.Visibility == Visibility.Hidden)
            {
                onButtons();
            }
            else
            {
                offButtons();
            }
        }

        private void buttonTwoClick(object sender, RoutedEventArgs e)
        {
            offButtons();
            food += 30;

            if (food > 100)
            {
                MessageBox.Show("Что-то поменьше", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                food += -30;
            }
            else
            {
                textLabelOne.Text = $"Food: {food}%";
            }
        }

        private void buttonThreeClick(object sender, RoutedEventArgs e)
        {
            offButtons();
            food += 20;

            if (food > 100)
            {
                MessageBox.Show("Что-то поменьше", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                food += -20;
            }
            else
            {
                textLabelOne.Text = $"Food: {food}%";
            }
        }

        private void buttonFourClick(object sender, RoutedEventArgs e)
        {
            happy += 40;

            if(happy > 100)
            {
                MessageBox.Show("Кот счастлив", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                happy -= 40;
            }
            else
            {
                textLabelTwo.Text = $"Happy: {happy}%";
            }
        }
    }
}