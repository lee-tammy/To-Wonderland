using UnityEngine;
using System.Collections;

public class music2 : MonoBehaviour {
	public AudioSource sound;
	public AudioClip wonderlandSound;
	public AudioClip teaHouseSound;
	private bool wonderlandSoundOn;
	private bool teaHouseSoundOn;
	private gameManager2 gm;
	// Use this for initialization
	void Start () {
		sound = GetComponent<AudioSource> ();
		gm = GameObject.FindGameObjectWithTag ("GameManager2").GetComponent<gameManager2> ();
		teaHouseSoundOn = false;
		wonderlandSoundOn = false;
	}

	// Update is called once per frame
	void Update () {
		if (Application.loadedLevel == 27 || Application.loadedLevel == 36 || Application.loadedLevel==28) {
			teaHouseSoundOn = false;
			if (!wonderlandSoundOn) {
				wonderlandMusic ();
			}
		} else if (Application.loadedLevel == 37 || Application.loadedLevel == 42) {
			wonderlandSoundOn = false;
			if (!teaHouseSoundOn) {
				teaHouseMusic ();
			}
		}

	}
		

	void wonderlandMusic(){

		sound.clip = wonderlandSound;
		sound.Play ();
		wonderlandSoundOn = true;
	}

	void teaHouseMusic(){

		sound.clip = teaHouseSound;
		sound.Play ();
		teaHouseSoundOn = true;
	}

}
