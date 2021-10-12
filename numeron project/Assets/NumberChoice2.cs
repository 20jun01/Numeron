using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UI処理のクラスを使用する宣言
using UnityEngine.UI;
 
public class NumberChoice2 : MonoBehaviour
{
    // Image コンポーネントを格納する変数
    private Image m_Image;
    // スプライトオブジェクトを格納する配列
    public Sprite[] m_Sprite;
    // スプライトオブジェクトを変更するためのフラグ
    bool Change;
 
    // ゲーム開始時に実行する処理
    void Start()
    {
        // Image コンポーネントを取得して変数 m_Image に格納
        m_Image = GetComponent<Image>();
        Change = false;
    }
 
    // ゲーム実行中に毎フレーム実行する処理
    public void OnClick(int number)
    {
        if (Change == true){
            switch (number)
            {
                case 0:
                    m_Image.sprite = m_Sprite[0];
                    break;
                case 1:
                    m_Image.sprite = m_Sprite[1];
                    break;
                case 2:
                    m_Image.sprite = m_Sprite[2];
                    break;
                case 3:
                    m_Image.sprite = m_Sprite[3];
                    break;
                case 4:
                    m_Image.sprite = m_Sprite[4];
                    break;
                case 5:
                    m_Image.sprite = m_Sprite[5];
                    break;
                case 6:
                    m_Image.sprite = m_Sprite[6];
                    break;
                case 7:
                    m_Image.sprite = m_Sprite[7];
                    break;
                case 8:
                    m_Image.sprite = m_Sprite[8];
                    break;
                case 9:
                    m_Image.sprite = m_Sprite[9];
                    break;
                default:
                    break;
            }
        }
    }

    // ゲーム実行中に毎フレーム実行する処理
    public void OnClick_waku2(int number)
    {
        if(number == 11){
            Change = true;
        }
        else if(number == 10 || number == 12){
            Change = false;
        }
    }
}