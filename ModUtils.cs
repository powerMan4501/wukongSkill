using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using b1;
using b1.BGW;
using B1UI;
using BtlShare;
using CommB1;
using CsB1;
using CSharpModBase;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace PanelActionsMod
{
    /// <summary>
    /// 极简工具：只提供画板三类动作真正需要的能力 ——
    /// 取世界/角色、发物品、变身、按路径生成 Boss/角色。
    /// </summary>
    public static class ModUtils
    {
        #region 世界 / 角色

        public static UWorld? GetWorld()
        {
            UObjectRef uobjectRef = GCHelper.FindRef(FGlobals.GWorld);
            return uobjectRef?.Managed as UWorld;
        }

        public static BGP_PlayerControllerB1? GetPlayerController()
        {
            UWorld? world = GetWorld();
            if (world == null || world.IsNullOrDestroyed()) return null;
            var pc = UGSE_EngineFuncLib.GetFirstLocalPlayerController(world);
            if (pc == null || pc.IsNullOrDestroyed()) return null;
            return pc as BGP_PlayerControllerB1;
        }

        public static APawn? GetControlledPawn()
        {
            var pc = GetPlayerController();
            if (pc == null || pc.IsNullOrDestroyed()) return null;
            return pc.GetControlledPawn();
        }

        #endregion

        #region 物品

        private static CommB1.PlayerDataMgr? GetPlayerMgr()
        {
            return GSG.GamePlayer.CreateTransaction((OPReason)2);
        }

        /// <summary>添加单个物品</summary>
        public static void gain_item(int itemId, int itemCount = 1)
        {
            var mgr = GetPlayerMgr();
            if (mgr == null) return;
            mgr.Bag.GainItemOne(new ItemOne { Id = itemId, Num = itemCount });
            mgr.Commit();
        }

        /// <summary>批量添加物品：一个事务内连续 GainItemOne，最后只提交一次（大范围 ID 时快很多）</summary>
        public static int gain_items(IEnumerable<int> itemIds, int itemCount = 1)
        {
            if (itemIds == null) return 0;
            int num = itemCount < 1 ? 1 : itemCount;
            var mgr = GetPlayerMgr();
            if (mgr == null) return 0;

            int added = 0;
            foreach (int id in itemIds)
            {
                if (id <= 0) continue;
                mgr.Bag.GainItemOne(new ItemOne { Id = id, Num = num });
                added++;
            }
            mgr.Commit();
            return added;
        }

        #endregion

        #region 变身

        /// <summary>
        /// 变身到指定 ResID（ItemData.trans_list 里的游戏内置变身）。
        /// ResID=10 是「变回悟空」，走 TransEnd 路径。
        /// </summary>
        public static void doTrans(int resId, int magicSkill = 0)
        {
            var character = ModHelper.GetCharacter();
            if (character == null)
            {
                Log.Warn("[PanelActionsMod] 未找到玩家角色，无法变身");
                return;
            }
            if (resId <= 0)
            {
                Log.Warn("[PanelActionsMod] 变身 ID 无效");
                return;
            }

            BPS_GSEventCollection evt = BPS_EventCollectionCS.Get(character.PlayerState);
            PlayerTransParam param = new PlayerTransParam
            {
                TargetResId = resId,
                SpawnSkillId = magicSkill,
                NeedBlend = true
            };

            if (resId == 10)
            {
                evt.Evt_TriggerPlayerTransEnd.Invoke(EPlayerTransEndType.SkillEffect, param);
            }
            else
            {
                evt.Evt_TriggerPlayerTransBegin.Invoke(EPlayerTransBeginType.SkillEffect, param);
            }
        }

        #endregion

        #region 生成 Boss / 角色

        /// <summary>生成物默认出生距离：主角正前方（厘米）</summary>
        public const float SummonForwardDistance = 800f;

        /// <summary>生成物脚底离地高度（厘米）：先从空中落下，避免高个子怪陷进地里</summary>
        public const float SummonDropHeight = 300f;

        /// <summary>预估的胶囊体半高（厘米）</summary>
        public const float SummonDefaultCapsuleHalfHeight = 150f;

        public struct SummonSpawnInfo
        {
            /// <summary>生成物中心点（= 脚底 + 胶囊体半高），直接作为 Spawn 的 Location</summary>
            public FVector CenterLocation;

            /// <summary>脚底位置（地面之上 DropHeight）</summary>
            public FVector FeetLocation;

            /// <summary>与主角同向 —— 生成物背对主角</summary>
            public FRotator Rotation;

            /// <summary>落点处的地面 Z</summary>
            public float GroundZ;
        }

        public static T LoadAsset<T>(string asset) where T : UObject
        {
            return BGW_PreloadAssetMgr.Get(GetWorld()).TryGetCachedResourceObj<T>(
                asset, ELoadResourceType.SyncLoadAndCache, EAssetPriority.Default, null, -1, -1);
        }

        public static UClass LoadClass(string asset)
        {
            return LoadAsset<UClass>(asset);
        }

        /// <summary>取角色胶囊体半高（厘米），取不到时返回保守默认值</summary>
        public static float GetCapsuleHalfHeight(AActor? actor, float fallback = SummonDefaultCapsuleHalfHeight)
        {
            try
            {
                if (actor != null && !actor.IsNullOrDestroyed() && actor is ACharacter character
                    && character.CapsuleComponent != null && !character.CapsuleComponent.IsNullOrDestroyed())
                {
                    float h = character.CapsuleComponent.GetScaledCapsuleHalfHeight();
                    if (h > 0f) return h;
                }
            }
            catch { }
            return fallback;
        }

        /// <summary>向下射线取指定 XY 处的地面 Z；射线打不到时返回 false</summary>
        public static bool TryGetGroundZ(AActor? reference, FVector pos, out float groundZ, float up = 800f, float down = 5000f)
        {
            groundZ = pos.Z;
            try
            {
                if (reference == null || reference.IsNullOrDestroyed()) return false;
                FHitResultSimple groundHit;
                int result = UBGUSelectUtil.LineTraceSimple(
                    reference,
                    new FVector(pos.X, pos.Y, pos.Z + up),
                    new FVector(pos.X, pos.Y, pos.Z - down),
                    ETraceTypeQuery.TraceTypeQuery1, false, out groundHit, null);
                if (result > 0)
                {
                    groundZ = groundHit.HitLocation.Z;
                    return true;
                }
            }
            catch (Exception e)
            {
                Log.Warn($"[PanelActionsMod] 地面射线失败: {e.Message}");
            }
            return false;
        }

        /// <summary>
        /// 计算生成点：主角正前方 distance 处，只取水平朝向（抬头/低头不影响落点），
        /// 朝向与主角一致 → 生成物背对主角；脚底位于地面之上 dropHeight，中心点再抬高胶囊体半高。
        /// </summary>
        public static SummonSpawnInfo CalcSummonSpawnInfo(AActor origin, float distance = SummonForwardDistance,
            float dropHeight = SummonDropHeight, float capsuleHalfHeight = 0f)
        {
            SummonSpawnInfo info = new SummonSpawnInfo();
            FVector selfPos = origin.GetActorLocation();

            FVector forward = origin.GetActorForwardVector();
            forward.Z = 0f;
            if (forward.Size() < 0.001f) forward = new FVector(1f, 0f, 0f);
            forward = forward.GetSafeNormal();

            FVector feet = selfPos + forward * distance;

            // 地面高度：优先向下射线；打不到就退回主角脚底高度
            float groundZ = selfPos.Z - GetCapsuleHalfHeight(origin);
            if (TryGetGroundZ(origin, feet, out float tracedGroundZ)) groundZ = tracedGroundZ;

            if (capsuleHalfHeight <= 0f) capsuleHalfHeight = SummonDefaultCapsuleHalfHeight;
            feet.Z = groundZ + dropHeight;

            FRotator rotation = MathLib.Conv_VectorToRotator(forward);
            rotation.Pitch = 0f;
            rotation.Roll = 0f;

            info.GroundZ = groundZ;
            info.FeetLocation = feet;
            info.CenterLocation = feet + new FVector(0f, 0f, capsuleHalfHeight);
            info.Rotation = rotation;
            return info;
        }

        /// <summary>
        /// 强制指定 Tamer 的出生 Transform（脚底位置传入，内部补 CapsuleHalfHeight 抬到中心点），
        /// 保证出怪时脚踩在地面而不是陷进地里。
        /// </summary>
        private static void ForceTamerTransform(BUTamerActor boss, FVector feetLocation, FRotator rotation)
        {
            FTransform transform = boss.GetActorTransform();
            transform.Translation = feetLocation + boss.CurrentRef.CapsuleHalfHeight;
            transform.SetRotation(rotation.Quaternion());

            FTamerRef currentRef = boss.CurrentRef;
            currentRef.AddSpawnRuleFlag(ETamerSpawnRule.OnlySpawn);
            currentRef.ResetLocationCache();
            currentRef.TamerTransform = transform;
            currentRef.OverrideResetType = (EBGUResetType)3;
            currentRef.GroupOverrideResetType = (EBGUResetType)3;

            // 反射改私有 _phase，让它进入 Loaded 阶段才会真正刷出来
            FieldInfo? field = typeof(FTamerRef).GetField("_phase", BindingFlags.Instance | BindingFlags.NonPublic);
            field?.SetValue(currentRef, ETamerPhase.Loaded);

            ((ABGUTamerBase)boss).TamerType = (ETamerType)2;
            currentRef.ResetLocationCache();
            currentRef.TamerTransform = transform;
        }

        /// <summary>
        /// 按蓝图路径生成 actor / Boss。
        /// isBoss=true 走 GM 生成（Tamer 单位），否则按 PrefabricatorAsset 生成普通 actor。
        /// </summary>
        public static AActor? SpawnActor(string classAsset, bool isBoss = false)
        {
            UWorld? world = GetWorld();
            if (world == null)
            {
                Log.Warn("[PanelActionsMod] world 为空，无法生成");
                return null;
            }
            APawn? player = GetControlledPawn();
            if (player == null)
            {
                Log.Warn("[PanelActionsMod] 未找到玩家角色，无法生成");
                return null;
            }

            SummonSpawnInfo spawn = CalcSummonSpawnInfo(player);

            try
            {
                if (isBoss)
                {
                    UClass uClass = UObject.LoadClass<AActor>(null, classAsset);
                    if (uClass == null)
                    {
                        Log.Warn($"[PanelActionsMod] Boss 类加载失败: {classAsset}");
                        return null;
                    }

                    BUTamerActor? tamer = BGUFunctionLibraryCS.BGUSpawnActor(world, uClass, spawn.CenterLocation, spawn.Rotation) as BUTamerActor;
                    if (tamer == null)
                    {
                        Log.Warn($"[PanelActionsMod] Boss 生成失败: {classAsset}");
                        return null;
                    }

                    tamer.CurrentRef.AddSpawnRuleFlag(ETamerSpawnRule.OnlySpawn);
                    tamer.MarkAsSpawnedTamer(null);
                    ForceTamerTransform(tamer, spawn.FeetLocation, spawn.Rotation);

                    FTransform transform = player.GetActorTransform();
                    transform.SetLocation(spawn.CenterLocation);
                    transform.SetRotation(spawn.Rotation.Quaternion());
                    UBGUFunctionLibrary.BGUFinishSpawningActor(tamer, transform);

                    BGUFuncLibAICS.SearchTargetSP(tamer);
                    SchedulePostSpawn(tamer);
                    return tamer;
                }

                UClass pClass = LoadClass($"PrefabricatorAsset'{classAsset}'");
                if (pClass == null)
                {
                    Log.Warn($"[PanelActionsMod] 资源加载失败: {classAsset}");
                    return null;
                }

                FTransform spawnTransform = player.GetActorTransform();
                spawnTransform.SetLocation(spawn.CenterLocation);
                spawnTransform.SetRotation(spawn.Rotation.Quaternion());

                BUTamerActor? actor = UBGUFunctionLibrary.BGUBeginDeferredActorSpawnFromClass(
                    world, pClass, spawnTransform, ESpawnActorCollisionHandlingMethod.AlwaysSpawn, null) as BUTamerActor;
                if (actor == null)
                {
                    Log.Warn($"[PanelActionsMod] 生成失败: {classAsset}");
                    return null;
                }

                actor.MarkAsSpawnedTamer(null);
                BUTamerActor? finished = UBGUFunctionLibrary.BGUFinishSpawningActor(actor, spawnTransform) as BUTamerActor;
                AActor result = finished ?? actor;
                if (finished != null) ForceTamerTransform(finished, spawn.FeetLocation, spawn.Rotation);

                BGUFuncLibAICS.SearchTargetSP(result);
                SchedulePostSpawn(result);
                return result;
            }
            catch (Exception e)
            {
                Log.Error($"[PanelActionsMod] 生成异常 {classAsset}: {e.Message}");
                return null;
            }
        }

        /// <summary>出怪后稍等再重新索敌并分配阵营（Tamer 需要一点时间初始化）</summary>
        private static void SchedulePostSpawn(AActor actor)
        {
            Task.Run(async () =>
            {
                await Task.Delay(2000);
                Utils.TryRunOnGameThread(() =>
                {
                    try
                    {
                        diffTeamID();
                        BGUFuncLibAICS.SearchTargetSP(actor);
                    }
                    catch (Exception e)
                    {
                        Log.Warn($"[PanelActionsMod] 出怪后处理失败: {e.Message}");
                    }
                });
            });
        }

        private static bool IsPlayer(string? name)
        {
            return name != null && name.ToLower().Contains("unit_player");
        }

        /// <summary>给周围非玩家单位分配递增阵营 ID（&gt;1），这样召唤出来的 Boss 才会与玩家敌对</summary>
        public static void diffTeamID()
        {
            APawn? player = GetControlledPawn();
            if (player == null) return;

            UBGUSelectUtil.SphereOverlapBGUCharacters(player, BGUFuncLibActorTransformCS.BGUGetActorLocation(player), 3000, out var list);
            if (list == null) return;

            int teamID = 100;
            foreach (var actor in list)
            {
                if (actor == null || IsPlayer(actor.PathName)) continue;
                if (actor is BGUCharacterCS target && target.GetTeamIDInCS() != 1)
                {
                    target.SetTeamIDInCS(teamID++);
                }
            }
        }

        #endregion
    }
}
