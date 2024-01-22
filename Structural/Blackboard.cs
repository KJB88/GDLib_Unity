using System.Collections.Generic;

namespace KBGDLib.Structural
{
    public static class BlackboardLibrary
    {
        public static string TRANSFORM = "Transform";
        public static string RIGIDBODY2D = "Rigidbody2D";
    }

    // The entire blackboard is an approach similar to Blackboards used when developing BehaviourTrees, ideally this would hold wrapped classes via polymorphism (EG: EntityTransform : BlackboardEntry).
    public class Blackboard 
    {
        private List<BlackboardVariable> blackboard = new List<BlackboardVariable>();

        public void AddBlackboardData(BlackboardVariable entry)
        {
            blackboard.Add(entry);
        }
        public bool TryGetBlackboardData(string targetEntryName, out object targetEntryData)
        {
            targetEntryData = null;

            if (!blackboard.Exists(e => e.entryName == targetEntryName.ToLower())))
                    return false;
        }
    }

    public abstract class BlackboardVariable
    {

    }
}