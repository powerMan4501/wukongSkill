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

namespace MagicMod
{
    /// <summary>
    /// MagicMod 工具类
    /// </summary>
    public static class ModUtils
    {
        /// <summary>
        /// 获取游戏世界
        /// </summary>
        public static UWorld? GetWorld()
        {
            UObjectRef uobjectRef = GCHelper.FindRef(FGlobals.GWorld);
            return uobjectRef?.Managed as UWorld;
        }

        /// <summary>
        /// 获取玩家控制器
        /// </summary>


        public static BGP_PlayerControllerB1? GetPlayerController()
        {
            var world = GetWorld();
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
        public static void setActorEquip(int EquipID)
        {
            APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetWorld());
            if (firstLocalPlayerController.IsNullOrDestroyed())
            {
                BGW_LogUtil.LogError("[TestState_NormalSkill_CompleteCoverage] CurPC.IsNullOrDestroyed!");
                return;
            }
            BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get(firstLocalPlayerController.PlayerState);
            if (bTF_EventCollectionCS == null)
            {
                BGW_LogUtil.LogError("[TestState_NormalSkill_CompleteCoverage] BTFEventCollection == null!");
                return;
            }
            ulong num = 0uL;
            foreach (ReadOnlyRoleEquip equip in BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(firstLocalPlayerController).RoleData.RoleCs.Bag.EquipList)
            {
                if (equip.EquipId == EquipID)
                {
                    num = equip.Uid;
                    break;
                }
            }
            if (num != 0)
            {
                CSMsgActorWearEquipReq actorWearEquip = new CSMsgActorWearEquipReq
                {
                    EquipUid = num
                };
                bTF_EventCollectionCS.Evt_ActorWearEquipReq(actorWearEquip, delegate
                {
                });
            }
        }

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

        /// <summary>
        /// 批量获得物品：一个事务内连续 GainItemOne，最后只 Commit 一次。
        /// 逐个调用 gain_item 时每个物品都要开事务+提交，大范围（上千个 ID）会非常慢。
        /// </summary>
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
        public static void Montage_GetPosition(float MontagePosOffset, UAnimMontage? animMontage)
        {
            var character = ModHelper.GetCharacter();
            if (character == null)
            {

                return;
            }
            UAnimInstance animInstance = character.Mesh.GetAnimInstance();
            if (animInstance != null)
            {
                if (animMontage != null)
                {
                    animInstance.Montage_SetPosition(animMontage, MontagePosOffset);
                    return;
                }
                UAnimMontage currentActiveMontage = animInstance.GetCurrentActiveMontage();

                if (currentActiveMontage != null)
                {
                    animInstance.Montage_SetPosition(currentActiveMontage, MontagePosOffset);
                }
            }
        }

        public static void JingDouYun()
        {
            var character = GetBGUPlayerCharacterCS();
            if (character != null && ModHelper.IsWuKong(character))
            {
                BUS_EventCollectionCS.Get(character).Evt_ToggleCloudMove.Invoke();
            }
        }

        public static void doTrans(int ResId, int magicSkill)
        {
            var character = ModHelper.GetCharacter();
            if (character == null)
            {
                Log.Warn("[MagicMod] 未找到玩家角色");
                return;
            }

            if (ResId <= 0)
            {
                Log.Warn("[MagicMod] Trans ID 无效");
                return;
            }

            // 先触发变身前置技能
            BPS_GSEventCollection bPS_GSEventCollection = BPS_EventCollectionCS.Get((character as BGUPlayerCharacterCS).PlayerState);
            PlayerTransParam playerTransParam = new PlayerTransParam
            {
                TargetResId = ResId,
                SpawnSkillId = (int)magicSkill,
                NeedBlend = true
            };
            if (ResId == 10)
            {
                bPS_GSEventCollection.Evt_TriggerPlayerTransEnd.Invoke(EPlayerTransEndType.SkillEffect, playerTransParam);

            }
            else
            {
                bPS_GSEventCollection.Evt_TriggerPlayerTransBegin.Invoke(EPlayerTransBeginType.SkillEffect, playerTransParam);

            }
        }

