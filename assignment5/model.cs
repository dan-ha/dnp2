using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    public enum MediaType
    {
        CD,
        DVD
    }

    public class Multimedia : INotifyPropertyChanged
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public MediaType Type { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class MultimediaList: ObservableCollection<Multimedia>
    {
        public List<Multimedia> mList { get; set; }
        public MultimediaList()
        {
            this.mList = new List<Multimedia>();
        }
    }
}
