using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteButton : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip n_sound;
    public SpriteRenderer render; 
    public GameObject prefab;
    public float zoffset = 10;

    void Start()
    {
        render = this.gameObject.GetComponent<SpriteRenderer> ();
     //   render.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseDown(){
        audioSource.PlayOneShot(n_sound);
        transform.position = new Vector3(Random.Range(-2.1f, 2.2f), Random.Range(-1.0f, -3.7f), -0.15f);
    }
   
}
