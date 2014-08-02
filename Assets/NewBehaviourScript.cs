using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public Transform cylinder;
	
	void Start() {
		for (int y = 0; y < 5; y++) {
			for (int x = 0; x < 5; x++) {
				Instantiate(cylinder, new Vector3(x, y, 0), Quaternion.identity);
			}
		}
	}
}
