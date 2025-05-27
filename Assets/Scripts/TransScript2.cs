using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransScript2 : MonoBehaviour
{
    public ObjScript2 objScript;
    void Update()
    {
        if (objScript.lastDragged != null)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                objScript.lastDragged.GetComponent<RectTransform>().
                    transform.Rotate(0, 0, Time.deltaTime * 12f);
            }

            if (Input.GetKey(KeyCode.X))
            {
                objScript.lastDragged.GetComponent<RectTransform>().
                    transform.Rotate(0, 0, -Time.deltaTime * 12f);
            }

            if (Input.GetKey(KeyCode.Y))
            {
                objScript.lastDragged.GetComponent<RectTransform>().
                    transform.Rotate(0, 0, -Time.deltaTime * 12f);
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {

                if (objScript.lastDragged.GetComponent<RectTransform>().transform.localScale.y < 1.5f)
                {
                    objScript.lastDragged.GetComponent<RectTransform>().
                        transform.localScale = new Vector2(
                        objScript.lastDragged.GetComponent<RectTransform>().
                        transform.localScale.x,
                        objScript.lastDragged.GetComponent<RectTransform>().
                        transform.localScale.y + 0.001f);
                }
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {

                if (objScript.lastDragged.GetComponent<RectTransform>().transform.localScale.y > 0.5f)
                {
                    objScript.lastDragged.GetComponent<RectTransform>().
                        transform.localScale = new Vector2(
                        objScript.lastDragged.GetComponent<RectTransform>().
                        transform.localScale.x,
                        objScript.lastDragged.GetComponent<RectTransform>().
                        transform.localScale.y - 0.001f);
                }
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {

                if (objScript.lastDragged.GetComponent<RectTransform>().transform.localScale.y > 0.5f)
                {
                    objScript.lastDragged.GetComponent<RectTransform>().
                        transform.localScale = new Vector2(
                        objScript.lastDragged.GetComponent<RectTransform>().
                        transform.localScale.x - 0.001f,
                        objScript.lastDragged.GetComponent<RectTransform>().
                        transform.localScale.y);
                }
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {

                if (objScript.lastDragged.GetComponent<RectTransform>().transform.localScale.y < 1.5f)
                {
                    objScript.lastDragged.GetComponent<RectTransform>().
                        transform.localScale = new Vector2(
                        objScript.lastDragged.GetComponent<RectTransform>().
                        transform.localScale.x + 0.001f,
                        objScript.lastDragged.GetComponent<RectTransform>().
                        transform.localScale.y);
                }
            }
        }
    }
}
