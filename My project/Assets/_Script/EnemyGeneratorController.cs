using UnityEngine;

public class EnemyGeneratorController : MonoBehaviour
{
    public GameObject smallDragon;

    void Start()
    {
        InvokeRepeating(nameof(GenerateEnemy), 0, 1.5f);
    }

    void GenerateEnemy()
    {
        float xRandom = Random.Range(0.5f, 5.7f);

        var curV = transform.position;
        Vector3 spawnVector = new(curV.x + xRandom, curV.y, curV.z);
        
        Instantiate(smallDragon, spawnVector, Quaternion.identity);
    }
}
