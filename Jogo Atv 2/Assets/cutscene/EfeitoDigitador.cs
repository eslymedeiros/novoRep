using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[RequireComponent(typeof(AudioSource))]

public class EfeitoDigitador : MonoBehaviour
{
    private TextMeshProUGUI componenteTexto;
    private AudioSource _audioSource;
    private string mensagemOriginal;
    public bool imprimindo;
    

    private void Awake(){
        TryGetComponent(out componenteTexto);
        TryGetComponent(out _audioSource);
        mensagemOriginal = componenteTexto.text;
        componenteTexto.text = "";
    }
    private void OnEnable(){
        
    }
    private void OnDisable(){
        componenteTexto.text = mensagemOriginal;
    }
    public void ImprimirMensagem(string mensagem){
        
    }

    //IEnumerator LetraPorLetra(string mensagem){
    //    string msg = "";
    //}
}
