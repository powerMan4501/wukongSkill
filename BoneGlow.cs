using System;
using System.Collections.Generic;
using b1;
using b1.BGW;
using CSharpModBase;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace MagicMod
{
    /// <summary>
    /// 指定骨骼 / 插槽发光（或挂任意 Niagara / Cascade 特效）封装。
    /// 支持在一个骨骼上叠加多个发光特效（"棍光组合"），并可完全通过参数配置。
    ///
    /// JSON 用法：
    ///   1) 默认棍光组合（武器自动挂多种光，不再单调）：
    ///        { "Type": "BoneGlow", "BoneName": "weapon_r" }
    ///   2) 预设组合（fire / gold / rich）：
    ///        { "Type": "BoneGlow", "BoneName": "weapon_r", "FXPreset": "rich" }
    ///   3) 自定义多棍光（完全参数化，数组里每一项都是一个发光特效）：
    ///        {
    ///          "Type": "BoneGlow", "BoneName": "weapon_r",
    ///          "FXList": [
    ///            { "path": "/Game/.../NG_xxx.NG_xxx", "scale": 1.0, "offset": [0,0,10], "rotation": [0,0,0], "duration": 0 },
    ///            { "path": "/Game/.../NG_yyy.NG_yyy", "scale": 0.6 }
    ///          ]
    ///        }
    ///   4) 兼容旧的单特效写法：
    ///        { "Type": "BoneGlow", "BoneName": "hand_l", "path": "...", "FXScale": 1.5, "Duration": 5000 }
    ///   5) 关闭：{ "Type": "BoneGlowStop", "BoneName": "weapon_r" }
    ///
    /// FXItem 字段：
    ///   path      —— 资源路径（"/Game/.../NG_xxx.NG_xxx"）；为空则按骨骼挑默认发光
    ///   scale     —— 缩放，默认 1
    ///   offset    —— 位置偏移 [x,y,z]（相对骨骼，厘米），默认 [0,0,0]
    ///   rotation  —— 旋转 [pitch,yaw,roll]（度），默认 [0,0,0]
    ///   duration  —— 该特效持续毫秒；0 或省略则继承动作的 Duration（默认永久）
    /// </summary>
    public static class BoneGlow
    {
        // 已确认存在于游戏包内的玩家发光 Niagara（FModel 导出后缀 _16777215 是导出 ID，真实对象名需去掉）
        private const string GOLD = "/Game/00Main/VFX/Characters/sunwukong/Niagara/Buff/Attack/NG_WuKong_Buff_Attack_Start.NG_WuKong_Buff_Attack_Start";
        private const string LANGYA_GP = "/Game/00Main/VFX/Characters/sunwukong/Niagara/Equip/Langyagun02/Niagara/NG_wukong_langyagun02_gp.NG_wukong_langyagun02_gp";
        private const string YEHUO_FIRE = "/Game/00Main/VFX/Characters/sunwukong/Niagara/Equip/Yehuo/NG_Equip_Weapon_Yehuo_Fire_Loop.NG_Equip_Weapon_Yehuo_Fire_Loop";

        // key = "<actorHashCode>|<boneName小写>"
        private static readonly Dictionary<string, List<UFXSystemComponent>> _active = new Dictionary<string, List<UFXSystemComponent>>();
        private static readonly object _lock = new object();
        // 周期性定时器（ColorChannel 扫描）的句柄，停止时显式 Stop
        private static readonly List<TimerPool.TimerHandle> _scanHandles = new List<TimerPool.TimerHandle>();

        private static string Key(AActor a, string bone) => $"{a.GetHashCode()}|{(bone ?? "").ToLowerInvariant()}";

        // ===== 对外入口 =====

        /// <summary>在指定骨骼上挂默认/预设/单特效发光（兼容旧写法）。</summary>
        public static bool Start(BGUCharacterCS chr, string boneName, string fxPath = "", float durationMs = -1f, float scale = 1f)
        {
            boneName = string.IsNullOrEmpty(boneName) ? "weapon_r" : boneName;
            // 武器骨骼未指定 path 时，直接给"棍光组合"，开箱即多光不单调
            if (string.IsNullOrEmpty(fxPath) && boneName.Contains("weapon"))
            {
                return StartPreset(chr, boneName, "rich", durationMs);
            }
            var item = new FXItem { path = fxPath, scale = scale, duration = (int)durationMs };
            return Start(chr, boneName, new List<FXItem> { item }, durationMs);
        }

        /// <summary>在指定骨骼上按 FXList 叠加多个发光特效。</summary>
        public static bool Start(BGUCharacterCS chr, string boneName, List<FXItem> items, float defaultDurationMs = -1f,
            float[] defaultColor = null, float? defaultIntensity = null, bool strict = false)
        {
            if (chr == null || chr.IsNullOrDestroyed()) return false;
            boneName = string.IsNullOrEmpty(boneName) ? "weapon_r" : boneName;
            if (items == null || items.Count == 0) return false;

            // 同骨骼先清掉旧的，避免重复触发越叠越亮
            Stop(chr, boneName);

            // 解析挂载组件与挂点
            FName attachPoint;
            USceneComponent ownerComp = ResolveAttachComponent(chr, boneName, out attachPoint);
            if (ownerComp == null || ownerComp.IsNullOrDestroyed())
            {
                Log.Warn($"[BoneGlow] 找不到挂载组件，骨骼={boneName}");
                return false;
            }
            int okCount = 0;
            foreach (var it in items)
            {
                if (it == null) continue;
                bool isNiagara;
                UObject fxObj = ResolveFX(boneName, it.path, out isNiagara, strict);
                if (fxObj == null) continue;

                float scale = it.scale ?? 1f;
                FVector loc = ToVec(it.offset);
                FRotator rot = ToRot(it.rotation);

                UFXSystemComponent comp = null;
                if (isNiagara)
                {
                    comp = UNiagaraFunctionLibrary.SpawnSystemAttached(
                        fxObj as UNiagaraSystem, ownerComp, attachPoint,
                        loc, rot, EAttachLocation.SnapToTarget, bAutoDestroy: false);
                }
                else
                {
                    comp = UGameplayStatics.SpawnEmitterAttached(
                        fxObj as UParticleSystem, ownerComp, attachPoint,
                        loc, rot, new FVector(scale), EAttachLocation.SnapToTarget,
                        bAutoDestroy: false, EPSCPoolMethod.None, bAutoActivate: true);
                }
                if (comp == null || comp.IsNullOrDestroyed()) continue;
                if (isNiagara)
                {
                    // scale3 优先：非等比缩放（沿棍长拉长/压扁，用来让光铺满整根棍而不是只糊在末端）
                    if (it.scale3 != null && it.scale3.Length >= 3)
                        comp.SetWorldScale3D(new FVector(it.scale3[0], it.scale3[1], it.scale3[2]));
                    else if (scale != 1f)
                        comp.SetWorldScale3D(new FVector(scale));
                }

                // 自定义：给 Niagara 组件设颜色/强度变量（把现成特效染成想要的颜色，如金色火焰/金光）
                if (comp is UNiagaraComponent nc)
                {
                    var colArr = (it.color != null && it.color.Length >= 3) ? it.color : defaultColor;
                    var inten = it.intensity ?? defaultIntensity;
                    ApplyNiagaraVars(nc, it, colArr, inten);
                }

                RegisterComp(chr, boneName, comp);
                float dur = it.duration ?? (int)defaultDurationMs;
                if (dur > 0) ScheduleStop(chr, boneName, comp, dur);
                okCount++;
            }

            if (okCount == 0)
            {
                Log.Warn($"[BoneGlow] 骨骼 {boneName} 的所有发光特效均加载失败（检查 path 是否正确）");
                return false;
            }
            Log.Info($"[BoneGlow] 骨骼 {boneName} 挂上 {items.Count} 个发光配置，生效 {okCount} 个");
            return true;
        }

        /// <summary>用内置预设组合挂发光。preset: rich(默认多光) / fire(火+金) / gold(金)。</summary>
        public static bool StartPreset(BGUCharacterCS chr, string boneName, string preset, float defaultDurationMs = -1f)
        {
            return Start(chr, boneName, PresetItems(preset), defaultDurationMs);
        }

        /// <summary>关闭指定骨骼上的全部发光特效</summary>
        public static void Stop(BGUCharacterCS chr, string boneName)
        {
            if (chr == null) return;
            var k = Key(chr, boneName);
            List<UFXSystemComponent> list;
            lock (_lock)
            {
                if (!_active.TryGetValue(k, out list)) return;
                _active.Remove(k);
            }
            foreach (var c in list) DestroyComp(c);
        }

        /// <summary>关闭发光。chr 为 null 时关闭所有角色的所有骨骼发光</summary>
        public static void StopAll(BGUCharacterCS chr = null)
        {
            lock (_lock)
            {
                var prefix = chr != null ? (chr.GetHashCode() + "|") : null;
                var toClear = new List<string>();
                foreach (var kv in _active)
                {
                    if (prefix == null || kv.Key.StartsWith(prefix)) toClear.Add(kv.Key);
                }
                foreach (var k in toClear)
                {
                    if (_active.TryGetValue(k, out var list))
                    {
                        foreach (var c in list) DestroyComp(c);
                    }
                    _active.Remove(k);
                }
            }
        }

        // ===== 内部实现 =====

        /// <summary>
        /// 解析"该挂到哪个组件、哪个插槽"。
        ///
        /// 关键坑：玩家由多个 bodypart_* 部件组成，武器骨骼（weapon_r / weapon_r_index_01..06）
        /// 在【武器 Mesh 组件】（bodypart_weapon，骨架 SK_Wukong_DaSheng）上，
        /// 而 chr.Mesh（角色主网格）上的 weapon_r 往往取不到；一旦取不到插槽，
        /// SpawnSystemAttached 会退回组件原点 —— 表现就是"火焰裹在身体上"。
        /// 所以武器类骨骼要优先解析到武器 Mesh 组件，并在没插槽时退化到"整块武器网格挂载"而不是角色中心。
        /// </summary>
        private static USceneComponent ResolveAttachComponent(BGUCharacterCS chr, string boneName, out FName attachPoint)
        {
            attachPoint = new FName(boneName);

            bool weaponBone = !string.IsNullOrEmpty(boneName) &&
                              (boneName.IndexOf("weapon", StringComparison.OrdinalIgnoreCase) >= 0 ||
                               boneName.IndexOf("gun", StringComparison.OrdinalIgnoreCase) >= 0);

            if (weaponBone)
            {
                var wc = FindWeaponMesh(chr);
                if (wc != null && !wc.IsNullOrDestroyed())
                {
                    bool has = SocketExists(wc, boneName);
                    if (has)
                    {
                        Log.Info($"[BoneGlow] 挂载点：武器组件 '{wc.GetName()}' 的插槽 '{boneName}'");
                    }
                    else
                    {
                        attachPoint = FName.None;   // 挂到整块武器网格，避免退到角色中心
                        Log.Info($"[BoneGlow] 武器组件 '{wc.GetName()}' 上没有插槽 '{boneName}'，改为整块武器网格挂载（光会铺满整根棍）");
                    }
                    return wc;
                }
            }

            // 非武器骨骼 / 找不到武器组件：按游戏自己的方式解析
            USceneComponent ownerComp = chr.Mesh;
            BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, chr, new FName(boneName), out var socketComp);
            if (socketComp != null && !socketComp.IsNullOrDestroyed()) ownerComp = socketComp;
            Log.Info($"[BoneGlow] 挂载点：'{ownerComp?.GetName()}' 的插槽 '{boneName}'");
            return ownerComp;
        }

        /// <summary>找玩家的武器 Mesh 组件：先走武器管理器，再按名字含 weapon 兜底。</summary>
        private static USkeletalMeshComponent FindWeaponMesh(BGUCharacterCS chr)
        {
            // 1) 武器管理器（最准）
            try
            {
                var wm = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_WeaponManagerData, BUC_WeaponManagerData>(chr);
                if (wm != null)
                {
                    int n = wm.GetWeaponNum();
                    for (int i = 0; i < n; i++)
                    {
                        var w = wm.FindWeaponByIndex(i);
                        if (w == null || w.IsNullOrDestroyed()) continue;
                        var mc = w.GetComponentByClass<USkeletalMeshComponent>();
                        if (mc != null && !mc.IsNullOrDestroyed()) return mc;
                    }
                }
            }
            catch { }

            // 2) 名字含 weapon 的 SkeletalMesh 组件（含子 Actor）
            try
            {
                var all = new List<USkeletalMeshComponent>();
                CollectSkeletal(chr, all);
                foreach (var c in all)
                {
                    var nm = c.GetName() ?? "";
                    if (nm.IndexOf("weapon", StringComparison.OrdinalIgnoreCase) >= 0) return c;
                }
                if (all.Count > 0) return all[0];
            }
            catch { }
            return null;
        }

        private static void CollectSkeletal(AActor actor, List<USkeletalMeshComponent> outList)
        {
            if (actor == null || actor.IsNullOrDestroyed()) return;
            var comps = actor.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>());
            if (comps != null)
            {
                foreach (var c in comps)
                {
                    if (c is USkeletalMeshComponent m && !m.IsNullOrDestroyed() && !outList.Contains(m)) outList.Add(m);
                }
            }
            try
            {
                actor.GetAllChildActors(out var children);
                if (children != null)
                {
                    foreach (var ch in children)
                    {
                        if (ch != null && !ch.IsNullOrDestroyed()) CollectSkeletal(ch, outList);
                    }
                }
            }
            catch { }
        }

        private static bool SocketExists(UMeshComponent mesh, string socketName)
        {
            try
            {
                var names = mesh.GetAllSocketNames();
                if (names == null || string.IsNullOrEmpty(socketName)) return false;
                foreach (var s in names)
                {
                    if (string.Equals(s.ToString(), socketName, StringComparison.OrdinalIgnoreCase)) return true;
                }
            }
            catch { }
            return false;
        }

        private static void RegisterComp(AActor chr, string bone, UFXSystemComponent c)
        {
            lock (_lock)
            {
                var k = Key(chr, bone);
                if (!_active.TryGetValue(k, out var list))
                {
                    list = new List<UFXSystemComponent>();
                    _active[k] = list;
                }
                list.Add(c);
            }
        }

        private static void ScheduleStop(AActor chr, string bone, UFXSystemComponent c, float ms)
        {
            var ak = Key(chr, bone);
            // 走 TimerPool：触发完自动 Dispose 并移出池。
            // 以前这些 Timer 一直挂在静态列表里，闭包捕获的特效组件被永久 root，UE GC 回收不掉
            TimerPool.Once((int)ms, () =>
            {
                // StopOne → DestroyComp 会销毁 UObject，必须投递到游戏线程
                RunOnGameThreadSafe(() => { try { StopOne(ak, c); } catch { } });
            });
        }

        /// <summary>
        /// 把 UObject 相关操作投递到游戏线程（异步，不阻塞 Timer 线程）。
        /// Timer 回调跑在线程池线程，直接销毁组件 / 设置 Niagara 变量属于跨线程操作 UObject。
        /// </summary>
        private static void RunOnGameThreadSafe(FSimpleDelegate action)
        {
            try { FThreading.RunOnGameThreadAsync(action); }
            catch { }
        }

        /// <summary>Mod 卸载时调用：停掉所有扫描定时器，避免重载后定时器残留并跨线程操作 UObject。</summary>
        public static void ClearTimers()
        {
            lock (_lock)
            {
                foreach (var h in _scanHandles) TimerPool.Stop(h);
                _scanHandles.Clear();
            }
        }

        private static void StopOne(string key, UFXSystemComponent c)
        {
            lock (_lock)
            {
                if (_active.TryGetValue(key, out var list))
                {
                    list.Remove(c);
                    if (list.Count == 0) _active.Remove(key);
                }
            }
            DestroyComp(c);
        }

        private static void DestroyComp(UFXSystemComponent c)
        {
            if (c == null || c.IsNullOrDestroyed()) return;
            try
            {
                c.Deactivate();
                c.DestroyComponent(c);
            }
            catch (Exception e)
            {
                Log.Warn($"[BoneGlow] 销毁特效组件失败: {e.Message}");
            }
        }

        // Niagara 常用颜色变量名（黑神话多为 User. 前缀），广播设置，存在的才会生效
        private static readonly string[] NiagaraColorVars =
        {
            "User.Color", "Color", "User.EmissiveColor", "EmissiveColor",
            "User.Tint", "Tint", "User.ParticleColor", "ParticleColor", "BaseColor"
        };

        // Niagara 常用强度/亮度变量名
        private static readonly string[] NiagaraIntensityVars =
        {
            "User.Intensity", "Intensity", "User.EmissiveIntensity", "EmissiveIntensity",
            "User.Brightness", "Brightness", "User.Power", "Power"
        };

        /// <summary>给 Niagara 组件设置自定义变量（颜色/强度/通道/火焰大小/密度/任意变量）</summary>
        private static void ApplyNiagaraVars(UNiagaraComponent nc, FXItem it, float[] colorArr, float? intensity)
        {
            bool hasColor = colorArr != null && colorArr.Length >= 3;

            if (hasColor)
            {
                var col = new FLinearColor(colorArr[0], colorArr[1], colorArr[2], 1f);
                foreach (var v in NiagaraColorVars)
                {
                    try { nc.SetVariableLinearColor(new FName(v), col); } catch { }
                    try { nc.SetNiagaraVariableLinearColor(v, col); } catch { }
                }
            }
            if (intensity.HasValue)
            {
                foreach (var v in NiagaraIntensityVars)
                {
                    try { nc.SetVariableFloat(new FName(v), intensity.Value); } catch { }
                    try { nc.SetNiagaraVariableFloat(v, intensity.Value); } catch { }
                }
            }

            // 武器火焰类特效的真实参数（来自 NG_Equip_Weapon_Yehuo_Fire_Loop 导出的 User 变量）
            if (it != null)
            {
                if (it.channel.HasValue) SetNiagaraInt(nc, "User.ColorChannel", it.channel.Value);
                if (it.fireScale.HasValue) SetNiagaraFloat(nc, "User.FireScale", it.fireScale.Value);
                if (it.count.HasValue) SetNiagaraInt(nc, "User.ParticleCount", it.count.Value);

                if (it.vars != null)
                {
                    foreach (var v in it.vars)
                    {
                        if (v == null || string.IsNullOrEmpty(v.name) || v.value == null || v.value.Length == 0) continue;
                        string t = (v.type ?? "float").ToLowerInvariant();
                        if (t == "int") SetNiagaraInt(nc, v.name, (int)v.value[0]);
                        else if (t == "bool") SetNiagaraBool(nc, v.name, v.value[0] != 0f);
                        else if (t == "color")
                        {
                            var c = new FLinearColor(v.value[0], v.value.Length > 1 ? v.value[1] : 0f,
                                v.value.Length > 2 ? v.value[2] : 0f, v.value.Length > 3 ? v.value[3] : 1f);
                            nc.SetVariableLinearColor(new FName(v.name), c);
                            nc.SetNiagaraVariableLinearColor(v.name, c);
                        }
                        else SetNiagaraFloat(nc, v.name, v.value[0]);
                    }
                }

                // 调试：自动轮换颜色通道，一次找出想要的颜色
                if (it.scanChannel.HasValue && it.scanChannel.Value > 1)
                {
                    int max = it.scanChannel.Value;
                    int idx = 0;
                    // 周期性任务：句柄存起来，扫满一轮自动停，ClearTimers 也会停
                    // （不能像以前那样丢进只增不减的列表里一直跑，闭包会永久 root 住这个 Niagara 组件）
                    TimerPool.TimerHandle handle = null;
                    handle = TimerPool.Repeat(1500, () =>
                    {
                        // SetNiagaraInt 是 UObject 操作，投递到游戏线程
                        RunOnGameThreadSafe(() =>
                        {
                            try
                            {
                                int ch = idx++ % max;
                                SetNiagaraInt(nc, "User.ColorChannel", ch);
                                Log.Info($"[BoneGlow] 扫描 ColorChannel = {ch}（看到想要的颜色时记住这个值）");
                            }
                            catch { }
                        });

                        if (idx >= max) TimerPool.Stop(handle);
                    });
                    lock (_lock) _scanHandles.Add(handle);
                    Log.Info($"[BoneGlow] 已启动 ColorChannel 扫描（0..{max - 1}，每1.5秒切换，扫完一轮自动停）");
                }
            }

            Log.Info($"[BoneGlow] Niagara自定义: 颜色={(hasColor ? $"({colorArr[0]},{colorArr[1]},{colorArr[2]})" : "无")} 强度={(intensity.HasValue ? intensity.Value.ToString() : "无")}" +
                (it != null && it.channel.HasValue ? $" 通道={it.channel.Value}" : ""));
        }

        private static void SetNiagaraInt(UNiagaraComponent nc, string name, int v)
        {
            try { nc.SetVariableInt(new FName(name), v); } catch { }
            try { nc.SetNiagaraVariableInt(name, v); } catch { }
        }

        private static void SetNiagaraFloat(UNiagaraComponent nc, string name, float v)
        {
            try { nc.SetVariableFloat(new FName(name), v); } catch { }
            try { nc.SetNiagaraVariableFloat(name, v); } catch { }
        }

        private static void SetNiagaraBool(UNiagaraComponent nc, string name, bool v)
        {
            try { nc.SetVariableBool(new FName(name), v); } catch { }
            try { nc.SetNiagaraVariableBool(name, v); } catch { }
        }

        private static FVector ToVec(float[] a)
        {
            if (a == null || a.Length < 3) return FVector.ZeroVector;
            return new FVector(a[0], a[1], a[2]);
        }

        private static FRotator ToRot(float[] a)
        {
            if (a == null || a.Length < 3) return FRotator.ZeroRotator;
            return new FRotator(a[0], a[1], a[2]);
        }

        /// <summary>
        /// 解析资源：先用户 path，再骨骼默认候选；先 Niagara 后 Cascade。
        /// strict=true 时：用户填了 path 但加载失败 → 直接失败，绝不悄悄回退到默认光效
        /// （曾经因为这个静默兜底，武器骨骼回退到业火火焰，导致"填啥路径都是火"）。
        /// </summary>
        private static UObject ResolveFX(string boneName, string userPath, out bool isNiagara, bool strict = false)
        {
            isNiagara = false;
            var candidates = new List<string>();
            bool hasUserPath = !string.IsNullOrEmpty(userPath);
            if (hasUserPath) candidates.Add(userPath);
            candidates.AddRange(DefaultCandidates(boneName));

            int tried = 0;
            foreach (var c in candidates)
            {
                var n = ActionExecutor.LoadAsset<UNiagaraSystem>(c);
                tried++;
                if (n != null && !n.IsNullOrDestroyed())
                {
                    isNiagara = true;
                    if (hasUserPath && tried > 1)
                        Log.Warn($"[BoneGlow] 你填的 Niagara 加载失败，已回退到默认光效 '{c}'（原路径：{userPath}）");
                    else
                        Log.Info($"[BoneGlow] 使用 Niagara: {c}");
                    return n;
                }
                if (strict && hasUserPath && tried == 1)
                {
                    Log.Warn($"[BoneGlow] 指定路径加载失败（strict 模式，不回退默认）: {userPath}");
                    return null;
                }
            }
            foreach (var c in candidates)
            {
                var p = ActionExecutor.LoadAsset<UParticleSystem>(c);
                if (p != null && !p.IsNullOrDestroyed())
                {
                    isNiagara = false;
                    if (hasUserPath && !ReferenceEquals(p, null))
                        Log.Info($"[BoneGlow] 使用 Cascade: {c}");
                    return p;
                }
            }
            return null;
        }

        /// <summary>按骨骼挑选默认发光候选（越靠前优先级越高）</summary>
        private static List<string> DefaultCandidates(string boneName)
        {
            var list = new List<string>();
            if (boneName.Contains("weapon"))
            {
                list.Add(YEHUO_FIRE);     // 武器附魔火光（推断路径，失败会自动跳过）
                list.Add(LANGYA_GP);      // 狼牙棒棍身光效（已确认）
            }
            list.Add(GOLD);               // 玩家金光（已确认，最稳兜底）
            return list;
        }

        /// <summary>内置棍光预设组合</summary>
        private static List<FXItem> PresetItems(string preset)
        {
            switch ((preset ?? "").ToLowerInvariant())
            {
                case "fire":
                    return new List<FXItem>
                    {
                        new FXItem { path = YEHUO_FIRE, scale = 1.2f },
                        new FXItem { path = GOLD, scale = 0.7f },
                    };
                case "gold":
                    return new List<FXItem>
                    {
                        new FXItem { path = GOLD, scale = 1.0f },
                    };
                case "rich":
                case "棍光":
                default:
                    return new List<FXItem>
                    {
                        new FXItem { path = LANGYA_GP, scale = 1.0f },   // 棍身主光
                        new FXItem { path = GOLD, scale = 0.7f },       // 外层金辉
                        new FXItem { path = YEHUO_FIRE, scale = 1.2f }, // 内焰火光
                    };
            }
        }
    }
}
