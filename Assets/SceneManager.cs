using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {

	public GameObject randomSlime;
	public GameObject chasingSlime;

	public float maxPlayerDist;
	public float minPlayerDist;

	private Transform player;

	private int waveIndex;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player").transform;
		waveIndex = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectsWithTag("Enemy").Length <= 0){

			switch(waveIndex){

			case 0:
				StartCoroutine(sendWave(randomSlime));
				waveIndex++;
				break;

			case 1:
				StartCoroutine(sendWave(randomSlime, randomSlime));
				waveIndex++;
				break;
			
			case 2:
				StartCoroutine(sendWave(randomSlime, randomSlime, chasingSlime));
				waveIndex++;
				break;

			case 3:
				StartCoroutine(sendWave(chasingSlime,chasingSlime,chasingSlime,chasingSlime));
				waveIndex++;
				break;
			}



		}
	}


	IEnumerator sendWave(params GameObject [] enemies){
		for (int i = 0; i < enemies.Length; i++){

			float sign_x = 0;
			float sign_y = 0;

			if (Random.Range(0.0f,1.0f) > 0.5f){
				sign_x = 1;
			}
			else{
				sign_x = -1;
			}

			if (Random.Range(0.0f,1.0f) > 0.5f){
				sign_y = 1;
			}
			else{
				sign_y = -1;
			}

			float posx = player.position.x +sign_x*Random.Range(minPlayerDist, maxPlayerDist);
			float posy = player.position.y +sign_y*Random.Range(minPlayerDist, maxPlayerDist);

			Vector3 pos = new Vector3(posx, posy, 0);

			Object.Instantiate(enemies[i], pos, Quaternion.identity);

			yield  return new WaitForSeconds(0.2f);


		}
	}

}
