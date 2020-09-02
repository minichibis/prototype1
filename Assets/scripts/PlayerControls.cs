/** Sam Carpenter
* Assignment 1
* make the player move about
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
	public float speed;
	public float maxspeed;
	public float turnspeed;
	public float maxturnspeed;
	public float hInput;
	public float vInput;
	public bool prevspeed;
	public bool prevturn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
		hInput = Input.GetAxis("Horizontal");
		vInput = Input.GetAxis("Vertical");
		if(prevspeed){
			speed = Mathf.Lerp(speed, maxspeed, 0.05f);
		}else{
			speed = Mathf.Lerp(speed, 0, 0.05f);
		}
		if(prevturn){
			turnspeed = Mathf.Lerp(turnspeed, maxturnspeed * Mathf.Sign(hInput), 0.05f);
		}else{
			turnspeed = Mathf.Lerp(turnspeed, 0, 0.05f);
		}
		
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
		transform.Rotate(Vector3.up * turnspeed * Time.deltaTime);
		
		prevspeed = false;
		if(vInput > 0){
			prevspeed = true;
		}
		prevturn = false;
		if(hInput != 0){
			prevturn = true;
		}
		
    }
}
