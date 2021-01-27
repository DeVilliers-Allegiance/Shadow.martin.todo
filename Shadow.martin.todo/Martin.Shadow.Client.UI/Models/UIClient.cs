using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shadow.martin.client.ui.todo.Models
{
    public class UIClient
    {
        private UIClient()
        {
            cboxs = new List<CBox>
            {
                new CBox(0, false, "read my first to do.")
            };
        }
        public int clientId { get; private set; }
        public string firstName { get; private set; }

        public List<CBox> cboxs = new List<CBox>();
        public UIClient(int clId, List<CBox> cBoxes)
        {
            this.firstName = "Tom";
            this.clientId = clId;
            this.cboxs = cBoxes;
        }
        public UIClient(int clId)
        {
            this.firstName = "Tom";
            this.clientId = clId;
            this.cboxs = new List<CBox>
            {
                new CBox(0, false, "read my first to do.")
            };
        }
    }
}
