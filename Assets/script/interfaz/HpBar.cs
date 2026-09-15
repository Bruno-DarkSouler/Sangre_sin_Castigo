using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{

    public Image fillBar;
    public PlayerStates playerStates;
    public float maxHP;
    // Start is called before the first frame update
    void Start()
    {
        maxHP = 100;
    }

    // Update is called once per frame
    void Update()
    {
        fillBar.fillAmount = playerStates.HP / maxHP;
    }
}
