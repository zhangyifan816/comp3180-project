using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonCtrl : MonoBehaviour
{
    public int score = 0;//Other scripts can make score automatically increase by 1 after each Apple disappears
    public Text display;//Used for screen display
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        display.text = score.ToString();//Assign text the number that should be displayed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void dianji()
    {
        SceneManager.LoadScene(0);
    }
}
