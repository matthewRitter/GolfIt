using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropball : MonoBehaviour
{
    public void Drop(GameObject ball){
        Rigidbody golfBall = ball.GetComponent<Rigidbody>();
        golfBall.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
    }
}
