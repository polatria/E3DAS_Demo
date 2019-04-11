using UnityEngine;

public class Demo : MonoBehaviour
{
  public GameObject[] txtObject;
  private AzimuthText aziTxt;
  private MethodText mthTxt;
  private SoundText sndTxt;

  const int AZISTEP = 15;
  int azi;
  AudioSource source;

  int set;
  string[] dataset = { "prop/", "conv/" };

  int file;
  string[] soundfile = { "wn/", "marimba/" };

  void Awake()
  {
    aziTxt = txtObject[0].GetComponent<AzimuthText>();
    mthTxt = txtObject[1].GetComponent<MethodText>();
    sndTxt = txtObject[2].GetComponent<SoundText>();
    source = GetComponent<AudioSource>();
  }

  // Use this for initialization
  void Start()
  {
    set = 0;
    file = 0;
    azi = 0;

    source.clip = Resources.Load<AudioClip>(dataset[set] + soundfile[file] + azi.ToString());
    source.Play();
  }
	
	// Update is called once per frame
	void Update()
  {
    aziTxt.azimuth = azi * AZISTEP;
    mthTxt.method = set;
    sndTxt.sound = file;

    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
      if (azi > 0)
      {
        azi--;
        source.clip = Resources.Load<AudioClip>(dataset[set] + soundfile[file] + azi.ToString());
        source.Play();
      }
      else
      {
        azi = 360 / AZISTEP - 1;
        source.clip = Resources.Load<AudioClip>(dataset[set] + soundfile[file] + azi.ToString());
        source.Play();
      }
    }
    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
      if (azi < 360 / AZISTEP - 1)
      {
        azi++;
        source.clip = Resources.Load<AudioClip>(dataset[set] + soundfile[file] + azi.ToString());
        source.Play();
      }
      else
      {
        azi = 0;
        source.clip = Resources.Load<AudioClip>(dataset[set] + soundfile[file] + azi.ToString());
        source.Play();
      }
    }

    if (Input.GetKeyDown(KeyCode.F))
    {
      if (file == 0)
      {
        file = 1;
      }
      else
      {
        file = 0;
      }
      source.clip = Resources.Load<AudioClip>(dataset[set] + soundfile[file] + azi.ToString());
      source.Play();
    }

    if (Input.GetKeyDown(KeyCode.Space))
    {
      if (set == 0)
      {
        set = 1;
      }
      else
      {
        set = 0;
      }
      source.clip = Resources.Load<AudioClip>(dataset[set] + soundfile[file] + azi.ToString());
      source.Play();
    }
  }
}
