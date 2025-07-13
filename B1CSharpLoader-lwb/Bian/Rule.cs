using b1;
using CSharpModBase;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnrealEngine.Runtime;
using UnrealEngine.Engine;
using System.Reflection;
namespace bian
{

    public class Filter
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int BuffID { get; set; }
    }

    public class RuleAction
    {
        public string Type { get; set; }
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
        public int buffCondition { get; set; }
        public int noBuffCondition { get; set; }


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

        public List<int>? buffsCondition { get; set; }
        public List<int>? noBuffsCondition { get; set; }

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

        public float? startTimeRate { get; set; }
        public float? endTimeRate { get; set; }
        public float? speedRate { get; set; }
        public float? startTime { get; set; }
        public float? endTime { get; set; }
        public bool? isLoop { get; set; }
        public Rule()
        {
            Name = "新规则";
            Description = "新规则";
        }

        public bool IsMatchMontage(string montageName)
        {
            if (montageName != null && montageName.Length > 0 && Filters != null && Filters.Count > 0)
            {
                for (int i = 0; i < Filters.Count; i++)
                {
                    var filter = Filters[i];
                    if (filter.Type == "montage")
                    {
                        if (filter.Name != null && montageName.IndexOf(filter.Name) > -1)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public void DoAction(RuleAction action, float timeLength = 1000)
        {
            var character = Helper.GetBGUPlayerCharacterCS();

            switch (action.Type.ToLower())
            {
                case "buff":
                    if (action.BuffID > 0)
                    {
                        var buffTime = timeLength;
                        if (action.BuffTime > 0)
                        {
                            buffTime = action.BuffTime;
                        }
                        // Log.Info($"bian: start run rule action: add-buff {action.BuffID}");
                        BGUFunctionLibraryCS.BGUAddBuff(character, character, action.BuffID, EBuffSourceType.GM, buffTime);
                    }
                    break;
                case "skill":
                    if (action.SkillID > 0)
                    {
                        //BUS_EventCollectionCS.Get(character).Evt_RequestSmartCastSkill.Invoke(action.SkillID, null, EMontageBindReason.Default, false);
                        //var csi = new FCastSkillInfo(action.SkillID, ECastSkillSourceType.Notify);
                        //csi.NeedCheckSkillCanCast = false;
                        //BUS_EventCollectionCS.Get(character)?.Evt_UnitCastSkillTry.Invoke(csi);
                        BUS_EventCollectionCS.Get(character).Evt_RequestSmartCastSkill.Invoke(action.SkillID, null, EMontageBindReason.NormalSkill, false);
                    }
                    break;

                case "trans":

                    if (action?.SkillID > 0)
                    {

                        BUS_EventCollectionCS.Get(character)?.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(10100, ECastSkillSourceType.GM));
                        Task.Run(async delegate
                        {
                            await Task.Delay(650);
                            Utils.TryRunOnGameThread((Action)delegate
                            {
                                Helper.CastMimicrySkill(character, action.SkillID);
                            });

                        });

                    }

                    break;

                case "boss":



                    break;


                case "followcamera":
                    if (action?.XRate != 0 || action?.YRate != 0 || action?.ZRate != 0)
                    {
                        var originRelativeLocation = character.FollowCamera.RelativeLocation;
                        character = Helper.GetBGUPlayerCharacterCS();
                        character.FollowCamera.RelativeLocation = new FVector((double)(action?.XRate ?? 0.0), (double)(action?.YRate ?? 0.0), action?.ZRate ?? 0.0);
                        var returnTime = action?.returnTime > 0 ? action.returnTime : 1000;
                        Task.Run(async delegate
                        {
                            await Task.Delay((int)returnTime);
                            Utils.TryRunOnGameThread((Action)delegate
                            {
                                character.FollowCamera.RelativeLocation = new FVector(0.0, 0.0, 0.0);
                            });

                        });
                    }
                    break;
                case "magic":


                    if (action?.SkillID > 0)
                    {
                        BUS_EventCollectionCS.Get(character)?.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(10100, ECastSkillSourceType.GM));
                        Task.Run(async delegate
                        {
                            await Task.Delay(650);
                            var backTime = (int)(action?.backTime ?? 1900);
                            Utils.TryRunOnGameThread((Action)delegate
                            {
                                Helper.CastVigorSkillByID(character, action.SkillID, backTime);
                            });
                            await Task.Delay(backTime);

                            Utils.TryRunOnGameThread((Action)delegate
                       {
                           var character = Helper.GetBGUPlayerCharacterCS();
                           BUS_MagicallyChangeComp magicChangeComp = Helper.FindActorCompByClass<BUS_MagicallyChangeComp>(character);
                           Helper.ResetVigorSkill(magicChangeComp, action.SkillID);
                           character = Helper.GetBGUPlayerCharacterCS();
                           BUS_EventCollectionCS.Get(character)?.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(10199, ECastSkillSourceType.GM));
                           character.FollowCamera.RelativeLocation = new UnrealEngine.Runtime.FVector(0, 0, 0);
                       });
                        });
                    }


                    break;
                case "bullet":
                    if (action.Bullet != null)
                    {
                        // Log.Info($"bian: start run rule action: spawn-bullet {action.Bullet}");
                        Helper.SpawnProjectile(character, action.Bullet, action.ProjectTileID, action.ForTarget, action.BulletCount, action.IsRandom, new FVector(action.OffsetX, action.OffsetY, action.OffsetZ), action);
                    }
                    break;
                case "summon":
                    if (action.SummonID > 0)
                    {
                        // Log.Info($"bian: start run rule action: spawn-summon {action.SummonID}x{action.SummonCount}");
                        Helper.SummonReq(action.SummonID, action.SummonCount, action.SummonAliveTime);
                    }
                    break;

                case "effect":
                    if (action.EffectID > 0)
                    {
                        var type = EANTriggerEffectTargetType.Owner;
                        if (action.ForTarget)
                        {
                            type = EANTriggerEffectTargetType.LastAttacker;
                        }
                        Helper.TriggerEffect(character, action.EffectID, type);
                    }
                    break;
                default:
                    break;
            }
        }

        public bool DoRule(float timeLength_, float playRate_, UAnimMontage montage = null, Rule ruleItem = null)
        {

            var timeLength = timeLength_ > 0 ? timeLength_ : 1000;
            var playRate = playRate_ > 0 ? playRate_ : 1;
            if (AfterActions != null)
            {

                for (int i = 0; i < AfterActions.Count; i++)
                {


                    var action = AfterActions[i];
                    var character = Helper.GetBGUPlayerCharacterCS();
                    bool skipAction = false;
                    // 如果设置了buff条件，就校验是否有对应的buff
                    if (action.buffCondition > 0)
                    {
                        if (!BGUFunctionLibraryCS.BGUHasBuffByID(character, action.buffCondition))
                        {

                            // Console.WriteLine($"has no buff {action.buffCondition} {action.desc}");
                            continue;
                        }
                    }
                    if (action.buffsCondition != null && action.buffsCondition.Count > 0)
                    {
                        foreach (var buffer in action.buffsCondition)
                        {
                            if (!BGUFunctionLibraryCS.BGUHasBuffByID(character, buffer))
                            {
                                skipAction = true;
                                break; // 退出 foreach 循环
                            }
                        }
                    }

                    if (action.noBuffCondition > 0)
                    {
                        if (BGUFunctionLibraryCS.BGUHasBuffByID(character, action.noBuffCondition))

                        {

                            // Console.WriteLine($"has buff {action.noBuffCondition}  {action.desc}");
                            continue;
                        }
                    }

                    if (action.noBuffsCondition != null && action.noBuffsCondition.Count > 0)
                    {
                        foreach (var buffer in action.noBuffsCondition)
                        {
                            if (BGUFunctionLibraryCS.BGUHasBuffByID(character, buffer))
                            {
                                skipAction = true;
                                break; // 退出 foreach 循环
                            }
                        }
                    }

                    if (skipAction)
                    {
                        continue; // 跳过当前 for 循环的迭代
                    }
                    if (action.noTalentCondition > 0)
                    {
                        if (BGUFunctionLibraryCS.BGUHasTalentByID(character, action.noTalentCondition))
                        {
                            // Console.WriteLine($"has talent {action.noTalentCondition}");
                            continue;
                        }
                    }

                    // 如果设置了天赋条件，就校验是否有对应的天赋
                    if (action.talentCondition > 0)
                    {
                        if (!BGUFunctionLibraryCS.BGUHasTalentByID(character, action.talentCondition))
                        {
                            // Console.WriteLine($"has no talent {action.talentCondition}");
                            continue;
                        }
                    }
                    if (action.Type.ToLower() == "skill" && action.TimeDelay <= 0)
                    {
                        action.TimeDelay = 1;
                    }
                    if (action.TimeDelay <= 0)
                    {
                        if (action.Type.ToUpper() == "TRANS" || action.Type.ToUpper() == "BOSS" || action.Type.ToUpper() == "MAGIC")
                        {
                            action.TimeDelay = 1;
                        }

                    }
                    var timeDelay = action.TimeDelay;
                    var MontagePathName = montage?.PathName;
                    if (action.TimeDelay > 1)
                    {
                        timeDelay = (int)(action.TimeDelay / playRate);
                    }

                    if (action.TimeDelay > 0)
                    {
                        Task.Run(async () =>
                        {
                            try
                            {
                                await Task.Delay(timeDelay);
                                Utils.TryRunOnGameThread((Action)async delegate
                                {
                                    var currMontage = Manager.GetCurrentMontage();
                                    var character = Helper.GetBGUPlayerCharacterCS();
                                    // 获取动画实例
                                    if (character == null)
                                    {
                                        return;
                                    }
                                    if (character?.Mesh == null)
                                    {
                                        return;
                                    }
                                    var animInstance = character.Mesh.GetAnimInstance();
                                    if (animInstance == null)
                                    {
                                        return;
                                    }
                                    float currentPosition = 0;
                                    if (montage != null)
                                    {
                                        // 获取动画当前播放时间
                                        currentPosition = animInstance.Montage_GetPosition(montage);
                                    }

                                    if (ruleItem != null && montage != null)
                                    {
                                        if (!ruleItem.IsMatchMontage(currMontage))
                                        {
                                            return;
                                        }
                                        // 加个误差值
                                        var diff = 150;
                                        if (currentPosition > 0 && currentPosition * 1000 >= timeDelay - diff)
                                        {
                                            DoAction(action, timeLength / playRate);
                                        }
                                        else
                                        {
                                            // 处理时缓导致的动画变慢，还没播放到定义的时间点的情况
                                            if (currentPosition > 0 && timeDelay - currentPosition * 1000 > diff)
                                            {
                                                await Task.Delay((int)(timeDelay - currentPosition * 1000));
                                                DoAction(action, timeLength / playRate);
                                                return;
                                            }
                                            DoAction(action, timeLength / playRate);
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        DoAction(action, timeLength / playRate);
                                    }

                                });
                            }
                            catch (Exception e)
                            {
                                Log.Error($"执行 action.TimeDelay 报错 {e?.Message}");
                            }
                        });
                    }
                    else
                    {
                        DoAction(action, timeLength / playRate);
                    }
                }
            }
            return true;
        }

        public bool IsMatchBuff(int buffID)
        {
            if (Filters != null && Filters.Count > 0)
            {
                for (int i = 0; i < Filters.Count; i++)
                {
                    var filter = Filters[i];
                    if (filter.Type == "buff")
                    {
                        if (filter.BuffID == buffID)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
