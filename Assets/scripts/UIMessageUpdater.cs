using UnityEngine;
using TMPro; 

public class UIMessageUpdater : MonoBehaviour
{
    private TextMeshProUGUI statusText;

    private string grabMessage = "¡Objeto Agarrado!";
    private string releaseMessage = "Objeto Suelto";


    public void DisplayGrabMessage()
    {
        if (statusText != null)
        {
            statusText.text = grabMessage;
        }
    }


    public void DisplayReleaseMessage()
    {
        if (statusText != null)
        {
            statusText.text = releaseMessage;
        }
    }
}