using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandomMovement : MonoBehaviour {

	public float coarseTimeBetweenAction;
	public float randomTimeBetweenAction;

	public float speed;

	private bool isMoving;
	private float timeBeforeNextAction;

	private Rigidbody2D rgb;

	// Use this for initialization
	void Start () {
		isMoving = false;
		computeTimeBeforNextAction();
		rgb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		timeBeforeNextAction -= Time.deltaTime;
		if (timeBeforeNextAction <= 0.0f){
			moveInRandomDirection();
			computeTimeBeforNextAction();
		}
	}


	void computeTimeBeforNextAction(){
		timeBeforeNextAction = coarseTimeBetweenAction + Random.Range(-randomTimeBetweenAction, randomTimeBetweenAction);
	}

	void moveInRandomDirection(){
		float x_dir = Random.Range(-1.0f,1.0f);
		float y_dir = Random.Range(-1.0f,1.0f);
		float norm = Mathf.Sqrt(x_dir*x_dir + y_dir * y_dir);

		rgb.AddForce(new Vector2(speed*x_dir/norm, speed*y_dir/norm));
	}

}
