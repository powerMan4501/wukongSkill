using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using b1;
using b1.BGW;
using b1.Plugins.Calliope;
using B1UI;
using BtlB1;
using BtlShare;
using CommB1;
using CsB1;
using CSharpModBase;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace ActionsMod
{
    /// <summary>
    /// 自包含的玩家/角色辅助方法（从 MagicMod 的 ModHelper/ModUtils 提取，去掉对 MagicMod 其它子系统的依赖）。
    /// </summary>
    public static class ModHelper
    {
        /// <summary>获取游戏世界（从 GWorld 全局指针读取）</summary>
        public static UWorld? GetWorld()
        {
            UObjectRef uobjectRef = GCHelper.FindRef(FGlobals.GWorld);
            return uobjectRef?.Managed as UWorld;
        }

        /// <summary>获取本地玩家控制器</summary>
        public static BGP_PlayerControllerB1? GetPlayerController()
        {
            var world = GetWorld();
            if (world == null || world.IsNullOrDestroyed()) return null;
            var pc = UGSE_EngineFuncLib.GetFirstLocalPlayerController(world);
            if (pc == null || pc.IsNullOrDestroyed()) return null;
            return pc as BGP_PlayerControllerB1;
        }

        /// <summary>获取当前受控 Pawn</summary>
        public static APawn? GetControlledPawn()
        {
            var pc = GetPlayerController();
            if (pc == null || pc.IsNullOrDestroyed()) return null;
            return pc.GetControlledPawn();
        }

        /// <summary>获取当前受控玩家角色（BGUPlayerCharacterCS）；变身期间受控 Pawn 可能是 Boss 而返回 null</summary>
        public static BGUPlayerCharacterCS? GetBGUPlayerCharacterCS()
        {
            return GetControlledPawn() as BGUPlayerCharacterCS;
        }

        /// <summary>获取当前玩家角色（OnKeyPressed 等场景使用）</summary>
        public static BGUPlayerCharacterCS? GetCharacter()
        {
            return GetBGUPlayerCharacterCS();
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
                && name.ToLowerInvariant().IndexOf("sk_wukong_simple", StringComparison.Ordinal) > -1;
        }

        /// <summary>当前角色的骨骼网格资源全名，取不到时返回空串</summary>
        public static string GetCurrentSKMeshName(BGUPlayerCharacterCS character)
        {
            if (character == null) return "";
            return character.Mesh?.SkeletalMesh?.GetFullName() ?? "";
        }

        /// <summary>骨骼作用域匹配：skMesh 为空视为通用（恒真）；否则按资源名子串忽略大小写匹配</summary>
        public static bool MatchSKMesh(BGUPlayerCharacterCS character, string? skMesh)
        {
            if (string.IsNullOrEmpty(skMesh)) return true;
            string current = GetCurrentSKMeshName(character);
            if (string.IsNullOrEmpty(current)) return false;
            return current.IndexOf(skMesh!, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        /// <summary>单位名作用域匹配：unitName 为空视为通用（恒真）；否则按角色单位名（GetName）子串忽略大小写匹配</summary>
        public static bool MatchUnitName(BGUPlayerCharacterCS character, string? unitName)
        {
            if (string.IsNullOrEmpty(unitName)) return true;
            string current = character.GetName() ?? "";
            if (string.IsNullOrEmpty(current)) return false;
            return current.IndexOf(unitName!, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        // ===== 物品发放（从 MagicMod.Utils.getPlayerMgr / gain_item / gain_items 提取）=====

        public static CommB1.PlayerDataMgr getPlayerMgr()
        {
            var Player = GSG.GamePlayer;
            var PlayerMgr = GSG.GamePlayer.CreateTransaction((OPReason)2);
            return PlayerMgr;
        }

        public static void gain_item(int ItemID, int ItemCount = 1)
        {
            var PlayerMgr = getPlayerMgr();
            if (PlayerMgr == null) return;
            PlayerMgr.Bag.GainItemOne(new ItemOne
            {
                Id = ItemID,
                Num = ItemCount
            });
            PlayerMgr.Commit();
        }

        /// <summary>批量获得物品：一个事务内连续 GainItemOne，最后只 Commit 一次</summary>
        public static int gain_items(IEnumerable<int> itemIds, int itemCount = 1)
        {
            if (itemIds == null) return 0;
            int num = itemCount < 1 ? 1 : itemCount;
            var PlayerMgr = getPlayerMgr();
            if (PlayerMgr == null) return 0;

            int added = 0;
            foreach (int id in itemIds)
            {
                if (id <= 0) continue;
                PlayerMgr.Bag.GainItemOne(new ItemOne
                {
                    Id = id,
                    Num = num
                });
                added++;
            }
            PlayerMgr.Commit();
            return added;
        }

        // ===== 组件查找（反射读 UActorCompContainerCS.CompCSs）=====

        /// <summary>在角色身上按类型查找业务组件（BUS_* / BUC_* 宿主）</summary>
        public static T? FindActorCompByClass<T>(BGUCharacterCS character) where T : UActorCompBaseCS
        {
            if (character == null || character.IsNullOrDestroyed()) return null;

            UActorCompContainerCS acc = character.ActorCompContainerCS;
            if (acc == null) return null;

            FieldInfo field = typeof(UActorCompContainerCS).GetField("CompCSs", BindingFlags.NonPublic | BindingFlags.Instance);
            if (field == null) return null;

            List<UActorCompBaseCS>? comps = field.GetValue(acc) as List<UActorCompBaseCS>;
            if (comps == null) return null;

            foreach (var comp in comps)
            {
                if (comp is T t) return t;
            }
            return null;
        }

        // ===== 幻化变身（MagicallyChange）相关 =====

        /// <summary>
        /// setMagicBack：设置幻化到持续时间结束是否自动变回。
        /// isBack=false 时不会自动变回，需要手动触发 out_magic。
        /// </summary>
        public static void setMagicBack(BGUPlayerCharacterCS character, bool isBack)
        {
            var magicChangeComp = FindActorCompByClass<BUS_MagicallyChangeComp>(character);
            if (magicChangeComp == null)
            {
                Log.Warn("[ActionsMod] setMagicBack 未找到 BUS_MagicallyChangeComp");
                return;
            }

            FieldInfo fieldData = typeof(BUS_MagicallyChangeComp).GetField("MagicallyChangeData", BindingFlags.NonPublic | BindingFlags.Instance);
            if (fieldData == null)
            {
                Log.Warn("[ActionsMod] setMagicBack 反射字段 MagicallyChangeData 失败");
                return;
            }

            if (fieldData.GetValue(magicChangeComp) is BUC_MagicallyChangeData data)
            {
                data.DurMagicallyChange = isBack;
                Log.Info($"[ActionsMod] setMagicBack DurMagicallyChange={isBack}");
            }
        }

        /// <summary>
        /// out_magic：退出幻化变身，变回原角色。
        /// 任何还原路径都先恢复被"幻化隐藏"的部件，避免残留导致头/部件消失。
        /// </summary>
        public static void magicallyChangeBack()
        {
            var character = GetCharacter();
            if (character == null)
            {
                Log.Warn("[ActionsMod] magicallyChangeBack 未找到玩家角色");
                return;
            }

            SoulBossLogic.RestoreMagicHidden();

            BUS_GSEventCollection BE_Owner = BUS_EventCollectionCS.Get(character);
            if (BE_Owner == null) return;
            BE_Owner.Evt_OnMagicallyChangeRecover.Invoke(10199);
        }

        /// <summary>Montage_SetPosition：把当前（或指定）Montage 的播放位置跳到指定秒</summary>
        public static void Montage_SetPosition(float positionSec, UAnimMontage? animMontage = null)
        {
            var character = GetCharacter();
            if (character == null) return;

            var mesh = character.Mesh;
            if (mesh == null || mesh.IsNullOrDestroyed()) return;

            UAnimInstance animInstance = mesh.GetAnimInstance();
            if (animInstance == null) return;

            if (animMontage != null)
            {
                animInstance.Montage_SetPosition(animMontage, positionSec);
                return;
            }

            UAnimMontage currentActiveMontage = animInstance.GetCurrentActiveMontage();
            if (currentActiveMontage != null)
            {
                animInstance.Montage_SetPosition(currentActiveMontage, positionSec);
            }
        }

        /// <summary>
        /// 技能是否已完成冷却（可释放），移植自 MagicMod.isFinishCoolDown。
        /// 依次看：取消CD状态 → CD百分比 → 剩余冷却时间。
        /// </summary>
        public static bool IsSkillCDFinished(int skillId, BGUPlayerCharacterCS character)
        {
            if (character == null || skillId <= 0) return false;

            try
            {
                BUC_SimpleStateData? simpleStateData = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(character);
                if (simpleStateData != null && simpleStateData.HasSimpleState(EBGUSimpleState.CancelSkillCD)) return true;

                IBUC_SkillInstsData? skillInstsData = BGU_DataUtil.GetReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(character);
                if (skillInstsData == null) return false;

                float cdPercent = BGUFuncLibSkillCS.GetSkillCDTimePercent(character, skillId, in skillInstsData);
                if (cdPercent >= 1) return true;

                if (skillInstsData.GetSkillCooldownTime(skillId, out float remainingCooldownTime, out _)) return true;
                return remainingCooldownTime <= 0f;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>触发 ExtLifeSaving（分身替死/救主，参照 MagicMod 的分身术用法）</summary>
        public static void ActiveExtLifeSaving(BGUPlayerCharacterCS character)
        {
            BUS_EventCollectionCS.Get(character)?.Evt_Active_ExtLifeSaving.Invoke(P1: true);
        }

        // ===== 召唤（summon）=====

        /// <summary>召唤物出生后重试设置阵营的时间点（毫秒），异步出生需要轮询</summary>
        private static readonly int[] SummonTeamApplyDelays = { 100, 300, 600, 1000, 2000 };

        /// <summary>
        /// summon 动作：召唤怪物/召唤物（移植自 MagicMod.SummonReq）。
        /// SummonID>0 时沿用 SummonCommDesc 配表；给了 path 则用该 Tamer 蓝图类覆盖模板。
        /// 可选：SkillID（出生技能）、SummonBuffIds（出生 Buff）、SummonTeamId（强制阵营，>0 生效）。
        /// </summary>
        public static FCalliopeGuid SummonReq(ActionConfig? action)
        {
            var character = GetCharacter();
            if (character == null) return default;

            int summonCount = action?.SummonCount ?? 1;
            int summonId = action?.SummonID ?? 0;
            int skillId = action?.SkillID ?? 0;
            float summonAliveTime = action?.SummonAliveTime ?? -1f;
            int teamId = action?.SummonTeamId ?? 0;
            string? path = action?.path;
            if (summonCount < 1) summonCount = 1;

            // 1) 自定义怪物：按 path 加载 Tamer 蓝图类
            UClass? tamerClass = null;
            if (!string.IsNullOrEmpty(path))
            {
                tamerClass = LoadTamerClass(path!);
                if (tamerClass == null)
                {
                    Log.Warn($"[ActionsMod] 召唤失败：无法加载 Tamer 类 {path}");
                    return default;
                }
            }

            // 2) 出生配置：有 SummonID 走配表；没有时用内置最小配置
            FSummonSpawnConfigWrap wrap = summonId > 0
                ? FSummonSpawnConfigWrap.WrapSpawnConfig_BySummonCommDesc(summonId, character)
                : CreateDefaultSummonWrap();

            if (tamerClass != null) wrap.TamerTemplate = tamerClass;
            if (wrap.TamerTemplate == null)
            {
                Log.Warn($"[ActionsMod] 召唤失败：既没有可用的 path，SummonID={summonId} 也没提供怪物模板");
                return default;
            }

            wrap.SummonAliveTime = summonAliveTime;
            wrap.DestroyDelayTime = 0f;

            // 3) 出生技能
            if (skillId > 0)
            {
                wrap.UseBornSkill = true;
                wrap.BornSkillIDs = new List<int> { skillId };
            }

            // 4) 出生 Buff（追加，不覆盖表内自带的）
            List<int>? birthBuffs = action?.SummonBuffIds;
            if (birthBuffs != null && birthBuffs.Count > 0)
            {
                if (wrap.SpawnBirthBuff == null) wrap.SpawnBirthBuff = new List<int>();
                foreach (int buffId in birthBuffs)
                {
                    if (buffId > 0 && !wrap.SpawnBirthBuff.Contains(buffId)) wrap.SpawnBirthBuff.Add(buffId);
                }
            }

            // 5) 自定义阵营：切断"跟随召唤者阵营"的主从同步，避免出生后被同步回玩家阵营
            if (teamId > 0) wrap.IsSummonerAsMaster = false;

            FSummonReq fSummonReq = default(FSummonReq);
            fSummonReq.SummonType = ESummonType.Normal;
            var summonGuid = GameplayTagExtension.ConvertToCalliopeGuid(Guid.NewGuid());
            fSummonReq.SummonGuid = summonGuid;
            fSummonReq.SummonID = summonId;
            fSummonReq.SummonCount = Convert.ToInt32(summonCount);
            fSummonReq.Summoner = character;
            fSummonReq.SpawnConfigWrap = wrap;

            FSummonReq inSummonReq = fSummonReq;
            BPS_EventCollectionCS.GetLocal(character).Evt_RequestSummon.Invoke(inSummonReq);
            Log.Info($"[ActionsMod] 召唤 SummonID={summonId} path={path ?? "（用表内模板）"} Count={summonCount} BornSkill={skillId} Team={teamId}");

            // 召唤物异步出生，出生后再设置阵营
            if (teamId > 0)
            {
                ScheduleSetSummonTeam(character, summonGuid, teamId);
            }
            return summonGuid;
        }

        /// <summary>不依赖 SummonCommDesc 的最小召唤配置：出生在召唤者位置、面向当前目标、按自身感知索敌</summary>
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

        /// <summary>加载 Tamer 蓝图类：先同步 LoadClass，失败再用预加载管理器按路径取</summary>
        private static UClass? LoadTamerClass(string path)
        {
            try
            {
                UClass uClass = UObject.LoadClass<AActor>(null, path);
                if (uClass != null) return uClass;
            }
            catch (Exception e)
            {
                Log.Warn($"[ActionsMod] LoadClass 失败 {path}: {e.Message}");
            }

            try
            {
                UWorld? world = GetWorld();
                if (world != null)
                {
                    return BGW_PreloadAssetMgr.Get(world)
                        .TryGetCachedResourceObj<UClass>(path, ELoadResourceType.SyncLoadAndCache);
                }
            }
            catch (Exception e)
            {
                Log.Warn($"[ActionsMod] 预加载 Tamer 类失败 {path}: {e.Message}");
            }
            return null;
        }

        /// <summary>延迟给本次召唤出来的单位设置阵营（异步出生，需重试直到能取到实例）</summary>
        private static void ScheduleSetSummonTeam(BGUPlayerCharacterCS summoner, FCalliopeGuid summonGuid, int teamId)
        {
            _ = Task.Run(async () =>
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
                Log.Warn($"[ActionsMod] 召唤物阵营设置失败：未取到本次召唤的实例 TeamID={teamId}");
            });
        }

        /// <summary>找到本次召唤产出的单位，设置阵营并重新索敌</summary>
        private static bool TryApplySummonTeam(BGUPlayerCharacterCS summoner, FCalliopeGuid summonGuid, int teamId)
        {
            List<BGUCharacterCS> units = GetSummonedUnits(summoner, summonGuid);
            if (units.Count == 0) return false;

            foreach (BGUCharacterCS unit in units)
            {
                unit.SetTeamIDInCS(teamId);
                BGUFuncLibAICS.SearchTargetSP(unit);
            }
            Log.Info($"[ActionsMod] 已把 {units.Count} 个召唤物的阵营设为 {teamId}");
            return true;
        }

        /// <summary>
        /// 取本次召唤（按 SummonGuid 匹配）已经生成出来的怪物实例；匹配不到时退化为"该召唤者最近一次召唤"。
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
                Log.Warn($"[ActionsMod] 获取召唤物实例失败: {e.Message}");
            }
            return result;
        }

        // ===== 位移 / 缩放 =====

        /// <summary>取胶囊体半高（用于落地面校准），取不到时给 100 兜底</summary>
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
        /// 把当前锁定的目标拉到自己正前方指定距离处，并默认让它背对自己（便于背刺 / 放投技）。
        /// </summary>
        /// <param name="distance">正前方距离（厘米），默认 500</param>
        /// <param name="facing">落位后的朝向：away=背对自己(默认) / face=面对自己 / keep=保持原朝向</param>
        /// <param name="groundSnap">是否向下射线贴合地面（防止传进地下或悬空），默认 true</param>
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
                Log.Warn($"[ActionsMod] [TeleportTargetToFront] 读取锁定信息失败: {e.Message}");
            }
            if (target == null || target.IsNullOrDestroyed())
            {
                target = BGUFunctionLibraryCS.BGUGetTarget(character);
            }
            if (target == null || target.IsNullOrDestroyed())
            {
                Log.Info("[ActionsMod] [TeleportTargetToFront] 没有锁定目标，跳过");
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
                Log.Info("[ActionsMod] [TeleportTargetToFront] 前方被阻挡，退到碰撞点前方");
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

            Log.Info($"[ActionsMod] [TeleportTargetToFront] 目标 {target.GetName()} 已拉到身前 {distance:F0}，朝向={mode}");
            return true;
        }

        /// <summary>计算并设置 AMScale 缩放率（需要当前有 Montage 在播才生效）</summary>
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

            BUS_GSEventCollection? eventCollection = BUS_EventCollectionCS.Get(character);
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
            Log.Info($"[ActionsMod] CalcAMScale: Duration={totalDuration}, Rate=[{minRate},{maxRate}], Offset=({moveOffset},{moveOffsetZ})");
        }

        // ===== 子弹（弹体）生成 =====

        /// <summary>默认的 ProjectileSpawnConfig 资源路径，当 bulletConfig 未指定 path 时使用</summary>
        public static string DefaultProjectileSpawnConfigPath = "/Game/DefaultProjectileSpawnConfig";

        /// <summary>加载 ProjectileSpawnConfig 资源（同步加载并缓存）</summary>
        public static BGWDataAsset_ProjectileSpawnConfig? GetProjectileSpawnConfig(string path, AActor character)
        {
            return BGW_PreloadAssetMgr.Get(character)
                .TryGetCachedResourceObj<BGWDataAsset_ProjectileSpawnConfig>(path, ELoadResourceType.SyncLoadAndCache);
        }

        /// <summary>玩家到当前锁定目标的距离（厘米），无目标/无角色时返回 0</summary>
        public static float GetTargetDistance()
        {
            var character = GetCharacter();
            if (character == null) return 0f;

            var target = BGUFunctionLibraryCS.BGUGetTarget(character);
            if (target == null) return 0f;

            FVector charPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(character);
            FVector targetPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(target);
            return (targetPos - charPos).Size();
        }

        /// <summary>
        /// 生成弹体（移植自 MagicMod.SpawnProjectile）：
        /// 以 path 指向的 BGWDataAsset_ProjectileSpawnConfig 为模板，用 bulletConfig 里的非缺省字段逐项覆盖，
        /// 最后通过 Evt_OnNotifyStateSpawnProjectileObj 派发生成请求。
        /// 注意：不修改 cfg 原始资源，一切覆盖都写在局部变量里。
        /// </summary>
        public static void SpawnProjectile(AActor character, bulletConfig ProjectileSpawnConfig)
        {
            if (ProjectileSpawnConfig == null || character == null) return;

            string loadPath = ProjectileSpawnConfig.path ?? DefaultProjectileSpawnConfigPath;
            BGWDataAsset_ProjectileSpawnConfig? cfg = GetProjectileSpawnConfig(loadPath, character);
            if (cfg == null)
            {
                Log.Warn($"[ActionsMod] 加载 ProjectileSpawnConfig 失败 path={loadPath}");
                return;
            }

            BUC_UnitStateData? readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(character);
            if (readOnlyData != null && readOnlyData.HasState(EBGUUnitState.Dead)) return;

            if (!(character is ACharacter aCharacter)) return;
            BUS_GSEventCollection? bUS_GSEventCollection = BUS_EventCollectionCS.Get(aCharacter);
            if (bUS_GSEventCollection == null) return;

            AActor caster = character;
            AActor target = caster;
            int distanceNum = ProjectileSpawnConfig.distance ?? 500;
            float distance = GetTargetDistance();

            if (ProjectileSpawnConfig.Target != null)
            {
                target = ProjectileSpawnConfig.Target;
                caster = target;
            }
            if (ProjectileSpawnConfig.type == "shot" && BGUFunctionLibraryCS.BGUGetTarget(caster) != null)
            {
                target = BGUFunctionLibraryCS.BGUGetTarget(caster);
            }

            FEffectInstReq effectInstReq = default(FEffectInstReq);

            // 用局部变量存覆盖后的值，避免写回 cfg 资源
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

            if (ProjectileSpawnConfig.type == "shot")
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

            if (ProjectileSpawnConfig.BulletFlySpd > 0)
            {
                finalBulletFlySpd.Spd.LeftValue = (int)ProjectileSpawnConfig.BulletFlySpd;
                finalBulletFlySpd.Spd.RightValue = (int)ProjectileSpawnConfig.BulletFlySpd;
            }

            bool offsetChanged = false;
            FVector xyz = character.GetActorForwardVector();
            if (ProjectileSpawnConfig.SpawnOffsetX != null)
            {
                finalSpawnPosOffsetInfo.PosOffset.X = (float)ProjectileSpawnConfig.SpawnOffsetX * xyz.X;
                offsetChanged = true;
            }
            if (ProjectileSpawnConfig.SpawnOffsetY != null)
            {
                finalSpawnPosOffsetInfo.PosOffset.Y = (float)ProjectileSpawnConfig.SpawnOffsetY * xyz.Y;
                offsetChanged = true;
            }
            if (ProjectileSpawnConfig.SpawnOffsetZ != null)
            {
                finalSpawnPosOffsetInfo.PosOffset.Z = (float)ProjectileSpawnConfig.SpawnOffsetZ * xyz.Z;
                offsetChanged = true;
            }
            if (offsetChanged)
            {
                finalSpawnPosOffsetInfo.PosOffsetType = ProjectilePosOffsetType.Normal;
            }

            if (ProjectileSpawnConfig.spawnBaseSocketName != null)
            {
                finalSpawnBase.UseSocket = true;
                finalSpawnBase.SocketName = (FName)ProjectileSpawnConfig.spawnBaseSocketName;
            }

            ProjectileBornDirOffsetStruct finalBornDir = cfg.BornDirOffset;
            if (ProjectileSpawnConfig.BornDirOffsetX != null)
            {
                finalBornDir.BornDirOffsetX.LeftValue = (float)ProjectileSpawnConfig.BornDirOffsetX;
                finalBornDir.BornDirOffsetX.RightValue = (float)ProjectileSpawnConfig.BornDirOffsetX;
            }
            if (ProjectileSpawnConfig.BornDirOffsetY != null)
            {
                finalBornDir.BornDirOffsetY.LeftValue = (float)ProjectileSpawnConfig.BornDirOffsetY;
                finalBornDir.BornDirOffsetY.RightValue = (float)ProjectileSpawnConfig.BornDirOffsetY;
            }
            if (ProjectileSpawnConfig.BornDirOffsetZ != null)
            {
                finalBornDir.BornDirOffsetZ.LeftValue = (float)ProjectileSpawnConfig.BornDirOffsetZ;
                finalBornDir.BornDirOffsetZ.RightValue = (float)ProjectileSpawnConfig.BornDirOffsetZ;
            }

            if (ProjectileSpawnConfig.effectInstReq != null)
            {
                effectInstReq = (FEffectInstReq)ProjectileSpawnConfig.effectInstReq;
                finalSpawnBase.BaseType = ProjectileBaseType.UseEffectPosition;
            }

            FGSProjecttileObjSpawnNSInfo ProjectileSpawnNSInfo = new FGSProjecttileObjSpawnNSInfo();
            ProjectileSpawnNSInfo.ProjectileType = EProjectileType.Bullet;
            ProjectileSpawnNSInfo.BuffIDList = cfg.BuffIDList.ToList();
            ProjectileSpawnNSInfo.ProjectileID = finalProjectileID;
            ProjectileSpawnNSInfo.SpawnWave = cfg.ProjectileWave;
            ProjectileSpawnNSInfo.SpawnNumPerWave = finalProjectileNumInOneWave;
            ProjectileSpawnNSInfo.InitSpawnInfo(finalSpawnBase, finalSpawnPosOffsetInfo, cfg.bEnableSpawnBase_NoneTarget,
                cfg.SpawnBase_NoneTarget, cfg.SpawnPosOffsetInfo_NoneTarget, caster, aCharacter, target, null, in effectInstReq);
            ProjectileSpawnNSInfo.AttachToSpawnBase = cfg.AttachToSpawnBase;
            ProjectileSpawnNSInfo.AttachRule_Rot = cfg.AttachRule_Rot;
            ProjectileSpawnNSInfo.InitTargetInfo(finalTargetBase, cfg.TargetPosOffsetInfo, cfg.bEnableTargetBase_NoneTarget,
                cfg.TargetBase_NoneTarget, cfg.TargetPosOffsetInfo_NoneTarget, caster, aCharacter, target, null, in effectInstReq);
            ProjectileSpawnNSInfo.BornDirBaseInfo = finalBornDirBaseInfo;
            ProjectileSpawnNSInfo.BornDirOffset = finalBornDir;
            ProjectileSpawnNSInfo.ProjectileFlySpd = finalBulletFlySpd;
            ProjectileSpawnNSInfo.ProjectileRotSpd = cfg.BulletRotSpd;
            ProjectileSpawnNSInfo.MontageID = -1;
            ProjectileSpawnNSInfo.SpawnWaveDuration = ((ProjectileSpawnNSInfo.SpawnWave > 1)
                ? (ProjectileSpawnNSInfo.ANSTotalTime / (float)(ProjectileSpawnNSInfo.SpawnWave - 1)) : 0f);
            ProjectileSpawnNSInfo.SpawnCounter = 0;
            ProjectileSpawnNSInfo.SpawnWaveCounter = 0;
            ProjectileSpawnNSInfo.bEnableMultiTargetMode = cfg.bEnableMultiTargetMode;
            ProjectileSpawnNSInfo.MutilTargetRule = cfg.MutilTargetRule;

            if (ModLog.Verbose) ModLog.Info($"[ActionsMod] SpawnProjectile ID={finalProjectileID}, Socket={finalSpawnBase.SocketName}");
            bUS_GSEventCollection.Evt_OnNotifyStateSpawnProjectileObj.Invoke(ref ProjectileSpawnNSInfo);
        }

        // ===== 原生变身（Player Trans）相关 =====

        /// <summary>trans_back：结束原生变身，变回悟空（仅在确实处于变身状态时触发）</summary>
        public static void TransBack()
        {
            var character = GetCharacter();
            if (character == null) return;

            APlayerState? playerState = character.PlayerState;
            if (playerState == null || playerState.IsNullOrDestroyed()) return;

            IBPC_PlayerTagData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerTagData, BPC_PlayerTagData>(playerState);
            if (readOnlyData == null || !readOnlyData.HasTag(EBGPPlayerTag.Transforming))
            {
                Log.Info("[ActionsMod] trans_back：当前未处于变身状态，忽略");
                return;
            }

            BPS_GSEventCollection.Get(playerState)?.Evt_TriggerPlayerTransEnd.Invoke(
                EPlayerTransEndType.CastSpell, default(PlayerTransParam));
        }

        /// <summary>
        /// change_to_dasheng：变身齐天大圣（法天象地）。
        /// 流程（移植自 MagicMod）：
        ///   1) 改 TransQiTianDaShengConfigDesc.Duration（Tick 每帧从 desc 重读，改这里才有效）
        ///   2) 同步 PassiveSkillData 里的缓存 desc
        ///   3) 放宽变身门槛：把 BUC_QiTianDaShengData 里的天赋/装备需求收缩到"必定满足"，
        ///      并清掉 BanTrans2DaSheng 禁止状态
        ///   4) 切到 PreStage 后触发 Evt_TriggerTrans2DaSheng
        /// </summary>
        /// <param name="time">持续秒数，默认 999</param>
        public static void change_to_dasheng(int? time = 999)
        {
            var Owner = GetCharacter();
            if (Owner == null)
            {
                Log.Warn("[ActionsMod] change_to_dasheng 未找到玩家角色");
                return;
            }

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
            BUC_QiTianDaShengData? daShengData = BGU_DataUtil.GetReadOnlyData<IBUC_QiTianDaShengData, BUC_QiTianDaShengData>(Owner) as BUC_QiTianDaShengData;
            if (daShengData == null)
            {
                Log.Warn("[ActionsMod] 变身大圣失败：拿不到 BUC_QiTianDaShengData");
                return;
            }

            BUC_EquipData? equipData = BGU_DataUtil.GetReadOnlyData<IBUC_EquipData, BUC_EquipData>(Owner) as BUC_EquipData;
            BPC_RoleBaseData? roleBaseData = Owner.PlayerState != null
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
            ClearBanTrans2DaSheng(simpleStateData);
            BGUFunctionLibraryCS.BGUSetUnitSimpleState(Owner, EBGUSimpleState.BanTrans2DaSheng, false);

            // 4) Evt_TriggerTrans2DaSheng 只在 DaShengStage == PreStage 时才生效，
            //    必须先切到 PreStage 再触发（原版流程：Tick 进 PreStage → 变身动画的 BANS_TriggerTrans2DaSheng 触发）
            daShengData.DaShengStage = EDaShengStage.PreStage;
            daShengData.DaShengDurationTimer = 0f;
            daShengData.DaShengDurationTotalTime = duration;

            Log.Info($"[ActionsMod] 执行变身大圣 Duration:{duration}");

            BUS_GSEventCollection obj = BUS_EventCollectionCS.Get(Owner);
            if (obj == null) return;

            obj.Evt_TriggerTrans2DaSheng.Invoke();

            // 进入 DaShengMode 的瞬间系统会加一次 BanTrans2DaSheng，必须在同一帧清掉，
            // 否则下一帧 BUS_QiTianDaShengComp 的 Tick 开头就会 Reset2LittleMonkey
            ClearBanTrans2DaSheng(simpleStateData);

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
            StartBanTrans2DaShengGuard(simpleStateData);
        }

        /// <summary>把 BanTrans2DaSheng 的引用计数直接清零（SimpleStates 是引用计数数组）</summary>
        private static void ClearBanTrans2DaSheng(BUC_SimpleStateData? simpleStateData)
        {
            try
            {
                if (simpleStateData != null)
                {
                    simpleStateData.SimpleStates[(int)EBGUSimpleState.BanTrans2DaSheng] = 0;
                }
            }
            catch { }
        }

        /// <summary>变身后的 6 秒内持续压制 BanTrans2DaSheng（200 次 × 30ms）</summary>
        private static void StartBanTrans2DaShengGuard(BUC_SimpleStateData? simpleStateData)
        {
            _ = Task.Run(async () =>
            {
                for (int i = 0; i < 200; i++)
                {
                    await Task.Delay(30);
                    Utils.TryRunOnGameThread(() =>
                    {
                        try
                        {
                            if (simpleStateData != null &&
                                simpleStateData.SimpleStates[(int)EBGUSimpleState.BanTrans2DaSheng] > 0)
                            {
                                simpleStateData.SimpleStates[(int)EBGUSimpleState.BanTrans2DaSheng] = 0;
                            }
                        }
                        catch { }
                    });
                }
            });
        }
    }
}
