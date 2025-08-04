using b1.EventDelDefine;
using b1;
using CSharpModBase;
using HarmonyLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using System.Reflection;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using BtlShare;
using ArchiveB1;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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


        public class BuffDispConfig
        {
            public int ID { get; set; }
            public int BuffID { get; set; }
            public int CasterResID { get; set; }
            public int OwnerResID { get; set; }
            public int IsUseDispConfig { get; set; }
            public List<EffectConfig> EnterFX { get; set; }
            public List<object> TickingCurveParam { get; set; }
            public List<object> AlmostLeaveFX { get; set; }
            public List<object> LeaveFX { get; set; }
            public List<object> DamageFXSetting { get; set; }
            public List<object> MaterialSetting { get; set; }
            public int ForceDisplay { get; set; }
        }

        public class EffectConfig
        {
            public string PSPath { get; set; }
            public int Scale { get; set; }
            public int IsAttach { get; set; }
            public string AttachName { get; set; }
            public double WorldOffsetX { get; set; }
            public double WorldOffsetY { get; set; }
            public double WorldOffsetZ { get; set; }
            public int UseScaleFit { get; set; }
            public int IsAttachToSkin { get; set; }
            public string SkelMeshParamName { get; set; }
            public string AddTags { get; set; }
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

        /// 加载并应用BuffDisp配置到游戏数据库中
        public static int LoadAndApplyBuffDispConfigs(string configDirectory = null)
        {
            // 如果没有提供目录路径，使用默认路径
            if (configDirectory == null)
            {
                configDirectory = Path.Combine("CSharpLoader", "Mods", "bian", "BuffDisp");
            }

            var buffDispConfigs = LoadAllBuffDispConfigs(configDirectory);
            var buffDispList = BGW_GameDB.GetAllBuffDispDesc();
            Log.Info($"LoadAndApplyBuffDispConfigs buffDispList:{buffDispConfigs.Count}");
            if (buffDispList != null && buffDispList.Count > 0 && buffDispConfigs != null)
            {
                // 获取第一个BuffDispDesc作为模板
                var templateBuffDisp = buffDispList.First().Value;
                int processedCount = 0;

                foreach (var dispConfig in buffDispConfigs)
                {
                    try
                    {
                        // 克隆模板对象
                        var newBuffDisp = (FUStBuffDispDesc)templateBuffDisp.Clone();

                        // 设置新BuffDisp的属性
                        newBuffDisp.ID = dispConfig.ID;
                        newBuffDisp.BuffID = dispConfig.BuffID;
                        newBuffDisp.CasterResID = dispConfig.CasterResID;
                        newBuffDisp.OwnerResID = dispConfig.OwnerResID;
                        newBuffDisp.IsUseDispConfig = (EGSYesNo)dispConfig.IsUseDispConfig;
                        newBuffDisp.ForceDisplay = (EGSYesNo)dispConfig.ForceDisplay;

                        // 处理EnterFX
                        if (dispConfig.EnterFX != null && dispConfig.EnterFX.Count > 0)
                        {
                            // 创建一个新的 FUStFXSetting 列表
                            var newEnterFX = new List<FUStFXSetting>();

                            // 将每个 EffectConfig 转换为 FUStFXSetting
                            foreach (var fxConfig in dispConfig.EnterFX)
                            {
                                var newFx = new FUStFXSetting();
                                newFx.PSPath = fxConfig.PSPath;
                                newFx.Scale = fxConfig.Scale;
                                newFx.IsAttach = (EGSYesNo)fxConfig.IsAttach;
                                newFx.AttachName = fxConfig.AttachName;
                                newFx.UseScaleFit = (EGSYesNo)fxConfig.UseScaleFit;
                                newFx.IsAttachToSkin = (EGSYesNo)fxConfig.IsAttachToSkin;
                                newFx.SkelMeshParamName = fxConfig.SkelMeshParamName;
                                newFx.AddTags = fxConfig.AddTags;

                                newEnterFX.Add(newFx);
                            }

                            // 使用反射来设置只读属性
                            var enterFXProperty = typeof(FUStBuffDispDesc).GetProperty("EnterFX");
                            if (enterFXProperty != null && enterFXProperty.CanWrite)
                            {
                                enterFXProperty.SetValue(newBuffDisp, newEnterFX);
                            }
                            else
                            {
                                // 如果属性不可写，尝试使用字段
                                var enterFXField = typeof(FUStBuffDispDesc).GetField("EnterFX", BindingFlags.NonPublic | BindingFlags.Instance);
                                if (enterFXField != null)
                                {
                                    enterFXField.SetValue(newBuffDisp, newEnterFX);
                                }
                            }
                        }



                        if (buffDispList.ContainsKey(dispConfig.BuffID))
                        {
                            buffDispList[dispConfig.BuffID] = newBuffDisp;
                            Log.Info($"Updated existing BuffDisp config for ID: {dispConfig.BuffID}");
                        }
                        else
                        {
                            // 使用BuffID作为键，将新的BuffDisp添加到字典中
                            buffDispList.Add(dispConfig.BuffID, newBuffDisp);
                            Log.Info($"Added new BuffDisp config for ID: {dispConfig.BuffID}");
                        }


                        Log.Info($"Successfully added BuffDisp config for ID: {dispConfig.ID}");
                        processedCount++;
                    }
                    catch (Exception ex)
                    {
                        Log.Error($"Failed to process BuffDisp config for ID {dispConfig.ID}: {ex.Message}");
                    }
                }

                Log.Info($"Total processed BuffDisp configs: {processedCount}");
                return processedCount;
            }
            else
            {
                Log.Error("Failed to load LoadAndApplyBuffDispConfigs configs or template BuffDisp is not available");
                return 0;
            }
        }
        public static int LoadAndApplyBuff(string configDirectory = null)
        {
            // 如果没有提供目录路径，使用默认路径
            if (configDirectory == null)
            {
                configDirectory = Path.Combine("CSharpLoader", "Mods", "bian", "BuffDesc");
            }

            var buffConfigs = LoadAllBuffConfigs(configDirectory);
            var buffList = BGW_GameDB.GetAllBuffDesc();

            if (buffList != null && buffList.Count > 0 && buffConfigs != null)
            {
                // 获取第一个BuffDispDesc作为模板
                var templateBuffDisp = buffList.First().Value;
                int processedCount = 0;

                foreach (var buffConfig in buffConfigs)
                {
                    try
                    {
                        // 克隆模板对象
                        var newBuffDisp = (FUStBuffDesc)templateBuffDisp.Clone();

                        // 设置新BuffDisp的属性
                        newBuffDisp.ID = buffConfig.ID;
                        newBuffDisp.BuffActiveCondition = buffConfig.BuffActiveCondition;
                        newBuffDisp.BuffLayerCounterType = buffConfig.BuffLayerCounterType;
                        newBuffDisp.BuffCategory = buffConfig.BuffCategory;
                        newBuffDisp.CanRemoveWhenAttackHit = buffConfig.CanRemoveWhenAttackHit;
                        newBuffDisp.CanRemoveWhenAttacked = buffConfig.CanRemoveWhenAttacked;

                        newBuffDisp.Duration = buffConfig.Duration;
                        newBuffDisp.Delay = buffConfig.Delay;
                        newBuffDisp.Interval = buffConfig.Interval;
                        newBuffDisp.MaxLayer = buffConfig.MaxLayer;
                        newBuffDisp.TargetBase = buffConfig.TargetBase;
                        newBuffDisp.TargetCount = buffConfig.TargetCount;
                        newBuffDisp.TargetFilter = buffConfig.TargetFilter;
                        newBuffDisp.TargetTypeFilter = buffConfig.TargetTypeFilter;
                        newBuffDisp.Range = buffConfig.Range;



                        // 处理EnterFX
                        if (buffConfig.BuffEffects != null && buffConfig.BuffEffects.Count > 0)
                        {
                            // 创建一个新的 FUStFXSetting 列表
                            var newEnterFX = new List<FUStBuffEffectAttr>();

                            // 将每个 EffectConfig 转换为 FUStFXSetting
                            foreach (var fxConfig in buffConfig.BuffEffects)
                            {
                                var newFx = new FUStBuffEffectAttr();
                                newFx.EffectTrigger = fxConfig.EffectTrigger;
                                newFx.EffectType = fxConfig.EffectType;
                                newFx.EffectTargetSelectType = fxConfig.EffectTargetSelectType;

                                if (fxConfig.EffectParamsString != null && fxConfig.EffectParamsString.Count > 0)
                                {
                                    newFx.EffectParamsString.AddRange(fxConfig.EffectParamsString);
                                }


                                if (fxConfig.EffectParams != null && fxConfig.EffectParams.Count > 0)
                                {
                                    newFx.EffectParams.AddRange(fxConfig.EffectParams);
                                }


                                if (fxConfig.EffectParamsFloat != null && fxConfig.EffectParamsFloat.Count > 0)
                                {
                                    newFx.EffectParamsFloat.AddRange(fxConfig.EffectParamsFloat);
                                }


                                newEnterFX.Add(newFx);
                            }


                        }




                        if (buffList.ContainsKey(buffConfig.ID))
                        {
                            buffList[buffConfig.ID] = newBuffDisp;
                        }
                        else
                        {
                            // 使用BuffID作为键，将新的BuffDisp添加到字典中
                            buffList.Add(buffConfig.ID, newBuffDisp);
                        }

                        Log.Info($"Successfully 添加buff成功 BuffID: {buffConfig.ID}");
                        processedCount++;
                    }
                    catch (Exception ex)
                    {
                        Log.Error($"Failed to process LoadAndApplyBuff config for BuffID {buffConfig.ID}: {ex.Message}");
                    }
                }

                Log.Info($"Total processed LoadAndApplyBuff configs: {processedCount}");
                return processedCount;
            }
            else
            {
                Log.Error("Failed to load LoadAndApplyBuff configs or template LoadAndApplyBuff is not available");
                return 0;
            }
        }

        public static FUStBuffDesc AddNewBuff_cpoy(int NewBuffID, int CopybuffID)
        {
            FUStBuffDesc fUStBuffDesc = GameDBRuntime.GetFUStBuffDesc(NewBuffID);
            if (fUStBuffDesc != null)
            {
                return fUStBuffDesc;
            }
            if (BGW_GameDB.GetAllBuffDesc().TryGetValue(CopybuffID, out var value))
            {
                FUStBuffDesc val = new FUStBuffDesc();
                val.MergeFrom(value);
                val.ID = NewBuffID;
                BGW_GameDB.GetAllBuffDesc().Add(val.ID, val);
            }
            return value;
        }
        public static void RegisterManager()
        {
            Manager.GetModelManager().InitConfig();
            Manager.GetModelManager().BindEvents();


            // 加载技能映射规则
            string configPath = Path.Combine("CSharpLoader", "Mods", "bian", "skillMaping");
            LoadAllSkillMappingRules(configPath);
            // 加载并应用BuffDisp配置
            LoadAndApplyBuffDispConfigs();
            LoadAndApplyBuff();


            // 在这里可以将buffDispConfigs插入到游戏中的数据
            if (harmony == null)
            {
                harmony = new Harmony("mod.reece.bian");
                var assembly = Assembly.GetExecutingAssembly();
                harmony.PatchAll(assembly);
            }
        }
        public static List<BuffDispConfig> LoadAllBuffDispConfigs(string configDirectory)
        {
            if (!Directory.Exists(configDirectory))
            {
                Log.Error($"BuffDisp config directory not found: {configDirectory}");
                try
                {
                    Directory.CreateDirectory(configDirectory);
                    Log.Info($"Created BuffDisp config directory: {configDirectory}");
                }
                catch (Exception ex)
                {
                    Log.Error($"Failed to create BuffDisp config directory: {ex.Message}");
                    return new List<BuffDispConfig>();
                }
            }

            List<BuffDispConfig> allConfigs = new List<BuffDispConfig>();

            // 加载所有JSON文件
            foreach (string file in Directory.GetFiles(configDirectory, "*.json"))
            {
                try
                {
                    string jsonContent = File.ReadAllText(file);

                    // 配置JsonSerializer以正确处理数据
                    var settings = new JsonSerializerSettings
                    {
                        Converters = new List<JsonConverter> { new StringEnumConverter() }
                    };

                    var configs = JsonConvert.DeserializeObject<List<BuffDispConfig>>(jsonContent, settings);
                    if (configs != null)
                    {
                        allConfigs.AddRange(configs);
                        Log.Info($"Loaded {configs.Count} BuffDisp configs from {Path.GetFileName(file)}");
                    }
                }
                catch (Exception ex)
                {
                    Log.Error($"Error loading BuffDisp configs from {file}: {ex.Message}");
                }
            }

            Log.Info($"Total loaded BuffDisp configs: {allConfigs.Count}");
            return allConfigs;
        }

        public static List<FUStBuffDesc> LoadAllBuffConfigs(string configDirectory)
        {
            if (!Directory.Exists(configDirectory))
            {
                Log.Error($"BuffDisp config directory not found: {configDirectory}");
                try
                {
                    Directory.CreateDirectory(configDirectory);
                    Log.Info($"Created BuffDisp config directory: {configDirectory}");
                }
                catch (Exception ex)
                {
                    Log.Error($"Failed to create BuffDisp config directory: {ex.Message}");
                    return new List<FUStBuffDesc>();
                }
            }

            List<FUStBuffDesc> allConfigs = new List<FUStBuffDesc>();

            // 加载所有JSON文件
            foreach (string file in Directory.GetFiles(configDirectory, "*.json"))
            {
                try
                {
                    string jsonContent = File.ReadAllText(file);

                    // 配置JsonSerializer以正确处理数据
                    var settings = new JsonSerializerSettings
                    {
                        Converters = new List<JsonConverter> { new StringEnumConverter() }
                    };

                    var configs = JsonConvert.DeserializeObject<List<FUStBuffDesc>>(jsonContent, settings);
                    if (configs != null)
                    {
                        allConfigs.AddRange(configs);
                        Log.Info($"Loaded {configs.Count} BuffDisp configs from {Path.GetFileName(file)}");
                    }
                }
                catch (Exception ex)
                {
                    Log.Error($"Error loading BuffDisp configs from {file}: {ex.Message}");
                }
            }

            Log.Info($"Total loaded BuffDisp configs: {allConfigs.Count}");
            return allConfigs;
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
        private static List<SkillMappingRule> LoadSkillMappingRulesFromJson(string filePath)
        {
            try
            {
                string jsonContent = File.ReadAllText(filePath);

                // 配置JsonSerializer以正确处理枚举
                var settings = new JsonSerializerSettings
                {
                    Converters = new List<JsonConverter> { new StringEnumConverter() }
                };

                var rules = JsonConvert.DeserializeObject<List<SkillMappingRule>>(jsonContent, settings);
                return rules ?? new List<SkillMappingRule>();
            }
            catch (Exception ex)
            {
                Log.Error($"Failed to load skill mapping rules from {filePath}: {ex.Message}");
                return new List<SkillMappingRule>();
            }
        }

        public static void LoadAllSkillMappingRules(string configDirectory)
        {
            if (!Directory.Exists(configDirectory))
            {
                Log.Error($"Config directory not found: {configDirectory}");
                // 尝试创建目录
                try
                {
                    Directory.CreateDirectory(configDirectory);
                    Log.Info($"Created config directory: {configDirectory}");
                }
                catch (Exception ex)
                {
                    Log.Error($"Failed to create config directory: {ex.Message}");
                    return;
                }
            }

            // 清空现有规则
            AllSkillMappingRules.Clear();

            // 加载所有JSON文件
            foreach (string file in Directory.GetFiles(configDirectory, "*.json"))
            {
                try
                {
                    var rules = LoadSkillMappingRulesFromJson(file);
                    Log.Info($"Loaded {rules.Count} rules from {Path.GetFileName(file)}");
                    // 直接将规则添加到总列表中，不需要分类
                    AllSkillMappingRules.AddRange(rules);
                }
                catch (Exception ex)
                {
                    Log.Error($"Error loading rules from {file}: {ex.Message}");
                }
            }

            Log.Info($"Total loaded rules: {AllSkillMappingRules.Count}");
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
                        forwardVector.Y *= 800;  // 只在Y轴方向增加800单位
                        forwardVector.X *= 800;  // 只在X轴方向增加800单位
                        ProjectileSpawnInfo.SpawnPosition = playerLocation + forwardVector;
                        Log.Info($"夜叉王飞轮子弹Y+800   forwardVector:{forwardVector} SpawnPosition:{ProjectileSpawnInfo.SpawnPosition}");
                    }

                }

            }

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
            Log.Info($"buff {BuffID} add  ,Duration:{Duration} RootCaster:{RootCaster.PathName}");
            if (BuffID == 287 || BuffID == 293)
            {
                // 劈棍和戳棍识破buff增加到0.9秒
                Duration = 1000;
                BGUFunctionLibraryCS.BGUAddBuff(RootCaster, RootCaster, 218, EBuffSourceType.GM, Duration);//给识破buff加无敌
                //218
                Log.Info($"buff {BuffID} add  ,Duration:{Duration} RootCaster:{RootCaster.PathName}");
            }


            if (BuffID == 288)
            {
                // 识破成功，加识破成功专属buff 888666029, 霸体和棍势
                BGUFunctionLibraryCS.BGUAddBuff(RootCaster, RootCaster, 888666029, EBuffSourceType.GM, Duration);//给识破buff加无敌
                //218
                
            }

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


            // 遍历所有规则
            // var mapArr = AllSkillMappingRules.Where(r => r.OriginalId == currentId); 

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
                    Log.Info($"可以重复转化 matchItem:{matchItem?.desc} {matchItem.MappedId}");

                    ID = matchItem.MappedId;
                    currentId = matchItem.MappedId;
                }

                // 重新过滤
                var newArr = AllSkillMappingRules.Where(r => r.OriginalId == currentId).ToList();
                var nonRepeatableRules = newArr.Where(r => !r.canRepeat.HasValue || !r.canRepeat.Value).ToList();
                var matchItem_ = nonRepeatableRules.FirstOrDefault(r => IsSkillMappingRuleMatch(r, character, isChuogun, isLigun, isPigun, target));
                if (matchItem_ != null)
                {
                    Log.Info($"不可以重复matchItem_:{matchItem_?.desc} {matchItem_.MappedId}");
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
        /*[HarmonyPatch(typeof(UInputPreProcEvent), "OnAnyKeyTriggerEvent")]
        [HarmonyPrefix]
        private static void OnAnyKeyTriggerEvent(FKey Key)
        {
            Log.Debug($"bian: [PATCH]OnAnyKeyTriggerEvent  --> {Key.GetFName()}");
        }*/

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
