using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Ending_Video: MonoBehaviour
{
    public VideoPlayer videoEnd;
    void Start()
    {
        videoEnd = GetComponent<VideoPlayer>();
        videoEnd.Play();
        videoEnd.loopPointReached += Ending;
    }
    void Ending (VideoPlayer video)
    {
        video.Stop();
        SceneManager.LoadScene("World_01_Menu");
    }
}
