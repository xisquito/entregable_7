using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerController : MonoBehaviour
{

    //Creamos 2 funciones, la primera, de tipo string que nos dice el mensaje que sale en pantalla, la segunda la creamos para el Canvas
    private string screenMessage;
    public TextMeshProUGUI canvasMensaje;



    // Start is called before the first frame update
    void Start()
    {
        //En el Start, decimos que el "screenMessage" ponga una frase, y decimos que el texto del Canvas es igual al "screenMessage"
        screenMessage = "Pulsa alguna de las 4 teclas";

        canvasMensaje.text = screenMessage;


    }


    void Update()
    {

        //En el Update, decimos que muestre un mensaje en el "screenMessage, que se activará cuando pretemos las 4 flechas
        canvasMensaje.text = screenMessage;

        ShowMessage(screenMessage,KeyCode.LeftArrow);
        ShowMessage(screenMessage,KeyCode.RightArrow);
        ShowMessage(screenMessage,KeyCode.UpArrow);
        ShowMessage(screenMessage,KeyCode.DownArrow);
    }

    public void ShowMessage(string message, KeyCode key)
    {

        //Creamos una lcasse pública que no nos devuelve nada, de tipo ShowMessage, y con los "if" decimos cada flecha el texto que queremos que salga, y el space
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            screenMessage = "Derecha";
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            screenMessage = "Izquierda";
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            screenMessage = "Arriba";
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            screenMessage = "Abajo";
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            screenMessage = "Pium";
        }
    }

    
    
}
