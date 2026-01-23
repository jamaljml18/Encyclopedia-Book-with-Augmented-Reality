using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static Unity.Burst.Intrinsics.X86;

public class RotateManager : MonoBehaviour
{
    [SerializeField] private float rotation = 10f;
    // Tiger
    [SerializeField] private Button rightRotateButton_Tiger;
    [SerializeField] private Button leftRotateButton_Tiger;
    [SerializeField] private Button upRotateButton_Tiger;
    [SerializeField] private Button downRotateButton_Tiger;
    // Komodo
    [SerializeField] private Button rightRotateButton_Komodo;
    [SerializeField] private Button leftRotateButton_Komodo;
    [SerializeField] private Button upRotateButton_Komodo;
    [SerializeField] private Button downRotateButton_Komodo;
    // Badak
    [SerializeField] private Button rightRotateButton_Badak;
    [SerializeField] private Button leftRotateButton_Badak;
    [SerializeField] private Button upRotateButton_Badak;
    [SerializeField] private Button downRotateButton_Badak;
    // Gajah
    [SerializeField] private Button rightRotateButton_Gajah;
    [SerializeField] private Button leftRotateButton_Gajah;
    [SerializeField] private Button upRotateButton_Gajah;
    [SerializeField] private Button downRotateButton_Gajah;
    // Pesut
    [SerializeField] private Button rightRotateButton_Pesut;
    [SerializeField] private Button leftRotateButton_Pesut;
    [SerializeField] private Button upRotateButton_Pesut;
    [SerializeField] private Button downRotateButton_Pesut;
    // Cendrawasih
    [SerializeField] private Button rightRotateButton_Cendrawasih;
    [SerializeField] private Button leftRotateButton_Cendrawasih;
    [SerializeField] private Button upRotateButton_Cendrawasih;
    [SerializeField] private Button downRotateButton_Cendrawasih;
    // Jalak
    [SerializeField] private Button rightRotateButton_Jalak;
    [SerializeField] private Button leftRotateButton_Jalak;
    [SerializeField] private Button upRotateButton_Jalak;
    [SerializeField] private Button downRotateButton_Jalak;
    // Elang
    [SerializeField] private Button rightRotateButton_Elang;
    [SerializeField] private Button leftRotateButton_Elang;
    [SerializeField] private Button upRotateButton_Elang;
    [SerializeField] private Button downRotateButton_Elang;
    // Raflesia
    [SerializeField] private Button rightRotateButton_Raflesia;
    [SerializeField] private Button leftRotateButton_Raflesia;
    [SerializeField] private Button upRotateButton_Raflesia;
    [SerializeField] private Button downRotateButton_Raflesia;
    // Bangkai
    [SerializeField] private Button rightRotateButton_Bangkai;
    [SerializeField] private Button leftRotateButton_Bangkai;
    [SerializeField] private Button upRotateButton_Bangkai;
    [SerializeField] private Button downRotateButton_Bangkai;
    // Bumi
    [SerializeField] private Button rightRotateButton_Bumi;
    [SerializeField] private Button leftRotateButton_Bumi;
    [SerializeField] private Button upRotateButton_Bumi;
    [SerializeField] private Button downRotateButton_Bumi;
    // Hidrologi
    [SerializeField] private Button rightRotateButton_Hidrologi;
    [SerializeField] private Button leftRotateButton_Hidrologi;
    [SerializeField] private Button upRotateButton_Hidrologi;
    [SerializeField] private Button downRotateButton_Hidrologi;

    [SerializeField] private GameObject tiger_1;
    [SerializeField] private GameObject tiger_2;

    [SerializeField] private GameObject komodo_1;
    [SerializeField] private GameObject komodo_2;

    [SerializeField] private GameObject badak_1;
    [SerializeField] private GameObject badak_2;

    [SerializeField] private GameObject gajah_1;
    [SerializeField] private GameObject gajah_2;

    [SerializeField] private GameObject pesut_1;
    [SerializeField] private GameObject pesut_2;

    [SerializeField] private GameObject cendrawasih_1;
    [SerializeField] private GameObject cendrawasih_2;

