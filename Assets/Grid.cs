using UnityEngine;

public class Grid : MonoBehaviour
{
    const int ROW = 9;
    const int COLUMN = 9;

    [SerializeField] Tile tilePrefab;
    [SerializeField] Transform pawnPrefab;
    Tile[,] tiles = new Tile[ROW, COLUMN];

    void Awake() {
        var cam = Camera.main.transform;
        var camerZ = cam.position.z;
        const float spacing = 1f;

        cam.position = new(4 * spacing, 4 * spacing, -10);

        for (int i = 0; i < ROW; ++i) {
            for (int j = 0; j < COLUMN; ++j) {
                var x = spacing * i;
                var y = spacing * j;
                var pos = new Vector3(x, y);
                tiles[i, j] = Instantiate(tilePrefab, pos, Quaternion.identity, transform);
            }
        }

        var pawnPos = new Vector3(4 * spacing, 0 * spacing);
        Instantiate(pawnPrefab, pawnPos, Quaternion.identity, transform);

        pawnPos = new Vector3(4 * spacing, 8 * spacing);
        Instantiate(pawnPrefab, pawnPos, Quaternion.identity, transform);
    }
}

