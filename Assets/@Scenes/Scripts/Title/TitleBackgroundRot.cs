using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleBackgroundRot : MonoBehaviour {

    [Range(1f, 100f)]
    public float rotSpeed = 20f;  

	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(new Vector3(0f, 0f, -rotSpeed * Time.deltaTime));
	}
}
