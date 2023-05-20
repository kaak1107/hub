using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttontest : MonoBehaviour
{
    // Start is called before the first frame update
    public void SwichScene()
    {
        SceneManager.LoadScene("honpenScene", LoadSceneMode.Single);
    }
}
