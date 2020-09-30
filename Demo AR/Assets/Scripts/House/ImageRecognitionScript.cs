using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ImageRecognitionScript : MonoBehaviour
{
    private ARTrackedImageManager _arTrackedManager;
    public GameObject house;
    GameObject temp;


    private void Awake()
    {

        _arTrackedManager = FindObjectOfType<ARTrackedImageManager>();
    }

    private void OnEnable()
    {
        _arTrackedManager.trackedImagesChanged += OnTrackedImagesChanged;

    }

    private void OnDisable()
    {
        _arTrackedManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        ARTrackedImage trackedImage = null;

        for (int i = 0; i < eventArgs.added.Count; i++)
        {
            trackedImage = eventArgs.added[i];

            if (string.Compare(trackedImage.referenceImage.name, "house_scaled") == 0)
            {
                //Destroy(temp);
               // temp = Instantiate(animal);
                house.transform.position = trackedImage.transform.position;
                house.transform.rotation = trackedImage.transform.rotation;
                house.transform.parent = trackedImage.transform;

            }
            
            // instantiate AR object, set trackedImage.transform
            // use a Dictionary, the key could be the trackedImage, or the name of the reference image -> trackedImage.referenceImage.name
            // the value of the Dictionary is the AR object you instantiate.
        }

        for (int i = 0; i < eventArgs.updated.Count; i++)
        {
            trackedImage = eventArgs.updated[i];
            if (trackedImage.trackingState == TrackingState.Tracking)
            //if (trackedImage.trackingState != TrackingState.None)
            {
                house.SetActive(true);

                // set AR object to active, use Dictionary to get AR object based on trackedImage
                // you can also include TrackingState.Limited by checking for None
            }
            else
            {
                house.SetActive(false);
                // set active to false
            }
        }

    }

}