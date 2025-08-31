using System;
using System.Reflection;
using b1;
using HarmonyLib;
using UnrealEngine.Runtime;
using UnrealEngine.Engine;
using CSharpModBase;


namespace bian;

[HarmonyPatch]
public class Hooks
{

    public static bool isInit = false;
    [HarmonyPatch]
    public class HookBGGGameStateCS
    {
        private static MethodBase TargetMethod()
        {
            return AccessTools.Method("b1.BGGGameStateCS:AfterInitAllComp", (Type[])null, (Type[])null);
        }

        [HarmonyPatch]
        private static void Prefix(ref BGGGameStateCS __instance)
        {
            if ((UObject)(object)__instance != null)
            {
                Manager.loadAllStaticData(false, 0);
            }
        }
    }

    // 新增的拦截器类
    [HarmonyPatch]
    public class HookBUS_PassiveSkillComp
    {
        private static MethodBase TargetMethod()
        {
            return AccessTools.Method("b1.BUS_PassiveSkillComp:OnAttach", (Type[])null, (Type[])null);
        }
        [HarmonyPrefix]
        private static void Prefix()
        {
            try
            {
                if (isInit) return;
                // 在 OnAttach 执行前加载和应用被动技能配置
                LoadUtils.LoadAndApplyPassiveSkills();
                LoadUtils.LoadAndApplyChargeSkill();
                LoadUtils.ModifyIronData();
                Console.WriteLine($"InitPassiveSkillMap.Prefix");
                isInit = true;
            }

            catch (Exception ex)
            {
                // 记录错误但不阻止原始方法执行
                Console.WriteLine($"Error in HookBUS_PassiveSkillComp.Prefix: {ex.Message}");
            }
        }
    }

    // [HarmonyPatch]
    // public class HookBUS_IronBodyComp
    // {
    //     private static MethodBase TargetMethod()
    //     {
    //         return AccessTools.Method("b1.BUS_IronBodyComp:OnAttach", (Type[])null, (Type[])null);
    //     }

    //     [HarmonyPostfix]
    //     private static void Postfix(ref BUS_IronBodyComp __instance)
    //     {

    //         Log.Info($" ironBodyData OnAttach __instance：{__instance}");
    //         if (__instance != null)
    //         {
    //             // 使用反射来访问和修改私有字段
    //             var ironBodyDataField = typeof(BUS_IronBodyComp).GetField("IronBodyData", BindingFlags.NonPublic | BindingFlags.Instance);
    //             if (ironBodyDataField != null)
    //             {
    //                 var ironBodyData = ironBodyDataField.GetValue(__instance);
    //                 if (ironBodyData != null)
    //                 {
    //                     var endPreciseWindowTimeProperty = ironBodyData.GetType().GetProperty("EndPreciseWindowTime");
    //                     if (endPreciseWindowTimeProperty != null)
    //                     {
    //                         endPreciseWindowTimeProperty.SetValue(ironBodyData, 3f);
    //                         Log.Info($" ironBodyData set EndPreciseWindowTime to 3");
    //                     }
    //                 }
    //             }
    //         }
    //     }
    // }


    // [HarmonyPatch]
    // public class HookBUS_IronBodyComp
    // {
    //     private static MethodBase TargetMethod()
    //     {
    //         return AccessTools.Method("b1.BUS_IronBodyComp:OnAttach", (Type[])null, (Type[])null);
    //     }

    //     [HarmonyPatch]
    //     private static void Prefix()
    //     {
    //         if (isInit) return;
    //         LoadUtils.ModifyIronData();
    //         LoadUtils.LoadAndApplyPassiveSkills();
    //         LoadUtils.LoadAndApplyChargeSkill();
    //         Console.WriteLine($"BUS_IronBodyComp.Prefix");
    //         isInit = true;
    //     }
    // }


    // [HarmonyPatch]
    // public class HookUAnimNotifyState
    // {
    //     private static MethodBase TargetMethod()
    //     {
    //         return AccessTools.Method("UnrealEngine.Engine.UAnimNotifyState:Received_NotifyEnd_Implementation", (Type[])null, (Type[])null);
    //     }

    //     [HarmonyPrefix]
    //     private static void Prefix(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, FAnimNotifyEventReference EventReference)
    //     {
    //         try
    //         {
    //             // 在这里实现你的自定义逻辑
    //             Console.WriteLine($"AnimNotifyState End:GetFName: {Animation?.GetFName()}, GetFullName:{Animation?.GetFullName()}");
    //         }
    //         catch (Exception ex)
    //         {
    //             Console.WriteLine($"Error in HookUAnimNotifyState.Prefix: {ex.Message}");
    //         }
    //     }
    // }

}
