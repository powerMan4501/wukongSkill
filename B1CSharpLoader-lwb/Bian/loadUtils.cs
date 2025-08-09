using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using UnrealEngine.Runtime;
using b1;
using BtlShare;
using ArchiveB1;
using CSharpModBase;
using BtlB1;
using Google.Protobuf.Collections;
using b1.Protobuf.DataAPI;




public class SummonConfig
{
    public string? desc { get; set; }
    public int ID { get; set; }
    public int? ResID { get; set; }
    public double? SummonAliveTime { get; set; }
    public string? SummonTamerTemplatePath { get; set; }
    public string? SummonBPTemplatePath { get; set; }
    public int? SummonUnitRotationType { get; set; }
    public int? SummonUnitLocationType { get; set; }
    public int? SelectPointRandom { get; set; }
    public int? PointSetCachedReqID { get; set; }
    public string? SummonDataAssetsPath { get; set; }
    public string? SummonSpawnEQSPath { get; set; }
    public string? SummonSpawnSceneItemTag { get; set; }
    public string? BornEffectPath { get; set; }
    public int? UseBornSkill { get; set; }
    public List<string>? BornMontagePathList { get; set; }
    public List<int>? BornSkillList { get; set; }
    public List<string>? DisappearMontagePathList { get; set; }
    public double? BornDelayTime { get; set; }
    public int? SummonTargetMethod { get; set; }
    public double? BornEffDisplayTime { get; set; }
    public double? DestroyDelayTime { get; set; }
    public List<int>? BuffList { get; set; }
    public double? InitSpeed { get; set; }
    public int? SyncBattleSC { get; set; }
    public int? IsCopyEquip { get; set; }
    public int? CopyAttrConfigID { get; set; }
    public int? IsDestroyWhenSummonerDead { get; set; }
    public int? IsSummonerAsMaster { get; set; }
    public double? BeforeBornTime { get; set; }
}

public class ChargeSkillBuffInfo
{
    public int BuffID { get; set; }
    public double BeginTimeInBeginStage { get; set; }
    public double EndTimeInEndStage { get; set; }
}

public class ChargeSkillConfig
{
    public string? desc { get; set; }
    public int ID { get; set; }
    public EGSYesNo? LoopCanMove { get; set; }
    public EGSYesNo? LoopCanRotate { get; set; }
    public EMoveSpeedType? ChargeMoveSpeedRate { get; set; }
    public List<ChargeSkillBuffInfo> ChargeSkillBuffInfoList { get; set; }
}



public class ProjectileDispConfig
{
    public int ID { get; set; }
    public int? ProjectileFXUseDBC { get; set; }
    public string ProjectileSpawnPSPath { get; set; }
    public string ProjectileSelfSpawnDBCPath { get; set; }
    public double? SpawnPStoSpawnInterval { get; set; }
    public double? BulletLowestSpdCanPlayPS { get; set; }
    public string BulletHitItemPSPath { get; set; }
    public string BulletHitUnitPSPath { get; set; }
    public string BulletLifeOverPSPath { get; set; }
    public string BeHitedProjectilePlayFXPath { get; set; }
    public string BeHitedProjectilePostAKPath { get; set; }
    public string FXDestroyImmediatelyTag { get; set; }
    public int? HitChrAudioID { get; set; }
    public string Guard { get; set; }
}


public class ProjectileMoveConfig
{
    public int ID { get; set; }
    public int? ProjectileMoveModeType { get; set; }
    public int? ProjectileSpdType { get; set; }
    public double? ProjectileFlyTime { get; set; }
    public int? MoveClampToLand { get; set; }
    public int? MoveAlignToLand { get; set; }
    public string Guard { get; set; }
}



public class BulletCommConfig
{
    public int ID { get; set; }
    public string? ProjectileBPTemplatePath { get; set; }
    public int? ProjectileIsFresh { get; set; }
    public int? ProjectileType { get; set; }
    public double? ProjectileTypeParam { get; set; }
    public double? ProjectileDelayDestroyTime { get; set; }
    public double? ProjectileLifeTime { get; set; }
    public double? ProjectileLifeSpeed { get; set; }
    public int? LifeOverWithDetach { get; set; }
    public string? ProjectileAnimPath { get; set; }
    public int? ProjectileNumLimit { get; set; }
    public int? BeHitedProjectileSwitchID { get; set; }
    public string? ProjectileSweepReactionDataAssetPath { get; set; }
    public int? ProjectileMeshIsFacingTarget { get; set; }
    public int? ScaleCurveXAxisType { get; set; }
    public int? ScaleCurveYAxisType { get; set; }
    public string? ProjectileScaleCurvePath { get; set; }
    public string? ProjectileInnerRadiusCurvePath { get; set; }
    public int? ScaleOnlyApplyToCheck { get; set; }
}


public class BulletExpandConfig
{
    public string desc { get; set; }
    public int ID { get; set; }
    public int? BulletIsForMerge { get; set; }
    public int? BulletIsMergeChild { get; set; }
    public string BulletMergeTag { get; set; }
    public List<int> LifeOverEffectID { get; set; }
    public List<int> HitChrEffectsforSelf { get; set; }
    public List<int> HitProjectileEffectsforSelf { get; set; }
    public List<int> HitItemEffectsforSelf { get; set; }
    public List<int> HitEffectsforChr { get; set; }
    public List<int> HitEffectsforProjectile { get; set; }
    public int? HitDestructibleStrengthType { get; set; }
    public int? HitDestructibleDirectionType { get; set; }
    public List<int> DelayTriggerEffects { get; set; }
    public double? BulletSweepCheckGap { get; set; }
    public double? BulletSweepCheckDelayTime { get; set; }
    public int? BulletIsOnlyHitTarget { get; set; }
    public int? BulletCanThroughBlockage { get; set; }
    public string Guard { get; set; }
}





