using UnityEngine;
using System.Collections;
using System;

public class WatchBehaviour : MonoBehaviour {

	[Range(0.0f, 100.0f)]
	public float speed;

	public GameObject SecondHand;
	public GameObject MinuteHand;
	public GameObject HourHand;

	public Quaternion startRotation;

	// Use this for initialization
	void Awake () {
		Debug.Log ("awake");
	}



	// Use this for initialization
	void Start () {
		Debug.Log ("start");
		startRotation = transform.localRotation;
	}
	
	// Update is called once per frame
	void Update () {

		//transform.Rotate(Vector3.right * Time.deltaTime *speed);
		

		DateTime currentTime = DateTime.Now;
		float millisec = (float) Math.Round(currentTime.Millisecond/100.0);
		float second = (float)currentTime.Second + millisec / 10;
		float minute = (float) currentTime.Minute+second/60f;
		float hour = (float) currentTime.Hour%12+minute/60f;

		float secondAngle = -360 * (second / 60);
		float minuteAngle = - 360*(minute/60);
		float hourAngle = - 360*(hour/12);

		SecondHand.transform.localRotation = Quaternion.Euler(0, 0, 360-secondAngle);
		MinuteHand.transform.localRotation = Quaternion.Euler(0, 0, 360-minuteAngle);
		HourHand.transform.localRotation = Quaternion.Euler(0, 0, 360-hourAngle);
	
	}

	void On(){
		//transform.localRotation = startRotation;
		//Animator.SetTrigger("WatchAppear");
		//GetComponent<Animation>().Play();


	}

	void Off(){


	}
}
