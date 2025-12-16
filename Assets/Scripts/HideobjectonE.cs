using UnityEngine;

public class HideObjectOnSpace : MonoBehaviour
{
    public GameObject objectToHide;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (objectToHide != null)
            {
                objectToHide.SetActive(false);
            }
        }
    }
}