    [SerializeField] private GameObject jalak_1;
    [SerializeField] private GameObject jalak_2;

    [SerializeField] private GameObject elang_1;
    [SerializeField] private GameObject elang_2;

    [SerializeField] private GameObject raflesia_1;
    [SerializeField] private GameObject raflesia_2;

    [SerializeField] private GameObject bangkai_1;
    [SerializeField] private GameObject bangkai_2;

    [SerializeField] private GameObject bumi_1;
    [SerializeField] private GameObject bumi_2;

    [SerializeField] private GameObject hidrologi_1;
    [SerializeField] private GameObject hidrologi_2;

    private void Start()
    {
        allObjectsFalse();

    }

    // Tiger 
    public void OnTargetFound_Tiger() 
    {
        rightRotateButton_Tiger.gameObject.SetActive(true);
        leftRotateButton_Tiger.gameObject.SetActive(true);
        upRotateButton_Tiger.gameObject.SetActive(true);
        downRotateButton_Tiger.gameObject.SetActive(true);

        //// Komodo Button
        //rightRotateButton_Komodo.gameObject.SetActive(false);
        //leftRotateButton_Komodo.gameObject.SetActive(false);
        //upRotateButton_Komodo.gameObject.SetActive(false);
        //downRotateButton_Komodo.gameObject.SetActive(false);

        //// Badak Button
        //rightRotateButton_Badak.gameObject.SetActive(false);
        //leftRotateButton_Badak.gameObject.SetActive(false);
        //upRotateButton_Badak.gameObject.SetActive(false);
        //downRotateButton_Badak.gameObject.SetActive(false);

        //// Gajah Button
        //rightRotateButton_Gajah.gameObject.SetActive(false);
        //leftRotateButton_Gajah.gameObject.SetActive(false);
        //upRotateButton_Gajah.gameObject.SetActive(false);
        //downRotateButton_Gajah.gameObject.SetActive(false);

        //// Pesut Button
        //rightRotateButton_Pesut.gameObject.SetActive(false);
        //leftRotateButton_Pesut.gameObject.SetActive(false);
        //upRotateButton_Pesut.gameObject.SetActive(false);
        //downRotateButton_Pesut.gameObject.SetActive(false);

        //// Cendrawasih Button
        //rightRotateButton_Cendrawasih.gameObject.SetActive(false);
        //leftRotateButton_Cendrawasih.gameObject.SetActive(false);
        //upRotateButton_Cendrawasih.gameObject.SetActive(false);
        //downRotateButton_Cendrawasih.gameObject.SetActive(false);

        //// Jalak Button
        //rightRotateButton_Jalak.gameObject.SetActive(false);
        //leftRotateButton_Jalak.gameObject.SetActive(false);
        //upRotateButton_Jalak.gameObject.SetActive(false);
        //downRotateButton_Jalak.gameObject.SetActive(false);

        //// Elang Button
        //rightRotateButton_Elang.gameObject.SetActive(false);
        //leftRotateButton_Elang.gameObject.SetActive(false);
        //upRotateButton_Elang.gameObject.SetActive(false);
        //downRotateButton_Elang.gameObject.SetActive(false);
    }

    public void OnTargetLost_Tiger()
    {
        allObjectsFalse();
    }

