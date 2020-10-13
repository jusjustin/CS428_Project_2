using UnityEngine;
using UnityEngine.Events;
using Vuforia;
 
public class astro_button : MonoBehaviour
{
 
    public GameObject vbBtnObj;
    public AudioSource audioSource;
 
    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("AstroButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }
 
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        audioSource.Play();
        Debug.Log("Button pressed");
    }
 
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button released");
    }
}