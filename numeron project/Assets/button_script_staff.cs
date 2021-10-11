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
    // Start is called before the first frame update
    void Start()
    {
        sound_tap = GetComponent<AudioSource>();
    }

    // when  button tapped, this function will be called
    public void OnClick(){
        // write code here.
        sound_tap.PlayOneShot(sound_tap.clip);
        button_script_staff.change_scene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // delay function
    static async void change_scene(){
        await Task.Delay(350);
        // Get GameObject and show with Addressables.
        // If you want more information, click here.(https://light11.hatenadiary.com/entry/2019/12/26/225232)
        Addressables
            .LoadAssetAsync<GameObject>("Image_staff") // アドレスを文字列で指定
            .Completed += op => {
                // 結果を取得してインスタンス化
                // 本来はエラーハンドリングなど必要
                Instantiate(op.Result);
            };
        // SceneManager.LoadScene("Select_num");
    }
}