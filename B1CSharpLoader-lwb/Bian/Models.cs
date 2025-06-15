using System;
using System.Collections.Generic;
using System.IO;
using UnrealEngine.Engine;
using Newtonsoft.Json;
using CSharpModBase;
using b1;
using b1.BGW;
using BtlShare;
using CSharpModBase.Input;
using b1.EventDelDefine;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Linq;
using UnrealEngine.Runtime;
using b1.Plugins.TressFX;
using System.Threading.Tasks;
using HarmonyLib;

namespace bian
{

    public interface ITransable
    {
        void TransToModel();
        void TransBack();
        bool IsCurrentModel(string SkName);
    }

    public class ModelManager
    {

        public List<ITransable> models;
        public Conf Config;
        public GamePadConf GamePadConf;
        private double CoolDownTime = 0;
        public int SkillIndex = 0;
        private bool HasInit = false;
        private BaseModel CurrentModel;
        private Ui UI;
        public List<RuleGroup> Rules;
        public ITransable Wukong;
        private static Dictionary<String, int> SkillMapping = new();

        private Dictionary<string, Key> KeyValuePairs = new Dictionary<string, Key>() {
            {"LBUTTON", Key.LBUTTON},
            {"RBUTTON", Key.RBUTTON},
            {"XBUTTON1", Key.XBUTTON1},
            {"XBUTTON2", Key.XBUTTON2},
            {"MBUTTON", Key.MBUTTON},
            {"BACK", Key.BACK},
            {"TAB", Key.TAB},
            {"CLEAR", Key.CLEAR},
            {"RETURN", Key.RETURN},
            {"ENTER", Key.ENTER},
            {"SHIFT", Key.SHIFT},
            {"MENU", Key.MENU},
            {"PAUSE", Key.PAUSE},
            {"CAPITAL", Key.CAPITAL},
            {"KANA", Key.KANA},
            {"HANGEUL", Key.HANGEUL},
            {"HANGUL", Key.HANGUL},
            {"ESCAPE", Key.ESCAPE},
            {"CONVERT", Key.CONVERT},
            {"NONCONVERT", Key.NONCONVERT},
            {"ACCEPT", Key.ACCEPT},
            {"MODECHANGE", Key.MODECHANGE},
            {"SPACE", Key.SPACE},
            {"PRIOR", Key.PRIOR},
            {"NEXT", Key.NEXT},
            {"END", Key.END},
            {"HOME", Key.HOME},
            {"LEFT", Key.LEFT},
            {"UP", Key.UP},
            {"RIGHT", Key.RIGHT},
            {"DOWN", Key.DOWN},
            {"SELECT", Key.SELECT},
            {"PRINT", Key.PRINT},
            {"EXECUTE", Key.EXECUTE},
            {"SNAPSHOT", Key.SNAPSHOT},
            {"INSERT", Key.INSERT},
            {"DELETE", Key.DELETE},
            {"HELP", Key.HELP},
            {"D0", Key.D0},
            {"D1", Key.D1},
            {"D2", Key.D2},
            {"D3", Key.D3},
            {"D4", Key.D4},
            {"D5", Key.D5},
            {"D6", Key.D6},
            {"D7", Key.D7},
            {"D8", Key.D8},
            {"D9", Key.D9},
            {"A", Key.A},
            {"B", Key.B},
            {"C", Key.C},
            {"D", Key.D},
            {"E", Key.E},
            {"F", Key.F},
            {"G", Key.G},
            {"H", Key.H},
            {"I", Key.I},
            {"J", Key.J},
            {"K", Key.K},
            {"L", Key.L},
            {"M", Key.M},
            {"N", Key.N},
            {"O", Key.O},
            {"P", Key.P},
            {"Q", Key.Q},
            {"R", Key.R},
            {"S", Key.S},
            {"T", Key.T},
            {"U", Key.U},
            {"V", Key.V},
            {"W", Key.W},
            {"X", Key.X},
            {"Y", Key.Y},
            {"Z", Key.Z},
            {"LWIN", Key.LWIN},
            {"RWIN", Key.RWIN},
            {"APPS", Key.APPS},
            {"SLEEP", Key.SLEEP},
            {"NUMPAD0", Key.NUMPAD0},
            {"NUMPAD1", Key.NUMPAD1},
            {"NUMPAD2", Key.NUMPAD2},
            {"NUMPAD3", Key.NUMPAD3},
            {"NUMPAD4", Key.NUMPAD4},
            {"NUMPAD5", Key.NUMPAD5},
            {"NUMPAD6", Key.NUMPAD6},
            {"NUMPAD7", Key.NUMPAD7},
            {"NUMPAD8", Key.NUMPAD8},
            {"NUMPAD9", Key.NUMPAD9},
            {"MULTIPLY", Key.MULTIPLY},
            {"ADD", Key.ADD},
            {"SEPARATOR", Key.SEPARATOR},
            {"SUBTRACT", Key.SUBTRACT},
            {"DECIMAL", Key.DECIMAL},
            {"DIVIDE", Key.DIVIDE},
            {"F1", Key.F1},
            {"F2", Key.F2},
            {"F3", Key.F3},
            {"F4", Key.F4},
            {"F5", Key.F5},
            {"F6", Key.F6},
            {"F7", Key.F7},
            {"F8", Key.F8},
            {"F9", Key.F9},
            {"F10", Key.F10},
            {"F11", Key.F11},
            {"F12", Key.F12},
            {"F13", Key.F13},
            {"F14", Key.F14},
            {"F16", Key.F16},
            {"F17", Key.F17},
            {"F18", Key.F18},
            {"F19", Key.F19},
            {"F20", Key.F20},
            {"F21", Key.F21},
            {"F22", Key.F22},
            {"F23", Key.F23},
            {"F24", Key.F24},
            {"NUMLOCK", Key.NUMLOCK},
            {"SCROLL", Key.SCROLL},
            {"LSHIFT", Key.LSHIFT},
            {"RSHIFT", Key.RSHIFT},
            {"LMENU", Key.LMENU},
            {"RMENU", Key.RMENU},
            {"OEM_1", Key.OEM_1},
            {"OEM_PLUS", Key.OEM_PLUS},
            {"OEM_COMMA", Key.OEM_COMMA},
            {"OEM_MINUS", Key.OEM_MINUS},
            {"OEM_PERIOD", Key.OEM_PERIOD},
            {"OEM_2", Key.OEM_2},
            {"OEM_3", Key.OEM_3},
            {"OEM_4", Key.OEM_4},
            {"OEM_5", Key.OEM_5},
            {"OEM_6", Key.OEM_6},
            {"OEM_7", Key.OEM_7},
        };

