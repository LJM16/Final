using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
   public void Next()
   {
        SceneManager.LoadScene(1);
   }

    public void Next2()
   {
        SceneManager.LoadScene(0);
   }

   public void Next3()
   {
     SceneManager.LoadScene(2);
   }
}
