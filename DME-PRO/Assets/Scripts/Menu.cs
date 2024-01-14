
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GotoMenu()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene(0);
    }
}
