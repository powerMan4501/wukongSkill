using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using b1;
using BtlShare;
using CSharpModBase;
using BtlB1;
using Google.Protobuf.Collections;
using b1.Protobuf.DataAPI;
using bian;
using ResB1;
using UnrealEngine.Engine;
using b1.Protobuf.GSProtobufRuntimeAPI;


public class ActionConfig
{
    public string code { get; set; }
    public List<RuleAction> actions { get; set; }
}

public class DamageExpandConfig
{
    public string desc { get; set; }
    public int ID { get; set; }
    public int? CanTriggerScar { get; set; }
    public int? CanTriggerFX { get; set; }
    public int? CanTriggerFightBackCounter { get; set; }
    public int? DamageReason { get; set; }
    public int? DamageImmueLevel { get; set; }
    public int? CritRateAddition { get; set; }
    public double? CritDmgAddition { get; set; }
    public int? IgnoreBeAttacked { get; set; }
    public double? AddTargetCurHpRatio { get; set; }
    public double? ImmobilizeHit { get; set; }
    public double? PartDamage { get; set; }
    public double? PevalueIncrements { get; set; }
    public double? TransIncrements { get; set; }
    public int? HitWeightGearType { get; set; }
    public int? PillarFormTerminatorType { get; set; }
    public int? BrokenFrozenImmediately { get; set; }
}


public class SoulSkillConfig
{
    public int Id { get; set; }
    public string? SkillName { get; set; }
    public string DAPath { get; set; }
    public int? SkillId { get; set; }
    public int? BuffId { get; set; }
    public int? AttrEffectId { get; set; }
    public int? EffectTalentId { get; set; }
    public string? EffectTalentDesc { get; set; }

}

public class NotifyParam
{
    public List<FUStCheckShape> sweepCheckShape { get; set; }
    public List<int> EffectIDList { get; set; }
}
public class notifyItem
{
    public string? NotifyTrackName { get; set; }
    public NotifyParam? notifyParam { get; set; }
    public float? StartTime { get; set; }
    public float? EndTime { get; set; }
}
public class AnimRuleBySweepCheck
{
    public string montage { get; set; }
    public double? linkValue { get; set; }
    public List<RuleAction>? AfterActions { get; set; }
    public List<RuleAction>? SweepActions { get; set; }
    public List<RuleAction>? hitActions { get; set; }
    public List<RuleAction>? bulletsActions { get; set; }
    public List<notifyItem>? notifies { get; set; }
    public List<int>? hitEffects { get; set; }
    public bool? replaceEffects { get; set; }

    public List<RuleAction>? CastActions { get; set; }
    public float? speedRate { get; set; }
    public float? MoveOffset { get; set; }
    public float? scaleWeaponNum { get; set; }
    public int? addRadius { get; set; }
    public float? AMScaleRate { get; set; }
    public bool? openShooterMode { get; set; }
    public bool? closeShooterMode { get; set; }
    public EMovementMode? moveMode { get; set; }
    public float? AMSpeedRate { get; set; }


}


public class PassiveConfig
{
    public string? desc { get; set; }
    public int ID { get; set; }
    public float? BaseValue { get; set; }
    // 可以添加更多需要修改的属性
}

public class SkillEffectConfig
{
    public string? desc { get; set; }
    public int ID { get; set; }
    public BuffActiveCondition? EffectActiveCondition { get; set; }
    public int? EffectType { get; set; }
    public int? EffectCategory { get; set; }
    public int? TargetBase { get; set; }
    public int? TargetCount { get; set; }
    public int? TargetFilter { get; set; }
    public int? TargetTypeFilter { get; set; }
    public int? AffiliationTypeFilter { get; set; }
    public BuffRange? Range { get; set; }
    public int? FXTransUseConfig { get; set; }
    public string? PlayFXSocketName { get; set; }
    public double? PlayFXLocalDirX { get; set; }
    public double? PlayFXLocalDirY { get; set; }
    public double? PlayFXLocalDirZ { get; set; }
    public double? FXCameraOffset { get; set; }
    public int? HitActionDir { get; set; }
    public int? HitOrientationType { get; set; }
    public string? HitOriBaseCompName { get; set; }
    public int? CanFractureVictim { get; set; }
    public int? CanCutVictim { get; set; }
    public List<int>? EffectParamsInt { get; set; }
    public List<double>? EffectParamsFloat { get; set; }
    public List<string>? EffectParamsStr { get; set; }
    public string? Guard { get; set; }
}



public class SkillConfig
{
    public string? desc { get; set; }
    public int ID { get; set; }
    public int? SkillBaseTarget { get; set; }
    public int? SkillType { get; set; }
    public double? MoveSkillDisMinRate { get; set; }
    public double? MoveSkillDisMaxRate { get; set; }
    public string? TemplatePath { get; set; }
    public double? NoiseLoudness { get; set; }
    public int? MinAttrCostType1 { get; set; }
    public double? MinAttrCostBase1 { get; set; }
    public double? MinAttrCostRatio1 { get; set; }
    public int? MinAttrCostType2 { get; set; }
    public double? MinAttrCostBase2 { get; set; }
    public double? MinAttrCostRatio2 { get; set; }
    public double? PreCooldownTime { get; set; }
    public double? CooldownTime { get; set; }
    public int? CooldownType { get; set; }
    public int? DmgRangeType { get; set; }
    public int? SkillRotateType { get; set; }
    public int? OnlyPlayerControlledSkillRotate { get; set; }
    public int? DoneAddBuffID { get; set; }
    public int? SkillHitSetSimpleState { get; set; }
    public string? AtkReboundingMontage { get; set; }
    public string? LowAtkReboundingMontage { get; set; }
    public string? SkillArmorBrokeMontage { get; set; }
    public int? IsComboSkill { get; set; }
    public int? IsOverlying { get; set; }
    public int? IsCanMoveAttack { get; set; }
    public string? CooldownSkills { get; set; }
    public double? AdditionalHatredValue { get; set; }
}


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
    public List<EffectConfig> EnterFX { get; set; }
}

public class EffectConfig
{
    public string PSPath { get; set; }
    public float? Scale { get; set; }
    public EGSYesNo? IsAttach { get; set; }
    public string? AttachName { get; set; }
    public float? WorldOffsetX { get; set; }
    public float? WorldOffsetY { get; set; }
    public float? WorldOffsetZ { get; set; }
    public EGSYesNo? UseScaleFit { get; set; }
    public EGSYesNo? IsAttachToSkin { get; set; }
    public string? SkelMeshParamName { get; set; }
    public string? AddTags { get; set; }
}

public class BuffActiveCondition
{
    public int? ConditionType { get; set; } = null;
    public string? ConditionParams { get; set; } = null;
}

public class BuffRange
{
    public int? RangeType { get; set; } = null;
    public int? RangeCenterType { get; set; } = null;
    public List<int>? RangeParam { get; set; } = null;
}

