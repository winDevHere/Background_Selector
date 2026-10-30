using UnityEngine;

public class BackgroundPicker : MonoBehaviour
{
    [SerializeField] GameObject _forestImage;
    [SerializeField] GameObject _beachImage;

    void Start()
    {
        _forestImage.SetActive(false);
        _beachImage.SetActive(false);
    }

    public void SetForestBkg()
    {
        _forestImage.SetActive(true);
        _beachImage.SetActive(false);
    }
    public void SetBeachBkg()
    {
        _forestImage.SetActive(false);
        _beachImage.SetActive(true);
    }
    public void SetNoneBkg()
    {
        _forestImage.SetActive(false);
        _beachImage.SetActive(false);
    }
}
