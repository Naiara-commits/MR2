using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CambiarEscena1()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void CambiarEscena2()
    {

        SceneManager.LoadScene("Scene2");
    }
    
}
