using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void tvResources_DoubleClick(object sender, EventArgs e)
        {
            switch(tvResources.SelectedNode.Text) // 이걸 Parent 노드를 계산 하는 걸로
            {
                case "Sprites":
                    this.resourcePropertyGrid.ChangeResource(ResourceType.SPRITE);
                    break;
                case "Sounds":
                    this.resourcePropertyGrid.ChangeResource(ResourceType.SOUND);
                    break;
                case "Fonts":
                    this.resourcePropertyGrid.ChangeResource(ResourceType.FONT);
                    break;
                case "Scripts":
                    this.resourcePropertyGrid.ChangeResource(ResourceType.SCRIPT);
                    break;
                case "Scenes":
                    this.resourcePropertyGrid.ChangeResource(ResourceType.SCENE);
                    break;
            }
        }
    }
}
 