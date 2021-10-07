
namespace laba4
{
    partial class FormInput
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
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.lbN = new System.Windows.Forms.Label();
            this.lbM = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid1
            // 
            this.Grid1.AllowUserToAddRows = false;
            this.Grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.ColumnHeadersVisible = false;
            this.Grid1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Grid1.Location = new System.Drawing.Point(24, 93);
            this.Grid1.Name = "Grid1";
            this.Grid1.RowHeadersVisible = false;
            this.Grid1.RowHeadersWidth = 51;
            this.Grid1.RowTemplate.Height = 24;
            this.Grid1.Size = new System.Drawing.Size(463, 326);
            this.Grid1.TabIndex = 0;
            // 
            // lbN
            // 
            this.lbN.AutoSize = true;
            this.lbN.Location = new System.Drawing.Point(21, 46);
            this.lbN.Name = "lbN";
            this.lbN.Size = new System.Drawing.Size(32, 17);
            this.lbN.TabIndex = 1;
            this.lbN.Text = "n = ";
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.Location = new System.Drawing.Point(213, 46);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(31, 17);
            this.lbM.TabIndex = 2;
            this.lbM.Text = "m =";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(59, 41);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(122, 22);
            this.txtN.TabIndex = 3;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(250, 41);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(122, 22);
            this.txtM.TabIndex = 4;
            this.txtM.TextChanged += new System.EventHandler(this.txtM_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(570, 389);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(113, 49);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lbM);
            this.Controls.Add(this.lbN);
            this.Controls.Add(this.Grid1);
            this.Name = "FormInput";
            this.Text = "FormInput";
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.Label lbN;
        private System.Windows.Forms.Label lbM;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Button btnOk;
    }
}