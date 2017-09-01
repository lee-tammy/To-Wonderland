using UnityEngine;
using System.Collections;

public class music : MonoBehaviour {
	public AudioSource sound;
	public AudioClip houseSound;
	public AudioClip townSound;
	public AudioClip wonderlandSound;
	public AudioClip teaHouseSound;
	private bool wonderlandSoundOn;
	private bool teaHouseSoundOn;
	private bool houseSoundOn;
	private bool townSoundOn;
	private gameManager gm;
	private gameManager2 gm2;
	// Use this for initialization
	void Start () {
		sound = GetComponent<AudioSource> ();
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<gameManager> ();
		gm2 = GameObject.FindGameObjectWithTag ("GameManager2").GetComponent<gameManager2> ();
		houseSoundOn = false;
		townSoundOn = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.loadedLevel == 15) {
			houseSoundOn = false;
			teaHouseSoundOn = false;
			wonderlandSoundOn = false;
			if (!townSoundOn) {
				townMusic ();
			}
		} else if (Application.loadedLevel == 13 || Application.loadedLevel == 2) {
			townSoundOn = false;
			wonderlandSoundOn = false;
			teaHouseSoundOn = false;
			if (!houseSoundOn) {
				houseMusic ();
			}
		} else if (Application.loadedLevel == 27 || Application.loadedLevel == 36 || Application.loadedLevel == 28 || Application.loadedLevel == 42) {
			townSoundOn = false;
			houseSoundOn = false;
			teaHouseSoundOn = false;
			if (!wonderlandSoundOn) {
				wonderlandMusic ();
			}
		} else if (Application.loadedLevel == 37) {
			townSoundOn = false;
			houseSoundOn = false;
			wonderlandSoundOn = false;
			if (!teaHouseSoundOn) {
				teaHouseMusic ();
			}
		} else if (Application.loadedLevel == 12 || Application.loadedLevel == 14 || Application.loadedLevel == 26 || Application.loadedLevel == 43) {
			sound.Stop ();
			townSoundOn = false;
			houseSoundOn = false;
			wonderlandSoundOn = false;
			teaHouseSoundOn = false;
			if (Application.loadedLevel == 43) {
				Destroy (gameObject);
			}
		}
	}

	void townMusic()
	{
		
		sound.clip = townSound;
		sound.Play ();
		townSoundOn = true;
	}

	void houseMusic()
	{
		sound.clip = houseSound;
		sound.Play ();
		houseSoundOn = true;
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
