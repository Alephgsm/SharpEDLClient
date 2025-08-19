// Copyright © Serge Weinstock 2014.
//
// This library is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with this library.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SergeUtils
{
    /// <summary>
    /// A dropdown window for combos.
    /// </summary>
    [ToolboxItem(false)]
    public class DropdownControl : ToolStripDropDown, IMessageFilter
    {
#region Properties
        /// <summary>
        /// Gets the content of the pop-up.
        /// </summary>
        public Control Content { get; private set; }

#endregion
#region Fields
        /// <summary>The toolstrip host</summary>
        private ToolStripControlHost m_host;
        /// <summary>The control for which we display this dropdown</summary>
        private Control m_opener;
#endregion
        /// <summary>
        /// Constructor
        /// </summary>
        public DropdownControl(Control content)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Display the dropdown and adjust its size and location
        /// </summary>
        public void Show(Control opener, Size preferredSize = new Size())
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#region internals
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// On resizes, resize the contents
        /// </summary>
        protected override void OnSizeChanged(EventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#region IMessageFilter implementation
        private const int WM_LBUTTONDOWN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int WM_RBUTTONDOWN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int WM_MBUTTONDOWN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int WM_NCLBUTTONDOWN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int WM_NCRBUTTONDOWN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int WM_NCMBUTTONDOWN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        public static extern int MapWindowPoints(IntPtr hWndFrom, IntPtr hWndTo, [In, Out] ref Point pt, int cPoints)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        };
        /// <summary>
        /// We monitor all messages in order to detect when the users clicks outside the dropdown and the combo
        /// If this happens, we close the dropdown (as AutoClose is false)
        /// </summary>
        public bool PreFilterMessage(ref Message m)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
#endregion
    }
}