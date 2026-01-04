/**
 * AR-STACK-GAME: A Mobile Augmented Reality Case Study in 3D Stacking and Physics
 * 
 * This source file is part of a curated Computer Engineering project collection.
 * It is preserved as a final technical artifact representing the application 
 * of ARCore and Unity Engine in mobile gaming.
 * 
 * AUTHOR: Amey Thakur (https://github.com/Amey-Thakur)
 * REPOSITORY: https://github.com/Amey-Thakur/AR-STACK-GAME
 * ORIGINAL RELEASE: August 12, 2020
 * 
 * LICENSE: MIT License
 */

using UnityEngine;

namespace ARStackGame.Core
{
    /// <summary>
    /// Handles the instantiation of new cubes at appropriate intervals and positions.
    /// Controls the alternating spawn direction (X and Z axes).
    /// </summary>
    public class CubeSpawner : MonoBehaviour
    {
        public static CubeSpawner Instance { get; private set; }

        [SerializeField] private MovingCube cubePrefab;
        [SerializeField] private Transform spawnPoint;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        /// <summary>
        /// Spawns a new cube in the scene.
        /// </summary>
        public void SpawnCube()
        {
            var lastCube = MovingCube.LastCube;
            var spawnPos = spawnPoint.position;

            if (lastCube != null)
            {
                spawnPos = new Vector3(
                    lastCube.transform.position.x,
                    lastCube.transform.position.y + cubePrefab.transform.localScale.y,
                    lastCube.transform.position.z
                );
            }

            var cube = Instantiate(cubePrefab, spawnPos, Quaternion.identity);
            
            // Determine move direction based on height/index (alternating X and Z)
            var moveDirection = (int)spawnPos.y % 2 == 0 ? MoveDirection.X : MoveDirection.Z;
            cube.Initiate(moveDirection);
        }
    }

    public enum MoveDirection
    {
        X,
        Z
    }
}
