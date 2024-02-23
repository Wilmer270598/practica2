namespace proyecto_final_prog._III
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            groupBox1 = new GroupBox();
            Mod = new NumericUpDown();
            Mar = new ComboBox();
            Pla = new TextBox();
            label4 = new Label();
            label3 = new Label();
            Placa = new Label();
            groupBox2 = new GroupBox();
            labelHora = new TextBox();
            Fec = new DateTimePicker();
            label5 = new Label();
            label2 = new Label();
            Des = new ComboBox();
            Dgv = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Salida1 = new Label();
            Salida2 = new Label();
            label8 = new Label();
            menuStrip1 = new MenuStrip();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            tOTALPEAJEDELDESTINOELEGIDOToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            pLACADELVEHICULOQUEPAGOMAYORPEAJEToolStripMenuItem = new ToolStripMenuItem();
            fINToolStripMenuItem = new ToolStripMenuItem();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Mod).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(354, 47);
            label1.Name = "label1";
            label1.Size = new Size(299, 41);
            label1.TabIndex = 0;
            label1.Text = "CONTROL DE PEAJE";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Aquamarine;
            groupBox1.Controls.Add(Mod);
            groupBox1.Controls.Add(Mar);
            groupBox1.Controls.Add(Pla);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Placa);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(99, 83);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(339, 182);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS DE 1 VEHICULO";
            // 
            // Mod
            // 
            Mod.Location = new Point(117, 145);
            Mod.Margin = new Padding(3, 2, 3, 2);
            Mod.Maximum = new decimal(new int[] { 2023, 0, 0, 0 });
            Mod.Minimum = new decimal(new int[] { 1985, 0, 0, 0 });
            Mod.Name = "Mod";
            Mod.Size = new Size(131, 29);
            Mod.TabIndex = 5;
            Mod.Value = new decimal(new int[] { 1985, 0, 0, 0 });
            // 
            // Mar
            // 
            Mar.FormattingEnabled = true;
            Mar.Items.AddRange(new object[] { "TOYOTA", "NISSAN", "ISUZU", "GAC", "SUZUKI", "ETC" });
            Mar.Location = new Point(117, 89);
            Mar.Margin = new Padding(3, 2, 3, 2);
            Mar.Name = "Mar";
            Mar.Size = new Size(133, 29);
            Mar.TabIndex = 4;
            // 
            // Pla
            // 
            Pla.Location = new Point(117, 43);
            Pla.Margin = new Padding(3, 2, 3, 2);
            Pla.Name = "Pla";
            Pla.Size = new Size(133, 29);
            Pla.TabIndex = 3;
            Pla.TextChanged += Pla_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 149);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 2;
            label4.Text = "Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 95);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 1;
            label3.Text = "Marca";
            // 
            // Placa
            // 
            Placa.AutoSize = true;
            Placa.Location = new Point(20, 43);
            Placa.Name = "Placa";
            Placa.Size = new Size(50, 21);
            Placa.TabIndex = 0;
            Placa.Text = "Placa";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Aquamarine;
            groupBox2.Controls.Add(labelHora);
            groupBox2.Controls.Add(Fec);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(Des);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(576, 111);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(389, 154);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "DATOS DE PEAJE";
            // 
            // labelHora
            // 
            labelHora.Location = new Point(41, 131);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(100, 29);
            labelHora.TabIndex = 4;
            labelHora.TextChanged += labelHora_TextChanged;
            // 
            // Fec
            // 
            Fec.Format = DateTimePickerFormat.Short;
            Fec.Location = new Point(185, 97);
            Fec.Margin = new Padding(3, 2, 3, 2);
            Fec.Name = "Fec";
            Fec.Size = new Size(141, 29);
            Fec.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 97);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 2;
            label5.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 42);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 1;
            label2.Text = "Destino";
            // 
            // Des
            // 
            Des.FormattingEnabled = true;
            Des.Items.AddRange(new object[] { "COCHABAMBA", "SUCRE", "LA PAZ", "ORURO", "SANTA CRUZ", "BENI", "PANDO", "TARIJA" });
            Des.Location = new Point(185, 40);
            Des.Margin = new Padding(3, 2, 3, 2);
            Des.Name = "Des";
            Des.Size = new Size(133, 29);
            Des.TabIndex = 0;
            // 
            // Dgv
            // 
            Dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            Dgv.Location = new Point(162, 279);
            Dgv.Margin = new Padding(3, 2, 3, 2);
            Dgv.Name = "Dgv";
            Dgv.RowHeadersVisible = false;
            Dgv.RowHeadersWidth = 51;
            Dgv.RowTemplate.Height = 29;
            Dgv.Size = new Size(753, 124);
            Dgv.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "PLACA";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "MARCA";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "MODELO";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "DESTINO";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "FECHA";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "PEAJE";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Salida1
            // 
            Salida1.BackColor = SystemColors.HotTrack;
            Salida1.BorderStyle = BorderStyle.Fixed3D;
            Salida1.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Salida1.Location = new Point(82, 452);
            Salida1.Name = "Salida1";
            Salida1.Size = new Size(196, 97);
            Salida1.TabIndex = 7;
            Salida1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Salida2
            // 
            Salida2.BackColor = SystemColors.HotTrack;
            Salida2.BorderStyle = BorderStyle.Fixed3D;
            Salida2.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Salida2.Location = new Point(448, 452);
            Salida2.Name = "Salida2";
            Salida2.Size = new Size(210, 97);
            Salida2.TabIndex = 8;
            Salida2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.HotTrack;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(780, 452);
            label8.Name = "label8";
            label8.Size = new Size(214, 97);
            label8.TabIndex = 9;
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { guardarToolStripMenuItem, toolStripMenuItem1, fINToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1060, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(60, 20);
            guardarToolStripMenuItem.Text = "guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { tOTALPEAJEDELDESTINOELEGIDOToolStripMenuItem, toolStripMenuItem2, pLACADELVEHICULOQUEPAGOMAYORPEAJEToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(84, 20);
            toolStripMenuItem1.Text = "informacion";
            // 
            // tOTALPEAJEDELDESTINOELEGIDOToolStripMenuItem
            // 
            tOTALPEAJEDELDESTINOELEGIDOToolStripMenuItem.Name = "tOTALPEAJEDELDESTINOELEGIDOToolStripMenuItem";
            tOTALPEAJEDELDESTINOELEGIDOToolStripMenuItem.Size = new Size(332, 22);
            tOTALPEAJEDELDESTINOELEGIDOToolStripMenuItem.Text = "TOTAL  PEAJE DEL DESTINO ELEGIDO ";
            tOTALPEAJEDELDESTINOELEGIDOToolStripMenuItem.Click += tOTALPEAJEDELDESTINOELEGIDOToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(332, 22);
            toolStripMenuItem2.Text = "PEAJE PROMEDIO DE LA MARCA ELEGIDA";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // pLACADELVEHICULOQUEPAGOMAYORPEAJEToolStripMenuItem
            // 
            pLACADELVEHICULOQUEPAGOMAYORPEAJEToolStripMenuItem.Name = "pLACADELVEHICULOQUEPAGOMAYORPEAJEToolStripMenuItem";
            pLACADELVEHICULOQUEPAGOMAYORPEAJEToolStripMenuItem.Size = new Size(332, 22);
            pLACADELVEHICULOQUEPAGOMAYORPEAJEToolStripMenuItem.Text = "PLACA DEL VEHICULO QUE PAGO MAYOR PEAJE";
            pLACADELVEHICULOQUEPAGOMAYORPEAJEToolStripMenuItem.Click += pLACADELVEHICULOQUEPAGOMAYORPEAJEToolStripMenuItem_Click;
            // 
            // fINToolStripMenuItem
            // 
            fINToolStripMenuItem.Name = "fINToolStripMenuItem";
            fINToolStripMenuItem.Size = new Size(37, 20);
            fINToolStripMenuItem.Text = "FIN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(476, 421);
            label6.Name = "label6";
            label6.Size = new Size(140, 21);
            label6.TabIndex = 11;
            label6.Text = "PEAJE PRONEDIO";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(125, 421);
            label7.Name = "label7";
            label7.Size = new Size(107, 21);
            label7.TabIndex = 12;
            label7.Text = "TOTAL PEAJE";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(780, 421);
            label9.Name = "label9";
            label9.Size = new Size(191, 21);
            label9.TabIndex = 13;
            label9.Text = "PLACA DE MAYOR PSGO";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1060, 562);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(Salida2);
            Controls.Add(Salida1);
            Controls.Add(Dgv);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Control de Peaje";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Mod).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox Pla;
        private Label label4;
        private Label label3;
        private Label Placa;
        private NumericUpDown Mod;
        private ComboBox Mar;
        private GroupBox groupBox2;
        private Label label5;
        private Label label2;
        private ComboBox Des;
        private DateTimePicker Fec;
        private DataGridView Dgv;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label Salida1;
        private Label Salida2;
        private Label label8;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem tOTALPEAJEDELDESTINOELEGIDOToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem pLACADELVEHICULOQUEPAGOMAYORPEAJEToolStripMenuItem;
        private ToolStripMenuItem fINToolStripMenuItem;
        private Label label6;
        private Label label7;
        private Label label9;
        private System.Windows.Forms.Timer timer1;
        private TextBox labelHora;
    }
}