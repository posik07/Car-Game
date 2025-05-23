using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour
{
    public GameObject garbageTruck;
    public GameObject schoolBus;
    public GameObject ambulance;
    public GameObject traktors1;
    public GameObject traktors5;
    public GameObject police;
    public GameObject b2mashina;
    public GameObject cementa;
    public GameObject e46mashina;
    public GameObject e61mashina;
    public GameObject eskavators;
    public GameObject ugunsDzeseji;


    [HideInInspector]
    public Vector2 gTruckPos;
    [HideInInspector]
    public Vector2 sBussPos;
    [HideInInspector]
    public Vector2 ambulancePos;
    [HideInInspector]
    public Vector2 traktors1Pos;
    [HideInInspector]
    public Vector2 traktors5Pos;
    [HideInInspector]
    public Vector2 policePos;
    [HideInInspector]
    public Vector2 b2mashinaPos;
    [HideInInspector]
    public Vector2 cementaPos;
    [HideInInspector]
    public Vector2 e46mashinaPos;
    [HideInInspector]
    public Vector2 e61mashinaPos;
    [HideInInspector]
    public Vector2 eskavatorsPos;
    [HideInInspector]
    public Vector2 ugunsDzesejiPos;

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
        traktors1Pos = traktors1.GetComponent<RectTransform>().localPosition;
        traktors5Pos = traktors5.GetComponent<RectTransform>().localPosition;
        policePos = police.GetComponent<RectTransform>().localPosition;
        b2mashinaPos = b2mashina.GetComponent<RectTransform>().localPosition;
        cementaPos = cementa.GetComponent<RectTransform>().localPosition;
        e46mashinaPos = e46mashina.GetComponent<RectTransform>().localPosition;
        e61mashinaPos = e61mashina.GetComponent<RectTransform>().localPosition;
        eskavatorsPos = eskavators.GetComponent<RectTransform>().localPosition;
        ugunsDzesejiPos = ugunsDzeseji.GetComponent<RectTransform>().localPosition;
    }
}
