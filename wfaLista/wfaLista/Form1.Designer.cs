namespace wfaLista
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNRO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLISTA = new System.Windows.Forms.TextBox();
            this.buttonInsereFIM = new System.Windows.Forms.Button();
            this.buttonIMPRIMIR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonOK_Remove = new System.Windows.Forms.Button();
            this.buttonLIMPAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // textBoxNRO
            // 
            this.textBoxNRO.Location = new System.Drawing.Point(172, 62);
            this.textBoxNRO.Name = "textBoxNRO";
            this.textBoxNRO.Size = new System.Drawing.Size(125, 31);
            this.textBoxNRO.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lista: ";
            // 
            // textBoxLISTA
            // 
            this.textBoxLISTA.Location = new System.Drawing.Point(172, 141);
            this.textBoxLISTA.Name = "textBoxLISTA";
            this.textBoxLISTA.Size = new System.Drawing.Size(841, 31);
            this.textBoxLISTA.TabIndex = 3;
            // 
            // buttonInsereFIM
            // 
            this.buttonInsereFIM.Location = new System.Drawing.Point(69, 284);
            this.buttonInsereFIM.Name = "buttonInsereFIM";
            this.buttonInsereFIM.Size = new System.Drawing.Size(159, 42);
            this.buttonInsereFIM.TabIndex = 4;
            this.buttonInsereFIM.Text = "Insere FIM";
            this.buttonInsereFIM.UseVisualStyleBackColor = true;
            this.buttonInsereFIM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonInsereFIM_MouseClick);
            // 
            // buttonIMPRIMIR
            // 
            this.buttonIMPRIMIR.Location = new System.Drawing.Point(811, 283);
            this.buttonIMPRIMIR.Name = "buttonIMPRIMIR";
            this.buttonIMPRIMIR.Size = new System.Drawing.Size(151, 41);
            this.buttonIMPRIMIR.TabIndex = 5;
            this.buttonIMPRIMIR.Text = "IMPRIMIR";
            this.buttonIMPRIMIR.UseVisualStyleBackColor = true;
            this.buttonIMPRIMIR.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonIMPRIMIR_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Insere INICIO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // buttonOK_Remove
            // 
            this.buttonOK_Remove.Location = new System.Drawing.Point(697, 285);
            this.buttonOK_Remove.Name = "buttonOK_Remove";
            this.buttonOK_Remove.Size = new System.Drawing.Size(75, 40);
            this.buttonOK_Remove.TabIndex = 8;
            this.buttonOK_Remove.Text = "OK";
            this.buttonOK_Remove.UseVisualStyleBackColor = true;
            this.buttonOK_Remove.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonOK_Remove_MouseClick);
            // 
            // buttonLIMPAR
            // 
            this.buttonLIMPAR.Location = new System.Drawing.Point(995, 284);
            this.buttonLIMPAR.Name = "buttonLIMPAR";
            this.buttonLIMPAR.Size = new System.Drawing.Size(113, 40);
            this.buttonLIMPAR.TabIndex = 9;
            this.buttonLIMPAR.Text = "LIMPAR";
            this.buttonLIMPAR.UseVisualStyleBackColor = true;
            this.buttonLIMPAR.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonLIMPAR_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 677);
            this.Controls.Add(this.buttonLIMPAR);
            this.Controls.Add(this.buttonOK_Remove);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonIMPRIMIR);
            this.Controls.Add(this.buttonInsereFIM);
            this.Controls.Add(this.textBoxLISTA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNRO);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lista Encadeada";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNRO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLISTA;
        private System.Windows.Forms.Button buttonInsereFIM;
        private System.Windows.Forms.Button buttonIMPRIMIR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonOK_Remove;
        private System.Windows.Forms.Button buttonLIMPAR;
    }
}

