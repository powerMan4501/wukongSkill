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

public class TimerComp : UActorCompBaseCS
{
    public UWorld? World = null;
    public UCanvasPanel? MainCon = null;
    public bool isInitialized = false;

    private static FVector2D VecRT = new FVector2D(0.2, 0.15);  // 左边
    private static FAnchors AnchorsRT = default(FAnchors);

    static TimerComp()
    {
        AnchorsRT.Minimum = VecRT;
        AnchorsRT.Maximum = VecRT;
    }

    public override void OnAttach()
    {
        SetCanTick(true);
    }

    public override int GetTickGroupMask()
    {
        return CanTick() ? 1 : 0;
    }



    private static readonly HashSet<EBGUAttrFloat> PercentageAttributes = new HashSet<EBGUAttrFloat>
{
    EBGUAttrFloat.CritRate,
    EBGUAttrFloat.CritDmgMulDef,
    EBGUAttrFloat.DmgDef,
    EBGUAttrFloat.DmgAddition
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
            if (attribute.Key == EBGUAttrFloat.Hp)
            {
                float hpMax = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.HpMax);
                ShowPlayerInfo.UpdateUTextBlockContentIfChanged(ShowPlayerInfo.BasicInfoVs[index], $"{value} / {hpMax}");
            }
            else
         if (attribute.Key == EBGUAttrFloat.Mp)
            {
                float MpMax = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.MpMax);
                ShowPlayerInfo.UpdateUTextBlockContentIfChanged(ShowPlayerInfo.BasicInfoVs[index], $"{value} / {MpMax}");
            }

            else if (PercentageAttributes.Contains(attribute.Key))
            {
                float critRate = value / 100f;
                ShowPlayerInfo.UpdateUTextBlockContentIfChanged(ShowPlayerInfo.BasicInfoVs[index], $"{(int)critRate}%");
            }

            else if (attribute.Key == EBGUAttrFloat.CritMultiplierBase)
            {

                float CritMultiplier = BGUFunctionLibraryCS.GetAttrValue(controlledPawn, EBGUAttrFloat.CritMultiplier);
                ShowPlayerInfo.UpdateUTextBlockContentIfChanged(ShowPlayerInfo.BasicInfoVs[index], $"{(int)CritMultiplier / 100f + 130f}%");
            }
            else
            {
                ShowPlayerInfo.UpdateUTextBlockContentIfChanged(ShowPlayerInfo.BasicInfoVs[index], $"{(int)value}");

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
        return isInitialized && CheckWorldAndPawn() &&
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
                // if (ShowPlayerInfo.BasicAttributes.ElementAt(i).Key == EBGUAttrFloat.Shield)
                // {
                //     keySlot.SetPosition(new FVector2D(20.0f, -20f));  // 左下角位置
                // }
                // else
                // {
                //     keySlot.SetPosition(new FVector2D(-580.0, 20f + 60f * i));
                // }
                keySlot.SetPosition(new FVector2D(-580.0, 20f + 60f * i));
            }

            UCanvasPanelSlot valueSlot = MainCon.AddChild(ShowPlayerInfo.BasicInfoVs[i]) as UCanvasPanelSlot;
            if (ShowPlayerInfo.IsValidUObject(valueSlot))
            {
                valueSlot.SetAnchors(AnchorsRT);
                valueSlot.SetAlignment(VecRT);


                // if (ShowPlayerInfo.BasicAttributes.ElementAt(i).Key == EBGUAttrFloat.Shield)
                // {
                //     keySlot.SetPosition(new FVector2D(20.0f, -20f));  // 左下角位置
                // }
                // else
                // {
                //     valueSlot.SetPosition(new FVector2D(-40.0, 20f + 60f * i));
                // }
                valueSlot.SetPosition(new FVector2D(-40.0, 20f + 60f * i));
            }
        }
    }
    public void InitWidgets()
    {
        // 重置初始化状态
        isInitialized = false;
        World = ShowPlayerInfo.GetWorld();
        if (!ShowPlayerInfo.IsValidUObject(World))
            return;

        if (GSUI.UIMgr.FindUIPage(World, 2) is UIBattleMainCon obj)
        {
            MainCon = obj.GetFieldOrProperty<UCanvasPanel>("MainCon");
            if (ShowPlayerInfo.IsValidUObject(MainCon))
            {
                InitBasicInfo();
                isInitialized = true;
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
}
