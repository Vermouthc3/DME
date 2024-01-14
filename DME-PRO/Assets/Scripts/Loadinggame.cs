
using UnityEngine;
using UnityEngine.SceneManagement;


public class Loadinggame : MonoBehaviour
{


    public void TransDataScene()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene(1);
    }
}

