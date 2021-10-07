using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class frmtest : Form
    {
        public frmtest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "";
            MySqlConnection conn;

            try
            {
                connectionString = @"Server=localhost;Database=smis025819;Uid=root;
                                     Pwd=usbw;SSL Mode=None";
                conn = new MySqlConnection(connectionString);
                conn.Open();
                MetroFramework.MetroMessageBox.Show(this, " Se establecio conexion!" , 
                    "CONEXION EXITOSA" ,MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
            catch (Exception Ex)
            {
                MetroFramework.MetroMessageBox.Show(this, Ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }
    }
}

