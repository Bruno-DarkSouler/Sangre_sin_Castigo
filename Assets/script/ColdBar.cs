using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColdBar : MonoBehaviour
{
    public Image fillBar;
    public PlayerStates playerStates;
    public float maxCold;
    // Start is called before the first frame update
    void Start()
    {
        maxCold = 100;
    }

    // Update is called once per frame
    void Update()
    {
        fillBar.fillAmount = playerStates.cold / maxCold;
        Debug.Log(playerStates.cold / maxCold);
    }
}
