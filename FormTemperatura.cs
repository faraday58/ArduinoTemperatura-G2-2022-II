using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ArduinoTemperatura_G2_2022_II
{
    public partial class FormTemperatura : Form
    {
        private int tiempo;
        private sbyte temperatura;
        private Random aleatoria;
        private Form formpadre;
        public FormTemperatura(Form formpadre)
        {
            InitializeComponent();
            this.formpadre = formpadre;
        }
        //Solamente al iniciar la simulación.
        private void iniciarToolStripMenuItem1_Click(object sender, EventArgs e)
        {            
            timerTemperatura.Start();
            aleatoria= new Random();

        }

        private void timerTemperatura_Tick(object sender, EventArgs e)
        {
            temperatura = (sbyte)aleatoria.Next(126);
            dgvTemperatura.Rows.Add(tiempo++, temperatura);


        }

        private void pararToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerTemperatura.Stop();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            StreamWriter sw = null;
            SaveFileDialog sf = new SaveFileDialog();

            sf.Filter = "Archivos de Texto | *.txt|Todos los archivos (*.*)|*.*";
            sf.DefaultExt = ".txt";
            if (sf.ShowDialog() == DialogResult.OK  )
            {
                try
                {
                    sw = new StreamWriter(sf.FileName);
                    sw.WriteLine("Tiempo,Temperatura");
                    for(int i =0; i <dgvTemperatura.Rows.Count; i ++)
                    {
                        sw.WriteLine(dgvTemperatura.Rows[i].Cells[0].Value + "," + dgvTemperatura.Rows[i].Cells[1].Value);
                    }
                }
                catch(Exception error)
                {
                    MessageBox.Show("Error: " + error.Message);
                }
                finally
                {
                    sw.Close();
                }
                
                


            }




        }
    }
}
