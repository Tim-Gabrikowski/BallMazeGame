using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Config-", menuName = "ScriptableObjects/Config")]
public class LevelConfig : ScriptableObject
{
    public string levelName;
    
    public void nextLevel(){
        Scene nextScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(nextScene.buildIndex + 1);
    }
}
