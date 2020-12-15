using UnityEngine;

namespace Input
{
    public class InputManager : MonoBehaviour
    {
        public static PlayerInput Controls { get; private set; }

        public static Vector2 Direction { get; private set; }

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

        private void Update()
        {
            var vec = new Vector2();
            
            if (Controls.Player.Up.triggered)
                vec += Vector2.up;
            if (Controls.Player.Down.triggered)
                vec += Vector2.down;
            if (Controls.Player.Left.triggered)
                vec += Vector2.left;
            if (Controls.Player.Right.triggered)
                vec += Vector2.right;

            Direction = vec;
        }
    }
}
