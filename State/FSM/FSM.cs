namespace GDLib.StateHandling
{
    /// <summary>
    /// Finite State Machine (FSM) holds the current State to be updated.
    /// </summary>
    public class FSM
    {
        /// The current <see cref="State"/> to be updated.
        protected State currentState;

        public FSM() { }

        /// <summary> Allows a new state to be set for updating. </summary>
        /// <include file='../../Docs/StateHandling.xml' path='doc/members/member[@name="GDLib.StateHandling.FSM.SetState"]/*'/>
        public void SetState(State state, Blackboard blackboard)
        {
            currentState?.OnStateExit(blackboard);

            currentState = state;
            currentState.OnStateEntry(blackboard);
        }

        /// <summary> Updates the current state. </summary>
        /// <include file='../../Docs/StateHandling.xml' path='doc/members/member[@name="GDLib.StateHandling.FSM.UpdateState"]/*'/>
        public void UpdateState(Blackboard blackboard) => currentState?.UpdateState(blackboard);
    };
}