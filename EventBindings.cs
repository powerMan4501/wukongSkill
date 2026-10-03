using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using b1;
using BtlB1;
using BtlShare;
using CSharpModBase;
using Newtonsoft.Json;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace ActionsMod
{
    /// <summary>
    /// 事件驱动子系统（从 MagicMod 迁移）：把「游戏事件 → 一组动作」的配置加载进缓存，并在事件回调里分发执行。
    /// 与 ActionExecutor 的「按键 → 动作」路径互补：
    ///   - SweepCheck/  按动画路径 + NotifyBeginTime 触发（sweep_actions），并承载 cast_actions / bullet_actions
    ///   - BuffActions/ 按 BuffID 触发
    ///   - EffectActions/ 按 EffectID 触发
    ///   - Projectile/  按生成的弹体 Actor PathName 应用缩放与法术场 Buff 覆盖
    /// 这套表格是否在游戏里生效，取决于有没有执行 RegEvents 动作去订阅事件（见 ModEvents）。
    /// </summary>
    public static class EventBindings
    {
        // SweepCheck 动画绑定配置缓存
        private static List<SweepCheckBindingConfig> _sweepCheckBindings = new List<SweepCheckBindingConfig>();

        // Projectile 生成绑定配置缓存
        private static List<ProjectileBindingConfig> _projectileBindings = new List<ProjectileBindingConfig>();

        // BuffID → 动作列表 绑定配置缓存（BuffBegin 时按 BuffID 触发）
        private static readonly Dictionary<int, IdActionBindingConfig> _buffActionBindings = new Dictionary<int, IdActionBindingConfig>();

        // EffectID → 动作列表 绑定配置缓存（OnTriggerSkillEffect 时按 EffectID 触发）
        private static readonly Dictionary<int, IdActionBindingConfig> _effectActionBindings = new Dictionary<int, IdActionBindingConfig>();

        // 输入技能重定向绑定配置缓存（Evt_InputCastSkill）
        private static List<InputCastBindingConfig> _inputCastBindings = new List<InputCastBindingConfig>();

        // 定身 / 激光弹绑定配置缓存（Evt_CastImmobilize）
        private static List<ImmobilizeBindingConfig> _immobilizeBindings = new List<ImmobilizeBindingConfig>();

        // 造成伤害绑定配置缓存（Evt_OnSkillCostDmg）
        private static List<SkillCostDmgBindingConfig> _skillCostDmgBindings = new List<SkillCostDmgBindingConfig>();

        // 结算伤害（受击/攻击）绑定配置缓存（Evt_TriggerNormalDamageEffect）
        private static List<NormalDamageBindingConfig> _normalDamageBindings = new List<NormalDamageBindingConfig>();

        /// <summary>最近一次伤害上下文（供 add_attr 百分比模式 / reflect_damage 使用，单线程游戏回调内有效）</summary>
        public struct DamageContext
        {
            public AActor? Attacker;
            public float Dmg;
            public FSkillDamageConfig SkillDamageConfig;
            public FEffectInstReq EffectInstReq;
            public FBattleAttrSnapShot AttrMemData;
            public bool Valid => Attacker != null;
        }

        private static DamageContext _lastDamage = default;

        /// <summary>当前（最近一次）伤害上下文</summary>
        public static DamageContext LastDamage => _lastDamage;

        /// <summary>最近一次伤害量：add_attr 的 AttrPercent 用它做基数</summary>
        public static float LastDamageValue => _lastDamage.Dmg;

        private static void SetLastDamage(AActor? attacker, float dmg, FSkillDamageConfig dmgConfig,
            in FEffectInstReq req, in FBattleAttrSnapShot attrMemData)
        {
            _lastDamage = new DamageContext
            {
                Attacker = attacker,
                Dmg = dmg,
                SkillDamageConfig = dmgConfig,
                EffectInstReq = req,
                AttrMemData = attrMemData
            };
        }

        /// <summary>按 Anim 关键字查找 SweepCheck 绑定里配置的 addRadius（没命中返回 null）</summary>
        public static int? GetAddRadius(string animationPath)
        {
            if (string.IsNullOrEmpty(animationPath)) return null;
            foreach (var binding in _sweepCheckBindings)
            {
                if (string.IsNullOrEmpty(binding.Animation)) continue;
                if (animationPath.IndexOf(binding.Animation, StringComparison.OrdinalIgnoreCase) >= 0) return binding.addRadius;
            }
            return null;
        }

        // ===================== 初始化 =====================

        /// <summary>初始化 SweepCheck 动画绑定配置</summary>
        public static void InitSweepCheckBindings(List<SweepCheckBindingConfig> bindings)
        {
            _sweepCheckBindings = bindings ?? new List<SweepCheckBindingConfig>();
            Log.Info($"[ActionsMod] 初始化 SweepCheck 绑定配置，共 {_sweepCheckBindings.Count} 条规则");
            foreach (var sc in _sweepCheckBindings)
            {
                if (sc.bullet_actions != null && sc.bullet_actions.Count > 0)
                {
                    foreach (var ba in sc.bullet_actions)
                    {
                        Log.Info($"[ActionsMod]   Animation='{sc.Animation}' bullet_actions ProjectileID={ba.ID} -> {ba.actions.Count} 个动作");
                    }
                }
                if (sc.sweep_actions != null && sc.sweep_actions.Count > 0)
                {
                    int totalActions = 0;
                    foreach (var g in sc.sweep_actions) totalActions += g.Actions.Count;
                    Log.Info($"[ActionsMod]   Animation='{sc.Animation}' (多时间点) -> {sc.sweep_actions.Count} 个时间点组, 共 {totalActions} 个动作");
                }
                else
                {
                    Log.Info($"[ActionsMod]   Animation='{sc.Animation}', NotifyBeginTime={sc.NotifyBeginTime?.ToString() ?? "任意"} -> {sc.Actions.Count} 个动作");
                }
            }
        }

        /// <summary>初始化 Projectile 生成绑定配置</summary>
        public static void InitProjectileBindings(List<ProjectileBindingConfig> bindings)
        {
            _projectileBindings = bindings ?? new List<ProjectileBindingConfig>();
            Log.Info($"[ActionsMod] 初始化 Projectile 绑定配置，共 {_projectileBindings.Count} 条规则");
            foreach (var pb in _projectileBindings)
            {
                string scaleDesc = pb.config?.Scale3D != null
                    ? $"({pb.config.Scale3D.X}, {pb.config.Scale3D.Y}, {pb.config.Scale3D.Z})"
                    : "无";
                int buffCount = pb.config?.FieldBuffList?.Count ?? 0;
                Log.Info($"[ActionsMod]   PathName='{pb.pathName}' -> Scale3D={scaleDesc}, FieldBuffList={buffCount} 个");
            }
        }

        /// <summary>初始化 ID 动作绑定配置（BuffActions / EffectActions），同 ID 后加载的覆盖先加载的</summary>
        private static void InitIdActionBindings(List<IdActionBindingConfig> bindings,
            Dictionary<int, IdActionBindingConfig> cache, string tag)
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
            Log.Info($"[ActionsMod] 初始化 {tag} 绑定配置，共 {cache.Count} 条规则");
            foreach (var kvp in cache)
            {
                Log.Info($"[ActionsMod]   {tag} ID={kvp.Key} ({kvp.Value.name ?? "无名称"}) -> {kvp.Value.actions.Count} 个动作");
            }
        }

        /// <summary>初始化 Buff 动作绑定配置（BuffBegin 时按 BuffID 触发）</summary>
        public static void InitBuffActionBindings(List<IdActionBindingConfig> bindings)
            => InitIdActionBindings(bindings, _buffActionBindings, "BuffActions");

        /// <summary>初始化 Effect 动作绑定配置（OnTriggerSkillEffect 时按 EffectID 触发）</summary>
        public static void InitEffectActionBindings(List<IdActionBindingConfig> bindings)
            => InitIdActionBindings(bindings, _effectActionBindings, "EffectActions");

        /// <summary>初始化输入技能重定向绑定配置（InputCast/）</summary>
        public static void InitInputCastBindings(List<InputCastBindingConfig> bindings)
        {
            _inputCastBindings = bindings ?? new List<InputCastBindingConfig>();
            Log.Info($"[ActionsMod] 初始化 InputCast 绑定配置，共 {_inputCastBindings.Count} 条规则");
            foreach (var b in _inputCastBindings)
            {
                Log.Info($"[ActionsMod]   InputCast '{b.name ?? "无名称"}' Type={b.InputActionType ?? "任意"}, SkillIDs={b.SkillIDs?.Count ?? 0} 个, IsRelease={b.IsRelease?.ToString() ?? "任意"} -> {b.actions.Count} 个动作");
            }
        }

        /// <summary>初始化定身绑定配置（Immobilize/）</summary>
        public static void InitImmobilizeBindings(List<ImmobilizeBindingConfig> bindings)
        {
            _immobilizeBindings = bindings ?? new List<ImmobilizeBindingConfig>();
            Log.Info($"[ActionsMod] 初始化 Immobilize 绑定配置，共 {_immobilizeBindings.Count} 条规则");
            foreach (var b in _immobilizeBindings)
            {
                Log.Info($"[ActionsMod]   Immobilize '{b.name ?? "无名称"}' ConfigIDs={b.ConfigIDs?.Count ?? 0} 个 -> {b.actions.Count} 个动作");
            }
        }

        /// <summary>初始化造成伤害绑定配置（SkillCostDmg/）</summary>
        public static void InitSkillCostDmgBindings(List<SkillCostDmgBindingConfig> bindings)
        {
            _skillCostDmgBindings = bindings ?? new List<SkillCostDmgBindingConfig>();
            Log.Info($"[ActionsMod] 初始化 SkillCostDmg 绑定配置，共 {_skillCostDmgBindings.Count} 条规则");
            foreach (var b in _skillCostDmgBindings)
            {
                Log.Info($"[ActionsMod]   SkillCostDmg '{b.name ?? "无名称"}' SkillID={b.SkillID?.ToString() ?? "任意"}, SkillIDs={b.SkillIDs?.Count ?? 0} 个, MinDmg={b.MinDmg?.ToString() ?? "不限制"} -> {b.actions.Count} 个动作");
            }
        }

        /// <summary>初始化结算伤害绑定配置（NormalDamageEffect/）</summary>
        public static void InitNormalDamageBindings(List<NormalDamageBindingConfig> bindings)
        {
            _normalDamageBindings = bindings ?? new List<NormalDamageBindingConfig>();
            Log.Info($"[ActionsMod] 初始化 NormalDamageEffect 绑定配置，共 {_normalDamageBindings.Count} 条规则");
            foreach (var b in _normalDamageBindings)
            {
                Log.Info($"[ActionsMod]   NormalDamageEffect '{b.name ?? "无名称"}' BuffIds={b.BuffIds?.Count ?? 0} 个, CheckAttacker={b.CheckAttacker} -> {b.actions.Count} 个动作");
            }
        }

        // ===================== 配置加载（从 Mod 目录下的各文件夹）=====================

        /// <summary>加载全部事件驱动绑定配置（目录不存在时静默跳过）</summary>
        /// <param name="modDir">Mod 根目录，如 ...\CSharpLoader\Mods\ActionsMod</param>
        public static void LoadAll(string modDir)
        {
            InitSweepCheckBindings(LoadJsonList<SweepCheckBindingConfig>(modDir, "SweepCheck"));
            InitProjectileBindings(LoadJsonList<ProjectileBindingConfig>(modDir, "Projectile"));
            InitBuffActionBindings(LoadJsonList<IdActionBindingConfig>(modDir, "BuffActions"));
            InitEffectActionBindings(LoadJsonList<IdActionBindingConfig>(modDir, "EffectActions"));
            InitInputCastBindings(LoadJsonList<InputCastBindingConfig>(modDir, "InputCast"));
            InitImmobilizeBindings(LoadJsonList<ImmobilizeBindingConfig>(modDir, "Immobilize"));
            InitSkillCostDmgBindings(LoadJsonList<SkillCostDmgBindingConfig>(modDir, "SkillCostDmg"));
            InitNormalDamageBindings(LoadJsonList<NormalDamageBindingConfig>(modDir, "NormalDamageEffect"));
        }

        /// <summary>加载某文件夹下所有 json，每个文件都按 List&lt;T&gt; 解析并汇总</summary>
        private static List<T> LoadJsonList<T>(string modDir, string folderName)
        {
            var result = new List<T>();
            string dir = Path.Combine(modDir, folderName);
            if (!Directory.Exists(dir))
            {
                Log.Info($"[ActionsMod] {folderName} 目录不存在（可选）: {dir}");
                return result;
            }

            string[] jsonFiles = Directory.GetFiles(dir, "*.json");
            Log.Info($"[ActionsMod] 扫描 {folderName} 目录，找到 {jsonFiles.Length} 个配置文件");

            foreach (string filePath in jsonFiles)
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    var list = JsonConvert.DeserializeObject<List<T>>(json);
                    if (list != null)
                    {
                        result.AddRange(list);
                        Log.Info($"[ActionsMod]   加载 {folderName}/{Path.GetFileName(filePath)}: {list.Count} 条规则");
                    }
                }
                catch (Exception e)
                {
                    Log.Error($"[ActionsMod] 加载 {folderName} 配置失败 {filePath}: {e.Message}");
                }
            }
            return result;
        }

        // ===================== 事件分发 =====================

        /// <summary>按 ID 查找绑定并执行动作（供 BuffBegin / OnTriggerSkillEffect 复用）</summary>
        private static void DoIdActions(BGUPlayerCharacterCS character, int id,
            Dictionary<int, IdActionBindingConfig> cache, FEffectInstReq? effectInstReq)
        {
            if (character == null || id <= 0 || cache.Count == 0) return;
            if (!cache.TryGetValue(id, out var binding) || binding.actions == null || binding.actions.Count == 0) return;

            // 高频回调（每秒几十次）：只有命中配置才走到 DoActions，未命中时不做任何字符串拼接
            ActionExecutor.DoActions(character, binding.actions, effectInstReq);
        }

        /// <summary>Buff 添加时按 BuffID 匹配并执行配置动作</summary>
        public static void DoBuffBeginActions(BGUPlayerCharacterCS character, int buffId)
            => DoIdActions(character, buffId, _buffActionBindings, null);

        /// <summary>技能效果触发时按 EffectID 匹配并执行配置动作</summary>
        public static void DoSkillEffectActions(BGUPlayerCharacterCS character, int effectId, FEffectInstReq effectInstReq)
            => DoIdActions(character, effectId, _effectActionBindings, effectInstReq);

        /// <summary>
        /// 子弹/法术场 Actor 生成时，按 PathName 匹配 Projectile 绑定并应用覆盖（缩放 + 法术场 Buff）。
        /// 首次匹配后停止。
        /// </summary>
        public static void ApplyProjectileBindings(AActor ower)
        {
            if (ower == null || _projectileBindings.Count == 0) return;
            string pathName = ower.PathName;
            if (string.IsNullOrEmpty(pathName)) return;

            foreach (var binding in _projectileBindings)
            {
                if (string.IsNullOrEmpty(binding.pathName) || binding.config == null) continue;
                if (pathName.IndexOf(binding.pathName, StringComparison.OrdinalIgnoreCase) < 0) continue;

                if (ModLog.Verbose) ModLog.Info($"[ActionsMod] Projectile 匹配 PathName='{binding.pathName}', Actor='{pathName}'");

                if (binding.config.Scale3D != null)
                {
                    ower.SetActorRelativeScale3D(new FVector(
                        binding.config.Scale3D.X,
                        binding.config.Scale3D.Y,
                        binding.config.Scale3D.Z));
                }

                if (binding.config.FieldBuffList != null && binding.config.FieldBuffList.Count > 0)
                {
                    BUC_MFOverlapData? mfOverlapData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_MFOverlapData>(ower);
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
                                    TargetTeamFilter = 4,  // 4 表示敌人
                                    TargetTypeFilter = 1   // 1 表示角色
                                });
                                if (ModLog.Verbose) ModLog.Info($"[ActionsMod] 法术场追加 FieldBuff ID={buffId}");
                            }
                        }
                    }
                    else
                    {
                        Log.Warn($"[ActionsMod] Actor 无 BUC_MFOverlapData，跳过 FieldBuffList: {pathName}");
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
            if (character == null || _sweepCheckBindings.Count == 0) return;
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

                    if (ModLog.Verbose) ModLog.Info($"[ActionsMod] BulletSpawn 匹配 Animation='{binding.Animation}', ProjectileID={projectileId}，执行 {group.actions.Count} 个动作");
                    ActionExecutor.DoActions(character, group.actions);
                }
            }
        }

        /// <summary>根据技能 TemplatePath 匹配并执行 cast_actions（复用 SweepCheck 配置，按 Animation 关键字匹配）</summary>
        public static void DoCastActions(BGUPlayerCharacterCS character, string templatePath)
        {
            if (character == null || _sweepCheckBindings.Count == 0) return;
            if (string.IsNullOrEmpty(templatePath)) return;

            foreach (var binding in _sweepCheckBindings)
            {
                if (string.IsNullOrEmpty(binding.Animation)) continue;
                if (binding.cast_actions == null || binding.cast_actions.Count == 0) continue;
                if (templatePath.IndexOf(binding.Animation, StringComparison.OrdinalIgnoreCase) < 0) continue;

                if (ModLog.Verbose) ModLog.Info($"[ActionsMod] CastSkill 匹配 Animation='{binding.Animation}'，执行 {binding.cast_actions.Count} 个 cast_actions");
                ActionExecutor.DoActions(character, binding.cast_actions);
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
            if (character == null || _sweepCheckBindings.Count == 0) return;
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
                        if (group.NotifyBeginTime.HasValue
                            && notifyBeginTime.ToString() != group.NotifyBeginTime.Value.ToString()) continue;

                        if (ModLog.Verbose) ModLog.Info($"[ActionsMod] SweepCheck 匹配 Animation='{binding.Animation}', Time={notifyBeginTime}，执行 {group.Actions.Count} 个动作");
                        ActionExecutor.DoActions(character, group.Actions);
                    }
                    continue; // 新格式已处理，跳过旧格式逻辑
                }

                // 旧格式：顶层 NotifyBeginTime + Actions
                if (binding.NotifyBeginTime.HasValue
                    && notifyBeginTime.ToString() != binding.NotifyBeginTime.Value.ToString()) continue;

                if (ModLog.Verbose) ModLog.Info($"[ActionsMod] SweepCheck 匹配 Animation='{binding.Animation}', Time={notifyBeginTime}，执行 {binding.Actions.Count} 个动作");
                ActionExecutor.DoActions(character, binding.Actions);
                break; // 旧格式首次匹配后停止
            }
        }

        // ===================== 输入 / 伤害类事件分发 =====================

        /// <summary>输入技能被释放时（Evt_InputCastSkill）按输入类型 + 技能ID 命中并执行的配置动作（技能重定向）</summary>
        public static void DoInputCastActions(BGUPlayerCharacterCS character, EInputActionType inputActionType,
            bool isRelease, int skillId)
        {
            if (character == null || _inputCastBindings.Count == 0) return;

            string typeName = inputActionType.ToString();
            foreach (var binding in _inputCastBindings)
            {
                if (binding.actions == null || binding.actions.Count == 0) continue;
                if (!string.IsNullOrEmpty(binding.InputActionType)
                    && !typeName.Equals(binding.InputActionType, StringComparison.OrdinalIgnoreCase)) continue;
                if (binding.IsRelease.HasValue && binding.IsRelease.Value != isRelease) continue;
                if (binding.SkillIDs != null && binding.SkillIDs.Count > 0 && !binding.SkillIDs.Contains(skillId)) continue;

                if (ModLog.Verbose) ModLog.Info($"[ActionsMod] InputCast 命中 '{binding.name ?? "无名称"}' {typeName} SkillID={skillId}，执行 {binding.actions.Count} 个动作");
                ActionExecutor.DoActions(character, binding.actions);
            }
        }

        /// <summary>释放定身时（Evt_CastImmobilize）命中并执行的配置动作（典型：bullet 激光弹）</summary>
        public static void DoImmobilizeActions(BGUPlayerCharacterCS character, int configId)
        {
            if (character == null || _immobilizeBindings.Count == 0) return;

            foreach (var binding in _immobilizeBindings)
            {
                if (binding.actions == null || binding.actions.Count == 0) continue;
                if (binding.ConfigIDs != null && binding.ConfigIDs.Count > 0 && !binding.ConfigIDs.Contains(configId)) continue;

                if (ModLog.Verbose) ModLog.Info($"[ActionsMod] Immobilize 命中 '{binding.name ?? "无名称"}' ConfigID={configId}，执行 {binding.actions.Count} 个动作");
                ActionExecutor.DoActions(character, binding.actions);
            }
        }

        /// <summary>
        /// 技能造成伤害时（Evt_OnSkillCostDmg）执行的配置动作。
        /// 会把伤害量写进上下文，供后续 add_attr 的 AttrPercent 作为基数。
        /// </summary>
        public static void DoSkillCostDmgActions(BGUPlayerCharacterCS character, AActor victim, int skillId, int finalDmg, bool isCrit)
        {
            if (character == null || _skillCostDmgBindings.Count == 0) return;

            SetLastDamage(victim, finalDmg, default(FSkillDamageConfig), default(FEffectInstReq), default(FBattleAttrSnapShot));
            try
            {
                foreach (var binding in _skillCostDmgBindings)
                {
                    if (binding.actions == null || binding.actions.Count == 0) continue;
                    if (binding.NeedCrit.HasValue && binding.NeedCrit.Value != isCrit) continue;
                    if (binding.MinDmg.HasValue && finalDmg < binding.MinDmg.Value) continue;

                    bool hasSkillFilter = binding.SkillID.HasValue || (binding.SkillIDs != null && binding.SkillIDs.Count > 0);
                    if (hasSkillFilter)
                    {
                        bool skillMatched = (binding.SkillID.HasValue && binding.SkillID.Value == skillId)
                            || (binding.SkillIDs != null && binding.SkillIDs.Contains(skillId));
                        if (!skillMatched) continue;
                    }

                    if (ModLog.Verbose) ModLog.Info($"[ActionsMod] SkillCostDmg 命中 '{binding.name ?? "无名称"}' SkillID={skillId}, Dmg={finalDmg}，执行 {binding.actions.Count} 个动作");
                    ActionExecutor.DoActions(character, binding.actions);
                }
            }
            finally
            {
                _lastDamage = default;
            }
        }

        // ===== 手动触发（绑在按键上时忽略匹配条件，跑该类配置里的全部规则，便于调配置）=====

        /// <summary>执行一次 InputCast/ 里所有规则的动作</summary>
        public static void RunAllInputCastActions(BGUPlayerCharacterCS character)
        {
            foreach (var binding in _inputCastBindings)
            {
                if (binding?.actions == null || binding.actions.Count == 0) continue;
                ActionExecutor.DoActions(character, binding.actions);
            }
        }

        /// <summary>执行一次 Immobilize/ 里所有规则的动作（激光弹调试用）</summary>
        public static void RunAllImmobilizeActions(BGUPlayerCharacterCS character)
        {
            foreach (var binding in _immobilizeBindings)
            {
                if (binding?.actions == null || binding.actions.Count == 0) continue;
                ActionExecutor.DoActions(character, binding.actions);
            }
        }

        /// <summary>执行一次 SkillCostDmg/ 里所有规则的动作（回血回蓝调试用，注意此时没有伤害上下文）</summary>
        public static void RunAllSkillCostDmgActions(BGUPlayerCharacterCS character)
        {
            foreach (var binding in _skillCostDmgBindings)
            {
                if (binding?.actions == null || binding.actions.Count == 0) continue;
                ActionExecutor.DoActions(character, binding.actions);
            }
        }

        /// <summary>
        /// 结算伤害时（Evt_TriggerNormalDamageEffect）执行的配置动作，典型用途是"反弹伤害"。
        /// 只有攻击者不是自己时才考虑；可要求自己（或攻击者）持有指定 Buff 作为触发门槛。
        /// 会把攻击者与伤害数据写入上下文，供 reflect_damage 取用。
        /// </summary>
        public static void DoNormalDamageActions(BGUPlayerCharacterCS character, AActor attacker,
            FSkillDamageConfig skillDamageConfig, in FEffectInstReq effectInstReq, in FBattleAttrSnapShot attrMemData)
        {
            if (character == null || attacker == null || _normalDamageBindings.Count == 0) return;
            if (attacker.PathName == character.PathName) return; // 自己打自己不算

            SetLastDamage(attacker, 0f, skillDamageConfig, in effectInstReq, in attrMemData);
            try
            {
                foreach (var binding in _normalDamageBindings)
                {
                    if (binding.actions == null || binding.actions.Count == 0) continue;

                    if (binding.BuffIds != null && binding.BuffIds.Count > 0)
                    {
                        var checkTarget = binding.CheckAttacker ? attacker : (AActor)character;
                        bool hasBuff = false;
                        foreach (int buffId in binding.BuffIds)
                        {
                            if (BGUFunctionLibraryCS.BGUHasBuffByID(checkTarget, buffId)) { hasBuff = true; break; }
                        }
                        if (!hasBuff) continue;
                    }

                    if (ModLog.Verbose) ModLog.Info($"[ActionsMod] NormalDamageEffect 命中 '{binding.name ?? "无名称"}' Attacker={attacker.PathName}，执行 {binding.actions.Count} 个动作");
                    ActionExecutor.DoActions(character, binding.actions);
                }
            }
            finally
            {
                _lastDamage = default;
            }
        }
    }
}
