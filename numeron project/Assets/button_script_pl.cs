using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        SceneManager.LoadScene("addanpink");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
