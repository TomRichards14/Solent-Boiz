using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLadder : MonoBehaviour {
    public bool GoingLeft = false;
    public bool GoingRight = true;
	void Update () {
        if (GoingLeft == true)
        {
            GoLeft();
        }
        if (GoingRight == true)
        {
            GoRight();
        }
    }
    //CHANGE DIRECTION WHEN THE PLATFORM COLLIDES WITH THE BARRIERS
    private void OnCollisionEnter(Collision collision)
    {
        if (GoingLeft == true)
        {
            GoingLeft = false;
            GoingRight = true;
        }
        else if (GoingRight == true)
        {
            GoingRight = false;
            GoingLeft = true;
        }
    }
    void GoLeft()
    {
        transform.Translate(Vector3.right * Time.deltaTime);
    }
    void GoRight()
    {
        transform.Translate(Vector3.right * -Time.deltaTime);
    }
}