    // Komodo
    public void OnTargetFound_Komodo()
    {
        rightRotateButton_Komodo.gameObject.SetActive(true);
        leftRotateButton_Komodo.gameObject.SetActive(true);
        upRotateButton_Komodo.gameObject.SetActive(true);
        downRotateButton_Komodo.gameObject.SetActive(true);

        //// Tiger Button
        //rightRotateButton_Tiger.gameObject.SetActive(false);
        //leftRotateButton_Tiger.gameObject.SetActive(false);
        //upRotateButton_Tiger.gameObject.SetActive(false);
        //downRotateButton_Tiger.gameObject.SetActive(false);

        //// Badak Button
        //rightRotateButton_Badak.gameObject.SetActive(false);
        //leftRotateButton_Badak.gameObject.SetActive(false);
        //upRotateButton_Badak.gameObject.SetActive(false);
        //downRotateButton_Badak.gameObject.SetActive(false);

        //// Gajah Button
        //rightRotateButton_Gajah.gameObject.SetActive(false);
        //leftRotateButton_Gajah.gameObject.SetActive(false);
        //upRotateButton_Gajah.gameObject.SetActive(false);
        //downRotateButton_Gajah.gameObject.SetActive(false);

        //// Pesut Button
        //rightRotateButton_Pesut.gameObject.SetActive(false);
        //leftRotateButton_Pesut.gameObject.SetActive(false);
        //upRotateButton_Pesut.gameObject.SetActive(false);
        //downRotateButton_Pesut.gameObject.SetActive(false);

        //// Cendrawasih Button
        //rightRotateButton_Cendrawasih.gameObject.SetActive(false);
        //leftRotateButton_Cendrawasih.gameObject.SetActive(false);
        //upRotateButton_Cendrawasih.gameObject.SetActive(false);
        //downRotateButton_Cendrawasih.gameObject.SetActive(false);

        //// Jalak Button
        //rightRotateButton_Jalak.gameObject.SetActive(false);
        //leftRotateButton_Jalak.gameObject.SetActive(false);
        //upRotateButton_Jalak.gameObject.SetActive(false);
        //downRotateButton_Jalak.gameObject.SetActive(false);
    }

    public void OnTargetLost_Komodo()
    {
        allObjectsFalse();
    }

    // Badak
    public void OnTargetFound_Badak()
    {
        rightRotateButton_Badak.gameObject.SetActive(true);
        leftRotateButton_Badak.gameObject.SetActive(true);
        upRotateButton_Badak.gameObject.SetActive(true);
        downRotateButton_Badak.gameObject.SetActive(true);

        //// Tiger Button
        //rightRotateButton_Tiger.gameObject.SetActive(false);
        //leftRotateButton_Tiger.gameObject.SetActive(false);
        //upRotateButton_Tiger.gameObject.SetActive(false);
        //downRotateButton_Tiger.gameObject.SetActive(false);

        //// Komodo Button
        //rightRotateButton_Komodo.gameObject.SetActive(false);
        //leftRotateButton_Komodo.gameObject.SetActive(false);
        //upRotateButton_Komodo.gameObject.SetActive(false);
        //downRotateButton_Komodo.gameObject.SetActive(false);

        //// Gajah Button
        //rightRotateButton_Gajah.gameObject.SetActive(false);
        //leftRotateButton_Gajah.gameObject.SetActive(false);
        //upRotateButton_Gajah.gameObject.SetActive(false);
        //downRotateButton_Gajah.gameObject.SetActive(false);

        //// Pesut Button
        //rightRotateButton_Pesut.gameObject.SetActive(false);
        //leftRotateButton_Pesut.gameObject.SetActive(false);
        //upRotateButton_Pesut.gameObject.SetActive(false);
        //downRotateButton_Pesut.gameObject.SetActive(false);

        //// Cendrawasih Button
        //rightRotateButton_Cendrawasih.gameObject.SetActive(false);
        //leftRotateButton_Cendrawasih.gameObject.SetActive(false);
        //upRotateButton_Cendrawasih.gameObject.SetActive(false);
        //downRotateButton_Cendrawasih.gameObject.SetActive(false);

        //// Jalak Button
        //rightRotateButton_Jalak.gameObject.SetActive(false);
        //leftRotateButton_Jalak.gameObject.SetActive(false);
        //upRotateButton_Jalak.gameObject.SetActive(false);
        //downRotateButton_Jalak.gameObject.SetActive(false);

        //// Elang Button
        //rightRotateButton_Elang.gameObject.SetActive(false);
        //leftRotateButton_Elang.gameObject.SetActive(false);
        //upRotateButton_Elang.gameObject.SetActive(false);
        //downRotateButton_Elang.gameObject.SetActive(false);
    }

    public void OnTargetLost_Badak()
    {
        allObjectsFalse();
    }

