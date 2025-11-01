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
using BtlShare;
using b1.EventDelDefine;
using ArchiveB1;
using B1UI.GSUI;
using CommB1;
using ResB1;



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
                Console.WriteLine($"BANS_GSSweepCheck.NotifyParam: {NotifyParam.Animation.GetFName()} ,linkValue:{linkValue}");
                if (allRules?.Count > 0)
                {
                    var matchedRule = allRules.FirstOrDefault(rule =>
                        !string.IsNullOrEmpty(nowMontage) &&
                        nowMontage.Contains(rule.montage) &&
                        (rule?.linkValue == 0 || rule?.linkValue.ToString() == linkValue.ToString()));
                    if (matchedRule != null && matchedRule?.SweepActions?.Count > 0)
                    {

                        var rule = new Rule();
                        var method = typeof(Rule).GetMethod("DoAfterActions");
                        Log.Info($"do rule {matchedRule.montage}");
                        if (method == null)
                        {
                            Log.Info($"do rule no method");
                            return;
                        }

                        rule?.DoAfterActions(matchedRule.SweepActions);
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



    private static readonly Dictionary<string, bool> ProcessedAnimCache = new Dictionary<string, bool>();

    public static void handleNotify(UAnimMontage Montage, float? MoveOffset = 1)
    {
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
            TArrayUnsafe<FAnimNotifyEvent> AnimNotifyEventList = new TArrayUnsafe<FAnimNotifyEvent>();
            UGSE_AnimFuncLib.GetAllNotifyEvent(Montage, AnimNotifyEventList);
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
                        if (config?.replaceEffects == true)
                        {
                            sweepCheck.EffectIDList.Clear();
                        }
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



    private static bool IsPlayer(string name)
    {
        if (name != null && name?.ToLower()?.IndexOf("unit_player") > -1)
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
            var Caster = EffectInstReq.Attacker;



            if (Caster == null || (!IsPlayer(Caster.PathName) && !Caster.PathName.Contains("TAMER_player_tornado")))
            {
                return;
            }
            Log.Info($"Evt_TriggerSkillEffect EffectID:{EffectID}");
            var Target = InnerTarget;
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


            if (Caster == null || !IsPlayer(Caster?.PathName))
            {
                return;
            }
            if (BuffID != 1015)
            {
                Log.Info($"Evt_BuffAdd BuffID:{BuffID}");

            }
            // 冰火雷毒buff互斥
            List<int> buffers = [888666005, 888666006, 888666007, 888666008];
            if (buffers.Contains(BuffID))
            {
                HandleBuffMutex(Caster, BuffID, buffers);
            }

            // 棍光 buff互斥
            List<int> gun_buffers = [66655401, 66655402, 66655403, 66655404, 66655405, 66655406, 66655407, 66655408, 555503209];
            if (gun_buffers.Contains(BuffID))
            {
                HandleBuffMutex(Caster, BuffID, gun_buffers);
            }
            var buffRulesMap = Manager.buffRulesMap;
            // 检查是否有对应的buff规则
            if (!buffRulesMap.ContainsKey(BuffID))
            {
                return;
            }
            // 获取对应buff的所有规则
            var matchingRules = buffRulesMap[BuffID];
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


    [HarmonyPatch]
    public static class CastSkillPatch
    {
        [HarmonyPatch(typeof(BUS_MovementSystem), "OnSkillWithAnimMontage")]
        [HarmonyPrefix]
        static void Prefix(BUS_MovementSystem __instance, UAnimMontage Montage, ref float PlayTimeRate, float MontagePosOffset, FName StartSectionName, EMontageBindReason Reason)
        {

            if (__instance == null || Montage == null) return;
            if (__instance?.GetOwner() == null) return;
            if (__instance.GetOwner()?.PathName == null) return;
            if (!IsPlayer(__instance.GetOwner().PathName))
            {
                return;
            }
            var currentMontage = Montage.PathName;
            if (currentMontage == null) return;



            Log.Info($"Evt_CastSkillAnime Montage:{Montage.GetName()}");

            if (currentMontage.Contains("Animation/Player/Wukong/") || currentMontage.Contains("AM_wukong_trans_from_Vigor"))
            {
                Helper.updateIsPlayVigorSkillByID(false);
            }

            var allRules = GetCachedAnimRules();
            if (allRules == null || allRules.Count == 0) return;

            var matchedRule = allRules.FirstOrDefault(rule =>
                     !string.IsNullOrEmpty(currentMontage) &&
                     currentMontage.Contains(rule.montage));

            if (matchedRule?.CastActions?.Count > 0)
            {
                var rule = new Rule();
                rule.DoAfterActions(matchedRule.CastActions);
            }

            PlayTimeRate = matchedRule?.speedRate != null ? (float)matchedRule.speedRate : PlayTimeRate;

            if (matchedRule?.scaleWeaponNum != null)
            {
                Manager.OnScaleWeapon((float)matchedRule.scaleWeaponNum);
            }

            handleNotify(Montage, 0);
        }
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
        int[] comboSkills = { 10705, 10706, 10720, 10721, 50003, 50005, 50007, 50001 };
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

                BGUFunctionLibraryCS.BGUAddBuff(character, character, 289, EBuffSourceType.GM, 3000);
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
            __result = DSShop.ECheckBuyStat.CanBuy;
            return false; // 跳过原始方法的执行
        }

        [HarmonyPatch(typeof(DSShop), "CanBuyMinValue")]
        [HarmonyPrefix]
        static bool Prefix(ref int __result)
        {
            __result = 99;
            return false; // 跳过原始方法的执行
        }


        [HarmonyPatch(typeof(DSShop), "GetIsCanSell")]
        [HarmonyPrefix]
        static bool Prefix(ref bool __result)
        {
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
            AddGoodsNum = 99;
        }

        [HarmonyPatch(typeof(PlayerShop), "BuyShopItem")]
        public static void Prefix(ref int ShopId, ref int GoodsId, ref int BuyNum, ref bool CheckLimit)
        {
            CheckLimit = false;
        }
    }

}