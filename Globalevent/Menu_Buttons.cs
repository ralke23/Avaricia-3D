using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    public void MenuToIntroduction()
    {
        SceneManager.LoadScene("World_01_Introduccion");
    }
   // public void EndingToMenu()
   // {
   //     SceneManager.LoadScene("Intro");
    //}
}
