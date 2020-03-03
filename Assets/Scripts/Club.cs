using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Club
{
    public Vector3 hit(Rigidbody golfBall, float force){
        return golfBall.gameObject.transform.forward * force;
    }
}
