using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour, IPointerDownHandler
{

    //当检测到鼠标在该物体上有“按下”操作时，触发以下函数
    public void OnPointerDown(PointerEventData eventData)
    {
        SceneManager.LoadScene(2);
    }
}

