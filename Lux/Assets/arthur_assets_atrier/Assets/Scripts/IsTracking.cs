using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class IsTracking : MonoBehaviour
{
    
    public bool isTracking;

    ARTrackedImageManager m_TrackedImageManager;

    void Start()
    {
        isTracking = false;
    }
        
    void Awake()
    {
        m_TrackedImageManager = GetComponent<ARTrackedImageManager>();
    }

    void OnEnable()
    {
        m_TrackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        m_TrackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    void UpdateInfo(ARTrackedImage trackedImage)
    {
        if (isTracking == false)
        {
            if (trackedImage.trackingState == TrackingState.Tracking)
            {
                isTracking = true;
            }
        }
    }

    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var trackedImage in eventArgs.added)
            UpdateInfo(trackedImage);

        foreach (var trackedImage in eventArgs.updated)
            UpdateInfo(trackedImage);
    }
}