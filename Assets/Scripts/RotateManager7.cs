using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RotateManager7 : MonoBehaviour
{
    [SerializeField] private float rotation = 10f;
    // Sasadu
    [SerializeField] private Button rightRotateButton_Sasadu;
    [SerializeField] private Button leftRotateButton_Sasadu;
    [SerializeField] private Button upRotateButton_Sasadu;
    [SerializeField] private Button downRotateButton_Sasadu;

    // Baileo
    [SerializeField] private Button rightRotateButton_Baileo;
    [SerializeField] private Button leftRotateButton_Baileo;
    [SerializeField] private Button upRotateButton_Baileo;
    [SerializeField] private Button downRotateButton_Baileo;

    // Kaki Seribu Barat
    [SerializeField] private Button rightRotateButton_Kaki_Seribu_Barat;
    [SerializeField] private Button leftRotateButton_Kaki_Seribu_Barat;
    [SerializeField] private Button upRotateButton_Kaki_Seribu_Barat;
    [SerializeField] private Button downRotateButton_Kaki_Seribu_Barat;

    // Kariwari
    [SerializeField] private Button rightRotateButton_Kariwari;
    [SerializeField] private Button leftRotateButton_Kariwari;
    [SerializeField] private Button upRotateButton_Kariwari;
    [SerializeField] private Button downRotateButton_Kariwari;

    // Honai Tengah
    [SerializeField] private Button rightRotateButton_Honai_Tengah;
    [SerializeField] private Button leftRotateButton_Honai_Tengah;
    [SerializeField] private Button upRotateButton_Honai_Tengah;
    [SerializeField] private Button downRotateButton_Honai_Tengah;

    // Tinggi
    [SerializeField] private Button rightRotateButton_Tinggi;
    [SerializeField] private Button leftRotateButton_Tinggi;
    [SerializeField] private Button upRotateButton_Tinggi;
    [SerializeField] private Button downRotateButton_Tinggi;

    // Kaki Seribu Barat Daya
    [SerializeField] private Button rightRotateButton_Kaki_Seribu_Barat_Daya;
    [SerializeField] private Button leftRotateButton_Kaki_Seribu_Barat_Daya;
    [SerializeField] private Button upRotateButton_Kaki_Seribu_Barat_Daya;
    [SerializeField] private Button downRotateButton_Kaki_Seribu_Barat_Daya;

    // Honai Tengah
    [SerializeField] private Button rightRotateButton_Honai_Pegunungan;
    [SerializeField] private Button leftRotateButton_Honai_Pegunungan;
    [SerializeField] private Button upRotateButton_Honai_Pegunungan;
    [SerializeField] private Button downRotateButton_Honai_Pegunungan;

    [SerializeField] private GameObject Sasadu_1;
    [SerializeField] private GameObject Sasadu_2;

    [SerializeField] private GameObject Baileo_1;
    [SerializeField] private GameObject Baileo_2;

    [SerializeField] private GameObject Kaki_Seribu_Barat_1;
    [SerializeField] private GameObject Kaki_Seribu_Barat_2;

    [SerializeField] private GameObject Kariwari_1;
    [SerializeField] private GameObject Kariwari_2;

    [SerializeField] private GameObject Honai_Tengah_1;
    [SerializeField] private GameObject Honai_Tengah_2;

    [SerializeField] private GameObject Tinggi_1;
    [SerializeField] private GameObject Tinggi_2;

    [SerializeField] private GameObject Kaki_Seribu_Barat_Daya_1;
    [SerializeField] private GameObject Kaki_Seribu_Barat_Daya_2;

    [SerializeField] private GameObject Honai_Pegunungan_1;
    [SerializeField] private GameObject Honai_Pegunungan_2;

    private void Start()
    {
        allObjectsFalse();

    }

    // Sasadu 
    public void OnTargetFound_Sasadu()
    {
        rightRotateButton_Sasadu.gameObject.SetActive(true);
        leftRotateButton_Sasadu.gameObject.SetActive(true);
        upRotateButton_Sasadu.gameObject.SetActive(true);
        downRotateButton_Sasadu.gameObject.SetActive(true);
    }

    public void OnTargetLost_Sasadu()
    {
        allObjectsFalse();
    }

    // Baileo
    public void OnTargetFound_Baileo()
    {
        rightRotateButton_Baileo.gameObject.SetActive(true);
        leftRotateButton_Baileo.gameObject.SetActive(true);
        upRotateButton_Baileo.gameObject.SetActive(true);
        downRotateButton_Baileo.gameObject.SetActive(true);
    }

    public void OnTargetLost_Baileo()
    {
        allObjectsFalse();
    }

    // Kaki Seribu Barat
    public void OnTargetFound_Kaki_Seribu_Barat()
    {
        rightRotateButton_Kaki_Seribu_Barat.gameObject.SetActive(true);
        leftRotateButton_Kaki_Seribu_Barat.gameObject.SetActive(true);
        upRotateButton_Kaki_Seribu_Barat.gameObject.SetActive(true);
        downRotateButton_Kaki_Seribu_Barat.gameObject.SetActive(true);
    }

    public void OnTargetLost_Kaki_Seribu_Barat()
    {
        allObjectsFalse();
    }

    // Kariwari
    public void OnTargetFound_Kariwari()
    {
        rightRotateButton_Kariwari.gameObject.SetActive(true);
        leftRotateButton_Kariwari.gameObject.SetActive(true);
        upRotateButton_Kariwari.gameObject.SetActive(true);
        downRotateButton_Kariwari.gameObject.SetActive(true);
    }

    public void OnTargetLost_Kariwari()
    {
        allObjectsFalse();
    }

    // Honai Tengah
    public void OnTargetFound_Honai_Tengah()
    {
        rightRotateButton_Honai_Tengah.gameObject.SetActive(true);
        leftRotateButton_Honai_Tengah.gameObject.SetActive(true);
        upRotateButton_Honai_Tengah.gameObject.SetActive(true);
        downRotateButton_Honai_Tengah.gameObject.SetActive(true);
    }

    public void OnTargetLost_Honai_Tengah()
    {
        allObjectsFalse();
    }

    // Tinggi
    public void OnTargetFound_Tinggi()
    {
        rightRotateButton_Tinggi.gameObject.SetActive(true);
        leftRotateButton_Tinggi.gameObject.SetActive(true);
        upRotateButton_Tinggi.gameObject.SetActive(true);
        downRotateButton_Tinggi.gameObject.SetActive(true);
    }

    public void OnTargetLost_Tinggi()
    {
        allObjectsFalse();
    }

    // Kaki Seribu Barat Daya
    public void OnTargetFound_Kaki_Seribu_Barat_Daya()
    {
        rightRotateButton_Kaki_Seribu_Barat_Daya.gameObject.SetActive(true);
        leftRotateButton_Kaki_Seribu_Barat_Daya.gameObject.SetActive(true);
        upRotateButton_Kaki_Seribu_Barat_Daya.gameObject.SetActive(true);
        downRotateButton_Kaki_Seribu_Barat_Daya.gameObject.SetActive(true);
    }

    public void OnTargetLost_Kaki_Seribu_Barat_Daya()
    {
        allObjectsFalse();
    }

    // Honai Pegunungan
    public void OnTargetFound_Honai_Pengunungan()
    {
        rightRotateButton_Honai_Pegunungan.gameObject.SetActive(true);
        leftRotateButton_Honai_Pegunungan.gameObject.SetActive(true);
        upRotateButton_Honai_Pegunungan.gameObject.SetActive(true);
        downRotateButton_Honai_Pegunungan.gameObject.SetActive(true);
    }

    public void OnTargetLost_Honai_Pegunungan()
    {
        allObjectsFalse();
    }

    private void allObjectsFalse()
    {
        // Sasadu Button
        rightRotateButton_Sasadu.gameObject.SetActive(false);
        leftRotateButton_Sasadu.gameObject.SetActive(false);
        upRotateButton_Sasadu.gameObject.SetActive(false);
        downRotateButton_Sasadu.gameObject.SetActive(false);

        // Baileo Button
        rightRotateButton_Baileo.gameObject.SetActive(false);
        leftRotateButton_Baileo.gameObject.SetActive(false);
        upRotateButton_Baileo.gameObject.SetActive(false);
        downRotateButton_Baileo.gameObject.SetActive(false);

        // Kaki Seibu Barat Tinggi Button
        rightRotateButton_Kaki_Seribu_Barat.gameObject.SetActive(false);
        leftRotateButton_Kaki_Seribu_Barat.gameObject.SetActive(false);
        upRotateButton_Kaki_Seribu_Barat.gameObject.SetActive(false);
        downRotateButton_Kaki_Seribu_Barat.gameObject.SetActive(false);

        // Kariwari Jateng Button
        rightRotateButton_Kariwari.gameObject.SetActive(false);
        leftRotateButton_Kariwari.gameObject.SetActive(false);
        upRotateButton_Kariwari.gameObject.SetActive(false);
        downRotateButton_Kariwari.gameObject.SetActive(false);

        // Honai Tengah Button
        rightRotateButton_Honai_Tengah.gameObject.SetActive(false);
        leftRotateButton_Honai_Tengah.gameObject.SetActive(false);
        upRotateButton_Honai_Tengah.gameObject.SetActive(false);
        downRotateButton_Honai_Tengah.gameObject.SetActive(false);

        // Tinggi Button
        rightRotateButton_Tinggi.gameObject.SetActive(false);
        leftRotateButton_Tinggi.gameObject.SetActive(false);
        upRotateButton_Tinggi.gameObject.SetActive(false);
        downRotateButton_Tinggi.gameObject.SetActive(false);

        // Kaki Seibu Barat Daya Button
        rightRotateButton_Kaki_Seribu_Barat_Daya.gameObject.SetActive(false);
        leftRotateButton_Kaki_Seribu_Barat_Daya.gameObject.SetActive(false);
        upRotateButton_Kaki_Seribu_Barat_Daya.gameObject.SetActive(false);
        downRotateButton_Kaki_Seribu_Barat_Daya.gameObject.SetActive(false);

        // Honai Pegunungan Button
        rightRotateButton_Honai_Pegunungan.gameObject.SetActive(false);
        leftRotateButton_Honai_Pegunungan.gameObject.SetActive(false);
        upRotateButton_Honai_Pegunungan.gameObject.SetActive(false);
        downRotateButton_Honai_Pegunungan.gameObject.SetActive(false);
    }

    // Sasadu 
    public void RightRotation_Sasadu()
    {
        Sasadu_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Sasadu()
    {
        Sasadu_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Sasadu()
    {
        Sasadu_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Sasadu()
    {
        Sasadu_2.transform.Rotate(-rotation, 0f, 0f);

    }

    // Baileo 
    public void RightRotation_Baileo()
    {
        Baileo_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Baileo()
    {
        Baileo_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Baileo()
    {
        Baileo_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Baileo()
    {
        Baileo_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Kaki Seribu Barat 
    public void RightRotation_Kaki_Seribu_Barat()
    {
        Kaki_Seribu_Barat_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Kaki_Seribu_Barat()
    {
        Kaki_Seribu_Barat_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Kaki_Seribu_Barat()
    {
        Kaki_Seribu_Barat_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Kaki_Seribu_Barat()
    {
        Kaki_Seribu_Barat_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Kariwari
    public void RightRotation_Kariwari()
    {
        Kariwari_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Kariwari()
    {
        Kariwari_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Kariwari()
    {
        Kariwari_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Kariwari()
    {
        Kariwari_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Honai Tengah
    public void RightRotation_Honai_Tengah()
    {
        Honai_Tengah_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Honai_Tengah()
    {
        Honai_Tengah_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Honai_Tengah()
    {
        Honai_Tengah_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Honai_Tengah()
    {
        Honai_Tengah_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Tinggi
    public void RightRotation_Tinggi()
    {
        Tinggi_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Tinggi()
    {
        Tinggi_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Tinggi()
    {
        Tinggi_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Tinggi()
    {
        Tinggi_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Kaki Seribu Barat Daya
    public void RightRotation_Kaki_Seribu_Barat_Daya()
    {
        Kaki_Seribu_Barat_Daya_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Kaki_Seribu_Barat_Daya()
    {
        Kaki_Seribu_Barat_Daya_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Kaki_Seribu_Barat_Daya()
    {
        Kaki_Seribu_Barat_Daya_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Kaki_Seribu_Barat_Daya()
    {
        Kaki_Seribu_Barat_Daya_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Honai Pegunungan
    public void RightRotation_Honai_Pegunungan()
    {
        Honai_Pegunungan_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Honai_Pegunungan()
    {
        Honai_Pegunungan_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Honai_Pegunungan()
    {
        Honai_Pegunungan_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Honai_Pegunungan()
    {
        Honai_Pegunungan_2.transform.Rotate(-rotation, 0f, 0f);
    }
}