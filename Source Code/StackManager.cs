/**
 * AR-STACK-GAME: A Mobile Augmented Reality Case Study in 3D Stacking and Physics
 * 
 * This source file is part of a curated Computer Engineering project collection.
 * It is preserved as a final technical artifact representing the application 
 * of ARCore and Unity Engine in mobile gaming.
 * 
 * AUTHORS: Amey Thakur (https://github.com/Amey-Thakur) & Hasan Rizvi (https://github.com/rizvihasan)
 * REPOSITORY: https://github.com/Amey-Thakur/AR-STACK-GAME
 * ORIGINAL RELEASE: August 12, 2020
 * 
 * LICENSE: MIT License
 */

using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ARStackGame.Core
{
    /// <summary>
    /// Manages the overall game state, scoring, and UI transitions.
    /// Acts as the central controller for the stacking logic.
    /// </summary>
    public class StackManager : MonoBehaviour
    {
        public static StackManager Instance { get; private set; }

        [Header("Game Configuration")]
        [SerializeField] private Text scoreText;
        [SerializeField] private GameObject startUI;
        [SerializeField] private GameObject gameOverUI;

        private int _score;
        private bool _isGameStarted;
        private bool _isGameOver;

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

        private void Start()
        {
            ResetGame();
        }

        private void Update()
        {
            if (_isGameOver)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    RestartScene();
                }
                return;
            }

            if (!_isGameStarted)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    StartGame();
                }
                return;
            }

            if (Input.GetMouseButtonDown(0))
            {
                HandleInput();
            }
        }

        private void StartGame()
        {
            _isGameStarted = true;
            startUI.SetActive(false);
            CubeSpawner.Instance.SpawnCube();
        }

        private void HandleInput()
        {
            // Logic for dropping the current moving cube
            if (MovingCube.CurrentCube != null)
            {
                MovingCube.CurrentCube.Stop();
            }
        }

        public void IncrementScore()
        {
            _score++;
            scoreText.text = _score.ToString();
            CubeSpawner.Instance.SpawnCube();
        }

        public void EndGame()
        {
            _isGameOver = true;
            gameOverUI.SetActive(true);
            Debug.Log("Game Over. Final Score: " + _score);
        }

        private void ResetGame()
        {
            _score = 0;
            _isGameStarted = false;
            _isGameOver = false;
            scoreText.text = "0";
            startUI.SetActive(true);
            gameOverUI.SetActive(false);
        }

        private void RestartScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
