using b1.EventDelDefine;
using b1;
using CSharpModBase;
using HarmonyLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System;
using BtlShare;
using ArchiveB1;
using System.IO;
using Newtonsoft.Json;
using UnrealEngine.InputCore;




public enum SkillMapCondition
{
    StancePoke,    // 戳棍姿态
    StanceProp,//立棍
    StanceHeavy,//劈棍
    hasBuff,
    disTance,
    any,//无条件转化
}

public class SkillMappingRule
{
    public int OriginalId { get; set; }
    public int MappedId { get; set; }
    public SkillMapCondition Condition { get; set; }
    public int? conditionValue { get; set; } // 可选：需要的buff 或者距离
    public string? desc { get; set; }//描述
    public bool? canRepeat { get; set; }//是否可以重复转化
}

namespace bian
{
    [HarmonyPatch]
    public static class Manager
    {

        private static ModelManager manager;
        private static Harmony harmony;
        private static Ui UI;

        public static string? currentMontage;
        private static BuffDescRuntime DescRuntime;
        public static string Nameo;

        public static ModelManager GetModelManager()
        {
            if (manager == null)
            {
                manager = new ModelManager();
            }
            return manager;
        }

        public static void CreateUi()
        {
            if (UI == null)
            {
                UI = new Ui();
            }
            UI.CreateUI();
        }


        public static void loadAllStaticData()
        {
            LoadUtils.LoadAndApplyBuffDispConfigs();
            LoadUtils.LoadAndApplyBuff();
            LoadUtils.LoadAndApplySummon();
            LoadUtils.LoadAndApplyChargeSkill();
            LoadUtils.LoadAndApplyBulletExpand();
            LoadUtils.LoadAndApplyBulletComm();
            LoadUtils.LoadAndApplyProjectileMove();
            LoadUtils.LoadAndApplyProjectileDisp();

            LoadUtils.LoadAndApplySkillDesc();
            LoadUtils.LoadAndApplySkillEffect();
        }



        public static void RegisterManager()
        {
            Manager.GetModelManager().InitConfig();
            Manager.GetModelManager().BindEvents();


            // 加载技能映射规则
            string configPath = Path.Combine("CSharpLoader", "Mods", "bian", "skillMaping");
            LoadUtils.LoadAllSkillMappingRules(configPath);

            loadAllStaticData();


            // 在这里可以将buffDispConfigs插入到游戏中的数据
            if (harmony == null)
            {
                harmony = new Harmony("mod.reece.bian");
                var assembly = Assembly.GetExecutingAssembly();
                harmony.PatchAll(assembly);
            }
        }


        public static void UnregisterManager()
        {
            Manager.GetModelManager().UnRegEvent();
            if (harmony != null)
            {
                harmony.UnpatchAll();
            }
        }

        public static string GetCurrentMontage()
        {
            if (currentMontage == null)
            {
                return "";
            }
            return currentMontage;
        }

        private static List<SkillMappingRule> AllSkillMappingRules = new List<SkillMappingRule>();

        // 添加公共属性
        public static IReadOnlyList<SkillMappingRule> SkillMappingRules
        {
            get { return AllSkillMappingRules.AsReadOnly(); }
        }

        // 添加公共方法来修改规则列表
        public static void ClearSkillMappingRules()
        {
            AllSkillMappingRules.Clear();
        }

        public static void AddSkillMappingRules(IEnumerable<SkillMappingRule> rules)
        {
            AllSkillMappingRules.AddRange(rules);
        }


        [HarmonyPatch(typeof(GSDel_RequestSpawnAProjectile), "Invoke")]
        [HarmonyPrefix]
        private static void GSDel_RequestSpawnAProjectileInvoke(ref FGSProjectileSpawnInfo ProjectileSpawnInfo)
        {
            if (Manager.GetModelManager().Config.CanLogDebug("[PATCH]RequestSpawnAProjectile"))
            {

                if (IsPlayer(ProjectileSpawnInfo.Spawner.PathName))
                {
                    if (ProjectileSpawnInfo.ProjectileID == 44051501)
                    {
                        var playerLocation = ProjectileSpawnInfo.Spawner.GetActorLocation();
                        var xyz = ProjectileSpawnInfo.Spawner.GetActorForwardVector();
                        var forwardVector = ProjectileSpawnInfo.Spawner.GetActorForwardVector();
                        forwardVector.Y *= 600;  // 只在Y轴方向增加800单位
                        forwardVector.X *= 600;  // 只在X轴方向增加800单位
                        ProjectileSpawnInfo.SpawnPosition = playerLocation + forwardVector;
                        Log.Info($"夜叉王飞轮子弹Y+600   forwardVector:{forwardVector} SpawnPosition:{ProjectileSpawnInfo.SpawnPosition}");
                    }

                }

            }

        }

