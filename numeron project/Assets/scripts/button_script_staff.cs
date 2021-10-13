using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Threading.Tasks;
// Addressables
using UnityEngine.AddressableAssets;

public class button_script_staff : MonoBehaviour
{
    private AudioSource sound_tap;
    [SerializeField] GameObject Image;
    // Start is called before the first frame update
    void Start()
    {
        sound_tap = GetComponent<AudioSource>();
    }

    // when  button tapped, this function will be called
    public void OnClick(){
        // write code here.
        sound_tap.PlayOneShot(sound_tap.clip);
        // button_script_staff.change_scene();
        Image.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}