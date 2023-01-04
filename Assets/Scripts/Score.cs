using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.VFX;

public class Score : MonoBehaviour
{
    private int _scoreValue = 0;
    public Text scoreText;
    public GameObject winMessage;
    public GameObject[] Mur;
    public GameObject[] Target;
    private int value = 0;
    
    void Start()
    {
        for (int i = 0; i < Target.Length; i++)
        {
            Target[i].GetComponent<ConstantRotation>().Value = i + 1;
        }
    }

    public void UpScore(int value)
    {
        _scoreValue += value ;
        scoreText.text = "Score : " + _scoreValue.ToString();
        if (_scoreValue >= 12)
        {
            winMessage.SetActive(true);
        }

        if (_scoreValue % 2 == 0)
        {
            for (int i = _scoreValue-2 ; i <_scoreValue ; i++)
            {
                Mur[i+0].SetActive(true);
            }
        }

    }
}
