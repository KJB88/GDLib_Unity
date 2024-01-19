//using UnityEngine;

//namespace KBGDLib.Structural
//{
//    public abstract class State : ScriptableObject // Base class state for all states to derive from. Set as ScriptableObject to allow for modular building-block construction of extensible behaviours
//    {
//        private string stateName;
//        public string StateName => stateName;

//        public State(string stateName) => this.stateName = stateName;

//        protected abstract void Initialize();
//        protected abstract void OnStateEntry();
//        protected abstract void OnStateExit();

//        protected abstract void RunState(InputSource input, EntityBlackboard blackboard);
//    }
//}