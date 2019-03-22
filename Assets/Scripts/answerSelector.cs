using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class answerSelector : MonoBehaviour {


    private Vector3 originalPos;
    private bool samePos;
    GameObject selectedNumber;
    Transform parent;
    private void Start()
    {
        originalPos = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
        parent = GameObject.Find("AsteroidSprite").transform;

    }
    private void OnMouseDown()
    {
        Debug.Log("Click on");

        
            this.gameObject.AddComponent<answerFollow>();
        Destroy(this.gameObject.GetComponent<BoxCollider2D>());
        selectedNumber = this.gameObject;
        this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 1;
        this.gameObject.transform.parent = parent;


        

    }

    private void OnMouseUp()
    {
        GameObject[] _list = GameObject.FindGameObjectsWithTag("Answer");
        
        
        for (int i = 0; i < _list.Length; i++)
        {
            for (int p = 0; p < _list.Length; p++)
            {
                if (i != p)
                {
                    if (_list[i].transform.position == _list[p].transform.position)
                    {
                        
                        samePos = true;
                        if (samePos == true && _list[p] != selectedNumber)
                        {
                            
                            Destroy(_list[p].GetComponent<answerFollow>());
                            _list[p].AddComponent<BoxCollider2D>();
                            _list[p].transform.position = originalPos;
                            _list[p].transform.parent = null;



                            samePos = false;
                        }

                        if (samePos == true && _list[i] != selectedNumber) {
                            
                            Destroy(_list[i].GetComponent<answerFollow>());
                            _list[i].AddComponent<BoxCollider2D>();
                            _list[i].transform.position = originalPos;
                            _list[i].transform.parent = null;

                            samePos = false;

                        }
                    }
                    
                }
            }
        }
      

    }
  
}