        private Dictionary<string, GamePadButton> PadValuePairs = new Dictionary<string, GamePadButton>()
        {
            {"DPADUP", GamePadButton.DPadUp},
            {"DPADDOWN", GamePadButton.DPadDown},
            {"DPADLEFT", GamePadButton.DPadLeft},
            {"DPADRIGHT", GamePadButton.DPadRight},
            {"START", GamePadButton.Start},
            {"BACK", GamePadButton.Back},
            {"LEFTTHUMB", GamePadButton.LeftThumb},
            {"RIGHTTHUMB", GamePadButton.RightThumb},
            {"LEFTSHOULDER", GamePadButton.LeftShoulder},
            {"RIGHTSHOULDER", GamePadButton.RightShoulder},
            {"GA", GamePadButton.A},
            {"GB", GamePadButton.B},
            {"GX", GamePadButton.X},
            {"GY", GamePadButton.Y},
            {"LEFTTRIGGER", GamePadButton.LeftTrigger},
            {"RIGHTTRIGGER", GamePadButton.RightTrigger},
            {"DPADRIGHTUP", GamePadButton.DPadRightUp},
            {"DPADLEFTDOWN", GamePadButton.DPadLeftDown},
            {"DPADRIGHTDOWN", GamePadButton.DPadRightDown},
            {"DPADLEFTUP", GamePadButton.DPadLeftUp},
        };

        public ModelManager()
        {
            Config = new Conf();
        }

        public void AddModel(ITransable model)
        {
            if (model != null)
            {
                models.Add(model);
                RefreshSkillMapping((BaseModel)model);
            }
        }
        public ITransable? GetCurrentModel(BGUPlayerCharacterCS actor)
        {
            ITransable? foundModel = null;
            if (models != null)
            {
                foreach (var item in models)
                {
                    if (item.IsCurrentModel(actor.Mesh.SkeletalMesh.GetFullName()))
                    {
                        foundModel = item;
                        if (CurrentModel != null)
                        {
                            if (CurrentModel.Type == ((BaseModel)item).Type)
                            {
                                return item;
                            }
                        }
                        else
                        {
                            if (actor.PathName.ToLower().IndexOf("wukong") > -1)
                            {
                                if (!(item is TransModel))
                                {
                                    return item;
                                }
                            }
                            else
                            {
                                if (item is TransModel)
                                {
                                    return item;
                                }
                            }
                        }
                    }
                }

            }
            return foundModel;
        }

        public void InitConfig()
        {
            models = LoadFromJson();
            Config = LoadConfig();
            GamePadConf = LoadPadKeyConfig();
            Rules = LoadRules();

            var invalidIndex = -1;
            for (int i = 0; i < models.Count; i++)
            {
                if (((BaseModel)models[i]).Label.ToLower().IndexOf("wukong") > -1)
                {
                    Wukong = models[i];
                    invalidIndex = i;
                }
            }
            if (invalidIndex > -1)
            {
                models.RemoveRange(invalidIndex, 1);
            }
        }

        public void AfterTransBack()
        {
            // Log.Debug("bian: trigger trans back!");
            var character = Helper.GetBGUPlayerCharacterCS();
            var model = GetCurrentModel(character);
            if (model != null)
            {
                model.TransBack();
                SkillIndex = 0;

                if (((BaseModel)model).TransDone != null)
                {
                    if (((BaseModel)model).TransDone.Buffers != null && ((BaseModel)model).TransDone.Buffers.Count > 0)
                    {
                        foreach (var buffer in ((BaseModel)model).TransDone.Buffers)
                        {
                            BGUFunctionLibraryCS.BGURemoveBuffImmediately(character, buffer, EBuffEffectTriggerType.Remove);
                            // Log.Debug($"bian: remove buff --> {buffer}");
                        }
                    }
                }
                else
                {
                    character.SetActorScale3D(new FVector(1.0, 1.0, 1.0));
                }

            }
            else if (character.Mesh.SkeletalMesh.PathName.IndexOf("_plant") > -1)
            {
                model = FindModelByLabel("SK_lys_snowkutree_05", "MAGIC");
                if (model != null)
                {
                    model.TransBack();
                    SkillIndex = 0;
                }
            }

            if (Config != null && Config.TransDone != null)
            {
                if (Config.TransDone.Buffers != null && Config.TransDone.Buffers.Count > 0)
                {
                    foreach (var buffer in Config.TransDone.Buffers)
                    {
                        BGUFunctionLibraryCS.BGURemoveBuffImmediately(character, buffer, EBuffEffectTriggerType.Remove);
                        // Log.Debug($"bian: remove buff --> {buffer}");
                    }
                }
            }

            if (model != null)
            {
                if (((BaseModel)model).PlayTimeRate != 1)
                {
                    Helper.GetBUS_GSEventCollection().Evt_SetGMCustomTimeDilation.Invoke(1f);
                }
            }

            models.ForEach(item =>
            {
                ((BaseModel)item).IsTrans = false;
            });

        }


