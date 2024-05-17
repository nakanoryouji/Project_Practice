using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Fever : MonoBehaviour
{
    public Text feverCountText;
    public GameObject feverTimeObject;
    Text feverTimeText;
    public Slider slider;

    int gaugeMax = 100;
    double delay = 0.0;

    // Start is called before the first frame update
    void Start()
    {
        feverTimeObject.SetActive(false);
        feverTimeText = feverTimeObject.GetComponent<Text>();
        feverCountText.text = GlobalValue.feverCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalValue.feverFlag)
        {
            feverTimeObject.SetActive(true);
            FeverTime();
        }
    }

    public void FeverGauge()
    {
        if(GlobalValue.feverCount < gaugeMax)
        {
            GlobalValue.feverCount++;
            slider.value = GlobalValue.feverCount;

            feverCountText.text = GlobalValue.feverCount.ToString();
        }
        else
        {
            GlobalValue.feverFlag = true;
            FeverTime();
        }
    }

    public void FeverTime()
    {
        
        delay += Time.deltaTime;
        feverTimeText.text = "FEVER:" + ((GlobalValue.level / 5) - delay).ToString("f2") + "\n" + "Level~100”{";
        //Debug.Log(delay);

        if ((GlobalValue.level / 5) - delay <= 0.0)
        {
            feverTimeObject.SetActive(false);
            GlobalValue.feverFlag = false;
            GlobalValue.feverCount = 0;
            delay = 0.0;
        }
    }
}
