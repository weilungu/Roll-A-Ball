using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] SceneAsset[] levels;
    
    public void GameLevel(int level)
    {
        if (level <= 0) 
            level = 1;
        
        SceneManager.LoadScene(levels[level-1].name);
    }
}
