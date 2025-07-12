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
        public static string currentMontage;
        [HarmonyPatch(typeof(BUS_GSEventCollection), "Evt_CastSkillWithAnimMontageMultiCast_Implementation")]
        [HarmonyPrefix]
        private static void CastSkillWithAnimMontageMultiCast(BUS_GSEventCollection __instance, ref UAnimMontage Montage, ref float PlayTimeRate, float MontagePosOffset, FName StartSectionName)
        {

            if (Manager.GetModelManager().Config.CanLogDebug("[PATCH]CastSkillWithAnimMontageMultiCast"))
            {
                Log.Info($"bian: 执行动画 -->{Montage.PathName} {Montage.SequenceLength}");
            }

            if (!IsPlayer(__instance.GetOwner().PathName))
            {
                return;
            }

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
            currentMontage = Montage.PathName;
            handleLoopExecution(null, length, playRate, Montage.PathName, Montage.SequenceLength);
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


                                if (ruleItem?.speedRate > 0)
                                {
                                    PlayTimeRate_ = (float)ruleItem.speedRate; //动画播放速率
                                }
                                if ((ruleItem?.isLoop) == true)
                                {
                                    // 循环执行 DoRule
                                    handleLoopExecution(ruleItem, length, playRate, Montage.PathName, Montage.SequenceLength);
                                }
                                else
                                {
                                    ruleItem.DoRule(length, playRate, Montage.PathName, ruleItem);

                                }
                            }
                        }
                    }
                }
            }

            PlayTimeRate = PlayTimeRate_;
        }

        private static void handleLoopExecution(Rule ruleItem, float length, float playRate, string montagePath, float SequenceLength)
        {

            // 使用 Task 在后台循环执行
            var loopTask = currentMontage != montagePath ? null : Task.Run(async () =>
                  {
                      // 获取循环间隔时间（可以根据动画长度调整）
                      int intervalMs = (int)(length / SequenceLength);

                      Log.Info($"bian: 开始循环执行技能 -->{montagePath}, 间隔:{intervalMs}ms");
                      if (currentMontage != montagePath || ruleItem == null)
                      {
                          return;
                      }
                      try
                      {
                          // 首次执行
                          Utils.TryRunOnGameThread(() =>
                          {
                              var method = ruleItem.GetType().GetMethod("DoRule");
                              method?.Invoke(ruleItem, new object[] { length, playRate, montagePath, ruleItem });
                          });

                          // 循环执行
                          while (currentMontage == montagePath)
                          {
                              await Task.Delay(intervalMs);

                              Utils.TryRunOnGameThread(() =>
                              {
                                  ruleItem.DoRule(length, playRate, montagePath, ruleItem);
                              });
                          }
                      }
                      catch (Exception e)
                      {

                          Log.Error($"bian: 循环执行技能出错 -->{montagePath}, {e}");
                      }


                  });
        }


        [HarmonyPatch(typeof(BUS_GSEventCollection), "Evt_SmartCastSkillTryMultiCast_Implementation")]
        [HarmonyPrefix]
        private static void SmartCastSkillTryMultiCast(int ID)
        {
            if (Manager.GetModelManager().Config.CanLogDebug("[PATCH]SmartCastSkill"))
            {
                // Log.Info($"bian: 真实的id SmartCastSkillTryMultiCast -->{ID}");
            }
            var character = Helper.GetBGUPlayerCharacterCS();
            var bufferId = 20101;

            if (ID == 10801)
            {
                // 平A1
                bufferId = 20101;
            }
            if (ID == 10802)
            {
                // 平A2
                bufferId = 20102;
            }
            if (ID == 10803)
            {
                // 平A3
                bufferId = 20103;
            }
            if (ID == 10804)
            {
                // 平A4
                bufferId = 20104;
            }
            if (ID == 10705 || ID == 10706 || ID == 50001 || ID == 50003 || ID == 50005 || ID == 10721 || ID == 10720)
            {
                BGUFunctionLibraryCS.BGUAddBuff(character, character, 289, EBuffSourceType.GM, 3000);
            }
            if (bufferId > 0)
            {
                BGUFunctionLibraryCS.BGUAddBuff(character, character, bufferId, EBuffSourceType.GM, 4000);
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
