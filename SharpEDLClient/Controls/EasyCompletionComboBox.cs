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
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;

namespace SergeUtils
{
    /// <summary>
    /// This is a combobox with a suggestion list à la "Sublime Text"
    /// 
    /// Searches are made against the pattern in the combo textbox by matching
    /// all the characters in the pattern in the right order but not consecutively
    /// </summary>
    public class EasyCompletionComboBox : ComboBox
    {
#region fields and properties
        /// <summary>our custom drowp down control</summary>
        private readonly DropdownControl m_dropDown;
        /// <summary>the suggestion list inside the drop down control</summary>
        private readonly ListBox m_suggestionList;
        /// <summary>the bold font used for drawing strings in the listbox</summary>
        private Font m_boldFont;
        /// <summary>Allows to know if the last text change is triggered by the keyboard</summary>
        private bool m_fromKeyboard;
        /// <summary>How do we match user input to strings?</summary>
        private StringMatchingMethod m_matchingMethod;
#endregion
        /// <summary>
        /// constructor
        /// </summary>
        public EasyCompletionComboBox()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// <see cref = "ComboBox.Dispose(bool)"/>
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#region size and position of suggest box
        /// <summary>
        /// <see cref = "ComboBox.OnLocationChanged(EventArgs)"/>
        /// </summary>
        protected override void OnLocationChanged(EventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// <see cref = "ComboBox.OnSizeChanged(EventArgs)"/>
        /// </summary>
        protected override void OnSizeChanged(EventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#region visibility of suggest box
        /// <summary>
        /// Shows the drop down.
        /// </summary>
        public void showDropDown()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Hides the drop down.
        /// </summary>
        public void hideDropDown()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// <see cref = "ComboBox.OnLostFocus(EventArgs)"/>
        /// </summary>
        protected override void OnLostFocus(EventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// <see cref = "ComboBox.OnDropDown(EventArgs)"/>
        /// </summary>
        protected override void OnDropDown(EventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#region keystroke and mouse events
        /// <summary>
        /// Called when the user clicks on an item in the list
        /// </summary>
        private void onSuggestionListClick(object sender, EventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Process command keys
        /// </summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// if the dropdown is visible some keystrokes
        /// should behave in a custom way
        /// </summary>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// We need to know if the last text changed event was due to one of the dropdowns 
        /// or to the keyboard
        /// </summary>
        /// <param name = "e"></param>
        protected override void OnDropDownClosed(EventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// this were we can make suggestions
        /// </summary>
        /// <param name = "e"></param>
        protected override void OnTextChanged(EventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// We highlight the selection under the mouse in the suggestion listbox
        /// </summary>
        private void onSuggestionListMouseMove(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#region owner drawn
        /// <summary>
        /// We keep track of system settings changes for the font
        /// </summary>
        private void onFontChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Draw a segment of a string and updates the bound rectangle for being used for the next segment drawing
        /// </summary>
        private static void DrawString(Graphics g, Color color, ref Rectangle rect, string text, Font font)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Draw an item in the suggestion listbox
        /// </summary>
        private void onSuggestionListDrawItem(object sender, DrawItemEventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#region misc
        [Category("Behavior"), DefaultValue(false), Description("Specifies whether items in the list portion of the combobo are sorted.")]
        public new bool Sorted
        {
            get
            {
                return base.Sorted;
            }

            set
            {
                m_suggestionList.Sorted = value;
                base.Sorted = value;
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool DroppedDown
        {
            get
            {
                return base.DroppedDown || m_dropDown.Visible;
            }

            set
            {
                m_dropDown.Visible = false;
                base.DroppedDown = value;
            }
        }

#endregion
#region New properties
        [DefaultValue(StringMatchingMethod.NoWildcards), Description("How strings are matched against the user input"), Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Category("Behavior")]
        public StringMatchingMethod MatchingMethod
        {
            get
            {
                return m_matchingMethod;
            }

            set
            {
                if (m_matchingMethod != value)
                {
                    m_matchingMethod = value;
                    if (m_dropDown.Visible)
                    {
                        // recalculate the matches
                        showDropDown();
                    }
                }
            }
        }

#endregion
#region Hidden inherited properties
        /// <summary>This property is not relevant for this class.</summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), EditorBrowsable(EditorBrowsableState.Never)]
        public new AutoCompleteSource AutoCompleteSource
        {
            get
            {
                return base.AutoCompleteSource;
            }

            set
            {
                base.AutoCompleteSource = value;
            }
        }

        /// <summary>This property is not relevant for this class.</summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), EditorBrowsable(EditorBrowsableState.Never)]
        public new AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get
            {
                return base.AutoCompleteCustomSource;
            }

            set
            {
                base.AutoCompleteCustomSource = value;
            }
        }

        /// <summary>This property is not relevant for this class.</summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), EditorBrowsable(EditorBrowsableState.Never)]
        public new AutoCompleteMode AutoCompleteMode
        {
            get
            {
                return base.AutoCompleteMode;
            }

            set
            {
                base.AutoCompleteMode = value;
            }
        }

        /// <summary>This property is not relevant for this class.</summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), EditorBrowsable(EditorBrowsableState.Never)]
        public new ComboBoxStyle DropDownStyle
        {
            get
            {
                return base.DropDownStyle;
            }

            set
            {
                base.DropDownStyle = value;
            }
        }
#endregion
    }
}