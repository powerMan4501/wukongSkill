using b1;
using BtlShare;
using CSharpModBase;
using System;
using System.Collections.Generic;
using System.Linq;
using UnrealEngine.Engine;

namespace bian
{
    public class Commands
    {
        public static int index = 0;
        public static int offset = 0;
        public static int prevIndex = 0;
        public static int ShieldMax = 6000;
        public static int SkillSuperArmor = 20000;

        public void MaiDongHuiLai(ModelManager? manager)
        {

            var character = Helper.GetBGUPlayerCharacterCS();
            if (character == null) return;
            var meshName = character?.Mesh?.SkeletalMesh?.GetFullName();
            IBUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(character);
            BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(character);
            if (bUS_GSEventCollection == null) return;
            if (character?.Mesh?.SkeletalMesh?.GetFullName()?.ToLower()?.IndexOf("SK_Wukong_Simple".ToLower()) > -1)
            {

                if (readOnlyData != null)
                {
                    bUS_GSEventCollection.Evt_SetAttrFloat?.Invoke(EBGUAttrFloat.Mp, readOnlyData.GetFloatValue(EBGUAttrFloat.MpMax));
                    bUS_GSEventCollection.Evt_SetAttrFloat?.Invoke(EBGUAttrFloat.Hp, readOnlyData.GetFloatValue(EBGUAttrFloat.HpMax));
                    bUS_GSEventCollection.Evt_SetAttrFloat?.Invoke(EBGUAttrFloat.Stamina, readOnlyData.GetFloatValue(EBGUAttrFloat.StaminaMax));
                    bUS_GSEventCollection.Evt_SetAttrFloat?.Invoke(EBGUAttrFloat.SpecialEnergy, readOnlyData.GetFloatValue(EBGUAttrFloat.SpecialEnergyMax));
                    bUS_GSEventCollection.Evt_SetAttrFloat?.Invoke(EBGUAttrFloat.VigorEnergy, readOnlyData.GetFloatValue(EBGUAttrFloat.VigorEnergyMax));
                    bUS_GSEventCollection.Evt_SetAttrFloat?.Invoke(EBGUAttrFloat.FabaoEnergy, readOnlyData.GetFloatValue(EBGUAttrFloat.FabaoEnergyMax));
                    bUS_GSEventCollection.Evt_SetAttrFloat?.Invoke(EBGUAttrFloat.BloodBottomNum, readOnlyData.GetFloatValue(EBGUAttrFloat.BloodBottomNumMax));
                    bUS_GSEventCollection.Evt_SetAttrFloat?.Invoke(EBGUAttrFloat.BlockCollapseArmor, readOnlyData.GetFloatValue(EBGUAttrFloat.BlockCollapseArmorMax));
                    bUS_GSEventCollection.Evt_SetAttrFloat?.Invoke(EBGUAttrFloat.Shield, readOnlyData.GetFloatValue(EBGUAttrFloat.ShieldMax));
                    bUS_GSEventCollection.Evt_SetAttrFloat?.Invoke(EBGUAttrFloat.SkillSuperArmor, readOnlyData.GetFloatValue(EBGUAttrFloat.SkillSuperArmorMax));
                    bUS_GSEventCollection.Evt_IncreaseAttrFloat?.Invoke(EBGUAttrFloat.Pevalue, 100);
                    bUS_GSEventCollection.Evt_IncreaseAttrFloat?.Invoke(EBGUAttrFloat.CommDropAddition, 10000);

                }



                // BGUFunctionLibraryCS.BGUSetAttrValue(character, EBGUAttrFloat.BlockCollapseArmor, ShieldMax);
                // BGUFunctionLibraryCS.BGUSetAttrValue(character, EBGUAttrFloat.ShieldMax, ShieldMax);
                // BGUFunctionLibraryCS.BGUSetAttrValue(character, EBGUAttrFloat.Shield, ShieldMax);
                // BGUFunctionLibraryCS.BGUSetAttrValue(character, EBGUAttrFloat.SkillSuperArmorMax, SkillSuperArmor);
                // BGUFunctionLibraryCS.BGUSetAttrValue(character, EBGUAttrFloat.SkillSuperArmor, SkillSuperArmor);

            }
            else
            {
                bUS_GSEventCollection.Evt_IncreaseAttrFloat?.Invoke(EBGUAttrFloat.Mp, readOnlyData.GetFloatValue(EBGUAttrFloat.MpMax));
                bUS_GSEventCollection.Evt_IncreaseAttrFloat?.Invoke(EBGUAttrFloat.Hp, readOnlyData.GetFloatValue(EBGUAttrFloat.HpMax));
                bUS_GSEventCollection.Evt_IncreaseAttrFloat?.Invoke(EBGUAttrFloat.Pevalue, 100);
                bUS_GSEventCollection.Evt_IncreaseAttrFloat?.Invoke(EBGUAttrFloat.SpecialEnergy, 100);
                bUS_GSEventCollection.Evt_IncreaseAttrFloat?.Invoke(EBGUAttrFloat.CurEnergy, 100);
                bUS_GSEventCollection.Evt_IncreaseAttrFloat?.Invoke(EBGUAttrFloat.Pelevel, 100);
                bUS_GSEventCollection.Evt_SetAttrFloat?.Invoke(EBGUAttrFloat.Shield, 1000);

            }

            // BGUFunctionLibraryCS.BGUAddBuff(character, character, 450, EBuffSourceType.GM, 250);

        }

