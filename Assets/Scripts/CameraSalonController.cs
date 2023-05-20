using System.Collections;
using UnityEngine;

public class CameraSalonController : MonoBehaviour
{
    private Transform _transform;
    [SerializeField] private GameObject _camTarget;
    [SerializeField] private GameObject _canvasPizarra;
    private bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        _transform = transform;
         
        StartCoroutine(Waiting(3));
    }

    // Update is called once per frame
    void Update()
    {
        if (!active) return;

        if (Vector3.Distance(_transform.position, _camTarget.transform.position) <= 5)
        {
            //_transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            //Debug.Log("QUIEEETO, ESPERAR 3 SEGUNDOS PARA ABRIR CANVAS");
            abrirCanvas();

        }
        else
        {
            //Vector3.MoveTowards(_transform.position, _CamTarget.transform.position, 5 * Time.deltaTime);
            //Debug.Log("AVANZA");
            _transform.position = Vector3.MoveTowards(_transform.position, _camTarget.transform.position, 5 * Time.deltaTime);
        }
    }

    IEnumerator Waiting(int time)
    {   
        yield return new WaitForSeconds(time);
        active = true;
    }

    void abrirCanvas()
    {
        //Debug.Log("Entra a abrircanvas");
        StartCoroutine(Waiting(3));
        //Debug.Log("Activa pizarra");
        _canvasPizarra.SetActive(true);
    }


}