        /// <summary>召唤物默认出生距离：主角正前方（厘米）</summary>
        public const float SummonForwardDistance = 800f;

        /// <summary>
        /// 召唤物默认出生抬高高度（厘米）：脚底离地高度。
        /// 生成物先出现在空中、再靠重力落到地面，这样高个子怪的脚是踩在地上的，而不是陷进地里。
        /// </summary>
        public const float SummonDropHeight = 300f;

        /// <summary>预估的召唤物胶囊体半高（厘米）。真正出怪后由 Tamer 的 CapsuleHalfHeight 修正。</summary>
        public const float SummonDefaultCapsuleHalfHeight = 150f;

        /// <summary>召唤物出生信息</summary>
        public struct SummonSpawnInfo
        {
            /// <summary>生成物中心点（= 脚底 + 胶囊体半高），直接作为 Spawn 的 Location</summary>
            public FVector CenterLocation;

            /// <summary>脚底位置（地面之上 DropHeight），用于 TamerTransform / 落地校正</summary>
            public FVector FeetLocation;

            /// <summary>与主角同向 —— 生成物背对主角</summary>
            public FRotator Rotation;

            /// <summary>落点处的地面 Z</summary>
            public float GroundZ;
        }

        /// <summary>取角色胶囊体半高（厘米），取不到时返回保守默认值。</summary>
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

        /// <summary>向下射线取指定 XY 处的地面 Z；射线打不到时返回 false。</summary>
        public static bool TryGetGroundZ(AActor? reference, FVector pos, out float groundZ, float up = 800f, float down = 5000f)
        {
            groundZ = pos.Z;
            try
            {
                if (reference == null || reference.IsNullOrDestroyed()) return false;
                FHitResultSimple groundHit;
                int groundResult = UBGUSelectUtil.LineTraceSimple(
                    reference,
                    new FVector(pos.X, pos.Y, pos.Z + up),
                    new FVector(pos.X, pos.Y, pos.Z - down),
                    ETraceTypeQuery.TraceTypeQuery1, false, out groundHit, null);
                if (groundResult > 0)
                {
                    groundZ = groundHit.HitLocation.Z;
                    return true;
                }
            }
            catch (Exception e)
            {
                Log.Warn($"[MagicMod] 地面射线失败: {e.Message}");
            }
            return false;
        }

