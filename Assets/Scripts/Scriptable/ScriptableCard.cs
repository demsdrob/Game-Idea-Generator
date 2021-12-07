using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card Data", menuName = "Cards", order = 1)]
public class ScriptableCard : ScriptableObject
{
    [Header("Card UI")] 
    public string _tittle;
    public string _description;
    
    [Header("Card Color")] public Color _cardColor;
    [Header("Elements in Card")] public List<string> _elements;
}