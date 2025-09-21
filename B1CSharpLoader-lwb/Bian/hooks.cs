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

            if (NotifyParam.Animation != null && NotifyParam.owner != null && NotifyParam.owner.GetName().IndexOf("Unit_Player_Wukong_C") > -1)
            {
                var allRules = GetCachedAnimRules();
                if (allRules == null || allRules.Count == 0) return; // 如果获取规则失败，则直接返回
                var nowMontage = NotifyParam.Animation.PathName;
                var linkValue = NotifyParam.AnimNotifyEvent_LinkValue;
                Console.WriteLine($"BANS_GSSweepCheck.NotifyParam: {NotifyParam.Animation.GetFName()} ,linkValue:{linkValue} ");
                if (allRules.Count > 0)
                {
                    var matchedRule = allRules.FirstOrDefault(rule =>
                        !string.IsNullOrEmpty(nowMontage) &&
                        nowMontage.Contains(rule.montage) &&
                        (rule?.linkValue == 0 || rule?.linkValue.ToString() == linkValue.ToString()));
                    if (matchedRule != null && matchedRule?.SweepActions?.Count > 0)
                    {
                        var rule = new Rule();
                        rule.DoAfterActions(matchedRule.SweepActions);
                    }
                }
            }
        }
    }






    [HarmonyPatch]
    public class HookGSSpawnBulletsNotifyBeginCS
    {
        private static MethodBase TargetMethod()
        {
            return AccessTools.Method("b1.BANS_GSSpawnBullets:GSNotifyBeginCS_Implementation", (Type[])null, (Type[])null);
        }

        [HarmonyPatch]
        private static void Prefix(FUStGSNotifyParam NotifyParam)
        {

            if (NotifyParam.Animation != null && NotifyParam.owner != null && NotifyParam.owner.GetName().IndexOf("Unit_Player_Wukong_C") > -1)
            {
                var allRules = GetCachedAnimRules();
                if (allRules == null || allRules.Count == 0) return; // 如果获取规则失败，则直接返回
                var nowMontage = NotifyParam.Animation.PathName;
                var linkValue = NotifyParam.AnimNotifyEvent_LinkValue;
                var fname = NotifyParam.Animation.GetFName();
                Console.WriteLine($"BANS_GSSweepCheck.NotifyParam: {NotifyParam.Animation.GetFName()} ,linkValue:{linkValue} ");
                if (allRules.Count > 0)
                {
                    var matchedRule = allRules.FirstOrDefault(rule =>
                        !string.IsNullOrEmpty(nowMontage) &&
                        nowMontage.Contains(rule.montage) &&
                        (rule?.linkValue == 0 || rule?.linkValue.ToString() == linkValue.ToString()));
                    if (matchedRule != null && matchedRule?.bulletsActions?.Count > 0)
                    {
                        var rule = new Rule();
                        rule.DoAfterActions(matchedRule.bulletsActions);
                    }
                }
            }
        }
    }

    private static readonly Dictionary<string, bool> ProcessedAnimCache = new Dictionary<string, bool>();

    public static void handleNotify(UAnimMontage Montage, float? MoveOffset = 1)
    {
        try
        {
            if (Montage == null || Montage?.PathName == null)
            {
                return;
            }


            // if (AnimNotifyEventList != null && AnimNotifyEventList.Count > 0)
            // {
            //     Log.Info($"{Montage.GetName()} AnimNotifyEventList Count: {AnimNotifyEventList.Count} ");
            //     // 输出 AnimNotifyEventList 中的 NotifyName
            //     var animNotifyEventNames = AnimNotifyEventList.Select(item => item.NotifyName.ToString()).ToList();
            //     if (animNotifyEventNames.Count > 0)
            //     {
            //         Log.Info($"AnimNotifyEventList NotifyNames: {string.Join(", ", animNotifyEventNames)}");
            //     }
            // }

            if (ProcessedAnimCache.ContainsKey(Montage.PathName))
            {
                return;
            }
            UGSE_AnimFuncLib.GetAllNotifyEvent(Montage, out var AnimNotifyEventList);
            // 确保数据已加载
            // if (notifyDataList.Count == 0)
            // {
            //     LoadNotifyData();
            // }

            if (!(AnimNotifyEventList != null && AnimNotifyEventList.Count > 0))
            {
                return;
            }

            var allRules = GetCachedAnimRules();
            if (allRules == null || allRules.Count == 0) return; // 如果获取规则失败，则直接返回
            // 查找匹配的JSON数据
            var strPathName = Montage.PathName.ToString();
            var addRadius = 100;

            // 替换原有的硬编码判断逻辑
            var config = allRules.FirstOrDefault(c => strPathName.Contains(c.montage));
            if (config != null)
            {
                addRadius = config.addRadius ?? 100;
            }
            // 查找相同类型的通知作为模板
            foreach (FAnimNotifyEvent item in AnimNotifyEventList)
            {
                if (item.NotifyStateClass is BANS_GSSweepCheck sweepCheck)
                {
                    for (int i = 0; i < sweepCheck.SweepCheckShape.Count; i++)
                    {
                        var sweepItem = sweepCheck.SweepCheckShape[i];
                        var addNum = sweepItem.Radius < 1000 ? sweepItem.Radius + addRadius : sweepItem.Radius;
                        sweepItem.Radius = addNum;
                        var scaleNum = Math.Round(addNum / sweepItem.Radius, 3);
                        if (scaleNum > 1)
                        {
                            sweepItem.SKComp.SetRelativeScale3D(new FVector(scaleNum, scaleNum, scaleNum));
                        }
                        sweepCheck.SweepCheckShape[i] = sweepItem;

                    }
                }
                else if (item.NotifyName == new FName("BANS_GSCalcAMScale"))
                {

                    // 获取当前属性值
                    var currentValue = BANS_GSCalcAMScaleHelper.GetProperty(item.NotifyStateClass, "AMScaleMaxRate");
                    var AMScaleMoveOffset = BANS_GSCalcAMScaleHelper.GetProperty(item.NotifyStateClass, "AMScaleMoveOffset");

                    // 只有当当前值小于10时才修改为10
                    if ((float)currentValue < 8)
                    {
                        var AMScaleItem = item.NotifyStateClass;
                        BANS_GSCalcAMScaleHelper.SetProperty(item.NotifyStateClass, "AMScaleMaxRate", 8);
                    }
                    if ((float)AMScaleMoveOffset >= -800 && (float)AMScaleMoveOffset <= -10)
                    {
                        var AMScaleItem = item.NotifyStateClass;

                        if (MoveOffset > 1)
                        {
                            var finalValue = (float)AMScaleMoveOffset - (float)MoveOffset;
                            BANS_GSCalcAMScaleHelper.SetProperty(item.NotifyStateClass, "AMScaleMoveOffset", finalValue);

                        }
                    }
                }
                else if (item.NotifyName == new FName("BANS_GSDodgeWindow") || item.NotifyName == new FName("ComboWindow"))
                {
                    item.LinkValue = 0.1f; // 设置触发时间为0.1秒
                }
                else if (BANS_GSAttackWarnningHelper.IsAttackWarning(item.NotifyStateClass))
                {
                    // 获取 hitLevel 属性
                    var hitLevel = BANS_GSAttackWarnningHelper.GetProperty(item.NotifyStateClass, "HitLevel");
                    // 在这里可以处理 hitLevel 属性
                    if ((int)hitLevel < 5)
                    {
                        BANS_GSAttackWarnningHelper.SetProperty(item.NotifyStateClass, "HitLevel", 5);
                    }
                }

            }
            // 标记该动画蒙太奇已处理
            ProcessedAnimCache[Montage.PathName] = true;
        }
        catch (Exception ex)
        {
            // 记录异常信息
            System.Console.WriteLine($"Error in getNotifyToJson: {ex.Message}");
            return;
        }
    }
}
