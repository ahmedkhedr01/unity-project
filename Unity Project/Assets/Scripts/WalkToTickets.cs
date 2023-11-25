using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkToTickets : MonoBehaviour
{
    public GameObject movieChoiceCanvas;
 
    void Update()
    {
        if(transform.position.z < 1 ){
movieChoiceCanvas.SetActive(true);
        }
    }
}
