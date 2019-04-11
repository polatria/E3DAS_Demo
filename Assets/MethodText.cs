using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MethodText : MonoBehaviour
{
  public int method;
  private Text thisText;

  string[] status = { "ON", "OFF" };

  // Use this for initialization
  void Start()
  {
    thisText = GetComponent<Text>();
  }

  // Update is called once per frame
  void Update()
  {
    thisText.text = "Bone conduction: " + status[method];
  }
}
