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
using UnrealEngine.InputCore;
using System.Runtime.InteropServices;




public enum SkillMapCondition
{
    StancePoke,    // 戳棍姿态
    StanceProp,//立棍
    StanceHeavy,//劈棍
    hasBuff,
    disTance,
    hasTalent,//拥有某个天赋
    montage,//动画
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

        // 核心组件
        private static ModelManager manager;
        private static Harmony harmony;
        private static Ui UI;

        public static string? currentMontage;
        public static string? comboMontage;
        public static string? currentTime;
        public static string Nameo;
        public static bool isBig = false;


        // 连招配置
        private static List<ComboConfig> comboConfigs = new List<ComboConfig>();
        // 监听的键值
        private static HashSet<string> monitoredKeys = new HashSet<string>();
        private static Dictionary<string, List<ComboConfig>> keyToComboConfigsMap = new Dictionary<string, List<ComboConfig>>();


        // 监听的效果id
        public static Dictionary<int, List<Rule>> effectRulesMap = new Dictionary<int, List<Rule>>();

        // 监听的BuffID
        public static Dictionary<int, List<Rule>> buffRulesMap = new Dictionary<int, List<Rule>>();

        // 监听的动画
        public static Dictionary<string, List<Rule>> montageRulesMap = new Dictionary<string, List<Rule>>();

        public static List<SkillMappingRule> AllSkillMappingRules = new List<SkillMappingRule>();
        public static bool isBuffConfigsLoaded = false; // 添加静态标志变量

        // 添加公共属性
        public static IReadOnlyList<SkillMappingRule> SkillMappingRules
        {
            get { return AllSkillMappingRules.AsReadOnly(); }
        }


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


        private static void GetBuffDispListWithRetry(int retryInterval = 1000, int maxRetries = 30)
        {
            var buffDispList = BGW_GameDB.GetAllBuffDispDesc();

            if (buffDispList == null || buffDispList.Count == 0)
            {
                // if (maxRetries > 0)
                // {
                //     Helper.DelayExecute(retryInterval, () => GetBuffDispListWithRetry(5000, maxRetries - 1));
                // }
            }
            else
            {

                LoadUtils.LoadAllBossModels();
                LoadUtils.LoadAndApplyChargeSkill();
                LoadUtils.LoadAndApplyBulletExpand();
                LoadUtils.LoadAndApplyBulletComm();
                LoadUtils.LoadAndApplyProjectileMove();
                LoadUtils.LoadAndApplyProjectileDisp();
                LoadUtils.LoadAndApplySkillDesc();


                LoadUtils.LoadAndApplySkillEffect();
                LoadUtils.LoadAndApplyPassiveSkills();
                LoadUtils.LoadAndApplyBuffDispConfigs();
                LoadUtils.LoadAndApplyBuff();
                LoadUtils.ModifyIronData();
                LoadUtils.ModifyPlayCtrlDescData();

                LoadUtils.LoadAndApplySuitDesc();
                LoadUtils.LoadAndApplyItemDesc();
                LoadUtils.ModifyHP();
                LoadUtils.ModifySoulskill();
                // LoadUtils.ModifyCommDropRuleDesc();
                LoadUtils.ModifyTrans();
                LoadUtils.ModifyWine();
                LoadUtils.LoadAndApplyDamageExpandDesc();
                LoadUtils.LoadAndApplyEquipDesc();
                LoadUtils.LoadAnimRulesBySweepCheck();
                LoadUtils.ModifySkillsMap();
                LoadUtils.LoadAndApplyTalentDesc();
                LoadUtils.LoadAndApplyEquipAttrDesc();
                LoadUtils.LoadAndApplyHuluDesc();
                LoadUtils.LoadAndApplySummon();
                LoadSkill.LoadActionsBySkill();
                LoadUtils.modifySuperSkillArmor();
                isBuffConfigsLoaded = true;
                // Hooks.RegOnCastSkillWithAnimMontageEvent();
            }
        }
        public static List<ActionConfig> ActionsByInput;
        public static string inputCodeStr;
        public static void loadAllStaticData(bool forceUpdate = false, int delayTime = 1000)
        {
            if (!!Helper.is_bian_mod_stop)
            {
                return;
            }

            LoadComboConfigs();//全部连招
            ActionsByInput = LoadUtils.LoadActionConfigs();

            if (isBuffConfigsLoaded && !forceUpdate) { return; }
            // 加载技能映射规则
            LoadUtils.LoadAllSkillMappingRules();

            InitializeEffectRulesMap();//初始化技能子弹效果rule
            // 使用新的递归方法获取buffDispList
            GetBuffDispListWithRetry(delayTime);

        }


