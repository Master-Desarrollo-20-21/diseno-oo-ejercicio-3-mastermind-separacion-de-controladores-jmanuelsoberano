using MasterMind.Types;
using System.Collections.Generic;
using MasterMind.Models;

namespace MasterMind.Controllers
{
    public class Logic
    {
        private Session session;
        private Dictionary<StateValue, AcceptorController> acceptorControllers;

        public Logic(Session session)
        {
            this.session = session;
            this.acceptorControllers = new Dictionary<StateValue, AcceptorController>()
            {
                {StateValue.INITIAL, new StartController(this.session)},
                {StateValue.IN_GAME, new PlayController(this.session)},
                {StateValue.RESUME, new ResumeController(this.session)},
                {StateValue.EXIT, new NullController(this.session)},
            };
        }

        public AcceptorController GetController()
        {
            return this.acceptorControllers[this.session.GetValueState()];
        }
    }
}