using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class quitMenu : MonoBehaviour {
	public Canvas menu;
	public Button startText;
	public Button quitText;
	// Use this for initialization
	void Start () {
		menu = menu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		quitText = quitText.GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void exitPress(){
		menu.enabled = true;
		startText.enabled = false;
		quitText.enabled = false;
	}

	public void noPress(){
		menu.enabled = false;
		startText.enabled = true;
		quitText.enabled = true;
	}

	public void startGame(){
		Application.LoadLevel (1);
	}

	public void exitGame(){
		Application.Quit ();
	}
}
