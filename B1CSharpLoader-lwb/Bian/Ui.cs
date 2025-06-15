using b1;
using B1UI.GSUI;
using CSharpModBase;
using GSE.GSUI;
using ResB1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace bian
{
    public class Ui
    {
        private GSUIPage UI;
        private ModelManager manager;

        public Ui() {
            manager = Manager.GetModelManager();
        }

        public void CreateUI()
        {
            UWorld world = Helper.GetWorld();
            ABGPPlayerController aBGPPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(world) as ABGPPlayerController;
            BGUPlayerCharacterCS worldContext = Helper.GetControlledPawn() as BGUPlayerCharacterCS;

            BGUFunctionLibraryManaged.BGUSwitchPage(world, EUIPageID.ShrineMain);
            UI = GSUI.UIMgr.FindUIPage(worldContext, (int)(EUIPageID.ShrineMain)) as UIShrineMain;
            if (UI == null)
            {
                return;
            }

            FieldInfo field = typeof(UIShrineMain).GetField("ShrineMenuHelper", BindingFlags.Instance | BindingFlags.NonPublic);
            if (field == null || !(field.GetValue(UI) is FMenuHelper<EShrineMenuTag> fMenuHelper))
            {
                return;
            }
            FieldInfo field2 = typeof(UIShrineMain).GetField("TeleportMenuHelper", BindingFlags.Instance | BindingFlags.NonPublic);
            if (!(field2 == null) && field2.GetValue(UI) is FMenuHelper<ETeleportMenuTag> teleportHelper)
            {
                fMenuHelper.ClearLayout();
                Create72BainMenu(fMenuHelper, world);
                CreateSkillMenu(fMenuHelper, world);
                CreateCommandMenu(fMenuHelper, world);
                CreateDreamMenu(fMenuHelper, world);
                CreateRuleMenu(fMenuHelper, world);
                CreateGamePadMenu(fMenuHelper, world);
                CreateHelpMenu(fMenuHelper, world);
                CreateCommentMenu(fMenuHelper, world);
                fMenuHelper.UpdateLayout();

            }
        }

        public void CreateGamePadMenu(FMenuHelper<EShrineMenuTag> helper, UWorld world) {
            helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
            {
                MenuBtnType = EMenuBtnType.Func,
                BtnActionType = EMenuBtnActionType.Teleport,
                Name = FText.FromString("手柄映射"),
                Tips = FText.FromString("手柄映射---已经绑定的手柄键位映射"),
                BtnHashCode = "Func_GamePad",
                SortId = 1
            });
            var ruleIndex = 0;
            helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
            {
                MenuBtnType = EMenuBtnType.Func,
                BtnActionType = EMenuBtnActionType.Teleport,
                Name = FText.FromString($"以下为手柄按键映射列表"),
                Tips = FText.FromString($"手柄按键映射列表"),
                BtnHashCode = $"Func_GamePad_{ruleIndex}",
                BtnAction = delegate
                {
                    GSB1UIUtil.ShowConfirm(null, FText.FromString("此处为已经加载的所有手柄键位映射，这些手柄按键已经自动映射到键盘键位。你可以在文件夹conf/gamepad.config里查看和修改。"), FText.FromString("明白"), null, false);
                },
                SortId = 0,
                ParentBtnHash = "Func_GamePad"
            });

            if (manager.GamePadConf != null && manager.GamePadConf.KeyBinding != null) {
                var index = 0;
                foreach (var key in manager.GamePadConf.KeyBinding.Keys)
                {
                    index += 1;
                    helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
                    {
                        MenuBtnType = EMenuBtnType.Func,
                        BtnActionType = EMenuBtnActionType.Teleport,
                        Name = FText.FromString($"{key}-->{manager.GamePadConf.KeyBinding[key]}"),
                        Tips = FText.FromString($"手柄按键：{key} 已经映射为键盘按键：{manager.GamePadConf.KeyBinding[key]}"),
                        BtnHashCode = $"Func_GamePad_{index}",
                        BtnAction = delegate
                        {
                            GSB1UIUtil.ShowConfirm(null, FText.FromString($"手柄按键：{key} 已经映射为键盘按键：{manager.GamePadConf.KeyBinding[key]}"), FText.FromString("明白"), null, false);
                        },
                        SortId = 0,
                        ParentBtnHash = $"Func_GamePad"
                    });
                }
            }
            
        }

        public void CreateRuleMenu(FMenuHelper<EShrineMenuTag> helper, UWorld world)
        {
            helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
            {
                MenuBtnType = EMenuBtnType.Func,
                BtnActionType = EMenuBtnActionType.Teleport,
                Name = FText.FromString("法则"),
                Tips = FText.FromString("法则---天地秩序，尽在掌握【已加载的自定义触发规则】"),
                BtnHashCode = "Func_Rule",
                SortId = 1
            });

            var ruleIndex = 0;
            helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
            {
                MenuBtnType = EMenuBtnType.Func,
                BtnActionType = EMenuBtnActionType.Teleport,
                Name = FText.FromString($"以下为法则列表"),
                Tips = FText.FromString($"只可查看法则"),
                BtnHashCode = $"Func_Rule_{ruleIndex}",
                BtnAction = delegate
                {
                    GSB1UIUtil.ShowConfirm(null, FText.FromString("此处为已经加载的所有法则。\n\n触发方式支持：buff添加时，技能释放时；\n\n支持的动作：添加buff,召唤物，释放子弹，释放技能"), FText.FromString("明白"), null, false);
                },
                SortId = 0,
                ParentBtnHash = "Func_Rule"
            });
            for (int i = 0; i < manager.Rules.Count; i++)
            {
                var ruleGroup = manager.Rules[i];


                ruleIndex += 1;
                helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
                {
                    MenuBtnType = EMenuBtnType.Func,
                    BtnActionType = EMenuBtnActionType.Teleport,
                    Name = FText.FromString($"{ruleGroup.Name}"),
                    Tips = FText.FromString($"法则{ruleIndex}: {ruleGroup.Name} 法则数量： {ruleGroup.Rules.Count} 作者: {ruleGroup.Author}"),
                    BtnHashCode = $"Func_Rule_{ruleIndex}",
                    BtnAction = delegate
                    {
                        GSB1UIUtil.ShowConfirm(null, FText.FromString("此处为已经加载的所有法则。\n\n触发方式支持：buff添加时，技能释放时；\n\n支持的动作：添加buff,召唤物，释放子弹，释放技能"), FText.FromString("明白"), null, false);
                    },
                    SortId = 0,
                    ParentBtnHash = "Func_Rule"
                });
            }
        }
        public void CreateDreamMenu(FMenuHelper<EShrineMenuTag> helper, UWorld world)
        {
            helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
            {
                MenuBtnType = EMenuBtnType.Func,
                BtnActionType = EMenuBtnActionType.Teleport,
                Name = FText.FromString("幻境"),
                Tips = FText.FromString("幻境---黄粱一梦，无根之萍  【体验未完成的变身配置】"),
                BtnHashCode = "Func_Dream",
                SortId = 1
            });

            var dreamIndex = 0;
            for (int i = 0; i < manager.models.Count; i++)
            {
                var loadedModel = manager.models[i] as BaseModel;
                if (manager.Config.KeyMapping.Where(item => item.Label == loadedModel.Label && item.Type == loadedModel.Type).Count() == 0)
                {
                    dreamIndex += 1;
                    helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
                    {
                        MenuBtnType = EMenuBtnType.Func,
                        BtnActionType = EMenuBtnActionType.Teleport,
                        Name = FText.FromString($"{loadedModel.Name}"),
                        Tips = FText.FromString($"第{dreamIndex}梦: {loadedModel.Name} 体验技能数量： {loadedModel.Skills.Count()}"),
                        BtnHashCode = $"Func_Dream_{dreamIndex}",
                        BtnAction = delegate
                        {
                            var character = Helper.GetBGUPlayerCharacterCS();
                            if (character == null)
                            {
                                return;
                            }
                            if (!Helper.IsWukong(character))
                            {
                                var currentModel = manager.GetCurrentModel(character);
                                if (currentModel != null)
                                {
                                    GSB1UIUtil.ShowConfirm(null, FText.FromString("大圣，入梦太快了,先回归本体才能继续体验变身技能"), FText.FromString("变回悟空"), null, true, delegate
                                    {
                                        var character = Helper.GetBGUPlayerCharacterCS();
                                        if (character != null && !Helper.IsWukong(character))
                                        {
                                            currentModel = manager.GetCurrentModel(character);
                                            if (currentModel != null)
                                            {
                                                manager.AfterTransBack();
                                            }
                                        }
                                        return true;
                                    });
                                }
                                else
                                {
                                    GSB1UIUtil.ShowConfirm(null, FText.FromString("大圣，入梦太快了,按~键先回归本体才能继续体验变身技能"), FText.FromString("明白"), null, false);
                                }
                            }
                            else
                            {
                                manager.DoTrans(loadedModel as ITransable);
                            }
                        },
                        SortId = 0,
                        ParentBtnHash = "Func_Dream"
                    });
                }
            }
        }

        public void CreateCommandMenu(FMenuHelper<EShrineMenuTag> helper, UWorld world)
        {
            helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
            {
                MenuBtnType = EMenuBtnType.Func,
                BtnActionType = EMenuBtnActionType.Teleport,
                Name = FText.FromString("秘法"),
                Tips = FText.FromString("秘法---超出三界外，不在五行中 【查看金手指等命令】"),
                BtnHashCode = "Func_Magic",
                SortId = 1,
            });

            for (int i = 0; i < manager.Config.KeyMapping.Count; i++)
            {
                var keyItem = manager.Config.KeyMapping[i];
                if (keyItem.Type == "COMMAND")
                {
                    helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
                    {
                        MenuBtnType = EMenuBtnType.Func,
                        BtnActionType = EMenuBtnActionType.Teleport,
                        Name = FText.FromString($"{keyItem.Name}  {keyItem.Key}"),
                        Tips = FText.FromString($"{keyItem.Name}  快捷键：{keyItem.Key}"),
                        BtnAction = delegate {
                            MethodInfo methodInfo = typeof(Commands).GetMethod(keyItem.Label, BindingFlags.Public | BindingFlags.Instance);
                            if (methodInfo != null)
                            {
                                try
                                {
                                    methodInfo.Invoke(new Commands(), new object[] { manager, }.Concat(keyItem.Params ?? new object[] { }).ToArray());
                                }
                                catch (Exception e)
                                {
                                    GSB1UIUtil.ShowConfirm(null, FText.FromString($"执行失败.{e.ToString()}"), FText.FromString("了解"), null, false);
                                    return;
                                }
                                GSB1UIUtil.ShowConfirm(null, FText.FromString("已执行"), FText.FromString("了解"), null, false);
                            }

                        },
                        BtnHashCode = $"Func_Magic_{i}",
                        ParentBtnHash = "Func_Magic",
                        SortId = 0,
                    });
                }
            }
        }

        public void CreateHelpMenu(FMenuHelper<EShrineMenuTag> helper, UWorld world)
        {
            helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
            {
                MenuBtnType = EMenuBtnType.Func,
                BtnActionType = EMenuBtnActionType.Teleport,
                Name = FText.FromString("作者 reece15"),
                Tips = FText.FromString("作者：reece15  "),
                BtnHashCode = "Func_Help",
                BtnAction = delegate {
                    GSB1UIUtil.ShowConfirm(null, FText.FromString("作者B站ID:reece15。\n\n自用MOD，免费分享，MOD还有很多瑕疵，后续会优化更新^_^"), FText.FromString("666"), null, false);
                },
                SortId = 1,
            });
        }

        public void CreateCommentMenu(FMenuHelper<EShrineMenuTag> helper, UWorld world)
        {
            helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
            {
                MenuBtnType = EMenuBtnType.Func,
                BtnActionType = EMenuBtnActionType.Teleport,
                Name = FText.FromString("引用和致谢"),
                Tips = FText.FromString("引用和致谢"),
                BtnHashCode = "Func_Comment",
                BtnAction = delegate {
                    GSB1UIUtil.ShowConfirm(null, FText.FromString("UI参考自云轩大佬的BOSSRUSHV3 mod, 很了不起的MOD！\n\n本MOD基于c#loader mod加载器，开天辟地的mod加载器！\n\n大量变身配置文件来自群友制作分享，感谢他们！"), FText.FromString("感谢"), null, false);
                },
                SortId = 1,
            });
        }

        public void CreateSkillMenu(FMenuHelper<EShrineMenuTag> helper, UWorld world)
        {

            var character = Helper.GetBGUPlayerCharacterCS();
            if (character != null)
            {
                var model = manager.GetCurrentModel(character);
                List<Skill> skills;
                if (model != null)
                {
                    helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
                    {
                        MenuBtnType = EMenuBtnType.Func,
                        BtnActionType = EMenuBtnActionType.Teleport,
                        Name = FText.FromString("法术"),
                        Tips = FText.FromString("法术---万般术法，皆名列在册【当前变身的技能表】"),
                        BtnHashCode = "Func_ModelSkill",
                        SortId = 1,
                    });
                    BindSkillEvent(model as BaseModel, helper, 0);
                }
                else if (manager.Wukong != null) {
                    helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
                    {
                        MenuBtnType = EMenuBtnType.Func,
                        BtnActionType = EMenuBtnActionType.Teleport,
                        Name = FText.FromString("法术"),
                        Tips = FText.FromString("法术---万般术法，皆名列在册【当前变身的技能表】"),
                        BtnHashCode = "Func_ModelSkill",
                        SortId = 1,
                    });
                    BindSkillEvent((BaseModel)manager.Wukong, helper, 0);
                } 
                else 
                {
                    helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
                    {
                        MenuBtnType = EMenuBtnType.Func,
                        BtnActionType = EMenuBtnActionType.Teleport,
                        Name = FText.FromString("法术"),
                        Tips = FText.FromString("法术---万般术法，皆名列在册【当前变身的技能表】"),
                        BtnAction = delegate {
                            GSB1UIUtil.ShowConfirm(null, FText.FromString("变身后才能查看技能表，请变身后重新进入菜单再试"), FText.FromString("了解"), null, false);
                        },
                        BtnHashCode = "Func_ModelSkill",
                        SortId = 1,
                    });
                }
            }
        }

        private void BindSkillEvent(BaseModel model, FMenuHelper<EShrineMenuTag> helper, int index)
        {
            helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
            {
                MenuBtnType = EMenuBtnType.Func,
                BtnActionType = EMenuBtnActionType.Teleport,
                Name = FText.FromString($"【{model.Name}】的技能出招表"),
                Tips = FText.FromString($"{((BaseModel)model).Name} 的技能出招表。也可按快捷键 [ ] | 释放技能(上一个，当前，下一个) 来自作者: {model.Author}"),
                BtnAction = delegate {
                    GSB1UIUtil.ShowConfirm(null, FText.FromString("注意：变身后需要重新打开这个菜单，技能表才会刷新！"), FText.FromString("了解"), null, false);
                },
                BtnHashCode = $"Func_ModelSkill_{index}",
                ParentBtnHash = "Func_ModelSkill",
                SortId = 0,
            });

            var skills = ((BaseModel)model).Skills.OrderByDescending(item => item.Key).ToArray();
            for (int i = 0; i < skills.Count(); i++)
            {
                var skill = skills[i];
                helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
                {
                    MenuBtnType = EMenuBtnType.Func,
                    BtnActionType = EMenuBtnActionType.Teleport,
                    Name = FText.FromString($"{skill.Name}  {skill.KeyText()}"),
                    Tips = FText.FromString($"{((BaseModel)model).Name}  技能：{skill.Name} 快捷键：{skill.KeyText()} 技能ID: {skill.Id}"),
                    BtnAction = delegate {
                        var character = Helper.GetBGUPlayerCharacterCS();
                        Log.Debug("bian: btn click");
                        if (character == null)
                        {
                            return;
                        }
                        if (!Helper.IsWukong(character))
                        {
                            var currentModel = manager.GetCurrentModel(character);
                            if (currentModel != null && model == currentModel)
                            {
                                manager.CastSkill(character, skill, EMontageBindReason.NormalSkill, false, 0, skill.GetAllBuffers());
                            }
                            else
                            {
                                GSB1UIUtil.ShowConfirm(null, FText.FromString("变身后请重新进入菜单再试！"), FText.FromString("了解"), null, false);
                            }
                        }
                        else
                        {
                            if (model != null && model == manager.Wukong) {
                                manager.CastSkill(character, skill, EMontageBindReason.NormalSkill, false, 0, skill.GetAllBuffers());
                            } else { 
                                GSB1UIUtil.ShowConfirm(null, FText.FromString("变身后请重新进入菜单再试！"), FText.FromString("了解"), null, false);
                            }
                        }
                    },
                    BtnHashCode = $"Func_ModelSkill_{index}_{i}",
                    ParentBtnHash = "Func_ModelSkill",
                    SortId = 0,
                });
            }
        }

        public void Create72BainMenu(FMenuHelper<EShrineMenuTag> helper, UWorld world)
        {
            helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
            {
                MenuBtnType = EMenuBtnType.Func,
                BtnActionType = EMenuBtnActionType.Teleport,
                Name = FText.FromString("72变"),
                Tips = FText.FromString("72变---大圣神通 一念化万物  【72变，化身为妖】"),
                BtnHashCode = "Func_Trans",
                SortId = 1
            });

            for (int i = 0; i < manager.Config.KeyMapping.Count; i++)
            {
                var keyItem = manager.Config.KeyMapping[i];
                if (keyItem.Type == "TRANS" || keyItem.Type == "BOSS" || keyItem.Type == "MAGIC")
                {
                    var model = manager.FindModelByLabel(keyItem.Label, keyItem.Type);
                    if (model != null)
                    {
                        helper.Register(new FBtnRegisterInfo<EShrineMenuTag>
                        {
                            MenuBtnType = EMenuBtnType.Func,
                            BtnActionType = EMenuBtnActionType.Teleport,
                            Name = FText.FromString($"{keyItem.Name}"),
                            Tips = FText.FromString($"第{i + 1}变: {keyItem.Name} 快捷键:{keyItem.KeyText()}"),
                            BtnHashCode = $"Func_Trans_{i}",
                            BtnAction = delegate
                            {
                                var character = Helper.GetBGUPlayerCharacterCS();
                                Log.Debug("bian: btn click");
                                if (character == null)
                                {
                                    return;
                                }
                                if (!Helper.IsWukong(character))
                                {
                                    var currentModel = manager.GetCurrentModel(character);
                                    if (currentModel != null)
                                    {
                                        GSB1UIUtil.ShowConfirm(null, FText.FromString("大圣，变身太快了,先变回本体才能继续变身"), FText.FromString("变回悟空"), null, true, delegate
                                        {
                                            var character = Helper.GetBGUPlayerCharacterCS();
                                            if (character != null && !Helper.IsWukong(character))
                                            {
                                                currentModel = manager.GetCurrentModel(character);
                                                if (currentModel != null)
                                                {
                                                    manager.AfterTransBack();
                                                }
                                            }
                                            return true;
                                        });
                                    }
                                    else
                                    {
                                        GSB1UIUtil.ShowConfirm(null, FText.FromString("大圣，变身太快了,按~键先变回本体才能继续变身"), FText.FromString("明白"), null, false);
                                    }
                                }
                                else
                                {
                                    manager.DoTrans(model);
                                }
                            },
                            SortId = 0,
                            ParentBtnHash = "Func_Trans"
                        });
                    }
                }
            }
        }
    }
}
