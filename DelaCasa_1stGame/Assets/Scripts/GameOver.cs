using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    private BackgroundMusic backgroundMusic;

    private void Start()
    {
        backgroundMusic = FindObjectOfType<BackgroundMusic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOverPanel.SetActive(true);
        }
    }
    public void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GoBack()
    {
        backgroundMusic.StopMusic();
        SceneManager.LoadSceneAsync(0);
    }
}
