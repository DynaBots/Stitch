using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class AudioPlay : MonoBehaviour {

	void Start() {
		audio.Play();
		audio.Play(44100);
	}
}
