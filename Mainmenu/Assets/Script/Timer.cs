using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour

{
    public Slider slider;
    public float sliderValue = 100;
    // Start is called before the first frame update
    void Start()
    {
        //Calling the Timer to start counting 
        StartCoroutine(Counting());

    }
    public IEnumerator Counting()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("time out");

        while (true)
        {
            yield return new WaitForSeconds(1);
            sliderValue--;
        }
    }
        
        public void Update()
        {
            slider.value = sliderValue;
        }
    }

