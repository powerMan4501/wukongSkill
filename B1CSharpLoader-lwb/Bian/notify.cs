
using UnrealEngine.Engine;
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
using UnrealEngine.Runtime;



namespace bian;

public class AnimSweepConfig
{
    public string anim { get; set; }
    public int addRadius { get; set; }
}

// 添加数据模型类
public class NotifyParams
{
    public double? Duration { get; set; }
    public double? SegmentLength { get; set; }
    public double? LinkValue { get; set; }
}

public class StateClassParams
{
    public int? BuffID { get; set; }
    public object? AMScaleAxis { get; set; }
    public double? AMScaleMinRate { get; set; }
    public double? AMScaleMaxRate { get; set; }
    public double? AMScaleMoveOffset { get; set; }
    public double? PureScaleValue { get; set; }
    public double? LandingTraceLength { get; set; }
}

public class NotifyItem
{
    public NotifyParams? NotifyParams { get; set; }
    public string? NotifyStateClass { get; set; }
    public StateClassParams? StateClassParams { get; set; }
}

public class NotifyData
{
    public string PathName { get; set; }
    public int ID { get; set; }
    public List<NotifyItem> notifys { get; set; }
}

// 在 bian 命名空间内添加这个辅助类
public static class BANS_GSCalcAMScaleHelper
{

    public static object CreateInstance()
    {
        // 使用反射创建实例
        var assembly = Assembly.GetAssembly(typeof(BANS_GSAddBuffByID)); // 假设 BANS_GSAddBuffByID 和 BANS_GSCalcAMScale 在同一程序集
        var type = assembly.GetType("b1.BANS_GSCalcAMScale"); // 使用完整的类型名称
        return Activator.CreateInstance(type, true); // true 表示允许访问非公共构造函数
    }
    public static object GetProperty(object instance, string propertyName)
    {
        var type = instance.GetType();
        var property = type.GetProperty(propertyName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        if (property != null)
        {
            return property.GetValue(instance);
        }
        return null;
    }

    public static void SetProperty(object instance, string propertyName, object value)
    {
        var type = instance.GetType();
        var property = type.GetProperty(propertyName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        if (property != null)
        {
            property.SetValue(instance, value);
        }
    }
    public static void SetProperties(object instance, StateClassParams stateParams)
    {
        if (stateParams == null || instance == null) return;

        // 创建属性名到值的映射
        var properties = new Dictionary<string, object>
    {
        { "AMScaleAxis", stateParams.AMScaleAxis },
        { "AMScaleMinRate", stateParams.AMScaleMinRate },
        { "AMScaleMaxRate", stateParams.AMScaleMaxRate },
        { "AMScaleMoveOffset", stateParams.AMScaleMoveOffset },
        { "PureScaleValue", stateParams.PureScaleValue },
        { "LandingTraceLength", stateParams.LandingTraceLength }
    };

        // 遍历所有属性，只有当值不为null时才设置
        foreach (var prop in properties)
        {
            if (prop.Value != null)
            {
                SetProperty(instance, prop.Key, prop.Value);
            }
        }
    }

}


public static class NotifyUtils
{
    private static readonly Dictionary<string, bool> ProcessedAnimCache = new Dictionary<string, bool>();
    private static List<NotifyData> notifyDataList = new List<NotifyData>();
    private static List<AnimSweepConfig> sweepConfigList = new List<AnimSweepConfig>();


    public static void LoadSweepConfig()
    {
        try
        {
            string folderPath = Path.Combine("CSharpLoader", "Mods", "bian", "AnimSweepCheck");
            if (!Directory.Exists(folderPath))
            {
                Log.Warn($"Directory not found: {folderPath}");
                return;
            }

            string[] jsonFiles = Directory.GetFiles(folderPath, "*.json");
            if (jsonFiles.Length == 0)
            {
                Log.Warn($"No JSON files found in: {folderPath}");
                return;
            }

            foreach (string file in jsonFiles)
            {
                try
                {
                    string jsonContent = File.ReadAllText(file);
                    List<AnimSweepConfig> configs = JsonConvert.DeserializeObject<List<AnimSweepConfig>>(jsonContent) ?? new List<AnimSweepConfig>();
                    sweepConfigList.AddRange(configs);
                }
                catch (Exception ex)
                {
                    Log.Error($"Error processing file {file}: {ex.Message}");
                }
            }
        }
        catch (Exception ex)
        {
            Log.Error($"Error loading sweep config: {ex.Message}");
        }
    }


