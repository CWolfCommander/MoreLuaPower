﻿using HarmonyLib;
using MoonSharp.Interpreter;
using System;
using UnityEngine;
using System.Collections.Generic;



[HarmonyPatch(typeof(EffectActions), MethodType.Constructor)]
[HarmonyPatch(new Type[] { typeof(string) })]
class MoreLuaPower_GlobalLuaTypes
{
    static void Postfix() {
        UserData.RegisterType<Rewired.Player>(InteropAccessMode.Default, null);
        UserData.RegisterType<S>(InteropAccessMode.Default, null);
        UserData.RegisterType<Run>(InteropAccessMode.Default, null);
        UserData.RegisterType<ItemObject>(InteropAccessMode.Default, null);
        UserData.RegisterType<SpellListCard>(InteropAccessMode.Default, null);
        UserData.RegisterType<ListCard>(InteropAccessMode.Default, null);
        UserData.RegisterType<StatusEffect>(InteropAccessMode.Default, null);
        UserData.RegisterType<HeroSelectCtrl>(InteropAccessMode.Default, null);
        UserData.RegisterType<AnimatorOverrideController>(InteropAccessMode.Default, null);
        UserData.RegisterType<Sprite>(InteropAccessMode.Default, null);
        UserData.RegisterType<Texture2D>(InteropAccessMode.Default, null);
        UserData.RegisterType<AnimationOverrider>(InteropAccessMode.Default, null);
        UserData.RegisterType<GameObject>(InteropAccessMode.Default, null);
        UserData.RegisterType<World>(InteropAccessMode.Default, null);
        UserData.RegisterType<CustomWorldGenerator>(InteropAccessMode.Default, null);
        UserData.RegisterType<CustomColumnGenerator>(InteropAccessMode.Default, null);
        UserData.RegisterType<CustomZoneGenerator>(InteropAccessMode.Default, null);
        UserData.RegisterType<ArcType>(InteropAccessMode.Default, null);
        UserData.RegisterType<BeingType>(InteropAccessMode.Default, null);
        UserData.RegisterType<Brand>(InteropAccessMode.Default, null);
        UserData.RegisterType<Check>(InteropAccessMode.Default, null);
        UserData.RegisterType<DeviceType>(InteropAccessMode.Default, null);
        UserData.RegisterType<DialogueType>(InteropAccessMode.Default, null);
        UserData.RegisterType<Edition>(InteropAccessMode.Default, null);
        UserData.RegisterType<Effect>(InteropAccessMode.Default, null);
        UserData.RegisterType<Ending>(InteropAccessMode.Default, null);
        UserData.RegisterType<Enhancement>(InteropAccessMode.Default, null);
        UserData.RegisterType<GameMode>(InteropAccessMode.Default, null);
        UserData.RegisterType<GScene>(InteropAccessMode.Default, null);
        UserData.RegisterType<GState>(InteropAccessMode.Default, null);
        UserData.RegisterType<GunPointSetting>(InteropAccessMode.Default, null);
        UserData.RegisterType<InputAction>(InteropAccessMode.Default, null);
        UserData.RegisterType<KeyCode>(InteropAccessMode.Default, null);
        UserData.RegisterType<Location>(InteropAccessMode.Default, null);
        UserData.RegisterType<MovPattern>(InteropAccessMode.Default, null);
        UserData.RegisterType<Pattern>(InteropAccessMode.Default, null);
        UserData.RegisterType<RewardType>(InteropAccessMode.Default, null);
        UserData.RegisterType<Shape>(InteropAccessMode.Default, null);
        UserData.RegisterType<Sort>(InteropAccessMode.Default, null);
        UserData.RegisterType<Tag>(InteropAccessMode.Default, null);
        UserData.RegisterType<TextType>(InteropAccessMode.Default, null);
        UserData.RegisterType<TileType>(InteropAccessMode.Default, null);
        UserData.RegisterType<UIColor>(InteropAccessMode.Default, null);
        UserData.RegisterType<ZoneType>(InteropAccessMode.Default, null);
        UserData.RegisterType<ZoneGeneratorFlags>(InteropAccessMode.Default, null);
    }
}