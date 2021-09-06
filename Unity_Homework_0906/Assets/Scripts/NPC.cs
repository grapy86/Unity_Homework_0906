using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private void NPCTalk(string Talk = "對話的內容")
    {
        
    }
    public bool OpenShop()
    {
        return true;
    }
    public int BuyItems(int Price = 100)
    {
        return 0;
    }
    public void Quest(int Quest)
    {

    }
    private int QuestUpdate(int QuestItem = 1)
    {
        return 0;
    }
    private bool QuestComplete(int Quest)
    {
        return false;
    }
}
