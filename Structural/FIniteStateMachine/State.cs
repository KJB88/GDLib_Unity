namespace KBGDLib.Structural
{
    /// <summary>
    /// Base class state for all states to derive from. Set as ScriptableObject to allow for modular building-block construction of extensible behaviours
    /// </summary>
    public abstract class State
    {
        private string stateName = "DEFAULT";
        public string StateName => stateName;

        protected FSM stateMachine;

        public State(string stateName, FSM fsm)
        {
            this.stateName = stateName;
            this.stateMachine = fsm;
        }

        public abstract void OnStateEntry(Blackboard blackboard);
        public abstract void OnStateExit(Blackboard blackboard);

        public abstract void UpdateState(Blackboard blackboard);
    }
}