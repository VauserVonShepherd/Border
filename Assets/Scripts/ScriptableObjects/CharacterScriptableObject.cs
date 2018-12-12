using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterInfo", menuName = "Character", order = 1)]
public class CharacterScriptableObject : ScriptableObject {
    [SerializeField]
    private Sprite head;
    [SerializeField]
    private Sprite body;
    [SerializeField]
    private Sprite Equipment;

    [SerializeField]
    private int range;
    [SerializeField]
    private int health;

    public void LoadCharacter(Characters character)
    {
        character.m_Head.sprite = head;
        character.m_Body.sprite = body;
        character.m_Equipment.sprite = Equipment;

        character.m_Range.localScale = new Vector3(range, range, 1);
        character.health = health;
    } 
}
