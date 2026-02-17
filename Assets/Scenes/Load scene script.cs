using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadscenescript : MonoBehaviour
{
    
    //public string Sigma; // lägg till namnen på scenen du vill gå till det borde funka så

    public void LoadScene()// shall load the scene
    {
        SceneManager.LoadScene("Sigma");// scenen den ska loada
    }

// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
