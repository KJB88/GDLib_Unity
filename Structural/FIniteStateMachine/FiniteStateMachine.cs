using System.Collections.Generic;
using UnityEngine;

namespace KBGDLib.Structural
{
    /// <summary>
    /// Finite State Machine.
    /// It holds the currently updating state using UpdateState.
    /// Current State can be changed by calling SetState, which will handle transition internally.
    /// </summary>
    public class FiniteStateMachine
    {
        private State currentState;

        public FiniteStateMachine(State state) => currentState = state;

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