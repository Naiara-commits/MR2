using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private TextMeshProUGUI contadorTexto;
    private int cubosDestruidos = 0;
    private const int fin = 10;

    void Awake()
    {
        Instance = this;
    }

    public void Contador()
    {
        cubosDestruidos++;
        contadorTexto.text = cubosDestruidos + " / " + fin;

        if (cubosDestruidos >= fin)
        {
            SceneManager.LoadScene("MainMenu");

            //FindObjectOfType<Topos>().CancelInvoke(nameof(Topos.spawnTopos));

        }
    }

    public bool MetaAlcanzada() => cubosDestruidos >= fin;
}
