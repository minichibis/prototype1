/** Sam Carpenter
* Assignment 1
* used for trigger zone stuff, BETTER
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
	public Text textbox;
	public Text scorenum;
	public int gameo = 0;
	public int scorethresh = 3;
	public int score = 0;
		
    // Update is called once per frame
     void Update()
    {
		scorenum.text = score.ToString();
		
		if(gameo == 0){
			if(score >= scorethresh){
					gameo = 1;
			}
		}else if (gameo == 1){
			textbox.text = "You Win!\nPress R...";
		} else{
			textbox.text = "You Lose!\nPress R...";
		}
		
		if(Input.GetKeyDown(KeyCode.R)){
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
    }
}
