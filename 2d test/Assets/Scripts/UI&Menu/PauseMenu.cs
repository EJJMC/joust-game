using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    [SerializeField] AudioSource MusicSource;
    [SerializeField] AudioSource SFXSource;

    [SerializeField] Slider MusicvolumeSlider;
    [SerializeField] Slider SFXvolumeSlider;    

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void MainMenu(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quitting Game");
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void Start()
    {


        if (PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else if (PlayerPrefs.HasKey("SFXVolume"))
        {
            PlayerPrefs.SetFloat("SFXVolume", 1);
            Load();
        }

        else
        {
            Load();
        }
    }

    public void ChangeMusicVolume()
    {
        MusicSource.volume = MusicvolumeSlider.value;
        Save();
    }

    public void ChangeSFXVolume()
    {
        SFXSource.volume = SFXvolumeSlider.value;
        Save();
    }

    private void Load()
    {
        MusicvolumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
        SFXvolumeSlider.value = PlayerPrefs.GetFloat("SFXVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", MusicvolumeSlider.value);
        PlayerPrefs.SetFloat("SFXVolume", SFXvolumeSlider.value);
    }
}