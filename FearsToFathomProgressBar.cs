using UnityEngine;
using UnityEngine.UI;

public class FearsToFathomProgressBar : MonoBehaviour
{


    public Slider slider;

    public float duration = 12f; // the time it takes to fill 

    private float pasttime = 0f; // the time that has past


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        pasttime += Time.deltaTime; // increase 1 each second
        slider.value = Mathf.Clamp01(pasttime / duration); // The actuall function

        if(pasttime >= duration)
        {

            Debug.Log("Full");


        }

        
    }
}
