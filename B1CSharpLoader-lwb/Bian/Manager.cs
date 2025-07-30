using b1.EventDelDefine;
using b1;
using CSharpModBase;
using HarmonyLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using System.Reflection;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using BtlShare;
using ArchiveB1;

public enum SkillMapCondition
{
    StancePoke,    // 戳棍姿态
    StanceProp,//立棍
    StanceHeavy,//劈棍
    hasBuff,
    disTance,
    any,//无条件转化
}

public class SkillMappingRule
{
    public int OriginalId { get; set; }
    public int MappedId { get; set; }
    public SkillMapCondition Condition { get; set; }
    public int? conditionValue { get; set; } // 可选：需要的buff 或者距离
    public string? desc { get; set; }//描述
}

namespace bian
{
    [HarmonyPatch]
    public static class Manager
    {

        private static ModelManager manager;
        private static Harmony harmony;
        private static Ui UI;

        public static string? currentMontage;
        private static BuffDescRuntime DescRuntime;
        public static string Nameo;

        public static ModelManager GetModelManager()
        {
            if (manager == null)
            {
                manager = new ModelManager();
            }
            return manager;
        }

        public static void CreateUi()
        {
            if (UI == null)
            {
                UI = new Ui();
            }
            UI.CreateUI();
        }

        public static void RegisterManager()
        {
            Manager.GetModelManager().InitConfig();
            Manager.GetModelManager().BindEvents();

            if (harmony == null)
            {
                harmony = new Harmony("mod.reece.bian");
                var assembly = Assembly.GetExecutingAssembly();
                harmony.PatchAll(assembly);
            }
        }

        public static void UnregisterManager()
        {
            Manager.GetModelManager().UnRegEvent();
            if (harmony != null)
            {
                harmony.UnpatchAll();
            }
        }

        public static string GetCurrentMontage()
        {
            if (currentMontage == null)
            {
                return "";
            }
            return currentMontage;
        }
        [HarmonyPatch(typeof(GSDel_RequestSpawnAProjectile), "Invoke")]
        [HarmonyPrefix]
        private static void GSDel_RequestSpawnAProjectileInvoke(ref FGSProjectileSpawnInfo ProjectileSpawnInfo)
        {
            if (Manager.GetModelManager().Config.CanLogDebug("[PATCH]RequestSpawnAProjectile"))
            {
                if (ProjectileSpawnInfo.ProjectileID == 1085601)
                {
                    Log.Info($"RequestSpawnAProjectile 飞棍 SkillID:{ProjectileSpawnInfo.SkillID} SpawnPosition:{ProjectileSpawnInfo.SpawnPosition}");
                }
            }

        }

        [HarmonyPatch(typeof(BUS_GSEventCollection), "Evt_BuffAdd_Multicast_Invoke")]
        [HarmonyPrefix]
        private static void BuffAdd_Multicast(ref int BuffID, AActor Caster, AActor RootCaster, ref float Duration)
        {
            if (Manager.GetModelManager().Config.CanLogDebug("[PATCH]BuffAdd_Multicast"))
            {
                if (BuffID != 1015)
                {
                }

            }

            if (Caster == null || !IsPlayer(Caster.PathName))
            {
                return;
            }

            // 冰火雷毒buff互斥
            List<int> buffers = [888666005, 888666006, 888666007, 888666008];
            if (buffers.Contains(BuffID))
            {
                foreach (var buffer in buffers)
                {
                    if (buffer != BuffID)
                    {
                        BGUFunctionLibraryCS.BGURemoveBuffImmediately(Caster, buffer, EBuffEffectTriggerType.Remove);
                    }
                }
            }

            var mgr = Manager.GetModelManager();
            if (mgr.Rules != null && mgr.Rules.Count > 0)
            {
                for (int i = 0; i < mgr.Rules.Count; i++)
                {
                    var rule = mgr.Rules[i];
                    if (rule.Rules != null && rule.Rules.Count > 0)
                    {
                        for (int j = 0; j < rule.Rules.Count; j++)
                        {
                            var ruleItem = rule.Rules[j];
                            if (ruleItem.IsMatchBuff(BuffID))
                            {
                                var Duration_ = Duration > 0 ? Duration : 1000;
                                ruleItem.DoRule(Duration_, 1, null, null);
                            }
                        }
                    }
                }
            }

        }

