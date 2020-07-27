using System;
namespace Observer
{
    public class Reducer : IReducer
    {
        public (int, int) Update(IAction action, (int sum, int subtract) state)
        {
            switch (action.Action)
            {
                case ActionEnum.Add:
                    return (state.sum + action.PayLoad, state.subtract);
                case ActionEnum.Subtract:
                    return (state.sum, state.subtract - action.PayLoad);
                default:
                    return (state.sum, state.subtract);
            }
        }
    }
}
