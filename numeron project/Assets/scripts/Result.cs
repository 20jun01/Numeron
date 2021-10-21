using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class Result : MonoBehaviour
{
    public Image winplayer;
    public Image player1;
    public Image player2;
    // Start is called before the first frame update
    void Start()
    {
     if(!NumChoice.flag_p){
         winplayer.sprite=player1.sprite;
     }   else {
         winplayer.sprite=player2.sprite;
     }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
