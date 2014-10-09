using UnityEngine;
using System.Collections;

public class Back : MonoBehaviour {
	
	public GUIStyle custom;
	public GUIStyle custom1;
	
	// Use this for initialization
	void Start () {
		
		
		
	}
	
	// Update is called once per frame
	
	void OnGUI () {
		//GUILayout.BeginArea( new Rect( 0, 0, Screen.height*.5f, Screen.width*.5f) );
		
	
		if (GUI.Button(new Rect(10,10, 100, 100),"Menu",custom1)){

			Application.LoadLevel("menu");

		}
		
	}
}

