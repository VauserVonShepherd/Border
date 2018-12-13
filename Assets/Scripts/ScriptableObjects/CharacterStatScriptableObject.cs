using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterInfo", menuName = "Character", order = 1)]
public class CharacterStatScriptableObject : ScriptableObject {
    [SerializeField]
    private Sprite head;
    [SerializeField]
    private Sprite body;
    [SerializeField]
    private Sprite Equipment;

    [SerializeField]
    private int range = 0;
    [SerializeField]
    private int health = 1;
    [SerializeField]
    private int morale = 1;
    [SerializeField]
    private int speed = 1;

    public void LoadCharacter(Characters character)
    {
        character.m_Head.sprite = head;
        character.m_Body.sprite = body;
        character.m_Equipment.sprite = Equipment;

        character.m_Range.localScale = new Vector3(range, range, 1);
        character.m_Health = health;
        character.m_Speed = speed;
        character.m_Morale = morale;
    } 
}
