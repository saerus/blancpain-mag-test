using UnityEngine;
using System.Collections;

public class lightMovement : MonoBehaviour {
	Quaternion mine;

	// Use this for initialization
	void Start () {
		mine = transform.rotation;
	}	
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0, Mathf.Sin(Time.frameCount/100f)/10f, 0);
	}
}
