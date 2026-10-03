using System;
using System.Reflection;
using System.Collections.Generic;
using b1;
using b1.Plugins.Calliope;
using BtlShare;
using CSharpModBase;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using b1.EventDelDefine;
using b1.BGW;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using BtlB1;

namespace MagicMod
{
    /// <summary>
    /// 游戏 API 辅助方法封装
    /// </summary>
    public static class ModHelper
    {
        /// <summary>
        /// GetCharacter 缓存有效期（毫秒）。
        /// 这是本 Mod 调用最频繁的方法：SweepCheckBegin / BuffBegin / OnTriggerSkillEffect /
        /// OnTriggerNormalDamageEffect / OnSkillCostDmg
        /// 全部以它为入口，战斗中原地每秒可达上千次，而每次都要走
        /// GCHelper.FindRef(GWorld) → GetFirstLocalPlayerController → GetControlledPawn 三次跨边界查询。
        /// 缓存后同一帧内的重复查询直接复用；TTL 取 100ms（约 6 帧），
        /// 兼顾"受控 Pawn 会变"（变身 / 傀儡附身 / 切场景）的实时性。
        /// </summary>
        private const int CharacterCacheTtlMs = 100;

        private static BGUPlayerCharacterCS? _cachedCharacter;
        private static int _cachedCharacterTick = 0;

        /// <summary>
        /// 主动失效角色缓存。变身 / 傀儡附身 / 切场景 / Mod 重载时调用，
        /// 避免拿到旧的 Pawn 引用。
        /// </summary>
        public static void InvalidateCharacterCache()
        {
            _cachedCharacter = null;
            _cachedCharacterTick = 0;
        }

        /// <summary>
        /// 获取当前玩家角色（带 100ms 缓存）
        /// </summary>
        public static BGUPlayerCharacterCS? GetCharacter()
        {
            return GetCharacter(false);
        }

        /// <summary>
        /// 获取当前玩家角色。
        /// </summary>
        /// <param name="forceRefresh">true = 跳过缓存重新查询（对实时性要求高的路径用，如按键触发）</param>
        public static BGUPlayerCharacterCS? GetCharacter(bool forceRefresh)
        {
            try
            {
                if (!forceRefresh)
                {
                    var cached = _cachedCharacter;
                    // 缓存命中：仍然有效 + 在 TTL 内。Environment.TickCount 回绕用 unchecked 差值处理
                    if (cached != null && !cached.IsNullOrDestroyed())
                    {
                        int now = Environment.TickCount;
                        unchecked
                        {
                            if (now - _cachedCharacterTick < CharacterCacheTtlMs) return cached;
                        }
                    }
                }

                UObjectRef uobjectRef = GCHelper.FindRef(FGlobals.GWorld);
                var world = uobjectRef?.Managed as UWorld;
                if (world == null)
                {
                    InvalidateCharacterCache();
                    return null;
                }

                var controller = UGSE_EngineFuncLib.GetFirstLocalPlayerController(world);
                if (controller == null)
                {
                    InvalidateCharacterCache();
                    return null;
                }

                var pawn = controller.GetControlledPawn() as BGUPlayerCharacterCS;
                // 只缓存"查到了"的结果，避免加载初期返回 null 后还要等 TTL 过期
                if (pawn != null && !pawn.IsNullOrDestroyed())
                {
                    _cachedCharacter = pawn;
                    _cachedCharacterTick = Environment.TickCount;
                }
                else
                {
                    InvalidateCharacterCache();
                }
                return pawn;
            }
            catch (Exception e)
            {
                Log.Error($"[MagicMod] GetCharacter 失败: {e.Message}");
                InvalidateCharacterCache();
                return null;
            }
        }

        /// <summary>
        /// 召唤物出生后设置阵营的重试节奏（毫秒）。召唤是异步的（Tamer 生成 + ECS BeginPlay），
        /// 所以要延迟重试几次，直到能从 BGC_SummonData 里取到真正的怪物实例。
        /// </summary>
        private static readonly int[] SummonTeamApplyDelays = { 400, 600, 800, 1200, 2000 };

        /// <summary>
        /// 召唤（summon 动作）。支持三项自定义，不再需要为每种"怪物+招式"组合建一个 SummonID：
        ///   1) path：直接指定 TAMER 蓝图路径，覆盖 SummonCommDesc 里的 TamerTemplate；
        ///   2) SkillID：出生技能（自定义招式），不再要求技能必须能在配表里查到；
        ///   3) SummonTeamId：出生后强制设置阵营（1=玩家阵营/己方，非 1 = 敌方或中立）并重新索敌。
        /// SummonID 可以留空：此时用内置的最小 SpawnConfig 召唤（出生在召唤者位置、面向当前目标、按感知索敌）。
        /// </summary>
        public static void SummonReq(ActionConfig? action)
        {
            var character = GetCharacter();
            if (character == null) return;
            var SummonCount = action?.SummonCount ?? 1;
            var SummonID = action?.SummonID ?? 0;
            var skillID = action?.SkillID ?? 0;
            var SummonAliveTime = action?.SummonAliveTime ?? -1f;
            var teamId = action?.SummonTeamId ?? 0;
            string? path = action?.path;
            if (SummonCount < 1)
            {
                SummonCount = 1;
            }

            // 1) 自定义怪物：按 path 加载 TAMER 蓝图类
            UClass? tamerClass = null;
            if (!string.IsNullOrEmpty(path))
            {
                tamerClass = LoadTamerClass(path!);
                if (tamerClass == null)
                {
                    Log.Warn($"[MagicMod] 召唤失败：无法加载 Tamer 类 {path}");
                    return;
                }
            }

            // 2) 出生配置：有 SummonID 走配表（沿用其出生点/存活/特效等）；
            //    没有 SummonID 时用内置最小配置，完全不依赖 SummonCommDesc。
            FSummonSpawnConfigWrap wrap;
            if (SummonID > 0)
            {
                wrap = FSummonSpawnConfigWrap.WrapSpawnConfig_BySummonCommDesc(SummonID, character);
            }
            else
            {
                wrap = CreateDefaultSummonWrap();
            }

            if (tamerClass != null)
            {
                wrap.TamerTemplate = tamerClass;
            }
            if (wrap.TamerTemplate == null)
            {
                Log.Warn($"[MagicMod] 召唤失败：既没有可用的 path，SummonID={SummonID} 也没提供怪物模板");
                return;
            }

            wrap.SummonAliveTime = SummonAliveTime;
            wrap.DestroyDelayTime = 0f;

            // 3) 自定义招式：出生技能（原实现要求 GetSkillSDesc 命中才生效，这里放宽为直接下发）
            if (skillID > 0)
            {
                wrap.UseBornSkill = true;
                wrap.BornSkillIDs = new List<int> { skillID };
            }

            // 4) 出生 Buff：追加到 SpawnBirthBuff（表内自带的出生 Buff 会保留）
            List<int>? birthBuffs = action?.SummonBuffIds;
            if (birthBuffs != null && birthBuffs.Count > 0)
            {
                if (wrap.SpawnBirthBuff == null) wrap.SpawnBirthBuff = new List<int>();
                foreach (int buffId in birthBuffs)
                {
                    if (buffId > 0 && !wrap.SpawnBirthBuff.Contains(buffId)) wrap.SpawnBirthBuff.Add(buffId);
                }
            }

            // 5) 自定义阵营：切断"跟随召唤者阵营"的主从同步，避免出生后被主从同步覆盖回玩家阵营
            if (teamId > 0)
            {
                wrap.IsSummonerAsMaster = false;
            }

            FSummonReq fSummonReq = default(FSummonReq);
            fSummonReq.SummonType = ESummonType.Normal;
            var summonGuid = GameplayTagExtension.ConvertToCalliopeGuid(Guid.NewGuid());
            fSummonReq.SummonGuid = summonGuid;
            fSummonReq.SummonID = SummonID;
            fSummonReq.SummonCount = (Int32)SummonCount;
            fSummonReq.Summoner = character;
            fSummonReq.SpawnConfigWrap = wrap;

            FSummonReq inSummonReq = fSummonReq;
            BPS_EventCollectionCS.GetLocal(character).Evt_RequestSummon.Invoke(inSummonReq);
            Log.Info($"[MagicMod] 召唤 SummonID={SummonID} path={path ?? "（用表内模板）"} Count={SummonCount} BornSkill={skillID} Team={teamId}");

            // 召唤物是异步生成的，出生后再设置阵营
            if (teamId > 0)
            {
                ScheduleSetSummonTeam(character, summonGuid, teamId);
            }
        }

        /// <summary>
        /// 不依赖 SummonCommDesc 的最小召唤配置：出生在召唤者位置、面向当前目标、按自身感知索敌。
        /// </summary>
        private static FSummonSpawnConfigWrap CreateDefaultSummonWrap()
        {
            return new FSummonSpawnConfigWrap
            {
                SummonAliveTime = -1f,
                SummonUnitLocationType = ESummonUnitLocationType.UseCasterPos,
                SummonUnitRotationType = ESummonUnitRotationType.FacingCurTarget,
                SearchTargetType = EServantSearchTargetType.ByPerception,
                BornSkillIDs = new List<int>(),
                BornMontages = new List<UAnimMontage>(),
                SpawnBirthBuff = new List<int>(),
                DisappearMontagePathList = new List<string>(),
            };
        }

        /// <summary>
        /// 加载 TAMER 蓝图类：先同步 LoadClass，失败再用预加载管理器按路径取。
        /// </summary>
        private static UClass? LoadTamerClass(string path)
        {
            try
            {
                UClass uClass = UObject.LoadClass<AActor>(null, path);
                if (uClass != null) return uClass;
            }
            catch (Exception e)
            {
                Log.Warn($"[MagicMod] LoadClass 失败 {path}: {e.Message}");
            }

            try
            {
                UWorld? world = ModUtils.GetWorld();
                if (world != null)
                {
                    return BGW_PreloadAssetMgr.Get(world).TryGetCachedResourceObj<UClass>(
                        path, ELoadResourceType.SyncLoadAndCache);
                }
            }
            catch (Exception e)
            {
                Log.Warn($"[MagicMod] 预加载 Tamer 类失败 {path}: {e.Message}");
            }
            return null;
        }

        /// <summary>
        /// 延迟给本次召唤出来的单位设置阵营（异步出生，需重试直到能取到实例）
        /// </summary>
        private static void ScheduleSetSummonTeam(BGUPlayerCharacterCS summoner, FCalliopeGuid summonGuid, int teamId)
        {
            Task.Run(async () =>
            {
                foreach (int delay in SummonTeamApplyDelays)
                {
                    await Task.Delay(delay);
                    bool applied = false;
                    Utils.TryRunOnGameThread(() =>
                    {
                        applied = TryApplySummonTeam(summoner, summonGuid, teamId);
                    });
                    await Task.Delay(50); // 等游戏线程那次回调执行完
                    if (applied) return;
                }
                Log.Warn($"[MagicMod] 召唤物阵营设置失败：未取到本次召唤的实例 TeamID={teamId}");
            });
        }

        /// <summary>
        /// 找到本次召唤产出的单位，设置阵营并重新索敌
        /// </summary>
        private static bool TryApplySummonTeam(BGUPlayerCharacterCS summoner, FCalliopeGuid summonGuid, int teamId)
        {
            List<BGUCharacterCS> units = GetSummonedUnits(summoner, summonGuid);
            if (units.Count == 0) return false;

            int playerTeamId = summoner.GetTeamIDInCS();
            foreach (BGUCharacterCS unit in units)
            {
                unit.SetTeamIDInCS(teamId);
                BGUFuncLibAICS.SearchTargetSP(unit);
                // 登记进"两阵营互殴"池：与玩家同阵营=己方，否则=敌方
                RegisterTeamBattleUnit(unit, teamId, playerTeamId);
            }
            Log.Info($"[MagicMod] 已把 {units.Count} 个召唤物的阵营设为 {teamId}（玩家阵营={playerTeamId}）");
            return true;
        }

