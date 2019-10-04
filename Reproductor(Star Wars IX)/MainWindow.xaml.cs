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

namespace Reproductor_Star_Wars_IX_
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Trailer1_Checked(object sender, RoutedEventArgs e)
        {
            reproductor.Source = new Uri(@"C:\Users\alumno\Desktop\trailer1.mp4");
        }

        private void Trailer2_Checked(object sender, RoutedEventArgs e)
        {
            reproductor.Source = new Uri(@"C:\Users\alumno\Desktop\trailer2.mp4");
        }

        private void Silenciar_Checked(object sender, RoutedEventArgs e)
        {
            reproductor.IsMuted = !reproductor.IsMuted;
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            reproductor.Play();
        }

        private void Pausa_Click(object sender, RoutedEventArgs e)
        {
            reproductor.Pause();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            reproductor.Stop();
        }
    }
}
