using UnityEngine;
using UnityEngine.Events;
using Vuforia;
 
public class astro_button : MonoBehaviour
{
 
    public GameObject vbBtnObj;
    public AudioSource audioSource;
    public Animator animatorMMA;
 
    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("AstroButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        animatorMMA.GetComponent<Animator>();
    }
 
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        audioSource.Play();
        animatorMMA.Play("Dance");
        Debug.Log("Button pressed");
    }
 
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button released");
    }
}