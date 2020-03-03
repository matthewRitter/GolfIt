using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public int maxPower;
    public int minPower;
    public int power;

    private Rigidbody golfBall;

    public bool isMoving;

    private bool increasing;
    private bool powerChanging;




    // Start is called before the first frame update
    void Start()
    {
        golfBall = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!(isMoving))
        {
            if ((Input.GetKeyDown("space")) && !(powerChanging))
            {
                powerChanging = true;
                StartCoroutine(changePower());
            }
            else if ((Input.GetKeyDown("space")) && (powerChanging))
            {
                powerChanging = false;
            }

        }
    }

    private void StartCoRoutine(IEnumerator enumerator)
    {
        throw new NotImplementedException();
    }

    private IEnumerator changePower()
    {
        while (powerChanging)
        {
            if (increasing)
            {
                if (power + 1 > maxPower)
                {
                    power--;
                    increasing = false;
                }
                else
                {
                    power++;
                }
            }
            else
            {
                if (power - 1 < minPower)
                {
                    power++;
                    increasing = true;
                }
                else
                {
                    power--;
                }
            }
            yield return new WaitForSeconds(.05f);
        }
        powerChanging = false;
    }




}
