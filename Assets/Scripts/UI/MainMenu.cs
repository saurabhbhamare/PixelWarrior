using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button playButton;
    void Start()
    {
        
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }
}
