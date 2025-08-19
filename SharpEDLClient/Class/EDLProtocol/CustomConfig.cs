using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpEDLClient.Class.EDLProtocol
{
    public enum LoaderType
    {
        AutoDetect,
        FromFile,
        SelectedDevice
    }

    public class CustomConfig
    {
        public static LoaderType CustomLoader = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static string Loader = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static string storage = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public static int sector_size = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
    }
}