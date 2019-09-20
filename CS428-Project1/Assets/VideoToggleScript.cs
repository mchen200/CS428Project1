using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class VideoToggleScript : MonoBehaviour, IVirtualButtonEventHandler
{
  public GameObject buttonObj;

  public GameObject video1;
  public GameObject video2;
  public GameObject video3;

  public VideoPlayer frankClip;
  public VideoPlayer markClip;
  public VideoPlayer justinClip;

  int toggleNumber;

  // Start is called before the first frame update
  void Start()
    {
    buttonObj = GameObject.Find("videoplayerbutton");
    buttonObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    toggleNumber = 0;

    video1.SetActive(true);
    video2.SetActive(false);
    video3.SetActive(false);

    frankClip.Stop();
    markClip.Stop();
    justinClip.Stop();
  }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void OnButtonPressed(VirtualButtonBehaviour vb)
  {
    toggleNumber++;
    //loops back to first video
    if(toggleNumber >= 4)
    {
      toggleNumber = 0;
      video1.SetActive(false);
      video2.SetActive(false);
      video3.SetActive(false);
      frankClip.Stop();
      markClip.Stop();
      justinClip.Stop();
    }
    else if(toggleNumber == 1)
    {
      video1.SetActive(true);
      video2.SetActive(false);
      video3.SetActive(false);
      frankClip.Play();
      markClip.Stop();
      justinClip.Stop();
    }
    else if (toggleNumber == 2)
    {
      video1.SetActive(false);
      video2.SetActive(true);
      video3.SetActive(false);
      frankClip.Stop();
      markClip.Play();
      justinClip.Stop();
    }
    else if (toggleNumber == 3)
    {
      video1.SetActive(false);
      video2.SetActive(false);
      video3.SetActive(true);
      frankClip.Stop();
      markClip.Stop();
      justinClip.Play();
    }
  }

  public void OnButtonReleased(VirtualButtonBehaviour vb)
  {
  }
}