    // Gajah
    public void OnTargetFound_Gajah()
    {
        rightRotateButton_Gajah.gameObject.SetActive(true);
        leftRotateButton_Gajah.gameObject.SetActive(true);
        upRotateButton_Gajah.gameObject.SetActive(true);
        downRotateButton_Gajah.gameObject.SetActive(true);

        //// Tiger Button
        //rightRotateButton_Tiger.gameObject.SetActive(false);
        //leftRotateButton_Tiger.gameObject.SetActive(false);
        //upRotateButton_Tiger.gameObject.SetActive(false);
        //downRotateButton_Tiger.gameObject.SetActive(false);

        //// Komodo Button
        //rightRotateButton_Komodo.gameObject.SetActive(false);
        //leftRotateButton_Komodo.gameObject.SetActive(false);
        //upRotateButton_Komodo.gameObject.SetActive(false);
        //downRotateButton_Komodo.gameObject.SetActive(false);

        //// Badak Button
        //rightRotateButton_Badak.gameObject.SetActive(false);
        //leftRotateButton_Badak.gameObject.SetActive(false);
        //upRotateButton_Badak.gameObject.SetActive(false);
        //downRotateButton_Badak.gameObject.SetActive(false);

        //// Pesut Button
        //rightRotateButton_Pesut.gameObject.SetActive(false);
        //leftRotateButton_Pesut.gameObject.SetActive(false);
        //upRotateButton_Pesut.gameObject.SetActive(false);
        //downRotateButton_Pesut.gameObject.SetActive(false);

        //// Cendrawasih Button
        //rightRotateButton_Cendrawasih.gameObject.SetActive(false);
        //leftRotateButton_Cendrawasih.gameObject.SetActive(false);
        //upRotateButton_Cendrawasih.gameObject.SetActive(false);
        //downRotateButton_Cendrawasih.gameObject.SetActive(false);

        //// Jalak Button
        //rightRotateButton_Jalak.gameObject.SetActive(false);
        //leftRotateButton_Jalak.gameObject.SetActive(false);
        //upRotateButton_Jalak.gameObject.SetActive(false);
        //downRotateButton_Jalak.gameObject.SetActive(false);

        //// Elang Button
        //rightRotateButton_Elang.gameObject.SetActive(false);
        //leftRotateButton_Elang.gameObject.SetActive(false);
        //upRotateButton_Elang.gameObject.SetActive(false);
        //downRotateButton_Elang.gameObject.SetActive(false);

    }

    public void OnTargetLost_Gajah()
    {
         allObjectsFalse();
    }

    // Pesut
    public void OnTargetFound_Pesut()
    {
        rightRotateButton_Pesut.gameObject.SetActive(true);
        leftRotateButton_Pesut.gameObject.SetActive(true);
        upRotateButton_Pesut.gameObject.SetActive(true);
        downRotateButton_Pesut.gameObject.SetActive(true);

        //// Tiger Button
        //rightRotateButton_Tiger.gameObject.SetActive(false);
        //leftRotateButton_Tiger.gameObject.SetActive(false);
        //upRotateButton_Tiger.gameObject.SetActive(false);
        //downRotateButton_Tiger.gameObject.SetActive(false);

        //// Komodo Button
        //rightRotateButton_Komodo.gameObject.SetActive(false);
        //leftRotateButton_Komodo.gameObject.SetActive(false);
        //upRotateButton_Komodo.gameObject.SetActive(false);
        //downRotateButton_Komodo.gameObject.SetActive(false);

        //// Badak Button
        //rightRotateButton_Badak.gameObject.SetActive(false);
        //leftRotateButton_Badak.gameObject.SetActive(false);
        //upRotateButton_Badak.gameObject.SetActive(false);
        //downRotateButton_Badak.gameObject.SetActive(false);

        //// Gajah Button
        //rightRotateButton_Gajah.gameObject.SetActive(false);
        //leftRotateButton_Gajah.gameObject.SetActive(false);
        //upRotateButton_Gajah.gameObject.SetActive(false);
        //downRotateButton_Gajah.gameObject.SetActive(false);

        //// Cendrawasih Button
        //rightRotateButton_Cendrawasih.gameObject.SetActive(false);
        //leftRotateButton_Cendrawasih.gameObject.SetActive(false);
        //upRotateButton_Cendrawasih.gameObject.SetActive(false);
        //downRotateButton_Cendrawasih.gameObject.SetActive(false);

        //// Jalak Button
        //rightRotateButton_Jalak.gameObject.SetActive(false);
        //leftRotateButton_Jalak.gameObject.SetActive(false);
        //upRotateButton_Jalak.gameObject.SetActive(false);
        //downRotateButton_Jalak.gameObject.SetActive(false);

        //// Elang Button
        //rightRotateButton_Elang.gameObject.SetActive(false);
        //leftRotateButton_Elang.gameObject.SetActive(false);
        //upRotateButton_Elang.gameObject.SetActive(false);
        //downRotateButton_Elang.gameObject.SetActive(false);
    }

