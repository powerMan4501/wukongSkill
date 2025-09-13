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




public enum SkillMapCondition
{
    StancePoke,    // 戳棍姿态
    StanceProp,//立棍
    StanceHeavy,//劈棍
    hasBuff,
    disTance,
    hasTalent,//拥有某个天赋
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
        private static Dictionary<int, List<Rule>> effectRulesMap = new Dictionary<int, List<Rule>>();

        // 监听的BuffID
        private static Dictionary<int, List<Rule>> buffRulesMap = new Dictionary<int, List<Rule>>();

        // 监听的动画
        private static Dictionary<string, List<Rule>> montageRulesMap = new Dictionary<string, List<Rule>>();

        private static List<SkillMappingRule> AllSkillMappingRules = new List<SkillMappingRule>();
        private static bool isBuffConfigsLoaded = false; // 添加静态标志变量

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
                if (maxRetries > 0)
                {
                    Helper.DelayExecute(retryInterval, () => GetBuffDispListWithRetry(5000, maxRetries - 1));
                }
            }
            else
            {

                // 成功获取到buffDispList，继续加载其他配置
                LoadUtils.LoadAndApplySummon();
                LoadUtils.LoadAndApplyChargeSkill();
                LoadUtils.LoadAndApplyBulletExpand();
                LoadUtils.LoadAndApplyBulletComm();
                LoadUtils.LoadAndApplyProjectileMove();
                LoadUtils.LoadAndApplyProjectileDisp();
                LoadUtils.LoadAndApplySkillDesc();
                LoadUtils.LoadAndApplySkillEffect();
                LoadUtils.LoadAndApplyBuffDispConfigs();
                LoadUtils.LoadAndApplyBuff();
                LoadUtils.ModifyIronData();
                LoadUtils.ModifyPlayCtrlDescData();
                LoadUtils.LoadAndApplyPassiveSkills();
                LoadUtils.ModifySuitDesc();
                NotifyUtils.LoadSweepConfig();
                NotifyUtils.LoadNotifyData();
                LoadUtils.ModifyHP();

                LoadUtils.LoadAnimRulesBySweepCheck();
                isBuffConfigsLoaded = true;
            }
        }

        public static void loadAllStaticData(bool forceUpdate = false, int delayTime = 1000)
        {


            if (isBuffConfigsLoaded && !forceUpdate) { return; }
            // 加载技能映射规则
            LoadUtils.LoadAllSkillMappingRules();
            LoadComboConfigs();//全部连招
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




        public static void RegisterManager()
        {
            Manager.GetModelManager().InitConfig();
            Manager.GetModelManager().BindEvents();


            loadAllStaticData(true, 0);
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
                        // 夜叉王飞轮往前增加700
                        var playerLocation = ProjectileSpawnInfo.Spawner.GetActorLocation();
                        var xyz = ProjectileSpawnInfo.Spawner.GetActorForwardVector();
                        var forwardVector = ProjectileSpawnInfo.Spawner.GetActorForwardVector();
                        forwardVector.Y *= 700;
                        forwardVector.X *= 700;
                        ProjectileSpawnInfo.SpawnPosition = playerLocation + forwardVector;
                    }

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



        [HarmonyPatch(typeof(BUS_GSEventCollection), "Evt_TriggerSkillEffectBySkillMultiCast_Implementation")]
        [HarmonyPrefix]
        private static void TriggerSkillEffectBySkillMultiCast(ref int EffectID, ref AActor Caster, ref AActor Target, ref FEffectInstReq EffectInstReq)
        {
            if (Caster == null || !IsPlayer(Caster.PathName))
            {
                return;
            }
            // Log.Info($"Evt_TriggerSkillEffect EffectID:{EffectID}");
            // 检查是否有对应的效果规则
            if (!effectRulesMap.ContainsKey(EffectID))
            {

                return;
            }


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


        // 通用的buff互斥处理方法
        private static void HandleBuffMutex(AActor caster, int currentBuffId, List<int> mutexBuffIds)
        {
            foreach (var buffId in mutexBuffIds.Where(id => id != currentBuffId))
            {
                BGUFunctionLibraryCS.BGURemoveBuffImmediately(caster, buffId, EBuffEffectTriggerType.Remove);
            }
        }

        [HarmonyPatch(typeof(BUS_GSEventCollection), "Evt_BuffAdd_Multicast_Invoke")]
        [HarmonyPrefix]
        private static void BuffAdd_Multicast(ref int BuffID, AActor Caster, AActor RootCaster, ref float Duration)
        {
            if (Manager.GetModelManager().Config.CanLogDebug("[PATCH]BuffAdd_Multicast"))
            {

            }

            if (Caster == null || !IsPlayer(Caster?.PathName))
            {
                return;
            }
            // if (BuffID != 1015)
            // {
            //     Log.Info($"Evt_BuffAdd_Multicast_Invoke {BuffID}");
            // }

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

        private static bool IsPlayer(string name)
        {
            if (name != null && name.ToLower().IndexOf("unit_player") > -1)
            {
                return true;
            }
            return false;
        }
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
            if (currentMontage.Contains("Animation/Player/Wukong/"))
            {
                Helper.updateIsPlayVigorSkillByID(false);
            }
            if (!currentMontage.Contains("AM_Wukong_Dodge"))
            {
                comboMontage = Montage.PathName;
            }
            // currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            var mgr = Manager.GetModelManager();
            var currentModel = mgr.GetCurrentModel(__instance.GetOwner() as BGUPlayerCharacterCS) as BaseModel;
            var length = Montage.GetPlayLength() * 1000;
            var playRate = 1f;
            NotifyUtils.handleNotify(Montage);


            if (currentModel != null && currentModel.PlayTimeRate > 0)
            {
                playRate = currentModel.PlayTimeRate;
            }
            var PlayTimeRate_ = PlayTimeRate;
            if (currentModel?.skillSpeedRate > 0)
            {
                PlayTimeRate_ = (float)currentModel.skillSpeedRate; //动画播放速率
            }
            // montageName.Contains(filter.Name)


            // 检查是否有对应的动画规则
            if (!montageRulesMap.Any(x => !string.IsNullOrEmpty(x.Key) && currentMontage.Contains(x.Key)))
            {
                return;
            }
            var matchingRules = montageRulesMap.FirstOrDefault(x => currentMontage.Contains(x.Key)).Value;
            if (matchingRules.Count == 0)
            {
                return;
            }



            // 一个循环只执行一次分身
            bool hasExecutedSkill = false;
            bool hasCaledWeapon = false;
            foreach (var ruleItem in matchingRules)
            {

                if (!hasExecutedSkill && ruleItem?.skillID_fs > 0) // 增加标志判断
                {
                    Helper.FenshenGSTryCastSkill((int)ruleItem.skillID_fs, false);
                    hasExecutedSkill = true; // 设置标志为true
                }
                if (!hasCaledWeapon && ruleItem?.scaleWeaponNum > 1)
                {
                    OnScaleWeapon((float)ruleItem.scaleWeaponNum);
                    hasCaledWeapon = true;
                }
                else
                {
                    hasCaledWeapon = false; // 重置标志
                    OnScaleWeapon(1);
                }

                if (ruleItem?.speedRate > 0)
                {
                    PlayTimeRate_ = (float)ruleItem.speedRate; //动画播放速率
                }
                ruleItem.DoRule(length, playRate, Montage, ruleItem);
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


            //天赋条件判断
            bool talentMatch = rule.Condition == SkillMapCondition.hasTalent &&
                             rule.conditionValue > 0 &&
                             BGUFunctionLibraryCS.BGUHasTalentByID(character, (int)rule.conditionValue);
            // 距离条件判断
            bool distanceMatch = rule.Condition == SkillMapCondition.disTance &&
                                 rule.conditionValue >= 0 &&
                                 target != null &&
                                 character.GetDistanceTo(target) >= rule.conditionValue;

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
        private static void OnScaleWeapon(float num = 2)
        {

            // 获取当前玩家
            var player = Helper.GetBGUPlayerCharacterCS();
            if (player == null || scaleWeaponNum == num) return;
            scaleWeaponNum = num;
            // 获取角色的朝向向量
            var forwardVector = player.GetActorForwardVector();
            if (forwardVector == null) return;
            List<UActorComponent> componentsByTag = player.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>());
            if (componentsByTag != null && componentsByTag.Count > 0)
            {
                foreach (var uStaticMeshComponent in componentsByTag)
                {

                    if (uStaticMeshComponent != null && uStaticMeshComponent.GetName() != null && uStaticMeshComponent.GetName().ToLower().Contains("weapon"))
                    {
                        var item_ = uStaticMeshComponent as USkeletalMeshComponent;
                        item_.SetRelativeScale3D(new FVector(num, 1, 1));
                    }
                }
                // 重置计时器
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

            List<UActorComponent> componentsByTag = player.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>());
            if (componentsByTag != null && componentsByTag.Count > 0)
            {
                foreach (var uStaticMeshComponent in componentsByTag)
                {
                    if (uStaticMeshComponent != null && uStaticMeshComponent.GetName() != null && uStaticMeshComponent.GetName().ToLower().Contains("weapon"))
                    {
                        var item_ = uStaticMeshComponent as USkeletalMeshComponent;
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


        [HarmonyPatch(typeof(BUS_GSEventCollection), "Evt_SmartCastSkillTryMultiCast_Implementation")]
        [HarmonyPrefix]
        private static void SmartCastSkillTryMultiCast(ref int ID, ref List<int> RuleIDList)
        {
            if (Manager.GetModelManager().Config.CanLogDebug("[PATCH]SmartCastSkill"))
            {
                // Log.Info($"bian: 真实的id SmartCastSkillTryMultiCast -->{ID}");
            }

            var character = Helper.GetBGUPlayerCharacterCS();
            if (character == null) return;

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
            // var bufferId = GetBufferIdForSkill(ID);

            // 添加连招相关buff
            if (IsComboSkill(ID))
            {
                BGUFunctionLibraryCS.BGUAddBuff(character, character, 289, EBuffSourceType.GM, 3000);
            }

            // if (bufferId > 0)
            // {
            //     BGUFunctionLibraryCS.BGUAddBuff(character, character, bufferId, EBuffSourceType.GM, 4000);
            // }

            // 处理技能映射规则
            ProcessSkillMappingRules(ref ID, currentId, character, isChuogun, isLigun, isPigun);
        }




        private static int GetBufferIdForSkill(int skillId)
        {
            var bufferMappings = new Dictionary<int, int>
            {
                {10801, 888666021},
                {10802, 888666022},
                {10803, 888666023},
                {10804, 888666024},
                {10805, 888666025}
            };

            // 清理之前的buff
            if (bufferMappings.ContainsValue(skillId))
            {
                var character = Helper.GetBGUPlayerCharacterCS();
                var buffToRemove = bufferMappings.FirstOrDefault(x => x.Value == skillId).Key;
                if (buffToRemove > 0)
                {
                    BGUFunctionLibraryCS.BGURemoveBuffImmediately(character, buffToRemove, EBuffEffectTriggerType.Remove);
                }
            }

            return bufferMappings.ContainsKey(skillId) ? bufferMappings[skillId] : 0;
        }



        private static bool IsComboSkill(int skillId)
        {
            int[] comboSkills = { 10705, 10706, 10720, 10721, 50003, 50005, 50007, 50001 };
            return comboSkills.Contains(skillId);
        }

        private static void ProcessSkillMappingRules(ref int ID, int currentId, BGUCharacterCS character,
            bool isChuogun, bool isLigun, bool isPigun)
        {
            var mapArr = AllSkillMappingRules.Where(r => r.OriginalId == currentId).ToList();
            if (!mapArr.Any()) return;

            var target = BGUFunctionLibraryCS.BGUGetTarget(character) as BGUCharacterCS;

            // 优先处理可重复规则
            var repeatableRules = mapArr.Where(r => r.canRepeat.HasValue && r.canRepeat.Value).ToList();
            var matchItem = repeatableRules.FirstOrDefault(r =>
                IsSkillMappingRuleMatch(r, character, isChuogun, isLigun, isPigun, target));

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
                IsSkillMappingRuleMatch(r, character, isChuogun, isLigun, isPigun, target));

            if (matchItem_ != null)
            {
                ID = matchItem_.MappedId;
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


        private static void CastMagicSkill(BGUCharacterCS character, ComboConfig combo)
        {
            Helper.DelayExecute(10, () =>
            {
                Utils.TryRunOnGameThread((Action)delegate
                {
                    Helper.CastVigorSkillByID((BGUPlayerCharacterCS)character, combo.skillID, combo?.backTime ?? 0, combo?.MagicSkillID ?? 0);
                });
            });
        }


        [HarmonyPatch(typeof(UInputPreProcEvent), "OnAnyKeyTriggerEvent")]
        [HarmonyPrefix]

        private static void OnAnyKeyTriggerEvent(FKey Key)
        {
            if (keyToComboConfigsMap.Count == 0)
            {
                return;
            }

            string keyName = "";
            if (Key != null)
            {
                keyName = Key.GetFName().ToString();
            }
            if (string.IsNullOrEmpty(keyName) || !keyToComboConfigsMap.ContainsKey(keyName))
            {
                return;
            }

            var character = Helper.GetBGUPlayerCharacterCS();
            if (character == null) return;

            UAnimInstance animInstance = character.Mesh.GetAnimInstance();
            var currMontage = animInstance?.GetCurrentActiveMontage();


            var currentPosition = animInstance?.Montage_GetPosition(currMontage);
            GetCharacterStance(character, out bool isChuogun, out bool isLigun, out bool isPigun);
            var target = BGUFunctionLibraryCS.BGUGetTarget(character) as BGUCharacterCS;

            // 直接获取该按键对应的所有规则
            var keyCombos = keyToComboConfigsMap[keyName];
            foreach (var combo in keyCombos)
            {
                // 如果nowMontage有值，才检查动画相关条件
                if (!string.IsNullOrEmpty(combo.nowMontage))
                {
                    if (currMontage != null)
                    {
                        string fullPath = currMontage.PathName;
                        if (fullPath.Contains(combo.nowMontage) && currentPosition >= combo.rate)
                        {
                            var rule = new SkillMappingRule
                            {
                                Condition = combo.Condition,
                                conditionValue = combo.conditionValue
                            };

                            if (combo.Condition == SkillMapCondition.any ||
                                IsSkillMappingRuleMatch(rule, character, isChuogun, isLigun, isPigun, target))
                            {
                                if (combo.type == "magic")
                                {
                                    CastMagicSkill(character, combo);
                                    break;
                                }

                                BUS_EventCollectionCS.Get(character).Evt_RequestSmartCastSkill.Invoke(
                                    combo.skillID, null, EMontageBindReason.NormalSkill, false);
                                break;
                            }
                        }
                    }

                }
                else
                {
                    var rule = new SkillMappingRule
                    {
                        Condition = combo.Condition,
                        conditionValue = combo.conditionValue
                    };

                    if (combo.Condition == SkillMapCondition.any ||
                        IsSkillMappingRuleMatch(rule, character, isChuogun, isLigun, isPigun, target))
                    {
                        if (combo.type == "magic")
                        {
                            CastMagicSkill(character, combo);
                            break;
                        }
                        BUS_EventCollectionCS.Get(character).Evt_RequestSmartCastSkill.Invoke(
                            combo.skillID, null, EMontageBindReason.NormalSkill, false);
                        break; // 找到匹配的规则后立即返回
                    }
                }
            }
        }

    }
}
