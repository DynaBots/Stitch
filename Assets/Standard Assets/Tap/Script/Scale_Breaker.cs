using System;
using UnityEngine;
using TouchScript.Gestures;
using Random = UnityEngine.Random;

public class Scale_Breaker : MonoBehaviour
{
	private void OnEnable()
	{
		// subscribe to gesture's Tapped event
		GetComponent<ScaleGesture> ().ScaleStarted += tappedHandler;
		
	}
	
	private void OnDisable()
	{
		// don't forget to unsubscribe
		GetComponent<ScaleGesture>().ScaleStarted -= tappedHandler;
	}
	
	private void tappedHandler(object sender, EventArgs e)
	{
		Debug.Log ("Scaled");
	}
}
