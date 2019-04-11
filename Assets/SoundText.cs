using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundText : MonoBehaviour
{
  public int sound;
  private Text thisText;

  string[] status = { "White noise", "iPhone" };

  // Use this for initialization
  void Start()
  {
    thisText = GetComponent<Text>();
  }

  // Update is called once per frame
  void Update()
  {
    thisText.text = "Sound source: " + status[sound];
  }
}
