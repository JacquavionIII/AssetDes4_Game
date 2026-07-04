using UnityEngine;

public class escape : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            quitGame();
        }        
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
