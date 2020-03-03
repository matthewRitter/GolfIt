using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superball : MonoBehaviour
{
    public Vector3 hit(Vector3 force, int speed){
        force.Normalize();
        force *= (10 * speed);
        return force;
    }
}
