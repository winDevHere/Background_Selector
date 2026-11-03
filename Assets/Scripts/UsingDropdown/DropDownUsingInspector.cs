using TMPro;
using UnityEngine;

public class DropDownUsingInspector : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropdown;
    [SerializeField] GameObject noneRawImage;
    [SerializeField] GameObject forestRawImage;
    [SerializeField] GameObject beachRawImage;

    public void OnDropdownChanged(int index)
    {
        Debug.Log($"Selected {index}: {dropdown.options[index].text}");
        if (index == 0)
        {
            noneRawImage.SetActive(true);
            forestRawImage.SetActive(false);
            beachRawImage.SetActive(false);
        }
        else if(index == 1)
        {
            noneRawImage.SetActive(false);
            forestRawImage.SetActive(true);
            beachRawImage.SetActive(false);
        }
        else
        {
            noneRawImage.SetActive(false);
            forestRawImage.SetActive(false);
            beachRawImage.SetActive(true);
        }
    }
}
