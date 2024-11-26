using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.MVC.Controller;

namespace WpfApp1.MVC.View
{
    public interface IMainView
    {
        void SetController(MainController controller);
    }
}
