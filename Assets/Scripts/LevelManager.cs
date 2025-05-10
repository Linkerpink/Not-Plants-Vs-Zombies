using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public LevelSO level;
    
    [SerializeField] private GameObject tilePrefab;
    
    private GameObject levelObject;
    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnLevel();
        }
    }
    
    public void SpawnLevel()
    {
        levelObject = GameObject.Find("Level");
        foreach (Transform _child in levelObject.transform)
        {
            Destroy(_child.gameObject);
        }
        
        if (level != null && levelObject != null)
        {
            for (int i = 0; i < level.lanes; i++)
            {
                for (int j = 0; j < level.laneLength; j++)
                {
                    Instantiate(tilePrefab, transform.position + new Vector3(i, 0, j), Quaternion.identity, levelObject.GetComponent<Transform>());
                }
            }
        }
    }
}