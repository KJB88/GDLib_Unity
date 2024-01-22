using UnityEngine;

namespace KBGDLib.Structural
{
    public abstract class State : ScriptableObject // Base class state for all states to derive from. Set as ScriptableObject to allow for modular building-block construction of extensible behaviours
    {
        [SerializeField] private string stateName = "DEFAULT";
        public string StateName => stateName;

        protected abstract void Initialize();
        protected abstract void OnStateEntry();
        protected abstract void OnStateExit();

        protected abstract void RunState(Blackboard blackboard);
    }
}