public class BuffDispConfig
{
    public int ID { get; set; }
    public int BuffID { get; set; }
    public int? CasterResID { get; set; }
    public int? OwnerResID { get; set; }
    public int? IsUseDispConfig { get; set; }
    public List<EffectConfig> EnterFX { get; set; }
    public int? ForceDisplay { get; set; }
}

public class EffectConfig
{
    public string PSPath { get; set; }
    public int? Scale { get; set; }
    public int? IsAttach { get; set; }
    public string? AttachName { get; set; }
    public double? WorldOffsetX { get; set; }
    public double? WorldOffsetY { get; set; }
    public double? WorldOffsetZ { get; set; }
    public int? UseScaleFit { get; set; }
    public int? IsAttachToSkin { get; set; }
    public string? SkelMeshParamName { get; set; }
    public string? AddTags { get; set; }
}


namespace bian
{
    public static class LoadUtils
    {
        private static readonly JsonSerializerSettings JsonSettings = new JsonSerializerSettings
        {
            Converters = new List<JsonConverter> { new StringEnumConverter() }
        };

        // 通用JSON配置加载方法
        public static List<T> LoadJsonConfigs<T>(string configDirectory, string configTypeName) where T : class
        {
            if (!Directory.Exists(configDirectory))
            {
                Log.Error($"{configTypeName} config directory not found: {configDirectory}");
                try
                {
                    Directory.CreateDirectory(configDirectory);
                    Log.Info($"Created {configTypeName} config directory: {configDirectory}");
                }
                catch (Exception ex)
                {
                    Log.Error($"Failed to create {configTypeName} config directory: {ex.Message}");
                    return new List<T>();
                }
            }

            List<T> allConfigs = new List<T>();
            foreach (string file in Directory.GetFiles(configDirectory, "*.json"))
            {
                try
                {
                    string jsonContent = File.ReadAllText(file);
                    var configs = JsonConvert.DeserializeObject<List<T>>(jsonContent, JsonSettings);
                    if (configs != null)
                    {
                        allConfigs.AddRange(configs);
                        Log.Info($"Loaded {configs.Count} {configTypeName} configs from {Path.GetFileName(file)}");
                    }
                }
                catch (Exception ex)
                {
                    Log.Error($"Error loading {configTypeName} configs from {file}: {ex.Message}");
                }
            }

            Log.Info($"Total loaded {configTypeName} configs: {allConfigs.Count}");
            return allConfigs;
        }

