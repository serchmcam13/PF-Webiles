using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	bool end;
	public GameObject player;
    
	public static int counter = 1;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (Input.GetKeyDown ("right") && counter == 1) 
		{
			Vector3 moveRight2 = new Vector3 (5.97f, 0, 0);
			player.transform.Translate (moveRight2);
			counter = 2;
		}else

		if (Input.GetKeyDown ("left") && counter == 1) 
		{
			Vector3 moveleft = new Vector3 (-6.46f, 0, 0);
			player.transform.Translate (moveleft);
			counter = 0;
			}else

		if (Input.GetKeyDown ("right") && counter == 0) 
		{
			Vector3 moveRight1 = new Vector3 (6.46f, 0, 0);
			player.transform.Translate (moveRight1);
			counter = 1;
				}else

		if (Input.GetKeyDown ("left") && counter == 2) 
		{
			Vector3 moveLeft1 = new Vector3 (-5.97f, 0, 0);
			player.transform.Translate (moveLeft1);
			counter = 1;
					}else

		if (Input.GetKeyDown ("right") && counter == 2) 
		{
			Vector3 moveRight3 = new Vector3 (6.04f, 0, 0);
			player.transform.Translate (moveRight3);
			counter = 3;
						}else

		if (Input.GetKeyDown ("left") && counter == 3) 
		{
			Vector3 moveleft2 = new Vector3 (-6.04f, 0, 0);
			player.transform.Translate (moveleft2);
			counter = 2;
		}



	}
    
    

	
}
