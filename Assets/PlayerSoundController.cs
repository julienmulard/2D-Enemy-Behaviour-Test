using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundController : MonoBehaviour {

	public AudioSource source;

	public AudioClip swordSlash;
	public AudioClip isHit;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void playSwordSlash(){
		source.PlayOneShot(swordSlash);
	}

	void playIsHit(){
		source.PlayOneShot(isHit);
	}
}
