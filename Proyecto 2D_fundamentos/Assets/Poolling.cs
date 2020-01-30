using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poolling : MonoBehaviour
{
    public static Poolling SharedInstance;
    public List<GameObject> pool_objetos;
    public GameObject objeto_repetir;
    public int cantidad;
    public int contador = 0;
    public int index;
    // Start is called before the first frame update

    private void Awake()
    {
        SharedInstance = this;
    }
    void Start()
    {
        index = 0;
        pool_objetos = new List<GameObject>();
        for (int i = 0; i < cantidad; i++)
        {
            GameObject obj = (GameObject)Instantiate(objeto_repetir);
            pool_objetos.Add(obj);
            obj.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        GameObject Oola = GetPooledObjects();
        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("Entra a matah" + index.ToString());
            if (!All_inactive())
            {
                pool_objetos[index].SetActive(false);
                index++;
                if (index >= pool_objetos.Count)
                {
                    index = 0;
                }
            }
            
            
        }
        if(Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("Entra IF1 ");
            if (Oola != null)
            {
                Oola.SetActive(true);
                Oola.transform.position = new Vector3(contador, 3, 0);
                contador++;
                Debug.Log("Entra");
            }
        }
    }

    public GameObject GetPooledObjects()
    {
        for(int i= 0; i < pool_objetos.Count; i++)
        {
            if (!pool_objetos[i].activeInHierarchy)
            {
                return pool_objetos[i];
            }
        }
        return null;
    }
    public bool All_inactive()
    {
        bool inactivos = true;
        for (int i = 0; i < pool_objetos.Count; i++)
        {
            if (pool_objetos[i].activeInHierarchy)
            {
                inactivos = false;
            }
        }
        return inactivos;
    }

}
