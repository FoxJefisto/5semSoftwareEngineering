
namespace laba3
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.lbN = new System.Windows.Forms.Label();
            this.lbM = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.lbC = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lbAnswer = new System.Windows.Forms.Label();
            this.Grid2 = new System.Windows.Forms.DataGridView();
            this.lbCondition = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(76, 109);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(125, 27);
            this.txtN.TabIndex = 0;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(282, 109);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(125, 27);
            this.txtM.TabIndex = 1;
            this.txtM.TextChanged += new System.EventHandler(this.txtM_TextChanged);
            // 
            // lbN
            // 
            this.lbN.AutoSize = true;
            this.lbN.Location = new System.Drawing.Point(35, 112);
            this.lbN.Name = "lbN";
            this.lbN.Size = new System.Drawing.Size(35, 20);
            this.lbN.TabIndex = 2;
            this.lbN.Text = "n = ";
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.Location = new System.Drawing.Point(236, 112);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(40, 20);
            this.lbM.TabIndex = 3;
            this.lbM.Text = "m = ";
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(465, 109);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(120, 34);
            this.btnSolve.TabIndex = 4;
            this.btnSolve.Text = "Решить задачу";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // Grid1
            // 
            this.Grid1.AllowUserToAddRows = false;
            this.Grid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.ColumnHeadersVisible = false;
            this.Grid1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Grid1.Location = new System.Drawing.Point(35, 213);
            this.Grid1.Name = "Grid1";
            this.Grid1.RowHeadersVisible = false;
            this.Grid1.RowHeadersWidth = 51;
            this.Grid1.RowTemplate.Height = 29;
            this.Grid1.Size = new System.Drawing.Size(427, 286);
            this.Grid1.TabIndex = 5;
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Location = new System.Drawing.Point(35, 158);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(30, 20);
            this.lbC.TabIndex = 6;
            this.lbC.Text = "c =";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(76, 155);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(125, 27);
            this.txtC.TabIndex = 7;
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.Location = new System.Drawing.Point(715, 116);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(0, 20);
            this.lbAnswer.TabIndex = 8;
            // 
            // Grid2
            // 
            this.Grid2.AllowUserToAddRows = false;
            this.Grid2.AllowUserToDeleteRows = false;
            this.Grid2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid2.ColumnHeadersVisible = false;
            this.Grid2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Grid2.Location = new System.Drawing.Point(583, 213);
            this.Grid2.Name = "Grid2";
            this.Grid2.ReadOnly = true;
            this.Grid2.RowHeadersVisible = false;
            this.Grid2.RowHeadersWidth = 51;
            this.Grid2.RowTemplate.Height = 29;
            this.Grid2.Size = new System.Drawing.Size(425, 286);
            this.Grid2.TabIndex = 9;
            // 
            // lbCondition
            // 
            this.lbCondition.AutoSize = true;
            this.lbCondition.Location = new System.Drawing.Point(282, 31);
            this.lbCondition.Name = "lbCondition";
            this.lbCondition.Size = new System.Drawing.Size(67, 20);
            this.lbCondition.TabIndex = 10;
            this.lbCondition.Text = "Условие";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 511);
            this.Controls.Add(this.lbCondition);
            this.Controls.Add(this.Grid2);
            this.Controls.Add(this.lbAnswer);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.Grid1);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.lbM);
            this.Controls.Add(this.lbN);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtN);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label lbN;
        private System.Windows.Forms.Label lbM;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lbAnswer;
        private System.Windows.Forms.DataGridView Grid2;
        private System.Windows.Forms.Label lbCondition;
    }
}

