using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquadUnit : Selectable {
    [SerializeField]
    private CharacterStatScriptableObject characterStat;
    [SerializeField]
    private Characters baseCharacterPrefab;
    
    public List<AI_Behaviour> characterList = new List<AI_Behaviour>();

    [Space]

    [SerializeField]
    private int squadMaxSize = 6;

    private void Start()
    {
        if(characterStat)
        SpawnSquad(characterStat);
    }

    public void SpawnSquad(CharacterStatScriptableObject SpawningCharacter)
    {
        characterStat = SpawningCharacter;

        for(int i = 0; i < squadMaxSize; i++)
        {
            Vector3 pos = StaticFunctions.SpawnInCircle(transform.position, 0.1f, squadMaxSize, i);

            GameObject characterUnit = Instantiate(baseCharacterPrefab.gameObject, pos, Quaternion.identity,transform);
            characterUnit.GetComponent<AI_Behaviour>().SpawnInSquad(this);

            characterList.Add(characterUnit.GetComponent<AI_Behaviour>());
        }
    }//end spawn squad

    public void MoveSquad(Vector3 targetPos)
    {
        for (int i = 0; i < characterList.Count; i++)
        {
            Vector3 pos = StaticFunctions.SpawnInCircle(targetPos, 0.1f, squadMaxSize, i);

            characterList[i].m_Movement.target = pos;
        }
    }
}
