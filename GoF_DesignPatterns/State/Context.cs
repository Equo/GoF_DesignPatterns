using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_DesignPatterns.State
{
    public class Context
    {
        private IState state;
        public IState State
        {
            get { return state; }
        }

        private void ChangeState(IState state)
        {
            this.state = state;
        }
        
        public Context(IState state)
        {
            this.state = state;
        }

        public void Request()
        {
            state.Handle(this);
        }
    }
}
