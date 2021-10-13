using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Threading.Tasks;


public class button_script_pl : MonoBehaviour
{
    private AudioSource sound_tap;
    // Start is called before the first frame update
    void Start()
    {
       sound_tap = GetComponent<AudioSource>();
    }

    // when  button tapped, this function will be called
    public void OnClick(){
        // write code here.
        // to the vs player scene(revise "addanpink" to appropriate name)
        sound_tap.PlayOneShot(sound_tap.clip);
        button_script_pl.change_scene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // delay function
    static async void change_scene(){
        await Task.Delay(350);
        SceneManager.LoadScene("Select_num");
    }
}
