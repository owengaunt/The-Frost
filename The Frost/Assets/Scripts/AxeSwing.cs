using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeSwing : MonoBehaviour
{
    public GameObject TheAxe;
    CharacterInput characterinput;

   void Start()
    {
        characterinput = GetComponent<CharacterInput>();
    }
        
// Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(characterinput.axeswing))
        {
            TheAxe.GetComponent<Animator>().Play("AxeSwing");
        }
    }

}
