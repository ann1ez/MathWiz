using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    public int SceneSeq;

    public void Reset()
    {
        SceneManager.LoadScene(SceneSeq);
    }
}