        /// <summary>
        /// 取本次召唤（按 SummonGuid 匹配）已经生成出来的怪物实例。
        /// 链路：BGC_SummonData → FSummonInstance → FServantInstanceBase.ServantTamerRef.MonsterInstancePtr。
        /// 匹配不到时退化为"该召唤者最近一次召唤"。
        /// </summary>
        public static List<BGUCharacterCS> GetSummonedUnits(BGUPlayerCharacterCS summoner, FCalliopeGuid summonGuid)
        {
            var result = new List<BGUCharacterCS>();
            try
            {
                var summonData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_SummonData, BGC_SummonData>(summoner);
                if (summonData == null) return result;

                summonData.GetSummonInstancesBySummoner(BGU_DataUtil.GetActorGuid(summoner), out List<FSummonInstance> instances);
                if (instances == null || instances.Count == 0) return result;

                FSummonInstance? target = null;
                foreach (FSummonInstance inst in instances)
                {
                    if (inst != null && inst.SummonInstanceID.Equals(summonGuid))
                    {
                        target = inst;
                        break;
                    }
                }
                if (target == null) target = instances[instances.Count - 1];
                if (target == null) return result;

                foreach (FServantInstanceBase servant in target.ServantInstances)
                {
                    FTamerRef? tamerRef = servant?.ServantTamerRef;
                    if (tamerRef == null) continue;
                    TWeakObject<BGUCharacterCS> ptr = tamerRef.MonsterInstancePtr;
                    if (!ptr.IsValid()) continue;
                    BGUCharacterCS unit = ptr.Get();
                    if (unit != null) result.Add(unit);
                }
            }
            catch (Exception e)
            {
                Log.Warn($"[MagicMod] 获取召唤物实例失败: {e.Message}");
            }
            return result;
        }

        #region 两阵营互殴（召唤物互相攻击，而不是一起打玩家）

        /// <summary>
        /// 互殴 tick 间隔（毫秒）。AI 的仇恨系统会按感知/仇恨值自己改目标（默认盯玩家），
        /// 所以必须持续把"对面最近的单位"强制写成它的锁定目标，参考 BVB mod 的做法。
        /// </summary>
        private const int TeamBattleTickMs = 500;

        private static readonly object _teamBattleLock = new object();

        /// <summary>己方：TeamID 与玩家相同（不会被己方误伤，也不会打玩家）</summary>
        private static readonly List<BGUCharacterCS> _teamBattleFriendly = new List<BGUCharacterCS>();

        /// <summary>敌方：TeamID 与玩家不同（与己方、与玩家都敌对）</summary>
        private static readonly List<BGUCharacterCS> _teamBattleHostile = new List<BGUCharacterCS>();

        private static Timer? _teamBattleTimer;

        /// <summary>
        /// 登记一个召唤物：TeamID 与玩家相同进己方，否则进敌方。双方都有单位时自动启动 tick。
        /// 注意：双方 TeamID 必须不同且互相敌对，否则攻击不会掉血（伤害判定会过滤非敌对单位）。
        /// </summary>
        public static void RegisterTeamBattleUnit(BGUCharacterCS unit, int unitTeamId, int playerTeamId)
        {
            if (unit == null) return;
            lock (_teamBattleLock)
            {
                _teamBattleFriendly.RemoveAll(IsUnitGone);
                _teamBattleHostile.RemoveAll(IsUnitGone);
                _teamBattleFriendly.RemoveAll(u => ReferenceEquals(u, unit));
                _teamBattleHostile.RemoveAll(u => ReferenceEquals(u, unit));

                if (unitTeamId == playerTeamId)
                {
                    _teamBattleFriendly.Add(unit);
                }
                else
                {
                    _teamBattleHostile.Add(unit);
                }

                if (_teamBattleFriendly.Count > 0 && _teamBattleHostile.Count > 0)
                {
                    StartTeamBattleTick();
                }
            }
        }

        /// <summary>
        /// 登记 SpawnActor（GM 生成 Boss / Prefabricator）出来的 Tamer。Tamer 是异步出怪的，
        /// 所以延迟重试若干次直到 GetMonster() 能取到实例，再设置阵营并登记进互殴池。
        /// teamId&lt;=0 表示沿用 diffTeamID 分配的阵营（按敌方登记）。
        /// </summary>
        public static void RegisterSpawnedTamer(BUTamerActor? tamer, int teamId = 0)
        {
            if (tamer == null) return;
            Task.Run(async () =>
            {
                foreach (int delay in new[] { 300, 800, 1500, 2500 })
                {
                    await Task.Delay(delay);
                    bool done = false;
                    Utils.TryRunOnGameThread(() => { done = TryRegisterSpawnedTamerOnce(tamer, teamId); });
                    await Task.Delay(50); // 等游戏线程那次回调执行完
                    if (done) return;
                }
                Log.Warn($"[MagicMod] SpawnActor 生成物未取到怪物实例，未登记互殴池 TeamID={teamId}");
            });
        }

        /// <summary>单次尝试：取 Tamer 的怪物实例 → 设阵营 → 登记（返回是否成功）</summary>
        private static bool TryRegisterSpawnedTamerOnce(BUTamerActor tamer, int teamId)
        {
            try
            {
                if (tamer == null || tamer.IsNullOrDestroyed()) return false;
                BGUCharacterCS? monster = tamer.GetMonster();
                if (monster == null || monster.IsNullOrDestroyed()) return false;
                BGUPlayerCharacterCS? player = GetCharacter();
                if (player == null) return false;

                if (teamId > 0) monster.SetTeamIDInCS(teamId);

                // 生成物的脚陷进地面时（高个子怪常见）抬回地面之上，正在空中下落时不动
                ModUtils.RescueSunkUnit(monster);

                int finalTeamId = teamId > 0 ? teamId : monster.GetTeamIDInCS();
                RegisterTeamBattleUnit(monster, finalTeamId, player.GetTeamIDInCS());
                Log.Info($"[MagicMod] SpawnActor 生成物已登记互殴池 TeamID={finalTeamId}（玩家阵营={player.GetTeamIDInCS()}）");
                return true;
            }
            catch (Exception e)
            {
                Log.Warn($"[MagicMod] 登记 SpawnActor 生成物失败: {e.Message}");
                return false;
            }
        }

        /// <summary>启动互殴 tick（反复调用安全，只会起一个定时器）</summary>
        public static void StartTeamBattleTick()
        {
            if (_teamBattleTimer != null) return;
            _teamBattleTimer = new Timer(
                _ => Utils.TryRunOnGameThread(TickTeamBattle),
                null, TeamBattleTickMs, TeamBattleTickMs);
            Log.Info($"[MagicMod] 两阵营互殴 tick 已启动（{TeamBattleTickMs}ms）");
        }

        /// <summary>停止互殴 tick 并清空双方名单（Mod 卸载/重载时调用）</summary>
        public static void StopTeamBattleTick()
        {
            _teamBattleTimer?.Dispose();
            _teamBattleTimer = null;
            lock (_teamBattleLock)
            {
                _teamBattleFriendly.Clear();
                _teamBattleHostile.Clear();
            }
        }

        /// <summary>每 tick：清掉死掉的单位，互相指定最近的敌方为目标</summary>
        private static void TickTeamBattle()
        {
            try
            {
                if (GetCharacter() == null) return;
                lock (_teamBattleLock)
                {
                    _teamBattleFriendly.RemoveAll(IsUnitGone);
                    _teamBattleHostile.RemoveAll(IsUnitGone);
                    if (_teamBattleFriendly.Count == 0 || _teamBattleHostile.Count == 0)
                    {
                        // 一方打光了就没必要继续跑
                        _teamBattleTimer?.Dispose();
                        _teamBattleTimer = null;
                        return;
                    }
                    AssignEnemyTargets(_teamBattleFriendly, _teamBattleHostile);
                    AssignEnemyTargets(_teamBattleHostile, _teamBattleFriendly);
                }
            }
            catch (Exception e)
            {
                Log.Error($"[MagicMod] 两阵营互殴 tick 异常: {e.Message}");
            }
        }

        /// <summary>给 attackers 里每个单位指定 enemies 中距离最近的一个为目标</summary>
        private static void AssignEnemyTargets(List<BGUCharacterCS> attackers, List<BGUCharacterCS> enemies)
        {
            foreach (BGUCharacterCS attacker in attackers)
            {
                if (IsUnitGone(attacker)) continue;
                BGUCharacterCS? target = FindNearestUnit(attacker, enemies);
                if (target == null) continue;

                // 已经锁定对面的人就别打断（避免每 tick 抢目标打断出招）
                AActor? curTarget = BGUFunctionLibraryCS.BGUGetTarget(attacker);
                if (curTarget != null && !curTarget.IsNullOrDestroyed() && ContainsByRef(enemies, curTarget))
                {
                    continue;
                }

                // 1) 走 AI 抓目标：会唤醒 AI 进战斗（内部最终也是 BGUSetTargetInfo），
                //    但内部有敌对校验，阵营不敌对时会静默失败
                BUS_EventCollectionCS.Get(attacker)?.Evt_AICatchTarget?.Invoke(target, ETargetSourceType.Target_ByTaunter);
                // 2) 兜底硬写锁定目标：仇恨/感知把目标抢回玩家时也能拉回来
                BGUFunctionLibraryCS.BGUSetTargetInfo(false, attacker,
                    new UnitLockTargetInfo(target, ETargetSourceType.Target_ByTaunter, ELockTargetWayType.Manual, "", ""));
            }
        }

        /// <summary>找 candidates 里距离 from 最近且存活的单位</summary>
        private static BGUCharacterCS? FindNearestUnit(BGUCharacterCS from, List<BGUCharacterCS> candidates)
        {
            FVector origin = BGUFuncLibActorTransformCS.BGUGetActorLocation(from);
            float bestDist = float.MaxValue;
            BGUCharacterCS? best = null;
            foreach (BGUCharacterCS candidate in candidates)
            {
                if (IsUnitGone(candidate) || ReferenceEquals(candidate, from)) continue;
                float dist = FVector.Dist(origin, BGUFuncLibActorTransformCS.BGUGetActorLocation(candidate));
                if (dist < bestDist)
                {
                    bestDist = dist;
                    best = candidate;
                }
            }
            return best;
        }

        /// <summary>单位是否已失效或已死亡</summary>
        private static bool IsUnitGone(BGUCharacterCS unit)
        {
            if (unit == null || unit.IsNullOrDestroyed()) return true;
            BUC_UnitStateData? stateData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(unit);
            return stateData != null && stateData.HasState(EBGUUnitState.Dead);
        }

        /// <summary>按引用判断列表里是否包含该 Actor（UE 包装对象不用 Equals，避免误判）</summary>
        private static bool ContainsByRef(List<BGUCharacterCS> list, AActor actor)
        {
            foreach (BGUCharacterCS item in list)
            {
                if (ReferenceEquals(item, actor)) return true;
            }
            return false;
        }

        #endregion

        public static void RegPlayerTransEvent()
        {
            var character = GetCharacter();
            if (character == null) return;
            BPS_GSEventCollection.Get(character.PlayerState).Evt_TriggerPlayerTransBegin -= new Del_PlayerTransBegin(OnEventTransBegin);
            BPS_GSEventCollection.Get(character.PlayerState).Evt_TriggerPlayerTransBegin += new Del_PlayerTransBegin(OnEventTransBegin);
            BPS_GSEventCollection.Get(character.PlayerState).Evt_TriggerPlayerTransEnd -= new Del_PlayerTransEnd(OnEventTransEnd);
            BPS_GSEventCollection.Get(character.PlayerState).Evt_TriggerPlayerTransEnd += new Del_PlayerTransEnd(OnEventTransEnd);
        }

