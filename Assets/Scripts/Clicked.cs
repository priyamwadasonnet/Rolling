using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Clicked : MonoBehaviour
{
    public Button button;
    public void OnClick()
    {
        SceneManager.LoadScene(1);
    }
}
