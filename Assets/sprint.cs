using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class sprint : MonoBehaviour
{
    public ActionBasedContinuousMoveProvider locomotionSystem;

    void Start(){
        
    }
    
    void Update()
    {
        if(Input.GetAxis("XRI_Right_PrimaryButton") != 0){
            Debug.Log("x");
            locomotionSystem.moveSpeed = 2;
        }
        else{
            locomotionSystem.moveSpeed = 1;
        }
    }
}
