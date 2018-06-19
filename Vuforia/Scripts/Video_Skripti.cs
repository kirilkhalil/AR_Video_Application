using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class Video_Skripti : DefaultTrackableEventHandler{

    private VideoPlayer videoPlayer;

    //public Button playNappi;
    // Use this for initialization
    protected override void Start(){

        base.Start();
        videoPlayer = FindObjectOfType<VideoPlayer>().GetComponent<VideoPlayer>();
    }

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        if (videoPlayer) videoPlayer.Play();
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        if (videoPlayer) videoPlayer.Pause();
    }


    // Update is called once per frame
    /* void Update() {

         if (videoPlayer.isPlaying)
         {
             ShowPlayButton(false);

         }

         else
         {
             ShowPlayButton(true);
         }
     }

     void OnApplicationPause(bool pause)
     {
         if (pause)
             Pause();
     }

     public void Play()
     {      
         //PauseAudio(false);
         videoPlayer.Play();
         ShowPlayButton(false);
     }

     public void Pause()
     {
         if (videoPlayer)
         {
             //PauseAudio(true);
             videoPlayer.Pause();
             ShowPlayButton(true);
         }
     }

     private void ShowPlayButton(bool enable)
     {
         playNappi.enabled = enable;
         playNappi.GetComponent<Image>().enabled = enable;
     }*/
}