        private static bool IsPlayer(string name)
        {
            if (name != null && name.ToLower().IndexOf("unit_player") > -1)
            {
                return true;
            }
            return false;
        }

        [HarmonyPatch(typeof(BUS_GSEventCollection), "Evt_CastSkillWithAnimMontageMultiCast_Implementation")]
        [HarmonyPrefix]
        private static void CastSkillWithAnimMontageMultiCast(BUS_GSEventCollection __instance, ref UAnimMontage Montage, ref float PlayTimeRate, float MontagePosOffset, FName StartSectionName)
        {

            // if (Manager.GetModelManager().Config.CanLogDebug("[PATCH]CastSkillWithAnimMontageMultiCast"))
            // {
            //  }

            if (!IsPlayer(__instance.GetOwner().PathName))
            {
                return;
            }


            currentMontage = Montage.PathName;
            var mgr = Manager.GetModelManager();
            var currentModel = mgr.GetCurrentModel(__instance.GetOwner() as BGUPlayerCharacterCS) as BaseModel;
            var length = Montage.GetPlayLength() * 1000;
            var playRate = 1f;


            if (currentModel != null && currentModel.PlayTimeRate > 0)
            {
                playRate = currentModel.PlayTimeRate;
            }
            var PlayTimeRate_ = PlayTimeRate;
            if (currentModel?.skillSpeedRate > 0)
            {
                PlayTimeRate_ = (float)currentModel.skillSpeedRate; //动画播放速率
            }

            if (mgr.Rules != null && mgr.Rules.Count > 0)
            {

                for (int i = 0; i < mgr.Rules.Count; i++)
                {
                    var rule = mgr.Rules[i];
                    if (rule.Rules != null && rule.Rules.Count > 0)
                    {
                        for (int j = 0; j < rule.Rules.Count; j++)
                        {
                            var ruleItem = rule.Rules[j];
                            if (Montage != null && ruleItem.IsMatchMontage(Montage.PathName))
                            {
                                if (ruleItem?.skillID_fs > 0)
                                {
                                    Helper.FenshenGSTryCastSkill((int)ruleItem.skillID_fs, false);
                                }
                                else
                                {
                                    Helper.FenshenGSTryCastSkill((int)0, false);
                                }

                                if (ruleItem?.speedRate > 0)
                                {
                                    PlayTimeRate_ = (float)ruleItem.speedRate; //动画播放速率
                                }
                                ruleItem.DoRule(length, playRate, Montage, ruleItem);
                            }
                        }
                    }
                }
            }
            else
            {
                Helper.FenshenGSTryCastSkill(0, false);
            }

            PlayTimeRate = PlayTimeRate_;
        }


