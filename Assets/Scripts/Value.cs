using System.Collections;
using System.Collections.Generic;using System.Runtime.CompilerServices;
using UnityEngine;

public class Value : MonoBehaviour
{
    public GameObject[] Target;
    private int value = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Target.Length; i++)
        {
            Target[i].GetComponent<ConstantRotation>().Value = i + 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
