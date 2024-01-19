namespace KBGDLib.Input
{
    public sealed class VirtualInputSource : InputSource // Swaps device-specific and platform-specific inputs to a common device-agnostic, platform-agnostic common input schema.
    {
        public VirtualInputSource()
        {
            // Configure resources for the VID - this includes hooking into the input handlers for Unity
        }
        public override void GetInput()
        {
            // This is where the VID would gather input from whatever device is doing input
            // and translate it into device-agnostic virtual input, detaching input device from
            // high-level game systems. Also useful to separate input from Unity into platform-agnostic
            // input.
        }
    } 

}