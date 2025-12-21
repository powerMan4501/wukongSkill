using System;
using System.Collections.Generic;
using b1;
using B1UI.GSUI;
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
              else if (attribute.Key == EBGUAttrFloat.FreezeAbnormalAcc)
            {
                // 异常
                float FreezeDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.FreezeAbnormalAcc);
                float BurnDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.BurnAbnormalAcc);
                float PoisonDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.PoisonAbnormalAcc);
                float ThunderDef = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.ThunderAbnormalAcc);
                ShowPlayerInfo.UpdateUTextBlockContentIfChanged(ShowPlayerInfo.BasicInfoVs[index], $"四灾异常: 冰:{(int)FreezeDef}, 火:{(int)BurnDef},  毒:{(int)PoisonDef},  雷:{(int)ThunderDef}");
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
