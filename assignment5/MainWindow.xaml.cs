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

namespace assignment5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    partial class MainWindow : Window
    {

        public MultimediaList multimediaList;
        public MainWindow()
        {
            InitializeComponent();
            multimediaList = new MultimediaList();
            multimediaList.mList.Add(new Multimedia() { Title = "Never Gonna Give You Up", Artist = "Rick Astley", Genre = "pop", Type = MediaType.CD });
            multimediaList.mList.Add(new Multimedia() { Title = "The Pianist", Artist = "Roman Polanski", Genre = "drama", Type = MediaType.DVD });
            multimediaList.mList.Add(new Multimedia() { Title = "Fight CLub", Artist = "David Fincher", Genre = "action", Type = MediaType.DVD });

            multimediaListBox.ItemsSource = multimediaList.mList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogAddItem dialog = new DialogAddItem();
            dialog.ShowDialog();
        }
    }
}
