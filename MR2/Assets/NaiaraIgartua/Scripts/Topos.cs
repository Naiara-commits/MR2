using UnityEngine;

public class Topos : MonoBehaviour
{
    
    [SerializeField] public GameObject[] cajasTopos;
    public Color colorVacio = Color.grey;
    public Color colorTopo = Color.red;
    public Color colorWin = Color.green;
    public Color colorPerder = Color.black;
    public Renderer rnd;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rnd = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IEnumerator()
    {
        int numAleatorios = Random.Range(0, cajasTopos.Length);
        GameObject cajaRandom = cajasTopos[numAleatorios];
        rnd.material.color = colorTopo;

        yield return new WaitForSeconds(3f);

        rnd.material.color = colorPerder;
        
    }
}
