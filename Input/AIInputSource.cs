
namespace KBGDLib.Input
{
    public sealed class AIInputSource : InputSource // Updates base input from an AI brain instead of an input device.
    {
        public AIInputSource()
        {
            // Configure resources for the AIID - this includes possibly configuring the behaviours or archetype of the entity
        }
        public override void GetInput()
        {
            // Input source for AI, does not take input from input device but calculates input via AI decision maker
            // This could be a modular approach with plug-n-play logic blocks utilising Behaviour Trees or a simpler FSM approach, or both (HFSM-BT)
        }
    };
}