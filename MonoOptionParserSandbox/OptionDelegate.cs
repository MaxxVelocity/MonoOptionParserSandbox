using System;
using System.Collections.Generic;
using System.Text;

namespace MonoOptionParserSandbox
{
    public class OptionDelegate
    {
        private List<string> list;
        private Action targetAction;

        //private delegate void targetFuntion();

        public List<string> ParameterNameAliases { get; private set; }

        public Delegate TargetFuction {get; private set;}

        //public OptionDelegate(List<string> parameterNameAliases, Delegate targetFuction)
        //{
        //    this.ParameterNameAliases = parameterNameAliases;
        //    this.TargetFuction = targetFuction;
        //}

        public OptionDelegate(List<string> list, Action targetAction)
        {
            this.list = list;
            this.targetAction = targetAction;
        }

        public void Invoke(params object[] args)
        {
            targetAction.Invoke();
            //this.TargetFuction.DynamicInvoke(args);
        }
    }
}