    public void OnTargetLost_Pesut()
    {
        allObjectsFalse();
    }

    // Cendrawasih
    public void OnTargetFound_Cendrawasih()
    {
        rightRotateButton_Cendrawasih.gameObject.SetActive(true);
        leftRotateButton_Cendrawasih.gameObject.SetActive(true);
        upRotateButton_Cendrawasih.gameObject.SetActive(true);
        downRotateButton_Cendrawasih.gameObject.SetActive(true);

        //// Tiger Button
        //rightRotateButton_Tiger.gameObject.SetActive(false);
        //leftRotateButton_Tiger.gameObject.SetActive(false);
        //upRotateButton_Tiger.gameObject.SetActive(false);
        //downRotateButton_Tiger.gameObject.SetActive(false);

        //// Komodo Button
        //rightRotateButton_Komodo.gameObject.SetActive(false);
        //leftRotateButton_Komodo.gameObject.SetActive(false);
        //upRotateButton_Komodo.gameObject.SetActive(false);
        //downRotateButton_Komodo.gameObject.SetActive(false);

        //// Badak Button
        //rightRotateButton_Badak.gameObject.SetActive(false);
        //leftRotateButton_Badak.gameObject.SetActive(false);
        //upRotateButton_Badak.gameObject.SetActive(false);
        //downRotateButton_Badak.gameObject.SetActive(false);

        //// Gajah Button
        //rightRotateButton_Gajah.gameObject.SetActive(false);
        //leftRotateButton_Gajah.gameObject.SetActive(false);
        //upRotateButton_Gajah.gameObject.SetActive(false);
        //downRotateButton_Gajah.gameObject.SetActive(false);

        //// Pesut Button
        //rightRotateButton_Pesut.gameObject.SetActive(false);
        //leftRotateButton_Pesut.gameObject.SetActive(false);
        //upRotateButton_Pesut.gameObject.SetActive(false);
        //downRotateButton_Pesut.gameObject.SetActive(false);

        //// Jalak Button
        //rightRotateButton_Jalak.gameObject.SetActive(false);
        //leftRotateButton_Jalak.gameObject.SetActive(false);
        //upRotateButton_Jalak.gameObject.SetActive(false);
        //downRotateButton_Jalak.gameObject.SetActive(false);

        //// Elang Button
        //rightRotateButton_Elang.gameObject.SetActive(false);
        //leftRotateButton_Elang.gameObject.SetActive(false);
        //upRotateButton_Elang.gameObject.SetActive(false);
        //downRotateButton_Elang.gameObject.SetActive(false);
    }

    public void OnTargetLost_Cendrawasih()
    {
        allObjectsFalse();
    }