public class BuffEffect
{
    public int? EffectTrigger { get; set; } = null;
    public int? EffectType { get; set; } = null;
    public int? EffectTargetSelectType { get; set; } = null;
    public List<string>? EffectParamsString { get; set; } = null;
    public List<int>? EffectParams { get; set; } = null;
    public List<float>? EffectParamsFloat { get; set; } = null;
}

public class BuffConfig
{
    public int ID { get; set; } = 0;
    public string? BuffTips { get; set; } = null;
    public BuffActiveCondition? BuffActiveCondition { get; set; } = null;
    public int? BuffLayerCounterType { get; set; } = null;
    public int? BuffCategory { get; set; } = null;
    public int? CanRemoveWhenAttackHit { get; set; } = null;
    public int? CanRemoveWhenAttacked { get; set; } = null;
    public int? Delay { get; set; } = null;
    public int? Duration { get; set; } = null;
    public int? Interval { get; set; } = null;
    public int? AlmostEndAheadTime { get; set; } = null;
    public int? MaxLayer { get; set; } = null;
    public int? TargetBase { get; set; } = null;
    public int? TargetCount { get; set; } = null;
    public int? TargetFilter { get; set; } = null;
    public int? TargetTypeFilter { get; set; } = null;
    public int? AffiliationTypeFilter { get; set; } = null;
    public BuffRange? Range { get; set; } = null;
    public List<BuffEffect>? BuffEffects { get; set; } = null;
    public int? IsExclusiveBuff { get; set; } = null;
    public int? CanBeInherited { get; set; } = null;
    public string? Guard { get; set; } = null;
}


namespace bian
{

    public class ComboConfig
    {
        public string? nowMontage { get; set; }
        public double? rate { get; set; }
        public int skillID { get; set; }
        public SkillMapCondition Condition { get; set; }
        public string InputCore { get; set; }
        public int? conditionValue { get; set; }
        public string? desc { get; set; }
        public string? type { get; set; }
        public float? UnitScale { get; set; }
        public int? MagicSkillID { get; set; }
        public int? ResId { get; set; }
        public float? Scale3D { get; set; }
        public string? bossLabel { get; set; }
        public string? RushDir { get; set; }


    }
    public static class LoadUtils
    {
        private static readonly JsonSerializerSettings JsonSettings = new JsonSerializerSettings
        {
            Converters = new List<JsonConverter> { new StringEnumConverter() }
        };



        // 加载连招配置
        public static List<ComboConfig> LoadComboConfigs(string configDirectory = null)
        {
            configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "dataPBTable", "ComboSkill");
            var comboConfigs = new List<ComboConfig>();
            var monitoredKeys = new HashSet<string>();

