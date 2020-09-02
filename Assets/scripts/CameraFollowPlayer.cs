/** Sam Carpenter
* Assignment 1
* Moves the camera to follow the player
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
	
	public GameObject player;
	
	public Vector3 offset = new Vector3(0, 5, -10);

    // Update is called once per frame
    void Update()
    {
		transform.position = player.transform.position + offset;
    }
}
