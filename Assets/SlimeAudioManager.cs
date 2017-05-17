using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeAudioManager : MonoBehaviour {

	public AudioSource source;

	public AudioClip appear;
	public AudioClip isHit;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void playAppear(){
		source.PlayOneShot(appear);
	}

	void playIsHit(){
		source.PlayOneShot(isHit);
	}
}
