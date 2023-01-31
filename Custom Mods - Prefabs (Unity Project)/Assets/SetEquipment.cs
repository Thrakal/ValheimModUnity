using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetEquipment : MonoBehaviour
{
    public VisEquipment equipment;

    // Start is called before the first frame update
    void Start()
    {
        equipment = GetComponent<VisEquipment>();
        
        equipment.SetModel(0);
        equipment.SetHairColor(Vector3.zero);
        equipment.SetSkinColor(Vector3.zero);

        equipment.SetHairItem(GetHair(Hair.NoHair));
        equipment.SetBeardItem("");
        equipment.SetChestItem("");
        equipment.SetLegItem("");
        equipment.SetLeftItem("", 0);
        equipment.SetRightItem("");

        // Different items equipped based on monster kill
    }

    private string GetHair(Hair hair) {
        string[] prefabNames = new string[] {
            "HairNone",
            "Hair1",
            "Hair2",
            "Hair3",
            "Hair4",
            "Hair5",
            "Hair6",
            "Hair7",
            "Hair8",
            "Hair9",
            "Hair10",
            "Hair11",
            "Hair12",
            "Hair13",
            "Hair14",
            "Hair15",
            "Hair16",
            "Hair17",
            "Hair18",
            "Hair19",
            "Hair20",
            "Hair21",
            "Hair22",
            "Hair23"
        };

        return prefabNames[(int)hair];
    }

    private enum Hair {
        NoHair = 0,
        Ponytail_1 = 1,
        Ponytail_2 = 2,
        Braided_1 = 3,
        Ponytail_3 = 4,
        Short_1 = 5,
        Long_1 = 6,
        Ponytail_4 = 7,
        Short_2 = 8,
        SideSwept_1 = 9,
        SideSwept_2 = 10,
        Braided_2 = 11,
        Braided_3 = 12,
        Braided_4 = 13,
        SideSwept_3 = 14,
        Curls_Pulled_Back = 15,
        Braids_Gathered = 16,
        Braids_Neat = 17,
        Braids_Royal = 18,
        Curls_1 = 19,
        Curls_2 = 20,
        Buns_Twin = 21,
        Buns_Single = 22,
        Curls_Short = 23
    }
}
