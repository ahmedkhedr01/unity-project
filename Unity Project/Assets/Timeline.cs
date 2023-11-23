using UnityEngine;
using UnityEngine.Playables;

public class TimelineScript : MonoBehaviour
{
    PlayableDirector director;

    void Start()
    {
        director = GetComponent<PlayableDirector>();
    }

    public void PlayTimeline()
    {
        director.Play();
    }
}