using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;


public class BackCoverButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{
  //0 = info, 1 = reviews
  int buttonToggle;

  public GameObject buttonObj;

  public GameObject infoText;

  public GameObject ratings;

  public GameObject Review1Text;
  public GameObject Review2Text;
  public GameObject Review3Text;
  public GameObject Review4Text;
  public GameObject Review5Text;
  public GameObject Review6Text;

  public GameObject text1;
  public GameObject text2;
  public GameObject text3;
  public GameObject text4;
  public GameObject text5;
  public GameObject text6;

  public GameObject videoToggleButton;

  // Start is called before the first frame update
  void Start()
    {
      buttonToggle = 0;
      buttonObj = GameObject.Find("VirtualButtonBack");
      buttonObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

      videoToggleButton = GameObject.Find("videoplayerbutton1");

    infoText = GameObject.Find("infoText");

    ratings = GameObject.Find("Ratings");

    Review1Text = GameObject.Find("review1");
    Review2Text = GameObject.Find("review2");
    Review3Text = GameObject.Find("review3");
    Review4Text = GameObject.Find("review4");
    Review5Text = GameObject.Find("review5");
    Review6Text = GameObject.Find("review6");

    text1 = GameObject.Find("text1");
    text2 = GameObject.Find("text2");
    text3 = GameObject.Find("text3");
    text4 = GameObject.Find("text4");
    text5 = GameObject.Find("text5");
    text6 = GameObject.Find("text6");

    infoText.SetActive(true);

    ratings.SetActive(false);

    Review1Text.SetActive(false);
    Review2Text.SetActive(false);
    Review3Text.SetActive(false);
    Review4Text.SetActive(false);
    Review5Text.SetActive(false);
    Review6Text.SetActive(false);

    text1.SetActive(false);
    text2.SetActive(false);
    text3.SetActive(false);
    text4.SetActive(false);
    text5.SetActive(false);
    text6.SetActive(false);

  }

  public void OnButtonPressed(VirtualButtonBehaviour vb)
  {
    //show reviews
    if(buttonToggle == 0) {
      buttonToggle = 1;
      infoText.SetActive(false);

      ratings.SetActive(true);

      Review1Text.SetActive(true);
      Review2Text.SetActive(true);
      Review3Text.SetActive(true);
      Review4Text.SetActive(true);
      Review5Text.SetActive(true);
      Review6Text.SetActive(true);

      text1.SetActive(true);
      text2.SetActive(true);
      text3.SetActive(true);
      text4.SetActive(true);
      text5.SetActive(true);
      text6.SetActive(true);

    }
    //show info
    else if(buttonToggle == 1) {
      buttonToggle = 0;
      infoText.SetActive(true);

      ratings.SetActive(false);

      Review1Text.SetActive(false);
      Review2Text.SetActive(false);
      Review3Text.SetActive(false);
      Review4Text.SetActive(false);
      Review5Text.SetActive(false);
      Review6Text.SetActive(false);

      text1.SetActive(false);
      text2.SetActive(false);
      text3.SetActive(false);
      text4.SetActive(false);
      text5.SetActive(false);
      text6.SetActive(false);

    }
    Debug.Log("button pressed");

  }

  public void OnButtonReleased(VirtualButtonBehaviour vb)
  {
    Debug.Log("button released");
  }
  void Update()
  {

  }
}
