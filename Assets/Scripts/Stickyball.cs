using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stickyball : MonoBehaviour
{
    public void Stick(GameObject ball)
    {
        Rigidbody golfBall = ball.GetComponent<Rigidbody>();
        golfBall.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
    }

    public void Reset(GameObject ball)
    {
        Rigidbody golfBall = ball.GetComponent<Rigidbody>();
        golfBall.constraints = RigidbodyConstraints.None;
    }
}
