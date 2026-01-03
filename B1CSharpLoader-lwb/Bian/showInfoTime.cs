using System;
using System.Collections.Generic;
using System.Linq;
using b1;
using B1UI.GSUI;
using BtlB1;
using BtlShare;
using CSharpModBase;
using GSE.GSUI;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.UMG;

namespace bian;

public class TimerComp : GameStateSystemBase
{
    public UWorld? World = null;
    public UCanvasPanel? MainCon = null;


    private static FVector2D VecRT = new FVector2D(0.25, 0.14);  // 第一位是距离左边屏幕的距离，第二位是距离顶部屏幕的距离
    private static FAnchors AnchorsRT = default(FAnchors);

    static TimerComp()
    {
        AnchorsRT.Minimum = VecRT;
        AnchorsRT.Maximum = VecRT;
    }
    public override void OnEndPlay(EEndPlayReason EndPlayReason)
    {
        DestroyMainCon();
        base.OnEndPlay(EndPlayReason);
    }
    public override void OnAttach()
    {
        SetCanTick(true);
    }

    public override int GetTickGroupMask()
    {
        return CanTick() ? 1024 : 0;
    }

    // 方案2：使用自定义结构体
    public struct SurfaceTypeInfo
    {
        public string Name;
        public int BuffId;
    }
    Dictionary<int, string> buffDict = new Dictionary<int, string>
                {
                    {BuffElementIds.Thunder, "雷"},
                    {BuffElementIds.Ice, "冰"},
                    {BuffElementIds.Fire, "火"},
                    {BuffElementIds.Poison, "毒"}
                };

    // 方案2：使用自定义结构体
    public interface ISurfaceTypeInfo
    {
        string Name { get; set; }
        int BuffId { get; set; }
    }

    // 777666001 水环境buff 777666002雪 777666003火 777666004草地/土壤
    Dictionary<ESceneItemSurfaceType, SurfaceTypeInfo> SurfaceTypeDict = new Dictionary<ESceneItemSurfaceType, SurfaceTypeInfo>
{
    {ESceneItemSurfaceType.DefaultSurface, new SurfaceTypeInfo { Name = "无", BuffId = 0}},
    {ESceneItemSurfaceType.GrassSurface, new SurfaceTypeInfo { Name = "草地", BuffId = 777666004}},
    {ESceneItemSurfaceType.WaterSurface, new SurfaceTypeInfo { Name = "水中", BuffId = 777666001}},
    {ESceneItemSurfaceType.CloudSurface, new SurfaceTypeInfo { Name = "云", BuffId = 777666004}},
    {ESceneItemSurfaceType.StoneSurface, new SurfaceTypeInfo { Name = "石头", BuffId = 777666004}},
    {ESceneItemSurfaceType.MudSurface, new SurfaceTypeInfo { Name = "泥地", BuffId = 777666001}},
    {ESceneItemSurfaceType.SoilSurface, new SurfaceTypeInfo { Name = "土壤", BuffId = 777666004}},
    {ESceneItemSurfaceType.WoodSurface, new SurfaceTypeInfo { Name = "木头", BuffId = 777666004}},
    {ESceneItemSurfaceType.HfmsoftSandSurface, new SurfaceTypeInfo { Name = "软沙", BuffId = 777666004}},
    {ESceneItemSurfaceType.GlideSandSurface, new SurfaceTypeInfo { Name = "滑沙", BuffId = 777666004}},
    {ESceneItemSurfaceType.SnowSurface, new SurfaceTypeInfo { Name = "雪地", BuffId = 777666002}},
    {ESceneItemSurfaceType.IceSurface, new SurfaceTypeInfo { Name = "冰面", BuffId = 777666002}},
    {ESceneItemSurfaceType.LavaSurface, new SurfaceTypeInfo { Name = "岩浆", BuffId = 777666003}},
    {ESceneItemSurfaceType.YinSurface, new SurfaceTypeInfo { Name = "阴", BuffId = 777666004}},
    {ESceneItemSurfaceType.YangSurface, new SurfaceTypeInfo { Name = "阳", BuffId = 777666004}},
    {ESceneItemSurfaceType.BloodSurface, new SurfaceTypeInfo { Name = "血池", BuffId = 777666001}},
    {ESceneItemSurfaceType.GlideSnow, new SurfaceTypeInfo { Name = "滑雪", BuffId = 777666002}},
    {ESceneItemSurfaceType.GlideIce, new SurfaceTypeInfo { Name = "滑冰", BuffId = 777666002}},
    {ESceneItemSurfaceType.BajieMud, new SurfaceTypeInfo { Name = "泥浆", BuffId = 777666001}},
    {ESceneItemSurfaceType.CricketBody, new SurfaceTypeInfo { Name = "蟋蟀背", BuffId = 0}},
    {ESceneItemSurfaceType.EnumMax, new SurfaceTypeInfo { Name = "最大值", BuffId = 0}}
};




