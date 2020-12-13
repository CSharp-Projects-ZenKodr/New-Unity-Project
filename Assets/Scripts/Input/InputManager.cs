using UnityEngine;

namespace Input
{
    public class InputManager : MonoBehaviour
    {
        public static PlayerInput Controls { get; private set; }

        private void Awake()
        {
            Controls = new PlayerInput();
        }

        private void OnEnable()
        {
            Controls.Enable();
        }

        private void OnDisable()
        {
            Controls.Disable();
        }
    }
}
