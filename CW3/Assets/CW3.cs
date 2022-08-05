using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CW3 : MonoBehaviour
{
    string heroName = "captain marvel";
    int heroPower = 30;

    string villainName = "Doctor Eve";
    int villainPower = 20;

    float playerSpeed = 12.7f;

 
    void setSpeed(float speed)
        {
            playerSpeed = speed;
        }

    void CompareSpeed()
    {
        float oldspeed = 25.2f;
        float newspeed = 23.2f;

        if (newspeed < oldspeed)
        {
            print(oldspeed);
        }

        else if (newspeed == oldspeed)
        {
            print(newspeed);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
        print("the hero's is " + heroName + " and the villain's name is " + villainName);

        //WhoTheStrongest
        if (heroPower > villainPower)
        {
            print("hero is the strongest");
        }
        else if (heroPower < villainPower)
        {
            print("villain is the strongest");
        }
        else
        {
            print("there power is equal");
        }
        setSpeed(2.5f);
        print(playerSpeed);
          
        CompareSpeed();








        }


    // Update is called once per frame
    void Update()
    {
        
    }
}