            if (Directory.Exists(configDirectory))
            {
                foreach (string file in Directory.GetFiles(configDirectory, "*.json"))
                {
                    try
                    {
                        string json = File.ReadAllText(file);
                        var configs = JsonConvert.DeserializeObject<List<ComboConfig>>(json);
                        if (configs != null)
                        {
                            // 去重处理
                            var uniqueConfigs = configs.GroupBy(c => new { c.nowMontage, c.rate, c.skillID, c.Condition, c.InputCore })
                                                      .Select(g => g.First())
                                                      .ToList();
                            comboConfigs.AddRange(configs);
                            // 收集所有需要监听的按键
                            foreach (var config in uniqueConfigs)
                            {
                                if (!string.IsNullOrEmpty(config.InputCore))
                                {
                                    monitoredKeys.Add(config.InputCore);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Error($"Error loading combo config from {file}: {ex.Message}");
                    }
                }
            }
            Log.Info($"success load combo config: {comboConfigs.Count}");
            return comboConfigs;
        }

        // 自动导出报错信息
        public static void ExportErrorToJson(Exception ex)
        {
            try
            {
                string errorDirectory = Path.Combine("CSharpLoader", "Mods", "bian", "errorMsg");
                if (!Directory.Exists(errorDirectory))
                {
                    Directory.CreateDirectory(errorDirectory);
                }

                var errorData = new
                {
                    Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    Message = ex.Message,
                    StackTrace = ex.StackTrace,
                    Source = ex.Source
                };

                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string jsonContent = JsonConvert.SerializeObject(errorData, JsonSettings);
                string filePath = Path.Combine(errorDirectory, $"{timestamp}.json");
                File.WriteAllText(filePath, jsonContent);
            }
            catch (Exception writeEx)
            {
                Log.Error($"Failed to export error to JSON: {writeEx.Message}");
            }
        }

        // 把游戏数据导出去，每10条数据生成一个JSON文件
        public static void ExportDataToJson<T>(string dataType) where T : class
        {
            try
            {
                string exportDirectory = Path.Combine("CSharpLoader", "Mods", "bian", "dataPBTable", "exportedData", dataType);
                if (!Directory.Exists(exportDirectory))
                {
                    Directory.CreateDirectory(exportDirectory);
                }

                var data = new Dictionary<int, T>();

                // 根据类型获取不同的数据
                switch (dataType.ToLower())
                {
                    case "buffdisp":
                        if (BGW_GameDB.GetAllBuffDispDesc() is Dictionary<int, FUStBuffDispDesc> buffDispData)
                        {
                            data = buffDispData as Dictionary<int, T>;
                        }
                        break;
                    case "buff":
                        if (BGW_GameDB.GetAllBuffDesc() is Dictionary<int, FUStBuffDesc> buffData)
                        {
                            data = buffData as Dictionary<int, T>;
                        }
                        break;
                    case "skill":
                        if (BGW_GameDB.GetAllSkillSDesc() is Dictionary<int, FUStSkillSDesc> skillData)
                        {
                            data = skillData as Dictionary<int, T>;
                        }
                        break;


                        // 可以继续添加其他类型的支持
                }

                if (data != null && data.Count > 0)
                {
                    int totalItems = data.Count;
                    int itemsPerPage = 10;
                    int totalPages = (int)Math.Ceiling((double)totalItems / itemsPerPage);

                    Log.Info($"Starting to export {totalItems} {dataType} data in {totalPages} pages");

                    // 将字典转换为列表以便分页
                    var dataList = data.ToList();

                    for (int page = 1; page <= totalPages; page++)
                    {
                        // 计算当前页的数据范围
                        int startIndex = (page - 1) * itemsPerPage;
                        int count = Math.Min(itemsPerPage, totalItems - startIndex);
                        var pageData = dataList.Skip(startIndex).Take(count).ToDictionary(x => x.Key, x => x.Value);

                        // 序列化当前页数据
                        string jsonContent = JsonConvert.SerializeObject(pageData, JsonSettings);

                        // 创建文件名，包含页码信息
                        string fileName = $"{dataType}_page{page}_of{totalPages}.json";
                        string filePath = Path.Combine(exportDirectory, fileName);

                        // 写入文件
                        File.WriteAllText(filePath, jsonContent);

                        Log.Info($"Successfully exported {dataType} data page {page}/{totalPages} to {fileName}");
                    }
                }
                else
                {
                    Log.Error($"No data found for type: {dataType}");
                }
            }
            catch (Exception ex)
            {
                ExportErrorToJson(ex); // 使用第一个方法导出错误信息
            }
        }

        // 通用JSON配置加载方法
        public static List<T> LoadJsonConfigs<T>(string configDirectory, string configTypeName) where T : class
        {
            if (!Directory.Exists(configDirectory))
            {
                Log.Error($"{configTypeName} config directory not found: {configDirectory}");
                try
                {
                    Directory.CreateDirectory(configDirectory);
                    // Log.Info($"Created {configTypeName} config directory: {configDirectory}");
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
        private static FUStBuffEffectActiveCondition ConvertBuffActiveCondition(BuffActiveCondition source)
        {
            var target = new FUStBuffEffectActiveCondition();
            if (source.ConditionType.HasValue)
                target.ConditionType = (EGSBuffAndSkillEffectActiveCondition)source.ConditionType.Value;
            if (!string.IsNullOrEmpty(source.ConditionParams))
                target.ConditionParams = source.ConditionParams;
            return target;
        }


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
                            targetProp.SetValue(target, ConvertBuffActiveCondition(condition));
                            break;

                        case "EffectActiveCondition" when sourceValue is BuffActiveCondition condition:
                            targetProp.SetValue(target, ConvertBuffActiveCondition(condition));
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
                                        // Log.Info($"Successfully updated BuffEffects list");
                                    }
                                    else
                                    {
                                        buffEffectsField.SetValue(target, newEffects);
                                        // Log.Info($"Successfully set new BuffEffects list");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    // Log.Error($"Failed to set BuffEffects: {ex.Message}");
                                }
                            }
                            else
                            {
                                // Log.Error("Could not find BuffEffects field in target type");
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
                                        // Log.Info($"Successfully updated EnterFX list");
                                    }
                                    else
                                    {
                                        enterFxField.SetValue(target, enterEffects);
                                        // Log.Info($"Successfully set new EnterFX list");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    // Log.Error($"Failed to set EnterFX: {ex.Message}");
                                }
                            }
                            else
                            {
                                // Log.Error("Could not find EnterFX field in target type");
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
                            if (sourceValue is EGSYesNo enumValue)
                            {
                                targetProp.SetValue(target, enumValue);
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
                                        // Log.Info($"Successfully updated ChargeSkillBuffInfoList");
                                    }
                                    else
                                    {
                                        buffInfoListField.SetValue(target, buffInfoList);
                                        // Log.Info($"Successfully set new ChargeSkillBuffInfoList");
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

                        case "EffectParamsInt" when sourceValue is List<int> intParams:
                            var targetIntList = targetProp.GetValue(target) as IList;
                            if (targetIntList != null)
                            {
                                targetIntList.Clear();
                                foreach (var param in intParams)
                                {
                                    targetIntList.Add(param);
                                }
                            }
                            break;

                        case "EffectParamsFloat" when sourceValue is List<double> floatParams:
                            var targetFloatList = targetProp.GetValue(target) as IList;
                            if (targetFloatList != null)
                            {
                                targetFloatList.Clear();
                                foreach (var param in floatParams)
                                {
                                    targetFloatList.Add((float)param);
                                }
                            }
                            break;

                        case "EffectParamsStr" when sourceValue is List<string> strParams:
                            var targetStrList = targetProp.GetValue(target) as IList;
                            if (targetStrList != null)
                            {
                                targetStrList.Clear();
                                foreach (var param in strParams)
                                {
                                    targetStrList.Add(param);
                                }
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
                        // Log.Info($"Successfully updated {targetProp.Name} string list");
                    }
                    else
                    {
                        // Log.Error($"Target field {targetField.Name} is not of type RepeatedField<string>");
                    }
                }
                else
                {
                    // Log.Error($"Could not find field for {targetProp.Name} property");
                }
            }
            catch (Exception ex)
            {
                // Log.Error($"Error updating {targetProp.Name} string list: {ex.Message}");
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
                        // Log.Info($"Successfully updated {targetProp.Name} int list");
                    }
                    else
                    {
                        // Log.Error($"Target field {targetField.Name} is not of type RepeatedField<int>");
                    }
                }
                else
                {
                    // Log.Error($"Could not find field for {targetProp.Name} property");
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
                // Log.Info($"Successfully updated {targetProp.Name} property");
            }
            catch (Exception ex)
            {
                // Log.Error($"Error updating {targetProp.Name} property: {ex.Message}");
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
            configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "dataPBTable", "buff_disp");


            var buffDispList = BGW_GameDB.GetAllBuffDispDesc();
            var configs = LoadJsonConfigs<BuffDispConfig>(configDirectory, "buff_disp");
            if (buffDispList == null || buffDispList.Count == 0 || configs == null)
            {
                Log.Error("Failed to get buff disp list from game database");
                return 0;
            }

            // 去重处理
            configs = configs.GroupBy(c => c.ID).Select(g => g.First()).ToList();
            var processedCount = 0;
            foreach (var config in configs)
            {
                try
                {
                    var targetBuffDisp = GetOrCreateBuffDisp(buffDispList, config);
                    CopyProperties(config, targetBuffDisp);
                    processedCount++;
                    // Log.Info($"Successfully processed BuffDisp with BuffID: {config.BuffID}");
                }
                catch (Exception ex)
                {
                    // Log.Error($"Failed to process BuffDisp config for BuffID {config.BuffID}: {ex.Message}");
                }
            }


            Log.Info($"Total processed BuffDisp configs: {processedCount}");

            Helper.DelayExecute(100, () =>
            {
                var method = typeof(BGW_GameDB).GetMethod("InitBuffDispMap", BindingFlags.NonPublic | BindingFlags.Static);
                method?.Invoke(null, null);
            });
            return processedCount;
        }

        // 加载并应用Buff配置
        public static int LoadAndApplyBuff(string configDirectory = null)
        {
            try
            {
                configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "dataPBTable", "BuffDesc");

                var buffConfigs = LoadJsonConfigs<BuffConfig>(configDirectory, "Buff");
                var buffList = BGW_GameDB.GetAllBuffDesc();

                if (buffList == null || buffList.Count == 0 || buffConfigs == null)
                {
                    return 0;
                }
                // 去重处理
                buffConfigs = buffConfigs.GroupBy(c => c.ID).Select(g => g.First()).ToList();
                const int templateBuffId = 295;
                if (!buffList.TryGetValue(templateBuffId, out var templateBuff))
                {
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
                    }
                    catch (Exception ex)
                    {
                        // Log.Error($"Failed to process buff config for ID {buffConfig.ID}: {ex.Message}");
                    }
                }

                Log.Info($"Total processed buff configs: {processedCount}");
                // 100101
                // GameDBRuntime，
                var talentSDesc = GameDBRuntime.GetTalentSDesc(100101);
                talentSDesc.AddBuffIDs = string.Join(",", new List<int> { 888666001 });