    // 添加加载JSON数据的方法
    public static void LoadNotifyData()
    {
        try
        {
            string folderPath = Path.Combine("CSharpLoader", "Mods", "bian", "AnimNotify");
            if (!Directory.Exists(folderPath))
            {
                Log.Error($"Directory not found: {folderPath}");
                return;
            }

            if (Directory.Exists(folderPath))
            {
                string[] jsonFiles = Directory.GetFiles(folderPath, "*.json");
                if (jsonFiles.Length == 0)
                {
                    Log.Warn($"No JSON files found in: {folderPath}");
                    return;
                }
                foreach (string file in jsonFiles)
                {
                    try
                    {
                        string jsonContent = File.ReadAllText(file);
                        List<NotifyData> data = JsonConvert.DeserializeObject<List<NotifyData>>(jsonContent);
                        if (data != null && data.Count > 0)
                        {
                            notifyDataList.AddRange(data);
                        }
                        else
                        {
                            Log.Warn($"No valid data found in file: {file}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Error($"Error processing file {file}: {ex.Message}");
                    }
                }

            }
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Error loading notify data: {ex.Message}");
        }
    }

    public static void handleNotify(UAnimMontage Montage)
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
            // 确保数据已加载
            if (notifyDataList.Count == 0)
            {
                LoadNotifyData();
            }


            UGSE_AnimFuncLib.GetAllNotifyEvent(Montage, out var AnimNotifyEventList);

            // 查找匹配的JSON数据
            var strPathName = Montage.PathName.ToString();
            NotifyData matchingData = notifyDataList.FirstOrDefault(data => data.PathName == Montage.PathName);
            var addRadius = 100;

            // 替换原有的硬编码判断逻辑
            var config = sweepConfigList.FirstOrDefault(c => strPathName.Contains(c.anim));
            if (config != null)
            {
                addRadius = config.addRadius;
            }
            // 查找相同类型的通知作为模板
            foreach (FAnimNotifyEvent item in AnimNotifyEventList)
            {
                if (item.NotifyStateClass is BANS_GSSweepCheck sweepCheck)
                {
                    for (int i = 0; i < sweepCheck.SweepCheckShape.Count; i++)
                    {
                        var sweepItem = sweepCheck.SweepCheckShape[i];
                        sweepItem.Radius = sweepItem.Radius < 1000 ? sweepItem.Radius + addRadius : sweepItem.Radius;
                        sweepCheck.SweepCheckShape[i] = sweepItem;
                    }
                }
                else if (item.NotifyName == new FName("BANS_GSCalcAMScale"))
                {
                    // 获取当前属性值
                    var currentValue = BANS_GSCalcAMScaleHelper.GetProperty(item.NotifyStateClass, "AMScaleMaxRate");
                    // 只有当当前值小于10时才修改为10
                    if (currentValue is double doubleValue && doubleValue < 10)
                    {
                        BANS_GSCalcAMScaleHelper.SetProperty(item.NotifyStateClass, "AMScaleMaxRate", 10);
                    }
                }

            }

            // if (matchingData != null && matchingData?.notifys != null && matchingData?.notifys?.Count > 0)
            // {
            //     // 添加JSON数据中的通知
            //     foreach (var notifyItem in matchingData.notifys)
            //     {
            //         if (notifyItem == null || notifyItem.NotifyStateClass == null)
            //         {
            //             continue;
            //         }
            //         // 查找相同类型的通知作为模板
            //         FAnimNotifyEvent templateEvent = AnimNotifyEventList.FirstOrDefault(e =>
            //             e.NotifyStateClass?.GetType().Name == notifyItem.NotifyStateClass) ?? AnimNotifyEventList[0];
            //         FAnimNotifyEvent? newNotify = new FAnimNotifyEvent();
            //         // 根据通知类型创建相应的通知类

            //         if (newNotify != null && templateEvent != null)
            //         {
            //             // 设置通知参数
            //             newNotify.TriggerTimeOffset = 0;
            //             newNotify.EndTriggerTimeOffset = 0;
            //             newNotify.TriggerWeightThreshold = templateEvent.TriggerWeightThreshold;
            //             newNotify.NotifyName = templateEvent.NotifyName;
            //             newNotify.Notify = templateEvent.Notify;
            //             newNotify.NotifyStateClass = templateEvent.NotifyStateClass;
            //             newNotify.Duration = (float)(notifyItem?.NotifyParams?.Duration ?? 0.5);
            //             newNotify.EndLink = templateEvent.EndLink;

            //             newNotify.MontageTickType = templateEvent.MontageTickType;
            //             newNotify.NotifyTriggerChance = templateEvent.NotifyTriggerChance;
            //             newNotify.NotifyFilterType = templateEvent.NotifyFilterType;
            //             newNotify.NotifyFilterLOD = templateEvent.NotifyFilterLOD;


            //             newNotify.TrackIndex = templateEvent.TrackIndex;
            //             newNotify.LinkedMontage = templateEvent.LinkedMontage;
            //             newNotify.SlotIndex = templateEvent.SlotIndex;

            //             newNotify.SegmentIndex = templateEvent.SegmentIndex;
            //             newNotify.CachedLinkMethod = templateEvent.CachedLinkMethod;
            //             newNotify.SegmentBeginTime = templateEvent.SegmentBeginTime;



            //             newNotify.SegmentLength = (float)(notifyItem?.NotifyParams?.SegmentLength ?? 2);

            //             newNotify.LinkValue = (float)(notifyItem?.NotifyParams?.LinkValue ?? 0.0);
            //             newNotify.LinkedSequence = templateEvent.LinkedSequence;


            //             // 根据类型创建通知状态类
            //             if (notifyItem?.NotifyStateClass == "BANS_GSAddBuffByID")
            //             {
            //                 var addBuffNotify = UObject.NewObject<BANS_GSAddBuffByID>();
            //                 addBuffNotify.BuffID = notifyItem?.StateClassParams?.BuffID ?? 287;
            //                 newNotify.NotifyStateClass = addBuffNotify;
            //                 newNotify.NotifyName = new FName("BANS_GSAddBuffByID");



            //                 AnimNotifyEventList[AnimNotifyEventList.Count - 1].NotifyStateClass = newNotify.NotifyStateClass;
            //                 AnimNotifyEventList[AnimNotifyEventList.Count - 1].NotifyName = newNotify.NotifyName;
            //                 AnimNotifyEventList[AnimNotifyEventList.Count - 1].LinkValue = newNotify.LinkValue;
            //                 AnimNotifyEventList[AnimNotifyEventList.Count - 1].LinkedSequence = newNotify.LinkedSequence;

            //             }
            //             else if (notifyItem?.NotifyStateClass == "BANS_GSCalcAMScale")
            //             {
            //                 // 使用辅助类创建实例
            //                 var calcAMScaleNotify = BANS_GSCalcAMScaleHelper.CreateInstance();

            //                 // 使用新的辅助方法批量设置属性值
            //                 BANS_GSCalcAMScaleHelper.SetProperties(calcAMScaleNotify, notifyItem?.StateClassParams);

            //                 newNotify.NotifyStateClass = calcAMScaleNotify as UAnimNotifyState;
            //                 newNotify.NotifyName = new FName("BANS_GSCalcAMScale");

            //             }

            //         }
            //     }
            // }
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
