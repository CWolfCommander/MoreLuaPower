﻿/*
 *  More Lua Power, made by Golden Epsilon
 *  Audio loading, ProgramAdvance, Kickers, and Multicast added by Sunreal
 *  PetBuff for MoreLuaPower by stephanreiken
 *  Workshop URL: https://steamcommunity.com/sharedfiles/filedetails/?id=2066319533
 *  GitHub Page: https://github.com/GoldenEpsilon/MoreLuaPower
 *
 *  Please do not include the DLL in your mods directly:
 *      Ask people to download the workshop version instead.
 *      
 *  That said, if there's something you want to modify from the code to make your own harmony mod, feel free!
 *  I am also open to help; If you have something you want to add in here, just let me know/add it in yourself! You will be credited.
*/

//There are some libraries I don't need that are being called here, this is so that I can copy/paste when creating a new file no matter what it needs.
using HarmonyLib;
using MoonSharp.Interpreter;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using System.Reflection.Emit;
using System.Collections.ObjectModel;
using Rewired.Utils.Classes.Data;
using Rewired;

[HarmonyPatch(typeof(S))]
[HarmonyPatch("Awake")]
class MoreLuaPower
{
    static void Prepare() {
        Debug.Log("MoreLuaPower Version 1.2");
		LuaPowerCustomEnumsSetup.Setup();

    }
}
