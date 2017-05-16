using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalSort : MonoBehaviour {

	private SpriteRenderer sprite_renderer;

	// Use this for initialization
	void Start () {
		sprite_renderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (sprite_renderer){
			
			float height = sprite_renderer.sprite.bounds.size.y;

			sprite_renderer.sortingOrder = (int)((this.transform.position.y + height*0.5) * -100)-1;


		}
	}
}