        // 通用属性复制方法
        // 文件位置：[Bian\loadUtils.cs](Bian\loadUtils.cs#L100-L200)
        // 通用属性复制方法
        public static void CopyProperties<TSource, TTarget>(TSource source, TTarget target)
        {
            if (source == null || target == null) return;

            var sourceType = source.GetType();
            var targetType = target.GetType();

            foreach (var sourceProp in sourceType.GetProperties())
            {
                var sourceValue = sourceProp.GetValue(source);
                if (sourceValue == null) continue;

                var targetProp = targetType.GetProperty(sourceProp.Name);
                if (targetProp == null) continue;

                try
                {
                    // 处理特殊属性
                    switch (sourceProp.Name)
                    {
                        case "BuffActiveCondition" when sourceValue is BuffActiveCondition condition:
                            var targetCondition = new FUStBuffEffectActiveCondition();
                            CopyBuffActiveCondition(condition, targetCondition);
                            targetProp.SetValue(target, targetCondition);
                            break;

                        case "Range" when sourceValue is BuffRange range:
                            var targetRange = new FUStRange();
                            CopyBuffRange(range, targetRange);
                            targetProp.SetValue(target, targetRange);
                            break;

                        case "BuffEffects" when sourceValue is List<BuffEffect> effects:
                            var newEffects = effects.Select(effect =>
                            {
                                var newEffect = new FUStBuffEffectAttr();
                                newEffect.EffectParamsString.Clear();
                                newEffect.EffectParams.Clear();
                                newEffect.EffectParamsFloat.Clear();

                                if (effect.EffectTrigger.HasValue)
                                    newEffect.EffectTrigger = (EBuffEffectTriggerType)effect.EffectTrigger;
                                if (effect.EffectType.HasValue)
                                    newEffect.EffectType = (EBuffAndSkillEffectType)effect.EffectType;
                                if (effect.EffectTargetSelectType.HasValue)
                                    newEffect.EffectTargetSelectType = (EBuffEffectTargetSelectType)effect.EffectTargetSelectType;

                                effect.EffectParamsString?.ForEach(param => newEffect.EffectParamsString.Add(param));
                                effect.EffectParams?.ForEach(param => newEffect.EffectParams.Add(param));
                                effect.EffectParamsFloat?.ForEach(param => newEffect.EffectParamsFloat.Add(param));

                                return newEffect;
                            }).ToList();

                            var fields = target.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                            var buffEffectsField = fields.FirstOrDefault(f => f.Name.ToLower().Contains("buffeffects"));

                            if (buffEffectsField != null)
                            {
                                try
                                {
                                    if (buffEffectsField.GetValue(target) is System.Collections.IList existingEffects)
                                    {
                                        existingEffects.Clear();
                                        newEffects.ForEach(effect => existingEffects.Add(effect));
                                        Log.Info($"Successfully updated BuffEffects list");
                                    }
                                    else
                                    {
                                        buffEffectsField.SetValue(target, newEffects);
                                        Log.Info($"Successfully set new BuffEffects list");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Log.Error($"Failed to set BuffEffects: {ex.Message}");
                                }
                            }
                            else
                            {
                                Log.Error("Could not find BuffEffects field in target type");
                            }
                            break;


                        case "EnterFX" when sourceValue is List<EffectConfig> effects:
                            var enterEffects = effects.Select(effect =>
                            {
                                var newEffect = new FUStFXSetting();
                                // 复制EffectConfig的属性到FUStFXSetting
                                if (!string.IsNullOrEmpty(effect.PSPath))
                                    newEffect.PSPath = effect.PSPath;
                                if (effect.Scale.HasValue)
                                    newEffect.Scale = effect.Scale.Value;
                                if (effect.IsAttach.HasValue)
                                    newEffect.IsAttach = (EGSYesNo)effect.IsAttach.Value;
                                if (!string.IsNullOrEmpty(effect.AttachName))
                                    newEffect.AttachName = effect.AttachName;
                                if (effect.WorldOffsetX.HasValue)
                                    newEffect.WorldOffsetX = (float)effect.WorldOffsetX.Value;
                                if (effect.WorldOffsetY.HasValue)
                                    newEffect.WorldOffsetY = (float)effect.WorldOffsetY.Value;
                                if (effect.WorldOffsetZ.HasValue)
                                    newEffect.WorldOffsetZ = (float)effect.WorldOffsetZ.Value;
                                if (effect.UseScaleFit.HasValue)
                                    newEffect.UseScaleFit = (EGSYesNo)effect.UseScaleFit.Value;
                                if (effect.IsAttachToSkin.HasValue)
                                    newEffect.IsAttachToSkin = (EGSYesNo)effect.IsAttachToSkin.Value;
                                if (!string.IsNullOrEmpty(effect.SkelMeshParamName))
                                    newEffect.SkelMeshParamName = effect.SkelMeshParamName;
                                if (!string.IsNullOrEmpty(effect.AddTags))
                                    newEffect.AddTags = effect.AddTags;

                                return newEffect;
                            }).ToList();

                            var fieldss = target.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                            var enterFxField = fieldss.FirstOrDefault(f => f.Name.ToLower().Contains("enterfx"));

                            if (enterFxField != null)
                            {
                                try
                                {
                                    if (enterFxField.GetValue(target) is System.Collections.IList existingEffects)
                                    {
                                        existingEffects.Clear();
                                        enterEffects.ForEach(effect => existingEffects.Add(effect));
                                        Log.Info($"Successfully updated EnterFX list");
                                    }
                                    else
                                    {
                                        enterFxField.SetValue(target, enterEffects);
                                        Log.Info($"Successfully set new EnterFX list");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Log.Error($"Failed to set EnterFX: {ex.Message}");
                                }
                            }
                            else
                            {
                                Log.Error("Could not find EnterFX field in target type");
                            }
                            break;

                        case "LifeOverEffectID":
                        case "HitChrEffectsforSelf":
                        case "HitProjectileEffectsforSelf":
                        case "HitItemEffectsforSelf":
                        case "HitEffectsforChr":
                        case "HitEffectsforProjectile":
                        case "DelayTriggerEffects":
                            if (sourceValue is List<int> intList && intList != null)
                            {
                                var targetList = targetProp.GetValue(target) as IList;
                                if (targetList != null)
                                {
                                    targetList.Clear();
                                    if (intList != null)
                                    {
                                        foreach (var item in intList)
                                        {
                                            targetList.Add(item);
                                        }
                                    }
                                }
                            }
                            break;

                        // case "ChargeSkillBuffInfoList" when sourceValue is List<ChargeSkillBuffInfo> buffInfos:
                        //     var buffInfoList = buffInfos.Select(buffInfo =>
                        //     {
                        //         var newBuffInfo = new FUStChargeSkillBuffInfo();
                        //         newBuffInfo.BuffID = buffInfo.BuffID;
                        //         newBuffInfo.BeginTimeInBeginStage = (float)buffInfo.BeginTimeInBeginStage;
                        //         newBuffInfo.EndTimeInEndStage = (float)buffInfo.EndTimeInEndStage;
                        //         return newBuffInfo;
                        //     }).ToList();

                        //     var chfields = target.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                        //     var buffInfoListField = chfields.FirstOrDefault(f => f.Name.ToLower().Contains("chargeskillbuffinfolist"));

                        //     if (buffInfoListField != null)
                        //     {
                        //         try
                        //         {
                        //             if (buffInfoListField.GetValue(target) is System.Collections.IList existingBuffInfos)
                        //             {
                        //                 existingBuffInfos.Clear();
                        //                 buffInfoList.ForEach(buffInfo => existingBuffInfos.Add(buffInfo));
                        //                 Log.Info($"Successfully updated ChargeSkillBuffInfoList");
                        //             }
                        //             else
                        //             {
                        //                 buffInfoListField.SetValue(target, buffInfoList);
                        //                 Log.Info($"Successfully set new ChargeSkillBuffInfoList");
                        //             }
                        //         }
                        //         catch (Exception ex)
                        //         {
                        //             Log.Error($"Failed to set ChargeSkillBuffInfoList: {ex.Message}");
                        //         }
                        //     }
                        //     else
                        //     {
                        //         Log.Error("Could not find ChargeSkillBuffInfoList field in target type");
                        //     }
                        //     break;

                        // 处理SummonConfig中的数组类型字段
                        case "BornMontagePathList":
                        case "DisappearMontagePathList":
                            if (sourceValue is List<string> stringList)
                            {
                                HandleStringListProperty(target, targetProp, stringList);
                            }
                            break;

                        case "BornSkillList":
                        case "BuffList":
                            if (sourceValue is List<int> intLists)
                            {
                                HandleIntListProperty(target, targetProp, intLists);
                            }
                            break;

                        case "LoopCanMove":
                        case "LoopCanRotate":
                            if (sourceValue is int enumValue)
                            {
                                targetProp.SetValue(target, (EGSYesNo)enumValue);
                            }
                            break;

                        case "ChargeMoveSpeedRate":
                            if (sourceValue is EMoveSpeedType speedRate)
                            {
                                targetProp.SetValue(target, speedRate);
                            }
                            break;

                        case "ChargeSkillBuffInfoList" when sourceValue is List<ChargeSkillBuffInfo> buffInfos:
                            var buffInfoList = buffInfos.Select(buffInfo =>
                            {
                                var newBuffInfo = new FUStChargeSkillBuffInfo();
                                newBuffInfo.BuffID = buffInfo.BuffID;
                                newBuffInfo.BeginTimeInBeginStage = (float)buffInfo.BeginTimeInBeginStage;
                                newBuffInfo.EndTimeInEndStage = (float)buffInfo.EndTimeInEndStage;
                                return newBuffInfo;
                            }).ToList();

                            var chfields = target.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                            var buffInfoListField = chfields.FirstOrDefault(f => f.Name.ToLower().Contains("chargeskillbuffinfolist"));

                            if (buffInfoListField != null)
                            {
                                try
                                {
                                    if (buffInfoListField.GetValue(target) is System.Collections.IList existingBuffInfos)
                                    {
                                        existingBuffInfos.Clear();
                                        buffInfoList.ForEach(buffInfo => existingBuffInfos.Add(buffInfo));
                                        Log.Info($"Successfully updated ChargeSkillBuffInfoList");
                                    }
                                    else
                                    {
                                        buffInfoListField.SetValue(target, buffInfoList);
                                        Log.Info($"Successfully set new ChargeSkillBuffInfoList");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Log.Error($"Failed to set ChargeSkillBuffInfoList: {ex.Message}");
                                }
                            }
                            else
                            {
                                Log.Error("Could not find ChargeSkillBuffInfoList field in target type");
                            }
                            break;



                        default:
                            var targetValue = ConvertValue(sourceValue, targetProp.PropertyType);
                            targetProp.SetValue(target, targetValue);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Log.Error($"Failed to copy property {sourceProp.Name}: {ex.Message}");
                }
            }
        }
        // 处理字符串列表属性
        private static void HandleStringListProperty(object target, PropertyInfo targetProp, List<string> stringList)
        {
            try
            {
                // 尝试通过反射找到对应的字段
                var fields = target.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                var targetField = fields.FirstOrDefault(f => f.Name.ToLower().Contains(targetProp.Name.ToLower()));

                if (targetField != null)
                {
                    // 如果目标字段是RepeatedField<string>类型
                    if (targetField.GetValue(target) is RepeatedField<string> targetList)
                    {
                        targetList.Clear();
                        foreach (var item in stringList)
                        {
                            if (!string.IsNullOrEmpty(item)) // 过滤空字符串
                            {
                                targetList.Add(item);
                            }
                        }
                        Log.Info($"Successfully updated {targetProp.Name} string list");
                    }
                    else
                    {
                        Log.Error($"Target field {targetField.Name} is not of type RepeatedField<string>");
                    }
                }
                else
                {
                    Log.Error($"Could not find field for {targetProp.Name} property");
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Error updating {targetProp.Name} string list: {ex.Message}");
            }
        }

        // 处理整数列表属性
        private static void HandleIntListProperty(object target, PropertyInfo targetProp, List<int> intList)
        {
            try
            {
                // 尝试通过反射找到对应的字段
                var fields = target.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                var targetField = fields.FirstOrDefault(f => f.Name.ToLower().Contains(targetProp.Name.ToLower()));

                if (targetField != null)
                {
                    // 如果目标字段是RepeatedField<int>类型
                    if (targetField.GetValue(target) is RepeatedField<int> targetList)
                    {
                        targetList.Clear();
                        foreach (var item in intList)
                        {
                            if (item != 0) // 过滤0值
                            {
                                targetList.Add(item);
                            }
                        }
                        Log.Info($"Successfully updated {targetProp.Name} int list");
                    }
                    else
                    {
                        Log.Error($"Target field {targetField.Name} is not of type RepeatedField<int>");
                    }
                }
                else
                {
                    Log.Error($"Could not find field for {targetProp.Name} property");
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Error updating {targetProp.Name} int list: {ex.Message}");
            }
        }
        // 复制BuffActiveCondition
        private static void CopyBuffActiveCondition(BuffActiveCondition source, FUStBuffEffectActiveCondition target)
        {
            if (source == null || target == null) return;

            if (source.ConditionType.HasValue)
                target.ConditionType = (EGSBuffAndSkillEffectActiveCondition)source.ConditionType.Value;
            if (source.ConditionParams != null)
                target.ConditionParams = source.ConditionParams;
        }

        // 复制BuffRange
        private static void CopyBuffRange(BuffRange source, FUStRange target)
        {
            if (source == null || target == null) return;

            if (source.RangeType.HasValue)
                target.RangeType = (ERangeType)source.RangeType.Value;
            if (source.RangeCenterType.HasValue)
                target.RangeCenterType = (EEffectRangeCenterType)source.RangeCenterType.Value;
            if (source.RangeParam != null)
            {
                target.RangeParam.Clear();
                foreach (var param in source.RangeParam)
                    target.RangeParam.Add(param);
            }
        }



        // 处理特殊列表属性
        public static void HandleListProperty<T>(PropertyInfo targetProp, object target, IEnumerable sourceValues) where T : new()
        {
            if (!(sourceValues is IEnumerable<object> sourceItems)) return;

            try
            {
                var backingField = targetProp.DeclaringType.GetField($"<{targetProp.Name}>k__BackingField",
                    BindingFlags.NonPublic | BindingFlags.Instance);

                if (backingField == null)
                {
                    Log.Error($"Could not find backing field for {targetProp.Name} property");
                    return;
                }

                var currentList = backingField.GetValue(target) as IList;
                if (currentList != null)
                {
                    currentList.Clear();
                }

                var targetList = new List<T>();
                foreach (var sourceItem in sourceItems)
                {
                    var targetItem = new T();
                    CopyProperties(sourceItem, targetItem);
                    targetList.Add(targetItem);
                }

                backingField.SetValue(target, targetList);
                Log.Info($"Successfully updated {targetProp.Name} property");
            }
            catch (Exception ex)
            {
                Log.Error($"Error updating {targetProp.Name} property: {ex.Message}");
            }
        }

        // 类型转换辅助方法
        private static object ConvertValue(object sourceValue, Type targetType)
        {
            if (sourceValue == null)
                return null;

            if (targetType.IsAssignableFrom(sourceValue.GetType()))
                return sourceValue;

            if (Nullable.GetUnderlyingType(targetType) is Type nullableType)
            {
                if (sourceValue == null)
                    return null;
                return ConvertValue(sourceValue, nullableType);
            }

            if (targetType.IsEnum)
            {
                if (sourceValue is string stringValue)
                    return Enum.Parse(targetType, stringValue);
                return Enum.ToObject(targetType, sourceValue);
            }

            return Convert.ChangeType(sourceValue, targetType);
        }

        // 加载并应用BuffDisp配置
        public static int LoadAndApplyBuffDispConfigs(string configDirectory = null)
        {
            configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "BuffDisp");

            var buffDispList = BGW_GameDB.GetAllBuffDispDesc();
            if (buffDispList == null || buffDispList.Count == 0)
            {
                Log.Error("Failed to get buff disp list from game database");
                return 0;
            }

            var configs = LoadJsonConfigs<BuffDispConfig>(configDirectory, "BuffDisp");
            var processedCount = 0;

            foreach (var config in configs)
            {
                try
                {
                    var targetBuffDisp = GetOrCreateBuffDisp(buffDispList, config);
                    CopyProperties(config, targetBuffDisp);
                    processedCount++;
                    Log.Info($"Successfully processed BuffDisp with BuffID: {config.BuffID}");
                }
                catch (Exception ex)
                {
                    Log.Error($"Failed to process BuffDisp config for BuffID {config.BuffID}: {ex.Message}");
                }
            }

            Log.Info($"Total processed BuffDisp configs: {processedCount}");
            return processedCount;
        }

        // 加载并应用Buff配置
        public static int LoadAndApplyBuff(string configDirectory = null)
        {
            try
            {
                configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "BuffDesc");

                var buffConfigs = LoadJsonConfigs<BuffConfig>(configDirectory, "Buff");
                var buffList = BGW_GameDB.GetAllBuffDesc();


                if (buffList == null || buffList.Count == 0 || buffConfigs == null)
                {
                    Log.Error("Failed to load buff configs or buff list is not available");
                    return 0;
                }

                const int templateBuffId = 295;
                if (!buffList.TryGetValue(templateBuffId, out var templateBuff))
                {
                    Log.Error($"Template buff (ID: {templateBuffId}) not found");
                    return 0;
                }

                var processedCount = 0;
                foreach (var buffConfig in buffConfigs)
                {
                    try
                    {
                        var targetBuff = GetOrCreateBuff(buffConfig, buffList, templateBuff);
                        CopyProperties(buffConfig, targetBuff);
                        processedCount++;
                        Log.Info($"Successfully processed buff with ID: {buffConfig.ID}");
                    }
                    catch (Exception ex)
                    {
                        Log.Error($"Failed to process buff config for ID {buffConfig.ID}: {ex.Message}");
                    }
                }

                Log.Info($"Total processed buff configs: {processedCount}");
                return processedCount;
            }
            catch (Exception ex)
            {
                Log.Error($"Critical error in LoadAndApplyBuff: {ex.Message}");
                return 0;
            }
        }

        // 加载技能映射规则
        public static void LoadAllSkillMappingRules(string configDirectory)
        {
            if (!Directory.Exists(configDirectory))
            {
                Log.Error($"Config directory not found: {configDirectory}");
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

            var rules = LoadJsonConfigs<SkillMappingRule>(configDirectory, "SkillMapping");
            Manager.ClearSkillMappingRules();
            Manager.AddSkillMappingRules(rules);

            Log.Info($"Total loaded rules: {Manager.SkillMappingRules.Count}");
        }


        // 获取或创建BuffDisp
        private static FUStBuffDispDesc GetOrCreateBuffDisp(Dictionary<int, FUStBuffDispDesc> buffDispList, BuffDispConfig config)
        {
            if (buffDispList.ContainsKey(config.ID))
            {
                Log.Info($"Updating existing BuffDisp with ID: {config.ID}");
                return buffDispList[config.ID];
            }

            buffDispList.TryGetValue(202901, out var templateBuff);
            var newBuff = (FUStBuffDispDesc)templateBuff.Clone();
            buffDispList.Add(config.ID, newBuff);
            Log.Info($"Creating new BuffDisp with ID: {config.ID}");
            return newBuff;
        }

        // 获取或创建Buff
        private static FUStBuffDesc GetOrCreateBuff(BuffConfig config, Dictionary<int, FUStBuffDesc> buffList, FUStBuffDesc templateBuff)
        {
            if (buffList.TryGetValue(config.ID, out var existingBuff))
            {
                Log.Info($"Updating existing buff with ID: {config.ID}");
                return existingBuff;
            }

            var newBuff = (FUStBuffDesc)templateBuff.Clone();
            buffList.Add(config.ID, newBuff);
            Log.Info($"Creating new buff with ID: {config.ID}");
            return newBuff;
        }





        // 加载并应用BulletExpand配置
        public static int LoadAndApplyBulletExpand(string configDirectory = null)
        {
            try
            {
                configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "BulletData", "bulletExpand");

                var bulletExpandConfigs = LoadJsonConfigs<BulletExpandConfig>(configDirectory, "BulletExpand");
                var bulletExpandList = BGW_GameDB.GetAllBulletExpandDesc();

                if (bulletExpandList == null || bulletExpandList.Count == 0 || bulletExpandConfigs == null)
                {
                    Log.Error("Failed to load bullet expand configs or bullet expand list is not available");
                    return 0;
                }

                const int templateBulletId = 117;
                if (!bulletExpandList.TryGetValue(templateBulletId, out var templateBullet))
                {
                    Log.Error($"Template bullet (ID: {templateBulletId}) not found");
                    return 0;
                }

                var processedCount = 0;
                foreach (var bulletConfig in bulletExpandConfigs)
                {
                    try
                    {
                        var targetBullet = GetOrCreateBulletExpand(bulletConfig, bulletExpandList, templateBullet);
                        CopyProperties(bulletConfig, targetBullet);
                        processedCount++;
                        Log.Info($"Successfully processed bullet expand with ID: {bulletConfig.ID}");
                    }
                    catch (Exception ex)
                    {
                        Log.Error($"Failed to process bullet expand config for ID {bulletConfig.ID}: {ex.Message}");
                    }
                }

                Log.Info($"Total processed bullet expand configs: {processedCount}");
                return processedCount;
            }
            catch (Exception ex)
            {
                Log.Error($"Critical error in LoadAndApplyBulletExpand: {ex.Message}");
                return 0;
            }
        }

        // 获取或创建BulletExpand
        private static FUStBulletExpandDesc GetOrCreateBulletExpand(BulletExpandConfig config, Dictionary<int, FUStBulletExpandDesc> bulletExpandList, FUStBulletExpandDesc templateBullet)
        {
            if (bulletExpandList.TryGetValue(config.ID, out var existingBullet))
            {
                Log.Info($"Updating existing bullet expand with ID: {config.ID}");
                return existingBullet;
            }

            var newBullet = (FUStBulletExpandDesc)templateBullet.Clone();
            bulletExpandList.Add(config.ID, newBullet);
            Log.Info($"Creating new bullet expand with ID: {config.ID}");
            return newBullet;
        }


        // 加载并应用BulletComm配置 todo 目前有个问题 BGW_GameDB.GetAllBulletCommDesc() 拿不到数据
        public static Dictionary<int, FUStBulletCommDesc> GetAllBulletCommDesc()
        {
            return BG_ProtobufDataAPI<FUStBulletCommDesc>.Get().GetAll();
        }
        public static int LoadAndApplyBulletComm(string configDirectory = null)
        {
            try
            {
                configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "BulletData", "BulletComm");

                var bulletCommConfigs = LoadJsonConfigs<BulletCommConfig>(configDirectory, "BulletComm");
                var bulletCommList = BGW_GameDB.GetAllProjectileCommDesc();



                if (bulletCommConfigs == null || bulletCommList.Count == 0 || bulletCommConfigs.Count == 0)
                {
                    Log.Error($"Failed to load bullet comm configs bulletCommList:{bulletCommList.Count}");
                    return 0;
                }

                // 修改点：如果没有模板子弹，使用默认值或创建一个
                const int templateBulletId = 117;
                if (!bulletCommList.TryGetValue(templateBulletId, out var templateBullet))
                {
                    // 创建一个默认的模板子弹
                    templateBullet = new FUStProjectileCommDesc();
                    bulletCommList.Add(templateBulletId, templateBullet);
                    Log.Info($"Template bullet (ID: {templateBulletId}) not found, created a new one");
                }

                var processedCount = 0;
                foreach (var bulletConfig in bulletCommConfigs)
                {
                    try
                    {
                        var targetBullet = GetOrCreateBulletComm(bulletConfig, bulletCommList, templateBullet);
                        CopyProperties(bulletConfig, targetBullet);
                        processedCount++;
                        Log.Info($"Successfully processed bullet comm with ID: {bulletConfig.ID}");
                    }
                    catch (Exception ex)
                    {
                        Log.Error($"Failed to process bullet comm config for ID {bulletConfig.ID}: {ex.Message}");
                    }
                }

                Log.Info($"Total processed bullet comm configs: {processedCount}");
                return processedCount;
            }
            catch (Exception ex)
            {
                Log.Error($"Critical error in LoadAndApplyBulletComm: {ex.Message}");
                return 0;
            }
        }


        // 获取或创建BulletComm
        private static FUStProjectileCommDesc GetOrCreateBulletComm(BulletCommConfig config, Dictionary<int, FUStProjectileCommDesc> bulletCommList, FUStProjectileCommDesc templateBullet)
        {
            if (bulletCommList.TryGetValue(config.ID, out var existingBullet))
            {
                Log.Info($"Updating existing bullet comm with ID: {config.ID}");
                return existingBullet;
            }

            var newBullet = (FUStProjectileCommDesc)templateBullet.Clone();
            bulletCommList.Add(config.ID, newBullet);
            return newBullet;
        }




        // 加载并应用ProjectileMove配置
        public static int LoadAndApplyProjectileMove(string configDirectory = null)
        {
            try
            {
                configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "BulletData", "move");

                var projectileMoveConfigs = LoadJsonConfigs<ProjectileMoveConfig>(configDirectory, "ProjectileMove");
                var projectileMoveList = BGW_GameDB.GetAllProjectileMoveDesc();

                if (projectileMoveList == null || projectileMoveList.Count == 0 || projectileMoveConfigs == null)
                {
                    Log.Error("Failed to load projectile move configs or projectile move list is not available");
                    return 0;
                }

                const int templateProjectileId = 117;
                if (!projectileMoveList.TryGetValue(templateProjectileId, out var templateProjectile))
                {
                    Log.Error($"Template projectile (ID: {templateProjectileId}) not found");
                    return 0;
                }

                var processedCount = 0;
                foreach (var projectileConfig in projectileMoveConfigs)
                {
                    try
                    {
                        var targetProjectile = GetOrCreateProjectileMove(projectileConfig, projectileMoveList, templateProjectile);
                        CopyProperties(projectileConfig, targetProjectile);
                        processedCount++;
                        Log.Info($"Successfully processed projectile move with ID: {projectileConfig.ID}");
                    }
                    catch (Exception ex)
                    {
                        Log.Error($"Failed to process projectile move config for ID {projectileConfig.ID}: {ex.Message}");
                    }
                }

                Log.Info($"Total processed projectile move configs: {processedCount}");
                return processedCount;
            }
            catch (Exception ex)
            {
                Log.Error($"Critical error in LoadAndApplyProjectileMove: {ex.Message}");
                return 0;
            }
        }

        // 获取或创建ProjectileMove
        private static FUStProjectileMoveDesc GetOrCreateProjectileMove(ProjectileMoveConfig config, Dictionary<int, FUStProjectileMoveDesc> projectileMoveList, FUStProjectileMoveDesc templateProjectile)
        {
            if (projectileMoveList.TryGetValue(config.ID, out var existingProjectile))
            {
                Log.Info($"Updating existing projectile move with ID: {config.ID}");
                return existingProjectile;
            }

            var newProjectile = (FUStProjectileMoveDesc)templateProjectile.Clone();
            projectileMoveList.Add(config.ID, newProjectile);
            Log.Info($"Creating new projectile move with ID: {config.ID}");
            return newProjectile;
        }




        // 加载并应用ProjectileDisp配置
        public static Dictionary<int, FUStProjectileDispDesc> GetAllProjectileDispDesc()
        {
            return BG_ProtobufDataAPI<FUStProjectileDispDesc>.Get().GetAll();
        }

        // 加载并应用ProjectileDisp配置
        public static int LoadAndApplyProjectileDisp(string configDirectory = null)
        {
            try
            {
                configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "BulletData", "disp");

                var projectileDispConfigs = LoadJsonConfigs<ProjectileDispConfig>(configDirectory, "ProjectileDisp");
                var projectileDispList = GetAllProjectileDispDesc();



                if (projectileDispConfigs == null || projectileDispList.Count == 0 || projectileDispConfigs.Count == 0)
                {
                    Log.Error("Failed to load projectile disp configs");
                    return 0;
                }

                // 修改点：如果没有模板投射物，使用默认值或创建一个
                const int templateProjectileId = 117;
                if (!projectileDispList.TryGetValue(templateProjectileId, out var templateProjectile))
                {
                    // 创建一个默认的模板投射物
                    templateProjectile = new FUStProjectileDispDesc();
                    projectileDispList.Add(templateProjectileId, templateProjectile);
                    // Log.Info($"Template projectile (ID: {templateProjectileId}) not found, created a new one");
                }

                var processedCount = 0;
                foreach (var projectileConfig in projectileDispConfigs)
                {
                    try
                    {
                        var targetProjectile = GetOrCreateProjectileDisp(projectileConfig, projectileDispList, templateProjectile);
                        CopyProperties(projectileConfig, targetProjectile);
                        processedCount++;
                        // Log.Info($"Successfully processed projectile disp with ID: {projectileConfig.ID}");
                    }
                    catch (Exception ex)
                    {
                        Log.Error($"Failed to process projectile disp config for ID {projectileConfig.ID}: {ex.Message}");
                    }
                }

                Log.Info($"Total processed projectile disp configs: {processedCount}");
                return processedCount;
            }
            catch (Exception ex)
            {
                Log.Error($"Critical error in LoadAndApplyProjectileDisp: {ex.Message}");
                return 0;
            }
        }

        // 获取或创建ProjectileDisp
        private static FUStProjectileDispDesc GetOrCreateProjectileDisp(ProjectileDispConfig config, Dictionary<int, FUStProjectileDispDesc> projectileDispList, FUStProjectileDispDesc templateProjectile)
        {
            if (projectileDispList.TryGetValue(config.ID, out var existingProjectile))
            {
                Log.Info($"Updating existing projectile disp with ID: {config.ID}");
                return existingProjectile;
            }

            var newProjectile = (FUStProjectileDispDesc)templateProjectile.Clone();
            projectileDispList.Add(config.ID, newProjectile);
            Log.Info($"Creating new projectile disp with ID: {config.ID}");
            return newProjectile;
        }

        // 以上是子弹全部方法



        public static Dictionary<int, FUStChargeSkillSDesc> GetAllFUStChargeSkillSDesc()
        {

            return BG_ProtobufDataAPI<FUStChargeSkillSDesc>.Get().GetAll();
        }


        public static int LoadAndApplyChargeSkill(string configDirectory = null)
        {
            try
            {
                configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "ChargeSkill");

                var chargeSkillConfigs = LoadJsonConfigs<ChargeSkillConfig>(configDirectory, "ChargeSkill");
                var chargeSkillList = GetAllFUStChargeSkillSDesc();

                if (chargeSkillList == null)
                {
                    chargeSkillList = new Dictionary<int, FUStChargeSkillSDesc>();
                    Log.Info("Charge skill list is null, creating a new one");
                }

                if (chargeSkillConfigs == null || chargeSkillConfigs.Count == 0)
                {
                    Log.Error("Failed to load charge skill configs");
                    return 0;
                }

                const int templateSkillId = 10720;
                if (!chargeSkillList.TryGetValue(templateSkillId, out var templateSkill))
                {
                    templateSkill = new FUStChargeSkillSDesc();
                    chargeSkillList.Add(templateSkillId, templateSkill);
                    Log.Info($"Template skill (ID: {templateSkillId}) not found, created a new one");
                }

                var processedCount = 0;
                foreach (var skillConfig in chargeSkillConfigs)
                {
                    try
                    {
                        var targetSkill = GetOrCreateChargeSkill(skillConfig, chargeSkillList, templateSkill);
                        CopyProperties(skillConfig, targetSkill);
                        processedCount++;
                        // Log.Info($"Successfully processed charge skill with ID: {skillConfig.ID}");
                    }
                    catch (Exception ex)
                    {
                        Log.Error($"Failed to process charge skill config for ID {skillConfig.ID}: {ex.Message}");
                    }
                }

                Log.Info($"Total processed charge skill configs: {processedCount}");
                return processedCount;
            }
            catch (Exception ex)
            {
                Log.Error($"Critical error in LoadAndApplyChargeSkill: {ex.Message}");
                return 0;
            }
        }


