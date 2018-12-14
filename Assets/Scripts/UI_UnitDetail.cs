using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_UnitDetail : MonoBehaviour {
    [SerializeField]
    private List<Image> AttachmentImageDetails = new List<Image>();

    public void OnDisable()
    {
        foreach(Image attachmentImg in AttachmentImageDetails)
        {
            attachmentImg.sprite = null;
        }      
    }
}
