using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarJogoScript : MonoBehaviour {
    
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Return) || (Input.touchCount == 2))
        {
            JogadorScript.pontos = 0;
            SceneManager.LoadScene("Game");
        }
    }
}
