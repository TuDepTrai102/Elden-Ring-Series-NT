using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EldenRing.NT
{
    [System.Serializable]
    //  SINCE WE WANT TO REFERENCE THIS DATA FOR EVERY SAVE FILE, THIS SCRIPT IS NOT A MONOBEHAVIOR AND IS INSTEAD SERIALIZABLE
    public class CharacterSaveData
    {
        [Header("CHARACTER NAME")]
        public string characterName;

        [Header("TIME PLAYED")]
        public float secondsPlayed;

        //  QUESTION: WHY NOT USE A VECTOR3?
        //  ANSWER: WE CAN ONLY SAVE DATA FROM "BASIC" VARIABLE TYPES (float, int, string, bool, ... ETC, ETC)
        [Header("WORLD COORDINATES")]
        public float xPosition;
        public float yPosition;
        public float zPosition;
    }
}