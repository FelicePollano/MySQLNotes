using Ninject;
using Ninject.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLNotes
{
    public class IOCBootstrapper
    {
        StandardKernel kernel;
        public IOCBootstrapper()
        {
            kernel = new StandardKernel();
            BindAllInViews();
            BindAllInPresenters();
        }

        private void BindAllInPresenters()
        {
            BindAll("Presenters");
        }

        private void BindAll(string prefix)
        {
            foreach (var t in Assembly.GetExecutingAssembly().GetTypes().Where(t => !t.IsAbstract && t.FullName.Contains($".{prefix}.")))
            {
                foreach (var i in t.GetInterfaces())
                {
                    kernel.Bind(i).To(t);
                }
            }
        }

        private void BindAllInViews()
        {
            BindAll("Views");
        }

        
       

        public  void BindViewsAndPresenters(Control form)
        {
            var viewTypeName = $"I{form.Name}View";
            var presenterTypeName = $"I{form.Name}Presenter";
            var tview = Assembly.GetExecutingAssembly().GetTypes().Where(tt =>string.Compare(tt.Name,viewTypeName, true)==0).FirstOrDefault();
            var tpres = Assembly.GetExecutingAssembly().GetTypes().Where(tt => string.Compare(tt.Name, presenterTypeName, true) == 0).FirstOrDefault();
            if (null != tview)
            {
               var view = kernel.Get(tview, new ConstructorArgument("control",form));
               kernel.Get(tpres, new ConstructorArgument("view", view));
            }
            foreach (Control child in form.Controls)
            {
                BindViewsAndPresenters(child);
            }
            form.ControlAdded += (s, e) => { BindViewsAndPresenters(e.Control); };
        }
        
    }
}
