using UnityEngine;
using UnityEngine.SceneManagement;

public class ChanceScenes : MonoBehaviour {

    public  void ChanceScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
