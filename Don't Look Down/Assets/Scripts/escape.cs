using UnityEngine;

public class escape : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            quitGame();
        }        
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
