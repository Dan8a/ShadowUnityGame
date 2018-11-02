using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSoundScript : MonoBehaviour {

    public AudioSource jumpSound;
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Space))
        {
            jumpSound.Play();
        }
	}
}
