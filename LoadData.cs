using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using b1;
using CSharpModBase;
using Google.Protobuf;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MagicMod
{
    /// <summary>
    /// 泛型 JSON 数据加载器（自包含，不依赖 ProtobufLoader）
    /// 复刻 ProtobufLoader 的核心注入逻辑，直接读取 JSON 并注入游戏数据
    /// 
    /// 使用方式：
    /// 1. 在 CSharpLoader/Mods/MagicMod/PBTable/ 目录下放置 JSON 文件
    ///    文件名格式: {类型名}-{任意后缀}.json，如 FUStBuffDesc-zl.json
    /// 2. JSON 格式: [{ "ID": 123, "field1": "value1", ... }, ...]
    /// 3. 通过按键绑定 LoadData 动作触发加载
    /// </summary>
    public static class LoadDataManager
    {
        // 备份: Type -> (ID -> 原始记录)，null 表示新增的记录
        private static readonly Dictionary<Type, Dictionary<int, IMessage>> RecordBackup
            = new Dictionary<Type, Dictionary<int, IMessage>>();

        #region 公开方法

        /// <summary>
        /// 从默认 PBTable 目录加载所有 JSON 数据文件
        /// </summary>
        public static bool isLoadFinish = false;
        public static void LoadAllJsonData()
        {
            if (isLoadFinish) return;
            string dataDir = GetPBTableDir();
            if (!Directory.Exists(dataDir))
            {
                Directory.CreateDirectory(dataDir);
                Log.Info($"[MagicMod] 已创建 PBTable 目录: {dataDir}");
                return;
            }

            string[] jsonFiles = Directory.GetFiles(dataDir, "*.json");
            if (jsonFiles.Length == 0)
            {
                Log.Info($"[MagicMod] PBTable 目录无 JSON 文件: {dataDir}");
                return;
            }

            Log.Info($"[MagicMod] 扫描 PBTable 目录，找到 {jsonFiles.Length} 个 JSON 文件");
            EnsureGameAssembliesLoaded();

            int successCount = 0;
            foreach (string filePath in jsonFiles)
            {
                if (LoadJsonDataFile(filePath))
                    successCount++;
            }

            RefreshDBCache();
            isLoadFinish = true;
            Log.Info($"[MagicMod] 数据加载完成: {successCount}/{jsonFiles.Length} 个文件成功");
        }

        /// <summary>
        /// 重置所有已修改的数据
        /// </summary>
        public static void ResetAllData()
        {
            try
            {
                foreach (var kvp in RecordBackup)
                {
                    Type dataType = kvp.Key;
                    var backups = kvp.Value;

                    var dataDict = GetDataDict(dataType);
                    if (dataDict == null) continue;

                    foreach (var backup in backups)
                    {
                        int id = backup.Key;
                        if (backup.Value == null)
                            dataDict.Remove(id); // 新增的记录，删除
                        else
                            dataDict[id] = backup.Value; // 恢复原始记录
                    }
                    Log.Info($"[MagicMod] 已重置 {dataType.Name}: {backups.Count} 条");
                }

                RecordBackup.Clear();
                RefreshDBCache();
                Log.Info("[MagicMod] 所有数据已重置");
            }
            catch (Exception e)
            {
                Log.Error($"[MagicMod] 重置数据失败: {e.Message}");
            }
        }

        /// <summary>
        /// 加载单个 JSON 数据文件
        /// </summary>
        public static bool LoadJsonDataFile(string filePath)
        {
            string fileName = Path.GetFileNameWithoutExtension(filePath);
            string typeName = ExtractTypeName(fileName);

            if (string.IsNullOrEmpty(typeName))
            {
                Log.Error($"[MagicMod] 无法从文件名提取类型名: {fileName}");
                return false;
            }

            Log.Info($"[MagicMod] 开始加载 {fileName} -> {typeName}");

            try
            {
                // 1. 读取 JSON
                string json = File.ReadAllText(filePath);
                JToken token = JToken.Parse(json);

                JArray recordsArray;
                if (token is JArray arr)
                    recordsArray = arr;
                else if (token is JObject obj && obj.TryGetValue("List", out var listToken) && listToken is JArray listArr)
                    recordsArray = listArr;
                else
                {
                    Log.Error($"[MagicMod] JSON 格式错误: {fileName}");
                    return false;
                }

                if (recordsArray.Count == 0)
                {
                    Log.Info($"[MagicMod] {fileName} 无数据记录");
                    return true;
                }

                // 1.5 模板合并：找 BuffTips=="template_01" 的记录作为模板
                JObject template = null;
                int templateIndex = -1;
                for (int i = 0; i < recordsArray.Count; i++)
                {
                    var obj = recordsArray[i] as JObject;
                    if (obj != null && obj.Value<string>("BuffTips") == "template_01")
                    {
                        template = obj;
                        templateIndex = i;
                        break;
                    }
                }
                if (template != null)
                {
                    recordsArray.RemoveAt(templateIndex);
                    Log.Info($"[MagicMod] 找到模板记录 template_01，将合并到 {recordsArray.Count} 条数据");
                }

                // 2. 找到数据类型
                Type dataType = ResolveType(typeName);
                if (dataType == null)
                {
                    Log.Error($"[MagicMod] 未找到数据类型: {typeName}");
                    return false;
                }

                // 3. 反序列化 JSON 为 protobuf 消息对象
                var jsonSettings = new JsonSerializerSettings
                {
                    DefaultValueHandling = DefaultValueHandling.Ignore,
                    NullValueHandling = NullValueHandling.Ignore,
                };

                var records = new List<object>();
                foreach (var recordToken in recordsArray)
                {
                    JObject recordObj = recordToken as JObject;
                    if (recordObj == null) continue;

                    // 如果有模板，先克隆模板再用记录覆盖（记录的值优先）
                    JObject mergeTarget = template != null
                        ? (JObject)template.DeepClone()
                        : new JObject();
                    mergeTarget.Merge(recordObj, new JsonMergeSettings
                    {
                        MergeArrayHandling = MergeArrayHandling.Replace
                    });

                    object record = JsonConvert.DeserializeObject(
                        mergeTarget.ToString(), dataType, jsonSettings);
                    if (record != null)
                        records.Add(record);
                }

                if (records.Count == 0)
                {
                    Log.Error($"[MagicMod] {fileName} 反序列化无有效记录");
                    return false;
                }

                // 4. 注入数据（参考 ProtobufLoader.LoadNoneRuntimeDataImp）
                InjectData(dataType, records);

                Log.Info($"[MagicMod] {fileName} 加载成功 ({records.Count} 条记录)");
                return true;
            }
            catch (Exception e)
            {
                Log.Error($"[MagicMod] 加载 {fileName} 失败: {e.Message}");
                return false;
            }
        }

        #endregion

        #region 数据注入（复刻 ProtobufLoader 核心逻辑）

        /// <summary>
        /// 注入数据到游戏的 _dataDict（参考 ProtobufLoader.LoadNoneRuntimeDataImp）
        /// </summary>
        private static void InjectData(Type dataType, List<object> records)
        {
            // 获取 BG_ProtobufDataAPI<T>.Get("ID") 实例
            object apiInstance = GetProtobufDataAPIInstance(dataType);
            if (apiInstance == null)
            {
                Log.Error($"[MagicMod] 获取 BG_ProtobufDataAPI 失败: {dataType.Name}");
                return;
            }

            // 获取 _dataDict 和 _propertyID（用 IDictionary 因为 Dictionary<int,T> 不能转为 Dictionary<int,object>）
            var dataDict = GetFieldOrProperty(apiInstance, "_dataDict") as IDictionary;
            string propertyID = GetFieldOrProperty(apiInstance, "_propertyID") as string;

            if (dataDict == null)
            {
                Log.Error($"[MagicMod] 获取 _dataDict 失败: {dataType.Name}");
                return;
            }

            if (string.IsNullOrEmpty(propertyID))
            {
                Log.Error($"[MagicMod] 获取 _propertyID 失败: {dataType.Name}");
                return;
            }

            // 初始化备份
            if (!RecordBackup.ContainsKey(dataType))
                RecordBackup[dataType] = new Dictionary<int, IMessage>();

            // 注入每条记录（与 ProtobufLoader.LoadNoneRuntimeDataImp 完全一致）
            foreach (object record in records)
            {
                int? id = GetFieldOrProperty(record, propertyID) as int?;
                if (!id.HasValue)
                {
                    Log.Warn("[MagicMod] 记录无 ID 字段，跳过");
                    continue;
                }

                if (dataDict.Contains(id.Value))
                {
                    // 备份原始记录（参考 ProtobufLoader 的 IDeepCloneable 备份）
                    if (!RecordBackup[dataType].ContainsKey(id.Value))
                    {
                        var existing = dataDict[id.Value] as IMessage;
                        if (existing != null)
                        {
                            // 尝试深拷贝
                            var cloneMethod = existing.GetType().GetMethod("Clone");
                            if (cloneMethod != null)
                                RecordBackup[dataType][id.Value] = cloneMethod.Invoke(existing, null) as IMessage;
                            else
                                RecordBackup[dataType][id.Value] = existing; // 无法克隆，保留引用
                        }
                        else
                        {
                            RecordBackup[dataType][id.Value] = null; // 标记为已覆盖
                        }
                    }
                    Log.Info($"[MagicMod] 覆盖 {dataType.Name} ID={id.Value}");
                }
                else
                {
                    if (!RecordBackup[dataType].ContainsKey(id.Value))
                        RecordBackup[dataType][id.Value] = null; // 标记为新增
                    Log.Info($"[MagicMod] 新增 {dataType.Name} ID={id.Value}");
                }

                dataDict[id.Value] = record;
            }
        }

        /// <summary>
        /// 获取 BG_ProtobufDataAPI<T>.Get("ID") 实例
        /// </summary>
        private static object GetProtobufDataAPIInstance(Type dataType)
        {
            Type apiType = null;
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                apiType = asm.GetType("b1.Protobuf.DataAPI.BG_ProtobufDataAPI`1");
                if (apiType != null) break;
            }
            if (apiType == null)
            {
                Log.Error("[MagicMod] 未找到 BG_ProtobufDataAPI 类型");
                return null;
            }

            Type closedType = apiType.MakeGenericType(dataType);
            return closedType.GetMethod("Get", BindingFlags.Static | BindingFlags.Public)
                ?.Invoke(null, new object[] { "ID" });
        }

        /// <summary>
        /// 获取数据的 _dataDict（用于 Reset）
        /// </summary>
        private static IDictionary GetDataDict(Type dataType)
        {
            object apiInstance = GetProtobufDataAPIInstance(dataType);
            if (apiInstance == null) return null;
            return GetFieldOrProperty(apiInstance, "_dataDict") as IDictionary;
        }

        #endregion

        #region 反射辅助（复刻 ProtobufLoader.MyExten）

        /// <summary>
        /// 获取字段或属性值（复刻 ProtobufLoader.MyExten.GetFieldOrProperty）
        /// 先查字段再查属性，避免 Ambiguous match
        /// </summary>
        private static object GetFieldOrProperty(object obj, string name)
        {
            Type type = obj.GetType();

            // 先查字段
            FieldInfo field = type.GetField(name, BindingFlags.Instance | BindingFlags.NonPublic)
                ?? type.GetField(name, BindingFlags.Instance | BindingFlags.Public)
                ?? type.GetField(name, BindingFlags.Static | BindingFlags.NonPublic)
                ?? type.GetField(name, BindingFlags.Static | BindingFlags.Public);
            if (field != null) return field.GetValue(obj);

            // 再查属性（用 GetProperties 遍历避免 Ambiguous match）
            foreach (var prop in type.GetProperties(
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                if (prop.Name == name) return prop.GetValue(obj);
            }

            return null;
        }

        #endregion

        #region 缓存刷新（复刻 ProtobufLoader.RefreshDBCache）

        /// <summary>
        /// 刷新游戏数据库缓存（复刻 ProtobufLoader.RefreshDBCache）
        /// 调用 BGW_GameDB 的各种 Init 方法 + GameDBRuntime.BuildAllDescToDict
        /// </summary>
        private static void RefreshDBCache()
        {
            try
            {
                Type gameDBType = null;
                foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
                {
                    gameDBType = asm.GetType("b1.BGW_GameDB")
                        ?? asm.GetType("b1.BGW.BGW_GameDB")
                        ?? asm.GetType("BGW_GameDB");
                    if (gameDBType != null) break;
                }
                // 也尝试从缓存查找
                if (gameDBType == null && _typeCache.TryGetValue("BGW_GameDB", out Type cached))
                    gameDBType = cached;

                if (gameDBType == null)
                {
                    Log.Error("[MagicMod] 未找到 BGW_GameDB 类型");
                    return;
                }

                // 复刻 ProtobufLoader.RefreshDBCache 的 Init 方法列表
                string[] initMethods = {
                    "InitPartRuleUnitMap", "InitsMapAttackHitFX_ID", "InitsMapBeAttackedFX_ID",
                    "InitCameraGroupUnitMap", "InitStraightCamUnitMap", "InitGiantCamUnitMap",
                    "InitDiagonalCamUnitMap", "InitPassiveSkillMap", "InitUnitDeadMap",
                    "InitSoulSkillMimicryMap", "InitHitSceneItemPerformMap", "InitFeatureFilterMap",
                    "InitBuffTickRuleBySimpleStateData", "InitOnlineScreenMsgConfDict",
                    "InitInteractMappingDict", "InitAiInteractMappingDict",
                    "InitCustomStateMachineDict", "InitGuideAssetConfigDict",
                    "InitActionNameTriggerEventIdDict", "InitGlobalConfigDesc",
                    "InitsChallengeDescDict", "InitCollectionSpawnInfoDict", "InitBossRoomDict",
                    "InitGlobalCannotDeadExtraCacheDict", "InitBuffDispMap", "InitBuffRuleMap",
                    "InitElementDmgRatioLevelMapping", "InitAbnormalCommConfig",
                    "InitBeAttackedDispInfo", "InitMapSymbolDescInfo", "InitGlobalAlchemyList",
                    "InitPigsyStoryIAndRLibrary", "InitDOPerformMapping",
                    "InitDefeatSlowTimeConfig", "InitCameraConversionParamConfig",
                    "InitPotentialEnergyMap", "InitBossDict", "InitAbnormalDispMap",
                    "InitAICrowdDetourlevelConfigDict", "InitBeAttackedStiffLevelMapping",
                    "InitDialogue_FacialAnimPreloadMap", "InitLevelSequenceClearBattleItemConfig",
                    "InitAkMarkerDesc", "InitFacialResourceMap", "InitSeqAudioJumpMap"
                };

                int invoked = 0;
                foreach (string methodName in initMethods)
                {
                    var method = gameDBType.GetMethod(methodName,
                        BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
                    if (method != null)
                    {
                        method.Invoke(null, null);
                        invoked++;
                    }
                }

                // 调用 GameDBRuntime.BuildAllDescToDict
                Type runtimeType = null;
                foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
                {
                    runtimeType = asm.GetType("b1.GameDBRuntime")
                        ?? asm.GetType("GameDBRuntime");
                    if (runtimeType != null) break;
                }
                if (runtimeType == null && _typeCache.TryGetValue("GameDBRuntime", out Type cachedRT))
                    runtimeType = cachedRT;

                if (runtimeType != null)
                {
                    var buildMethod = runtimeType.GetMethod("BuildAllDescToDict",
                        BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
                    if (buildMethod != null)
                    {
                        buildMethod.Invoke(null, null);
                        invoked++;
                    }
                }

                Log.Info($"[MagicMod] RefreshDBCache 完成，调用了 {invoked} 个方法");
            }
            catch (Exception e)
            {
                Log.Error($"[MagicMod] RefreshDBCache 失败: {e.Message}");
            }
            finally
            {
                ModHelper.refreshTalent();
            }
        }

        #endregion

        #region 程序集加载与类型解析

        private static void EnsureGameAssembliesLoaded()
        {
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                if (asm.GetName().Name == "GSE.ProtobufDB") { BuildTypeCache(); return; }
            }

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string[] candidates = {
                Path.Combine(baseDir, "GameDll"),
                Path.Combine(baseDir, "..", "GameDll"),
                Path.Combine(baseDir, "..", "..", "GameDll"),
                Path.Combine(baseDir, "..", "..", "..", "GameDll"),
            };

            foreach (string dir in candidates)
            {
                string fullPath = Path.GetFullPath(dir);
                if (File.Exists(Path.Combine(fullPath, "GSE.ProtobufDB.dll")))
                {
                    try { Assembly.LoadFrom(Path.Combine(fullPath, "GSE.ProtobufDB.dll")); }
                    catch { }
                    break;
                }
            }

            BuildTypeCache();
        }

        private static readonly Dictionary<string, Type> _typeCache = new Dictionary<string, Type>();

        private static void BuildTypeCache()
        {
            int count = 0;
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                try { foreach (var t in asm.GetTypes()) { _typeCache[t.Name] = t; count++; } }
                catch { }
            }
            Log.Info($"[MagicMod] 类型缓存: {count} 个类型");
        }

        private static Type ResolveType(string typeName)
        {
            if (_typeCache.TryGetValue(typeName, out Type cached))
                return cached;

            string[] namespaces = { "ResB1", "BtlShare", "b1.Protobuf.DataAPI", "b1", "CommB1", "CsB1" };
            string[] assemblies = { "GSE.ProtobufDB", "Protobuf.RunTime", "b1.Managed" };

            foreach (string ns in namespaces)
                foreach (string asmName in assemblies)
                {
                    Type t = Type.GetType($"{ns}.{typeName}, {asmName}");
                    if (t != null) return t;
                }

            return null;
        }

        #endregion

        #region 工具方法

        public static string GetPBTableDir()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Common.ModDir, "MagicMod", "PBTable");
        }

        private static string ExtractTypeName(string fileName)
        {
            int dashIndex = fileName.IndexOf('-');
            return dashIndex > 0 ? fileName.Substring(0, dashIndex) : fileName;
        }

        #endregion
    }
}