        private static bool isBuffLoaded = false; // 添加静态标志变量




        [HarmonyPatch(typeof(BUS_GSEventCollection), "Evt_TriggerSkillEffectBySkillMultiCast_Implementation")]
        [HarmonyPrefix]
        private static void TriggerSkillEffectBySkillMultiCast(ref int EffectID, ref AActor Caster, ref AActor Target, ref FEffectInstReq EffectInstReq)
        {
            Log.Info($"Evt_TriggerSkillEffectBySkillMultiCast_Implementation  EffectID:{EffectID} Caster:{Caster.PathName} Target:{Target.PathName} EffectInstReq:{EffectInstReq.HitLocation}");

        }
        [HarmonyPatch(typeof(BUS_GSEventCollection), "Evt_NotifyGraphClientMultiCast_Implementation")]
        [HarmonyPrefix]
        private static void NotifyGraphClientMultiCast(ref string FinalGuid, ref FGameplayTag NotifyTag)
        {
            Log.Info($"Evt_NotifyGraphClientMultiCast_Implementation  FinalGuid:{FinalGuid} NotifyTag:{NotifyTag.TagName}");

        }


        [HarmonyPatch(typeof(BUS_GSEventCollection), "Evt_BuffAdd_Multicast_Invoke")]
        [HarmonyPrefix]
        private static void BuffAdd_Multicast(ref int BuffID, AActor Caster, AActor RootCaster, ref float Duration)
        {
            if (Manager.GetModelManager().Config.CanLogDebug("[PATCH]BuffAdd_Multicast"))
            {

            }

            if (Caster == null || !IsPlayer(Caster.PathName))
            {
                return;
            }
            var buffDesc = GameDBRuntime.GetFUStBuffDesc(BuffID);

            if (buffDesc != null && (buffDesc?.Duration > 1000 || BuffID == 9870001))
            {
                Log.Info($"buff {BuffID}，Duration:{buffDesc.Duration},Interval:{buffDesc.Interval},");
                if (buffDesc?.Range?.RangeParam != null && buffDesc.Range.RangeParam.Count > 0)
                {
                    Log.Info($"buff {BuffID} ,Duration:{buffDesc.Duration},Interval:{buffDesc.Interval},range:{buffDesc.Range.RangeParam[0]} ，BuffActiveCondition：{buffDesc?.BuffActiveCondition?.ConditionParams}");
                }

                if (buffDesc?.BuffEffects != null)
                {
                    Log.Info($"buff {BuffID} EffectParams:{buffDesc?.BuffEffects?.Count()} ");
                }
            }
            // if (buffDesc != null && buffDesc?.BuffEffects != null && buffDesc?.BuffEffects?.Count > 0)
            // {
            //     Log.Info($"buff {BuffID} add  ,buffDescBuffTips {buffDesc.BuffTips} {buffDesc.Duration} EffectParams:{buffDesc?.BuffEffects[0]?.EffectParams[0]}");
            // }


            // 冰火雷毒buff互斥
            List<int> buffers = [888666005, 888666006, 888666007, 888666008];
            if (buffers.Contains(BuffID))
            {
                foreach (var buffer in buffers)
                {
                    if (buffer != BuffID)
                    {
                        BGUFunctionLibraryCS.BGURemoveBuffImmediately(Caster, buffer, EBuffEffectTriggerType.Remove);
                    }
                }
            }

            var mgr = Manager.GetModelManager();
            if (mgr.Rules != null && mgr.Rules.Count > 0)
            {
                for (int i = 0; i < mgr.Rules.Count; i++)
                {
                    var rule = mgr.Rules[i];
                    if (rule.Rules != null && rule.Rules.Count > 0)
                    {
                        for (int j = 0; j < rule.Rules.Count; j++)
                        {
                            var ruleItem = rule.Rules[j];
                            if (ruleItem.IsMatchBuff(BuffID))
                            {
                                var Duration_ = Duration > 0 ? Duration : 1000;
                                ruleItem.DoRule(Duration_, 1, null, null);
                            }
                        }
                    }
                }
            }

        }

