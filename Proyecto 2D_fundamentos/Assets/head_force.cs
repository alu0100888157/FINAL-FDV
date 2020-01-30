using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class head_force : MonoBehaviour
{
    public Rigidbody2D rb;
    public delegate void Rotacion();
    public event Rotacion on_rotacion;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
           
            rb.transform.position = new Vector3(3,3,3);
            on_rotacion(); 
            Debug.Log("Entra");
            Debug.Log(rb.transform.position);
        }
    }
}
