using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class StackingItem : MonoBehaviour
{
    public static StackingItem instance;

    [Header("Between of Objects")]
    [SerializeField] float distanceBetweenObjects = 0.60f;
    //Distance between object and object's clone

    [Header("Parent and Child Object")]
    [SerializeField] private Transform _parentObject;
    //Represents the parent object
    [SerializeField] private Transform _mainObject;
    //Represents the child object

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void Growing(GameObject middle, GameObject upper)
    {
        //Head will grow as player collect donuts and pies      
        if(_mainObject != null)
        {
            middle.transform.parent = _parentObject;
            Vector3 pos = _mainObject.localPosition;
            pos.y += distanceBetweenObjects;
            middle.transform.localPosition = pos;   
            _mainObject = middle.transform;
            upper.transform.Translate(0, distanceBetweenObjects, 0);
        }

        
       

    }

    public void Shrinking(GameObject middle, GameObject upper, List<GameObject> gmList)
    {
        //Head will shrink as player collect cactus

        gmList.RemoveAt(gmList.Count-1);
        Destroy(middle);
        upper.transform.Translate(0, -distanceBetweenObjects, 0);
        _mainObject = gmList.Last().transform;
               
    }

}
