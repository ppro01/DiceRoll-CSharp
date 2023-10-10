namespace DiceRoll
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIniciativa = new System.Windows.Forms.Button();
            this.btnRolagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(153, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione uma função:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(482, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Listar Iniciativa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(132, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rolar Dados";
            // 
            // btnIniciativa
            // 
            this.btnIniciativa.BackColor = System.Drawing.SystemColors.Control;
            this.btnIniciativa.BackgroundImage = global::DiceRoll.Properties.Resources.silhueta_do_corredor_correndo_rapido;
            this.btnIniciativa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciativa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciativa.FlatAppearance.BorderSize = 0;
            this.btnIniciativa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciativa.Location = new System.Drawing.Point(446, 119);
            this.btnIniciativa.Name = "btnIniciativa";
            this.btnIniciativa.Size = new System.Drawing.Size(200, 200);
            this.btnIniciativa.TabIndex = 2;
            this.btnIniciativa.UseVisualStyleBackColor = false;
            this.btnIniciativa.Click += new System.EventHandler(this.btnIniciativa_Click);
            // 
            // btnRolagem
            // 
            this.btnRolagem.BackColor = System.Drawing.SystemColors.Control;
            this.btnRolagem.BackgroundImage = global::DiceRoll.Properties.Resources.perspective_dice_six_faces_six_38558;
            this.btnRolagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRolagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRolagem.FlatAppearance.BorderSize = 0;
            this.btnRolagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolagem.Location = new System.Drawing.Point(88, 119);
            this.btnRolagem.Name = "btnRolagem";
            this.btnRolagem.Size = new System.Drawing.Size(200, 200);
            this.btnRolagem.TabIndex = 1;
            this.btnRolagem.UseVisualStyleBackColor = false;
            this.btnRolagem.Click += new System.EventHandler(this.btnRolagem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIniciativa);
            this.Controls.Add(this.btnRolagem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRolagem;
        private System.Windows.Forms.Button btnIniciativa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

