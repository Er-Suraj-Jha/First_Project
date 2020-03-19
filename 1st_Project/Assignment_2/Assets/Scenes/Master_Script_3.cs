using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Master_Script_3 : MonoBehaviour
{
  public Button button;
  // public string newScene;
  private void Start()
  {
    button.onClick.AddListener(OnButtonClick);
  }

  private void OnButtonClick()
  {
      Debug.Log("Button Clicked");
      SceneManager.LoadScene("3rd_Scene");
  }
 
    
}
