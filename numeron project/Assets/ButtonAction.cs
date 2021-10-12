using UnityEngine;
using UnityEngine.UI;
public class ButtonAction : MonoBehaviour
{
    public void OnButtonClick() {
        ChangeRandomColor();
    }

    void ChangeRandomColor() {
        var r = Random.Range(0f, 1f);
        var g = Random.Range(0f, 1f);
        var b = Random.Range(0f, 1f);
        GetComponent<Image>().color = new Color(r, g, b); 
    }
}