using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OppositeLights : MonoBehaviour
{
    public GameObject[] redLight;
    public GameObject[] yellowLight;
    public GameObject[] greenLight;
    private void Awake()
    {
        redLight = GameObject.FindGameObjectsWithTag("Red_Opp");
        yellowLight = GameObject.FindGameObjectsWithTag("Yellow_Opp");
        greenLight = GameObject.FindGameObjectsWithTag("Green_Opp");
    }
    void Start()
    {
        StartCoroutine(lightSwitchOpposite());

    }

    IEnumerator lightSwitchOpposite()
    {
        while (true)
        {
            //зеленый
            foreach (GameObject redLight in redLight) { redLight.SetActive(false); }
            foreach (GameObject yellowLight in yellowLight) { yellowLight.SetActive(false); }
            foreach (GameObject greenLight in greenLight) { greenLight.SetActive(true); }
            yield return new WaitForSeconds(10);
            //желтый
            foreach (GameObject redLight in redLight) { redLight.SetActive(false); }
            foreach (GameObject yellowLight in yellowLight) { yellowLight.SetActive(true); }
            foreach (GameObject greenLight in greenLight) { greenLight.SetActive(false); }
            yield return new WaitForSeconds(2);
            //красный
            foreach (GameObject redLight in redLight) { redLight.SetActive(true); }
            foreach (GameObject yellowLight in yellowLight) { yellowLight.SetActive(false); }
            foreach (GameObject greenLight in greenLight) { greenLight.SetActive(false); }
            yield return new WaitForSeconds(10);
            //красный+желтый
            foreach (GameObject redLight in redLight) { redLight.SetActive(true); }
            foreach (GameObject yellowLight in yellowLight) { yellowLight.SetActive(true); }
            foreach (GameObject greenLight in greenLight) { greenLight.SetActive(false); }
            yield return new WaitForSeconds(5);

        }
    }
}
