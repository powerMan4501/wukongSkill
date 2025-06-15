
using b1;
using b1.BGW;
using b1.Plugins.TressFX;
using BtlB1;
using BtlShare;
using CSharpModBase;
using Newtonsoft.Json;
using ResB1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace bian
{
    public static class Helper
    {
        private static UWorld? world;

        public static UWorld? GetWorld()
        {
            if (world == null)
            {
                UObjectRef uobjectRef = GCHelper.FindRef(FGlobals.GWorld);
                world = uobjectRef?.Managed as UWorld;
            }
            return world;
        }

        public static APawn GetControlledPawn()
        {
            return UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetWorld()).GetControlledPawn();
        }

        public static BGUPlayerCharacterCS GetBGUPlayerCharacterCS()
        {
            return (GetControlledPawn() as BGUPlayerCharacterCS)!;
        }

        public static BGP_PlayerControllerB1 GetPlayerController()
        {
            return (BGP_PlayerControllerB1)UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetWorld());
        }

        public static BUS_GSEventCollection GetBUS_GSEventCollection()
        {
            return BUS_EventCollectionCS.Get(GetControlledPawn());
        }


        public static T LoadAsset<T>(string asset) where T : UObject
        {
            return b1.BGW.BGW_PreloadAssetMgr.Get(GetWorld()).TryGetCachedResourceObj<T>(asset, b1.BGW.ELoadResourceType.SyncLoadAndCache, b1.BGW.EAssetPriority.Default, null, -1, -1);
        }

        public static UClass LoadClass(string asset)
        {
            return LoadAsset<UClass>(asset);
        }

        public static AActor? SpawnActor(string classAsset)
        {
            var controlledPawn = GetControlledPawn();
            FVector actorLocation = controlledPawn.GetActorLocation();
            FVector b = controlledPawn.GetActorForwardVector() * 1000.0f;
            FVector start = actorLocation + b;
            FRotator frotator = UMathLibrary.FindLookAtRotation(start, actorLocation);
            UClass uClass = LoadClass($"PrefabricatorAsset'{classAsset}'");
            if (uClass == null)
            {
                return null;
            }
            return BGUFunctionLibraryCS.BGUSpawnActor(controlledPawn.World, uClass, start, frotator);
        }

        public static AActor GetActorOfClass(string classAsset)
        {
            return UGameplayStatics.GetActorOfClass(GetWorld(), LoadAsset<UClass>(classAsset));
        }

        public static T? FindActorCompByClass<T>(BGUPlayerCharacterCS character) where T : UActorCompBaseCS
        {
            UActorCompContainerCS acc = character.ActorCompContainerCS;
            FieldInfo field = typeof(UActorCompContainerCS).GetField("CompCSs", BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null)
            {
                List<UActorCompBaseCS> comps = field.GetValue(acc) as List<UActorCompBaseCS>;
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


        public static void ResetVigorSkill(BUS_MagicallyChangeComp magicChangeComp, int VigorSkillID)
        {
            Console.WriteLine("bian: reset vigor skill");
            if (magicChangeComp != null)
            {
                FieldInfo fieldData = typeof(BUS_MagicallyChangeComp).GetField("MagicallyChangeData", BindingFlags.NonPublic | BindingFlags.Instance);
                BUC_MagicallyChangeData data = fieldData.GetValue(magicChangeComp) as BUC_MagicallyChangeData;
                data.DurMagicallyChange = true;
                data.bIsPendingCast = false;
                data.bIsPendingReset = true;
                data.ResetReason = EResetReason_MagicallyChange.Normal;
                data.CastReason = ECastReason_MagicallyChange.VigorSkill;
                data.CurVigorSkillID = VigorSkillID;
                data.MimicrySkillTimer = 0;

                var soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(VigorSkillID);
                if (soulSkillDesc != null)
                {

                    if (soulSkillDesc.Type == SoulSkillType.Mimicry)
                    {
                        // 反射获取 LevelData 相关数据
                        FieldInfo levelFieldData = typeof(BUS_MagicallyChangeComp).GetField("LevelData", BindingFlags.NonPublic | BindingFlags.Instance);
                        IBIC_LevelData LevelData = levelFieldData.GetValue(magicChangeComp) as IBIC_LevelData;

                        FUStSoulSkillMimicryDesc soulSkillMimicryDesc = BGW_GameDB.GetSoulSkillMimicryDesc(VigorSkillID, LevelData.CurrentLevelID);
                        if (soulSkillMimicryDesc != null)
                        {
                            BGWDataAsset_VigorSkillMimicryConfig config = BGW_PreloadAssetMgr.Get(magicChangeComp).TryGetCachedResourceObj<UBGWDataAsset>(soulSkillMimicryDesc.DAPath, ELoadResourceType.SyncLoadAndCache) as BGWDataAsset_VigorSkillMimicryConfig;
                            data.PendingConfig = config;
                            MethodInfo reset = typeof(BUS_MagicallyChangeComp).GetMethod("Reset", BindingFlags.NonPublic | BindingFlags.Instance);
                            reset.Invoke(magicChangeComp, new Object[] { data.ResetReason }); ;
                        }
                    }
                    else
                    {
                        var config = BGW_PreloadAssetMgr.Get(magicChangeComp).TryGetCachedResourceObj<BGWDataAsset_MagicallyChangeConfig>(soulSkillDesc.DAPath, ELoadResourceType.SyncLoadAndCache);
                        data.PendingConfig = config;
                        MethodInfo reset = typeof(BUS_MagicallyChangeComp).GetMethod("Reset", BindingFlags.NonPublic | BindingFlags.Instance);
                        reset.Invoke(magicChangeComp, new Object[] { data.ResetReason }); ;
                    }
                }
            }
        }

        public static void StopVigorSkill(BUS_MagicallyChangeComp magicChangeComp)
        {
            Console.WriteLine("bian: stop vigor skill");
            if (magicChangeComp != null)
            {
                FieldInfo fieldData = typeof(BUS_MagicallyChangeComp).GetField("MagicallyChangeData", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldData != null)
                {
                    BUC_MagicallyChangeData data = fieldData.GetValue(magicChangeComp) as BUC_MagicallyChangeData;
                    data.DurMagicallyChange = false;
                }
            }
        }

        public static void SetWalkSpeed(BGUPlayerCharacterCS character, float value)
        {
            BUS_SpeedCtrlComp speedCtrlComp = FindActorCompByClass<BUS_SpeedCtrlComp>(character);

            if (speedCtrlComp != null)
            {
                FieldInfo speedCtrlData = typeof(BUS_SpeedCtrlComp).GetField("SpeedCtrlData", BindingFlags.NonPublic | BindingFlags.Instance);
                if (speedCtrlData != null)
                {

                    var BGS = GetBUS_GSEventCollection();

                    BUC_SpeedCtrlData ctrl = speedCtrlData.GetValue(speedCtrlComp) as BUC_SpeedCtrlData;
                    // Log.Debug($"bian: speed:{ctrl.GetMoveSpeedFast()}");

                    BGS.Evt_SetFloatProperty.Invoke(EPropType.Movement_MaxCustomMovementSpeed, value);
                    BGS.Evt_SetFloatProperty.Invoke(EPropType.Movement_MaxWalkSpeed, value);
                    BGS.Evt_SetFloatProperty.Invoke(EPropType.Movement_MaxWalkSpeedCrouched, value);
                    BGS.Evt_SetFloatProperty.Invoke(EPropType.Movement_MaxAcceleration, value * 2);
                }
            }
        }

        public static void CastVigorSkillByID(BGUPlayerCharacterCS character, int VigorSkillID, bool CanReset = false)
        {
            var magicChangeComp = FindActorCompByClass<BUS_MagicallyChangeComp>(character);

            MethodInfo methodInfo = magicChangeComp.GetType().GetMethod("DoCastMagicallyChangeSkill", BindingFlags.NonPublic | BindingFlags.Instance);

            var soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(VigorSkillID);
            if (soulSkillDesc == null)
            {
                return;
            }
            BGWDataAsset_MagicallyChangeConfig config = BGW_PreloadAssetMgr.Get(magicChangeComp).TryGetCachedResourceObj<BGWDataAsset_MagicallyChangeConfig>(soulSkillDesc.DAPath, ELoadResourceType.SyncLoadAndCache);

            FieldInfo fieldData = typeof(BUS_MagicallyChangeComp).GetField("MagicallyChangeData", BindingFlags.NonPublic | BindingFlags.Instance);
            BUC_MagicallyChangeData data = fieldData.GetValue(magicChangeComp) as BUC_MagicallyChangeData;

            data.DurMagicallyChange = CanReset;  // 不变回去，需要手动变回

            methodInfo.Invoke(magicChangeComp, new object[] { config as UBGWDataAsset, soulSkillDesc.SkillId, soulSkillDesc.SkillIdReEnter });

            // BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(character);

            // 开启交互
            // bUS_GSEventCollection.Evt_SwitchNoInteraction.Invoke(P1: true);

            // 单独设置角色的速率 移动动画会有问题
            // bUS_GSEventCollection.Evt_SetGMCustomTimeDilation.Invoke(2f);
        }
        public static void CastVigorSkill(BGUPlayerCharacterCS character, int VigorSkillID)
        {
            // 获取变身技能描述
            var soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(VigorSkillID);
            if (soulSkillDesc == null)
            {
                return;
            }

            // Log.Debug("bian:CastVigorSkill");
            var magicChangeComp = FindActorCompByClass<BUS_MagicallyChangeComp>(character);
            var BGS = GetBUS_GSEventCollection();

            if (magicChangeComp != null)
            {

                // 反射获取 MagicallyChangeData 变身控制相关数据
                FieldInfo fieldData = typeof(BUS_MagicallyChangeComp).GetField("MagicallyChangeData", BindingFlags.NonPublic | BindingFlags.Instance);
                BUC_MagicallyChangeData data = fieldData.GetValue(magicChangeComp) as BUC_MagicallyChangeData;

                // 初始化状态
                Console.WriteLine("bian:reset status");
                //data.bIsPendingCast = true;
                //data.bIsPendingReset = false;
                data.CurVigorSkillID = 0;
                data.DurMagicallyChange = false;  // 不变回去，需要手动变回
                //data.VigorSkillReEnterWaitTime = soulSkillDesc.ReEnterWaitTime;
                //data.CastReason = ECastReason_MagicallyChange.VigorSkill;

                // 打断当前所有动画
                UGSE_AnimFuncLib.StopAllMontages(character, 0f);
                UGSE_AnimFuncLib.TickAnimationAndRefreshBone(character);
                BGS.Evt_UnitTryBreakSkill.Invoke("触发幻化变身技能，打断当前技能");

                // 添加buffer
                if (soulSkillDesc.BuffId > 0)
                {
                    BGS.Evt_BuffAdd.Invoke(soulSkillDesc.BuffId, character, character, -1f, EBuffSourceType.MagicallyChange);
                }

                // 获取技能和绑定技能动画对象
                FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(soulSkillDesc.SkillId, character);
                UAnimMontage montage_CurrentMontageEndEventBinded = BGW_PreloadAssetMgr.Get(character).TryGetCachedResourceObj<UAnimMontage>(skillSDesc.TemplatePath, ELoadResourceType.SyncLoadAndCache);
                data.Montage_CurrentMontageEndEventBinded = montage_CurrentMontageEndEventBinded;

                // 获取精魄配置
                BGWDataAsset_MagicallyChangeConfig config = BGW_PreloadAssetMgr.Get(magicChangeComp).TryGetCachedResourceObj<BGWDataAsset_MagicallyChangeConfig>(soulSkillDesc.DAPath, ELoadResourceType.SyncLoadAndCache);
                data.PendingConfig = config;

                // 如果需要缩放的话
                if (config.UnitScale > 0f)
                {
                    UCapsuleComponent capsuleComponent = character.CapsuleComponent;
                    USkeletalMeshComponent mesh = character.Mesh;
                    float num = config.UnitScale / data.DefaultConfig.UnitScale.X;
                    float num2 = config.UnitScale / data.DefaultConfig.UnitScale.Z;
                    float inRadius = data.DefaultConfig.CapsuleRadius / num;
                    float num3 = data.DefaultConfig.CapsuleHalfHeight / num2;
                    character.SetActorScale3D(new FVector(config.UnitScale));
                    capsuleComponent.SetCapsuleSize(inRadius, num3, bUpdateOverlaps: false);
                    if (mesh != null)
                    {
                        FVector location = mesh.GetRelativeTransform().GetLocation();
                        location.Z = 0f - num3;
                        mesh.SetRelativeLocation(location, bSweep: false, out var _, bTeleport: true);
                    }
                }


                // 重新设置骨骼和碰撞体
                string[] methods = { "SetSKMesh", "UpdateAbnormalDispID", "UpdateMeshInfo", "UpdateHitMoveCollision", "UpdateTressFXInfo", "UpdateWeapons", "UpdateDispInteractInfo" };
                Dictionary<string, object[]> methodDictionary = new Dictionary<string, object[]>
                {
                    { "SetSKMesh", new object[] { config.SKMesh, config.ABPClass, config.Materials.ToList() } },
                    { "UpdateAbnormalDispID", new object[] {  false, config.Override_AbnormalDispID_Attacker, config.Override_AbnormalDispID_Victim} },
                    { "UpdateMeshInfo", new object[] { true, } },
                    { "UpdateHitMoveCollision", new object[] { true, config.CapsuleHalfHeight, config.CapsuleRadius } },
                    { "UpdateTressFXInfo", new object[] { true, config } },
                    { "UpdateWeapons", new object[] { true, config } },
                    { "UpdateDispInteractInfo", new object[] { true, config } },
                };
                foreach (var entry in methodDictionary)
                {
                    MethodInfo methodInfo = magicChangeComp.GetType().GetMethod(entry.Key, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    if (methodInfo != null)
                    {
                        try
                        {
                            methodInfo.Invoke(magicChangeComp, entry.Value);
                        }
                        catch (TargetInvocationException ex)
                        {
                            Console.WriteLine($"Error invoking {entry.Key}: {ex.InnerException.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Method {entry.Key} not found.");
                    }
                }
                data.bIsPendingReset = false;
                BGS?.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CantGainVigorEnergy);
                BPS_GSEventCollection.Get(character.PlayerState).Evt_EnterSkillCameraConversionParam.Invoke(data.CurVigorSkillID);
                BGS?.Evt_RequestHideOldBuffDisp.Invoke(P1: false);
                // Log.Debug("bian:cast vigor skill done!");
            }

        }

        public static void CastMimicrySkill(BGUPlayerCharacterCS character, int VigorSkillID)
        {
            // 获取变身技能描述
            var soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(VigorSkillID);
            if (soulSkillDesc == null)
            {
                return;
            }

            // Log.Debug("bian:CastMimicrySkill");
            var magicChangeComp = FindActorCompByClass<BUS_MagicallyChangeComp>(character);
            var BGS = GetBUS_GSEventCollection();

            if (magicChangeComp != null)
            {

                // 反射获取 MagicallyChangeData 变身控制相关数据
                FieldInfo fieldData = typeof(BUS_MagicallyChangeComp).GetField("MagicallyChangeData", BindingFlags.NonPublic | BindingFlags.Instance);
                BUC_MagicallyChangeData data = fieldData.GetValue(magicChangeComp) as BUC_MagicallyChangeData;

                // 反射获取 LevelData 相关数据
                FieldInfo levelFieldData = typeof(BUS_MagicallyChangeComp).GetField("LevelData", BindingFlags.NonPublic | BindingFlags.Instance);
                IBIC_LevelData LevelData = levelFieldData.GetValue(magicChangeComp) as IBIC_LevelData;

                // 初始化状态
                Console.WriteLine("bian:reset status");
                //data.bIsPendingCast = true;
                //data.bIsPendingReset = false;
                data.CurVigorSkillID = VigorSkillID;
                data.MimicrySkillTimer = 1;
                data.DurMagicallyChange = false;  // 不变回去，需要手动变回
                //data.VigorSkillReEnterWaitTime = soulSkillDesc.ReEnterWaitTime;
                //data.CastReason = ECastReason_MagicallyChange.VigorSkill;

                // 打断当前所有动画
                UGSE_AnimFuncLib.StopAllMontages(character, 0f);
                UGSE_AnimFuncLib.TickAnimationAndRefreshBone(character);
                BGS.Evt_UnitTryBreakSkill.Invoke("触发幻化变身技能，打断当前技能");

                // 添加buffer
                if (soulSkillDesc.BuffId > 0)
                {
                    BGS.Evt_BuffAdd.Invoke(soulSkillDesc.BuffId, character, character, -1f, EBuffSourceType.MagicallyChange);
                }

                // 获取精魄配置
                FUStSoulSkillMimicryDesc soulSkillMimicryDesc = BGW_GameDB.GetSoulSkillMimicryDesc(data.CurVigorSkillID, LevelData.CurrentLevelID);
                if (soulSkillMimicryDesc != null)
                {
                    BGWDataAsset_VigorSkillMimicryConfig config = BGW_PreloadAssetMgr.Get(magicChangeComp).TryGetCachedResourceObj<UBGWDataAsset>(soulSkillMimicryDesc.DAPath, ELoadResourceType.SyncLoadAndCache) as BGWDataAsset_VigorSkillMimicryConfig;
                    data.PendingConfig = config;

                    // 重新设置骨骼和碰撞体
                    Dictionary<string, object[]> methodDictionary = new Dictionary<string, object[]>
                    {
                        { "SetSKMesh", new object[] { config.SKMesh, config.ABPClass, config.Materials.ToList() } },
                        { "UpdateAbnormalDispID", new object[] {  false, config.Override_AbnormalDispID_Attacker, config.Override_AbnormalDispID_Victim} },
                        { "UpdateMeshInfo", new object[] { true, } },
                        { "UpdateHitMoveCollision", new object[] { true, config.CapsuleHalfHeight, config.CapsuleRadius } },
                        { "SetTressFXCompVisibility", new object[] { false } },
                        { "SetWeaponVisibility", new object[] { false } },
                    };
                    foreach (var entry in methodDictionary)
                    {
                        MethodInfo methodInfo = magicChangeComp.GetType().GetMethod(entry.Key, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                        if (methodInfo != null)
                        {
                            try
                            {
                                methodInfo.Invoke(magicChangeComp, entry.Value);
                            }
                            catch (TargetInvocationException ex)
                            {
                                Console.WriteLine($"Error invoking {entry.Key}: {ex.InnerException.Message}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Method {entry.Key} not found.");
                        }
                    }

                    BGUFuncLibAnim.BGUActorTryPlayMontage(character, config.AnimMimicryStart, FName.None);

                    data.bIsPendingReset = false;
                    //BGS?.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CantGainVigorEnergy);
                    //BPS_GSEventCollection.Get(character.PlayerState).Evt_EnterSkillCameraConversionParam.Invoke(data.CurVigorSkillID);
                    //BGS?.Evt_RequestHideOldBuffDisp.Invoke(P1: true);

                    if (soulSkillMimicryDesc != null && soulSkillMimicryDesc.Buff != 0)
                    {
                        BGS.Evt_BuffAdd.Invoke(soulSkillMimicryDesc.Buff, character, character, -1f, EBuffSourceType.MagicallyChange);
                    }
                    // Log.Debug("bian:cast vigor skill done!");
                }
            }

        }

        public static void TriggerEffect(BGUPlayerCharacterCS character, int EffectID, EANTriggerEffectTargetType TargetType)
        {
            FEffectInstReq fEffectInstReq = new FEffectInstReq(character);
            fEffectInstReq.Attacker = character;
            fEffectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(character);
            fEffectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(character);
            fEffectInstReq.HitActionDir = EHitActionDir.Default;
            FEffectInstReq effectInstReq = fEffectInstReq;

            AActor aActor2 = character;
            if (TargetType != EANTriggerEffectTargetType.Owner)
            {
                aActor2 = BGUFunctionLibraryCS.BGUGetTarget(character);
            }
            // Log.Debug($"bian: TriggerSkillEffect---->{EffectID}");
            GetBUS_GSEventCollection().Evt_TriggerSkillEffect.Invoke(EffectID, effectInstReq, aActor2);
        }

        public static void SummonReq(Int64 SummonID, Int64 SummonCount, int SummonAliveTime = 12)
        {
            var character = Helper.GetBGUPlayerCharacterCS();

            if (SummonCount < 1)
            {
                SummonCount = 1;
            }

            FSummonReq fSummonReq = default(FSummonReq);
            fSummonReq.SummonType = ESummonType.Normal;
            fSummonReq.SummonGuid = GameplayTagExtension.ConvertToCalliopeGuid(Guid.NewGuid());
            fSummonReq.SummonID = (Int32)SummonID;
            fSummonReq.SpawnConfigWrap = FSummonSpawnConfigWrap.WrapSpawnConfig_BySummonCommDesc((Int32)SummonID, character);
            fSummonReq.SpawnConfigWrap.SummonAliveTime = SummonAliveTime;
            fSummonReq.SummonCount = (Int32)SummonCount;
            fSummonReq.Summoner = character;
            fSummonReq.bTeleportSelf = false;
            fSummonReq.EffectCaster = null;
            fSummonReq.BuffOwner = null;
            fSummonReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(character);
            FSummonReq inSummonReq = fSummonReq;
            BPS_EventCollectionCS.GetLocal(character).Evt_RequestSummon.Invoke(inSummonReq);
        }

        public static void SpawnProjectile(BGUPlayerCharacterCS character, string path, int projectileID = 0, bool forTarget = false, int bulletCount = 1, bool isRandom = false, FVector offset = default(FVector), RuleAction? action = null)
        {
            BGWDataAsset_ProjectileSpawnConfig bGWDataAsset_ProjectileSpawnConfig = BGW_PreloadAssetMgr.Get(character).TryGetCachedResourceObj<BGWDataAsset_ProjectileSpawnConfig>(path, ELoadResourceType.SyncLoadAndCache);
            if (bGWDataAsset_ProjectileSpawnConfig == null)
            {
                // Log.Warn($"bian: projectile not found! {path}");
                return;
            }
            AActor aActor = character;
            AActor target = BGUFunctionLibraryCS.BGUGetTarget(character);

            string targetString = "BGW_90_hfm_leiwa_Atk_41_Lv6_change";
            bool isShotBull = path.Contains(targetString);
            //发射类的子弹不执行这个
            if (forTarget && target != null && !isShotBull)
            {
                aActor = target;
            }

            FEffectInstReq fEffectInstReq = new FEffectInstReq(character);
            FEffectInstReq effectInstReq = fEffectInstReq;
            BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(character);

            if (projectileID <= 0)
            {
                projectileID = bGWDataAsset_ProjectileSpawnConfig.ProjectileID;
            }

            if (bulletCount < 1)
            {
                bulletCount = bGWDataAsset_ProjectileSpawnConfig.ProjectileNumInOneWave;
            }

            if (bUS_GSEventCollection != null)
            {
                FGSProjecttileObjSpawnNSInfo ProjectileSpawnNSInfo = new FGSProjecttileObjSpawnNSInfo();
                ProjectileSpawnNSInfo.ProjectileType = EProjectileType.Bullet;
                ProjectileSpawnNSInfo.BuffIDList = bGWDataAsset_ProjectileSpawnConfig.BuffIDList.ToList();
                ProjectileSpawnNSInfo.ProjectileID = projectileID;
                ProjectileSpawnNSInfo.SpawnWave = bGWDataAsset_ProjectileSpawnConfig.ProjectileWave;
                ProjectileSpawnNSInfo.SpawnNumPerWave = bulletCount;

                var offsetInfo = bGWDataAsset_ProjectileSpawnConfig.SpawnPosOffsetInfo;
                var bornDirOffset = bGWDataAsset_ProjectileSpawnConfig.BornDirOffset;
                var targetBase = bGWDataAsset_ProjectileSpawnConfig.TargetBase;

                var spawnBase = bGWDataAsset_ProjectileSpawnConfig.SpawnBase;

                if (forTarget && target != null && isShotBull)
                {
                    //对目标发射

                    targetBase.BaseType = ProjectileBaseType.CurTarget_ProjectileSpawner;

                    spawnBase.BaseType = ProjectileBaseType.ProjectileSpawner;

                    Log.Warn($"bian: targetBase: {targetBase.BaseType}");
                    Log.Warn($"bian: spawnBase: {spawnBase.BaseType}");
                }

                if (isRandom)
                {
                    offsetInfo.PosOffsetType = ProjectilePosOffsetType.RandomOffset;
                    offsetInfo.PosOffset = new FVector(500, 500, 125.0);
                    offsetInfo.VerticalOffset_World = 120f;
                    offsetInfo.RangeOffsetInfo.CircleRadius = 800;
                    bornDirOffset.BornDirOffsetX.LeftValue = -40f;
                    bornDirOffset.BornDirOffsetX.RightValue = 40f;
                    bornDirOffset.BornDirOffsetY.LeftValue = -40f;
                    bornDirOffset.BornDirOffsetY.RightValue = 40f;
                    bornDirOffset.BornDirOffsetZ.LeftValue = 0f;
                    bornDirOffset.BornDirOffsetZ.RightValue = 200f;
                }

                if (offset.X > 0 || offset.Y > 0 || offset.Z > 0)
                {

                    var xyz = aActor.GetActorForwardVector();
                    offsetInfo.PosOffset.X = offsetInfo.PosOffset.X + (offset.X * xyz.X);
                    offsetInfo.PosOffset.Y = offsetInfo.PosOffset.Y + (offset.Y * xyz.Y);
                    offsetInfo.PosOffset.Z = offsetInfo.PosOffset.Z + (offset.Z * xyz.Z);

                }
                var none_target = bGWDataAsset_ProjectileSpawnConfig.bEnableSpawnBase_NoneTarget;
                if (forTarget && target != null && isShotBull)
                {
                    none_target = false;
                }
                ProjectileSpawnNSInfo.InitSpawnInfo(spawnBase, offsetInfo, none_target, bGWDataAsset_ProjectileSpawnConfig.SpawnBase_NoneTarget, bGWDataAsset_ProjectileSpawnConfig.SpawnPosOffsetInfo_NoneTarget, character, aActor, aActor, null, in fEffectInstReq);
                ProjectileSpawnNSInfo.AttachToSpawnBase = bGWDataAsset_ProjectileSpawnConfig.AttachToSpawnBase;
                ProjectileSpawnNSInfo.AttachRule_Rot = bGWDataAsset_ProjectileSpawnConfig.AttachRule_Rot;
                ProjectileSpawnNSInfo.InitTargetInfo(targetBase, bGWDataAsset_ProjectileSpawnConfig.TargetPosOffsetInfo, bGWDataAsset_ProjectileSpawnConfig.bEnableTargetBase_NoneTarget, bGWDataAsset_ProjectileSpawnConfig.TargetBase_NoneTarget, bGWDataAsset_ProjectileSpawnConfig.TargetPosOffsetInfo_NoneTarget, character, aActor, aActor, null, in fEffectInstReq);
                ProjectileSpawnNSInfo.BornDirBaseInfo = bGWDataAsset_ProjectileSpawnConfig.BornDirBaseInfo;
                if (forTarget && target != null && isShotBull)
                {
                    ProjectileSpawnNSInfo.BornDirBaseInfo.BornDirType = ProjectileBornDirType.LookAtTargetPos;
                }
                switch (ProjectileSpawnNSInfo.BornDirBaseInfo.BornDirType)
                {
                    case ProjectileBornDirType.UseEffectNormal:
                        ProjectileSpawnNSInfo.BornDirBaseInfo.HitPointNormalDir = fEffectInstReq.HitPointNormalDir;
                        break;
                    case ProjectileBornDirType.UseEffectCasterRot:
                        ProjectileSpawnNSInfo.BornDirBaseInfo.ExtraRotBaseActor = character;
                        break;
                }
                ProjectileSpawnNSInfo.BornDirOffset = bornDirOffset;
                ProjectileSpawnNSInfo.ProjectileFlySpd = bGWDataAsset_ProjectileSpawnConfig.BulletFlySpd;
                ProjectileSpawnNSInfo.ProjectileRotSpd = bGWDataAsset_ProjectileSpawnConfig.BulletRotSpd;



                if (forTarget && isShotBull)
                {
                    ProjectileSpawnNSInfo.ProjectileFlySpd.Spd.LeftValue = 10000;
                    ProjectileSpawnNSInfo.ProjectileFlySpd.Spd.RightValue = 10000;
                    if (action?.SpeedLeftValue > 0)
                    {
                        ProjectileSpawnNSInfo.ProjectileFlySpd.Spd.LeftValue = action.SpeedLeftValue;
                    }
                    if (action?.SpeedRightValue > 0)
                    {
                        ProjectileSpawnNSInfo.ProjectileFlySpd.Spd.RightValue = action.SpeedRightValue;
                    }
                }
                ProjectileSpawnNSInfo.MontageID = -1;
                ProjectileSpawnNSInfo.ANSTotalTime = 0;
                ProjectileSpawnNSInfo.SpawnWaveDuration = (ProjectileSpawnNSInfo.SpawnWaveDuration = ((ProjectileSpawnNSInfo.SpawnWave > 1) ? (ProjectileSpawnNSInfo.ANSTotalTime / (float)(ProjectileSpawnNSInfo.SpawnWave - 1)) : 0f));
                ProjectileSpawnNSInfo.SpawnCounter = 0;
                ProjectileSpawnNSInfo.SpawnWaveCounter = 0;
                ProjectileSpawnNSInfo.bEnableMultiTargetMode = bGWDataAsset_ProjectileSpawnConfig.bEnableMultiTargetMode;
                ProjectileSpawnNSInfo.MutilTargetRule = bGWDataAsset_ProjectileSpawnConfig.MutilTargetRule;
                bUS_GSEventCollection.Evt_OnNotifyStateSpawnProjectileObj.Invoke(ref ProjectileSpawnNSInfo);
            }
        }
        public static double DateTimeToTimestamp()
        {
            // 创建一个代表UTC时间1970年1月1日的DateTime
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            // 计算当前时间与epoch之间的时间差
            TimeSpan timeSinceEpoch = DateTime.Now.ToUniversalTime() - epoch;
            // 将时间差转换为秒，并包含毫秒部分
            double timestamp = timeSinceEpoch.TotalSeconds * 1000;
            return timestamp;
        }

        public static void DelayExecute(int delayMilliseconds, Action action)
        {
            Task.Delay(delayMilliseconds).ContinueWith(t =>
            {
                action();
            });
        }

        public static bool IsWukong(BGUCharacterCS character)
        {
            return character.Mesh.SkeletalMesh.GetFullName().ToLower().IndexOf("SK_Wukong_Simple".ToLower()) > -1;
        }

        public static ITransable? ExportTamer(BGUCharacterCS actor)
        {
            if (actor != null)
            {
                BUTamerActor tM = actor.GetTamerOwner() as BUTamerActor;
                if (tM == null)
                {
                    // Log.Debug($"bian: XXXXX bad tamer");
                    return null;
                }
                // Log.Debug($"bian: find tamer {tM.MonsterClassPath}");

                var allSkillIDs = BGUFuncLibAICS.BGUGetUnitAllSkillID(actor);

                var model = new BossModel();
                model.BossConf = new BossConfig();

                try
                {

                    BGUFuncLibNonRuntime.LoadProtobufData<FUStUnitCommDesc>();
                    BGUFuncLibNonRuntime.LoadProtobufData<FUStUnitBattleInfoExtendDesc>();
                    ACharacter aCharacter = tM.GetMonster() as ACharacter;
                    //GetAllMertials(aCharacter);

                    // Log.Debug($"bian: start convert boss config");
                    model.BossConf.CapsuleHalfHeight = aCharacter.CapsuleComponent.GetUnscaledCapsuleHalfHeight();
                    // Log.Debug($"bian: load CapsuleHalfHeight>{model.BossConf.CapsuleHalfHeight}");

                    model.BossConf.CapsuleRadius = aCharacter.CapsuleComponent.GetUnscaledCapsuleRadius();
                    // Log.Debug($"bian: load CapsuleRadius>{model.BossConf.CapsuleRadius}");

                    model.BossConf.SKMesh = aCharacter.Mesh.SkeletalMesh.PathName;
                    // Log.Debug($"bian: load SKMesh>{model.BossConf.SKMesh}");

                    model.BossConf.ABPClass = aCharacter.Mesh.AnimClass.GetDefaultObject().PathName;
                    model.BossConf.ABPClass = model.BossConf.ABPClass.Replace("Default__", "");

                    // Log.Debug($"bian: load ABPClass>{model.BossConf.ABPClass}");

                    model.BossConf.PhysicsAsset = aCharacter.Mesh.SkeletalMesh.PhysicsAsset.PathName;
                    // Log.Debug($"bian: load PhysicsAsset>{model.BossConf.PhysicsAsset}");

                    if (tM.ConfigInfoComp.UnitCDesc.Weapons != null && tM.ConfigInfoComp.UnitCDesc.Weapons.Count > 0)
                    {
                        model.BossConf.Weapons = new List<WeaponConfig>();
                        foreach (var item in tM.ConfigInfoComp.UnitCDesc.Weapons)
                        {
                            WeaponConfig weaponConfig = new WeaponConfig();
                            weaponConfig.SocketName = item.SocketName.PlainName;
                            weaponConfig.Weapon = item.Weapon.GetDefaultObject().GetPathName().Replace("Default__", "");
                            // Log.Debug($"bian: load Weapons>{weaponConfig.Weapon}");
                            // Log.Debug($"bian: load Weapons socketName>{weaponConfig.SocketName}");
                            model.BossConf.Weapons.Add(weaponConfig);
                        }
                    }
                    else
                    {
                        // Log.Debug($"bian: Skip load Weapons,count == 0");
                    }

                    List<UActorComponent> tfxComps = aCharacter.GetComponentsByClass(UClass.GetClass<UTressFXComponent>());
                    List<UActorComponent> childComp = aCharacter.GetComponentsByClass(UClass.GetClass<UChildActorComponent>());

                    for (int i = 0; i < childComp.Count; i++)
                    {
                        UChildActorComponent uChildActorComponent = childComp[i] as UChildActorComponent;
                        if (!uChildActorComponent.ChildActor.IsNullOrDestroyed())
                        {
                            List<UActorComponent> componentsByClass5 = uChildActorComponent.ChildActor.GetComponentsByClass(UClass.GetClass<UTressFXComponent>());
                            tfxComps.AddRange(componentsByClass5);
                        }
                    }

                    // Log.Debug($"bian: find treefx component count:{tfxComps.Count}");

                    if (tfxComps.Count > 0)
                    {
                        model.BossConf.TFXConfigs = new List<TFXConfig>();
                        for (int i = 0; i < tfxComps.Count; i++)
                        {
                            var uTressFXComponent = tfxComps[i] as UTressFXComponent;
                            // Log.Debug($"bian: load uTressFXComponent>{uTressFXComponent.PathName}");

                            TFXConfig item = new TFXConfig();

                            if (uTressFXComponent.Asset != null)
                            {
                                item.TFXAsset = uTressFXComponent.Asset.PathName;
                            }


                            if (uTressFXComponent.HairMaterial != null)
                            {
                                item.HairMaterial = uTressFXComponent.HairMaterial.PathName;
                                // Log.Debug($"bian: load uTressFXComponent.HairMaterial>{uTressFXComponent.HairMaterial.PathName}");

                                // Log.Debug($"bian: load uTressFXComponent.HairMaterial.>{uTressFXComponent.HairMaterial.PathName}");
                            }

                            item.ShadeSettings = new MockFTressFXShadeSettings();
                            item.ShadeSettings.FiberRadius = uTressFXComponent.ShadeSettings.FiberRadius;
                            item.ShadeSettings.FiberSpacing = uTressFXComponent.ShadeSettings.FiberSpacing;
                            item.ShadeSettings.HairThickness = uTressFXComponent.ShadeSettings.HairThickness;
                            item.ShadeSettings.RootTangentBlending = uTressFXComponent.ShadeSettings.RootTangentBlending;
                            item.ShadeSettings.ShadowThickness = uTressFXComponent.ShadeSettings.ShadowThickness;

                            item.LodScreenSize = uTressFXComponent.LodScreenSize;
                            item.EnableSimulation = uTressFXComponent.EnableSimulation;
                            model.BossConf.TFXConfigs.Add(item);
                        }
                    }

                    if (tM.ConfigInfoComp.DispInteractBoneMap.Count > 0)
                    {
                        model.BossConf.InteractBones = new List<MockedInteractBone>();
                        foreach (KeyValuePair<FName, FBoneUseForDispMap> item2 in tM.ConfigInfoComp.DispInteractBoneMap)
                        {
                            var interactBone = new MockedInteractBone();
                            interactBone.FirstBoneName = item2.Value.FirstBoneName.ToString();
                            interactBone.NextBoneName = item2.Value.NextBoneName.ToString();
                            interactBone.FirstRadius = item2.Value.FirstRadius;
                            interactBone.NextRadius = item2.Value.NextRadius;
                            model.BossConf.InteractBones.Add(interactBone);
                        }
                    }


                    FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(tM.ConfigInfoComp.UnitCDesc.ResID);
                    if (unitCommDesc != null)
                    {
                        int defaultBattleInfoExtendID = unitCommDesc.DefaultBattleInfoExtendID;
                        int overrideID = tM.ConfigInfoComp.UnitCDesc.OverrideID;
                        FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc((overrideID > 0) ? overrideID : defaultBattleInfoExtendID);
                        if (unitBattleInfoExtendDesc != null)
                        {
                            model.BossConf.Override_AbnormalDispID_Attacker = unitBattleInfoExtendDesc.AbnormalDispAttackerID;
                            model.BossConf.Override_AbnormalDispID_Victim = unitBattleInfoExtendDesc.AbnormalDispVictimID;
                        }
                    }

                    // Log.Debug("bian: start build data");
                    model.Name = tM.GetMonster().Mesh.SkeletalMesh.GetName();
                    model.Type = "BOSS";
                    model.TamerPath = tM.MonsterClassPath;
                    model.XRateBig = 0.3f;
                    model.ZRateBig = 0.1f;
                    model.CoolDownRate = 50;
                    model.XRateSmall = 2;
                    model.Level1Scale = 1;
                    model.Level2Scale = 1;
                    model.Label = tM.GetMonster().Mesh.SkeletalMesh.GetName();
                    model.Skills = new List<Skill>();
                    foreach (var ID in allSkillIDs)
                    {
                        var skill = new Skill();
                        skill.Id = ID;
                        skill.Key = "";
                        model.Skills.Add(skill);
                    }
                    // Log.Debug("bian: start export data");
                    string json = JsonConvert.SerializeObject(model, Formatting.Indented);
                    string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string filePath = Path.Combine(currentDirectory, $@"CSharpLoader\Mods\bian\models\export\boss_{model.Name}.json");
                    File.WriteAllText(filePath, json);
                    // Log.Debug($"bian: successed export {tM.MonsterClassPath}");

                    return model;
                }
                catch (Exception ex)
                {

                    Log.Error(ex.ToString());
                    return null;
                }

            }
            return null;
        }

        public static void GetAllMertials(ACharacter actor)
        {
            var materials = actor.Mesh.GetMaterials();

            for (int i = 0; i < materials.Count; i++)
            {
                // Log.Debug($"{materials[i].GetFName()}");
            }
        }
    }
}