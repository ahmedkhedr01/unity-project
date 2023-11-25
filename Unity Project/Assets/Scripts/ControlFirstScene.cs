using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ControlFirstScene : MonoBehaviour
{
    public PlayableDirector timeline;
    public GameObject canvas;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeline.state != PlayState.Playing)
        {
            canvas.SetActive(true);
            animator.SetBool("idle",true);
        }
    }
}
