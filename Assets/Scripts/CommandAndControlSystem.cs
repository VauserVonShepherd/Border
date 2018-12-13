using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandAndControlSystem : MonoBehaviour {
    [SerializeField]
    private PlayerInput playerInput;

    [SerializeField]
    private Camera mainCamera;

    private Selectable currentSelected;
    
    private void Update()
    {
        if(!playerInput.GetSelectionInput())
        {
            return;
        }

        int layer = ~(1 << LayerMask.NameToLayer("Range"));

        Ray ray = mainCamera.ScreenPointToRay(playerInput.GetInputScreenPosition());
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 1, layer);

        if (playerInput.GetSelectionInput())
        {
            if (currentSelected)
            {
                if (currentSelected.GetComponent<SquadUnit>())
                {
                    currentSelected.GetComponent<SquadUnit>().MoveSquad(ray.origin);
                }
                return;
            }

            if (hit && hit.collider && hit.collider.GetComponent<Selectable>())
            {
                currentSelected = hit.collider.GetComponent<Selectable>().Select();
            }
        }
    }
}