        public static void UnRegPlayerTransEvent()
        {
            var character = GetCharacter();
            if (character == null) return;
            BPS_GSEventCollection.Get(character.PlayerState).Evt_TriggerPlayerTransBegin -= new Del_PlayerTransBegin(OnEventTransBegin);
            BPS_GSEventCollection.Get(character.PlayerState).Evt_TriggerPlayerTransEnd -= new Del_PlayerTransEnd(OnEventTransEnd);
        }

        public static void RegSweepCheckBeginEvent()
        {
            var character = GetCharacter();
            if (character == null) return;
            try
            {

                BUS_EventCollectionCS.Get(character).Evt_SweepCheckBegin -= new Del_SweepCheckBegin(SweepCheckBegin);
                BUS_EventCollectionCS.Get(character).Evt_SweepCheckBegin += new Del_SweepCheckBegin(SweepCheckBegin);


                BUS_EventCollectionCS.Get(character).Evt_RequestSmartCastSkill -= new Del_RequestSmartCastSkill(OnRequestSmartCastSkill);
                BUS_EventCollectionCS.Get(character).Evt_RequestSmartCastSkill += new Del_RequestSmartCastSkill(OnRequestSmartCastSkill);



                BUS_EventCollectionCS.Get(character).Evt_InputCastSkill -= new Del_InputCastSkill(OnInputCastSkill);
                BUS_EventCollectionCS.Get(character).Evt_InputCastSkill += new Del_InputCastSkill(OnInputCastSkill);



                BUS_EventCollectionCS.Get(character).Evt_CastImmobilize -= new Del_Void_Int(OnCastImmobilize);
                BUS_EventCollectionCS.Get(character).Evt_CastImmobilize += new Del_Void_Int(OnCastImmobilize);


                BUS_EventCollectionCS.Get(character).Evt_OnSkillCostDmg -= new Del_OnSkillCostDmg(OnSkillCostDmg);
                BUS_EventCollectionCS.Get(character).Evt_OnSkillCostDmg += new Del_OnSkillCostDmg(OnSkillCostDmg);




                BUS_EventCollectionCS.Get(character).Evt_BuffAdd -= new Del_BuffAdd(BuffBegin);
                BUS_EventCollectionCS.Get(character).Evt_BuffAdd += new Del_BuffAdd(BuffBegin);


                BUS_EventCollectionCS.Get(character).Evt_TriggerSkillEffect -= new Del_TriggerSkillEffect(OnTriggerSkillEffect);
                BUS_EventCollectionCS.Get(character).Evt_TriggerSkillEffect += new Del_TriggerSkillEffect(OnTriggerSkillEffect);

                BUS_EventCollectionCS.Get(character).Evt_NotifyMasterProjectileSpawned -= new Del_Actor(OnNotifyMasterProjectileSpawned);
                BUS_EventCollectionCS.Get(character).Evt_NotifyMasterProjectileSpawned += new Del_Actor(OnNotifyMasterProjectileSpawned);

                BUS_EventCollectionCS.Get(character).Evt_OnNotifyStateSpawnProjectileObj -= new Del_OnNotifyStateSpawnProjectileObj(OnNotifyStateSpawnProjectileObj);
                BUS_EventCollectionCS.Get(character).Evt_OnNotifyStateSpawnProjectileObj += new Del_OnNotifyStateSpawnProjectileObj(OnNotifyStateSpawnProjectileObj);


                BUS_EventCollectionCS.Get(character).Evt_TriggerNormalDamageEffect -= new Del_TriggerNormalDamageEffect(OnTriggerNormalDamageEffect);
                BUS_EventCollectionCS.Get(character).Evt_TriggerNormalDamageEffect += new Del_TriggerNormalDamageEffect(OnTriggerNormalDamageEffect);


                BUS_EventCollectionCS.Get(character).Evt_PlayMontageCallback -= new Del_PlayMontageCallback(OnPlayMontageCallback);
                BUS_EventCollectionCS.Get(character).Evt_PlayMontageCallback += new Del_PlayMontageCallback(OnPlayMontageCallback);

                // BUS_EventCollectionCS.Get(character).Evt_SweepCheckInPreciseDodgeRange -= new Del_SweepCheckInPreciseDodgeRange(SweepCheckInPreciseDodgeRange);
                // BUS_EventCollectionCS.Get(character).Evt_SweepCheckInPreciseDodgeRange += new Del_SweepCheckInPreciseDodgeRange(SweepCheckInPreciseDodgeRange);
            }
            catch (Exception e)
            {
                Log.Error($"[MagicMod] RegSweepCheckBeginEvent 失败: {e.Message}");
            }
        }
        public static void UnSweepCheckBeginEvent()
        {
            var character = GetCharacter();
            if (character == null) return;
            try
            {

                BUS_EventCollectionCS.Get(character).Evt_SweepCheckBegin -= new Del_SweepCheckBegin(SweepCheckBegin);
                BUS_EventCollectionCS.Get(character).Evt_RequestSmartCastSkill -= new Del_RequestSmartCastSkill(OnRequestSmartCastSkill);
                BUS_EventCollectionCS.Get(character).Evt_InputCastSkill -= new Del_InputCastSkill(OnInputCastSkill);
                BUS_EventCollectionCS.Get(character).Evt_CastImmobilize -= new Del_Void_Int(OnCastImmobilize);
                BUS_EventCollectionCS.Get(character).Evt_OnSkillCostDmg -= new Del_OnSkillCostDmg(OnSkillCostDmg);
                BUS_EventCollectionCS.Get(character).Evt_BuffAdd -= new Del_BuffAdd(BuffBegin);
                BUS_EventCollectionCS.Get(character).Evt_TriggerSkillEffect -= new Del_TriggerSkillEffect(OnTriggerSkillEffect);
                BUS_EventCollectionCS.Get(character).Evt_NotifyMasterProjectileSpawned -= new Del_Actor(OnNotifyMasterProjectileSpawned);

                BUS_EventCollectionCS.Get(character).Evt_OnNotifyStateSpawnProjectileObj -= new Del_OnNotifyStateSpawnProjectileObj(OnNotifyStateSpawnProjectileObj);


                BUS_EventCollectionCS.Get(character).Evt_TriggerNormalDamageEffect -= new Del_TriggerNormalDamageEffect(OnTriggerNormalDamageEffect);
                BUS_EventCollectionCS.Get(character).Evt_PlayMontageCallback -= new Del_PlayMontageCallback(OnPlayMontageCallback);
                // BUS_EventCollectionCS.Get(character).Evt_SweepCheckInPreciseDodgeRange -= new Del_SweepCheckInPreciseDodgeRange(SweepCheckInPreciseDodgeRange);



            }
            catch (Exception e)
            {
                Log.Error($"[MagicMod] UnSweepCheckBeginEvent 失败: {e.Message}");
            }
        }

        private static void SweepCheckInPreciseDodgeRange(AActor Attacker, int MontageID, int GroupID, int NotifyID, float MontageTime)
        {
            var character = GetCharacter();
            if (character == null)
            {
                return;
            }
            // Log.Info($"完美闪避触发范围 SweepCheckInPreciseDodgeRange: MontageID: {MontageID}, GroupID: {GroupID}, NotifyID: {NotifyID}, MontageTime: {MontageTime}");
        }

        private static void OnNotifyStateSpawnProjectileObj(ref FGSProjecttileObjSpawnNSInfo ProjectileSpawnNSInfo, bool bNeedHandleStopReq, EProjectileSpawnMethod SpawnMethod, int MethodUniqueID)
        {
            var character = GetCharacter();
            if (character == null) return;
            UAnimMontage currentMontage = character.GetCurrentMontage();
            var pathName = currentMontage?.PathName ?? "";
            var ProjectileID = ProjectileSpawnNSInfo?.ProjectileID ?? 0;
            // 按 SweepCheck 配置中的 bullet_actions（Animation + ProjectileID）匹配并执行对应动作
            ActionExecutor.DoBulletSpawnActions(character, pathName, ProjectileID);
            if (ModLog.Verbose) ModLog.Info($"[MagicMod] OnNotifyStateSpawnProjectileObj发射子弹 Montage: {currentMontage?.GetFName()}, ProjectileID:{ProjectileSpawnNSInfo?.ProjectileID}");

        }

        public static float getTargetDistane()
        {
            var character = GetCharacter();
            if (character == null)
            {

                return 0f;
            }
            var Target = BGUFunctionLibraryCS.BGUGetTarget(character);
            if (Target == null)
            {
                return 0f;
            }
            FVector charPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(character);
            FVector targetPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(Target);
            FVector direction = (targetPos - charPos);
            float distance = direction.Size();

            return (int)distance;
        }
        private static readonly Dictionary<string, bool> ProcessedAnimCache = new Dictionary<string, bool>();



        // Notify 名比较用的 FName。原来是在遍历每个 Notify 时 new 出来的，
        // 每次构造都要进 name table 做一次哈希查找，一条 Montage 几十个 Notify 就是上百次，缓存起来
        private static readonly FName DodgeWindowNotifyName = new FName("BANS_GSDodgeWindow");
        private static readonly FName ComboWindowNotifyName = new FName("ComboWindow");