    // Jalak
    public void OnTargetFound_Jalak()
    {
        rightRotateButton_Jalak.gameObject.SetActive(true);
        leftRotateButton_Jalak.gameObject.SetActive(true);
        upRotateButton_Jalak.gameObject.SetActive(true);
        downRotateButton_Jalak.gameObject.SetActive(true);

        //// Tiger Button
        //rightRotateButton_Tiger.gameObject.SetActive(false);
        //leftRotateButton_Tiger.gameObject.SetActive(false);
        //upRotateButton_Tiger.gameObject.SetActive(false);
        //downRotateButton_Tiger.gameObject.SetActive(false);

        //// Komodo Button
        //rightRotateButton_Komodo.gameObject.SetActive(false);
        //leftRotateButton_Komodo.gameObject.SetActive(false);
        //upRotateButton_Komodo.gameObject.SetActive(false);
        //downRotateButton_Komodo.gameObject.SetActive(false);

        //// Badak Button
        //rightRotateButton_Badak.gameObject.SetActive(false);
        //leftRotateButton_Badak.gameObject.SetActive(false);
        //upRotateButton_Badak.gameObject.SetActive(false);
        //downRotateButton_Badak.gameObject.SetActive(false);

        //// Gajah Button
        //rightRotateButton_Gajah.gameObject.SetActive(false);
        //leftRotateButton_Gajah.gameObject.SetActive(false);
        //upRotateButton_Gajah.gameObject.SetActive(false);
        //downRotateButton_Gajah.gameObject.SetActive(false);

        //// Pesut Button
        //rightRotateButton_Pesut.gameObject.SetActive(false);
        //leftRotateButton_Pesut.gameObject.SetActive(false);
        //upRotateButton_Pesut.gameObject.SetActive(false);
        //downRotateButton_Pesut.gameObject.SetActive(false);

        //// Cendrawasih Button
        //rightRotateButton_Cendrawasih.gameObject.SetActive(false);
        //leftRotateButton_Cendrawasih.gameObject.SetActive(false);
        //upRotateButton_Cendrawasih.gameObject.SetActive(false);
        //downRotateButton_Cendrawasih.gameObject.SetActive(false);

        //// Elang Button
        //rightRotateButton_Elang.gameObject.SetActive(false);
        //leftRotateButton_Elang.gameObject.SetActive(false);
        //upRotateButton_Elang.gameObject.SetActive(false);
        //downRotateButton_Elang.gameObject.SetActive(false);
    }

    public void OnTargetLost_Jalak()
    {
        allObjectsFalse();
    }

    // Elang
    public void OnTargetFound_Elang()
    {
        rightRotateButton_Elang.gameObject.SetActive(true);
        leftRotateButton_Elang.gameObject.SetActive(true);
        upRotateButton_Elang.gameObject.SetActive(true);
        downRotateButton_Elang.gameObject.SetActive(true);

        //// Tiger Button
        //rightRotateButton_Tiger.gameObject.SetActive(false);
        //leftRotateButton_Tiger.gameObject.SetActive(false);
        //upRotateButton_Tiger.gameObject.SetActive(false);
        //downRotateButton_Tiger.gameObject.SetActive(false);

        //// Komodo Button
        //rightRotateButton_Komodo.gameObject.SetActive(false);
        //leftRotateButton_Komodo.gameObject.SetActive(false);
        //upRotateButton_Komodo.gameObject.SetActive(false);
        //downRotateButton_Komodo.gameObject.SetActive(false);

        //// Badak Button
        //rightRotateButton_Badak.gameObject.SetActive(false);
        //leftRotateButton_Badak.gameObject.SetActive(false);
        //upRotateButton_Badak.gameObject.SetActive(false);
        //downRotateButton_Badak.gameObject.SetActive(false);

        //// Gajah Button
        //rightRotateButton_Gajah.gameObject.SetActive(false);
        //leftRotateButton_Gajah.gameObject.SetActive(false);
        //upRotateButton_Gajah.gameObject.SetActive(false);
        //downRotateButton_Gajah.gameObject.SetActive(false);

        //// Pesut Button
        //rightRotateButton_Pesut.gameObject.SetActive(false);
        //leftRotateButton_Pesut.gameObject.SetActive(false);
        //upRotateButton_Pesut.gameObject.SetActive(false);
        //downRotateButton_Pesut.gameObject.SetActive(false);

        //// Cendrawasih Button
        //rightRotateButton_Cendrawasih.gameObject.SetActive(false);
        //leftRotateButton_Cendrawasih.gameObject.SetActive(false);
        //upRotateButton_Cendrawasih.gameObject.SetActive(false);
        //downRotateButton_Cendrawasih.gameObject.SetActive(false);

        //// Jalak Button
        //rightRotateButton_Jalak.gameObject.SetActive(false);
        //leftRotateButton_Jalak.gameObject.SetActive(false);
        //upRotateButton_Jalak.gameObject.SetActive(false);
        //downRotateButton_Jalak.gameObject.SetActive(false);
    }

