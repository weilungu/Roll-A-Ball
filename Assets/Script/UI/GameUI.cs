using System;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    // Inspector
    [Header("Gameplay UI")]
    [SerializeField] Text scoreText;
    [SerializeField] Text outcomeText;
    
    [Header("Outcome UI")]
    [SerializeField] GameObject outcomePanel;
    [SerializeField] Text outcomeScoreText;
    
    [Header("Component")]
    [SerializeField] PlayerPickup pickup;
    

    // === API === //
    public void UpdateScoreUI(int amount)
        => scoreText.text = $"Score: {amount} / {pickup.Amount}";
    
    public Text GetOutcomeText() => outcomeText;
    public Text GetScoreText() => scoreText;
    
    public GameObject GetOutcomePanel() => outcomePanel;
    public Text GetOutcomeScore() => outcomeScoreText;
}
