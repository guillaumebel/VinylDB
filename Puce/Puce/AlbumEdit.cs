using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Puce
{
    /// <summary>
    /// Show album edit
    /// </summary>
    public partial class AlbumEdit : Form
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public AlbumEdit()
        {
            InitializeComponent();
        }

#region "Event"

        /// <summary>
        /// Close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Save the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

#endregion
       
    }
}
