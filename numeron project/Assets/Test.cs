using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UI処理のクラスを使用する宣言
using UnityEngine.UI;
 
public class Test : MonoBehaviour
{
    // Image コンポーネントを格納する変数
    private Image m_Image;
    // スプライトオブジェクトを格納する配列
    public Sprite[] m_Sprite;
    // ゲーム開始時に実行する処理
    void Start()
    {
        // Image コンポーネントを取得して変数 m_Image に格納
        m_Image = GetComponent<Image>();
    }
 
    // ゲーム実行中に毎フレーム実行する処理
    public void OnClick()
    {
        m_Image.sprite = m_Sprite[0];
    }
}