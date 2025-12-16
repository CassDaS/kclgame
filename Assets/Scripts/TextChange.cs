using UnityEngine;
using TMPro;

public class ChangeTextOnSpace : MonoBehaviour
{
    public TextMeshProUGUI textObject;
    public string newText = "Text Changed!";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (textObject != null)
            {
                textObject.text = newText;
            }
        }
    }
}
