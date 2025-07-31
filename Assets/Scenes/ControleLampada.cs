using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ControleLampada : MonoBehaviour
{
    public Image button;
    public Sprite imagemDaLampada;   // Aqui vai a imagem do seu botão (a da lâmpada)
    public Sprite imagemLampadaAcesa;  // A imagem da lâmpada acesa
    public Sprite imagemLampadaApagada; // A imagem da lâmpada apagada

    public  GameObject painelEscurecerTela; // NOVO: Aqui vai o seu PainelEscuro
    public float tempoDeTransicao = 1.0f; // NOVO: Quanto tempo a tela leva pra escurecer/clarear

    public bool estaAcesa = false; // Começa com a lâmpada apagada

    // Esta função é chamada quando o botão é clicado
    public void LigarDesligarLampada()
    {
        estaAcesa = !estaAcesa; // Inverte o estado (se está acesa, apaga; se está apagada, acende)

        if (estaAcesa)
        {
            button.sprite = imagemLampadaAcesa; // Troca a imagem do botão para a lâmpada acesa
            button.color = new Color(255, 255, 255, 1);
            StartCoroutine(MudarCorDaTela(estaAcesa)); // Começa a clarear a tela (transparência total)
        }
        else
        {
            button.sprite = imagemLampadaApagada; // Troca a imagem do botão para a lâmpada apagada
            button.color = new Color(255, 255, 255, 0.4f);
            StartCoroutine(MudarCorDaTela(estaAcesa)); // Começa a escurecer a tela (quase preto, mas não 100%)
        }
        // Debug.Log("Lâmpada está " + (estaAcesa ? "ACESA" : "APAGADA"));
    }

    // Função para mudar a cor da tela suavemente
    IEnumerator MudarCorDaTela(bool condiction)
    {
        if (condiction) {
            yield return null;
            painelEscurecerTela.SetActive(!condiction);
        }
        else {
            yield return null;
            painelEscurecerTela.SetActive(!condiction);
        }
    }
}