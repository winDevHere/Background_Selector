using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DropDownSelect : MonoBehaviour
{
    //[SerializeField] GameObject _forestImage;
    //[SerializeField] GameObject _beachImage;
    //[SerializeField] Dropdown myDropdown;

    void Start()
    {
        //_forestImage.SetActive(false);
        //_beachImage.SetActive(false);
    }

    

    public void OnDropdownValueChanged()
    {
        Debug.Log("Change");
        //if (index == 0)
        //{
        //    _forestImage.SetActive(false);
        //    _beachImage.SetActive(false);
        //    Debug.Log("None is selected");
        //}
        //else if(index == 1)
        //{
        //    _forestImage.SetActive(true);
        //    _beachImage.SetActive(false);
        //    Debug.Log("Forest is selected");
        //}
        //else
        //{
        //    _forestImage.SetActive(false);
        //    _beachImage.SetActive(true);
        //    Debug.Log("Beach is selected");
        //}
        ////Debug.Log(index);
    }
}
