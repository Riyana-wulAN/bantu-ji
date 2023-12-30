using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Pindah : MonoBehaviour
{
    public GameObject menu;
    public GameObject materi;
    public GameObject soal;
    public GameObject data;
    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(true);
        materi.SetActive(false);
    }
    public void dataClicked()
    {
        menu.SetActive(false);
        data.SetActive(true);
    }
    public void keluardrdtClicked()
    {
        menu.SetActive(true);
        data.SetActive(false);
    }
    public void materiClicked()
    {
        menu.SetActive(false);
        materi.SetActive(true);
    }
    public void keluarClicked()
    {
        menu.SetActive(true);
        materi.SetActive(false);
    }
    public void soalClicked()
    {
        menu.SetActive(false);
        soal.SetActive(true);
    }
    public void keluardrsoalClicked()
    {
        menu.SetActive(true);
        soal.SetActive(false);
    }

        // Update is called once per frame
        void Update()
        {

        }
    }

