using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {
	
	void Start () {
		
	}
	public void OnClick_SelectSituation(int i) {
		switch (i) {
			case 0:
				SceneManager.LoadScene(2);
				break;
		}
	}
}
