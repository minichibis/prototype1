/** Sam Carpenter
* Assignment 1
* makes it only trigger once
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlyTriggerOnce : MonoBehaviour
{
	public bool triggered;
    // Start is called before the first frame update
    void Start()
    {
        triggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
