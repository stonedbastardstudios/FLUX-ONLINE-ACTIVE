using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class DragPanelHandler : MonoBehaviour, IDragHandler {
    public GameObject character;

    public void OnDrag(PointerEventData data) {
        //Debug.Log(xMouse);

        if (data.pressPosition.x < data.position.x) {
            character.transform.eulerAngles -= new Vector3(0f, 150 * Time.deltaTime, 0f);
        } else if(data.pressPosition.x > data.position.x) {
            character.transform.eulerAngles += new Vector3(0f, 150 * Time.deltaTime, 0f);
        }
        //Debug.Log("Dragging");
    }
}
