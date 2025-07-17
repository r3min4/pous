using UnityEngine;
using UnityEngine.UI; // Importe o namespace UI
using System.Collections; // Necessário para Coroutines, se for usar

public class LightSwitch : MonoBehaviour
{
    public Image lightBulbImage; // Arraste seu componente Image do botão aqui no Inspector
    public Sprite lightOnSprite;  // A imagem da lâmpada acesa
    public Sprite lightOffSprite; // A imagem da lâmpada apagada

    private bool isLightOn = false; // Variável para controlar o estado da lâmpada

    // Este método será chamado quando o botão for clicado
    public void ToggleLight()
    {
        isLightOn = !isLightOn; // Inverte o estado da lâmpada (se estava ligado, desliga; se estava desligado, liga)

        if (isLightOn)
        {
            lightBulbImage.sprite = lightOnSprite; // Define a imagem para a lâmpada acesa
        }
        else
        {
            lightBulbImage.sprite = lightOffSprite; // Define a imagem para a lâmpada apagada
        }

        Debug.Log("Lâmpada está " + (isLightOn ? "ACESA" : "APAGADA")); // Mensagem para debug no console
    }
}