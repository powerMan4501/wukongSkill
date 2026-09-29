#nullable disable
using System;
using System.Collections.Generic;
using b1;
using CSharpModBase;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace MagicMod
{
    /// <summary>单条表现（对应游戏 FUStFXSetting）。</summary>
    public class DispFxItem
    {
        /// <summary>
        /// 资源路径。两种写法：
        ///   1) DBC：BGWDataAsset_B1DBC'/Game/....DBC_Xxx.DBC_Xxx'  （走 DispLib，可打包 粒子+音效+材质+震屏）
        ///   2) Niagara / Cascade：/Game/....NG_Xxx.NG_Xxx          （直接挂到骨骼插槽上）
        /// 路径里含 "BGWDataAsset_B1DBC" 会自动判定为 DBC，也可用 dbc 字段强制。
        /// </summary>
        public string path = "";

        /// <summary>挂点骨骼 / 插槽名，默认 weapon_r（棍子）。DBC 走它自己的 SocketName，此项仅对 Niagara/Cascade 生效。</summary>
        public string attach = "weapon_r";

        public float scale = 1f;

        /// <summary>该特效自身持续毫秒；0 = 跟随整体 Duration。</summary>
        public int duration = 0;

        /// <summary>强制指定是否为 DBC（true/false），不填则按路径自动判断。</summary>
        public bool? dbc = null;

        /// <summary>棍光颜色 [r,g,b]（0~1，可 &gt;1 做 HDR 过曝）。广播到 Niagara 常见颜色变量。</summary>
        public float[] color = null;

        /// <summary>棍光强度 / 亮度（广播到 Niagara 常见强度变量）。</summary>
        public float? intensity = null;

        /// <summary>任意 Niagara 变量（优先级最高），如 [{"name":"User.ColorChannel","type":"int","value":[2]}]</summary>
        public List<FXVar> vars = null;

        /// <summary>非等比缩放 [x,y,z]：沿棍长拉长、横向压扁，让光铺满整根棍而不是糊在末端。优先于 scale。</summary>
        public float[] scale3 = null;

        /// <summary>火焰类特效：User.ColorChannel（int，颜色通道枚举）</summary>
        public int? channel = null;

        /// <summary>火焰类特效：User.FireScale（火焰大小；调小=贴身一层光）</summary>
        public float? fireScale = null;

        /// <summary>火焰类特效：User.ParticleCount（粒子密度）</summary>
        public int? count = null;

        /// <summary>调试：自动轮换 User.ColorChannel（填上限，如 4 → 0..3 每 1.5 秒切换），用来一次找出想要的颜色</summary>
        public int? scanChannel = null;
    }

    /// <summary>一次"表现"的完整配置（对应游戏 FUStBuffDispDesc 里我们真正用得到的部分）。</summary>
    public class BuffDispLiteConfig
    {
        /// <summary>进入表现：播出的特效 / DBC（可多条叠加）。</summary>
        public List<DispFxItem> EnterFX = new List<DispFxItem>();

        /// <summary>结束表现：Stop 时一次性播出的特效（可空）。</summary>
        public List<DispFxItem> LeaveFX = new List<DispFxItem>();

        /// <summary>
        /// 材质曲线配置资源路径数组（BGWDataAsset_BuffSetCurveValueToMeshConfig）。
        /// 这是游戏自己驱动"武器发光随时间变化"的通道，走 Evt_BeginForSetCurveValueToMesh，
        /// 能按 WeaponIndexList / WeaponMatIndexList 精确打到武器材质上。
        /// </summary>
        public List<string> MaterialSetting = new List<string>();

        /// <summary>传给材质曲线的总时长（秒），影响曲线采样速度。</summary>
        public float MaterialDuration = 1f;

        /// <summary>整体持续毫秒；0 = 常驻直到 DispFXStop / 下次 DispFX。</summary>
        public float Duration = 0f;
    }

    /// <summary>
    /// 自包含的"表现播放"，等价于游戏 BUS_BuffDispComp 的 PlayAddBuffDisp / TriggerRemoveBuffDisp，
    /// 但完全由我们的 JSON 驱动，不查 BuffDispDesc 表、不依赖任何 buff。
    ///
    /// 复刻的三条通路（与 BUS_BuffDispComp 一一对应）：
    ///   1) EnterFX 里的 DBC        → Evt_RequestSpawnFXByDispConfig      （= PlayOneFXWithDispConfig）
    ///   2) EnterFX 里的 Niagara/Cascade → SpawnSystemAttached 挂骨骼插槽   （= PlayOneFX）
    ///   3) MaterialSetting         → Evt_BeginForSetCurveValueToMesh     （= 材质随时间/曲线发光）
    ///   结束时：LeaveFX + Evt_RequestDestroyByFXRequestID + Evt_OverForSetCurveValueToMesh
    ///
    /// ===== JSON 用法 =====
    ///   // 棍光：一条 DBC 挂上 + 一个材质曲线打武器
    ///   { "Type": "DispFX",
    ///     "FXList": [ { "path": "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/DBC/XuliBaofa/DBC_XuLi_Baofa_2.DBC_XuLi_Baofa_2'" } ],
    ///     "MatSetting": [ "BGWDataAsset_BuffSetCurveValueToMeshConfig'/Game/....DA_Xxx.DA_Xxx'" ],
    ///     "Duration": 3000 }
    ///
    ///   // 纯 Niagara 挂棍子（不走 DBC）
    ///   { "Type": "DispFX",
    ///     "FXList": [ { "path": "/Game/.../NG_Equip_Weapon_Yehuo_Fire_Loop.NG_Equip_Weapon_Yehuo_Fire_Loop",
    ///                   "attach": "weapon_r", "scale": 1.2 } ] }
    ///
    ///   { "Type": "DispFXStop" }   // 立即结束（播 LeaveFX 并还原材质）
    /// </summary>
    public static class BuffDispLite
    {
        private class Session
        {
            public AActor Owner;
            public List<int> DbcIds = new List<int>();
            public List<string> Bones = new List<string>();
            public List<int> MatInstIds = new List<int>();
            public bool MatNeedRecovery = true;
            public BuffDispLiteConfig Cfg;
            public System.Threading.Timer Timer;
        }

        private static readonly Dictionary<int, Session> _sessions = new Dictionary<int, Session>();
        private static readonly object _lock = new object();
        // 与游戏一致：材质通知用负数 ID，避免和其它系统的通知 ID 冲突
        private static int _matIdSeq = -1000;

        /// <summary>播一次表现。同一角色重复调用会先结束上一次。</summary>
        public static bool Play(AActor owner, BuffDispLiteConfig cfg)
        {
            if (owner == null || owner.IsNullOrDestroyed() || cfg == null) return false;

            Stop(owner);
            // 顺带清掉已经失效（单位已销毁）的历史 Session，避免它们一直 root 着 AActor
            PurgeDeadSessions();

            var s = new Session { Owner = owner, Cfg = cfg };
            int ok = 0;

            // ---- 1) EnterFX ----
            if (cfg.EnterFX != null)
            {
                foreach (var it in cfg.EnterFX)
                {
                    if (it == null || string.IsNullOrEmpty(it.path)) continue;
                    bool isDbc = it.dbc ?? it.path.IndexOf("BGWDataAsset_B1DBC", StringComparison.OrdinalIgnoreCase) >= 0;

                    if (isDbc)
                    {
                        int id = DbcFx.Spawn(owner, it.path);
                        if (id > 0) { s.DbcIds.Add(id); ok++; }
                    }
                    else
                    {
                        var chr = owner as BGUCharacterCS;
                        if (chr == null) { Log.Warn("[DispFX] 非角色单位，无法挂骨骼特效"); continue; }
                        string bone = string.IsNullOrEmpty(it.attach) ? "weapon_r" : it.attach;

                        // 走 BoneGlow 的完整参数版，才能把颜色 / 强度 / 任意 Niagara 变量传进去
                        var fx = new FXItem
                        {
                            path = it.path,
                            scale = it.scale <= 0 ? 1f : it.scale,
                            duration = it.duration,
                            color = it.color,
                            intensity = it.intensity,
                            vars = it.vars,
                            scale3 = it.scale3,
                            channel = it.channel,
                            fireScale = it.fireScale,
                            count = it.count,
                            scanChannel = it.scanChannel,
                        };
                        float dur = it.duration > 0 ? it.duration : (cfg.Duration > 0 ? cfg.Duration : -1f);
                        if (BoneGlow.Start(chr, bone, new List<FXItem> { fx }, dur, null, null, strict: true))
                        {
                            if (!s.Bones.Contains(bone)) s.Bones.Add(bone);
                            ok++;
                        }
                    }
                }
            }

            // ---- 2) MaterialSetting：游戏自己的"材质随时间变化"通道 ----
            if (cfg.MaterialSetting != null)
            {
                foreach (var p in cfg.MaterialSetting)
                {
                    if (string.IsNullOrEmpty(p)) continue;
                    int instId = BeginMaterialCurve(owner, p, cfg.MaterialDuration);
                    if (instId != 0) { s.MatInstIds.Add(instId); ok++; }
                }
            }

            if (ok == 0)
            {
                Log.Warn("[DispFX] 没有任何表现生效（检查 path / MatSetting 路径）");
                return false;
            }

            lock (_lock) _sessions[owner.GetHashCode()] = s;
            Log.Info($"[DispFX] 已播表现：DBC×{s.DbcIds.Count} 骨骼特效×{s.Bones.Count} 材质曲线×{s.MatInstIds.Count}");

            if (cfg.Duration > 0)
            {
                s.Timer = new System.Threading.Timer(_ =>
                {
                    try { Utils.TryRunOnGameThread(() => Stop(owner)); } catch { }
                }, null, (int)cfg.Duration, System.Threading.Timeout.Infinite);
            }
            return true;
        }

        /// <summary>
        /// 清掉"宿主单位已经销毁"的 Session。
        /// Session 直接持有 AActor，只要留在字典里这个 UObject 就永远回收不掉；
        /// 单位死亡 / 过场打断 / 切场景时收不到动画结束回调，就会永久残留。
        /// </summary>
        private static void PurgeDeadSessions()
        {
            List<Session>? dead = null;
            lock (_lock)
            {
                foreach (var kv in _sessions)
                {
                    var s = kv.Value;
                    if (s?.Owner == null || s.Owner.IsNullOrDestroyed())
                        (dead ??= new List<Session>()).Add(s);
                }
                if (dead != null)
                {
                    foreach (var s in dead) _sessions.Remove(s.Owner.GetHashCode());
                }
            }
            if (dead == null) return;

            foreach (var s in dead)
            {
                try { s.Timer?.Dispose(); } catch { }
            }
        }

        /// <summary>结束全部表现（Mod 卸载 / 热重载时调用，避免 Session 残留 root 住 AActor）。</summary>
        public static void StopAll()
        {
            List<Session> snapshot;
            lock (_lock)
            {
                snapshot = new List<Session>(_sessions.Values);
                _sessions.Clear();
            }
            foreach (var s in snapshot)
            {
                try { s.Timer?.Dispose(); } catch { }
                var owner = s?.Owner;
                if (owner == null || owner.IsNullOrDestroyed()) continue;
                // 复用 Stop 的收尾逻辑（销毁 DBC / 骨骼特效 / 还原材质），但不再重复播 LeaveFX
                try
                {
                    foreach (var id in s.DbcIds) DbcFx.StopById(owner, id);
                    if (owner is BGUCharacterCS chr)
                    {
                        foreach (var b in s.Bones) BoneGlow.Stop(chr, b);
                    }
                    foreach (var id in s.MatInstIds) EndMaterialCurve(owner, id, s.MatNeedRecovery);
                }
                catch (Exception e)
                {
                    Log.Warn($"[DispFX] 清理表现失败: {e.Message}");
                }
            }
            Log.Info($"[DispFX] 已清理全部表现（{snapshot.Count} 个）");
        }

        /// <summary>结束表现：播 LeaveFX、销毁特效、还原材质。</summary>
        public static void Stop(AActor owner)
        {
            if (owner == null || owner.IsNullOrDestroyed()) return;
            Session s;
            lock (_lock)
            {
                if (!_sessions.TryGetValue(owner.GetHashCode(), out s)) return;
                _sessions.Remove(owner.GetHashCode());
            }
            try { s.Timer?.Dispose(); } catch { }

            // 1) LeaveFX（一次性，播完就不管）
            if (s.Cfg?.LeaveFX != null)
            {
                foreach (var it in s.Cfg.LeaveFX)
                {
                    if (it == null || string.IsNullOrEmpty(it.path)) continue;
                    bool isDbc = it.dbc ?? it.path.IndexOf("BGWDataAsset_B1DBC", StringComparison.OrdinalIgnoreCase) >= 0;
                    if (isDbc) DbcFx.Spawn(owner, it.path, false, it.duration > 0 ? it.duration : 0f);
                    else
                    {
                        var chr = owner as BGUCharacterCS;
                        if (chr != null)
                            BoneGlow.Start(chr, string.IsNullOrEmpty(it.attach) ? "weapon_r" : it.attach,
                                it.path, it.duration > 0 ? it.duration : 2000f, it.scale <= 0 ? 1f : it.scale);
                    }
                }
            }

            // 2) 销毁 DBC
            foreach (var id in s.DbcIds) DbcFx.StopById(owner, id);

            // 3) 销毁骨骼特效
            var chr2 = owner as BGUCharacterCS;
            if (chr2 != null)
            {
                foreach (var b in s.Bones) BoneGlow.Stop(chr2, b);
            }

            // 4) 还原材质
            foreach (var id in s.MatInstIds) EndMaterialCurve(owner, id, s.MatNeedRecovery);

            Log.Info("[DispFX] 表现已结束");
        }

        // ===== 材质曲线通道（= BUS_BuffDispComp 的 MaterialSetting）=====

        private static int BeginMaterialCurve(AActor owner, string path, float duration)
        {
            try
            {
                var asset = ActionExecutor.LoadAsset<BGWDataAsset_BuffSetCurveValueToMeshConfig>(path);
                if (asset == null || asset.IsNullOrDestroyed())
                {
                    Log.Warn($"[DispFX] 材质曲线资源加载失败: {path}");
                    return 0;
                }
                int instId = --_matIdSeq;
                BUS_EventCollectionCS.Get(owner).Evt_BeginForSetCurveValueToMesh.Invoke(
                    instId,
                    asset.FloatCurveParamList,
                    asset.LinearColorCurveParamList,
                    asset.NotApplyToChrMesh,
                    asset.MatIndexList,
                    asset.BothWeapons,
                    asset.WeaponIndexList,
                    asset.WeaponMatIndexList,
                    asset.BothChildMeshes,
                    asset.ChildMeshTagList,
                    asset.ChildMeshMatIndexList,
                    asset.BothChildActor,
                    asset.ChildActorMeshMatIndexList,
                    duration,
                    asset.bFitRealTime);

                BUS_EventCollectionCS.Get(owner).Evt_BeginForSetCurveValueToHair.Invoke(
                    instId, asset.HairType, asset.HairCompTagList, asset.HairFloatCurveParamList, duration);

                Log.Info($"[DispFX] 材质曲线已下发 id={instId} ← {path}");
                return instId;
            }
            catch (Exception e)
            {
                Log.Error($"[DispFX] 材质曲线下发失败 {path}: {e.Message}");
                return 0;
            }
        }

        private static void EndMaterialCurve(AActor owner, int instId, bool needRecovery)
        {
            try
            {
                BUS_EventCollectionCS.Get(owner).Evt_OverForSetCurveValueToMesh.Invoke(instId, needRecovery);
                BUS_EventCollectionCS.Get(owner).Evt_OverForSetCurveValueToHair.Invoke(instId, needRecovery);
            }
            catch (Exception e)
            {
                Log.Warn($"[DispFX] 材质还原失败 id={instId}: {e.Message}");
            }
        }
    }
}
