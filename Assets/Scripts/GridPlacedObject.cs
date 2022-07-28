using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPlacedObject : MonoBehaviour{
    

    [SerializeField] private GridLocation gridLocation;
    
    void Start(){
        SnapToGrid();
    }

    public void SetGridLocation(float x, float y, float z){
        gridLocation.SetPlacementValues(x, y, z);
    }
    
    
    void SnapToGrid(){
        transform.position = gridLocation.GetActualLocation();
    }
}
