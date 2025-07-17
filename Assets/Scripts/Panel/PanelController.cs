using UnityEngine;

namespace Panel
{
    public class PanelController
    {
        private IPanelState currentState;

        public void ChangeState(IPanelState newState)
        {
            currentState.OnExit();
            currentState = newState;
            currentState.OnEnter();
        }
    }
}
