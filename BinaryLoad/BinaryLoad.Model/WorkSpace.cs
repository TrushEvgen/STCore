using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryLoad.Model
{
    public class WorkSpace
    {
        public int WID { get; set; }

        public int ParentWID { get; set; }

        public string Name { get; set; }

        public string  Description { get; set; }

        public string Diagrams { get; set; }

        public string Autors { get; set; }
    }
}