        public void BindEvents()
        {
            HashSet<string> unique = new HashSet<string>();
            List<string> list = new List<string>();
            List<string> padKeys = new List<string>();

            foreach (var key in KeyValuePairs.Keys)
            {
                list.Add(key);
            }

            foreach (var key in PadValuePairs.Keys)
            {
                padKeys.Add(key);
            }

            string s = String.Join("|", list);
            string p = String.Join("|", padKeys);
            Regex regex = new Regex($@"^(?:({p})(?:(\+({p}))*)|([CAS]\+)*({s}))$", RegexOptions.IgnoreCase);
            Regex normalRegex = new Regex($@"^([CAS]\+)*({s})$", RegexOptions.IgnoreCase);
            Regex padRegexStrict = new Regex($@"^({p})(?:(\+({p}))*)$", RegexOptions.IgnoreCase);

            if (models != null)
            {
                foreach (BaseModel item in models.Concat(new ITransable[] { Wukong, }))
                {
                    if (item != null && item.Skills != null)
                    {
                        foreach (Skill skill in item.Skills)
                        {
                            if (regex.IsMatch(skill.Key))
                            {
                                unique.Add(skill.Key.ToUpper());
                            }
                            else if (skill.Key != null && skill.Key != "")
                            {
                                // Log.Error($"{item.Label} key {skill.Key} format error!");
                            }
                        }
                    }
                }
            }

            if (Config != null)
            {
                foreach (var keyItem in Config.KeyMapping)
                {
                    if (keyItem.Key != null && regex.IsMatch(keyItem.Key))
                    {
                        unique.Add(keyItem.Key.ToUpper());
                    }
                    else if (keyItem.Key != null && keyItem.Key != "")
                    {
                        // Log.Error($"config {keyItem.Label} key {keyItem.Key} format error!");
                    }
                }
            }

            if (GamePadConf != null && GamePadConf.KeyBinding != null && GamePadConf.KeyBinding.Count > 0)
            {
                foreach (var item in GamePadConf.KeyBinding)
                {
                    if (padRegexStrict.IsMatch(item.Key) && normalRegex.IsMatch(item.Value))
                    {
                        unique.Add(item.Key.ToUpper());
                    }
                    else
                    {
                        // Log.Error($"gamepad keybinding error! key: {item.Key}, value:{item.Value}");
                    }
                }
            }

            foreach (var key in unique)
            {
                var keys = key.Split('+');
                var controlKey = ModifierKeys.None;
                var normalKey = Key.None;

                if (padRegexStrict.IsMatch(key))
                {
                    var realKey = key;
                    if (GamePadConf != null && GamePadConf.KeyBinding != null)
                    {
                        var tempRealKey = "";
                        GamePadConf.KeyBinding.TryGetValue(key, out tempRealKey);
                        if (tempRealKey != null && tempRealKey != "")
                        {
                            realKey = tempRealKey;
                        }
                    }
                    var keyFlag = GamePadButton.None;
                    var tempKey = GamePadButton.None;
                    List<GamePadButton> flags = new List<GamePadButton>();
                    for (int i = 0; i < keys.Length; i++)
                    {
                        PadValuePairs.TryGetValue(keys[i], out tempKey);
                        keyFlag |= tempKey;
                        flags.Add(tempKey);
                    }
                    Utils.RegisterGamePadBind(keyFlag, () =>
                    {
                        TriggerSkill(realKey);
                    });
                    if (realKey != key)
                    {
                        // Log.Debug($"Bind GamePad key: {key} --> {realKey}, keyflag: {keyFlag}");
                    }
                    else
                    {
                        // Log.Debug($"Bind GamePad key: {key}, keyflag: {keyFlag}");
                    }
                }
                else if (keys.Length >= 2)
                {

                    for (int i = 0; i < keys.Length - 1; i++)
                    {
                        if (keys[i] == "A")
                        {
                            controlKey |= ModifierKeys.Alt;
                        }
                        else if (keys[i] == "C")
                        {
                            controlKey |= ModifierKeys.Control;
                        }
                        else if (keys[i] == "S")
                        {
                            controlKey |= ModifierKeys.Shift;
                        }
                    }

                    KeyValuePairs.TryGetValue(keys.Last(), out normalKey);

                    Utils.RegisterKeyBind(controlKey, normalKey, () =>
                    {
                        TriggerSkill(key);
                    });
                    // Log.Debug($"Bind key: {key}");
                }
                else
                {
                    KeyValuePairs.TryGetValue(keys[0], out normalKey);
                    // Log.Debug($"Bind key: {key}");
                    Utils.RegisterKeyBind(normalKey, () =>
                    {
                        TriggerSkill(key);
                    });
                }
            }

        }

        public void RegEvent()
        {
            var character = Helper.GetBGUPlayerCharacterCS();
            BPS_GSEventCollection.Get(character.PlayerState).Evt_TriggerPlayerTransBegin -= new Del_PlayerTransBegin(OnEventTransBegin);
            BPS_GSEventCollection.Get(character.PlayerState).Evt_TriggerPlayerTransBegin += new Del_PlayerTransBegin(OnEventTransBegin);
        }

        public void UnRegEvent()
        {
            var character = Helper.GetBGUPlayerCharacterCS();
            BPS_GSEventCollection.Get(character.PlayerState).Evt_TriggerPlayerTransBegin -= new Del_PlayerTransBegin(OnEventTransBegin);
        }

        public void ApplyBuffers()
        {
            if (Config != null && Config.TransDone != null)
            {
                var character = Helper.GetBGUPlayerCharacterCS();
                if (Config.TransDone.Buffers != null && Config.TransDone.Buffers.Count > 0)
                {
                    foreach (var buffer in Config.TransDone.Buffers)
                    {
                        if (!BGUFunctionLibraryCS.BGUHasBuff(character, (EBPBuffID)buffer))
                        {
                            BGUFunctionLibraryCS.BGUAddBuff(character, character, buffer, EBuffSourceType.GM, -1);
                            // Log.Debug($"bian: add buff --> {buffer}");
                        }
                    }
                }
            }

            if (CurrentModel != null && CurrentModel.TransDone != null)
            {
                var character = Helper.GetBGUPlayerCharacterCS();
                if (CurrentModel.TransDone.Buffers != null && CurrentModel.TransDone.Buffers.Count > 0)
                {
                    foreach (var buffer in CurrentModel.TransDone.Buffers)
                    {
                        if (!BGUFunctionLibraryCS.BGUHasBuff(character, (EBPBuffID)buffer))
                        {
                            BGUFunctionLibraryCS.BGUAddBuff(character, character, buffer, EBuffSourceType.GM, -1);
                            // Log.Debug($"bian: add buff --> {buffer}");
                        }
                    }
                }
            }

            if (CurrentModel != null)
            {
                if (CurrentModel.Level1Scale > 0 && CurrentModel.Level1Scale != 1)
                {
                    var scale = CurrentModel.Level1Scale;
                    var character = Helper.GetBGUPlayerCharacterCS();
                    if (character != null)
                    {
                        character.SetActorScale3D(new FVector(scale, scale, scale));
                    }


                }

                if (CurrentModel.PlayTimeRate != 1)
                {
                    // Log.Debug($"bian: change play rate--->{CurrentModel.PlayTimeRate}");
                    Helper.GetBUS_GSEventCollection().Evt_SetGMCustomTimeDilation.Invoke(CurrentModel.PlayTimeRate);
                }

            }
        }

        private void DoTransEnd()
        {
            var character = Helper.GetBGUPlayerCharacterCS();
            BGUFunctionLibraryCS.BGUAddBuff(character, character, 20300, EBuffSourceType.GM, 1000);
            BGUFunctionLibraryCS.BGUAddBuff(character, character, 20400, EBuffSourceType.GM, -1);

            // Log.Debug("bian: do trans end SKMESH:" + character.Mesh.SkeletalMesh.GetFullName());

            var model = (BaseModel)GetCurrentModel(character);
            if (model != null)
            {

                if (model.DisableDepthOfField)
                {
                    model.DoDisableDepthOfField(character);
                }
            }
            else
            {
                // Log.Error("unsupport SKMESH:" + character.Mesh.SkeletalMesh.GetFullName());
            }
            ApplyBuffers();
        }

