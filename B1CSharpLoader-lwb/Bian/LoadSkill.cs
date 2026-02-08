


using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using CSharpModBase;
using UnrealEngine.Engine;
using b1.BGW;
using b1;
using BtlShare;
using UnrealEngine.Runtime;
using System;
using System.Linq;
using b1.Protobuf.DataAPI;


namespace bian;

public class LoadSkill
{
    public class ActionsBySkillConfig
    {
        public int skillID { get; set; }
        public string? TemplatePath { get; set; }
        public MontageConfig? montage_config { get; set; }
        public List<RuleAction>? cast_actions { get; set; }
        public List<sweepActionsConfig>? sweep_actions { get; set; }
        public List<RuleAction>? dmg_actions { get; set; }
        public List<RuleAction>? end_actions { get; set; }

        public List<sweepActionsConfig>? bullet_actions { get; set; }
        public List<EffectActions>? effect_actions { get; set; }
        public List<BuffAction>? buff_actions { get; set; }
    }

    public class sweepActionsConfig
    {

        public float linkValue { get; set; }
        public List<RuleAction>? actions { get; set; }

    }

    public class MontageConfig
    {
        public float? speedRate { get; set; }
        public float? AMSpeedRate { get; set; }
        public float? scaleWeaponNum { get; set; }

        public float? AMScaleRate { get; set; }
        public int? addRadius { get; set; }
        public List<int>? hitEffects { get; set; }
        public bool? replaceEffects { get; set; }
    }

    public class EffectActions
    {
        public int ID { get; set; }
        public List<RuleAction>? actions { get; set; }
    }

    public class BuffAction
    {
        public int ID { get; set; }
        public List<RuleAction>? actions { get; set; }
    }


    public static Dictionary<int, ActionsBySkillConfig> ActionsBySkillConfigs { get; set; } = new Dictionary<int, ActionsBySkillConfig>();

    public static Dictionary<int, List<RuleAction>> BuffRules { get; set; } = new Dictionary<int, List<RuleAction>>();
    public static Dictionary<int, List<RuleAction>> EffectRules { get; set; } = new Dictionary<int, List<RuleAction>>();
    public static Dictionary<string, List<RuleAction>> MontageRules { get; set; } = new Dictionary<string, List<RuleAction>>();
    public static Dictionary<string, ActionsBySkillConfig> TemplatePathConfigs { get; set; } = new Dictionary<string, ActionsBySkillConfig>();



    public static void LoadActionsBySkill(string configDirectory = null)
    {
        configDirectory ??= Path.Combine("CSharpLoader", "Mods", "bian", "ActionsBySkill");

        if (!Directory.Exists(configDirectory))
        {
            return;
        }

        ActionsBySkillConfigs.Clear();
        TemplatePathConfigs.Clear();
        BuffRules.Clear();
        EffectRules.Clear();
        foreach (string file in Directory.GetFiles(configDirectory, "*.json"))
        {

            string json = File.ReadAllText(file);
            var configs = JsonConvert.DeserializeObject<List<ActionsBySkillConfig>>(json);
            if (configs != null)
            {
                foreach (var config in configs)
                {
                    // 添加到TemplatePathConfigs字典
                    FUStSkillSDesc skillSDesc = BG_ProtobufDataAPI<FUStSkillSDesc>.Get().FindByID(config.skillID);
                    if (skillSDesc == null) return;
                    var templatePath = skillSDesc.TemplatePath;
                    if (!TemplatePathConfigs.ContainsKey(templatePath))
                    {
                        TemplatePathConfigs.Add(templatePath, config);
                    }
                    // LoadMontageRules(player, config);
                    if (!ActionsBySkillConfigs.ContainsKey(config.skillID))
                    {

                        ActionsBySkillConfigs.Add(config.skillID, config);

                        // 处理 buff_actions
                        if (config.buff_actions != null && config.buff_actions.Count > 0)
                        {
                            foreach (var buffAction in config.buff_actions)
                            {
                                if (buffAction != null && buffAction.ID > 0 && buffAction.actions != null && buffAction.actions.Count > 0)
                                {
                                    BuffRules[buffAction.ID] = buffAction.actions;
                                }
                            }
                        }

                        // 处理 effect_actions
                        if (config.effect_actions != null && config.effect_actions.Count > 0)
                        {
                            foreach (var effectAction in config.effect_actions)
                            {
                                if (effectAction.actions != null && effectAction.ID > 0)
                                {
                                    EffectRules[effectAction.ID] = effectAction.actions;
                                }
                            }
                        }
                    }
                }
            }


        }

        Log.Info($"Total loaded ActionsBySkill configs: {ActionsBySkillConfigs.Count}");
        Log.Info($"Total loaded BuffRules: {BuffRules.Count}");
        Log.Info($"Total loaded EffectRules: {EffectRules.Count}");
    }


    public static void LoadMontageRules(AActor player, ActionsBySkillConfig itemConfig)
    {
        if (player == null) return;


        var ActorResID = BGU_DataUtil.GetActorResID(player);
        if (!(ActorResID > 0)) return;
        FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(itemConfig.skillID, player);
        if (skillSDesc == null) return;
        var templatePath = skillSDesc.TemplatePath;
        UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(player).TryGetCachedResourceObj<UAnimMontage>(templatePath, ELoadResourceType.SyncLoadAndCache, EAssetPriority.Default, null, -1, ActorResID);
        if (uAnimMontage == null) return;
        TArrayUnsafe<FAnimNotifyEvent> AnimNotifyEventList = new TArrayUnsafe<FAnimNotifyEvent>();
        UGSE_AnimFuncLib.GetAllNotifyEvent(uAnimMontage, AnimNotifyEventList);
        Log.Info($" loaded AnimNotifyEventList:{uAnimMontage.PathName}, {AnimNotifyEventList.Count}");
        if (!(AnimNotifyEventList != null && AnimNotifyEventList.Count > 0))
        {
            return;
        }
        var config = itemConfig.montage_config;
        if (config == null) return;
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
    }
}