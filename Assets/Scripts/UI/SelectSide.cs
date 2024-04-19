using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectSide : MonoBehaviour
{
    [SerializeField] private string mainMenuScene;
    [SerializeField] private string chooseMapScene;

    public void BackToMenu()
    {
        SceneManager.LoadScene(mainMenuScene);
    }

    private void GoToChooseMap()
    {
        SceneManager.LoadScene(chooseMapScene);
    }

    public void ChooseSide(int i)
    {
        Settings.SelectSide(i);
        GoToChooseMap();
    }
}
