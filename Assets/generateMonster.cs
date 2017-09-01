using UnityEngine;
using System.Collections;

public class generateMonster : MonoBehaviour {
	public int monsters;
	public Transform monster;
	public int maxMonsters;
	public bool spawnTime;
	// Use this for initialization
	void Start () {
		monsters=1;
		spawnTime = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (monsters < maxMonsters) {
			if (spawnTime == true) {
				Invoke ("popMonsters",0f);
			}
			Invoke ("Activate", 10f);

		}
	}

	void popMonsters(){
		Instantiate(monster,new Vector3 (transform.position.x, 3.48f, 0), Quaternion.identity);
		monsters++;
		spawnTime = false;
	}

	void subtractMonsterCount(){
		monsters--;
	}
	void Activate(){
		spawnTime = true;
	}
}