    public void RenderBasicInfo(float DeltaTime)
    {
        if (!CheckWorldAndPawn())
            return;

        APawn controlledPawn = ShowPlayerInfo.GetControlledPawn();
        if (!ShowPlayerInfo.IsValidActor(controlledPawn))
            return;

        int index = 0;
        foreach (var attribute in ShowPlayerInfo.BasicAttributes)
        {
            if (index >= ShowPlayerInfo.BasicInfoVs.Count)
                break;

            var value = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, attribute.Key);

            if (attribute.Key == EBGUAttrFloat.Shield)
            {

                // 护盾/伤害减免
                float DmgDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.DmgDef);
                float Shield = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.Shield);
                float Atk = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.Atk);
                ShowPlayerInfo.UpdateUTextBlockContentIfChanged(ShowPlayerInfo.BasicInfoVs[index], $"护盾: {(int)Shield}, 攻击: {(int)Atk}, 减伤: {(int)DmgDef / 100}%");
            }
            //   else if (attribute.Key == EBGUAttrFloat.Atk)
            // {

            //     // 攻击/伤害加成
            //     float DmgAddition = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.DmgAddition);
            //     ShowPlayerInfo.UpdateUTextBlockContentIfChanged(ShowPlayerInfo.BasicInfoVs[index], $"攻击: {(int)value},  加伤: {(int)DmgAddition / 100}%");
            // }
            else if (attribute.Key == EBGUAttrFloat.CritRate)
            {
                // 暴击/暴伤
                float CritMultiplier = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.CritMultiplier);
                float SkillSuperArmor = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.SkillSuperArmor);
                // 攻击/伤害加成
                float DmgAddition = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.DmgAddition);
                ShowPlayerInfo.UpdateUTextBlockContentIfChanged(ShowPlayerInfo.BasicInfoVs[index], $"暴击：{(int)value / 100}%, 暴伤：{(int)CritMultiplier / 100f + 130f}%, 加伤: {(int)DmgAddition / 100}%, 技能霸体: {(int)SkillSuperArmor}");
            }
            else if (attribute.Key == EBGUAttrFloat.Hp)
            {
                // 生命/法力
                float Mp = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.Mp);
                float def = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.Def);
                ShowPlayerInfo.UpdateUTextBlockContentIfChanged(ShowPlayerInfo.BasicInfoVs[index], $"生命：{(int)value},  法力：{(int)Mp}, 防御：{(int)def}");
            }




            else if (attribute.Key == EBGUAttrFloat.FreezeDef)
            {
                // 抗性
                float FreezeDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.FreezeDef);
                float BurnDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.BurnDef);
                float PoisonDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.PoisonDef);
                float ThunderDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.ThunderDef);
                ShowPlayerInfo.UpdateUTextBlockContentIfChanged(ShowPlayerInfo.BasicInfoVs[index], $"四灾抗性: 冰:{(int)FreezeDef}, 火:{(int)BurnDef},  毒:{(int)PoisonDef},  雷:{(int)ThunderDef}");
            }
            else if (attribute.Key == EBGUAttrFloat.FreezeAtk)
            {
                // 抗性
                float FreezeDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.FreezeAtk);
                float BurnDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.BurnAtk);
                float PoisonDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.PoisonAtk);
                float ThunderDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.ThunderAtk);
                ShowPlayerInfo.UpdateUTextBlockContentIfChanged(ShowPlayerInfo.BasicInfoVs[index], $"四灾攻击: 冰:{(int)FreezeDef}, 火:{(int)BurnDef},  毒:{(int)PoisonDef},  雷:{(int)ThunderDef}");
            }
            else if (attribute.Key == EBGUAttrFloat.CurEnergy)
            {
                // 抗性
                float TransEnergyMax = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.TransEnergyMax);
                float FabaoEnergy = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.FabaoEnergy);
                float VigorEnergy = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.VigorEnergy);
                float CommDropAddition = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.CommDropAddition);
                int dropAdd = (int)CommDropAddition / 100 > 100 ? 100 : (int)CommDropAddition / 100;
                ShowPlayerInfo.UpdateUTextBlockContentIfChanged(ShowPlayerInfo.BasicInfoVs[index], $"神力: {(int)value},  法宝: {(int)FabaoEnergy},  精魄: {(int)VigorEnergy}, 掉宝: {dropAdd}%");
            }

            else if (attribute.Key == EBGUAttrFloat.EnumMax)
            {
                string currentBuff = buffDict.FirstOrDefault(kvp => BGUFunctionLibraryCS.BGUHasBuffByID(controlledPawn, kvp.Key)).Value;
                var buffText = !string.IsNullOrEmpty(currentBuff) ? $"当前buff: {currentBuff}" : "当前buff: 无";
                // ACharacter aCharacter = GetOwner() as ACharacter;
                // if (aCharacter != null)
                // {
                //     FVector StartTrace = BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter) + aCharacter.GetActorUpVector() * aCharacter.CapsuleComponent.GetScaledCapsuleHalfHeight();
                //     FVector fVector = aCharacter.GetActorUpVector() * -100.0 - aCharacter.GetActorUpVector() * aCharacter.CapsuleComponent.GetScaledCapsuleHalfHeight();
                //     FVector EndTrace = BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter) + fVector;
                //     var MovementData = RequireReadOnlyData<IBUC_MovementData, BUC_MovementData>();
                //     if (MovementData != null)
                //     {
                //         var EnvironmentInteractionMgrData = RequireWritableData<BUC_EnvironmentInteractionMgrData>();

                //         EnvironmentInteractionMgrData.bNearGround = MovementData.CanUseSurfaceTypeFromMovementComp() && BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter).Z - MovementData.CurFloorHitPoint.Z < 0f - fVector.Z;
                //         var curItem = SurfaceTypeDict.FirstOrDefault(kvp => kvp.Key == EnvironmentInteractionMgrData.LastResultSurfaceType).Value;

                //         string SurfaceTypeStr = curItem.Name;
                //         // var buffId = curItem.BuffId;
                //         // if (buffId != 0 && !BGUFunctionLibraryCS.BGUHasBuffByID(controlledPawn, buffId))
                //         // {
                //         //     BGUFunctionLibraryCS.BGUAddBuff(controlledPawn, controlledPawn, buffId, EBuffSourceType.GM, 3000);
                //         // }
                //         buffText += $";   地形: {SurfaceTypeStr}";
                //     }
                // }
                ShowPlayerInfo.UpdateUTextBlockContentIfChanged(ShowPlayerInfo.BasicInfoVs[index], buffText);
            }

            else if (attribute.Key == EBGUAttrFloat.None)
            {
                var target = BGUFunctionLibraryCS.BGUGetTarget(controlledPawn) as BGUCharacterCS;


                var text = "目标角色";
                if (target == null)
                {
                    target = Helper.GetNearestActor(4000);
                    text = "最近角色";
                }
                if (target != null)
                {
                    // 生命/法力
                    float Hp = BGUFunctionLibraryCS.GetAttrValue(target, EBGUAttrFloat.Hp);
                    float Atk = BGUFunctionLibraryCS.GetAttrValue(target, EBGUAttrFloat.Atk);
                    float DmgDef = BGUFunctionLibraryCS.GetAttrValue(target, EBGUAttrFloat.DmgDef);
                    var teamID = target.GetTeamIDInCS();
                    var player = Helper.GetBGUPlayerCharacterCS();
                    var playerTeamID = player.GetTeamIDInCS();
                    var teamTxt = teamID == playerTeamID ? "友" : "敌";
                    BGW_UIEventCollection.Get(target)?.Evt_UI_InitTopBarUI(ECSExtension.ToEntity(target));
                    // 攻击/伤害加成
                    float DmgAddition = BGUFunctionLibraryCS.GetAttrValue(target, EBGUAttrFloat.DmgAddition);
                    ShowPlayerInfo.UpdateUTextBlockContentIfChanged(ShowPlayerInfo.BasicInfoVs[index], $"{text}({teamTxt})生命:{(int)Hp}, 攻击:{(int)Atk}, 减伤:{(int)DmgDef / 100}%, 加伤:{(int)DmgAddition / 100}%");
                }
                else
                {
                    ShowPlayerInfo.UpdateUTextBlockContentIfChanged(ShowPlayerInfo.BasicInfoVs[index], "");
                }
            }


            index++;
        }
    }

    private bool CheckWorldAndPawn()
    {
        UWorld world = ShowPlayerInfo.GetWorld();
        if (!ShowPlayerInfo.IsValidUObject(world) || !ShowPlayerInfo.IsValidUObject(World))
            return false;

        APawn controlledPawn = ShowPlayerInfo.GetControlledPawn();
        return ShowPlayerInfo.IsValidActor(controlledPawn);
    }

    public bool InitDone()
    {
        return CheckWorldAndPawn() &&
               ShowPlayerInfo.IsValidUObject(MainCon) &&
               ShowPlayerInfo.IsValidUObject(World) &&
               ShowPlayerInfo.BasicInfoVs != null &&
               ShowPlayerInfo.BasicInfoVs.Count > 0;
    }


    public void InitBasicInfo()
    {
        if (!ShowPlayerInfo.IsValidUObject(MainCon))
            return;

        if (ShowPlayerInfo.BasicInfoKs == null || ShowPlayerInfo.BasicInfoVs == null)
            return;


        for (int i = 0; i < ShowPlayerInfo.BasicAttributes.Count; i++)
        {
            UCanvasPanelSlot keySlot = MainCon.AddChild(ShowPlayerInfo.BasicInfoKs[i]) as UCanvasPanelSlot;
            if (ShowPlayerInfo.IsValidUObject(keySlot))
            {
                keySlot.SetAnchors(AnchorsRT);
                keySlot.SetAlignment(VecRT);

                keySlot.SetPosition(new FVector2D(-580.0, 20f + 60f * i));
            }

            UCanvasPanelSlot valueSlot = MainCon.AddChild(ShowPlayerInfo.BasicInfoVs[i]) as UCanvasPanelSlot;
            if (ShowPlayerInfo.IsValidUObject(valueSlot))
            {
                valueSlot.SetAnchors(AnchorsRT);
                valueSlot.SetAlignment(VecRT);
                valueSlot.SetPosition(new FVector2D(-40.0, 20f + 60f * i));
            }
        }
    }
    public void InitWidgets()
    {
        // 重置初始化状态
        World = ShowPlayerInfo.GetWorld();
        if (!ShowPlayerInfo.IsValidUObject(World))
            return;

        if (GSUI.UIMgr.FindUIPage(World, 2) is UIBattleMainCon obj)
        {
            MainCon = obj.GetFieldOrProperty<UCanvasPanel>("MainCon");
            if (ShowPlayerInfo.IsValidUObject(MainCon))
            {
                InitBasicInfo();
            }
        }
    }

    public override void OnTickWithGroup(float DeltaTime, int TickGroup)
    {
        try
        {
            if (!InitDone())
            {
                InitWidgets();
            }
            else
            {
                RenderBasicInfo(DeltaTime);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ticker Exp: " + ex.Message);
        }
    }


    public void DestroyMainCon()
    {
        if (!ShowPlayerInfo.IsValidUObject(MainCon) || MainCon == null)
            return;

        try
        {
            // 安全移除已知的子控件
            if (ShowPlayerInfo.BasicInfoKs != null && ShowPlayerInfo.BasicInfoVs != null)
            {
                for (int i = 0; i < ShowPlayerInfo.BasicAttributes.Count; i++)
                {
                    if (ShowPlayerInfo.IsValidUObject(ShowPlayerInfo.BasicInfoKs[i]))
                        MainCon.RemoveChild(ShowPlayerInfo.BasicInfoKs[i]);
                    if (ShowPlayerInfo.IsValidUObject(ShowPlayerInfo.BasicInfoVs[i]))
                        MainCon.RemoveChild(ShowPlayerInfo.BasicInfoVs[i]);
                }
            }
            // 清空引用
            MainCon = null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"DestroyMainCon Error: {ex.Message}");
        }
    }

}
