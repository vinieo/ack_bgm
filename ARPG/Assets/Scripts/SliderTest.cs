using UnityEngine;
using System.Collections;

public class SliderTest : MonoBehaviour {
	public AudioSource audio;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void GetSliderValue(float value){
		audio.volume = value;
	}
}
