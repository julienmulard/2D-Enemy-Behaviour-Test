using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerManager : MonoBehaviour {

	private SpriteRenderer parentRenderer;
	private SpriteRenderer renderer;

	private bool isAppearing;

	// Use this for initialization
	void Start () {
		parentRenderer = transform.parent.GetComponent<SpriteRenderer>();
		renderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
	
//		renderer.sortingOrder = parentRenderer.sortingOrder;
		renderer.sortingOrder = parentRenderer.sortingOrder+1;

	}
}
