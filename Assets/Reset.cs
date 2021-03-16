using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public void Retry(){
        Time.timeScale = 1; //Because losing pauses game
        SceneManager.LoadScene("MathiasScene");
        
    }
}
