using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;

public class ChangeTexture : MonoBehaviour
{
    [SerializeField] RawImage myRawImage;
    [SerializeField] Texture[] textures;

    void Start()
    {
        StartCoroutine(ChangeBkgSequence());
    }

    IEnumerator ChangeBkgSequence()
    {
        for (int i=0; i<textures.Length; i++)
        {
            myRawImage.texture = textures[i];
            yield return new WaitForSeconds(1);
        }
    }
}
