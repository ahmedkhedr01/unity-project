using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class WalkToTickets : MonoBehaviour
{
    public GameObject movieChoiceCanvas;
    public PlayableDirector timeline;

    void Update()
    {
        if (transform.position.z < 1)
        {
            movieChoiceCanvas.SetActive(true);
        }
        if (timeline.state != PlayState.Playing)
        {
            movieChoiceCanvas.SetActive(false);
        }
    }
}
