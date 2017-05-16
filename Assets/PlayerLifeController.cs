using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeController : MonoBehaviour {

	public int numHP;

	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ApplyDamage(int damage){
		numHP--;
		if (numHP <= 0){
			anim.SetTrigger("Death");
			this.transform.gameObject.SendMessage("stopMoving");
		}
		anim.SetTrigger("isHit");
		this.transform.gameObject.SendMessage("stopMoving");


	}
}
