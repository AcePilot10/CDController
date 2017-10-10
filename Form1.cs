using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CDController
{
    public partial class CDControllerForm : Form
    {
   
        //Media Control Interface (MCI)
        //Imports and registers the function for an MCI command
        [DllImport("winmm.dll")]
        protected static extern int mciSendString(string cmd, StringBuilder returnString, int returnLength, IntPtr callBack);
      /* Parameters:
       * 
       * cmd = Command to be ran
       * returnString = returns information about command
       * returnLength = Size, in characters of the return buffer of returnString
       * callBack = Handles to a callback window
       * 
       */


        public CDControllerForm()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
            lblCurrent.Text = "CD Is Currently Open";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            mciSendString("set cdaudio door closed", null, 0, IntPtr.Zero);
            lblCurrent.Text = "CD Is Currently Closed";
        }
    }
}
