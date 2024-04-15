
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager1 : MonoBehaviour
{
   

 
    [SerializeField] private GameObject playButton;



 

    public void Play()
    {
        SceneManager.LoadScene("Flappy Bird");

    }







}
