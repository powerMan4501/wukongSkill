
using UnrealEngine.Engine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using b1;
using CSharpModBase;



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
public static class BANS_GSAttackWarnningHelper
{
    public static object CreateInstance()
    {
        // 使用反射创建实例
        var assembly = Assembly.GetAssembly(typeof(BANS_GSAddBuffByID)); // 假设 BANS_GSAddBuffByID 和 BANS_GSAttackWarnning 在同一程序集
        var type = assembly.GetType("b1.BANS_GSAttackWarnning"); // 使用完整的类型名称
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

    public static bool IsAttackWarning(object instance)
    {
        if (instance == null) return false;
        var type = instance.GetType();
        return type.Name == "BANS_GSAttackWarnning";
    }
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
}