        public void SetActorTimeLineSpeed(ModelManager manager, float rate)
        {
            // Log.Debug("bian: trigger SetGMCustomTimeDilation!");
            var character = Helper.GetBGUPlayerCharacterCS();
            if (character != null && rate > 0)
            {
                Helper.GetBUS_GSEventCollection().Evt_SetGMCustomTimeDilation.Invoke(rate);
            }
        }

        public void SummonReq(ModelManager manager, Int64 SummonID, Int64 SummonCount)
        {

            Helper.SummonReq(SummonID, SummonCount);
        }

        public void TriggerSkill(ModelManager manager)
        {
            var character = Helper.GetBGUPlayerCharacterCS();
            BUS_EventCollectionCS.Get(character)?.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(10199, ECastSkillSourceType.MagicallyChange));
        }

        public void TransUnit(ModelManager mananger)
        {
            Helper.GetBUS_GSEventCollection().Evt_TransBeginSpawnNewOne.Invoke(10, 0, true, EPlayerTransBeginType.SkillEffect);
        }

        public void SwitchPlayerTeamWithTarget(ModelManager manager)
        {
            var character = Helper.GetBGUPlayerCharacterCS();
            var teamID = character.GetTeamIDInCS();
            var target = BGUFunctionLibraryCS.BGUGetTarget(character) as BGUCharacterCS;
            if (target != null)
            {
                var targetTeamID = target.GetTeamIDInCS();
                target.SetTeamIDInCS(teamID);
                character.SetTeamIDInCS(targetTeamID);
            }
        }

        public void SyncTeamWithTarget(ModelManager manager)
        {
            var character = Helper.GetBGUPlayerCharacterCS();

            var target = BGUFunctionLibraryCS.BGUGetTarget(character) as BGUCharacterCS;
            if (target != null)
            {
                var teamID = target.GetTeamIDInCS();
                character.SetTeamIDInCS(teamID);
            }
            else
            {
                BUS_EventCollectionCS.Get(character).Evt_ResetTeamID.Invoke();
            }
        }

        public void TriggerPrevEffect(ModelManager manager)
        {
            if (offset != -1)
            {
                index -= 2;
            }
            offset = -1;
            prevIndex = index;
            TriggerEffects(manager);
        }

        public void TriggerCurrentEffect(ModelManager manager)
        {
            offset = 0;
            index = prevIndex;
            TriggerEffects(manager);
        }

