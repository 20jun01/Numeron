using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script_Enter : MonoBehaviour
{
    public int sel_pl = 0;
    public static int[,] pl_nums = new int[2, 3];
    public bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick(){
        // write code here on click
        // 入力された数字が有効を確認する変数flag
        if(sel_pl == 0 && flag == true){
            // 数字を取得(未実装)
            sel_pl = 1;
            SceneManager.LoadScene("Select_num");
        }else if(sel_pl == 1 && flag == true){
            // 数字を取得(未実装)
            // next scene
            SceneManager.LoadScene("addanpink"); 
        }else{
            // errror message
        }
        // SceneManager.LoadScene("addanpink"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
