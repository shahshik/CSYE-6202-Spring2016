using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srudent_Registration
{
    public class Presenter
    {
        private IModel model;
        private IView view;

        private Presenter() { }

        public Presenter(IModel model, IView view)
        {
            this.model = model;
            this.view = view;
        }

        public void Show()
        {
            var form = view as frmRegistration;

            if (form != null)
            {
                form.ShowDialog();
            }
        }
    }
}
