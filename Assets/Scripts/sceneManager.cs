using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public UnityEvent loadnext;
    
    public void LoadNextLevel()
	{
		int actualScene = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(++actualScene);
	}
    
    private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject == GameManager.instance.player) loadnext.Invoke();
	}
}
