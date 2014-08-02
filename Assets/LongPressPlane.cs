using System;
using TouchScript.Gestures;
using TouchScript.Hit;
using UnityEngine;
using Random = UnityEngine.Random;

public class LongPressPlane : MonoBehaviour
{
	public Transform CubePrefab;
	public Transform Container;
	public float Scale = .5f;
	
	private void OnEnable()
	{
		GetComponent<LongPressGesture>().LongPressed += tappedHandler;
	}
	
	private void OnDisable()
	{
		GetComponent<LongPressGesture>().LongPressed -= tappedHandler;
	}
	
	private void tappedHandler(object sender, EventArgs e)
	{
		var gesture = sender as LongPressGesture;
		ITouchHit hit;
		gesture.GetTargetHitResult(out hit);
		var hit3d = hit as ITouchHit3D;
		if (hit3d == null) return;
		/*
		Color color = new Color(Random.value, Random.value, Random.value);
		var cube = Instantiate(CubePrefab) as Transform;
		cube.parent = Container;
		cube.name = "Cube";
		cube.localScale = Vector3.one*Scale*cube.localScale.x;
		cube.position = hit3d.Point + hit3d.Normal*.5f;
		cube.renderer.material.color = color;
		*/
		GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube.AddComponent<Rigidbody>();
		cube.transform.position = hit3d.Point + hit3d.Normal * .5f;

		Debug.Log (hit3d.Point + hit3d.Normal*.5f);
	}
}