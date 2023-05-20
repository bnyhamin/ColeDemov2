using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Video;

public class PizarraVideoController : MonoBehaviour
{
    [SerializeField] private VideoPlayer video;
    // Start is called before the first frame update
    void Start()
    {
        LoadVideo();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LoadVideo()
    {
        int idcontenido = PlayerPrefs.GetInt("varglobal_idContenido");
        string temp = Application.dataPath + "/Sprites/Videos/Matematicas/2Primaria/"+idcontenido+".mp4";
        print("temp_contenido_videoclases:"+ temp);
        //if (video.url == temp) return;
        video.url = temp;
        video.Prepare();
        video.Play();
        video.loopPointReached += CheckOver;
        
    }

    void CheckOver(VideoPlayer vp)
    {
        Debug.Log("Acumular puntos");
        GameManager.Instance.CloseVideoClases();
    }
}
