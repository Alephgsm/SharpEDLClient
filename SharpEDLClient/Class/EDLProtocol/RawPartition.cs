using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpEDLClient.Class.EDLProtocol
{
    public class RawPartition : INotifyPropertyChanged
    {
        [Obfuscation(Exclude = true, Feature = "renaming")]
        public string name { get; set; }

        [Obfuscation(Exclude = true, Feature = "renaming")]
        public ulong Sector { get; set; }

        [Obfuscation(Exclude = true, Feature = "renaming")]
        public int lun { get; set; }

        [Obfuscation(Exclude = true, Feature = "renaming")]
        public ulong Sectors { get; set; }

        [Obfuscation(Exclude = true, Feature = "renaming")]
        public string SECTOR_SIZE_IN_BYTES;
        [Obfuscation(Exclude = true, Feature = "renaming")]
        private bool _isenable;
        [Obfuscation(Exclude = true, Feature = "renaming")]
        [Obfuscation(Exclude = true, Feature = "renaming")]
        public bool Enable
        {
            get
            {
                return _isenable;
            }

            set
            {
                _isenable = value;
                NotifyPropertyChanged("isChecked");
            }
        }

        [Obfuscation(Exclude = true, Feature = "renaming")]
        public event PropertyChangedEventHandler PropertyChanged;
        [Obfuscation(Exclude = true, Feature = "renaming")]
        private void NotifyPropertyChanged(string info)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}