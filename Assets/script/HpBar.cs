using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{

    public Image fillBar;
    private PlayerController playerController;
    public float maxHP;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("player").GetComponent<PlayerController>();
        maxHP = playerController.HP;
    }

    // Update is called once per frame
    void Update()
    {
        fillBar.fillAmount = playerController.HP / maxHP;
        
    }
}
