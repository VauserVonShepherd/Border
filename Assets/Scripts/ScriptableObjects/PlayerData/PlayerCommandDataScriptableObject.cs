using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CommandData", menuName = "PlayerData/CommandData", order = 1)]
public class PlayerCommandDataScriptableObject : ScriptableObject {
    public List<CharacterStatScriptableObject> UnitsInCommand = new List<CharacterStatScriptableObject>();
}
