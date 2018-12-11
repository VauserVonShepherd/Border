using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour {
    [SerializeField]
    private CharacterScriptableObject characterInfo;

    public SpriteRenderer m_Head;
    public SpriteRenderer m_Body;
    public SpriteRenderer m_Equipment;

    public Transform m_Range;

    [HideInInspector]
    public int health = 1;

    private void Start()
    {
        characterInfo.LoadCharacter(this);
    }
}
