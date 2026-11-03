using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChangeTextureInDropdown : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropdown;
    [SerializeField] Texture[] textures;
    [SerializeField] RawImage myRawImage;
    
    void Start()
    {
        //dropdown.options[0].text = "Beach";
        //dropdown.options[1].text = "Black";
        //dropdown.options[2].text = "Forest";
        
        //dropdown.options[3].text = "Tree";
        //dropdown.options[2].text = "Water";
    }

    public void DropDownValueChanged()
    {
        int i = dropdown.value;
        myRawImage.texture = textures[i];
    }
}
