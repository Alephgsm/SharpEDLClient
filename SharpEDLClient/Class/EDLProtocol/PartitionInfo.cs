using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpEDLClient.Class.EDLProtocol
{
    public class PartitionInfo : INotifyPropertyChanged
    {
        [Obfuscation(Exclude = true, Feature = "renaming")]
        private bool _enable;
        [Obfuscation(Exclude = true, Feature = "renaming")]
        public bool Enable
        {
            get
            {
                return _enable;
            }

            set
            {
                if (value == _enable)
                    return;
                _enable = value;
                this.NotifyPropertyChanged("IsChecked");
            }
        }

        [Obfuscation(Exclude = true, Feature = "renaming")]
        [field: NonSerialized()]
        public event PropertyChangedEventHandler PropertyChanged;
        [Obfuscation(Exclude = true, Feature = "renaming")]
        private void NotifyPropertyChanged(string info)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        [Obfuscation(Exclude = true, Feature = "renaming")]
        public string file_name { set; get; }

        public uint physical_partition;
        [Obfuscation(Exclude = true, Feature = "renaming")]
        public string start_sector { set; get; }

        [Obfuscation(Exclude = true, Feature = "renaming")]
        public uint sector_num { set; get; }

        [Obfuscation(Exclude = true, Feature = "renaming")]
        public string label { set; get; }

        [Obfuscation(Exclude = true, Feature = "renaming")]
        public uint sector_size_in_byte { set; get; }

        [Obfuscation(Exclude = true, Feature = "renaming")]
        public string filepath { set; get; }
        public RawItem item { set; get; }

        public PartitionInfo(string filename, string filepath, string physicalpartition, string startsector, string sectornum, string sectorsizeinbyte, string label, RawItem item)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}