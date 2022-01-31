using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelection : MonoBehaviour
{
    public void Gallery()
    {
        SceneManager.LoadScene(2);
    }
    public void Relativity()
    {
        SceneManager.LoadScene(3);
    }
    public void ThrSpheres()
    {
        //SceneManager.LoadScene(0);
    }
    public void AnoWorld()
    {
        //SceneManager.LoadScene(0);
    }
    public void Waterfall()
    {
        SceneManager.LoadScene(4);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
