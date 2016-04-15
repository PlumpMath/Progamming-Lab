using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progamming.Resource
{
    public enum ResourceType
    {
        NONE, SPRITE, SOUND, FONT, SCRIPT, SCENE
    }

    public class Resource
    {
        public ResourceType ResourceType;
    }
}