        private static readonly List<SkillMappingRule> SkillMappingRules = new List<SkillMappingRule>
        {
            new SkillMappingRule { OriginalId = 10801, MappedId = 10701, Condition = SkillMapCondition.StancePoke, desc="戳棍下,棍的平A变成枪平A"},
            new SkillMappingRule { OriginalId = 10801, MappedId = 50011, Condition = SkillMapCondition.any, desc="无条件，转成大圣平A"},


            new SkillMappingRule { OriginalId = 10802, MappedId = 10702, Condition = SkillMapCondition.StancePoke, desc="戳棍下,棍的平A变成枪平A"},
            new SkillMappingRule { OriginalId = 10802, MappedId = 50012, Condition = SkillMapCondition.any, desc="无条件，转成大圣平A"},


            new SkillMappingRule { OriginalId = 10803, MappedId = 10703, Condition = SkillMapCondition.StancePoke, desc="戳棍下,棍的平A变成枪平A"},
            new SkillMappingRule { OriginalId = 10803, MappedId = 50013, Condition = SkillMapCondition.any, desc="无条件，转成大圣平A"},


            new SkillMappingRule { OriginalId = 10804, MappedId = 10704, Condition = SkillMapCondition.StancePoke, desc="戳棍下,棍的平A变成枪平A"},
            new SkillMappingRule { OriginalId = 10804, MappedId = 50014, Condition = SkillMapCondition.any, desc="无条件，转成大圣平A"},


            new SkillMappingRule { OriginalId = 10805, MappedId = 10715, Condition = SkillMapCondition.StancePoke, desc="戳棍下, Q5变无豆进尺"},
            new SkillMappingRule { OriginalId = 10805, MappedId = 50015, Condition = SkillMapCondition.any, desc="无条件，转成大圣平A"},

            new SkillMappingRule { OriginalId = 10705, MappedId = 50001, Condition = SkillMapCondition.hasBuff, conditionValue=888666021, desc="10705转成大圣Q1切手"},
            new SkillMappingRule { OriginalId = 10705, MappedId = 50003, Condition = SkillMapCondition.hasBuff, conditionValue=888666022, desc="10705转成大圣Q2切手"},
            new SkillMappingRule { OriginalId = 10705, MappedId = 50005, Condition = SkillMapCondition.hasBuff, conditionValue=888666023, desc="10705转成大圣Q3切手"},
            new SkillMappingRule { OriginalId = 10705, MappedId = 50007, Condition = SkillMapCondition.hasBuff, conditionValue=888666024, desc="10705转成大圣Q4切手"},


            new SkillMappingRule { OriginalId = 10706, MappedId = 50001, Condition = SkillMapCondition.hasBuff, conditionValue=888666021, desc="10705转成大圣Q1切手"},
            new SkillMappingRule { OriginalId = 10706, MappedId = 50003, Condition = SkillMapCondition.hasBuff, conditionValue=888666022, desc="10705转成大圣Q2切手"},
            new SkillMappingRule { OriginalId = 10706, MappedId = 50005, Condition = SkillMapCondition.hasBuff, conditionValue=888666023, desc="10705转成大圣Q3切手"},
            new SkillMappingRule { OriginalId = 10706, MappedId = 50007, Condition = SkillMapCondition.hasBuff, conditionValue=888666024, desc="10705转成大圣Q4切手"},



            new SkillMappingRule { OriginalId = 10707, MappedId = 50002, Condition = SkillMapCondition.hasBuff, conditionValue=888666021, desc="10705转成大圣Q1切手"},
            new SkillMappingRule { OriginalId = 10707, MappedId = 50004, Condition = SkillMapCondition.hasBuff, conditionValue=888666022, desc="10705转成大圣Q2切手"},
            new SkillMappingRule { OriginalId = 10707, MappedId = 50006, Condition = SkillMapCondition.hasBuff, conditionValue=888666023, desc="10705转成大圣Q3切手"},
            new SkillMappingRule { OriginalId = 10707, MappedId = 50008, Condition = SkillMapCondition.hasBuff, conditionValue=888666024, desc="10705转成大圣Q4切手"},

            new SkillMappingRule { OriginalId = 10708, MappedId = 50002, Condition = SkillMapCondition.hasBuff, conditionValue=888666021, desc="10705转成大圣Q1切手"},
            new SkillMappingRule { OriginalId = 10708, MappedId = 50004, Condition = SkillMapCondition.hasBuff, conditionValue=888666022, desc="10705转成大圣Q2切手"},
            new SkillMappingRule { OriginalId = 10708, MappedId = 50006, Condition = SkillMapCondition.hasBuff, conditionValue=888666023, desc="10705转成大圣Q3切手"},
            new SkillMappingRule { OriginalId = 10708, MappedId = 50008, Condition = SkillMapCondition.hasBuff, conditionValue=888666024, desc="10705转成大圣Q4切手"},

        };

