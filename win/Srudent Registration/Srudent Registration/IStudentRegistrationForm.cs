using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srudent_Registration
{
    interface IStudentRegistrationForm : IView
    {
        event EventHandler DataChanged;
    }
}
