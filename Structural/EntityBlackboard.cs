namespace KBGDLib.Structural
{
    public class EntityBlackboard // The entire blackboard is an approach similar to Blackboards used when developing BehaviourTrees, ideally this would hold wrapped classes via polymorphism (EG: EntityTransform : BlackboardEntry).
    {
        public Transform entityTransform;
        public Rigidbody2D entityRigidbody;
        public Collider2D entityCollider;
    } 
}