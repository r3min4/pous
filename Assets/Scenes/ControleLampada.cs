using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ControleLampada : MonoBehaviour
{
    public Image button;
    public Sprite imagemDaLampada;   // Aqui vai a imagem do seu botão (a da lâmpada)
    public Sprite imagemLampadaAcesa;  // A imagem da lâmpada acesa
    public Sprite imagemLampadaApagada; // A imagem da lâmpada apagada

    public Image painelEscurecerTela; // NOVO: Aqui vai o seu PainelEscuro
    public float tempoDeTransicao = 1.0f; // NOVO: Quanto tempo a tela leva pra escurecer/clarear

    public bool estaAcesa = false; // Começa com a lâmpada apagada

    // Esta função é chamada quando o botão é clicado
    public void LigarDesligarLampada()
    {
        estaAcesa = !estaAcesa; // Inverte o estado (se está acesa, apaga; se está apagada, acende)

        if (estaAcesa)
        {
            button.sprite = imagemLampadaAcesa; // Troca a imagem do botão para a lâmpada acesa
            StartCoroutine(MudarCorDaTela(estaAcesa)); // Começa a clarear a tela (transparência total)
        }
        else
        {
            button.sprite = imagemLampadaApagada; // Troca a imagem do botão para a lâmpada apagada
            StartCoroutine(MudarCorDaTela(estaAcesa)); // Começa a escurecer a tela (quase preto, mas não 100%)
        }
        Debug.Log("Lâmpada está " + (estaAcesa ? "ACESA" : "APAGADA"));
    }

    // Função para mudar a cor da tela suavemente
    IEnumerator MudarCorDaTela(bool condiction)
    {
        // Color corAtualDoPainel = painelEscurecerTela.color;
        // float alphaInicial = corAtualDoPainel.a;
        // float tempoPassado = 0f;

        // while (tempoPassado < tempoDeTransicao)
        // {
        //     tempoPassado += Time.deltaTime; // Conta o tempo
        //     float progresso = tempoPassado / tempoDeTransicao;
        //     corAtualDoPainel.a = Mathf.Lerp(alphaInicial, alphaAlvo, progresso); // Calcula a nova transparência
        //     painelEscurecerTela.color = corAtualDoPainel; // Aplica a nova transparência ao painel
        //     yield return null; // Espera um pouquinho e continua no próximo momento
        // }
        // corAtualDoPainel.a = alphaAlvo; // Garante que a transparência chegue no valor certo
        // painelEscurecerTela.color = corAtualDoPainel;
        if (condiction) {
            painelEscurecerTela.SetActive(!condiction);
        }
        else {
            painelEscurecerTela.SetActive(!condiction);
            yield return null;
        }
    }
}