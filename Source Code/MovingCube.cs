/**
 * AR-STACK-GAME: A Mobile Augmented Reality Case Study in 3D Stacking and Physics
 * 
 * This source file is part of a curated Computer Engineering project collection.
 * It is preserved as a final technical project representing the application 
 * of ARCore and Unity Engine in mobile gaming.
 * 
 * AUTHORS: Amey Thakur (https://github.com/Amey-Thakur) & Hasan Rizvi (https://github.com/rizvihasan)
 * REPOSITORY: https://github.com/Amey-Thakur/AR-STACK-GAME
 * ORIGINAL RELEASE: August 12, 2020
 * 
 * LICENSE: MIT License
 */

using UnityEngine;

namespace ARStackGame.Core
{
    /// <summary>
    /// Represents the currently active (moving) cube.
    /// Handles oscillation and the "slicing" logic when the cube is dropped.
    /// </summary>
    public class MovingCube : MonoBehaviour
    {
        public static MovingCube CurrentCube { get; private set; }
        public static MovingCube LastCube { get; private set; }

        [SerializeField] private float moveSpeed = 1.0f;
        private MoveDirection _direction;
        private bool _isMoving;

        public void Initiate(MoveDirection direction)
        {
            _direction = direction;
            _isMoving = true;
            CurrentCube = this;
        }

        private void Update()
        {
            if (!_isMoving) return;

            float moveAmount = Mathf.PingPong(Time.time * moveSpeed, 2.0f) - 1.0f;
            
            if (_direction == MoveDirection.X)
                transform.position = new Vector3(moveAmount, transform.position.y, transform.position.z);
            else
                transform.position = new Vector3(transform.position.x, transform.position.y, moveAmount);
        }

        public void Stop()
        {
            _isMoving = false;
            
            // Simplified slicing/stacking logic
            float hangover = CalculateHangover();
            float maxAllowedHangover = transform.localScale.x; // Simplified threshold

            if (Mathf.Abs(hangover) >= maxAllowedHangover)
            {
                StackManager.Instance.EndGame();
                return;
            }

            LastCube = this;
            StackManager.Instance.IncrementScore();
        }

        private float CalculateHangover()
        {
            if (LastCube == null) return 0;

            if (_direction == MoveDirection.X)
                return transform.position.x - LastCube.transform.position.x;
            else
                return transform.position.z - LastCube.transform.position.z;
        }
    }
}
 
