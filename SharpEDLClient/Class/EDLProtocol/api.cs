using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpEDLClient.Class.EDLProtocol
{
    public class Loader
    {
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string ShowDev { get; set; }

        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        private string _model;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        private string _product;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        [JsonProperty(PropertyName = "id")]
        public string Brand { get; set; }

        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
                ShowDev += value + " [";
            }
        }

        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string URL { get; set; }

        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string FileID { get; set; }

        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string FileSize { get; set; }

        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string Product
        {
            get
            {
                return _product;
            }

            set
            {
                _product = value;
                ShowDev += value + "]";
            }
        }

        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string UnlockSupported { get; set; }

        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string FBUnlock { get; set; }

        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string FlashStorage { get; set; }

        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string FastbootCMD { get; set; }
    }
}