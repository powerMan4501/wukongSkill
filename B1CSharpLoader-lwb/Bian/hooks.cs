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
                Console.WriteLine($" AfterInitAllComp.Prefix: ");
                Manager.loadAllStaticData(false, 0);
            }
        }
    }
    //    // 新增的拦截器类
    //     [HarmonyPatch]
    //     public class HookBUS_ChargeSkill
    //     {
    //         private static MethodBase TargetMethod()
    //         {
    //             return AccessTools.Method("b1.BUS_PassiveSkillComp:OnAttach", (Type[])null, (Type[])null);
    //         }
    //         [HarmonyPrefix]
    //         private static void Prefix()
    //         {
    //             try
    //             {
    //                 if (isInit) return;
    //                 LoadUtils.LoadAndApplyChargeSkill();
    //                 isInit = true;
    //             }

    //             catch (Exception ex)
    //             {
    //                 // 记录错误但不阻止原始方法执行
    //                 Console.WriteLine($"Error in HookBUS_PassiveSkillComp.Prefix: {ex.Message}");
    //             }
    //         }
    //     }





    // 新增的拦截器类
    [HarmonyPatch]
    public class HookBUS_PassiveSkillComp
    {
        private static MethodBase TargetMethod()
        {
            return AccessTools.Method("b1.BGW_GameDB:InitPassiveSkillMap", (Type[])null, (Type[])null);
        }
        [HarmonyPrefix]
        private static void Prefix()
        {
            try
            {
                // 在 OnAttach 执行前加载和应用被动技能配置
                LoadUtils.LoadAndApplyPassiveSkills();
                LoadUtils.LoadAndApplyChargeSkill();
                LoadUtils.ModifyIronData();
                Console.WriteLine($"InitPassiveSkillMap.Prefix");
            }

            catch (Exception ex)
            {
                // 记录错误但不阻止原始方法执行
                Console.WriteLine($"Error in HookBUS_PassiveSkillComp.Prefix: {ex.Message}");
            }
        }
    }

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
    //             if (MeshComp.SkeletalMesh.GetFullName().ToLower().IndexOf("SK_Wukong_Simple".ToLower()) > -1)
    //             {
    //                 var currentTime = Manager.GetCurrentTime();
    //                 var currentMontage = Manager.GetCurrentMontage();
    //                 var nowTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
    //                 // 计算时间差
    //                 if (!string.IsNullOrEmpty(currentTime))
    //                 {
    //                     DateTime current = DateTime.Parse(currentTime);
    //                     DateTime now = DateTime.Parse(nowTime);
    //                     TimeSpan diff = now - current;
    //                     double secondsDiff = diff.TotalSeconds;
    //                     Log.Info($"Received_Notify_Implementation Animation: {Animation.GetName()},  difference: {secondsDiff} seconds");
    //                 }

    //             }
    //         }
    //         catch (Exception ex)
    //         {
    //             Console.WriteLine($"Error in HookUAnimNotifyState.Prefix: {ex.Message}");
    //         }
    //     }
    // }

}
