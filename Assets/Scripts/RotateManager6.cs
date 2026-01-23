using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RotateManager6 : MonoBehaviour
{
    [SerializeField] private float rotation = 10f;
    // Candi Bentar
    [SerializeField] private Button rightRotateButton_Candi_Bentar;
    [SerializeField] private Button leftRotateButton_Candi_Bentar;
    [SerializeField] private Button upRotateButton_Candi_Bentar;
    [SerializeField] private Button downRotateButton_Candi_Bentar;
    // Istana Loka
    [SerializeField] private Button rightRotateButton_Istana_Loka;
    [SerializeField] private Button leftRotateButton_Istana_Loka;
    [SerializeField] private Button upRotateButton_Istana_Loka;
    [SerializeField] private Button downRotateButton_Istana_Loka;
    // Musalaki
    [SerializeField] private Button rightRotateButton_Musalaki;
    [SerializeField] private Button leftRotateButton_Musalaki;
    [SerializeField] private Button upRotateButton_Musalaki;
    [SerializeField] private Button downRotateButton_Musalaki;
    // Dulohupa
    [SerializeField] private Button rightRotateButton_Dulohupa;
    [SerializeField] private Button leftRotateButton_Dulohupa;
    [SerializeField] private Button upRotateButton_Dulohupa;
    [SerializeField] private Button downRotateButton_Dulohupa;
    // Boyang
    [SerializeField] private Button rightRotateButton_Boyang;
    [SerializeField] private Button leftRotateButton_Boyang;
    [SerializeField] private Button upRotateButton_Boyang;
    [SerializeField] private Button downRotateButton_Boyang;
    // Tambi
    [SerializeField] private Button rightRotateButton_Tambi;
    [SerializeField] private Button leftRotateButton_Tambi;
    [SerializeField] private Button upRotateButton_Tambi;
    [SerializeField] private Button downRotateButton_Tambi;
    // Walawengko
    [SerializeField] private Button rightRotateButton_Walawengko;
    [SerializeField] private Button leftRotateButton_Walawengko;
    [SerializeField] private Button upRotateButton_Walawengko;
    [SerializeField] private Button downRotateButton_Walawengko;
    // Banua Tada
    [SerializeField] private Button rightRotateButton_Banua_Tada;
    [SerializeField] private Button leftRotateButton_Banua_Tada;
    [SerializeField] private Button upRotateButton_Banua_Tada;
    [SerializeField] private Button downRotateButton_Banua_Tada;
    // Tongkonan
    [SerializeField] private Button rightRotateButton_Tongkonan;
    [SerializeField] private Button leftRotateButton_Tongkonan;
    [SerializeField] private Button upRotateButton_Tongkonan;
    [SerializeField] private Button downRotateButton_Tongkonan;

    [SerializeField] private GameObject Candi_Bentar_1;
    [SerializeField] private GameObject Candi_Bentar_2;

    [SerializeField] private GameObject Istana_Loka_1;
    [SerializeField] private GameObject Istana_Loka_2;

    [SerializeField] private GameObject Musalaki_1;
    [SerializeField] private GameObject Musalaki_2;

    [SerializeField] private GameObject Dulohupa_1;
    [SerializeField] private GameObject Dulohupa_2;

    [SerializeField] private GameObject Boyang_1;
    [SerializeField] private GameObject Boyang_2;

    [SerializeField] private GameObject Tambi_1;
    [SerializeField] private GameObject Tambi_2;

    [SerializeField] private GameObject Walawengko_1;
    [SerializeField] private GameObject Walawengko_2;

    [SerializeField] private GameObject Banua_Tada_1;
    [SerializeField] private GameObject Banua_Tada_2;

    [SerializeField] private GameObject Tongkonan_1;
    [SerializeField] private GameObject Tongkonan_2;

    private void Start()
    {
        allObjectsFalse();

    }

    // Candi_Bentar 
    public void OnTargetFound_Candi_Bentar()
    {
        rightRotateButton_Candi_Bentar.gameObject.SetActive(true);
        leftRotateButton_Candi_Bentar.gameObject.SetActive(true);
        upRotateButton_Candi_Bentar.gameObject.SetActive(true);
        downRotateButton_Candi_Bentar.gameObject.SetActive(true);
    }

    public void OnTargetLost_Candi_Bentar()
    {
        allObjectsFalse();
    }

    // Istana_Loka
    public void OnTargetFound_Istana_Loka()
    {
        rightRotateButton_Istana_Loka.gameObject.SetActive(true);
        leftRotateButton_Istana_Loka.gameObject.SetActive(true);
        upRotateButton_Istana_Loka.gameObject.SetActive(true);
        downRotateButton_Istana_Loka.gameObject.SetActive(true);
    }

    public void OnTargetLost_Istana_Loka()
    {
        allObjectsFalse();
    }

    // Musalaki
    public void OnTargetFound_Musalaki()
    {
        rightRotateButton_Musalaki.gameObject.SetActive(true);
        leftRotateButton_Musalaki.gameObject.SetActive(true);
        upRotateButton_Musalaki.gameObject.SetActive(true);
        downRotateButton_Musalaki.gameObject.SetActive(true);
    }

    public void OnTargetLost_Musalaki()
    {
        allObjectsFalse();
    }

    // Dulohupa
    public void OnTargetFound_Dulohupa()
    {
        rightRotateButton_Dulohupa.gameObject.SetActive(true);
        leftRotateButton_Dulohupa.gameObject.SetActive(true);
        upRotateButton_Dulohupa.gameObject.SetActive(true);
        downRotateButton_Dulohupa.gameObject.SetActive(true);
    }

    public void OnTargetLost_Dulohupa()
    {
        allObjectsFalse();
    }

    // Boyang
    public void OnTargetFound_Boyang()
    {
        rightRotateButton_Boyang.gameObject.SetActive(true);
        leftRotateButton_Boyang.gameObject.SetActive(true);
        upRotateButton_Boyang.gameObject.SetActive(true);
        downRotateButton_Boyang.gameObject.SetActive(true);
    }

    public void OnTargetLost_Boyang()
    {
        allObjectsFalse();
    }

    // Tambi
    public void OnTargetFound_Tambi()
    {
        rightRotateButton_Tambi.gameObject.SetActive(true);
        leftRotateButton_Tambi.gameObject.SetActive(true);
        upRotateButton_Tambi.gameObject.SetActive(true);
        downRotateButton_Tambi.gameObject.SetActive(true);
    }

    public void OnTargetLost_Tambi()
    {
        allObjectsFalse();
    }

    // Walawengko
    public void OnTargetFound_Walawengko()
    {
        rightRotateButton_Walawengko.gameObject.SetActive(true);
        leftRotateButton_Walawengko.gameObject.SetActive(true);
        upRotateButton_Walawengko.gameObject.SetActive(true);
        downRotateButton_Walawengko.gameObject.SetActive(true);
    }

    public void OnTargetLost_Walawengko()
    {
        allObjectsFalse();
    }

    // Banua_Tada
    public void OnTargetFound_Banua_Tada()
    {
        rightRotateButton_Banua_Tada.gameObject.SetActive(true);
        leftRotateButton_Banua_Tada.gameObject.SetActive(true);
        upRotateButton_Banua_Tada.gameObject.SetActive(true);
        downRotateButton_Banua_Tada.gameObject.SetActive(true);
    }

    public void OnTargetLost_Banua_Tada()
    {
        allObjectsFalse();
    }

    // Tongkonan
    public void OnTargetFound_Tongkonan()
    {
        rightRotateButton_Tongkonan.gameObject.SetActive(true);
        leftRotateButton_Tongkonan.gameObject.SetActive(true);
        upRotateButton_Tongkonan.gameObject.SetActive(true);
        downRotateButton_Tongkonan.gameObject.SetActive(true);
    }

    public void OnTargetLost_Tongkonan()
    {
        allObjectsFalse();
    }

    private void allObjectsFalse()
    {
        // Candi Bentar Button
        rightRotateButton_Candi_Bentar.gameObject.SetActive(false);
        leftRotateButton_Candi_Bentar.gameObject.SetActive(false);
        upRotateButton_Candi_Bentar.gameObject.SetActive(false);
        downRotateButton_Candi_Bentar.gameObject.SetActive(false);

        // Istana Loka Button
        rightRotateButton_Istana_Loka.gameObject.SetActive(false);
        leftRotateButton_Istana_Loka.gameObject.SetActive(false);
        upRotateButton_Istana_Loka.gameObject.SetActive(false);
        downRotateButton_Istana_Loka.gameObject.SetActive(false);

        // Musalaki Button
        rightRotateButton_Musalaki.gameObject.SetActive(false);
        leftRotateButton_Musalaki.gameObject.SetActive(false);
        upRotateButton_Musalaki.gameObject.SetActive(false);
        downRotateButton_Musalaki.gameObject.SetActive(false);

        // Dulohupa Button
        rightRotateButton_Dulohupa.gameObject.SetActive(false);
        leftRotateButton_Dulohupa.gameObject.SetActive(false);
        upRotateButton_Dulohupa.gameObject.SetActive(false);
        downRotateButton_Dulohupa.gameObject.SetActive(false);

        // Boyang Button
        rightRotateButton_Boyang.gameObject.SetActive(false);
        leftRotateButton_Boyang.gameObject.SetActive(false);
        upRotateButton_Boyang.gameObject.SetActive(false);
        downRotateButton_Boyang.gameObject.SetActive(false);

        // Tambi Button
        rightRotateButton_Tambi.gameObject.SetActive(false);
        leftRotateButton_Tambi.gameObject.SetActive(false);
        upRotateButton_Tambi.gameObject.SetActive(false);
        downRotateButton_Tambi.gameObject.SetActive(false);

        // Walawengko Button
        rightRotateButton_Walawengko.gameObject.SetActive(false);
        leftRotateButton_Walawengko.gameObject.SetActive(false);
        upRotateButton_Walawengko.gameObject.SetActive(false);
        downRotateButton_Walawengko.gameObject.SetActive(false);

        // Banua Tada Button
        rightRotateButton_Banua_Tada.gameObject.SetActive(false);
        leftRotateButton_Banua_Tada.gameObject.SetActive(false);
        upRotateButton_Banua_Tada.gameObject.SetActive(false);
        downRotateButton_Banua_Tada.gameObject.SetActive(false);

        // Tongkonan Button
        rightRotateButton_Tongkonan.gameObject.SetActive(false);
        leftRotateButton_Tongkonan.gameObject.SetActive(false);
        upRotateButton_Tongkonan.gameObject.SetActive(false);
        downRotateButton_Tongkonan.gameObject.SetActive(false);
    }

    // Candi Bentar 
    public void RightRotation_Candi_Bentar()
    {
        Candi_Bentar_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Candi_Bentar()
    {
        Candi_Bentar_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Candi_Bentar()
    {
        Candi_Bentar_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Candi_Bentar()
    {
        Candi_Bentar_2.transform.Rotate(-rotation, 0f, 0f);

    }

    // Istana Loka 
    public void RightRotation_Istana_Loka()
    {
        Istana_Loka_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Istana_Loka()
    {
        Istana_Loka_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Istana_Loka()
    {
        Istana_Loka_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Istana_Loka()
    {
        Istana_Loka_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Musalaki 
    public void RightRotation_Musalaki()
    {
        Musalaki_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Musalaki()
    {
        Musalaki_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Musalaki()
    {
        Musalaki_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Musalaki()
    {
        Musalaki_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Dulohupa 
    public void RightRotation_Dulohupa()
    {
        Dulohupa_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Dulohupa()
    {
        Dulohupa_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Dulohupa()
    {
        Dulohupa_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Dulohupa()
    {
        Dulohupa_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Boyang
    public void RightRotation_Boyang()
    {
        Boyang_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Boyang()
    {
        Boyang_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Boyang()
    {
        Boyang_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Boyang()
    {
        Boyang_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Tambi 
    public void RightRotation_Tambi()
    {
        Tambi_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Tambi()
    {
        Tambi_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Tambi()
    {
        Tambi_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Tambi()
    {
        Tambi_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Walawengko 
    public void RightRotation_Walawengko()
    {
        Walawengko_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Walawengko()
    {
        Walawengko_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Walawengko()
    {
        Walawengko_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Walawengko()
    {
        Walawengko_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Banua Tada 
    public void RightRotation_Banua_Tada()
    {
        Banua_Tada_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Banua_Tada()
    {
        Banua_Tada_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Banua_Tada()
    {
        Banua_Tada_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Banua_Tada()
    {
        Banua_Tada_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Tongkonan 
    public void RightRotation_Tongkonan()
    {
        Tongkonan_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Tongkonan()
    {
        Tongkonan_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Tongkonan()
    {
        Tongkonan_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Tongkonan()
    {
        Tongkonan_2.transform.Rotate(-rotation, 0f, 0f);
    }
}