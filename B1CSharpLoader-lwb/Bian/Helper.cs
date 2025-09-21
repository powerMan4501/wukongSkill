
using b1;
using b1.BGW;
using b1.Plugins.Calliope;
using b1.Plugins.TressFX;
using BtlB1;
using BtlShare;
using CSharpModBase;
using Newtonsoft.Json;
using ResB1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace bian
{
    public static class Helper
    {
        private static UWorld? world;
        public static FCalliopeGuid? summonGuid;

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


        public static void ResetVigorSkill(BUS_MagicallyChangeComp magicChangeComp, int VigorSkillID)
        {
            Console.WriteLine("bian: reset vigor skill");
            if (magicChangeComp != null)
            {
                FieldInfo fieldData = typeof(BUS_MagicallyChangeComp).GetField("MagicallyChangeData", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldData == null) return;
                BUC_MagicallyChangeData data = fieldData?.GetValue(magicChangeComp) as BUC_MagicallyChangeData;
                if (data == null) return;
                data.DurMagicallyChange = true;
                data.bIsPendingCast = false;
                data.bIsPendingReset = true;
                data.ResetReason = EResetReason_MagicallyChange.Normal;
                data.CastReason = ECastReason_MagicallyChange.VigorSkill;
                data.CurVigorSkillID = VigorSkillID;
                data.MimicrySkillTimer = 0;
                data.RecoverSkillID = 10199;
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
                        reset.Invoke(magicChangeComp, new Object[] { data.ResetReason });
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


        private static readonly Dictionary<Type, Dictionary<string, MethodInfo>> _methodCache = new Dictionary<Type, Dictionary<string, MethodInfo>>();

        private static MethodInfo GetCachedMethodInfo(Type type, string methodName)
        {
            if (!_methodCache.TryGetValue(type, out var typeMethods))
            {
                typeMethods = new Dictionary<string, MethodInfo>();
                _methodCache[type] = typeMethods;
            }

            if (!typeMethods.TryGetValue(methodName, out var methodInfo))
            {
                methodInfo = type.GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);
                typeMethods[methodName] = methodInfo;
            }

            return methodInfo;
        }

        private static BUS_MagicallyChangeComp? _cachedMagicChangeComp;
        private static BGUPlayerCharacterCS? _cachedCharacter;
        private static BUS_MagicallyChangeComp? GetCachedMagicChangeComp(BGUPlayerCharacterCS character)
        {
            if (_cachedCharacter != character || _cachedMagicChangeComp == null)
            {
                _cachedMagicChangeComp = FindActorCompByClass<BUS_MagicallyChangeComp>(character);
                _cachedCharacter = character;
            }
            return _cachedMagicChangeComp;
        }
        private static readonly Dictionary<int, BGWDataAsset_MagicallyChangeConfig> _vigorSkillConfigCache = new Dictionary<int, BGWDataAsset_MagicallyChangeConfig>();
        private static readonly Dictionary<string, BGWDataAsset_MagicallyChangeConfig> boss_vigorSkillConfigCache = new Dictionary<string, BGWDataAsset_MagicallyChangeConfig>();

        public static bool isPlayVigorSkillByID;
        public static int playVigorSkillID;
        public static BGUPlayerCharacterCS playVigorCharacter;


        public static void updateIsPlayVigorSkillByID(bool isPlay)
        {
            isPlayVigorSkillByID = isPlay;
        }
        public static void CastVigorSkillByID(BGUPlayerCharacterCS character, int VigorSkillID, float backTime = 0, int? MagicSkillID = 0, float? Scale3D = 1)
        {
            var magicChangeComp = GetCachedMagicChangeComp(character);
            if (magicChangeComp == null)
            {
                return;
            }

            var soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(VigorSkillID);

            if (soulSkillDesc == null || magicChangeComp == null)
            {
                return;
            }
            // 检查缓存中是否已存在该配置
            if (!_vigorSkillConfigCache.TryGetValue(VigorSkillID, out var config))
            {
                // 缓存不存在，则加载配置
                config = BGW_PreloadAssetMgr.Get(magicChangeComp).TryGetCachedResourceObj<BGWDataAsset_MagicallyChangeConfig>(soulSkillDesc.DAPath, ELoadResourceType.SyncLoadAndCache);
                if (config != null)
                {
                    // 将新加载的配置加入缓存
                    _vigorSkillConfigCache[VigorSkillID] = config;
                }
            }

            if (config == null)
            {
                return;
            }
            var BGS = GetBUS_GSEventCollection();
            var Duration = backTime > 0 ? backTime : 1000f;
            BGS.Evt_BuffAdd.Invoke(22010, character, character, Duration, EBuffSourceType.MagicallyChange);
            var finalId = MagicSkillID > 0 ? MagicSkillID : soulSkillDesc.SkillId;
            try
            {
                isPlayVigorSkillByID = true;
                playVigorSkillID = (int)finalId;
                playVigorCharacter = character;
                if (Scale3D != null && Scale3D > 0)
                {
                    character.SetActorScale3D(new FVector((float)Scale3D));
                }
                BGUFunctionLibraryCS.CastMagicallyChangeSkill(character, config, (int)finalId, 10199);
                // MyUtils.SetCamera();

            }
            catch (System.Exception ex)
            {
                Log.Error($"bian:{ex?.Message} ");

            }
        }
        public static BGWDataAsset_MagicallyChangeConfig? getMagicConfig(BGUPlayerCharacterCS character, string bossLabel, string type)
        {

            if (!boss_vigorSkillConfigCache.TryGetValue(bossLabel, out var config))
            {
                var magicChangeComp = GetCachedMagicChangeComp(character);
                if (magicChangeComp == null)
                {
                    return null;
                }
                ModelManager modelManager = new ModelManager();
                modelManager.InitConfig();  // 初始化配置
                BossModel model = modelManager.FindModelByLabel(bossLabel, type) as BossModel;
                if (model == null)
                {
                    return null;
                }
                UObject defaultObject = UClass.GetClass<BGWDataAsset_MagicallyChangeConfig>().GetDefaultObject();
                BGWDataAsset_MagicallyChangeConfig val = (BGWDataAsset_MagicallyChangeConfig)(object)((defaultObject is BGWDataAsset_MagicallyChangeConfig) ? defaultObject : null);

                config = val;
                var BossConf = model?.BossConf;
                if (BossConf == null)
                {
                    return null;
                }
                config = BGW_PreloadAssetMgr.Get(magicChangeComp).TryGetCachedResourceObj<BGWDataAsset_MagicallyChangeConfig>("BGWDataAsset_MagicallyChangeConfig'/Game/00MainHZ/Characters/Transform/VigorSkill/S2/MC_40_psd_hutoushe_01.MC_40_psd_hutoushe_01'", ELoadResourceType.SyncLoadAndCache);
                config.ABPClass = LoadClass(BossConf.ABPClass);
                config.SKMesh = UObject.LoadObject<USkeletalMesh>(GetWorld(), BossConf.SKMesh);
                config.CapsuleRadius = BossConf.CapsuleRadius;
                config.CapsuleHalfHeight = BossConf.CapsuleHalfHeight;
                config.Override_AbnormalDispID_Attacker = BossConf.Override_AbnormalDispID_Attacker;
                config.Override_AbnormalDispID_Victim = BossConf.Override_AbnormalDispID_Victim;
                config.TamerAssetPath = model.TamerPath;
                config.PhysicsAsset = UObject.LoadObject<UPhysicsAsset>(GetWorld(), BossConf.PhysicsAsset);
                config.TFXConfig.Clear();
                if (BossConf.TFXConfigs != null && BossConf.TFXConfigs.Count > 0)
                {
                    for (int i = 0; i < BossConf.TFXConfigs.Count; i++)
                    {
                        var item = default(FMagicallyChangeConfig_TFXConfig);
                        if (BossConf.TFXConfigs[i].TFXAsset != null)
                        {
                            item.TFXAsset = UObject.LoadObject<UTressFXAsset>(GetWorld(), BossConf.TFXConfigs[i].TFXAsset);
                        }

                        item.ShadeSettings = default(FTressFXShadeSettings);
                        item.ShadeSettings.FiberRadius = BossConf.TFXConfigs[i].ShadeSettings.FiberRadius;
                        item.ShadeSettings.FiberSpacing = BossConf.TFXConfigs[i].ShadeSettings.FiberSpacing;
                        item.ShadeSettings.HairThickness = BossConf.TFXConfigs[i].ShadeSettings.HairThickness;
                        item.ShadeSettings.RootTangentBlending = BossConf.TFXConfigs[i].ShadeSettings.RootTangentBlending;
                        item.ShadeSettings.ShadowThickness = BossConf.TFXConfigs[i].ShadeSettings.ShadowThickness;

                        item.LodScreenSize = BossConf.TFXConfigs[i].LodScreenSize;
                        item.bEnableSimulation = BossConf.TFXConfigs[i].EnableSimulation;

                        if (BossConf.TFXConfigs[i].HairMaterial != null)
                        {
                            item.HairMaterial = UObject.LoadObject<UMaterialInterface>(GetWorld(), BossConf.TFXConfigs[i].HairMaterial);
                        }

                        config.TFXConfig.Add(item);
                    }
                }
                config.InteractBones.Clear();
                if (BossConf.InteractBones != null && BossConf.InteractBones.Count > 0)
                {
                    for (int i = 0; i < BossConf.InteractBones.Count; i++)
                    {
                        var item = default(FBoneUseForDispMap);
                        item.FirstRadius = BossConf.InteractBones[i].FirstRadius;
                        item.NextRadius = BossConf.InteractBones[i].NextRadius;
                        item.FirstBoneName = new FName(BossConf.InteractBones[i].FirstBoneName);
                        item.NextBoneName = new FName(BossConf.InteractBones[i].NextBoneName);
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
                        weapon.Weapon = UObject.LoadClass<AActor>(null, item.Weapon);
                        weapon.SocketName = new FName(item.SocketName);
                        weapons.Add(weapon);
                    }
                    config.Weapons.SetValues(weapons);
                }
                if (model.Level1Scale > 0 && model.Level1Scale != 1)
                {
                    config.UnitScale = model.Level1Scale;
                }

                // 将新加载的配置加入缓存
                boss_vigorSkillConfigCache[bossLabel] = config;
            }

            return config;
        }

        public static void CastVigorSkillByModel(BGUPlayerCharacterCS character, string bossLabel, string type, int skillId)
        {
            // 检查缓存中是否已存在该配置
            Log.Info($"bian:{bossLabel} ,type,{type} ,skillId,{skillId} ");
            var magicChangeComp = GetCachedMagicChangeComp(character);
            if (magicChangeComp == null)
            {
                return;
            }
            var config = getMagicConfig(character, bossLabel, type);
            if (config == null)
            {
                return;
            }

            FieldInfo fieldData = typeof(BUS_MagicallyChangeComp).GetField("MagicallyChangeData", BindingFlags.NonPublic | BindingFlags.Instance);
            if (fieldData == null) return;
            BUC_MagicallyChangeData data = fieldData.GetValue(magicChangeComp) as BUC_MagicallyChangeData;
            if (data == null) return;
            data.ResetReason = EResetReason_MagicallyChange.Normal;
            data.CastReason = ECastReason_MagicallyChange.NormalSkill;
            data.DurMagicallyChange = true;
            data.RecoverSkillID = 10199;
            isPlayVigorSkillByID = true;
            BGUFunctionLibraryCS.CastMagicallyChangeSkill((AActor)MyUtils.GetControlledPawn(), config, skillId, 10199);
            // MyUtils.SetCamera();
        }


        public static void ResetVigorSkillByID(BGUPlayerCharacterCS character)
        {
            if (character == null)
            {
                return;
            }
            var magicChangeComp = GetCachedMagicChangeComp(character);
            if (magicChangeComp == null)
            {
                return;
            }
            MethodInfo reset = typeof(BUS_MagicallyChangeComp).GetMethod("Reset", BindingFlags.NonPublic | BindingFlags.Instance);
            if (reset == null)
            {
                return;
            }
            reset.Invoke(magicChangeComp, new Object[] { EResetReason_MagicallyChange.None });
            character.FollowCamera.RelativeLocation = new FVector(0, 0, 0);
        }

        public static void CastVigorSkill(BGUPlayerCharacterCS character, int VigorSkillID, bool reset = false)
        {
            // 获取变身技能描述
            var soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(VigorSkillID);

            Console.WriteLine($"bian:reset status {VigorSkillID} {soulSkillDesc}");
            if (soulSkillDesc == null)
            {
                return;
            }


            var magicChangeComp = FindActorCompByClass<BUS_MagicallyChangeComp>(character);
            var BGS = GetBUS_GSEventCollection();

            if (magicChangeComp != null)
            {

                // 反射获取 MagicallyChangeData 变身控制相关数据
                FieldInfo fieldData = typeof(BUS_MagicallyChangeComp).GetField("MagicallyChangeData", BindingFlags.NonPublic | BindingFlags.Instance);
                BUC_MagicallyChangeData data = fieldData.GetValue(magicChangeComp) as BUC_MagicallyChangeData;

                // 初始化状态
                //data.bIsPendingCast = true;
                //data.bIsPendingReset = false;
                data.CurVigorSkillID = 0;
                data.DurMagicallyChange = reset;  // 不变回去，需要手动变回
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

        public static void CastMimicrySkill(BGUPlayerCharacterCS character, int VigorSkillID, int? MagicSkillID = 0)
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
        public static FCalliopeGuid getGUid()
        {
            return (FCalliopeGuid)summonGuid;
        }

        public static void SummonReq(Int64 SummonID, Int64 SummonCount, int SummonAliveTime = 12, int? skillID = 0)
        {
            var character = Helper.GetBGUPlayerCharacterCS();

            if (SummonCount < 1)
            {
                SummonCount = 1;
            }

            FSummonReq fSummonReq = default(FSummonReq);
            fSummonReq.SummonType = ESummonType.Normal;
            summonGuid = GameplayTagExtension.ConvertToCalliopeGuid(Guid.NewGuid());
            fSummonReq.SummonGuid = (FCalliopeGuid)summonGuid;
            fSummonReq.SummonID = (Int32)SummonID;
            fSummonReq.SpawnConfigWrap = FSummonSpawnConfigWrap.WrapSpawnConfig_BySummonCommDesc((Int32)SummonID, character);
            fSummonReq.SpawnConfigWrap.SummonAliveTime = SummonAliveTime;
            fSummonReq.SpawnConfigWrap.DestroyDelayTime = 0;

            if (skillID.HasValue && skillID.Value > 0)
            {
                var skillDesc = BGW_GameDB.GetSkillSDesc(skillID.Value, character);
                if (skillDesc != null)
                {
                    fSummonReq.SpawnConfigWrap.BornSkillIDs = [skillID.Value];
                    fSummonReq.SpawnConfigWrap.UseBornSkill = true;
                }

            }
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
            if (action?.Caster != null)
            {
                aActor = action.Caster;
            }
            if (action?.Target != null)
            {
                target = action.Target;
            }
            string targetString = "BGW_90_hfm_leiwa_Atk_41_Lv6_change";
            bool isShotBull = path.Contains(targetString);
            //发射类的子弹不执行这个
            if (forTarget && target != null && !isShotBull)
            {
                aActor = target;
            }
            bool attackTarget = action?.attackTarget != null && action.attackTarget;
            if (attackTarget && target != null && !isShotBull)
            {
                aActor = target;
            }
            FEffectInstReq fEffectInstReq = new FEffectInstReq(character);

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
                    targetBase.UseSocket = true;
                    targetBase.SocketName = (FName)"CAMERA_LOCK";
                    spawnBase.BaseType = ProjectileBaseType.ProjectileSpawner;

                }
                if (action?.spawnBaseSocketName != null)
                {
                    spawnBase.UseSocket = true;
                    spawnBase.SocketName = (FName)(action?.spawnBaseSocketName);
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
                if (action?.BornDirOffsetXLeftValue > 0)
                {
                    bornDirOffset.BornDirOffsetX.LeftValue = action.BornDirOffsetXLeftValue;
                }
                if (action?.BornDirOffsetXRightValue > 0)
                {
                    bornDirOffset.BornDirOffsetX.RightValue = action.BornDirOffsetXRightValue;

                }

                if (action?.BornDirOffsetYLeftValue > 0)
                {
                    bornDirOffset.BornDirOffsetY.LeftValue = action.BornDirOffsetYLeftValue;
                }
                if (action?.BornDirOffsetYRightValue > 0)
                {
                    bornDirOffset.BornDirOffsetY.RightValue = action.BornDirOffsetYRightValue;
                }

                if (action?.BornDirOffsetZLeftValue > 0)
                {
                    bornDirOffset.BornDirOffsetZ.LeftValue = action.BornDirOffsetZLeftValue;
                }
                if (action?.BornDirOffsetZRightValue > 0)
                {
                    bornDirOffset.BornDirOffsetZ.RightValue = action.BornDirOffsetZRightValue;
                }
                if (offset.X > 0 || offset.Y > 0 || offset.Z > 0)
                {

                    if (attackTarget && target != null)
                    {
                        offsetInfo.PosOffset.X = offsetInfo.PosOffset.X;
                        offsetInfo.PosOffset.Y = offsetInfo.PosOffset.Y;
                        offsetInfo.PosOffset.Z = offsetInfo.PosOffset.Z;
                    }
                    else
                    {
                        var xyz = aActor.GetActorForwardVector();
                        offsetInfo.PosOffset.X = offsetInfo.PosOffset.X + (offset.X * xyz.X);
                        offsetInfo.PosOffset.Y = offsetInfo.PosOffset.Y + (offset.Y * xyz.Y);
                        offsetInfo.PosOffset.Z = offsetInfo.PosOffset.Z + (offset.Z * xyz.Z);
                    }


                }
                var none_target = bGWDataAsset_ProjectileSpawnConfig.bEnableSpawnBase_NoneTarget;
                if (forTarget && target != null && isShotBull)
                {
                    none_target = false;
                }
                if (attackTarget && target != null && isShotBull)
                {
                    none_target = false;
                }
                if (action?.TargetProjectilePosOffsetType != null)
                {
                    ProjectileSpawnNSInfo.TargetPosOffsetInfo.PosOffsetType = (b1.ProjectilePosOffsetType)Enum.Parse(typeof(b1.ProjectilePosOffsetType), action.TargetProjectilePosOffsetType);
                }

                // if (action?.TargetRangeOffsetInfo != null)
                // {
                //     ProjectileSpawnNSInfo.TargetPosOffsetInfo.RangeOffsetInfo = JsonConvert.DeserializeObject<b1.FRangePointSetRule>(action.TargetRangeOffsetInfo);
                // }

                if (action?.TargetMatrixDensity != null)
                {
                    ProjectileSpawnNSInfo.TargetPosOffsetInfo.RangeOffsetInfo.MatrixDensity = (int)action.TargetMatrixDensity;
                    ProjectileSpawnNSInfo.TargetPosOffsetInfo.PosOffsetType = (b1.ProjectilePosOffsetType)Enum.Parse(typeof(b1.ProjectilePosOffsetType), "RangeOffset");

                }
                if (action?.NoiseX > 0 || action?.NoiseY > 0 || action?.NoiseZ > 0)
                {
                    ProjectileSpawnNSInfo.TargetPosOffsetInfo.RangeOffsetInfo.Noise = new FVector(action?.NoiseX ?? 0, action?.NoiseY ?? 0, action?.NoiseZ ?? 0);
                }
                if (action?.TargetCircleRadius != null)
                {
                    ProjectileSpawnNSInfo.TargetPosOffsetInfo.RangeOffsetInfo.CircleRadius = (int)action.TargetCircleRadius;
                    ProjectileSpawnNSInfo.TargetPosOffsetInfo.PosOffsetType = (b1.ProjectilePosOffsetType)Enum.Parse(typeof(b1.ProjectilePosOffsetType), "RangeOffset");
                }
                if (action?.EffectInstReq != null)
                {
                    fEffectInstReq = (FEffectInstReq)action.EffectInstReq;
                    spawnBase.BaseType = ProjectileBaseType.UseEffectPosition;
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

                if (action != null && action?.BornDirType != null)
                {
                    ProjectileSpawnNSInfo.BornDirBaseInfo.BornDirType =
                        (b1.ProjectileBornDirType)Enum.Parse(typeof(b1.ProjectileBornDirType), action.BornDirType);

                }
                if (action != null && action?.AttachToSpawnBase != null)
                {
                    ProjectileSpawnNSInfo.AttachToSpawnBase = (bool)action.AttachToSpawnBase;
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
                if (action?.BulletNumInOneWave > 0)
                {
                    ProjectileSpawnNSInfo.SpawnNumPerWave = action.BulletNumInOneWave;
                }
                if (action?.ProjectOffsetPosition?.Count() > 0)
                {
                    ProjectileSpawnNSInfo.SpawnPosOffsetInfo.PosOffset.X += action.ProjectOffsetPosition[0];
                    ProjectileSpawnNSInfo.SpawnPosOffsetInfo.PosOffset.Y += action.ProjectOffsetPosition[1];
                    ProjectileSpawnNSInfo.SpawnPosOffsetInfo.PosOffset.Z += action.ProjectOffsetPosition[2];
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
        public static List<ABGUCharacter> getMonsterByDistance(float MaxDistance = 6000)
        {
            var play = GetBGUPlayerCharacterCS();
            UBGUSelectUtil.SphereOverlapBGUCharacters(play, BGUFuncLibActorTransformCS.BGUGetActorLocation(play), MaxDistance, out var OutArray);
            return OutArray;
        }
        public static void StrongMonster()
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

                    var fs_name = item?.GetFullName().ToLower();
                    if (fs_name?.IndexOf("unit_player_wukong") > -1)
                    {
                        BGUFunctionLibraryCS.BGUAddBuff(item, item, 888666001, EBuffSourceType.GM, -1);
                        continue;
                    }
                    //己方霸体不吃毒火冰
                    BGUFunctionLibraryCS.BGUAddBuff(item, item, 888666002, EBuffSourceType.GM, -1);
                    BGUFunctionLibraryCS.BGUAddBuff(item, item, 888666003, EBuffSourceType.GM, -1);
                }
                else
                {
                    BGUFunctionLibraryCS.BGUAddBuff(item, item, 888666003, EBuffSourceType.GM, -1);
                }
            }


        }
        public static bool isSameTeam(BGUPlayerCharacterCS monster)
        {
            var play = Helper.GetBGUPlayerCharacterCS();
            var playerTeamID = play.GetTeamIDInCS();
            var targetTeamID = monster?.GetTeamIDInCS();

            if (targetTeamID != null && targetTeamID == playerTeamID)
            {
                Log.Info($"isSameTeamfun target name: ${monster?.PathName}");
                return true;
            }
            return false;
        }
        public static void FenshenTeleport()
        {
            var play = Helper.GetBGUPlayerCharacterCS();
            FVector actorLocation = play.GetActorLocation();
            actorLocation.X -= 200;
            actorLocation.Y -= 200;
            FRotator fRotator2 = play.GetActorRotation();

            List<BGUCharacterCS> allActorsOfClassList = play.World.GetAllActorsOfClassList<BGUCharacterCS>();

            foreach (BGUCharacterCS item in allActorsOfClassList)
            {

                if (item.CanBeDamaged && BGU_DataUtil.GetActorTeamID(play) == BGU_DataUtil.GetActorTeamID(item))
                {
                    var fs_name = item?.GetFullName().ToLower();
                    // 取所有的队友，排除自己
                    if (fs_name?.IndexOf("unit_player_wukong") < 0)
                    {
                        item?.Teleport(actorLocation, fRotator2);
                    }

                }
            }
        }
        // 分身触发技能
        // 添加缓存字段
        private static List<BGUCharacterCS> _cachedCharacters = new List<BGUCharacterCS>();
        private static DateTime _lastCacheUpdate = DateTime.MinValue;
        private static readonly TimeSpan _cacheUpdateInterval = TimeSpan.FromMilliseconds(5000); // 缓存更新间隔

        // 分身触发技能 - 优化版本
        public static void FenshenGSTryCastSkill(int skillID, bool? needPort = false)
        {
            // var play = Helper.GetBGUPlayerCharacterCS();
            // if (play == null || play.World == null) return;
            SummonReq(1111222003, 1, 3, skillID);
            // // 检查是否需要更新缓存
            // if (DateTime.Now - _lastCacheUpdate > _cacheUpdateInterval || _cachedCharacters.Count == 0)
            // {
            //     UpdateCharacterCache(play.World);
            // }

            // // 使用缓存数据进行过滤
            // var filteredActors = _cachedCharacters.Where(item =>
            //     BGU_DataUtil.GetActorTeamID(play) == BGU_DataUtil.GetActorTeamID(item) &&
            //     BGUFunctionLibraryCS.BGUHasBuffByID(item, 888666002)
            // ).ToList();

            // var teamFenshen = _cachedCharacters.Where(item =>
            //     BGU_DataUtil.GetActorTeamID(play) == BGU_DataUtil.GetActorTeamID(item)
            // ).ToList();

            // if (teamFenshen.Count < 2)
            // {
            //     Helper.SummonReq(5009301, 1, 9999);

            //     // 立即更新缓存以包含新召唤的单位
            //     UpdateCharacterCache(play.World);
            //     return;
            // }

            // 处理技能释放逻辑
            // ProcessSkillCast(filteredActors, skillID);
        }

        // 更新角色缓存
        private static void UpdateCharacterCache(UWorld world)
        {
            _cachedCharacters = world.GetAllActorsOfClassList<BGUCharacterCS>();
            _lastCacheUpdate = DateTime.Now;
        }

        // 处理技能释放逻辑
        private static void ProcessSkillCast(List<BGUCharacterCS> actors, int skillID)
        {
            foreach (BGUCharacterCS item in actors)
            {
                var fs_name = item?.GetFullName().ToLower();
                if (fs_name?.IndexOf("unit_player_wukong") > -1)
                {
                    continue; // 排除自己
                }

                if (skillID > 0 && (fs_name?.IndexOf("unit_monkeysummon") > -1 || fs_name?.IndexOf("TAMER_monkeysummon") > -1))
                {
                    TryCastSkill(item, skillID);
                }
                else
                {
                    var allSkillIDs = BGUFuncLibAICS.BGUGetUnitAllSkillID(item);
                    if (fs_name?.IndexOf("unit_mgd_jsds_summon_c") > -1)
                    {
                        allSkillIDs = GetSpecialSkillIDs();
                    }

                    if (allSkillIDs != null && allSkillIDs?.Count > 0 && fs_name?.IndexOf("unit_player_wukong") < 0)
                    {
                        var randomSkillID = GetRandomSkillID(allSkillIDs);
                        if (randomSkillID > 0)
                        {
                            TryCastSkill(item, randomSkillID);
                        }
                    }
                }
            }
        }

        // 尝试释放技能
        private static void TryCastSkill(BGUCharacterCS character, int skillID)
        {
            try
            {
                FCastSkillInfo castSkillInfo = new FCastSkillInfo(skillID, ECastSkillSourceType.GM);
                if (castSkillInfo.SkillID > 0)
                {
                    BUS_EventCollectionCS.Get(character).Evt_UnitCastSkillTry.Invoke(castSkillInfo);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Error casting skill {skillID}: {ex.Message}");
            }
        }

        // 获取特殊技能ID列表
        private static List<int> GetSpecialSkillIDs()
        {
            return new List<int>
    {
        700101, 700102, 700103, 700104,
        700105, 700106, 700107, 700108, 700109, 700110,
        700111, 700112, 700113, 700114, 700115, 700116, 700117, 700118, 700119, 700120,
        700121, 700122, 700123, 700124, 700125, 700126, 700127, 700128, 700129, 700130,
        700131, 700132, 700133, 700134, 700135, 700136, 700137, 700138, 700139, 700140,
        700141, 700142, 700143, 700144, 700145, 700146, 700147, 700148, 700149, 700150,
        700151, 700152, 700153, 700154, 700155
    };
        }

        // 获取随机技能ID
        private static int GetRandomSkillID(List<int> skillIDs)
        {
            Random random = new Random();
            int randomIndex = random.Next(skillIDs.Count);
            return skillIDs[randomIndex];
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

                    // BGUFuncLibNonRuntime.LoadProtobufData<FUStUnitCommDesc>();
                    // BGUFuncLibNonRuntime.LoadProtobufData<FUStUnitBattleInfoExtendDesc>();
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