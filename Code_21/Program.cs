using System.Collections.Generic;
/**
* Definition for singly-linked list.
* public class ListNode {
*     public int val;
*     public ListNode next;
*     public ListNode(int val=0, ListNode next=null) {
*         this.val = val;
*         this.next = next;
*     }
* }
*/

var s = new Solution();

ListNode list1 = new(1, new ListNode(2, new ListNode(4, null)));
ListNode list2 = new(1, new ListNode(4, new ListNode(4, null)));

s.MergeTwoLists(list1, list2);




public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode HEAD = new ListNode();
        var ptr = HEAD;
        if (list1 == null) { return list2; }
        if (list2 == null) { return list1; }
        if (list1.val < list2.val)
        {
            ptr.val = list1.val;
            list1 = list1.next;
        }
        else
        {
            ptr.val = list2.val;
            list2 = list2.next;
        }

        while(list1 != null && list2 != null)
        {
            if(list1.val < list2.val) 
            {
                ptr.next = list1;
                list1 = list1.next;
                ptr = ptr.next;
            }
            else
            {
                ptr.next = list2;
                list2 = list2.next;
                ptr = ptr.next;
            }
        }
        if (list1 == null)
        {
            ptr.next = list2;
        } 
        else
        {
            ptr.next = list1;
        }
        return HEAD;
    }
}