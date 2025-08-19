using Newtonsoft.Json;
using SharpEDLClient.Class;
using SharpEDLClient.Class.EDLProtocol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpEDLClient.Forms
{
    public partial class selectdevice : Form
    {
        public List<Loader> Models = new List<Loader>();
        public selectdevice()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public string XiaomiJs = $"{util.MyPath}\\bin\\loader\\devices\\xiaomi.json";
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void selectdevice_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void CmbxBxDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void CmbBxVendors_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}