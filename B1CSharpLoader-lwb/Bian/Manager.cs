using b1.EventDelDefine;
using b1;
using CSharpModBase;
using HarmonyLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using System.Reflection;
using System.Linq;

namespace bian
{
    [HarmonyPatch]
    public static class Manager
    {

        private static ModelManager manager;
        private static Harmony harmony;
        private static Ui UI;

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


        [HarmonyPatch(typeof(GSDel_RequestSpawnAProjectile), "Invoke")]
        [HarmonyPrefix]
        private static void GSDel_RequestSpawnAProjectileInvoke(ref FGSProjectileSpawnInfo ProjectileSpawnInfo)
        {
            // if (Manager.GetModelManager().Config.CanLogDebug("[PATCH]RequestSpawnAProjectile"))
            // {
            //     Log.Debug(
            //     $"bain:[PATCH]GSDel_RequestSpawnAProjectile --> \n=======ProjectileID:{ProjectileSpawnInfo.ProjectileID} " +
            //     $"\n=======BornDir:{ProjectileSpawnInfo.BornDir} " +
            //     $"\n=======AttachRule_Rot:{ProjectileSpawnInfo.AttachRule_Rot}  " +
            //     $"\n=======AttachToSpawnBase_SocketName:{ProjectileSpawnInfo.AttachToSpawnBase_SocketName}  " +
            //     $"\n=======SpawnPosition:{ProjectileSpawnInfo.SpawnPosition}  " +
            //     $"\n=======SpawnPosition:{ProjectileSpawnInfo.SpawnPosition}  " +
            //     $"\n=======TargetPos:{ProjectileSpawnInfo.TargetPos}  " +
            //     $"\n=======AttachToSpawnBase_SpawnBaseActor:{ProjectileSpawnInfo.AttachToSpawnBase_SpawnBaseActor}  " +
            //     $"\n=======ProjectileType:{ProjectileSpawnInfo.ProjectileType} " +
            //     $"\n=======SkillID:{ProjectileSpawnInfo.SkillID}" +
            //     $"\n=======SkillID:{ProjectileSpawnInfo.SkillID}");
            // }

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
                                ruleItem.DoRule(Duration);
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

            if (Manager.GetModelManager().Config.CanLogDebug("[PATCH]CastSkillWithAnimMontageMultiCast"))
            {
                // Log.Debug($"bian: [PATCH]CastSkillWithAnimMontageMultiCast-->Montage:{Montage.PathName}  PlayTimeRate:{PlayTimeRate}  MontagePosOffset:{MontagePosOffset} StartSectionName:{StartSectionName}");
            }

            if (!IsPlayer(__instance.GetOwner().PathName))
            {
                return;
            }
            /*var model = manager.GetCurrentModel(__instance.GetOwner() as BGUPlayerCharacterCS) as BaseModel;
            if (model != null && model.PlayTimeRate != 1 && model.PlayTimeRate > 0) {
                PlayTimeRate = model.PlayTimeRate;
            }

            var fName = Montage.PathName.Split('.').Last().ToLower();
            var skillID = ModelManager.GetSkillIDByFName(fName);
            Log.Debug($"bian: [PATCH]CastSkillWithAnimMontageMultiCast,change play time rate start-->Montage:{fName}  PlayTimeRate:{PlayTimeRate}");
            if (skillID > 0) {
                
                Log.Debug($"bian: [PATCH]CastSkillWithAnimMontageMultiCast,change play time rate start2-->Montage:{fName}  PlayTimeRate:{PlayTimeRate}");
                if (model != null && model.Skills != null && model.Skills.Count > 0)
                {
                    Log.Debug($"bian: [PATCH]CastSkillWithAnimMontageMultiCast,change play time rate start3-->Montage:{fName}  PlayTimeRate:{PlayTimeRate}");
                    for (int i = 0; i < model.Skills.Count; i++) {
                        var skill = model.Skills[i];
                        if (skill.Id == skillID) {
                            if (skill.PlayTimeRate != 1 && skill.PlayTimeRate > 0) {
                                PlayTimeRate = skill.PlayTimeRate;
                                Log.Debug($"bian: [PATCH]CastSkillWithAnimMontageMultiCast,change play time rate-->Montage:{fName}  PlayTimeRate:{PlayTimeRate}");
                                break;
                            }
                        }
                    }
                }
            }
            
*/
            var mgr = Manager.GetModelManager();
            var currentModel = mgr.GetCurrentModel(__instance.GetOwner() as BGUPlayerCharacterCS) as BaseModel;
            var length = Montage.GetPlayLength() * 1000;
            var playRate = 1f;
            if (currentModel != null && currentModel.PlayTimeRate > 0)
            {
                playRate = currentModel.PlayTimeRate;
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
                                // Log.Info($"bian: CastSkillWithAnimMontageMultiCast find matched rule {rule.path},start run rule!");
                                ruleItem.DoRule(length, playRate);
                            }
                        }
                    }
                }
            }
        }

        [HarmonyPatch(typeof(BUS_GSEventCollection), "Evt_SmartCastSkillTryMultiCast_Implementation")]
        [HarmonyPrefix]
        private static void SmartCastSkillTryMultiCast(int ID)
        {
            if (Manager.GetModelManager().Config.CanLogDebug("[PATCH]SmartCastSkill"))
            {
                // Log.Info($"bian: SmartCastSkillTryMultiCast -->{ID}");
            }
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
