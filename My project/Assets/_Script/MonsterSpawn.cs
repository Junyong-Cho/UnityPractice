using UnityEngine;

public class MonsterSpawn : MonoBehaviour
{
    public GameObject monster;

    void Start()
    {
        InvokeRepeating(nameof(SpawnMonster), 0, 2);
    }

    void SpawnMonster()
    {
        var _vec = transform.position;
        Vector3 vec = new(_vec.x + Random.Range(-2.5f, 2.5f), _vec.y, _vec.z);

        Instantiate(monster, vec, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
            
    }
}
