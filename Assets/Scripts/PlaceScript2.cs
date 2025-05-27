using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlaceScript2 : MonoBehaviour, IDropHandler
{
    private float placeZRotation, carZRotation, difZRotation;
    private Vector2 placeSize, carSize;
    private float xSizeDif, ySizeDif;
    public ObjScript2 objScript;
    public bool rightPlace = false;


    public void OnDrop(PointerEventData eventData)
    {
        if ((eventData.pointerDrag != null) && Input.GetMouseButtonUp(0)
            && Input.GetMouseButton(2) == false)
        {
            
            bool wasRightPlace = this.rightPlace;

            if (eventData.pointerDrag.tag.Equals(tag))
            {
                placeZRotation =
                eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;

                carZRotation = GetComponent<RectTransform>().transform.eulerAngles.z;

                difZRotation = Mathf.Abs(placeZRotation - carZRotation);
                Debug.Log("Dif Z Rotation: " + difZRotation);

                placeSize = eventData.pointerDrag.GetComponent<RectTransform>().localScale;
                carSize = GetComponent<RectTransform>().localScale;
                xSizeDif = Mathf.Abs(placeSize.x - carSize.x);
                ySizeDif = Mathf.Abs(placeSize.y - carSize.y);
                Debug.Log("Dif X Size: " + xSizeDif + " Dif Y Size: " + ySizeDif);

                if ((difZRotation <= 5 || (difZRotation >= 355 && difZRotation <= 360))
                    && (xSizeDif <= 0.1 && ySizeDif <= 0.1))
                {
                    Debug.Log("Right Place");
                    this.rightPlace = true;


                    // Увеличиваем счётчик, если раньше объект был не на месте
                    if (!wasRightPlace)
                    {
                        objScript.robotPlacedCorrectly++;
                        Debug.Log("Robots Placed Correctly: " + objScript.robotPlacedCorrectly);


                    }

                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =
                        GetComponent<RectTransform>().anchoredPosition; // iecentrē pozīciju
                    eventData.pointerDrag.GetComponent<RectTransform>().localRotation =
                        GetComponent<RectTransform>().localRotation;//pielāgo rotāciju
                    eventData.pointerDrag.GetComponent<RectTransform>().localScale =
                        GetComponent<RectTransform>().localScale; //pielāgo izmēru

                    switch (eventData.pointerDrag.tag)
                    {
                        case "HEAD":
                            objScript.audioSource.PlayOneShot(objScript.audioClip[1]);
                            break;
                        case "LEFTLEG":
                            objScript.audioSource.PlayOneShot(objScript.audioClip[1]);
                            break;
                        case "LEFTGAND":
                            objScript.audioSource.PlayOneShot(objScript.audioClip[1]);
                            break;
                        case "RIGHTLEG":
                            objScript.audioSource.PlayOneShot(objScript.audioClip[1]);
                            break;
                        case "RIGHTHAND":
                            objScript.audioSource.PlayOneShot(objScript.audioClip[1]);
                            break;

                        default:
                            Debug.LogError("Unknown tag!");
                            break;
                    }
                }
                else
                {
                    // Если объект был на правильном месте, но теперь нет — уменьшаем счётчик
                    if (wasRightPlace)
                    {
                        objScript.robotPlacedCorrectly--;
                        Debug.Log("Cars Placed Correctly: " + objScript.robotPlacedCorrectly);
                    }

                    this.rightPlace = false;
                }
            }
            else
            {
                // Если был на месте, а теперь поставлен не туда — уменьшаем счётчик
                if (wasRightPlace)
                {
                    objScript.robotPlacedCorrectly--;
                    Debug.Log("Cars Placed Correctly: " + objScript.robotPlacedCorrectly);
                }

                this.rightPlace = false;
                objScript.audioSource.PlayOneShot(objScript.audioClip[1]);

                switch (eventData.pointerDrag.tag)
                {
                    case "HEAD":
                        objScript.head.GetComponent<RectTransform>().localPosition = objScript.headPos;
                        break;
                    case "LEFTGAND":
                        objScript.leftHand.GetComponent<RectTransform>().localPosition = objScript.leftHandPos;
                        break;
                    case "LEFTLEG":
                        objScript.leftLeg.GetComponent<RectTransform>().localPosition = objScript.leftLegPos;
                        break;
                    case "RIGHTHAND":
                        objScript.rightHand.GetComponent<RectTransform>().localPosition = objScript.rightHandPos;
                        break;
                    case "RIGHTLEG":
                        objScript.rightLeg.GetComponent<RectTransform>().localPosition = objScript.rightLegPos;
                        break;
                    default:
                        Debug.LogError("Unknown tag!");
                        break;
                }
            }
        }
    }
}