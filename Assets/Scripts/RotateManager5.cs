using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RotateManager5 : MonoBehaviour
{
    [SerializeField] private float rotation = 10f;
    // Sulah Nyanda
    [SerializeField] private Button rightRotateButton_Sulah_Nyanda;
    [SerializeField] private Button leftRotateButton_Sulah_Nyanda;
    [SerializeField] private Button upRotateButton_Sulah_Nyanda;
    [SerializeField] private Button downRotateButton_Sulah_Nyanda;

    // Kebaya
    [SerializeField] private Button rightRotateButton_Kebaya;
    [SerializeField] private Button leftRotateButton_Kebaya;
    [SerializeField] private Button upRotateButton_Kebaya;
    [SerializeField] private Button downRotateButton_Kebaya;

    // Kasepuhan
    [SerializeField] private Button rightRotateButton_Kasepuhan;
    [SerializeField] private Button leftRotateButton_Kasepuhan;
    [SerializeField] private Button upRotateButton_Kasepuhan;
    [SerializeField] private Button downRotateButton_Kasepuhan;

    // Joglo Jateng
    [SerializeField] private Button rightRotateButton_Joglo_Jateng;
    [SerializeField] private Button leftRotateButton_Joglo_Jateng;
    [SerializeField] private Button upRotateButton_Joglo_Jateng;
    [SerializeField] private Button downRotateButton_Joglo_Jateng;

    // Joglo Jogja
    [SerializeField] private Button rightRotateButton_Joglo_Jogja;
    [SerializeField] private Button leftRotateButton_Joglo_Jogja;
    [SerializeField] private Button upRotateButton_Joglo_Jogja;
    [SerializeField] private Button downRotateButton_Joglo_Jogja;

    // Joglo Jatim
    [SerializeField] private Button rightRotateButton_Joglo_Jatim;
    [SerializeField] private Button leftRotateButton_Joglo_Jatim;
    [SerializeField] private Button upRotateButton_Joglo_Jatim;
    [SerializeField] private Button downRotateButton_Joglo_Jatim;

    [SerializeField] private GameObject Sulah_Nyanda_1;
    [SerializeField] private GameObject Sulah_Nyanda_2;

    [SerializeField] private GameObject Kebaya_1;
    [SerializeField] private GameObject Kebaya_2;

    [SerializeField] private GameObject Kasepuhan_1;
    [SerializeField] private GameObject Kasepuhan_2;

    [SerializeField] private GameObject Joglo_Jateng_1;
    [SerializeField] private GameObject Joglo_Jateng_2;

    [SerializeField] private GameObject Joglo_Jogja_1;
    [SerializeField] private GameObject Joglo_Jogja_2;

    [SerializeField] private GameObject Joglo_Jatim_1;
    [SerializeField] private GameObject Joglo_Jatim_2;

    private void Start()
    {
        allObjectsFalse();

    }

    // Sulah_Nyanda 
    public void OnTargetFound_Sulah_Nyanda()
    {
        rightRotateButton_Sulah_Nyanda.gameObject.SetActive(true);
        leftRotateButton_Sulah_Nyanda.gameObject.SetActive(true);
        upRotateButton_Sulah_Nyanda.gameObject.SetActive(true);
        downRotateButton_Sulah_Nyanda.gameObject.SetActive(true);
    }

    public void OnTargetLost_Sulah_Nyanda()
    {
        allObjectsFalse();
    }

    // Kebaya
    public void OnTargetFound_Kebaya()
    {
        rightRotateButton_Kebaya.gameObject.SetActive(true);
        leftRotateButton_Kebaya.gameObject.SetActive(true);
        upRotateButton_Kebaya.gameObject.SetActive(true);
        downRotateButton_Kebaya.gameObject.SetActive(true);
    }

    public void OnTargetLost_Kebaya()
    {
        allObjectsFalse();
    }

    // Bubungan Tinggi
    public void OnTargetFound_Kasepuhan()
    {
        rightRotateButton_Kasepuhan.gameObject.SetActive(true);
        leftRotateButton_Kasepuhan.gameObject.SetActive(true);
        upRotateButton_Kasepuhan.gameObject.SetActive(true);
        downRotateButton_Kasepuhan.gameObject.SetActive(true);
    }

    public void OnTargetLost_Kasepuhan()
    {
        allObjectsFalse();
    }

    // Joglo Jateng
    public void OnTargetFound_Joglo_Jateng()
    {
        rightRotateButton_Joglo_Jateng.gameObject.SetActive(true);
        leftRotateButton_Joglo_Jateng.gameObject.SetActive(true);
        upRotateButton_Joglo_Jateng.gameObject.SetActive(true);
        downRotateButton_Joglo_Jateng.gameObject.SetActive(true);
    }

    public void OnTargetLost_Joglo_Jateng()
    {
        allObjectsFalse();
    }

    // Joglo Jogja
    public void OnTargetFound_Joglo_Jogja()
    {
        rightRotateButton_Joglo_Jogja.gameObject.SetActive(true);
        leftRotateButton_Joglo_Jogja.gameObject.SetActive(true);
        upRotateButton_Joglo_Jogja.gameObject.SetActive(true);
        downRotateButton_Joglo_Jogja.gameObject.SetActive(true);
    }

    public void OnTargetLost_Joglo_Jogja()
    {
        allObjectsFalse();
    }

    // Joglo Jatim
    public void OnTargetFound_Joglo_Jatim()
    {
        rightRotateButton_Joglo_Jatim.gameObject.SetActive(true);
        leftRotateButton_Joglo_Jatim.gameObject.SetActive(true);
        upRotateButton_Joglo_Jatim.gameObject.SetActive(true);
        downRotateButton_Joglo_Jatim.gameObject.SetActive(true);
    }

    public void OnTargetLost_Joglo_Jatim()
    {
        allObjectsFalse();
    }

    private void allObjectsFalse()
    {
        // Sulah_Nyanda Button
        rightRotateButton_Sulah_Nyanda.gameObject.SetActive(false);
        leftRotateButton_Sulah_Nyanda.gameObject.SetActive(false);
        upRotateButton_Sulah_Nyanda.gameObject.SetActive(false);
        downRotateButton_Sulah_Nyanda.gameObject.SetActive(false);

        // Kebaya Button
        rightRotateButton_Kebaya.gameObject.SetActive(false);
        leftRotateButton_Kebaya.gameObject.SetActive(false);
        upRotateButton_Kebaya.gameObject.SetActive(false);
        downRotateButton_Kebaya.gameObject.SetActive(false);

        // Bubungan Tinggi Button
        rightRotateButton_Kasepuhan.gameObject.SetActive(false);
        leftRotateButton_Kasepuhan.gameObject.SetActive(false);
        upRotateButton_Kasepuhan.gameObject.SetActive(false);
        downRotateButton_Kasepuhan.gameObject.SetActive(false);

        // Joglo Jateng Button
        rightRotateButton_Joglo_Jateng.gameObject.SetActive(false);
        leftRotateButton_Joglo_Jateng.gameObject.SetActive(false);
        upRotateButton_Joglo_Jateng.gameObject.SetActive(false);
        downRotateButton_Joglo_Jateng.gameObject.SetActive(false);

        // Joglo Jogja Button
        rightRotateButton_Joglo_Jogja.gameObject.SetActive(false);
        leftRotateButton_Joglo_Jogja.gameObject.SetActive(false);
        upRotateButton_Joglo_Jogja.gameObject.SetActive(false);
        downRotateButton_Joglo_Jogja.gameObject.SetActive(false);

        // Joglo Jatim Button
        rightRotateButton_Joglo_Jatim.gameObject.SetActive(false);
        leftRotateButton_Joglo_Jatim.gameObject.SetActive(false);
        upRotateButton_Joglo_Jatim.gameObject.SetActive(false);
        downRotateButton_Joglo_Jatim.gameObject.SetActive(false);
    }

    // Sulah_Nyanda 
    public void RightRotation_Sulah_Nyanda()
    {
        Sulah_Nyanda_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Sulah_Nyanda()
    {
        Sulah_Nyanda_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Sulah_Nyanda()
    {
        Sulah_Nyanda_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Sulah_Nyanda()
    {
        Sulah_Nyanda_2.transform.Rotate(-rotation, 0f, 0f);

    }

    // Kebaya 
    public void RightRotation_Kebaya()
    {
        Kebaya_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Kebaya()
    {
        Kebaya_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Kebaya()
    {
        Kebaya_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Kebaya()
    {
        Kebaya_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Bubungan Tinggi 
    public void RightRotation_Kasepuhan()
    {
        Kasepuhan_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Kasepuhan()
    {
        Kasepuhan_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Kasepuhan()
    {
        Kasepuhan_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Kasepuhan()
    {
        Kasepuhan_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Joglo Jateng 
    public void RightRotation_Joglo_Jateng()
    {
        Joglo_Jateng_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Joglo_Jateng()
    {
        Joglo_Jateng_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Joglo_Jateng()
    {
        Joglo_Jateng_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Joglo_Jateng()
    {
        Joglo_Jateng_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Joglo Jogja
    public void RightRotation_Joglo_Jogja()
    {
        Joglo_Jogja_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Joglo_Jogja()
    {
        Joglo_Jogja_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Joglo_Jogja()
    {
        Joglo_Jogja_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Joglo_Jogja()
    {
        Joglo_Jogja_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Joglo Jatim
    public void RightRotation_Joglo_Jatim()
    {
        Joglo_Jatim_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Joglo_Jatim()
    {
        Joglo_Jatim_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Joglo_Jatim()
    {
        Joglo_Jatim_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Joglo_Jatim()
    {
        Joglo_Jatim_2.transform.Rotate(-rotation, 0f, 0f);
    }
}