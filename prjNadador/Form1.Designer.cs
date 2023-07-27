namespace prjNadador
{
    partial class frmNadador
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb60 = new System.Windows.Forms.RadioButton();
            this.rb59 = new System.Windows.Forms.RadioButton();
            this.rb17 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnTotais = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(103, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(204, 16);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(296, 34);
            this.txtNome.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rb60);
            this.groupBox1.Controls.Add(this.rb59);
            this.groupBox1.Controls.Add(this.rb17);
            this.groupBox1.Controls.Add(this.rb10);
            this.groupBox1.Location = new System.Drawing.Point(108, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(381, 235);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione uma opção";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rb60
            // 
            this.rb60.AutoSize = true;
            this.rb60.Location = new System.Drawing.Point(84, 162);
            this.rb60.Margin = new System.Windows.Forms.Padding(4);
            this.rb60.Name = "rb60";
            this.rb60.Size = new System.Drawing.Size(201, 31);
            this.rb60.TabIndex = 3;
            this.rb60.TabStop = true;
            this.rb60.Text = "60 anos ou mais";
            this.rb60.UseVisualStyleBackColor = true;
            // 
            // rb59
            // 
            this.rb59.AutoSize = true;
            this.rb59.Location = new System.Drawing.Point(84, 123);
            this.rb59.Margin = new System.Windows.Forms.Padding(4);
            this.rb59.Name = "rb59";
            this.rb59.Size = new System.Drawing.Size(198, 31);
            this.rb59.TabIndex = 2;
            this.rb59.TabStop = true;
            this.rb59.Text = "De 18 a 59 anos";
            this.rb59.UseVisualStyleBackColor = true;
            // 
            // rb17
            // 
            this.rb17.AutoSize = true;
            this.rb17.Location = new System.Drawing.Point(84, 85);
            this.rb17.Margin = new System.Windows.Forms.Padding(4);
            this.rb17.Name = "rb17";
            this.rb17.Size = new System.Drawing.Size(198, 31);
            this.rb17.TabIndex = 1;
            this.rb17.TabStop = true;
            this.rb17.Text = "De 11 a 17 anos";
            this.rb17.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Location = new System.Drawing.Point(84, 46);
            this.rb10.Margin = new System.Windows.Forms.Padding(4);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(185, 31);
            this.rb10.TabIndex = 0;
            this.rb10.TabStop = true;
            this.rb10.Text = "De 0 a 10 anos";
            this.rb10.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(108, 323);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(108, 35);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(247, 323);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 35);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(247, 394);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 34);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnTotais
            // 
            this.btnTotais.Location = new System.Drawing.Point(381, 323);
            this.btnTotais.Margin = new System.Windows.Forms.Padding(4);
            this.btnTotais.Name = "btnTotais";
            this.btnTotais.Size = new System.Drawing.Size(108, 35);
            this.btnTotais.TabIndex = 6;
            this.btnTotais.Text = "Totais";
            this.btnTotais.UseVisualStyleBackColor = true;
            this.btnTotais.Click += new System.EventHandler(this.btnTotais_Click);
            // 
            // frmNadador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::prjNadador.Properties.Resources.nadante;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(615, 542);
            this.ControlBox = false;
            this.Controls.Add(this.btnTotais);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmNadador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classificação de Nadadores";
            this.Load += new System.EventHandler(this.frmNadador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb60;
        private System.Windows.Forms.RadioButton rb59;
        private System.Windows.Forms.RadioButton rb17;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnTotais;
    }
}

