using UnityEngine;
using System.Collections;

public class blowflame : MonoBehaviour {
	public GameObject game;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void blowing () {
		game.SetActive(false);
	}
	public void back(){
		Application.LoadLevel (0);
		game.SetActive(true);
	}
}
