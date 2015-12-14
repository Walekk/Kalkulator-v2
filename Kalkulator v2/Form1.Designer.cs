namespace Kalkulator_v2
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
            this.components = new System.ComponentModel.Container();
            this.richTextBoxWynik = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonDodawanie = new System.Windows.Forms.RadioButton();
            this.radioButtonOdejmowanie = new System.Windows.Forms.RadioButton();
            this.radioButtonMnozenie = new System.Windows.Forms.RadioButton();
            this.radioButtonDzielenie = new System.Windows.Forms.RadioButton();
            this.buttonOblicz = new System.Windows.Forms.Button();
            this.richTextBoxHistoria = new System.Windows.Forms.RichTextBox();
            this.buttonZapiszJakoLiczba1 = new System.Windows.Forms.Button();
            this.buttonZapiszJakoLIczba2 = new System.Windows.Forms.Button();
            this.buttonKasujHistorieOperacji = new System.Windows.Forms.Button();
            this.textBoxLIczba1 = new System.Windows.Forms.TextBox();
            this.textBoxLiczba2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.komunikatLiczba1 = new System.Windows.Forms.Label();
            this.komunikatLiczba2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStripWynik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodawanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odejmowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnozenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dzielenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripHistoriaOperacji = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.wprowadzJakoLiczba1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wprowadzJakoLiczba2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kasujHistorieOperacjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.contextMenuStripWynik.SuspendLayout();
            this.contextMenuStripHistoriaOperacji.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxWynik
            // 
            this.richTextBoxWynik.ContextMenuStrip = this.contextMenuStripWynik;
            this.richTextBoxWynik.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxWynik.Name = "richTextBoxWynik";
            this.richTextBoxWynik.ReadOnly = true;
            this.richTextBoxWynik.Size = new System.Drawing.Size(423, 22);
            this.richTextBoxWynik.TabIndex = 0;
            this.richTextBoxWynik.Text = "";
            this.richTextBoxWynik.TextChanged += new System.EventHandler(this.richTextBoxWynik_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxWynik);
            this.groupBox1.Location = new System.Drawing.Point(3, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wynik";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonDzielenie);
            this.groupBox2.Controls.Add(this.radioButtonMnozenie);
            this.groupBox2.Controls.Add(this.radioButtonOdejmowanie);
            this.groupBox2.Controls.Add(this.radioButtonDodawanie);
            this.groupBox2.Location = new System.Drawing.Point(9, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 52);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operacje";
            // 
            // radioButtonDodawanie
            // 
            this.radioButtonDodawanie.AutoSize = true;
            this.radioButtonDodawanie.Location = new System.Drawing.Point(9, 19);
            this.radioButtonDodawanie.Name = "radioButtonDodawanie";
            this.radioButtonDodawanie.Size = new System.Drawing.Size(79, 17);
            this.radioButtonDodawanie.TabIndex = 0;
            this.radioButtonDodawanie.TabStop = true;
            this.radioButtonDodawanie.Text = "Dodawanie";
            this.radioButtonDodawanie.UseVisualStyleBackColor = true;
            this.radioButtonDodawanie.CheckedChanged += new System.EventHandler(this.radioButtonDodawanie_CheckedChanged);
            // 
            // radioButtonOdejmowanie
            // 
            this.radioButtonOdejmowanie.AutoSize = true;
            this.radioButtonOdejmowanie.Location = new System.Drawing.Point(117, 19);
            this.radioButtonOdejmowanie.Name = "radioButtonOdejmowanie";
            this.radioButtonOdejmowanie.Size = new System.Drawing.Size(89, 17);
            this.radioButtonOdejmowanie.TabIndex = 1;
            this.radioButtonOdejmowanie.TabStop = true;
            this.radioButtonOdejmowanie.Text = "Odejmowanie";
            this.radioButtonOdejmowanie.UseVisualStyleBackColor = true;
            this.radioButtonOdejmowanie.CheckedChanged += new System.EventHandler(this.radioButtonOdejmowanie_CheckedChanged);
            // 
            // radioButtonMnozenie
            // 
            this.radioButtonMnozenie.AutoSize = true;
            this.radioButtonMnozenie.Location = new System.Drawing.Point(209, 19);
            this.radioButtonMnozenie.Name = "radioButtonMnozenie";
            this.radioButtonMnozenie.Size = new System.Drawing.Size(71, 17);
            this.radioButtonMnozenie.TabIndex = 2;
            this.radioButtonMnozenie.TabStop = true;
            this.radioButtonMnozenie.Text = "Mnozenie";
            this.radioButtonMnozenie.UseVisualStyleBackColor = true;
            this.radioButtonMnozenie.CheckedChanged += new System.EventHandler(this.radioButtonMnozenie_CheckedChanged);
            // 
            // radioButtonDzielenie
            // 
            this.radioButtonDzielenie.AutoSize = true;
            this.radioButtonDzielenie.Location = new System.Drawing.Point(301, 19);
            this.radioButtonDzielenie.Name = "radioButtonDzielenie";
            this.radioButtonDzielenie.Size = new System.Drawing.Size(68, 17);
            this.radioButtonDzielenie.TabIndex = 3;
            this.radioButtonDzielenie.TabStop = true;
            this.radioButtonDzielenie.Text = "Dzielenie";
            this.radioButtonDzielenie.UseVisualStyleBackColor = true;
            this.radioButtonDzielenie.CheckedChanged += new System.EventHandler(this.radioButtonDzielenie_CheckedChanged);
            // 
            // buttonOblicz
            // 
            this.buttonOblicz.Location = new System.Drawing.Point(9, 222);
            this.buttonOblicz.Name = "buttonOblicz";
            this.buttonOblicz.Size = new System.Drawing.Size(416, 23);
            this.buttonOblicz.TabIndex = 3;
            this.buttonOblicz.Text = "Oblicz";
            this.buttonOblicz.UseVisualStyleBackColor = true;
            this.buttonOblicz.Click += new System.EventHandler(this.buttonOblicz_Click);
            // 
            // richTextBoxHistoria
            // 
            this.richTextBoxHistoria.ContextMenuStrip = this.contextMenuStripHistoriaOperacji;
            this.richTextBoxHistoria.Location = new System.Drawing.Point(9, 265);
            this.richTextBoxHistoria.Name = "richTextBoxHistoria";
            this.richTextBoxHistoria.ReadOnly = true;
            this.richTextBoxHistoria.Size = new System.Drawing.Size(419, 293);
            this.richTextBoxHistoria.TabIndex = 4;
            this.richTextBoxHistoria.Text = "";
            // 
            // buttonZapiszJakoLiczba1
            // 
            this.buttonZapiszJakoLiczba1.Location = new System.Drawing.Point(2, 564);
            this.buttonZapiszJakoLiczba1.Name = "buttonZapiszJakoLiczba1";
            this.buttonZapiszJakoLiczba1.Size = new System.Drawing.Size(75, 23);
            this.buttonZapiszJakoLiczba1.TabIndex = 5;
            this.buttonZapiszJakoLiczba1.Text = "Liczba 1";
            this.buttonZapiszJakoLiczba1.UseVisualStyleBackColor = true;
            this.buttonZapiszJakoLiczba1.Click += new System.EventHandler(this.buttonZapiszJakoLiczba1_Click);
            // 
            // buttonZapiszJakoLIczba2
            // 
            this.buttonZapiszJakoLIczba2.Location = new System.Drawing.Point(350, 564);
            this.buttonZapiszJakoLIczba2.Name = "buttonZapiszJakoLIczba2";
            this.buttonZapiszJakoLIczba2.Size = new System.Drawing.Size(75, 23);
            this.buttonZapiszJakoLIczba2.TabIndex = 6;
            this.buttonZapiszJakoLIczba2.Text = "Liczba2";
            this.buttonZapiszJakoLIczba2.UseVisualStyleBackColor = true;
            this.buttonZapiszJakoLIczba2.Click += new System.EventHandler(this.buttonZapiszJakoLIczba2_Click);
            // 
            // buttonKasujHistorieOperacji
            // 
            this.buttonKasujHistorieOperacji.Location = new System.Drawing.Point(83, 564);
            this.buttonKasujHistorieOperacji.Name = "buttonKasujHistorieOperacji";
            this.buttonKasujHistorieOperacji.Size = new System.Drawing.Size(261, 23);
            this.buttonKasujHistorieOperacji.TabIndex = 7;
            this.buttonKasujHistorieOperacji.Text = "Kasuje historie";
            this.buttonKasujHistorieOperacji.UseVisualStyleBackColor = true;
            this.buttonKasujHistorieOperacji.Click += new System.EventHandler(this.buttonKasujHistorieOperacji_Click);
            // 
            // textBoxLIczba1
            // 
            this.textBoxLIczba1.Location = new System.Drawing.Point(6, 19);
            this.textBoxLIczba1.MaxLength = 20;
            this.textBoxLIczba1.Name = "textBoxLIczba1";
            this.textBoxLIczba1.Size = new System.Drawing.Size(175, 20);
            this.textBoxLIczba1.TabIndex = 8;
            this.textBoxLIczba1.TextChanged += new System.EventHandler(this.textBoxLIczba1_TextChanged);
            this.textBoxLIczba1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLIczba1_KeyPress);
            // 
            // textBoxLiczba2
            // 
            this.textBoxLiczba2.Location = new System.Drawing.Point(11, 19);
            this.textBoxLiczba2.MaxLength = 20;
            this.textBoxLiczba2.Name = "textBoxLiczba2";
            this.textBoxLiczba2.Size = new System.Drawing.Size(190, 20);
            this.textBoxLiczba2.TabIndex = 9;
            this.textBoxLiczba2.TextChanged += new System.EventHandler(this.textBoxLiczba2_TextChanged);
            this.textBoxLiczba2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLiczba2_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.komunikatLiczba1);
            this.groupBox3.Controls.Add(this.textBoxLIczba1);
            this.groupBox3.Location = new System.Drawing.Point(13, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 77);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liczba1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.komunikatLiczba2);
            this.groupBox4.Controls.Add(this.textBoxLiczba2);
            this.groupBox4.Location = new System.Drawing.Point(218, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(207, 77);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Liczba2";
            // 
            // komunikatLiczba1
            // 
            this.komunikatLiczba1.AutoSize = true;
            this.komunikatLiczba1.Location = new System.Drawing.Point(7, 46);
            this.komunikatLiczba1.Name = "komunikatLiczba1";
            this.komunikatLiczba1.Size = new System.Drawing.Size(0, 13);
            this.komunikatLiczba1.TabIndex = 9;
            // 
            // komunikatLiczba2
            // 
            this.komunikatLiczba2.AutoSize = true;
            this.komunikatLiczba2.Location = new System.Drawing.Point(7, 46);
            this.komunikatLiczba2.Name = "komunikatLiczba2";
            this.komunikatLiczba2.Size = new System.Drawing.Size(0, 13);
            this.komunikatLiczba2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Historia operacji";
            // 
            // contextMenuStripWynik
            // 
            this.contextMenuStripWynik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodawanieToolStripMenuItem,
            this.odejmowanieToolStripMenuItem,
            this.mnozenieToolStripMenuItem,
            this.dzielenieToolStripMenuItem});
            this.contextMenuStripWynik.Name = "contextMenuStripWynik";
            this.contextMenuStripWynik.Size = new System.Drawing.Size(149, 92);
            // 
            // dodawanieToolStripMenuItem
            // 
            this.dodawanieToolStripMenuItem.Name = "dodawanieToolStripMenuItem";
            this.dodawanieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dodawanieToolStripMenuItem.Text = "Dodawanie";
            this.dodawanieToolStripMenuItem.Click += new System.EventHandler(this.dodawanieToolStripMenuItem_Click);
            // 
            // odejmowanieToolStripMenuItem
            // 
            this.odejmowanieToolStripMenuItem.Name = "odejmowanieToolStripMenuItem";
            this.odejmowanieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.odejmowanieToolStripMenuItem.Text = "Odejmowanie";
            this.odejmowanieToolStripMenuItem.Click += new System.EventHandler(this.odejmowanieToolStripMenuItem_Click);
            // 
            // mnozenieToolStripMenuItem
            // 
            this.mnozenieToolStripMenuItem.Name = "mnozenieToolStripMenuItem";
            this.mnozenieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.mnozenieToolStripMenuItem.Text = "Mnozenie";
            this.mnozenieToolStripMenuItem.Click += new System.EventHandler(this.mnozenieToolStripMenuItem_Click);
            // 
            // dzielenieToolStripMenuItem
            // 
            this.dzielenieToolStripMenuItem.Name = "dzielenieToolStripMenuItem";
            this.dzielenieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dzielenieToolStripMenuItem.Text = "Dzielenie";
            this.dzielenieToolStripMenuItem.Click += new System.EventHandler(this.dzielenieToolStripMenuItem_Click);
            // 
            // contextMenuStripHistoriaOperacji
            // 
            this.contextMenuStripHistoriaOperacji.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wprowadzJakoLiczba1ToolStripMenuItem,
            this.wprowadzJakoLiczba2ToolStripMenuItem,
            this.kasujHistorieOperacjiToolStripMenuItem});
            this.contextMenuStripHistoriaOperacji.Name = "contextMenuStripHistoriaOperacji";
            this.contextMenuStripHistoriaOperacji.Size = new System.Drawing.Size(198, 70);
            // 
            // wprowadzJakoLiczba1ToolStripMenuItem
            // 
            this.wprowadzJakoLiczba1ToolStripMenuItem.Name = "wprowadzJakoLiczba1ToolStripMenuItem";
            this.wprowadzJakoLiczba1ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.wprowadzJakoLiczba1ToolStripMenuItem.Text = "Wprowadz jako Liczba1";
            this.wprowadzJakoLiczba1ToolStripMenuItem.Click += new System.EventHandler(this.wprowadzJakoLiczba1ToolStripMenuItem_Click);
            // 
            // wprowadzJakoLiczba2ToolStripMenuItem
            // 
            this.wprowadzJakoLiczba2ToolStripMenuItem.Name = "wprowadzJakoLiczba2ToolStripMenuItem";
            this.wprowadzJakoLiczba2ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.wprowadzJakoLiczba2ToolStripMenuItem.Text = "Wprowadz jako Liczba2";
            this.wprowadzJakoLiczba2ToolStripMenuItem.Click += new System.EventHandler(this.wprowadzJakoLiczba2ToolStripMenuItem_Click);
            // 
            // kasujHistorieOperacjiToolStripMenuItem
            // 
            this.kasujHistorieOperacjiToolStripMenuItem.Name = "kasujHistorieOperacjiToolStripMenuItem";
            this.kasujHistorieOperacjiToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.kasujHistorieOperacjiToolStripMenuItem.Text = "Kasuj historie operacji";
            this.kasujHistorieOperacjiToolStripMenuItem.Click += new System.EventHandler(this.kasujHistorieOperacjiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonKasujHistorieOperacji);
            this.Controls.Add(this.buttonZapiszJakoLIczba2);
            this.Controls.Add(this.buttonZapiszJakoLiczba1);
            this.Controls.Add(this.richTextBoxHistoria);
            this.Controls.Add(this.buttonOblicz);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.contextMenuStripWynik.ResumeLayout(false);
            this.contextMenuStripHistoriaOperacji.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxWynik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonDzielenie;
        private System.Windows.Forms.RadioButton radioButtonMnozenie;
        private System.Windows.Forms.RadioButton radioButtonOdejmowanie;
        private System.Windows.Forms.RadioButton radioButtonDodawanie;
        private System.Windows.Forms.Button buttonOblicz;
        private System.Windows.Forms.RichTextBox richTextBoxHistoria;
        private System.Windows.Forms.Button buttonZapiszJakoLiczba1;
        private System.Windows.Forms.Button buttonZapiszJakoLIczba2;
        private System.Windows.Forms.Button buttonKasujHistorieOperacji;
        private System.Windows.Forms.TextBox textBoxLIczba1;
        private System.Windows.Forms.TextBox textBoxLiczba2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label komunikatLiczba1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label komunikatLiczba2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripWynik;
        private System.Windows.Forms.ToolStripMenuItem dodawanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odejmowanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnozenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dzielenieToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripHistoriaOperacji;
        private System.Windows.Forms.ToolStripMenuItem wprowadzJakoLiczba1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wprowadzJakoLiczba2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kasujHistorieOperacjiToolStripMenuItem;
    }
}

