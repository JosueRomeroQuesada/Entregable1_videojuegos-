
using System;
using TMPro;
using UnityEngine;


[Serializable]
public class CollectibleUI
{
    [SerializeField]
    CollectibleType CollecttibleType;

    [SerializeField]
    TextMeshProUGUI textbox;

    public CollectibleType GetCollectibleType() 
    { return CollecttibleType; }

    public TextMeshProUGUI GetTextbox()
    { return textbox; }
    
}
