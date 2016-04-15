using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Progamming.Resource;

namespace Progamming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //SetLanguage(Language.ENG);
        }

        public void SetLanguage(Language lang)
        {
            #region mainMenuStrip
            fileToolStripMenuItem.Text = lang == Language.ENG ? ResourceGUI.TEXT_MENUSTRIP_FILE_ENG : ResourceGUI.TEXT_MENUSTRIP_FILE_KOR;
            editToolStripMenuItem.Text = lang == Language.ENG ? ResourceGUI.TEXT_MENUSTRIP_EDIT_ENG : ResourceGUI.TEXT_MENUSTRIP_EDIT_KOR;
            resourcesToolStripMenuItem.Text = lang == Language.ENG ? ResourceGUI.TEXT_MENUSTRIP_RESOURCES_ENG : ResourceGUI.TEXT_MENUSTRIP_RESOURCES_KOR;
            scriptsToolStripMenuItem.Text = lang == Language.ENG ? ResourceGUI.TEXT_MENUSTRIP_SCRIPTS_ENG : ResourceGUI.TEXT_MENUSTRIP_SCRIPTS_KOR;
            runToolStripMenuItem.Text = lang == Language.ENG ? ResourceGUI.TEXT_MENUSTRIP_RUN_ENG : ResourceGUI.TEXT_MENUSTRIP_RUN_KOR;
            windowToolStripMenuItem.Text = lang == Language.ENG ? ResourceGUI.TEXT_MENUSTRIP_WINDOW_ENG : ResourceGUI.TEXT_MENUSTRIP_WINDOW_KOR;
            helpToolStripMenuItem.Text = lang == Language.ENG ? ResourceGUI.TEXT_MENUSTRIP_HELP_ENG : ResourceGUI.TEXT_MENUSTRIP_HELP_KOR;
            #endregion
        }

        private ResourceType ResourceTypeFromNode(TreeNode node)
        {
            TreeNode temp = node;
            if (temp.Parent != null)
                while (temp.FirstNode != temp.Parent.Parent)
                {
                    temp = temp.Parent;
                }
            

            switch (temp.Text)
            {
                case "Sprites":
                    return ResourceType.SPRITE;
                case "Sounds":
                    return ResourceType.SOUND;
                case "Fonts":
                    return ResourceType.FONT;
                case "Scripts":
                    return ResourceType.SCRIPT;
                case "Scenes":
                    return ResourceType.SCENE;
            }

            throw new Exception("No such that node");
        }

        private void tvResources_DoubleClick(object sender, EventArgs e)
        {
            this.resourcePropertyGrid.ChangeResource(ResourceTypeFromNode(this.tvResources.SelectedNode));
        }

        private void tvResources_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                
            }
        }

        private void showForm(Form form)
        {
            form.Parent = this.pForms;
            form.TopLevel = false;
            form.Show();
        }
    }
}