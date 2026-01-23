using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RotateManager4 : MonoBehaviour
{
    [SerializeField] private float rotation = 10f;
    // Panjang
    [SerializeField] private Button rightRotateButton_Panjang;
    [SerializeField] private Button leftRotateButton_Panjang;
    [SerializeField] private Button upRotateButton_Panjang;
    [SerializeField] private Button downRotateButton_Panjang;
    // Lamin
    [SerializeField] private Button rightRotateButton_Lamin;
    [SerializeField] private Button leftRotateButton_Lamin;
    [SerializeField] private Button upRotateButton_Lamin;
    [SerializeField] private Button downRotateButton_Lamin;
    // Bubungan Tinggi
    [SerializeField] private Button rightRotateButton_Bubungan_Tinggi;
    [SerializeField] private Button leftRotateButton_Bubungan_Tinggi;
    [SerializeField] private Button upRotateButton_Bubungan_Tinggi;
    [SerializeField] private Button downRotateButton_Bubungan_Tinggi;
    // Betang
    [SerializeField] private Button rightRotateButton_Betang;
    [SerializeField] private Button leftRotateButton_Betang;
    [SerializeField] private Button upRotateButton_Betang;
    [SerializeField] private Button downRotateButton_Betang;
    // Baloy
    [SerializeField] private Button rightRotateButton_Baloy;
    [SerializeField] private Button leftRotateButton_Baloy;
    [SerializeField] private Button upRotateButton_Baloy;
    [SerializeField] private Button downRotateButton_Baloy;

    [SerializeField] private GameObject Panjang_1;
    [SerializeField] private GameObject Panjang_2;

    [SerializeField] private GameObject Lamin_1;
    [SerializeField] private GameObject Lamin_2;

    [SerializeField] private GameObject Bubungan_Tinggi_1;
    [SerializeField] private GameObject Bubungan_Tinggi_2;

    [SerializeField] private GameObject Betang_1;
    [SerializeField] private GameObject Betang_2;

    [SerializeField] private GameObject Baloy_1;
    [SerializeField] private GameObject Baloy_2;

    private void Start()
    {
        allObjectsFalse();

    }

    // Panjang 
    public void OnTargetFound_Panjang()
    {
        rightRotateButton_Panjang.gameObject.SetActive(true);
        leftRotateButton_Panjang.gameObject.SetActive(true);
        upRotateButton_Panjang.gameObject.SetActive(true);
        downRotateButton_Panjang.gameObject.SetActive(true);
    }

    public void OnTargetLost_Panjang()
    {
        allObjectsFalse();
    }

    // Lamin
    public void OnTargetFound_Lamin()
    {
        rightRotateButton_Lamin.gameObject.SetActive(true);
        leftRotateButton_Lamin.gameObject.SetActive(true);
        upRotateButton_Lamin.gameObject.SetActive(true);
        downRotateButton_Lamin.gameObject.SetActive(true);
    }

    public void OnTargetLost_Lamin()
    {
        allObjectsFalse();
    }

    // Bubungan Tinggi
    public void OnTargetFound_Bubungan_Tinggi()
    {
        rightRotateButton_Bubungan_Tinggi.gameObject.SetActive(true);
        leftRotateButton_Bubungan_Tinggi.gameObject.SetActive(true);
        upRotateButton_Bubungan_Tinggi.gameObject.SetActive(true);
        downRotateButton_Bubungan_Tinggi.gameObject.SetActive(true);
    }

    public void OnTargetLost_Bubungan_Tinggi()
    {
        allObjectsFalse();
    }

    // Betang
    public void OnTargetFound_Betang()
    {
        rightRotateButton_Betang.gameObject.SetActive(true);
        leftRotateButton_Betang.gameObject.SetActive(true);
        upRotateButton_Betang.gameObject.SetActive(true);
        downRotateButton_Betang.gameObject.SetActive(true);
    }

    public void OnTargetLost_Betang()
    {
        allObjectsFalse();
    }

    // Baloy
    public void OnTargetFound_Baloy()
    {
        rightRotateButton_Baloy.gameObject.SetActive(true);
        leftRotateButton_Baloy.gameObject.SetActive(true);
        upRotateButton_Baloy.gameObject.SetActive(true);
        downRotateButton_Baloy.gameObject.SetActive(true);
    }

    public void OnTargetLost_Baloy()
    {
        allObjectsFalse();
    }

    private void allObjectsFalse()
    {
        // Panjang Button
        rightRotateButton_Panjang.gameObject.SetActive(false);
        leftRotateButton_Panjang.gameObject.SetActive(false);
        upRotateButton_Panjang.gameObject.SetActive(false);
        downRotateButton_Panjang.gameObject.SetActive(false);

        // Lamin Button
        rightRotateButton_Lamin.gameObject.SetActive(false);
        leftRotateButton_Lamin.gameObject.SetActive(false);
        upRotateButton_Lamin.gameObject.SetActive(false);
        downRotateButton_Lamin.gameObject.SetActive(false);

        // Bubungan Tinggi Button
        rightRotateButton_Bubungan_Tinggi.gameObject.SetActive(false);
        leftRotateButton_Bubungan_Tinggi.gameObject.SetActive(false);
        upRotateButton_Bubungan_Tinggi.gameObject.SetActive(false);
        downRotateButton_Bubungan_Tinggi.gameObject.SetActive(false);

        // Betang Button
        rightRotateButton_Betang.gameObject.SetActive(false);
        leftRotateButton_Betang.gameObject.SetActive(false);
        upRotateButton_Betang.gameObject.SetActive(false);
        downRotateButton_Betang.gameObject.SetActive(false);

        // Baloy Button
        rightRotateButton_Baloy.gameObject.SetActive(false);
        leftRotateButton_Baloy.gameObject.SetActive(false);
        upRotateButton_Baloy.gameObject.SetActive(false);
        downRotateButton_Baloy.gameObject.SetActive(false);
    }

    // Panjang 
    public void RightRotation_Panjang()
    {
        Panjang_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Panjang()
    {
        Panjang_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Panjang()
    {
        Panjang_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Panjang()
    {
        Panjang_2.transform.Rotate(-rotation, 0f, 0f);

    }

    // Lamin 
    public void RightRotation_Lamin()
    {
        Lamin_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Lamin()
    {
        Lamin_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Lamin()
    {
        Lamin_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Lamin()
    {
        Lamin_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Bubungan Tinggi 
    public void RightRotation_Bubungan_Tinggi()
    {
        Bubungan_Tinggi_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Bubungan_Tinggi()
    {
        Bubungan_Tinggi_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Bubungan_Tinggi()
    {
        Bubungan_Tinggi_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Bubungan_Tinggi()
    {
        Bubungan_Tinggi_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Betang 
    public void RightRotation_Betang()
    {
        Betang_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Betang()
    {
        Betang_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Betang()
    {
        Betang_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Betang()
    {
        Betang_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Baloy
    public void RightRotation_Baloy()
    {
        Baloy_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Baloy()
    {
        Baloy_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Baloy()
    {
        Baloy_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Baloy()
    {
        Baloy_2.transform.Rotate(-rotation, 0f, 0f);
    }
}