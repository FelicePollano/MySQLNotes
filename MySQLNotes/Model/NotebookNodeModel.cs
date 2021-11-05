using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLNotes.Model
{
    public class NotebookNodeModel
    {
        public string  Name { get; set; }
        public int Id { get; set; }

        public bool IsFolder { get; set; }

    }
}
