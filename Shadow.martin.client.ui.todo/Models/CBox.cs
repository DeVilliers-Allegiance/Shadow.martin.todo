using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shadow.martin.client.ui.todo.Models
{
    public partial class CBox
    {
        private CBox()
        {

        }
        public int cBoxID { get; set; }
        public bool ticked { get; private set; }
        public string cBoxName { get; private set; }
        public CBox(int boxId, bool tick, string cName)
        {
            this.cBoxID = boxId;
            this.cBoxName = cName;
            this.ticked = tick;
        }
    }
}
