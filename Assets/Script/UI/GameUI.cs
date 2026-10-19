using System;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    
    
    // UI Button Used
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("Retry");
    }

    public void Exit()
    {
        Application.Quit();
        print("Quit Game");
    }

    public void Home()
    {
        SceneManager.LoadScene(0);
    }
}
