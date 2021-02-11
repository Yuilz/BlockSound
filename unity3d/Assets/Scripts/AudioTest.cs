using UnityEngine;

using System.Collections;

using System.IO;

using System.Text;

public class AudioTest : MonoBehaviour
{
	private float hSliderValue = 0.5f;
	private float hSliderValue2 = 60.0f;
	private float hSliderValue3 = 60.5f;
	void Start ()
	{
		KalimbaPd.Init();
		
		//KalimbaPd.OpenFile("kalimbaTest.pd", "pd");
		KalimbaPd.OpenFile("sequenzer_00.pd", "pd");
	}

	void OnGUI ()
	{
		if (GUI.Button (new Rect (10, 10, 100, 50), "sine_on")) 
		{
			KalimbaPd.SendBangToReceiver("bang_on");
		}
		
		if (GUI.Button (new Rect (10, 10+50+10, 100, 50), "sine_off")) 
		{
			KalimbaPd.SendBangToReceiver("bang_on");
		}
		/*
		if (GUI.Button (new Rect (10, 10+50+10+50+10, 100, 50), "oggtest")) 
		{
			KalimbaPd.SendBangToReceiver("startogg");
		}
		
		hSliderValue = GUI.HorizontalSlider (new Rect (10, 10+180, 100, 50), hSliderValue, 0.0f, 1.0f);
                KalimbaPd.SendFloat(hSliderValue, "myAmp");

		GUI.Label (new Rect (20, 200, 100, 50), "Volume [0..1]");
		*/
		hSliderValue2 = GUI.HorizontalSlider (new Rect (10, 10+230, 100, 50), hSliderValue2, 0.0f, 128.0f);
                KalimbaPd.SendFloat(hSliderValue2, "note1");

		GUI.Label (new Rect (20, 250, 100, 50), "Note [0..100]");
		
		hSliderValue3 = GUI.HorizontalSlider (new Rect (10, 10+280, 100, 50), hSliderValue3, 0.0f, 128.0f);
                KalimbaPd.SendFloat(hSliderValue3, "note2");

		GUI.Label (new Rect (20, 300, 100, 50), "Note [0..100]");
	}
}
