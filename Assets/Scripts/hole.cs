using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole : MonoBehaviour
{

    public float radius = 1;
    private GameObject parent;


    // Start is called before the first frame update
    void Start()
    {
        parent = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeRadius(float newRadius)
    {
        radius = newRadius;
        Vector3 newScale = new Vector3(radius, radius, radius);
        gameObject.transform.localScale = newScale;
        parent.transform.localScale = newScale;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("GolfBall"))
        {
            print("You made it!");
            //Script to move to the next hole
        }
    }


}
