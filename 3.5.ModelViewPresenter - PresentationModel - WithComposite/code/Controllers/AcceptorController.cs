using System;
using System.Collections.Generic;
using System.Text;

namespace MasterMind.Controllers
{
    public interface AcceptorController
    {
        void Accept(ControllersVisitor controllersVisitor);

        public bool IsNull();
    }
}
