using System;
using UnityEngine;

namespace MiniGames.TrainEscape.Scripts.Player
{
    public class PlayerScript : MonoBehaviour
    {
        [SerializeField] private Controls _controls;

        private void FixedUpdate()
        {
            Movement();
        }

        private void Movement()
        {
            if (_controls.IsMoveForward())
            {
                //todo - move forward
            }
            //todo - move horizontal
        }
    }
}
