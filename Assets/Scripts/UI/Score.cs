using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
	public Text score;
	public static int scoreCounter = 0;
    
    void Update()
    {
		if(Input.GetKeyDown(KeyCode.Escape)) Invoke("Restartlevel", 1f);
		score.text = "Score: " + scoreCounter;
    }
	
	
	
	void Restartlevel (){
		SceneManager.LoadScene("UnityScene");
		scoreCounter = 0;
	}
}
