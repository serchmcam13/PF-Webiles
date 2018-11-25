using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
     
    public GameObject overMenu;
    public GameObject player;
    public GameObject respawn;
    public Button start;
    public GameObject obstacles;
    public AudioSource song;
    
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("I hit "+ col.gameObject.tag);
            overMenu.SetActive (true);
		    Time.timeScale = 0f;
		    GameController.GameIsPaused = true;
            song.Stop();
            col.gameObject.GetComponent<AudioSource>().Play();
            Destroy(col.gameObject);
            obstacles = GameObject.FindGameObjectWithTag("Obstacle");
            DestroyObject(obstacles);
        }  
    }
    
    
    public void StartOver()
    {
        
        player.transform.position = respawn.transform.position;
        overMenu.SetActive (false);
        Time.timeScale = 1f;
        GameController.GameIsPaused = false;
        GameController.gamevel = 80;
        GameController.gamevel2 = 80;
        GameController.numFrames = 0;

        Movement.counter = 1;
        song.Play();
        
        /* C+omo destruir todos los notes*/
    
        
    }
    
    private void ResetGame()
    {
        SceneManager.LoadScene("Level");
    }
    
}
