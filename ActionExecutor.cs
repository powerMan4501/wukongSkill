using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using b1;
using b1.BGW;
using b1.Plugins.TressFX;
using BtlB1;
using BtlShare;
using CSharpModBase;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace MagicMod
{
    /// <summary>
    /// 动作执行器：根据 ActionType 分发并执行不同的自定义事件
    /// </summary>
    public static class ActionExecutor
    {


        private static readonly object _typeLock = new object();

        // 记录 Skill 和 Magic 动作的上次执行时间，用于节流控制
        private static readonly Dictionary<ActionType, long> _lastExecuteTime = new Dictionary<ActionType, long>();
        private const long ThrottleIntervalMs = 300; // 0.3秒节流间隔

        /// <summary>
        /// 递归深度闸门：DoActions 执行的动作（Skill / Magic / bullet / Trans 等）会再次触发游戏事件
        /// （SweepCheckBegin / OnTriggerSkillEffect / OnRequestSmartCastSkill / OnNotifyStateSpawnProjectileObj），
        /// 而这些事件又会回到 DoActions。配置一旦成环（典型如夜叉王 440506020：Montage_SetPosition
        /// 把动画拉回 2.3s 重放 → 再次触发同一效果），就是无界递归。
        /// 这里按线程统计嵌套层数，超过上限直接放弃本次执行并打日志，避免卡死/爆栈。
        /// </summary>
        private const int MaxActionDepth = 3;
        private static readonly ThreadLocal<int> _actionDepth = new ThreadLocal<int>(() => 0);

        // 骨骼绑定配置缓存
        private static List<MeshActionConfig> _meshBindings = new List<MeshActionConfig>();

        // SweepCheck 动画绑定配置缓存
        public static List<SweepCheckBindingConfig> _sweepCheckBindings = new List<SweepCheckBindingConfig>();

        // Projectile 生成绑定配置缓存
        private static List<ProjectileBindingConfig> _projectileBindings = new List<ProjectileBindingConfig>();

        // BuffID → 动作列表 绑定配置缓存（BuffBegin 时按 BuffID 触发）
        private static readonly Dictionary<int, IdActionBindingConfig> _buffActionBindings = new Dictionary<int, IdActionBindingConfig>();

        // EffectID → 动作列表 绑定配置缓存（OnTriggerSkillEffect 时按 EffectID 触发）
        private static readonly Dictionary<int, IdActionBindingConfig> _effectActionBindings = new Dictionary<int, IdActionBindingConfig>();

        // MagicID → 幻化变身 Boss 外观自定义配置缓存（从 soulBossConfig 文件夹汇总而来）
        private static readonly Dictionary<int, SoulBossConfig> _soulConfigs = new Dictionary<int, SoulBossConfig>();

        // TransID → 变身（Player Trans）自定义配置缓存（从 transConfig 文件夹汇总而来）
        private static readonly Dictionary<int, TransConfig> _transConfigs = new Dictionary<int, TransConfig>();

        // 已注入游戏 DB 的变身描述 ID，避免重复注入
        private static readonly HashSet<int> _injectedTransIds = new HashSet<int>();

        /// <summary>
        /// 初始化骨骼绑定配置
        /// </summary>
        public static void InitMeshBindings(List<MeshActionConfig> meshBindings)
        {
            _meshBindings = meshBindings ?? new List<MeshActionConfig>();
            Log.Info($"[MagicMod] 初始化骨骼绑定配置，共 {_meshBindings.Count} 个骨骼绑定");
            foreach (var mb in _meshBindings)
            {
                Log.Info($"[MagicMod]   Mesh='{mb.Mesh}' -> {mb.Actions.Count} 个动作");
            }
        }

        /// <summary>
        /// 初始化 SweepCheck 动画绑定配置
        /// </summary>
        public static void InitSweepCheckBindings(List<SweepCheckBindingConfig> bindings)
        {
            _sweepCheckBindings = bindings ?? new List<SweepCheckBindingConfig>();
            Log.Info($"[MagicMod] 初始化 SweepCheck 绑定配置，共 {_sweepCheckBindings.Count} 条规则");
            foreach (var sc in _sweepCheckBindings)
            {
                if (sc.bullet_actions != null && sc.bullet_actions.Count > 0)
                {
                    foreach (var ba in sc.bullet_actions)
                    {
                        Log.Info($"[MagicMod]   Animation='{sc.Animation}' bullet_actions ProjectileID={ba.ID} -> {ba.actions.Count} 个动作");
                    }
                }
                if (sc.sweep_actions != null && sc.sweep_actions.Count > 0)
                {
                    int totalActions = 0;
                    foreach (var g in sc.sweep_actions) totalActions += g.Actions.Count;
                    Log.Info($"[MagicMod]   Animation='{sc.Animation}' (多时间点) -> {sc.sweep_actions.Count} 个时间点组, 共 {totalActions} 个动作");
                    // foreach (var g in sc.sweep_actions)
                    // {
                    //     Log.Info($"[MagicMod]     NotifyBeginTime={g.NotifyBeginTime?.ToString() ?? "null(匹配所有)"} -> {g.Actions.Count} 个动作");
                    // }
                }
                else
                {
                    Log.Info($"[MagicMod]   Animation='{sc.Animation}', MinTime={sc.NotifyBeginTime} -> {sc.Actions.Count} 个动作");
                }
            }

        }

        /// <summary>
        /// 初始化 Projectile 生成绑定配置
        /// </summary>
        public static void InitProjectileBindings(List<ProjectileBindingConfig> bindings)
        {
            _projectileBindings = bindings ?? new List<ProjectileBindingConfig>();
            Log.Info($"[MagicMod] 初始化 Projectile 绑定配置，共 {_projectileBindings.Count} 条规则");
            foreach (var pb in _projectileBindings)
            {
                string scaleDesc = pb.config?.Scale3D != null
                    ? $"({pb.config.Scale3D.X}, {pb.config.Scale3D.Y}, {pb.config.Scale3D.Z})"
                    : "无";
                int buffCount = pb.config?.FieldBuffList?.Count ?? 0;
                Log.Info($"[MagicMod]   PathName='{pb.pathName}' -> Scale3D={scaleDesc}, FieldBuffList={buffCount} 个");
            }
        }

        /// <summary>
        /// 初始化 ID 动作绑定配置（BuffActions / EffectActions），同 ID 后加载的覆盖先加载的
        /// </summary>
        private static void InitIdActionBindings(List<IdActionBindingConfig> bindings, Dictionary<int, IdActionBindingConfig> cache, string tag)
        {
            cache.Clear();
            if (bindings != null)
            {
                foreach (var binding in bindings)
                {
                    if (binding == null || binding.id <= 0) continue;
                    cache[binding.id] = binding;
                }
            }
            Log.Info($"[MagicMod] 初始化 {tag} 绑定配置，共 {cache.Count} 条规则");
            foreach (var kvp in cache)
            {
                Log.Info($"[MagicMod]   {tag} ID={kvp.Key} ({kvp.Value.name ?? "无名称"}) -> {kvp.Value.actions.Count} 个动作");
            }
        }

        /// <summary>
        /// 初始化 Buff 动作绑定配置（BuffBegin 时按 BuffID 触发）
        /// </summary>
        public static void InitBuffActionBindings(List<IdActionBindingConfig> bindings)
        {
            InitIdActionBindings(bindings, _buffActionBindings, "BuffActions");
        }

        /// <summary>
        /// 初始化 Effect 动作绑定配置（OnTriggerSkillEffect 时按 EffectID 触发）
        /// </summary>
        public static void InitEffectActionBindings(List<IdActionBindingConfig> bindings)
        {
            InitIdActionBindings(bindings, _effectActionBindings, "EffectActions");
        }

        /// <summary>
        /// 初始化幻化变身 Boss 外观配置（soulConfigList），同 ID 后加载的覆盖先加载的
        /// </summary>
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
            Log.Info($"[MagicMod] 初始化 soulBossConfig 配置，共 {_soulConfigs.Count} 条规则");
            foreach (var kvp in _soulConfigs)
            {
                Log.Info($"[MagicMod]   SoulConfig ID={kvp.Key} -> BuffId={kvp.Value.BuffId}, TamerPath='{kvp.Value.TamerPath}'");
            }
        }

        /// <summary>
        /// 按 MagicID 查找幻化变身 Boss 外观配置，未命中返回 null（走原有 DAPath 流程）
        /// </summary>
        public static SoulBossConfig? GetSoulConfig(int magicId)
        {
            if (magicId <= 0) return null;
            _soulConfigs.TryGetValue(magicId, out var cfg);
            return cfg;
        }

        /// <summary>
        /// 初始化变身（Player Trans）自定义配置（transConfigList），同 ID 后加载的覆盖先加载的
        /// </summary>
        public static void InitTransConfigs(List<TransConfig> configs)
        {
            _transConfigs.Clear();
            _injectedTransIds.Clear();
            if (configs != null)
            {
                foreach (var cfg in configs)
                {
                    if (cfg == null || cfg.ID <= 0) continue;
                    // 原生变身模式需要 BPPath；傀儡附身模式(UseTamerPossess)则用 PossessAssetPath/TamerPath，不依赖 BPPath
                    bool hasNativePath = !string.IsNullOrEmpty(cfg.BPPath);
                    bool hasPossessPath = cfg.UseTamerPossess
                        && (!string.IsNullOrEmpty(cfg.PossessAssetPath) || !string.IsNullOrEmpty(cfg.TamerPath));
                    if (!hasNativePath && !hasPossessPath)
                    {
                        Log.Warn($"[MagicMod]   跳过无效 TransConfig ID={cfg.ID} ({cfg.name ?? "无名称"})：缺少 BPPath（原生变身）或 PossessAssetPath/TamerPath（傀儡附身）");
                        continue;
                    }
                    _transConfigs[cfg.ID] = cfg;
                }
            }
            Log.Info($"[MagicMod] 初始化 transConfig 变身配置，共 {_transConfigs.Count} 条规则");
            foreach (var kvp in _transConfigs)
            {
                string asset = !string.IsNullOrEmpty(kvp.Value.BPPath) ? kvp.Value.BPPath
                    : (!string.IsNullOrEmpty(kvp.Value.PossessAssetPath) ? kvp.Value.PossessAssetPath! : (kvp.Value.TamerPath ?? ""));
                Log.Info($"[MagicMod]   TransConfig ID={kvp.Key} ({kvp.Value.name ?? "无名称"}) [{(kvp.Value.UseTamerPossess ? "傀儡附身" : "原生变身")}] -> Asset='{asset}'");
            }
        }

        /// <summary>
        /// 按 TransID 查找变身配置，未命中返回 null（走原有 ResID 变身流程）
        /// </summary>
        public static TransConfig? GetTransConfig(int transId)
        {
            
            if (transId <= 0) return null;
            _transConfigs.TryGetValue(transId, out var cfg);
            return cfg;
        }

        /// <summary>
        /// 枚举全部 transConfig 变身配置（供画板“变身”分类展示）
        /// </summary>
        public static IEnumerable<TransConfig> GetAllTransConfigs()
        {
            return _transConfigs.Values;
        }

        /// <summary>
        /// 按 TransID 触发一次变身，复用 DoTransAction 完整流程（先注入变身描述再变身）。
        /// 供画板“变身”分类按钮直接调用。
        /// </summary>
        public static void DoTransById(int transId)
        {
            var character = ModHelper.GetCharacter();
            if (character == null)
            {
                Log.Warn($"[MagicMod] 画板变身失败：未找到玩家角色 TransID={transId}");
                return;
            }
            DoTransAction(character, new ActionConfig { Type = ActionType.Trans, Value = transId });
        }

        /// <summary>
        /// 将 transConfig 转换为 FUStUnitTransCommDesc 并注入游戏配表（活引用字典），
        /// 使 BGW_GameDB.GetUnitTransCommDesc(ID) 能取到自定义变身描述。
        /// </summary>
        public static bool InjectUnitTransDesc(TransConfig cfg)
        {
            if (cfg == null || cfg.ID <= 0 || string.IsNullOrEmpty(cfg.BPPath)) return false;
            try
            {
                var desc = new FUStUnitTransCommDesc
                {
                    ID = cfg.ID,
                    BPPath = cfg.BPPath,
                    TamerPath = cfg.TamerPath ?? "",
                    IsInheritBuffInSpawnNew = (EGSYesNo)(cfg.IsInheritBuffInSpawnNew ?? 1),
                    UnitBornSkillID = cfg.UnitBornSkillID ?? 0,
                    NewUnitBornSkillID = cfg.NewUnitBornSkillID ?? 0,
                    UnitSpawnScale = cfg.UnitSpawnScale ?? 0f,
                    NewUnitSpawnScale = cfg.NewUnitSpawnScale ?? 0f,
                    IsUseEQS = (EGSYesNo)(cfg.IsUseEQS ?? 0),
                    UnitSpawnLocationOffset = cfg.UnitSpawnLocationOffset ?? "",
                    NewUnitSpawnLocationOffset = cfg.NewUnitSpawnLocationOffset ?? "",
                    PossessBlendTime = cfg.PossessBlendTime ?? 0f,
                    PossessBlendFunc = cfg.PossessBlendFunc ?? 0,
                    PossessBlendExp = cfg.PossessBlendExp ?? 0f,
                };

                // GetAllUnitTransCommDesc 返回的是配表内部活引用字典，直接写入即可被 FindByID 读到
                var all = BGW_GameDB.GetAllUnitTransCommDesc();
                if (all == null)
                {
                    Log.Error($"[MagicMod] 获取 UnitTransCommDesc 字典失败 TransID={cfg.ID}");
                    return false;
                }
                all[cfg.ID] = desc;

                bool ok = BGW_GameDB.GetUnitTransCommDesc(cfg.ID) != null;
                if (ok) _injectedTransIds.Add(cfg.ID);
                Log.Info($"[MagicMod] 注入变身描述 TransID={cfg.ID} BPPath='{cfg.BPPath}' 结果={(ok ? "成功" : "失败")}");
                return ok;
            }
            catch (Exception e)
            {
                Log.Error($"[MagicMod] 注入变身描述失败 TransID={cfg.ID}: {e.Message}");
                return false;
            }
        }

        /// <summary>
        /// 确保指定 TransID 的变身描述已注入（幂等，只注入一次）
        /// </summary>
        public static bool EnsureTransDescInjected(int transId)
        {
            var cfg = GetTransConfig(transId);
            if (cfg == null) return false;
            if (_injectedTransIds.Contains(transId) && BGW_GameDB.GetUnitTransCommDesc(transId) != null)
                return true;
            bool ok = InjectUnitTransDesc(cfg);
            // 变身描述注入成功后，按需注入玩家变身单位配置（法术槽/变回技能等）
            if (ok) InjectPlayerTransUnitConfDesc(cfg);
            return ok;
        }

        /// <summary>
        /// 判断 transConfig 是否配置了 FUStPlayerTransUnitConfDesc 相关内容（决定是否注入该表）
        /// </summary>
        private static bool HasPlayerTransUnitConf(TransConfig cfg)
        {
            return (cfg.MagicSkillList != null && cfg.MagicSkillList.Count > 0)
                || (cfg.TransBackSkillId ?? 0) > 0
                || (cfg.DrinkSkillId ?? 0) > 0
                || (cfg.TransBackBeHit ?? 0) > 0
                || (cfg.ReSetTransId ?? 0) > 0
                || (cfg.DeadDontTransback ?? 0) > 0
                || (cfg.ReadArchiveTrans ?? 0) > 0
                || (cfg.ShowSettingUiOnly ?? 0) > 0
                || (cfg.TransType ?? 0) > 0;
        }

        /// <summary>
        /// 将 SpellType 字符串（名称或整数）解析为 SpellType 枚举
        /// </summary>
        private static SpellType ParseSpellType(string s)
        {
            if (string.IsNullOrEmpty(s)) return SpellType.Min;
            if (int.TryParse(s.Trim(), out int v)) return (SpellType)v;
            if (Enum.TryParse<SpellType>(s.Trim(), true, out var st)) return st;
            Log.Warn($"[MagicMod] 无法解析 SpellType='{s}'，回退为 Min");
            return SpellType.Min;
        }

        /// <summary>
        /// 将 transConfig 转换为 FUStPlayerTransUnitConfDesc 并注入游戏配表（键 = ID*100）。
        /// 决定变身后的法术槽、主动变回技能、喝药技能等。仅在配置了相关内容时注入；
        /// 未配置时返回 false，游戏会自然回退到玩家自己的法术配置。
        /// </summary>
        public static bool InjectPlayerTransUnitConfDesc(TransConfig cfg)
        {
            if (cfg == null || cfg.ID <= 0) return false;
            if (!HasPlayerTransUnitConf(cfg)) return false;
            try
            {
                var desc = new FUStPlayerTransUnitConfDesc
                {
                    ID = cfg.ID * 100,
                    TransBackSkillId = cfg.TransBackSkillId ?? 0,
                    DrinkSkillId = cfg.DrinkSkillId ?? 0,
                    TransBackBeHit = cfg.TransBackBeHit ?? 0,
                    ReSetTransId = cfg.ReSetTransId ?? 0,
                    DeadDontTransback = cfg.DeadDontTransback ?? 0,
                    ReadArchiveTrans = cfg.ReadArchiveTrans ?? 0,
                    ShowSettingUiOnly = cfg.ShowSettingUiOnly ?? 0,
                    TransType = (EPlayerTransType)(cfg.TransType ?? 0),
                };
                if (cfg.MagicSkillList != null)
                {
                    foreach (var m in cfg.MagicSkillList)
                    {
                        if (m == null) continue;
                        desc.MagicSkillInfoList.Add(new FUStMagicConfInfo
                        {
                            Type = ParseSpellType(m.Type),
                            SpellID = m.SpellID,
                        });
                    }
                }

                // GetTBFUStPlayerTransUnitConfDesc 返回配表内部活引用字典，直接写入即可被 FindByID 读到
                var all = GameDBRuntime.GetTBFUStPlayerTransUnitConfDesc();
                if (all == null)
                {
                    Log.Error($"[MagicMod] 获取 PlayerTransUnitConfDesc 字典失败 TransID={cfg.ID}");
                    return false;
                }
                all[cfg.ID * 100] = desc;

                bool ok = BGW_GameDB.GetFUStPlayerTransUnitConfDesc(cfg.ID) != null;
                Log.Info($"[MagicMod] 注入玩家变身单位配置 TransID={cfg.ID} Key={cfg.ID * 100} 法术数={desc.MagicSkillInfoList.Count} TransBackSkillId={desc.TransBackSkillId} 结果={(ok ? "成功" : "失败")}");
                return ok;
            }
            catch (Exception e)
            {
                Log.Error($"[MagicMod] 注入玩家变身单位配置失败 TransID={cfg.ID}: {e.Message}");
                return false;
            }
        }

        /// <summary>
        /// 按 ID 查找绑定并执行动作（供 BuffBegin / OnTriggerSkillEffect 复用）
        /// </summary>
        private static void DoIdActions(BGUPlayerCharacterCS character, int id, Dictionary<int, IdActionBindingConfig> cache, string tag, FEffectInstReq? effectInstReq)
        {
            if (character == null || id <= 0 || cache == null || cache.Count == 0) return;
            if (!cache.TryGetValue(id, out var binding) || binding.actions == null || binding.actions.Count == 0) return;

            Log.Info($"[MagicMod] {tag} 匹配 ID={id} ({binding.name ?? "无名称"})，执行 {binding.actions.Count} 个动作");
            DoActions(character, binding.actions, effectInstReq);
        }

        /// <summary>
        /// Buff 添加时按 BuffID 匹配并执行配置动作
        /// </summary>
        public static void DoBuffBeginActions(BGUPlayerCharacterCS character, int buffId)
        {
            DoIdActions(character, buffId, _buffActionBindings, "BuffActions", null);
        }

        /// <summary>
        /// 技能效果触发时按 EffectID 匹配并执行配置动作
        /// </summary>
        public static void DoSkillEffectActions(BGUPlayerCharacterCS character, int effectId, FEffectInstReq effectInstReq)
        {
            DoIdActions(character, effectId, _effectActionBindings, "EffectActions", effectInstReq);
        }

        /// <summary>
        /// 子弹/法术场 Actor 生成时，按 PathName 匹配 Projectile 绑定并应用覆盖（缩放 + 法术场 Buff）
        /// 首次匹配后停止（与原 else-if 链行为一致）
        /// </summary>
        public static void ApplyProjectileBindings(AActor ower)
        {
            if (ower == null || _projectileBindings == null || _projectileBindings.Count == 0) return;
            string pathName = ower.PathName;
            if (string.IsNullOrEmpty(pathName)) return;

            foreach (var binding in _projectileBindings)
            {
                if (string.IsNullOrEmpty(binding.pathName) || binding.config == null) continue;
                if (pathName.IndexOf(binding.pathName, StringComparison.OrdinalIgnoreCase) < 0) continue;

                Log.Info($"[MagicMod] Projectile 匹配 PathName='{binding.pathName}', Actor='{pathName}'");

                if (binding.config.Scale3D != null)
                {
                    ower.SetActorRelativeScale3D(new FVector(
                        binding.config.Scale3D.X,
                        binding.config.Scale3D.Y,
                        binding.config.Scale3D.Z));
                }

                if (binding.config.FieldBuffList != null && binding.config.FieldBuffList.Count > 0)
                {
                    BUC_MFOverlapData mfOverlapData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_MFOverlapData>(ower);
                    if (mfOverlapData != null)
                    {
                        foreach (int buffId in binding.config.FieldBuffList)
                        {
                            if (!mfOverlapData.FieldBuffList.Any(buff =>
                                buff.BuffID == buffId &&
                                buff.TargetTeamFilter == 4 &&
                                buff.TargetTypeFilter == 1))
                            {
                                mfOverlapData.FieldBuffList.Add(new FFieldBuffInfo
                                {
                                    BuffID = buffId,
                                    bIgnoreTypeFilter = false,
                                    TargetTeamFilter = 4,  // 4表示敌人
                                    TargetTypeFilter = 1   // 1表示角色
                                });
                                Log.Info($"[MagicMod] 法术场追加 FieldBuff ID={buffId}");
                            }
                        }
                    }
                    else
                    {
                        Log.Warn($"[MagicMod] Actor 无 BUC_MFOverlapData，跳过 FieldBuffList: {pathName}");
                    }
                }

                break; // 首次匹配后停止
            }
        }

        /// <summary>
        /// 子弹生成事件时按动画路径 + ProjectileID 匹配 bullet_actions 并执行动作（匹配所有命中的组）
        /// </summary>
        public static void DoBulletSpawnActions(BGUPlayerCharacterCS character, string animationPath, int projectileId)
        {
            if (character == null || _sweepCheckBindings == null || _sweepCheckBindings.Count == 0) return;
            if (string.IsNullOrEmpty(animationPath) || projectileId <= 0) return;

            foreach (var binding in _sweepCheckBindings)
            {
                if (string.IsNullOrEmpty(binding.Animation)) continue;
                if (binding.bullet_actions == null || binding.bullet_actions.Count == 0) continue;
                if (animationPath.IndexOf(binding.Animation, StringComparison.OrdinalIgnoreCase) < 0) continue;

                foreach (var group in binding.bullet_actions)
                {
                    if (group == null || group.ID != projectileId) continue;
                    if (group.actions == null || group.actions.Count == 0) continue;

                    Log.Info($"[MagicMod] BulletSpawn 匹配 Animation='{binding.Animation}', ProjectileID={projectileId}，执行 {group.actions.Count} 个动作");
                    DoActions(character, group.actions);
                }
            }
        }

        /// <summary>
        /// 根据技能 TemplatePath 匹配并执行 cast_actions（复用 SweepCheck 配置，通过 Animation 关键字匹配）
        /// </summary>
        public static void DoCastActions(BGUPlayerCharacterCS character, string templatePath)
        {
            if (character == null || _sweepCheckBindings == null || _sweepCheckBindings.Count == 0) return;
            if (string.IsNullOrEmpty(templatePath)) return;

            foreach (var binding in _sweepCheckBindings)
            {
                if (string.IsNullOrEmpty(binding.Animation)) continue;
                if (binding.cast_actions == null || binding.cast_actions.Count == 0) continue;
                if (templatePath.IndexOf(binding.Animation, StringComparison.OrdinalIgnoreCase) < 0) continue;

                Log.Info($"[MagicMod] CastSkill 匹配 Animation='{binding.Animation}', TemplatePath='{templatePath}'，执行 {binding.cast_actions.Count} 个 cast_actions");
                DoActions(character, binding.cast_actions);
            }
        }

        /// <summary>
        /// 根据动画路径和时间戳匹配 SweepCheck 绑定并执行动作
        /// 支持两种格式：
        ///   新格式：sweep_actions 数组，每个元素含独立 NotifyBeginTime + Actions（匹配所有命中的组）
        ///   旧格式：顶层 NotifyBeginTime + Actions（首次匹配后停止）
        /// </summary>
        public static void DoSweepCheckActions(BGUPlayerCharacterCS character, string animationPath, float notifyBeginTime)
        {
            if (character == null || _sweepCheckBindings == null || _sweepCheckBindings.Count == 0) return;
            if (string.IsNullOrEmpty(animationPath)) return;

            foreach (var binding in _sweepCheckBindings)
            {
                if (string.IsNullOrEmpty(binding.Animation)) continue;
                if (animationPath.IndexOf(binding.Animation, StringComparison.OrdinalIgnoreCase) < 0) continue;

                // 新格式：sweep_actions 数组，每个元素有独立的 NotifyBeginTime
                if (binding.sweep_actions != null && binding.sweep_actions.Count > 0)
                {
                    foreach (var group in binding.sweep_actions)
                    {
                        // NotifyBeginTime 为 null 表示匹配所有时间
                        if (group.NotifyBeginTime.HasValue && notifyBeginTime.ToString() != group.NotifyBeginTime.Value.ToString()) continue;

                        Log.Info($"[MagicMod] SweepCheck 匹配 Animation='{binding.Animation}', Time={notifyBeginTime}, Group.NotifyBeginTime={group.NotifyBeginTime?.ToString() ?? "null"}，执行 {group.Actions.Count} 个动作");
                        DoActions(character, group.Actions);
                    }
                    continue; // 新格式已处理，跳过旧格式逻辑
                }

                // 旧格式：顶层 NotifyBeginTime + Actions
                if (binding.NotifyBeginTime.HasValue && notifyBeginTime.ToString() != binding.NotifyBeginTime.Value.ToString()) continue;

                Log.Info($"[MagicMod] SweepCheck 匹配 Animation='{binding.Animation}', Time={notifyBeginTime}，执行 {binding.Actions.Count} 个动作");
                DoActions(character, binding.Actions);
                break; // 旧格式首次匹配后停止
            }
        }

        /// <summary>
        /// 根据角色当前 Mesh 查找匹配的骨骼绑定并执行动作
        /// </summary>
        /// <returns>是否找到匹配并执行了动作</returns>
        public static bool DoMeshActions(BGUPlayerCharacterCS character)
        {
            if (character == null || _meshBindings == null || _meshBindings.Count == 0)
                return false;


            string unitName = character.GetName() ?? "";
            if (string.IsNullOrEmpty(unitName))
            {
                return false;
            }
            Log.Info($"[MagicMod] DoMeshActions 当前角色: {unitName}");
            foreach (var meshBinding in _meshBindings)
            {
                if (string.IsNullOrEmpty(meshBinding.unitName) && string.IsNullOrEmpty(meshBinding.Mesh)) continue;

                if (unitName.IndexOf(meshBinding.unitName, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Log.Info($"[MagicMod] 匹配骨骼绑定 Mesh='{meshBinding.Mesh}'，执行 {meshBinding.Actions.Count} 个动作");

                    DoActions(character, meshBinding.Actions);
                    return true;
                }
            }
            return false;
        }
        /**
15001

*/
        // TalentID -> 元素类型 映射表，用于 O(1) 查找当前角色元素属性
        private static readonly Dictionary<int, string> _talentElementMap = new Dictionary<int, string>
        {

            { 106039, "bullet_fire" }, // 满堂红
            { 106022, "bullet_ice" }, // 辟水珠
            { 106015, "bullet_poison" }, // 三清令
            { 106028, "bullet_thunder" }, // 博山炉


            // 火
            { 105002, "bullet_fire" }, // 金箍棒
            { 105011, "bullet_fire" }, // 业火棍
            { 105016, "bullet_fire" }, // 混铁棍
            { 105022, "bullet_fire" }, // 兽棍·诸相

        
            // 冰
            { 105101, "bullet_ice" }, // 三尖两刃枪
            { 105102, "bullet_ice" }, // 楮白枪
            // 毒
            { 105004, "bullet_poison" }, // 兽棍·熊罴
            { 105006, "bullet_poison" }, // 几丁棍
            { 105007, "bullet_poison" }, // 昆棍·百眼
            { 105008, "bullet_poison" }, // 出云棍
            { 105009, "bullet_poison" }, // 兽棍·貂鼠
            { 105012, "bullet_poison" }, // 狼牙棒
            { 105013, "bullet_poison" }, // 昆棍·蛛仙
            { 105018, "bullet_poison" }, // 昆棍·通天
            { 105019, "bullet_poison" }, // 兽棍·金睛
            { 105020, "bullet_poison" }, // 磬槌
            // 雷
            { 105003, "bullet_thunder" }, // 鳞棍·双蛇
            { 105014, "bullet_thunder" }, // 鳞棍·亢金
            { 105015, "bullet_thunder" }, // 飞龙宝杖
            { 105017, "bullet_thunder" }, // 天龙棍
        };

        /// <summary>
        /// 获取当前角色的元素属性（通过天赋ID映射表一次遍历即可确定）
        ///
        /// 带短窗口缓存：一次挥棍里 4 个 cast_actions 会各判一次条件，
        /// 每次都整表遍历（约 30 次 BGUHasTalentByID）纯属浪费。
        /// 同一角色在极短窗口内复用结果；窗口只覆盖"同一次挥棍"，
        /// 因此换武器/换天赋后仍会立刻重新判定，不会出现元素错乱。
        /// </summary>
        private const int ElemCacheWindowMs = 50;
        private static BGUPlayerCharacterCS _elemCacheChar;
        private static string _elemCacheValue = "";
        private static int _elemCacheMs = 0;

        public static string getCurrentElemt(BGUPlayerCharacterCS character)
        {
            // net472 没有 Environment.TickCount64，用 TickCount（int 毫秒）
            int now = Environment.TickCount;
            if (ReferenceEquals(_elemCacheChar, character)
                && (now - _elemCacheMs) < ElemCacheWindowMs)
            {
                return _elemCacheValue;
            }

            string result = "";
            foreach (var kvp in _talentElementMap)
            {
                if (BGUFunctionLibraryCS.BGUHasTalentByID(character, kvp.Key))
                {
                    result = kvp.Value;
                    break;
                }
            }

            _elemCacheChar = character;
            _elemCacheValue = result;
            _elemCacheMs = now;
            return result;
        }
        public static string getCurrentElemtText()
        {
            var character = ModHelper.GetCharacter();
            if (character == null) return "无";
            switch (getCurrentElemt(character))
            {
                case "bullet_fire":
                    return "火";
                case "bullet_ice":
                    return "冰";
                case "bullet_thunder":
                    return "雷";
                case "bullet_poison":
                    return "毒";
                default:
                    return "无";
            }
        }
        /// <summary>
        /// 校验动作触发条件
        /// </summary>
        private static bool CheckCondition(BGUPlayerCharacterCS character, ConditionConfig condition)
        {
            if (condition == null || string.IsNullOrEmpty(condition.Type))
            {
                return true;
            }

            string[] paramList = condition.Params?.Split(',') ?? [];

            switch (condition.Type)
            {
                case "LastSkillID":
                    int lastSkillId = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ActionRequestData>(character)?.GetLastSkillID() ?? 0;
                    if (ModLog.Verbose) ModLog.Info($"[MagicMod] 检查 LastSkillID: {lastSkillId} 是否在 {condition.Params} 中");

                    foreach (var param in paramList)
                    {
                        if (int.TryParse(param.Trim(), out int skillId) && skillId == lastSkillId)
                        {
                            return true;
                        }
                    }
                    if (ModLog.Verbose) ModLog.Info($"[MagicMod] 检查 LastSkillID: {lastSkillId} 不在 {condition.Params} 中");
                    return false;

                case "hasAnyBuff":
                    foreach (var param in paramList)
                    {
                        int.TryParse(param.Trim(), out int buffId);
                        if (BGUFunctionLibraryCS.BGUHasBuffByID(character, buffId))
                        {
                            if (ModLog.Verbose) ModLog.Info($"[MagicMod] 检查 buffId,有buff: {buffId} ");
                            return true;
                        }
                        else
                        {
                            if (ModLog.Verbose) ModLog.Info($"[MagicMod] 检查 buffId，没有buff: {buffId}");
                        }

                    }
                    return false;


                case "bullet_fire":
                case "bullet_ice":
                case "bullet_thunder":
                case "bullet_poison":
                    return getCurrentElemt(character) == condition.Type;


                case "hasAnyTalent":
                    foreach (var param in paramList)
                    {
                        int.TryParse(param.Trim(), out int TalentID);
                        if (BGUFunctionLibraryCS.BGUHasTalentByID(character, TalentID))
                        {
                            return true;
                        }
                    }
                    return false;

                case "noHasAnyBuff":
                    foreach (var param in paramList)
                    {
                        int.TryParse(param.Trim(), out int buffId);
                        if (BGUFunctionLibraryCS.BGUHasBuffByID(character, buffId))
                        {
                            if (ModLog.Verbose) ModLog.Info($"[MagicMod] 检查 noHasAnyBuff, 存在buff: {buffId}, 条件不满足");
                            return false;
                        }
                        else
                        {
                            if (ModLog.Verbose) ModLog.Info($"[MagicMod] 检查 noHasAnyBuff, 不存在buff: {buffId}");
                        }
                    }
                    if (ModLog.Verbose) ModLog.Info($"[MagicMod] 检查 noHasAnyBuff, 所有buff均不存在, 条件满足");
                    return true;



                default:
                    Log.Warn($"[MagicMod] 未知的 Condition Type: {condition.Type}");
                    return false;
            }
        }

        /// <summary>
        /// 执行一组动作
        /// </summary>
        public static void DoActions(BGUPlayerCharacterCS character, List<ActionConfig> actions, FEffectInstReq? effectInstReq = null)
        {
            if (character == null || actions == null || actions.Count == 0) return;

            // 递归深度闸门：超过上限说明配置成环了，直接放弃本次执行
            if (_actionDepth.Value >= MaxActionDepth)
            {
                Log.Warn($"[MagicMod] DoActions 递归深度达到上限 {MaxActionDepth}，本次忽略（疑似配置成环，请检查 Skill/Magic/bullet 动作是否回指自身）");
                return;
            }

            _actionDepth.Value++;
            try
            {
                HashSet<ActionType> executedTypes = new HashSet<ActionType>();

                // 兜底动作（"default": true）不参与首轮执行
                List<ActionConfig> normalActions = actions.Where(a => a == null || a.Default != true).ToList();
                List<ActionConfig> fallbackActions = actions.Where(a => a != null && a.Default == true).ToList();

                int executed = RunActionList(character, normalActions, executedTypes, effectInstReq);

                // 没有任何一个普通动作执行成功（条件不满足等），且有兜底动作 → 执行兜底
                if (executed == 0 && fallbackActions.Count > 0)
                {
                    Log.Info($"[MagicMod] 无动作满足条件，执行 {fallbackActions.Count} 个兜底动作");
                    RunActionList(character, fallbackActions, executedTypes, effectInstReq);
                }
            }
            finally
            {
                _actionDepth.Value--;
            }
        }

        /// <summary>
        /// 执行一组动作，返回真正执行成功的动作数量。
        /// 延迟动作视为已安排（计入返回数量），避免与兜底动作重复触发。
        /// </summary>
        private static int RunActionList(BGUPlayerCharacterCS character, List<ActionConfig> actions,
            HashSet<ActionType> executedTypes, FEffectInstReq? effectInstReq = null)
        {
            if (character == null || actions == null || actions.Count == 0) return 0;

            int executed = 0;
            foreach (var action in actions)
            {
                if (action == null) continue;
                int delay = (int)action?.Delay;
                if (delay > 0)
                {
                    // 延迟执行，传递 executedTypes 以便在实际执行时进行去重
                    // 显式丢弃 Task（原写法把 ConfigureAwait 的结果直接丢掉，异常无人观测、也无法取消）
                    _ = ExecuteDelayed(character, action, executedTypes, effectInstReq);
                    executed++;
                }
                else
                {
                    // 检查-执行-标记 必须在同一个锁内，防止并发时同类型重复执行
                    lock (_typeLock)
                    {
                        // bullet 类型允许同类型多次执行（每次 ProjectileID 不同）
                        bool needDedup = action.Type != ActionType.bullet;
                        if (needDedup && executedTypes.Contains(action.Type))
                        {
                            Log.Info($"[MagicMod] 跳过重复动作 Type={action.Type}，同类型只执行第一个满足条件的");
                            continue;
                        }
                        if (DoAction(character, action, effectInstReq))
                        {
                            if (needDedup) executedTypes.Add(action.Type);
                            executed++;
                        }
                    }
                }
            }
            return executed;
        }

        /// <summary>
        /// 执行单个动作（根据 ActionType 分发）
        /// </summary>
        /// <returns>是否实际执行了动作（条件满足且角色存活）</returns>
        public static bool DoAction(BGUPlayerCharacterCS character, ActionConfig action, FEffectInstReq? effectInstReq = null)
        {
            if (character == null) return false;
            BUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(character);
            if (readOnlyData != null && readOnlyData.HasState(EBGUUnitState.Dead))
            {
                return false;
            }
            if (action.Condition != null && !CheckCondition(character, action.Condition))
            {
                return false;
            }

            // 重复执行：duration(总时长ms) + interval(间隔ms) → 次数 = duration / interval（至少 1 次）
            if (action.RepeatDuration > 0 && action.RepeatInterval > 0)
            {
                // 注意：JSON 里 Buff 时长 "Duration" 与重复总时长 "duration" 只差大小写，
                // Newtonsoft 大小写不敏感，两者会绑到同一个 RepeatDuration 上
                // （如 actions.json 的 "Duration": 999999 会被当成重复总时长）。
                // 因此这里必须钳制次数与间隔，避免 interval 很小时产生海量循环。
                const int MaxRepeatCount = 512;
                const int MinRepeatIntervalMs = 16; // 约一帧，避免每毫秒级刷爆游戏线程

                int count = Math.Max(1, (int)(action.RepeatDuration / action.RepeatInterval));
                if (count > MaxRepeatCount)
                {
                    Log.Warn($"[MagicMod] 动作 Type={action.Type} 重复次数 {count} 超过上限 {MaxRepeatCount}，已钳制（duration={action.RepeatDuration}, interval={action.RepeatInterval}）");
                    count = MaxRepeatCount;
                }
                if (action.RepeatInterval < MinRepeatIntervalMs)
                {
                    Log.Warn($"[MagicMod] 动作 Type={action.Type} 重复间隔 {action.RepeatInterval}ms 过小，已按 {MinRepeatIntervalMs}ms 处理");
                    count = Math.Min(count, MaxRepeatCount);
                }
                // 第 1 次立即执行（跳过节流，保证请求的次数完整）
                ExecuteActionCore(character, action, effectInstReq, true);
                if (count > 1)
                {
                    // 剩余次数在后台按游戏时间轮询，每 interval 毫秒在游戏线程执行一次
                    _ = Task.Run(async () => await RepeatActionLoop(character, action, effectInstReq, count));
                }
                return true;
            }

            return ExecuteActionCore(character, action, effectInstReq, false);
        }

        /// <summary>
        /// 单个动作的实际执行体（DoAction 与重复执行循环共用）。
        /// skipThrottle=true 时跳过 Skill/Magic 的 0.5 秒节流（用于重复执行，保证请求的次数完整）。
        /// </summary>
        private static bool ExecuteActionCore(BGUPlayerCharacterCS character, ActionConfig action, FEffectInstReq? effectInstReq, bool skipThrottle)
        {
            // 节流控制：Skill 和 Magic 类型动作 0.5秒内最多触发一次
            if (!skipThrottle && (action.Type == ActionType.Skill || action.Type == ActionType.Magic))
            {
                long currentTime = DateTime.UtcNow.Ticks / TimeSpan.TicksPerMillisecond;
                if (_lastExecuteTime.TryGetValue(action.Type, out long lastTime) && (currentTime - lastTime) < ThrottleIntervalMs)
                {
                    Log.Info($"[MagicMod] 动作节流中 Type={action.Type}，距上次执行不足0.5秒");
                    return false;
                }
                _lastExecuteTime[action.Type] = currentTime;
            }

            // 抓投附加配置：本动作触发的那次抓投是否隐藏被抓方（吞入/抱入类投技防穿模）
            if (action.grabConfig != null)
            {
                GrabSyncGuestFix.RequestGrab(action.grabConfig);
            }

            try
            {
                switch (action.Type)
                {
                    case ActionType.Buff:
                        DoBuffAction(character, action);
                        break;
                    case ActionType.setMagicBack:
                        ModHelper.setMagicBack(character, action.Value > 0 ? true : false);
                        break;

                    case ActionType.montage:
                        if (action.path != null)
                        {
                            var uAnimMontage = BGW_PreloadAssetMgr.Get(character).TryGetCachedResourceObj<UAnimMontage>(action.path, ELoadResourceType.SyncLoadAndCache);
                            Log.Info($"[MagicMod] 尝试播放 Montage: {uAnimMontage?.PathName}");
                            if (uAnimMontage != null)
                            {
                                ModUtils.Montage_GetPosition((float)action.Value / 1000, uAnimMontage);
                            }
                        }
                        break;
                    case ActionType.Montage_SetPosition:
                        if (action.Value != null)
                        {
                            ModUtils.Montage_GetPosition((float)action.Value / 1000, null);
                        }
                        break;
                    case ActionType.gian_item:
                        if (action.Values != null && action.Values.Count > 0)
                        {
                            foreach (var item in action.Values)
                            {
                                ModUtils.gain_item(item, item == 1002 ? 100000 : 1);
                            }
                        }
                        break;
                    case ActionType.range_buff:
                        DoRangeBuffAction(character, action);
                        break;

                    case ActionType.summon:
                        ModHelper.SummonReq(action);
                        break;

                    case ActionType.grabscan:
                    {
                        // 1) 给了 path/Values(字符串型)：直接按 Montage 路径查（最快，不用放技能）
                        if (!string.IsNullOrEmpty(action.path))
                        {
                            GrabSyncGuestFix.ScanGrabMontages(new[] { action.path! });
                            break;
                        }
                        if (action.Values != null && action.Values.Count > 0)
                        {
                            GrabSyncGuestFix.ScanGrabSkills(action.Values);
                        }
                        else if (action.Value > 0)
                        {
                            int count = action.Count ?? 1;
                            GrabSyncGuestFix.ScanGrabSkillsInRange((int)action.Value, (int)action.Value + count - 1);
                        }
                        else
                        {
                            Log.Warn("[MagicMod] grabscan 需要 path(Montage路径) / Values(技能ID列表) / Value+Count(区间)");
                        }
                        break;
                    }

                    case ActionType.grab:
                    {
                        string montagePath = action.path ?? string.Empty;
                        if (!string.IsNullOrEmpty(montagePath))
                        {
                            var montage = LoadAsset<UAnimMontage>(montagePath!);
                            if (montage != null)
                            {
                                GrabSyncGuestFix.ScheduleGrab(montage, GrabSyncGuestFix.FindNearestTarget(action.range ?? 2000f));
                            }
                            else
                            {
                                Log.Warn($"[MagicMod] grab Montage 加载失败 path={montagePath}");
                            }
                        }
                        else if (action.Value > 0)
                        {
                            GrabSyncGuestFix.TryCastGrabSkill((int)action.Value, null, action.range ?? 2000f);
                        }
                        else
                        {
                            Log.Warn("[MagicMod] grab 需要 path(Montage路径) 或 Value(技能ID)");
                        }
                        break;
                    }

                    case ActionType.SpawnActor:
                        if (string.IsNullOrEmpty(action.path))
                        {
                            Log.Warn("[MagicMod] SpawnActor 缺少 path");
                            break;
                        }
                        // Value>0 走 GM 生成（Boss），否则按 PrefabricatorAsset 生成普通 actor
                        // SpawnTeamId：>0 时出怪后设置该阵营并登记进两阵营互殴池
                        ModUtils.SpawnActor(action.path!, (action.Value ?? 0) > 0, action.SpawnTeamId ?? 0);
                        break;

                    case ActionType.addallsummonlifetime:
                        BUS_EventCollectionCS.Get(character)?.Evt_AddAllSummonLifeTime.Invoke((float)(action?.SummonAliveTime ?? 100f));
                        break;

                    case ActionType.JingDouYun:
                        if (ModHelper.IsWuKong(character))
                        {
                            ModUtils.JingDouYun();
                        }
                        break;
                    case ActionType.Skill:
                        DoSkillAction(character, action);
                        break;

                    case ActionType.Magic:
                        if (ModHelper.IsWuKong(character))
                        {
                            DoMagicAction(character, action);
                        }
                        break;

                    case ActionType.out_magic:
                        RestoreMagicHidden();
                        ModHelper.magicallyChangeBack();
                        break;

                    case ActionType.change_to_dasheng:
                        ModHelper.change_to_dasheng();
                        break;

                    case ActionType.trans_back:
                        ModHelper.TransBack();
                        break;

                    case ActionType.DumpTrans:
                        Log.Warn("[MagicMod] DumpTrans 已停用（原生变身系统已移除）");
                        break;


                    case ActionType.Trans:
                        // 原生变身状态（单位已换成基底/目标单位，网检查会失败）或确认是悟空时才允许变身
                        if (ModHelper.IsWuKong(character))
                        {
                            DoTransAction(character, action);
                        }
                        else
                        {
                            Log.Warn("[MagicMod] 当前角色不是悟空（可能已在变身状态），忽略 Trans 动作；请先触发 trans_back 变回");
                        }
                        break;

                    case ActionType.UI:
                        var pageUI = new Ui();
                        pageUI.CreateUI();
                        break;
                    case ActionType.BossPanel:
                        BossPanel.OpenPanel();
                        break;
                    case ActionType.Rushskill:
                        ModHelper.ModifyCD(10095, true, -150);
                        ModHelper.doPhantomRushSkill(character, action.RushDir ?? "Forward");

                        break;
                    case ActionType.bullet:
                        if (action?.bulletConfig != null)
                        {
                            if (action.bulletConfig.ProjectileIDs != null && action.bulletConfig.ProjectileIDs.Count > 0)
                            {

                                foreach (var item in action.bulletConfig.ProjectileIDs)
                                {
                                    var config = action.bulletConfig;
                                    config.ProjectileID = item;
                                    config.effectInstReq = effectInstReq;
                                    ModHelper.SpawnProjectile(character, config);
                                }
                            }
                            else
                            {
                                var config = action.bulletConfig;
                                config.effectInstReq = effectInstReq;
                                ModHelper.SpawnProjectile(character, config);

                            }
                        }
                        break;
                    case ActionType.clearInfo:
                        ShowPlayerInfo.ClearAllUI();
                        break;
                    case ActionType.showInfo:
                        ModHelper.RegPlayerTransEvent();
                        ModHelper.RegSweepCheckBeginEvent();
                        LoadDataManager.LoadAllJsonData();
                        if (ShowPlayerInfo.hasValueTextBlock())
                        {
                            ShowPlayerInfo.ClearAllUI();
                        }
                        else
                        {
                            ShowPlayerInfo.InitItems(false);
                            ShowPlayerInfo.StartUpdateTimer();
                        }


                        break;
                    case ActionType.kill:
                        ModUtils.KillMonster();
                        break;
                    case ActionType.AddItem:
                        DoAddItemAction(character, action);
                        break;
                    case ActionType.AddItemRange:
                        DoAddItemRangeAction(character, action);
                        break;
                    case ActionType.LoadData:
                        LoadDataManager.LoadAllJsonData();
                        break;
                    case ActionType.ResetData:
                        LoadDataManager.ResetAllData();
                        break;
                    case ActionType.TeleportTarget:
                        DoTeleportTargetAction(action);
                        break;
                    case ActionType.TeleportTargetToFront:
                        DoTeleportTargetToFrontAction(action);
                        break;
                    case ActionType.CalcAMScale:
                        DoCalcAMScaleAction(action);
                        break;
                    case ActionType.MaterialGlow:
                        {
                            MaterialGlow.Start(character, new MaterialGlowConfig
                            {
                                BoneName = string.IsNullOrEmpty(action.BoneName) ? "weapon_r" : action.BoneName,
                                MatSlot = action.MatSlot ?? "",
                                Color = (action.MatColor != null && action.MatColor.Length >= 3) ? action.MatColor : null,
                                ColorName = action.MatColorName ?? "",
                                Intensity = action.MatIntensity ?? 5f,
                                Mode = string.IsNullOrEmpty(action.MatMode) ? "weaponfx" : action.MatMode,
                                Preset = string.IsNullOrEmpty(action.MatPreset) ? "staff" : action.MatPreset,
                                Scalars = action.MatParams,
                                Vectors = action.MatVectors,
                                KeepAlive = action.MatKeepAlive ?? true,
                                DurationMs = action.Duration ?? 0f,
                            });
                        }
                        break;
                    case ActionType.MaterialGlowStop:
                        MaterialGlow.Stop(character);
                        break;
                    case ActionType.ProbeHair:
                        ProbeHairAssets(character);
                        break;
                    case ActionType.ShowHair:
                        RestoreHairMesh(character, action);
                        break;
                    case ActionType.WeaponScale:
                        WeaponScale.Scale(character, action.WeaponScale, action.WeaponScaleHoldMs ?? 600, action.WeaponScaleRestoreMs ?? 0);
                        break;
                    default:
                        Log.Warn($"[MagicMod] 未知的 ActionType: {action.Type}");
                        break;
                }
            }
            catch (Exception e)
            {
                Log.Error($"[MagicMod] 执行动作失败 Type={action.Type} Value={action.Value}: {e.Message}");
            }
            return true;
        }

        /// <summary>
        /// 重复执行循环：第 1 次已在 DoAction 立即执行，这里从 i=1 开始补齐剩余次数。
        /// 间隔基于游戏世界时间（WaitForGameTime，随时缓/暂停同步），每次在游戏线程执行本动作；
        /// 角色销毁/死亡时 ExecuteActionCore 会自动短路，无需额外停止。
        /// </summary>
        private static async Task RepeatActionLoop(BGUPlayerCharacterCS character, ActionConfig action, FEffectInstReq? effectInstReq, int count)
        {
            // 间隔下限兜底（约一帧）：防止 interval 配得过小导致每毫秒往游戏线程灌一次任务
            float intervalSec = Math.Max(16, action.RepeatInterval ?? 16) / 1000f;
            for (int i = 1; i < count; i++)
            {
                await WaitForGameTime(intervalSec);
                Utils.TryRunOnGameThread(() =>
                {
                    try
                    {
                        ExecuteActionCore(character, action, effectInstReq, true);
                    }
                    catch (Exception ex)
                    {
                        Log.Warn($"[MagicMod] 重复动作执行异常（角色可能已销毁）: {ex.Message}");
                    }
                });
            }
        }

        /// <summary>
        /// 毛发资产探测：排查某 Boss（如大圣残躯）换皮/变身后秃头的原因。
        /// 打印三类信息（日志前缀 [HairProbe]）：
        ///  1) 残躯相关 SKMesh 的材质槽，标注疑似毛发（路径含 hair/mao）的 slot；
        ///  2) 一批候选 TressFX 资产路径是否存在（残躯可能用类似 JSDS_01A_Fur_TFX / MGD_JSDS_Fur_TFX 的命名）；
        ///  3) 当前角色身上的 SkeletalMesh / StaticMesh 部件与 TressFX 组件（换皮后是否还挂着毛/头部件）。
        /// 用法：先变身/换皮成残躯，再按绑定按键触发，把 [HairProbe] 日志发回即可定位修复方向。
        /// </summary>
        private static void ProbeHairAssets(BGUPlayerCharacterCS character)
        {
            var world = ModUtils.GetWorld();
            Log.Info("[HairProbe] ===== 开始毛发资产探测 =====");

            // 1) 残躯相关 SKMesh 的材质槽
            string[] skPaths = {
                "/Game/00MainHZ/Characters/Enemy/MGD/MGD_JSDS/Meshes/SK_mgd_jsds.SK_mgd_jsds",
                "/Game/00MainHZ/Characters/MGD/MGD_JSDS_02/Meshes/SK_mgd_jsds_02.SK_mgd_jsds_02",
            };
            foreach (var p in skPaths)
            {
                var sk = UObject.LoadObject<USkeletalMesh>(world, p);
                if (sk == null || sk.IsNullOrDestroyed())
                {
                    Log.Info($"[HairProbe] SKMesh 加载失败/不存在: {p}");
                    continue;
                }
                Log.Info($"[HairProbe] SKMesh OK: {p}");
                try
                {
                    var mats = sk.GetMaterials();
                    for (int i = 0; i < mats.Count; i++)
                    {
                        var mi = mats[i].MaterialInterface;
                        string mp = (mi != null && !mi.IsNullOrDestroyed()) ? mi.GetPathName() : "<null>";
                        bool isHair = mp.IndexOf("hair", StringComparison.OrdinalIgnoreCase) >= 0
                                   || mp.IndexOf("mao", StringComparison.OrdinalIgnoreCase) >= 0
                                   || mp.IndexOf("fur", StringComparison.OrdinalIgnoreCase) >= 0;
                        Log.Info($"[HairProbe]   slot[{i}] = {mp}{(isHair ? "  <== 疑似毛发" : "")}");
                    }
                }
                catch (Exception e) { Log.Warn($"[HairProbe] 读材质失败: {e.Message}"); }
            }

            // 2) 候选 TressFX 资产
            Log.Info("[HairProbe] ----- 候选 TressFX 资产（存在=可填进 TFXConfigs） -----");
            string[] tfxCandidates = {
                "/Game/00MainHZ/Characters/Wukong/Meshes/Equip/JSDS_01A/Hair/JSDS_01A_Fur_TFX.JSDS_01A_Fur_TFX",
                "/Game/00MainHZ/Characters/Wukong/Meshes/Equip/DaShengKuiJia/Hair/DaShengKuiJia_Fur_TFX.DaShengKuiJia_Fur_TFX",
                "/Game/00MainHZ/Characters/Wukong/Meshes/Equip/Dashengtao/Hair/Dashengtao_Fur_TFX.Dashengtao_Fur_TFX",
                "/Game/00MainHZ/Characters/Enemy/MGD/MGD_JSDS/Hair/MGD_JSDS_Fur_TFX.MGD_JSDS_Fur_TFX",
                "/Game/00MainHZ/Characters/MGD/MGD_JSDS/Hair/MGD_JSDS_Fur_TFX.MGD_JSDS_Fur_TFX",
                "/Game/00MainHZ/Characters/Enemy/MGD/MGD_JSDS/Hair/HAIR_mgd_jsds_TFX.HAIR_mgd_jsds_TFX",
                "/Game/00MainHZ/Characters/Wukong/Materials/Equip/JSDS_01A/M_Hair_KajiyaKai_Inst.M_Hair_KajiyaKai_Inst",
            };
            foreach (var t in tfxCandidates)
            {
                var asset = UObject.LoadObject<UTressFXAsset>(world, t);
                bool ok = asset != null && !asset.IsNullOrDestroyed();
                // 顺带试一下材质（部分候选其实是材质）
                if (!ok)
                {
                    var mat = UObject.LoadObject<UMaterialInterface>(world, t);
                    ok = mat != null && !mat.IsNullOrDestroyed();
                }
                Log.Info($"[HairProbe]   {(ok ? "存在" : "缺失")} -> {t}");
            }

            // 4) Boss 怪物组件探测
            //    注意：UGSFuncLibForEditor / GSEditorAssetLibrary 属于编辑器模块（/Script/FuncLibEditor.*），
            //    打包版里这些函数无效（返回 null），所以不能靠 GetCDONodeComponents 读 CDO。
            //    可行做法：临时生成一只 boss 实例，读它身上真实的 TressFX 组件与骨骼网格。
            Log.Info("[HairProbe] ----- Boss 怪物组件探测（拿真实 TressFX 毛发路径） -----");
            const string unitPath = "/Game/00Main/Design/Units/MGD/TAMER_mgd_jsds_p2.TAMER_mgd_jsds_p2_C";
            try
            {
                var unitCls =  LoadClass($"PrefabricatorAsset'{unitPath}'");
                if (unitCls == null) Log.Info($"[HairProbe]   单位类加载失败: {unitPath}");
                else
                {
                    // string monsterPath = (unitCls.GetDefaultObject() as BUTamerActor)?.MonsterClassPath ?? string.Empty;
                    // var monsterCls = !string.IsNullOrEmpty(monsterPath)
                    //     ? UObject.LoadClass<AActor>(world, monsterPath)
                    //     : unitCls;
                    // Log.Info($"[HairProbe]   单位 {unitPath} -> MonsterClassPath='{monsterPath}'");
                    // var mcdo = monsterCls?.GetDefaultObject() as BGUCharacterCS;
                    // if (mcdo == null) Log.Info("[HairProbe]   怪物 CDO 加载失败");
                    // else
                    // {
                    //     Log.Info($"[HairProbe]   怪物主 Mesh = {mcdo.Mesh?.SkeletalMesh?.GetPathName() ?? "<null>"}");
                    //     DumpActorHair(mcdo, "[HairProbe]   [CDO]");
                    // }

                    if (character != null && !character.IsNullOrDestroyed())
                    {
                        // 出生点统一：主角正前方 800，脚底在地面之上（避免陷进地里），背对主角
                        var spawn = ModUtils.CalcSummonSpawnInfo(character);
                        var boss = BGUFunctionLibraryCS.BGUSpawnActor(world, unitCls, spawn.CenterLocation, spawn.Rotation);
                        if (boss == null) Log.Info("[HairProbe]   生成 boss 失败");
                        else
                        {
                            Log.Info("[HairProbe]   ===== 已生成一只真残躯，10 秒后自动销毁：请直接看它头顶有没有毛，和变身状态对比 =====");
                            DumpActorHair(boss, "[HairProbe]   [Boss-即时]");
                            // spawn 后组件要过若干帧才初始化完，立即 dump 只会拿到空组件；
                            // 所以延迟多档 dump，才能读到真 boss 的 TressFX 资产与运行时材质。
                            DumpActorHairDelayed(boss, "[HairProbe]   [Boss-0.5s]", 500);
                            DumpActorHairDelayed(boss, "[HairProbe]   [Boss-2s]", 2000);
                            DumpActorHairDelayed(boss, "[HairProbe]   [Boss-5s]", 5000);
                            Task.Run(async () =>
                            {
                                await Task.Delay(10000);
                                Utils.TryRunOnGameThread(() =>
                                {
                                    try
                                    {
                                        if (boss != null && !boss.IsNullOrDestroyed())
                                        {
                                            boss.DestroyActor();
                                            Log.Info("[HairProbe]   已销毁临时 boss");
                                        }
                                    }
                                    catch (Exception e2) { Log.Warn($"[HairProbe]   销毁 boss 失败: {e2.Message}"); }
                                });
                            });
                        }
                    }
                    else Log.Info("[HairProbe]   character 为空，跳过生成 boss");
                }
            }
            catch (Exception e) { Log.Warn($"[HairProbe]   Boss 组件探测异常: {e.Message}"); }

            // 3) 当前角色身上的组件
            if (character != null && !character.IsNullOrDestroyed())
            {
                Log.Info("[HairProbe] ----- 当前角色组件（换皮后请先看这里） -----");
                try
                {
                    foreach (var c in character.GetComponentsByClass((TSubclassOf<UActorComponent>)UClass.GetClass<USkeletalMeshComponent>()))
                    {
                        if (c is USkeletalMeshComponent smc)
                            Log.Info($"[HairProbe]   SKComp mesh={smc.SkeletalMesh?.GetPathName() ?? "<null>"} visible={ProbeVisibleOf(smc)} hiddenInGame={ProbeHiddenOf(smc)}");
                    }
                }
                catch (Exception e) { Log.Warn($"[HairProbe] SKComp 遍历失败: {e.Message}"); }
                try
                {
                    foreach (var c in character.GetComponentsByClass((TSubclassOf<UActorComponent>)UClass.GetClass<UStaticMeshComponent>()))
                    {
                        if (c is UStaticMeshComponent smc)
                            Log.Info($"[HairProbe]   SMComp mesh={smc.StaticMesh?.GetPathName() ?? "<null>"} visible={ProbeVisibleOf(smc)} hiddenInGame={ProbeHiddenOf(smc)}");
                    }
                }
                catch (Exception e) { Log.Warn($"[HairProbe] SMComp 遍历失败: {e.Message}"); }
                try
                {
                    var cls = MyUtils.LoadAsset<UClass>("/Script/TressFX.TressFXComponent");
                    foreach (var c in character.GetComponentsByClass(cls))
                    {
                        UTressFXComponent tfx = c as UTressFXComponent;
                        string assetPath = tfx != null && tfx.Asset != null ? tfx.Asset.GetPathName() : "<null>";
                        string hairMat = tfx != null && tfx.HairMaterial != null ? tfx.HairMaterial.GetPathName() : "<null>";
                        bool sim = tfx != null && tfx.EnableSimulation;
                        float lod = tfx != null ? tfx.LodScreenSize : -1f;
                        Log.Info($"[HairProbe]   TressFXComp Asset={assetPath} HairMaterial={hairMat} EnableSimulation={sim} LodScreenSize={lod}");
                    }
                }
                catch (Exception e) { Log.Warn($"[HairProbe] TressFX 遍历失败: {e.Message}"); }

                // 附加：把玩家身上的【全部】组件也列出来，方便和真 boss 的组件列表逐项对比，
                // 找出"真 boss 有、玩家没有"的那个毛发组件。
                try
                {
                    var all = character.GetComponentsByClass((TSubclassOf<UActorComponent>)UClass.GetClass<UActorComponent>());
                    Log.Info($"[HairProbe] ----- 玩家全部组件（共 {all.Count} 个，用于和真 boss 对比） -----");
                    foreach (var c in all)
                    {
                        if (c == null) continue;
                        string mi = string.Empty;
                        try
                        {
                            if (c is UStaticMeshComponent s2 && s2.StaticMesh != null) mi = " mesh=" + s2.StaticMesh.GetPathName();
                            else if (c is USkeletalMeshComponent k2 && k2.SkeletalMesh != null) mi = " mesh=" + k2.SkeletalMesh.GetPathName();
                        }
                        catch { }
                        Log.Info($"[HairProbe]   comp={c.GetClass()?.GetName()}{mi} visible={ProbeVisibleOf(c)}");
                    }
                }
                catch (Exception e) { Log.Warn($"[HairProbe] 玩家全组件 dump 失败: {e.Message}"); }

                // 运行时材质：资产材质里毛发槽是有材质的，但幻化可能在运行时把它覆盖成 M_Invisible，
                // 那样资产层面怎么查都是"有毛"，实际渲染却是秃的。这里读组件真正生效的材质来对比。
                try
                {
                    Log.Info("[HairProbe] ----- 玩家运行时材质（重点：毛发槽是否被覆盖成 M_Invisible） -----");
                    foreach (var c in character.GetComponentsByClass((TSubclassOf<UActorComponent>)UClass.GetClass<USkeletalMeshComponent>()))
                    {
                        if (c is USkeletalMeshComponent smc && smc.SkeletalMesh != null && ProbeVisibleOf(smc))
                            DumpRuntimeMaterials(smc, "[HairProbe]   [玩家]");
                    }
                }
                catch (Exception e) { Log.Warn($"[HairProbe] 运行时材质遍历失败: {e.Message}"); }
            }
            else
            {
                Log.Info("[HairProbe] character 为 null，跳过组件遍历（请确保在游戏内、角色已生成时触发）");
            }
            Log.Info("[HairProbe] ===== 探测结束 =====");
        }

        /// <summary>
        /// 打印 actor 身上的 TressFX 毛发组件与骨骼网格组件（含资产路径、可见性）。
        /// 用于确认 boss 的毛发到底是 TressFX 资产还是独立 mesh。
        /// </summary>
        private static void DumpActorHair(AActor actor, string tag)
        {
            if (actor == null || actor.IsNullOrDestroyed()) return;
            try
            {
                foreach (var c in actor.GetComponentsByClass((TSubclassOf<UActorComponent>)UClass.GetClass<UTressFXComponent>()))
                {
                    if (c is UTressFXComponent tfx)
                        Log.Info($"{tag} TFX Asset={tfx.Asset?.GetPathName() ?? "<null>"} HairMaterial={tfx.HairMaterial?.GetPathName() ?? "<null>"} Lod={tfx.LodScreenSize} Sim={tfx.EnableSimulation} visible={ProbeVisibleOf(tfx)}");
                }
            }
            catch (Exception e) { Log.Warn($"{tag} TFX 遍历失败: {e.Message}"); }
            try
            {
                foreach (var c in actor.GetComponentsByClass((TSubclassOf<UActorComponent>)UClass.GetClass<USkeletalMeshComponent>()))
                {
                    if (c is USkeletalMeshComponent smc && smc.SkeletalMesh != null)
                        Log.Info($"{tag} SKComp mesh={smc.SkeletalMesh.GetPathName()} visible={ProbeVisibleOf(smc)} hiddenInGame={ProbeHiddenOf(smc)}");
                }
            }
            catch (Exception e) { Log.Warn($"{tag} SKComp 遍历失败: {e.Message}"); }

            // 附加：把这个 actor 的【全部】组件列出来，确认生成出来的 boss 身上到底挂了什么。
            // 这是定位"真 boss 的毛来自哪个组件"的唯一可靠途径。
            try
            {
                var all = actor.GetComponentsByClass((TSubclassOf<UActorComponent>)UClass.GetClass<UActorComponent>());
                Log.Info($"{tag} 组件总数={all.Count}");
                foreach (var c in all)
                {
                    if (c == null) continue;
                    string mi = string.Empty;
                    try
                    {
                        if (c is UStaticMeshComponent s2 && s2.StaticMesh != null) mi = " mesh=" + s2.StaticMesh.GetPathName();
                        else if (c is USkeletalMeshComponent k2 && k2.SkeletalMesh != null) mi = " mesh=" + k2.SkeletalMesh.GetPathName();
                    }
                    catch { }
                    Log.Info($"{tag}   comp={c.GetClass()?.GetName()}{mi} visible={ProbeVisibleOf(c)}");
                }
            }
            catch (Exception e) { Log.Warn($"{tag} 全组件 dump 失败: {e.Message}"); }
        }

        /// <summary>
        /// 反射读取组件可见性。游戏隐藏装备/部件用的是 SetVisibility（bVisible），
        /// 而不是 bHiddenInGame，所以判断"有没有被游戏藏起来"必须看这个。
        /// </summary>
        private static bool ProbeVisibleOf(object obj)
        {
            try
            {
                var m = obj.GetType().GetMethod("IsVisible", Type.EmptyTypes);
                if (m != null && m.ReturnType == typeof(bool)) return (bool)m.Invoke(obj, null);
            }
            catch { }
            return false;
        }

        /// <summary>反射读取组件/Actor 的游戏内隐藏标记（不同版本布尔属性名不一致，容错）</summary>
        private static bool ProbeHiddenOf(object obj)
        {
            foreach (var n in new[] { "bHiddenInGame", "HiddenInGame", "bHidden", "Hidden" })
            {
                try
                {
                    var t = obj.GetType();
                    var pi = t.GetProperty(n, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                    if (pi != null && pi.PropertyType == typeof(bool)) return (bool)pi.GetValue(obj);
                    var fi = t.GetField(n, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                    if (fi != null && fi.FieldType == typeof(bool)) return (bool)fi.GetValue(obj);
                }
                catch { }
            }
            return false;
        }

        /// <summary>
        /// 打印骨骼网格组件"运行时真正生效"的材质，并与资产自带材质对比。
        /// 资产里毛发槽是有材质的，但幻化可能在运行时把它覆盖成 M_Invisible —— 那样资产层面
        /// 怎么查都是"有毛"，实际渲染却是秃的。只有读组件运行时材质才能看出来。
        /// </summary>
        private static void DumpRuntimeMaterials(USkeletalMeshComponent smc, string tag)
        {
            if (smc == null || smc.IsNullOrDestroyed()) return;
            string meshName = (smc.SkeletalMesh != null && !smc.SkeletalMesh.IsNullOrDestroyed())
                ? smc.SkeletalMesh.GetPathName() : "<null>";
            Log.Info($"{tag} SKComp={meshName}");

            int count = 0;
            try
            {
                var mats = smc.SkeletalMesh?.GetMaterials();
                if (mats != null) count = mats.Count;
            }
            catch { }
            if (count <= 0) count = 8;

            for (int i = 0; i < count; i++)
            {
                string runtime = "<null>";
                string parent = string.Empty;
                try
                {
                    var m = smc.GetMaterial(i);
                    if (m != null && !m.IsNullOrDestroyed())
                    {
                        runtime = m.GetPathName();
                        // 运行时材质常是 MaterialInstanceDynamic（名字是 /Engine/Transient.MaterialInstanceDynamic_xxxx），
                        // 光看名字判断不出它到底继承了什么。毛发槽若是被换成了基于 M_Invisible 的 MID，
                        // 视觉上就是秃的，但名字上完全看不出来 —— 必须读 Parent。
                        try
                        {
                            var pi = m.GetType().GetProperty("Parent",
                                System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                            var pv = pi?.GetValue(m) as UMaterialInterface;
                            if (pv != null && !pv.IsNullOrDestroyed()) parent = pv.GetPathName();
                        }
                        catch { }
                    }
                }
                catch { runtime = "<读取失败>"; }

                string asset = "<null>";
                try
                {
                    var mats = smc.SkeletalMesh?.GetMaterials();
                    if (mats != null && i < mats.Count)
                    {
                        var ami = mats[i].MaterialInterface;
                        asset = (ami != null && !ami.IsNullOrDestroyed()) ? ami.GetPathName() : "<null>";
                    }
                }
                catch { }

                // 判断"是不是被藏了"要同时看运行时材质本身和它的父材质
                string judge = string.IsNullOrEmpty(parent) ? runtime : parent;
                bool invisible = judge.IndexOf("M_Invisible", StringComparison.OrdinalIgnoreCase) >= 0
                              || judge.IndexOf("M_invisible", StringComparison.OrdinalIgnoreCase) >= 0;
                bool isHair = judge.IndexOf("hair", StringComparison.OrdinalIgnoreCase) >= 0
                           || judge.IndexOf("fur", StringComparison.OrdinalIgnoreCase) >= 0;

                string flags = string.Empty;
                if (isHair) flags += " <==毛发";
                if (invisible) flags += " <==被 M_Invisible 隐藏";
                if (!invisible && runtime != asset) flags += $" <==与资产不同(资产={asset})";
                if (!string.IsNullOrEmpty(parent)) flags += $" [parent={parent}]";

                Log.Info($"{tag}   mat[{i}] runtime={runtime}{flags}");
            }
        }

        /// <summary>
        /// 延迟若干毫秒后再 dump actor 的毛发组件 / 骨骼网格 / 运行时材质。
        /// BGUSpawnActor 刚生成的 actor 组件还没初始化完，立即读只会拿到空组件（什么都打不出来）。
        /// </summary>
        private static void DumpActorHairDelayed(AActor boss, string tag, int delayMs)
        {
            Task.Run(async () =>
            {
                await Task.Delay(delayMs);
                Utils.TryRunOnGameThread(() =>
                {
                    try
                    {
                        if (boss == null || boss.IsNullOrDestroyed())
                        {
                            Log.Info($"{tag} boss 已销毁，跳过");
                            return;
                        }
                        DumpActorHair(boss, tag);
                        foreach (var c in boss.GetComponentsByClass((TSubclassOf<UActorComponent>)UClass.GetClass<USkeletalMeshComponent>()))
                        {
                            if (c is USkeletalMeshComponent smc && smc.SkeletalMesh != null && ProbeVisibleOf(smc))
                                DumpRuntimeMaterials(smc, tag);
                        }
                    }
                    catch (Exception e) { Log.Warn($"{tag} 延迟 dump 失败: {e.Message}"); }
                });
            });
        }

        /// <summary>
        /// 恢复"毛发部件"可见，修复变身/幻化后秃头。
        ///
        /// 结论（由解包资产与运行时探测共同确认）：
        /// 残躯(MGD_JSDS)本身没有任何 TressFX 资产，也没有 TressFXComponent，
        /// 所以走 TFXConfig 这条路注定拿不到毛。
        /// 真正的毛发是静态网格 SM_Wukong_head_born_static —— 它的材质槽名是
        /// Hair03_MTL / Hair04_MTL，材质是 M_Hair_KajiyaKai_Inst（毛发材质），
        /// 三角形数 21 万+，它就是毛发网格本身，而不是"头"。
        /// 幻化变身时游戏把玩家身上的部件（含这个毛发网格）一并隐藏，于是变身后就秃了。
        /// 这里把它重新设为可见即可。
        /// </summary>
        private static void RestoreHairMesh(BGUPlayerCharacterCS character, ActionConfig action)
        {
            if (character == null || character.IsNullOrDestroyed()) return;

            // ★ 关键一：主网格把被幻化隐藏的材质 section 全部重新显示。
            //   残躯网格自带发片槽 cardhair_MTL -> M_Wukong_Haircard_Inst，
            //   幻化系统常用 ShowMaterialSection/HideMaterialSection 把它藏起来；
            //   此时 GetMaterial(slot) 依然返回毛发材质，所以现象就是"材质对、几何也在，却看不到毛"。
            try
            {
                var mainMesh = character.Mesh;
                if (mainMesh != null && !mainMesh.IsNullOrDestroyed())
                {
                    int shown = 0;
                    for (int i = 0; i < 64; i++)
                    {
                        try { mainMesh.ShowMaterialSection(i, 0, true, i); shown++; }
                        catch { }
                    }
                    Log.Info($"[MagicMod] 主网格材质 section 全部显示完成（尝试 {shown} 个）");

                    // ★ 毛发 section 会被 LOD 剔除：残躯网格带 HairSpecialWeight（毛发 LOD 权重），
                    //   一旦主网格被推到高 LOD（低精度），发片/发丝 section 就不再渲染，
                    //   于是"材质正确、几何存在、section 也没隐藏，但就是看不到毛"。
                    //   ForcedLodModel = 1 表示强制 LOD0（最高精度），0 表示自动。
                    // 反射设置：不同版本 API 名字不一致（方法 / 属性 都试一遍）
                    try
                    {
                        var miLod = mainMesh.GetType().GetMethod("SetForcedLodModel", new[] { typeof(int) });
                        if (miLod != null) miLod.Invoke(mainMesh, new object[] { 1 });
                        else
                        {
                            var piLod = mainMesh.GetType().GetProperty("ForcedLodModel",
                                System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                            if (piLod != null && piLod.CanWrite) piLod.SetValue(mainMesh, 1);
                            else Log.Warn("[MagicMod] 未找到 ForcedLodModel（方法/属性都没有），跳过强制 LOD0");
                        }
                    }
                    catch (Exception eLod) { Log.Warn($"[MagicMod] 强制 LOD0 失败: {eLod.Message}"); }

                    int predicted = -1, forced = -1;
                    try
                    {
                        var piP = mainMesh.GetType().GetProperty("PredictedLODLevel",
                            System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                        if (piP != null) predicted = Convert.ToInt32(piP.GetValue(mainMesh));
                    }
                    catch { }
                    try
                    {
                        var piF = mainMesh.GetType().GetProperty("ForcedLodModel",
                            System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                        if (piF != null) forced = Convert.ToInt32(piF.GetValue(mainMesh));
                    }
                    catch { }
                    Log.Info($"[MagicMod] 主网格 LOD: 强制后 ForcedLodModel={forced} PredictedLODLevel={predicted}");
                }
                else Log.Warn("[MagicMod] 主网格为空，section 显示跳过");
            }
            catch (Exception e) { Log.Warn($"[MagicMod] 显示主网格 section 失败: {e.Message}"); }

            // ★★★ 真正的修复：玩家自己装备上【带毛发材质槽的部件】在幻化时被整体隐藏 → 秃头。
            //   实测（未变身、穿大圣套时）玩家身上：
            //     SK_wukong_head_dashengtao  mat[7] = M_Wukong_Haircard_Inst   <== 头发
            //     SK_weiba(尾巴)             mat[1] = M_Hair_KajiyaKai_Inst    <== 尾毛
            //     SK_wukong_body_dashengtao  mat[0] = M_Wukong_Haircard_Inst   <== 体毛
            //   做法：把这些部件重新显示，并把它们的【非毛发槽】全部设成 M_Invisible，
            //   这样只补回毛发，不会多出头盔/脸/衣服去和残躯身体重叠。
            try
            {
                var world2 = ModUtils.GetWorld();
                UMaterialInterface? invis = null;
                try { invis = UObject.LoadObject<UMaterialInterface>(world2, "/Game/00Main/GlobalMat/BaseLibrary/Cha/BaseMaterial/M_Invisible.M_invisible"); }
                catch { }

                // ★★ 关键：幻化隐藏玩家部件用的是游戏自己的事件
                //   BUS_MagicallyChangeComp.SetSKMeshVisibility(bVisible:false)
                //     → Evt_SetModularMeshVisibility.Invoke(false)
                //   由 BUS_CharacterModularCompImpl.OnSetModularMeshVisibility 处理，
                //   它对每个模块化部件调 SetVisibility(bVisible)。
                //   恢复就必须走同一个接口：Evt_SetModularMeshVisibility.Invoke(true)。
                //   （自己用反射调 SetVisibility(bool,bool) 是错的：游戏那边是单参数签名，
                //     反射找不到方法就静默失败 —— 这正是上一步"画面毫无变化"的原因。）
                try
                {
                    var gsEvt = BUS_EventCollectionCS.Get(character);
                    if (gsEvt != null)
                    {
                        gsEvt.Evt_SetModularMeshVisibility.Invoke(true);
                        Log.Info("[MagicMod] 已调用 Evt_SetModularMeshVisibility(true)（游戏原生玩家部件恢复接口）");
                    }
                    else Log.Warn("[MagicMod] BUS_EventCollectionCS.Get(character) 返回空，无法恢复部件");
                }
                catch (Exception eEvt) { Log.Warn($"[MagicMod] 调用 Evt_SetModularMeshVisibility 失败: {eEvt.Message}"); }

                var mainSk = character.Mesh;
                int fixedCount = 0;
                foreach (var c in character.GetComponentsByClass((TSubclassOf<UActorComponent>)UClass.GetClass<USkeletalMeshComponent>()))
                {
                    if (!(c is USkeletalMeshComponent skc) || skc.SkeletalMesh == null) continue;
                    if (mainSk != null && skc == mainSk) continue; // 主网格跳过，否则会把残躯身体也隐藏掉

                    var mats = skc.SkeletalMesh.GetMaterials();
                    if (mats == null || mats.Count == 0) continue;

                    // 该部件是否含有毛发槽
                    bool hasHair = false;
                    for (int i = 0; i < mats.Count; i++)
                    {
                        var mi0 = mats[i].MaterialInterface;
                        string n0 = (mi0 != null && !mi0.IsNullOrDestroyed()) ? mi0.GetPathName() : "";
                        if (n0.IndexOf("hair", StringComparison.OrdinalIgnoreCase) >= 0
                         || n0.IndexOf("fur", StringComparison.OrdinalIgnoreCase) >= 0) { hasHair = true; break; }
                    }
                    if (!hasHair) continue;

                    // 改成强类型调用（游戏那边 OnSetModularMeshVisibility 用的就是单/双参数 SetVisibility，
                    // 之前用反射写两参数签名匹配不上，静默失败）
                    try { skc.SetHiddenInGame(false, false); } catch { }
                    try { skc.SetVisibility(true, false); } catch { }

                    int hid = 0;
                    // 诊断阶段：先【原样显示】，不隐藏非毛发槽。
                    // 目的：判断"可见性恢复"到底有没有生效 ——
                    //   若生效，画面上应该会多出一个悟空头/头盔；
                    //   若毫无变化，说明 SetVisibility 没起作用（那就得换 API）。
                    // 确认生效后再打开下面的"只保留毛发槽"逻辑。
                    if (false && invis != null)
                    {
                        for (int i = 0; i < mats.Count; i++)
                        {
                            var mi1 = mats[i].MaterialInterface;
                            string n1 = (mi1 != null && !mi1.IsNullOrDestroyed()) ? mi1.GetPathName() : "";
                            bool isHair = n1.IndexOf("hair", StringComparison.OrdinalIgnoreCase) >= 0
                                       || n1.IndexOf("fur", StringComparison.OrdinalIgnoreCase) >= 0;
                            if (!isHair) { try { skc.SetMaterial(i, invis); hid++; } catch { } }
                        }
                    }
                    fixedCount++;
                    Log.Info($"[MagicMod] 恢复毛发部件: {skc.SkeletalMesh.GetPathName()}（隐藏非毛发槽 {hid}/{mats.Count} 个）");
                }
                if (fixedCount == 0) Log.Warn("[MagicMod] 未找到任何带毛发槽的部件（当前装备可能不含毛发部件）");
                else Log.Info($"[MagicMod] 共恢复 {fixedCount} 个带毛发部件（只保留毛发槽，其余设 M_Invisible）");
            }
            catch (Exception eNew) { Log.Warn($"[MagicMod] 恢复毛发部件异常: {eNew.Message}"); }

            // 关键字：默认只认已确认的毛发网格；也支持配置里用 path 覆盖（逗号分隔）
            string[] kws = { "head_born_static" };
            string? cfg = action?.path;
            if (!string.IsNullOrEmpty(cfg))
            {
                var parts = cfg!.Split(new[] { ',', ';', '|' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length > 0) kws = parts;
            }

            var hitPaths = new List<string>();
            var toShow = new List<object>();

            try
            {
                foreach (var c in character.GetComponentsByClass((TSubclassOf<UActorComponent>)UClass.GetClass<UStaticMeshComponent>()))
                {
                    if (c is UStaticMeshComponent smc && smc.StaticMesh != null)
                    {
                        string p = smc.StaticMesh.GetPathName();
                        foreach (var k in kws)
                        {
                            if (!string.IsNullOrEmpty(k) && p.IndexOf(k, StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                toShow.Add(smc);
                                hitPaths.Add("SM:" + p);
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception e) { Log.Warn($"[MagicMod] 查找毛发静态网格失败: {e.Message}"); }

            // 保险起见，骨骼网格里若也有同名毛发部件，一并恢复
            try
            {
                foreach (var c in character.GetComponentsByClass((TSubclassOf<UActorComponent>)UClass.GetClass<USkeletalMeshComponent>()))
                {
                    if (c is USkeletalMeshComponent smc && smc.SkeletalMesh != null)
                    {
                        string p = smc.SkeletalMesh.GetPathName();
                        foreach (var k in kws)
                        {
                            if (!string.IsNullOrEmpty(k) && p.IndexOf(k, StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                toShow.Add(smc);
                                hitPaths.Add("SK:" + p);
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception e) { Log.Warn($"[MagicMod] 查找毛发骨骼网格失败: {e.Message}"); }

            if (toShow.Count == 0)
            {
                Log.Warn($"[MagicMod] 未找到毛发部件(关键字={string.Join(",", kws)})，恢复跳过");
                return;
            }

            foreach (var comp in toShow)
            {
                try { comp.GetType().GetMethod("SetHiddenInGame", new[] { typeof(bool), typeof(bool) })?.Invoke(comp, new object[] { false, false }); }
                catch { }
                try { comp.GetType().GetMethod("SetVisibility", new[] { typeof(bool), typeof(bool) })?.Invoke(comp, new object[] { true, false }); }
                catch { }
                // 幻化隐藏组件后可能没重置渲染状态，导致恢复可见也不渲染；强制刷新一次
                try { comp.GetType().GetMethod("MarkRenderStateDirty", Type.EmptyTypes)?.Invoke(comp, null); }
                catch { }

                // ★★ 这道题最关键的一步：SM_Wukong_head_born_static 有两个 section
                //    Hair03_MTL(1.2万三角形 = 内层头壳) / Hair04_MTL(21万三角形 = 真正的发丝)。
                //    静网格渲染在低精度 LOD 时只有头壳、发丝被剔除 —— 现象正好是
                //    "有头壳、头顶秃"。所以这里对毛发部件本身也强制 LOD0。
                try
                {
                    bool ok = false;
                    var miLod = comp.GetType().GetMethod("SetForcedLodModel", new[] { typeof(int) });
                    if (miLod != null) { miLod.Invoke(comp, new object[] { 1 }); ok = true; }
                    else
                    {
                        var piLod = comp.GetType().GetProperty("ForcedLodModel",
                            System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                        if (piLod != null && piLod.CanWrite) { piLod.SetValue(comp, 1); ok = true; }
                    }
                    Log.Info($"[MagicMod]   毛发部件强制 LOD0: {(ok ? "已设置" : "未找到 LOD 接口")}");
                }
                catch (Exception eL) { Log.Warn($"[MagicMod]   毛发部件强制 LOD0 失败: {eL.Message}"); }
                // ★ 还原为网格自带材质：运行时材质是换装系统生成的 MaterialInstanceDynamic，
                //   毛发参数（发丝 alpha / Kajiya-Kay 着色）多半在生成 MID 时丢掉了，
                //   于是渲染成一片实心色块而不是发丝。还原成资产自带的
                //   M_Hair_KajiyaKai_Inst（Hair03_MTL / Hair04_MTL）才能正常出毛。
                try
                {
                    if (comp is UStaticMeshComponent smc && smc.StaticMesh != null)
                    {
                        var mats = smc.StaticMesh.GetStaticMaterials();
                        if (mats != null)
                        {
                            for (int i = 0; i < mats.Count; i++)
                            {
                                var mi = mats[i].MaterialInterface;
                                if (mi != null && !mi.IsNullOrDestroyed()) smc.SetMaterial(i, mi);
                            }
                        }
                    }
                    else if (comp is USkeletalMeshComponent skc && skc.SkeletalMesh != null)
                    {
                        var mats = skc.SkeletalMesh.GetMaterials();
                        if (mats != null)
                        {
                            for (int i = 0; i < mats.Count; i++)
                            {
                                var mi = mats[i].MaterialInterface;
                                if (mi != null && !mi.IsNullOrDestroyed()) skc.SetMaterial(i, mi);
                            }
                        }
                    }
                }
                catch (Exception e) { Log.Warn($"[MagicMod] 还原毛发自带材质失败: {e.Message}"); }

                // 打印还原后真正生效的材质，确认是否已换回 M_Hair_KajiyaKai_Inst
                try
                {
                    if (comp is UMeshComponent umc)
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            UMaterialInterface? mi = null;
                            try { mi = umc.GetMaterial(i); } catch { }
                            if (mi == null || mi.IsNullOrDestroyed()) break;
                            Log.Info($"[MagicMod]   毛发部件还原后材质[{i}] = {mi.GetPathName()}");
                        }
                    }
                }
                catch { }

                // ★ 诊断挂载：毛发是"静态网格挂到头部骨骼"上的，如果幻化把它重新挂到了别的骨骼
                //   （或挂到了根/空 socket），毛发就会塌成一坨/错位。这里把挂载骨骼和世界位置打出来。
                try
                {
                    var t = comp.GetType();
                    string sock = "<n/a>";
                    try
                    {
                        var pi = t.GetProperty("AttachSocketName",
                            System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                        if (pi != null) sock = pi.GetValue(comp)?.ToString() ?? "<null>";
                        else
                        {
                            var mi = t.GetMethod("GetAttachSocketName");
                            if (mi != null) sock = mi.Invoke(comp, null)?.ToString() ?? "<null>";
                        }
                    }
                    catch { }

                    string parentName = "<n/a>";
                    try
                    {
                        var piP = t.GetProperty("AttachParent",
                            System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                        var pv = piP?.GetValue(comp);
                        if (pv != null) parentName = pv.GetType().Name;
                    }
                    catch { }

                    string loc = "<n/a>";
                    try
                    {
                        var piL = t.GetProperty("ComponentLocation",
                                       System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                               ?? t.GetProperty("RelativeLocation",
                                       System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                        var vv = piL?.GetValue(comp);
                        if (vv != null) loc = vv.ToString() ?? "<obj>";
                    }
                    catch { }

                    bool vis = ProbeVisibleOf(comp);
                    Log.Info($"[MagicMod]   毛发部件挂载诊断: socket='{sock}' parent={parentName} loc={loc} visible={vis}");
                }
                catch { }
            }

            foreach (var p in hitPaths) Log.Info($"[MagicMod] 恢复毛发部件可见: {p}");
            Log.Info($"[MagicMod] 已恢复 {toShow.Count} 个毛发部件可见（关键字={string.Join(",", kws)}）");
        }

        /// <summary>
        /// Buff 动作：添加指定 Buff
        /// </summary>
        private static void DoBuffAction(BGUPlayerCharacterCS character, ActionConfig action)
        {

            List<int> buffIds = action.Values ?? new List<int> { action.Value.GetValueOrDefault() };

            int duration = (int)(action.Duration > 0 ? action.Duration : 0);

            if (buffIds == null || buffIds.Count == 0)
            {
                Log.Warn("[MagicMod] Buff ID 无效");
                return;
            }

            try
            {
                foreach (var item in buffIds)
                {
                    BGUFunctionLibraryCS.BGUAddBuff(character, character, item, EBuffSourceType.GM, duration);
                }
            }
            catch (Exception e)
            {
                Log.Error($"[MagicMod] 添加 Buff 失败: {e.Message}");
            }
        }

        private static void DoRangeBuffAction(BGUPlayerCharacterCS character, ActionConfig action)
        {
            List<int> buffIds = action.Values ?? new List<int> { action.Value.GetValueOrDefault() };

            int duration = (int)(action.Duration > 0 ? action.Duration : 0);

            if (buffIds == null || buffIds.Count == 0)
            {
                Log.Warn("[MagicMod] Buff ID 无效");
                return;
            }
            var rangValue = action.range ?? 3000;
            List<ABGUCharacter> allActorsOfClassList = ModUtils.getMonsterByDistance(rangValue);

            try
            {
                foreach (var actor in allActorsOfClassList)
                {
                    foreach (var item in buffIds)
                    {
                        BGUFunctionLibraryCS.BGUAddBuff(character, actor, item, EBuffSourceType.GM, duration);
                    }
                }

            }
            catch (Exception e)
            {
                Log.Error($"[MagicMod] 添加 Buff 失败: {e.Message}");
            }
        }

        /// <summary>
        /// Skill 动作：释放指定技能
        /// </summary>
        private static void DoSkillAction(BGUPlayerCharacterCS character, ActionConfig action)
        {
            int skillId = (int)action.Value;
            if (skillId <= 0)
            {
                Log.Warn("[MagicMod] Skill ID 无效");
                return;
            }

            BUS_EventCollectionCS.Get(character)?.Evt_RequestSmartCastSkill.Invoke(
                skillId, null, EMontageBindReason.NormalSkill, false);
            Log.Info($"[MagicMod] 释放技能 ID={skillId}");
        }

        /// <summary>
        /// Magic 动作：释放法术/变化技能
        /// 优先使用 soulBossConfig 中的自定义配置（按 magicId 匹配），未命中时回退到 DAPath 加载
        /// </summary>
        private static void DoMagicAction(BGUPlayerCharacterCS character, ActionConfig action)
        {
            string daPath = action.DAPath ?? string.Empty; // 假设 ActionConfig 中使用 StrValue 存储 DAPath
            int magicSkillId = action.magicSkill.GetValueOrDefault(); // 幻化变身技能Id
            int recoverSkillId = action.magicBackSkill.GetValueOrDefault(); // 幻化变身还原技能ID
            int magicId = (int)action.Value;

            // 查找 soulBossConfig 中的自定义配置（soulConfigList）
            SoulBossConfig? soulConfig = GetSoulConfig(magicId);

            if (magicId > 0)
            {
                SoulSkillDesc soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(magicId);
                if (soulSkillDesc != null && soulSkillDesc.DAPath != null)
                {
                    daPath = soulSkillDesc.DAPath;


                    if (magicSkillId <= 0)
                    {
                        magicSkillId = soulSkillDesc.SkillId;
                    }
                    // 命中自定义配置时，Buff 改用 soulConfig.BuffId 附加
                    if (soulConfig == null && soulSkillDesc.BuffId > 0)
                    {
                        BGUFunctionLibraryCS.BGUAddBuff(character, character, soulSkillDesc.BuffId, EBuffSourceType.GM, 5000);
                    }
                }
            }
            if (recoverSkillId <= 0)
            {
                recoverSkillId = 10199;
            }
            if (magicSkillId <= 0 || recoverSkillId <= 0)
            {
                Log.Warn($"[MagicMod] Magic 技能ID无效 变身ID={magicSkillId}, 还原ID={recoverSkillId}");
                return;
            }

            BGWDataAsset_MagicallyChangeConfig? config = null;
            if (soulConfig != null)
            {
                // 命中 soulConfigList，使用自定义数据构造配置
                config = getMagicConfig(character, magicId);
                if (config != null)
                {
                    Log.Info($"[MagicMod] 使用 soulBossConfig 自定义配置 MagicID={magicId}");
                    if (soulConfig?.BuffId > 0)
                    {
                        BGUFunctionLibraryCS.BGUAddBuff(character, character, (int)(soulConfig?.BuffId), EBuffSourceType.GM, 5000);
                    }
                }
                else
                {
                    Log.Warn($"[MagicMod] soulBossConfig 配置构造失败 MagicID={magicId}，回退到 DAPath 加载");
                }
            }
            if (config == null)
            {
                if (string.IsNullOrEmpty(daPath))
                {
                    Log.Warn("[MagicMod] Magic DAPath 无效");
                    return;
                }

                config = b1.BGW.BGW_PreloadAssetMgr.Get(character).TryGetCachedResourceObj<BGWDataAsset_MagicallyChangeConfig>(daPath, b1.BGW.ELoadResourceType.SyncLoadAndCache);
                if (config == null)
                {
                    Log.Warn($"[MagicMod] 加载幻化变身配置失败 DAPath={daPath}");
                    return;
                }
            }

            BUS_EventCollectionCS.Get(character)?.Evt_OnCastMagicallyChangeSkill.Invoke(config, magicSkillId, recoverSkillId);
            // 幻化套用后，按配置隐藏玩家装备部件（如残躯被玩家头盖住导致秃头）
            ApplyMagicHideMeshes(character, soulConfig);
        }

        public static T? FindActorCompByClass<T>(BGUCharacterCS character) where T : UActorCompBaseCS
        {
            UActorCompContainerCS acc = character.ActorCompContainerCS;
            System.Reflection.FieldInfo field = typeof(UActorCompContainerCS).GetField("CompCSs", System.Reflection.BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null)
            {
                List<UActorCompBaseCS> comps = field.GetValue(acc) as List<UActorCompBaseCS>;
                if (comps == null) return null;
                foreach (var comp in comps)
                {
                    if (comp is T)
                    {
                        return (T)comp;
                    }
                }
            }
            return null;
        }
        public static T LoadAsset<T>(string asset) where T : UObject
        {
            var world = ModUtils.GetWorld();
            return BGW_PreloadAssetMgr.Get(world).TryGetCachedResourceObj<T>(asset, ELoadResourceType.SyncLoadAndCache, b1.BGW.EAssetPriority.Default, null, -1, -1);
        }
        public static UClass LoadClass(string asset)
        {
            return LoadAsset<UClass>(asset);
        }
        // 记录被"幻化隐藏"功能临时隐藏的 mesh 组件，变回/切换到其它形态时统一恢复，避免残留
        private static readonly HashSet<UPrimitiveComponent> _magicHiddenMeshes = new HashSet<UPrimitiveComponent>();

        /// <summary>
        /// 恢复上一轮被本系统隐藏的玩家部件（变回原角色或切换到无 HideMeshKeywords 的形态时调用）。
        /// </summary>
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
        private static void ApplyMagicHideMeshes(BGUPlayerCharacterCS character, SoulBossConfig? soulConfig)
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
                Log.Info($"[MagicMod] 幻化隐藏玩家部件 {cnt} 个 (keywords={string.Join(",", kws)})");
            }
            catch (Exception e) { Log.Warn($"[MagicMod] 幻化隐藏部件异常: {e.Message}"); }
        }

        /// <summary>
        /// 根据 soulBossConfig 自定义配置（按 magicID 匹配）构造一个全新的幻化变身配置对象。
        /// 返回的是新建的 UObject 实例，不会污染游戏缓存的资源对象。
        /// </summary>
        public static BGWDataAsset_MagicallyChangeConfig? getMagicConfig(BGUCharacterCS character, int magicID)
        {
            // 利用magicID查找 soulConfigList 获取配置项
            var model = GetSoulConfig(magicID);
            if (model == null)
            {
                Log.Warn($"[MagicMod] soulConfigList 中未找到 MagicID={magicID} 的配置");
                return null;
            }

            var BossConf = model.BossConf;
            if (BossConf == null)
            {
                Log.Warn($"[MagicMod] MagicID={magicID} 的 BossConf 为空");
                return null;
            }

            // 新建配置实例，避免直接修改缓存的资源配置对象
            var config = UObject.NewObject<BGWDataAsset_MagicallyChangeConfig>();
            if (config == null)
            {
                Log.Error($"[MagicMod] 创建 BGWDataAsset_MagicallyChangeConfig 实例失败 MagicID={magicID}");
                return null;
            }

            var world = ModUtils.GetWorld();
            string? abpClass = BossConf.ABPClass;
            if (!string.IsNullOrEmpty(abpClass))
            {
                config.ABPClass = LoadClass(abpClass);
            }
            string? skMesh = BossConf.SKMesh;
            if (!string.IsNullOrEmpty(skMesh))
            {
                config.SKMesh = UObject.LoadObject<USkeletalMesh>(world, skMesh);
            }
            config.CapsuleRadius = BossConf.CapsuleRadius;
            config.CapsuleHalfHeight = BossConf.CapsuleHalfHeight;
            config.Override_AbnormalDispID_Attacker = BossConf.Override_AbnormalDispID_Attacker;
            config.Override_AbnormalDispID_Victim = BossConf.Override_AbnormalDispID_Victim;
            config.TamerAssetPath = model.TamerPath;
            string? physicsAsset = BossConf.PhysicsAsset;
            if (!string.IsNullOrEmpty(physicsAsset))
            {
                config.PhysicsAsset = UObject.LoadObject<UPhysicsAsset>(world, physicsAsset);
            }
            config.TFXConfig.Clear();
            if (BossConf.TFXConfigs != null && BossConf.TFXConfigs.Count > 0)
            {
                for (int i = 0; i < BossConf.TFXConfigs.Count; i++)
                {
                    var item = default(FMagicallyChangeConfig_TFXConfig);
                    if (BossConf.TFXConfigs[i].TFXAsset != null)
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

                    if (BossConf.TFXConfigs[i].HairMaterial != null)
                    {
                        item.HairMaterial = UObject.LoadObject<UMaterialInterface>(world, BossConf.TFXConfigs[i].HairMaterial);
                    }

                    config.TFXConfig.Add(item);
                }
            }
            else
            {
                // BossConf 未显式配置 TFXConfigs 时，自动提取 boss 的 TressFX 毛发。
                // 残躯等 boss 的毛发是 TressFX 资产（或独立 mesh），不填 Config.TFXConfig 会被游戏 UpdateTressFXInfo 清空 -> 秃头。
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
                List<FUnitWeapon> weapons = new List<FUnitWeapon>();
                for (int i = 0; i < BossConf.Weapons.Count; i++)
                {
                    var item = BossConf.Weapons[i];
                    var weapon = default(FUnitWeapon);
                    if (!string.IsNullOrEmpty(item.Weapon))
                    {
                        weapon.Weapon = UObject.LoadClass<AActor>(null, item.Weapon);
                    }
                    weapon.SocketName = new FName(item.SocketName ?? "None");
                    weapons.Add(weapon);
                }
                config.Weapons.SetValues(weapons);
            }
            if (BossConf.UnitScale > 0 && BossConf.UnitScale != 1)
            {
                config.UnitScale = (float)BossConf.UnitScale;
            }
            else
            {
                config.UnitScale = (float)1.0;

            }

            return config;
        }

        /// <summary>
        /// BossConf 未配置 TFXConfigs 时，自动提取 boss 的 TressFX 毛发配置（按单位路径缓存，只提取一次）。
        /// 残躯等 boss 的毛发是 TressFX 资产（不在 SKMesh 上），不填 Config.TFXConfig 会被游戏 UpdateTressFXInfo 清空 -> 秃头。
        /// 提取策略：优先 CDO（瞬时零风险）；打包版 CDO 无 OwnedComponents 时，临时生成一只 boss 实例读真实组件，读完立即销毁。
        /// 缓存只存字符串路径 + 参数（不存 UObject），每次变身用 LoadObject 重新加载，避免打包版 UObject 被 GC 后野指针。
        /// </summary>
        private sealed class BossTfxEntry
        {
            public string AssetPath = string.Empty;
            public string? HairMatPath;
            public FTressFXShadeSettings ShadeSettings;
            public float LodScreenSize;
            public bool bEnableSimulation;
        }
        private static readonly Dictionary<string, List<BossTfxEntry>> _bossTfxCache = new();

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
                    if (!string.IsNullOrEmpty(e.HairMatPath))
                        item.HairMaterial = UObject.LoadObject<UMaterialInterface>(world, e.HairMatPath);
                    item.ShadeSettings = e.ShadeSettings;
                    item.LodScreenSize = e.LodScreenSize;
                    item.bEnableSimulation = e.bEnableSimulation;
                    config.TFXConfig.Add(item);
                    n++;
                }

                if (n == 0)
                {
                    Log.Warn($"[MagicMod] TFX 自动提取拿到 0 个 TressFX。" +
                             $"若变身仍秃头，说明残躯毛发可能是独立骨骼网格而非 TFX——请把上方 'boss 额外骨骼网格' 行发我，改用挂 mesh 方案。");
                }
                else
                {
                    Log.Info($"[MagicMod] TFX 自动提取完成：{n} 个 (单位={unitPath})");
                }
            }
            catch (Exception e) { Log.Warn($"[MagicMod] TFX 自动提取异常: {e.Message}"); }
        }

        /// <summary>真正提取 boss 的 TressFX 配置：先 CDO，失败则生成实例读组件。</summary>
        private static List<BossTfxEntry> ExtractBossTFX(UWorld world, string unitPath)
        {
            var result = new List<BossTfxEntry>();
            var unitCls = UObject.LoadClass<AActor>(world, unitPath);
            if (unitCls == null) { Log.Warn($"[MagicMod] 提取毛发失败：单位类加载失败 {unitPath}"); return result; }

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
            catch (Exception e) { Log.Warn($"[MagicMod] CDO 提取失败，转实例: {e.Message}"); }

            // 2) 生成实例（打包版 CDO 无 OwnedComponents，必须生成实体读真实组件）
            var pc = ModHelper.GetCharacter();
            var loc = pc != null ? pc.GetActorLocation() + pc.GetActorForwardVector() * 50f : FVector.ZeroVector;
            var rot = pc != null ? pc.GetActorRotation() : FRotator.ZeroRotator;
            var boss = BGUFunctionLibraryCS.BGUSpawnActor(world, unitCls, loc, rot);
            if (boss == null) { Log.Warn($"[MagicMod] 提取毛发失败：生成 {unitPath} 失败"); return result; }
            try
            {
                CollectTfx(boss, result, "[实例]");
                // 额外骨骼网格（排查"毛发是独立 mesh"的情况）
                var mainMesh = (boss as BGUCharacterCS)?.Mesh;
                foreach (var c in boss.GetComponentsByClass((TSubclassOf<UActorComponent>)UClass.GetClass<USkeletalMeshComponent>()))
                {
                    if (c is USkeletalMeshComponent smc && smc.SkeletalMesh != null && smc != mainMesh)
                        Log.Info($"[MagicMod] boss 额外骨骼网格(可能是毛发/部件): {smc.SkeletalMesh.GetPathName()} visible={ProbeVisibleOf(smc)}");
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
                    Log.Info($"[MagicMod] 提取到 boss 毛发[{result.Count - 1}] {tag} Asset={tfx.Asset.GetPathName()} HairMaterial={tfx.HairMaterial?.GetPathName() ?? "<null>"} Lod={tfx.LodScreenSize}");
                }
            }
        }

        /// <summary>
        /// Trans 动作：变身
        /// 优先使用 transConfig 中的自定义配置（按 ResId 匹配）：先注入 FUStUnitTransCommDesc，再触发变身；
        /// 未命中自定义配置时，回退到原有行为（直接按游戏已有 ResID 变身）。
        /// </summary>
        private static void DoTransAction(BGUPlayerCharacterCS character, ActionConfig action)
        {
            int ResId = (int)action.Value.GetValueOrDefault();
            if (ResId <= 0)
            {
                Log.Warn("[MagicMod] Trans ID 无效");
                return;
            }

            // 查找 transConfig 自定义配置，命中则确保变身描述已注入游戏配表
            TransConfig? transConfig = GetTransConfig(ResId);

            // 命中自定义配置且开启 UseTamerPossess 时不再生成 boss 傀儡附身。
            if (transConfig != null && transConfig.UseTamerPossess)
            {
                Log.Warn($"[MagicMod] 傀儡附身已停用 TransID={ResId} ({transConfig.name ?? "无名称"})");
                return;
            }

            // 命中自定义配置但未开启 UseTamerPossess 时也不再变身（傀儡附身已停用，原生变身系统已移除）。
            if (transConfig != null)
            {
                Log.Warn($"[MagicMod] 变身已停用 TransID={ResId} ({transConfig.name ?? "无名称"})");
                return;
            }

            int spawnSkillId = (int)action.magicSkill.GetValueOrDefault();
            bool needBlend = true;
            var beginType = EPlayerTransBeginType.SkillEffect;

            // 先触发变身前置逻辑
            BPS_GSEventCollection bPS_GSEventCollection = BPS_EventCollectionCS.Get((character as BGUPlayerCharacterCS).PlayerState);
            PlayerTransParam playerTransParam = new PlayerTransParam
            {
                TargetResId = ResId,
                SpawnSkillId = spawnSkillId,
                NeedBlend = needBlend
            };
            bPS_GSEventCollection.Evt_TriggerPlayerTransBegin.Invoke(beginType, playerTransParam);
        }

        /// <summary>
        /// 变身状态下，把基础输入(LightAttack/HeavyAttack/Dodge)重定向到 transConfig 指定的技能。
        /// 按当前被附身单位的 ResID 查配置；命中且配了对应技能 ID 则释放并返回 true。
        /// 未命中(非自定义变身单位或未配该输入)返回 false，由调用方保留游戏原有行为。
        /// </summary>
        public static bool TryDoTransInputSkill(BGUPlayerCharacterCS character, EInputActionType inputType)
        {
            if (character == null) return false;
            try
            {
                int resId = character.GetResID();
                var cfg = GetTransConfig(resId);
                if (cfg == null) return false;

                int skillId;
                switch (inputType)
                {
                    case EInputActionType.LightAttack: skillId = cfg.LightAttackSkillId ?? 0; break;
                    case EInputActionType.HeavyAttack: skillId = cfg.HeavyAttackSkillId ?? 0; break;
                    case EInputActionType.Dodge: skillId = cfg.DodgeSkillId ?? 0; break;
                    default: return false;
                }
                if (skillId <= 0) return false;

                BUS_EventCollectionCS.Get(character)?.Evt_RequestSmartCastSkill.Invoke(
                    skillId, null, EMontageBindReason.NormalSkill, false);
                Log.Info($"[MagicMod] 变身普攻重定向 ResID={resId} Input={inputType} -> SkillID={skillId}");
                return true;
            }
            catch (Exception e)
            {
                Log.Error($"[MagicMod] 变身普攻重定向失败 Input={inputType}: {e.Message}");
                return false;
            }
        }

        /// <summary>
        /// AddItem 动作：添加物品到背包
        /// </summary>
        private static void DoAddItemAction(BGUPlayerCharacterCS character, ActionConfig action)
        {
            int itemId = (int)action.Value;
            int count = action.Count.GetValueOrDefault(1);

            if (itemId <= 0)
            {
                Log.Warn("[MagicMod] AddItem ID 无效");
                return;
            }

            // 查找物品名称（用于日志）
            string itemName = "未知物品";
            if (ItemData.ItemArr_DANYAO.TryGetValue(itemId, out var danyaoName))
            {
                itemName = danyaoName;
            }
            else if (ItemData.ItemArr_paojiu_equip.TryGetValue(itemId, out var equipName))
            {
                itemName = equipName;
            }

            try
            {
                ModUtils.gain_item(itemId, count);
                Log.Info($"[MagicMod] 添加物品 ID={itemId}, 名称={itemName}, 数量={count}");
            }
            catch (Exception e)
            {
                Log.Error($"[MagicMod] 添加物品失败 ID={itemId}: {e.Message}");
            }
        }

        /// <summary>
        /// AddItemRange 动作：批量添加一段连续 ID 的物品（一键拿完整个分类）
        /// Values = [起始ID, 结束ID]（两个值时按闭区间展开；其他情况按显式 ID 列表处理）
        /// Count = 每个物品给几个（默认 1）
        /// </summary>
        private static void DoAddItemRangeAction(BGUPlayerCharacterCS character, ActionConfig action)
        {
            if (action.Values == null || action.Values.Count == 0)
            {
                Log.Warn("[MagicMod] AddItemRange 缺少 Values（[起始ID,结束ID] 或 ID 列表）");
                return;
            }

            int perCount = action.Count.GetValueOrDefault(1);
            if (perCount < 1) perCount = 1;

            List<int> ids = new List<int>();
            if (action.Values.Count == 2)
            {
                int start = action.Values[0];
                int end = action.Values[1];
                if (start > end)
                {
                    int tmp = start;
                    start = end;
                    end = tmp;
                }
                if (end - start > 5000)
                {
                    Log.Warn($"[MagicMod] AddItemRange 区间过大（{start}~{end}），已截断到 5000 个");
                    end = start + 5000;
                }
                for (int id = start; id <= end; id++) ids.Add(id);
            }
            else
            {
                ids.AddRange(action.Values);
            }

            try
            {
                int added = ModUtils.gain_items(ids, perCount);
                Log.Info($"[MagicMod] 批量添加物品 {added} 种，每种 {perCount} 个，区间 {ids[0]}~{ids[ids.Count - 1]}");
            }
            catch (Exception e)
            {
                Log.Error($"[MagicMod] 批量添加物品失败: {e.Message}");
            }
        }

        /// <summary>
        /// TeleportTarget 动作：传送到锁定目标附近
        /// </summary>
        private static void DoTeleportTargetAction(ActionConfig action)
        {
            float offsetDistance = 200f;
            if (action.Params != null && action.Params.TryGetValue("OffsetDistance", out var offsetObj))
            {
                float.TryParse(offsetObj.ToString(), out offsetDistance);
            }
            else if (action.Value.HasValue)
            {
                offsetDistance = action.Value.Value;
            }
            ModHelper.TeleportNearTarget(offsetDistance);
        }

        /// <summary>
        /// TeleportTargetToFront 动作：把锁定的目标拉到自己正前方，并让它背对自己
        /// </summary>
        private static void DoTeleportTargetToFrontAction(ActionConfig action)
        {
            float distance = 500f;
            string facing = "away";
            bool groundSnap = true;

            if (action.Value.HasValue) distance = action.Value.Value;

            if (action.Params != null)
            {
                if (action.Params.TryGetValue("Distance", out var dObj) && float.TryParse(dObj?.ToString(), out var dVal)) distance = dVal;
                if (action.Params.TryGetValue("Facing", out var fObj) && fObj != null) facing = fObj.ToString() ?? "away";
                if (action.Params.TryGetValue("GroundSnap", out var gObj) && bool.TryParse(gObj?.ToString(), out var gVal)) groundSnap = gVal;
            }

            ModHelper.TeleportTargetToFront(distance, facing, groundSnap);
        }

        /// <summary>
        /// CalcAMScale 动作：计算并设置 AMScale 缩放率
        /// </summary>
        private static void DoCalcAMScaleAction(ActionConfig action)
        {
            float totalDuration = 0.3f;
            float notifyBeginTime = 0f;
            float notifyEndTime = 0.3f;
            float minRate = 0.01f;
            float maxRate = 20f;
            float moveOffset = 0f;
            float moveOffsetZ = 0f;

            if (action.Params != null)
            {
                if (action.Params.TryGetValue("TotalDuration", out var td) && float.TryParse(td.ToString(), out var tdVal)) totalDuration = tdVal;
                if (action.Params.TryGetValue("NotifyBeginTime", out var nbt) && float.TryParse(nbt.ToString(), out var nbtVal)) notifyBeginTime = nbtVal;
                if (action.Params.TryGetValue("NotifyEndTime", out var net) && float.TryParse(net.ToString(), out var netVal)) notifyEndTime = netVal;
                if (action.Params.TryGetValue("MinRate", out var minr) && float.TryParse(minr.ToString(), out var minrVal)) minRate = minrVal;
                if (action.Params.TryGetValue("MaxRate", out var maxr) && float.TryParse(maxr.ToString(), out var maxrVal)) maxRate = maxrVal;
                if (action.Params.TryGetValue("MoveOffset", out var mo) && float.TryParse(mo.ToString(), out var moVal)) moveOffset = moVal;
                if (action.Params.TryGetValue("MoveOffsetZ", out var moz) && float.TryParse(moz.ToString(), out var mozVal)) moveOffsetZ = mozVal;
            }

            ModHelper.CalcAMScale(totalDuration, notifyBeginTime, notifyEndTime, minRate, maxRate, moveOffset, moveOffsetZ);
        }

        /// <summary>
        /// 延迟执行动作
        /// 计时基于游戏世界时间（UWorld.TimeSeconds），会随全局 TimeDilation（"时缓"）一起变慢，
        /// 与动画/物理节奏保持同步；避免 Task.Delay 走系统时钟导致的时序错位。
        /// </summary>
        private static async Task ExecuteDelayed(BGUPlayerCharacterCS character, ActionConfig action, HashSet<ActionType> executedTypes, FEffectInstReq? effectInstReq)
        {
            await WaitForGameTime((action.Delay ?? 0) / 1000f);
            // await Task.Delay((int)(action.Delay ?? 0) / 1000);
            Utils.TryRunOnGameThread(() =>
            {
                var player = ModHelper.GetCharacter();
                if (player != null)
                {
                    // 检查-执行-标记 必须在同一个锁内，防止并发时同类型重复执行
                    lock (_typeLock)
                    {
                        // bullet 类型允许同类型多次执行（每次 ProjectileID 不同）
                        bool needDedup = action.Type != ActionType.bullet;
                        if (needDedup && executedTypes.Contains(action.Type))
                        {
                            Log.Info($"[MagicMod] 延迟动作跳过 Type={action.Type}，同类型已执行过");
                            return;
                        }
                        if (DoAction(player, action, effectInstReq))
                        {
                            if (needDedup) executedTypes.Add(action.Type);
                        }
                    }
                }
            });
        }

        /// <summary>
        /// 基于游戏世界时间等待指定秒数。
        /// 读取 UWorld.TimeSeconds（等价于 UGameplayStatics.GetTimeSeconds），该值会随全局
        /// TimeDilation（"时缓"）一起变慢，因此延迟与游戏内动画/物理节奏同步；暂停时也会冻结。
        /// 若希望延迟不受时缓影响（纯墙钟），可把下方 GetTimeSeconds 换成 RealTimeSeconds。
        /// 通过 WorldTimeHelper 直接读内存，可安全在后台线程轮询，无需切回游戏线程。
        /// </summary>
        /// <param name="seconds">游戏时间秒数</param>
        private static async Task WaitForGameTime(float seconds)
        {
            if (seconds <= 0f) return;

            IntPtr worldAddress = EngineLoop.WorldTime.WorldAddress;
            if (worldAddress == IntPtr.Zero)
            {
                // 世界尚未就绪（如刚启动/切场景），退回系统时钟保证功能可用
                await Task.Delay((int)(seconds * 1000f));
                return;
            }

            float targetTime = WorldTimeHelper.GetTimeSeconds(worldAddress) + seconds;

            // 墙钟兜底：TimeSeconds 受全局 TimeDilation 影响，暂停 / 时缓 / 过场时会被冻结，
            // 此时 targetTime 永远达不到，任务会永久挂起并一直持有 character 等 UObject 引用
            // （每次触发泄漏一个 Task，每 8ms 唤醒一次）。这里加一个墙钟上限保证一定会退出。
            int wallClockLimitMs = Math.Max(1000, (int)(seconds * 1000f * 3));
            Stopwatch wallClock = Stopwatch.StartNew();

            // 轮询间隔 8ms：兼顾精度与 CPU 占用；实际经过时长由 TimeDilation 决定
            const int pollIntervalMs = 8;
            while (true)
            {
                // 世界被切换/销毁时提前结束，避免访问无效内存
                if (EngineLoop.WorldTime.WorldAddress != worldAddress) break;
                if (WorldTimeHelper.GetTimeSeconds(worldAddress) >= targetTime) break;
                if (wallClock.ElapsedMilliseconds >= wallClockLimitMs)
                {
                    Log.Warn($"[MagicMod] WaitForGameTime 超过墙钟上限 {wallClockLimitMs}ms 仍未等到游戏时间 {seconds}s（可能处于暂停/时缓），提前退出");
                    break;
                }
                await Task.Delay(pollIntervalMs);
            }
        }
    }
}
