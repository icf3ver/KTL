using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
     
public class Restart : MonoBehaviour {
    public void RestartGame() {
        SceneManager.LoadScene("KTL");
    }
}