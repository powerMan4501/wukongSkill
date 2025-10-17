using b1;
using CSharpModBase;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnrealEngine.Runtime;
using UnrealEngine.Engine;
using System.Linq;
using BtlShare;
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
        public string Type { get; set; }
        public List<RuleAction>? bullets { get; set; }
        public List<RuleAction>? buffs { get; set; }
        public bool? noUseEffectLocation { get; set; }

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
        public List<int> ProjectOffsetPosition { get; set; }
        public AActor? Caster { get; set; } // 临时存储施法者
        public AActor? Target { get; set; } // 临时存储目标
        public FEffectInstReq? EffectInstReq { get; set; } // 临时存储目标
        public string? BornDirType { get; set; }
        public float? Scale3D { get; set; }
        public float? UnitScale { get; set; }



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
                var buffTime = action?.BuffTime > 0 ? action.BuffTime : timeLength;
                var target = action?.Target ?? character;
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

        private void HandleBulletAction(BGUPlayerCharacterCS character, RuleAction action, float timeLength)
        {
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
            Log.Info($"DoAction type:{action.Type},desc:{action?.desc}");
            switch (action?.Type?.ToLower())
            {
                case "buff":
                    HandleBuffAction(character, action, timeLength);
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
                        // ExecuteDelayedAction(() =>
                        // {
                        //     character.FollowCamera.RelativeLocation = new FVector(
                        //         action?.XRate ?? -1300.0, action?.YRate ?? 0.0, action?.ZRate ?? 10.0);
                        //     Helper.CastVigorSkillByID(character, action.SkillID, backTime);
                        // }, 0).ContinueWith(async _ =>
                        // {
                        //     await Task.Delay(backTime);
                        //     Utils.TryRunOnGameThread(() =>
                        //     {
                        //         var magicChangeComp = Helper.FindActorCompByClass<BUS_MagicallyChangeComp>(character);
                        //         Helper.ResetVigorSkill(magicChangeComp, action.SkillID);
                        //         BUS_EventCollectionCS.Get(character)?.Evt_UnitCastSkillTry.Invoke(
                        //             new FCastSkillInfo(10199, ECastSkillSourceType.GM));
                        //         character.FollowCamera.RelativeLocation = new FVector(0, 0, 0);
                        //     });
                        // });
                    }
                    break;

                case "bullet":
                    HandleBulletAction(character, action, timeLength);
                    break;

                case "summon":
                    if (action.SummonID > 0)
                    {
                        Helper.SummonReq(action.SummonID, action.SummonCount, action.SummonAliveTime);
                    }
                    break;

                case "effect":
                    if (action.EffectID > 0)
                    {
                        var type = action.ForTarget ? EANTriggerEffectTargetType.LastAttacker : EANTriggerEffectTargetType.Owner;
                        Helper.TriggerEffect(character, action.EffectID, type);
                    }
                    break;
            }
        }



        public void DoAfterActions(List<RuleAction> actions)
        {
            if (actions == null || actions.Count == 0) return;
            var character = Helper.GetBGUPlayerCharacterCS();
            Log.Info($"DoAfterActions {actions.Count}");
            foreach (var action in actions)
            {
                if (character == null) continue;
                // 检查条件
                var result = CheckBuffConditions(character, action);
                if (!result || !CheckTalentConditions(character, action))
                    continue;
                Log.Info($"DoAfterActions check hasBuff: {action.hasBuff} , {result}");
                if (action?.TimeDelay > 0)
                {
                    ExecuteDelayedAction(() => DoAction(action, 1000 / 1), action.TimeDelay).ConfigureAwait(false);
                    continue;
                }
                else
                {
                    DoAction(action, 1000 / 1);
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
