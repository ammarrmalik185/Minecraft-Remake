using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBlock : MonoBehaviour{
    [SerializeField] private GameObject placementPrefab;
    
    void Update(){
        if (Input.GetKeyDown(KeyCode.Mouse2)){
            var ray = Camera.main.ScreenPointToRay(Input. mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, 100)) {
                Debug.Log(hit.point);
                Vector3 v = hit.point - transform.position;
                v.Scale(new Vector3(0.99f,0.99f,0.99f));
                var position = transform.position + v;
                Debug.Log(position);
                var newBlock = Instantiate(placementPrefab);
                newBlock.GetComponent<GridPlacedObject>().SetGridLocation(hit.point.x, hit.point.y, hit.point.z);
            }
        }
    }
}
