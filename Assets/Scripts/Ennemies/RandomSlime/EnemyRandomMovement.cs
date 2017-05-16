using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandomMovement : MonoBehaviour {

	public float coarseTimeBetweenAction;
	public float randomTimeBetweenAction;

	public float speed;
	public float actionDuration;

	private bool isMoving;
	private float timeBeforeNextAction;
	private float timeBeforeEndAction;
	private Transform player;
	private Animator anim;

	private Vector2 move;

	private Rigidbody2D rgb;

	// Use this for initialization
	void Start () {
		isMoving = false;
		initTimeBeforeNextAction();

		rgb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		player = GameObject.Find("Player").transform;
		move = new Vector2(0,0);
	}

	// Update is called once per frame
	void Update () {

		timeBeforeNextAction -= Time.deltaTime;
		timeBeforeEndAction -= Time.deltaTime;

		if (timeBeforeNextAction <= 0.0f){
			computeMovement();
			initTimeBeforeEndAction();
			initTimeBeforeNextAction();
			anim.SetBool("isMoving", true);
		}
		if (timeBeforeEndAction > 0.0f){
			moveTowardsThePlayer();
		}
		else{
			//stopMoving();
			anim.SetBool("isMoving", false);
		}
	}


	void initTimeBeforeNextAction(){
		timeBeforeNextAction = coarseTimeBetweenAction + Random.Range(-randomTimeBetweenAction, randomTimeBetweenAction);
	}

	void initTimeBeforeEndAction(){
		timeBeforeEndAction = actionDuration; 
	}

	void computeMovement(){
		Vector3 player_pos = player.position;
		float x_dir = Random.Range(-1.0f,1.0f);
		float y_dir = Random.Range(-1.0f,1.0f);
		float norm = Mathf.Sqrt(x_dir*x_dir + y_dir * y_dir);

		move = new Vector2(x_dir/norm*speed, y_dir/norm*speed);
	}

	void moveTowardsThePlayer(){

		rgb.velocity = move;


		//rgb.AddForce(new Vector2(speed*x_dir/norm, speed*y_dir/norm));
	}

	void stopMoving(){
		rgb.velocity = new Vector2(0.0f,0.0f);
	}


	void registerHit(){
		timeBeforeEndAction = 0;
		initTimeBeforeNextAction();
		anim.SetBool("isMoving", false);

	}

//	void beginAppear(){
//		transform.FindChild("Shadow").SendMessage("setAppearingBoolTrue");
//	}
//	void endAppear(){
//		transform.FindChild("Shadow").SendMessage("setAppearingBoolFalse");
//	}

}
