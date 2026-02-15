using b1;
using CSharpModBase;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnrealEngine.Runtime;
using UnrealEngine.Engine;
using System.Linq;
using BtlShare;
using B1UI;
using ResB1;
namespace bian
{

    public class Filter
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int BuffID { get; set; }
        public int EffectID { get; set; }
    }

    public class RuleAction
    {

        public int? equipId { get; set; }
        public List<RuleAction>? summonerActions { get; set; }
        public List<EAbnormalStateType>? clearTypes { get; set; }
        public bool? toPlayerTeam { get; set; }
        public bool? IsSummonerAsMaster { get; set; }
        public bool? IsDragFarest { get; set; }
        public float? NewMinArmLength { get; set; }
        public float? NewMaxArmLength { get; set; }
        public float? NewMinSocketZ { get; set; }
        public float? NewMaxSocketZ { get; set; }
        public int? RecoverSkillID { get; set; }
        public bool? onlyFirst { get; set; }
        public bool? isModStop { get; set; }
        public int? changeTime { get; set; }
        public bool? resetBack { get; set; }
        public string? bossLabel { get; set; }
        public string? path { get; set; }
        public List<int>? scaleXYZ { get; set; }

        public string? RushDir { get; set; }
        public int? montageIndex { get; set; }
        public string? montageValue { get; set; }
        public float? attrValue { get; set; }
        public int? attrType { get; set; }

        public string? skillType { get; set; }
        public string? bossType { get; set; }
        public string? SummonTamerTemplatePath { get; set; }
        public string? SummonBPTemplatePath { get; set; }
        public string[]? DisappearMontagePathList { get; set; }
        public string[]? BornMontagePathList { get; set; }
        public int? UseBornSkill { get; set; }

        public int? magicID { get; set; }
        public int? MagicSkillID { get; set; }
        public int? ResId { get; set; }
        public List<int>? skillIndexs { get; set; }
        public List<int>? skillValues { get; set; }


        public string Type { get; set; }
        public List<RuleAction>? bullets { get; set; }
        public List<RuleAction>? buffs { get; set; }
        public bool? noUseEffectLocation { get; set; }
        public object[] Params { get; set; }
        public int BuffID { get; set; }
        public int SkillID { get; set; }

        public int BuffTime { get; set; }
        public string Bullet { get; set; }
        public int ProjectTileID { get; set; }

        public int SummonID { get; set; }

        public int SummonCount { get; set; }
        public int TimeDelay { get; set; }
        public int SummonAliveTime { get; set; }

        public int OffsetX { get; set; }
        public int OffsetY { get; set; }
        public int OffsetZ { get; set; }
        public int BulletCount { get; set; }

        public int EffectID { get; set; }


        public bool ForTarget { get; set; }
        public bool attackTarget { get; set; }

        public bool IsRandom { get; set; }

        public int SpeedLeftValue { get; set; }

        public int SpeedRightValue { get; set; }
        public int hasBuff { get; set; }
        public int noHasBuff { get; set; }


        public int talentCondition { get; set; }
        public int noTalentCondition { get; set; }
        public string desc { get; set; }


        public int BornDirOffsetXLeftValue { get; set; }
        public int BornDirOffsetXRightValue { get; set; }


        public int BornDirOffsetYLeftValue { get; set; }
        public int BornDirOffsetYRightValue { get; set; }
        public int BornDirOffsetZLeftValue { get; set; }
        public int BornDirOffsetZRightValue { get; set; }

        public int BulletNumInOneWave { get; set; }
        public bool? AttachToSpawnBase { get; set; }
        public List<int>? BuffIDs { get; set; }
        public List<int>? ProjectTileIDs { get; set; }
        public List<int>? hasAnyBuff { get; set; }
        public List<int>? noHasAnyBuff { get; set; }


        public string? TargetProjectilePosOffsetType { get; set; }
        public string? TargetRangeOffsetInfo { get; set; }
        public int? TargetMatrixDensity { get; set; }
        public int? TargetCircleRadius { get; set; }
        public int? NoiseX { get; set; }
        public int? NoiseY { get; set; }
        public int? NoiseZ { get; set; }

        public int? VigorSkillID { get; set; }
        public int? BossSkillID { get; set; }
        public string? Label { get; set; }
        public string? FollowCamera { get; set; }
        public double? XRate { get; set; }
        public double? YRate { get; set; }
        public double? ZRate { get; set; }
        public int? returnTime { get; set; }
        public float? backTime { get; set; }
        public string? spawnBaseSocketName { get; set; }
        public string? targetBaseSocketName { get; set; }


        public int? intervalTime { get; set; }
        public int? intervalTimes { get; set; }
        public int? ItemID { get; set; }
        public int? ItemCount { get; set; }
        public List<int> ProjectOffsetPosition { get; set; }
        public AActor? Caster { get; set; } // 临时存储施法者
        public AActor? Target { get; set; } // 临时存储目标
        public FEffectInstReq? EffectInstReq { get; set; } // 临时存储目标
        public string? BornDirType { get; set; }
        public float? Scale3D { get; set; }
        public float? UnitScale { get; set; }
        public int? actionId { get; set; }
        public float? value { get; set; }

        public BuffActiveCondition? activeCondition { get; set; }






        public RuleAction()
        {
            Type = "skill|buff|bullet";
            SummonCount = 1;
            SummonAliveTime = 10;

            OffsetY = 0;
            OffsetX = 0;
            OffsetZ = 0;
            ProjectTileID = 0;
            ForTarget = false;
            attackTarget = false;
            BulletCount = 1;
            IsRandom = false;
            TimeDelay = 0;
        }

    }

    public class RuleGroup
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Rule> Rules { get; set; }

        public string Author { get; set; }

        public string path { get; set; }

        public RuleGroup()
        {
            Name = "新规则组";
            Description = "新规则组";
            path = "";
            Rules = new List<Rule>();
        }
    }
    public class Rule
    {
        private ModelManager manager;
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Filter> Filters { get; set; }
        public List<RuleAction> AfterActions { get; set; }


        public float? MoveOffset { get; set; }
        public float? scaleWeaponNum { get; set; }
        public float? startTimeRate { get; set; }
        public float? endTimeRate { get; set; }
        public float? speedRate { get; set; }
        public float? startTime { get; set; }
        public float? endTime { get; set; }
        public bool? isLoop { get; set; }
        public int? skillID_fs { get; set; }
        // 添加以下两个属性
        public AActor? Caster { get; set; } // 临时存储施法者
        public AActor? Target { get; set; } // 临时存储目标
        public FEffectInstReq? EffectInstReq { get; set; } // 临时存储目标


        public Rule()
        {
            Name = "新规则";
            Description = "新规则";
        }




        private bool CheckBuffConditions(BGUPlayerCharacterCS character, RuleAction action)
        {
            // 首先检查 BGUHasBuffByID 方法是否存在
            var method = typeof(BGUFunctionLibraryCS).GetMethod("BGUHasBuffByID");
            if (method == null)
            {
                Log.Error("BGUHasBuffByID method not found in BGUFunctionLibraryCS");
                return false;
            }
            if (action.hasBuff > 0 && !BGUFunctionLibraryCS.BGUHasBuffByID(character, action.hasBuff))
                return false;

            if (action.noHasBuff > 0 && BGUFunctionLibraryCS.BGUHasBuffByID(character, action.noHasBuff))
                return false;

            if (action.hasAnyBuff?.Count > 0 && !action.hasAnyBuff.All(buff => BGUFunctionLibraryCS.BGUHasBuffByID(character, buff)))
                return false;

            if (action.noHasAnyBuff?.Count > 0 && action.noHasAnyBuff.Any(buff => BGUFunctionLibraryCS.BGUHasBuffByID(character, buff)))
                return false;


            if (action.activeCondition != null && action.activeCondition.ConditionType != null && action.activeCondition.ConditionParams != null)
            {
                if (!BGUFunctionLibraryCS.BGUCheckBuffEffectActiveCondition(0, bIsBuff: false, character,
    (EGSBuffAndSkillEffectActiveCondition)(action.activeCondition.ConditionType ?? 0),
    action.activeCondition.ConditionParams.Split(','), null))
                {
                    return false;
                }

            }

            return true;
        }

        private bool CheckTalentConditions(BGUPlayerCharacterCS character, RuleAction action)
        {
            if (action?.talentCondition == null) return true;
            // 首先检查 BGUHasTalentByID 方法是否存在
            var method = typeof(BGUFunctionLibraryCS).GetMethod("BGUHasTalentByID");
            if (method == null)
            {
                Log.Error("BGUHasTalentByID method not found in BGUFunctionLibraryCS");
                return true;
            }
            if (action.talentCondition > 0 && !BGUFunctionLibraryCS.BGUHasTalentByID(character, action.talentCondition))
                return false;

            if (action.noTalentCondition > 0 && BGUFunctionLibraryCS.BGUHasTalentByID(character, action.noTalentCondition))
                return false;

            return true;
        }

        private void HandleBuffAction(BGUPlayerCharacterCS character, RuleAction action, float timeLength)
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
                    if (!BGUFunctionLibraryCS.BGUHasBuffByID(target, buff))
                    {
                        BGUFunctionLibraryCS.BGUAddBuff(character, target, buff, EBuffSourceType.GM, buffTime);
                    }

                }
            }
        }

        private void HandleBulletAction(BGUPlayerCharacterCS character, RuleAction action, float timeLength)
        {
            Log.Info($"执行BulletAction:{action?.Bullet}");
            if (action?.buffs?.Count > 0)
            {
                var buffTime = timeLength;
                var caster = action?.Caster ?? character;
                var target = action?.Target ?? character;

                if (caster == null || target == null)
                {
                    // 记录错误日志
                    return;
                }
                foreach (var bulletItem in action.buffs.Where(b => CheckBuffConditions(character, b)))
                {
                    if (bulletItem.BuffTime > 0)
                        buffTime = bulletItem.BuffTime;
                    BGUFunctionLibraryCS.BGUAddBuff(caster, target, bulletItem.BuffID, EBuffSourceType.GM, buffTime);
                }
            }

            if (action?.bullets?.Count > 0)
            {
                foreach (var bulletItem in action.bullets.Where(b => CheckBuffConditions(character, b)))
                {
                    var projectTileIds = bulletItem.ProjectTileIDs?.Count > 0 ? bulletItem.ProjectTileIDs : [bulletItem.ProjectTileID];

                    if (action.EffectInstReq != null && !(action?.noUseEffectLocation ?? false))
                    {
                        bulletItem.EffectInstReq = action.EffectInstReq;
                    }

                    if (projectTileIds?.Count > 0)
                    {
                        foreach (var projectTileId in projectTileIds)
                        {
                            Helper.SpawnProjectile(character, bulletItem.Bullet, projectTileId, bulletItem.ForTarget,
                                bulletItem.BulletCount, bulletItem.IsRandom,
                                new FVector(bulletItem.OffsetX, bulletItem.OffsetY, bulletItem.OffsetZ), bulletItem);
                        }
                    }
                }
            }
            Log.Info($"执行desc：{action?.desc},Bullet:{action?.Bullet}，action.EffectInstReq：{action?.EffectInstReq?.ObjectID}");
            if (action.Bullet != null)
            {

                var projectTileIds = action.ProjectTileIDs?.Count > 0 ? action.ProjectTileIDs : [action.ProjectTileID];
                if (projectTileIds?.Count > 0)
                {
                    foreach (var projectTileId in projectTileIds)
                    {

                        Helper.SpawnProjectile(character, action.Bullet, projectTileId, action.ForTarget,
                            action.BulletCount, action.IsRandom,
                            new FVector(action.OffsetX, action.OffsetY, action.OffsetZ), action);
                    }
                }
            }
        }

        private async Task ExecuteDelayedAction(Action action, int delay, bool checkMontage = true, UAnimMontage montage = null, Rule rule = null)
        {
            if (delay <= 0)
            {
                action();
                return;
            }

            await Task.Delay(delay);
            Utils.TryRunOnGameThread(() =>
            {
                if (checkMontage && montage != null && rule != null)
                {
                    var character = Helper.GetBGUPlayerCharacterCS();
                    var animInstance = character.Mesh?.GetAnimInstance();
                    if (animInstance == null) return;

                    var currentMontage = animInstance.GetCurrentActiveMontage();
                    if (currentMontage == null || !rule.IsMatchMontage(currentMontage.PathName))
                        return;
                }
                action();
            });
        }

        public bool IsMatchMontage(string montageName)
        {
            if (string.IsNullOrEmpty(montageName) || Filters == null || Filters.Count == 0)
                return false;

            return Filters.Any(filter =>
                filter.Type == "montage" &&
                !string.IsNullOrEmpty(filter.Name) &&
                montageName.Contains(filter.Name));
        }

        public void DoAction(RuleAction action, float timeLength = 1000)
        {
            var character = Helper.GetBGUPlayerCharacterCS();
            if (character == null) return;

            Log.Info($"执行DoAction Type: {action?.Type}，desc：{action?.desc},EffectInstReq:{action?.EffectInstReq?.ObjectID}");
            switch (action?.Type?.ToLower())
            {
                case "buff":
                    HandleBuffAction(character, action, timeLength);
                    break;
                case "change_actor_to_target":
                    // 周围2000的角色全部变成己方的人，并把目标对准当前锁定的目标

                    Helper.ChangeEmenyTarget();
                    break;
                case "set_mod_stop":
                    Helper.set_mod_stop(action.isModStop.HasValue ? action.isModStop.Value : false);
                    break;

                case "change_actor_target":
                    // 把其他敌人的目标对准当前锁定的目标,toPlayerTeam 为true就是把周围的人变成己方的人，除了目标
                    Helper.changeAllActorTarget(action?.toPlayerTeam ?? false);
                    break;

                case "removeBuff":
                    if (action?.BuffID != null && action?.BuffID > 0)
                    {
                        BGUFunctionLibraryCS.BGURemoveBuffImmediately(character, action.BuffID, EBuffEffectTriggerType.Remove);
                    }
                    if (action?.BuffIDs != null && action?.BuffIDs?.Count > 0)
                    {
                        foreach (var buffId in action.BuffIDs)
                        {
                            BGUFunctionLibraryCS.BGURemoveBuffImmediately(character, buffId, EBuffEffectTriggerType.Remove);
                        }
                    }
                    break;



                case "show_shop":
                    Helper.show_shop();
                    break;

                case "show_fuhuo_ui":
                    Helper.fuhuo_ui();
                    break;

                case "show_duiyou":
                    Helper.show_duiyou();
                    break;

                case "close_duiyou":
                    Helper.close_duiyou();
                    break;

                case "enter_main":
                    Helper.enter_main();
                    break;

                case "gc_one":
                    Helper.gc_one();
                    break;
                case "log_info":
                    Helper.LogProjInfo();
                    break;

                case "qiehuan_map":
                    Helper.SwitchMap();
                    break;
                case "skill":
                    if (action.SkillID > 0)
                    {
                        BUS_EventCollectionCS.Get(character).Evt_RequestSmartCastSkill.Invoke(
                            action.SkillID, null, EMontageBindReason.NormalSkill, false);
                    }
                    break;

                case "trans":
                    if (action?.SkillID > 0)
                    {
                        BUS_EventCollectionCS.Get(character)?.Evt_UnitCastSkillTry.Invoke(
                            new FCastSkillInfo(10100, ECastSkillSourceType.GM));
                        ExecuteDelayedAction(() =>
                            Helper.CastMimicrySkill(character, action.SkillID), 650).ConfigureAwait(false);
                    }
                    break;

                case "followcamera":
                    if (action?.XRate != 0 || action?.YRate != 0 || action?.ZRate != 0)
                    {
                        character.FollowCamera.RelativeLocation = new FVector(
                            action?.XRate ?? 0.0, action?.YRate ?? 0.0, action?.ZRate ?? 0.0);
                        ExecuteDelayedAction(() =>
                            character.FollowCamera.RelativeLocation = new FVector(0.0, 0.0, 0.0),
                            (int)(action?.returnTime ?? 1000)).ConfigureAwait(false);
                    }
                    break;

                case "magic":
                    if (action?.SkillID > 0)
                    {
                        Helper.CastVigorSkillByID(character, action.SkillID, action?.UnitScale ?? 1, (int?)(action?.Scale3D ?? 1));
                    }
                    break;
                case "spaw_monster":

                    if (action?.SummonTamerTemplatePath != null)
                    {
                        Helper.GMSpawnMonster(action.SummonTamerTemplatePath);
                        // var teamID = Helper.GetBGUPlayerCharacterCS().GetTeamIDInCS();
                        // if (action?.toPlayerTeam == true)
                        // {
                        //     Helper.SpawnActor(action.SummonTamerTemplatePath, teamID);
                        // }
                        // else
                        // {
                        //     Helper.SpawnActor(action.SummonTamerTemplatePath, null);

                        // }
                    }

                    break;
                case "bullet":
                    HandleBulletAction(character, action, timeLength);
                    break;
                case "duo_po":
                    Helper.SyncTeamWithTarget();
                    break;
                case "sync_teamid":
                    Helper.SyncTeamWithTarget();
                    break;
                case "diff_teamid":
                    Helper.diffTeamID();
                    break;

                case "reset_teamid":
                    Helper.resetTeamID();
                    break;
                case "summon":
                    if (action?.SummonID > 0)
                    {
                        Helper.newSummonReq(action);
                    }
                    break;
                case "out_magic":
                    Helper.OnMagicallyChangeFadeOut();
                    break;
                case "weak_monster":
                    Helper.WeakMonster();
                    break;
                case "change_target":
                    Helper.change_target();
                    break;
                case "strong_monster":
                    // 加强怪
                    Helper.StrongMonster();
                    break;
                case "show_sweepcheck_shape":
                    BUS_EventCollectionCS.Get(character)?.Evt_ShowSweepCheckShape.Invoke();
                    break;

                case "qian_jin":
                    var value = action?.value != null ? action.value : 900f;
                    Helper.MoveActor((float)value);
                    break;

                case "change_move_speed":
                    BUC_SpeedCtrlData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_SpeedCtrlData>(character);
                    unPersistentReadOnlyData.SetSpeedInfoBase(5400f, 4550f, 1600f);
                    var BGS = Helper.GetBUS_GSEventCollection();
                    BGS.Evt_SetMoveSpeedAddValue.Invoke(1000);
                    break;
                case "addallsummonlifetime":

                    BUS_EventCollectionCS.Get(character)?.Evt_AddAllSummonLifeTime.Invoke((float)(action?.SummonAliveTime ?? 100f));

                    break;
                case "use_item":
                    if (action?.ItemID > 0)
                    {
                        BUS_EventCollectionCS.Get(character)?.Evt_TriggerItemSkillAction_UseItem.Invoke((int)action.ItemID);
                    }
                    break;
                case "summoner_do_actions":
                    if (action?.summonerActions != null && action?.summonerActions?.Count > 0)
                    {
                        foreach (var actionItem in action.summonerActions)
                        {
                            Helper.summonerDoActions(actionItem);
                        }
                    }
                    break;
                case "ironbody":
                    var eventCollection = BUS_EventCollectionCS.Get(character);
                    if (eventCollection != null)
                    {
                        eventCollection.Evt_IronBodyStart.Invoke();
                    }
                    break;
                case "scale_project":
                    var ProjectTileIDs = action?.ProjectTileIDs?.Count > 0 ? action?.ProjectTileIDs : new List<int> { action?.ProjectTileID ?? 0 };

                    if (ProjectTileIDs?.Count > 0)
                    {
                        var num = action?.UnitScale ?? 2;
                        var scaleX = (action?.scaleXYZ != null && action.scaleXYZ.Count > 0) ? action.scaleXYZ[0] : 1;
                        var scaleY = (action?.scaleXYZ != null && action.scaleXYZ.Count > 0) ? action.scaleXYZ[1] : 1;
                        var scaleZ = (action?.scaleXYZ != null && action.scaleXYZ.Count > 0) ? action.scaleXYZ[2] : 1;


                        foreach (var projectTileID in ProjectTileIDs)
                        {
                            var projectBase = BGUFuncLibProjectile.GetCtrProjectileByID(character, projectTileID);
                            Log.Info($"projectBase:{projectBase?.PathName}");
                            if (projectBase != null)
                            {

                                projectBase.SetActorScale3D(new FVector(scaleX, scaleY, scaleZ));

                            }
                        }
                    }
                    break;
                case "dragfarcamera":
                    if (action?.NewMinArmLength != null || action?.NewMaxArmLength != null || action?.NewMinSocketZ != null || action?.NewMaxSocketZ != null)
                    {
                        BUS_EventCollectionCS.Get(character).Evt_DragFarCamera.Invoke(action?.IsDragFarest ?? false, action?.NewMinArmLength ?? -1, action?.NewMaxArmLength ?? -1, action?.NewMinSocketZ ?? -1, action?.NewMaxSocketZ ?? -1);
                    }
                    break;
                case "xuelunyan":
                    Helper.xuelunyan();
                    break;

                case "export_actor":
                    Helper.ExportAllActors();
                    break;
                case "maidonghuilai":
                    var commands = new Commands();
                    commands.MaiDongHuiLai(null);
                    break;
                case "resetskillcd":
                    BUS_EventCollectionCS.Get(character)?.Evt_ResetSkillCD.Invoke();
                    break;

                case "enterskillcam":
                    if (action?.actionId != null)
                    {
                        BPS_EventCollectionCS.GetLocal(character).Evt_EnterSkillCam.Invoke(character, (int)action.actionId);
                    }
                    break;
                case "exitskillcam":
                    BPS_EventCollectionCS.GetLocal(character).Evt_ExitSkillCam.Invoke(character);
                    break;

                case "add_attr":
                    if (action?.attrValue != null && action?.attrType != null)
                    {
                        BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(character);
                        if (bUS_GSEventCollection == null) return;
                        bUS_GSEventCollection.Evt_IncreaseAttrFloat?.Invoke((EBGUAttrFloat)(action.attrType ?? 151), action?.attrValue ?? 100);
                        if (action?.attrType == (int)EBGUAttrFloat.SkillSuperArmor)
                        {
                            bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.SkillSuperArmor, false);
                        }
                    }
                    break;

                case "decrease_abnormal":
                    BUS_GSEventCollection bUS_GSEventCollection_ = BUS_EventCollectionCS.Get(character);
                    if (bUS_GSEventCollection_ != null)
                    {
                        bUS_GSEventCollection_.Evt_DecreaseAbnormalAccValue.Invoke((EAbnormalStateType)(action.attrType ?? 1), action?.attrValue ?? 1000);
                    }
                    break;
                case "change_equip":
                    if (action?.equipId != null)
                    {
                        EquipDesc equipDesc = GameDBRuntime.GetEquipDesc((int)action.equipId);
                        if (equipDesc != null)
                        {
                            Helper.setActorEquip((int)action.equipId);
                        }
                    }

                    break;
                case "additem":
                    if (action != null && action.ItemID != null && action.ItemCount != null)
                    {
                        Helper.gain_item((int)action.ItemID, (int)action.ItemCount);
                    }


                    break;
                case "alltaskitem":
                    Helper.addAllTaskItem();
                    break;


                case "effect":
                    if (action.EffectID > 0)
                    {
                        var type = action.ForTarget ? EANTriggerEffectTargetType.LastAttacker : EANTriggerEffectTargetType.Owner;
                        Helper.TriggerEffect(character, action.EffectID, type);
                    }
                    break;

                case "bossskill":
                    if (action.bossLabel != null && action.bossType != null && action?.MagicSkillID != null)
                    {
                        Helper.CastVigorSkillByModel(character, action.bossLabel, action.bossType ?? "", action?.MagicSkillID ?? 0, action?.resetBack ?? false, action?.RecoverSkillID ?? 10199);
                    }
                    break;
                case "magicskill":
                    if (action.magicID != null)
                    {
                        Helper.CastVigorSkillByID(character, (int)action.magicID, action?.UnitScale ?? 1, action?.MagicSkillID ?? 0, action?.Scale3D ?? 1, action?.resetBack ?? false);
                    }
                    break;
                case "transskill":
                    if (action?.ResId != null && action?.MagicSkillID != null)
                    {
                        Helper.CastTranskillByID(character, action?.ResId ?? 0, action?.MagicSkillID ?? 0);

                    }
                    break;
                case "clear_all_abnormal":
                    // 设置默认清除冰、火、毒异常状态

                    var finalClearTypes = action?.clearTypes?.Select(x => (int)x).ToList() ?? new List<int> {
    (int)EAbnormalStateType.Abnormal_Burn,
    (int)EAbnormalStateType.Abnormal_Freeze,
    (int)EAbnormalStateType.Abnormal_Poison
};


                    Helper.ClearAllAbnormal(character, finalClearTypes);
                    break;

                case "show_info":
                    ShowPlayerInfo.InitItems(false);
                    break;
                case "clear_ui":
                    ShowPlayerInfo.ClearAllUI();
                    break;
                case "export_json":
                    Helper.export_json();
                    break;


                case "attack_feedback":
                    var EffectID = action?.EffectID;
                    var hitFXPath = action?.path;
                    var Target = action?.Target;
                    var EffectInstReq = action?.EffectInstReq;
                    if (EffectID != null && hitFXPath != null && Target != null && EffectInstReq != null)
                    {
                        Helper.AttackFeedbackPerform(hitFXPath, Target, (int)EffectID, (FEffectInstReq)EffectInstReq);

                    }
                    break;
                case "rushskill":
                    Helper.doPhantomRushSkill(character, action.RushDir ?? "Forward");

                    break;

                case "trans_dasheng":
                    Helper.change_to_dasheng(action?.changeTime ?? 999);
                    break;



            }
        }

        public CommB1.PlayerDataMgr getPlayerDataMgr()
        {
            return GSG.GamePlayer.CreateTransaction((OPReason)1);

        }
        public void updateData()
        {
            var playerDataMgr = getPlayerDataMgr();
            if (playerDataMgr != null)
            {
                playerDataMgr.Commit();
            }

        }



        private bool CheckAnimConditions(BGUPlayerCharacterCS character, RuleAction action)
        {

            var montageList = Hooks.playMontageList;
            if (montageList == null || montageList.Count == 0) return false;
            var montageIndex = action.montageIndex ?? 0;
            if (montageIndex >= montageList.Count) return false;
            if (montageList[montageIndex] != null && montageList[montageIndex].Contains(action.montageValue))
            {
                return true;
            }
            return false;
        }


        private bool CheckSkillConditions(BGUPlayerCharacterCS character, RuleAction action)
        {

            var playSkillList = Hooks.playSkillList;
            if (playSkillList == null || playSkillList.Count == 0) return false;

            // 支持多个索引的检查
            if (action?.skillIndexs?.Count > 0 && action?.skillValues?.Count > 0)
            {
                // 检查是否有任何一个索引匹配
                return action.skillIndexs.Any(index =>
                    index < playSkillList.Count &&
                    action.skillValues.Contains(playSkillList[index])
                );
            }
            return false;
        }



        private bool CheckAllConditions(BGUPlayerCharacterCS character, RuleAction action)
        {
            // 检查动画条件
            if (action?.montageIndex != null && action?.montageValue != null)
            {
                if (!CheckAnimConditions(character, action))
                    return false;
            }

            // 检查技能条件
            if (action?.skillIndexs != null && action?.skillValues != null)
            {
                if (!CheckSkillConditions(character, action))
                    return false;
            }

            // 检查buff条件
            if (action?.hasBuff > 0 || action?.noHasBuff > 0 ||
                action?.hasAnyBuff?.Count > 0 || action?.noHasAnyBuff?.Count > 0)
            {
                if (!CheckBuffConditions(character, action))
                    return false;
            }



            // 检查天赋条件
            if (action?.talentCondition != null || action?.noTalentCondition != null)
            {
                if (!CheckTalentConditions(character, action))
                    return false;
            }

            return true;
        }



        public async void DoAfterActions(List<RuleAction> actions)
        {
            if (actions == null || actions.Count == 0) return;
            var character = Helper.GetBGUPlayerCharacterCS();
            if (character == null) return;
            foreach (var action in actions)
            {
                // 使用统一的条件检查方法
                if (!CheckAllConditions(character, action))
                    continue;
                if (action?.TimeDelay > 0)
                {
                    // 如果是多次执行就间隔执行
                    if (action.intervalTime > 0)
                    {
                        var intervalTime = action.intervalTime ?? 100;
                        var intervalTimes = action.intervalTimes ?? 2;
                        var times = intervalTimes;
                        for (int loopTimes = 0; loopTimes < times; loopTimes++)
                        {
                            await Task.Delay((int)intervalTime);
                            DoAction(action, 10000);
                        }

                    }
                    else
                    {
                        ExecuteDelayedAction(() => DoAction(action, 1000 / 1), action.TimeDelay).ConfigureAwait(false);

                    }
                    continue;
                }
                else
                {

                    // 如果是多次执行就间隔执行
                    if (action?.intervalTime > 0)
                    {
                        var intervalTime = action.intervalTime ?? 100;
                        var intervalTimes = action.intervalTimes ?? 2;
                        var times = intervalTimes;
                        for (int loopTimes = 0; loopTimes < times; loopTimes++)
                        {
                            await Task.Delay((int)intervalTime);
                            DoAction(action, 10000);
                        }
                    }
                    else
                    {
                        DoAction(action, 1000 / 1);
                    }
                    continue;
                }
            }

        }
        public bool DoRule(float timeLength_, float playRate_, UAnimMontage montage = null, Rule ruleItem = null)
        {
            var timeLength = timeLength_ > 0 ? timeLength_ : 1000;
            var playRate = playRate_ > 0 ? playRate_ : 1;

            if (AfterActions == null) return true;

            foreach (var action in AfterActions)
            {
                var character = Helper.GetBGUPlayerCharacterCS();
                if (character == null) continue;

                // 设置ruleItem相关属性
                SetRuleItemProperties(action, ruleItem);

                // 检查条件
                if (!CheckBuffConditions(character, action) || !CheckTalentConditions(character, action))
                    continue;

                // 设置默认延迟并计算时间参数
                if (!SetupActionDelay(action, playRate, out var timeDelay, out var intervalTime))
                {
                    DoAction(action, timeLength / playRate);
                    continue;
                }

                if (montage != null && ruleItem != null)
                {
                    // 如果是比较短的延迟就直接执行，不走动画匹配
                    if (action.TimeDelay < 800)
                    {
                        // 如果是多次执行就间隔执行
                        if (intervalTime > 0)
                        {
                            var num = Math.Min(15000, Math.Max(1000, montage.GetPlayLength() * 1000));
                            var times = action?.intervalTimes > 0 ? action?.intervalTimes.Value : (int)(num / intervalTime);
                            for (int loopTimes = 0; loopTimes < times; loopTimes++)
                            {
                                ExecuteDelayedAction(() => DoAction(action, timeLength / playRate), intervalTime).ConfigureAwait(false);
                            }
                        }
                        else
                        {
                            ExecuteDelayedAction(() => DoAction(action, timeLength / playRate), action.TimeDelay).ConfigureAwait(false);
                        }
                        continue;
                    }
                    else
                    {
                        // 走动画匹配的逻辑
                        ExecuteDelayedAction(async () =>
                        {
                            await HandleAnimationBasedExecution(action, timeLength, playRate, timeDelay, intervalTime, character, montage, ruleItem);
                        }, timeDelay, true, montage, ruleItem).ConfigureAwait(false);
                    }

                }
                else
                {
                    if (action.TimeDelay > 0)
                    {
                        ExecuteDelayedAction(() => DoAction(action, timeLength / playRate), action.TimeDelay).ConfigureAwait(false);
                        continue;
                    }
                    else
                    {
                        DoAction(action, timeLength / playRate);
                        continue;
                    }
                }

            }
            return true;
        }

        // 设置ruleItem相关属性
        private void SetRuleItemProperties(RuleAction action, Rule ruleItem)
        {
            if (ruleItem == null) return;

            if (ruleItem.Caster != null) action.Caster = ruleItem.Caster;
            if (ruleItem.Target != null) action.Target = ruleItem.Target;
            if (ruleItem.EffectInstReq != null && !(action?.noUseEffectLocation ?? false))
                action.EffectInstReq = ruleItem.EffectInstReq;
        }

        // 设置默认延迟并计算时间参数
        private bool SetupActionDelay(RuleAction action, float playRate, out int timeDelay, out int intervalTime)
        {
            // 设置默认延迟
            if (action.Type.ToLower() == "skill" && action.TimeDelay <= 0)
                action.TimeDelay = 1;
            if (action.TimeDelay <= 0 && action.Type.ToUpper() is "TRANS" or "BOSS" or "MAGIC")
                action.TimeDelay = 1;

            timeDelay = action.TimeDelay > 1 ? (int)(action.TimeDelay / playRate) : action.TimeDelay;
            intervalTime = (int)(action?.intervalTime > 0 ? action.intervalTime : 0);

            return action.TimeDelay > 0;
        }

        // 处理基于动画的执行
        private async Task HandleAnimationBasedExecution(RuleAction action, float timeLength, float playRate,
            int timeDelay, int intervalTime, BGUPlayerCharacterCS character, UAnimMontage montage, Rule ruleItem)
        {
            var currMontage = Manager.GetCurrentMontage();
            if (character == null || currMontage == null || character.Mesh == null)
                return;

            var animInstance = character.Mesh.GetAnimInstance();
            if (animInstance == null) return;

            float currentPosition = montage != null ? animInstance.Montage_GetPosition(montage) : 0;
            var nowMontage = animInstance.GetCurrentActiveMontage();

            if (ruleItem != null && montage != null && nowMontage != null)
            {
                if (!ruleItem.IsMatchMontage(nowMontage.PathName))
                    return;

                var diff = timeDelay > 800 ? (int)Math.Round(timeDelay / 10.0 * 1.3) : 200;

                // 如果已经播放到了指定位置，则执行
                if (currentPosition > 0 && currentPosition * 1000 >= timeDelay - diff)
                {
                    await ExecuteWithInterval(action, timeLength, playRate, intervalTime, montage, nowMontage, ruleItem);
                }
                else if (currentPosition > 0 && timeDelay - currentPosition * 1000 > diff)
                {
                    await Task.Delay((int)(timeDelay - currentPosition * 1000));
                    nowMontage = animInstance.GetCurrentActiveMontage();
                    if (nowMontage != null && !ruleItem.IsMatchMontage(nowMontage.PathName))
                        return;
                    DoAction(action, timeLength / playRate);
                }
                else
                {
                    DoAction(action, timeLength / playRate);
                }
            }
            else
            {
                DoAction(action, timeLength / playRate);
            }
        }

        // 执行带间隔的重复操作
        private async Task ExecuteWithInterval(RuleAction action, float timeLength, float playRate,
            int intervalTime, UAnimMontage montage, UAnimMontage nowMontage, Rule ruleItem)
        {
            if (intervalTime <= 0)
            {
                DoAction(action, timeLength / playRate);
                return;
            }

            var num = Math.Min(15000, Math.Max(1000, montage.GetPlayLength() * 1000));
            var times = action?.intervalTimes > 0 ? action?.intervalTimes.Value : (int)(num / intervalTime);


            for (int loopTimes = 0; loopTimes < times; loopTimes++)
            {
                // 检查动画是否仍然匹配
                nowMontage = Helper.GetBGUPlayerCharacterCS()?.Mesh?.GetAnimInstance()?.GetCurrentActiveMontage();
                if (nowMontage == null || !ruleItem.IsMatchMontage(nowMontage.PathName))
                    break;

                await Task.Delay((int)intervalTime);
                DoAction(action, timeLength / playRate);
            }
        }

        public bool IsMatchBuff(int buffID)
        {
            return Filters?.Any(filter =>
                filter.Type == "buff" && filter.BuffID == buffID) ?? false;
        }
        public bool IsMatchEffect(int EffectID)
        {
            return Filters?.Any(filter =>
                filter.Type == "effect" && filter.EffectID == EffectID) ?? false;
        }

    }
}
