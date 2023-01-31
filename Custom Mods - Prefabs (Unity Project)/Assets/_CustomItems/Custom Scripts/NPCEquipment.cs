using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace CozyheimTweaks
{
    internal class NPCEquipment : MonoBehaviour
    {
        public VisEquipment equipment;

        public GenderNPC Gender;
        public ColorNPC SkinColor;
        public ColorNPC HairColor;
        public HairNPC Hair;
        public BeardNPC Beard;

        public void CopyEquipment(NPCEquipment copyEquipment)
        {
            Gender = copyEquipment.Gender;
            SkinColor = copyEquipment.SkinColor;
            HairColor = copyEquipment.HairColor;
            Hair = copyEquipment.Hair;
            Beard = copyEquipment.Beard;
        }

        // Start is called before the first frame update
        void Start()
        {
            equipment = GetComponent<VisEquipment>();

            
            equipment.SetModel(GetGender(Gender));
            equipment.SetSkinColor(GetColor(SkinColor));
            equipment.SetHairColor(GetColor(HairColor));

            equipment.SetHairItem(GetHair(Hair));
            equipment.SetBeardItem(GetBeard(Beard));
            
            equipment.SetChestItem("ArmorBronzeChest");
            equipment.SetLegItem("ArmorBronzeLegs");
            equipment.SetLeftItem("ShieldBanded", 0);
            equipment.SetRightItem("AxeBronze");
        }

        private Vector3 GetColor(ColorNPC color)
        {
            Vector3[] colors = new Vector3[] {
                new Vector3(255, 0, 0), // Red
                new Vector3(0, 255, 0), // Green
                new Vector3(0, 0, 255), // Blue
                new Vector3(255, 255, 255), // White
                new Vector3(0, 0, 0) // Black
            };

            return colors[(int)color].normalized;
        }

        private int GetGender(GenderNPC gender)
        {
            return (int)gender;
        }

        private string GetBeard(BeardNPC beard)
        {
            string[] prefabNames = new string[] {
                "BeardNone",
                "Beard1",
                "Beard2",
                "Beard3",
                "Beard4",
                "Beard5",
                "Beard6",
                "Beard7",
                "Beard8",
                "Beard9",
                "Beard10",
                "Beard11",
                "Beard12",
                "Beard13",
                "Beard14",
                "Beard15",
                "Beard16"
            };

            return prefabNames[(int)beard];
        }

        private string GetHair(HairNPC hair)
        {
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

    }
    internal enum ColorNPC
    {
        Red = 0,
        Green = 1,
        Blue = 2,
        White = 3,
        Black = 4
    }

    internal enum GenderNPC
    {
        Male = 0,
        Female = 1
    }

    internal enum BeardNPC
    {
        NoBeard = 0,
        Long_1 = 1,
        Long_2 = 2,
        Short_1 = 3,
        Short_2 = 4,
        Braided_1 = 5,
        Braided_2 = 6,
        Short_3 = 7,
        Thick_1 = 8,
        Braided_3 = 9,
        Braided_4 = 10,
        Thick_2 = 11,
        Royal_1 = 12,
        Royal_2 = 13,
        Braided_5 = 14,
        Short_4 = 15,
        Stonedweller = 16
    }

    internal enum HairNPC
    {
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
