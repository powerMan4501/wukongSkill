#nullable disable
using System;
using System.Collections.Generic;
using b1;
using b1.EventDelDefine;
using CSharpModBase;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace MagicMod
{
    /// <summary>
    /// 棍影（武器挥舞残影）辅助封装。
    ///
    /// 游戏内"棍影"的实现原理（来自 GameDll 反编译）：
    ///   1) 引擎基类 UAnimNotifyState_Trail（UnrealEngine.Engine）：用 Cascade 粒子 PSTemplate，
    ///      在动画上挂两个 Socket（FirstSocketName / SecondSocketName）之间生成 Trail 粒子残影。
    ///   2) 游戏包装类 BANS_GSTrail / BANS_GSTrailWithArray（main/b1）：继承自上面的 Trail，
    ///      只是把它们做成可配置 AnimNotifyState（PSTemplate + Socket 列表 + 宽度曲线）。
    ///   3) 新方案 BAN_DispLibSimpleRibbonTrailsArray（GSDispLib）：Niagara 版本，用
    ///      template(UNiagaraSystem) + socketName + customParams(颜色等) 在指定骨骼 Socket 上生成 Ribbon 残影。
    ///
    /// 作为 Mod 无法给已有动画资产塞 Notify，因此本类用"运行时"方式复刻：
    ///   - 取玩家主武器（金箍棒）的 USkeletalMeshComponent（走 IBUC_WeaponManagerData，同 WeaponScale.cs）。
    ///   - 用 UNiagaraFunctionLibrary.SpawnSystemAttached 把一条 Niagara Ribbon 挂在棍子末端 Socket 上。
    ///   - 订阅 Evt_PlayMontageCallback：目标动画开始播放时挂上棍影，结束/被打断时淡出销毁。
    ///   - 颜色通过 Niagara 变量（默认 "GS_Color"）传入，可任意自定义。
    ///
    /// 注意：Niagara 模板资源（决定残影形状/宽度）与 Socket 名必须你提供/确认：
    ///   - NiagaraTemplatePath：一条 Niagara Ribbon 类特效的资源路径（可用 FModel 在 VFX 下找 Trail/Ribbon，
    ///     或复用游戏已有的棍影 FX）。
    ///   - SocketName：棍子末端的 Socket 名，先用 ListWeaponSockets() 打出来挑（如 "Weapon_Tip"）。
    ///   - ColorParamName：Niagara 里控制颜色的变量名，依你选的模板而定（不确定就留空，只不改色）。
    /// </summary>
    public static class StaffTrailHelper
    {
        public class TrailConfig
        {
            /// <summary>Niagara Ribbon 类特效资源路径（必须，如 /Game/.../NS_StaffTrail.NS_StaffTrail）</summary>
            public string NiagaraTemplatePath = "";

            /// <summary>棍子末端 Socket 名（需运行时确认，见 ListWeaponSockets）</summary>
            public string SocketName = "Weapon_Tip";

            /// <summary>棍影颜色（线性 0~1，含 alpha）</summary>
            public FLinearColor Color = new FLinearColor(1f, 0.8f, 0.2f, 1f);

            /// <summary>Niagara 控制颜色的变量名；为空表示不改色</summary>
            public string ColorParamName = "GS_Color";

            /// <summary>自动销毁（Niagara 自身管理生命周期）</summary>
            public bool AutoDestroy = true;

            /// <summary>动画结束后多久销毁组件，让残影淡出（秒）</summary>
            public float FadeOutDelay = 0.4f;
        }

        private class Binding
        {
            public string MontagePath;       // 归一化后的动画路径
            public TrailConfig Cfg;
            public UNiagaraComponent ActiveComponent; // 当前挂着的组件（游戏线程内赋值）
        }

        private static readonly object _lock = new object();
        private static readonly List<Binding> _bindings = new List<Binding>();
        private static BGUPlayerCharacterCS _boundCharacter;
        private static Del_PlayMontageCallback _globalHandler;

        /// <summary>
        /// 绑定：当 path 对应的动画开始播放时自动挂棍影，结束/打断时移除。
        /// 可多次调用绑定不同动画（共享一个 Montage 回调）。
        /// </summary>
        public static void Bind(BGUPlayerCharacterCS character, string montagePath, TrailConfig cfg)
        {
            if (character == null || string.IsNullOrEmpty(montagePath)) return;
            lock (_lock)
            {
                if (_boundCharacter == null)
                {
                    _boundCharacter = character;
                    _globalHandler = new Del_PlayMontageCallback(OnMontageCallback);
                    BUS_EventCollectionCS.Get(character).Evt_PlayMontageCallback += _globalHandler;
                }
                _bindings.Add(new Binding { MontagePath = Normalize(montagePath), Cfg = cfg });
            }
            Log.Info($"[StaffTrail] 已绑定棍影到动画 {montagePath}");
        }

        /// <summary>解绑全部（热重载时调用，避免回调残留）</summary>
        public static void UnbindAll()
        {
            lock (_lock)
            {
                if (_boundCharacter != null && _globalHandler != null)
                {
                    try { BUS_EventCollectionCS.Get(_boundCharacter).Evt_PlayMontageCallback -= _globalHandler; }
                    catch { }
                }
                foreach (var b in _bindings) StopTrail(b.ActiveComponent);
                _bindings.Clear();
                _boundCharacter = null;
                _globalHandler = null;
            }
        }

        private static void OnMontageCallback(EMontageBindReason reason, UAnimMontage montage, EMontageCallbackState state)
        {
            if (montage == null) return;
            string path = Normalize(montage.PathName);
            bool started = state == EMontageCallbackState.OnStarted;
            bool ended = state == EMontageCallbackState.OnCompleted
                      || state == EMontageCallbackState.OnInterrupted
                      || state == EMontageCallbackState.OnPlayFailed;
            if (!started && !ended) return;

            lock (_lock)
            {
                foreach (var b in _bindings)
                {
                    if (b.MontagePath != path) continue;
                    if (started)
                    {
                        b.ActiveComponent = StartTrail(_boundCharacter, b.Cfg);
                    }
                    else if (ended)
                    {
                        StopTrail(b.ActiveComponent);
                        b.ActiveComponent = null;
                    }
                }
            }
        }

        /// <summary>
        /// 立即给当前主武器挂上棍影（返回组件；因走游戏线程可能异步，返回 null 不代表失败）。
        /// 通常配合 Bind 自动使用；也可在任意时刻手动调用做常驻棍影。
        /// </summary>
        public static UNiagaraComponent StartTrail(BGUPlayerCharacterCS character, TrailConfig cfg)
        {
            if (character == null || character.IsNullOrDestroyed()) return null;
            if (string.IsNullOrEmpty(cfg.NiagaraTemplatePath))
            {
                Log.Warn("[StaffTrail] NiagaraTemplatePath 为空，无法挂棍影");
                return null;
            }

            UNiagaraComponent result = null;
            Utils.TryRunOnGameThread(() =>
            {
                var wm = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_WeaponManagerData, BUC_WeaponManagerData>(character);
                if (wm == null) { Log.Warn("[StaffTrail] 取不到 IBUC_WeaponManagerData"); return; }

                USkeletalMeshComponent meshComp = null;
                int n = wm.GetWeaponNum();
                for (int i = 0; i < n; i++)
                {
                    var w = wm.FindWeaponByIndex(i);
                    if (w != null && !w.IsNullOrDestroyed())
                    {
                        meshComp = w.GetComponentByClass<USkeletalMeshComponent>();
                        if (meshComp != null) break;
                    }
                }
                if (meshComp == null) { Log.Warn("[StaffTrail] 找不到武器 SkeletalMeshComponent（主武器未装备？）"); return; }

                var tmpl = ActionExecutor.LoadAsset<UNiagaraSystem>(cfg.NiagaraTemplatePath);
                if (tmpl == null) { Log.Warn($"[StaffTrail] 加载 Niagara 失败: {cfg.NiagaraTemplatePath}"); return; }

                var comp = UNiagaraFunctionLibrary.SpawnSystemAttached(
                    tmpl,
                    meshComp,
                    new FName(cfg.SocketName),
                    FVector.ZeroVector,
                    FRotator.ZeroRotator,
                    EAttachLocation.SnapToTarget,
                    cfg.AutoDestroy,
                    true);

                if (comp != null && !string.IsNullOrEmpty(cfg.ColorParamName))
                {
                    comp.SetVariableLinearColor(new FName(cfg.ColorParamName), cfg.Color);
                }
                result = comp;
                Log.Info($"[StaffTrail] 已挂棍影 -> socket={cfg.SocketName}, color=({cfg.Color.R:F2},{cfg.Color.G:F2},{cfg.Color.B:F2})");
            });
            return result;
        }

        /// <summary>停止并淡出销毁一条棍影</summary>
        public static void StopTrail(UNiagaraComponent comp)
        {
            if (comp == null || comp.IsNullOrDestroyed()) return;
            Utils.TryRunOnGameThread(() =>
            {
                if (comp.IsNullOrDestroyed()) return;
                comp.Deactivate();
                var c = comp;
                // 走 TimerPool：触发完自动 Dispose 并移出池。
                // 以前这些 Timer 被静态列表永久持有，闭包捕获的 Niagara 组件回收不掉
                TimerPool.Once((int)(0.4f * 1000), () =>
                {
                    Utils.TryRunOnGameThread(() =>
                    {
                        if (!c.IsNullOrDestroyed()) c.DestroyComponent(c);
                    });
                });
            });
        }

        /// <summary>调试：打印主武器 Mesh 上所有 Socket 名，用来确认棍子末端 Socket</summary>
        public static void ListWeaponSockets(BGUPlayerCharacterCS character)
        {
            if (character == null || character.IsNullOrDestroyed()) return;
            Utils.TryRunOnGameThread(() =>
            {
                var wm = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_WeaponManagerData, BUC_WeaponManagerData>(character);
                if (wm == null) return;
                int n = wm.GetWeaponNum();
                for (int i = 0; i < n; i++)
                {
                    var w = wm.FindWeaponByIndex(i);
                    if (w == null || w.IsNullOrDestroyed()) continue;
                    var mc = w.GetComponentByClass<USkeletalMeshComponent>();
                    if (mc == null) continue;
                    var names = mc.GetAllSocketNames();
                    Log.Info($"[StaffTrail] 武器#{i} Socket 列表({names.Count}):");
                    foreach (var s in names) Log.Info($"   - {s}");
                }
            });
        }

        private static string Normalize(string p)
        {
            if (string.IsNullOrEmpty(p)) return "";
            p = p.ToLowerInvariant();
            int dot = p.LastIndexOf('.');
            int slash = p.LastIndexOf('/');
            if (dot > slash) p = p.Substring(0, dot); // 去掉对象路径末尾的 ".AssetName"
            return p;
        }
    }
}
