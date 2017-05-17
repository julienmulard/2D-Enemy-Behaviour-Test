using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour {

	public float speed;

	private Animator anim;
	private Rigidbody2D rgb;
	private bool is_attacking;

	private bool canMove;


//	private Collider2D attack_hb_up;
//	private Collider2D attack_hb_down;
//	private Collider2D attack_hb_left;
//	private Collider2D attack_hb_right;



	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		rgb = GetComponent<Rigidbody2D>();
		is_attacking = false;
		canMove = true;

//		attack_hb_up = transform.FindChild("AttackUpHitBox").GetComponent<Collider2D>();
//		attack_hb_down = transform.FindChild("AttackDownHitBox").GetComponent<Collider2D>();
//		attack_hb_left = transform.FindChild("AttackLeftHitBox").GetComponent<Collider2D>();
//		attack_hb_right = transform.FindChild("AttackRightHitBox").GetComponent<Collider2D>();
//
//		attack_hb_up.enabled = false;
//		attack_hb_down.enabled = false;
//		attack_hb_left.enabled = false;
//		attack_hb_right.enabled = false;


	}
	
	// Update is called once per frame
	void Update () {
		float y_move = 0;
		float x_move = 0;
		bool is_walking = false;

		//if (is_attacking == false){
		y_move = Input.GetAxisRaw("Vertical")*speed;
		x_move = Input.GetAxisRaw("Horizontal")*speed;
		//}

		if (Input.GetButtonDown("Fire1")){
			//is_attacking = true;
			anim.SetTrigger("isAttacking");
		}

//		transform.Translate(x_move, y_move, 0);
		if (canMove == true){
			rgb.velocity = new Vector2(x_move, y_move);
		}

		if (x_move != 0 || y_move != 0){
			anim.SetFloat("moveX", x_move);
			anim.SetFloat("moveY", y_move);
			is_walking = true;
		}

		anim.SetBool("isWalking", is_walking);
//			is_last_attack_frame = false;
	}


//	void attackHitBoxEnable(){
//		float x_move = anim.GetFloat("moveX");
//		float y_move = anim.GetFloat("moveY");
//
//		if (Mathf.Abs(x_move) == Mathf.Abs(y_move)){
//			if (x_move > 0 && y_move > 0){
//				attack_hb_up.enabled = true;
//			}
//			else if(x_move > 0 && y_move < 0){
//				attack_hb_down.enabled = true;
//			}
//			else if (x_move < 0 && y_move < 0){
//				attack_hb_down.enabled = true;
//			}
//			else if(x_move < 0 && y_move > 0){
//				attack_hb_left.enabled = true;
//			}
//		}
//		else{
//			if (Mathf.Abs(x_move) > Mathf.Abs(y_move)){
//				if (x_move > 0){
//					attack_hb_right.enabled = true;
//				}
//				else{
//					attack_hb_left.enabled = true;
//				}
//			}
//			else{
//				if (y_move > 0){
//					attack_hb_up.enabled = true;
//				}
//				else{
//					attack_hb_down.enabled = true;
//				}
//			}
//		}
//	}


//	void disableHitboxes(){
//		attack_hb_up.enabled = false;
//		attack_hb_down.enabled = false;
//		attack_hb_left.enabled = false;
//		attack_hb_right.enabled = false;
//
//	}


//	void endAttack(){
//		is_attacking = false;
//		anim.SetBool("isAttacking", false);
//		is_last_attack_frame = true;
//		disableHitboxes();
//	}
//
	void stopMoving(){
		canMove = false;
		rgb.velocity = new Vector2(0,0);

	}

	void startMoving(){
		canMove = true;	
	}
}
