using System.Collections;
using System.Collections.Generic;
using Vuforia;
using UnityEngine;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{
    private VirtualButtonBehaviour virtualBtn;
    public Animator birdAnim;
    //Se declara la variable de audiosource y audioclip para el sonido
    AudioSource audioSource;
    public AudioClip sing;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //Darle play a la animacion 
        birdAnim.SetTrigger("sing");
        //Suena el audio con una duracion de 1.9 segundos.
        audioSource.PlayOneShot(sing, 1.9F);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }

    // Use this for initialization
    void Start () {
        virtualBtn = GetComponent<VirtualButtonBehaviour>();
        virtualBtn.RegisterEventHandler(this);
        //se crea el componente de audiosource para el sonido
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
