using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjScript2 : MonoBehaviour
{
    public GameObject head;
    public GameObject leftHand;
    public GameObject rightHand;
    public GameObject leftLeg;
    public GameObject rightLeg;

    [HideInInspector] public Vector2 headPos;
    [HideInInspector] public Vector2 leftHandPos;
    [HideInInspector] public Vector2 rightHandPos;
    [HideInInspector] public Vector2 leftLegPos;
    [HideInInspector] public Vector2 rightLegPos;

    [HideInInspector]
    public int robotPlacedCorrectly = 0;

    public AudioSource audioSource;
    public AudioClip[] audioClip;
    [HideInInspector] public bool rightPlace = false;
    public GameObject lastDragged = null;

    public int totalRobot = 5;
    private bool levelFinished = false;

    private GameManager gameManager;

    private void Start()
    {
        headPos = head.GetComponent<RectTransform>().localPosition;
        leftHandPos = leftHand.GetComponent<RectTransform>().localPosition;
        rightHandPos = rightHand.GetComponent<RectTransform>().localPosition;
        leftLegPos = leftLeg.GetComponent<RectTransform>().localPosition;
        rightLegPos = rightLeg.GetComponent<RectTransform>().localPosition;

        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if (!levelFinished && robotPlacedCorrectly >= totalRobot)
        {
            levelFinished = true;
            Debug.Log("Visas mašinas uz vietas!");
            if (gameManager != null)
            {
                gameManager.OnAllCarsPlaced();
            }
            else
            {
                Debug.LogError("GameManager nav atrasts!");
            }
        }
    }
}
