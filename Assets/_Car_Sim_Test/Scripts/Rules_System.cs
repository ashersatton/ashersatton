using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rules_System : MonoBehaviour
{
    public enum rulesList
    {
        Give_Way,
        Stop,
        Speed_Control,
        No_Way
    }
    [SerializeField] public rulesList rule;
    private GameObject[] Give_Way;
    private GameObject[] No_Way;
    private GameObject[] Speed_Control;
    private GameObject[] Stop;
    public Rigidbody rb;
    public GameObject car_player;
    public GameObject speed_50_text;
    public GameObject give_way_text;
    private void Start()
    {
        CheckRule();
    }
    private void Update()
    {
        car_player.GetComponent<Rigidbody>();
    }

    private void CheckRule()
    {
        if (rule == rulesList.Give_Way)
        {
            Give_Way = GameObject.FindGameObjectsWithTag("Give_Way");
            Debug.Log("Rule_Check: Give_way");
        }
        else if (rule == rulesList.No_Way)
        {
            No_Way = GameObject.FindGameObjectsWithTag("No_Way");
            Debug.Log("Rule_Check: Stop");
        }
        else if (rule == rulesList.Speed_Control)
        {
            Speed_Control = GameObject.FindGameObjectsWithTag("Speed_Control");
            Debug.Log("Rule_Check: SpeedControl");
        }
        else if (rule == rulesList.Stop)
        {
            Stop = GameObject.FindGameObjectsWithTag("Stop");
            Debug.Log("Rule_Check: Stop");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Car_Player") && rule == rulesList.Give_Way)
        {
            give_way_text.gameObject.SetActive(true);
            Debug.Log("Car_Give_Way_Enter");
        }
        else if (other.gameObject.CompareTag("Car_Player") && rule == rulesList.Speed_Control)
        {
            float speed = Vector3.Magnitude(rb.velocity);
            Debug.Log("Enter Speed: " + (int)speed*3.6f);
            
        }
    }
    public void OnTriggerStay(Collider other)
    {
         if (other.gameObject.CompareTag("Car_Player") && rule == rulesList.Speed_Control)
         {
            float speed = Vector3.Magnitude(rb.velocity) * 3.6f;
            Debug.Log("current speed: " + (int)speed);
            if ((int)speed > 50)
            {
                speed_50_text.gameObject.SetActive(true);
            }
            else
            {
                speed_50_text.gameObject.SetActive(false);
            }
         }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Car_Player") && rule == rulesList.Speed_Control)
         {
            speed_50_text.gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("Car_Player") && rule == rulesList.Give_Way)
        {
            give_way_text.gameObject.SetActive(false);
        }
    }
}