    public void OnTargetLost_Elang()
    {
        allObjectsFalse();
    }

    // Raflesia
    public void OnTargetFound_Raflesia()
    {
        rightRotateButton_Raflesia.gameObject.SetActive(true);
        leftRotateButton_Raflesia.gameObject.SetActive(true);
        upRotateButton_Raflesia.gameObject.SetActive(true);
        downRotateButton_Raflesia.gameObject.SetActive(true);
    }

    public void OnTargetLost_Raflesia()
    {
        allObjectsFalse();
    }

    // Bangkai
    public void OnTargetFound_Bangkai()
    {
        rightRotateButton_Bangkai.gameObject.SetActive(true);
        leftRotateButton_Bangkai.gameObject.SetActive(true);
        upRotateButton_Bangkai.gameObject.SetActive(true);
        downRotateButton_Bangkai.gameObject.SetActive(true);
    }

    public void OnTargetLost_Bangkai()
    {
        allObjectsFalse();
    }

    // Bumi
    public void OnTargetFound_Bumi()
    {
        rightRotateButton_Bumi.gameObject.SetActive(true);
        leftRotateButton_Bumi.gameObject.SetActive(true);
        upRotateButton_Bumi.gameObject.SetActive(true);
        downRotateButton_Bumi.gameObject.SetActive(true);
    }

    public void OnTargetLost_Bumi()
    {
        allObjectsFalse();
    }

    // Hidrologi
    public void OnTargetFound_Hidrologi()
    {
        rightRotateButton_Hidrologi.gameObject.SetActive(true);
        leftRotateButton_Hidrologi.gameObject.SetActive(true);
        upRotateButton_Hidrologi.gameObject.SetActive(true);
        downRotateButton_Hidrologi.gameObject.SetActive(true);
    }

    public void OnTargetLost_Hidrologi()
    {
        allObjectsFalse();
    }

    private void allObjectsFalse()
    {
        // Tiger Button
        rightRotateButton_Tiger.gameObject.SetActive(false);
        leftRotateButton_Tiger.gameObject.SetActive(false);
        upRotateButton_Tiger.gameObject.SetActive(false);
        downRotateButton_Tiger.gameObject.SetActive(false);

        // Komodo Button
        rightRotateButton_Komodo.gameObject.SetActive(false);
        leftRotateButton_Komodo.gameObject.SetActive(false);
        upRotateButton_Komodo.gameObject.SetActive(false);
        downRotateButton_Komodo.gameObject.SetActive(false);

        // Badak Button
        rightRotateButton_Badak.gameObject.SetActive(false);
        leftRotateButton_Badak.gameObject.SetActive(false);
        upRotateButton_Badak.gameObject.SetActive(false);
        downRotateButton_Badak.gameObject.SetActive(false);

        // Gajah Button
        rightRotateButton_Gajah.gameObject.SetActive(false);
        leftRotateButton_Gajah.gameObject.SetActive(false);
        upRotateButton_Gajah.gameObject.SetActive(false);
        downRotateButton_Gajah.gameObject.SetActive(false);

        // Pesut Button
        rightRotateButton_Pesut.gameObject.SetActive(false);
        leftRotateButton_Pesut.gameObject.SetActive(false);
        upRotateButton_Pesut.gameObject.SetActive(false);
        downRotateButton_Pesut.gameObject.SetActive(false);

        // Cendrawasih Button
        rightRotateButton_Cendrawasih.gameObject.SetActive(false);
        leftRotateButton_Cendrawasih.gameObject.SetActive(false);
        upRotateButton_Cendrawasih.gameObject.SetActive(false);
        downRotateButton_Cendrawasih.gameObject.SetActive(false);

        // Jalak Button
        rightRotateButton_Jalak.gameObject.SetActive(false);
        leftRotateButton_Jalak.gameObject.SetActive(false);
        upRotateButton_Jalak.gameObject.SetActive(false);
        downRotateButton_Jalak.gameObject.SetActive(false);

        // Elang Button
        rightRotateButton_Elang.gameObject.SetActive(false);
        leftRotateButton_Elang.gameObject.SetActive(false);
        upRotateButton_Elang.gameObject.SetActive(false);
        downRotateButton_Elang.gameObject.SetActive(false);

        // Raflesia Button
        rightRotateButton_Raflesia.gameObject.SetActive(false);
        leftRotateButton_Raflesia.gameObject.SetActive(false);
        upRotateButton_Raflesia.gameObject.SetActive(false);
        downRotateButton_Raflesia.gameObject.SetActive(false);

        // Bangkai Button
        rightRotateButton_Bangkai.gameObject.SetActive(false);
        leftRotateButton_Bangkai.gameObject.SetActive(false);
        upRotateButton_Bangkai.gameObject.SetActive(false);
        downRotateButton_Bangkai.gameObject.SetActive(false);

        // Bumi Button
        rightRotateButton_Bumi.gameObject.SetActive(false);
        leftRotateButton_Bumi.gameObject.SetActive(false);
        upRotateButton_Bumi.gameObject.SetActive(false);
        downRotateButton_Bumi.gameObject.SetActive(false);

        // Hidrologi Button
        rightRotateButton_Hidrologi.gameObject.SetActive(false);
        leftRotateButton_Hidrologi.gameObject.SetActive(false);
        upRotateButton_Hidrologi.gameObject.SetActive(false);
        downRotateButton_Hidrologi.gameObject.SetActive(false);
    }

