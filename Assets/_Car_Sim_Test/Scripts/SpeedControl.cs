using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedControl : MonoBehaviour
{

    public Rigidbody PlayerCarBody;
    private int[] controlSpeed = new int[6];
    public int controle;
    public enum ControlSelector
    {
        Control_20,
        Control_30,
        Control_40,
        Control_60,
        Control_70,
        Control_90
    }
    public ControlSelector currentControl;
    public void Start()
    {
        controlSpeed[0] = 20;
        controlSpeed[1] = 30;
        controlSpeed[2] = 40;
        controlSpeed[3] = 60;
        controlSpeed[4] = 70;
        controlSpeed[5] = 90;
    }
    public void OnTriggerEnter(Collider other)
    {
        
        switch (currentControl)
        {
            case ControlSelector.Control_20:
                SetupControl();
                if(controle == 20)
                {
                    Debug.Log("Нарушение: " + controle);
                }
                break;
            case ControlSelector.Control_30:
                SetupControl();
                if (controle == 30)
                {
                    Debug.Log("Нарушение: " + controle);
                }
                break;
            case ControlSelector.Control_40:
                SetupControl();
                if (controle == 40)
                {
                    Debug.Log("Нарушение: " + controle);
                }
                break;
            case ControlSelector.Control_60:
                SetupControl();
                if (controle == 60)
                {
                    Debug.Log("Нарушение: " + controle);
                }
                break;
            case ControlSelector.Control_70:
                SetupControl();
                if (controle == 70)
                {
                    Debug.Log("Нарушение: " + controle);
                }
                break;
            case ControlSelector.Control_90:
                SetupControl();
                if (controle == 90)
                {
                    Debug.Log("Нарушение: " + controle);
                }
                break;
        }
    }

    public int SetupControl()
    {
        float speed = Vector3.Magnitude(PlayerCarBody.velocity) * 3.6f;
        foreach (int i in controlSpeed)
        {
            if (speed > i)
            {
                Debug.Log("Speed Control: " + i);
                controle = i;
            }
            else if (speed < i)
            {
                Debug.Log("Not Current");
            }
            else
            {

            }
        }
        return controle;
    }
}
