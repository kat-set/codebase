using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange : MonoBehaviour
{

    
    public string sceneName;
    
    public void GoToGame()
    {
    SceneManager.LoadScene(sceneName);
    }

}
