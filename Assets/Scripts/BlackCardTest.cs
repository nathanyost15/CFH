using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackCardTest : MonoBehaviour
{    
    private Deck blackDeck;
    private TMPro.TextMeshPro textBox;
    void Start()
    {        
        textBox = (TMPro.TextMeshPro) GameObject.Find("BlackTextObj").GetComponent("TextMeshPro");        
        if(textBox == null)
        {
            Debug.Log("Could not find game component Text Mesh");
        }
        blackDeck = new Deck("Assets/Docs/Black_Cards.txt");
        if(blackDeck.GetError() != "")
        {
            Debug.Log("Could not find Black_Cards.txt");
        }
        blackDeck.Shuffle();
        textBox.text = blackDeck.Draw();
    }
 
    void Update()
    {        
    }
}
