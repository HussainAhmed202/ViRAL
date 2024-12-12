using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    void Start() { }

    void Update() { }
    

    // Start is called before the first frame update
    public void onButtonClick()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("VocabularyLearnMode");
    }

   
}