        [HarmonyPatch(typeof(BUS_GSEventCollection), "Evt_SmartCastSkillTryMultiCast_Implementation")]
        [HarmonyPrefix]
        private static void SmartCastSkillTryMultiCast(ref int ID, ref List<int> RuleIDList)
        {
            if (Manager.GetModelManager().Config.CanLogDebug("[PATCH]SmartCastSkill"))
            {
                // Log.Info($"bian: 真实的id SmartCastSkillTryMultiCast -->{ID}");
            }
            var character = Helper.GetBGUPlayerCharacterCS();
            var bufferId = 20101;

            var control = Helper.GetPlayerController();

            var readOnlyData = BGU_DataUtil.GetPlayerControlReadonlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(control);
            var stance = readOnlyData?.RoleData?.RoleCs?.Actor?.Wear?.Stance;//当前棍法
            var isChuogun = stance == Stance.Poke;
            var isLigun = stance == Stance.Prop;
            var isPigun = stance == Stance.Heavy;

            var currentId = ID;
            if (readOnlyData != null)
            {
                Log.Info($"Evt_CastSkillWithAnimMontageMultiCast  {stance}");

            }
            if (ID == 10801)
            {
                // 平A1
                bufferId = 888666021;
            }
            if (ID == 10802)
            {
                // 平A2
                BGUFunctionLibraryCS.BGURemoveBuffImmediately(character, 888666021, EBuffEffectTriggerType.Remove);
                bufferId = 888666022;
            }
            if (ID == 10803)
            {
                // 平A3
                BGUFunctionLibraryCS.BGURemoveBuffImmediately(character, 888666022, EBuffEffectTriggerType.Remove);
                bufferId = 888666023;
            }
            if (ID == 10804)
            {
                // 平A4
                BGUFunctionLibraryCS.BGURemoveBuffImmediately(character, 888666023, EBuffEffectTriggerType.Remove);
                bufferId = 888666024;
            }
            if (ID == 10805)

            {
                // 平A5
                BGUFunctionLibraryCS.BGURemoveBuffImmediately(character, 888666024, EBuffEffectTriggerType.Remove);
                bufferId = 888666025;

            }
            if (new int[] { 10705, 10706, 10720, 10721, 50003, 50005, 50007, 50001 }.Contains(ID))
            {
                BGUFunctionLibraryCS.BGUAddBuff(character, character, 289, EBuffSourceType.GM, 3000);
            }

            if (bufferId > 0)
            {
                BGUFunctionLibraryCS.BGUAddBuff(character, character, bufferId, EBuffSourceType.GM, 4000);
            }

            var applicableRules = SkillMappingRules.Where(r => r.OriginalId == currentId);
            if (applicableRules.Count() > 0)
            {
                var target = BGUFunctionLibraryCS.BGUGetTarget(character) as BGUCharacterCS;
                var matchItem = applicableRules.FirstOrDefault(r => r.Condition == SkillMapCondition.StancePoke && isChuogun || r.Condition == SkillMapCondition.hasBuff && r.conditionValue > 0 && BGUFunctionLibraryCS.BGUHasBuffByID(character, (int)r.conditionValue) || r.Condition == SkillMapCondition.disTance && r.conditionValue >= 0 && target != null && character.GetDistanceTo(target) >= r.conditionValue || r.Condition == SkillMapCondition.any);
                if (matchItem != null)
                {
                    ID = matchItem.MappedId;
                }
            }
        }



