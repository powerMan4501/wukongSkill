using System;
using System.Collections.Generic;
using System.IO;
using b1;
using b1.BGW;
using b1.Plugins.TressFX;
using BtlB1;
using BtlShare;
using CSharpModBase;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using Newtonsoft.Json;

namespace ActionsMod
{
    /// <summary>
    /// 幻化变身 Boss 外观自定义配置（soulBossConfig）加载与套用逻辑，移植自 MagicMod。
    /// Magic 动作的 Value(MagicID) 命中 soulBossConfig 时，用自定义外观（模型/动画/物理/毛发/武器等）
    /// 覆盖游戏原生幻化配置，并支持按 HideMeshKeywords 隐藏被遮挡的玩家部件（解决残躯秃头等）。
    /// </summary>
    internal static class SoulBossLogic
    {
        private static readonly Dictionary<int, SoulBossConfig> _soulConfigs = new Dictionary<int, SoulBossConfig>();

        /// <summary>判断资产路径是否有效（非空且非运行时临时对象 /Engine/Transient.*）</summary>
        private static bool IsValidAssetPath(string? p)
            => !string.IsNullOrEmpty(p) && !p!.StartsWith("/Engine/Transient", StringComparison.OrdinalIgnoreCase);

        // 记录被"幻化隐藏"功能临时隐藏的 mesh 组件，变回/切换到其它形态时统一恢复，避免残留
        private static readonly HashSet<UPrimitiveComponent> _magicHiddenMeshes = new HashSet<UPrimitiveComponent>();

        /// <summary>初始化幻化变身 Boss 外观配置（soulConfigList），同 ID 后加载的覆盖先加载的</summary>
        public static void InitSoulConfigs(List<SoulBossConfig> configs)
        {
            _soulConfigs.Clear();
            if (configs != null)
            {
                foreach (var cfg in configs)
                {
                    if (cfg == null || cfg.ID <= 0) continue;
                    _soulConfigs[cfg.ID] = cfg;
                }
            }
            Log.Info($"[ActionsMod] 初始化 soulBossConfig 配置，共 {_soulConfigs.Count} 条规则");
            foreach (var kvp in _soulConfigs)
            {
                Log.Info($"[ActionsMod]   SoulConfig ID={kvp.Key} -> BuffId={kvp.Value.BuffId}, TamerPath='{kvp.Value.TamerPath}'");
            }
        }

        /// <summary>按 MagicID 查找幻化变身 Boss 外观配置，未命中返回 null（走原有 DAPath 流程）</summary>
        public static SoulBossConfig? GetSoulConfig(int magicId)
        {
            if (magicId <= 0) return null;
            _soulConfigs.TryGetValue(magicId, out var cfg);
            return cfg;
        }

