using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AzimuthText : MonoBehaviour
{
  public int azimuth;
  private Text thisText;

  // Use this for initialization
	void Start()
  {
    thisText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update()
  {
    thisText.text = "Azimuth: " + azimuth.ToString() + " deg";
	}
}
