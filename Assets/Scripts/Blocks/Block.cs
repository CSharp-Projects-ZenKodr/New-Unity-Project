using UnityEngine;

namespace Blocks
{
    public class Block : MonoBehaviour
    {
        public Vector2 Position { get; set; }

        private void Update()
        {
            var pos = new Vector3(Position.x, Position.y, 0f);

            if (transform.position != pos) transform.position = pos;
        }
    }
}
