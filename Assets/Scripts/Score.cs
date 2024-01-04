using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public GameObject[] myObjects;
    public Text score;
    public static int finalScore = 0;
    
    // Start is called before the first frame update
    void Start()
    {       
        score.text = 0.ToString();
    }
    bool ArrayContains(GameObject[] array, GameObject g)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].tag == g.tag)
            {
                return true;
            }        
        }
        return false;
    }

    private void OnCollisionEnter(Collision collision)
    {        
         if (ArrayContains(myObjects, collision.gameObject))
         {
            score.text = (int.Parse(score.text) + 10).ToString();
            finalScore += 10;
            Destroy(collision.collider.gameObject);
         }         
        
        else
        {
            score.text = (int.Parse(score.text) - 5).ToString();
            finalScore -= 5;
            Destroy(collision.collider.gameObject);
        }
    }
}