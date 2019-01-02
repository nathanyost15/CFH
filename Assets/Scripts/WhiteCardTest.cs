using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteCardTest : MonoBehaviour
{    
    private Deck whiteDeck;
    private TMPro.TextMeshPro textBox;
    void Start()
    {
        textBox = gameObject.GetComponentsInChildren<TMPro.TextMeshPro>()[0];
        if (textBox == null)
        {
            Debug.Log("Could not find game component: TextMeshPro");
        }
        whiteDeck = new Deck("Assets/Docs/White_Cards.txt");
        if (whiteDeck.GetError() != "")
        {
            Debug.Log("Could not find Black_Cards.txt");
        }
        whiteDeck.Shuffle();
        textBox.text = whiteDeck.Draw();
    }

    void Update()
    {
        whiteDeck.Shuffle();
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            textBox.text = whiteDeck.Draw();
        }
    }
}
