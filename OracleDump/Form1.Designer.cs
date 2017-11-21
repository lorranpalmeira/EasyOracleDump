namespace OracleDump
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.remap_schema_from = new System.Windows.Forms.TextBox();
            this.opcional = new System.Windows.Forms.TextBox();
            this.remap_tablespace_from = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.remap_schema_to = new System.Windows.Forms.TextBox();
            this.remap_tablespace_to = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.expdp_radio = new System.Windows.Forms.RadioButton();
            this.impdp_radio = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.command = new System.Windows.Forms.TextBox();
            this.go_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.remap_ts_index_from = new System.Windows.Forms.TextBox();
            this.remap_ts_index_to = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.linux = new System.Windows.Forms.RadioButton();
            this.windows = new System.Windows.Forms.RadioButton();
            this.schemas = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.directory = new System.Windows.Forms.TextBox();
            this.dumpfile = new System.Windows.Forms.TextBox();
            this.logfile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // remap_schema_from
            // 
            this.remap_schema_from.Location = new System.Drawing.Point(144, 156);
            this.remap_schema_from.Name = "remap_schema_from";
            this.remap_schema_from.Size = new System.Drawing.Size(100, 20);
            this.remap_schema_from.TabIndex = 0;
            // 
            // opcional
            // 
            this.opcional.Location = new System.Drawing.Point(144, 211);
            this.opcional.Name = "opcional";
            this.opcional.Size = new System.Drawing.Size(522, 20);
            this.opcional.TabIndex = 1;
            // 
            // remap_tablespace_from
            // 
            this.remap_tablespace_from.Location = new System.Drawing.Point(144, 185);
            this.remap_tablespace_from.Name = "remap_tablespace_from";
            this.remap_tablespace_from.Size = new System.Drawing.Size(100, 20);
            this.remap_tablespace_from.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Remap Schema from:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Remap Tablespace from:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Opcional :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "To:";
            // 
            // remap_schema_to
            // 
            this.remap_schema_to.Location = new System.Drawing.Point(285, 156);
            this.remap_schema_to.Name = "remap_schema_to";
            this.remap_schema_to.Size = new System.Drawing.Size(100, 20);
            this.remap_schema_to.TabIndex = 13;
            // 
            // remap_tablespace_to
            // 
            this.remap_tablespace_to.Location = new System.Drawing.Point(285, 182);
            this.remap_tablespace_to.Name = "remap_tablespace_to";
            this.remap_tablespace_to.Size = new System.Drawing.Size(100, 20);
            this.remap_tablespace_to.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "To:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // expdp_radio
            // 
            this.expdp_radio.AutoSize = true;
            this.expdp_radio.Location = new System.Drawing.Point(144, 13);
            this.expdp_radio.Name = "expdp_radio";
            this.expdp_radio.Size = new System.Drawing.Size(55, 17);
            this.expdp_radio.TabIndex = 16;
            this.expdp_radio.TabStop = true;
            this.expdp_radio.Text = "Expdp";
            this.expdp_radio.UseVisualStyleBackColor = true;
            // 
            // impdp_radio
            // 
            this.impdp_radio.AutoSize = true;
            this.impdp_radio.Location = new System.Drawing.Point(144, 30);
            this.impdp_radio.Name = "impdp_radio";
            this.impdp_radio.Size = new System.Drawing.Size(54, 17);
            this.impdp_radio.TabIndex = 17;
            this.impdp_radio.TabStop = true;
            this.impdp_radio.Text = "Impdp";
            this.impdp_radio.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Type :";
            // 
            // command
            // 
            this.command.Location = new System.Drawing.Point(144, 276);
            this.command.Multiline = true;
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(500, 38);
            this.command.TabIndex = 19;
            // 
            // go_button
            // 
            this.go_button.Location = new System.Drawing.Point(12, 239);
            this.go_button.Name = "go_button";
            this.go_button.Size = new System.Drawing.Size(75, 23);
            this.go_button.TabIndex = 20;
            this.go_button.Text = "Go";
            this.go_button.UseVisualStyleBackColor = true;
            this.go_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Send To Server";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Server:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(144, 353);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 23;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(324, 349);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 24;
            this.textBox11.UseSystemPasswordChar = true;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(489, 350);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Status:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(250, 356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Password :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(432, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Instance:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(75, 428);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Stopped";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 276);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Command:";
            // 
            // remap_ts_index_from
            // 
            this.remap_ts_index_from.Location = new System.Drawing.Point(435, 178);
            this.remap_ts_index_from.Name = "remap_ts_index_from";
            this.remap_ts_index_from.Size = new System.Drawing.Size(100, 20);
            this.remap_ts_index_from.TabIndex = 36;
            // 
            // remap_ts_index_to
            // 
            this.remap_ts_index_to.Location = new System.Drawing.Point(566, 175);
            this.remap_ts_index_to.Name = "remap_ts_index_to";
            this.remap_ts_index_to.Size = new System.Drawing.Size(100, 20);
            this.remap_ts_index_to.TabIndex = 37;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(391, 185);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "From:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(537, 182);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "To:";
            // 
            // linux
            // 
            this.linux.AutoSize = true;
            this.linux.Location = new System.Drawing.Point(144, 320);
            this.linux.Name = "linux";
            this.linux.Size = new System.Drawing.Size(50, 17);
            this.linux.TabIndex = 40;
            this.linux.TabStop = true;
            this.linux.Text = "Linux";
            this.linux.UseVisualStyleBackColor = true;
            // 
            // windows
            // 
            this.windows.AutoSize = true;
            this.windows.Location = new System.Drawing.Point(235, 320);
            this.windows.Name = "windows";
            this.windows.Size = new System.Drawing.Size(69, 17);
            this.windows.TabIndex = 41;
            this.windows.TabStop = true;
            this.windows.Text = "Windows";
            this.windows.UseVisualStyleBackColor = true;
            // 
            // schemas
            // 
            this.schemas.Location = new System.Drawing.Point(144, 130);
            this.schemas.Name = "schemas";
            this.schemas.Size = new System.Drawing.Size(100, 20);
            this.schemas.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Schemas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Logfile :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Dumpfile :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Directory:";
            // 
            // directory
            // 
            this.directory.Location = new System.Drawing.Point(144, 52);
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(100, 20);
            this.directory.TabIndex = 44;
            // 
            // dumpfile
            // 
            this.dumpfile.Location = new System.Drawing.Point(144, 78);
            this.dumpfile.Name = "dumpfile";
            this.dumpfile.Size = new System.Drawing.Size(100, 20);
            this.dumpfile.TabIndex = 43;
            // 
            // logfile
            // 
            this.logfile.Location = new System.Drawing.Point(144, 104);
            this.logfile.Name = "logfile";
            this.logfile.Size = new System.Drawing.Size(100, 20);
            this.logfile.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 462);
            this.Controls.Add(this.schemas);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.directory);
            this.Controls.Add(this.dumpfile);
            this.Controls.Add(this.logfile);
            this.Controls.Add(this.windows);
            this.Controls.Add(this.linux);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.remap_ts_index_to);
            this.Controls.Add(this.remap_ts_index_from);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.go_button);
            this.Controls.Add(this.command);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.impdp_radio);
            this.Controls.Add(this.expdp_radio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.remap_tablespace_to);
            this.Controls.Add(this.remap_schema_to);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remap_tablespace_from);
            this.Controls.Add(this.opcional);
            this.Controls.Add(this.remap_schema_from);
            this.Name = "Form1";
            this.Text = "Easy Oracle Dump";
            this.Load += new System.EventHandler(this.Dump_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox remap_schema_from;
        private System.Windows.Forms.TextBox opcional;
        private System.Windows.Forms.TextBox remap_tablespace_from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox remap_schema_to;
        private System.Windows.Forms.TextBox remap_tablespace_to;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton expdp_radio;
        private System.Windows.Forms.RadioButton impdp_radio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox command;
        private System.Windows.Forms.Button go_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox remap_ts_index_from;
        private System.Windows.Forms.TextBox remap_ts_index_to;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton linux;
        private System.Windows.Forms.RadioButton windows;
        private System.Windows.Forms.TextBox schemas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox directory;
        private System.Windows.Forms.TextBox dumpfile;
        private System.Windows.Forms.TextBox logfile;
    }
}

