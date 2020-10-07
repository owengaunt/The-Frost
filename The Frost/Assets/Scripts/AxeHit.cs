using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using UnityEngine;

public class AxeHit : MonoBehaviour
{
    Animator anim;
    public Camera fpscam;
    
    public bool AxeTrue = true;
    public float range = 1.5f;
    public float Damage = 10f;
    public float swingRate = 1f;

    private float nextTimetoSwing = 0f;

    public void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    
    public void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= nextTimetoSwing)
        {
            nextTimetoSwing = Time.time + 1f / swingRate;
            Hit();
        }


        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Active");
        }
    }

    
    public void Hit()
    {

        RaycastHit hit;
        if(Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range))
        {
            UnityEngine.Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                if(AxeTrue == true)
                {
                    target.TakeDamage(Damage);
                }
            }
        }
    }



    public void SetAxe()
    {
        if(AxeTrue == false)
        {
            AxeTrue = true;
        }
        if(AxeTrue == true)
        {
            AxeTrue = false;
        }
    }
    
   
}
