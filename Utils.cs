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

        public static void processIfBossCantSpawnNormaly(BUTamerActor boss, FVector bossBornLocation)
        {
            var player = GetControlledPawn();
            var playerTransformScale = player.GetActorTransform().Scale3D;
            FTransform actorTransform = player.GetActorTransform();
            actorTransform.Scale3D = playerTransformScale;
            actorTransform.Translation = bossBornLocation + boss.CurrentRef.CapsuleHalfHeight;
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
                    FTransform actorTransform = playerCharacter.GetActorTransform();

                    var Target = BGUFunctionLibraryCS.BGUGetTarget(playerCharacter);

                    if (Target == null)
                    {
                        Target = playerCharacter;
                    }
                    var world = GetWorld();
                    if (world == null) return;
                    var BossBornLocation = Target.GetActorLocation() + Target.GetActorForwardVector() * 1800.0;
                    FRotator BossBornRotation = Target.GetActorRotation();
                    actorTransform.SetLocation(Target.GetActorLocation() + playerCharacter.GetActorForwardVector() * 1800.0);
                    actorTransform.SetRotation((Target.GetActorForwardVector()).Rotation().Quaternion());
                    BUTamerActor? bUTamerActor = BGUFunctionLibraryCS.BGUSpawnActor(world, uClass, BossBornLocation, BossBornRotation) as BUTamerActor;

                    // BUTamerActor bUTamerActor = UBGUFunctionLibrary.BGUBeginDeferredActorSpawnFromClass(playerCharacter.World, uClass, actorTransform, ESpawnActorCollisionHandlingMethod.AlwaysSpawn, null) as BUTamerActor;
                    if (bUTamerActor != null)
                    {
                        bUTamerActor.CurrentRef.AddSpawnRuleFlag(ETamerSpawnRule.OnlySpawn);
                        bUTamerActor.MarkAsSpawnedTamer(null);
                        processIfBossCantSpawnNormaly(bUTamerActor, BossBornLocation + new FVector(1000.0, 0.0, 100.0));

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

        public static AActor? SpawnActor(string classAsset, bool isBoss = false, int teamId = 0)
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

            FVector actorLocation = controlledPawn.GetActorLocation() + controlledPawn.GetActorForwardVector() * 1500.0;
            var Target = BGUFunctionLibraryCS.BGUGetTarget(controlledPawn);

            FVector fVector = controlledPawn.GetControlRotation()
                .GetForwardVector() * 700.0;
            var World = GetWorld();
            if (World == null) return null;
            FVector location = actorLocation + fVector;
            if (Target != null)
            {
                location = Target.GetActorLocation();
                Log.Info($"对着目标({Target.GetName()})生成角色SpawnActor");
            }
            // FRotator rotation = UMathLibrary.FindLookAtRotation(location, actorLocation);
            UClass uClass = LoadClass($"PrefabricatorAsset'{classAsset}'");
            if (uClass == null)
            {
                return null;
            }
            BUTamerActor? actor = UBGUFunctionLibrary.BGUBeginDeferredActorSpawnFromClass(World, uClass, new FTransform(location), ESpawnActorCollisionHandlingMethod.AlwaysSpawn, null) as BUTamerActor;
            //    var actor = BGU_UnrealWorldUtil.RequestSpawnUnit(controlledPawn.World,uClass,new FTransform(actorLocation),null);
            // var actor = BGUFunctionLibraryCS.BGUSpawnActor(controlledPawn.World, uClass, start, frotator);
            if (actor != null)
            {
                actor.MarkAsSpawnedTamer(null);
                BUTamerActor? actorFinish = UBGUFunctionLibrary.BGUFinishSpawningActor(actor, controlledPawn.GetActorTransform()) as BUTamerActor;
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