        public void OnEventTransBegin(EPlayerTransBeginType UnitTransType, PlayerTransParam PlayerTransParam)
        {
            DoTransEnd();
        }

        public bool CastSkill(BGUPlayerCharacterCS character, Skill skill, EMontageBindReason Source, bool Force, int Rate = 0, int[] Buffers = null, float playTimeRate = 1)
        {

            FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(skill.Id, character);
            if (skillSDesc != null)
            {
                if (!Force)
                {
                    if (!skill.CanBreak && Helper.DateTimeToTimestamp() <= CoolDownTime)
                    {
                        return false;
                    }
                    else
                    {
                        var SkillMontage = BGW_PreloadAssetMgr.Get(character).TryGetCachedResourceObj<UAnimMontage>(skillSDesc.TemplatePath, ELoadResourceType.SyncLoadAndCache);
                        // Log.Debug($"play lengh: {SkillMontage.GetPlayLength()} name: {SkillMontage.GetPathName()}");
                        if (Buffers != null)
                        {
                            foreach (var buffer in Buffers)
                            {
                                BGUFunctionLibraryCS.BGUAddBuff(character, character, buffer, EBuffSourceType.GM, SkillMontage.GetPlayLength() * 1000 / playTimeRate);
                            }
                        }

                        CoolDownTime = Helper.DateTimeToTimestamp() + SkillMontage.GetPlayLength() * 1000 * Rate / 100 / playTimeRate;
                        BUS_EventCollectionCS.Get(character).Evt_RequestSmartCastSkill.Invoke(skill.Id, null, Source, false);
                    }
                }
                else
                {
                    if (Buffers != null)
                    {
                        var SkillMontage = BGW_PreloadAssetMgr.Get(character).TryGetCachedResourceObj<UAnimMontage>(skillSDesc.TemplatePath, ELoadResourceType.SyncLoadAndCache);
                        foreach (var buffer in Buffers)
                        {
                            BGUFunctionLibraryCS.BGUAddBuff(character, character, buffer, EBuffSourceType.GM, SkillMontage.GetPlayLength() * 1000 / playTimeRate);
                        }
                    }
                    BUS_EventCollectionCS.Get(character).Evt_RequestSmartCastSkill.Invoke(skill.Id, null, Source, false);
                }
            }
            return true;
        }

        public ITransable? FindModelByLabel(string? Label, string Type)
        {
            if (Label == null)
            {
                return null;
            }

            foreach (var item in models)
            {
                if (item.IsCurrentModel(Label) && ((BaseModel)item).Type == Type)
                {
                    return item;
                }
            }

            return null;
        }