        private static bool IsPlayer(string name)
        {
            if (name != null && name.ToLower().IndexOf("unit_player") > -1)
            {
                return true;
            }
            return false;
        }
        private static bool isBuffConfigsLoaded = false; // 添加静态标志变量
        [HarmonyPatch(typeof(BUS_GSEventCollection), "Evt_CastSkillWithAnimMontageMultiCast_Implementation")]
        [HarmonyPrefix]
        private static void CastSkillWithAnimMontageMultiCast(BUS_GSEventCollection __instance, ref UAnimMontage Montage, ref float PlayTimeRate, float MontagePosOffset, FName StartSectionName)
        {

            // if (Manager.GetModelManager().Config.CanLogDebug("[PATCH]CastSkillWithAnimMontageMultiCast"))
            // {
            //  }

            if (!IsPlayer(__instance.GetOwner().PathName))
            {
                return;
            }


            currentMontage = Montage.PathName;
            var mgr = Manager.GetModelManager();
            var currentModel = mgr.GetCurrentModel(__instance.GetOwner() as BGUPlayerCharacterCS) as BaseModel;
            var length = Montage.GetPlayLength() * 1000;
            var playRate = 1f;


            if (currentModel != null && currentModel.PlayTimeRate > 0)
            {
                playRate = currentModel.PlayTimeRate;
            }
            var PlayTimeRate_ = PlayTimeRate;
            if (currentModel?.skillSpeedRate > 0)
            {
                PlayTimeRate_ = (float)currentModel.skillSpeedRate; //动画播放速率
            }

            if (mgr.Rules != null && mgr.Rules.Count > 0)
            {

                for (int i = 0; i < mgr.Rules.Count; i++)
                {
                    var rule = mgr.Rules[i];
                    if (rule.Rules != null && rule.Rules.Count > 0)
                    {
                        for (int j = 0; j < rule.Rules.Count; j++)
                        {
                            var ruleItem = rule.Rules[j];
                            if (Montage != null && ruleItem.IsMatchMontage(Montage.PathName))
                            {
                                if (ruleItem?.skillID_fs > 0)
                                {
                                    Helper.FenshenGSTryCastSkill((int)ruleItem.skillID_fs, false);
                                }
                                else
                                {
                                    Helper.FenshenGSTryCastSkill((int)0, false);
                                }

                                if (ruleItem?.speedRate > 0)
                                {
                                    PlayTimeRate_ = (float)ruleItem.speedRate; //动画播放速率
                                }
                                ruleItem.DoRule(length, playRate, Montage, ruleItem);
                            }
                        }
                    }
                }
            }
            else
            {
                Helper.FenshenGSTryCastSkill(0, false);
            }

            PlayTimeRate = PlayTimeRate_;
        }


        private static bool IsSkillMappingRuleMatch(SkillMappingRule rule, BGUCharacterCS character, bool isChuogun, bool isLigun, bool isPigun, BGUCharacterCS target = null)
        {
            // 姿态条件判断
            bool stanceMatch = (rule.Condition == SkillMapCondition.StancePoke && isChuogun) ||
                               (rule.Condition == SkillMapCondition.StanceProp && isLigun) ||
                               (rule.Condition == SkillMapCondition.StanceHeavy && isPigun);

            // Buff条件判断
            bool buffMatch = rule.Condition == SkillMapCondition.hasBuff &&
                             rule.conditionValue > 0 &&
                             BGUFunctionLibraryCS.BGUHasBuffByID(character, (int)rule.conditionValue);

            // 距离条件判断
            bool distanceMatch = rule.Condition == SkillMapCondition.disTance &&
                                 rule.conditionValue >= 0 &&
                                 target != null &&
                                 character.GetDistanceTo(target) >= rule.conditionValue;

            // 无条件判断
            bool anyMatch = rule.Condition == SkillMapCondition.any;

            // 返回任意一个条件匹配即为true
            return stanceMatch || buffMatch || distanceMatch || anyMatch;
        }



