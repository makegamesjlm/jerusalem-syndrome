using UnityEngine;

namespace MiniGames.TrainEscape.Scripts.Player
{
    [CreateAssetMenu(fileName = "Controls", menuName = "MiniGames/TrainEscape/Player/Controls")]
    public class Controls : ScriptableObject
    {
        public KeyCode MoveForward;
        public string HorizontalMove;
        
        public bool IsMoveForward()
        {
            return Input.GetKey(MoveForward);
        }

        public float HorizontalMovement()
        {
            return Input.GetAxis(HorizontalMove);
        }
    }
}