        public void OnPlayMontageCallback(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
        {
            // Log.Debug(Montage.PathName);
            // Log.Debug($"{State}");

            switch (State)
            {
                case EMontageCallbackState.OnCompleted:
                    // Log.Debug($"bian: trigger montage {Montage.PathName}");
                    if (Montage.PathName.IndexOf("AM_wukong_trans_from_Vigor") > -1)
                    {
                        // Log.Debug($"bian:skill success! 10100");
                        if (!(CurrentModel is TransModel))
                        {
                            var character = Helper.GetBGUPlayerCharacterCS();
                            if (Helper.IsWukong(character))
                            {
                                ((ITransable)CurrentModel).TransToModel();
                                ApplyBuffers();
                            }
                        }
                    }
                    break;
            }
        }


        public void DoTrans(ITransable model)
        {
            CurrentModel = model as BaseModel;

            if (CurrentModel.Label.ToLower().IndexOf("wukong") != -1)
            {
                return;
            }

            // Log.Debug($"bian: do trans  {((BaseModel)model).Label}");
            if (model is TransModel)
            {
                RegEvent();
            }
            model.TransToModel();

            if (!(model is TransModel))
            {
                ApplyBuffers();
            }
            SkillIndex = 0;
        }

        private void SyncHitCount(string key, List<Skill> skills, int hitCount)
        {
            if (skills != null)
            {
                foreach (var skill in skills)
                {
                    if (skill.Key == key && skill.Step > 0)
                    {
                        skill.HitCount = hitCount;
                    }
                }
            }

        }

        public void ApplyKeyItems(KeyItem keyItem)
        {
            switch (keyItem.Type)
            {
                case "TRANS":
                case "BOSS":
                case "MAGIC":
                    var obj = FindModelByLabel(keyItem.Label, keyItem.Type);

                    if (obj != null && ((BaseModel)obj).Type == keyItem.Type)
                    {
                        CurrentModel = obj as BaseModel;
                        if (CurrentModel is TransModel)
                        {
                            RegEvent();
                        }
                        obj.TransToModel();

                        if (!(obj is TransModel))
                        {
                            ApplyBuffers();
                        }
                        SkillIndex = 0;
                    }
                    else
                    {
                        // Log.Error($"model label {keyItem.Label} not found");
                    }
                    break;
                case "COMMAND":
                    MethodInfo methodInfo = typeof(Commands).GetMethod(keyItem.Label, BindingFlags.Public | BindingFlags.Instance);
                    if (methodInfo != null)
                    {
                        methodInfo.Invoke(new Commands(), new object[] { this, }.Concat(keyItem.Params ?? new object[] { }).ToArray());
                    }
                    break;
                case "ADD_BUFF":
                    var character = Helper.GetBGUPlayerCharacterCS();
                    if (keyItem.BuffId != null)
                    {
                        BGUFunctionLibraryCS.BGUAddBuff(character, character, keyItem.BuffId ?? 103, EBuffSourceType.GM, keyItem.BuffTime ?? 1000);

                    }
                    break;
                default:
                    // Log.Error("unsupport key type");
                    break;
            }
        }


        public void TriggerDebugSkill(int offset = 1)
        {
            SkillIndex += offset;
            var character = Helper.GetBGUPlayerCharacterCS();
            var skillIDs = new List<int>();

            var name = character.Mesh.SkeletalMesh.GetFullName().Split('.').Last();
            if (name.StartsWith("SK_"))
            {
                name = name.Substring(3);
            }
            else if (name.StartsWith("SKEL_"))
            {
                name = name.Substring(5);
            }
            if (name.ToLower().IndexOf("wukong_simple") > -1)
            {
                name = "Wukong";
                skillIDs = BGUFunclibEditorUtility.GetSkillIDByAMPath("Wukong").Concat(BGUFunclibEditorUtility.GetSkillIDByAMPath("wukong")).OrderBy(item => item).ToList();
            }
            else
            {
                skillIDs = BGUFunclibEditorUtility.GetSkillIDByAMPath(name).OrderBy(item => item).ToList();
            }

            // Log.Debug($"bian: keyword: {name}");

            if (skillIDs.Count() == 0)
            {
                var model = GetCurrentModel(character) as BaseModel;
                if (model != null)
                {
                    skillIDs = BGUFunclibEditorUtility.GetSkillIDByAMPath(model.Label.Replace("SK_", "")).OrderBy(item => item).ToList();
                    if (skillIDs.Count() == 0 && model.Skills != null && model.Skills.Count > 0)
                    {
                        skillIDs.AddRange(model.Skills.Where(obj => obj != null).Select(obj => obj.Id).ToList());
                    }
                }

                if (skillIDs.Count() == 0)
                {
                    // Log.Error("bian:unit skills not found!");
                    return;
                }
            }
            // Log.Info($"bian:unit skills found {skillIDs.Count()}, index: {SkillIndex}");

            if (SkillIndex <= skillIDs.Count() && SkillIndex > 0)
            {
                FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(skillIDs[SkillIndex - 1], character);
                while (offset != 0 && skillSDesc == null && SkillIndex > 0 && SkillIndex <= skillIDs.Count())
                {
                    SkillIndex += offset;
                    skillSDesc = BGW_GameDB.GetSkillSDesc(skillIDs[SkillIndex - 1], character);
                }

                if (skillSDesc == null)
                {
                    return;
                }

                // Log.Debug($"Bian: skill found: {skillSDesc.ID}|{skillSDesc.TemplatePath}");
                BUS_EventCollectionCS.Get(character).Evt_RequestSmartCastSkill.Invoke(skillSDesc.ID, null, EMontageBindReason.Default, false);
            }
            else if (SkillIndex > skillIDs.Count())
            {
                SkillIndex = 0;
            }
            else
            {
                SkillIndex = skillIDs.Count() - 1;
            }
        }

        public bool TriggerSkill(string key)
        {
            BGUPlayerCharacterCS character = null;
            try
            {
                character = Helper.GetBGUPlayerCharacterCS();
            }
            catch
            {
                return false;
            }

            if (!HasInit)
            {
                HasInit = true;
            }

            if (character == null || character.Mesh == null || character.Mesh.SkeletalMesh == null)
            {
                // Log.Debug($"bian: waitting game loaded...");
                return false;
            }

            // Log.Debug($"bian: -----trigger key:{key}, current sk:{character.Mesh.SkeletalMesh.GetFullName()}");

            if (character.Mesh.SkeletalMesh.GetFullName().ToLower().IndexOf("SK_Wukong_Simple".ToLower()) > -1)
            {
                if (Config == null)
                {
                    // Log.Error($"config.json load field!");
                    return false;
                }

                foreach (var keyItem in Config.KeyMapping)
                {
                    if (key == keyItem.Key)
                    {
                        ApplyKeyItems(keyItem);
                    }
                }
                TriggerKeyEvent(Wukong, key, character);
            }
            else
            {
                foreach (var keyItem in Config.KeyMapping)
                {
                    if (key == keyItem.Key && keyItem.AlawaysCanCast)
                    {
                        ApplyKeyItems(keyItem);
                        return true;
                    }
                }

                var obj = GetCurrentModel(character);
                TriggerKeyEvent(obj, key, character);
            }

            return false;
        }


        public bool TriggerKeyEvent(ITransable obj, string key, BGUPlayerCharacterCS character)
        {
            if (obj != null)
            {
                foreach (var skill in ((BaseModel)obj).Skills)
                {
                    if (skill.Key == key)
                    {

                        int rate = ((BaseModel)obj).CoolDownRate;
                        float playTimeRate = ((BaseModel)obj).PlayTimeRate;
                        if (skill.Step > 0 && skill.StepCount > 0)
                        {
                            if (skill.HitCount % skill.StepCount == skill.Step - 1)
                            {
                                var flag = CastSkill(character, skill, EMontageBindReason.Default, false, rate, skill.GetAllBuffers(), playTimeRate);
                                if (flag)
                                {
                                    skill.HitCount += 1;
                                    // Log.Debug($"hit count: {skill.HitCount}");
                                    SyncHitCount(skill.Key, ((BaseModel)obj).Skills, skill.HitCount);
                                }
                                return flag;
                            }
                        }
                        else
                        {
                            return CastSkill(character, skill, EMontageBindReason.Default, false, rate, skill.GetAllBuffers(), playTimeRate);
                        }
                    }
                }
            }
            return false;
        }


        public static int GetSkillIDByFName(string FName)
        {
            var skillID = 0;
            SkillMapping.TryGetValue(FName, out skillID);
            return skillID;
        }

        public static void RefreshSkillMapping(BaseModel model)
        {

            if (model.Skills != null && model.Skills.Count > 0)
            {
                for (int i = 0; i < model.Skills.Count; i++)
                {
                    if (model.Skills[i].Id > 0)
                    {
                        var skillDesc = BGW_GameDB.GetOriginalSkillSDesc(model.Skills[i].Id);
                        if (skillDesc != null && skillDesc.TemplatePath != null)
                        {
                            var fName = skillDesc.TemplatePath.Split('.').Last().ToLower().Trim(['\'']);
                            model.Skills[i].SetFName(fName);
                            if (!SkillMapping.ContainsKey(fName))
                            {
                                SkillMapping.Add(fName, model.Skills[i].Id);
                            }
                        }
                    }
                }
            }
        }


        public static List<ITransable> LoadFromJson()
        {
            List<ITransable> models = new List<ITransable>();
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string modelsDirectory = Path.Combine(currentDirectory, @"CSharpLoader\Mods\bian\models");
            string exportDirectory = Path.Combine(currentDirectory, @"CSharpLoader\Mods\bian\models\export");
            if (!File.Exists(modelsDirectory))
            {
                Directory.CreateDirectory(modelsDirectory);
            }

            if (!File.Exists(exportDirectory))
            {
                Directory.CreateDirectory(exportDirectory);
            }

            string[] JsonFiles = Directory.GetFiles(modelsDirectory, "*.json").OrderByDescending(f => File.GetLastWriteTime(f)).Concat(Directory.GetFiles(exportDirectory, "*.json").OrderByDescending(f => File.GetLastWriteTime(f)))
                                    .ToArray();

            HashSet<string> keys = new HashSet<string>();

            foreach (var path in JsonFiles)
            {
                // 读取文件内容
                string JsonContent = File.ReadAllText(path);

                var dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonContent);
                string type = (string)dict["Type"];
                string label = (string)dict["Label"];
                string key = $"{label}_{type}";

                if (keys.Contains(key))
                {
                    // Log.Warn($"bian: existed config file, skip {label} {type}");
                    continue;
                }
                keys.Add(key);

                ITransable obj = null;
                try
                {

                    switch (type)
                    {
                        case "BOSS":
                            obj = JsonConvert.DeserializeObject<BossModel>(JsonContent);
                            break;
                        case "MAGIC":
                            obj = JsonConvert.DeserializeObject<MagicChangeModel>(JsonContent);
                            break;

                        case "TRANS":
                            obj = JsonConvert.DeserializeObject<TransModel>(JsonContent);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    // Error($"bian:load model config error! -->{path},{ex}");
                }
                if (obj == null)
                {
                    // Log.Error($"{path} format error!unsupport type :{type}");
                }
                else
                {
                    var model = (BaseModel)obj;
                    models.Add(obj);
                    model.RefreshStepCount();
                    RefreshSkillMapping(model);
                }
            }
            // Log.Info($"bian: load models done, count: {models.Count}");
            return models;
        }

        public static Conf? LoadConfig()
        {
            string CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string ConfPath = Path.Combine(CurrentDirectory, @"CSharpLoader\Mods\bian\conf\config.json");
            if (!File.Exists(ConfPath))
            {
                // Log.Error($"{ConfPath} not found");
                return null;
            }

            Conf config = new Conf();
            string JsonContent = File.ReadAllText(ConfPath);
            try
            {
                config = JsonConvert.DeserializeObject<Conf>(JsonContent);
            }
            catch (Exception ex)
            {
                // Log.Error($"bian:load config error! -->{ConfPath},{ex}");
            }

            // Log.Info($"bian: load config done, count: {config?.KeyMapping?.Count}");
            return config;
        }

        public static GamePadConf LoadPadKeyConfig()
        {
            string CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string ConfPath = Path.Combine(CurrentDirectory, @"CSharpLoader\Mods\bian\conf\gamepad.json");
            if (!File.Exists(ConfPath))
            {
                // Log.Error($"{ConfPath} not found");
                return null;
            }

            GamePadConf config = new GamePadConf();
            string JsonContent = File.ReadAllText(ConfPath);
            try
            {
                config = JsonConvert.DeserializeObject<GamePadConf>(JsonContent);
            }
            catch (Exception ex)
            {
                // Log.Error($"bian:load gamepad config error! -->{ConfPath},{ex}");
            }

            // Log.Info($"bian: load gamepad config done, count: {config?.KeyBinding?.Count}");
            return config;
        }

        public static List<RuleGroup> LoadRules()
        {
            List<RuleGroup> rules = new List<RuleGroup>();
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string rulesDirectory = Path.Combine(currentDirectory, @"CSharpLoader\Mods\bian\rules");
            if (!File.Exists(rulesDirectory))
            {
                Directory.CreateDirectory(rulesDirectory);
            }
            string[] JsonFiles = Directory.GetFiles(rulesDirectory, "*.json").OrderByDescending(f => File.GetLastWriteTime(f)).ToArray();

            HashSet<string> keys = new HashSet<string>();

            foreach (var path in JsonFiles)
            {
                // 读取文件内容
                string JsonContent = File.ReadAllText(path);

                try
                {
                    var ruleGroup = JsonConvert.DeserializeObject<RuleGroup>(JsonContent);
                    ruleGroup.path = path.Split('/').Last();

                    rules.Add(ruleGroup);
                }
                catch (Exception e)
                {
                    // Log.Error($"bian:load rule config rule--> {path}, {e}");
                }
            }
            // Log.Info($"bian: load rules done, count: {rules.Count}");
            return rules;
        }
    }

