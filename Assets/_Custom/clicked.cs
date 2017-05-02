using UnityEngine;
using System.Collections;

public class clicked : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void Onclickbutton(){
		Debug.Log ("clicked");
		Application.LoadLevel (1);
	}
}
