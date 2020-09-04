/** Sam Carpenter
* Assignment 1
* used for trigger zone stuff, also does falling off clif for convienence
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEnterTrigger : MonoBehaviour{
	public Text textbox;
    // Update is called once per frame
    void Update(){
		if (transform.position.y < -1 && GetComponent<ScoreManager>().gameo == 0){
			GetComponent<ScoreManager>().gameo = -1;
		}
    }
	
	private void OnTriggerEnter(Collider other){
		if(other.CompareTag("Finish") && GetComponent<ScoreManager>().gameo == 0 && !other.GetComponent<OnlyTriggerOnce>().triggered){
			GetComponent<ScoreManager>().score++;
			other.GetComponent<OnlyTriggerOnce>().triggered = true;
		}
	}
}
