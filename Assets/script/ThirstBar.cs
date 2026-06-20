using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirstBar : MonoBehaviour
{
    public Image fillBar;
    public PlayerStates playerStates; //Posibilidad de hacer readonly
    public float maxThirst;
    // Start is called before the first frame update
    void Start()
    {
        maxThirst = playerStates.thirst;
    }

    // Update is called once per frame
    void Update()
    {
        fillBar.fillAmount = playerStates.thirst / maxThirst;
        
    }
}
