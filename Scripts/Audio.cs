using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (AudioSource))]
public class Audio : MonoBehaviour {
    AudioSource anysong;
    public static float[] samples = new float[512];
    public static float[] freqband = new float[4];
    
	// Use this for initialization
	void Start () {
        anysong = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        specAudio();
        createFreqBands();

	}

    void specAudio(){
		anysong.GetSpectrumData(samples, 0, FFTWindow.Rectangular);
    }

    void createFreqBands(){
        /*
12000/512 = 23.5
0 - 34 = 23.5*34.13 = 799
1 - 68 = 23.5*68.26 = 1598
2 - 136 = 23.5*136.53 = 3196
3 - 272 = 23.5*273.06 = 6392
         */

        int count = 0;
        for (int i = 0; i<3; i++){
            float average = 0;
            double sampcount = (int)Mathf.Pow(2,i)*34.13;

            for (int j = 0; j < sampcount; j++){
                average += samples[count];
                count++;
            }

            average /= count;
            freqband[i] = average*10;
        }
    }


}