        public void TriggerNextEffect(ModelManager manager)
        {
            if (offset != 1)
            {
                index += 2;
            }
            offset = 1;
            prevIndex = index;
            TriggerEffects(manager);
        }

        public void TriggerEffects(ModelManager manager)
        {
            // Log.Debug("bian: trigger TriggerEffects!");
            var character = Helper.GetBGUPlayerCharacterCS();
            if (character != null)
            {
                var effects = BGW_GameDB.GetAllSkillEffectDesc().Where(item => item.Value.EffectType == EBuffAndSkillEffectType.SpawnProjectile).ToArray();
                // Log.Debug($"bian: find effects count--->{effects.Length}!");

                if (index >= effects.Length)
                {
                    index = 0;
                }
                if (index < 0)
                {
                    index = effects.Length - 1;
                }

                for (int i = 0; i < effects.Length; i++)
                {
                    if (index == i)
                    {
                        // Log.Debug($"bian: trigger effect {index}---->{effects[i].Value.ID}|{effects[i].Value.EffectType}");
                        Helper.TriggerEffect(character, effects[i].Value.ID, EANTriggerEffectTargetType.Owner);
                        index += offset;
                        break;
                    }
                }
            }
        }



        public void TransBack(ModelManager manager)
        {
            manager.AfterTransBack();
        }

        public void ExportAllActors(ModelManager manager)
        {
            // Log.Debug("bian: trigger ExportAllActors!");
            List<AActor> allActorsInWorld = UBGUFunctionLibrary.GetAllActorsInWorld(Helper.GetWorld());
            foreach (AActor item in allActorsInWorld)
            {
                if (item as BGUCharacterCS != null)
                {
                    // Log.Debug($"bian: find actor----->{item.PathName}\n-------------------------------------------------------------------------------");
                    Helper.ExportTamer(item as BGUCharacterCS);
                }
            }


            Helper.ExportAllActors();



        }


        public void JingDouYun(ModelManager manager)
        {
            var character = Helper.GetBGUPlayerCharacterCS();
            if (character != null && Helper.IsWukong(character))
            {
                BUS_EventCollectionCS.Get(character).Evt_ToggleCloudMove.Invoke();
            }
        }

        public void XieLongYan(ModelManager manager)
        {
            // Log.Debug("bian: trigger XueLongYan!");
            var character = Helper.GetBGUPlayerCharacterCS();
            var actor = BGUFunctionLibraryCS.BGUGetTarget(character) as BGUCharacterCS;

            if (actor != null)
            {
                var target = BGUFunctionLibraryCS.BGUGetTarget(character) as BGUCharacterCS;
                if (target != null)
                {
                    var model = Helper.ExportTamer(target);
                    if (model != null)
                    {
                        if (((BaseModel)model).Label.ToLower().IndexOf("wukong") == -1)
                        {
                            if (manager.FindModelByLabel(((BaseModel)model).Label, "") == null)
                            {
                                manager.AddModel(model);
                            }
                            if (manager.GetCurrentModel(character) == null)
                            {
                                model.TransToModel();
                            }

                        }

                    }

                }
            }

        }

        public void ShowUI(ModelManager manager)
        {
            Manager.CreateUi();
        }

        public void CastPrevSkill(ModelManager manager)
        {
            manager.TriggerDebugSkill(-1);
        }

        public void CastNextSkill(ModelManager manager)
        {
            manager.TriggerDebugSkill(1);
        }


        public void CastCurrentSkill(ModelManager manager)
        {
            manager.TriggerDebugSkill(0);
        }

        public void ExportTargetTamer(ModelManager manager)
        {
            Log.Debug("bian: trigger ExportTargetTamer");

            var BGS = Helper.GetBUS_GSEventCollection();
            var character = Helper.GetBGUPlayerCharacterCS();

            var actor = BGUFunctionLibraryCS.BGUGetTarget(character) as BGUCharacterCS;
            if (actor != null)
            {
                Log.Debug(actor.GetTamerOwner().ToString());
                Helper.ExportTamer(actor);
            }
        }

    }
}
