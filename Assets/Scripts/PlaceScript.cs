using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlaceScript : MonoBehaviour, IDropHandler
{
    private float placeZRotation, carZRotation, difZRotation;
    private Vector2 placeSize, carSize;
    private float xSizeDif, ySizeDif;
    public ObjectScript objectScript;

    public void OnDrop(PointerEventData eventData)
    {
        if ((eventData.pointerDrag != null) && Input.GetMouseButtonUp(0)
            && Input.GetMouseButton(2) == false)
        {
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
                ySizeDif = Mathf.Abs(ySizeDif - carSize.y);
                Debug.Log("Dif X Size: " + xSizeDif + " Dif Y Size: " + ySizeDif);

                if ((difZRotation <= 5 || (difZRotation >= 355 && difZRotation <= 360))
                    && (xSizeDif <= 0.1 && ySizeDif <= 0.1))
                {
                    Debug.Log("Right Place");
                    objectScript.rightPlace = true;

                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =
                        GetComponent<RectTransform>().anchoredPosition; // iecentrē pozīciju
                    eventData.pointerDrag.GetComponent<RectTransform>().localRotation =
                        GetComponent<RectTransform>().localRotation;//pielāgo rotāciju
                    eventData.pointerDrag.GetComponent<RectTransform>().localScale =
                        GetComponent<RectTransform>().localScale; //pielāgo izmēru

                    switch (eventData.pointerDrag.tag)
                    {
                        case "Garbage":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClip[2]);
                            break;
                        case "Ambulance":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClip[4]);
                            break;
                        case "School":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClip[3]);
                            break;
                        case "Traktors1":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClip[10]);
                            break;
                        case "Traktors5":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClip[11]);
                            break;
                        case "Police":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClip[9]);
                            break;
                        case "b2":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClip[5]);
                            break;
                        case "Cement":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClip[6]);
                            break;
                        case "e46":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClip[7]);
                            break;
                        case "e61":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClip[8]);
                            break;
                        case "Eskavators":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClip[12]);
                            break;
                        case "Ugunsdzeseji":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClip[13]);
                            break;

                        default:
                            Debug.LogError("Unknown tag!");
                            break;
                    }
                }

            }
            else
            {
                objectScript.rightPlace = false;
                objectScript.audioSource.PlayOneShot(objectScript.audioClip[1]);

                switch (eventData.pointerDrag.tag)
                {
                    case "Garbage":
                        objectScript.garbageTruck.GetComponent<RectTransform>().localPosition = objectScript.gTruckPos;
                        break;
                    case "Ambulance":
                        objectScript.ambulance.GetComponent<RectTransform>().localPosition = objectScript.ambulancePos;
                        break;
                    case "School":
                        objectScript.schoolBus.GetComponent<RectTransform>().localPosition = objectScript.sBussPos;
                        break;
                    case "Traktors1":
                        objectScript.traktors1.GetComponent<RectTransform>().localPosition = objectScript.traktors1Pos;
                        break;
                    case "Traktors5":
                        objectScript.traktors5.GetComponent<RectTransform>().localPosition = objectScript.traktors5Pos;
                        break;
                    case "Police":
                        objectScript.police.GetComponent<RectTransform>().localPosition = objectScript.policePos;
                        break;
                    case "b2":
                        objectScript.b2mashina.GetComponent<RectTransform>().localPosition = objectScript.b2mashinaPos;
                        break;
                    case "Cement":
                        objectScript.cementa.GetComponent<RectTransform>().localPosition = objectScript.cementaPos;
                        break;
                    case "e46":
                        objectScript.e46mashina.GetComponent<RectTransform>().localPosition = objectScript.e46mashinaPos;
                        break;
                    case "e61":
                        objectScript.e61mashina.GetComponent<RectTransform>().localPosition = objectScript.e61mashinaPos;
                        break;
                    case "Eskavators":
                        objectScript.eskavators.GetComponent<RectTransform>().localPosition = objectScript.eskavatorsPos;
                        break;
                    case "Ugunsdzeseji":
                        objectScript.ugunsDzeseji.GetComponent<RectTransform>().localPosition = objectScript.ugunsDzesejiPos;
                        break;

                    default:
                        Debug.LogError("Unknown tag!");
                        break;
                }


            }
        }
    }
}