        // 修改蓄力技能
        private static FUStChargeSkillSDesc GetOrCreateChargeSkill(ChargeSkillConfig config, Dictionary<int, FUStChargeSkillSDesc> chargeSkillList, FUStChargeSkillSDesc templateSkill)
        {
            if (chargeSkillList.TryGetValue(config.ID, out var existingSkill))
            {
                Log.Info($"Updating existing charge skill with ID: {config.ID}");
                return existingSkill;
            }

            var newSkill = (FUStChargeSkillSDesc)templateSkill.Clone();
            chargeSkillList.Add(config.ID, newSkill);
            Log.Info($"Creating new charge skill with ID: {config.ID}");
            return newSkill;
        }




        // 加载并应用Summon配置


        public static int LoadAndApplySummon(string configDirectory = null)
        {
            try
            {
                configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "Summon");

                var summonConfigs = LoadJsonConfigs<SummonConfig>(configDirectory, "Summon");
                var summonList = BGW_GameDB.GetAllSummonCommDesc();

                // 如果summonList为空，创建一个新的字典
                if (summonList == null)
                {
                    summonList = new Dictionary<int, FUStSummonCommDesc>();
                    Log.Info("Summon list is null, creating a new one");
                }
                else if (summonList.Count == 0)
                {
                    Log.Info("Summon list is empty, but will continue processing");
                }

                if (summonConfigs == null || summonConfigs.Count == 0)
                {
                    Log.Error("Failed to load summon configs");
                    return 0;
                }

                // 如果没有模板召唤物，使用默认值或创建一个
                const int templateSummonId = 1001101;
                if (!summonList.TryGetValue(templateSummonId, out var templateSummon))
                {
                    // 创建一个默认的模板召唤物
                    templateSummon = new FUStSummonCommDesc();
                    summonList.Add(templateSummonId, templateSummon);
                    Log.Info($"Template summon (ID: {templateSummonId}) not found, created a new one");
                }

                var processedCount = 0;
                foreach (var summonConfig in summonConfigs)
                {
                    try
                    {
                        var targetSummon = GetOrCreateSummon(summonConfig, summonList, templateSummon);
                        CopyProperties(summonConfig, targetSummon);
                        processedCount++;
                        Log.Info($"Successfully processed summon with ID: {summonConfig.ID}");
                    }
                    catch (Exception ex)
                    {
                        Log.Error($"Failed to process summon config for ID {summonConfig.ID}: {ex.Message}");
                    }
                }

                Log.Info($"Total processed summon configs: {processedCount}");
                return processedCount;
            }
            catch (Exception ex)
            {
                Log.Error($"Critical error in LoadAndApplySummon: {ex.Message}");
                return 0;
            }
        }

        // 获取或创建Summon
        private static FUStSummonCommDesc GetOrCreateSummon(SummonConfig config, Dictionary<int, FUStSummonCommDesc> summonList, FUStSummonCommDesc templateSummon)
        {
            if (summonList.TryGetValue(config.ID, out var existingSummon))
            {
                Log.Info($"Updating existing summon with ID: {config.ID}");
                return existingSummon;
            }

            var newSummon = (FUStSummonCommDesc)templateSummon.Clone();
            summonList.Add(config.ID, newSummon);
            Log.Info($"Creating new summon with ID: {config.ID}");
            return newSummon;
        }


    }
}



