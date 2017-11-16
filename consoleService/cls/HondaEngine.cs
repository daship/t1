using consoleService.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleService.cls
{
    public class HondaEngine : iEngine
    {
        public string StartEngine()
        {
            return "Honda Engine starts";
        }
    }
}
