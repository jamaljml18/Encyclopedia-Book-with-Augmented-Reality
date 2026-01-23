using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RotateManager3 : MonoBehaviour
{
    [SerializeField] private float rotation = 10f;
    // Krong Bade
    [SerializeField] private Button rightRotateButton_Krong_Bade;
    [SerializeField] private Button leftRotateButton_Krong_Bade;
    [SerializeField] private Button upRotateButton_Krong_Bade;
    [SerializeField] private Button downRotateButton_Krong_Bade;
    // Bolon
    [SerializeField] private Button rightRotateButton_Bolon;
    [SerializeField] private Button leftRotateButton_Bolon;
    [SerializeField] private Button upRotateButton_Bolon;
    [SerializeField] private Button downRotateButton_Bolon;
    // Limas
    [SerializeField] private Button rightRotateButton_Limas;
    [SerializeField] private Button leftRotateButton_Limas;
    [SerializeField] private Button upRotateButton_Limas;
    [SerializeField] private Button downRotateButton_Limas;
    // Gadang
    [SerializeField] private Button rightRotateButton_Gadang;
    [SerializeField] private Button leftRotateButton_Gadang;
    [SerializeField] private Button upRotateButton_Gadang;
    [SerializeField] private Button downRotateButton_Gadang;
    // Bubungan Lima
    [SerializeField] private Button rightRotateButton_Bubungan_Lima;
    [SerializeField] private Button leftRotateButton_Bubungan_Lima;
    [SerializeField] private Button upRotateButton_Bubungan_Lima;
    [SerializeField] private Button downRotateButton_Bubungan_Lima;
    // Selaso
    [SerializeField] private Button rightRotateButton_Selaso;
    [SerializeField] private Button leftRotateButton_Selaso;
    [SerializeField] private Button upRotateButton_Selaso;
    [SerializeField] private Button downRotateButton_Selaso;
    // Limas Potong
    [SerializeField] private Button rightRotateButton_Limas_Potong;
    [SerializeField] private Button leftRotateButton_Limas_Potong;
    [SerializeField] private Button upRotateButton_Limas_Potong;
    [SerializeField] private Button downRotateButton_Limas_Potong;
    // Kajang Leko
    [SerializeField] private Button rightRotateButton_Kajang_Leko;
    [SerializeField] private Button leftRotateButton_Kajang_Leko;
    [SerializeField] private Button upRotateButton_Kajang_Leko;
    [SerializeField] private Button downRotateButton_Kajang_Leko;

    // Nuwo Sesat
    [SerializeField] private Button rightRotateButton_Nuwo_Sesat;
    [SerializeField] private Button leftRotateButton_Nuwo_Sesat;
    [SerializeField] private Button upRotateButton_Nuwo_Sesat;
    [SerializeField] private Button downRotateButton_Nuwo_Sesat;

    // Rakit
    [SerializeField] private Button rightRotateButton_Rakit;
    [SerializeField] private Button leftRotateButton_Rakit;
    [SerializeField] private Button upRotateButton_Rakit;
    [SerializeField] private Button downRotateButton_Rakit;

    [SerializeField] private GameObject Krong_Bade_1;
    [SerializeField] private GameObject Krong_Bade_2;

    [SerializeField] private GameObject Bolon_1;
    [SerializeField] private GameObject Bolon_2;

    [SerializeField] private GameObject Limas_1;
    [SerializeField] private GameObject Limas_2;

    [SerializeField] private GameObject gadang_1;
    [SerializeField] private GameObject gadang_2;

    [SerializeField] private GameObject Bubungan_Lima_1;
    [SerializeField] private GameObject Bubungan_Lima_2;

    [SerializeField] private GameObject Selaso_1;
    [SerializeField] private GameObject Selaso_2;

    [SerializeField] private GameObject Limas_Potong_1;
    [SerializeField] private GameObject Limas_Potong_2;

    [SerializeField] private GameObject Kajang_Leko_1;
    [SerializeField] private GameObject Kajang_Leko_2;

    [SerializeField] private GameObject Nuwo_Sesat_1;
    [SerializeField] private GameObject Nuwo_Sesat_2;

    [SerializeField] private GameObject Rakit_1;
    [SerializeField] private GameObject Rakit_2;

    private void Start()
    {
        allObjectsFalse();

    }

    // Krong Bade 
    public void OnTargetFound_Krong_Bade()
    {
        rightRotateButton_Krong_Bade.gameObject.SetActive(true);
        leftRotateButton_Krong_Bade.gameObject.SetActive(true);
        upRotateButton_Krong_Bade.gameObject.SetActive(true);
        downRotateButton_Krong_Bade.gameObject.SetActive(true);
    }

    public void OnTargetLost_Krong_Bade()
    {
        allObjectsFalse();
    }

    // Bolon
    public void OnTargetFound_Bolon()
    {
        rightRotateButton_Bolon.gameObject.SetActive(true);
        leftRotateButton_Bolon.gameObject.SetActive(true);
        upRotateButton_Bolon.gameObject.SetActive(true);
        downRotateButton_Bolon.gameObject.SetActive(true);
    }

    public void OnTargetLost_Bolon()
    {
        allObjectsFalse();
    }

    // Limas
    public void OnTargetFound_Limas()
    {
        rightRotateButton_Limas.gameObject.SetActive(true);
        leftRotateButton_Limas.gameObject.SetActive(true);
        upRotateButton_Limas.gameObject.SetActive(true);
        downRotateButton_Limas.gameObject.SetActive(true);
    }

    public void OnTargetLost_Limas()
    {
        allObjectsFalse();
    }

    // Gadang
    public void OnTargetFound_Gadang()
    {
        rightRotateButton_Gadang.gameObject.SetActive(true);
        leftRotateButton_Gadang.gameObject.SetActive(true);
        upRotateButton_Gadang.gameObject.SetActive(true);
        downRotateButton_Gadang.gameObject.SetActive(true);
    }

    public void OnTargetLost_Gadang()
    {
        allObjectsFalse();
    }

    // Bubungan Lima
    public void OnTargetFound_Bubungan_Lima()
    {
        rightRotateButton_Bubungan_Lima.gameObject.SetActive(true);
        leftRotateButton_Bubungan_Lima.gameObject.SetActive(true);
        upRotateButton_Bubungan_Lima.gameObject.SetActive(true);
        downRotateButton_Bubungan_Lima.gameObject.SetActive(true);
    }

    public void OnTargetLost_Bubungan_Lima()
    {
        allObjectsFalse();
    }

    // Selaso
    public void OnTargetFound_Selaso()
    {
        rightRotateButton_Selaso.gameObject.SetActive(true);
        leftRotateButton_Selaso.gameObject.SetActive(true);
        upRotateButton_Selaso.gameObject.SetActive(true);
        downRotateButton_Selaso.gameObject.SetActive(true);
    }

    public void OnTargetLost_Selaso()
    {
        allObjectsFalse();
    }

    // Limas_Potong
    public void OnTargetFound_Limas_Potong()
    {
        rightRotateButton_Limas_Potong.gameObject.SetActive(true);
        leftRotateButton_Limas_Potong.gameObject.SetActive(true);
        upRotateButton_Limas_Potong.gameObject.SetActive(true);
        downRotateButton_Limas_Potong.gameObject.SetActive(true);
    }

    public void OnTargetLost_Limas_Potong()
    {
        allObjectsFalse();
    }

    // Kajang Leko
    public void OnTargetFound_Kajang_Leko()
    {
        rightRotateButton_Kajang_Leko.gameObject.SetActive(true);
        leftRotateButton_Kajang_Leko.gameObject.SetActive(true);
        upRotateButton_Kajang_Leko.gameObject.SetActive(true);
        downRotateButton_Kajang_Leko.gameObject.SetActive(true);
    }

    public void OnTargetLost_Kajang_Leko()
    {
        allObjectsFalse();
    }

    // Nuwo Sesat
    public void OnTargetFound_Nuwo_Sesat()
    {
        rightRotateButton_Nuwo_Sesat.gameObject.SetActive(true);
        leftRotateButton_Nuwo_Sesat.gameObject.SetActive(true);
        upRotateButton_Nuwo_Sesat.gameObject.SetActive(true);
        downRotateButton_Nuwo_Sesat.gameObject.SetActive(true);
    }

    public void OnTargetLost_Nuwo_Sesat()
    {
        allObjectsFalse();
    }

    // Rakit
    public void OnTargetFound_Rakit()
    {
        rightRotateButton_Rakit.gameObject.SetActive(true);
        leftRotateButton_Rakit.gameObject.SetActive(true);
        upRotateButton_Rakit.gameObject.SetActive(true);
        downRotateButton_Rakit.gameObject.SetActive(true);
    }

    public void OnTargetLost_Rakit()
    {
        allObjectsFalse();
    }

    private void allObjectsFalse()
    {
        // Krong Bade Button
        rightRotateButton_Krong_Bade.gameObject.SetActive(false);
        leftRotateButton_Krong_Bade.gameObject.SetActive(false);
        upRotateButton_Krong_Bade.gameObject.SetActive(false);
        downRotateButton_Krong_Bade.gameObject.SetActive(false);

        // Bolon Button
        rightRotateButton_Bolon.gameObject.SetActive(false);
        leftRotateButton_Bolon.gameObject.SetActive(false);
        upRotateButton_Bolon.gameObject.SetActive(false);
        downRotateButton_Bolon.gameObject.SetActive(false);

        // Limas Button
        rightRotateButton_Limas.gameObject.SetActive(false);
        leftRotateButton_Limas.gameObject.SetActive(false);
        upRotateButton_Limas.gameObject.SetActive(false);
        downRotateButton_Limas.gameObject.SetActive(false);

        // Gadang Button
        rightRotateButton_Gadang.gameObject.SetActive(false);
        leftRotateButton_Gadang.gameObject.SetActive(false);
        upRotateButton_Gadang.gameObject.SetActive(false);
        downRotateButton_Gadang.gameObject.SetActive(false);

        // Bubungan Lima Button
        rightRotateButton_Bubungan_Lima.gameObject.SetActive(false);
        leftRotateButton_Bubungan_Lima.gameObject.SetActive(false);
        upRotateButton_Bubungan_Lima.gameObject.SetActive(false);
        downRotateButton_Bubungan_Lima.gameObject.SetActive(false);

        // Selaso Button
        rightRotateButton_Selaso.gameObject.SetActive(false);
        leftRotateButton_Selaso.gameObject.SetActive(false);
        upRotateButton_Selaso.gameObject.SetActive(false);
        downRotateButton_Selaso.gameObject.SetActive(false);

        // Limas Potong Button
        rightRotateButton_Limas_Potong.gameObject.SetActive(false);
        leftRotateButton_Limas_Potong.gameObject.SetActive(false);
        upRotateButton_Limas_Potong.gameObject.SetActive(false);
        downRotateButton_Limas_Potong.gameObject.SetActive(false);

        // Kajang Leko Button
        rightRotateButton_Kajang_Leko.gameObject.SetActive(false);
        leftRotateButton_Kajang_Leko.gameObject.SetActive(false);
        upRotateButton_Kajang_Leko.gameObject.SetActive(false);
        downRotateButton_Kajang_Leko.gameObject.SetActive(false);

        // Nuwo Sesat Button
        rightRotateButton_Nuwo_Sesat.gameObject.SetActive(false);
        leftRotateButton_Nuwo_Sesat.gameObject.SetActive(false);
        upRotateButton_Nuwo_Sesat.gameObject.SetActive(false);
        downRotateButton_Nuwo_Sesat.gameObject.SetActive(false);

        // Rakit Button
        rightRotateButton_Rakit.gameObject.SetActive(false);
        leftRotateButton_Rakit.gameObject.SetActive(false);
        upRotateButton_Rakit.gameObject.SetActive(false);
        downRotateButton_Rakit.gameObject.SetActive(false);
    }

    // Krong Bade 
    public void RightRotation_Krong_Bade()
    {
        Krong_Bade_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Krong_Bade()
    {
        Krong_Bade_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Krong_Bade()
    {
        Krong_Bade_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Krong_Bade()
    {
        Krong_Bade_2.transform.Rotate(-rotation, 0f, 0f);

    }

    // Bolon 
    public void RightRotation_Bolon()
    {
        Bolon_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Bolon()
    {
        Bolon_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Bolon()
    {
        Bolon_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Bolon()
    {
        Bolon_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Limas 
    public void RightRotation_Limas()
    {
        Limas_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Limas()
    {
        Limas_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Limas()
    {
        Limas_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Limas()
    {
        Limas_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Gadang 
    public void RightRotation_Gadang()
    {
        gadang_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Gadang()
    {
        gadang_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Gadang()
    {
        gadang_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Gadang()
    {
        gadang_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Bubungan Lima
    public void RightRotation_Bubungan_Lima()
    {
        Bubungan_Lima_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Bubungan_Lima()
    {
        Bubungan_Lima_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Bubungan_Lima()
    {
        Bubungan_Lima_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Bubungan_Lima()
    {
        Bubungan_Lima_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Selaso 
    public void RightRotation_Selaso()
    {
        Selaso_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Selaso()
    {
        Selaso_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Selaso()
    {
        Selaso_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Selaso()
    {
        Selaso_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Limas Potong 
    public void RightRotation_Limas_Potong()
    {
        Limas_Potong_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Limas_Potong()
    {
        Limas_Potong_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Limas_Potong()
    {
        Limas_Potong_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Limas_Potong()
    {
        Limas_Potong_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Kajang Leko 
    public void RightRotation_Kajang_Leko()
    {
        Kajang_Leko_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Kajang_Leko()
    {
        Kajang_Leko_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Kajang_Leko()
    {
        Kajang_Leko_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Kajang_Leko()
    {
        Kajang_Leko_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Nuwo Sesat 
    public void RightRotation_Nuwo_Sesat()
    {
        Nuwo_Sesat_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Nuwo_Sesat()
    {
        Nuwo_Sesat_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Nuwo_Sesat()
    {
        Nuwo_Sesat_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Nuwo_Sesat()
    {
        Nuwo_Sesat_2.transform.Rotate(-rotation, 0f, 0f);
    }

    // Rakit 
    public void RightRotation_Rakit()
    {
        Rakit_1.transform.Rotate(0f, -rotation, 0f);
    }

    public void LeftRotation_Rakit()
    {
        Rakit_1.transform.Rotate(0f, rotation, 0f);
    }

    public void UpRotation_Rakit()
    {
        Rakit_2.transform.Rotate(rotation, 0f, 0f);
    }

    public void DownRotation_Rakit()
    {
        Rakit_2.transform.Rotate(-rotation, 0f, 0f);
    }
}