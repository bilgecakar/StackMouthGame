using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CollectItem : MonoBehaviour
{
    [Header("Objects")]
    [SerializeField] GameObject middleObject;
    [SerializeField] GameObject upperObject;
    //Represents the upper and middle objets of the head

    private GameObject _cloneObject;
    //Middle object's clone

    private List<GameObject> _stackObjects;
    //List of middle object and middle object's clone

    int counter = 0;
    //Represents how many cactus player collect

 
    private void Start()
    {
        _stackObjects = new List<GameObject>();
        _stackObjects.Add(middleObject);
       

    }

    private void OnCollisionEnter(Collision collision)
    {

        if(_stackObjects.Count <10)
        {
            //Player can collect maximum of 10 pies or donuts

            if (collision.gameObject.tag == "Grow")
            {
                //If the tag of object it collided is Grow 
                //Destroy donut or pie
                //Clone middle object and add list
                //Call the Growing function in StackingItem class

                Destroy(collision.gameObject);
                _cloneObject = Instantiate(middleObject, middleObject.transform.position, middleObject.transform.rotation, middleObject.transform.parent);
                _cloneObject.transform.localScale= new Vector3(1, 1, 1);
                _stackObjects.Add(_cloneObject);
                StackingItem.instance.Growing(_stackObjects[_stackObjects.Count-1], upperObject);
              
            }
        }
    
        if (collision.gameObject.tag == "Shrink")
        {
            counter++;
            //The counter will increase as player collide cactus
        }

        if (counter > 0)
        {
            //Player can collide more than one cactus at the same time, so that it doesn't give an error when calling Shrinking function in the Stacking class
            for (int i = 0; i < counter; i++)
            {
                Destroy(collision.gameObject);
                if (_stackObjects.Count != 1)
                {
                    StackingItem.instance.Shrinking(_stackObjects.Last(), upperObject, _stackObjects);                   
                }
                else
                {
                    GameOver.instance.Finish();
                }
                
            }
            counter = 0;
        }
      
    }
   
}
