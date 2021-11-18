
namespace laba4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWork = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInput = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSolve = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileHor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileVert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuWork,
            this.menuHelp,
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 24);
            this.menuFile.Text = "File";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(116, 26);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuWork
            // 
            this.menuWork.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDialog,
            this.menuInput,
            this.menuSolve});
            this.menuWork.Name = "menuWork";
            this.menuWork.Size = new System.Drawing.Size(57, 24);
            this.menuWork.Text = "Work";
            // 
            // menuDialog
            // 
            this.menuDialog.Name = "menuDialog";
            this.menuDialog.Size = new System.Drawing.Size(137, 26);
            this.menuDialog.Text = "Dialog";
            this.menuDialog.Click += new System.EventHandler(this.menuDialog_Click);
            // 
            // menuInput
            // 
            this.menuInput.Name = "menuInput";
            this.menuInput.Size = new System.Drawing.Size(137, 26);
            this.menuInput.Text = "Input";
            this.menuInput.Click += new System.EventHandler(this.menuInput_Click);
            // 
            // menuSolve
            // 
            this.menuSolve.Name = "menuSolve";
            this.menuSolve.Size = new System.Drawing.Size(137, 26);
            this.menuSolve.Text = "Solve";
            this.menuSolve.Click += new System.EventHandler(this.menuSolve_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(55, 24);
            this.menuHelp.Text = "Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(224, 26);
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTileHor,
            this.menuTileVert,
            this.menuCascade,
            this.menuCloseCurrent,
            this.menuCloseAll});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // menuTileHor
            // 
            this.menuTileHor.Name = "menuTileHor";
            this.menuTileHor.Size = new System.Drawing.Size(224, 26);
            this.menuTileHor.Text = "TileHor";
            this.menuTileHor.Click += new System.EventHandler(this.menuTileHor_Click);
            // 
            // menuTileVert
            // 
            this.menuTileVert.Name = "menuTileVert";
            this.menuTileVert.Size = new System.Drawing.Size(224, 26);
            this.menuTileVert.Text = "TileVert";
            this.menuTileVert.Click += new System.EventHandler(this.menuTileVert_Click);
            // 
            // menuCascade
            // 
            this.menuCascade.Name = "menuCascade";
            this.menuCascade.Size = new System.Drawing.Size(224, 26);
            this.menuCascade.Text = "Cascase";
            this.menuCascade.Click += new System.EventHandler(this.menuCascade_Click);
            // 
            // menuCloseCurrent
            // 
            this.menuCloseCurrent.Name = "menuCloseCurrent";
            this.menuCloseCurrent.Size = new System.Drawing.Size(224, 26);
            this.menuCloseCurrent.Text = "CloseCurrent";
            this.menuCloseCurrent.Click += new System.EventHandler(this.menuCloseCurrent_Click);
            // 
            // menuCloseAll
            // 
            this.menuCloseAll.Name = "menuCloseAll";
            this.menuCloseAll.Size = new System.Drawing.Size(224, 26);
            this.menuCloseAll.Text = "CloseAll";
            this.menuCloseAll.Click += new System.EventHandler(this.menuCloseAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuWork;
        public System.Windows.Forms.ToolStripMenuItem menuDialog;
        public System.Windows.Forms.ToolStripMenuItem menuInput;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSolve;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuTileHor;
        private System.Windows.Forms.ToolStripMenuItem menuTileVert;
        private System.Windows.Forms.ToolStripMenuItem menuCascade;
        private System.Windows.Forms.ToolStripMenuItem menuCloseCurrent;
        private System.Windows.Forms.ToolStripMenuItem menuCloseAll;
    }
}

