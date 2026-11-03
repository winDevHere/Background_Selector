using UnityEngine;

public class DropDownObjectSwitcher : MonoBehaviour
{
    [SerializeField] GameObject[] objects;

    public void SetActiveObject(int index)
    {
        for (int i=0; i<objects.Length; i++)
        {
            objects[i].SetActive(i == index);
        }
    }

}
