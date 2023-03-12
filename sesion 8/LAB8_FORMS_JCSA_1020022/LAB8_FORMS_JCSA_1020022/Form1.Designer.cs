namespace LAB8_FORMS_JCSA_1020022
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LABELTITULO = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.COMBOBOX_OPCIONES = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_NumeroN = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.LB_RESSUMATORIA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_NUMERONFACTORIAL = new System.Windows.Forms.TextBox();
            this.BT_CALCULARFACTORIAL = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LB_RESFACTORIAL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_NUMEROMULTIP = new System.Windows.Forms.TextBox();
            this.BT_TABLAMULTIP = new System.Windows.Forms.Button();
            this.LB_RESTABLASMILTIP = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_NumeroPerfectoN = new System.Windows.Forms.TextBox();
            this.BT_NUMEROPERFECT = new System.Windows.Forms.Button();
            this.LB_RESNUMPERF = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LABELTITULO
            // 
            this.LABELTITULO.AutoSize = true;
            this.LABELTITULO.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABELTITULO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LABELTITULO.Location = new System.Drawing.Point(349, 9);
            this.LABELTITULO.Name = "LABELTITULO";
            this.LABELTITULO.Size = new System.Drawing.Size(307, 23);
            this.LABELTITULO.TabIndex = 0;
            this.LABELTITULO.Text = "LABORATORIO 8 JUAN SANDOVAL";
            this.LABELTITULO.Click += new System.EventHandler(this.LABELTITULO_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.COMBOBOX_OPCIONES);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECCION";
            // 
            // COMBOBOX_OPCIONES
            // 
            this.COMBOBOX_OPCIONES.FormattingEnabled = true;
            this.COMBOBOX_OPCIONES.Items.AddRange(new object[] {
            "SUMATORIA",
            "FACTORIAL",
            "MULTIPLICACION",
            "NUMERO PERFECTO"});
            this.COMBOBOX_OPCIONES.Location = new System.Drawing.Point(54, 48);
            this.COMBOBOX_OPCIONES.Name = "COMBOBOX_OPCIONES";
            this.COMBOBOX_OPCIONES.Size = new System.Drawing.Size(164, 26);
            this.COMBOBOX_OPCIONES.TabIndex = 0;
            this.COMBOBOX_OPCIONES.SelectedIndexChanged += new System.EventHandler(this.COMBOBOX_OPCIONES_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(414, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 379);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LB_RESSUMATORIA);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.TB_NumeroN);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sumatoria";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LB_RESFACTORIAL);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.BT_CALCULARFACTORIAL);
            this.tabPage2.Controls.Add(this.TB_NUMERONFACTORIAL);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(581, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Factorial";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.LB_RESTABLASMILTIP);
            this.tabPage3.Controls.Add(this.BT_TABLAMULTIP);
            this.tabPage3.Controls.Add(this.TB_NUMEROMULTIP);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(581, 348);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tablas de Multiplicar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.LB_RESNUMPERF);
            this.tabPage4.Controls.Add(this.BT_NUMEROPERFECT);
            this.tabPage4.Controls.Add(this.TB_NumeroPerfectoN);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(581, 348);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Numero Perfecto";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(50, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese numero N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // TB_NumeroN
            // 
            this.TB_NumeroN.Location = new System.Drawing.Point(262, 79);
            this.TB_NumeroN.Name = "TB_NumeroN";
            this.TB_NumeroN.Size = new System.Drawing.Size(164, 25);
            this.TB_NumeroN.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "CALCULAR SUMATORIA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LB_RESSUMATORIA
            // 
            this.LB_RESSUMATORIA.AutoSize = true;
            this.LB_RESSUMATORIA.Location = new System.Drawing.Point(94, 204);
            this.LB_RESSUMATORIA.Name = "LB_RESSUMATORIA";
            this.LB_RESSUMATORIA.Size = new System.Drawing.Size(80, 18);
            this.LB_RESSUMATORIA.TabIndex = 4;
            this.LB_RESSUMATORIA.Text = ".........";
            this.LB_RESSUMATORIA.Click += new System.EventHandler(this.LB_RESSUMATORIA_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "INGRESE NUMERO N";
            // 
            // TB_NUMERONFACTORIAL
            // 
            this.TB_NUMERONFACTORIAL.Location = new System.Drawing.Point(239, 65);
            this.TB_NUMERONFACTORIAL.Name = "TB_NUMERONFACTORIAL";
            this.TB_NUMERONFACTORIAL.Size = new System.Drawing.Size(121, 25);
            this.TB_NUMERONFACTORIAL.TabIndex = 1;
            // 
            // BT_CALCULARFACTORIAL
            // 
            this.BT_CALCULARFACTORIAL.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CALCULARFACTORIAL.Location = new System.Drawing.Point(411, 56);
            this.BT_CALCULARFACTORIAL.Name = "BT_CALCULARFACTORIAL";
            this.BT_CALCULARFACTORIAL.Size = new System.Drawing.Size(98, 44);
            this.BT_CALCULARFACTORIAL.TabIndex = 2;
            this.BT_CALCULARFACTORIAL.Text = "CALCULAR";
            this.BT_CALCULARFACTORIAL.UseVisualStyleBackColor = true;
            this.BT_CALCULARFACTORIAL.Click += new System.EventHandler(this.BT_CALCULARFACTORIAL_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "RESPUESTA";
            // 
            // LB_RESFACTORIAL
            // 
            this.LB_RESFACTORIAL.AutoSize = true;
            this.LB_RESFACTORIAL.Location = new System.Drawing.Point(200, 171);
            this.LB_RESFACTORIAL.Name = "LB_RESFACTORIAL";
            this.LB_RESFACTORIAL.Size = new System.Drawing.Size(88, 18);
            this.LB_RESFACTORIAL.TabIndex = 4;
            this.LB_RESFACTORIAL.Text = "----------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "INGRESE LA TABLA QUE DESEA SABER";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TB_NUMEROMULTIP
            // 
            this.TB_NUMEROMULTIP.Location = new System.Drawing.Point(200, 30);
            this.TB_NUMEROMULTIP.Name = "TB_NUMEROMULTIP";
            this.TB_NUMEROMULTIP.Size = new System.Drawing.Size(100, 25);
            this.TB_NUMEROMULTIP.TabIndex = 1;
            // 
            // BT_TABLAMULTIP
            // 
            this.BT_TABLAMULTIP.Location = new System.Drawing.Point(20, 287);
            this.BT_TABLAMULTIP.Name = "BT_TABLAMULTIP";
            this.BT_TABLAMULTIP.Size = new System.Drawing.Size(102, 41);
            this.BT_TABLAMULTIP.TabIndex = 2;
            this.BT_TABLAMULTIP.Text = "CALCULAR";
            this.BT_TABLAMULTIP.UseVisualStyleBackColor = true;
            this.BT_TABLAMULTIP.Click += new System.EventHandler(this.BT_TABLAMULTIP_Click);
            // 
            // LB_RESTABLASMILTIP
            // 
            this.LB_RESTABLASMILTIP.FormattingEnabled = true;
            this.LB_RESTABLASMILTIP.ItemHeight = 18;
            this.LB_RESTABLASMILTIP.Location = new System.Drawing.Point(200, 61);
            this.LB_RESTABLASMILTIP.Name = "LB_RESTABLASMILTIP";
            this.LB_RESTABLASMILTIP.Size = new System.Drawing.Size(164, 274);
            this.LB_RESTABLASMILTIP.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(386, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 48);
            this.button3.TabIndex = 5;
            this.button3.Text = "LIMPIAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ingrese numero N";
            // 
            // TB_NumeroPerfectoN
            // 
            this.TB_NumeroPerfectoN.Location = new System.Drawing.Point(292, 44);
            this.TB_NumeroPerfectoN.Name = "TB_NumeroPerfectoN";
            this.TB_NumeroPerfectoN.Size = new System.Drawing.Size(100, 25);
            this.TB_NumeroPerfectoN.TabIndex = 1;
            // 
            // BT_NUMEROPERFECT
            // 
            this.BT_NUMEROPERFECT.Location = new System.Drawing.Point(424, 36);
            this.BT_NUMEROPERFECT.Name = "BT_NUMEROPERFECT";
            this.BT_NUMEROPERFECT.Size = new System.Drawing.Size(101, 40);
            this.BT_NUMEROPERFECT.TabIndex = 2;
            this.BT_NUMEROPERFECT.Text = "CALCULAR";
            this.BT_NUMEROPERFECT.UseVisualStyleBackColor = true;
            this.BT_NUMEROPERFECT.Click += new System.EventHandler(this.BT_NUMEROPERFECT_Click);
            // 
            // LB_RESNUMPERF
            // 
            this.LB_RESNUMPERF.AutoSize = true;
            this.LB_RESNUMPERF.Location = new System.Drawing.Point(168, 108);
            this.LB_RESNUMPERF.Name = "LB_RESNUMPERF";
            this.LB_RESNUMPERF.Size = new System.Drawing.Size(0, 18);
            this.LB_RESNUMPERF.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1037, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LABELTITULO);
            this.Name = "Form1";
            this.Text = "LAB 8";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABELTITULO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox COMBOBOX_OPCIONES;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox TB_NumeroN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LB_RESSUMATORIA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LB_RESFACTORIAL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BT_CALCULARFACTORIAL;
        private System.Windows.Forms.TextBox TB_NUMERONFACTORIAL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_TABLAMULTIP;
        private System.Windows.Forms.TextBox TB_NUMEROMULTIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LB_RESTABLASMILTIP;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LB_RESNUMPERF;
        private System.Windows.Forms.Button BT_NUMEROPERFECT;
        private System.Windows.Forms.TextBox TB_NumeroPerfectoN;
        private System.Windows.Forms.Label label6;
    }
}

