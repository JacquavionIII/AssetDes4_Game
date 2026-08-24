using UnityEngine;
using UnityEngine.SceneManagement;

public class backscene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            back();
        }        
    }

    public void back()
    {
        SceneManager.LoadScene("Liam Scene");
    }
}
