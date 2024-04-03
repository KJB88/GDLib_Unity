namespace GDLib.StateHandling
{
    /// <summary>
    /// Base class for all States to derive from.
    /// </summary>
    public abstract class State
    {

        /// Reference to the parent FSM
        protected FSM fsm;

        public State(FSM fsm)
            => this.fsm = fsm;

        /// <summary>
        /// Initialize resources from the <see cref="Blackboard"/> upon entry to the <see cref="State"/>.
        /// </summary>
        /// <param name="blackboard">The <see cref="Blackboard"/> that contains the data for the <see cref="State"/> to act upon.</param>
        public abstract void OnStateEntry(Blackboard blackboard);

        /// <summary>
        /// Deinitialize resources from the <see cref="Blackboard"/> upon exit of the <see cref="State"/>.
        /// </summary>
        /// <param name="blackboard">The <see cref="Blackboard"/> that contains the data for the <see cref="State"/> to act upon.</param>
        public abstract void OnStateExit(Blackboard blackboard);

        /// <summary>
        /// Update the state.
        /// </summary>
        /// <param name="blackboard">The <see cref="Blackboard"/> that contains the data for the <see cref="State"/> to act upon.</param>
        public abstract void UpdateState(Blackboard blackboard);
    }
}