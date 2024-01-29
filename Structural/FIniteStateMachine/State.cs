using UnityEngine;

namespace KBGDLib.Structural
{
    /// <summary>
    /// Base class state for all states to derive from. Set as ScriptableObject to allow for modular building-block construction of extensible behaviours
    /// </summary>
    public abstract class State
    {
        private string stateName = "DEFAULT";
        public string StateName => stateName;

        protected FiniteStateMachine stateMachine;

        public State(string stateName, FiniteStateMachine fsm)
        {
            this.stateName = stateName;
            this.stateMachine = fsm;
        }

        public abstract void OnStateEntry();
        public abstract void OnStateExit();

        public abstract void UpdateState(Blackboard blackboard);
    }
}