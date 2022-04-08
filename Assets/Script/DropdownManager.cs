using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownManager : MonoBehaviour
{
    [SerializeField] private Dropdown Pistol;
    [SerializeField] private Dropdown Shotgun;
    [SerializeField] private Dropdown Submachinegun;
    [SerializeField] private Dropdown Assaultrifle;
    [SerializeField] private Dropdown Sniperrifle;
    [SerializeField] private Dropdown Heavyweapons;
    [SerializeField] private Dropdown Backpack;
    [SerializeField] private Dropdown Safe;
    [SerializeField] private Dropdown RostRoot;

    [SerializeField] private Text result;


    private void Start()
    {
        ChangeResult();
    }

    public void ChangeResult()
    {
        int total = 0;
        int[] gold = new int[] { 1000, 3000, 9000, 27000, 81000, 243000, 729000, 2187000, 3280500, 4374000, 5467500, 6561000, 7654500, 8748000, 9841500, 10935000, 12028500, 13122000, 14215500, 15309000, 16402500, 17496000, 18589500 };

        for (int i = Pistol.value; i < 10; i++) total += gold[i];
        for (int i = Shotgun.value; i < 10; i++) total += gold[i];
        for (int i = Submachinegun.value; i < 10; i++) total += gold[i];
        for (int i = Assaultrifle.value; i < 10; i++) total += gold[i];
        for (int i = Sniperrifle.value; i < 13; i++) total += gold[i];
        for (int i = Heavyweapons.value; i < 13; i++) total += gold[i];
        for (int i = Backpack.value; i < 13; i++) total += gold[i];
        for (int i = Safe.value; i < 23; i++) total += gold[i];
        for (int i = RostRoot.value; i < 8; i++) total += gold[i];

        result.text = total.ToString();
    }
}
