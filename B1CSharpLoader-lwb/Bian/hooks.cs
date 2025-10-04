using System;
using System.Reflection;
using b1;
using HarmonyLib;
using UnrealEngine.Runtime;
using UnrealEngine.Engine;
using CSharpModBase;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;



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
                Console.WriteLine($"AfterInitAllComp.Prefix ");

                Manager.loadAllStaticData(false, 0);
            }
        }
    }


    // [HarmonyPatch]
    // public class HookBUS_PassiveSkillComp
    // {
    //     private static MethodBase TargetMethod()
    //     {
    //         return AccessTools.Method("b1.BGW_GameDB:InitPassiveSkillMap", (Type[])null, (Type[])null);
    //     }
    //     [HarmonyPrefix]
    //     private static void Prefix()
    //     {
    //         try
    //         {
    //             if (isInit)
    //             {
    //                 return;
    //             }
    //             Console.WriteLine($"InitPassiveSkillMap.Prefix");
    //             LoadUtils.LoadAndApplyPassiveSkills();
    //             LoadUtils.LoadAndApplyChargeSkill();
    //             LoadUtils.ModifyIronData();
    //             isInit = true;
    //         }

    //         catch (Exception ex)
    //         {
    //             // 记录错误但不阻止原始方法执行
    //             Console.WriteLine($"Error in HookBUS_PassiveSkillComp.Prefix: {ex.Message}");
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

            if (NotifyParam.Animation != null && NotifyParam.owner != null && NotifyParam.owner.GetName().IndexOf("Unit_Player") > -1)
            {
                var allRules = GetCachedAnimRules();
                if (allRules == null || allRules.Count == 0) return; // 如果获取规则失败，则直接返回
                var nowMontage = NotifyParam.Animation.PathName;
                var linkValue = NotifyParam.AnimNotifyEvent_LinkValue;



                // // 导出骨骼点到JSON文件
                // string ownerName = NotifyParam.owner.GetName();
                // string fileName = $"{ownerName}_{NotifyParam.Animation.GetFName()}_bones.json";
                // string exportPath = Path.Combine("CSharpLoader", "Mods", "bian", "bonesData");
                // string fullPath = Path.Combine(exportPath, fileName);

                // if (!File.Exists(fullPath))
                // {
                //     var MeshComp = NotifyParam.MeshComp;
                //     var num = MeshComp?.GetNumBones();
                //     var boneList = new List<string>();
                //     if (num > 0 && MeshComp != null)
                //     {
                //         for (int i = 0; i < num; i++)
                //         {
                //             var BoneName = MeshComp.GetBoneName(i).ToString();
                //             boneList.Add(BoneName);
                //         }
                //         // 确保目录存在
                //         if (!Directory.Exists(exportPath))
                //         {
                //             Directory.CreateDirectory(exportPath);
                //         }

                //         string jsonContent = JsonConvert.SerializeObject(boneList, Formatting.Indented);
                //         File.WriteAllText(fullPath, jsonContent);
                //     }
                // }

                // string linkValueFileName = $"{NotifyParam.Animation.GetFName()}_BANS_GSSweepCheck_linkValue_{linkValue}.txt";
                // string linkValueExportPath = Path.Combine("CSharpLoader", "Mods", "bian", "linkValueData");
                // string linkValueFullPath = Path.Combine(linkValueExportPath, linkValueFileName);
                // // 确保目录存在
                // if (!Directory.Exists(linkValueExportPath))
                // {
                //     Directory.CreateDirectory(linkValueExportPath);
                // }

                // // 只在文件不存在时写入linkValue数据
                // if (!File.Exists(linkValueFullPath))
                // {
                //     string linkValueData = linkValue.ToString();
                //     File.WriteAllText(linkValueFullPath, linkValueData);
                // }

                Console.WriteLine($"BANS_GSSweepCheck.NotifyParam: {NotifyParam.Animation.GetFName()} ,linkValue:{linkValue}");
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


    // [HarmonyPatch]
    // public class HookBUS_SweepCheckHitComp
    // {
    //     private static MethodBase TargetMethod()
    //     {
    //         return AccessTools.Method("b1.BUS_SweepCheckHitComp:OnSweepCheckHit", (Type[])null, (Type[])null);
    //     }

    //     [HarmonyPatch]
    //     private static void Prefix(ref AActor Victim, ref float SweepProtectTime, ref string SkillTaskUniqID, in FEffectInstReq EffectInstReq, ref List<AbnormalStateAccConfig> AbnormalStateEffectList, ref List<FTriggerEffectWithCondition> EffectsWithCondition_Before, ref List<int> EffectIDList, ref List<FTriggerEffectWithCondition> EffectsWithCondition_After, ref int GroupID, ref int FromInstanceID)
    //     {

    //         var attacker = EffectInstReq.Attacker;
    //         if (attacker == null) return;
    //         var name = attacker?.PathName;
    //         if (name == null || name.ToLower().IndexOf("unit_player") < 0)
    //         {
    //             return;
    //         }
    //         var character = Helper.GetBGUPlayerCharacterCS();
    //         UAnimMontage? currentMontage = null;
    //         if (character == null)
    //         {
    //             return;
    //         }
    //         UAnimInstance animInstance = character.Mesh.GetAnimInstance();
    //         if (character == animInstance)
    //         {
    //             return;
    //         }
    //         currentMontage = animInstance.GetCurrentActiveMontage();

    //         var allRules = GetCachedAnimRules();
    //         if (allRules == null || allRules.Count == 0) return; // 如果获取规则失败，则直接返回
    //         var nowMontage = currentMontage.PathName;
    //         if (nowMontage == null)
    //         {
    //             return;
    //         }

    //         if (allRules.Count > 0)
    //         {
    //             var matchedRule = allRules.FirstOrDefault(rule =>
    //                 !string.IsNullOrEmpty(nowMontage) &&
    //                 nowMontage.Contains(rule.montage));

    //             if (matchedRule != null) return;
    //             if (matchedRule?.hitActions != null && matchedRule?.hitActions?.Count > 0)
    //             {
    //                 var rule = new Rule();
    //                 foreach (var action in matchedRule.hitActions)
    //                 {
    //                     action.Caster = character;
    //                     action.Target = Victim;
    //                     action.EffectInstReq = EffectInstReq;
    //                 }
    //                 rule.DoAfterActions(matchedRule.hitActions);
    //             }

    //             if (matchedRule?.hitEffects?.Count > 0)
    //             {
    //                 EffectIDList.AddRange(matchedRule.hitEffects);
    //             }
    //         }

    //     }
    // }




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

            if (NotifyParam.Animation != null && NotifyParam.owner != null && NotifyParam.owner.GetName().IndexOf("Unit_Player") > -1)
            {
                var allRules = GetCachedAnimRules();
                if (allRules == null || allRules.Count == 0) return; // 如果获取规则失败，则直接返回
                var nowMontage = NotifyParam.Animation.PathName;
                var linkValue = NotifyParam.AnimNotifyEvent_LinkValue;
                var fname = NotifyParam.Animation.GetFName();

                // string linkValueFileName = $"{NotifyParam.Animation.GetFName()}_BANS_GSSpawnBullets_linkValue_{linkValue}.txt";
                // string linkValueExportPath = Path.Combine("CSharpLoader", "Mods", "bian", "linkValueData");
                // string linkValueFullPath = Path.Combine(linkValueExportPath, linkValueFileName);
                // // 确保目录存在
                // if (!Directory.Exists(linkValueExportPath))
                // {
                //     Directory.CreateDirectory(linkValueExportPath);
                // }

                // // 只在文件不存在时写入linkValue数据
                // if (!File.Exists(linkValueFullPath))
                // {
                //     string linkValueData = linkValue.ToString();
                //     File.WriteAllText(linkValueFullPath, linkValueData);
                // }


                Console.WriteLine($"BANS_GSSpawnBullets.NotifyParam: {NotifyParam.Animation.GetFName()} ,linkValue:{linkValue} ");
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


    // [HarmonyPatch]
    // public class HookGameDBRuntimeInit
    // {
    //     private static MethodBase TargetMethod()
    //     {
    //         return AccessTools.Method("b1.BGW_GameDB:Init", (Type[])null, (Type[])null);
    //     }

    //     [HarmonyPatch]
    //     private static void Prefix()
    //     {
    //         Console.WriteLine($" BGW_GameDB.Prefix: ");
    //         Manager.loadAllStaticData(false, 0);
    //     }
    // }



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
            var hitEffects = new List<int>();
            float am_speed = 0;
            if (config != null)
            {
                addRadius = config.addRadius ?? 100;

                if (config.hitEffects != null && config.hitEffects.Count > 0)
                {
                    hitEffects.AddRange(config.hitEffects);
                }
                if (config.AMSpeedRate != null && config.AMSpeedRate > 0)
                {
                    am_speed = (float)config.AMSpeedRate;
                }
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
                    if (hitEffects.Count > 0)
                    {
                        foreach (var hitEffect in hitEffects)
                        {
                            sweepCheck.EffectIDList.Add(hitEffect);
                        }
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
                else if (item.NotifyName == new FName("BANS_GSSetAMSpeedRate"))
                {
                    // 使用反射来获取和设置属性值
                    var notifyStateClassType = item.NotifyStateClass.GetType();

                    // 获取 SectionSpeedRate 属性
                    var sectionSpeedRateProperty = notifyStateClassType.GetProperty("SectionSpeedRate");
                    if (sectionSpeedRateProperty != null)
                    {
                        // 获取当前属性值
                        var currentValue = sectionSpeedRateProperty.GetValue(item.NotifyStateClass);
                        float sectionSpeedRate = (float)currentValue;

                        // 检查并修改值
                        if (sectionSpeedRate < 1.5 && am_speed > 0)
                        {
                            sectionSpeedRateProperty.SetValue(item.NotifyStateClass, am_speed);
                        }
                    }

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
