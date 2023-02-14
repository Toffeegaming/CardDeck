using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FormsTest
{
    public partial class Keypad : UserControl
    {
        public Keypad()
        {
            InitializeComponent();
            //InitFonts();
            //SetFont();
            InitButtonList();
        }

//#region font
//        //TODO: Verplaats naar eigen aparte functie buiten keypad & geen duplicate code
//        [DllImport("gdi32.dll")]
//        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
//        private PrivateFontCollection mFontCollection = new PrivateFontCollection();
//        private void InitFonts()
//        {

//            Stream fontStream = new MemoryStream(Properties.Resources.Roboto_Regular);

//            //create an unsafe memory block for the data
//            System.IntPtr data = Marshal.AllocCoTaskMem((int)fontStream.Length);
//            //create a buffer to read in to
//            Byte[] fontData = new Byte[fontStream.Length];
//            //fetch the font program from the resource
//            fontStream.Read(fontData, 0, (int)fontStream.Length);
//            //copy the bytes to the unsafe memory block
//            Marshal.Copy(fontData, 0, data, (int)fontStream.Length);
//            // We HAVE to do this to register the font to the system (Weird .NET bug !)
//            uint cFonts = 0;
//            AddFontMemResourceEx(data, (uint)fontData.Length, IntPtr.Zero, ref cFonts);
//            //pass the font to the font collection
//            mFontCollection.AddMemoryFont(data, (int)fontStream.Length);
//            //close the resource stream
//            fontStream.Close();
//            //free the unsafe memory
//            Marshal.FreeCoTaskMem(data);


//            fontStream = new MemoryStream(Properties.Resources.Roboto_Black);

//            //create an unsafe memory block for the data
//            data = Marshal.AllocCoTaskMem((int)fontStream.Length);
//            //create a buffer to read in to
//            fontData = new Byte[fontStream.Length];
//            //fetch the font program from the resource
//            fontStream.Read(fontData, 0, (int)fontStream.Length);
//            //copy the bytes to the unsafe memory block
//            Marshal.Copy(fontData, 0, data, (int)fontStream.Length);
//            // We HAVE to do this to register the font to the system (Weird .NET bug !)
//            cFonts = 0;
//            AddFontMemResourceEx(data, (uint)fontData.Length, IntPtr.Zero, ref cFonts);
//            //pass the font to the font collection
//            mFontCollection.AddMemoryFont(data, (int)fontStream.Length);
//            //close the resource stream
//            fontStream.Close();
//            //free the unsafe memory
//            Marshal.FreeCoTaskMem(data);

//            this._fonts.Append(new Font( mFontCollection.Families[0], this.Button00.Font.Size ) );
//            this._fonts.Append(new Font(mFontCollection.Families[1], this.Button00.Font.Size));
//        }

//        private void SetFont()
//        {
//            // Text
//            this.ButtonBack.Font = _fonts[0];
//            this.ButtonState.Font = _fonts[0];
//            this.ButtonEnter.Font = _fonts[0];
//            this.TextBox.Font = _fonts[0];
//            // Numbers
//            this.Button00.Font = _fonts[1];
//            this.Button0.Font = _fonts[1];
//            this.Button1.Font = _fonts[1];
//            this.Button2.Font = _fonts[1];
//            this.Button3.Font = _fonts[1];
//            this.Button4.Font = _fonts[1];
//            this.Button5.Font = _fonts[1];
//            this.Button6.Font = _fonts[1];
//            this.Button7.Font = _fonts[1];
//            this.Button8.Font = _fonts[1];
//            this.Button9.Font = _fonts[1];
//        }
//#endregion

        private bool _active = true;

        private List<Button> _buttons; // list of all buttons that will be affected in more than one way by state transition | All except ButtonState

        private void InitButtonList()
        {
            _buttons = new List<Button>();

            _buttons.Add(Button00);
            _buttons.Add(Button0);
            _buttons.Add(Button1);
            _buttons.Add(Button2);
            _buttons.Add(Button3);
            _buttons.Add(Button4);
            _buttons.Add(Button5);
            _buttons.Add(Button6);
            _buttons.Add(Button7);
            _buttons.Add(Button8);
            _buttons.Add(Button9);
            _buttons.Add(ButtonBack);
            _buttons.Add(ButtonEnter);
        }

        //private Font[] _fonts= null;

        public bool Active
        {
            get { return _active; }
            set { SwitchState(value); }
        }

        //public Font[] Fonts
        //{
        //    get { return _fonts; }
        //    set
        //    {
        //        _fonts = value;

        //        this.SetFont();
        //    }
        //}

        public event EventHandler<KeypadInputEventArgs> OnKeypadInputSubmit;

        private void SendInput(string ean)
        {
            Console.WriteLine(ean);

            OnKeypadInputSubmit?.Invoke(this, new KeypadInputEventArgs { Input = ean } );
        }

        private void SwitchState(bool targetState)
        {
            if (targetState)
            {
                // Textbox
                TextBox.BackColor = Color.White;

                foreach (var button in _buttons)
                {
                    button.Enabled = true;
                    button.BackColor = Color.White;
                }
                
                // ButtonState
                ButtonState.Text = "Afrekenen"; 
            }
            else
            {
                
                // Inputfield
                TextBox.Text = "";
                TextBox.BackColor = Color.LightGray;

                foreach (var button in _buttons)
                {
                    button.Enabled = false;
                    button.BackColor = Color.LightGray;
                }
                // ButtonState
                ButtonState.Text = "Verkoop";
            }

            _active = targetState;
        }

#region Button Clicks
        private void Button0_Click(object sender, EventArgs e)
        {
            TextBox.Text += "0";
        }

        private void Button00_Click(object sender, EventArgs e)
        {
            TextBox.Text +="00";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TextBox.Text +="1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TextBox.Text +="2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            TextBox.Text +="3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            TextBox.Text +="4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            TextBox.Text +="5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            TextBox.Text +="6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            TextBox.Text +="7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            TextBox.Text +="8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            TextBox.Text +="9";
        }

        private void ButtonState_Click(object sender, EventArgs e)
        {
            SwitchState(!_active);
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            SendInput(TextBox.Text);
            TextBox.Text = "";
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Nothing to remove in input field.");
            }
           
        }
#endregion
    }

    public class KeypadInputEventArgs : EventArgs
    {
        public string Input { get; set; }
    }
}
