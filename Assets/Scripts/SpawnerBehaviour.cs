using System.Collections;
using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private float minY, maxY;
    [SerializeField] private float minTimeSpawn, maxTimeSpawn;
    
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(Spawner()); // On commence un timer 
    }

    /// <summary>
    /// Fonction de timer 
    /// </summary>
    /// <returns></returns>
    private IEnumerator Spawner()
    {
        while (true) // Tant que "vrai", donc tout le temps
        {
            // On attends un nombre aléatoire de seconde
            yield return new WaitForSeconds(Random.Range(minTimeSpawn, maxTimeSpawn));
            // On fait spawner un ennemi 
            Spawn();
        }
    }

    /// <summary>
    /// Fonction de spawn des ennemis
    /// </summary>
    private void Spawn()
    {
        // On calcule une position aléatoire sur l’axe y
        var position = new Vector3
        {
            x = transform.position.x,
            y = Random.Range(minY, maxY),
            z = 0
        };
        // On instantie un ennemi à la position précédemment calculée
        Instantiate(enemy, position, Quaternion.identity);
    }

    /// <summary>
    /// Détruit l’objet
    /// </summary>
    public void Die()
    {
        Destroy(gameObject);
    }
}
