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

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

namespace ARStackGame.AR
{
    /// <summary>
    /// Integrates ARCore via AR Foundation to detect horizontal planes 
    /// and anchor the game board in the physical environment.
    /// </summary>
    [RequireComponent(typeof(ARRaycastManager))]
    public class ARPlacementManager : MonoBehaviour
    {
        [SerializeField] private GameObject placementIndicator;
        [SerializeField] private GameObject gameFoundationPrefab;

        private ARRaycastManager _raycastManager;
        private Pose _placementPose;
        private bool _placementPoseIsValid;
        private bool _isGamePlaced;

        private void Awake()
        {
            _raycastManager = GetComponent<ARRaycastManager>();
        }

        private void Update()
        {
            if (_isGamePlaced) return;

            UpdatePlacementPose();
            UpdatePlacementIndicator();

            if (_placementPoseIsValid && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                PlaceGameFoundation();
            }
        }

        private void PlaceGameFoundation()
        {
            Instantiate(gameFoundationPrefab, _placementPose.position, _placementPose.rotation);
            _isGamePlaced = true;
            placementIndicator.SetActive(false);
            
            Debug.Log("AR Game Foundation Placed at: " + _placementPose.position);
        }

        private void UpdatePlacementPose()
        {
            var screenCenter = Camera.main.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
            var hits = new List<ARRaycastHit>();
            _raycastManager.Raycast(screenCenter, hits, TrackableType.PlaneWithinPolygon);

            _placementPoseIsValid = hits.Count > 0;
            if (_placementPoseIsValid)
            {
                _placementPose = hits[0].pose;
            }
        }

        private void UpdatePlacementIndicator()
        {
            if (_isGamePlaced) return;

            if (_placementPoseIsValid)
            {
                placementIndicator.SetActive(true);
                placementIndicator.transform.SetPositionAndRotation(_placementPose.position, _placementPose.rotation);
            }
            else
            {
                placementIndicator.SetActive(false);
            }
        }
    }
}
 
