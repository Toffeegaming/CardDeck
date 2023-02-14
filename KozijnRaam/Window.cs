using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KozijnRaam
{
    internal class Window
    {
        private Frame _frame;
        private int _id;

        public Window(Frame frame, int id)
        {
            _frame = frame;
            _id = id;
        }

        public string Show()
        {
            return $"I am a child {this} of the {_frame.Color} {_frame}. My id is: {_id}";
        }
    }
}
