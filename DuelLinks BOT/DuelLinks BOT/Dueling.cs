using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace DuelLinks_BOT
{
    // Handles dueling actions
    class Dueling
    {
        private static Bitmap tempScreenshot;
        private static bool logButtonExists;
        private static bool duelButtonExists;
        private static Point location;
        public static bool isDuelOver = false;
        private static Form1 frm;

        // Constructor to reference form's controls
        public Dueling(Form1 form)
        {
            frm = form;
        }
    }
}
