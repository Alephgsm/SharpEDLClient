using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SharpMTKClient.Control
{
    /// <summary>
    /// Represents a Windows text box control with placeholder.
    /// </summary>
    public class HintTextBox : TextBox
    {
#region Properties
        string _placeholderText = DEFAULT_PLACEHOLDER;
        bool _isPlaceholderActive = true;
        /// <summary>
        /// Gets a value indicating whether the Placeholder is active.
        /// </summary>
        [Browsable(false)]
        public bool IsPlaceholderActive
        {
            get
            {
                return _isPlaceholderActive;
            }

            private set
            {
                if (_isPlaceholderActive == value)
                    return;
                // Disable operating system handling for mouse events
                // This prevents the user to select the placeholder with mouse or double clicking
                SetStyle(ControlStyles.UserMouse, value);
                // If text equals the placeholder and Reset is called, the actual text doesn't change but the IsPlaceholderActive does.
                // Thus the style (Text or Placeholder) is not updated.
                // Invalidate forces that
                Invalidate();
                _isPlaceholderActive = value;
                OnPlaceholderActiveChanged(value);
            }
        }

        /// <summary>
        /// Gets or sets the placeholder in the PlaceholderTextBox.
        /// </summary>
        [Description("The placeholder associated with the control."), Category("Placeholder"), DefaultValue(DEFAULT_PLACEHOLDER)]
        public string PlaceholderText
        {
            get
            {
                return _placeholderText;
            }

            set
            {
                _placeholderText = value;
                // Only use the new value if the placeholder is active.
                if (IsPlaceholderActive)
                    Text = value;
            }
        }

        /// <summary>
        /// Gets or sets the current text in the TextBox.
        /// </summary>
        [Browsable(false)]
        public override string Text
        {
            get
            {
                // Check 'base.Text == Placeholder' because in some cases IsPlaceholderActive changes too late although it isn't the placeholder anymore.
                if (IsPlaceholderActive && base.Text == PlaceholderText)
                    return "";
                return base.Text;
            }

            set
            {
                base.Text = value;
            }
        }

        Color _placeholderTextColor;
        /// <summary>
        /// Gets or sets the foreground color of the control.
        /// </summary>
        [Description("The foreground color of this component, which is used to display the placeholder."), Category("Appearance"), DefaultValue(typeof(Color), "InactiveCaption")]
        public Color PlaceholderTextColor
        {
            get
            {
                return _placeholderTextColor;
            }

            set
            {
                if (_placeholderTextColor == value)
                    return;
                _placeholderTextColor = value;
                // Force redraw to show new color in designer instantly
                if (DesignMode)
                    Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the foreground color of the control.
        /// </summary>
        [Description("The foreground color of this component, which is used to display text."), Category("Appearance"), DefaultValue(typeof(Color), "WindowText")]
        public Color TextColor { get; set; }

        /// <summary>
        /// Do not access directly. Use TextColor.
        /// </summary>
        [Browsable(false)]
        public override Color ForeColor
        {
            get
            {
                if (IsPlaceholderActive)
                    return PlaceholderTextColor;
                return TextColor;
            }

            set
            {
                TextColor = value;
            }
        }

        /// <summary>
        /// Gets the length of text in the control.
        /// </summary>
        public override int TextLength => IsPlaceholderActive ? 0 : base.TextLength;

        /// <summary>
        /// Occurs when the value of the IsPlaceholderActive property has changed.
        /// </summary>
        [Description("Occurs when the value of the IsPlaceholderInside property has changed.")]
        public event EventHandler<PlaceholderActiveChangedEventArgs> PlaceholderActiveChanged;
#endregion
#region Global Variables
        /// <summary>
        /// Specifies the default placeholder text.
        /// </summary>
        const string DEFAULT_PLACEHOLDER = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        // Doc: https://msdn.microsoft.com/en-us/library/windows/desktop/bb761661(v=vs.85).aspx
        const int EM_SETSEL = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        /// <summary>
        /// Flag to avoid the TextChanged Event. Don't access directly, use Method 'ActionWithoutTextChanged(Action act)' instead.
        /// </summary>
        bool avoidTextChanged;
#endregion
#region Constructor
        /// <summary>
        /// Initializes a new instance of the PlaceholderTextBox class.
        /// </summary>
        public HintTextBox()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#region Functions
        /// <summary>
        /// Inserts placeholder, assigns placeholder style and sets cursor to first position.
        /// </summary>
        public void Reset()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Run an action with avoiding the TextChanged event.
        /// </summary>
        /// <param name = "act">Specifies the action to run.</param>
        private void ActionWithoutTextChanged(Action act)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void UpdateText()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#region Events
        int customMaxLength;
        protected override void OnCreateControl()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        protected override void OnTextChanged(EventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        protected override void WndProc(ref Message m)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        protected virtual void OnPlaceholderActiveChanged(bool newValue)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#region Avoid full text selection after first display with TabIndex = 0
        // Base class has a selectionSet property, but it is private.
        // We need to shadow with our own variable. If true, this means
        // "don't mess with the selection, the user did it."
        bool selectionSet;
        protected override void OnGotFocus(EventArgs e)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
#endregion
    }

    /// <summary>
    /// Provides data for the PlaceholderActiveChanged event.
    /// </summary>
    public class PlaceholderActiveChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the PlaceholderActiveChangedEventArgs class.
        /// </summary>
        /// <param name = "isActive">Specifies whether the placeholder is currently active.</param>
        public PlaceholderActiveChangedEventArgs(bool isActive)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        /// <summary>
        /// Gets the new value of the IsPlaceholderActive property.
        /// </summary>
        public bool IsActive { get; private set; }
    }
}