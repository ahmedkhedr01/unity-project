using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pointingTimeline;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void pointToMovie()
    {

        pointingTimeline.SetActive(true);
    }
}