                return processedCount;
            }
            catch (Exception ex)
            {
                // Log.Error($"Critical error in LoadAndApplyBuff: {ex.Message}");
                return 0;
            }
        }

        // 加载技能映射规则
        public static void LoadAllSkillMappingRules(string configDirectory = null)
        {
            configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "dataPBTable", "skillMaping");

            if (!Directory.Exists(configDirectory))
            {
                Log.Error($"Config directory not found: {configDirectory}");
                try
                {
                    Directory.CreateDirectory(configDirectory);
                    // Log.Info($"Created config directory: {configDirectory}");
                }
                catch (Exception ex)
                {
                    // Log.Error($"Failed to create config directory: {ex.Message}");
                    return;
                }
            }

            var rules = LoadJsonConfigs<SkillMappingRule>(configDirectory, "SkillMapping");
            if (rules == null || rules.Count == 0) return;
            // 对技能映射规则进行去重
            var AllSkillMappingRules = rules
                .GroupBy(rule => new { rule.OriginalId, rule.MappedId, rule.Condition })
                .Select(group => group.First())
                .ToList();
            Manager.ClearSkillMappingRules();
            Manager.AddSkillMappingRules(AllSkillMappingRules);

            // Log.Info($"Total loaded rules: {Manager.SkillMappingRules.Count}");
        }


        // 获取或创建BuffDisp
        private static FUStBuffDispDesc GetOrCreateBuffDisp(Dictionary<int, FUStBuffDispDesc> buffDispList, BuffDispConfig config)
        {
            if (buffDispList.ContainsKey(config.ID))
            {
                // Log.Info($"Updating existing BuffDisp with ID: {config.ID}");
                return buffDispList[config.ID];
            }

            buffDispList.TryGetValue(202901, out var templateBuff);
            var newBuff = (FUStBuffDispDesc)templateBuff.Clone();
            buffDispList.Add(config.ID, newBuff);
            // Log.Info($"Creating new BuffDisp with ID: {config.ID}");
            return newBuff;
        }

        // 获取或创建Buff
        private static FUStBuffDesc GetOrCreateBuff(BuffConfig config, Dictionary<int, FUStBuffDesc> buffList, FUStBuffDesc templateBuff)
        {
            if (buffList.TryGetValue(config.ID, out var existingBuff))
            {
                // Log.Info($"Updating existing buff with ID: {config.ID}");
                return existingBuff;
            }

            var newBuff = (FUStBuffDesc)templateBuff.Clone();
            buffList.Add(config.ID, newBuff);
            // Log.Info($"Creating new buff with ID: {config.ID}");
            return newBuff;
        }





        // 加载并应用BulletExpand配置
        public static int LoadAndApplyBulletExpand(string configDirectory = null)
        {
            try
            {
                configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "dataPBTable", "BulletData", "bulletExpand");


                var bulletExpandConfigs = LoadJsonConfigs<BulletExpandConfig>(configDirectory, "BulletExpand");
                var bulletExpandList = BGW_GameDB.GetAllBulletExpandDesc();

                if (bulletExpandList == null || bulletExpandList.Count == 0 || bulletExpandConfigs == null)
                {
                    Log.Error("Failed to load bullet expand configs or bullet expand list is not available");
                    return 0;
                }
                // 去重处理
                bulletExpandConfigs = bulletExpandConfigs.GroupBy(c => c.ID).Select(g => g.First()).ToList();
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
                        // Log.Info($"Successfully processed bullet expand with ID: {bulletConfig.ID}");
                    }
                    catch (Exception ex)
                    {
                        // Log.Error($"Failed to process bullet expand config for ID {bulletConfig.ID}: {ex.Message}");
                    }
                }

                // Log.Info($"Total processed bullet expand configs: {processedCount}");
                return processedCount;
            }
            catch (Exception ex)
            {
                // Log.Error($"Critical error in LoadAndApplyBulletExpand: {ex.Message}");
                return 0;
            }
        }

        // 获取或创建BulletExpand
        private static FUStBulletExpandDesc GetOrCreateBulletExpand(BulletExpandConfig config, Dictionary<int, FUStBulletExpandDesc> bulletExpandList, FUStBulletExpandDesc templateBullet)
        {
            if (bulletExpandList.TryGetValue(config.ID, out var existingBullet))
            {
                // Log.Info($"Updating existing bullet expand with ID: {config.ID}");
                return existingBullet;
            }

            var newBullet = (FUStBulletExpandDesc)templateBullet.Clone();
            bulletExpandList.Add(config.ID, newBullet);
            // Log.Info($"Creating new bullet expand with ID: {config.ID}");
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
                configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "dataPBTable", "BulletData", "BulletComm");


                var bulletCommConfigs = LoadJsonConfigs<BulletCommConfig>(configDirectory, "BulletComm");
                var bulletCommList = BGW_GameDB.GetAllProjectileCommDesc();



                if (bulletCommConfigs == null || bulletCommList.Count == 0 || bulletCommConfigs.Count == 0)
                {
                    Log.Error($"Failed to load bullet comm configs bulletCommList:{bulletCommList.Count}");
                    return 0;
                }

                // 去重处理
                bulletCommConfigs = bulletCommConfigs.GroupBy(c => c.ID).Select(g => g.First()).ToList();
                // 修改点：如果没有模板子弹，使用默认值或创建一个
                const int templateBulletId = 117;
                if (!bulletCommList.TryGetValue(templateBulletId, out var templateBullet))
                {
                    // 创建一个默认的模板子弹
                    templateBullet = new FUStProjectileCommDesc();
                    bulletCommList.Add(templateBulletId, templateBullet);
                    // Log.Info($"Template bullet (ID: {templateBulletId}) not found, created a new one");
                }

                var processedCount = 0;
                foreach (var bulletConfig in bulletCommConfigs)
                {
                    try
                    {
                        var targetBullet = GetOrCreateBulletComm(bulletConfig, bulletCommList, templateBullet);
                        CopyProperties(bulletConfig, targetBullet);
                        processedCount++;
                        // Log.Info($"Successfully processed bullet comm with ID: {bulletConfig.ID}");
                    }
                    catch (Exception ex)
                    {
                        // Log.Error($"Failed to process bullet comm config for ID {bulletConfig.ID}: {ex.Message}");
                    }
                }

                // Log.Info($"Total processed bullet comm configs: {processedCount}");
                return processedCount;
            }
            catch (Exception ex)
            {
                // Log.Error($"Critical error in LoadAndApplyBulletComm: {ex.Message}");
                return 0;
            }
        }


        // 获取或创建BulletComm
        private static FUStProjectileCommDesc GetOrCreateBulletComm(BulletCommConfig config, Dictionary<int, FUStProjectileCommDesc> bulletCommList, FUStProjectileCommDesc templateBullet)
        {
            if (bulletCommList.TryGetValue(config.ID, out var existingBullet))
            {
                // Log.Info($"Updating existing bullet comm with ID: {config.ID}");
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
                configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "dataPBTable", "BulletData", "move");

                var projectileMoveConfigs = LoadJsonConfigs<ProjectileMoveConfig>(configDirectory, "ProjectileMove");
                var projectileMoveList = BGW_GameDB.GetAllProjectileMoveDesc();

                if (projectileMoveList == null || projectileMoveList.Count == 0 || projectileMoveConfigs == null)
                {
                    Log.Error("Failed to load projectile move configs or projectile move list is not available");
                    return 0;
                }
                // 去重处理
                projectileMoveConfigs = projectileMoveConfigs.GroupBy(c => c.ID).Select(g => g.First()).ToList();
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
                        // Log.Info($"Successfully processed projectile move with ID: {projectileConfig.ID}");
                    }
                    catch (Exception ex)
                    {
                        // Log.Error($"Failed to process projectile move config for ID {projectileConfig.ID}: {ex.Message}");
                    }
                }

                // Log.Info($"Total processed projectile move configs: {processedCount}");
                return processedCount;
            }
            catch (Exception ex)
            {
                // Log.Error($"Critical error in LoadAndApplyProjectileMove: {ex.Message}");
                return 0;
            }
        }

        // 获取或创建ProjectileMove
        private static FUStProjectileMoveDesc GetOrCreateProjectileMove(ProjectileMoveConfig config, Dictionary<int, FUStProjectileMoveDesc> projectileMoveList, FUStProjectileMoveDesc templateProjectile)
        {
            if (projectileMoveList.TryGetValue(config.ID, out var existingProjectile))
            {
                // Log.Info($"Updating existing projectile move with ID: {config.ID}");
                return existingProjectile;
            }

            var newProjectile = (FUStProjectileMoveDesc)templateProjectile.Clone();
            projectileMoveList.Add(config.ID, newProjectile);
            // Log.Info($"Creating new projectile move with ID: {config.ID}");
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
                configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "dataPBTable", "BulletData", "disp");


                var projectileDispConfigs = LoadJsonConfigs<ProjectileDispConfig>(configDirectory, "ProjectileDisp");
                var projectileDispList = GetAllProjectileDispDesc();



                if (projectileDispConfigs == null || projectileDispList.Count == 0 || projectileDispConfigs.Count == 0)
                {
                    Log.Error("Failed to load projectile disp configs");
                    return 0;
                }
                // 去重处理
                projectileDispConfigs = projectileDispConfigs.GroupBy(c => c.ID).Select(g => g.First()).ToList();
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

                // Log.Info($"Total processed projectile disp configs: {processedCount}");
                return processedCount;
            }
            catch (Exception ex)
            {
                // Log.Error($"Critical error in LoadAndApplyProjectileDisp: {ex.Message}");
                return 0;
            }
        }

        // 获取或创建ProjectileDisp
        private static FUStProjectileDispDesc GetOrCreateProjectileDisp(ProjectileDispConfig config, Dictionary<int, FUStProjectileDispDesc> projectileDispList, FUStProjectileDispDesc templateProjectile)
        {
            if (projectileDispList.TryGetValue(config.ID, out var existingProjectile))
            {
                // Log.Info($"Updating existing projectile disp with ID: {config.ID}");
                return existingProjectile;
            }

            var newProjectile = (FUStProjectileDispDesc)templateProjectile.Clone();
            projectileDispList.Add(config.ID, newProjectile);
            // Log.Info($"Creating new projectile disp with ID: {config.ID}");
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
                configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "dataPBTable", "ChargeSkill");

                var chargeSkillConfigs = LoadJsonConfigs<ChargeSkillConfig>(configDirectory, "ChargeSkill");
                var chargeSkillList = GetAllFUStChargeSkillSDesc();

                if (chargeSkillList == null)
                {
                    chargeSkillList = new Dictionary<int, FUStChargeSkillSDesc>();
                    // Log.Info("Charge skill list is null, creating a new one");
                }

                if (chargeSkillConfigs == null || chargeSkillConfigs.Count == 0)
                {
                    // Log.Error("Failed to load charge skill configs");
                    return 0;
                }

                // 去重处理
                chargeSkillConfigs = chargeSkillConfigs.GroupBy(c => c.ID).Select(g => g.First()).ToList();
                const int templateSkillId = 10720;
                if (!chargeSkillList.TryGetValue(templateSkillId, out var templateSkill))
                {
                    templateSkill = new FUStChargeSkillSDesc();
                    chargeSkillList.Add(templateSkillId, templateSkill);
                    // Log.Info($"Template skill (ID: {templateSkillId}) not found, created a new one");
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
                        // Log.Error($"Failed to process charge skill config for ID {skillConfig.ID}: {ex.Message}");
                    }
                }

                Log.Info($"Total processed charge skill configs: {processedCount}");
                return processedCount;
            }
            catch (Exception ex)
            {
                // Log.Error($"Critical error in LoadAndApplyChargeSkill: {ex.Message}");
                return 0;
            }
        }


        // 修改蓄力技能
        private static FUStChargeSkillSDesc GetOrCreateChargeSkill(ChargeSkillConfig config, Dictionary<int, FUStChargeSkillSDesc> chargeSkillList, FUStChargeSkillSDesc templateSkill)
        {
            if (chargeSkillList.TryGetValue(config.ID, out var existingSkill))
            {
                // Log.Info($"Updating existing charge skill with ID: {config.ID}");
                return existingSkill;
            }

            var newSkill = (FUStChargeSkillSDesc)templateSkill.Clone();
            chargeSkillList.Add(config.ID, newSkill);
            // Log.Info($"Creating new charge skill with ID: {config.ID}");
            return newSkill;
        }




        // 加载并应用Summon配置


        public static int LoadAndApplySummon(string configDirectory = null)
        {
            try
            {
                configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "dataPBTable", "Summon");

                var summonConfigs = LoadJsonConfigs<SummonConfig>(configDirectory, "Summon");
                var summonList = BGW_GameDB.GetAllSummonCommDesc();

                // 如果summonList为空，创建一个新的字典
                if (summonList == null)
                {
                    summonList = new Dictionary<int, FUStSummonCommDesc>();
                    // Log.Info("Summon list is null, creating a new one");
                }
                else if (summonList.Count == 0)
                {
                    // Log.Info("Summon list is empty, but will continue processing");
                }

                if (summonConfigs == null || summonConfigs.Count == 0)
                {
                    // Log.Error("Failed to load summon configs");
                    return 0;
                }
                // 去重处理
                summonConfigs = summonConfigs.GroupBy(c => c.ID).Select(g => g.First()).ToList();
                // 如果没有模板召唤物，使用默认值或创建一个
                const int templateSummonId = 1001101;
                if (!summonList.TryGetValue(templateSummonId, out var templateSummon))
                {
                    // 创建一个默认的模板召唤物
                    templateSummon = new FUStSummonCommDesc();
                    summonList.Add(templateSummonId, templateSummon);
                    // Log.Info($"Template summon (ID: {templateSummonId}) not found, created a new one");
                }

                var processedCount = 0;
                foreach (var summonConfig in summonConfigs)
                {
                    try
                    {
                        var targetSummon = GetOrCreateSummon(summonConfig, summonList, templateSummon);
                        CopyProperties(summonConfig, targetSummon);
                        processedCount++;
                        // Log.Info($"Successfully processed summon with ID: {summonConfig.ID}");
                    }
                    catch (Exception ex)
                    {
                        // Log.Error($"Failed to process summon config for ID {summonConfig.ID}: {ex.Message}");
                    }
                }

                // Log.Info($"Total processed summon configs: {processedCount}");
                return processedCount;
            }
            catch (Exception ex)
            {
                // Log.Error($"Critical error in LoadAndApplySummon: {ex.Message}");
                return 0;
            }
        }

        // 获取或创建Summon
        private static FUStSummonCommDesc GetOrCreateSummon(SummonConfig config, Dictionary<int, FUStSummonCommDesc> summonList, FUStSummonCommDesc templateSummon)
        {
            if (summonList.TryGetValue(config.ID, out var existingSummon))
            {
                // Log.Info($"Updating existing summon with ID: {config.ID}");
                return existingSummon;
            }

            var newSummon = (FUStSummonCommDesc)templateSummon.Clone();
            summonList.Add(config.ID, newSummon);
            // Log.Info($"Creating new summon with ID: {config.ID}");
            return newSummon;
        }


        // 加载技能
        public static int LoadAndApplySkillDesc(string configDirectory = null)
        {
            try
            {
                configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "dataPBTable", "skillDesc");

                var skillConfigs = LoadJsonConfigs<SkillConfig>(configDirectory, "SkillDesc");
                var skillList = BGW_GameDB.GetAllSkillSDesc();

                if (skillList == null || skillList.Count == 0 || skillConfigs == null)
                {
                    Log.Error("Failed to load skill configs or skill list is not available");
                    return 0;
                }

                const int templateSkillId = 10801;
                if (!skillList.TryGetValue(templateSkillId, out var templateSkill))
                {
                    Log.Error($"Template skill (ID: {templateSkillId}) not found");
                    return 0;
                }
                // 去重处理
                skillConfigs = skillConfigs.GroupBy(c => c.ID).Select(g => g.First()).ToList();
                var processedCount = 0;
                foreach (var skillConfig in skillConfigs)
                {
                    try
                    {
                        var targetSkill = GetOrCreateSkillDesc(skillConfig, skillList, templateSkill);
                        CopyProperties(skillConfig, targetSkill);
                        processedCount++;
                        // Log.Info($"Successfully processed skill with ID: {skillConfig.ID}");
                    }
                    catch (Exception ex)
                    {
                        Log.Error($"Failed to process skill config for ID {skillConfig.ID}: {ex.Message}");
                    }
                }

                // Log.Info($"Total processed skill configs: {processedCount}");
                return processedCount;
            }
            catch (Exception ex)
            {
                Log.Error($"Critical error in LoadAndApplySkillDesc: {ex.Message}");
                return 0;
            }
        }

        private static FUStSkillSDesc GetOrCreateSkillDesc(SkillConfig config, Dictionary<int, FUStSkillSDesc> skillList, FUStSkillSDesc templateSkill)
        {
            if (skillList.TryGetValue(config.ID, out var existingSkill))
            {
                // Log.Info($"Updating existing skill with ID: {config.ID}");
                return existingSkill;
            }

            var newSkill = (FUStSkillSDesc)templateSkill.Clone();
            skillList.Add(config.ID, newSkill);
            // Log.Info($"Creating new skill with ID: {config.ID}");
            return newSkill;
        }

        // 加载技能效果

        public static int LoadAndApplySkillEffect(string configDirectory = null)
        {
            try
            {
                configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "dataPBTable", "skillEffect");

                var buffEffectConfigs = LoadJsonConfigs<SkillEffectConfig>(configDirectory, "skillEffect");
                var buffEffectList = BGW_GameDB.GetAllSkillEffectDesc();

                if (buffEffectList == null || buffEffectList.Count == 0 || buffEffectConfigs == null)
                {
                    Log.Error("Failed to load buff effect configs or buff effect list is not available");
                    return 0;
                }

                const int templateBuffEffectId = 1080101;
                if (!buffEffectList.TryGetValue(templateBuffEffectId, out var templateBuffEffect))
                {
                    Log.Error($"Template buff effect (ID: {templateBuffEffectId}) not found");
                    return 0;
                }
                // 去重处理
                buffEffectConfigs = buffEffectConfigs.GroupBy(c => c.ID).Select(g => g.First()).ToList();
                var processedCount = 0;
                foreach (var buffEffectConfig in buffEffectConfigs)
                {
                    try
                    {
                        var targetBuffEffect = GetOrCreateSkillEffect(buffEffectConfig, buffEffectList, templateBuffEffect);
                        CopyProperties(buffEffectConfig, targetBuffEffect);
                        processedCount++;
                    }
                    catch (Exception ex)
                    {
                        // Log.Error($"Failed to process buff effect config for ID {buffEffectConfig.ID}: {ex.Message}");
                    }
                }

                // Log.Info($"Total processed buff effect configs: {processedCount}");
                return processedCount;
            }
            catch (Exception ex)
            {
                // Log.Error($"Critical error in LoadAndApplyBuffEffect: {ex.Message}");
                return 0;
            }
        }

        private static FUStSkillEffectDesc GetOrCreateSkillEffect(SkillEffectConfig config, Dictionary<int, FUStSkillEffectDesc> buffEffectList, FUStSkillEffectDesc templateBuffEffect)
        {
            if (buffEffectList.TryGetValue(config.ID, out var existingBuffEffect))
            {
                // Log.Info($"Updating existing buff effect with ID: {config.ID}");
                return existingBuffEffect;
            }

            var newBuffEffect = (FUStSkillEffectDesc)templateBuffEffect.Clone();
            buffEffectList.Add(config.ID, newBuffEffect);
            // Log.Info($"Creating new buff effect with ID: {config.ID}");
            return newBuffEffect;
        }

        // 修改铜头不可击溃
        public static void ModifyIronData()
        {
            var ironDataList = BG_ProtobufDataAPI<FUStIronBodyConfigDesc>.Get().GetAll();
            if (ironDataList != null && ironDataList?.Count > 0)
            {
                foreach (var ironData in ironDataList.Values)
                {
                    if (ironData.PlayerDefense > 1 && ironData.PlayerDefense < 999)
                    {
                        ironData.PlayerDefense = 999;
                    }
                }

            }
        }


        // 修改血上限
        public static void ModifyHP()
        {
            var unitList = BGW_GameDB.GetAllUnitBattleInfoExtendDesc();
            if (unitList != null && unitList?.Count > 0)
            {
                foreach (var itemData in unitList.Values)
                {
                    if (itemData.HPFixedDM > 500 && itemData.HPFixedDM < 90000 && (int)itemData.QualityType < 9)

                    {
                        var num = (int)itemData.QualityType;
                        var hpNum = (int)num * 2 * 1000;
                        if (num > 6)
                        {
                            hpNum = (int)num * 1 * 1000;
                        }
                        if (itemData.DefaultFreezeDefValue > 100)
                        {
                            itemData.DefaultFreezeDefValue = 50;
                        }
                        if (itemData.DefaultBurnDefValue > 100)
                        {
                            itemData.DefaultBurnDefValue = 50;
                        }

                        if (itemData.DefaultPoisonDefValue > 100)
                        {
                            itemData.DefaultPoisonDefValue = 50;
                        }

                        if (itemData.DefaultThunderDefValue > 100)
                        {
                            itemData.DefaultThunderDefValue = 50;
                        }

                        itemData.HPFixedDM = Math.Min(itemData.HPFixedDM + hpNum, 40 * 10000);

                    }
                }
            }
        }
        // 加载并应用被动技能配置
        public static int LoadAndApplyPassiveSkills(string configDirectory = null)
        {
            try
            {
                configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "dataPBTable", "PassiveSkills");

                var passiveConfigs = LoadJsonConfigs<PassiveConfig>(configDirectory, "PassiveSkills");
                var passList = BG_ProtobufDataAPI<FUStPassiveSkillDesc>.Get().GetAll();

                if (passiveConfigs == null || passiveConfigs.Count == 0)
                {
                    Log.Error("Failed to load passive skill configs");
                    return 0;
                }

                if (passList == null || passList.Count == 0)
                {
                    Log.Error("Failed to get passive skill list from game database");
                    return 0;
                }
                // 去重处理
                passiveConfigs = passiveConfigs.GroupBy(c => c.ID).Select(g => g.First()).ToList();
                var processedCount = 0;
                foreach (var config in passiveConfigs)
                {
                    try
                    {
                        if (passList.TryGetValue(config.ID, out var passiveSkill))
                        {
                            // 修改BaseValue
                            if (config.BaseValue.HasValue)
                            {
                                passiveSkill.BaseValue = (float)config.BaseValue.Value;
                            }

                            // 可以添加更多属性的修改逻辑

                            processedCount++;
                        }
                        else
                        {
                            Log.Error($"Passive skill with ID {config.ID} not found");
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Error($"Failed to process passive skill config for ID {config.ID}: {ex.Message}");
                    }
                }

                Log.Info($"Total processed passive skill configs: {processedCount}");
                return processedCount;
            }
            catch (Exception ex)
            {
                Log.Error($"Critical error in LoadAndApplyPassiveSkills: {ex.Message}");
                return 0;
            }
        }


        // 索敌距离
        public static void ModifyPlayCtrlDescData()
        {
            var dataList = BG_ProtobufDataAPI<FUStPlayerSkillCtrlDesc>.Get().GetAll();
            if (dataList != null && dataList?.Count > 0)
            {
                foreach (var attackItem in dataList.Values)
                {
                    if (attackItem.AttackRange > 100 && attackItem.AttackRange < 2000)
                    {
                        attackItem.AttackRange = 2000;
                    }
                    if (attackItem.AttackSelectZLimit > 0 && attackItem.AttackSelectZLimit < 1500)
                    {
                        attackItem.AttackSelectZLimit = 1500;
                    }
                }
            }

        }


        // 套装只需要一套就能生效
        public static void ModifySuitDesc()
        {
            var dataList = BG_ProtobufDataAPI<FUStSuitDesc>.Get().GetAll();
            if (dataList?.Values == null || dataList.Count == 0)
                return;

            foreach (var itemData in dataList.Values.Where(item => item?.SuitInfo?.Count > 0))
            {
                foreach (var suitInfo in itemData.SuitInfo.Where(s => s != null))
                {
                    if (suitInfo.TriggerNum > 1)
                        suitInfo.TriggerNum = 1;

                    if (suitInfo.SuitEffectID == 901612)
                    {
                        suitInfo.SuitEffectDesc = "免疫投技，获得<EquipDetail_SuitDesc_KW>强硬</>效果";
                    }
                }
            }

        }



        public static void ModifyEquipDesc()
        {
            var dataList = BG_ProtobufDataAPI<EquipDesc>.Get().GetAll();
            if (dataList?.Values == null || dataList.Count == 0)
                return;

            foreach (var itemData in dataList.Values)
            {
                if (itemData?.Id == 16035)
                {
                    itemData.EquipEffectDesc = "装备后，每秒恢复20点生命/法力/法宝/变身能量；攻击触发暴击立即恢复20点棍势";
                }
            }

        }


        public static void ModifySoulskill()
        {
            var soulSkillList = BG_ProtobufDataAPI<SoulSkillDesc>.Get().GetAll();
            if (soulSkillList == null || soulSkillList.Count == 0) return;
            foreach (var soulSkill in soulSkillList.Values)
            {
                if (soulSkill.CastEnergy > 2)
                {
                    soulSkill.CastEnergy = 2;
                }
            }

        }

        public static void ModifyDrop()
        {
            var itemsList = BG_ProtobufDataAPI<FUStUnitBattleInfoExtendDesc>.Get().GetAll();
            if (itemsList == null || itemsList.Count == 0) return;
            var listArr = new List<int> { 23008, 34022, 34012 };
            //91019  金趁心,业火晶
            foreach (var item in itemsList.Values)
            {
                if (item.DropRule.Count >= 0)
                {
                    item.DropRule.AddRange(listArr);
                }
            }
        }

        public static void ModifyPrice()
        {
            RepeatedField<ItemDesc> itemsList = GameDBRuntime.GetTBItemDesc().List;
            if (itemsList == null || itemsList.Count == 0) return;
            foreach (var item in itemsList)
            {
                if (item.SellPrice > 0)
                {
                    item.SellPrice = item.SellPrice + 200 * 10000;
                }
                if (item.CarryMax > 0 && item.CarryMax < 999)
                {
                    item.CarryMax = 999;
                }
            }



        }
        public static void ModifyCommDropRuleDesc()
        {
            var itemsList = BG_ProtobufDataAPI<CommDropRuleDesc>.Get().GetAll();
            if (itemsList == null || itemsList.Count == 0) return;
            // 100% 掉落

            foreach (var item in itemsList.Values)
            {
                item.GroupDropRate = 100000;
                item.RollType = DropRollType.All;
                item.ExtraMoney = 100 * 10000;
                item.ExtraExp = 500;

                foreach (var Itemnum in item.RandDrop)
                {
                    Itemnum.Rate = 100000;
                }
                item.RandDrop.AddRange(new List<DropItemOne> { new DropItemOne { ItemId = 1006, Rate = 100000, MinNum = 1, MaxNum = 1 }, new DropItemOne { ItemId = 3961, Rate = 100000, MinNum = 1, MaxNum = 1 } });

                foreach (var ItemLib in item.DropLib)
                {
                    ItemLib.Weight = 10000;
                }
            }


            var itemsList2 = BG_ProtobufDataAPI<UnitDropNumDesc>.Get().GetAll();
            if (itemsList2 == null || itemsList2.Count == 0) return;
            foreach (var item2 in itemsList2.Values)
            {
                if (item2?.Random.Count > 0)
                {
                    foreach (var ItemNum in item2.Random)
                    {
                        if (ItemNum.Weight < 10000)
                        {
                            ItemNum.Weight = 10000;
                        }
                    }
                }
            }

        }
        public static void ModifyWeaponBuild()
        {
            var itemsList = BG_ProtobufDataAPI<WeaponBuildDesc>.Get().GetAll();
            if (itemsList == null || itemsList.Count == 0) return;
            var listArr = new List<ItemOne> { new ItemOne { Id = 1002, Num = 10 } };
            foreach (var item in itemsList.Values)
            {
                if (item.CostItem.Count > 0)
                {
                    item.CostItem.Clear();
                    item.CostItem.AddRange(listArr);
                }
                if (item.TransformItem.Count > 0)
                {
                    item.TransformItem.Clear();
                    item.TransformItem.AddRange(listArr);
                }

            }
        }

        public static void ModifyShopDesc()
        {
            var itemsList = BG_ProtobufDataAPI<ShopItemGroupDesc>.Get().GetAll();
            Log.Info($"Loaded ShopItemGroupDesc: {itemsList?.Count}");
            if (itemsList == null || itemsList.Count == 0) return;


        }

        public static void ModifyTrans()
        {
            var transList = BG_ProtobufDataAPI<FUStPlayerTransAttrDesc>.Get().GetAll();
            if (transList == null || transList.Count == 0) return;
            foreach (var itemData in transList.Values)
            {
                if (itemData.FreezeDefBase < 999)
                {
                    itemData.FreezeDefBase = 999;
                }
                if (itemData.BurnDefBase < 999)
                {
                    itemData.BurnDefBase = 999;
                }

                if (itemData.PoisonDefBase < 999)
                {
                    itemData.PoisonDefBase = 999;
                }

                if (itemData.ThunderDefBase < 999)
                {
                    itemData.ThunderDefBase = 999;
                }
            }
        }

        public static List<AnimRuleBySweepCheck> allSweepCheckAnimRules;
        public static List<AnimRuleBySweepCheck> LoadAnimRulesBySweepCheck(string configDirectory = null)
        {

            if (allSweepCheckAnimRules != null && allSweepCheckAnimRules.Count > 0)
            {
                return allSweepCheckAnimRules;
            }
            configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "AnimRulesBySweepCheck");
            var allRules = new List<AnimRuleBySweepCheck>();

            if (!Directory.Exists(configDirectory))
            {
                Log.Error($"AnimRulesBySweepCheck directory not found: {configDirectory}");
                try
                {
                    Directory.CreateDirectory(configDirectory);
                    Log.Info($"Created AnimRulesBySweepCheck directory: {configDirectory}");
                }
                catch (Exception ex)
                {
                    Log.Error($"Failed to create AnimRulesBySweepCheck directory: {ex.Message}");
                    return allRules;
                }
            }

            foreach (string file in Directory.GetFiles(configDirectory, "*.json"))
            {
                try
                {
                    string json = File.ReadAllText(file);
                    var rules = JsonConvert.DeserializeObject<List<AnimRuleBySweepCheck>>(json);
                    if (rules != null)
                    {
                        allRules.AddRange(rules);
                    }
                }
                catch (Exception ex)
                {
                    Log.Error($"Error loading anim rules from {file}: {ex.Message}");
                }
            }

            Log.Info($"Total loaded anim rules: {allRules.Count}");
            allSweepCheckAnimRules = allRules;
            return allRules;
        }




        public static int LoadAndApplyDamageExpandDesc(string configDirectory = null)
        {
            try
            {
                configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "dataPBTable", "DamageExpandDesc");

                var damageExpandConfigs = LoadJsonConfigs<DamageExpandConfig>(configDirectory, "DamageExpandDesc");
                var dataList = BG_ProtobufDataAPI<FUStSkillDamageExpandDesc>.Get().GetAll();

                if (damageExpandConfigs == null || damageExpandConfigs.Count == 0)
                {
                    Log.Error("Failed to load damage expand configs");
                    return 0;
                }

                if (dataList == null)
                {
                    dataList = new Dictionary<int, FUStSkillDamageExpandDesc>();
                }

                // 去重处理
                damageExpandConfigs = damageExpandConfigs.GroupBy(c => c.ID).Select(g => g.First()).ToList();

                const int templateId = 123456; // 使用一个已存在的ID作为模板
                if (!dataList.TryGetValue(templateId, out var templateExpand))
                {
                    templateExpand = new FUStSkillDamageExpandDesc();
                    templateExpand.CritRateAddition = 1;
                    dataList.Add(templateId, templateExpand);
                }
                templateExpand.CritRateAddition = 1;
                var processedCount = 0;
                foreach (var config in damageExpandConfigs)
                {
                    try
                    {
                        var targetExpand = GetOrCreateDamageExpandDesc(config, dataList, templateExpand);
                        CopyProperties(config, targetExpand);
                        processedCount++;
                    }
                    catch (Exception ex)
                    {
                        Log.Error($"Failed to process damage expand config for ID {config.ID}: {ex.Message}");
                    }
                }

                Log.Info($"Total processed damage expand configs: {processedCount}");
                return processedCount;
            }
            catch (Exception ex)
            {
                Log.Error($"Critical error in LoadAndApplyDamageExpandDesc: {ex.Message}");
                return 0;
            }
        }

        private static FUStSkillDamageExpandDesc GetOrCreateDamageExpandDesc(DamageExpandConfig config, Dictionary<int, FUStSkillDamageExpandDesc> dataList, FUStSkillDamageExpandDesc templateExpand)
        {
            if (dataList.TryGetValue(config.ID, out var existingExpand))
            {
                return existingExpand;
            }

            var newExpand = (FUStSkillDamageExpandDesc)templateExpand.Clone();
            dataList.Add(config.ID, newExpand);
            return newExpand;
        }


        public static List<ActionConfig> LoadActionConfigs(string configDirectory = null)
        {
            configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "ActionsByInput");
            var actionConfigs = new List<ActionConfig>();

            if (!Directory.Exists(configDirectory))
            {
                Log.Error($"Action configs directory not found: {configDirectory}");
                try
                {
                    Directory.CreateDirectory(configDirectory);
                    Log.Info($"Created action configs directory: {configDirectory}");
                }
                catch (Exception ex)
                {
                    Log.Error($"Failed to create action configs directory: {ex.Message}");
                    return actionConfigs;
                }
            }

            foreach (string file in Directory.GetFiles(configDirectory, "*.json"))
            {
                try
                {
                    string json = File.ReadAllText(file);
                    var configs = JsonConvert.DeserializeObject<List<ActionConfig>>(json);
                    if (configs != null)
                    {
                        actionConfigs.AddRange(configs);
                    }
                }
                catch (Exception ex)
                {
                    Log.Error($"Error loading action config from {file}: {ex.Message}");
                }
            }

            Log.Info($"Total loaded action configs: {actionConfigs.Count}");
            return actionConfigs;
        }


    }
}



