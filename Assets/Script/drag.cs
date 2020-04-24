using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour {

    Vector3 distance;
    float posX;
    float posY;

    private void OnMouseDown()
    {
        distance = Camera.main.WorldToScreenPoint(transform.position);
        // calculate the X position of the mouse
        posX = Input.mousePosition.x - distance.x;
        // calculate the Y position of the mouse
        posY = Input.mousePosition.y - distance.y;
    }

    private void OnMouseDrag()
    {
        Vector3 curPos = new Vector3(Input.mousePosition.x - posX, Input.mousePosition.y - posY, distance.z);
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
        transform.position = worldPos;
    }
}
