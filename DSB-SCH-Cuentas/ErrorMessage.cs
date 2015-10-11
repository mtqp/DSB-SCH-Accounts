using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accounts
{
    public partial class ErrorMessage : Form
    {
        private Exception exception;

        public ErrorMessage()
        {
            InitializeComponent();
        }

        public ErrorMessage(Exception exception)
            : this()
        {
            this.exception = exception;

            lblError.Text = "Algo salio mal! :( " + Environment.NewLine +
                            "Por favor acordate que estabas haciendo para avisarle a Mariano. Copia y pega estos datos y mandaselos a marian_sabianaa@hotmail.com." + Environment.NewLine +
                            exception.Message + Environment.NewLine +
                            exception.StackTrace;
        }
    }
}
