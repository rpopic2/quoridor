using UnityEngine;

public class Grid : MonoBehaviour
{
    const int ROW = 9;
    const int COLUMN = 9;
    static readonly Vector3 START1 = new(4, 0);
    static readonly Vector3 START2 = new(4, 8);

    [SerializeField] Tile tilePrefab;
    [SerializeField] Transform pawnPrefab;
    Tile[,] tiles = new Tile[ROW, COLUMN];

    void Awake() {
        var cam = Camera.main.transform;
        var cameraZ = cam.position.z;

        cam.position = new(4, 4, cameraZ);

        for (int i = 0; i < ROW; ++i) {
            for (int j = 0; j < COLUMN; ++j) {
                var pos = new Vector3(i, j);
                tiles[i, j] = Instantiate(tilePrefab, pos, Quaternion.identity, transform);
            }
        }

        Instantiate(pawnPrefab, START1, Quaternion.identity, transform);
        Instantiate(pawnPrefab, START2, Quaternion.identity, transform);
    }
}

