using System;
using UnityEngine;
using TouchScript.Gestures;
using Random = UnityEngine.Random;

public class Tap_Show : MonoBehaviour {

	public Font font;

	private void OnEnable()
	{
		// subscribe to gesture's Tapped event
		GetComponent<TapGesture> ().Tapped += tappedHandler;
		
	}
	
	private void OnDisable()
	{
		// don't forget to unsubscribe
		GetComponent<TapGesture>().Tapped -= tappedHandler;
	}

	private void tappedHandler(object sender, EventArgs e)
	{
		// if// if we are not too small

		font = (Font)Resources.Load("Fonts/OpenSans-Regular.ttf");
		Debug.Log (e.ToString());
		var obj = new GameObject();
		var text = obj.transform;
		text.parent = transform.parent;
		//text.position = transform.position;
		text.name = "Text";
		obj.AddComponent (typeof(GUIText));
		text.GetComponent<GUIText> ().text = "This is where the cat meowed";
		text.GetComponent<GUIText> ().font = font;
		text.GetComponent<GUIText> ().fontSize = 24;
		Vector3 temp = new Vector3(0.01f,0.09f,0);
		text.GetComponent<Transform> ().position += temp;
		//Destroy (gameObject);
		//transform.rigidbody.AddForce (10 * Random.insideUnitSphere, ForceMode.VelocityChange);
		AudioSource sound = gameObject.GetComponent<AudioSource>();
		sound.Play();

		GameObject person = GameObject.Find ("First Person Controller");
		//NavMeshAgent agent = person.GetComponent<NavMeshAgent>();
		//Debug.Log (agent.name);
		//agent.SetDestination (temp);

	}
	

}
