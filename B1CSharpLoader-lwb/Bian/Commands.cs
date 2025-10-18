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
        public static int SkillSuperArmor = 6000;

        public void MaiDongHuiLai(ModelManager manager)
        {
            // Log.Debug("bian: trigger maidonghuilai!");
            var character = Helper.GetBGUPlayerCharacterCS();
            if (character.Mesh.SkeletalMesh.GetFullName().ToLower().IndexOf("SK_Wukong_Simple".ToLower()) > -1)
            {
                BGUFunctionLibraryCS.BGUSetAttrValue(character, EBGUAttrFloat.Stamina, BGUFunctionLibraryCS.GetAttrValue(character, EBGUAttrFloat.StaminaMax));
                BGUFunctionLibraryCS.BGUSetAttrValue(character, EBGUAttrFloat.Hp, BGUFunctionLibraryCS.GetAttrValue(character, EBGUAttrFloat.HpMax));
                BGUFunctionLibraryCS.BGUSetAttrValue(character, EBGUAttrFloat.Mp, BGUFunctionLibraryCS.GetAttrValue(character, EBGUAttrFloat.MpMax));
                BGUFunctionLibraryCS.BGUSetAttrValue(character, EBGUAttrFloat.SpecialEnergy, BGUFunctionLibraryCS.GetAttrValue(character, EBGUAttrFloat.SpecialEnergyMax));
                BGUFunctionLibraryCS.BGUSetAttrValue(character, EBGUAttrFloat.FabaoEnergy, BGUFunctionLibraryCS.GetAttrValue(character, EBGUAttrFloat.FabaoEnergyMax));
                BGUFunctionLibraryCS.BGUSetAttrValue(character, EBGUAttrFloat.VigorEnergy, BGUFunctionLibraryCS.GetAttrValue(character, EBGUAttrFloat.VigorEnergyMax));
                BGUFunctionLibraryCS.BGUSetAttrValue(character, EBGUAttrFloat.BlockCollapseArmorMax, ShieldMax);
                BGUFunctionLibraryCS.BGUSetAttrValue(character, EBGUAttrFloat.BlockCollapseArmor, ShieldMax);

                BGUFunctionLibraryCS.BGUSetAttrValue(character, EBGUAttrFloat.ShieldMax, ShieldMax);
                BGUFunctionLibraryCS.BGUSetAttrValue(character, EBGUAttrFloat.Shield, ShieldMax);
                BGUFunctionLibraryCS.BGUSetAttrValue(character, EBGUAttrFloat.SkillSuperArmorMax, SkillSuperArmor);
                BGUFunctionLibraryCS.BGUSetAttrValue(character, EBGUAttrFloat.SkillSuperArmor, SkillSuperArmor);
                var UnitBarInfoComp = Helper.FindActorCompByClass<BUS_UnitBarInfoComp>(character);

                var World = Helper.GetWorld();
                BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(World);
                Log.Info($"bian: bGW_UIEventCollection is {bGW_UIEventCollection?.GetFName()}" );
                if (bGW_UIEventCollection != null)
                {
                    bGW_UIEventCollection.Evt_UI_SetShieldBarActive(ECSExtension.ToEntity(character), true);
                }
                if (UnitBarInfoComp != null)
                {
                    // 获取 UnitBarInfoData 私有字段
                    var unitBarInfoDataField = typeof(BUS_UnitBarInfoComp).GetField("UnitBarInfoData",
                        System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                    if (unitBarInfoDataField != null)
                    {
                        // 获取 UnitBarInfoData 实例
                        var unitBarInfoData = unitBarInfoDataField.GetValue(UnitBarInfoComp);

                        // 获取 ShieldShowInUI 属性
                        var shieldShowInUIProperty = unitBarInfoData.GetType().GetProperty("ShieldShowInUI");

                        if (shieldShowInUIProperty != null)
                        {
                            // 设置 ShieldShowInUI 为 true
                            shieldShowInUIProperty.SetValue(unitBarInfoData, true);
                        }
                    }
                }

            }
            else
            {
                BGUFunctionLibraryCS.BGUSetAttrValue(character, EBGUAttrFloat.Stamina, BGUFunctionLibraryCS.GetAttrValue(character, EBGUAttrFloat.StaminaMax));
                BGUFunctionLibraryCS.BGUSetAttrValue(character, EBGUAttrFloat.Hp, BGUFunctionLibraryCS.GetAttrValue(character, EBGUAttrFloat.HpMax));
                BGUFunctionLibraryCS.BGUSetAttrValue(character, EBGUAttrFloat.Mp, BGUFunctionLibraryCS.GetAttrValue(character, EBGUAttrFloat.MpMax));
            }
            BGUFunctionLibraryCS.BGUAddBuff(character, character, 450, EBuffSourceType.GM, 1000);
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
            var character = Helper.GetBGUPlayerCharacterCS();
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
                Log.Info($"bian: change team id-->{targetTeamID}");
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
                // Log.Debug($"bian: set team id-->{teamID}");
            }
            else
            {
                BUS_EventCollectionCS.Get(character).Evt_ResetTeamID.Invoke();
                Log.Info($"bian: reset team id to default");
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
                            else
                            {
                                // Log.Error($"bian: 72bian only for wukong!");
                            }
                        }

                    }
                    else
                    {
                        // Log.Error($"bian: export failed!");
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
