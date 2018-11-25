using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(!GameController.GameIsPaused)
        {
		this.transform.Translate(new Vector3(0, -0.5f, 0)); 
        }
	}
}