        /// <summary>
        /// 计算召唤物出生点：
        /// 1) 主角正前方 distance（厘米）处，只取水平朝向（抬头/低头不影响落点）；
        /// 2) 朝向与主角一致 → 生成物背对主角；
        /// 3) 脚底位于地面之上 dropHeight、中心点再抬高胶囊体半高 ——
        ///    再高的怪也是从空中落到地面，不会陷进地里。
        /// </summary>
        /// <param name="origin">参照角色（主角）</param>
        /// <param name="distance">正前方距离（厘米）</param>
        /// <param name="dropHeight">脚底离地高度（厘米）</param>
        /// <param name="capsuleHalfHeight">生成物半高，用于把中心点抬到脚底之上；&lt;=0 时按默认值预估</param>
        /// <param name="overrideXY">指定落点的 XY（例如"对着锁定目标生成"），为 null 时取主角正前方</param>
        public static SummonSpawnInfo CalcSummonSpawnInfo(AActor origin, float distance = SummonForwardDistance,
            float dropHeight = SummonDropHeight, float capsuleHalfHeight = 0f, FVector? overrideXY = null)
        {
            SummonSpawnInfo info = new SummonSpawnInfo();
            FVector selfPos = origin.GetActorLocation();

            // 只取水平分量：抬头/低头不改变落点
            FVector forward = origin.GetActorForwardVector();
            forward.Z = 0f;
            if (forward.Size() < 0.001f) forward = new FVector(1f, 0f, 0f);
            forward = forward.GetSafeNormal();

            FVector feet = selfPos + forward * distance;
            if (overrideXY.HasValue)
            {
                feet.X = overrideXY.Value.X;
                feet.Y = overrideXY.Value.Y;
            }

            // 地面高度：优先向下射线；射线打不到就退回主角脚底高度
            float groundZ = selfPos.Z - GetCapsuleHalfHeight(origin);
            if (TryGetGroundZ(origin, feet, out float tracedGroundZ)) groundZ = tracedGroundZ;

            if (capsuleHalfHeight <= 0f) capsuleHalfHeight = SummonDefaultCapsuleHalfHeight;

            feet.Z = groundZ + dropHeight;

            // 与主角同向 = 背对主角
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
        /// 落地校正：单位的脚陷进地面时（生成物个子高、地面射线偏差等）把它抬到地面之上。
        /// 正常站在地面上或正在空中下落时不处理。
        /// </summary>
        public static bool RescueSunkUnit(AActor? unit, float extraHeight = 20f)
        {
            try
            {
                if (unit == null || unit.IsNullOrDestroyed()) return false;
                FVector pos = unit.GetActorLocation();
                if (!TryGetGroundZ(unit, pos, out float groundZ)) return false;
                float halfHeight = GetCapsuleHalfHeight(unit);
                if (pos.Z - halfHeight >= groundZ - 5f) return false; // 没陷进去

                pos.Z = groundZ + halfHeight + extraHeight;
                unit.BGUSetActorLocation(pos, bSweep: false, bTeleport: true);
                Log.Info($"[MagicMod] 生成物陷进地面，已抬到地面之上: {unit.GetName()}");
                return true;
            }
            catch (Exception e)
            {
                Log.Warn($"[MagicMod] 落地校正失败: {e.Message}");
                return false;
            }
        }

        /// <summary>
        /// 强制指定 Tamer 的出生 Transform。bossBornLocation 传"脚底"位置，
        /// 内部会补上 CapsuleHalfHeight 抬高到中心点，保证出怪时脚踩在地面（或空中）而不是陷进地里。
        /// </summary>
        public static void processIfBossCantSpawnNormaly(BUTamerActor boss, FVector bossBornLocation, FRotator? rotation = null)
        {
            var player = GetControlledPawn();
            bool hasPlayer = player != null && !player.IsNullOrDestroyed();
            FTransform actorTransform = hasPlayer ? player!.GetActorTransform() : new FTransform();
            actorTransform.Scale3D = hasPlayer ? player!.GetActorTransform().Scale3D : new FVector(1f, 1f, 1f);
            actorTransform.Translation = bossBornLocation + boss.CurrentRef.CapsuleHalfHeight;
            if (rotation.HasValue)
            {
                actorTransform.SetRotation(rotation.Value.Quaternion());
            }
            FTamerRef currentRef = boss.CurrentRef;
            currentRef.AddSpawnRuleFlag(ETamerSpawnRule.OnlySpawn);
            currentRef.ResetLocationCache();
            currentRef.TamerTransform = actorTransform;
            FieldInfo field = typeof(FTamerRef).GetField("_phase", BindingFlags.Instance | BindingFlags.NonPublic);
            currentRef.OverrideResetType = (EBGUResetType)3;
            currentRef.GroupOverrideResetType = (EBGUResetType)3;
            field.SetValue(currentRef, ETamerPhase.Loaded);
            ((ABGUTamerBase)boss).TamerType = (ETamerType)2;
            currentRef.ResetLocationCache();
            currentRef.TamerTransform = actorTransform;
        }



        public static void GMSpawnMonster(string path, int teamId = 0)
        {
            try
            {
                // if (ParamStringList.Count == 0)
                // {
                //     return 0;
                // }
                // List<string> list = new List<string>();
                // list.Add("/Game/00Main/Design/Units/GYCY/TAMER_gycy_lang_03.TAMER_gycy_lang_03_C");
                // list.Add("/Game/00Main/Design/Units/GYCY/TAMER_gycy_lang_04.TAMER_gycy_lang_04_C");
                // list.Add("/Game/00Main/Design/Units/HYS/TAMER_hys_hms.TAMER_hys_hms_C");
                // list.Add("/Game/00Main/Design/Units/LYS/TAMER_LYS_SengMian_01.TAMER_LYS_SengMian_01_C");
                // int.TryParse(ParamStringList[0], out var result);
                UClass uClass = UObject.LoadClass<AActor>(null, path);
                ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetWorld(), 0);
                if (playerCharacter != null)
                {
                    var world = GetWorld();
                    if (world == null) return;

                    // 出生点：主角正前方 800，脚底在地面之上 300（靠重力落地），朝向与主角一致 → 背对主角
                    SummonSpawnInfo spawn = CalcSummonSpawnInfo(playerCharacter);

                    FTransform actorTransform = playerCharacter.GetActorTransform();
                    var BossBornLocation = spawn.CenterLocation;
                    FRotator BossBornRotation = spawn.Rotation;
                    actorTransform.SetLocation(BossBornLocation);
                    actorTransform.SetRotation(BossBornRotation.Quaternion());
                    BUTamerActor? bUTamerActor = BGUFunctionLibraryCS.BGUSpawnActor(world, uClass, BossBornLocation, BossBornRotation) as BUTamerActor;

                    // BUTamerActor bUTamerActor = UBGUFunctionLibrary.BGUBeginDeferredActorSpawnFromClass(playerCharacter.World, uClass, actorTransform, ESpawnActorCollisionHandlingMethod.AlwaysSpawn, null) as BUTamerActor;
                    if (bUTamerActor != null)
                    {
                        bUTamerActor.CurrentRef.AddSpawnRuleFlag(ETamerSpawnRule.OnlySpawn);
                        bUTamerActor.MarkAsSpawnedTamer(null);
                        // 传脚底位置：内部会补上 CapsuleHalfHeight 抬到中心点，高个子怪也不会陷进地面
                        processIfBossCantSpawnNormaly(bUTamerActor, spawn.FeetLocation, BossBornRotation);

                        UBGUFunctionLibrary.BGUFinishSpawningActor(bUTamerActor, actorTransform);

                        BGUFuncLibAICS.SearchTargetSP(bUTamerActor);


                        Task.Run(async () =>
                   {
                       await Task.Delay(2200);
                       Utils.TryRunOnGameThread(() =>
                       {
                           // teamId>0 时跳过 diffTeamID：它会把周围怪改成 100+ 递增 ID，会覆盖自定义阵营
                           if (teamId <= 0) diffTeamID();
                           BGUFuncLibAICS.SearchTargetSP(bUTamerActor);
                           ModHelper.RegisterSpawnedTamer(bUTamerActor, teamId);
                       });
                   });

                    }
                    else
                    {
                        Log.Info($"生成失败：{path}");
                    }
                }
            }
            catch (Exception arg)
            {
                Log.Info($"生成失败：{path}");
            }
        }

