using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitBall
{
    // Start is called before the first frame update
    Club putter = new Club();
    Superball superBall = new Superball();
    Stickyball stickyBall = new Stickyball();
    Dropball dropBall = new Dropball();


    public IEnumerator hit(string ballType, Rigidbody golfBall, int power, float x, float z)
    {
        Vector3 hitAngle = new Vector3(x, 3, z);
        Vector3 directionVector = golfBall.position - hitAngle;
        
        

        if (ballType.Equals("normal"))
        {
            golfBall.AddForce(putter.hit(golfBall, power));
            // golfBall.gameObject.transform.forward * power);
        }
        else if (ballType.Equals("super"))
        {
            golfBall.AddForce(superBall.hit(golfBall, power));
        }
        else if (ballType.Equals("sticky"))
        {
            golfBall.AddForce(putter.hit(golfBall, power));
        }
        else if (ballType.Equals("drop"))
        {
            golfBall.AddForce(putter.hit(golfBall, power));
        }
        yield return new WaitForSeconds(5f);
    }
}
