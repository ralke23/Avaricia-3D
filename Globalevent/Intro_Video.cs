using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Intro_Video : MonoBehaviour
{
    public VideoPlayer video;
    void Start()
    {
        video = GetComponent<VideoPlayer>();
        video.Play();
        video.loopPointReached += IntroductionEnd;
    }
    void IntroductionEnd(VideoPlayer video)
    {
        video.Stop();
        SceneManager.LoadScene("World_01_Avaricia");
    }
}
