using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerBar : MonoBehaviour
{
    public Image fillBar;
    public PlayerStates playerStates; //Posibilidad de hacer readonly
    public float maxCold;
    // Start is called before the first frame update
    void Start()
    {
        maxCold = playerStates.cold;
    }

    // Update is called once per frame
    void Update()
    {
        fillBar.fillAmount = playerStates.cold / maxCold;
        
    }
}
