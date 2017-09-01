using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class backToMainMenu : MonoBehaviour {
	public Button quitText;
	// Use this for initialization
	void Start () {
		quitText = quitText.GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void exitGame(){
		Application.LoadLevel(0);
	}
}
