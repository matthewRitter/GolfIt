using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stickyball
{
    public void Stick(GameObject ball)
    {
        Rigidbody golfBall = ball.GetComponent<Rigidbody>();
        golfBall.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        golfBall.velocity = Vector3.zero;
        golfBall.angularVelocity = Vector3.zero;
        golfBall.Sleep();
    }

    public IEnumerator Reset(GameObject ball)
    {
        yield return new WaitForSeconds(1f);
        Rigidbody golfBall = ball.GetComponent<Rigidbody>();
        golfBall.constraints = RigidbodyConstraints.None;
    }
}
