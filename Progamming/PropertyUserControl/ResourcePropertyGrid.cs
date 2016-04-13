using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progamming.PropertyUserControl
{
    public partial class ResourcePropertyGrid : UserControl
    {
        SpriteProperty spriteProperty = new SpriteProperty();
        SoundProperty soundProperty = new SoundProperty();
        FontProperty fontProperty = new FontProperty();
        ScriptProperty scriptProperty = new ScriptProperty();
        SceneProperty sceneProperty = new SceneProperty();

        public ResourcePropertyGrid()
        {
            InitializeComponent();
            InitResourceProperty();
        }

        private void InitResourceProperty()
        {
            this.spriteProperty.Parent =
                this.soundProperty.Parent =
                this.fontProperty.Parent =
                this.scriptProperty.Parent =
                this.sceneProperty.Parent = this.pnPropertyForm;

            this.spriteProperty.Dock = 
                this.soundProperty.Dock = 
                this.fontProperty.Dock = 
                this.scriptProperty.Dock = 
                this.sceneProperty.Dock = DockStyle.Fill;

            ShowResourceProperty(ResourceType.SPRITE);
        }

        private void ShowResourceProperty(ResourceType type)
        {
            this.spriteProperty.Hide();
            this.soundProperty.Hide();
            this.fontProperty.Hide();
            this.scriptProperty.Hide();
            this.sceneProperty.Hide();

            switch(type)
            {
                case ResourceType.SPRITE:
                    this.spriteProperty.Show();
                    break;
                case ResourceType.SOUND:
                    this.soundProperty.Show();
                    break;
                case ResourceType.FONT:
                    this.fontProperty.Show();
                    break;
                case ResourceType.SCRIPT:
                    this.scriptProperty.Show();
                    break;
                case ResourceType.SCENE:
                    this.sceneProperty.Show();
                    break;
            }
        }

        public void ChangeResource(ResourceType type)
        {
            ShowResourceProperty(type);
        }
    }
}
