using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GameController : MonoBehaviour {


    public int band;
    public float startscale, scalemult;
    bool cond = true;
    public GameObject notePrefab;
    public AudioSource songPause;
	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;
    public Vector3 moveVector;
    float band1, band2, band3, band4;
    public static int gamevel = 80;
    public static int gamevel2 = 80;
	public int bandnum = 0;

	public static int numFrames = 0;
	float[] positions = new float[4];
	int x1, x2;



	void Start () {
		positions[0]= -9.02f;
		positions[1]= -2.56f;
		positions[2]= 3.41f;
		positions[3]= 9.45f;
       
	}




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        //PRIMER NIVEL DE DIFICULTAD. LOS OBJETOS VAN CAYENDO CADA VEZ MAS RAPIDO

        if (numFrames % gamevel == 0 && GameIsPaused == false){

            if (gamevel >= 40)
            {

                band1 = Audio.freqband[0] * 1;
                band2 = Audio.freqband[1] * 5;
                band3 = Audio.freqband[2] * 25;
                band4 = Audio.freqband[3] + 0.3f;
                Debug.Log("band 1: "+band1);
                Debug.Log("band 3: "+band3);
                Debug.Log("band 4: "+band4);

                if (band1 > band2 && band1 > band3 && band1 > band4)
                {
                    x1 = 0;
                    bandnum = 1;
                }
                else
                {
                }
                if (band2 > band1 && band2 > band3 && band2 > band4)
                {
                    x1 = 1;
                    bandnum = 2;
                }
                else
                {
                }
                if (band3 > band1 && band3 > band2 && band3 > band4)
                {
                    x1 = 2;
                    bandnum = 3;
                }
                else
                {
                }
                if (band4 > band1 && band4 > band2 && band4 > band3)
                {
                    x1 = 3;
                    bandnum = 4;
                }
                else
                {
                }

                gamevel -= 1;
                Debug.Log(gamevel);
                GameObject noteInst = Instantiate(notePrefab);
                noteInst.transform.position = new Vector3(positions[x1], 33.1f, 14.2f);

                //noteInst.transform.localScale.y
            }
            else
            {
                //SEGUNDA DIFICULTAD LOS OBJETOS VAN CAYENDO DE DOS EN DOS

                    band1 = Audio.freqband[0] * 1;
                    band2 = Audio.freqband[1] * 5;
                    band3 = Audio.freqband[2] * 25;
                    band4 = Audio.freqband[3] + 0.3f;
                    Debug.Log("band 1: "+band1);
                    Debug.Log("band 3: "+band3);
                    Debug.Log("band 4: "+band4);

                    if (band1 > band2 && band1 > band3 && band1 > band4)
                    {
                        x1 = 0;
                        bandnum = 1;
                    }
                    else
                    {
                    }
                    if (band2 > band1 && band2 > band3 && band2 > band4)
                    {
                        x1 = 1;
                        bandnum = 2;
                    }
                    else
                    {
                    }
                    if (band3 > band1 && band3 > band2 && band3 > band4)
                    {
                        x1 = 2;
                        bandnum = 3;
                    }
                    else
                    {
                    }
                    if (band4 > band1 && band4 > band2 && band4 > band3)
                    {
                        x1 = 3;
                        bandnum = 4;
                    }
                    else
                    {
                    }

                    //SE GENERA LA SEGUNDA BANDA

                    if (bandnum == 1 && band2 > band3 && band2 > band4)
                    {
                        x2 = 1;
                    }
                    else { }
                    if (bandnum == 1 && band3 > band2 && band3 > band4)
                    {
                        x2 = 2;
                    }
                    else { }
                    if (bandnum == 1 && band4 > band2 && band4 > band3)
                    {
                        x2 = 3;
                    }
                    else { }



                    if (bandnum == 2 && band1 > band3 && band1 > band4)
                    {
                        x2 = 0;
                    }
                    else { }
                    if (bandnum == 2 && band3 > band1 && band3 > band4)
                    {
                        x2 = 2;
                    }
                    else { }
                    if (bandnum == 2 && band4 > band1 && band4 > band3)
                    {
                        x2 = 3;
                    }
                    else { }



                    if (bandnum == 3 && band1 > band2 && band1 > band4)
                    {
                        x2 = 0;
                    }
                    else { }
                    if (bandnum == 3 && band2 > band1 && band2 > band4)
                    {
                        x2 = 1;
                    }
                    else { }
                    if (bandnum == 3 && band4 > band1 && band4 > band2)
                    {
                        x2 = 3;
                    }
                    else { }



                    if (bandnum == 4 && band1 > band2 && band1 > band3)
                    {
                        x2 = 0;
                    }
                    else { }
                    if (bandnum == 4 && band2 > band1 && band2 > band3)
                    {
                        x2 = 1;
                    }
                    else { }
                    if (bandnum == 4 && band3 > band1 && band3 > band2)
                    {
                        x2 = 2;
                    }
                    else { 
                    }


                   if(gamevel2>=40){gamevel2 -= 1;}else{}
                    Debug.Log("Vel: " + gamevel2 + " x1: " + x1 + " x2: " + x2);
                    GameObject noteInst = Instantiate(notePrefab);
                    noteInst.transform.position = new Vector3(positions[x1], 33.1f, 14.2f);
                    GameObject noteInst2 = Instantiate(notePrefab);
                    noteInst2.transform.position = new Vector3(positions[x2], 33.1f, 14.2f);

            }
        }
        else{
			
		}
        
        

		numFrames++;
	}
   
    
	void Resume()
	{
		pauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;
        songPause.Play(); 
	}

	void Pause()
	{
		pauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		GameIsPaused = true;
        if(songPause.isPlaying)
        {
            songPause.Pause();
        }   
	}
    
    
    /* 
if(band1 > 
    */
}

