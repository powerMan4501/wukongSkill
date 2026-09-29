using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using b1;
using CSharpModBase;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace MagicMod
{
    /// <summary>
    /// 运行时直接播 DBC 表现（BGWDataAsset_B1DBC）。
    ///
    /// ===== 原理：这就是"给 BuffDispDesc 的 EnterFX 填 DBC 路径"走的那条路 =====
    ///   Buff 加上
    ///     → BUS_BuffDispComp.OnBuffAdd → BGW_GameDB.GetBuffDispDesc(宿主ResID, BuffID, 施法者ResID)
    ///     → PlayAddBuffDisp
    ///     → desc.IsUseDispConfig == Yes 时：PlayOneFXWithDispConfig(instance, fUStFXSetting.PSPath, ...)
    ///     → SpawnFXByDispConfig(DBCPath, Caster, ForceSyncLoad)
    ///     → BUSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(DBCPath, out RequestID, chr.Mesh, ...)
    ///     → BUS_DispLibDBCManageComp.RequestApplyOneDBCDataAssetByDAPath 解析这条 DBC 数据资产
    ///       （一个 DBC 可以同时装：Niagara 特效 / 音效 / 材质修改 / 震屏 / 生成 Actor ...，统一生命周期）
    ///   移除：Evt_RequestDestroyByFXRequestID(RequestID)
    ///
    /// 所以根本不用去改配表 —— 运行时直接发同一个事件即可，效果和"建一条 BuffDispDesc 挂 buff"完全一样。
    ///
    /// ===== JSON 用法 =====
    ///   { "Type": "SpawnDBC", "path": "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/DBC/XuliBaofa/DBC_XuLi_Baofa_2.DBC_XuLi_Baofa_2'" }
    ///   { "Type": "SpawnDBC", "path": "...", "Duration": 3000 }     // 3 秒后自动销毁
    ///   { "Type": "DBCStop" }                                        // 销毁本角色身上由 SpawnDBC 播出的全部 DBC
    ///   { "Type": "DumpBuffDisp", "Values": [249, 246, 2017] }       // 打印这些 BuffID 的 BuffDispDesc（找真正的棍光 DBC 路径）
    /// </summary>
    public static class DbcFx
    {
        // actorHash -> 该角色播出的 RequestID 列表
        private static readonly Dictionary<int, List<int>> _active = new Dictionary<int, List<int>>();
        private static readonly object _lock = new object();

        /// <summary>播一条 DBC。返回 RequestID（0 = 失败）。</summary>
        public static int Spawn(AActor owner, string dbcPath, bool forceSyncLoad = false, float durationMs = 0f)
        {
            if (owner == null || owner.IsNullOrDestroyed() || string.IsNullOrEmpty(dbcPath)) return 0;

            // 与游戏 BUS_BuffDispComp 一致：角色用 Mesh 作为"表现宿主组件"，DBC 里自带的 SocketName 会挂到它上面
            var chr = owner as BGUCharacterCS;
            USceneComponent? comp = null;
            if (chr != null && !chr.IsNullOrDestroyed()) comp = chr.Mesh;
            if (comp == null || comp.IsNullOrDestroyed()) comp = owner.RootComponent;

            int resID = 0;
            try { if (chr != null) resID = chr.GetResID(); } catch { }

            int requestId = 0;
            try
            {
                BUS_EventCollectionCS.Get(owner)
                    .Evt_RequestSpawnFXByDispConfig
                    .Invoke(dbcPath, out requestId, comp, false, default(FTransform), resID, forceSyncLoad);
            }
            catch (Exception e)
            {
                Log.Error($"[DBC] 播出失败 path={dbcPath}: {e.Message}");
                return 0;
            }

            if (requestId <= 0)
            {
                Log.Warn($"[DBC] RequestID=0，DBC 可能不存在或没被 DispLib 接收：{dbcPath}");
                return 0;
            }

            int key = owner.GetHashCode();
            lock (_lock)
            {
                if (!_active.TryGetValue(key, out var list)) { list = new List<int>(); _active[key] = list; }
                if (!list.Contains(requestId)) list.Add(requestId);
            }
            Log.Info($"[DBC] 已播出 RequestID={requestId} ← {dbcPath}");

            if (durationMs > 0)
            {
                // 走 TimerPool：触发完自动 Dispose 并从池中移除，
                // 否则这个 Timer 的闭包会一直 root 住 owner（AActor），UE GC 回收不掉
                TimerPool.Once((int)durationMs, () =>
                {
                    try { StopById(owner, requestId); } catch { }
                });
            }
            return requestId;
        }

        /// <summary>销毁指定 RequestID 的 DBC 表现。</summary>
        public static void StopById(AActor owner, int requestId)
        {
            if (owner == null || owner.IsNullOrDestroyed() || requestId <= 0) return;
            try
            {
                BUS_EventCollectionCS.Get(owner).Evt_RequestDestroyByFXRequestID.Invoke(requestId);
            }
            catch (Exception e)
            {
                Log.Warn($"[DBC] 销毁失败 RequestID={requestId}: {e.Message}");
                return;
            }
            int key = owner.GetHashCode();
            lock (_lock)
            {
                if (_active.TryGetValue(key, out var list))
                {
                    list.Remove(requestId);
                    if (list.Count == 0) _active.Remove(key);
                }
            }
            Log.Info($"[DBC] 已销毁 RequestID={requestId}");
        }

        /// <summary>销毁该角色身上由 SpawnDBC 播出的全部 DBC。</summary>
        public static void Stop(AActor owner)
        {
            if (owner == null || owner.IsNullOrDestroyed()) return;
            List<int> ids;
            int key = owner.GetHashCode();
            lock (_lock)
            {
                if (!_active.TryGetValue(key, out ids)) return;
                _active.Remove(key);
            }
            foreach (var id in ids) StopById(owner, id);
        }

        /// <summary>
        /// 打印指定 BuffID 的 BuffDispDesc（走 BGW_GameDB.GetBuffDispDesc，和游戏取表现的入口完全一致）。
        /// 用来找出"真正的棍光"用的是哪条 DBC / 哪个 Niagara / 哪个材质配置。
        /// </summary>
        public static void DumpBuffDisp(AActor owner, IEnumerable<int> buffIds)
        {
            if (owner == null || owner.IsNullOrDestroyed()) return;

            int resID = 0;
            var chr = owner as BGUCharacterCS;
            try { if (chr != null) resID = chr.GetResID(); } catch { }

            Log.Info($"[BuffDisp] ==== 探测开始（宿主ResID={resID}）====");
            foreach (int id in buffIds)
            {
                object? desc = null;
                string src = "";
                try
                {
                    desc = BGW_GameDB.GetBuffDispDesc(resID, id, resID);
                    if (desc != null) src = $"({resID},{id},{resID})";
                    if (desc == null) { desc = BGW_GameDB.GetBuffDispDesc(0, id, resID); if (desc != null) src = $"(0,{id},{resID})"; }
                    if (desc == null) { desc = BGW_GameDB.GetBuffDispDesc(resID, id, 0); if (desc != null) src = $"({resID},{id},0)"; }
                    if (desc == null) { desc = BGW_GameDB.GetBuffDispDesc(0, id, 0); if (desc != null) src = $"(0,{id},0)"; }
                }
                catch (Exception e)
                {
                    Log.Warn($"[BuffDisp] BuffID={id} 取表异常: {e.Message}");
                    continue;
                }

                if (desc == null)
                {
                    Log.Warn($"[BuffDisp] BuffID={id} → 没有 BuffDispDesc（不是【加 buff 播一次】的表现）");
                }
                else
                {
                    Log.Info($"[BuffDisp] BuffID={id} BuffDispDesc 命中映射 {src}");
                    DumpObject(desc, "  ");
                }

                // ★按层数叠加的表现（BuffLayerDisp）：层数每变一次播一条新 DBC —— "1层~4层越来越亮"就是它
                object? layerDesc = null;
                string lsrc = "";
                int[,] combos = { { resID, resID }, { 0, resID }, { resID, 0 }, { 0, 0 } };
                for (int c = 0; c < combos.GetLength(0); c++)
                {
                    int ownerId = combos[c, 0], casterId = combos[c, 1];
                    try
                    {
                        layerDesc = BGW_GameDB.GetBuffLayerDispDesc(ownerId, id, casterId);
                        if (layerDesc != null) { lsrc = $"({ownerId},{id},{casterId})"; break; }
                    }
                    catch { }
                }
                if (layerDesc == null)
                {
                    Log.Warn($"[BuffDisp] BuffID={id} → 也没有 BuffLayerDispDesc（不是按层数叠加的表现）");
                }
                else
                {
                    Log.Info($"[BuffDisp] ★BuffID={id} BuffLayerDispDesc 命中映射 {lsrc}（层数越多播的 DBC 越靠后=越亮）");
                    DumpObject(layerDesc, "  ");
                }
            }
            Log.Info("[BuffDisp] ==== 探测结束 ====");
        }

        /// <summary>
        /// 扫一段 BuffID，找出"表现配置里出现过关键字"的 buff。
        /// 例：{"Type":"ScanBuffDisp","Value":1,"Count":5000,"path":"XuLi"} → 所有用到 XuLi(蓄力) DBC 的 buff。
        /// 只打命中的，不匹配的不打。
        /// </summary>
        public static void ScanBuffDisp(AActor owner, int startId, int count, string keyword)
        {
            if (owner == null || owner.IsNullOrDestroyed()) return;
            if (count <= 0) count = 3000;
            int resID = 0;
            var chr = owner as BGUCharacterCS;
            try { if (chr != null) resID = chr.GetResID(); } catch { }

            bool hasKey = !string.IsNullOrEmpty(keyword);
            Log.Info($"[BuffScan] ==== 扫描 BuffID {startId}..{startId + count - 1}（关键字='{keyword}'）====");
            int hits = 0;

            for (int id = startId; id < startId + count; id++)
            {
                object? d1 = null, d2 = null;
                try
                {
                    d1 = BGW_GameDB.GetBuffDispDesc(resID, id, resID) ?? BGW_GameDB.GetBuffDispDesc(0, id, 0);
                    d2 = BGW_GameDB.GetBuffLayerDispDesc(resID, id, resID) ?? BGW_GameDB.GetBuffLayerDispDesc(0, id, 0);
                }
                catch { }
                if (d1 == null && d2 == null) continue;

                var lines = new List<string>();
                if (d1 != null) CollectStrings(d1, "Disp", lines);
                if (d2 != null) CollectStrings(d2, "Layer", lines);

                if (hasKey)
                {
                    bool matched = false;
                    foreach (var l in lines)
                    {
                        if (l.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) { matched = true; break; }
                    }
                    if (!matched) continue;
                }

                hits++;
                Log.Info($"[BuffScan] ★BuffID={id}{(d2 != null ? " [有层数表现]" : "")}");
                foreach (var l in lines) Log.Info($"[BuffScan]     {l}");
                if (hits >= 200) { Log.Info("[BuffScan] 命中过多，提前停止"); break; }
            }
            Log.Info($"[BuffScan] ==== 扫描结束，命中 {hits} 个 ====");
        }

        /// <summary>递归收集对象里所有字符串属性（路径/参数名），格式 "类型.属性 = 值"。</summary>
        private static void CollectStrings(object obj, string prefix, List<string> output)
        {
            if (obj == null) return;
            foreach (var p in obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (p.GetIndexParameters().Length > 0) continue;
                object? val;
                try { val = p.GetValue(obj); } catch { continue; }
                if (val == null) continue;

                if (val is string s)
                {
                    if (!string.IsNullOrEmpty(s)) output.Add($"{prefix}.{p.Name} = {s}");
                    continue;
                }
                if (val is IEnumerable en)
                {
                    int i = 0;
                    foreach (var item in en)
                    {
                        if (item == null) continue;
                        if (item is string si)
                        {
                            if (!string.IsNullOrEmpty(si)) output.Add($"{prefix}.{p.Name}[{i}] = {si}");
                        }
                        else if (!IsSimple(item))
                        {
                            CollectStrings(item, $"{prefix}.{p.Name}[{i}]", output);
                        }
                        i++;
                    }
                    continue;
                }
                if (!IsSimple(val)) CollectStrings(val, $"{prefix}.{p.Name}", output);
            }
        }

        // 反射打印（protobuf 生成的 FUSt* 类不在反编译源码里，用反射避免依赖具体类型）
        private static void DumpObject(object obj, string indent)
        {
            if (obj == null) return;
            var type = obj.GetType();
            foreach (var p in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (p.GetIndexParameters().Length > 0) continue;
                object? val;
                try { val = p.GetValue(obj); } catch { continue; }
                if (val == null) continue;

                if (val is string s)
                {
                    if (string.IsNullOrEmpty(s)) continue;
                    Log.Info($"{indent}{p.Name} = {s}");
                    continue;
                }
                if (val is IEnumerable en && !(val is string))
                {
                    int i = 0;
                    bool any = false;
                    foreach (var item in en)
                    {
                        if (item == null) continue;
                        if (IsSimple(item))
                        {
                            Log.Info($"{indent}{p.Name}[{i}] = {item}");
                        }
                        else
                        {
                            Log.Info($"{indent}{p.Name}[{i}]:");
                            DumpObject(item, indent + "    ");
                        }
                        any = true;
                        i++;
                    }
                    if (!any) continue;
                    continue;
                }
                if (IsSimple(val))
                {
                    Log.Info($"{indent}{p.Name} = {val}");
                }
            }
        }

        private static bool IsSimple(object o)
        {
            if (o == null) return true;
            var t = o.GetType();
            return t.IsPrimitive || t.IsEnum || o is string || o is decimal || o is float || o is double;
        }
    }
}
