using UnityEngine;


public class Inter : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "RedButton")
        {
            print("есть контакт");  
            FindAnyObjectByType<PotionSystem>().BrewPotion();
        }

    }
}
//окак