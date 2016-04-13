namespace Progamming
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Sprites");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Sounds");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Fonts");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Scripts");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Scenes");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Resources", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tvResources = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resourcePropertyGrid = new Progamming.PropertyUserControl.ResourcePropertyGrid();
            this.mainMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.resourcesToolStripMenuItem,
            this.scriptsToolStripMenuItem,
            this.runToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(786, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // resourcesToolStripMenuItem
            // 
            this.resourcesToolStripMenuItem.Name = "resourcesToolStripMenuItem";
            this.resourcesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.resourcesToolStripMenuItem.Text = "&Resources";
            // 
            // scriptsToolStripMenuItem
            // 
            this.scriptsToolStripMenuItem.Name = "scriptsToolStripMenuItem";
            this.scriptsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.scriptsToolStripMenuItem.Text = "&Scripts";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "&Run";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "&Window";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // tvResources
            // 
            this.tvResources.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvResources.Location = new System.Drawing.Point(0, 24);
            this.tvResources.Name = "tvResources";
            treeNode1.Name = "nodeSprites";
            treeNode1.Text = "Sprites";
            treeNode2.Name = "nodeSounds";
            treeNode2.Text = "Sounds";
            treeNode3.Name = "nodeFonts";
            treeNode3.Text = "Fonts";
            treeNode4.Name = "nodeScript";
            treeNode4.Text = "Scripts";
            treeNode5.Name = "nodeScenes";
            treeNode5.Text = "Scenes";
            treeNode6.Name = "nodeResources";
            treeNode6.Text = "Resources";
            this.tvResources.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.tvResources.Size = new System.Drawing.Size(158, 403);
            this.tvResources.TabIndex = 2;
            this.tvResources.DoubleClick += new System.EventHandler(this.tvResources_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resourcePropertyGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(158, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 403);
            this.panel1.TabIndex = 3;
            // 
            // resourcePropertyGrid
            // 
            this.resourcePropertyGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.resourcePropertyGrid.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.resourcePropertyGrid.Location = new System.Drawing.Point(446, 0);
            this.resourcePropertyGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resourcePropertyGrid.Name = "resourcePropertyGrid";
            this.resourcePropertyGrid.Size = new System.Drawing.Size(182, 403);
            this.resourcePropertyGrid.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 427);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tvResources);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Progamming";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.TreeView tvResources;
        private System.Windows.Forms.Panel panel1;
        private PropertyUserControl.ResourcePropertyGrid resourcePropertyGrid;
    }
}