    public class BaseModel
    {
        public string? Name { get; set; }
        public string Label { get; set; }
        public string Type { get; set; }
        public int CoolDownRate { get; set; }

        public float PlayTimeRate { get; set; }

        public float XRateBig { get; set; }

        public float ZRateBig { get; set; }
        public float XRateSmall { get; set; }

        public float Level1Scale { get; set; }

        public float Level2Scale { get; set; }


        public List<Skill>? Skills { get; set; }

        public bool DisableDepthOfField { get; set; }

        public AfterTransDone? TransDone { get; set; }


        public float XRate { get; set; }
        public float ZRate { get; set; }

        public string Author { get; set; }


        public bool IsTrans = false;


        public BaseModel()
        {
            CoolDownRate = 0;
            Label = "SK_UNSUPPORT_MESH";
            Type = "UNSUPPORT";
            XRate = 0;
            ZRate = 0;
            Author = "神秘人物";
            PlayTimeRate = 1;
        }

        public void DoDisableDepthOfField(BGUPlayerCharacterCS character)
        {
            var setting = character.FollowCamera.PostProcessSettings;
            setting.Override_DepthOfFieldFocalDistance = false;
            setting.Override_DepthOfFieldMinFstop = false;
            setting.Override_DepthOfFieldDepthBlurAmount = false;
            setting.DepthOfFieldFstop = 8.0f;
            setting.DepthOfFieldFocalDistance = 10000;
            setting.DepthOfFieldDepthBlurAmount = 0.0f;
            character.FollowCamera.PostProcessSettings = setting;
        }


        public void RefreshStepCount()
        {
            if (Skills != null)
            {
                var groupedSkills = Skills.GroupBy(s => s.Key);

                foreach (var group in groupedSkills)
                {
                    int groupCount = group.Count();
                    foreach (var skill in group)
                    {
                        skill.StepCount = groupCount;
                    }
                }
            }
        }
    }



    public class TransModel : BaseModel, ITransable
    {
        // TODO
        public int Id { get; set; }
        public string Asset { get; set; }
        public Skill? EnterSkill { get; set; }

        public bool IsCurrentModel(string SkName)
        {
            if (SkName.ToLower().IndexOf(Label.ToLower()) > -1)
            {
                return true;
            }
            return false;
        }

        public void TransBack()
        {
            var character = Helper.GetBGUPlayerCharacterCS();

            IBPC_PlayerTagData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerTagData, BPC_PlayerTagData>(character.PlayerState);
            if (readOnlyData.HasTag(EBGPPlayerTag.Transforming))
            {
                BPS_GSEventCollection.Get(character.PlayerState).Evt_TriggerPlayerTransEnd.Invoke(EPlayerTransEndType.CastSpell, default(PlayerTransParam));
            }
        }

        public void TransToModel()
        {
            if (EnterSkill != null && EnterSkill.Id != null)
            {
                var character = Helper.GetBGUPlayerCharacterCS();
                BUS_EventCollectionCS.Get(character).Evt_RequestSmartCastSkill.Invoke(EnterSkill.Id, null, EMontageBindReason.NormalSkill, false);
            }
        }
    }


