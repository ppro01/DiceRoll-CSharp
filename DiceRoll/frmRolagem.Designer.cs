namespace DiceRoll
{
    partial class frmRolagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRolagem));
            this.btnD20 = new System.Windows.Forms.Button();
            this.btnD12 = new System.Windows.Forms.Button();
            this.btnD100 = new System.Windows.Forms.Button();
            this.btnD10 = new System.Windows.Forms.Button();
            this.btnD8 = new System.Windows.Forms.Button();
            this.btnD6 = new System.Windows.Forms.Button();
            this.btnD4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numQntDad = new System.Windows.Forms.NumericUpDown();
            this.numSoma = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chkPior = new System.Windows.Forms.CheckBox();
            this.chkSoma = new System.Windows.Forms.CheckBox();
            this.gbFuncoes = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numQntDad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoma)).BeginInit();
            this.gbFuncoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnD20
            // 
            this.btnD20.BackColor = System.Drawing.SystemColors.Control;
            this.btnD20.BackgroundImage = global::DiceRoll.Properties.Resources.dice_d20_icon_138684;
            this.btnD20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnD20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnD20.FlatAppearance.BorderSize = 0;
            this.btnD20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD20.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.btnD20.ForeColor = System.Drawing.Color.Transparent;
            this.btnD20.Location = new System.Drawing.Point(225, 170);
            this.btnD20.Name = "btnD20";
            this.btnD20.Size = new System.Drawing.Size(80, 80);
            this.btnD20.TabIndex = 6;
            this.btnD20.Text = "20";
            this.btnD20.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnD20.UseVisualStyleBackColor = false;
            this.btnD20.Click += new System.EventHandler(this.DiceSelect_Click);
            // 
            // btnD12
            // 
            this.btnD12.BackColor = System.Drawing.SystemColors.Control;
            this.btnD12.BackgroundImage = global::DiceRoll.Properties.Resources.dice_d12_icon_138685;
            this.btnD12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnD12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnD12.FlatAppearance.BorderSize = 0;
            this.btnD12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD12.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.25F);
            this.btnD12.ForeColor = System.Drawing.Color.Transparent;
            this.btnD12.Location = new System.Drawing.Point(121, 170);
            this.btnD12.Name = "btnD12";
            this.btnD12.Size = new System.Drawing.Size(80, 80);
            this.btnD12.TabIndex = 5;
            this.btnD12.Text = "12";
            this.btnD12.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnD12.UseVisualStyleBackColor = false;
            this.btnD12.Click += new System.EventHandler(this.DiceSelect_Click);
            // 
            // btnD100
            // 
            this.btnD100.BackColor = System.Drawing.SystemColors.Control;
            this.btnD100.BackgroundImage = global::DiceRoll.Properties.Resources.d1001;
            this.btnD100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnD100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnD100.FlatAppearance.BorderSize = 0;
            this.btnD100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD100.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.btnD100.ForeColor = System.Drawing.Color.Transparent;
            this.btnD100.Location = new System.Drawing.Point(17, 170);
            this.btnD100.Name = "btnD100";
            this.btnD100.Size = new System.Drawing.Size(80, 80);
            this.btnD100.TabIndex = 4;
            this.btnD100.Text = "100";
            this.btnD100.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnD100.UseVisualStyleBackColor = false;
            this.btnD100.Click += new System.EventHandler(this.DiceSelect_Click);
            // 
            // btnD10
            // 
            this.btnD10.BackColor = System.Drawing.SystemColors.Control;
            this.btnD10.BackgroundImage = global::DiceRoll.Properties.Resources.dice_d10_icon_138686;
            this.btnD10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnD10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnD10.FlatAppearance.BorderSize = 0;
            this.btnD10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD10.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.25F);
            this.btnD10.ForeColor = System.Drawing.Color.Transparent;
            this.btnD10.Location = new System.Drawing.Point(17, 282);
            this.btnD10.Name = "btnD10";
            this.btnD10.Size = new System.Drawing.Size(80, 80);
            this.btnD10.TabIndex = 3;
            this.btnD10.Text = "10";
            this.btnD10.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnD10.UseVisualStyleBackColor = false;
            this.btnD10.Click += new System.EventHandler(this.DiceSelect_Click);
            // 
            // btnD8
            // 
            this.btnD8.BackColor = System.Drawing.SystemColors.Control;
            this.btnD8.BackgroundImage = global::DiceRoll.Properties.Resources.Pictogrammers_Material_Dice_d8_1024;
            this.btnD8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnD8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnD8.FlatAppearance.BorderSize = 0;
            this.btnD8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD8.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.25F);
            this.btnD8.ForeColor = System.Drawing.Color.Transparent;
            this.btnD8.Location = new System.Drawing.Point(225, 58);
            this.btnD8.Name = "btnD8";
            this.btnD8.Size = new System.Drawing.Size(80, 80);
            this.btnD8.TabIndex = 2;
            this.btnD8.Text = "8";
            this.btnD8.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnD8.UseVisualStyleBackColor = false;
            this.btnD8.Click += new System.EventHandler(this.DiceSelect_Click);
            // 
            // btnD6
            // 
            this.btnD6.BackColor = System.Drawing.SystemColors.Control;
            this.btnD6.BackgroundImage = global::DiceRoll.Properties.Resources.dice_d6_icon_138682;
            this.btnD6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnD6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnD6.FlatAppearance.BorderSize = 0;
            this.btnD6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD6.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.25F);
            this.btnD6.ForeColor = System.Drawing.Color.Black;
            this.btnD6.Location = new System.Drawing.Point(121, 58);
            this.btnD6.Name = "btnD6";
            this.btnD6.Size = new System.Drawing.Size(80, 80);
            this.btnD6.TabIndex = 1;
            this.btnD6.Text = "6";
            this.btnD6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnD6.UseVisualStyleBackColor = false;
            this.btnD6.Click += new System.EventHandler(this.DiceSelect_Click);
            // 
            // btnD4
            // 
            this.btnD4.BackColor = System.Drawing.SystemColors.Control;
            this.btnD4.BackgroundImage = global::DiceRoll.Properties.Resources.dice_d4_icon_138683;
            this.btnD4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnD4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnD4.FlatAppearance.BorderSize = 0;
            this.btnD4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD4.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.25F);
            this.btnD4.ForeColor = System.Drawing.Color.Transparent;
            this.btnD4.Location = new System.Drawing.Point(17, 58);
            this.btnD4.Name = "btnD4";
            this.btnD4.Size = new System.Drawing.Size(80, 80);
            this.btnD4.TabIndex = 0;
            this.btnD4.Text = "4";
            this.btnD4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnD4.UseVisualStyleBackColor = false;
            this.btnD4.Click += new System.EventHandler(this.DiceSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(44, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "D4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(148, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "D6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(252, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "D8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(40, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "D10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(36, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "D100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(144, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "D12";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(248, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "D20";
            // 
            // numQntDad
            // 
            this.numQntDad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQntDad.Location = new System.Drawing.Point(358, 120);
            this.numQntDad.Name = "numQntDad";
            this.numQntDad.Size = new System.Drawing.Size(120, 38);
            this.numQntDad.TabIndex = 16;
            this.numQntDad.ValueChanged += new System.EventHandler(this.numQntDad_ValueChanged);
            this.numQntDad.Validating += new System.ComponentModel.CancelEventHandler(this.numQntDad_Validating);
            this.numQntDad.Validated += new System.EventHandler(this.numQntDad_Validated);
            // 
            // numSoma
            // 
            this.numSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoma.Location = new System.Drawing.Point(572, 120);
            this.numSoma.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numSoma.Name = "numSoma";
            this.numSoma.Size = new System.Drawing.Size(120, 38);
            this.numSoma.TabIndex = 17;
            this.numSoma.ValueChanged += new System.EventHandler(this.numQntDad_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(333, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Número de Dados:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(542, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Soma no Resultado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(246, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Selecione o dado para rolar";
            // 
            // chkPior
            // 
            this.chkPior.AutoSize = true;
            this.chkPior.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPior.ForeColor = System.Drawing.Color.Transparent;
            this.chkPior.Location = new System.Drawing.Point(9, 99);
            this.chkPior.Name = "chkPior";
            this.chkPior.Size = new System.Drawing.Size(177, 28);
            this.chkPior.TabIndex = 21;
            this.chkPior.Text = "Pegar o pior valor";
            this.chkPior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPior.UseVisualStyleBackColor = true;
            // 
            // chkSoma
            // 
            this.chkSoma.AutoSize = true;
            this.chkSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSoma.ForeColor = System.Drawing.Color.Transparent;
            this.chkSoma.Location = new System.Drawing.Point(9, 38);
            this.chkSoma.Name = "chkSoma";
            this.chkSoma.Size = new System.Drawing.Size(191, 28);
            this.chkSoma.TabIndex = 22;
            this.chkSoma.Text = "Somar as rolagens ";
            this.chkSoma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSoma.UseVisualStyleBackColor = true;
            // 
            // gbFuncoes
            // 
            this.gbFuncoes.BackColor = System.Drawing.Color.SteelBlue;
            this.gbFuncoes.Controls.Add(this.chkSoma);
            this.gbFuncoes.Controls.Add(this.chkPior);
            this.gbFuncoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbFuncoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFuncoes.ForeColor = System.Drawing.SystemColors.Control;
            this.gbFuncoes.Location = new System.Drawing.Point(426, 244);
            this.gbFuncoes.Name = "gbFuncoes";
            this.gbFuncoes.Size = new System.Drawing.Size(236, 155);
            this.gbFuncoes.TabIndex = 23;
            this.gbFuncoes.TabStop = false;
            this.gbFuncoes.Text = "Outras opções";
            // 
            // frmRolagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.gbFuncoes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numSoma);
            this.Controls.Add(this.numQntDad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnD20);
            this.Controls.Add(this.btnD12);
            this.Controls.Add(this.btnD100);
            this.Controls.Add(this.btnD10);
            this.Controls.Add(this.btnD8);
            this.Controls.Add(this.btnD6);
            this.Controls.Add(this.btnD4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRolagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rolar Dados";
            ((System.ComponentModel.ISupportInitialize)(this.numQntDad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoma)).EndInit();
            this.gbFuncoes.ResumeLayout(false);
            this.gbFuncoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnD4;
        private System.Windows.Forms.Button btnD6;
        private System.Windows.Forms.Button btnD8;
        private System.Windows.Forms.Button btnD10;
        private System.Windows.Forms.Button btnD100;
        private System.Windows.Forms.Button btnD12;
        private System.Windows.Forms.Button btnD20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numQntDad;
        private System.Windows.Forms.NumericUpDown numSoma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkPior;
        private System.Windows.Forms.CheckBox chkSoma;
        private System.Windows.Forms.GroupBox gbFuncoes;
    }
}