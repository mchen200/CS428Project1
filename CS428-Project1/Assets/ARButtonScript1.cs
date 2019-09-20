using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARButtonScript1 : MonoBehaviour, IVirtualButtonEventHandler
{
  public GameObject buttonObj;
  public GameObject spokesNinja;
  public AudioClip intro;
  private AudioSource source { get { return GetComponent<AudioSource>(); } }

  public bool isOn;

  // Start is called before the first frame update
  void Start()
  {
    buttonObj = GameObject.Find("ARButton");
    buttonObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    spokesNinja = GameObject.Find("SpokesNinja");

    gameObject.AddComponent<AudioSource>();
    source.clip = intro;
    source.playOnAwake = false;
    spokesNinja.SetActive(false);
    isOn = false;
  }

  public void OnButtonPressed(VirtualButtonBehaviour vb)
  {
    isOn = !isOn;
    if (isOn)
    {
      //probably play video here
      source.PlayOneShot(intro);
      Debug.Log("button pressed");
      spokesNinja.SetActive(true);
    }
    else
    {
      source.Stop();
      spokesNinja.SetActive(false);
      Debug.Log("button released");
    }
  }
  public void OnButtonReleased(VirtualButtonBehaviour vb)
  {

  }
  // Update is called once per frame
  void Update()
  {

  }
}
