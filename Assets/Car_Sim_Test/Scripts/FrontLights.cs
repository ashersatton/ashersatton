using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontLights : MonoBehaviour
{
    public GameObject[] redLight;
    public GameObject[] yellowLight;
    public GameObject[] greenLight;
    private void Awake()
    {
        redLight = GameObject.FindGameObjectsWithTag("Red_Front");
        yellowLight = GameObject.FindGameObjectsWithTag("Yellow_Front");
        greenLight = GameObject.FindGameObjectsWithTag("Green_Front");
    }    
    void Start()
    {
        StartCoroutine(lightSwitchFront());
    }

    IEnumerator lightSwitchFront()
    {
        while (true)
        {
            //красный
            foreach (GameObject redLight in redLight) { redLight.SetActive(true); }
            foreach (GameObject yellowLight in yellowLight) { yellowLight.SetActive(false); }
            foreach (GameObject greenLight in greenLight) { greenLight.SetActive(false); }
            yield return new WaitForSeconds(10);
            //красный+желтый
            foreach (GameObject redLight in redLight) { redLight.SetActive(true); }
            foreach (GameObject yellowLight in yellowLight) { yellowLight.SetActive(true); }
            foreach (GameObject greenLight in greenLight) { greenLight.SetActive(false); }
            yield return new WaitForSeconds(2);
            //зеленый
            foreach (GameObject redLight in redLight) { redLight.SetActive(false); }
            foreach (GameObject yellowLight in yellowLight) { yellowLight.SetActive(false); }
            foreach (GameObject greenLight in greenLight) { greenLight.SetActive(true); }
            yield return new WaitForSeconds(10);
            //желтый
            foreach (GameObject redLight in redLight) { redLight.SetActive(false); }
            foreach (GameObject yellowLight in yellowLight) { yellowLight.SetActive(true); }
            foreach (GameObject greenLight in greenLight) { greenLight.SetActive(false); }
            yield return new WaitForSeconds(5);
        }
    }
    /*public void FindLights()
    {
        redLight = GameObject.FindGameObjectWithTag("Red_Front");
        yellowLight = GameObject.FindGameObjectWithTag("Yellow_Front");
        greenLight = GameObject.FindGameObjectWithTag("Green_Front");
    }*/
}
