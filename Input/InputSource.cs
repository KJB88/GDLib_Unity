using KBGDLib.Communicators;

namespace KBGDLib.Input
{
    public abstract class InputSource : IService // Base class for input sources so we can treat AI and Player driven input the same in states, reducing edge case handler code.
    {
        float xMovement = 0;
        public float XMovement => xMovement;
        float yMovement = 0;
        public float YMovement => yMovement;
        bool shoot = false;
        public bool Shoot => shoot;

        public abstract void GetInput();
    }
}