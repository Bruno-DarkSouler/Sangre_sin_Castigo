using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float HP;
    public float hunger;
    public float thirst;

    // Start is called before the first frame update
    void Start()
    {
        HP = 100;  
    }

    // Update is called once per frame
    void Update()
    {
    }
}
