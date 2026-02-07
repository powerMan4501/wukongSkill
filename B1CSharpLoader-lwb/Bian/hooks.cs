using System;
using System.Reflection;
using b1;
using HarmonyLib;
using UnrealEngine.Runtime;
using UnrealEngine.Engine;
using CSharpModBase;
using System.Collections.Generic;
using System.Linq;
using BtlShare;
using b1.EventDelDefine;
using ArchiveB1;
using B1UI.GSUI;
using CommB1;
using ResB1;



namespace bian;

public static class BuffElementIds
{
    public const int Ice = 888666006;
    public const int Fire = 888666007;
    public const int Poison = 888666008;
    public const int Thunder = 888666005;
}
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
            if (!!Helper.is_bian_mod_stop)
            {
                return;
            }
            if ((UObject)(object)__instance != null)
            {

                Manager.loadAllStaticData(false, 0);
            }
        }
    }


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
            if (!!Helper.is_bian_mod_stop)
            {
                return;
            }

            var player = Helper.GetBGUPlayerCharacterCS();
            if (player == null) return;
            if (NotifyParam.Animation != null && NotifyParam.owner != null && NotifyParam.owner?.PathName == player.PathName)
            {
                var owner = NotifyParam.owner as BGUCharacterCS;
                if (owner == null) return;
                if (player.PathName == owner.PathName)
                {
                    var linkValue = NotifyParam.AnimNotifyEvent_LinkValue;
                    Console.WriteLine($"BANS_GSSweepCheck.NotifyParam: {NotifyParam.Animation.GetFName()} ,linkValue:{linkValue}");

                    var rulesMap = LoadSkill.TemplatePathConfigs;
                    if (rulesMap == null) return;
                    var currentMontage = NotifyParam.Animation.PathName;
                    //                     var matchedConfig = rulesMap?.Values.FirstOrDefault(config =>
                    //   BGW_GameDB.GetSkillSDesc(config.skillID, NotifyParam.owner)?.TemplatePath?.Contains(NotifyParam.Animation.PathName) ?? false);
                    var str = $"AnimMontage'{NotifyParam.Animation.PathName}'";
                    var matchedItem = rulesMap.FirstOrDefault(item => item.Key.Contains(currentMontage));
                    if (matchedItem.Equals(default(KeyValuePair<string, LoadSkill.ActionsBySkillConfig>)))
                    {

                        var allRules = GetCachedAnimRules();
                        if (allRules == null || allRules.Count == 0) return; // 如果获取规则失败，则直接返回
                        var nowMontage = NotifyParam.Animation.PathName;
                        var matchedRule = allRules.FirstOrDefault(rule =>
                                    !string.IsNullOrEmpty(nowMontage) &&
                                    nowMontage.Contains(rule.montage) &&
                                    (rule?.linkValue == 0 || rule?.linkValue.ToString() == linkValue.ToString()));

                        if (matchedRule != null && matchedRule?.SweepActions?.Count > 0)
                        {
                            var rule_ = new Rule();
                            rule_?.DoAfterActions(matchedRule.SweepActions);
                        }
                        return;
                    }
                    var matchedConfig = matchedItem.Value;
                    // if (!rulesMap.TryGetValue(str, out var matchedConfig)) return;
                    if (matchedConfig == null || matchedConfig.sweep_actions == null || matchedConfig.sweep_actions.Count == 0) return;
                    var matchItem = matchedConfig.sweep_actions.FirstOrDefault(item => (item.linkValue == 0 || item.linkValue.ToString() == linkValue.ToString()));
                    if (matchItem == null || matchItem.actions == null || matchItem.actions.Count == 0) return;
                    var rule = new Rule();
                    rule?.DoAfterActions(matchItem.actions);
                    return;

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
        private static void Prefix(BANS_GSSpawnBullets __instance, FUStGSNotifyParam NotifyParam)
        {
            if (!!Helper.is_bian_mod_stop)
            {
                return;
            }
            var player = Helper.GetBGUPlayerCharacterCS();
            if (player == null) return;
            var PathName = NotifyParam.Animation.PathName;
            Helper.LogInfoOnce($"BANS_GSSpawnBullets发射子弹BulletID:{__instance.BulletID}");
            var BulletID = __instance.BulletID;
            if (BGUFunctionLibraryCS.BGUHasBuffByID(player, BuffElementIds.Fire) && BulletID == 1703001)
            {
                var BornDirOffset = __instance.BornDirOffset;
                BornDirOffset.BornDirOffsetX.LeftValue += 90;
                BornDirOffset.BornDirOffsetX.RightValue += 90;
                __instance.BornDirOffset = BornDirOffset;
                __instance.BulletID = 88880009;//火剑气
            }
            else if (BGUFunctionLibraryCS.BGUHasBuffByID(player, BuffElementIds.Ice) && BulletID == 88880009)
            {
                __instance.BulletID = 1703001;//冰剑气
            }

            if (NotifyParam.Animation != null && PathName.Contains("AM_player_lys_hou"))
            {

                // 修改子弹速度
                var newSpeed = new FSpawnBulletSpeed();
                newSpeed.Spd.LeftValue = 6000;
                newSpeed.Spd.RightValue = 6000;
                __instance.BulletFlySpd = newSpeed;
                // R1toR2
                // if (PathName.Contains("AM_player_lys_hou_F1_02") || PathName.Contains("R1toR2"))
                // {
                //     var targetBase = __instance.TargetBase;
                //     var spawnBase = __instance.SpawnBase;
                //     var BornDirBaseInfo = __instance.BornDirBaseInfo;

                //     targetBase.BaseType = ProjectileBaseType.CurTarget_ProjectileSpawner;
                //     targetBase.UseSocket = true;
                //     targetBase.SocketName = (FName)"CAMERA_LOCK";
                //     spawnBase.BaseType = ProjectileBaseType.ProjectileSpawner;
                //     BornDirBaseInfo.BornDirType = ProjectileBornDirType.LookAtTargetPos;
                //     // 爆气砍就对准目标发射
                //     __instance.TargetBase = targetBase;
                //     __instance.SpawnBase = spawnBase;
                //     __instance.BornDirBaseInfo = BornDirBaseInfo;
                // }

                __instance.BulletWave = 2;
            }
            if (NotifyParam.Animation != null && NotifyParam.owner != null && player.PathName == NotifyParam.owner.PathName)
            {


                var linkValue = NotifyParam.AnimNotifyEvent_LinkValue;
                Console.WriteLine($"BANS_GSSpawnBullets.NotifyParam: PathName：{NotifyParam.owner.PathName}，GetName：{NotifyParam.owner.GetName()} ,linkValue:{linkValue} ");

                var allRules = GetCachedAnimRules();
                if (allRules == null || allRules.Count == 0) return; // 如果获取规则失败，则直接返回
                var nowMontage = NotifyParam.Animation.PathName;
                var fname = NotifyParam.Animation.GetFName();

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

    public static void logNotifyTrack(UAnimMontage Montage)
    {



        TArrayUnsafe<FAnimNotifyEvent> AnimNotifyEventList = new TArrayUnsafe<FAnimNotifyEvent>();
        UGSE_AnimFuncLib.GetAllNotifyEvent(Montage, AnimNotifyEventList);
        if (!(AnimNotifyEventList != null && AnimNotifyEventList.Count > 0))
        {
            return;
        }

        if (AnimNotifyEventList?.Count > 0)
        {
            var itemFirst = AnimNotifyEventList.FirstOrDefault(item =>
            item.NotifyStateClass is BANS_GSAddBuffByID);
            var itemNew = new FAnimNotifyEvent();


            // 复制所有属性
            itemNew.LinkedMontage = itemFirst.LinkedMontage;
            itemNew.SlotIndex = itemFirst.SlotIndex;
            itemNew.SegmentIndex = itemFirst.SegmentIndex;
            itemNew.LinkMethod = itemFirst.LinkMethod;
            itemNew.CachedLinkMethod = itemFirst.CachedLinkMethod;
            itemNew.SegmentBeginTime = itemFirst.SegmentBeginTime;
            itemNew.SegmentLength = itemFirst.SegmentLength;
            itemNew.LinkValue = 0.1f;
            itemNew.LinkedSequence = itemFirst.LinkedSequence;
            itemNew.TriggerTimeOffset = 0;
            itemNew.EndTriggerTimeOffset = 0;
            // var NotifyStateClass = UClass.GetClass<BANS_GSAddBuffByID>();
            UObject NotifyStateClass = UObject.NewObject<BANS_GSAddBuffByID>(
                      Montage,
                      FName.None,
                      EObjectFlags.Transactional,
                      null,
                      copyTransientsFromClassDefaults: false,
                      (IntPtr)0
                  );
            if (NotifyStateClass is BANS_GSAddBuffByID bANS_GSAddBuffByID2)
            {
                bANS_GSAddBuffByID2.BuffID = 119;
                itemNew.NotifyStateClass = bANS_GSAddBuffByID2;
            }



            itemNew.Duration = 0.15f;
            itemNew.ConvertedFromBranchingPoint = itemFirst.ConvertedFromBranchingPoint;
            itemNew.MontageTickType = itemFirst.MontageTickType;
            itemNew.NotifyTriggerChance = itemFirst.NotifyTriggerChance;
            itemNew.NotifyFilterType = itemFirst.NotifyFilterType;
            itemNew.NotifyFilterLOD = itemFirst.NotifyFilterLOD;
            itemNew.TriggerOnDedicatedServer = itemFirst.TriggerOnDedicatedServer;
            itemNew.TriggerOnFollower = itemFirst.TriggerOnFollower;
            itemNew.NotifyColor = itemFirst.NotifyColor;
            itemNew.Guid = itemFirst.Guid;

            bool notifyExists = AnimNotifyEventList.Any(existing =>
       existing.NotifyStateClass is BANS_GSAddBuffByID existingBuff &&
       itemNew.NotifyStateClass is BANS_GSAddBuffByID newBuff &&
       existingBuff.BuffID == newBuff.BuffID);

            // 设置新的TrackIndex为最大值+1
            // itemNew.TrackIndex = itemFirst.TrackIndex;
            itemNew.NotifyName = new FName("BANS_GSAddBuffByID");
            if (!notifyExists)
            {
                Helper.LogInfoOnce($"添加通知: {itemNew.TrackIndex}");
                AnimNotifyEventList.Add(itemNew);
            }

        }

    }

    public static void CreateAndConfigureBuffByID(UAnimMontage AnimMontage, int BuffID, float StartTime)
    {

        var notifyClass = UClass.GetClass<BANS_GSAddBuffByID>();

        UAnimNotify uObject = UGSE_AnimFuncLib.AddAnimationNotifyEvent(AnimMontage, new FName("BANS_GSAddBuffByID"), StartTime, notifyClass);

        if (uObject != null)
        {
            Helper.LogInfoOnce($"添加通知 uObject:{uObject.GetFullName()}");
        }
        // UObject uObject = UObject.NewObject<BANS_GSAddBuffByID>(
        //     AnimMontage,
        //     FName.None,
        //     EObjectFlags.Transactional,
        //     null,
        //     copyTransientsFromClassDefaults: false,
        //     (IntPtr)0
        // );

        // if (uObject is BANS_GSAddBuffByID bANS_GSAddBuffByID2)
        // {
        //     bANS_GSAddBuffByID2.BuffID = BuffID;
        //     bANS_GSAddBuffByID2.BuffLayer = 1;
        //     bANS_GSAddBuffByID2.UseBuffDescDuration = false;

        //     Helper.LogInfoOnce($"添加通知:{BuffID}");
        //     UBGUFunctionLibrary.AddBuffNotifyStates(AnimMontage, uObject, BuffID, dictionary);
        //     return bANS_GSAddBuffByID2;
        // }
        // return null;
    }
    private static readonly Dictionary<string, bool> ProcessedAnimCache = new Dictionary<string, bool>();

    public static void handleNotify(UAnimMontage Montage, AActor player, LoadSkill.MontageConfig config)
    {
        if (!!Helper.is_bian_mod_stop)
        {
            return;
        }
        try
        {
            if (Montage == null || Montage?.PathName == null)
            {
                return;
            }

            if (ProcessedAnimCache.ContainsKey(Montage.PathName))
            {
                return;
            }
            // logNotifyTrack(Montage);
            TArrayUnsafe<FAnimNotifyEvent> AnimNotifyEventList = new TArrayUnsafe<FAnimNotifyEvent>();
            UGSE_AnimFuncLib.GetAllNotifyEvent(Montage, AnimNotifyEventList);
            if (!(AnimNotifyEventList != null && AnimNotifyEventList.Count > 0))
            {
                return;
            }

            // CreateAndConfigureBuffByID(Montage, 295, 0.1f);

            if (config == null)
            {

                return;
            }
            ;
            var addRadius = 100;
            var hitEffects = new List<int>();
            float am_speed = 0;
            if (config.hitEffects != null && config.hitEffects.Count > 0)
            {
                hitEffects.AddRange(config.hitEffects);
            }
            if (config.AMSpeedRate != null && config.AMSpeedRate > 0)
            {
                am_speed = (float)config.AMSpeedRate;
            }
            if (config.addRadius != null && config.addRadius > 0)
            {
                addRadius = (int)config.addRadius;
            }
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
            Log.Info($"修改Notify，给异常 handleNotify: {Montage.PathName}，Count：{AnimNotifyEventList.Count} ,addRadius:{addRadius} ,hitEffects:{hitEffects.Count} ,am_speed:{am_speed} ");
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
                        if (config?.replaceEffects == true)
                        {
                            sweepCheck.EffectIDList.Clear();
                        }
                        foreach (var hitEffect in hitEffects)
                        {
                            sweepCheck.EffectIDList.Add(hitEffect);
                        }
                    }



                    // 创建异常状态配置映射
                    var abnormalStateConfigs = new Dictionary<int, EAbnormalStateType>
                    {
                        { BuffElementIds.Ice, EAbnormalStateType.Abnormal_Freeze },  // 冰
                        { BuffElementIds.Fire, EAbnormalStateType.Abnormal_Burn },    // 火
                        { BuffElementIds.Poison, EAbnormalStateType.Abnormal_Poison },  // 毒
                        { BuffElementIds.Thunder, EAbnormalStateType.Abnormal_Thunder } // 雷
                    };

                    // 创建异常状态效果列表
                    // var AbnormalStateEffectList = sweepCheck.AbnormalStateEffectList;

                    // 为每个buff ID创建对应的配置
                    foreach (var kvp in abnormalStateConfigs)
                    {
                        var abnormalCondition = new FTriggerAbnormalCondition
                        {
                            Conditions = new List<FDetectCondition>
                            {
                                new FDetectCondition
                                {
                                    DetectedElementType = EDetectedElementType.HasBuff,
                                    BuffId = kvp.Key
                                }
                            }
                        };
                        var abnormalItem = new AbnormalStateAccConfig
                        {
                            Condition = abnormalCondition,
                            AbnormalStateType = kvp.Value,
                            Level = 1,
                            AccType = EAccAbnormalValueType.IncreaseByValue
                        };

                        // 检查是否已存在相同BuffId的异常状态效果
                        var hasExistingEffect = sweepCheck.AbnormalStateEffectList.Any(x =>
     x.Condition.Conditions.Any(c => c.BuffId == kvp.Key));
                        if (!hasExistingEffect)
                        {
                            sweepCheck.AbnormalStateEffectList.Add(abnormalItem);
                        }

                    }



                }
                else if (item.NotifyName == new FName("BANS_GSCalcAMScale"))
                {
                    var AMScaleRate = 8f;
                    if (config != null && config.AMScaleRate > 0)
                    {
                        AMScaleRate = (float)config.AMScaleRate;
                    }
                    // 获取当前属性值
                    var currentValue = BANS_GSCalcAMScaleHelper.GetProperty(item.NotifyStateClass, "AMScaleMaxRate");
                    var AMScaleMoveOffset = BANS_GSCalcAMScaleHelper.GetProperty(item.NotifyStateClass, "AMScaleMoveOffset");

                    // 只有当当前值小于10时才修改为10
                    if ((float)currentValue < AMScaleRate || config?.AMScaleRate > 0)
                    {
                        var AMScaleItem = item.NotifyStateClass;
                        BANS_GSCalcAMScaleHelper.SetProperty(item.NotifyStateClass, "AMScaleMaxRate", AMScaleRate);
                    }
                    if ((float)AMScaleMoveOffset >= -800 && (float)AMScaleMoveOffset <= -10)
                    {
                        var AMScaleItem = item.NotifyStateClass;
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



    private static bool IsPlayer(string name)
    {
        if (name == null) return false;

        var player = Helper.GetBGUPlayerCharacterCS();
        if (player == null) return false;
        if (name == player.PathName)
        {
            return true;
        }
        return false;
    }

    [HarmonyPatch]
    public class HookTriggerSkillEffect
    {
        private static readonly Dictionary<int, DateTime> _lastTriggerTimes = new Dictionary<int, DateTime>();


        [HarmonyPatch(typeof(GSDel_TriggerSkillEffect), "Invoke")]
        [HarmonyPrefix]
        private static void Prefix(int EffectID, FEffectInstReq EffectInstReq, AActor InnerTarget, bool bWithRPCEvent)
        {
            if (!!Helper.is_bian_mod_stop)
            {
                return;
            }
            var Caster = EffectInstReq.Attacker;
            if (Caster == null || (!IsPlayer(Caster.PathName) && !Caster.PathName.Contains("TAMER_player_tornado")))
            {
                return;
            }


            Helper.LogInfoOnce($"Evt_TriggerSkillEffect EffectID:{EffectID},ObjectID:{EffectInstReq.ObjectID}");
            var Target = InnerTarget;

            var effectRulesMap_new = LoadSkill.EffectRules;
            if (!(effectRulesMap_new == null || !effectRulesMap_new.ContainsKey(EffectID)))
            {
                var matchingRules_new = effectRulesMap_new.FirstOrDefault(rule => rule.Key == EffectID);
                if (matchingRules_new.Value.Count > 0)
                {
                    var rule = new Rule();
                    foreach (var ruleItem in matchingRules_new.Value)
                    {
                        ruleItem.Caster = Caster;
                        ruleItem.Target = Target;
                        ruleItem.EffectInstReq = EffectInstReq;
                    }
                    rule.DoAfterActions(matchingRules_new.Value);
                    return;
                }
            }


            var effectRulesMap = Manager.effectRulesMap;
            // 检查是否有对应的效果规则
            if (!effectRulesMap.ContainsKey(EffectID))
            {

                return;
            }
            var currentTime = DateTime.Now;
            // 检查该效果ID是否在0.2秒内已经触发过
            if (_lastTriggerTimes.TryGetValue(EffectID, out var lastTime))
            {
                if ((currentTime - lastTime).TotalMilliseconds < 100)
                {
                    return; // 距离上次触发不足0.1秒，跳过本次触发
                }
            }
            // 更新最后触发时间
            _lastTriggerTimes[EffectID] = currentTime;
            // 获取对应效果的所有规则
            var matchingRules = effectRulesMap[EffectID];
            foreach (var ruleItem in matchingRules)
            {
                ruleItem.Caster = Caster;
                ruleItem.Target = Target;
                ruleItem.EffectInstReq = EffectInstReq;
                ruleItem.DoRule(1000, 1, null, ruleItem);
            }
        }
    }

    // 通用的buff互斥处理方法
    private static void HandleBuffMutex(AActor caster, int currentBuffId, List<int> mutexBuffIds)
    {
        foreach (var buffId in mutexBuffIds.Where(id => id != currentBuffId))
        {
            BGUFunctionLibraryCS.BGURemoveBuffImmediately(caster, buffId, EBuffEffectTriggerType.Remove);
        }
    }

    // 调息触发
    private static readonly int[] tiaoxiBuffIds = { 1008, 1011, 306, 404 };
    // 在类的顶部定义数组
    private static readonly int[] SpecialBuffIds = { 1015, 2167, 604, 20986, 2030, 777666001, 777666002, 777666003, 777666004 };
    // 冰火雷毒buff互斥
    private static readonly List<int> buffers = [BuffElementIds.Thunder, BuffElementIds.Ice, BuffElementIds.Fire, BuffElementIds.Poison];

    private static readonly Dictionary<int, (int EffectType, int AbnormalType)> BuffEffectMappings = new()
    {
        { BuffElementIds.Ice, (5, 1) }, // 冰
        { BuffElementIds.Fire, (3, 2) }, // 火
        { BuffElementIds.Poison, (7, 3) }, // 毒
        { BuffElementIds.Thunder, (6, 4) }  // 雷
    };

    // 已知 3是火，
    public const int IceBaseValue = 5;    // 冰元素基础值
    public const int FireBaseValue = 3;   // 火元素基础值
    public const int PoisonBaseValue = 7; // 毒元素基础值
    public const int ThunderBaseValue = 6; // 雷元素基础值

    // 创建专门的处理方法
    public static void ApplyBuffEffect(AActor player, int? BuffID)
    {

        if (player == null) return;


        var baseValue = 1;//默认无效果
        if (BuffID > 0)
        {
            if (BuffID == BuffElementIds.Ice)
            {
                baseValue = IceBaseValue;
            }
            else if (BuffID == BuffElementIds.Fire)
            {
                baseValue = FireBaseValue;
            }
            else if (BuffID == BuffElementIds.Poison)
            {
                baseValue = PoisonBaseValue;
            }
            else if (BuffID == BuffElementIds.Thunder)
            {
                baseValue = ThunderBaseValue;
            }
        }
        else
        {
            if (BGUFunctionLibraryCS.BGUHasBuffByID(player, BuffElementIds.Ice))
            {
                baseValue = IceBaseValue;
            }
            else if (BGUFunctionLibraryCS.BGUHasBuffByID(player, BuffElementIds.Fire))
            {
                baseValue = FireBaseValue;
            }
            else if (BGUFunctionLibraryCS.BGUHasBuffByID(player, BuffElementIds.Poison))
            {
                baseValue = PoisonBaseValue;
            }
            else if (BGUFunctionLibraryCS.BGUHasBuffByID(player, BuffElementIds.Thunder))
            {
                baseValue = ThunderBaseValue;
            }
            else
            {
                baseValue = 1;
            }
        }

        var passiveData = BGW_GameDB.GetPassiveSkillDescByMappingIndex(16039, 1);//火被动
        if (passiveData != null)
        {
            passiveData.BaseValue = baseValue;
            passiveData.MainID = "1080101,1080201,1080301,1080401,1080402,1080501,1075101,1075201,1075301,1075401,1075402,1075501,1070001,1070101,1070201,1070202,1070301,1070401,5001101,5001201,5001301,5001401,5001402,5001501,5000101,5000201,5000301,5000302,5000401,5000501,5000601,5000602,5000801";
        }
        BUS_EventCollectionCS.Get(player)?.Evt_PassiveSkillModifyParam.Invoke(16039, 1, bRecover: false, 1);

    }


    [HarmonyPatch]
    public class HookBuffAdd
    {
        private static MethodBase TargetMethod()
        {
            return AccessTools.Method("b1.BUS_BuffComp:BuffBegin", (Type[])null, (Type[])null);
        }

        [HarmonyPatch]
        private static void Prefix(ref int BuffID, AActor Caster, AActor RootCaster, ref float Duration)
        {
            if (!!Helper.is_bian_mod_stop)
            {
                return;
            }

            if (Caster == null || !IsPlayer(Caster?.PathName))
            {
                return;
            }
            //  if (tiaoxiBuffIds.Contains(BuffID))
            // {
            //     ShowPlayerInfo.ClearAllUI();
            // }
            // 修改判断逻辑
            if (!SpecialBuffIds.Contains(BuffID))
            {

                Helper.LogInfoOnce($"Evt_BuffAdd BuffID:{BuffID}");
            }


            if (buffers.Contains(BuffID))
            {
                // ApplyBuffEffect(Caster, BuffID);
                HandleBuffMutex(Caster, BuffID, buffers);
            }

            // 棍光 buff互斥
            List<int> gun_buffers = [66655401, 66655402, 66655403, 66655404, 66655405, 66655406, 66655407, 66655408, 555503209];
            if (gun_buffers.Contains(BuffID))
            {

                HandleBuffMutex(Caster, BuffID, gun_buffers);
            }


            // 检查是否有对应的buff规则
            var buffRulesMap_new = LoadSkill.BuffRules;
            if (buffRulesMap_new != null && buffRulesMap_new.ContainsKey(BuffID))
            {
                var matchingRules_new = buffRulesMap_new[BuffID];
                if (matchingRules_new != null && matchingRules_new.Count > 0)
                {
                    var rule = new Rule();
                    rule.DoAfterActions(matchingRules_new);
                    return;
                }
            }
            var buffRulesMap_ = Manager.buffRulesMap;
            // 检查是否有对应的buff规则
            if (!buffRulesMap_.ContainsKey(BuffID))
            {
                return;
            }
            // 获取对应buff的所有规则
            var matchingRules = buffRulesMap_[BuffID];
            foreach (var ruleItem in matchingRules)
            {
                var Duration_ = Duration > 0 ? Duration : 1000;
                ruleItem.DoRule(Duration_, 1, null, ruleItem);
            }
        }
    }



    public static string? getPlayerActiveMontage()
    {
        var character = Helper.GetBGUPlayerCharacterCS();
        if (character == null) return null;
        var animInstance = character.Mesh?.GetAnimInstance();
        if (animInstance == null) return null;

        var currentMontage = animInstance.GetCurrentActiveMontage();
        if (currentMontage == null || currentMontage.PathName == null) return null;
        return currentMontage.PathName;
    }


    public static List<string> playMontageList = new List<string>();

    public static void InsertMontageReversed(string montagePath)
    {
        if (!string.IsNullOrEmpty(montagePath))
        {
            playMontageList.Insert(0, montagePath);
            // 保持列表长度在合理范围内
            if (playMontageList.Count > 5)
            {
                playMontageList.RemoveAt(playMontageList.Count - 1);
            }
        }
    }

    [HarmonyPatch]
    public static class CastSkillPatch
    {
        [HarmonyPatch(typeof(BUS_MovementSystem), "OnSkillWithAnimMontage")]
        [HarmonyPrefix]
        static void Prefix(BUS_MovementSystem __instance, UAnimMontage Montage, ref float PlayTimeRate, float MontagePosOffset, FName StartSectionName, EMontageBindReason Reason)
        {
            if (!!Helper.is_bian_mod_stop)
            {
                return;
            }

            if (__instance == null || Montage == null) return;
            if (__instance?.GetOwner() == null) return;
            if (__instance.GetOwner()?.PathName == null) return;
            if (!IsPlayer(__instance.GetOwner().PathName))
            {
                return;
            }
            var currentMontage = Montage.PathName;
            if (currentMontage == null) return;



            Helper.LogInfoOnce($"Evt_CastSkillAnime Montage:{Montage.GetName()}");
            InsertMontageReversed(currentMontage);

            if (currentMontage.Contains("Animation/Player/Wukong/") || currentMontage.Contains("AM_wukong_trans_from_Vigor"))
            {
                Helper.updateIsPlayVigorSkillByID(false);
            }
            var rulesMap = LoadSkill.TemplatePathConfigs;
            if (rulesMap == null) return;

            var config = getNewConfig(currentMontage) ?? getOldConfig(currentMontage);

            if (config == null)
            {
                config = new LoadSkill.MontageConfig();
            }
            PlayTimeRate = config.speedRate != null ? (float)config.speedRate : PlayTimeRate;

            if (config.scaleWeaponNum != null)
            {
                Manager.OnScaleWeapon((float)config.scaleWeaponNum);
            }

            handleNotify(Montage, __instance.GetOwner(), config);
        }
    }
    public static LoadSkill.MontageConfig? getOldConfig(string PathName)
    {
        var allRules = GetCachedAnimRules();
        if (allRules == null || allRules.Count == 0) return null;
        var strPathName = PathName.ToString();

        // // 替换原有的硬编码判断逻辑
        var configRules = allRules.FirstOrDefault(c => strPathName.Contains(c.montage));
        if (configRules == null) return null;
        var config = new LoadSkill.MontageConfig();
        config.hitEffects = configRules.hitEffects;
        config.addRadius = configRules.addRadius;
        config.AMSpeedRate = configRules.AMSpeedRate;
        config.replaceEffects = configRules.replaceEffects;
        return config;
    }
    public static LoadSkill.MontageConfig? getNewConfig(string PathName)
    {

        var rulesMap = LoadSkill.TemplatePathConfigs;
        if (rulesMap == null) return null;
        var str = $"AnimMontage'{PathName}'";
        if (!rulesMap.TryGetValue(str, out var matchedRule)) return null;
        if (matchedRule == null || matchedRule.montage_config == null)
        {
            return null;
        }
        return matchedRule.montage_config;
    }

    private static bool TryGetCharacterStance(out bool isChuogun, out bool isLigun, out bool isPigun)
    {
        isChuogun = false;
        isLigun = false;
        isPigun = false;

        var control = Helper.GetPlayerController();
        var readOnlyData = BGU_DataUtil.GetPlayerControlReadonlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(control);
        if (readOnlyData?.RoleData?.RoleCs?.Actor?.Wear?.Stance == null)
        {
            return false;
        }

        var stance = readOnlyData.RoleData.RoleCs.Actor.Wear.Stance;
        isChuogun = stance == Stance.Poke;
        isLigun = stance == Stance.Prop;
        isPigun = stance == Stance.Heavy;

        return true;
    }

    private static Dictionary<int, int> GetSkillMappings()
    {
        return new Dictionary<int, int>
                {
                    {10720, 10721},
                    {10725, 50010724},
                    {10724, 50010724},
                    {10706, 10705},
                    {10708, 50002},
                    {10707, 50002},
                    {10715, 10714}
                };
    }

    private static bool IsComboSkill(int skillId)
    {
        int[] comboSkills = { 10705, 10706, 10720, 10721, 50001, 50003, 50005, 50007 };
        return comboSkills.Contains(skillId);
    }
    private static void ProcessSkillMappingRules(ref int ID, int currentId, BGUCharacterCS character,
            bool isChuogun, bool isLigun, bool isPigun)
    {
        var AllSkillMappingRules = Manager.AllSkillMappingRules;
        var mapArr = AllSkillMappingRules.Where(r => r.OriginalId == currentId).ToList();
        if (!mapArr.Any()) return;

        var target = BGUFunctionLibraryCS.BGUGetTarget(character) as BGUCharacterCS;

        // 优先处理可重复规则
        var repeatableRules = mapArr.Where(r => r.canRepeat.HasValue && r.canRepeat.Value).ToList();
        var matchItem = repeatableRules.FirstOrDefault(r =>
            Manager.IsSkillMappingRuleMatch(r, character, isChuogun, isLigun, isPigun, target));

        if (matchItem != null)
        {
            ID = matchItem.MappedId;
            currentId = matchItem.MappedId;
        }

        // 处理不可重复规则
        var nonRepeatableRules = AllSkillMappingRules
            .Where(r => r.OriginalId == currentId && (!r.canRepeat.HasValue || !r.canRepeat.Value))
            .ToList();

        var matchItem_ = nonRepeatableRules.FirstOrDefault(r =>
            Manager.IsSkillMappingRuleMatch(r, character, isChuogun, isLigun, isPigun, target));

        if (matchItem_ != null)
        {
            ID = matchItem_.MappedId;
        }
    }

    [HarmonyPatch]
    public static class RequestSmartCastSkillPatch
    {
        [HarmonyPatch(typeof(GSDel_RequestSmartCastSkill), "Invoke")]
        [HarmonyPrefix]
        static void Prefix(ref int ID, List<int> RuleIDList, EMontageBindReason Reason, bool bNeedCheckSkillCanCast, ECastSkillSourceType SourceType)
        {
            if (!!Helper.is_bian_mod_stop)
            {
                return;
            }

            // 获取角色姿态信息
            if (!TryGetCharacterStance(out bool isChuogun, out bool isLigun, out bool isPigun))
            {
                return;
            }

            // 获取技能ID映射配置
            var skillMappings = GetSkillMappings();

            // 应用技能ID映射
            if (skillMappings.ContainsKey(ID))
            {
                ID = skillMappings[ID];
            }

            var currentId = ID;
            var character = Helper.GetBGUPlayerCharacterCS();
            if (character == null) return;

            Log.Info($"CastSkill skillId:{ID}");
            // 添加连招相关buff
            if (IsComboSkill(ID))
            {

                BGUFunctionLibraryCS.BGUAddBuff(character, character, 289, EBuffSourceType.GM, 6000);
            }

            // 处理技能映射规则
            ProcessSkillMappingRules(ref ID, currentId, character, isChuogun, isLigun, isPigun);
        }
    }

    [HarmonyPatch]
    public static class DSShopPatch
    {
        [HarmonyPatch(typeof(DSShop), "CalBuyStat")]
        static bool Prefix(ref DSShop.ECheckBuyStat __result)
        {
            if (!Helper.is_bian_mod_stop)
            {
                __result = DSShop.ECheckBuyStat.CanBuy;
                return false; // 跳过原始方法的执行
            }
            return true;
        }

        // [HarmonyPatch(typeof(DSShop), "CanBuyMinValue")]
        // [HarmonyPrefix]
        // static bool Prefix(ref int __result)
        // {
        //     if (!Helper.is_bian_mod_stop)
        //     {
        //         __result = 99;
        //     }
        //     return false; // 跳过原始方法的执行
        // }


        [HarmonyPatch(typeof(DSShop), "GetIsCanSell")]
        [HarmonyPrefix]
        static bool Prefix(ref bool __result)
        {
            if (!!Helper.is_bian_mod_stop)
            {
                return true;
            }
            __result = true;
            return false; // 跳过原始方法的执行
        }

    }



    [HarmonyPatch]
    public static class RefreshShopGoods_Patch
    {
        [HarmonyPatch(typeof(PlayerShop), "RefreshShopGoods")]
        static void Prefix(ShopItemDesc ShopItemDesc, int TargetShopId, ref int AddGoodsNum)
        {
            if (!!Helper.is_bian_mod_stop)
            {
                return;
            }
            AddGoodsNum = 99;
        }

        [HarmonyPatch(typeof(PlayerShop), "BuyShopItem")]
        public static void Prefix(ref int ShopId, ref int GoodsId, ref int BuyNum, ref bool CheckLimit)
        {
            if (!!Helper.is_bian_mod_stop)
            {
                return;
            }
            CheckLimit = false;
        }
    }




    [HarmonyPatch]
    public static class showDamUI_Patch
    {
        [HarmonyPatch(typeof(BUS_BeAttackedComp), "CanShowDmgNumUI")]
        static bool Prefix(ref bool __result, AActor AttackerMasterActor, bool HasCausedDamage, in FBattleAttrSnapShot Attacker_AttrMemData, bool AttackerIsPlayer_ForDmgNumber)
        {
            // 检查AttackerMasterActor是否存在且TeamID为1
            if (!!Helper.is_bian_mod_stop)
            {
                return true;
            }
            if (AttackerMasterActor.IsNullOrDestroyed())
            {
                return false;
            }
            if (!HasCausedDamage)
            {
                return false;
            }
            if (GSGameplayCVar.CVar_B1ShowDamageNumber.GetValueInGameThread() == 0)
            {
                return false;
            }

            BGUCharacterCS character = (BGUCharacterCS)AttackerMasterActor;
            var player = Helper.GetBGUPlayerCharacterCS();
            if (character.GetTeamIDInCS() == player.GetTeamIDInCS())
            {
                __result = true;
                return false; // 不执行原方法
            }
            return true;
        }
    }





    public static readonly List<int> SkillEffectsIds = new List<int> {
    1080101,1080201,1080301,1080401,1080402,1080501,
    1075101,1075201,1075301,1075401,1075402,1075501,
    1070001,1070101,1070201,1070202,1070301,1070401,
    5001101,5001201,5001301,5001401,5001402,5001501,
    5000101,5000201,5000301,5000302,5000401,5000501,
    5000601,5000602,5000801
};

    private static readonly int[] ReflectBuffIds = { 20234, 229, 288, 294, 10133, 96036, 24082 };

    [HarmonyPatch]
    public static class BeAttackedTeamCheckPatch
    {
        [HarmonyPatch(typeof(BUS_BeAttackedComp), "OnHandleNormalDamageEffect")]
        private static bool Prefix(BUS_BeAttackedComp __instance, AActor Attacker, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq, in FBattleAttrSnapShot Attacker_AttrMemData)
        {

            if (!!Helper.is_bian_mod_stop)
            {
                return true;
            }
            // 获取攻击者和受击者的团队ID
            var attacker = Attacker as BGUCharacterCS;
            var attackerTeamId = attacker?.GetTeamIDInCS();
            var victim = __instance.GetOwner() as BGUCharacterCS;
            var victimTeamId = victim?.GetTeamIDInCS();
            var playerTeamID = Helper.GetBGUPlayerCharacterCS()?.GetTeamIDInCS();
            // 如果是同一阵营，跳过伤害计算

            if (attackerTeamId == victimTeamId && victimTeamId == playerTeamID)
            {
                return false; // 跳过原始方法的执行
            }
            if (Attacker != null && victim != null && attackerTeamId == playerTeamID)
            {

                int dmgReasonEffectID = SkillDamageConfig.DmgReasonEffectID > 0 ? SkillDamageConfig.DmgReasonEffectID : EffectInstReq.ObjectID;
                FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(dmgReasonEffectID, Attacker);


                if (skillEffectDesc != null)
                {
                    if (BGUFunctionLibraryCS.BGUHasBuffByID(Attacker, BuffElementIds.Fire))
                    {
                        Helper.AttackFeedbackPerform("BGWDataAsset_B1DBC'/Game/00Main/VFX/Common/Niagara/Hit/Abnormal/DBC/DBC_NG_Abnormal_Hit_Fire.DBC_NG_Abnormal_Hit_Fire'", victim, dmgReasonEffectID, EffectInstReq);
                    }
                    else if (BGUFunctionLibraryCS.BGUHasBuffByID(Attacker, BuffElementIds.Ice))
                    {
                        Helper.AttackFeedbackPerform("BGWDataAsset_B1DBC'/Game/00Main/VFX/Common/Niagara/Hit/Abnormal/DBC/DBC_NG_Abnormal_Hit_Frozen.DBC_NG_Abnormal_Hit_Frozen'", victim, dmgReasonEffectID, EffectInstReq);
                    }
                    else if (BGUFunctionLibraryCS.BGUHasBuffByID(Attacker, BuffElementIds.Thunder))
                    {
                        Helper.AttackFeedbackPerform("BGWDataAsset_B1DBC'/Game/00Main/VFX/Common/Niagara/Hit/Abnormal/DBC/DBC_NG_Abnormal_Hit_Lightning_Blue.DBC_NG_Abnormal_Hit_Lightning_Blue'", victim, dmgReasonEffectID, EffectInstReq);
                    }
                    else if (BGUFunctionLibraryCS.BGUHasBuffByID(Attacker, BuffElementIds.Poison))
                    {
                        Helper.AttackFeedbackPerform("BGWDataAsset_B1DBC'/Game/00Main/VFX/Common/Niagara/Hit/Abnormal/DBC/DBC_NG_Abnormal_Hit_Poisoning_Green.DBC_NG_Abnormal_Hit_Poisoning_Green'", victim, dmgReasonEffectID, EffectInstReq);
                    }
                }

                // Helper.AttackFeedbackPerform()
                // var buffRulesMap = Manager.buffRulesMap;


                // if (skillEffectDesc != null && SkillEffectsIds.Contains(dmgReasonEffectID))
                // {
                //     var SkillDamageType = (ESkillDamageType)skillEffectDesc.EffectParamsInt[2];
                //     List<Rule>? matchingRules = null;
                //     switch (SkillDamageType)
                //     {
                //         case ESkillDamageType.FreezeAtk:
                //             buffRulesMap.TryGetValue(BuffElementIds.Ice, out matchingRules);
                //             break;
                //         case ESkillDamageType.PoisonAtk:
                //             buffRulesMap.TryGetValue(BuffElementIds.Poison, out matchingRules);
                //             break;

                //         case ESkillDamageType.BurnAtk:
                //             buffRulesMap.TryGetValue(BuffElementIds.Fire, out matchingRules);


                //             break;
                //         case ESkillDamageType.LightningAtk:
                //             buffRulesMap.TryGetValue(BuffElementIds.Thunder, out matchingRules);

                //             break;
                //         default:
                //             break;
                //     }

                //     if (matchingRules != null && matchingRules.Count > 0)
                //     {
                //         foreach (var ruleItem in matchingRules)
                //         {
                //             ruleItem.Caster = attacker;
                //             ruleItem.Target = victim;
                //             ruleItem.EffectInstReq = EffectInstReq;
                //             ruleItem.DoRule(1000, 1, null, ruleItem);
                //         }
                //     }

                //     return true;
                // }
            }

            if (victimTeamId == playerTeamID && Attacker != null)
            {

                var SkillDamageConfig_ = SkillDamageConfig;
                var EffectInstReq_ = EffectInstReq;
                var Attacker_AttrMemData_ = Attacker_AttrMemData;
                if (EffectInstReq_.Attacker != null)
                {
                    EffectInstReq_.Attacker = victim;
                }
                // 20234,229
                if (Attacker != null && ReflectBuffIds.Any(id => BGUFunctionLibraryCS.BGUHasBuffByID(victim, id)))
                {
                    BUS_EventCollectionCS.Get(Attacker)?.Evt_TriggerNormalDamageEffect?.Invoke(victim, in SkillDamageConfig_, in EffectInstReq_, in Attacker_AttrMemData_);
                }

            }

            return true; // 继续执行原始方法
        }

    }



    [HarmonyPatch]
    public static class BGUEnvironmentSurfaceEffectMgrPatch
    {
        [HarmonyPatch(typeof(BGUEnvironmentSurfaceEffectMgr), "DoesTargetPassFilter")]
        private static bool Prefix(int Filter, AActor Target, ref bool __result)
        {
            if (!!Helper.is_bian_mod_stop)
            {
                return true;
            }
            IBUC_ActorBasicData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_ActorBasicData, BUC_ActorBasicData>(Target);
            if (readOnlyData != null)
            {
                __result = true;
                return false;
            }
            return true; // 继续执行原始方法
        }
    }




    [HarmonyPatch]
    public static class BUS_AbnormalStateCompImplPatch
    {
        [HarmonyPatch(typeof(BUS_AbnormalStateCompImpl), "OnTriggerFrozen")]
        private static bool Prefix(BUS_AbnormalStateCompImpl __instance)
        {
            if (!!Helper.is_bian_mod_stop)
            {
                return true;
            }
            var owner = __instance.GetOwner() as BGUCharacterCS;
            if (owner == null) return true; // 如果没有owner，继续执行原始逻辑
            bool isPlayer = owner.GetTeamIDInCS() == Helper.GetBGUPlayerCharacterCS().GetTeamIDInCS();
            return !isPlayer; // 玩家返回false(跳过)，非玩家返回true(执行)
        }

    }

    private struct FDamageDynamicParam
    {
        public float HitWeight;

        public int StiffLevel;

        public int HitPartID;

        public BGWDataAsset_UnitBeAttackedConfig NowUseUBAConfig;

        public EAttackerArea AttackerArea;
    }

    private struct FDamageDescParam
    {
        public int HitVEffectID;

        public int AttackStiffEffectID;

        public ESkillDamageType SkillDamageType;

        public float HitWeight;

        public float BaseDamage;

        public int SpecialHitPartID;

        public float PartDamage;

        public float BaseDamageRatio;

        public float SkillArmorHit;

        public float BlockArmorHit;

        public float ImmobilizeHit;

        public bool bIgnoreBeAttacked;

        public float CritRateAddition;

        public float CritDamageAddition;

        public float HPMaxINV10000Damage_Element;

        public bool bCanTriggerFX;

        public bool bCanTriggerFightBackCounter;

        public EAbnormalStateType ElemAtkType;

        public float TargetCurHpRatio;

        public int ElementDmgLevel;

        public float HPMaxINV10000Damage_Abs;

        public bool BreakFrozenImmediatelyFlag;
    }
    [HarmonyPatch(typeof(BUS_BeAttackedComp), "DoDmg_B1_V2")]
    public class BUS_BeAttackedComp_DoDmg_B1_V2_Patch
    {
        private static void Postfix(
            BUS_BeAttackedComp __instance,
             AActor Attacker,
        bool IsCrit,
        float DmgNoiseMul,
        in FDamageDynamicParam DamageDynamicParam,
        in FDamageDescParam DamageDescParam,
        in FSkillDamageConfig SkillDamageConfig,
        in FBattleAttrSnapShot Attacker_AttrMemData,
        ref float FinalDamageValue,
        ref float FinalDmgForPart,
        ref float FinalElementDmgValue,
        bool bPrintLog = true)
        {
            if (!!Helper.is_bian_mod_stop)
            {
                return;
            }
            // 在这里修改返回值
            var owner = __instance.GetOwner() as BGUCharacterCS;
            var player = Helper.GetBGUPlayerCharacterCS();
            var AttackerPlayer = Attacker as BGUCharacterCS;
            if (owner != null && player != null && owner.GetTeamIDInCS() == player.GetTeamIDInCS())
            {
                if (FinalDamageValue > 1)
                {
                    if (owner.PathName == player.PathName)
                    {
                        float def = BGUFunctionLibraryCS.GetAttrValue(player, EBGUAttrFloat.Def);
                        FinalDamageValue = FinalDamageValue > def ? FinalDamageValue - def : 1;
                    }
                    else
                    {
                        // 这是队友
                        FinalDamageValue = FinalDamageValue * 0.5f;
                    }
                }
            }
            else if (AttackerPlayer != null && player != null && owner != null && AttackerPlayer.GetTeamIDInCS() == player.GetTeamIDInCS())
            {
                // 己方造成的伤害最少为目标的体力值/500
                float HpMax = BGUFunctionLibraryCS.GetAttrValue(owner, EBGUAttrFloat.HpMax);
                if (FinalDamageValue < HpMax / 500)
                {
                    FinalDamageValue = HpMax / 500;
                }
                if (FinalDamageValue < 100)
                {
                    FinalDamageValue = 100;
                }
            }
        }
    }




    [HarmonyPatch(typeof(BUS_PlayerInputActionComp), "OnCameraLockTarget")]
    public class OnCameraLockTarget_Patch
    {
        private static bool Prefix(BUS_PlayerInputActionComp __instance, UnitLockTargetInfo TargetInfo)
        {

            if (!!Helper.is_bian_mod_stop)
            {
                return true;
            }
            if (TargetInfo == null)
            {
                return false;
            }
            BGUCharacterCS lockTargetActor = TargetInfo.LockTargetActor as BGUCharacterCS;
            var owner = __instance.GetOwner() as BGUCharacterCS;
            var player = Helper.GetBGUPlayerCharacterCS();
            if (owner != null && lockTargetActor != null && player != null)
            {
                var nowTeamID = owner.GetTeamIDInCS();
                if (nowTeamID == player.GetTeamIDInCS() && nowTeamID == lockTargetActor.GetTeamIDInCS())
                {
                    return false;
                }
            }
            return true;

        }
    }






    [HarmonyPatch(typeof(BUS_AttrComp), "OnIncreaseFloatValue")]
    public static class BPS_PlayerTagSystemPatch
    {
        private static void Prefix(BUS_AttrComp __instance, ref EBGUAttrFloat AttrID, ref float IncreaseValue)
        {
            var owner = __instance.GetOwner() as BGUCharacterCS;
            if (owner != null)
            {
                var player = Helper.GetBGUPlayerCharacterCS();
                if (player != null && player.PathName == owner.PathName)
                {
                    ShowPlayerInfo.RenderBasicInfo();
                    if (AttrID == EBGUAttrFloat.CurEnergy || AttrID == EBGUAttrFloat.FabaoEnergy || AttrID == EBGUAttrFloat.VigorEnergy)
                    {
                        if (IncreaseValue < 0)
                        {
                            IncreaseValue = 1;
                        }
                    }
                }
            }
        }
    }

    [HarmonyPatch(typeof(BUS_AttrComp), "SetFloatValue")]
    public static class SetFloatValuePatch
    {
        private static void Prefix(BUS_AttrComp __instance)
        {
            var owner = __instance.GetOwner() as BGUCharacterCS;
            if (owner != null)
            {
                var player = Helper.GetBGUPlayerCharacterCS();
                if (player != null && player.PathName == owner.PathName)
                {
                    ShowPlayerInfo.RenderBasicInfo();
                }
            }
        }
    }





    [HarmonyPatch(typeof(BUS_SkillInstsCompSvr), "CastSkillOKAddBuff")]
    public static class CastSkillOKAddBuffPatch
    {
        private static void Prefix(BUS_SkillInstsCompSvr __instance, int SkillID)
        {
            var owner = __instance.GetOwner() as BGUCharacterCS;
            if (owner != null)
            {
                var player = Helper.GetBGUPlayerCharacterCS();
                if (player != null && player.PathName == owner.PathName)
                {

                    var rulesMap = LoadSkill.ActionsBySkillConfigs;
                    if (rulesMap != null && rulesMap.ContainsKey(SkillID))
                    {
                        if (!rulesMap.TryGetValue(SkillID, out var matchItem)) return;
                        if (matchItem != null && matchItem.cast_actions?.Count > 0)
                        {
                            Log.Info($"技能CastSkillOK：matchItem:{matchItem.cast_actions.Count}");
                            var rule = new Rule();
                            rule?.DoAfterActions(matchItem.cast_actions);
                        }
                    }
                    Log.Info($"释放技能开始 CastSkillOK：{SkillID}");
                }
            }
        }
    }

    [HarmonyPatch(typeof(BUS_SkillInstsCompSvr), "OnSkillCostDmg")]
    public static class BUS_SkillInstsCompSvrPatch
    {
        private static void Prefix(BUS_SkillInstsCompSvr __instance, AActor Victim, int SkillID, int FinalDmg, bool bIsCrit)
        {
            var owner = __instance.GetOwner() as BGUCharacterCS;
            if (owner != null)
            {
                var player = Helper.GetBGUPlayerCharacterCS();
                if (player != null && player.PathName == owner.PathName)
                {
                    var rulesMap = LoadSkill.ActionsBySkillConfigs;
                    if (rulesMap != null && rulesMap.ContainsKey(SkillID))
                    {
                        if (!rulesMap.TryGetValue(SkillID, out var matchItem)) return;
                        if (matchItem != null && matchItem?.dmg_actions?.Count > 0)
                        {
                            var rule = new Rule();
                            rule?.DoAfterActions(matchItem.dmg_actions);
                        }

                    }
                    BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(player);
                    if (bUS_GSEventCollection == null) return;
                    var num = (int)FinalDmg / 10;
                    if (num < 1) return;
                    bUS_GSEventCollection.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Shield, num);
                    bUS_GSEventCollection.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Hp, num);
                    bUS_GSEventCollection.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Mp, num);
                    bUS_GSEventCollection.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Stamina, num);
                    Log.Info($"技能造成伤害OnSkillCostDmg：SkillID:{SkillID},FinalDmg:{FinalDmg}");
                }
            }
        }
    }


    [HarmonyPatch(typeof(BUS_SkillInstsCompSvr), "OnSkillEnded")]
    public static class OnSkillEndedrPatch
    {
        private static bool Prefix(BUS_SkillInstsCompSvr __instance, int SkillID)
        {
            var owner = __instance.GetOwner() as BGUCharacterCS;
            if (owner == null) return true;
            var player = Helper.GetBGUPlayerCharacterCS();
            if (player == null) return true;
            if (player.PathName != owner.PathName) return true;

            // if (Helper.isPlayVigorSkillByID)
            // {
            //     Helper.ResetVigorSkillByID(player);
            // }
            var rulesMap = LoadSkill.ActionsBySkillConfigs;
            if (rulesMap == null || rulesMap.Count == 0) return true;
            if (!rulesMap.TryGetValue(SkillID, out var matchItem)) return true;

            if (matchItem == null || matchItem.end_actions?.Count == 0) return true;
            var rule = new Rule();
            if (rule == null) return true;
            rule.DoAfterActions(matchItem.end_actions);
            return true;
        }
    }
    // [HarmonyPatch(typeof(BUAVigorEnergy), "GetCostValue")]
    // public static class BUAVigorEnergyPatch
    // {
    //     private static void Postfix(BUAVigorEnergy __instance, ref (int, float) __result)
    //     {
    //         // 获取原始返回值
    //         float originalValue = __result.Item2;
    //         Helper.LogInfoOnce($"修改消耗消耗消耗消耗消耗消耗消耗值GetCostValue: {originalValue}");
    //         if ((float)originalValue > 2f)
    //         {
    //             // 修改返回值
    //             __result = (__result.Item1, 2f);
    //         }
    //     }
    // }


    [HarmonyPatch(typeof(BANS_GSAddBuffByID), "GSNotifyBeginCS_Implementation")]
    public static class BANS_GSAddBuffByID_Patch
    {
        [HarmonyPrefix]
        public static void Prefix_GSNotifyBeginCS_Implementation(
            BANS_GSAddBuffByID __instance,
            FUStGSNotifyParam NotifyParam,
            float TotalDuration)
        {
            // 获取当前实例的 BuffID
            int buffId = __instance.BuffID;

            Helper.LogInfoOnce($"添加buff的通知 BANS_GSAddBuffByID_Patch buffId: {buffId}, LinkValue:{NotifyParam.AnimNotifyEvent_LinkValue}");

        }
    }



    [HarmonyPatch(typeof(BUS_ProjectileBeAttackedComp), "OnProjectileBeHitted")]
    public static class BUS_ProjectileBeAttackedComp_Patch
    {
        [HarmonyPrefix]
        public static bool Prefix_GSNotifyBeginCS_Implementation(
            BUS_ProjectileBeAttackedComp __instance,
            AActor AttackerActor,
            List<int> HitEffectID)
        {


            BGUProjectileBaseActor bGUProjectileBaseActor = __instance.GetOwner() as BGUProjectileBaseActor;
            if (bGUProjectileBaseActor.IsNullOrDestroyed() || bGUProjectileBaseActor.IsDead())
            {
                return false;
            }

            AActor caster = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(bGUProjectileBaseActor)?.GetMasterActor();
            int projectileID = bGUProjectileBaseActor.GetProjectileID();
            if (caster != null && AttackerActor != null && caster.PathName == AttackerActor.PathName)
            {
                Helper.LogInfoOnce($"打中自己的子弹 OnProjectileBeHitted: {projectileID}");
                return false;
            }
            return true;
        }
    }
}