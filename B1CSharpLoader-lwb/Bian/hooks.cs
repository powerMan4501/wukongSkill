using System;
using System.Reflection;
using b1;
using HarmonyLib;
using UnrealEngine.Runtime;
using UnrealEngine.Engine;
using CSharpModBase;
using System.Collections.Generic;
using System.Linq;


namespace bian;

[HarmonyPatch]
public class Hooks
{

    public static bool isInit = false;

    private static List<AnimRuleBySweepCheck> _cachedAnimRules = null; // 缓存动画规则

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
                if (isInit)
                {
                    return;
                }
                Console.WriteLine($"InitPassiveSkillMap.Prefix");

                LoadUtils.LoadAndApplyPassiveSkills();
                LoadUtils.LoadAndApplyChargeSkill();
                LoadUtils.ModifyIronData();
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
    // public class HookMagicallyChange
    // {
    //     private static MethodBase TargetMethod()
    //     {
    //         return AccessTools.Method("b1.BUS_MagicallyChangeComp:OnPlayMontageCallback", (Type[])null, (Type[])null);
    //     }

    //     [HarmonyPatch]
    //     private static void Prefix(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
    //     {
    //         if (Helper.isPlayVigorSkillByID && State != EMontageCallbackState.Default && State != EMontageCallbackState.OnStarted)
    //         {
    //             Helper.updateIsPlayVigorSkillByID(false);
    //         }
    //     }
    // }



    // 获取缓存的动画规则，如果不存在则加载并缓存
    public static List<AnimRuleBySweepCheck> GetCachedAnimRules()
    {
        if (_cachedAnimRules == null)
        {
            try
            {
                _cachedAnimRules = LoadUtils.LoadAnimRulesBySweepCheck();
                Console.WriteLine("动画规则已加载并缓存");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"加载动画规则时出错: {ex.Message}");
                // 返回空集合而不是null，以避免后续代码中的空引用异常
                return new List<AnimRuleBySweepCheck>();
            }
        }
        return _cachedAnimRules;
    }


    [HarmonyPatch]
    public class HookGSNotifyBeginCS
    {
        private static MethodBase TargetMethod()
        {
            return AccessTools.Method("b1.BANS_GSSweepCheck:GSNotifyBeginCS_Implementation", (Type[])null, (Type[])null);
        }

        [HarmonyPatch]
        private static void Prefix(FUStGSNotifyParam NotifyParam, float TotalDuration)
        {
            {
                if (NotifyParam.Animation != null && NotifyParam.owner != null && NotifyParam.owner.GetName().IndexOf("Unit_Player_Wukong_C") > -1)
                {
                    var allRules = GetCachedAnimRules();
                    if (allRules == null || allRules.Count == 0) return; // 如果获取规则失败，则直接返回
                    var nowMontage = NotifyParam.Animation.PathName;
                    var linkValue = NotifyParam.AnimNotifyEvent_LinkValue;
                    Console.WriteLine($" BANS_GSSweepCheck.NotifyParam: {NotifyParam.Animation.GetFName()} ,linkValue:{linkValue},{NotifyParam.owner.GetName()},MeshComp,{NotifyParam.MeshComp.GetName()}");

                    if (allRules.Count > 0)
                    {
                        var matchedRule = allRules.FirstOrDefault(rule =>
                            !string.IsNullOrEmpty(nowMontage) &&
                            nowMontage.Contains(rule.montage) &&
                            (rule?.linkValue == 0 || rule?.linkValue.ToString() == linkValue.ToString()));
                        if (matchedRule != null && matchedRule?.AfterActions?.Count > 0)
                        {
                            var rule = new Rule();
                            rule.DoAfterActions(matchedRule.AfterActions);
                        }
                    }
                }

            }
        }
    }
}
