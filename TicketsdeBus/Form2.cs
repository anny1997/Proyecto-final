﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketsdeBus.BL;

namespace TicketsdeBus
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        public void CargarDatos(BusBL busBL, ViajesBL viajesBL)
        {
            listadeBusesBindingSource.DataSource = busBL.ListadeBuses;
            listadeViajesBindingSource.DataSource = viajesBL.ListadeViajes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();

            var archivo = openFileDialog1.FileName;

            if(archivo != "")
            {
                var fileInfo = new FileInfo(archivo);
                var fileStream = fileInfo.OpenRead();

                pictureBox1.Image = Image.FromStream(fileStream);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
