using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_DesignPatterns.State
{
    public interface IState
    {
        void Handle(Context context);
    }

    class ConcreteState1 : IState
    {
        public ConcreteState1()
        {
            ;
        }

        public void Handle(Context context)
        {
            ;
        }
    }

    class ConcreteState2 : IState
    {
        public ConcreteState2()
        {
            ;
        }

        public void Handle(Context context)
        {
            ;
        }
    }
}
