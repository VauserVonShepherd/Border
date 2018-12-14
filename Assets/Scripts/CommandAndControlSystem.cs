using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandAndControlSystem : MonoBehaviour {
    [SerializeField]
    private PlayerInput playerInput;

    [SerializeField]
    private Camera mainCamera;

    [SerializeField]
    private UIManager uiManager;

    private Selectable currentSelected;
    
    private void Update()
    {
        if(!playerInput.GetSelectionInput() && !playerInput.GetMovementInput())
        {
            return;
        }

        int layer = ~(1 << LayerMask.NameToLayer("Range"));

        Ray ray = mainCamera.ScreenPointToRay(playerInput.GetInputScreenPosition());
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 1, layer);

        if (playerInput.GetSelectionInput())
        {
            if (hit && hit.collider && hit.collider.GetComponent<Selectable>())
            {
                SelectSelectable(hit.collider.GetComponent<Selectable>());
            }
        }//left click
        else if (playerInput.GetMovementInput())
        {
            if (currentSelected)
            {
                print("move");
                //move
                if (currentSelected.GetComponent<SquadUnit>())
                {
                    Vector3 pos = new Vector3(ray.origin.x, ray.origin.y, 0);
                    currentSelected.GetComponent<SquadUnit>().MoveSquad(pos);
                }
                return;
            }
        }//end right click
    }  

    private void SelectSelectable(Selectable selectable)
    {
        uiManager.ToggleSelectedDetail(selectable);
        currentSelected = selectable.Select();
    }
}