        public static T LoadAsset<T>(string asset) where T : UObject
        {
            return BGW_PreloadAssetMgr.Get(GetWorld()).TryGetCachedResourceObj<T>(asset, ELoadResourceType.SyncLoadAndCache, b1.BGW.EAssetPriority.Default, null, -1, -1);
        }
        public static UClass LoadClass(string asset)
        {
            return LoadAsset<UClass>(asset);
        }

        /// <summary>
        /// 生成 actor / Boss。
        /// isBoss=true 走 GM 生成（Tamer 单位），否则按 PrefabricatorAsset 生成普通 actor。
        /// atTarget=true 时落点用锁定目标的 XY（默认 false：生成在主角正前方）。
        /// SpawnTeamId：&gt;0 时出怪后设置该阵营并登记进两阵营互殴池。
        /// </summary>
        public static AActor? SpawnActor(string classAsset, bool isBoss = false, int teamId = 0, bool atTarget = false)
        {

            if (isBoss)
            {
                GMSpawnMonster(classAsset, teamId);
                return null;
            }
            var controlledPawn = GetControlledPawn();
            if (controlledPawn == null)
            {
                return null;
            }

            var World = GetWorld();
            if (World == null) return null;

            // FRotator rotation = UMathLibrary.FindLookAtRotation(location, actorLocation);
            UClass uClass = LoadClass($"PrefabricatorAsset'{classAsset}'");
            if (uClass == null)
            {
                return null;
            }

            // 出生点：主角正前方 800，脚底在地面之上 300（从空中落地），朝向与主角一致 → 背对主角
            var Target = atTarget ? BGUFunctionLibraryCS.BGUGetTarget(controlledPawn) : null;
            SummonSpawnInfo spawn = CalcSummonSpawnInfo(controlledPawn, overrideXY:
                (Target != null && !Target.IsNullOrDestroyed()) ? Target.GetActorLocation() : (FVector?)null);
            if (Target != null && !Target.IsNullOrDestroyed())
            {
                Log.Info($"对着目标({Target.GetName()})生成角色SpawnActor");
            }

            FTransform spawnTransform = controlledPawn.GetActorTransform();
            spawnTransform.SetLocation(spawn.CenterLocation);
            spawnTransform.SetRotation(spawn.Rotation.Quaternion());

            BUTamerActor? actor = UBGUFunctionLibrary.BGUBeginDeferredActorSpawnFromClass(World, uClass, spawnTransform, ESpawnActorCollisionHandlingMethod.AlwaysSpawn, null) as BUTamerActor;
            //    var actor = BGU_UnrealWorldUtil.RequestSpawnUnit(controlledPawn.World,uClass,new FTransform(actorLocation),null);
            // var actor = BGUFunctionLibraryCS.BGUSpawnActor(controlledPawn.World, uClass, start, frotator);
            if (actor != null)
            {
                actor.MarkAsSpawnedTamer(null);
                BUTamerActor? actorFinish = UBGUFunctionLibrary.BGUFinishSpawningActor(actor, spawnTransform) as BUTamerActor;
                // 出怪位置按脚底校正（内部补 CapsuleHalfHeight），高个子怪也不会陷进地面
                if (actorFinish != null)
                {
                    processIfBossCantSpawnNormaly(actorFinish, spawn.FeetLocation, spawn.Rotation);
                }
                Task.Run(async () =>
            {
                await Task.Delay(2000);
                Utils.TryRunOnGameThread(() =>
                {
                    // teamId>0 时跳过 diffTeamID：它会覆盖自定义阵营
                    if (teamId <= 0) diffTeamID();
                    BGUFuncLibAICS.SearchTargetSP(actorFinish);
                    ModHelper.RegisterSpawnedTamer(actorFinish, teamId);
                });
            });


            }

            return actor;
        }
        public static void KillMonster()
        {
            AActor play = GetBGUPlayerCharacterCS();
            if (play == null || play.World == null) return;
            List<ABGUCharacter> allActorsOfClassList = getMonsterByDistance(9000);
            if (allActorsOfClassList == null || allActorsOfClassList.Count == 0) return;
            foreach (BGUCharacterCS item in allActorsOfClassList)
            {
                if (item == null || item?.GetFullName() == null)
                {
                    continue;
                }
                if (BGU_DataUtil.GetActorTeamID(play) == BGU_DataUtil.GetActorTeamID(item))
                {
                    continue;
                }
                var curHp = BGUFunctionLibraryCS.GetAttrValue(item, EBGUAttrFloat.Hp);
                if (curHp < 1)
                {
                    // 杀死0生命的怪
                    BGUFunctionLibraryCS.BGUAddBuff(item, item, 412203, EBuffSourceType.GM, 900);
                }
            }
        }
        public static void WeakMonster()
        {
            AActor play = GetBGUPlayerCharacterCS();
            KillMonster();
            if (play == null || play.World == null) return;
            List<ABGUCharacter> allActorsOfClassList = getMonsterByDistance(9000);
            if (allActorsOfClassList == null || allActorsOfClassList.Count == 0) return;
            foreach (BGUCharacterCS item in allActorsOfClassList)
            {

                if (item == null || item?.GetFullName() == null)
                {
                    continue;
                }
                if (BGU_DataUtil.GetActorTeamID(play) == BGU_DataUtil.GetActorTeamID(item))
                {
                    continue;
                }
                // var atk = BGUFunctionLibraryCS.GetAttrValue(item, EBGUAttrFloat.Atk);
                // if (atk > 10)
                // {
                //     BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.Atk, atk - 1);
                // }
                // var maxHp = BGUFunctionLibraryCS.GetAttrValue(item, EBGUAttrFloat.HpMax);
                // if (maxHp > 500)
                // {
                //     BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.HpMax, maxHp - 10);
                // }
                BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.BurnDef, 0);
                BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.BurnDefBase, 0);
                BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.ThunderDef, 0);
                BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.ThunderDefBase, 0);
                BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.PoisonDef, 0);
                BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.PoisonDefBase, 0);
                BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.FreezeDef, 0);
                BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.FreezeDefBase, 0);



                BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.FreezeImmue, true);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.BurnImmue, true);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.PoisonImmue, true);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.ThunderImmue, true);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.ImmueBurnAcc, true);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.ImmuePoisonAcc, true);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.ImmueThunderAcc, true);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.ImmueFreezeAcc, true);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.CommonDamageImmue, true);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.StrongDamageImmue, true);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.Camouflage, true);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.CantBeAutoLockTarget, true);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.CantBeBaseTarget, true);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.Imperceptible, true);

                BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.ImmueDamage, true);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.ImmueStiff, true);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.ImmueImmobilizing, true);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.CantBeSweepChecked, true);
                BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.CantBeLock, true);
            }
        }
        public static BGUPlayerCharacterCS GetBGUPlayerCharacterCS()
        {
            return (GetControlledPawn() as BGUPlayerCharacterCS)!;
        }

        public static List<ABGUCharacter> getMonsterByDistance(float MaxDistance = 6000)
        {
            var play = GetBGUPlayerCharacterCS();
            UBGUSelectUtil.SphereOverlapBGUCharacters(play, BGUFuncLibActorTransformCS.BGUGetActorLocation(play), MaxDistance, out var OutArray);
            return OutArray;
        }
        public static bool IsPlayer(string name)
        {
            if (name != null && name?.ToLower()?.IndexOf("unit_player") > -1)
            {
                return true;
            }
            return false;
        }

        public static void resetTeamID()
        {
            List<ABGUCharacter> allActorsOfClassList = getMonsterByDistance(3000);
            foreach (var actor in allActorsOfClassList)
            {
                BUS_EventCollectionCS.Get(actor).Evt_ResetTeamID.Invoke();
            }
        }
        public static void diffTeamID()
        {
            List<ABGUCharacter> allActorsOfClassList = getMonsterByDistance(3000);
            int teamID = 100; // 起始团队ID
            var player = GetBGUPlayerCharacterCS();

            foreach (var actor in allActorsOfClassList)
            {
                // 跳过玩家角色

                if (!IsPlayer(actor.PathName))
                {
                    // 为每个角色设置递增的团队ID
                    var target = actor as BGUCharacterCS;
                    // 己方除外
                    if (target != null && target.GetTeamIDInCS() != 1)
                    {
                        target.SetTeamIDInCS(teamID++);
                    }
                }
            }
        }

    }
}
