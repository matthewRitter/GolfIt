using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Club : MonoBehaviour
{
    public Vector3 hit(Vector3 force, int speed){
        force.Normalize();
        force *= speed;
        return force;
    }
}
