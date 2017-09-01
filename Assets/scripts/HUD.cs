using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUD : MonoBehaviour {
	public Sprite[] HeartSprites;
	public Image heartUI;
	private Player player;
	private gameManager2 gm;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();
		gm = GameObject.FindGameObjectWithTag ("GameManager2").GetComponent<gameManager2> ();
	}
	
	// Update is called once per frame
	void Update () {
		heartUI.sprite = HeartSprites [gm.curHealth];
	}
}
