using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : AI_Behaviour
{
    [SerializeField]
    private CharacterStatScriptableObject characterInfo;

    public SpriteRenderer m_Head;
    public SpriteRenderer m_Body;
    public SpriteRenderer m_Equipment;

    public Transform m_Range;
    
    public int m_Speed;
    public int m_Health;
    public int m_Morale;
    
    private void Start()
    {
        characterInfo.LoadCharacter(this);
    }
}
