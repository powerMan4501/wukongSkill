using b1;
using CSharpModBase;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnrealEngine.Runtime;

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
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Filter> Filters { get; set; }
        public List<RuleAction> AfterActions { get; set; }


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
                        // Log.Info($"bian: start run rule action: add-buff {action.BuffID}");
                        BGUFunctionLibraryCS.BGUAddBuff(character, character, action.BuffID, EBuffSourceType.GM, timeLength);
                    }
                    break;
                case "skill":
                    if (action.SkillID > 0)
                    {
                        // Log.Info($"bian: start run rule action: cast-skill {action.SkillID}");
                        //BUS_EventCollectionCS.Get(character).Evt_RequestSmartCastSkill.Invoke(action.SkillID, null, EMontageBindReason.Default, false);
                        //var csi = new FCastSkillInfo(action.SkillID, ECastSkillSourceType.Notify);
                        //csi.NeedCheckSkillCanCast = false;
                        //BUS_EventCollectionCS.Get(character)?.Evt_UnitCastSkillTry.Invoke(csi);
                        BUS_EventCollectionCS.Get(character).Evt_RequestSmartCastSkill.Invoke(action.SkillID, null, EMontageBindReason.NormalSkill, false);
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

        public bool DoRule(float timeLength = 1000, float playRate = 1)
        {
            if (AfterActions != null)
            {

                for (int i = 0; i < AfterActions.Count; i++)
                {


                    var action = AfterActions[i];

                    var character = Helper.GetBGUPlayerCharacterCS();

                    // 如果设置了buff条件，就校验是否有对应的buff
                    if (action.buffCondition > 0)
                    {
                        if (!BGUFunctionLibraryCS.BGUHasBuffByID(character, action.buffCondition))
                        {

                            Console.WriteLine($"has no buff {action.buffCondition} {action.desc}");
                            continue;
                        }
                    }


                    if (action.noBuffCondition > 0)
                    {
                        if (BGUFunctionLibraryCS.BGUHasBuffByID(character, action.noBuffCondition))

                        {

                            Console.WriteLine($"has buff {action.noBuffCondition}  {action.desc}");
                            continue;
                        }
                    }

                    if (action.noTalentCondition > 0)
                    {
                        if (BGUFunctionLibraryCS.BGUHasTalentByID(character, action.noTalentCondition))
                        {
                            Console.WriteLine($"has talent {action.noTalentCondition}");
                            continue;
                        }
                    }

                    // 如果设置了天赋条件，就校验是否有对应的天赋
                    if (action.talentCondition > 0)
                    {
                        if (!BGUFunctionLibraryCS.BGUHasTalentByID(character, action.talentCondition))
                        {
                            Console.WriteLine($"has no talent {action.talentCondition}");
                            continue;
                        }
                    }
                    if (action.Type.ToLower() == "skill" && action.TimeDelay <= 0)
                    {
                        action.TimeDelay = 1;
                    }

                    var timeDelay = action.TimeDelay;
                    if (action.TimeDelay > 1)
                    {
                        timeDelay = (int)(action.TimeDelay / playRate);
                    }
                    if (action.TimeDelay > 0)
                    {
                        Task.Run(async () =>
                        {
                            await Task.Delay(timeDelay);
                            Utils.TryRunOnGameThread((Action)delegate
                            {
                                DoAction(action, timeLength / playRate);
                            });
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
