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
using System.Windows.Shapes;

namespace assignment5
{
    /// <summary>
    /// Interaction logic for ModalDialog.xaml
    /// </summary>
    public partial class DialogAddItem : Window
    {
        public static Multimedia NewMedia;

        public DialogAddItem()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewMedia = new Multimedia()
            {
                Title = tbTitle.Text,
                Artist = tbArtist.Text,
                Genre = tbGenre.Text,
                Type = cbType.Text == "DVD" ? MediaType.DVD : MediaType.CD
            };
            this.Close();
        }
    }
}
