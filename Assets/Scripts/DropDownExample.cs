using UnityEngine;
using TMPro;

public class DropDownExample : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropdown;
    

    void Start()
    {
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    void OnDropdownValueChanged(int index)
    {
        Debug.Log("Value changed " + index);
    }

    private void OnDestroy()
    {
        dropdown.onValueChanged.RemoveListener(OnDropdownValueChanged);
    }
}
