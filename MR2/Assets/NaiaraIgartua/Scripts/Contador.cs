using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private TextMeshProUGUI contadorTexto;
    public int puntosPorTopo = 10;
    public int meta = 100;

    private int puntuacion = 0;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    public void Start()
    {
        puntuacion = 0;
        ActualizarUI();
    }

    public void Contador()
    {
        puntuacion += puntosPorTopo;
        ActualizarUI();

        if (MetaAlcanzada())
        {
            Invoke(nameof(CargarMenu), 1.0f);
        }
    }

    public bool MetaAlcanzada() => puntuacion >= meta;
    void CargarMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    void ActualizarUI()
    {
        if (contadorTexto != null)
            contadorTexto.text = puntuacion + " / " + meta;
    }
}
