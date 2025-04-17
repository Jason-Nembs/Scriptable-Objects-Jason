using UnityEngine;

[CreateAssetMenu(fileName = "New Cat", menuName = "Characters/Cat")]
public class CatCharacter : ScriptableObject
{
    public string characterName;
    public string description;
    public Sprite portrait;

    public int strength;
    public int intelligence;
    public int charisma;
    public int knowledge;
}