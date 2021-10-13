using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UI処理のクラスを使用する宣言
using UnityEngine.UI;
 
public class NumChoice : MonoBehaviour
{
    // Image コンポーネントを格納する変数
    private Image m_Image;
    // スプライトオブジェクトを格納する配列
    public Sprite[] m_Sprite;
    // 指定のimageのスプライトオブジェクトを変更するためのフラグ
    public static int Change;

    // ゲーム開始時に実行する処理
    void Start()
    {
        // Image コンポーネントを取得して変数 m_Image に格納
        m_Image = GetComponent<Image>();
        Change = 0;
    }


    // ゲーム実行中に毎フレーム実行する処理
    public void OnClick_waku(int number)
    {
        Change =  number;
    }

    public void OnClick_Change10(int number)
    {
        if (Change == 10){
            m_Image.sprite = m_Sprite[number];
        }         
    }
    public void OnClick_Change11(int number)
    {
        if (Change == 11){
            m_Image.sprite = m_Sprite[number];
        }         
    }
    public void OnClick_Change12(int number)
    {
        if (Change == 12){
            m_Image.sprite = m_Sprite[number];
        }         
    }
}