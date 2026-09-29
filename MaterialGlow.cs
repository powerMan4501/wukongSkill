using System;
using System.Collections.Generic;
using b1;
using CSharpModBase;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace MagicMod
{
    /// <summary>
    /// 棍光配置（一次 MaterialGlow 动作 = 一份配置）。
    ///
    /// 字段优先级：Scalars / Vectors（自定义参数） &gt; Preset（亮度档） &gt; 内置默认值。
    /// </summary>
    public class MaterialGlowConfig
    {
        /// <summary>目标骨骼 / 插槽名。棍子就是 "weapon_r"（默认）。留空 = 不限骨骼，收集全部 Mesh。</summary>
        public string BoneName = "weapon_r";

        /// <summary>
        /// 材质槽选择：
        ///   ""（默认） = 自动，优先挑"棍光/FX"槽（材质名含 fx / liuguang / glow / 流光），挑不到才全选；
        ///   "*" / "all" = 全部槽；
        ///   其它字符串 = 关键字（同时匹配槽名和材质名，不区分大小写）；
        ///   纯数字 = 直接按槽索引（如 "3"）。
        ///   "probe" = 只做探测打印，不改材质。
        /// </summary>
        public string MatSlot = "";

        /// <summary>棍光颜色 [r,g,b]（0~1，可 &gt;1 做 HDR 过曝）。不填则用 ColorName / Preset 的配色。</summary>
        public float[]? Color = null;

        /// <summary>预设配色名：fire(火橙) / gold(金) / ice(冰蓝) / blue / purple / green / cyan / white / red</summary>
        public string ColorName = "";

        /// <summary>亮度总控。5 = 大佬棍光 mod 的原味数值；调大更亮，调小更淡。默认 5。</summary>
        public float Intensity = 5f;

        /// <summary>
        /// 模式：
        ///   weaponfx（默认）= 只下发武器 FX 材质（ML_Emissive_JGB 层）的流光参数 —— 做"棍光"用这个；
        ///   emissive = 通用自发光参数（EmissiveIntensity / GlowColor ...）；
        ///   fresnel  = 菲涅尔边缘光（GSArtFresnel 系列）；
        ///   both     = weaponfx + emissive + fresnel 全下发；
        ///   direct   = 不替换槽材质，直接改游戏现有的动态材质实例（换皮/换武器时不容易被顶掉）。
        /// </summary>
        public string Mode = "weaponfx";

        /// <summary>
        /// 亮度档：staff / 棍光（默认，= 棍光 mod 数值）· soft（淡）· strong（爆亮）。
        /// 也可以直接填配色名（fire / gold / ice / purple / green ...）= staff 亮度 + 该配色。
        /// </summary>
        public string Preset = "staff";

        /// <summary>自定义标量参数（最高优先级，覆盖以上所有推导）。key = 材质参数名。</summary>
        public Dictionary<string, float>? Scalars = null;

        /// <summary>自定义颜色参数（最高优先级）。key = 材质参数名，value = [r,g,b] 或 [r,g,b,a]。</summary>
        public Dictionary<string, float[]>? Vectors = null;

        /// <summary>是否持续重应用（武器系统会周期性重建材质，需要反复点亮）。默认 true。</summary>
        public bool KeepAlive = true;

        /// <summary>
        /// 槽上现有材质已经是 UMaterialInstanceDynamic 时，自动切成 direct 模式
        /// （直接改游戏这个现成的 MID，不再套一层）。实测棍光槽 MF_..._FX_MTL 本来就是 MID，
        /// 套娃反而可能被武器系统换掉。默认 true。
        /// </summary>
        public bool AutoDirect = true;

        /// <summary>持续重应用间隔（毫秒），默认 300。</summary>
        public int KeepAliveIntervalMs = 300;

        /// <summary>true = 先把目标 Mesh / 材质槽全部打印出来（排查用），再正常点亮。</summary>
        public bool Probe = false;

        /// <summary>持续毫秒。>0 = 到点自动还原（出招棍光亮一下）；0 = 常亮，直到 MaterialGlowStop。默认 0。</summary>
        public float DurationMs = 0f;
    }

    /// <summary>
    /// 棍子（weapon_r）的"棍光"——运行时改武器 FX 材质的自发光 / 流光参数。
    ///
    /// ===== 原理（来自大佬的棍光 pak mod + 反编译）=====
    /// 1) 棍身发光不是粒子，而是武器上的一层【材质】：
    ///    M_wukong_weapon_fx（MaterialInstanceConstant，父类 M_WuKong_Weapo_01_Inst）
    ///    混合模式 = Additive，材质层栈 = ML_Emissive_JGB / ML_Emissive_JGB_Inst / ML_Emissive_Fresnel，
    ///    层间混合靠 BlendParameter "Lerp"（必须 = 1，否则自发光层完全不混入，棍子永远不亮）。
    /// 2) 真正控制亮度的参数（全部是 LayerParameter）：
    ///    A/B/C/D_Brightness_intensity、A/B/C/D_Power_intensity、A/B/C/D_outer_ring、
    ///    A/B/C/D_center_ring、A/B/C/D_PositionOffset_intensity、
    ///    LiuGuang_Base1_Brightness / LiuGuang_Base2_Brightness（流光底图亮度）、
    ///    LiuGuang_*(Tiling / Offset speed / Distortion)、
    ///    MaskPosition / MaskContrast / CenterPoint（发光段落沿棍长的位置）、
    ///    Size / FX_GunAlpha（整体大小与透明度）；
    ///    颜色只有 C_Color / D_Color（A、B 层无颜色参数，默认白）。
    /// 3) 大佬的棍光 mod 就是打包覆盖了这个材质实例，把 A/B/C/D 亮度改成 7/10/15/28、
    ///    LiuGuang 改成 3.2/2.8、C_Color=FF935B、D_Color=FF4C39 —— 本类的 "staff" 档即复刻这套数值。
    /// 4) 这里不打包资源，改为运行时建 UMaterialInstanceDynamic 下发同样的参数，
    ///    好处是可以在 JSON 里随时改颜色 / 亮度 / 任意参数。
    ///
    /// ===== JSON 用法（actions.json）=====
    ///   { "Type": "MaterialGlow" }                                            // 默认：weapon_r 金色棍光（大佬 mod 同款亮度）
    ///   { "Type": "MaterialGlow", "MatColorName": "fire" }                     // 火红棍光
    ///   { "Type": "MaterialGlow", "MatPreset": "strong", "MatColorName": "ice" }// 爆亮冰蓝
    ///   { "Type": "MaterialGlow", "MatIntensity": 2 }                          // 亮度减半（淡光）
    ///   { "Type": "MaterialGlow", "MatColor": [0.2,1,0.4],
    ///     "MatParams": { "D_Brightness_intensity": 60, "MaskPosition": 0.3 } } // 任意参数覆盖
    ///   { "Type": "MaterialGlow", "MatSlot": "probe" }                         // 只打印棍子上的所有材质槽，不改
    ///   { "Type": "MaterialGlowStop" }                                         // 还原原始材质
    /// </summary>
    public static class MaterialGlow
    {
        // ===== 武器 FX 材质（M_wukong_weapon_fx）真实参数名，均由 FModel 导出校验 =====

        // 四层流光的亮度 / 强度（ML_Emissive_JGB_Inst）
        private static readonly string[] LayerBrightnessParams =
        {
            "A_Brightness_intensity", "B_Brightness_intensity", "C_Brightness_intensity", "D_Brightness_intensity"
        };
        private static readonly string[] LayerPowerParams =
        {
            "A_Power_intensity", "B_Power_intensity", "C_Power_intensity", "D_Power_intensity"
        };
        // 流光底图亮度
        private static readonly string[] LiuGuangBrightnessParams =
        {
            "LiuGuang_Base1_Brightness", "LiuGuang_Base2_Brightness"
        };
        // 发光颜色参数（材质里实际只有 C_Color / D_Color，其余是兼容其它皮肤）
        private static readonly string[] WeaponColorParams =
        {
            "C_Color", "D_Color", "LiuGuang_Color", "A_Color", "B_Color"
        };
        // direct 模式下需要捕获 / 还原原值的参数全集
        private static readonly string[] AllWeaponScalarParams = Flatten(
            LayerBrightnessParams, LayerPowerParams, LiuGuangBrightnessParams,
            new[] { "Lerp", "Size", "FX_GunAlpha", "MaskPosition", "MaskContrast", "CenterPoint", "RefractionDepthBias" });

        // 通用自发光（emissive 模式，非武器 FX 材质时兜底）
        private static readonly string[] EmissiveScalarParams =
        {
            "EmissiveIntensity", "Emissive_Intensity", "EmissiveStrength", "Emissive_Strength",
            "EmissivePower", "EmissiveBoost", "Emissive", "GlowIntensity", "Glow_Intensity", "GlowStrength"
        };
        private static readonly string[] EmissiveColorParams =
        {
            "EmissiveColor", "Emissive_Color", "EmissiveTint", "GlowColor", "Glow_Color", "GlowTint"
        };
        // 菲涅尔边缘光（fresnel 模式）
        private static readonly string[] FresnelScalarNames =
        {
            "UseGSArtFresnel", "GSArtFresnelBright", "GSArtFresnelPower", "GSArtFresnelDark"
        };
        private static readonly string[] FresnelColorNames =
        {
            "GSArtFresnelColor_In", "GSArtFresnelColor_Out"
        };

        // 层参数广播范围：M_wukong_weapon_fx 有 3 个材质层 + 2 个混合层，多广播几层兼容其它棍子皮肤
        private const int MaxLayerIndex = 5;
        private const int MaxBlendIndex = 2;

        private static string[] Flatten(params string[][] groups)
        {
            var list = new List<string>();
            foreach (var g in groups)
            {
                if (g == null) continue;
                foreach (var s in g)
                {
                    if (!string.IsNullOrEmpty(s) && !list.Contains(s)) list.Add(s);
                }
            }
            return list.ToArray();
        }

        private class Entry
        {
            public AActor Owner = null!;
            public UMeshComponent Mesh = null!;
            public int Index;
            public UMaterialInterface? Original;
            public UMaterialInstanceDynamic? Mid;
            /// <summary>direct 模式：改的是游戏现有 MID，不替换槽材质，靠写回原值还原</summary>
            public bool Direct;
            public Dictionary<string, float> OldScalars = new Dictionary<string, float>();
            public Dictionary<string, FLinearColor> OldVectors = new Dictionary<string, FLinearColor>();
            // 持续重应用需要
            public MaterialGlowConfig Cfg = null!;
            public FLinearColor Col;
            public string SlotName = "";
        }

        private static readonly List<Entry> _entries = new List<Entry>();
        private static readonly object _lock = new object();
        private static System.Threading.Timer? _keepTimer;

        /// <summary>是否已有"已投递但还没在游戏线程执行完"的重应用任务（0/1，Interlocked 操作），用于去重防止回调堆积</summary>
        private static int _keepPending = 0;
        // 限时熄灭的定时器统一交给 TimerPool 托管（触发完自动 Dispose + 移出），
        // 不再自己持有引用：否则 Timer 闭包会一直 root 住 target（AActor），UE GC 回收不掉

        // ===== 对外入口 =====

        /// <summary>按配置点亮棍光（推荐入口）。</summary>
        public static bool Start(AActor owner, MaterialGlowConfig cfg)
        {
            if (owner == null || owner.IsNullOrDestroyed()) return false;
            cfg = cfg ?? new MaterialGlowConfig();
            if (cfg.Intensity <= 0f) cfg.Intensity = 5f;
            if (string.IsNullOrEmpty(cfg.Mode)) cfg.Mode = "weaponfx";
            if (cfg.MatSlot == null) cfg.MatSlot = "";
            if (cfg.KeepAliveIntervalMs <= 0) cfg.KeepAliveIntervalMs = 300;

            // MatSlot="probe" 或 Probe=true → 先把棍子上的材质槽全打出来，方便挑参数
            bool probeOnly = cfg.MatSlot.Equals("probe", StringComparison.OrdinalIgnoreCase);
            if (probeOnly || cfg.Probe) Probe(owner, cfg.BoneName);
            if (probeOnly) return false;

            // 先还原上一次改过的，避免 MID 层层嵌套
            Stop(owner);

            FLinearColor col = ResolveColor(cfg);
            var meshes = CollectWeaponMeshes(owner, cfg.BoneName);

            int changed = 0;
            foreach (var m in meshes)
            {
                changed += ApplyToMesh(m, owner, cfg, col);
            }

            if (changed == 0)
            {
                Log.Warn($"[棍光] 没有找到可改的材质槽（BoneName='{cfg.BoneName}' MatSlot='{cfg.MatSlot}'）。可先发一次 {{\"Type\":\"MaterialGlow\",\"MatSlot\":\"probe\"}} 看全部槽");
                return false;
            }

            Log.Info($"[棍光] 已点亮 {changed} 个材质槽（模式={cfg.Mode}，档位={cfg.Preset}，强度={cfg.Intensity}，颜色={col.R:F2},{col.G:F2},{col.B:F2}）");

            if (cfg.KeepAlive) StartKeepAlive(cfg.KeepAliveIntervalMs);

            if (cfg.DurationMs > 0)
            {
                var target = owner;
                TimerPool.Once((int)cfg.DurationMs, () =>
                {
                    try { Utils.TryRunOnGameThread(() => Stop(target)); } catch { }
                });
                Log.Info($"[棍光] {cfg.DurationMs}ms 后自动熄灭");
            }
            return true;
        }

        /// <summary>兼容旧调用：按槽关键字点亮。</summary>
        public static bool Start(AActor owner, string slotKeyword, float[] color, float intensity,
            string mode, string boneName = "")
        {
            return Start(owner, new MaterialGlowConfig
            {
                BoneName = string.IsNullOrEmpty(boneName) ? "weapon_r" : boneName,
                MatSlot = slotKeyword ?? "",
                Color = (color != null && color.Length >= 3) ? color : null,
                Intensity = intensity,
                Mode = string.IsNullOrEmpty(mode) ? "weaponfx" : mode,
            });
        }

        /// <summary>还原原始材质。owner 为 null 时还原全部。</summary>
        public static void Stop(AActor? owner = null)
        {
            var restore = new List<Entry>();
            lock (_lock)
            {
                for (int i = _entries.Count - 1; i >= 0; i--)
                {
                    var e = _entries[i];
                    if (owner != null && !ReferenceEquals(e.Owner, owner)) continue;
                    restore.Add(e);
                    _entries.RemoveAt(i);
                }
            }
            foreach (var e in restore)
            {
                try
                {
                    if (e.Direct)
                    {
                        if (e.Mid != null && !e.Mid.IsNullOrDestroyed())
                            RestoreOriginals(e.Mid, e.OldScalars, e.OldVectors);
                    }
                    else if (e.Mesh != null && !e.Mesh.IsNullOrDestroyed() && e.Original != null && !e.Original.IsNullOrDestroyed())
                    {
                        e.Mesh.SetMaterial(e.Index, e.Original);
                    }
                }
                catch (Exception ex)
                {
                    Log.Warn($"[棍光] 还原材质失败: {ex.Message}");
                }
            }
            if (restore.Count > 0) Log.Info($"[棍光] 已还原 {restore.Count} 个材质槽");
            StopKeepAliveIfIdle();
        }

        /// <summary>预设配色。</summary>
        public static float[] PresetColor(string name)
        {
            switch ((name ?? "").ToLowerInvariant())
            {
                case "fire": return new[] { 1f, 0.29f, 0.1f };   // 棍光 mod 的 C_Color 色调
                case "red": return new[] { 1f, 0.15f, 0.1f };
                case "blue": return new[] { 0.2f, 0.55f, 1f };
                case "ice": return new[] { 0.3f, 0.75f, 1f };
                case "purple": return new[] { 0.7f, 0.3f, 1f };
                case "green": return new[] { 0.2f, 1f, 0.45f };
                case "white": return new[] { 1f, 1f, 1f };
                case "cyan": return new[] { 0.2f, 1f, 1f };
                case "gold":
                default: return new[] { 1f, 0.85f, 0.25f };
            }
        }

        /// <summary>
        /// 探测：打印棍子（weapon_r）上所有候选 Mesh、材质槽、材质名，以及附着的粒子组件。
        /// 不改任何东西，纯粹用来挑 MatSlot / 参数名。
        /// </summary>
        public static void Probe(AActor owner, string boneName = "weapon_r")
        {
            if (owner == null || owner.IsNullOrDestroyed()) return;
            if (string.IsNullOrEmpty(boneName)) boneName = "weapon_r";
            Log.Info($"[棍光] ==== 探测开始（骨骼={boneName}）====");

            var meshes = CollectWeaponMeshes(owner, boneName);
            foreach (var m in meshes)
            {
                string socket = "";
                try { socket = (m as USceneComponent)?.GetAttachSocketName().ToString() ?? ""; } catch { }
                string skInfo = "(非蒙皮组件)";
                if (m is USkinnedMeshComponent sk)
                {
                    var skm = sk.SkeletalMesh;
                    skInfo = (skm == null || skm.IsNullOrDestroyed())
                        ? "SkeletalMesh=null"
                        : "SKM='" + skm.GetName() + "' 自带材质数=" + ((skm.GetMaterials() != null) ? skm.GetMaterials().Count : -1);
                }
                Log.Info($"[棍光] 组件 '{m.GetName()}' ({m.GetType().Name}) 挂点='{socket}' 槽数={m.GetNumMaterials()} {skInfo}");

                var slotNames = m.GetMaterialSlotNames();
                var mats = m.GetMaterials();
                int count = Math.Max(m.GetNumMaterials(), (mats != null) ? mats.Count : 0);
                for (int i = 0; i < count; i++)
                {
                    string slot = (slotNames != null && i < slotNames.Count) ? slotNames[i].ToString() : i.ToString();
                    UMaterialInterface? orig = FirstValid(
                        (mats != null && i < mats.Count) ? mats[i] : null,
                        m.GetMaterial(i));
                    if (orig == null && m is USkinnedMeshComponent skc)
                    {
                        try
                        {
                            var skm2 = skc.SkeletalMesh;
                            if (skm2 != null && !skm2.IsNullOrDestroyed())
                            {
                                var sm = skm2.GetMaterials();
                                if (sm != null && i < sm.Count) orig = FirstValid(orig, sm[i].MaterialInterface);
                            }
                        }
                        catch { }
                    }
                    string matName = NameOf(orig);
                    bool isFx = IsFxSlot(slot, matName);
                    Log.Info($"[棍光]   [{i}] slot='{slot}' mat='{matName}' {(isFx ? "★疑似棍光/FX槽" : "")}");
                }

                // 顺便列出插槽，方便找棍尖/棍身挂点
                try
                {
                    var socks = m.GetAllSocketNames();
                    if (socks != null && socks.Count > 0)
                    {
                        var names = new List<string>();
                        foreach (var s in socks) names.Add(s.ToString());
                        Log.Info($"[棍光]   插槽: {string.Join(", ", names)}");
                    }
                }
                catch { }
            }

            try
            {
                var nis = owner.GetComponentsByClass(UClass.GetClass<UNiagaraComponent>());
                if (nis != null)
                {
                    foreach (var c in nis)
                    {
                        if (c is UNiagaraComponent nc && !nc.IsNullOrDestroyed())
                            Log.Info($"[棍光] Niagara 组件: '{nc.GetName()}' active={nc.IsActive()}");
                    }
                }
            }
            catch { }

            Log.Info("[棍光] ==== 探测结束 ====");
        }

        // ===== 亮度档位 =====

        /// <summary>返回该档位下各亮度参数的基准值（会再乘 Intensity/5）。数值取自棍光 mod 的 M_wukong_weapon_fx。</summary>
        private static Dictionary<string, float> BrightnessProfile(string preset)
        {
            var d = new Dictionary<string, float>();
            float a, b, c, dd, lg1, lg2;
            switch ((preset ?? "").ToLowerInvariant())
            {
                case "soft": a = 3f; b = 4f; c = 6f; dd = 12f; lg1 = 1.5f; lg2 = 1.2f; break;
                case "strong": a = 12f; b = 18f; c = 25f; dd = 40f; lg1 = 5f; lg2 = 4.5f; break;
                case "staff":
                case "棍光":
                default: a = 7f; b = 10f; c = 15f; dd = 28f; lg1 = 3.2f; lg2 = 2.8f; break;   // 棍光 mod 原味
            }
            d["A_Brightness_intensity"] = a;
            d["B_Brightness_intensity"] = b;
            d["C_Brightness_intensity"] = c;
            d["D_Brightness_intensity"] = dd;
            d["A_Power_intensity"] = 1f;
            d["B_Power_intensity"] = 1f;
            d["C_Power_intensity"] = 1f;
            d["D_Power_intensity"] = 1f;
            d["LiuGuang_Base1_Brightness"] = lg1;
            d["LiuGuang_Base2_Brightness"] = lg2;
            return d;
        }

        private static bool IsColorName(string s)
        {
            switch ((s ?? "").ToLowerInvariant())
            {
                case "fire": case "gold": case "ice": case "blue": case "purple":
                case "green": case "cyan": case "white": case "red": return true;
                default: return false;
            }
        }

        private static FLinearColor ResolveColor(MaterialGlowConfig cfg)
        {
            if (cfg.Color != null && cfg.Color.Length >= 3) return ToColor(cfg.Color);
            if (!string.IsNullOrEmpty(cfg.ColorName)) return ToColor(PresetColor(cfg.ColorName));
            if (IsColorName(cfg.Preset)) return ToColor(PresetColor(cfg.Preset));
            return ToColor(PresetColor("gold"));
        }

        // ===== 目标 Mesh 收集 =====

        /// <summary>收集"棍子"相关的 Mesh 组件：武器管理器 → 名字含 weapon → 挂在目标骨骼插槽上 → 兜底全部。</summary>
        private static List<UMeshComponent> CollectWeaponMeshes(AActor owner, string boneName)
        {
            var result = new List<UMeshComponent>();
            var ranks = new Dictionary<UMeshComponent, int>();

            void Add(UMeshComponent m, int rank)
            {
                if (m == null || m.IsNullOrDestroyed()) return;
                if (result.Contains(m))
                {
                    if (ranks.TryGetValue(m, out int old) && rank < old) ranks[m] = rank;
                    return;
                }
                result.Add(m);
                ranks[m] = rank;
            }

            // 1) 武器管理器：游戏自己的武器索引，最准
            var chr = owner as BGUCharacterCS;
            if (chr != null && !chr.IsNullOrDestroyed())
            {
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
                            foreach (var mc in CollectMeshesOnActor(w)) Add(mc, 0);
                        }
                    }
                }
                catch { }
            }

            // 收集自身 + 子 Actor 上的所有 Mesh
            foreach (var m in CollectMeshesOnActor(owner))
            {
                string nm = m.GetName() ?? "";
                string socket = "";
                try { socket = (m as USceneComponent)?.GetAttachSocketName().ToString() ?? ""; } catch { }

                bool nameHit = nm.IndexOf("weapon", StringComparison.OrdinalIgnoreCase) >= 0;
                bool socketHit = !string.IsNullOrEmpty(boneName) &&
                                 socket.Equals(boneName, StringComparison.OrdinalIgnoreCase);
                if (nameHit) Add(m, 1);
                else if (socketHit) Add(m, 2);
            }

            // 2) 一个都没命中 → 退回"全部 Mesh（除身体主网格外）"
            if (result.Count == 0)
            {
                var mainMesh = chr?.Mesh;
                foreach (var m in CollectMeshesOnActor(owner))
                {
                    bool isMain = mainMesh != null && ReferenceEquals(m, mainMesh);
                    Add(m, isMain ? 4 : 3);
                }
            }

            result.Sort((x, y) => ranks[x].CompareTo(ranks[y]));
            return result;
        }

        private static List<UMeshComponent> CollectMeshesOnActor(AActor actor)
        {
            var list = new List<UMeshComponent>();
            if (actor == null || actor.IsNullOrDestroyed()) return list;
            try
            {
                var comps = actor.GetComponentsByClass(UClass.GetClass<UMeshComponent>());
                if (comps != null)
                {
                    foreach (var c in comps)
                    {
                        if (c is UMeshComponent m && !m.IsNullOrDestroyed() && !list.Contains(m)) list.Add(m);
                    }
                }
            }
            catch { }
            try
            {
                actor.GetAllChildActors(out var children);
                if (children != null)
                {
                    foreach (var ch in children)
                    {
                        if (ch == null || ch.IsNullOrDestroyed()) continue;
                        foreach (var m in CollectMeshesOnActor(ch))
                        {
                            if (!list.Contains(m)) list.Add(m);
                        }
                    }
                }
            }
            catch { }
            return list;
        }

        // ===== 应用 =====

        private static int ApplyToMesh(UMeshComponent mesh, AActor owner, MaterialGlowConfig cfg, FLinearColor col)
        {
            if (mesh == null || mesh.IsNullOrDestroyed()) return 0;

            var slotNames = mesh.GetMaterialSlotNames();
            var mats = mesh.GetMaterials();
            int count = Math.Max(mesh.GetNumMaterials(), (mats != null) ? mats.Count : 0);
            bool byIndex = int.TryParse(cfg.MatSlot, out int onlyIndex);
            bool allSlots = cfg.MatSlot == "*" || cfg.MatSlot.Equals("all", StringComparison.OrdinalIgnoreCase);

            // 先筛出候选槽
            var candidates = new List<int>();
            var fxFlags = new List<bool>();
            for (int i = 0; i < count; i++)
            {
                UMaterialInterface? orig = GetSlotMaterial(mesh, i);
                if (orig == null || orig.IsNullOrDestroyed()) continue;
                string slotName = (slotNames != null && i < slotNames.Count) ? slotNames[i].ToString() : i.ToString();
                string matName = NameOf(orig);
                bool isFx = IsFxSlot(slotName, matName);

                if (byIndex)
                {
                    if (i != onlyIndex) continue;
                }
                else if (allSlots || string.IsNullOrEmpty(cfg.MatSlot))
                {
                    // 后面再按 isFx 收敛
                }
                else if (slotName.IndexOf(cfg.MatSlot, StringComparison.OrdinalIgnoreCase) < 0 &&
                         matName.IndexOf(cfg.MatSlot, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    continue;
                }
                candidates.Add(i);
                fxFlags.Add(isFx);
            }

            // 自动模式：优先只点"棍光/FX"槽，一个都没有才全点
            if (!byIndex && !allSlots && string.IsNullOrEmpty(cfg.MatSlot))
            {
                var fxOnly = new List<int>();
                for (int k = 0; k < candidates.Count; k++)
                {
                    if (fxFlags[k]) fxOnly.Add(candidates[k]);
                }
                if (fxOnly.Count > 0) candidates = fxOnly;
            }

            bool direct = (cfg.Mode ?? "").IndexOf("direct", StringComparison.OrdinalIgnoreCase) >= 0;
            int changed = 0;
            int midSlots = 0;

            foreach (int i in candidates)
            {
                UMaterialInterface? orig = GetSlotMaterial(mesh, i);
                if (orig == null || orig.IsNullOrDestroyed()) continue;
                string slotName = (slotNames != null && i < slotNames.Count) ? slotNames[i].ToString() : i.ToString();

                if (orig is UMaterialInstanceDynamic) midSlots++;

                UMaterialInstanceDynamic? mid;
                bool thisDirect = direct || (cfg.AutoDirect && orig is UMaterialInstanceDynamic);
                if (thisDirect && orig is UMaterialInstanceDynamic existMid && !existMid.IsNullOrDestroyed())
                {
                    mid = existMid;
                }
                else
                {
                    mid = UMaterialLibrary.CreateDynamicMaterialInstance(owner, orig, FName.None, EMIDCreationFlags.None);
                    if (mid == null || mid.IsNullOrDestroyed()) continue;
                    mesh.SetMaterial(i, mid);
                }

                var e = new Entry
                {
                    Owner = owner,
                    Mesh = mesh,
                    Index = i,
                    Original = orig,
                    Mid = mid,
                    Direct = thisDirect,
                    Cfg = cfg,
                    Col = col,
                    SlotName = slotName,
                };
                if (thisDirect) CaptureOriginals(mid, e.OldScalars, e.OldVectors);

                ApplyParams(mid, cfg, col);

                lock (_lock) _entries.Add(e);
                changed++;
                Log.Info($"[棍光] '{mesh.GetName()}' 槽[{i}] '{slotName}' (mat={NameOf(orig)}) → {(thisDirect ? "直改现有MID" : "已挂动态材质")}");
            }
            return changed;
        }

        /// <summary>三级兜底取材质：组件材质列表 → GetMaterial(i) → SkeletalMesh 资源自带材质。</summary>
        private static UMaterialInterface? GetSlotMaterial(UMeshComponent mesh, int i)
        {
            var mats = mesh.GetMaterials();
            UMaterialInterface? orig = FirstValid((mats != null && i < mats.Count) ? mats[i] : null, mesh.GetMaterial(i));
            if (orig != null && !orig.IsNullOrDestroyed()) return orig;
            if (mesh is USkinnedMeshComponent skc)
            {
                try
                {
                    var skm = skc.SkeletalMesh;
                    if (skm != null && !skm.IsNullOrDestroyed())
                    {
                        var sm = skm.GetMaterials();
                        if (sm != null && i < sm.Count) return FirstValid(orig, sm[i].MaterialInterface);
                    }
                }
                catch { }
            }
            return null;
        }

        /// <summary>判断这个槽像不像"棍光/FX"材质（用于自动挑槽）。</summary>
        private static bool IsFxSlot(string slotName, string matName)
        {
            string[] keys = { "fx", "liuguang", "glow", "guang", "emissive", "liuguang" };
            foreach (var k in keys)
            {
                if (slotName.IndexOf(k, StringComparison.OrdinalIgnoreCase) >= 0) return true;
                if (matName.IndexOf(k, StringComparison.OrdinalIgnoreCase) >= 0) return true;
            }
            return false;
        }

        /// <summary>下发全部棍光参数。</summary>
        private static void ApplyParams(UMaterialInstanceDynamic mid, MaterialGlowConfig cfg, FLinearColor col)
        {
            string mode = (cfg.Mode ?? "weaponfx").ToLowerInvariant();
            bool weaponFx = mode.Contains("weaponfx") || mode.Contains("both") || mode.Contains("direct");
            bool emissive = mode.Contains("emissive") || mode.Contains("both");
            bool fresnel = mode.Contains("fresnel") || mode.Contains("both");

            // 亮度总控：5 = 棍光 mod 原味
            float k = cfg.Intensity / 5f;

            if (weaponFx)
            {
                // 1) 亮度档位
                foreach (var kv in BrightnessProfile(cfg.Preset))
                    SetScalarAll(mid, kv.Key, kv.Value * k);

                // 2) 混合 / 遮罩：Lerp 不拉到 1，自发光层根本不混入（棍子不会亮）
                SetScalarAll(mid, "Lerp", 1f);
                SetScalarAll(mid, "FX_GunAlpha", 1f);
                SetScalarAll(mid, "Size", 2f);
                // 发光段落沿棍长居中（0.5 = 整根棍都亮，不是只有端头）
                SetScalarAll(mid, "MaskPosition", 0.5f);
                SetScalarAll(mid, "CenterPoint", 0.5f);

                // 3) 颜色（材质里真正生效的是 C_Color / D_Color）
                foreach (var p in WeaponColorParams) SetVectorAll(mid, p, col);
            }

            if (emissive)
            {
                foreach (var p in EmissiveScalarParams) SetScalarAll(mid, p, cfg.Intensity);
                foreach (var p in EmissiveColorParams) SetVectorAll(mid, p, col);
            }

            if (fresnel)
            {
                SetScalarAll(mid, "UseGSArtFresnel", 1f);
                SetScalarAll(mid, "GSArtFresnelBright", cfg.Intensity);
                SetScalarAll(mid, "GSArtFresnelPower", 2f);
                SetScalarAll(mid, "GSArtFresnelDark", 0f);
                foreach (var p in FresnelColorNames) SetVectorAll(mid, p, col);
            }

            // 4) 自定义参数（最高优先级，最后下发覆盖上面所有推导）
            if (cfg.Scalars != null)
            {
                foreach (var kv in cfg.Scalars)
                {
                    if (string.IsNullOrEmpty(kv.Key)) continue;
                    SetScalarAll(mid, kv.Key, kv.Value);
                }
            }
            if (cfg.Vectors != null)
            {
                foreach (var kv in cfg.Vectors)
                {
                    if (string.IsNullOrEmpty(kv.Key) || kv.Value == null || kv.Value.Length < 3) continue;
                    SetVectorAll(mid, kv.Key, ToColor(kv.Value));
                }
            }
        }

        // ===== 持续重应用 =====

        private static void StartKeepAlive(int intervalMs)
        {
            lock (_lock)
            {
                if (_keepTimer != null) return;
                // ReapplyAll 会创建/设置 UObject（UMaterialInstanceDynamic），必须投递到游戏线程执行
                _keepTimer = new System.Threading.Timer(_ => PostReapply(), null, intervalMs, intervalMs);
            }
            Log.Info($"[棍光] 已启动持续重应用（每 {intervalMs}ms 重新点亮，防止武器系统重建材质后失效）");
        }

        private static void StopKeepAliveIfIdle()
        {
            lock (_lock)
            {
                if (_entries.Count > 0 || _keepTimer == null) return;
                _keepTimer.Dispose();
                _keepTimer = null;
            }
        }

        /// <summary>
        /// 把一次"持续重应用"投递到游戏线程（异步，不阻塞 Timer 线程）。
        /// Reapply 里会 CreateDynamicMaterialInstance / SetMaterial，属于创建和修改 UObject，
        /// 跨线程执行会和游戏线程抢锁导致卡顿甚至崩溃。
        /// </summary>
        private static void PostReapply()
        {
            // 上一次投递还没执行完 → 跳过本次，避免回调堆积
            if (System.Threading.Interlocked.CompareExchange(ref _keepPending, 1, 0) != 0) return;
            try
            {
                FThreading.RunOnGameThreadAsync(() =>
                {
                    try { ReapplyAll(); }
                    catch { }
                    finally { System.Threading.Interlocked.Exchange(ref _keepPending, 0); }
                });
            }
            catch
            {
                System.Threading.Interlocked.Exchange(ref _keepPending, 0);
            }
        }

        private static void ReapplyAll()
        {
            List<Entry> snapshot;
            lock (_lock)
            {
                if (_entries.Count == 0) return;
                snapshot = new List<Entry>(_entries);
            }
            foreach (var e in snapshot) Reapply(e);
        }

        private static void Reapply(Entry e)
        {
            var mesh = e.Mesh;
            if (mesh == null || mesh.IsNullOrDestroyed()) return;

            var cur = mesh.GetMaterial(e.Index);
            if (cur == null || cur.IsNullOrDestroyed()) return;

            var mid = cur as UMaterialInstanceDynamic;
            if (mid == null || mid.IsNullOrDestroyed())
            {
                // 材质被武器系统重建成了普通实例：基于新材质重建 MID 再挂回去
                var created = UMaterialLibrary.CreateDynamicMaterialInstance(e.Owner, cur, FName.None, EMIDCreationFlags.None);
                if (created == null || created.IsNullOrDestroyed()) return;
                mesh.SetMaterial(e.Index, created);
                mid = created;
                lock (_lock) e.Mid = created;
            }
            ApplyParams(mid, e.Cfg, e.Col);
        }

        // ===== 工具 =====

        private static void CaptureOriginals(UMaterialInstanceDynamic mid, Dictionary<string, float> sc, Dictionary<string, FLinearColor> vc)
        {
            foreach (var n in AllWeaponScalarParams)
            {
                try { sc[n] = mid.GetScalarParameterValue(new FName(n)); } catch { }
            }
            foreach (var n in WeaponColorParams)
            {
                try { vc[n] = mid.GetVectorParameterValue(new FName(n)); } catch { }
            }
        }

        private static void RestoreOriginals(UMaterialInstanceDynamic mid, Dictionary<string, float> sc, Dictionary<string, FLinearColor> vc)
        {
            foreach (var kv in sc)
            {
                try { mid.SetScalarParameterValue(new FName(kv.Key), kv.Value); } catch { }
            }
            foreach (var kv in vc)
            {
                try { mid.SetVectorParameterValue(new FName(kv.Key), kv.Value); } catch { }
            }
        }

        /// <summary>
        /// 设置标量参数：Global(FName) + 向所有材质层 / 混合层索引广播。
        /// 黑神话武器 FX 是多层材质，参数注册为 LayerParameter（Lerp 之类是 BlendParameter），
        /// 层索引未知故全量广播，不存在的组合会被引擎忽略。
        /// </summary>
        private static void SetScalarAll(UMaterialInstanceDynamic mid, string name, float value)
        {
            var fn = new FName(name);
            try { mid.SetScalarParameterValue(fn, value); } catch { }
            try
            {
                for (int idx = 0; idx <= MaxLayerIndex; idx++)
                {
                    var info = new FMaterialParameterInfo
                    {
                        Name = fn,
                        Association = EMaterialParameterAssociation.LayerParameter,
                        Index = idx
                    };
                    mid.SetScalarParameterValueByInfo(info, value);
                }
                for (int idx = 0; idx <= MaxBlendIndex; idx++)
                {
                    var binfo = new FMaterialParameterInfo
                    {
                        Name = fn,
                        Association = EMaterialParameterAssociation.BlendParameter,
                        Index = idx
                    };
                    mid.SetScalarParameterValueByInfo(binfo, value);
                }
            }
            catch { }
        }

        private static void SetVectorAll(UMaterialInstanceDynamic mid, string name, FLinearColor value)
        {
            var fn = new FName(name);
            try { mid.SetVectorParameterValue(fn, value); } catch { }
            try
            {
                for (int idx = 0; idx <= MaxLayerIndex; idx++)
                {
                    var info = new FMaterialParameterInfo
                    {
                        Name = fn,
                        Association = EMaterialParameterAssociation.LayerParameter,
                        Index = idx
                    };
                    mid.SetVectorParameterValueByInfo(info, value);
                }
                for (int idx = 0; idx <= MaxBlendIndex; idx++)
                {
                    var binfo = new FMaterialParameterInfo
                    {
                        Name = fn,
                        Association = EMaterialParameterAssociation.BlendParameter,
                        Index = idx
                    };
                    mid.SetVectorParameterValueByInfo(binfo, value);
                }
            }
            catch { }
        }

        private static UMaterialInterface? FirstValid(UMaterialInterface? a, UMaterialInterface? b)
        {
            if (a != null && !a.IsNullOrDestroyed()) return a;
            if (b != null && !b.IsNullOrDestroyed()) return b;
            return null;
        }

        private static string NameOf(UObject? o)
        {
            return (o != null && !o.IsNullOrDestroyed()) ? (o.GetName() ?? "") : "(null)";
        }

        private static FLinearColor ToColor(float[] a)
        {
            if (a == null || a.Length < 3) a = PresetColor("gold");
            float al = (a.Length >= 4) ? a[3] : 1f;
            return new FLinearColor(a[0], a[1], a[2], al);
        }
    }
}