        private static void InitializeEffectRulesMap()
        {
            effectRulesMap.Clear();
            buffRulesMap.Clear();
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
                            if (ruleItem.Filters != null && ruleItem.Filters.Count > 0)
                            {
                                foreach (var filter in ruleItem.Filters)
                                {
                                    if (filter.Type == "effect" && filter.EffectID > 0)
                                    {
                                        if (!effectRulesMap.ContainsKey(filter.EffectID))
                                        {
                                            effectRulesMap[filter.EffectID] = new List<Rule>();
                                        }
                                        effectRulesMap[filter.EffectID].Add(ruleItem);
                                    }
                                    else if (filter.Type == "buff" && filter.BuffID > 0)
                                    {
                                        if (!buffRulesMap.ContainsKey(filter.BuffID))
                                        {
                                            buffRulesMap[filter.BuffID] = new List<Rule>();
                                        }
                                        buffRulesMap[filter.BuffID].Add(ruleItem);

                                    }
                                    else if (filter.Type == "montage" && filter.Name != null)
                                    {
                                        if (!montageRulesMap.ContainsKey(filter.Name))
                                        {
                                            montageRulesMap[filter.Name] = new List<Rule>();
                                        }
                                        montageRulesMap[filter.Name].Add(ruleItem);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }



        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleOutputCP(uint wCodePageID);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleCP(uint wCodePageID);

        public static void EnableCNInConsole()
        {
            SetConsoleCP(65001u);
            SetConsoleOutputCP(65001u);
            Log.Info("EnableCNInConsole 开启中文输出");
        }

        public static void RegisterManager()
        {
            GetModelManager().InitConfig();
            GetModelManager().BindEvents();
            EnableCNInConsole();

            loadAllStaticData(false, 0);
            // 在这里可以将buffDispConfigs插入到游戏中的数据
            if (harmony == null)
            {
                harmony = new Harmony("mod.reece.bian");
                var assembly = Assembly.GetExecutingAssembly();
                try
                {
                    harmony.PatchAll(assembly);
                }
                catch (Exception ex)
                {
                    Log.Error($"Harmony patch failed: {ex.Message}");
                    Log.Error($"Stack trace: {ex.StackTrace}");
                }
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

        public static string GetCurrentTime()
        {
            if (currentTime == null)
            {
                return "";
            }
            return currentTime;
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


        public static Dictionary<int, FVector> scaleProjectileID = new Dictionary<int, FVector>
{
    {140, new FVector(5f, 5f, 5f)},
    {1085601, new FVector(2f, 10f, 10f)},
    {1085602, new FVector(2f, 10f, 10f)},
    {1085603, new FVector(2f, 10f, 10f)},
    {1085699, new FVector(2f, 10f, 10f)},
    {1090201, new FVector(5f, 5f, 5f)},
    {1090202, new FVector(5f, 5f, 5f)},
    {146, new FVector(1f, 1f, 1f)},
    {148, new FVector(5f, 5f, 5f)},
    {118, new FVector(5f, 5f, 5f)},
    {117, new FVector(5f, 5f, 5f)}
};

        [HarmonyPatch(typeof(GSDel_RequestSpawnAProjectile), "Invoke")]
        [HarmonyPrefix]
        private static void GSDel_RequestSpawnAProjectileInvoke(ref FGSProjectileSpawnInfo ProjectileSpawnInfo)
        {
            if (IsPlayer(ProjectileSpawnInfo.Spawner.PathName))
            {
                var id = ProjectileSpawnInfo.ProjectileID;
                if (scaleProjectileID.ContainsKey(id))
                {
                    var scale = scaleProjectileID[id];
                    Helper.DelayExecute(40, () =>
                    {
                        Helper.projectileScale(id, scale);
                    });
                }
            }
        }

        private static bool isBuffLoaded = false; // 添加静态标志变量

        public static string GetLastCharacters(string input, int length)
        {
            if (string.IsNullOrEmpty(input))
                return input;
            if (length <= 0)
                return string.Empty;
            if (input.Length <= length)
                return input;
            return input.Substring(input.Length - length);
        }



        // [HarmonyPatch(typeof(BUS_GSEventCollection), "Evt_TriggerSkillEffectBySkillMultiCast_Implementation")]
        // [HarmonyPrefix]
        // private static void TriggerSkillEffectBySkillMultiCast(ref int EffectID, ref AActor Caster, ref AActor Target, ref FEffectInstReq EffectInstReq)
        // {
        //     if (Caster == null || (!IsPlayer(Caster?.PathName) && !Caster.PathName.Contains("TAMER_player_tornado")))
        //     {
        //         return;
        //     }

        //     Log.Info($"Evt_TriggerSkillEffect EffectID:{EffectID}");
        //     // 检查是否有对应的效果规则
        //     if (!effectRulesMap.ContainsKey(EffectID))
        //     {

        //         return;
        //     }


        //     // 获取对应效果的所有规则
        //     var matchingRules = effectRulesMap[EffectID];
        //     foreach (var ruleItem in matchingRules)
        //     {
        //         ruleItem.Caster = Caster;
        //         ruleItem.Target = Target;
        //         ruleItem.EffectInstReq = EffectInstReq;
        //         ruleItem.DoRule(1000, 1, null, ruleItem);
        //     }
        // }


        // 通用的buff互斥处理方法
        private static void HandleBuffMutex(AActor caster, int currentBuffId, List<int> mutexBuffIds)
        {
            foreach (var buffId in mutexBuffIds.Where(id => id != currentBuffId))
            {
                BGUFunctionLibraryCS.BGURemoveBuffImmediately(caster, buffId, EBuffEffectTriggerType.Remove);
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


        // [HarmonyPatch(typeof(BUS_GSEventCollection), "Evt_CastSkillWithAnimMontageMultiCast_Implementation")]
        // [HarmonyPrefix]
        // private static void CastSkillWithAnimMontageMultiCast(BUS_GSEventCollection __instance, ref UAnimMontage Montage, ref float PlayTimeRate, float MontagePosOffset, FName StartSectionName)
        // {

        //     if (!IsPlayer(__instance.GetOwner().PathName))
        //     {
        //         return;
        //     }
        //     currentMontage = Montage.PathName;
        //     var character = __instance.GetOwner() as BGUPlayerCharacterCS;

        //     if (Helper.isPlayVigorSkillByID)
        //     {
        //         BGUFunctionLibraryCS.BGUAddBuff(character, character, 211, EBuffSourceType.GM, 3000);
        //         Helper.GetBUS_GSEventCollection().Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AttackStateBegin, -1f);
        //     }
        //     if (currentMontage.Contains("Animation/Player/Wukong/") || currentMontage.Contains("AM_wukong_trans_from_Vigor"))
        //     {
        //         Helper.updateIsPlayVigorSkillByID(false);
        //     }

        //     if (currentMontage.Contains("AM_wukong_trans_from_Vigor"))
        //     {
        //         if (character != null)
        //         {
        //             character.FollowCamera.RelativeLocation = new FVector(0, 0, 0);
        //         }
        //     }
        //     if (!currentMontage.Contains("AM_Wukong_Dodge"))
        //     {
        //         comboMontage = Montage.PathName;
        //     }
        //     // 添加jxsq 相关buff
        //     if (currentMontage.Contains(".AM_Wukong_JXSQ_Enter_") && character != null)
        //     {
        //         Helper.addJXSQBuffs(character);
        //     }




        //     var allRules = Hooks.GetCachedAnimRules();
        //     if (allRules == null || allRules.Count == 0) return; // 如果获取规则失败，则直接返回
        //     var matchedRule = allRules.FirstOrDefault(rule =>
        //              !string.IsNullOrEmpty(currentMontage) &&
        //              currentMontage.Contains(rule.montage));
        //     // if (matchedRule == null)
        //     // {
        //     //     OnScaleWeapon(1);
        //     //     return;
        //     // }
        //     if (matchedRule?.CastActions?.Count > 0)
        //     {
        //         var rule = new Rule();
        //         rule.DoAfterActions(matchedRule.CastActions);
        //     }

        //     if (matchedRule?.AMScaleRate != null && matchedRule?.AMScaleRate > 1)
        //     {
        //         if (character != null)
        //         {

        //             BUS_EventCollectionCS.Get(character).Evt_SetAMScaleRateByPosMultiCast.Invoke(EAMScaleType.ScaleForTarget, EAMScaleRateAxis.AxisX, 0, 0.2f, 0, false, false, 0.3f, 0.1f, 0.4f, 0.01f, (float)(matchedRule.AMScaleRate), -900, 0);
        //         }
        //     }
        //     if (matchedRule?.openShooterMode != null && character != null)
        //     {
        //         BUS_EventCollectionCS.Get(character).Evt_UnitStateTrigger.Invoke(EBUStateTrigger.ShooterModeTrigger, -1f);
        //     }
        //     if (matchedRule?.closeShooterMode != null && character != null)
        //     {
        //         BUS_EventCollectionCS.Get(character).Evt_UnitStateTrigger.Invoke(EBUStateTrigger.ShooterModeClear, -1f);
        //     }

        //     if (matchedRule?.moveMode != null && character != null)
        //     {
        //         character.CharacterMovement.SetMovementMode((EMovementMode)matchedRule.moveMode, 0);
        //     }
        //     if (matchedRule?.speedRate != null)
        //     {
        //         PlayTimeRate = (float)matchedRule.speedRate;
        //     }


        //     if (matchedRule?.scaleWeaponNum != null)
        //     {
        //         OnScaleWeapon((float)matchedRule.scaleWeaponNum);
        //     }

        //     Hooks.handleNotify(Montage, 0);
        // }


        public static bool IsSkillMappingRuleMatch(SkillMappingRule rule, BGUCharacterCS character, bool isChuogun, bool isLigun, bool isPigun, BGUCharacterCS target = null)
        {
            // 姿态条件判断
            bool stanceMatch = (rule.Condition == SkillMapCondition.StancePoke && isChuogun) ||
                               (rule.Condition == SkillMapCondition.StanceProp && isLigun) ||
                               (rule.Condition == SkillMapCondition.StanceHeavy && isPigun);

            // Buff条件判断
            bool buffMatch = rule.Condition == SkillMapCondition.hasBuff &&
                             rule.conditionValue > 0 &&
                             BGUFunctionLibraryCS.BGUHasBuffByID(character, (int)rule.conditionValue);


            //天赋条件判断
            bool talentMatch = rule.Condition == SkillMapCondition.hasTalent &&
                             rule.conditionValue > 0 &&
                             BGUFunctionLibraryCS.BGUHasTalentByID(character, (int)rule.conditionValue);
            // 距离条件判断
            bool distanceMatch = rule.Condition == SkillMapCondition.disTance &&
                                 rule.conditionValue >= 0 &&
                                 target != null &&
                                 character.GetDistanceTo(target) >= rule.conditionValue;

            // var currentMontage = GetPlayerCurrentActiveMontage(character);
            // bool animMatch = rule.Condition == SkillMapCondition.montage &&
            //                                 rule.conditionValue != null && currentMontage.PathName.Contains(rule.conditionValue.ToString());

            // 无条件判断
            bool anyMatch = rule.Condition == SkillMapCondition.any;


            // 返回任意一个条件匹配即为true
            return stanceMatch || buffMatch || distanceMatch || talentMatch || anyMatch;
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

        public static float scaleWeaponNum = 1;
        // 在Manager类的开头添加计时器变量
        private static System.Timers.Timer scaleResetTimer;
        public static void OnScaleWeapon(float num = 2)
        {

            // 获取当前玩家
            var player = Helper.GetBGUPlayerCharacterCS();
            if (player == null || scaleWeaponNum == num) return;
            scaleWeaponNum = num;

            TArrayUnsafe<UActorComponent> componentsByTag = player.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>());
            if (componentsByTag != null && componentsByTag.Count > 0)
            {
                foreach (var uStaticMeshComponent in componentsByTag)
                {
                    if (uStaticMeshComponent != null && uStaticMeshComponent.GetName() != null && uStaticMeshComponent.GetName().ToLower().Contains("weapon"))
                    {
                        var weaponComponent = uStaticMeshComponent as USkeletalMeshComponent;
                        if (weaponComponent != null)
                        {
                            weaponComponent.SetRelativeScale3D(new FVector(num, 1, 1));
                            // weaponComponent.SetWorldScale3D(new FVector(num, num, 1));
                        }
                    }
                }
                ResetScaleResetTimer();
            }

        }
        // 添加重置计时器方法
        private static void ResetScaleResetTimer()
        {
            // 如果计时器存在，先停止并释放
            if (scaleResetTimer != null)
            {
                scaleResetTimer.Stop();
                scaleResetTimer.Dispose();
            }

            // 创建新的计时器，2.5秒后触发
            scaleResetTimer = new System.Timers.Timer(2500);
            scaleResetTimer.AutoReset = false; // 只触发一次
            scaleResetTimer.Elapsed += (sender, e) =>
            {
                // 在主线程上执行UI操作
                Utils.TryRunOnGameThread((Action)delegate
                {
                    ResetWeaponScale();
                });
            };
            scaleResetTimer.Start();
        }

        // 添加恢复棍子原始大小的方法
        private static void ResetWeaponScale()
        {
            var player = Helper.GetBGUPlayerCharacterCS();
            if (player == null) return;

            TArrayUnsafe<UActorComponent> componentsByTag = player.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>());
            if (componentsByTag != null && componentsByTag.Count > 0)
            {
                foreach (var item in componentsByTag)
                {
                    if (item != null && item.GetName() != null && item.GetName().ToLower().Contains("weapon"))
                    {
                        Log.Info($"Weapon Name: {item.GetName()}");
                        var item_ = item as USkeletalMeshComponent;
                        item_.SetRelativeScale3D(new FVector(1, 1, 1));
                        scaleWeaponNum = 1;
                    }
                }
            }


            // 清理计时器
            if (scaleResetTimer != null)
            {
                scaleResetTimer.Stop();
                scaleResetTimer.Dispose();
                scaleResetTimer = null;
            }
        }




        private static void LoadComboConfigs()
        {
            comboConfigs = LoadUtils.LoadComboConfigs();
            monitoredKeys.Clear();
            keyToComboConfigsMap.Clear();

            foreach (var config in comboConfigs)
            {
                if (!string.IsNullOrEmpty(config.InputCore))
                {
                    monitoredKeys.Add(config.InputCore);

                    if (!keyToComboConfigsMap.ContainsKey(config.InputCore))
                    {
                        keyToComboConfigsMap[config.InputCore] = new List<ComboConfig>();
                    }
                    keyToComboConfigsMap[config.InputCore].Add(config);
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


        private static void CastMagicSkill(BGUCharacterCS character, ComboConfig combo, string type)
        {

            Utils.TryRunOnGameThread((Action)delegate
                {
                    if (type == "magic")
                    {
                        Helper.CastVigorSkillByID((BGUPlayerCharacterCS)character, combo.skillID, combo?.UnitScale ?? 1, combo?.MagicSkillID ?? 0, combo?.Scale3D ?? 1);
                    }

                    if (type == "bossLabel")
                    {
                        Helper.CastVigorSkillByModel((BGUPlayerCharacterCS)character, combo.bossLabel, combo.type ?? "", combo?.MagicSkillID ?? 0, combo?.resetBack ?? false, combo?.RecoverSkillID ?? 10199);
                    }
                    if (type == "RushSkill")
                    {
                        Helper.doPhantomRushSkill((BGUPlayerCharacterCS)character, combo.RushDir ?? "Forward");
                    }
                    if (type == "TRANS")
                    {
                        Helper.CastTranskillByID((BGUPlayerCharacterCS)character, combo?.ResId ?? 0, combo?.MagicSkillID ?? 0);
                    }

                });
        }


        [HarmonyPatch(typeof(UInputPreProcEvent), "OnAnyKeyTriggerEvent")]
        [HarmonyPrefix]
        private static void OnAnyKeyTriggerEvent(FKey Key)
        {
            if (!!Helper.is_bian_mod_stop)
            {
                return;
            }
            if (keyToComboConfigsMap.Count == 0)
            {
                return;
            }
            if (Helper.isPlayVigorSkillByID)
            {
                return;
            }
            string keyName = "";
            if (Key != null)
            {
                keyName = Key.GetFName().ToString();
                inputCodeStr += keyName;
            }

            var strFinal = inputCodeStr?.ToLower();
            Log.Info($"OnAnyKeyTriggerEvent keyName: {keyName} ,inputCodeStr:{strFinal},ActionsByInput.Count:{ActionsByInput?.Count}");
            if (ActionsByInput != null && ActionsByInput?.Count > 0)
            {
                var matchItem = ActionsByInput.FirstOrDefault(item => strFinal?.Contains(item?.code?.ToLower()) ?? false
                );

                if (matchItem != null && matchItem?.afterActions?.Count > 0)
                {
                    var rule = new Rule();
                    inputCodeStr = null;
                    rule?.DoAfterActions(matchItem.afterActions);
                }
                ;



            }
            if (inputCodeStr != null && inputCodeStr?.Length > 20)
            {
                inputCodeStr = null;
            }
            if (string.IsNullOrEmpty(keyName) || !keyToComboConfigsMap.ContainsKey(keyName))
            {
                return;
            }

            var character = Helper.GetBGUPlayerCharacterCS();
            Helper.LogInfoOnce($"OnAnyKeyTriggerEvent character.name:{character?.GetName()}");
            if (character == null || !character.PathName.Contains("Unit_Player_Wukong")) return;

            UAnimInstance animInstance = character.Mesh.GetAnimInstance();
            var currMontage = animInstance?.GetCurrentActiveMontage();
            var currentPosition = animInstance?.Montage_GetPosition(currMontage);
            GetCharacterStance(character, out bool isChuogun, out bool isLigun, out bool isPigun);
            var target = BGUFunctionLibraryCS.BGUGetTarget(character) as BGUCharacterCS;

            // 直接获取该按键对应的所有规则
            var keyCombos = keyToComboConfigsMap[keyName];



            var matchedCombo = keyCombos.FirstOrDefault(combo =>
            {
                // 检查动画条件
                if (!string.IsNullOrEmpty(combo.nowMontage))
                {
                    if (currMontage == null) return false;
                    string fullPath = currMontage.PathName;
                    if (!fullPath.Contains(combo.nowMontage) || currentPosition < combo.rate)
                        return false;
                }

                // 检查规则条件
                var rule = new SkillMappingRule
                {
                    Condition = combo.Condition,
                    conditionValue = combo.conditionValue
                };

                return combo.Condition == SkillMapCondition.any ||
                       IsSkillMappingRuleMatch(rule, character, isChuogun, isLigun, isPigun, target);
            });


            // 找到匹配的combo后执行相应技能
            if (matchedCombo != null)
            {

                if (matchedCombo?.afterActions != null && matchedCombo?.afterActions?.Count > 0)
                {
                    var rule = new Rule();
                    var method = typeof(Rule).GetMethod("DoAfterActions");
                    if (method == null)
                    {
                        Log.Info($"do rule no method");
                        return;
                    }

                    rule?.DoAfterActions(matchedCombo.afterActions);
                }
                else if (matchedCombo.bossLabel != null)
                {
                    CastMagicSkill(character, matchedCombo, "bossLabel");
                }
                else if (matchedCombo.type == "magic")
                {
                    CastMagicSkill(character, matchedCombo, "magic");
                }
                else if (matchedCombo.type == "RushSkill")
                {
                    CastMagicSkill(character, matchedCombo, "RushSkill");
                }
                else if (matchedCombo.type == "TRANS")
                {
                    CastMagicSkill(character, matchedCombo, "TRANS");
                }

                else
                {
                    BUS_EventCollectionCS.Get(character).Evt_RequestSmartCastSkill.Invoke(
                        matchedCombo.skillID, null, EMontageBindReason.NormalSkill, false);
                }
            }
        }

    }
}
