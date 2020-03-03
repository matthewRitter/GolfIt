using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropball
{
    public bool isDropping = false;
    public void Drop(GameObject ball){
        Rigidbody golfBall = ball.GetComponent<Rigidbody>();
        golfBall.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
        golfBall.velocity = Vector3.zero;
        golfBall.angularVelocity = Vector3.zero;
        golfBall.Sleep();
        isDropping = true;
    }

    public void Reset(GameObject ball)
    {
        //yield return new WaitForSeconds(1f);
        Rigidbody golfBall = ball.GetComponent<Rigidbody>();
        golfBall.constraints = RigidbodyConstraints.None;
        isDropping = false;
    }
}