        [HarmonyPatch(typeof(BUS_GSEventCollection), "Evt_SmartCastSkillTryMultiCast_Implementation")]
        [HarmonyPrefix]
        private static void SmartCastSkillTryMultiCast(ref int ID, ref List<int> RuleIDList)
        {
            if (Manager.GetModelManager().Config.CanLogDebug("[PATCH]SmartCastSkill"))
            {
                Log.Info($"bian: 真实的id SmartCastSkillTryMultiCast -->{ID}");
            }
            var character = Helper.GetBGUPlayerCharacterCS();
            var bufferId = 20101;

            var control = Helper.GetPlayerController();

            var readOnlyData = BGU_DataUtil.GetPlayerControlReadonlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(control);
            var stance = readOnlyData?.RoleData?.RoleCs?.Actor?.Wear?.Stance;//当前棍法
            var isChuogun = stance == Stance.Poke;
            var isLigun = stance == Stance.Prop;
            var isPigun = stance == Stance.Heavy;


            // 待定todo
            if (ID == 10720)
            {
                ID = 10721;
            }
            if (ID == 10725)
            {
                ID = 10724;
            }

            if (ID == 10706 || ID == 10705)
            {
                ID = 10705;
            }
            if (ID == 10708 || ID == 10707)
            {
                ID = 50002;
            }
            if (ID == 10715)
            {
                ID = 10714;
            }
            var currentId = ID;
            if (readOnlyData != null)
            {
                Log.Info($"Evt_CastSkillWithAnimMontageMultiCast  {stance}");

            }
            if (ID == 10801)
            {
                // 平A1
                bufferId = 888666021;
            }
            if (ID == 10802)
            {
                // 平A2
                BGUFunctionLibraryCS.BGURemoveBuffImmediately(character, 888666021, EBuffEffectTriggerType.Remove);
                bufferId = 888666022;
            }
            if (ID == 10803)
            {
                // 平A3
                BGUFunctionLibraryCS.BGURemoveBuffImmediately(character, 888666022, EBuffEffectTriggerType.Remove);
                bufferId = 888666023;
            }
            if (ID == 10804)
            {
                // 平A4
                BGUFunctionLibraryCS.BGURemoveBuffImmediately(character, 888666023, EBuffEffectTriggerType.Remove);
                bufferId = 888666024;
            }
            if (ID == 10805)

            {
                // 平A5
                BGUFunctionLibraryCS.BGURemoveBuffImmediately(character, 888666024, EBuffEffectTriggerType.Remove);
                bufferId = 888666025;

            }



            if (new int[] { 10705, 10706, 10720, 10721, 50003, 50005, 50007, 50001 }.Contains(ID))
            {
                BGUFunctionLibraryCS.BGUAddBuff(character, character, 289, EBuffSourceType.GM, 3000);//切手连招
                BGUFunctionLibraryCS.BGUAddBuff(character, character, 888666018, EBuffSourceType.GM, 800);//识破buff
            }


            // if (new int[] { 10707, 50002, 50004, 50006, 50008, 10714, 10724, 10723 }.Contains(ID))
            // {
            //     // 移除buff
            //     List<int> attack_buffers = [888666021, 888666022, 888666023, 888666024, 888666025];
            //     foreach (var buffer in attack_buffers)
            //     {
            //         BGUFunctionLibraryCS.BGURemoveBuffImmediately(character, buffer, EBuffEffectTriggerType.Remove);
            //     }
            // }

            if (bufferId > 0)
            {
                BGUFunctionLibraryCS.BGUAddBuff(character, character, bufferId, EBuffSourceType.GM, 4000);
            }

            // 首先过滤出所有匹配的规则
            var mapArr = AllSkillMappingRules.Where(r => r.OriginalId == currentId).ToList();

            if (mapArr.Count() > 0)
            {
                var target = BGUFunctionLibraryCS.BGUGetTarget(character) as BGUCharacterCS;

                // 优先检查canRepeat为true的规则
                // 优先检查canRepeat为true的规则
                var repeatableRules = mapArr.Where(r => r.canRepeat.HasValue && r.canRepeat.Value).ToList();

                var matchItem = repeatableRules.FirstOrDefault(r => IsSkillMappingRuleMatch(r, character, isChuogun, isLigun, isPigun, target));

                if (matchItem != null)
                {

                    ID = matchItem.MappedId;
                    currentId = matchItem.MappedId;
                }

                // 重新过滤
                var newArr = AllSkillMappingRules.Where(r => r.OriginalId == currentId).ToList();
                var nonRepeatableRules = newArr.Where(r => !r.canRepeat.HasValue || !r.canRepeat.Value).ToList();
                var matchItem_ = nonRepeatableRules.FirstOrDefault(r => IsSkillMappingRuleMatch(r, character, isChuogun, isLigun, isPigun, target));
                if (matchItem_ != null)
                {
                    ID = matchItem_.MappedId;
                }
            }
        }