    public class MagicChangeModel : BaseModel, ITransable
    {

        public Skill? EnterSkill { get; set; }
        private int TransEndTime = 0;

        public MagicChangeModel()
        {
            XRate = 0;
            ZRate = 0;
        }

        public bool IsCurrentModel(string SkName)
        {
            if (SkName.ToLower().IndexOf(Label.ToLower()) > -1)
            {
                return true;
            }
            return false;
        }

        public void TransBack()
        {
            if (EnterSkill != null)
            {
                var character = Helper.GetBGUPlayerCharacterCS();
                BUS_MagicallyChangeComp magicChangeComp = Helper.FindActorCompByClass<BUS_MagicallyChangeComp>(character);
                Helper.ResetVigorSkill(magicChangeComp, EnterSkill.Id);
                character = Helper.GetBGUPlayerCharacterCS();
                BUS_EventCollectionCS.Get(character)?.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(10199, ECastSkillSourceType.GM));
                character.FollowCamera.RelativeLocation = new UnrealEngine.Runtime.FVector(0, 0, 0);
            }
        }

        public void TransToModel()
        {
            if (EnterSkill != null && !IsTrans)
            {
                var character = Helper.GetBGUPlayerCharacterCS();
                if (character != null)
                {
                    IsTrans = true;
                    BUS_EventCollectionCS.Get(character)?.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(10100, ECastSkillSourceType.GM));
                    Task.Run(async delegate
                    {
                        await Task.Delay(650);
                        Utils.TryRunOnGameThread((Action)delegate
                        {
                            var character = Helper.GetBGUPlayerCharacterCS();
                            if (!EnterSkill.IsMimicry)
                            {
                                Helper.CastVigorSkill(character, EnterSkill.Id);
                            }
                            else
                            {
                                Helper.CastMimicrySkill(character, EnterSkill.Id);
                            }

                            if (XRate != 0 || ZRate != 0)
                            {
                                character = Helper.GetBGUPlayerCharacterCS();
                                character.FollowCamera.RelativeLocation = new UnrealEngine.Runtime.FVector(XRate, 0, ZRate);
                            }
                        });
                        IsTrans = false;
                    });
                }
            }
        }
    }


    public class BossModel : BaseModel, ITransable
    {

        public string TamerPath { set; get; }

        public BossConfig BossConf { set; get; }
        private BGWDataAsset_MagicallyChangeConfig config = null;

        public bool IsCurrentModel(string SkName)
        {
            if (SkName.ToLower().IndexOf(Label.ToLower()) > -1)
            {
                return true;
            }
            return false;
        }

        public void TransBack()
        {
            BuildConfig();
            var character = Helper.GetBGUPlayerCharacterCS();
            BUS_MagicallyChangeComp magicChangeComp = Helper.FindActorCompByClass<BUS_MagicallyChangeComp>(character);
            character = Helper.GetBGUPlayerCharacterCS();


            FieldInfo fieldData = typeof(BUS_MagicallyChangeComp).GetField("MagicallyChangeData", BindingFlags.NonPublic | BindingFlags.Instance);
            BUC_MagicallyChangeData data = fieldData.GetValue(magicChangeComp) as BUC_MagicallyChangeData;
            data.DurMagicallyChange = true;
            data.bIsPendingCast = false;
            data.bIsPendingReset = true;
            data.ResetReason = EResetReason_MagicallyChange.Normal;
            data.CastReason = ECastReason_MagicallyChange.NormalSkill;

            data.PendingConfig = config;
            MethodInfo reset = typeof(BUS_MagicallyChangeComp).GetMethod("Reset", BindingFlags.NonPublic | BindingFlags.Instance);
            reset.Invoke(magicChangeComp, new Object[] { data.ResetReason }); ;

            character.FollowCamera.RelativeLocation = new UnrealEngine.Runtime.FVector(0, 0, 0);
            Task.Run(async delegate
            {
                await Task.Delay(70);
                Utils.TryRunOnGameThread((Action)delegate
                {
                    var character = Helper.GetBGUPlayerCharacterCS();
                    BUS_EventCollectionCS.Get(character)?.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(10199, ECastSkillSourceType.GM));
                });
                IsTrans = false;
            });
        }

        public void BuildConfig()
        {
            var character = Helper.GetBGUPlayerCharacterCS();

            config = new BGWDataAsset_MagicallyChangeConfig();

            // Log.Debug($"bian: start load ABPClass-------------------");
            var magicChangeComp = Helper.FindActorCompByClass<BUS_MagicallyChangeComp>(character);
            config = BGW_PreloadAssetMgr.Get(magicChangeComp).TryGetCachedResourceObj<BGWDataAsset_MagicallyChangeConfig>("BGWDataAsset_MagicallyChangeConfig'/Game/00MainHZ/Characters/Transform/VigorSkill/S2/MC_40_psd_hutoushe_01.MC_40_psd_hutoushe_01'", ELoadResourceType.SyncLoadAndCache);
            config.ABPClass = Helper.LoadClass(BossConf.ABPClass);
            // Log.Debug($"bian: ABPClass<{config.ABPClass}> ");

            // Log.Debug($"bian: start load SKMesh-------------------");
            config.SKMesh = UObject.LoadObject<USkeletalMesh>(Helper.GetWorld(), BossConf.SKMesh);
            // Log.Debug($"bian: SKMesh<{config.SKMesh.GetFullName()}>");

            config.CapsuleRadius = BossConf.CapsuleRadius;
            config.CapsuleHalfHeight = BossConf.CapsuleHalfHeight;
            config.Override_AbnormalDispID_Attacker = BossConf.Override_AbnormalDispID_Attacker;
            config.Override_AbnormalDispID_Victim = BossConf.Override_AbnormalDispID_Victim;
            config.TamerAssetPath = TamerPath;

            // Log.Debug($"bian: end load PhysicsAsset-------------------");
            config.PhysicsAsset = UObject.LoadObject<UPhysicsAsset>(Helper.GetWorld(), BossConf.PhysicsAsset);
            // Log.Debug($"bian: PhysicsAsset-------------<{config.PhysicsAsset.PathName}>");

            // Log.Debug($"bian: start load TFXConfig-------------------");
            config.TFXConfig.Clear();
            if (BossConf.TFXConfigs != null && BossConf.TFXConfigs.Count > 0)
            {
                for (int i = 0; i < BossConf.TFXConfigs.Count; i++)
                {

                    var item = default(FMagicallyChangeConfig_TFXConfig);
                    if (BossConf.TFXConfigs[i].TFXAsset != null)
                    {
                        item.TFXAsset = UObject.LoadObject<UTressFXAsset>(Helper.GetWorld(), BossConf.TFXConfigs[i].TFXAsset);
                        // Log.Debug($"bian: load TFXAsset: {item.TFXAsset.PathName}");
                    }

                    item.ShadeSettings = default(FTressFXShadeSettings);
                    item.ShadeSettings.FiberRadius = BossConf.TFXConfigs[i].ShadeSettings.FiberRadius;
                    item.ShadeSettings.FiberSpacing = BossConf.TFXConfigs[i].ShadeSettings.FiberSpacing;
                    item.ShadeSettings.HairThickness = BossConf.TFXConfigs[i].ShadeSettings.HairThickness;
                    item.ShadeSettings.RootTangentBlending = BossConf.TFXConfigs[i].ShadeSettings.RootTangentBlending;
                    item.ShadeSettings.ShadowThickness = BossConf.TFXConfigs[i].ShadeSettings.ShadowThickness;

                    item.LodScreenSize = BossConf.TFXConfigs[i].LodScreenSize;
                    item.bEnableSimulation = BossConf.TFXConfigs[i].EnableSimulation;

                    if (BossConf.TFXConfigs[i].HairMaterial != null)
                    {
                        item.HairMaterial = UObject.LoadObject<UMaterialInterface>(Helper.GetWorld(), BossConf.TFXConfigs[i].HairMaterial);
                        // Log.Debug($"bian: load HairMaterial: {item.HairMaterial}");
                    }

                    config.TFXConfig.Add(item);
                }
            }
            // Log.Debug($"bian: TFXConfig count:{config.TFXConfig.Count}");


            // Log.Debug($"bian: start load InteractBones-------------------");
            config.InteractBones.Clear();
            if (BossConf.InteractBones != null && BossConf.InteractBones.Count > 0)
            {
                for (int i = 0; i < BossConf.InteractBones.Count; i++)
                {
                    var item = default(FBoneUseForDispMap);
                    item.FirstRadius = BossConf.InteractBones[i].FirstRadius;
                    item.NextRadius = BossConf.InteractBones[i].NextRadius;
                    item.FirstBoneName = new FName(BossConf.InteractBones[i].FirstBoneName);
                    item.NextBoneName = new FName(BossConf.InteractBones[i].NextBoneName);
                }
            }
            // Log.Debug($"bian: InteractBones count:{config.InteractBones.Count}");

            config.Materials.Clear();
            config.Weapons.Clear();

            // Log.Debug($"bian: start load weapons -------------------");

            if (BossConf.Weapons != null && BossConf.Weapons.Count > 0)
            {
                List<FUnitWeapon> weapons = new List<FUnitWeapon>();
                for (int i = 0; i < BossConf.Weapons.Count; i++)
                {
                    var item = BossConf.Weapons[i];
                    var weapon = default(FUnitWeapon);
                    weapon.Weapon = UObject.LoadClass<AActor>(null, item.Weapon);
                    weapon.SocketName = new FName(item.SocketName);
                    weapons.Add(weapon);
                    // Log.Debug($"bian: load Weapons: {weapon.Weapon.GetDefaultObject().PathName}");
                }
                config.Weapons.SetValues(weapons);
            }
            // Log.Debug($"bian: load weapons count: {config.Weapons.Count} -------------------");
        }

        public void DoTrans()
        {
            var character = Helper.GetBGUPlayerCharacterCS();
            // Log.Debug($"bian: loaded boss config {config}");

            var magicChangeComp = Helper.FindActorCompByClass<BUS_MagicallyChangeComp>(character);
            var BGS = Helper.GetBUS_GSEventCollection();

            FieldInfo fieldData = typeof(BUS_MagicallyChangeComp).GetField("MagicallyChangeData", BindingFlags.NonPublic | BindingFlags.Instance);
            BUC_MagicallyChangeData data = fieldData.GetValue(magicChangeComp) as BUC_MagicallyChangeData;

            data.DurMagicallyChange = false;
            data.CurVigorSkillID = 0;

            UGSE_AnimFuncLib.StopAllMontages(character, 0f);
            UGSE_AnimFuncLib.TickAnimationAndRefreshBone(character);
            BGS.Evt_UnitTryBreakSkill.Invoke("触发幻化变身技能，打断当前技能");

            Dictionary<string, object[]> methodDictionary = new Dictionary<string, object[]>
                {
                    { "SetSKMesh", new object[] { config.SKMesh, config.ABPClass, config.Materials.ToList() } },
                    { "UpdateAbnormalDispID", new object[] {  false, config.Override_AbnormalDispID_Attacker, config.Override_AbnormalDispID_Victim} },
                    { "UpdateMeshInfo", new object[] { true, } },
                    { "UpdateHitMoveCollision", new object[] { true, config.CapsuleHalfHeight, config.CapsuleRadius } },
                    { "UpdateTressFXInfo", new object[] { true, config } },
                    { "UpdateWeapons", new object[] { true, config } },
                    { "UpdateDispInteractInfo", new object[] { true, config } },
                };
            foreach (var entry in methodDictionary)
            {
                MethodInfo methodInfo = magicChangeComp.GetType().GetMethod(entry.Key, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                if (methodInfo != null)
                {
                    try
                    {
                        methodInfo.Invoke(magicChangeComp, entry.Value);
                    }
                    catch (TargetInvocationException ex)
                    {
                        Console.WriteLine($"Error invoking {entry.Key}: {ex.InnerException.Message}");
                    }
                }
                else
                {
                    Console.WriteLine($"Method {entry.Key} not found.");
                }
            }

            data.bIsPendingReset = false;
            character = Helper.GetBGUPlayerCharacterCS();
            if (XRate != 0 || ZRate != 0)
            {
                character = Helper.GetBGUPlayerCharacterCS();
                character.FollowCamera.RelativeLocation = new FVector(XRate, 0, ZRate);
            }

            // Log.Debug($"bian:trans to boss {character.Mesh.SkeletalMesh.PathName} done!");
            IsTrans = false;
        }

        public void TransToModel()
        {
            BuildConfig();
            if (IsTrans)
            {
                return;
            }
            IsTrans = true;
            // Log.Debug($"bian: trans to boss, {TamerPath}");
            var character = Helper.GetBGUPlayerCharacterCS();
            BUS_EventCollectionCS.Get(character)?.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(10100, ECastSkillSourceType.GM));

            Task.Run(async delegate
            {
                await Task.Delay(650);
                Utils.TryRunOnGameThread((Action)delegate
                {
                    DoTrans();
                });
                IsTrans = false;
            });
        }
    }
}
