using UnityEngine;
using System.Collections;

public class CubeMapRotation : MonoBehaviour {
	public int angle = 30;
	public int speed = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//for fixed rotation uncomment the line below:
		//Quaternion rot = Quaternion.Euler (0, angle, 0);
		
		//for animated cubemap:
		float ttt = (Time.time * speed);
		Quaternion rot = Quaternion.Euler (0, 0, ttt);
		Matrix4x4 m = new Matrix4x4 ();
		m.SetTRS(Vector3.zero, rot,new Vector3(1,1,1) );
		//
		Renderer[] renderers = transform.GetComponentsInChildren<Renderer>();
		Debug.Log(renderers.Length);
		foreach(Renderer r in renderers) {
			r.material.SetMatrix ("_Rotation", m);
		}
	}
}