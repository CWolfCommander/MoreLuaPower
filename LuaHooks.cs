﻿using HarmonyLib;
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

class LuaPowerHooks 
{
	public static void AddHook(FTrigger trigger, string func) {
		LuaPowerData.luaHooks.Add(new LuaPowerTrigger(trigger, func));
	}
}

[HarmonyPatch(typeof(ItemObject))]
[HarmonyPatch("Trigger")]
class MoreLuaPower_SpellCastHook
{
	static void Postfix(ItemObject __instance, FTrigger fTrigger) {
		foreach (LuaPowerTrigger hook in LuaPowerData.luaHooks.FindAll((LuaPowerTrigger hook) => { return hook._trigger == fTrigger; })) {
			EffectActions.CallFunctionWithItem(hook._func, __instance);
		}
	}
}
