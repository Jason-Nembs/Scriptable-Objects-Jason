using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectionUI : MonoBehaviour
{
    [Header("Characters")]
    public CatCharacter greenCat;
    public CatCharacter orangeCat;
    public CatCharacter pinkCat;
    public CatCharacter brownCat;

    [Header("UI Elements")]
    public Image portraitImage;
    public Text nameText;
    public Text descriptionText;
    public Text strengthText;
    public Text intelligenceText;
    public Text charismaText;
    public Text knowledgeText;

    public void SelectCharacter(CatCharacter cat)
    {
        portraitImage.sprite = cat.portrait;
        nameText.text = cat.characterName;
        descriptionText.text = cat.description;
        strengthText.text = "Strength: " + cat.strength.ToString();
        intelligenceText.text = "Intelligence: " + cat.intelligence.ToString();
        charismaText.text = "Charisma: " + cat.charisma.ToString();
        knowledgeText.text = "Knowledge: " + cat.knowledge.ToString();
    }
}
