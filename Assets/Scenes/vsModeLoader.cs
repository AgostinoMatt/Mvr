using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vsModeLoader : MonoBehaviour
{
    public static vsModeLoader instance;
    public static vsModeLoader Instance { get { return instance; } }

    public bool vsMode = false;


    // Start is called before the first frame update
    void Start()
    {
        if (instance != null || instance == this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("VsScene");
        vsMode = true;
    }
}
