using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public GameObject instructions;
    public AudioSource audioSource;
    public AudioClip clip;
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;
    public AudioClip clip5;
    public AudioClip clip6;
    public AudioClip clip7;

    

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Audio")
        {
            instructions.SetActive(true);
            
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                audioSource.Stop();
                audioSource.PlayOneShot(clip);
            }     
        }
        else if(other.tag == "Audio 1")
        {
            instructions.SetActive(true);

            

            if (Input.GetKeyDown(KeyCode.E))
            {
                audioSource.Stop();
                audioSource.PlayOneShot(clip1);
               
            }
        }
        else if (other.tag == "Audio 2")
        {
            instructions.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                audioSource.Stop();
                audioSource.PlayOneShot(clip2);
            }
        }
        else if (other.tag == "Audio 3")
        {
            instructions.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                audioSource.Stop();
                audioSource.PlayOneShot(clip3);
            }
        }
        else if (other.tag == "Audio 4")
        {
            instructions.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                audioSource.Stop();
                audioSource.PlayOneShot(clip4);
            }
        }
        else if (other.tag == "Audio 5")
        {
            instructions.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                audioSource.Stop();
                audioSource.PlayOneShot(clip5);
            }
        }
        else if (other.tag == "Audio 6")
        {
            instructions.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                audioSource.Stop();
                audioSource.PlayOneShot(clip6);
            }
        }
        else if (other.tag == "Audio 7")
        {
            instructions.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                audioSource.Stop();
                audioSource.PlayOneShot(clip7);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Audio" || other.tag == "Audio 1" || other.tag == "Audio 2" || other.tag == "Audio 3" || other.tag == "Audio 4" || other.tag == "Audio 5" || other.tag == "Audio 6" || other.tag == "Audio 7")
        {
            instructions.SetActive(false);
        }
    }
}