        /// <summary>从 soulBossConfig 文件夹加载所有幻化外观配置（每个文件是 SoulBossConfig 列表）</summary>
        public static List<SoulBossConfig> LoadSoulBossConfigs(string folder)
        {
            var list = new List<SoulBossConfig>();
            if (!Directory.Exists(folder))
            {
                Log.Info($"[ActionsMod] soulBossConfig 目录不存在（可选）: {folder}");
                return list;
            }
            string[] jsonFiles = Directory.GetFiles(folder, "*.json");
            Log.Info($"[ActionsMod] 扫描 soulBossConfig 目录，找到 {jsonFiles.Length} 个配置文件");
            foreach (string filePath in jsonFiles)
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    var configs = JsonConvert.DeserializeObject<List<SoulBossConfig>>(json);
                    if (configs == null)
                    {
                        // 兼容单对象（非数组）写法
                        var single = JsonConvert.DeserializeObject<SoulBossConfig>(json);
                        if (single != null) configs = new List<SoulBossConfig> { single };
                    }
                    if (configs != null) list.AddRange(configs);
                }
                catch (Exception e)
                {
                    Log.Error($"[ActionsMod] 加载 soulBossConfig 失败 {filePath}: {e.Message}");
                }
            }
            return list;
        }

        // ===================== 套用 =====================

        /// <summary>
        /// 根据 soulBossConfig 自定义配置（按 magicID 匹配）构造一个全新的幻化变身配置对象。
        /// 返回的是新建的 UObject 实例，不会污染游戏缓存的资源对象。
        /// </summary>
        public static BGWDataAsset_MagicallyChangeConfig? GetMagicConfig(BGUCharacterCS character, int magicID)
        {
            var model = GetSoulConfig(magicID);
            if (model == null)
            {
                Log.Warn($"[ActionsMod] soulConfigList 中未找到 MagicID={magicID} 的配置");
                return null;
            }
            var BossConf = model.BossConf;
            if (BossConf == null)
            {
                Log.Warn($"[ActionsMod] MagicID={magicID} 的 BossConf 为空");
                return null;
            }

            // 新建配置实例，避免直接修改缓存的资源配置对象
            var config = UObject.NewObject<BGWDataAsset_MagicallyChangeConfig>();
            if (config == null)
            {
                Log.Error($"[ActionsMod] 创建 BGWDataAsset_MagicallyChangeConfig 实例失败 MagicID={magicID}");
                return null;
            }

            var world = character.World;
            string? abpClass = BossConf.ABPClass;
            if (IsValidAssetPath(abpClass))
            {
                config.ABPClass = BGW_PreloadAssetMgr.Get(character).TryGetCachedResourceObj<UClass>(abpClass, ELoadResourceType.SyncLoadAndCache);
            }
            string? skMesh = BossConf.SKMesh;
            if (IsValidAssetPath(skMesh))
            {
                config.SKMesh = UObject.LoadObject<USkeletalMesh>(world, skMesh);
            }
            config.CapsuleRadius = BossConf.CapsuleRadius;
            config.CapsuleHalfHeight = BossConf.CapsuleHalfHeight;
            config.Override_AbnormalDispID_Attacker = BossConf.Override_AbnormalDispID_Attacker;
            config.Override_AbnormalDispID_Victim = BossConf.Override_AbnormalDispID_Victim;
            config.TamerAssetPath = model.TamerPath;

            string? physicsAsset = BossConf.PhysicsAsset;
            if (IsValidAssetPath(physicsAsset))
            {
                config.PhysicsAsset = UObject.LoadObject<UPhysicsAsset>(world, physicsAsset);
            }

            config.TFXConfig.Clear();
            if (BossConf.TFXConfigs != null && BossConf.TFXConfigs.Count > 0)
            {
                for (int i = 0; i < BossConf.TFXConfigs.Count; i++)
                {
                    var item = default(FMagicallyChangeConfig_TFXConfig);
                    if (IsValidAssetPath(BossConf.TFXConfigs[i].TFXAsset))
                    {
                        item.TFXAsset = UObject.LoadObject<UTressFXAsset>(world, BossConf.TFXConfigs[i].TFXAsset);
                    }
                    item.ShadeSettings = default(FTressFXShadeSettings);
                    var shade = BossConf.TFXConfigs[i].ShadeSettings;
                    if (shade != null)
                    {
                        item.ShadeSettings.FiberRadius = shade.FiberRadius;
                        item.ShadeSettings.FiberSpacing = shade.FiberSpacing;
                        item.ShadeSettings.HairThickness = shade.HairThickness;
                        item.ShadeSettings.RootTangentBlending = shade.RootTangentBlending;
                        item.ShadeSettings.ShadowThickness = shade.ShadowThickness;
                    }
                    item.LodScreenSize = BossConf.TFXConfigs[i].LodScreenSize;
                    item.bEnableSimulation = BossConf.TFXConfigs[i].EnableSimulation;
                    if (IsValidAssetPath(BossConf.TFXConfigs[i].HairMaterial))
                    {
                        item.HairMaterial = UObject.LoadObject<UMaterialInterface>(world, BossConf.TFXConfigs[i].HairMaterial);
                    }
                    config.TFXConfig.Add(item);
                }
            }
            else
            {
                // BossConf 未显式配置 TFXConfigs 时，自动提取 boss 的 TressFX 毛发。
                TryAutoFillTFX(world, config, model.TamerPath);
            }

            config.InteractBones.Clear();
            if (BossConf.InteractBones != null && BossConf.InteractBones.Count > 0)
            {
                for (int i = 0; i < BossConf.InteractBones.Count; i++)
                {
                    var item = default(FBoneUseForDispMap);
                    item.FirstRadius = BossConf.InteractBones[i].FirstRadius;
                    item.NextRadius = BossConf.InteractBones[i].NextRadius;
                    item.FirstBoneName = new FName(BossConf.InteractBones[i].FirstBoneName ?? "None");
                    item.NextBoneName = new FName(BossConf.InteractBones[i].NextBoneName ?? "None");
                    config.InteractBones.Add(item);
                }
            }

            config.Materials.Clear();
            config.Weapons.Clear();
            if (BossConf.Weapons != null && BossConf.Weapons.Count > 0)
            {
                for (int i = 0; i < BossConf.Weapons.Count; i++)
                {
                    var item = BossConf.Weapons[i];
                    var weapon = default(FUnitWeapon);
                    if (IsValidAssetPath(item.Weapon))
                    {
                        weapon.Weapon = UObject.LoadClass<AActor>(world, item.Weapon);
                    }
                    weapon.SocketName = new FName(item.SocketName ?? "None");
                    config.Weapons.Add(weapon);
                }
            }
            if (BossConf.UnitScale > 0 && BossConf.UnitScale != 1)
            {
                config.UnitScale = (float)BossConf.UnitScale;
            }
            else
            {
                config.UnitScale = 1.0f;
            }

            return config;
        }

        /// <summary>恢复上一轮被本系统隐藏的玩家部件（变回原角色或切换到无 HideMeshKeywords 的形态时调用）</summary>
        public static void RestoreMagicHidden()
        {
            try
            {
                foreach (var c in _magicHiddenMeshes)
                {
                    if (!c.IsNullOrDestroyed())
                        c.SetHiddenInGame(false, false);
                }
            }
            catch { }
            _magicHiddenMeshes.Clear();
        }

        /// <summary>
        /// 幻化套用后，按 soulBossConfig 的 HideMeshKeywords 隐藏角色身上匹配的玩家装备 mesh 组件，
        /// 让 boss 自带的头/身体外观露出来（解决残躯被玩家头盖住导致秃头等问题）。
        /// 调用前会先恢复上一轮隐藏的部件，避免跨形态残留。
        /// </summary>
        public static void ApplyMagicHideMeshes(BGUPlayerCharacterCS character, SoulBossConfig? soulConfig)
        {
            // 先恢复上一轮隐藏的（跨形态不残留）
            RestoreMagicHidden();
            var kws = soulConfig?.BossConf?.HideMeshKeywords;
            if (kws == null || kws.Count == 0) return;
            try
            {
                int cnt = 0;
                foreach (var c in character.GetComponentsByClass((TSubclassOf<UActorComponent>)UClass.GetClass<USkeletalMeshComponent>()))
                {
                    if (c is USkeletalMeshComponent smc && smc.SkeletalMesh != null)
                    {
                        string path = smc.SkeletalMesh.GetPathName();
                        foreach (var kw in kws)
                        {
                            if (!string.IsNullOrEmpty(kw) && path.IndexOf(kw, StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                smc.SetHiddenInGame(true, false);
                                _magicHiddenMeshes.Add(smc);
                                cnt++;
                                break;
                            }
                        }
                    }
                }
                foreach (var c in character.GetComponentsByClass((TSubclassOf<UActorComponent>)UClass.GetClass<UStaticMeshComponent>()))
                {
                    if (c is UStaticMeshComponent smc && smc.StaticMesh != null)
                    {
                        string path = smc.StaticMesh.GetPathName();
                        foreach (var kw in kws)
                        {
                            if (!string.IsNullOrEmpty(kw) && path.IndexOf(kw, StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                smc.SetHiddenInGame(true, false);
                                _magicHiddenMeshes.Add(smc);
                                cnt++;
                                break;
                            }
                        }
                    }
                }
                Log.Info($"[ActionsMod] 幻化隐藏玩家部件 {cnt} 个 (keywords={string.Join(",", kws)})");
            }
            catch (Exception e) { Log.Warn($"[ActionsMod] 幻化隐藏部件异常: {e.Message}"); }
        }

        // BossConf 未配置 TFXConfigs 时，自动提取 boss 的 TressFX 毛发配置（按单位路径缓存，只提取一次）。
        private sealed class BossTfxEntry
        {
            public string AssetPath = string.Empty;
            public string? HairMatPath;
            public FTressFXShadeSettings ShadeSettings;
            public float LodScreenSize;
            public bool bEnableSimulation;
        }
        private static readonly Dictionary<string, List<BossTfxEntry>> _bossTfxCache = new Dictionary<string, List<BossTfxEntry>>();

        private static void TryAutoFillTFX(UWorld world, BGWDataAsset_MagicallyChangeConfig config, string? unitPath)
        {
            if (config == null || string.IsNullOrEmpty(unitPath)) return;
            try
            {
                if (!_bossTfxCache.TryGetValue(unitPath!, out var cached))
                {
                    cached = ExtractBossTFX(world, unitPath!);
                    // 只缓存"成功"结果：失败时若把空列表写进缓存，后续每次变身都会直接命中 0 个（毒缓存）→ 永远秃头
                    if (cached.Count > 0) _bossTfxCache[unitPath!] = cached;
                }

                int n = 0;
                foreach (var e in cached)
                {
                    var item = default(FMagicallyChangeConfig_TFXConfig);
                    item.TFXAsset = UObject.LoadObject<UTressFXAsset>(world, e.AssetPath);
                    if (IsValidAssetPath(e.HairMatPath))
                        item.HairMaterial = UObject.LoadObject<UMaterialInterface>(world, e.HairMatPath);
                    item.ShadeSettings = e.ShadeSettings;
                    item.LodScreenSize = e.LodScreenSize;
                    item.bEnableSimulation = e.bEnableSimulation;
                    config.TFXConfig.Add(item);
                    n++;
                }

                if (n == 0)
                {
                    Log.Warn($"[ActionsMod] TFX 自动提取拿到 0 个 TressFX。" +
                             $"若变身仍秃头，说明该单位毛发可能是独立骨骼网格而非 TFX——请改用挂 mesh 方案。");
                }
                else
                {
                    Log.Info($"[ActionsMod] TFX 自动提取完成：{n} 个 (单位={unitPath})");
                }
            }
            catch (Exception e) { Log.Warn($"[ActionsMod] TFX 自动提取异常: {e.Message}"); }
        }

        /// <summary>真正提取 boss 的 TressFX 配置：先 CDO，失败则生成实例读组件。</summary>
        private static List<BossTfxEntry> ExtractBossTFX(UWorld world, string unitPath)
        {
            var result = new List<BossTfxEntry>();
            var unitCls = UObject.LoadClass<AActor>(world, unitPath);
            if (unitCls == null) { Log.Warn($"[ActionsMod] 提取毛发失败：单位类加载失败 {unitPath}"); return result; }

            // 1) CDO 尝试（瞬时，不生成实体；打包版通常拿不到）
            try
            {
                string monsterPath = (unitCls.GetDefaultObject() as BUTamerActor)?.MonsterClassPath ?? string.Empty;
                var monsterCls = !string.IsNullOrEmpty(monsterPath)
                    ? UObject.LoadClass<AActor>(world, monsterPath)
                    : unitCls;
                var cdo = monsterCls?.GetDefaultObject() as BGUCharacterCS;
                if (cdo != null)
                {
                    CollectTfx(cdo, result, "[CDO]");
                    if (result.Count > 0) return result;
                }
            }
            catch (Exception e) { Log.Warn($"[ActionsMod] CDO 提取失败，转实例: {e.Message}"); }

            // 2) 生成实例（打包版 CDO 无 OwnedComponents，必须生成实体读真实组件）
            var pc = ModHelper.GetCharacter();
            var loc = pc != null ? pc.GetActorLocation() + pc.GetActorForwardVector() * 50f : FVector.ZeroVector;
            var rot = pc != null ? pc.GetActorRotation() : FRotator.ZeroRotator;
            var boss = BGUFunctionLibraryCS.BGUSpawnActor(world, unitCls, loc, rot);
            if (boss == null) { Log.Warn($"[ActionsMod] 提取毛发失败：生成 {unitPath} 失败"); return result; }
            try
            {
                CollectTfx(boss, result, "[实例]");
                // 额外骨骼网格（排查"毛发是独立 mesh"的情况）
                var mainMesh = (boss as BGUCharacterCS)?.Mesh;
                foreach (var c in boss.GetComponentsByClass((TSubclassOf<UActorComponent>)UClass.GetClass<USkeletalMeshComponent>()))
                {
                    if (c is USkeletalMeshComponent smc && smc.SkeletalMesh != null && smc != mainMesh)
                        Log.Info($"[ActionsMod] boss 额外骨骼网格(可能是毛发/部件): {smc.SkeletalMesh.GetPathName()}");
                }
            }
            finally
            {
                boss.DestroyActor();
            }
            return result;
        }

        /// <summary>从 actor 收集所有带 Asset 的 TressFX 组件，写入 result（只存路径，不存 UObject）。</summary>
        private static void CollectTfx(AActor actor, List<BossTfxEntry> result, string tag)
        {
            foreach (var c in actor.GetComponentsByClass((TSubclassOf<UActorComponent>)UClass.GetClass<UTressFXComponent>()))
            {
                if (c is UTressFXComponent tfx && tfx.Asset != null)
                {
                    result.Add(new BossTfxEntry
                    {
                        AssetPath = tfx.Asset.GetPathName(),
                        HairMatPath = tfx.HairMaterial?.GetPathName(),
                        ShadeSettings = tfx.ShadeSettings,
                        LodScreenSize = tfx.LodScreenSize,
                        bEnableSimulation = tfx.EnableSimulation,
                    });
                    Log.Info($"[ActionsMod] 提取到 boss 毛发[{result.Count - 1}] {tag} Asset={tfx.Asset.GetPathName()} HairMaterial={tfx.HairMaterial?.GetPathName() ?? "<null>"} Lod={tfx.LodScreenSize}");
                }
            }
        }
    }
}
