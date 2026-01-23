using UnityEngine;
using UnityEngine.UI;

public class RotateManager2 : MonoBehaviour
{
    // Assign semua button lewat Inspector
    public Button rightRotateButton_Tiger;
    public Button leftRotateButton_Tiger;
    public Button upRotateButton_Tiger;
    public Button downRotateButton_Tiger;

    public Button rightRotateButton_Komodo;
    public Button leftRotateButton_Komodo;
    public Button upRotateButton_Komodo;
    public Button downRotateButton_Komodo;

    public Button rightRotateButton_Badak;
    public Button leftRotateButton_Badak;
    public Button upRotateButton_Badak;
    public Button downRotateButton_Badak;

    public Button rightRotateButton_Gajah;
    public Button leftRotateButton_Gajah;
    public Button upRotateButton_Gajah;
    public Button downRotateButton_Gajah;

    public Button rightRotateButton_Pesut;
    public Button leftRotateButton_Pesut;
    public Button upRotateButton_Pesut;
    public Button downRotateButton_Pesut;

    public Button rightRotateButton_Cendrawasih;
    public Button leftRotateButton_Cendrawasih;
    public Button upRotateButton_Cendrawasih;
    public Button downRotateButton_Cendrawasih;

    public Button rightRotateButton_Jalak;
    public Button leftRotateButton_Jalak;
    public Button upRotateButton_Jalak;
    public Button downRotateButton_Jalak;

    public Button rightRotateButton_Elang;
    public Button leftRotateButton_Elang;
    public Button upRotateButton_Elang;
    public Button downRotateButton_Elang;

    private string currentTarget = "";

    public void OnTargetFound(string targetName)
    {
        if (currentTarget == targetName) return;

        allObjectsFalse();
        currentTarget = targetName;

        switch (targetName)
        {
            case "Tiger":
                SetActiveButtons(rightRotateButton_Tiger, leftRotateButton_Tiger, upRotateButton_Tiger, downRotateButton_Tiger);
                break;
            case "Komodo":
                SetActiveButtons(rightRotateButton_Komodo, leftRotateButton_Komodo, upRotateButton_Komodo, downRotateButton_Komodo);
                break;
            case "Badak":
                SetActiveButtons(rightRotateButton_Badak, leftRotateButton_Badak, upRotateButton_Badak, downRotateButton_Badak);
                break;
            case "Gajah":
                SetActiveButtons(rightRotateButton_Gajah, leftRotateButton_Gajah, upRotateButton_Gajah, downRotateButton_Gajah);
                break;
            case "Pesut":
                SetActiveButtons(rightRotateButton_Pesut, leftRotateButton_Pesut, upRotateButton_Pesut, downRotateButton_Pesut);
                break;
            case "Cendrawasih":
                SetActiveButtons(rightRotateButton_Cendrawasih, leftRotateButton_Cendrawasih, upRotateButton_Cendrawasih, downRotateButton_Cendrawasih);
                break;
            case "Jalak":
                SetActiveButtons(rightRotateButton_Jalak, leftRotateButton_Jalak, upRotateButton_Jalak, downRotateButton_Jalak);
                break;
            case "Elang":
                SetActiveButtons(rightRotateButton_Elang, leftRotateButton_Elang, upRotateButton_Elang, downRotateButton_Elang);
                break;
            default:
                Debug.LogWarning("Unknown target name: " + targetName);
                break;
        }
    }

    public void OnTargetLost()
    {
        currentTarget = "";
        allObjectsFalse();
    }

    private void SetActiveButtons(Button right, Button left, Button up, Button down)
    {
        right.gameObject.SetActive(true);
        left.gameObject.SetActive(true);
        up.gameObject.SetActive(true);
        down.gameObject.SetActive(true);
    }

    private void allObjectsFalse()
    {
        rightRotateButton_Tiger.gameObject.SetActive(false);
        leftRotateButton_Tiger.gameObject.SetActive(false);
        upRotateButton_Tiger.gameObject.SetActive(false);
        downRotateButton_Tiger.gameObject.SetActive(false);

        rightRotateButton_Komodo.gameObject.SetActive(false);
        leftRotateButton_Komodo.gameObject.SetActive(false);
        upRotateButton_Komodo.gameObject.SetActive(false);
        downRotateButton_Komodo.gameObject.SetActive(false);

        rightRotateButton_Badak.gameObject.SetActive(false);
        leftRotateButton_Badak.gameObject.SetActive(false);
        upRotateButton_Badak.gameObject.SetActive(false);
        downRotateButton_Badak.gameObject.SetActive(false);

        rightRotateButton_Gajah.gameObject.SetActive(false);
        leftRotateButton_Gajah.gameObject.SetActive(false);
        upRotateButton_Gajah.gameObject.SetActive(false);
        downRotateButton_Gajah.gameObject.SetActive(false);

        rightRotateButton_Pesut.gameObject.SetActive(false);
        leftRotateButton_Pesut.gameObject.SetActive(false);
        upRotateButton_Pesut.gameObject.SetActive(false);
        downRotateButton_Pesut.gameObject.SetActive(false);

        rightRotateButton_Cendrawasih.gameObject.SetActive(false);
        leftRotateButton_Cendrawasih.gameObject.SetActive(false);
        upRotateButton_Cendrawasih.gameObject.SetActive(false);
        downRotateButton_Cendrawasih.gameObject.SetActive(false);

        rightRotateButton_Jalak.gameObject.SetActive(false);
        leftRotateButton_Jalak.gameObject.SetActive(false);
        upRotateButton_Jalak.gameObject.SetActive(false);
        downRotateButton_Jalak.gameObject.SetActive(false);

        rightRotateButton_Elang.gameObject.SetActive(false);
        leftRotateButton_Elang.gameObject.SetActive(false);
        upRotateButton_Elang.gameObject.SetActive(false);
        downRotateButton_Elang.gameObject.SetActive(false);
    }
}
