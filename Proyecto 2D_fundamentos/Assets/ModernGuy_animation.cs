using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModernGuy_animation : MonoBehaviour {
    public Rigidbody2D rb;
    public Animator animator;
    public head_force head_force;

    //Vector3 position;
	// Use this for initialization
	void Start () {
        head_force.on_rotacion += Rotacion;
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(this.transform.position, rb.transform.position) < 3)
        {
            animator.SetBool("Distance", true);
        }
        else
        {
            animator.SetBool("Distance", false);
        }
    }
    void Rotacion()
    {
        this.transform.rotation = Quaternion.Euler(0, 0, 90);
    }
}
