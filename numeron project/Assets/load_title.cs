using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Threading.Tasks;

public class load_title : MonoBehaviour
{
    private AudioSource sound_tap;
    // Start is called before the first frame update
    void Start()
    {
        sound_tap = GetComponent<AudioSource>();
    }

    public void OnClick(){
        sound_tap.PlayOneShot(sound_tap.clip);
        load_title.change_scene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    static async void change_scene(){
        await Task.Delay(350);
        SceneManager.LoadScene("Title");
    }
}
