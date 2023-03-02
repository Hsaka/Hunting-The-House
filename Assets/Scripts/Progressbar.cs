using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class Progressbar : MonoBehaviour
{
    public Image progBar;
    float currentValue;
    private readonly float speed=1;

    // Use this for initialization
    void Start()
    {
        progBar.fillAmount = currentValue / 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentValue < 10)
        {
            currentValue += speed * Time.deltaTime;
        }
        else
        {
        }

        progBar.fillAmount = currentValue / 10;
    }
}