        public static void OnPlayMontageCallback(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
        {

            var animationPath = Montage?.PathName ?? "";
            if (Montage == null || animationPath == "")
            {
                return;
            }

            // TArrayUnsafe 的底层是 Marshal.AllocHGlobal 的非托管数组，只有 Dispose 才会释放；
            // 光靠它的 finalizer 要等 GC，而 GC 感知不到非托管压力（每次播 Montage 一份，会一路涨）
            using (TArrayUnsafe<FAnimNotifyEvent> AnimNotifyEventList = new TArrayUnsafe<FAnimNotifyEvent>())
            {
            UGSE_AnimFuncLib.GetAllNotifyEvent(Montage, AnimNotifyEventList);
            if (!(AnimNotifyEventList != null && AnimNotifyEventList.Count > 0))
            {
                return;
            }
            int addRadius = 200;

            var _sweepCheckBindings = ActionExecutor._sweepCheckBindings;
            if (_sweepCheckBindings != null)
            {
                foreach (var binding in _sweepCheckBindings)
                {

                    if (animationPath.IndexOf(binding.Animation, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        addRadius = binding.addRadius ?? 100;
                    }
                }
            }

            foreach (FAnimNotifyEvent item in AnimNotifyEventList)
            {
                if (item.NotifyStateClass is BANS_GSSweepCheck sweepCheck)
                {
                    for (int i = 0; i < sweepCheck.SweepCheckShape.Count; i++)
                    {
                        var sweepItem = sweepCheck.SweepCheckShape[i];
                        var addNum = sweepItem.Radius < addRadius ? addRadius : sweepItem.Radius;
                        sweepItem.Radius = addNum;
                        var scaleNum = Math.Round(addNum / sweepItem.Radius, 3);
                        if (scaleNum > 1)
                        {
                            sweepItem.SKComp.SetRelativeScale3D(new FVector(scaleNum, scaleNum, scaleNum));
                        }

                        sweepCheck.SweepCheckShape[i] = sweepItem;

                    }

                }

                else if (item.NotifyName == DodgeWindowNotifyName || item.NotifyName == ComboWindowNotifyName)
                {
                    item.LinkValue = 0.1f; // 设置触发时间为0.1秒
                }
                else if (item.NotifyStateClass is BANS_GSSpawnBullets spawnBullets)
                {
                    // AM_hys_yinbinghoumo_Atk_05

                    var id = spawnBullets.BulletID;
                    if (animationPath.Contains("AM_LYS_XueHou_Atk_05") || animationPath.Contains("AM_hys_yinbinghoumo_Atk_05") || id == 1701001 || id == 1711001)
                    {
                        var num = spawnBullets.BulletWave;
                        spawnBullets.BulletWave = num < 2 ? 2 : num;

                        var distance = getTargetDistane();
                        if (ModLog.Verbose) ModLog.Info($"距离目标的距离 : {distance}");
                        ProjectileBaseStruct finalTargetBase = spawnBullets.TargetBase;
                        ProjectileBornDirStruct finalBornDirBaseInfo = spawnBullets.BornDirBaseInfo;
                        if (distance >= 2500 || id == 1016761)
                        {

                            finalBornDirBaseInfo.BornDirType = ProjectileBornDirType.LookAtTargetPos;
                            finalTargetBase.UseSocket = true;
                            finalTargetBase.BaseType = ProjectileBaseType.CurTarget_ProjectileSpawner;
                            finalTargetBase.SocketName = (FName)"CAMERA_LOCK";

                        }
                        else
                        {
                            finalBornDirBaseInfo.BornDirType = ProjectileBornDirType.UseSlotDir;
                        }
                        spawnBullets.BornDirBaseInfo = finalBornDirBaseInfo;
                        spawnBullets.TargetBase = finalTargetBase;
                    }
                    if (animationPath.Contains("AM_player_lys_hou_"))
                    {
                        spawnBullets.BulletWave = 2;
                        // 1711001
                        // var id = spawnBullets.BulletID;
                        // if (id == 1701001 || id == 1711001 || id == 1703001 || id == 1713001)
                        // {

                        // }
                        // {

                        //     if (getTargetDistane() >= 900)
                        //     {
                        //         ProjectileBaseStruct finalTargetBase = spawnBullets.TargetBase;
                        //         ProjectileBornDirStruct finalBornDirBaseInfo = spawnBullets.BornDirBaseInfo;
                        //         // finalBornDirBaseInfo.BornDirType = ProjectileBornDirType.LookAtTargetPos;
                        //         finalTargetBase.UseSocket = true;
                        //         finalTargetBase.BaseType = ProjectileBaseType.CurTarget_ProjectileSpawner;
                        //         finalTargetBase.SocketName = (FName)"CAMERA_LOCK";
                        //         spawnBullets.BornDirBaseInfo = finalBornDirBaseInfo;
                        //         spawnBullets.TargetBase = finalTargetBase;
                        //     }

                        // }
                        // ProjectileBornDirStruct finalBornDirBaseInfo = spawnBullets.BornDirBaseInfo;
                        // finalBornDirBaseInfo.BornDirType = ProjectileBornDirType.None;
                        // var character = GetCharacter();
                        // if (character == null)
                        // {
                        //     spawnBullets.BornDirBaseInfo = finalBornDirBaseInfo;
                        //     return;
                        // }
                        // var Target = BGUFunctionLibraryCS.BGUGetTarget(character);
                        // if (Target == null)
                        // {
                        //     spawnBullets.BornDirBaseInfo = finalBornDirBaseInfo;
                        //     return;
                        // }
                        // FVector charPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(character);
                        // FVector targetPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(Target);
                        // FVector direction = (targetPos - charPos);
                        // float distance = direction.Size();

                        // if (distance <= 900)
                        // {
                        //     spawnBullets.BornDirBaseInfo = finalBornDirBaseInfo;
                        //     return;
                        // }
                        // finalBornDirBaseInfo.BornDirType = ProjectileBornDirType.LookAtTargetPos;
                        // spawnBullets.BornDirBaseInfo = finalBornDirBaseInfo;
                    }
                }

            }

            // 标记该动画蒙太奇已处理
            // ProcessedAnimCache[Montage.PathName] = true;
            } // end using(AnimNotifyEventList)：释放非托管 Notify 数组
        }
        /// <summary>
        /// 子弹/法术场生成事件：按 Projectile 目录的 JSON 配置应用缩放与法术场 Buff 覆盖
        /// 配置格式：{ "pathName": "BP_xxx_C", "config": { "Scale3D": { "X": 2, "Y": 2, "Z": 0.5 }, "FieldBuffList": [ 181 ] } }
        /// </summary>
        public static void OnTriggerNormalDamageEffect(AActor Attacker, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq, in FBattleAttrSnapShot Attacker_AttrMemData)
        {
            var SkillDamageConfig_ = SkillDamageConfig;
            var EffectInstReq_ = EffectInstReq;
            var Attacker_AttrMemData_ = Attacker_AttrMemData;

            var character = GetCharacter();
            if (character == null || Attacker?.PathName == character?.PathName) return;
            if (EffectInstReq_.Attacker != null)
            {
                EffectInstReq_.Attacker = character;
            }
            // 20234,229
            var ReflectBuffIds = new List<int> { 229, 96036, 25080 };
            if (Attacker != null && ReflectBuffIds.Any(id => BGUFunctionLibraryCS.BGUHasBuffByID(character, id)))
            {
                BUS_EventCollectionCS.Get(Attacker)?.Evt_TriggerNormalDamageEffect?.Invoke(character, in SkillDamageConfig_, in EffectInstReq_, in Attacker_AttrMemData_);
            }
        }
        public static void OnNotifyMasterProjectileSpawned(AActor ower)
        {
            if (ower == null) return;
            ActionExecutor.ApplyProjectileBindings(ower);
        }


        public static void TianLongGun(AActor Victim, int SkillID, int FinalDmg, bool bIsCrit = false)
        {
            if (Victim == null) return;
            if (ModUtils.IsPlayer(Victim.PathName)) return;
            var character = GetCharacter();
            if (character == null) return;
            var currentElement = ActionExecutor.getCurrentElemt(character);

            var AbnormalStateType = EAbnormalStateType.Abnormal_Thunder;
            var config = new AbnormalStateAccConfig();

            if (currentElement == "bullet_thunder")
            {
                AbnormalStateType = EAbnormalStateType.Abnormal_Thunder;
            }
            else if (currentElement == "bullet_poison")
            {
                AbnormalStateType = EAbnormalStateType.Abnormal_Poison;
            }
            else if (currentElement == "bullet_ice")
            {
                AbnormalStateType = EAbnormalStateType.Abnormal_Freeze;
            }
            else if (currentElement == "bullet_fire")
            {
                AbnormalStateType = EAbnormalStateType.Abnormal_Burn;
            }


            if (currentElement != "")
            {
                config.AbnormalStateType = AbnormalStateType;
                config.AccType = EAccAbnormalValueType.IncreaseByValue;
                config.Level = 1;
                var addValue = Math.Max(FinalDmg * 0.1, 10);
                BGUFunctionLibraryCS.BGUHandleAbnormalState(character, Victim, config, (float)addValue);
                // BGUFunctionLibraryCS.BGUSetUnitSimpleState(Victim, EBGUSimpleState.ImmueDamage, true);
                // BGUFunctionLibraryCS.BGUSetUnitSimpleState(Victim, EBGUSimpleState.ImmueStiff, true);
                // BGUFunctionLibraryCS.BGUSetUnitSimpleState(Victim, EBGUSimpleState.ImmueImmobilizing, true);
                // BGUFunctionLibraryCS.BGUSetUnitSimpleState(Victim, EBGUSimpleState.CantBeSweepChecked, true);
                // BGUFunctionLibraryCS.BGUSetUnitSimpleState(Victim, EBGUSimpleState.CantBeLock, true);

            }

            IBUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(character);

            if (readOnlyData.HasSimpleState(EBGUSimpleState.IgnoreTargetElemDef))
            {
                weak_def(Victim, EBGUAttrFloat.ThunderDefBase);
                weak_def(Victim, EBGUAttrFloat.ThunderDef);


                weak_def(Victim, EBGUAttrFloat.FreezeDefBase);
                weak_def(Victim, EBGUAttrFloat.FreezeDef);

                weak_def(Victim, EBGUAttrFloat.BurnDefBase);
                weak_def(Victim, EBGUAttrFloat.BurnDef);

                weak_def(Victim, EBGUAttrFloat.PoisonDef);
                weak_def(Victim, EBGUAttrFloat.PoisonDefBase);
            }

        }
        public static void change_to_dasheng(int? time = 999)
        {
            var Owner = GetCharacter();
            if (Owner != null)
            {
                const int configID = 1;
                int duration = time ?? 999;

                // 1) Duration：Tick 每帧都会从 desc 重新读取，所以改这里才有效
                FUStTransQiTianDaShengConfigDesc originalDesc = BGW_GameDB.GetOriginalTransQiTianDaShengConfigDesc(configID);
                if (originalDesc != null)
                {
                    originalDesc.Duration = duration;
                }

                // 2) 同步修改角色 PassiveSkillData 中的缓存配置
                if (Owner.PassiveSkillData is BUC_PassiveSkillData writablePassiveData)
                {
                    writablePassiveData.GetAndCachedDesc<FUStTransQiTianDaShengConfigDesc>(configID, out var cachedDesc, out _);
                    if (cachedDesc != null)
                    {
                        cachedDesc.Duration = duration;
                    }
                }

                // 3) 关键：变身门槛存在 BUC_QiTianDaShengData 里，且只在组件首次 Tick 时从 desc 拷贝一次，
                //    之后改 desc 的 RelatedTalentIDList / RelatedEquipIDList 完全无效，必须直接改这份数据。
                //    判定（CheckCanKeepDaShengMode）要求：
                //      RelatedEquipIDList 全部在 EquipData.SelfEquipMap 里 && RelatedTalentIDList 全部在 TalenList 里
                //    注意：列表 Count==0 时对应 flag 保持 false（不是 true），所以 Clear() 只会让变身永远失败。
                BUC_QiTianDaShengData daShengData = BGU_DataUtil.GetReadOnlyData<IBUC_QiTianDaShengData, BUC_QiTianDaShengData>(Owner) as BUC_QiTianDaShengData;
                if (daShengData == null)
                {
                    Log.Info("执行变身大圣失败：拿不到 BUC_QiTianDaShengData");
                    return;
                }

                BUC_EquipData equipData = BGU_DataUtil.GetReadOnlyData<IBUC_EquipData, BUC_EquipData>(Owner) as BUC_EquipData;
                BPC_RoleBaseData roleBaseData = Owner.PlayerState != null
                    ? BGU_DataUtil.GetReadOnlyData<IBPC_RoleBaseData, BPC_RoleBaseData>(Owner.PlayerState) as BPC_RoleBaseData
                    : null;

                // 3.0 兜底：需求列表为空时，判定里的 flag 恒为 false，拿玩家已学的第一个天赋顶上
                if (daShengData.RelatedTalentIDList.Count == 0 && roleBaseData?.TalenList != null)
                {
                    foreach (var kv in roleBaseData.TalenList)
                    {
                        daShengData.RelatedTalentIDList.Add(kv.Key);
                        break;
                    }
                }

                // 3.1 天赋：把需求收缩成"已学天赋里的第一个"，再把缺失的补进 TalenList。
                //     这些字段都是 public，直接改即可（不需要反射）；收缩到 1 个是为了
                //     即使之后天赋被移除/重置，CheckCanKeepDaShengMode 也不会立刻失败
                var talentList = roleBaseData?.TalenList;
                if (daShengData.RelatedTalentIDList.Count > 0 && talentList != null)
                {
                    foreach (int talentId in daShengData.RelatedTalentIDList)
                    {
                        if (!talentList.ContainsKey(talentId))
                        {
                            talentList.Add(talentId, 1);
                        }
                    }
                    int firstTalent = daShengData.RelatedTalentIDList[0];
                    daShengData.RelatedTalentIDList = new List<int> { firstTalent };
                }


                // 3.2 装备：需求收缩到 1 件（优先武器），只要这一件穿着就永远满足判定，
                //     换防具/葫芦/法宝都不会再被打回
                if (equipData?.SelfEquipMap != null && equipData.SelfEquipMap.Count > 0)
                {
                    int keepEquipId = 0;
                    if (equipData.SelfEquipMap.TryGetValue(EquipPosition.Weapon, out int weaponId) && weaponId != 0)
                    {
                        keepEquipId = weaponId;
                    }
                    else
                    {
                        foreach (var kv in equipData.SelfEquipMap)
                        {
                            if (kv.Value != 0)
                            {
                                keepEquipId = kv.Value;
                                break;
                            }
                        }
                    }
                    if (keepEquipId != 0)
                    {
                        daShengData.RelatedEquipIDList = new List<int> { keepEquipId };
                    }
                }
                daShengData.HasValidDescInfo = daShengData.RelatedEquipIDList.Count > 0 || daShengData.RelatedTalentIDList.Count > 0;

                // 3.3 解除"禁止变身"：SimpleStates 是**引用计数**数组（Set +1 / Remove -1），
                //     多个来源叠加时只 Remove 一次清不掉，这里直接把计数清零
                daShengData.bIsBanTrans2DaSheng = false;
                BUC_SimpleStateData simpleStateData = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(Owner);
                try
                {
                    if (simpleStateData != null)
                    {
                        simpleStateData.SimpleStates[(int)EBGUSimpleState.BanTrans2DaSheng] = 0;
                    }
                }
                catch { }
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(Owner, EBGUSimpleState.BanTrans2DaSheng, false);

                // 4) Evt_TriggerTrans2DaSheng 只在 DaShengStage == PreStage 时才生效，
                //    必须先切到 PreStage 再触发（原版流程：Tick 进 PreStage → 变身动画的 BANS_TriggerTrans2DaSheng 触发）
                daShengData.DaShengStage = EDaShengStage.PreStage;
                daShengData.DaShengDurationTimer = 0f;
                daShengData.DaShengDurationTotalTime = duration;

                Log.Info($"执行变身大圣 Duration:{duration}");
                BUS_GSEventCollection obj = BUS_EventCollectionCS.Get(Owner);
                if (obj == null)
                {
                    return;
                }

                obj.Evt_TriggerTrans2DaSheng.Invoke();

                // 进入 DaShengMode 的瞬间系统会加一次 BanTrans2DaSheng，必须在同一帧清掉，
                // 否则下一帧 BUS_QiTianDaShengComp 的 Tick 开头就会 Reset2LittleMonkey
                try
                {
                    if (simpleStateData != null)
                    {
                        simpleStateData.SimpleStates[(int)EBGUSimpleState.BanTrans2DaSheng] = 0;
                    }
                }
                catch { }

                // 大圣形态的外观 / 技能组靠 DaSheng_SustainTriggerBuffIDList 驱动，补一次确保挂上
                foreach (int daShengBuffId in daShengData.DaSheng_SustainTriggerBuffIDList)
                {
                    try
                    {
                        BGUFunctionLibraryCS.BGUAddBuff(Owner, Owner, daShengBuffId, EBuffSourceType.Trans2DaSheng, -1f);
                    }
                    catch { }
                }

                // 头 6 秒每 30ms 在游戏线程压一次 Ban 状态，防止个别帧被重新加上打断变身
                TimerPool.TimerHandle? banGuard = null;
                int guardCount = 0;
                banGuard = TimerPool.Repeat(30, () =>
                {
                    guardCount++;
                    Utils.TryRunOnGameThread(() =>
                    {
                        try
                        {
                            if (simpleStateData != null && simpleStateData.SimpleStates[(int)EBGUSimpleState.BanTrans2DaSheng] > 0)
                            {
                                simpleStateData.SimpleStates[(int)EBGUSimpleState.BanTrans2DaSheng] = 0;
                            }
                        }
                        catch { }
                    });
                    if (guardCount >= 200)
                    {
                        TimerPool.Stop(banGuard);
                    }
                });
            }
        }

        public static void weak_def(AActor Victim, EBGUAttrFloat type)
        {

            if (BGUFunctionLibraryCS.GetAttrValue(Victim, type) > 0)
            {
                BGUFunctionLibraryCS.BGUSetAttrValue(Victim, type, 0);

            }
            if (type == EBGUAttrFloat.ThunderDefBase || type == EBGUAttrFloat.ThunderDef)
            {
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(Victim, EBGUSimpleState.ThunderImmue, true);
            }
            if (type == EBGUAttrFloat.FreezeDefBase || type == EBGUAttrFloat.FreezeDef)
            {
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(Victim, EBGUSimpleState.FreezeImmue, true);
            }
            if (type == EBGUAttrFloat.BurnDefBase || type == EBGUAttrFloat.BurnDef)
            {
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(Victim, EBGUSimpleState.BurnImmue, true);
            }
            if (type == EBGUAttrFloat.PoisonDefBase || type == EBGUAttrFloat.PoisonDef)
            {
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(Victim, EBGUSimpleState.PoisonImmue, true);
            }
        }

        public static void OnSkillCostDmg(AActor Victim, int SkillID, int FinalDmg, bool bIsCrit = false)
        {

            if (ModLog.Verbose) ModLog.Info($"执行技能效果 OnSkillCostDmg: {SkillID}, 伤害：{FinalDmg}, 是否暴击： {bIsCrit}");
            TianLongGun(Victim, SkillID, FinalDmg, bIsCrit);
            increase_attr(SkillID, FinalDmg, bIsCrit);

        }


        public static void TransBack()
        {

            var character = GetCharacter();
            if (character == null) return;

            IBPC_PlayerTagData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerTagData, BPC_PlayerTagData>(character.PlayerState);
            if (readOnlyData.HasTag(EBGPPlayerTag.Transforming))
            {
                BPS_GSEventCollection.Get(character.PlayerState).Evt_TriggerPlayerTransEnd.Invoke(EPlayerTransEndType.CastSpell, default(PlayerTransParam));
            }
        }

        public static void magicallyChangeBack()
        {
            var character = GetCharacter();
            if (character == null) return;

            // 任何还原路径（法术键 10417 / out_magic 动作）都先恢复被"幻化隐藏"的部件，避免残留导致头/部件消失
            ActionExecutor.RestoreMagicHidden();

            BUS_GSEventCollection BE_Owner = BUS_EventCollectionCS.Get(character);
            if (BE_Owner == null) return;
            BE_Owner.Evt_OnMagicallyChangeRecover.Invoke(10199);


        }
        public static void increase_attr(int SkillID, int FinalDmg, bool bIsCrit = false)
        {
            var character = GetCharacter();
            if (character == null) return;
            try
            {
                var num = Math.Max(FinalDmg * 0.1, 10);

                BGUFunctionLibraryCS.GM_AddAttr(character, EBGUAttrFloat.Hp, (float)num);
                BGUFunctionLibraryCS.GM_AddAttr(character, EBGUAttrFloat.Mp, (float)num);
                BGUFunctionLibraryCS.GM_AddAttr(character, EBGUAttrFloat.CurEnergy, (float)num);
                BGUFunctionLibraryCS.GM_AddAttr(character, EBGUAttrFloat.FabaoEnergy, (float)num);
                BGUFunctionLibraryCS.GM_AddAttr(character, EBGUAttrFloat.VigorEnergy, (float)num);
                if (bIsCrit)
                {
                    BGUFunctionLibraryCS.GM_AddAttr(character, EBGUAttrFloat.Shield, (float)num * 4);
                    BGUFunctionLibraryCS.GM_AddAttr(character, EBGUAttrFloat.BloodBottomNum, 10);
                }

            }
            catch (Exception e)
            {
                Log.Error($"[MagicMod] UnSweepCheckBeginEvent 失败: {e.Message}");
            }
        }

        public static void OnEventTransBegin(EPlayerTransBeginType UnitTransType, PlayerTransParam PlayerTransParam)
        {
            // 受控 Pawn 即将变成变身单位，立刻失效角色缓存，避免这段时间拿到旧本体
            InvalidateCharacterCache();

            Task.Run(async () =>
              {
                  await Task.Delay(1000);
                  Utils.TryRunOnGameThread(() =>
                  {
                      RegSweepCheckBeginEvent();
                  });
              });

        }

        public static bool isFinishCoolDown(int SkillID, BGUPlayerCharacterCS character)
        {
            var SimpleStateData = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(character);
            if (SimpleStateData.HasSimpleState(EBGUSimpleState.CancelSkillCD))
            {
                return true;
            }

            var SkillInstsData1 = BGU_DataUtil.GetReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(character);
            var CDTimePercent = BGUFuncLibSkillCS.GetSkillCDTimePercent(character, SkillID, in SkillInstsData1);
            if (CDTimePercent >= 1)
            {
                return true;
            }
            var SkillInstsData = BGU_DataUtil.GetReadOnlyData<BUC_SkillInstsData>(character);
            if (SkillInstsData.GetSkillCooldownTime(SkillID, out var RemainingCooldownTime, out var _))
            {
                return true;
            }
            return RemainingCooldownTime <= 0f;
        }
        public static void OnEventTransEnd(EPlayerTransEndType UnitTransType, PlayerTransParam PlayerTransParam)
        {
            // 受控 Pawn 变回本体，失效缓存立即重新取
            InvalidateCharacterCache();
            RegSweepCheckBeginEvent();
            var character = GetCharacter();
            if (character == null) return;
        }


        public static void OnCastImmobilize(int ConfigID)
        {
            var character = GetCharacter();
            if (character == null) return;
            // 发射子弹 ：激光
            var projectileConfig = new bulletConfig();
            projectileConfig.ProjectileID = 80000011;
            projectileConfig.spawnBaseSocketName = "hand_l";
            projectileConfig.path = "/Game/00Main/Design/Bullets/MGD/MGD_yangjian_01/DA/SP_mgd_yangjian_01_biglaser_01.SP_mgd_yangjian_01_biglaser_01";
            SpawnProjectile(character, projectileConfig);
            var Target = BGUFunctionLibraryCS.BGUGetTarget(character);
            if (Target != null)
            {
                var projectileConfig2 = new bulletConfig();
                projectileConfig2.ProjectileID = 40550101;
                projectileConfig2.Target = Target;
                projectileConfig2.path = "BGWDataAsset_ProjectileSpawnConfig'/Game/00Main/Design/Bullets/Online/SL/SZLC_shujing_02/BGW_szlc_shujing_02_mf_5003.BGW_szlc_shujing_02_mf_5003'";
                SpawnProjectile(character, projectileConfig2);
            }

        }

        public static void TriggerEffectToTarget(AActor character, int EffectID, AActor Target)
        {
            BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(character);
            if (bUS_GSEventCollection != null)
            {
                FEffectInstReq fEffectInstReq = new FEffectInstReq(character);
                fEffectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(Target);
                fEffectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(Target);
                fEffectInstReq.HitActionDir = EHitActionDir.Default;
                FEffectInstReq effectInstReq = fEffectInstReq;
                bUS_GSEventCollection.Evt_TriggerSkillEffect.Invoke(EffectID, effectInstReq, Target);
            }
        }

        public static void TriggerEffect(AActor character, int EffectID)
        {
            BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(character);
            if (bUS_GSEventCollection != null)
            {
                FEffectInstReq fEffectInstReq = new FEffectInstReq(character);
                fEffectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(character);
                fEffectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(character);
                fEffectInstReq.HitActionDir = EHitActionDir.Default;
                FEffectInstReq effectInstReq = fEffectInstReq;
                bUS_GSEventCollection.Evt_TriggerSkillEffect.Invoke(EffectID, effectInstReq, character);
            }
        }
        public static void refreshTalent()
        {
            var character = GetCharacter();
            if (character == null) return;
            BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(character);
            if (bUS_GSEventCollection == null) return;
            // Evt_AfterUnitRebirth
            bUS_GSEventCollection.Evt_AfterUnitRebirth.Invoke(ERebirthType.RebirthPoint);
        }

        public static void OnInputCastSkill(EInputActionType InputActionType, bool IsRelease, int SkillID, int DescID, int ItemID = -1)
        {


            var character = GetCharacter();
            if (character == null) return;
            switch (InputActionType)
            {
                case EInputActionType.LightAttack:
                    // 傀儡附身已停用：不再走连招链，保留原有行为（变身状态下重定向到目标角色技能）
                    if (!IsRelease) ActionExecutor.TryDoTransInputSkill(character, InputActionType);
                    break;
                case EInputActionType.HeavyAttack:
                    // 傀儡附身已停用：不再走连招链，保留原有行为（变身状态下重定向到目标角色技能）
                    if (!IsRelease) ActionExecutor.TryDoTransInputSkill(character, InputActionType);
                    break;
                case EInputActionType.SpinMode:
                    {

                        break;
                    }
                case EInputActionType.Dodge:
                    // 傀儡附身已停用：不再走连招链，保留原有行为（变身状态下重定向到目标角色技能）
                    if (!IsRelease) ActionExecutor.TryDoTransInputSkill(character, InputActionType);
                    break;
                case EInputActionType.UseVigorSkill:
                    // 傀儡附身已停用：不再走连招链
                    ActionExecutor.DoMeshActions(character);
                    break;
                case EInputActionType.CastItemSkill:
                    // 傀儡附身已停用：不再走连招链
                    break;
                case EInputActionType.UseSkillByType:
                    {
                        if (SkillID == 10417)
                        {
                            setMagicBack(character, true);
                            // 变回
                            magicallyChangeBack();
                        }

                        // 傀儡附身已停用：法术键不再走连招链，继续走原生法术逻辑

                        // 定身
                        if (SkillID == 10518)
                        {
                            // 定身术冷却日志已移除：下方 if 只对 10518 做一次冷却查询，日志那几次纯属浪费 GameDB 查询
                            if (!isFinishCoolDown(SkillID, character))
                            {
                                BUS_EventCollectionCS.Get(character)?.Evt_RequestSmartCastSkill.Invoke(
            50007, null, EMontageBindReason.NormalSkill, false);
                            }
                        }

                        // 铜头
                        if (SkillID == 10505)
                        {




                            if (!isFinishCoolDown(SkillID, character))
                            {
                                ModifyCD(10095, true, -150);
                                if (isFinishCoolDown(10095, character))
                                {
                                    doPhantomRushSkill(character, "Forward");
                                }
                                else
                                {
                                    BUS_EventCollectionCS.Get(character)?.Evt_RequestSmartCastSkill.Invoke(
                                               10505, null, EMontageBindReason.NormalSkill, false);
                                }
                            }

                        }

                        // 聚形散气
                        if (SkillID == 10095)
                        {



                            if (!isFinishCoolDown(SkillID, character))
                            {
                                BUS_EventCollectionCS.Get(character)?.Evt_RequestSmartCastSkill.Invoke(
                                               10505, null, EMontageBindReason.NormalSkill, false);
                            }
                        }





                        // 分身术
                        if (SkillID == 10516 || SkillID == 50093)
                        {
                            if (!isFinishCoolDown(SkillID, character))
                            {
                                BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(character);
                                if (bUS_GSEventCollection != null)
                                {
                                    bUS_GSEventCollection.Evt_Active_ExtLifeSaving.Invoke(P1: true);

                                    BUS_EventCollectionCS.Get(character)?.Evt_RequestSmartCastSkill.Invoke(
          10520, null, EMontageBindReason.NormalSkill, false);
                                }
                            }
                        }

                        if (SkillID == 18071)
                        {
                            // 虫变身 法术


                            if (!isFinishCoolDown(SkillID, character))
                            {
                                BUS_EventCollectionCS.Get(character)?.Evt_RequestSmartCastSkill.Invoke(
                                               18071, null, EMontageBindReason.NormalSkill, false);
                            }
                        }

                        if (SkillID == 17071)
                        {
                            // 猴 法术


                            if (!isFinishCoolDown(SkillID, character) || BGUFunctionLibraryCS.GetAttrValue(character, EBGUAttrFloat.Pevalue) < 100)
                            {
                                BUS_EventCollectionCS.Get(character)?.Evt_RequestSmartCastSkill.Invoke(
                                               17071, null, EMontageBindReason.NormalSkill, false);
                            }
                        }

                        if (SkillID == 17072)
                        {
                            // 猴 法术


                            if (!isFinishCoolDown(SkillID, character) || BGUFunctionLibraryCS.GetAttrValue(character, EBGUAttrFloat.Pevalue) < 100)
                            {
                                BUS_EventCollectionCS.Get(character)?.Evt_RequestSmartCastSkill.Invoke(
                                               17072, null, EMontageBindReason.NormalSkill, false);
                            }
                        }
                        if (SkillID == 13071)
                        {
                            // 石头 法术


                            if (!isFinishCoolDown(SkillID, character))
                            {
                                BUS_EventCollectionCS.Get(character)?.Evt_RequestSmartCastSkill.Invoke(
                                               13071, null, EMontageBindReason.NormalSkill, false);
                            }
                        }

                        if (SkillID == 23071)
                        {
                            // 马哥 法术


                            if (!isFinishCoolDown(SkillID, character))
                            {
                                BUS_EventCollectionCS.Get(character)?.Evt_RequestSmartCastSkill.Invoke(
                                               23071, null, EMontageBindReason.NormalSkill, false);
                            }
                        }

                        if (SkillID == 24082 || SkillID == 25084)
                        {
                            // 巨猿铜头 
                            if (BGUFunctionLibraryCS.GetAttrValue(character, EBGUAttrFloat.Pevalue) < 200)
                            {
                                BUS_EventCollectionCS.Get(character)?.Evt_RequestSmartCastSkill.Invoke(
                                               24311, null, EMontageBindReason.NormalSkill, false);
                            }
                            else if (!isFinishCoolDown(SkillID, character))
                            {
                                BUS_EventCollectionCS.Get(character)?.Evt_RequestSmartCastSkill.Invoke(
                                                24311, null, EMontageBindReason.NormalSkill, false);
                            }
                        }

                        if (SkillID == 24091)
                        {

                            TriggerEffect(character, 2409101);
                            // 巨猿分身术，变成突进平A
                            if (BGUFunctionLibraryCS.GetAttrValue(character, EBGUAttrFloat.Pevalue) < 200)
                            {
                                BUS_EventCollectionCS.Get(character)?.Evt_RequestSmartCastSkill.Invoke(
                                               25010, null, EMontageBindReason.NormalSkill, false);
                            }
                            else if (!isFinishCoolDown(SkillID, character))
                            {
                                BUS_EventCollectionCS.Get(character)?.Evt_RequestSmartCastSkill.Invoke(
                                                25010, null, EMontageBindReason.NormalSkill, false);
                            }
                        }


                        if (SkillID == 24071)
                        {
                            // 巨猿进入冰 法术  24072火法术


                            if (!isFinishCoolDown(SkillID, character))
                            {
                                BUS_EventCollectionCS.Get(character)?.Evt_RequestSmartCastSkill.Invoke(
                                               25134, null, EMontageBindReason.NormalSkill, false);
                            }
                        }

                        if (SkillID == 24072)
                        {
                            // 巨猿进入冰 法术  24072火法术


                            if (!isFinishCoolDown(SkillID, character))
                            {
                                BUS_EventCollectionCS.Get(character)?.Evt_RequestSmartCastSkill.Invoke(
                                               25214, null, EMontageBindReason.NormalSkill, false);
                            }
                        }

                        break;
                    }
            }
        }

        /// <summary>
        /// 传送到目标附近，保留指定距离（带碰撞检测）
        /// </summary>
        /// <param name="offsetDistance">与目标保留的距离（单位：厘米）</param>
        public static void TeleportNearTarget(float offsetDistance = 200f)
        {
            var character = GetCharacter();
            if (character == null) return;

            UnitLockTargetInfo targetInfo = BGUFunctionLibraryCS.BGUGetTargetInfo(character);
            AActor targetActor = targetInfo.LockTargetActor;
            if (targetActor == null)
            {
                Log.Info("TeleportNearTarget: 没有锁定目标");
                return;
            }

            FVector charPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(character);
            FVector targetPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(targetActor);
            FVector direction = (targetPos - charPos);
            float distance = direction.Size();

            if (distance <= offsetDistance)
            {
                Log.Info($"TeleportNearTarget: 距离({distance:F0})已在offsetDistance({offsetDistance:F0})范围内，跳过传送");
                return;
            }

            FVector dirNorm = direction.GetSafeNormal();
            FVector destPos = targetPos - dirNorm * offsetDistance;
            FRotator faceRot = MathLib.Conv_VectorToRotator(dirNorm);

            // 1. 向下射线检测地面高度，防止传入地下
            FVector traceTop = new FVector(destPos.X, destPos.Y, destPos.Z + 500f);
            FVector traceBottom = new FVector(destPos.X, destPos.Y, destPos.Z - 5000f);
            FHitResultSimple groundHit;
            int groundResult = UBGUSelectUtil.LineTraceSimple(
                character, traceTop, traceBottom,
                ETraceTypeQuery.TraceTypeQuery1, false, out groundHit, null);
            if (groundResult > 0)
            {
                destPos.Z = groundHit.HitLocation.Z + 50f; // 地面上方50cm（约半高）
            }

            // 2. 水平射线检测墙壁阻挡
            FHitResultSimple wallHit;
            int wallResult = UBGUSelectUtil.LineTraceSimple(
                character, charPos, destPos,
                ETraceTypeQuery.TraceTypeQuery1, false, out wallHit, null);
            if (wallResult > 0)
            {
                // 路径被阻挡，退到碰撞点前方
                destPos = wallHit.HitLocation - dirNorm * 50f;
                Log.Info("TeleportNearTarget: 路径被阻挡，退到碰撞点前方");
            }

            // 3. 使用 bSweep 碰撞安全方式放置角色
            character.BGUSetActorLocation(destPos, bSweep: true, bTeleport: true);
            character.BGUSetActorRotation(faceRot, bTeleportPhysics: false);
            Log.Info($"TeleportNearTarget: 传送到目标附近, 距离目标={offsetDistance}, 原距离={distance:F0}");
        }

        /// <summary>
        /// 取角色胶囊体半高（用于落地时把单位抬到地面之上），取不到时给一个保守值。
        /// </summary>
        private static float GetCapsuleHalfHeightForGround(AActor actor)
        {
            try
            {
                var ch = actor as ACharacter;
                if (ch != null && !ch.IsNullOrDestroyed() && ch.CapsuleComponent != null && !ch.CapsuleComponent.IsNullOrDestroyed())
                {
                    float h = ch.CapsuleComponent.GetScaledCapsuleHalfHeight();
                    if (h > 0f) return h;
                }
            }
            catch { }
            return 100f;
        }

        /// <summary>
        /// 把当前锁定的目标拉到自己正前方指定距离处，并默认让它背对自己（方便从背后偷袭 / 放投技）。
        /// </summary>
        /// <param name="distance">正前方距离（厘米），默认 500</param>
        /// <param name="facing">落位后的朝向：away=背对自己(默认) / face=面对自己 / keep=保持原朝向</param>
        /// <param name="groundSnap">是否向下射线贴合地面（防止传进地下或悬空），默认 true</param>
        /// <returns>是否成功传送</returns>
        public static bool TeleportTargetToFront(float distance = 500f, string? facing = "away", bool groundSnap = true)
        {
            var character = GetCharacter();
            if (character == null) return false;

            // 锁定目标：优先取锁定信息里的目标，取不到再退回 BGUGetTarget
            AActor? target = null;
            try
            {
                UnitLockTargetInfo targetInfo = BGUFunctionLibraryCS.BGUGetTargetInfo(character);
                target = targetInfo.LockTargetActor;
            }
            catch (Exception e)
            {
                Log.Warn($"[TeleportTargetToFront] 读取锁定信息失败: {e.Message}");
            }
            if (target == null || target.IsNullOrDestroyed())
            {
                target = BGUFunctionLibraryCS.BGUGetTarget(character);
            }
            if (target == null || target.IsNullOrDestroyed())
            {
                Log.Info("[TeleportTargetToFront] 没有锁定目标，跳过");
                return false;
            }

            FVector selfPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(character);

            // 自己的朝向（只取水平分量，避免上下抬头影响落点）
            FVector forward = character.GetActorForwardVector();
            forward.Z = 0f;
            if (forward.Size() < 0.001f) forward = new FVector(1f, 0f, 0f);
            forward = forward.GetSafeNormal();

            FVector destPos = selfPos + forward * distance;

            // 1. 向下射线贴合地面
            if (groundSnap)
            {
                FVector traceTop = new FVector(destPos.X, destPos.Y, destPos.Z + 500f);
                FVector traceBottom = new FVector(destPos.X, destPos.Y, destPos.Z - 5000f);
                FHitResultSimple groundHit;
                int groundResult = UBGUSelectUtil.LineTraceSimple(
                    character, traceTop, traceBottom,
                    ETraceTypeQuery.TraceTypeQuery1, false, out groundHit, null);
                if (groundResult > 0)
                {
                    destPos.Z = groundHit.HitLocation.Z + GetCapsuleHalfHeightForGround(target);
                }
            }

            // 2. 水平路径被墙挡住时，退到碰撞点前方
            FHitResultSimple wallHit;
            int wallResult = UBGUSelectUtil.LineTraceSimple(
                character, selfPos, destPos,
                ETraceTypeQuery.TraceTypeQuery1, false, out wallHit, null);
            if (wallResult > 0)
            {
                destPos = wallHit.HitLocation - forward * 50f;
                Log.Info("[TeleportTargetToFront] 前方被阻挡，退到碰撞点前方");
            }

            // 3. 落位（bTeleport：不做插值/不触发扫掠速度）
            target.BGUSetActorLocation(destPos, bSweep: true, bTeleport: true);

            // 4. 朝向：默认背对自己 —— 目标朝向 = 自己面朝的方向，于是它的后背朝着自己
            string mode = string.IsNullOrEmpty(facing) ? "away" : facing!.Trim().ToLowerInvariant();
            if (mode != "keep")
            {
                FVector faceDir = (mode == "face") ? -forward : forward;
                FRotator rot = BGUFuncLibActorTransformCS.BGUGetActorRotation(target);
                rot.Pitch = 0f;
                rot.Roll = 0f;
                rot.Yaw = MathLib.Conv_VectorToRotator(faceDir).Yaw;
                target.BGUSetActorRotation(rot, bTeleportPhysics: false);
            }

            Log.Info($"[TeleportTargetToFront] 目标 {target.GetName()} 已拉到身前 {distance:F0}，朝向={mode}");
            return true;
        }

        /// <summary>
        /// 计算并设置 AMScale 缩放率（需要蒙太奇正在播放才生效）
        /// </summary>
        public static void CalcAMScale(
            float totalDuration = 0.3f,
            float notifyBeginTime = 0f,
            float notifyEndTime = 0.3f,
            float minRate = 0.01f,
            float maxRate = 20f,
            float moveOffset = 0f,
            float moveOffsetZ = 0f)
        {
            var character = GetCharacter();
            if (character == null) return;
            BUS_GSEventCollection eventCollection = BUS_EventCollectionCS.Get(character);
            if (eventCollection == null) return;

            eventCollection.Evt_SetAMScaleRateByPosMultiCast.Invoke(
                EAMScaleType.ScaleForTarget,
                EAMScaleRateAxis.AxisX,
                75f,    // LandingTraceLength
                1f,     // PureScaleValue
                0,      // CachedDataID
                false,  // AttackRangeLimit
                false,  // DebugMode
                totalDuration,
                notifyBeginTime,
                notifyEndTime,
                minRate,
                maxRate,
                moveOffset,
                moveOffsetZ);
            Log.Info($"CalcAMScale: Duration={totalDuration}, Rate=[{minRate},{maxRate}], Offset=({moveOffset},{moveOffsetZ})");
        }
        public static void doPhantomRushSkill(BGUCharacterCS actor, string direction)
        {
            ESkillDirection phantomRushDir = ESkillDirection.None;
            switch (direction)
            {
                case "null":
                    phantomRushDir = ESkillDirection.Forward;
                    break;
                case "Forward":
                    phantomRushDir = ESkillDirection.Forward;
                    break;
                case "Backward":
                    phantomRushDir = ESkillDirection.Backward;
                    break;
                case "Left":
                    phantomRushDir = ESkillDirection.Left;
                    break;
                case "Right":
                    phantomRushDir = ESkillDirection.Right;
                    break;
            }
            BUS_EventCollectionCS.Get(actor).Evt_TriggerPhantomRush.Invoke(phantomRushDir);
        }



        public static void ModifyCD(int SkillID, bool bAddOrMul, float value)
        {

            var character = GetCharacter();
            if (character == null) return;
            // 10095
            BUS_EventCollectionCS.Get(character)?.Evt_ModifyCD.Invoke(SkillID, bAddOrMul, value);
        }
        public static void OnRequestSmartCastSkill(int SkillID, List<int> MappingRuleIDList, EMontageBindReason Reason, bool bNeedCheckSkillCanCast, ECastSkillSourceType SourceType)
        {
            var character = GetCharacter();
            if (character == null) return;
            FUStSkillSDesc SkillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, character);
            if (SkillSDesc == null) return;
            var pathName = SkillSDesc.TemplatePath;
            if (ModLog.Verbose) ModLog.Info($"执行释放cast_actions OnRequestSmartCastSkill: {SkillID}, TemplatePath: {pathName}，_sweepCheckBindings数量：{ActionExecutor._sweepCheckBindings?.Count} ");
            ActionExecutor.DoCastActions(character, pathName);


            if (SkillID == 10705 || SkillID == 10706 || SkillID == 10723 || SkillID == 50001 || SkillID == 50003 || SkillID == 50005)
            {

                BGUFunctionLibraryCS.BGUAddBuff(character, character, 289, EBuffSourceType.GM);
            }

            if (SkillID == 10530)
            {
                // 喝药

                if (BGUFunctionLibraryCS.GetAttrValue(character, EBGUAttrFloat.BloodBottomNum) < 1)
                {
                    BGUFunctionLibraryCS.GM_AddAttr(character, EBGUAttrFloat.BloodBottomNum, 1);
                }
            }
        }

        public static void BuffBegin(int BuffID, AActor Caster, AActor RootCaster, float Duration, EBuffSourceType BuffSourceType, bool bRecursed, FBattleAttrSnapShot BattleAttrSnapShot)
        {
            var character = GetCharacter();
            if (character == null) return;
            // 根据 BuffID 匹配 BuffActions 文件夹中的配置并执行对应动作
            ActionExecutor.DoBuffBeginActions(character, BuffID);
        }
        public static void OnTriggerSkillEffect(int EffectID, FEffectInstReq EffectInstReq, AActor InnerTarget, bool bWithRPCEvent)
        {
            var character = GetCharacter();
            if (character == null) return;
            // 技能效果触发极频繁：整条日志（含 InnerTarget.GetName() 原生调用）都收进开关，
            // 关闭时连字符串拼接和 GetName 都不会执行
            if (ModLog.Verbose) ModLog.Info($"执行技能效果 OnTriggerSkillEffect: {EffectID}, InnerTarget: {InnerTarget?.GetName()}");
            // 根据 EffectID 匹配 EffectActions 文件夹中的配置并执行对应动作
            ActionExecutor.DoSkillEffectActions(character, EffectID, EffectInstReq);
        }



        // public static void BuffBegin(int BuffID, AActor Caster, AActor RootCaster, float Duration, EBuffSourceType BuffSourceType = EBuffSourceType.Default, bool bRecursed = false, FBattleAttrSnapShot BattleAttrSnapShot = default(FBattleAttrSnapShot))
        // {
        //     Log.Info($"添加buff BuffBegin: {BuffID}, Caster: {Caster?.GetName()}, RootCaster: {RootCaster?.GetName()}, Duration: {Duration}");
        // }
        public static void SweepCheckBegin(int ObjectID, int WeaponIndex, List<FUStCheckShape> SweepCheckShape, List<int> EffectIDList, List<AbnormalStateAccConfig> AbnormalStateEffectList, List<int> EffectIDListForSceneItem, FHitDestructibleActorConfig HitDestructibleActorConfig, int HitChrAudioID, int HitChrFXWeight, FHitCheckConf HitCheckConf, bool CanHitBackBullet, float SweepCheckProtectTime, UAnimSequenceBase Animation, UAnimMontage AtkReboundingAM, UAnimMontage LowAtkReboundingAM, int SweepCheckGroupID, int FromInstanceID, List<FTriggerEffectWithCondition> EffectsWithCondition_Before, List<FTriggerEffectWithCondition> EffectsWithCondition_After, float NotifyBeginTime)
        {
            var character = GetCharacter();
            if (character == null || Animation == null) return;
            var pathName = Animation.GetPathName();
            if (ModLog.Verbose) ModLog.Info($"执行碰撞检查 SweepCheckBegin Animation:{pathName},NotifyBeginTime:{NotifyBeginTime}");

            // 注：这里不再手动放大 SweepCheck 的碰撞体 ——
            // 游戏组件 BeginPlay 就订阅了本事件，FUStCheckShape 是 struct，
            // 派发时就被值拷贝进 FSweepCheckCombineInfo（b.EnableCombineSweepCheckShape 默认 1），
            // 我们的修改改不到那份拷贝。

            ActionExecutor.DoSweepCheckActions(character, pathName, NotifyBeginTime);
        }
        /// <summary>
        /// 查找 Actor 上的指定 Component（与 Bian.Helper 一致）
        /// </summary>
        public static T? FindActorCompByClass<T>(BGUCharacterCS character) where T : UActorCompBaseCS
        {
            if (character == null) return null;
            UActorCompContainerCS acc = character.ActorCompContainerCS;
            FieldInfo field = typeof(UActorCompContainerCS).GetField("CompCSs", BindingFlags.NonPublic | BindingFlags.Instance);
            if (field == null) return null;

            List<UActorCompBaseCS>? comps = field.GetValue(acc) as List<UActorCompBaseCS>;
            if (comps == null) return null;

            foreach (var comp in comps)
            {
                if (comp is T typedComp) return typedComp;
            }
            return null;
        }

        /// <summary>
        /// 释放法术技能
        /// </summary>
        public static void CastVigorSkillByID(BGUPlayerCharacterCS character, int vigorSkillId)
        {
            var magicChangeComp = FindActorCompByClass<BUS_MagicallyChangeComp>(character);
            if (magicChangeComp == null) return;

            var soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(vigorSkillId);
            if (soulSkillDesc == null)
            {
                Log.Warn($"[MagicMod] SoulSkillDesc 未找到 ID={vigorSkillId}");
                return;
            }

            var BGS = BUS_EventCollectionCS.Get(character);
            BGS?.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(vigorSkillId, ECastSkillSourceType.GM));
        }
        public static bool IsWuKong(BGUPlayerCharacterCS character)
        {
            if (character == null || character.IsNullOrDestroyed()) return false;
            var mesh = character.Mesh;
            if (mesh == null || mesh.IsNullOrDestroyed()) return false;
            var sk = mesh.SkeletalMesh;
            if (sk == null || sk.IsNullOrDestroyed()) return false;
            var name = sk.GetFullName();
            return !string.IsNullOrEmpty(name)
                && name.ToLowerInvariant().IndexOf("sk_wukong_simple") > -1;
        }

