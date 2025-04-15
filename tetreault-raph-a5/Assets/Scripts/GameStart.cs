using UnityEngine;

public class GameStart : MonoBehaviour
{
    public GameObject Start;
    public bool isPaused = true;

    // Update is called once per frame
    void Update()
    {
        if (isPaused)
        {
            Time.timeScale = 0f;
        }

        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                isPaused = false;
                Start.SetActive(false);
                Time.timeScale = 1f;
            }
        }
        
    }
}
