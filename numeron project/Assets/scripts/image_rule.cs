using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class image_rule : MonoBehaviour
{
    [SerializeField] GameObject Image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick(){
        this.gameObject.SetActive(false);
        Image.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
