using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

	private Collider2D attack_hb_up;
	private Collider2D attack_hb_down;
	private Collider2D attack_hb_left;
	private Collider2D attack_hb_right;

	private Animator anim;

	// Use this for initialization
	void Start () {

		attack_hb_up = transform.FindChild("AttackUpHitBox").GetComponent<BoxCollider2D>();
		attack_hb_down = transform.FindChild("AttackDownHitBox").GetComponent<BoxCollider2D>();
		attack_hb_left = transform.FindChild("AttackLeftHitBox").GetComponent<BoxCollider2D>();
		attack_hb_right = transform.FindChild("AttackRightHitBox").GetComponent<BoxCollider2D>();
			
		attack_hb_up.enabled = false;
		attack_hb_down.enabled = false;
		attack_hb_left.enabled = false;
		attack_hb_right.enabled = false;

		anim = GetComponent<Animator>();
	}
	

	void attackUpHitBoxEnable(){
		attack_hb_up.enabled = true;
	}
	void attackDownHitBoxEnable(){
		attack_hb_down.enabled=true;
	}
	void attackLeftHitBoxEnable(){
		attack_hb_left.enabled=true;
	}
	void attackRightHitBoxEnable(){
		attack_hb_right.enabled=true;
	}

	void disableHitboxes(){
		attack_hb_up.enabled = false;
		attack_hb_down.enabled = false;
		attack_hb_left.enabled = false;
		attack_hb_right.enabled = false;

	}
	void Update(){
		

	}
}
