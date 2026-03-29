
using b1;
using b1.BGW;
using b1.ECS;
using b1.Plugins.Calliope;
using b1.Plugins.TressFX;
using b1.Protobuf.DataAPI;
using B1UI;
using B1UI.GSUI;
using BtlB1;
using BtlShare;
using CommB1;
using CsB1;
using CSharpModBase;
using GSE.GSUI;
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
using UnrealEngine.Runtime.Native;

namespace bian
{
    public class Helper
    {
        public static bool is_bian_mod_stop = false;
        public static bool auto_attack = false;
        public static int enterSkillID = 0;
        public static BUC_RollData enterRollData = new BUC_RollData();
        private static UWorld? world;
        public static FCalliopeGuid? summonGuid;


        public static bool set_mod_stop(Boolean value)
        {
            is_bian_mod_stop = value;
            return is_bian_mod_stop;
        }

        public static void awake_actor()
        {

            var enemies = getMonsterByDistance(4000);
            if (enemies == null || enemies.Count == 0) return;
            foreach (var enemy in enemies)
            {
                BGUFuncLibAICS.SearchTargetSP(enemy);
            }

        }
        public static bool tooggleAutoAttack()
        {

            auto_attack = !auto_attack;
            return auto_attack;
        }

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
        public static UAnimMontage? GetPlayerCurrentActiveMontage(BGUCharacterCS character)
        {

            if (character == null)
            {
                return null;
            }

            UAnimInstance animInstance = character.Mesh.GetAnimInstance();
            if (character == animInstance)
            {
                return null;
            }
            return animInstance.GetCurrentActiveMontage();
        }
        public static BGP_PlayerControllerB1 GetPlayerController()
        {
            return (BGP_PlayerControllerB1)UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetWorld());
        }

        public static BUS_GSEventCollection GetBUS_GSEventCollection()
        {
            return BUS_EventCollectionCS.Get(GetControlledPawn());
        }

        // 获取距离最近的敌人
        public static BGUCharacterCS GetNearestEnemy(float range = 3000)
        {
            var player = GetBGUPlayerCharacterCS();
            if (player == null) return null;

            var enemies = getMonsterByDistance(range);
            if (enemies == null || enemies.Count == 0) return null;

            BGUCharacterCS nearestEnemy = null;
            float minDistance = float.MaxValue;
            var playerPos = player.GetActorLocation();

            foreach (var enemy in enemies)
            {
                // 跳过同一队伍的角色
                if (BGU_DataUtil.GetActorTeamID(player) == BGU_DataUtil.GetActorTeamID(enemy))
                    continue;

                var distance = FVector.Distance(playerPos, enemy.GetActorLocation());
                if (distance < minDistance)
                {
                    minDistance = distance;
                    nearestEnemy = (BGUCharacterCS?)enemy;
                }
            }

            return nearestEnemy;
        }


        public static BGUCharacterCS GetNearestActor(float range = 3000)
        {
            var player = GetBGUPlayerCharacterCS();
            if (player == null) return null;

            var enemies = getMonsterByDistance(range);
            if (enemies == null || enemies.Count == 0) return null;

            BGUCharacterCS nearestEnemy = null;
            float minDistance = float.MaxValue;
            var playerPos = player.GetActorLocation();

            foreach (var enemy in enemies)
            {
                // 跳过自己
                if (player.PathName == enemy.PathName)
                    continue;

                var distance = FVector.Distance(playerPos, enemy.GetActorLocation());
                if (distance < minDistance)
                {
                    minDistance = distance;
                    nearestEnemy = (BGUCharacterCS?)enemy;
                }
            }

            return nearestEnemy;
        }
        public static BGUCharacterCS GetNearestAlly(float range = 3000)
        {
            var player = GetBGUPlayerCharacterCS();
            if (player == null) return null;

            var allies = getMonsterByDistance(range);
            if (allies == null || allies.Count == 0) return null;

            BGUCharacterCS nearestAlly = null;
            float minDistance = float.MaxValue;
            var playerPos = player.GetActorLocation();

            foreach (var ally in allies)
            {
                // 只选择同一队伍的角色
                if (BGU_DataUtil.GetActorTeamID(player) != BGU_DataUtil.GetActorTeamID(ally) || ally?.GetName() == player?.GetName())
                    continue;

                var distance = FVector.Distance(playerPos, ally.GetActorLocation());
                if (distance < minDistance)
                {
                    minDistance = distance;
                    nearestAlly = (BGUCharacterCS?)ally;
                }
            }

            return nearestAlly;
        }


        public static List<AActor> getAllSunmon(int num = 1)
        {
            var character = GetBGUPlayerCharacterCS();
            IBGC_SummonData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_SummonData, BGC_SummonData>(character);
            if (gameStateReadonlyData == null || gameStateReadonlyData.GetSummonerAllServantActors(character, out var ServantActors) <= 0)
            {
                return new List<AActor>();
            }
            var finalList = num > ServantActors.Count ? ServantActors : ServantActors.Take(num).ToList();
            return finalList.Cast<AActor>().ToList();
        }

        private static void HandleBuffAction(BGUPlayerCharacterCS character, RuleAction action, float timeLength)
        {
            var buffs = action?.BuffIDs?.Count > 0 ? action?.BuffIDs : action?.BuffID > 0 ? [action.BuffID] : null;
            if (buffs?.Count > 0)
            {
                var buffTime = (action?.BuffTime > 0 || action?.BuffTime == -1) ? action.BuffTime : timeLength;
                var target = action?.Target ?? character;
                if (action?.ForTarget == true)
                {
                    target = BGUFunctionLibraryCS.BGUGetTarget(character);
                    if (target == null)
                    {
                        //没有目标就抛出异常
                        return;
                    }
                }
                if (target == null)
                {
                    // 记录错误或抛出异常
                    return;
                }
                foreach (var buff in buffs)
                {
                    BGUFunctionLibraryCS.BGUAddBuff(character, target, buff, EBuffSourceType.GM, buffTime);
                }
            }
        }

        public static int getCurrentSkillId(BGUCharacterCS? character)
        {

            if (character == null) return 0;
            // BUC_SkillInstsData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SkillInstsData>(character);
            // if (readOnlyData == null) return 0;
            var skillId = BGUFuncLibSkillCS.BGUGetLastSkillID(character);
            return skillId;
        }
        private static Dictionary<string, double> _lastLogTime = new Dictionary<string, double>();
        private const double LOG_COOLDOWN = 3000; // 3秒

        public static void LogInfoOnce(string message)
        {
            double currentTime = DateTimeToTimestamp();
            if (_lastLogTime.TryGetValue(message, out double lastTime))
            {
                if (currentTime - lastTime < LOG_COOLDOWN)
                {
                    return; // 在冷却期内，不打印日志
                }
            }
            _lastLogTime[message] = currentTime;
            Log.Info(message);
        }

        public static void doActionBySkillId(BGUCharacterCS character)
        {

            var skillId = getCurrentSkillId(character);
            LogInfoOnce($"skillId:{skillId}");
        }

        public static void SpawnActorByWorld(string classAsset, int? teamID)
        {
            var player = GetBGUPlayerCharacterCS();
            if (player == null) return;
            UWorld World = player.World;
            if (World == null) return;
            FVector actorLocation = player.GetActorLocation();
            FVector fVector = player.GetControlRotation()
                .GetForwardVector() * 800.0;
            FVector location = actorLocation + fVector;
            FRotator rotation = UMathLibrary.FindLookAtRotation(location, actorLocation);
            FActorSpawnParametersInterop parameters = new FActorSpawnParametersInterop
            {
                SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AlwaysSpawn
            };
            // UClass unrealClass = BGW_PreloadAssetMgr.Get(World).TryGetCachedResourceObj<UClass>("PrefabricatorAsset'/Game/00Main/Design/Units/HFM/Unit_HFM_ShiXianFeng_01_Prefab.Unit_HFM_ShiXianFeng_01_Prefab_C'", ELoadResourceType.SyncLoadAndCache);
            UClass uClass = LoadClass($"PrefabricatorAsset'{classAsset}'");
            if (uClass == null) return;
            World.SpawnActor(uClass, ref location, ref rotation, ref parameters);


        }

