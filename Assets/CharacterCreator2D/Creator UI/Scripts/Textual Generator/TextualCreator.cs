using CharacterCreator2D;
using CharacterCreator2D.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextualCreator : MonoBehaviour
{
    public CharacterViewer character;
    bool _processing = false;
    public int CharacterName;
    public RuntimeDialog dialog;
    public InputField inputfield;

    public void LoadCharacterFromJSON(string path)
    {
        _processing = true;
        if (!string.IsNullOrEmpty(path))
        {
            this.character.LoadFromJSON(path);
            dialog.DisplayDialog("Generate Character", "Character generated succesfully.");
        }
        _processing = false;
    }

    public void GenerateCharater()
    {
        _processing = true;
        // Character is being created
        string path = string.Format("Assets/TestCharacters/Test{0}.json", CharacterName);
        LoadCharacterFromJSON(path);
        // Clears input field
        ClearInput();
        _processing = false;
    }

    public void ClearInput()
    {
        inputfield.Select();
        inputfield.text = "";
    }
}