    // Tiger 
    public void RightRotation_Tiger()
    {
        tiger_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Tiger()
    {
        tiger_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Tiger()
    {
        tiger_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Tiger()
    {
        tiger_2.transform.Rotate(-rotation, 0f, 0f);

    }

    // Komodo 
    public void RightRotation_Komodo()
    {
        komodo_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Komodo()
    {
        komodo_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Komodo()
    {
        komodo_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Komodo()
    {
        komodo_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Badak 
    public void RightRotation_Badak()
    {
        badak_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Badak()
    {
        badak_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Badak()
    {
        badak_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Badak()
    {
        badak_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Gajah 
    public void RightRotation_Gajah()
    {
        gajah_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Gajah()
    {
        gajah_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Gajah()
    {
        gajah_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Gajah()
    {
        gajah_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Pesut
    public void RightRotation_Pesut()
    {
        pesut_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Pesut()
    {
        pesut_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Pesut()
    {
        pesut_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Pesut()
    {
        pesut_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Cendrawasih 
    public void RightRotation_Cendrawasih()
    {
        cendrawasih_1.transform.Rotate(0f, 0f, -rotation);
    }

    public void LeftRotation_Cendrawasih()
    {
        cendrawasih_1.transform.Rotate(0f, 0f, rotation);
    }

    public void UpRotation_Cendrawasih()
    {
        cendrawasih_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Cendrawasih()
    {
        cendrawasih_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Jalak 
    public void RightRotation_Jalak()
    {
        jalak_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Jalak()
    {
        jalak_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Jalak()
    {
        jalak_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Jalak()
    {
        jalak_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Elang 
    public void RightRotation_Elang()
    {
        elang_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Elang()
    {
        elang_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Elang()
    {
        elang_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Elang()
    {
        elang_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Raflesia
    public void RightRotation_Raflesia()
    {
        raflesia_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Raflesia()
    {
        raflesia_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Rafleisa()
    {
        raflesia_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Raflesia()
    {
        raflesia_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Bangkai
    public void RightRotation_Bangkai()
    {
        bangkai_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Bangkai()
    {
        bangkai_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Bangkai()
    {
        bangkai_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Bangkai()
    {
        bangkai_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Bumi
    public void RightRotation_Bumi()
    {
        bumi_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Bumi()
    {
        bumi_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Bumi()
    {
        bumi_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Bumi()
    {
        bumi_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Hidrologi
    public void RightRotation_Hidrologi()
    {
        hidrologi_1.transform.Rotate(0f, rotation, 0f);
    }

    public void LeftRotation_Hidrologi()
    {
        hidrologi_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void UpRotation_Hidrologi()
    {
        hidrologi_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Hidrologi()
    {
        hidrologi_2.transform.Rotate(-rotation, 0f, 0f);
    }
}