        public static void addCopySkils(int skillId)
        {
            var listData = BG_ProtobufDataAPI<FUStSummonCopySkillDesc>.Get().GetAll();
            var character = Helper.GetBGUPlayerCharacterCS();
            if (listData != null && skillId > 0 && skillId != 10100 && skillId != 10199)
            {

                FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(skillId, character);
                if (!listData.ContainsKey(skillId) && skillSDesc != null && !skillSDesc.TemplatePath.Contains("AM_Wukong_heyao_"))
                {
                    var newSkill = new FUStSummonCopySkillDesc();
                    newSkill.ID = skillId;
                    newSkill.SummonUnitMontagePath = skillSDesc.TemplatePath;
                    listData.Add(skillId, newSkill);
                }
            }
        }
        public static void summonerDoActions(RuleAction action)
        {
            var list = getAllSunmon(5);
            var character = GetBGUPlayerCharacterCS();

            var skillId = action?.SkillID > 0 ? action.SkillID : getCurrentSkillId(character);

            if (list == null || list.Count == 0 || action == null || action.Type == null)
            {

                SummonReq(1001103, 1, 6, skillId);
                return;
            }
            ;
            var types = action?.Type?.ToLower();
            if (types == null) return;
            if (types == "skill")
            {
                addCopySkils(skillId);
                DelayExecute(100, () =>
                 {
                     BUS_EventCollectionCS.Get(character).Evt_SummonUseSkill.Invoke(skillId);

                 });
                return;
            }
            foreach (AActor item in list)
            {

                var finalActor = item as BGUCharacterCS;

                switch (types)
                {
                    case "buff":
                        var buffTime = action?.BuffTime ?? 1000;
                        if (action?.BuffIDs?.Count > 0)
                        {
                            foreach (var buff in action.BuffIDs)
                            {
                                BGUFunctionLibraryCS.BGUAddBuff(item, item, buff, EBuffSourceType.GM, buffTime);
                            }
                        }

                        break;
                    // case "skill":
                    //     // BUS_EventCollectionCS.Get(character).Evt_SummonUseSkill.Invoke(skillId);
                    //     // var ServantEventCollection = BUS_EventCollectionCS.Get(item);
                    //     // ServantEventCollection.Evt_CallSummonUseSkill.Invoke(skillId);
                    //     break;
                    case "magic":
                        if (action?.MagicSkillID > 0 && action?.path != null && finalActor != null)
                        {
                            fenshenCastMagic(item, action.path, (int)action.MagicSkillID);
                            // CastVigorSkillByID(finalActor, action.SkillID, action?.UnitScale ?? 1, (int?)(action?.Scale3D ?? 1));
                        }
                        break;

                    case "bossskill":

                        if (finalActor == null) continue;
                        if (action.bossLabel != null && action.bossType != null && action?.MagicSkillID != null)
                        {
                            CastVigorSkillByModel(finalActor, action.bossLabel, action.bossType ?? "", action?.MagicSkillID ?? 0, action?.resetBack ?? false, action?.RecoverSkillID ?? 10199);
                        }
                        break;
                    // case "magicskill":
                    //     if (action.magicID != null)
                    //     {
                    //         CastVigorSkillByID(finalActor, (int)action.magicID, action?.UnitScale ?? 1, action?.MagicSkillID ?? 0, action?.Scale3D ?? 1, action?.resetBack ?? false);
                    //     }
                    //     break;
                    case "add_attr":
                        if (action?.attrValue != null && action?.attrType != null)
                        {
                            BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(finalActor);
                            if (bUS_GSEventCollection == null) return;
                            bUS_GSEventCollection.Evt_IncreaseAttrFloat?.Invoke((EBGUAttrFloat)(action.attrType ?? 151), action?.attrValue ?? 100);
                            if (action?.attrType == (int)EBGUAttrFloat.SkillSuperArmor)
                            {
                                bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.SkillSuperArmor, false);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }


        }

        public static string GetLastChars(string str, int count)
        {
            if (string.IsNullOrEmpty(str) || count <= 0)
                return string.Empty;

            return str.Length > count ? str.Substring(str.Length - count) : str;
        }

        public static void SyncTeamWithTarget()
        {
            var character = Helper.GetBGUPlayerCharacterCS();

            var target = BGUFunctionLibraryCS.BGUGetTarget(character) as BGUCharacterCS;
            if (target != null)
            {
                var teamID = target.GetTeamIDInCS();
                var lockTarget = GetNearestEnemy(3000);
                if (lockTarget != null)
                {
                    BUS_EventCollectionCS.Get((AActor)(object)target).Evt_AICatchTarget.Invoke(lockTarget, ETargetSourceType.Target_BirthCatchSummonerTarget, false);
                }
                character.SetTeamIDInCS(teamID);
                // Log.Debug($"bian: set team id-->{teamID}");
            }
            else
            {
                BUS_EventCollectionCS.Get(character).Evt_ResetTeamID.Invoke();
            }
        }


        public static void resetTeamID()
        {
            List<ABGUCharacter> allActorsOfClassList = getMonsterByDistance(3000);
            foreach (var actor in allActorsOfClassList)
            {
                BUS_EventCollectionCS.Get(actor).Evt_ResetTeamID.Invoke();
            }
        }
        public static bool IsPlayer(string name)
        {
            if (name != null && name?.ToLower()?.IndexOf("unit_player") > -1)
            {
                return true;
            }
            return false;
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

        public static T LoadAsset<T>(string asset) where T : UObject
        {
            return BGW_PreloadAssetMgr.Get(GetWorld()).TryGetCachedResourceObj<T>(asset, ELoadResourceType.SyncLoadAndCache, b1.BGW.EAssetPriority.Default, null, -1, -1);
        }

        public static UClass LoadClass(string asset)
        {
            return LoadAsset<UClass>(asset);
        }


        // 持续执行15次
        public static void DelayExecuteUntilSuccess(int delayMs, Func<bool> condition, Action action, int maxAttempts = 19)
        {
            int attempts = 0;

            void TryExecute()
            {
                if (condition())
                {
                    action();
                }
                if (attempts < maxAttempts)
                {
                    attempts++;
                    DelayExecute(delayMs, TryExecute);
                }
            }
            TryExecute();
        }



        public static void GMSpawnMonster(string path)
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
                    actorTransform.SetLocation(playerCharacter.GetActorLocation() + playerCharacter.GetActorForwardVector() * 800.0);
                    actorTransform.SetRotation((-playerCharacter.GetActorForwardVector()).Rotation().Quaternion());
                    BUTamerActor bUTamerActor = UBGUFunctionLibrary.BGUBeginDeferredActorSpawnFromClass(playerCharacter.World, uClass, actorTransform, ESpawnActorCollisionHandlingMethod.AlwaysSpawn, null) as BUTamerActor;
                    if (bUTamerActor != null)
                    {
                        bUTamerActor.MarkAsSpawnedTamer(null);
                        UBGUFunctionLibrary.BGUFinishSpawningActor(bUTamerActor, actorTransform);
                        BGUFuncLibAICS.SearchTargetSP(bUTamerActor);
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

        public static AActor? SpawnActor(string classAsset, int? teamID)
        {
            var controlledPawn = GetControlledPawn();
            FVector actorLocation = controlledPawn.GetActorLocation();
            FVector fVector = controlledPawn.GetControlRotation()
                .GetForwardVector() * 900.0;
            FVector location = actorLocation + fVector;
            FRotator rotation = UMathLibrary.FindLookAtRotation(location, actorLocation);
            UClass uClass = LoadClass($"PrefabricatorAsset'{classAsset}'");
            if (uClass == null)
            {
                return null;
            }
            var World = controlledPawn.World;
            BUTamerActor? actor = UBGUFunctionLibrary.BGUBeginDeferredActorSpawnFromClass(controlledPawn.World, uClass, new FTransform(actorLocation), ESpawnActorCollisionHandlingMethod.AlwaysSpawn, null) as BUTamerActor;
            //    var actor = BGU_UnrealWorldUtil.RequestSpawnUnit(controlledPawn.World,uClass,new FTransform(actorLocation),null);
            // var actor = BGUFunctionLibraryCS.BGUSpawnActor(controlledPawn.World, uClass, start, frotator);
            if (actor != null)
            {
                actor.MarkAsSpawnedTamer(null);
                BUTamerActor? actorFinish = UBGUFunctionLibrary.BGUFinishSpawningActor(actor, controlledPawn.GetActorTransform()) as BUTamerActor;
                if (teamID != null && actorFinish != null)
                {
                    DelayExecuteUntilSuccess(20,
                        () =>
                        {
                            BGUCharacterCS monster = actorFinish.GetMonster();
                            if (monster != null)
                            {
                                var monsterTeamID = monster.GetTeamIDInCS();
                                if (monsterTeamID != (int)teamID)
                                {
                                    monster.SetTeamIDInCS((int)teamID);
                                }
                                else
                                {
                                    if (!BGUFunctionLibraryCS.BGUHasBuffByID(monster, 888666002))
                                    {
                                        BGUFunctionLibraryCS.BGUAddBuff(monster, monster, 888666002, EBuffSourceType.GM, -1);
                                    }

                                }
                                return monsterTeamID == (int)teamID;
                            }
                            return false;
                        },
                        () =>
                        {
                            BGUCharacterCS monster = actorFinish.GetMonster();
                            var monsterTeamID = monster.GetTeamIDInCS();
                            if (monsterTeamID != (int)teamID)
                            {
                                monster.SetTeamIDInCS((int)teamID);
                            }
                        });
                }
            }

            return actor;
        }

        public static AActor GetActorOfClass(string classAsset)
        {
            return UGameplayStatics.GetActorOfClass(GetWorld(), LoadAsset<UClass>(classAsset));
        }

        public static T? FindActorCompByClass<T>(BGUCharacterCS character) where T : UActorCompBaseCS
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

        public static void OnMagicallyChangeFadeOut()
        {
            var character = GetBGUPlayerCharacterCS();

            if (character == null) return;

            BUS_GSEventCollection BE_Owner = BUS_EventCollectionCS.Get(character);
            if (BE_Owner == null) return;
            BE_Owner.Evt_OnMagicallyChangeRecover.Invoke(10199);
            // if (character == null || !isPlayVigorSkillByID) return;
            // var magicChangeComp = FindActorCompByClass<BUS_MagicallyChangeComp>(character);
            // if (magicChangeComp == null) return;
            // MethodInfo reset = typeof(BUS_MagicallyChangeComp).GetMethod("Reset", BindingFlags.NonPublic | BindingFlags.Instance);
            // if (reset == null) return;
            // FieldInfo fieldData = typeof(BUS_MagicallyChangeComp).GetField("MagicallyChangeData", BindingFlags.NonPublic | BindingFlags.Instance);
            // if (fieldData != null)
            // {
            //     BUC_MagicallyChangeData data = fieldData?.GetValue(magicChangeComp) as BUC_MagicallyChangeData;
            //     if (data != null)
            //     {
            //         data.RecoverSkillID = 10199;
            //     }
            // }
            // reset.Invoke(magicChangeComp, [EResetReason_MagicallyChange.Normal]);

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

        public static void SetCharacterShieldActive(BGUCharacterCS character, bool isActive)
        {
            if (character == null) return;

            // 获取UI事件集合
            var uiEventCollection = BGW_UIEventCollection.Get(character.World);
            if (uiEventCollection != null)
            {
                // 将角色转换为Entity
                Entity entity = ECSExtension.ToEntity(character);
                // 通过事件系统调用SetShieldBarActive
                uiEventCollection.Evt_UI_SetShieldBarActive?.Invoke(entity, isActive);
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
        private static BGUCharacterCS? _cachedCharacter;
        private static BUS_MagicallyChangeComp? GetCachedMagicChangeComp(BGUCharacterCS character)
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
        public static bool noResetCombo = false;
        public static int playVigorSkillID;
        public static BGUCharacterCS playVigorCharacter;


        public static void updateIsPlayVigorSkillByID(bool isPlay)
        {
            isPlayVigorSkillByID = isPlay;
        }
        public static void updateNoResetCombo(bool isReset)
        {
            noResetCombo = isReset;
        }
        public static void fenshenCastMagic(AActor Owner, string path, int skillID, int? recoverSkillID = 10199)
        {
            BUS_GSEventCollection BE_Owner = BUS_EventCollectionCS.Get(Owner);


            UActorComponent AddedComponent = UGSE_ActorFuncLib.AddComponentByClass(
                   Owner,
                   (TSubclassOf<UActorComponent>)UClass.GetClass<BUS_MagicallyChangeComp>(),
                   false,  // bManualAttachment - 是否手动附加
                   FTransform.Identity,  // RelativeTransform - 相对变换
                   true   // bDeferredFinish - 是否延迟完成
               );

            BGWDataAsset_MagicallyChangeConfig bGWDataAsset_MagicallyChangeConfig = new BGWDataAsset_MagicallyChangeConfig();
            bGWDataAsset_MagicallyChangeConfig = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<BGWDataAsset_MagicallyChangeConfig>(path, ELoadResourceType.SyncLoadAndCache);

            Log.Info($"fenshenCastMagic bGWDataAsset_MagicallyChangeConfig:{bGWDataAsset_MagicallyChangeConfig?.PathName} ,AddedComponent:{AddedComponent?.GetFName()},Owner:{Owner.PathName}");
            if (!(bGWDataAsset_MagicallyChangeConfig == null))
            {
                BE_Owner?.Evt_OnCastMagicallyChangeSkill.Invoke(bGWDataAsset_MagicallyChangeConfig, skillID, recoverSkillID ?? 10199);
            }
        }
        public static void CastVigorSkillByID(BGUCharacterCS character, int VigorSkillID, float UnitScale, int? MagicSkillID = 0, float? Scale3D = 1, bool resetBack = false)
        {
            var magicChangeComp = FindActorCompByClass<BUS_MagicallyChangeComp>(character);
            if (magicChangeComp == null)
            {
                var player = GetBGUPlayerCharacterCS();
                magicChangeComp = FindActorCompByClass<BUS_MagicallyChangeComp>(player);
                if (magicChangeComp == null)
                {
                    return;
                }
            }

            var soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(VigorSkillID);

            if (soulSkillDesc == null || magicChangeComp == null)
            {
                return;
            }

            BGWDataAsset_MagicallyChangeConfig config = new BGWDataAsset_MagicallyChangeConfig();
            config = BGW_PreloadAssetMgr.Get(character).TryGetCachedResourceObj<BGWDataAsset_MagicallyChangeConfig>(soulSkillDesc.DAPath, ELoadResourceType.SyncLoadAndCache);

            // BGWDataAsset_MagicallyChangeConfig config = BGW_PreloadAssetMgr.Get(magicChangeComp).TryGetCachedResourceObj<BGWDataAsset_MagicallyChangeConfig>(soulSkillDesc.DAPath, ELoadResourceType.SyncLoadAndCache);

            if (config == null)
            {
                return;
            }
            var BGS = GetBUS_GSEventCollection();
            if (UnitScale > 0 && UnitScale != 1)
            {
                config.UnitScale = (float)UnitScale;
            }
            else
            {
                config.UnitScale = (float)1.0;

            }
            BGS.Evt_BuffAdd.Invoke(22010, character, character, 1000, EBuffSourceType.MagicallyChange);
            var finalId = MagicSkillID > 0 ? MagicSkillID : soulSkillDesc.SkillId;
            try
            {
                isPlayVigorSkillByID = true;
                noResetCombo = true;
                // BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(character);
                // bUS_GSEventCollection?.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EnterMagicWindow, 5000);
                BGUFunctionLibraryCS.BGUTriggerUnitState(character, EBUStateTrigger.AttackStateBegin, 5000);
                BGUFunctionLibraryCS.BGUTriggerUnitState(character, EBUStateTrigger.EnterVigorKeyCache, 5000);
                int currentLastSkillID = BGUFuncLibSkillCS.BGUGetLastSkillID(character);
                // BUC_RollData RollData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_RollData>(character);

                enterSkillID = currentLastSkillID;
                // if (RollData != null)
                // {
                //     enterRollData.DodgeStartSkillID = enterSkillID;
                //     enterRollData.CurStateIndex = RollData.CurStateIndex;
                //     enterRollData.RollCombo.Clear();
                //     enterRollData.RollCombo.AddRange(RollData.RollCombo);
                //     enterRollData.RollCombo.Add((int)finalId);
                //     enterRollData.RollComboLoopStartIdx = RollData.RollComboLoopStartIdx;
                //     enterRollData.bCastRollingSkill = RollData.bCastRollingSkill;
                // }

                // Log.Info($"释放精魄技能时的连招信息 CastVigorSkillByID：CurStateIndex:{RollData?.CurStateIndex}, RollCombo:{string.Join(",", RollData?.RollCombo)}, RollComboLoopStartIdx:{RollData?.RollComboLoopStartIdx}, bCastRollingSkill:{RollData?.bCastRollingSkill}");

                // DelayExecute(10, () =>
                // {

                //     // if (RollData.RollCombo.Contains((int)finalId))
                //     // {
                //     //     RollData.RollComboLoopStartIdx = RollData.RollCombo.FindIndex((int r) => r == finalId);
                //     // }
                //     // else
                //     // {
                //     //     int currentLastSkillID = BGUFuncLibSkillCS.BGUGetLastSkillID(character);
                //     //     int skillID = RollData.RollCombo[RollData.CurStateIndex];
                //     // }
                //     // List<int> _SkillBlackList = new List<int>();
                //     // List<int> _SkillWhiteList = new List<int> { (int)finalId, 10199 };
                //     // <BUC_RollData>

                //     // bUS_GSEventCollection?.Evt_SetMagicWindowSkillList.Invoke(_SkillBlackList, _SkillWhiteList);
                // });

                // DelayExecute(100, () =>
                // {
                //     bUS_GSEventCollection?.Evt_IncreaseAttrFloat?.Invoke(EBGUAttrFloat.SkillSuperArmor, 10000);
                // });
                playVigorSkillID = (int)finalId;
                playVigorCharacter = character;
                if (Scale3D != null && Scale3D > 0)
                {
                    character.SetActorScale3D(new FVector((float)Scale3D));
                }
                BGUFunctionLibraryCS.CastMagicallyChangeSkill(character, config, (int)finalId, 10199);

                if (resetBack == true)
                {
                    FieldInfo fieldData = typeof(BUS_MagicallyChangeComp).GetField("MagicallyChangeData", BindingFlags.NonPublic | BindingFlags.Instance);
                    if (fieldData == null) return;
                    BUC_MagicallyChangeData data = fieldData.GetValue(magicChangeComp) as BUC_MagicallyChangeData;
                    if (data == null) return;
                    data.DurMagicallyChange = (bool)resetBack;  // 不变回去，需要手动变回 
                }
                // MyUtils.SetCamera();

            }
            catch (System.Exception ex)
            {
                Log.Error($"bian:{ex?.Message} ");

            }
        }


        public static void CastTranskillByID(BGUPlayerCharacterCS character, int ResId, int MagicSkillID = 0)
        {

            BPS_GSEventCollection bPS_GSEventCollection = BPS_EventCollectionCS.Get((character as BGUPlayerCharacterCS).PlayerState);
            PlayerTransParam playerTransParam = new PlayerTransParam
            {
                TargetResId = ResId,
                SpawnSkillId = (int)MagicSkillID,
                NeedBlend = true
            };
            bPS_GSEventCollection.Evt_TriggerPlayerTransBegin.Invoke(EPlayerTransBeginType.SkillEffect, playerTransParam);
        }

        public static BGWDataAsset_MagicallyChangeConfig? getMagicConfig(BGUCharacterCS character, string bossLabel, string type)
        {

            // !boss_vigorSkillConfigCache.TryGetValue(bossLabel, out var config))
            // BGWDataAsset_MagicallyChangeConfig config;
            // 改为
            string cacheKey = $"{bossLabel}_{type}";
            var config = new BGWDataAsset_MagicallyChangeConfig();
            if (true)
            {

                var magicChangeComp = FindActorCompByClass<BUS_MagicallyChangeComp>(character);
                if (magicChangeComp == null)
                {
                    var player = GetBGUPlayerCharacterCS();
                    magicChangeComp = FindActorCompByClass<BUS_MagicallyChangeComp>(player);
                    if (magicChangeComp == null)
                    {
                        return null;
                    }
                }

                var allModels = LoadUtils.allModels;

                bossModel model = allModels.FirstOrDefault(x => x.Label == bossLabel && x.Type == type);

                if (model == null)
                {
                    return null;
                }
                // UObject defaultObject = UClass.GetClass<BGWDataAsset_MagicallyChangeConfig>().GetDefaultObject();
                // BGWDataAsset_MagicallyChangeConfig val = (BGWDataAsset_MagicallyChangeConfig)(object)((defaultObject is BGWDataAsset_MagicallyChangeConfig) ? defaultObject : null);

                // config = val;

                var BossConf = model.BossConf;
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
                if (BossConf.UnitScale > 0 && BossConf.UnitScale != 1)
                {
                    config.UnitScale = (float)BossConf.UnitScale;
                }
                else
                {
                    config.UnitScale = (float)1.0;

                }

                // 将新加载的配置加入缓存
                // boss_vigorSkillConfigCache[cacheKey] = config;
            }

            return config;
        }
        public static BGWDataAsset_MagicallyChangeConfig? getMagicConfigByModel(BGUPlayerCharacterCS character, bossModel model)
        {

            // !boss_vigorSkillConfigCache.TryGetValue(bossLabel, out var config))
            // BGWDataAsset_MagicallyChangeConfig config;
            // 改为
            var config = new BGWDataAsset_MagicallyChangeConfig();


            var magicChangeComp = FindActorCompByClass<BUS_MagicallyChangeComp>(character);
            if (magicChangeComp == null)
            {
                var player = GetBGUPlayerCharacterCS();
                magicChangeComp = FindActorCompByClass<BUS_MagicallyChangeComp>(player);
                if (magicChangeComp == null)
                {
                    return null;
                }
            }
            if (model == null)
            {
                return null;
            }

            var BossConf = model.BossConf;
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
        public static void CastVigorSkillByModel(BGUCharacterCS character, string bossLabel, string type, int skillId, bool? resetBack = false, int? RecoverSkillID = 10199)
        {
            // 检查缓存中是否已存在该配置

            var magicChangeComp = FindActorCompByClass<BUS_MagicallyChangeComp>(character);
            Log.Info($"bian:{bossLabel} ,type,{type} ,skillId,{skillId},magicChangeComp:{magicChangeComp}");
            if (magicChangeComp == null)
            {
                var player = GetBGUPlayerCharacterCS();
                magicChangeComp = FindActorCompByClass<BUS_MagicallyChangeComp>(player);
                if (magicChangeComp == null)
                {
                    return;
                }
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
            if (resetBack == true)
            {
                data.DurMagicallyChange = (bool)resetBack;  // 不变回去，需要手动变回 
            }
            data.ResetReason = EResetReason_MagicallyChange.Normal;
            data.CastReason = ECastReason_MagicallyChange.NormalSkill;
            data.DurMagicallyChange = true;
            data.RecoverSkillID = 10199;
            isPlayVigorSkillByID = true;
            noResetCombo = true;
            int currentLastSkillID = BGUFuncLibSkillCS.BGUGetLastSkillID(character);
            enterSkillID = currentLastSkillID;
            // BUC_RollData RollData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_RollData>(character);
            // if (RollData != null)
            // {
            //     enterRollData.DodgeStartSkillID = enterSkillID;
            //     enterRollData.CurStateIndex = RollData.CurStateIndex;
            //     enterRollData.RollCombo.Clear();
            //     enterRollData.RollCombo.AddRange(RollData.RollCombo);
            //     enterRollData.RollCombo.Add((int)skillId);
            //     enterRollData.RollComboLoopStartIdx = RollData.RollComboLoopStartIdx;
            //     enterRollData.bCastRollingSkill = RollData.bCastRollingSkill;
            // }
            // Log.Info($"释放精魄技能时的连招信息 CastVigorSkillByModel：CurStateIndex:{RollData?.CurStateIndex}, RollCombo:{string.Join(",", RollData?.RollCombo)}, RollComboLoopStartIdx:{RollData.RollComboLoopStartIdx}, bCastRollingSkill:{RollData.bCastRollingSkill}");
            BGUFunctionLibraryCS.BGUTriggerUnitState(character, EBUStateTrigger.AttackStateBegin, 5000);
            BGUFunctionLibraryCS.BGUTriggerUnitState(character, EBUStateTrigger.EnterVigorKeyCache, 5000);
            DelayExecute(222, () =>
            {
                BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(character);
                bUS_GSEventCollection?.Evt_IncreaseAttrFloat?.Invoke(EBGUAttrFloat.SkillSuperArmor, 10000);
            });
            // 打断当前所有动画
            UGSE_AnimFuncLib.StopAllMontages(character, 0f);
            UGSE_AnimFuncLib.TickAnimationAndRefreshBone(character);
            BGUFunctionLibraryCS.CastMagicallyChangeSkill(character, config, skillId, 10199);
            // MyUtils.SetCamera();
        }

        public static void CastVigorSkillByConfig(BGUPlayerCharacterCS character, BGWDataAsset_MagicallyChangeConfig config, int skillId, bool? resetBack = false, int? RecoverSkillID = 10199)
        {
            // 检查缓存中是否已存在该配置
            var magicChangeComp = GetCachedMagicChangeComp(character);
            if (magicChangeComp == null)
            {
                var player = GetBGUPlayerCharacterCS();
                magicChangeComp = FindActorCompByClass<BUS_MagicallyChangeComp>(player);
                if (magicChangeComp == null)
                {
                    return;
                }
            }
            if (config == null)
            {
                return;
            }

            FieldInfo fieldData = typeof(BUS_MagicallyChangeComp).GetField("MagicallyChangeData", BindingFlags.NonPublic | BindingFlags.Instance);
            if (fieldData == null) return;
            BUC_MagicallyChangeData data = fieldData.GetValue(magicChangeComp) as BUC_MagicallyChangeData;
            if (data == null) return;
            if (resetBack == true)
            {
                DelayExecute(333, () =>
                {
                    BUC_MagicallyChangeData magic_data = fieldData.GetValue(magicChangeComp) as BUC_MagicallyChangeData;
                    if (magic_data != null)
                    {
                        magic_data.DurMagicallyChange = (bool)resetBack;  // 不变回去，需要手动变回 
                    }
                });
            }
            data.ResetReason = EResetReason_MagicallyChange.Normal;
            data.CastReason = ECastReason_MagicallyChange.NormalSkill;
            data.DurMagicallyChange = true;
            data.RecoverSkillID = 10199;
            isPlayVigorSkillByID = true;
            noResetCombo = true;
            DelayExecute(222, () =>
                       {
                           BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(character);
                           bUS_GSEventCollection?.Evt_IncreaseAttrFloat?.Invoke(EBGUAttrFloat.SkillSuperArmor, 10000);
                       });
            // 打断当前所有动画
            UGSE_AnimFuncLib.StopAllMontages(character, 0f);
            UGSE_AnimFuncLib.TickAnimationAndRefreshBone(character);
            BGUFunctionLibraryCS.CastMagicallyChangeSkill(character, config, skillId, 10199);
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
                var player = GetBGUPlayerCharacterCS();
                magicChangeComp = FindActorCompByClass<BUS_MagicallyChangeComp>(player);
                if (magicChangeComp == null)
                {
                    return;
                }
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
            GetBUS_GSEventCollection().Evt_TriggerSkillEffect.Invoke(EffectID, effectInstReq, aActor2);
        }
        private static Dictionary<string, DateTime> _throttleLastExecuteTime = new Dictionary<string, DateTime>();

        public static bool Throttle(string key, int intervalMs)
        {
            DateTime currentTime = DateTime.Now;
            if (_throttleLastExecuteTime.TryGetValue(key, out DateTime lastTime))
            {
                if ((currentTime - lastTime).TotalMilliseconds < intervalMs)
                {
                    return false;
                }
            }
            _throttleLastExecuteTime[key] = currentTime;
            return true;
        }
        public static void autoAttack(int EffectID, float radius)
        {
            if (!auto_attack)
            {
                return;
            }
            TriggerRangeEffect(EffectID, radius);
        }
        public static void TriggerRangeEffect(int EffectID, float radius)
        {

            var character = GetBGUPlayerCharacterCS();
            if (character == null) return;
            List<ABGUCharacter> allActorsOfClassList = getMonsterByDistance(radius);
            if (allActorsOfClassList == null || allActorsOfClassList.Count == 0) return;
            FEffectInstReq fEffectInstReq = new FEffectInstReq(character);
            fEffectInstReq.Attacker = character;
            fEffectInstReq.HitActionDir = EHitActionDir.Default;
            foreach (var actor in allActorsOfClassList)
            {
                fEffectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(actor);
                fEffectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(actor);
                FEffectInstReq effectInstReq = fEffectInstReq;
                GetBUS_GSEventCollection().Evt_TriggerSkillEffect.Invoke(EffectID, effectInstReq, actor);
            }
        }

        public static void TriggerRangeBuff(int buffID, float radius)
        {

            var character = GetBGUPlayerCharacterCS();
            if (character == null) return;
            List<ABGUCharacter> allActorsOfClassList = getMonsterByDistance(radius);
            if (allActorsOfClassList == null || allActorsOfClassList.Count == 0) return;

            foreach (var actor in allActorsOfClassList)
            {
                BGUFunctionLibraryCS.BGUAddBuff(character, actor, buffID, EBuffSourceType.Default, 0);
            }
        }
        public static FCalliopeGuid getGUid()
        {
            return (FCalliopeGuid)summonGuid;
        }

        public static void SummonReq(Int64 SummonID, Int64 SummonCount, int SummonAliveTime = 12, int? skillID = 0)
        {
            var character = GetBGUPlayerCharacterCS();

            if (SummonCount < 1)
            {
                SummonCount = 1;
            }

            FSummonReq fSummonReq = default(FSummonReq);
            fSummonReq.SummonType = ESummonType.MonsterSpawn;
            summonGuid = GameplayTagExtension.ConvertToCalliopeGuid(Guid.NewGuid());
            fSummonReq.SummonGuid = (FCalliopeGuid)summonGuid;
            fSummonReq.SummonID = (Int32)SummonID;
            fSummonReq.SpawnConfigWrap = FSummonSpawnConfigWrap.WrapSpawnConfig_BySummonCommDesc((Int32)SummonID, character);
            fSummonReq.SpawnConfigWrap.SummonAliveTime = SummonAliveTime;
            fSummonReq.SpawnConfigWrap.DestroyDelayTime = 0;
            // fSummonReq.SpawnConfigWrap.SpawnBirthBuff = [888666002];
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


            fSummonReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(character);

            FSummonReq inSummonReq = fSummonReq;
            BPS_EventCollectionCS.GetLocal(character).Evt_RequestSummon.Invoke(inSummonReq);
        }
        public static void newSummonReq(RuleAction? action)
        {
            var character = Helper.GetBGUPlayerCharacterCS();
            var SummonCount = action?.SummonCount ?? 1;
            var SummonID = action?.SummonID;
            var skillID = action?.SkillID;
            var SummonAliveTime = action?.SummonAliveTime ?? -1f;
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
            if (action?.IsSummonerAsMaster != null)
            {
                fSummonReq.SpawnConfigWrap.IsSummonerAsMaster = (bool)action.IsSummonerAsMaster;
            }
            if (action?.DisappearMontagePathList != null)
            {
                fSummonReq.SpawnConfigWrap.DisappearMontagePathList.Clear();
                fSummonReq.SpawnConfigWrap.DisappearMontagePathList.AddRange(action.DisappearMontagePathList);
            }



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
            // fSummonReq.bTeleportSelf = false;
            // fSummonReq.EffectCaster = null;
            // fSummonReq.BuffOwner = null;

            // fSummonReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(character);

            FSummonReq inSummonReq = fSummonReq;
            BPS_EventCollectionCS.GetLocal(character).Evt_RequestSummon.Invoke(inSummonReq);
        }

        public static BGWDataAsset_ProjectileSpawnConfig getBGWDataAsset_ProjectileSpawnConfig(string path, AActor character)
        {
            return BGW_PreloadAssetMgr.Get(character).TryGetCachedResourceObj<BGWDataAsset_ProjectileSpawnConfig>(path, ELoadResourceType.SyncLoadAndCache);

        }
        public static void SpawnProjectile(AActor character, string path, int projectileID = 0, bool forTarget = false, int bulletCount = 1, bool isRandom = false, FVector offset = default(FVector), RuleAction? action = null)
        {
            BGWDataAsset_ProjectileSpawnConfig bGWDataAsset_ProjectileSpawnConfig = getBGWDataAsset_ProjectileSpawnConfig(path, character);
            if (bGWDataAsset_ProjectileSpawnConfig == null)
            {
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
            if (forTarget && target != null && !isShotBull)
            {
                aActor = target;
            }
            bool attackTarget = action?.attackTarget != null && action.attackTarget;
            if (attackTarget && target != null && !isShotBull)
            {
                aActor = target;
            }
            FEffectInstReq fEffectInstReq = default(FEffectInstReq);

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
                FGSProjecttileObjSpawnNSInfo ProjectileSpawnNSInfo = new FGSProjecttileObjSpawnNSInfo
                {
                    ProjectileType = EProjectileType.Bullet,
                    BuffIDList = bGWDataAsset_ProjectileSpawnConfig.BuffIDList.ToList(),
                    ProjectileID = projectileID,
                    SpawnWave = bGWDataAsset_ProjectileSpawnConfig.ProjectileWave,
                    SpawnNumPerWave = bulletCount
                };

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

                if (action?.targetBaseSocketName != null)
                {
                    targetBase.SocketName = (FName)(action.targetBaseSocketName);
                }
                if (action?.spawnBaseSocketName != null)
                {
                    spawnBase.UseSocket = true;
                    spawnBase.SocketName = (FName)(action?.spawnBaseSocketName);
                }
                offsetInfo.PosOffsetType = ProjectilePosOffsetType.Normal;
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

                    Log.Info($"offset.X:{offset.X} offset.Y:{offset.Y} offset.Z:{offset.Z}");
                    // var fVector = new FVector(offset.X, offset.Y, offset.Z);
                    // offsetInfo.PosOffset = fVector;
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
                ProjectileSpawnNSInfo.InitSpawnInfo(spawnBase, offsetInfo, none_target, bGWDataAsset_ProjectileSpawnConfig.SpawnBase_NoneTarget, bGWDataAsset_ProjectileSpawnConfig.SpawnPosOffsetInfo_NoneTarget, character, aActor, character, null, in fEffectInstReq);
                ProjectileSpawnNSInfo.AttachToSpawnBase = bGWDataAsset_ProjectileSpawnConfig.AttachToSpawnBase;
                ProjectileSpawnNSInfo.AttachRule_Rot = bGWDataAsset_ProjectileSpawnConfig.AttachRule_Rot;
                ProjectileSpawnNSInfo.InitTargetInfo(targetBase, bGWDataAsset_ProjectileSpawnConfig.TargetPosOffsetInfo, bGWDataAsset_ProjectileSpawnConfig.bEnableTargetBase_NoneTarget, bGWDataAsset_ProjectileSpawnConfig.TargetBase_NoneTarget, bGWDataAsset_ProjectileSpawnConfig.TargetPosOffsetInfo_NoneTarget, character, aActor, character, null, in fEffectInstReq);
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
                }
                if (action?.SpeedLeftValue > 0)
                {
                    ProjectileSpawnNSInfo.ProjectileFlySpd.Spd.LeftValue = action.SpeedLeftValue;
                }
                if (action?.SpeedRightValue > 0)
                {
                    ProjectileSpawnNSInfo.ProjectileFlySpd.Spd.RightValue = action.SpeedRightValue;
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
                ProjectileSpawnNSInfo.MontageID = -2;
                ProjectileSpawnNSInfo.ANSTotalTime = 0;
                ProjectileSpawnNSInfo.SpawnWaveDuration = (ProjectileSpawnNSInfo.SpawnWaveDuration = ((ProjectileSpawnNSInfo.SpawnWave > 1) ? (ProjectileSpawnNSInfo.ANSTotalTime / (float)(ProjectileSpawnNSInfo.SpawnWave - 1)) : 0f));
                ProjectileSpawnNSInfo.SpawnCounter = 0;
                ProjectileSpawnNSInfo.SpawnWaveCounter = 0;
                ProjectileSpawnNSInfo.bEnableMultiTargetMode = bGWDataAsset_ProjectileSpawnConfig.bEnableMultiTargetMode;
                ProjectileSpawnNSInfo.MutilTargetRule = bGWDataAsset_ProjectileSpawnConfig.MutilTargetRule;
                bUS_GSEventCollection.Evt_OnNotifyStateSpawnProjectileObj.Invoke(ref ProjectileSpawnNSInfo);
            }
        }
        public static bool CheckConditions(AActor caster, string conditions)
        {
            // conditions:hasAnyBuff:1001,1002,1003;no_hasAnyBuff:2001,2002;hasAnyTalent:3001,3002;no_hasAnyTalent:4001;last_skill_id:5001;stance:StancePoke

            if (string.IsNullOrEmpty(conditions))
                return true;

            string[] conditionList = conditions.Split(';');
            foreach (string condition in conditionList)
            {
                string trimmedCondition = condition.Trim();
                if (string.IsNullOrEmpty(trimmedCondition))
                    continue;

                if (trimmedCondition.Contains("hasAnyBuff:"))
                {
                    string buffString = trimmedCondition.Replace("hasAnyBuff:", "");
                    var hasAnyBuff = buffString.Split(',')
                        .Select(id => int.TryParse(id, out int buffId) ? buffId : 0)
                        .Any(buffId => buffId != 0 && BGUFunctionLibraryCS.BGUHasBuffByID(caster, buffId));

                    if (!hasAnyBuff) return false;
                }
                else if (trimmedCondition.Contains("no_hasAnyBuff:"))
                {
                    string buffString = trimmedCondition.Replace("no_hasAnyBuff:", "");
                    var hasAnyBuff = buffString.Split(',')
                        .Select(id => int.TryParse(id, out int buffId) ? buffId : 0)
                        .Any(buffId => buffId != 0 && BGUFunctionLibraryCS.BGUHasBuffByID(caster, buffId));

                    if (hasAnyBuff) return false;
                }
                else if (trimmedCondition.Contains("hasAnyTalent:"))
                {
                    string talentString = trimmedCondition.Replace("hasAnyTalent:", "");
                    var hasAnyTalent = talentString.Split(',')
                        .Select(id => int.TryParse(id, out int talentId) ? talentId : 0)
                        .Any(talentId => talentId != 0 && BGUFunctionLibraryCS.BGUHasTalentByID(caster, talentId));

                    if (!hasAnyTalent) return false;
                }
                else if (trimmedCondition.Contains("no_hasAnyTalent:"))
                {
                    string talentString = trimmedCondition.Replace("no_hasAnyTalent:", "");
                    var hasAnyTalent = talentString.Split(',')
                        .Select(id => int.TryParse(id, out int talentId) ? talentId : 0)
                        .Any(talentId => talentId != 0 && BGUFunctionLibraryCS.BGUHasTalentByID(caster, talentId));

                    if (hasAnyTalent) return false;
                }
                else if (trimmedCondition.Contains("last_skill_id:"))
                {
                    string lastSkillIDString = trimmedCondition.Replace("last_skill_id:", "");
                    if (int.TryParse(lastSkillIDString, out int lastSkillID))
                    {
                        int currentLastSkillID = BGUFuncLibSkillCS.BGUGetLastSkillID(caster);
                        if (currentLastSkillID != lastSkillID) return false;
                    }
                }
                else if (trimmedCondition.Contains("stance:"))
                {
                    string stanceString = trimmedCondition.Replace("stance:", "");
                    var player = caster as APlayerController;
                    if (player == null) return false;

                    var readOnlyData = BGU_DataUtil.GetPlayerControlReadonlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(player);
                    if (readOnlyData == null) return false;
                    var stance = readOnlyData.RoleData?.RoleCs?.Actor?.Wear?.Stance;//当前棍法
                                                                                    // StancePoke StanceProp StanceHeavy
                    if (stanceString.Contains(stance.ToString())) return false;
                }
            }
            return true;
        }




        // 改进后
        public static void SpawnProjectileByEffect(FUStSkillEffectDesc skillEffectDesc, AActor Caster, AActor Target, FEffectInstReq EffectInstReq)
        {
            if (skillEffectDesc.EffectParamsStr.Count < 2) return;
            if (!skillEffectDesc.EffectParamsStr[1].Contains("bullet")) return;

            // 检查条件
            if (skillEffectDesc.EffectParamsStr[2].Contains("conditions:"))
            {
                string conditions = skillEffectDesc.EffectParamsStr[2].Replace("conditions:", "");
                if (!CheckConditions(Caster, conditions)) return;
            }

            string path = skillEffectDesc.EffectParamsStr[3];
            // 从EffectParams获取参数
            int projectileID = skillEffectDesc.EffectParamsInt[0];
            int bulletCount = skillEffectDesc.EffectParamsInt[1];
            bool forTarget = skillEffectDesc.EffectParamsInt[2] == 1;
            bool isRandom = skillEffectDesc.EffectParamsInt[3] == 3;
            int PosOffsetType = skillEffectDesc.EffectParamsInt[3];//ProjectilePosOffsetType:0 None,1 Normal,2 RangeOffset,3 RandomOffset
            int ProjectileFlySpd = skillEffectDesc.EffectParamsInt[4]; //ProjectileFlySpd
            int ProjectileRotSpd = skillEffectDesc.EffectParamsInt[5];//ProjectileRotSpd
                                                                      // 获取位置偏移
            float posX = skillEffectDesc.EffectParamsFloat[0];
            float posY = skillEffectDesc.EffectParamsFloat[1];
            float posZ = skillEffectDesc.EffectParamsFloat[2];


            float BornOffsetX = skillEffectDesc.EffectParamsFloat[3];//BornOffsetX
            float BornOffsetY = skillEffectDesc.EffectParamsFloat[4];//BornOffsetY
            float BornOffsetZ = skillEffectDesc.EffectParamsFloat[5];//BornOffsetZ
            var offset = new FVector(posX, posY, posZ);

            // 创建RuleAction来传递EffectInstReq
            var action = new RuleAction
            {
                Caster = Caster,
                Target = Target,
                EffectInstReq = EffectInstReq,
                BornDirOffsetXLeftValue = (int)BornOffsetX,
                BornDirOffsetXRightValue = (int)BornOffsetX,
                BornDirOffsetYLeftValue = (int)BornOffsetY,
                BornDirOffsetYRightValue = (int)BornOffsetY,
                BornDirOffsetZLeftValue = (int)BornOffsetZ,
                BornDirOffsetZRightValue = (int)BornOffsetZ,
                SpeedLeftValue = ProjectileFlySpd,
                SpeedRightValue = ProjectileFlySpd,


            };
            var projectileIDs = new[] { projectileID };

            if (skillEffectDesc.EffectParamsStr[1].Contains("bullet_ids:"))
            {
                // "bullet_ids:141,142,1888"
                string projectileString = skillEffectDesc.EffectParamsStr[1].Replace("bullet_ids:", "");
                projectileIDs = projectileString.Split(',').Select(int.Parse).ToArray();

            }
            // 调用SpawnProjectile
            foreach (var ID in projectileIDs)
            {
                SpawnProjectile(GetBGUPlayerCharacterCS(), path, ID, forTarget, bulletCount, isRandom, offset, action);

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
        public static void changeAllActorTarget(bool? changeToPlayerTeam)
        {
            var player = GetBGUPlayerCharacterCS();
            var target = BGUFunctionLibraryCS.BGUGetTarget(player) as BGUCharacterCS;
            if (target == null) return;
            List<ABGUCharacter> allActorsOfClassList = getMonsterByDistance(2000);
            if (allActorsOfClassList == null || allActorsOfClassList.Count == 0) return;
            foreach (BGUCharacterCS item in allActorsOfClassList)
            {
                if (target != null && item.PathName != target.PathName && item.PathName != player.PathName)
                {
                    BUS_EventCollectionCS.Get((AActor)(object)item).Evt_AICatchTarget.Invoke(target, ETargetSourceType.Target_BirthCatchSummonerTarget, false);
                    if (changeToPlayerTeam == true)
                    {
                        //己方霸体不吃毒火冰
                        BGUFunctionLibraryCS.BGUAddBuff(item, item, 888666002, EBuffSourceType.GM, -1);

                        item.SetTeamIDInCS(player.GetTeamIDInCS());//设置怪物为玩家队伍
                    }
                }
            }

        }


        // 除了目标角色其他都变成己方的人
        public static void ChangeEmenyTarget()
        {
            List<ABGUCharacter> allActorsOfClassList = getMonsterByDistance(2000);

            if (allActorsOfClassList == null || allActorsOfClassList.Count == 0) return;
            var character = GetBGUPlayerCharacterCS();
            var target = BGUFunctionLibraryCS.BGUGetTarget(character) as BGUCharacterCS;
            foreach (BGUCharacterCS item in allActorsOfClassList)
            {
                if (item == null || item?.GetFullName() == null)
                {
                    continue;
                }
                var teamId = BGU_DataUtil.GetActorTeamID(GetBGUPlayerCharacterCS());
                if (BGU_DataUtil.GetActorTeamID(item) != teamId && item.PathName != target?.PathName)
                {
                    if (target != null)
                    {
                        BUS_EventCollectionCS.Get((AActor)(object)item).Evt_AICatchTarget.Invoke(target, ETargetSourceType.Target_BirthCatchSummonerTarget, false);
                    }
                    item.SetTeamIDInCS(teamId);//设置怪物为玩家队伍
                    return;
                }
            }
        }
        /// <param name="MaxDistance">最大搜索距离，默认为6000单位</param>
        /// <returns>返回一个包含在指定距离内所有怪物角色的列表</returns>
        public static List<ABGUCharacter> getMonsterByDistance(float MaxDistance = 6000)
        {
            var play = GetBGUPlayerCharacterCS();
            UBGUSelectUtil.SphereOverlapBGUCharacters(play, BGUFuncLibActorTransformCS.BGUGetActorLocation(play), MaxDistance, out var OutArray);
            return OutArray;
        }

        public static void trans_back()
        {
            var play = GetBGUPlayerCharacterCS();
            BUS_EventCollectionCS.Get(play).Evt_TransBackSpawnNewOne.Invoke(0, 0, false, EPlayerTransEndType.SkillEffect);
        }

        public static void trans_new_one()
        {
            var play = GetBGUPlayerCharacterCS();
            BUS_EventCollectionCS.Get(play).Evt_TransBackSpawnNewOne.Invoke(0, 0, false, EPlayerTransEndType.SkillEffect);
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

                    var atk = BGUFunctionLibraryCS.GetAttrValue(item, EBGUAttrFloat.Atk) + 50;
                    BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.Atk, atk);

                    var maxHp = BGUFunctionLibraryCS.GetAttrValue(item, EBGUAttrFloat.HpMax);
                    BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.HpMax, maxHp);
                    BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.Hp, maxHp);
                }
                else
                {

                    var maxHp = BGUFunctionLibraryCS.GetAttrValue(item, EBGUAttrFloat.HpMax);
                    if (maxHp < 10000 * 150)
                    {
                        BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.HpMax, maxHp + 500);
                        BGUFunctionLibraryCS.BGUAddBuff(item, item, 888666003, EBuffSourceType.GM, -1);
                    }
                    var atk = BGUFunctionLibraryCS.GetAttrValue(item, EBGUAttrFloat.Atk) + 20;
                    if (atk < 1000)
                    {
                        BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.Atk, atk);
                    }

                    BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.HpMax, maxHp + 500);
                    BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.BurnDef, 0);
                    BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.ThunderDef, 0);
                    BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.PoisonDef, 0);
                    BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.FreezeDef, 0);
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

                    BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.ImmueDamage, true);
                    BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.ImmueStiff, true);
                    BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.ImmueImmobilizing, true);
                    BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.CantBeSweepChecked, true);
                    BGUFunctionLibraryCS.BGUSetUnitSimpleState(item, EBGUSimpleState.CantBeLock, true);

                    Task.Run(async delegate
                    {
                        await Task.Delay(100);
                        Utils.TryRunOnGameThread((Action)delegate
                        {
                            BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.Hp, BGUFunctionLibraryCS.GetAttrValue(item, EBGUAttrFloat.HpMax));
                        });
                    });
                }
            }


        }

        // 把附近的敌人的目标全部转为锁定的目标
        public static void change_target()
        {
            var play = GetBGUPlayerCharacterCS();
            if (play == null || play.World == null) return;
            var target = BGUFunctionLibraryCS.BGUGetTarget(play) as BGUCharacterCS;
            if (target != null)
            {
                var enemies = getMonsterByDistance(2000);
                if (enemies == null || enemies.Count == 0) return;
                // var TargetInfo = new UnitLockTargetInfo(nearPlayer, ETargetSourceType.None, ELockTargetWayType.Auto);
                foreach (var enemy in enemies)
                {
                    // 跳过同一队伍的角色
                    if (BGU_DataUtil.GetActorTeamID(enemy) == 1)
                        continue;


                    BGUFunctionLibraryCS.BGUSetTargetInfo(false, (AActor)(object)enemy, new UnitLockTargetInfo((AActor)(object)target, ETargetSourceType.Target_ByTaunter, ELockTargetWayType.Manual, "", ""));
                    // var busEvent = BUS_EventCollectionCS.Get(enemy);
                    // busEvent?.Evt_ClearAllTarget.Invoke();
                    // busEvent?.Evt_ClearCameraLock.Invoke();
                    // busEvent?.Evt_SetCanSetTargetByHatred.Invoke(true);
                    // busEvent?.Evt_SetTargetInfo.Invoke(TargetInfo);
                    // busEvent?.Evt_CameraLockTarget.Invoke(new UnitLockTargetInfo(nearPlayer, ETargetSourceType.Target_ForceCameraLock, ELockTargetWayType.Manual, "", ""));
                    // busEvent?.Evt_AICatchTarget.Invoke(nearPlayer, ETargetSourceType.CameraLockUpdate, true);
                }

            }
        }
        public static void WeakMonster()
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

                    if (item.GetFullName() != play.GetFullName())
                    {
                        BGUFunctionLibraryCS.BGUAddBuff(item, item, 888666002, EBuffSourceType.GM, -1);
                        continue;
                    }
                    continue;
                }
                var atk = BGUFunctionLibraryCS.GetAttrValue(item, EBGUAttrFloat.Atk);
                if (atk > 10)
                {
                    BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.Atk, atk - 1);
                }
                var maxHp = BGUFunctionLibraryCS.GetAttrValue(item, EBGUAttrFloat.HpMax);
                if (maxHp > 500)
                {
                    BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.HpMax, maxHp - 10);
                }
                BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.BurnDef, 0);
                BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.ThunderDef, 0);
                BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.PoisonDef, 0);
                BGUFunctionLibraryCS.BGUSetAttrValue(item, EBGUAttrFloat.FreezeDef, 0);
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
            actorLocation.X -= 500;
            actorLocation.Y -= 500;
            FRotator fRotator2 = play.GetActorRotation();

            var list = getAllSunmon(10);

            foreach (BGUCharacterCS item in list)
            {

                if (item.CanBeDamaged)
                {
                    item.Teleport(actorLocation, fRotator2);
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
            SummonReq(1001103, 1, 3, skillID);
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
            if (character == null) return;
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


        public static void ExportAllActors()
        {
            // 获取所有Actor并导出为JSON
            ABGUCharacter[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<ABGUCharacter>(GetWorld());
            var actorDataList = new List<object>();

            foreach (AActor actor in allActorsOfClass)
            {
                if (actor.PathName != null)
                {
                    actorDataList.Add(new
                    {
                        PathName = actor.PathName,
                        ClassPathName = actor.GetClass().PathName,
                        Location = actor.GetActorLocation(),
                        Rotation = actor.GetActorRotation(),
                        Scale = actor.GetActorScale3D()
                    });
                }
            }

            // 创建导出目录
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string exportPath = Path.Combine(currentDirectory, @"CSharpLoader\Mods\bian\ActorsOfClass");
            Directory.CreateDirectory(exportPath);

            string json = JsonConvert.SerializeObject(actorDataList, Formatting.Indented);

            string filePath = Path.Combine(exportPath, $"export_{DateTime.Now:yyyyMMdd_HHmmss}.json");
            File.WriteAllText(filePath, json);
        }



        public static ITransable? ExportTamer(BGUCharacterCS actor)
        {
            // LoadUtils.ExportDataToJson<ShopItemGroupDesc>("shopdesc");
            // LoadUtils.ExportDataToJson<FUStBuffDispDesc>("buffdisp");
            // LoadUtils.ExportDataToJson<FUStSummonCommDesc>("FUStSummonCommDesc");
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
                model.AttrFloat = new Dictionary<string, float>();

                // 遍历所有EBGUAttrFloat属性
                foreach (EBGUAttrFloat attrType in Enum.GetValues(typeof(EBGUAttrFloat)))
                {
                    if (attrType == EBGUAttrFloat.None || attrType == EBGUAttrFloat.EnumMax)
                        continue;
                    model.AttrFloat[attrType.ToString()] = BGUFunctionLibraryCS.GetAttrValue(actor, attrType);
                }

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

                    TArrayUnsafe<UActorComponent> tfxComps = aCharacter.GetComponentsByClass(UClass.GetClass<UTressFXComponent>());
                    TArrayUnsafe<UActorComponent> childComp = aCharacter.GetComponentsByClass(UClass.GetClass<UChildActorComponent>());

                    for (int i = 0; i < childComp?.Count; i++)
                    {
                        UChildActorComponent uChildActorComponent = childComp[i] as UChildActorComponent;
                        if (!uChildActorComponent.ChildActor.IsNullOrDestroyed())
                        {
                            TArrayUnsafe<UActorComponent> componentsByClass5 = uChildActorComponent.ChildActor.GetComponentsByClass(UClass.GetClass<UTressFXComponent>());
                            for (int j = 0; j < componentsByClass5.Count; j++)
                            {
                                tfxComps.Add(componentsByClass5[j]);
                            }
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
                        skill.AnimPath = BG_ProtobufDataAPI<FUStSkillSDesc>.Get().FindByID(ID)?.TemplatePath;
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
        public static bossModel? getActorModel(BGUCharacterCS actor)
        {
            // LoadUtils.ExportDataToJson<ShopItemGroupDesc>("shopdesc");
            // LoadUtils.ExportDataToJson<FUStBuffDispDesc>("buffdisp");
            // LoadUtils.ExportDataToJson<FUStSkillSDesc>("skill");
            if (actor != null)
            {
                BUTamerActor tM = actor.GetTamerOwner() as BUTamerActor;
                if (tM == null)
                {
                    return null;
                }

                var allSkillIDs = BGUFuncLibAICS.BGUGetUnitAllSkillID(actor);

                var model = new bossModel();
                model.BossConf = new BossConfig();


                try
                {
                    ACharacter aCharacter = tM.GetMonster() as ACharacter;
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
                            model.BossConf.Weapons.Add(weaponConfig);
                        }
                    }

                    TArrayUnsafe<UActorComponent> tfxComps = aCharacter.GetComponentsByClass(UClass.GetClass<UTressFXComponent>());
                    TArrayUnsafe<UActorComponent> childComp = aCharacter.GetComponentsByClass(UClass.GetClass<UChildActorComponent>());

                    for (int i = 0; i < childComp?.Count; i++)
                    {
                        UChildActorComponent uChildActorComponent = childComp[i] as UChildActorComponent;
                        if (!uChildActorComponent.ChildActor.IsNullOrDestroyed())
                        {
                            TArrayUnsafe<UActorComponent> componentsByClass5 = uChildActorComponent.ChildActor.GetComponentsByClass(UClass.GetClass<UTressFXComponent>());
                            for (int j = 0; j < componentsByClass5.Count; j++)
                            {
                                tfxComps.Add(componentsByClass5[j]);
                            }
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
                        skill.AnimPath = BG_ProtobufDataAPI<FUStSkillSDesc>.Get().FindByID(ID)?.TemplatePath;
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


        public static void addJXSQBuffs(BGUCharacterCS actor)
        {
            List<int> buffs = [118, 119, 122, 123, 1056, 1059, 2093];
            foreach (int buffID in buffs)
            {
                if (!BGUFunctionLibraryCS.BGUHasBuffByID(actor, buffID))
                {
                    BGUFunctionLibraryCS.BGUAddBuff(actor, actor, buffID, EBuffSourceType.PhantomRush, 10000);
                }
            }
        }
        // 完美闪避变成jxsq
        public static void changeDodgeSkill(BGUCharacterCS actor, string montageName)
        {
            if (actor == null) return;
            Log.Info($"bian: changeDodgeSkill montageName:{montageName}");
            DelayExecute(700, () =>
            {
                try
                {
                    // 再次检查 actor 是否有效
                    if (actor == null) return;
                    BUS_GSEventCollection val = BUS_EventCollectionCS.Get(actor);
                    if (val == null) return;
                    val.Evt_RequestSmartCastSkill.Invoke(10095, null, EMontageBindReason.NormalSkill, true);
                }
                catch (Exception ex)
                {
                    Log.Error($"Error in changeDodgeSkill: {ex.Message}");
                }
            });
        }
        public static void export_json()
        {
            LoadUtils.ExportDataToJson<FUStSummonCommDesc>("sumData");
        }
        public static void doPhantomRushSkill(BGUCharacterCS actor, string direction)
        {
            ESkillDirection phantomRushDir = ESkillDirection.None;
            Log.Info($"bian: doPhantomRushSkill direction:{direction}");
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
            Log.Info($"bian: gain_item ItemID:{ItemID}, ItemCount:{ItemCount},{PlayerMgr?.GetType()}");
            PlayerMgr.Bag.GainItemOne(new ItemOne
            {
                Id = ItemID,
                Num = ItemCount
            });
            PlayerMgr.Commit();
        }
        public static void addAllTaskItem()
        {
            int num = 1;
            TBItemDesc tBItemDesc = GameDBRuntime.GetTBItemDesc();
            var PlayerMgr = getPlayerMgr();
            for (int i = 0; i < tBItemDesc.List.Count; i++)
            {
                ItemDesc val = tBItemDesc.List[i];
                if ((int)val.ItemType == 5)
                {
                    MsgErrCode val2 = PlayerMgr.Bag.GainItemOne(new ItemOne
                    {
                        Id = val.Id,
                        Num = num
                    });
                    if ((int)val2 > 0)
                    {
                        SysLogUtil.GAME_PLAYER.LogError($"GainItemOne Failed, Id:{val.Id}, Num:{1}");
                    }
                }
            }
            PlayerMgr.Commit();
        }

        public static void charge_skill_end()
        {
            DelayExecute(10, () =>
              {
                  var BUSEventCollection = BUS_EventCollectionCS.Get(GetControlledPawn());
                  if (BUSEventCollection != null)
                  {
                      BUSEventCollection.Evt_TriggerChargeSkillNextStageEvent.Invoke(EChargeSkillEndEventType.ChargeEnd);
                      BUSEventCollection.Evt_ComboGraphReset.Invoke();
                  }
              });
        }
        public static void change_to_dasheng(int? time = 999)
        {
            var Owner = GetControlledPawn();
            if (Owner != null)
            {
                FUStTransQiTianDaShengConfigDesc transQiTianDaShengConfigDesc = BGW_GameDB.GetTransQiTianDaShengConfigDesc(1, Owner);
                transQiTianDaShengConfigDesc.Duration = time ?? 999;
                BUS_GSEventCollection obj = BUS_EventCollectionCS.Get(Owner);

                var player = MyUtils.GetControlledPawn();

                if (obj != null && player != null)
                {
                    obj.Evt_TriggerTrans2DaSheng.Invoke();
                    BGUFunctionLibraryCS.BGUSetAttrValue(player, EBGUAttrFloat.Pevalue, 480f);
                }
            }
        }

        public static void ClearAllAbnormal(BGUPlayerCharacterCS character, List<int> clearTypes)
        {
            BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(character);
            if (bUS_GSEventCollection == null || clearTypes == null)
            {
                return;
            }
            HashSet<EAbnormalStateType> hashSet = new HashSet<EAbnormalStateType>();
            foreach (int item2 in clearTypes)
            {
                EAbnormalStateType item = (EAbnormalStateType)item2;
                hashSet.Add(item);
            }
            bUS_GSEventCollection.Evt_ClearAbnormalState.Invoke(hashSet);
        }

        public static void show_shop()
        {
            // 打开默认商店
            GenARoleMain.SetShowTabScene(ERoleScene.Role, "ShowShop");
            if (!GSG.IsPlayerReady())
            {
                return;
            }
            var world = GetWorld();
            GSUIPage gSUIPage = GSG.GSPageOP.FindUIPage((int)(EUIPageID.Shop));
            if (gSUIPage == null || world == null || !gSUIPage.IsActiveShowing())
            {
                int result = 1000;
                var ShopID = GSB1UIUtil.GetCurShopID(world);
                if (ShopID > 0)
                {
                    GenAShop.SetShopId(ShopID, "OpenShop");
                }
                // 打开默认商店
                foreach (InteractionFuncDesc item in GameDBRuntime.GetTBInteractionFuncDesc().List)
                {
                    if (item.MenuBtnActionType == EMenuBtnActionType.ShopBuy)
                    {
                        GSB1UIUtil.OpenShop(item.Id, world, result);
                        return;
                    }
                }
            }
        }
        public static void fuhuo_ui()
        {
            // 打开复活点UI
            if (!GSG.IsPlayerReady())
            {
                return;
            }
            GenAGPage.ShowPage(7, "ActiveShrineUI");
        }
        public static void gc_one()
        {
            UObject.CollectGarbage();
            GC.Collect();
        }

        public static void projectileScale(int ProjectileID, FVector? fVector)
        {
            var Character = Helper.GetBGUPlayerCharacterCS();
            var bGUProjectileBaseActor = BGUFuncLibProjectile.GetCtrProjectileByID(Character, ProjectileID) as BGUProjectileBaseActor;
            if (bGUProjectileBaseActor == null)
            {
                return;
            }

            // 获取原始缩放值
            var scaleBase = bGUProjectileBaseActor.GetActorScale3D();
            if (scaleBase == null)
            {
                return;
            }

            // 应用新的缩放到Actor
            FTransform newTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(bGUProjectileBaseActor);
            if (fVector == null)
            {
                fVector = new FVector(5f, 5f, 1);
            }
            newTransform.SetScale3D((FVector)(scaleBase * fVector));
            BGUFuncLibActorTransformCS.BGUSetActorTransform(bGUProjectileBaseActor, newTransform, bSweep: false, bTeleport: false);
            BUC_ProjectileBasicData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ProjectileBasicData>(bGUProjectileBaseActor);
            // 根据碰撞体类型更新碰撞体大小
            UPrimitiveComponent collisionComponent = null;
            switch (readOnlyData.CheckShapeType)
            {
                case EProjectileCheckShapeType.BoxShape:
                    collisionComponent = bGUProjectileBaseActor.GetBoxCollisionComp();
                    break;
                case EProjectileCheckShapeType.CapsuleShape:
                    collisionComponent = bGUProjectileBaseActor.GetCapsuleCollisionComp();
                    break;
                case EProjectileCheckShapeType.SphereShape:
                    collisionComponent = bGUProjectileBaseActor.GetSphereCollisionComp();
                    break;
                case EProjectileCheckShapeType.CustomShape:
                    collisionComponent = bGUProjectileBaseActor.GetCustomCollisionComp();
                    break;
            }

            // 更新碰撞体缩放
            if (collisionComponent != null)
            {
                var originalScale = collisionComponent.RelativeScale3D;
                if (ProjectileID == 146)
                {
                    fVector = new FVector(5f, 5f, 5f);
                }
                collisionComponent.SetRelativeScale3D((FVector)(originalScale * fVector));
            }
        }
        public static void show_duiyou()
        {
            // 展示队友信息UI
            var world = GetWorld();
            if (world == null) return;
            GenAGPage.ShowPage(4, "ActiveTeamPlayerUI", ChangeReason.UiInit);

            BGS_EventCollectionCS.Get(world)?.Evt_BGS_GMInitTeam.Invoke();
        }

        public static void close_duiyou()
        {
            // 关闭队友信息UI
            GenAGPage.FadeOutPage(4, "ActiveTeamPlayerUI", ChangeReason.UiInit);
        }

        public static void enter_main()
        {
            // 展示队友信息UI
            var world = GetWorld();
            if (world == null) return;
            BGW_EventCollection.Get(world).Evt_EnterMainMenu();
        }

        // 打印投影UI（血条、玩家名字等）相关数据
        public static int LogProjInfo()
        {
            foreach (object @object in UObject.GetObjects<BUI_BattleInfoCS>())
            {
                BUI_BattleInfoCS bUI_BattleInfoCS = @object as BUI_BattleInfoCS;
                if (!bUI_BattleInfoCS.IsNullOrDestroyed())
                {
                    BGW_LogUtil.LogError(bUI_BattleInfoCS.LogProjStat() ?? "");
                }
            }
            return 0;
        }

        // 切换小地图
        public static int SwitchMap()
        {
            var pageID = (int)(EUIPageID.DebugMap);
            if (GSG.GSPageOP.FindUIPage(pageID) != null)
            {
                GenAGPage.FadeOutPage(pageID, "SwitchMap");
            }
            else
            {
                GenAGPage.ShowPage(pageID, "SwitchMap");
            }
            return 0;
        }

        public static void AttackFeedbackPerform(string hitFXPath, AActor Victim, int SkillEffectID, FEffectInstReq EffectInstReq)
        {
            if (hitFXPath == null) return;
            var bGUCharacterCS = GetBGUPlayerCharacterCS();
            if (bGUCharacterCS == null) return;
            // UObject uObject = BGW_PreloadAssetMgr.Get(bGUCharacterCS).TryGetCachedResourceObj<UObject>(hitFXPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Low);

            // Log.Info($"AttackFeedbackPerform uObject:{uObject?.GetFullName()}");
            // UParticleSystem? uParticleSystem = null;
            // UNiagaraSystem? uNiagaraSystem = null;
            // if (uObject != null)
            // {
            //     uParticleSystem = uObject as UParticleSystem;
            //     if (uParticleSystem == null)
            //     {
            //         uNiagaraSystem = uObject as UNiagaraSystem;
            //     }
            // }
            BGUCharacterCS bGUCharacterCS2 = Victim as BGUCharacterCS;
            if (bGUCharacterCS2 == null)
            {
                return;
            }
            FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(SkillEffectID, bGUCharacterCS);
            if (skillEffectDesc == null)
            {
                return;
            }

            var World = bGUCharacterCS2.World;
            if (World == null) return;
            FTransform fTransform = new FTransform(EffectInstReq.HitPointNormalDir, EffectInstReq.HitLocation);
            if (skillEffectDesc.FXTransUseConfig == EGSYesNo.Yes)
            {
                FRotator rotation = MathLib.Conv_VectorToRotator(new FVector(skillEffectDesc.PlayFXLocalDirY, skillEffectDesc.PlayFXLocalDirZ, skillEffectDesc.PlayFXLocalDirX));
                FRotator rotation2 = BGUFuncLibActorTransformCS.BGUGetActorTransform(bGUCharacterCS2).TransformRotation(rotation);
                FVector socketLocation = bGUCharacterCS2.Mesh.GetSocketLocation(new FName(skillEffectDesc.PlayFXSocketName));
                FVector fVector = (UGSE_EngineFuncLib.GetFirstLocalPlayerController(World).PlayerCameraManager.GetCameraLocation() - BGUFuncLibActorTransformCS.BGUGetActorLocation(Victim)).GetSafeNormal() * skillEffectDesc.FXCameraOffset;
                socketLocation += fVector;
                fTransform = new FTransform(rotation2, socketLocation);
            }

            FTransform spawnTransform = fTransform;
            int resID = 15;
            BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
            bUS_GSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(hitFXPath, out var _, null, NeedSetSpawnTransform: true, spawnTransform, resID);



            // FRotator rotation = MathLib.Conv_VectorToRotator(new FVector(skillEffectDesc.PlayFXLocalDirY, skillEffectDesc.PlayFXLocalDirZ, skillEffectDesc.PlayFXLocalDirX));
            // FRotator rotation2 = BGUFuncLibActorTransformCS.BGUGetActorTransform(bGUCharacterCS2).TransformRotation(rotation);
            // FVector socketLocation = bGUCharacterCS2.Mesh.GetSocketLocation(new FName(skillEffectDesc.PlayFXSocketName));
            // FVector fVector = (GetPlayerController().PlayerCameraManager.GetCameraLocation() - BGUFuncLibActorTransformCS.BGUGetActorLocation(Victim)).GetSafeNormal() * skillEffectDesc.FXCameraOffset;
            // socketLocation += fVector;
            // var fTransform = new FTransform(rotation2, socketLocation);
            // if (uParticleSystem != null)
            // {
            //     UGameplayStaticsEx.SpawnEmitterAtLocation(Victim, uParticleSystem, ref fTransform);
            // }
            // else if (uNiagaraSystem != null)
            // {
            //     UNiagaraFunctionLibrary.SpawnSystemAtLocation(Victim, uNiagaraSystem, fTransform.GetLocation(), fTransform.Rotator(), fTransform.GetScale3D(), bAutoDestroy: true, bAutoActivate: true, ENCPoolMethod.AutoRelease, bPreCullCheck: false);
            // }

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
        public static void xuelunyan()
        {

            var character = GetBGUPlayerCharacterCS();
            var target = BGUFunctionLibraryCS.BGUGetTarget(character) as BGUCharacterCS;
            var skillID = getCurrentSkillId(target);
            if (skillID == 0)
            {
                target = GetNearestAlly();
                skillID = getCurrentSkillId(target);
            }
            if (skillID == 0)
            {
                target = GetNearestEnemy();
                skillID = getCurrentSkillId(target);
            }


            if (skillID != 0 && target != null && character != null)
            {


                if (target != null)
                {

                    if (target.Mesh.PathName == character.Mesh.PathName)
                    {
                        UAnimInstance animInstance = target.Mesh.GetAnimInstance();
                        if (animInstance != null)
                        {
                            var montage = animInstance.GetCurrentActiveMontage();
                            if (montage != null)
                            {
                                UAnimInstance animInstance_player = character.Mesh.GetAnimInstance();
                                animInstance_player.Montage_Play(montage, 1.2f);
                            }
                        }
                        return;
                    }
                    bossModel model = getActorModel(target);
                    if (model != null)
                    {
                        var config = getMagicConfigByModel(character, model);
                        if (config == null) return;

                        if (skillID > 0)
                        {
                            BGUFunctionLibraryCS.BGUAddBuff(character, character, 211, EBuffSourceType.GM, 5000);
                            BGUFunctionLibraryCS.BGUAddBuff(character, character, 300, EBuffSourceType.GM, 5000);//镜头拉远
                            CastVigorSkillByConfig(character, config, skillID);
                        }
                        return;
                    }

                }
            }

        }

        public static void MoveActor(float distance = 900f)
        {
            AActor Owner = Helper.GetBGUPlayerCharacterCS();
            if (Owner == null)
            {
                return;
            }

            // 获取当前位置
            FVector currentLocation = Owner.GetActorLocation();

            // 计算目标位置
            FVector forwardVector = Owner.GetActorForwardVector();
            FVector targetLocation = currentLocation + (forwardVector * distance);

            // 使用 Teleport 方法移动到目标位置
            Owner.Teleport(targetLocation, Owner.GetActorRotation());

        }
    }
}