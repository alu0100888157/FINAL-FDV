using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate_camera : MonoBehaviour
{

    public GameObject jugador1;
    public GameObject jugador2;
    public GameObject jugador12;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            jugador12.SetActive(true);
            jugador2.SetActive(false);
            jugador1.SetActive(false);
        }
        if (Input.GetKey(KeyCode.K))
        {
            jugador2.SetActive(true);
            jugador12.SetActive(false);
            jugador1.SetActive(false);
        }
        if (Input.GetKey(KeyCode.I))
        {
            jugador1.SetActive(true);
            jugador12.SetActive(false);
            jugador2.SetActive(false);
        }
        
    }
}
