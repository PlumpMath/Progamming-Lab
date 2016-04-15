using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Progamming.Resource
{
    public class Sprite : Resource
    {
        Image image;
        public Sprite()
        {
            this.ResourceType = ResourceType.SPRITE;
        }

        public void SetImage(Bitmap img)
        {
            this.image = img;
        }
    }
}
