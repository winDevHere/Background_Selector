using TMPro;
using UnityEngine;

public class BkgChange_DropDown : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropdown;
    [SerializeField] GameObject none;
    [SerializeField] GameObject forest;
    [SerializeField] GameObject beach;

    void Start()
    {
        dropdown.onValueChanged.AddListener(OnBkgSelect);
    }

    void OnBkgSelect(int index)
    {
        if (index == 1)
        {
            none.SetActive(false);
            forest.SetActive(true);
            beach.SetActive(false);
            Debug.Log(index);
        }
        else if (index == 2)
        {
            none.SetActive(false);
            forest.SetActive(false);
            beach.SetActive(true);
            Debug.Log(index);
        }
        else
        {
            none.SetActive(true);
            forest.SetActive(false);
            beach.SetActive(false);
            Debug.Log(index);
        }
    }

    private void OnDestroy()
    {
        dropdown.onValueChanged.RemoveListener(OnBkgSelect);
    }
}
