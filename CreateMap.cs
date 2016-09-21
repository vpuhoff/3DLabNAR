using UnityEngine;
using System.Collections;

public class CreateMap : MonoBehaviour {
    public float xstart;
    public float ystart;
    public float xend;
    public float yend;
    public int cellcount;
    public float cellsize;
    public Transform cube;
	// Use this for initialization
	void Start () {
        cellsize = xend - xstart;
        cellsize = cellsize / cellcount;
        for (float x = xstart; x < xend ; x+= cellsize)
        {
            for (float  y = ystart ; y < yend ; y+= cellsize)
            {
                if (Random.RandomRange(0,100)>60)
                {
                    var cell = Instantiate(cube);
                    cell.position = new Vector3(x, 2, y);
                }
            }
        }
	}
	
	// Update is called once per frame
	void Update () {

    }
}