        [HarmonyPatch(typeof(BUEffectSpawnBullets), "ApplyByBuff_Implement")]
        [HarmonyPrefix]
        private static bool ApplyByBuff_Implement(ref BuffInstData BuffInst, ref AActor Target, ref int EffectIdx, ref bool bIsPeriodical)
        {
            if (BuffInst == null)
            {
                return false;
            }
            int buffID = BuffInst.BuffID;
            FUStBuffDesc originalBuffDesc = BGW_GameDB.GetOriginalBuffDesc(buffID);
            IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(EntitySharedRefFuncLib.Actor(BuffInst.RootCasterRef));
            if (originalBuffDesc != null)
            {
                DescRuntime = new BuffDescRuntime(buffID, readOnlyData, originalBuffDesc);
            }
            FSpawnBulletMinMaxValue x = default(FSpawnBulletMinMaxValue);
            FSpawnBulletMinMaxValue y = default(FSpawnBulletMinMaxValue);
            FSpawnBulletMinMaxValue z = default(FSpawnBulletMinMaxValue);
            int intEffectParam = DescRuntime.GetIntEffectParam(EffectIdx, 0);
            int intEffectParam2 = DescRuntime.GetIntEffectParam(EffectIdx, 1);
            int intEffectParam3 = DescRuntime.GetIntEffectParam(EffectIdx, 2);
            int intEffectParam4 = DescRuntime.GetIntEffectParam(EffectIdx, 3);
            int intEffectParam5 = DescRuntime.GetIntEffectParam(EffectIdx, 4);
            int intEffectParam6 = DescRuntime.GetIntEffectParam(EffectIdx, 5);
            Nameo = DescRuntime.GetStringEffectParam(EffectIdx, 0);
            int intEffectParam7 = DescRuntime.GetIntEffectParam(EffectIdx, 6);
            float floatEffectParam = DescRuntime.GetFloatEffectParam(EffectIdx, 0);
            float floatEffectParam2 = DescRuntime.GetFloatEffectParam(EffectIdx, 1);
            float floatEffectParam3 = DescRuntime.GetFloatEffectParam(EffectIdx, 2);
            float floatEffectParam4 = DescRuntime.GetFloatEffectParam(EffectIdx, 3);
            float floatEffectParam5 = DescRuntime.GetFloatEffectParam(EffectIdx, 4);
            float floatEffectParam6 = DescRuntime.GetFloatEffectParam(EffectIdx, 5);
            float floatEffectParam7 = DescRuntime.GetFloatEffectParam(EffectIdx, 6);
            MyUtils.sm = Nameo;
            z.LeftValue = DescRuntime.GetIntEffectParam(EffectIdx, 7);
            z.RightValue = DescRuntime.GetIntEffectParam(EffectIdx, 8);
            z.IsEquidistance = true;
            MyUtils.SpwanProjectileByTracker3(intEffectParam, (MyUtils.ETrackType)intEffectParam2, intEffectParam3, new FVector((double)floatEffectParam, (double)floatEffectParam2, (double)floatEffectParam3), new FVector((double)floatEffectParam4, (double)floatEffectParam5, (double)floatEffectParam6), x, y, z, floatEffectParam7, intEffectParam4, intEffectParam5, intEffectParam6, intEffectParam7 == 1);
            return true;
        }




        public class ComboConfig
        {
            public string nowMontage { get; set; }
            public double rate { get; set; }
            public int skillID { get; set; }
            public SkillMapCondition Condition { get; set; }
            public string InputCore { get; set; }
            public int conditionValue { get; set; }
            public string desc { get; set; }
        }