        /// <summary>
        /// 当前角色的骨骼网格资源全名，如
        /// "SkeletalMesh /Game/00MainHZ/Characters/Wukong/Meshes/Preview/Simple/SK_Wukong_Simple.SK_Wukong_Simple"
        /// 取不到时返回空串。
        /// </summary>
        public static string GetCurrentSKMeshName(BGUPlayerCharacterCS character)
        {
            if (character == null) return "";
            return character.Mesh?.SkeletalMesh?.GetFullName() ?? "";
        }

        /// <summary>
        /// 骨骼作用域匹配：skMesh 为空视为通用（恒真）；否则按资源名子串忽略大小写匹配。
        /// </summary>
        public static bool MatchSKMesh(BGUPlayerCharacterCS character, string? skMesh)
        {
            if (string.IsNullOrEmpty(skMesh)) return true;
            string current = GetCurrentSKMeshName(character);
            if (string.IsNullOrEmpty(current)) return false;
            return current.IndexOf(skMesh!, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public static void setMagicBack(BGUPlayerCharacterCS character, bool isBack)
        {

            var magicChangeComp = FindActorCompByClass<BUS_MagicallyChangeComp>(character);
            if (magicChangeComp == null) return;
            FieldInfo fieldData = typeof(BUS_MagicallyChangeComp).GetField("MagicallyChangeData", BindingFlags.NonPublic | BindingFlags.Instance);
            if (fieldData == null) return;
            BUC_MagicallyChangeData data = fieldData.GetValue(magicChangeComp) as BUC_MagicallyChangeData;
            if (data == null) return;
            data.DurMagicallyChange = (bool)isBack;  // false 不变回去，需要手动变回 

        }

        public static bool IsShiTou(BGUPlayerCharacterCS character)
        {
            if (character == null) return false;
            Log.Info($"执行变身检查 IsShiTou: {character.Mesh?.SkeletalMesh?.GetFullName()}");
            return character.Mesh?.SkeletalMesh?.GetFullName()?.ToLower()?.IndexOf("SK_HFM_ShanZhen_01.SK_HFM_ShanZhen_01".ToLower()) > -1;
        }
        /// <summary>
        /// 释放变身技能
        /// </summary>
        public static void CastMimicrySkill(BGUPlayerCharacterCS character, int vigorSkillId)
        {
            var soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(vigorSkillId);
            if (soulSkillDesc == null)
            {
                Log.Warn($"[MagicMod] Mimicry SoulSkillDesc 未找到 ID={vigorSkillId}");
                return;
            }

            var magicChangeComp = FindActorCompByClass<BUS_MagicallyChangeComp>(character);
            var BGS = BUS_EventCollectionCS.Get(character);

            if (magicChangeComp != null && BGS != null)
            {
                BGS.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(vigorSkillId, ECastSkillSourceType.GM));
            }
        }
        public static BGWDataAsset_ProjectileSpawnConfig getBGWDataAsset_ProjectileSpawnConfig(string path, AActor character)
        {
            return BGW_PreloadAssetMgr.Get(character).TryGetCachedResourceObj<BGWDataAsset_ProjectileSpawnConfig>(path, ELoadResourceType.SyncLoadAndCache);

        }

        // 默认的 ProjectileSpawnConfig 资源路径，当 bulletConfig 未指定 path 时使用
        public static string DefaultProjectileSpawnConfigPath = "/Game/DefaultProjectileSpawnConfig";

        public static void SpawnProjectile(AActor character, bulletConfig ProjectileSpawnConfig)
        {

            if (ProjectileSpawnConfig == null || character == null)
            {
                return;
            }

            // 始终从路径加载，无 path 时使用默认路径，确保配置有合理的默认值
            string loadPath = ProjectileSpawnConfig.path ?? DefaultProjectileSpawnConfigPath;
            BGWDataAsset_ProjectileSpawnConfig cfg = getBGWDataAsset_ProjectileSpawnConfig(loadPath, character);
            if (cfg == null)
            {
                return;
            }

            AActor aActor = character;
            BUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(aActor);
            if (readOnlyData != null && readOnlyData.HasState(EBGUUnitState.Dead))
            {
                return;
            }
            ACharacter? aCharacter = aActor as ACharacter;
            if (aCharacter == null)
            {
                return;
            }
            BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aCharacter);


            if (bUS_GSEventCollection != null)
            {

                AActor Caster = aActor;
                AActor Target = Caster;
                var distanceNum = 500;
                if (ProjectileSpawnConfig.distance != null)
                {
                    distanceNum = (int)ProjectileSpawnConfig.distance;
                }
                var distance = getTargetDistane();
                if (ProjectileSpawnConfig.Target != null)
                {
                    Target = ProjectileSpawnConfig.Target;
                    Caster = Target;
                }

                if (ProjectileSpawnConfig.type == "shot" && BGUFunctionLibraryCS.BGUGetTarget(Caster) != null)
                {
                    Target = BGUFunctionLibraryCS.BGUGetTarget(Caster);
                }
                FEffectInstReq EffectInstReq = default(FEffectInstReq);

                // 使用局部变量存储最终值，避免修改缓存的 cfg 原始数据
                int finalProjectileID = cfg.ProjectileID;
                int finalProjectileNumInOneWave = 1;
                ProjectileBaseStruct finalTargetBase = cfg.TargetBase;
                ProjectileBornDirStruct finalBornDirBaseInfo = cfg.BornDirBaseInfo;
                FSpawnBulletSpeed finalBulletFlySpd = cfg.BulletFlySpd;
                ProjectilePosOffsetStruct finalSpawnPosOffsetInfo = cfg.SpawnPosOffsetInfo;
                ProjectileBaseStruct finalSpawnBase = cfg.SpawnBase;

                if (ProjectileSpawnConfig.ProjectileID > 0)
                {
                    finalProjectileID = ProjectileSpawnConfig.ProjectileID;
                }
                if (ProjectileSpawnConfig.ProjectileNumInOneWave > 0)
                {
                    finalProjectileNumInOneWave = (int)ProjectileSpawnConfig.ProjectileNumInOneWave;
                }

                if (ProjectileSpawnConfig?.type == "shot")
                {

                    if (distance >= distanceNum)
                    {
                        finalTargetBase.UseSocket = true;
                        finalTargetBase.SocketName = (FName)"CAMERA_LOCK";
                        finalBornDirBaseInfo.BornDirType = ProjectileBornDirType.LookAtTargetPos;
                    }
                    else
                    {
                        finalBornDirBaseInfo.BornDirType = ProjectileBornDirType.UseSlotDir;
                    }
                    finalTargetBase.BaseType = ProjectileBaseType.CurTarget_ProjectileSpawner;


                    finalBulletFlySpd.Spd.LeftValue = 7000;
                    finalBulletFlySpd.Spd.RightValue = 7000;
                }

                if (ProjectileSpawnConfig?.BulletFlySpd > 0)
                {
                    finalBulletFlySpd.Spd.LeftValue = (int)ProjectileSpawnConfig.BulletFlySpd;
                    finalBulletFlySpd.Spd.RightValue = (int)ProjectileSpawnConfig.BulletFlySpd;
                }

                // 合并 SpawnPosOffset（基于当前值修改对应分量）
                bool offsetChanged = false;

                var xyz = aActor.GetActorForwardVector();
                if (ProjectileSpawnConfig?.SpawnOffsetX != null)
                {
                    var offsetX = (float)ProjectileSpawnConfig.SpawnOffsetX;
                    finalSpawnPosOffsetInfo.PosOffset.X = offsetX * xyz.X;
                    offsetChanged = true;
                }
                if (ProjectileSpawnConfig?.SpawnOffsetY != null)
                {

                    var offsetY = (float)ProjectileSpawnConfig.SpawnOffsetY;
                    finalSpawnPosOffsetInfo.PosOffset.Y = offsetY * xyz.Y;

                    offsetChanged = true;
                }
                if (ProjectileSpawnConfig?.SpawnOffsetZ != null)
                {


                    var offsetZ = (float)ProjectileSpawnConfig.SpawnOffsetZ;
                    finalSpawnPosOffsetInfo.PosOffset.Z = offsetZ * xyz.Z;
                    offsetChanged = true;
                }
                if (offsetChanged)
                {
                    finalSpawnPosOffsetInfo.PosOffsetType = ProjectilePosOffsetType.Normal;
                }

                if (ProjectileSpawnConfig?.spawnBaseSocketName != null)
                {
                    finalSpawnBase.UseSocket = true;
                    finalSpawnBase.SocketName = (FName)(ProjectileSpawnConfig.spawnBaseSocketName);
                }

                var finalBornDir = cfg.BornDirOffset;
                if (ProjectileSpawnConfig?.BornDirOffsetX != null)
                {
                    finalBornDir.BornDirOffsetX.LeftValue = (float)ProjectileSpawnConfig.BornDirOffsetX;
                    finalBornDir.BornDirOffsetX.RightValue = (float)ProjectileSpawnConfig.BornDirOffsetX;
                }
                if (ProjectileSpawnConfig?.BornDirOffsetY != null)
                {
                    finalBornDir.BornDirOffsetY.LeftValue = (float)ProjectileSpawnConfig.BornDirOffsetY;
                    finalBornDir.BornDirOffsetY.RightValue = (float)ProjectileSpawnConfig.BornDirOffsetY;
                }
                if (ProjectileSpawnConfig?.BornDirOffsetZ != null)
                {
                    finalBornDir.BornDirOffsetZ.LeftValue = (float)ProjectileSpawnConfig.BornDirOffsetZ;
                    finalBornDir.BornDirOffsetZ.RightValue = (float)ProjectileSpawnConfig.BornDirOffsetZ;
                }


                if (ProjectileSpawnConfig?.effectInstReq != null)
                {
                    EffectInstReq = (FEffectInstReq)ProjectileSpawnConfig.effectInstReq;
                    finalSpawnBase.BaseType = ProjectileBaseType.UseEffectPosition;
                }

                // 仅在最后创建 ProjectileSpawnNSInfo，用于 Init 和事件调用
                FGSProjecttileObjSpawnNSInfo ProjectileSpawnNSInfo = new FGSProjecttileObjSpawnNSInfo();
                ProjectileSpawnNSInfo.ProjectileType = EProjectileType.Bullet;
                ProjectileSpawnNSInfo.BuffIDList = cfg.BuffIDList.ToList();
                ProjectileSpawnNSInfo.ProjectileID = finalProjectileID;
                ProjectileSpawnNSInfo.SpawnWave = cfg.ProjectileWave;

                Log.Info($"SpawnProjectile: {finalSpawnBase.SocketName} {ProjectileSpawnNSInfo.ProjectileID}");
                ProjectileSpawnNSInfo.SpawnNumPerWave = finalProjectileNumInOneWave;
                ProjectileSpawnNSInfo.InitSpawnInfo(finalSpawnBase, finalSpawnPosOffsetInfo, cfg.bEnableSpawnBase_NoneTarget, cfg.SpawnBase_NoneTarget, cfg.SpawnPosOffsetInfo_NoneTarget, Caster, aCharacter, Target, null, in EffectInstReq);
                ProjectileSpawnNSInfo.AttachToSpawnBase = cfg.AttachToSpawnBase;
                ProjectileSpawnNSInfo.AttachRule_Rot = cfg.AttachRule_Rot;
                ProjectileSpawnNSInfo.InitTargetInfo(finalTargetBase, cfg.TargetPosOffsetInfo, cfg.bEnableTargetBase_NoneTarget, cfg.TargetBase_NoneTarget, cfg.TargetPosOffsetInfo_NoneTarget, Caster, aCharacter, Target, null, in EffectInstReq);
                ProjectileSpawnNSInfo.BornDirBaseInfo = finalBornDirBaseInfo;
                ProjectileSpawnNSInfo.BornDirOffset = finalBornDir;
                ProjectileSpawnNSInfo.ProjectileFlySpd = finalBulletFlySpd;
                ProjectileSpawnNSInfo.ProjectileRotSpd = cfg.BulletRotSpd;
                ProjectileSpawnNSInfo.MontageID = -1;
                ProjectileSpawnNSInfo.SpawnWaveDuration = ((ProjectileSpawnNSInfo.SpawnWave > 1) ? (ProjectileSpawnNSInfo.ANSTotalTime / (float)(ProjectileSpawnNSInfo.SpawnWave - 1)) : 0f);
                ProjectileSpawnNSInfo.SpawnCounter = 0;
                ProjectileSpawnNSInfo.SpawnWaveCounter = 0;
                ProjectileSpawnNSInfo.bEnableMultiTargetMode = cfg.bEnableMultiTargetMode;
                ProjectileSpawnNSInfo.MutilTargetRule = cfg.MutilTargetRule;
                bUS_GSEventCollection.Evt_OnNotifyStateSpawnProjectileObj.Invoke(ref ProjectileSpawnNSInfo);
            }
        }
    }
}
