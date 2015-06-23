using UnityEngine;
using System.Collections;

public class DancingLights : MonoBehaviour {
	Light[] magics;
	// Use this for initialization
	void Start () {
		magics = transform.GetComponentsInChildren<Light>();
		foreach(Light ml in magics) {
			ml.gameObject.transform.position = Random.insideUnitSphere*10;
		}
	}
	
	// Update is called once per frame
	void Update () {
		foreach(Light ml in magics) {
			if(Random.Range(0, 10) < 5) {
				ml.enabled = true;
			} else {
				ml.enabled = false;
			}
		}
	}
}
