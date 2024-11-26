using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.MVC.View;

namespace WpfApp1.MVC.Controller
{
    public class MainController
    {
        private readonly IMainView _view;

        public MainController(IMainView view)
        {
            _view = view;
            _view.SetController(this);
        }
    }
}
