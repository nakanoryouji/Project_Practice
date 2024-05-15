using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpScript : MonoBehaviour
{

    public GameObject bullObject;
    public Slider slider;
    Vector3 objectPosition;
    Vector3 objectEulerAngles;


    // Start is called before the first frame update
    void Start()
    {
        objectPosition = bullObject.transform.position;
        objectEulerAngles = bullObject.transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpDown()
    {
        objectEulerAngles.x = slider.value;
    }

    public void RightLeft()
    {
        objectEulerAngles.y = -slider.value;
    }
}
