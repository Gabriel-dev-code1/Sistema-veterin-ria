
namespace WindowsFormsApp1
{
    partial class Cadastro_log
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtnomeCadLog = new System.Windows.Forms.TextBox();
            this.txtSenhaCadLog = new System.Windows.Forms.TextBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Crie uma senha:";
            // 
            // txtnomeCadLog
            // 
            this.txtnomeCadLog.Location = new System.Drawing.Point(121, 46);
            this.txtnomeCadLog.Name = "txtnomeCadLog";
            this.txtnomeCadLog.Size = new System.Drawing.Size(197, 20);
            this.txtnomeCadLog.TabIndex = 2;
            // 
            // txtSenhaCadLog
            // 
            this.txtSenhaCadLog.Location = new System.Drawing.Point(121, 78);
            this.txtSenhaCadLog.Name = "txtSenhaCadLog";
            this.txtSenhaCadLog.Size = new System.Drawing.Size(197, 20);
            this.txtSenhaCadLog.TabIndex = 3;
            // 
            // btnCad
            // 
            this.btnCad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad.Location = new System.Drawing.Point(181, 104);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(84, 34);
            this.btnCad.TabIndex = 4;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Crie seu login de acesso";
            // 
            // Cadastro_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 168);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.txtSenhaCadLog);
            this.Controls.Add(this.txtnomeCadLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro_log";
            this.Text = "Cadastro_log";
            this.Load += new System.EventHandler(this.Cadastro_log_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnomeCadLog;
        private System.Windows.Forms.TextBox txtSenhaCadLog;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Label label3;
    }
}