using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLifeController : MonoBehaviour {

	public float numHP;
	public float force;

	private Rigidbody2D rgb;
	private Animator anim;
	private Collider2D coll;

	// Use this for initialization
	void Start () {
		rgb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		coll = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SendFlying(Vector3 player_pos){
		float x_dir = transform.position.x - player_pos.x;
		float y_dir = transform.position.y - player_pos.y;
		float norm = Mathf.Sqrt(x_dir*x_dir + y_dir * y_dir);
		rgb.AddForce(new Vector2(force*x_dir/norm, force*y_dir/norm));
	}

	void ApplyDamage(int damage){
		numHP-=damage;
		if (numHP <= 0){
				anim.SetBool("Death", true);
		}
		anim.SetTrigger("isHit");
	}

	void deactivateHitbox(){
		coll.enabled = false;
	}

	void reactivateHitbox(){
		coll.enabled = true;
	}

	void death(){
		Destroy(this.gameObject);
	}
}
