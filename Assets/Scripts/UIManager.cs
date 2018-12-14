using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class UIManager : MonoBehaviour {
    public TextMeshProUGUI txt_Time;
    public TextMeshProUGUI txt_Money;
    
    public UI_UnitDetail SelectedDetail;

    [SerializeField]
    private PlayerFocusCamera m_PlayerFocusCamera;
    
    public void ToggleSelectedDetail(Selectable selectable)
    {
        if(selectable == null)
        {
            SelectedDetail.gameObject.SetActive(false);
        }
        else
        {
            SelectedDetail.gameObject.SetActive(true);
            m_PlayerFocusCamera.Target = selectable.transform;
        }
    }
}
