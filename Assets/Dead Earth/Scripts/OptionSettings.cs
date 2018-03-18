using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class OptionSettings : MonoBehaviour
{
    public PostProcessingBehaviour effect;

    void Awake()
    {
        if (PlayerPrefs.GetInt("CameraEffects") == 1)
        {
            effect.enabled = true;
            //camera.GetComponent<CameraBloodEffect>().enabled = true;
            
        }
        else if (PlayerPrefs.GetInt("CameraEffects") == 0)
        {
            effect.enabled = false;
            //camera.GetComponent<CameraBloodEffect>().enabled = false;
        }

        if (PlayerPrefs.GetInt("MotionBlur") == 1)
        {
            //MotionBlur is on
            effect.profile.motionBlur.enabled = true;

        }
        else if (PlayerPrefs.GetInt("MotionBlur") == 0)
        {
            //MOtionBlur is off
            effect.profile.motionBlur.enabled = false;
        }
        if (PlayerPrefs.GetInt("AmbientOcclusion") == 1)
        {
            //MotionBlur is on
            effect.profile.ambientOcclusion.enabled = true;

        }
        else if (PlayerPrefs.GetInt("AmbientOcclusion") == 0)
        {
            //MOtionBlur is off
            effect.profile.ambientOcclusion.enabled = false;
        }


        if (PlayerPrefs.GetInt("Bloom") == 1)
        {
            //MotionBlur is on
            effect.profile.bloom.enabled = true;

        }
        else if (PlayerPrefs.GetInt("Bloom") == 0)
        {
            //MOtionBlur is off
            effect.profile.bloom.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("CameraEffects") == 1)
        {
            //Effects are on
            effect.enabled = true;

        }
        else if (PlayerPrefs.GetInt("CameraEffects") == 0)
        {
            //Effects are off
            effect.enabled = false;
        }

        if (PlayerPrefs.GetInt("MotionBlur") == 1)
        {
            //MotionBlur is on
            effect.profile.motionBlur.enabled = true;

        }
        else if (PlayerPrefs.GetInt("MotionBlur") == 0)
        {
            //MOtionBlur is off
            effect.profile.motionBlur.enabled = false;
        }
        if (PlayerPrefs.GetInt("AmbientOcclusion") == 1)
        {
            //MotionBlur is on
            effect.profile.ambientOcclusion.enabled = true;

        }
        else if (PlayerPrefs.GetInt("AmbientOcclusion") == 0)
        {
            //MOtionBlur is off
            effect.profile.ambientOcclusion.enabled = false;
        }


        if (PlayerPrefs.GetInt("Bloom") == 1)
        {
            //MotionBlur is on
            effect.profile.bloom.enabled = true;

        }
        else if (PlayerPrefs.GetInt("Bloom") == 0)
        {
            //MOtionBlur is off
            effect.profile.bloom.enabled = false;
        }

    }
}
