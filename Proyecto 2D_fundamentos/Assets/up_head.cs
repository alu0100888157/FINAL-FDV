using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class up_head : MonoBehaviour
{
    public GameObject cabeza;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jump(GameObject cabeza2)
    {
        cabeza2.transform.position= new Vector3(3, 3, 3); 
        //cabeza2.transform.position.x = 3;
        //cabeza2.transform.position.y = 3;
        Debug.Log("ha saltado");
        Debug.Log(cabeza2.transform.position);
    }
}
