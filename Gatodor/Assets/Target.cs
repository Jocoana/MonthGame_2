using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject[] laigato;
    public GameObject gatoDor;
    public bool isTheGato;

   

    public void Die()
    {
        Destroy(gameObject);
        


        if (isTheGato)
        {
            Instantiate(gatoDor, transform.position, Quaternion.identity);
            
        }

        if (!isTheGato)
        {
            Instantiate(laigato[Random.Range(0, laigato.Length)], transform.position, Quaternion.identity);
            

        }
    }

    
}
