using System;
using UnityEngine;

[Serializable]
public class GridLocation{
    public static int gridScale = 1;
    
    [SerializeField] private int gridLocationX;
    [SerializeField] private int gridLocationY;
    [SerializeField] private int gridLocationZ;

    public Vector3 GetActualLocation(){
        return new Vector3(gridLocationX * gridScale + 0.5f, gridLocationY * gridScale + 0.5f,
            gridLocationZ * gridScale + 0.5f);
    }
    
    public void SetPlacementValues(float x, float y, float z){
        gridLocationX = Mathf.FloorToInt(x);
        gridLocationY = Mathf.FloorToInt(y);
        gridLocationZ = Mathf.FloorToInt(z);
    }
}