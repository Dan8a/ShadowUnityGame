using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Hazardous : MonoBehaviour {

    bool dead = false;

    // Use this for initialization
    void Start () {
	}

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        
        if (hit.gameObject.tag == "hazard")
        {
            dead = true;
            Debug.Log("found a death thing");
        }
                }

    // Update is called once per frame
    void Update () {
        OnControllerColliderHit();
        if (dead)
        {
            Debug.Log("omg im literally dying");
            Vector2 v2 = new Vector2(0, 0);
            transform.position = v2;
            dead = false;
        }
	}
}