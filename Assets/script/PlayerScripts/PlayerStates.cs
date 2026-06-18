using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStates : MonoBehaviour
{
    public float HP;
    public float hunger;
    public float thirst;
    public float cold;
    // Start is called before the first frame update
    void Start()
    {
        HP = 100;
        hunger = 50;
        thirst = 50;
        cold = 0;
    }

    //Functions for HP

    void increaseHP(float quantity)
    {
        
        if(HP + quantity >= 100)
        {
            HP = 100;
        }
        else
        {
            HP += quantity;
        }
    }

    void decreaseHP(float quantity)
    {
        
        if(HP + quantity >= 100)
        {
            HP = 100;
        }
        else
        {
            HP += quantity;
        }
    }

    //Functions for cold

    void increaseCold(float quantity)
    {
        
        if(cold + quantity >= 100)
        {
            cold = 100;
        }
        else
        {
            cold += quantity;
        }
    }

    void decreaseCold(float quantity)
    {
        
        if(cold + quantity >= 100)
        {
            cold = 100;
        }
        else
        {
            cold += quantity;
        }
    }

    //Functions for hunger

    void increaseHunger(float quantity)
    {
        
        if(hunger + quantity >= 100)
        {
            hunger = 100;
        }
        else
        {
            hunger += quantity;
        }
    }

    void decreaseHunger(float quantity)
    {
        
        if(hunger + quantity >= 100)
        {
            hunger = 100;
        }
        else
        {
            hunger += quantity;
        }
    }

    //Funcitons for thirst

    void increaseThirst(float quantity)
    {
        
        if(thirst + quantity >= 100)
        {
            thirst = 100;
        }
        else
        {
            thirst += quantity;
        }
    }

    void decreaseThirst(float quantity)
    {
        
        if(thirst + quantity >= 100)
        {
            thirst = 100;
        }
        else
        {
            thirst += quantity;
        }
    }
}
