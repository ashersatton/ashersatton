using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Give_Way_Sign : MonoBehaviour
{
    public GameObject sign_way;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sign_way.GetComponent<Collider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car_Player"))
        {
            Debug.Log("Car_Stop_Enter");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Car_Player"))
        {
            Debug.Log("Car_Exit");
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Car_Player"))
        {
            Debug.Log("Car_Enter");
        }
    }
    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.CompareTag("Car_Player"))
        {
            Debug.Log("Car_Exit");
        }
    }
    private void OnCollisionStay(Collision col)
    {
        if (col.gameObject.CompareTag("Car_Player"))
        {
            Debug.Log("Car_Stay");
        }
    }
}
