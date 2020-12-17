using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    public void OnClick_LaunchGame() //if we click on button, we go to next scène to play
    {
        SceneManager.LoadScene(1);
    }
}
