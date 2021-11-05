using MySQLNotes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLNotes.Views
{
    public delegate NotebookNodeModel[] ExpandDelegate(NotebookNodeModel data);
    public interface ITreeViewNotebooksView
    {
        event ExpandDelegate OnExpand;
        
    }
}
