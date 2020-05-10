﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HarmonyLib;
using I2.Loc;
using UnityEngine;

//A kicker cast is a spell that behaves differently depending on how much mana the player has. Generally looks like this. Cast mini thunder for zero mana,
//but if the player has 3 mana cast thunderstorm instead.
//EX: <Params KickerCast="true" KickerManaCost="4" KickerSpell="StormThunder"></Params>
//Kicker cast also supports multiple kickers
//EX: <Params KickerCast="true" KickerManaCost="1,4" KickerSpell="Thunder,StormThunder"></Params>

[HarmonyPatch(typeof(Player))]
[HarmonyPatch("CastSpell")]
class MoreLuaPower_Kickercast
{
    static bool Prefix(ref Player __instance, int slotNum, ref int manaOverride, bool consumeOverride)
    {
        if (__instance.duelDisk.castSlots[slotNum] != null &&
            __instance.duelDisk.castSlots[slotNum].spellObj.spell != null &&
            __instance.duelDisk.castSlots[slotNum].spellObj.spell.itemObj.paramDictionary.ContainsKey("KickerCast"))          
        {
            Dictionary<string, string> pd = __instance.duelDisk.castSlots[slotNum].spellObj.spell.itemObj.paramDictionary;
            if (!pd.ContainsKey("KickerSpell"))
            {
                Debug.Log("ERROR: Spell has KickerCast, but not KickerSpell");
                return true;
            }
            if (!pd.ContainsKey("KickerManaCost"))
            {
                Debug.Log("ERROR: Spell has KickerCast, but not KickerManaCost");
                return true;
            }

            List<string> SpellNames = pd["KickerSpell"].Split(',').ToList();
            List<string> ManaCosts = pd["KickerManaCost"].Split(',').ToList();

            for (int i = SpellNames.Count-1; i >= 0; i--)
            {
                if (__instance.duelDisk.currentMana >= (manaOverride < 0 ? Int32.Parse(ManaCosts[i]) : manaOverride))
                {
                    SpellObject Kicker = S.I.deCtrl.CreateSpellBase(SpellNames[i], __instance);
                    Kicker.PlayerCast();
                    var manaCost = (manaOverride < 0 ? Int32.Parse(ManaCosts[i]) : manaOverride);
                    __instance.duelDisk.currentMana -= (float)manaCost;
                    __instance.duelDisk.LaunchSlot(slotNum, false, null);
                    return false;
                }
            }
        }
        return true;
    }
}