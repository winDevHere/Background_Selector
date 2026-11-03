using UnityEngine;
using TMPro;

public class DropDownExample : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropdown;
    
    void Start()
    {
        // Listen for changes
        dropdown.onValueChanged.AddListener(OnDropdownChanged);
    }

    void OnDropdownChanged(int index)
    {
        string selectedText = dropdown.options[index].text;
        Debug.Log($"Selected index {index}: {selectedText}");
    }

    private void OnDestroy()
    {
        dropdown.onValueChanged.RemoveListener(OnDropdownChanged);
    }    
}