        private static List<ComboConfig> comboConfigs = new List<ComboConfig>();



        private static void LoadComboConfigs()
        {
            string configFolderPath = Path.Combine("CSharpLoader", "Mods", "bian", "ComboSkill");
            if (Directory.Exists(configFolderPath))
            {
                comboConfigs.Clear();
                foreach (string file in Directory.GetFiles(configFolderPath, "*.json"))
                {
                    string json = File.ReadAllText(file);
                    var configs = JsonConvert.DeserializeObject<List<ComboConfig>>(json);
                    if (configs != null)
                    {
                        comboConfigs.AddRange(configs);
                    }
                }
            }
        }



        private static void GetCharacterStance(BGUCharacterCS character, out bool isChuogun, out bool isLigun, out bool isPigun)
        {
            var control = Helper.GetPlayerController();
            var readOnlyData = BGU_DataUtil.GetPlayerControlReadonlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(control);
            var stance = readOnlyData?.RoleData?.RoleCs?.Actor?.Wear?.Stance;
            isChuogun = stance == Stance.Poke;
            isLigun = stance == Stance.Prop;
            isPigun = stance == Stance.Heavy;
        }




        [HarmonyPatch(typeof(UInputPreProcEvent), "OnAnyKeyTriggerEvent")]
        [HarmonyPrefix]

        private static void OnAnyKeyTriggerEvent(FKey Key)
        {
            if (comboConfigs.Count == 0)
            {
                LoadComboConfigs();
            }

            var character = Helper.GetBGUPlayerCharacterCS();
            if (character == null) return;

            UAnimInstance animInstance = character.Mesh.GetAnimInstance();
            var currMontage = animInstance.GetCurrentActiveMontage();
            if (currMontage == null) return;

            var currentPosition = animInstance.Montage_GetPosition(currMontage);
            var currentLength = currMontage.SequenceLength;

            var currentRate = currentPosition / currentLength;

            string keyName = Key.GetFName().ToString();
            if (keyName == "Tab" && !isBuffConfigsLoaded) // 添加标志变量检查
            {
                loadAllStaticData();

                isBuffConfigsLoaded = true; // 设置标志变量为true
            }
            GetCharacterStance(character, out bool isChuogun, out bool isLigun, out bool isPigun);
            var target = BGUFunctionLibraryCS.BGUGetTarget(character) as BGUCharacterCS;

            foreach (var combo in comboConfigs)
            {
                string fullPath = currMontage.PathName;
                string subString = combo.nowMontage;
                if (fullPath.Contains(subString) &&
                    currentPosition >= combo.rate &&
                    keyName == combo.InputCore)
                {
                    var rule = new SkillMappingRule
                    {
                        Condition = combo.Condition,
                        conditionValue = combo.conditionValue
                    };

                    if (combo.Condition == SkillMapCondition.any || IsSkillMappingRuleMatch(rule, character, isChuogun, isLigun, isPigun, target))
                    {
                        BUS_EventCollectionCS.Get(character).Evt_RequestSmartCastSkill.Invoke(combo.skillID, null, EMontageBindReason.NormalSkill, false);
                        break;
                    }
                }
            }
        }



        /*[HarmonyPatch(typeof(BUS_MagicallyChangeComp), "OnCastMagicallyChangeSkill")]
        [HarmonyPrefix]
        private static void OnCastMagicallyChangeSkill(BGWDataAsset_MagicallyChangeConfig Config, int SkillID, int RecoverSkillID, BUS_MagicallyChangeComp __instance)
        {
            Log.Debug($"bian: [PATCH]OnCastMagicallyChangeSkill  --> SkillID:{SkillID} Config:{Config.PathName} RecoverSkillID: {RecoverSkillID}");
        }

        [HarmonyPatch(typeof(BUS_MagicallyChangeComp), "DoCastMagicallyChangeSkill")]
        [HarmonyPrefix]
        private static void DoCastMagicallyChangeSkill(UBGWDataAsset Config, int SkillID, int RecoverSkillID, BUS_MagicallyChangeComp __instance)
        {
            Log.Debug($"bian: [PATCH]OnCastMagicallyChangeSkill  --> SkillID:{SkillID} Config:{Config.PathName} RecoverSkillID: {RecoverSkillID}");
        }*/
    }
}
