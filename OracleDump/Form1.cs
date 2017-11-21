using System;
using System.Windows.Forms;
using System.Management;

namespace OracleDump
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dump_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dump_text = string.Empty;
            dump_text += expdp_radio.Checked ? expdp_radio.Text.ToLower() : impdp_radio.Text.ToLower() ;
            dump_text += string.IsNullOrEmpty(remap_schema_from.Text) ? " ":" remap_schema=" +remap_schema_from.Text+":"+remap_schema_to.Text+" " ;
            //remap_tablespace_from.Text.Split(',');
            dump_text += string.IsNullOrEmpty(remap_tablespace_from.Text) ? " ":" remap_tablespace=" + remap_tablespace_from.Text + ":" + remap_tablespace_to.Text + " ";
            dump_text += string.IsNullOrEmpty(remap_ts_index_from.Text) ? " " : "," + remap_ts_index_from.Text + ":" + remap_ts_index_to.Text + " ";
            dump_text += string.IsNullOrEmpty(directory.Text) ? " " : " DIRECTORY=" + directory.Text ;
            dump_text += string.IsNullOrEmpty(dumpfile.Text) ? " " : " DUMPFILE=" + dumpfile.Text;
            dump_text += string.IsNullOrEmpty(logfile.Text) ? " " : " LOGFILE=" + logfile.Text;
            dump_text += string.IsNullOrEmpty(schemas.Text) ? " " : " SCHEMAS=" + schemas.Text;
            dump_text += string.IsNullOrEmpty(opcional.Text) ? " " : " " + opcional.Text;


            command.Text = dump_text;


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            if (linux.Checked)
            {
                //Call Putty
                MessageBox.Show(command.Text);
            }
            else if (windows.Checked) {
                //Call PSEXEC.
                MessageBox.Show(command.Text);
            }
            
            

        }

       

    }
}
