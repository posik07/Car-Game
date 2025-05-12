using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour
{
    public GameObject garbageTruck;
    public GameObject schoolBus;
    public GameObject ambulance;


    [HideInInspector]
    public Vector2 gTruckPos;
    [HideInInspector]
    public Vector2 sBussPos;
    [HideInInspector]
    public Vector2 ambulancePos;

    public AudioSource audioSource;
    public AudioClip[] audioClip;
    [HideInInspector]
    public bool rightPlace = false;
    public GameObject lastDragged = null;


    private void Start()
    {
        gTruckPos = garbageTruck.GetComponent<RectTransform>().localPosition;
        sBussPos = schoolBus.GetComponent<RectTransform>().localPosition;
        ambulancePos = ambulance.GetComponent<RectTransform>().localPosition;
    }
}
