using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Behaviour : Selectable
{
    public AI_Movement m_Movement;

    [HideInInspector]
    public SquadUnit m_Squad;

    public void SpawnInSquad(SquadUnit squad)
    {
        m_Squad = squad;
    }

    public override Selectable Select()
    {
        return m_Squad;
    }
}
