using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cas;

namespace KozijnRaam
{
    internal class Frame
    {
        private List<Window> _windows;
        public readonly string Color;
        private readonly IoHandler _io;

        public Frame(int numberOfWindows, string color)
        {
            _io = IoHandler.Instance;
            _windows = new List<Window>(numberOfWindows);

            for (int i = 0; i < numberOfWindows; i++)
            {
                _windows.Add(new Window(this, i));
            }
            Color = color;
        }

        public void ShowWindows()
        {
            _io.PrintLine($"This is the {Color} {this}.\nI have {_windows.Count} windows, let's hear from them:");
            foreach (var window in _windows)
            {
                _io.PrintLine(window.Show());
            }
            _io.PrintLine("");
        }
    }
}
