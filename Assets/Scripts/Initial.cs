using UnityEngine;
using UnityEngine.SceneManagement;
public class Initial : MonoBehaviour {

	private void Awake() {
		SceneManager.LoadScene(1);
	}
}
