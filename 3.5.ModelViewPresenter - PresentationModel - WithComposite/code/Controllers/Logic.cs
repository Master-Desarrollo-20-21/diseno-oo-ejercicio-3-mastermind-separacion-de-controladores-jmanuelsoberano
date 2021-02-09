using MasterMind.Types;
using System.Collections.Generic;
using MasterMind.Models;
using System;

namespace MasterMind.Controllers
{
    public class Logic
    {
        private Board board;
        private State state;
        private Dictionary<StateValue, Controller> controllers;

        public Logic()
        {
            this.state = new State();
            this.board = new Board();
            this.controllers = new Dictionary<StateValue, Controller>()
            {
                {StateValue.INITIAL, new StartController(this.board, this.state)},
                {StateValue.IN_GAME, new PlayController(this.board, this.state)},
                {StateValue.RESUME, new ResumeController(this.board, this.state)},
                {StateValue.EXIT, new NullController(this.board, this.state)},
            };
        }

        public Controller GetController()
        {
            return this.controllers[this.state.GetStateValue()];
        }
    }
}