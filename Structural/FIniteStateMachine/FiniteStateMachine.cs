using System.Collections.Generic;

namespace KBGDLib.Structural
{
    /// <summary>
    /// Finite State Machine.
    /// It holds the currently updating state using UpdateState.
    /// Current State can be changed by calling SetState, which will handle transition internally.
    /// </summary>
    public class FSM
    {
        private State currentState;

        public FSM(State state) => currentState = state;

        public string GetCurrentStateName() => currentState.StateName;

        public void SetState(State state)
        {
            currentState.OnStateExit();

            currentState = state;
            currentState.OnStateEntry();
        }

        public void UpdateFSM(Blackboard blackboard) => currentState?.UpdateState(blackboard);
    };
}