        [HarmonyPatch(typeof(BUEffectSpawnBullets), "ApplyByBuff_Implement")]
        [HarmonyPrefix]
        private static bool ApplyByBuff_Implement(ref BuffInstData BuffInst, ref AActor Target, ref int EffectIdx, ref bool bIsPeriodical)
        {
            if (BuffInst == null)
            {
                return false;
            }
            int buffID = BuffInst.BuffID;
            FUStBuffDesc originalBuffDesc = BGW_GameDB.GetOriginalBuffDesc(buffID);
            IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(EntitySharedRefFuncLib.Actor(BuffInst.RootCasterRef));
            if (originalBuffDesc != null)
            {
                DescRuntime = new BuffDescRuntime(buffID, readOnlyData, originalBuffDesc);
            }
            FSpawnBulletMinMaxValue x = default(FSpawnBulletMinMaxValue);
            FSpawnBulletMinMaxValue y = default(FSpawnBulletMinMaxValue);
            FSpawnBulletMinMaxValue z = default(FSpawnBulletMinMaxValue);
            int intEffectParam = DescRuntime.GetIntEffectParam(EffectIdx, 0);
            int intEffectParam2 = DescRuntime.GetIntEffectParam(EffectIdx, 1);
            int intEffectParam3 = DescRuntime.GetIntEffectParam(EffectIdx, 2);
            int intEffectParam4 = DescRuntime.GetIntEffectParam(EffectIdx, 3);
            int intEffectParam5 = DescRuntime.GetIntEffectParam(EffectIdx, 4);
            int intEffectParam6 = DescRuntime.GetIntEffectParam(EffectIdx, 5);
            Nameo = DescRuntime.GetStringEffectParam(EffectIdx, 0);
            int intEffectParam7 = DescRuntime.GetIntEffectParam(EffectIdx, 6);
            float floatEffectParam = DescRuntime.GetFloatEffectParam(EffectIdx, 0);
            float floatEffectParam2 = DescRuntime.GetFloatEffectParam(EffectIdx, 1);
            float floatEffectParam3 = DescRuntime.GetFloatEffectParam(EffectIdx, 2);
            float floatEffectParam4 = DescRuntime.GetFloatEffectParam(EffectIdx, 3);
            float floatEffectParam5 = DescRuntime.GetFloatEffectParam(EffectIdx, 4);
            float floatEffectParam6 = DescRuntime.GetFloatEffectParam(EffectIdx, 5);
            float floatEffectParam7 = DescRuntime.GetFloatEffectParam(EffectIdx, 6);
            MyUtils.sm = Nameo;
            z.LeftValue = DescRuntime.GetIntEffectParam(EffectIdx, 7);
            z.RightValue = DescRuntime.GetIntEffectParam(EffectIdx, 8);
            z.IsEquidistance = true;
            MyUtils.SpwanProjectileByTracker3(intEffectParam, (MyUtils.ETrackType)intEffectParam2, intEffectParam3, new FVector((double)floatEffectParam, (double)floatEffectParam2, (double)floatEffectParam3), new FVector((double)floatEffectParam4, (double)floatEffectParam5, (double)floatEffectParam6), x, y, z, floatEffectParam7, intEffectParam4, intEffectParam5, intEffectParam6, intEffectParam7 == 1);
            return true;
        }
        /*[HarmonyPatch(typeof(UInputPreProcEvent), "OnAnyKeyTriggerEvent")]
        [HarmonyPrefix]
        private static void OnAnyKeyTriggerEvent(FKey Key)
        {
            Log.Debug($"bian: [PATCH]OnAnyKeyTriggerEvent  --> {Key.GetFName()}");
        }*/

        /*[HarmonyPatch(typeof(BUS_MagicallyChangeComp), "OnCastMagicallyChangeSkill")]
        [HarmonyPrefix]
        private static void OnCastMagicallyChangeSkill(BGWDataAsset_MagicallyChangeConfig Config, int SkillID, int RecoverSkillID, BUS_MagicallyChangeComp __instance)
        {
            Log.Debug($"bian: [PATCH]OnCastMagicallyChangeSkill  --> SkillID:{SkillID} Config:{Config.PathName} RecoverSkillID: {RecoverSkillID}");
        }

        [HarmonyPatch(typeof(BUS_MagicallyChangeComp), "DoCastMagicallyChangeSkill")]
        [HarmonyPrefix]
        private static void DoCastMagicallyChangeSkill(UBGWDataAsset Config, int SkillID, int RecoverSkillID, BUS_MagicallyChangeComp __instance)
        {
            Log.Debug($"bian: [PATCH]OnCastMagicallyChangeSkill  --> SkillID:{SkillID} Config:{Config.PathName} RecoverSkillID: {RecoverSkillID}");
        }*/
    }
}
