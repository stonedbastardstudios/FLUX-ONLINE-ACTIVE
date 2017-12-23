using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class DragPanelHandler : MonoBehaviour, IDragHandler {
    public GameObject character;
    public Camera cam;

    [Range(50f, 250f)] [Tooltip("Rotation Speed Muiltiplier")]
    public float rotSpeed = 50;

    public void OnDrag(PointerEventData data) {

        if (Input.GetAxis("Mouse X") < 0) {
            character.transform.eulerAngles += new Vector3(0f, rotSpeed * Time.deltaTime, 0f);
        }

        if (Input.GetAxis("Mouse X") > 0)
        {
            character.transform.eulerAngles -= new Vector3(0f, rotSpeed * Time.deltaTime, 0f);
        }
    }
}
