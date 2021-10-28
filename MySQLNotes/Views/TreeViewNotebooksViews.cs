using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLNotes.Views
{
    public class TreeViewNotebooksViews:ITreeViewNotebooksView
    {
        private readonly TreeView control;

        public TreeViewNotebooksViews(TreeView control)
        {
            this.control = control;
        }
    }
}
