using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
    
    
    public Sprite B;
    public Sprite H;
    public Sprite I;
    public Sprite O;
    public Sprite P;
    public Sprite U;
    public Sprite X;
    public Sprite Z;

    public int imgNumberCount;

    public void changeImages() // make sure to attach this to event trigger
    {
        switch (imgNumberCount)
        {

          
            case 0:
                GetComponent<Image>().sprite = B;
                imgNumberCount++;
                break;
            case 1:
                GetComponent<Image>().sprite = H;
                imgNumberCount++;
                break;
            case 2:
                GetComponent<Image>().sprite = I;
                imgNumberCount++;
                break;
            case 3:
                GetComponent<Image>().sprite = O;
                imgNumberCount++;
                break;
            case 4:
                GetComponent<Image>().sprite = P;
                imgNumberCount++; 
                break;
            case 5:
                GetComponent<Image>().sprite = U;
                imgNumberCount++; 
                break;
            case 6:
                GetComponent<Image>().sprite = X;
                imgNumberCount++;
                break;
            case 7:
                GetComponent<Image>().sprite = Z;
                imgNumberCount++;
                imgNumberCount = 0; //Reset it to 0
                break;
            default:
                Debug.Log("Error");
                break;
        }
    }
}
