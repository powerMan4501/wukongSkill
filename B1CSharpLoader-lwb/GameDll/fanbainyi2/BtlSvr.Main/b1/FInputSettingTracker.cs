using System;
using System.Collections.Generic;
using System.Linq;
using ArchiveB1;
using b1.Plugins.GSInput;
using B1UI.GSUI;
using BtlB1;
using CommB1;
using OssB1;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1;

public class FInputSettingTracker : FInputTrackerBase
{
	public class FDetailTrackerBase
	{
		protected FInputSettingTracker InputSettingTracker { get; }

		protected Dictionary<FName, FCustomizedKeyConfig> MappableCustomizedKeyConfigs => InputSettingTracker.MappableCustomizedKeyConfigs;

		protected BGW_SettingMgrV2 SettingMgr => InputSettingTracker.SettingMgr;

		protected List<FCustomizedInputTypeInfo> InputMappingContextInfos => InputSettingTracker.InputMappingContextInfos.Values.ToList();

		protected APlayerController LocalPlayerController => UGSE_EngineFuncLib.GetFirstLocalPlayerController(SettingMgr);

		protected ulong RoleId => 0uL;

		protected FDetailTrackerBase(FInputSettingTracker InInputSettingTracker)
		{
			InputSettingTracker = InInputSettingTracker;
		}

		protected bool IsMappableNameOfType(FName MappableName, EGSInputChangeType InputChangeType)
		{
			if (MappableCustomizedKeyConfigs.TryGetValue(MappableName, out var value))
			{
				return value.ChangeType == InputChangeType;
			}
			return false;
		}

		public virtual bool TryDumpFullOssData(InputSettingInfo Data)
		{
			Data.RoleId = RoleId;
			return true;
		}
	}

	public class FKeyboardTracker : FDetailTrackerBase
	{
		public UGSInputSettingsPreProcEvent PreProcEvent { get; }

		private Dictionary<FName, FName> DefaultMappableKeyDic { get; }

		private Dictionary<FName, FName> UserMappableKeyDic { get; set; }

		private Dictionary<FName, FName> CurMappableKeyDic { get; set; }

		private List<FKey> WhiteKeyList { get; }

		private Dictionary<ECustomizedKeyUnlockCondition, Func<bool>> UnlockConditions { get; set; }

		public FKeyboardTracker(FInputSettingTracker InInputSettingTracker, BGWDataAsset_CustomizedInputSetting CustomizedInputSetting)
			: base(InInputSettingTracker)
		{
			PreProcEvent = UObject.NewObject<UGSInputSettingsPreProcEvent>(base.InputSettingTracker.Owner);
			PreProcEvent.AddToRoot();
			WhiteKeyList = CustomizedInputSetting.WhiteKeyList.ToList();
			RegisterUnlockConditions();
			DefaultMappableKeyDic = new Dictionary<FName, FName>();
			foreach (FCustomizedInputTypeInfo inputMappingContextInfo in base.InputMappingContextInfos)
			{
				UInputMappingContext duplicateInputMappingContext = inputMappingContextInfo.DuplicateInputMappingContext;
				foreach (KeyValuePair<FName, FKey> item in UGSE_InputFuncLib.GetMappableKey(duplicateInputMappingContext))
				{
					FName key = item.Key;
					if (!IsMappableNameOfType(key, EGSInputChangeType.KeyboardMouse))
					{
						continue;
					}
					FName fName = item.Value.GetFName();
					if (!CustomizedInputSetting.Configs.ContainsKey(key))
					{
						continue;
					}
					if (DefaultMappableKeyDic.ContainsKey(key))
					{
						if (DefaultMappableKeyDic[key] != fName)
						{
							FMessage.OpenDialog($"Enhanced Input: Mappable 设置冲突：InputMappingContext = {duplicateInputMappingContext}, Name = {key}, Key1 = {DefaultMappableKeyDic[key]}, Key2 = {fName}");
						}
					}
					else
					{
						DefaultMappableKeyDic.Add(key, fName);
					}
				}
			}
			CurMappableKeyDic = new Dictionary<FName, FName>();
			if (base.SettingMgr.EnhancedInput == null)
			{
				base.SettingMgr.EnhancedInput = new EnhancedInputSettingData();
			}
			if (!base.SettingMgr.EnhancedInput.KeyboardMappableKeys.Any())
			{
				foreach (KeyValuePair<FName, FName> item2 in DefaultMappableKeyDic)
				{
					base.SettingMgr.EnhancedInput.KeyboardMappableKeys.Add(new CommB1.MappableKey
					{
						MappableName = item2.Key.PlainName,
						KeyName = item2.Value.PlainName
					});
				}
			}
			foreach (CommB1.MappableKey keyboardMappableKey in base.SettingMgr.EnhancedInput.KeyboardMappableKeys)
			{
				CurMappableKeyDic.Add(new FName(keyboardMappableKey.MappableName), new FName(keyboardMappableKey.KeyName));
			}
			foreach (FName item3 in CurMappableKeyDic.Keys.Except(DefaultMappableKeyDic.Keys).ToList())
			{
				CurMappableKeyDic.Remove(item3);
			}
			foreach (FName item4 in DefaultMappableKeyDic.Keys.Except(CurMappableKeyDic.Keys).ToList())
			{
				CurMappableKeyDic.Add(item4, DefaultMappableKeyDic[item4]);
			}
			Apply();
		}

		private void RegisterUnlockConditions()
		{
			UnlockConditions = new Dictionary<ECustomizedKeyUnlockCondition, Func<bool>>
			{
				{
					ECustomizedKeyUnlockCondition.AlwaysShow,
					() => true
				},
				{
					ECustomizedKeyUnlockCondition.MagicArtifact,
					() => GetGlobalData()?.ShowFabaoBtn ?? false
				},
				{
					ECustomizedKeyUnlockCondition.VigorSkill,
					() => GetGlobalData()?.ShowSoulSkillBtn ?? false
				},
				{
					ECustomizedKeyUnlockCondition.Cloud,
					() => GetGlobalData()?.ShowJinDouYunBtn ?? false
				},
				{
					ECustomizedKeyUnlockCondition.PropStance,
					() => GetGlobalData()?.ShowPropStanceBtn ?? false
				},
				{
					ECustomizedKeyUnlockCondition.PokeStance,
					() => GetGlobalData()?.ShowPokeStanceBtn ?? false
				}
			};
			ReadOnlyGlobalData GetFromShareArchiveSaveFile()
			{
				GlobalData globalData = BGW_GameArchiveMgr.Get(base.SettingMgr).LoadShareDataOnly()?.SharedRoleData?.GlobalData;
				if (globalData != null)
				{
					return new ReadOnlyGlobalData(globalData);
				}
				return null;
			}
			ReadOnlyGlobalData GetGlobalData()
			{
				if (BGUFuncLibMap.IsBattleMap(base.SettingMgr))
				{
					IBPC_PlayerRoleData playerControlReadonlyData = BGU_DataUtil.GetPlayerControlReadonlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(base.LocalPlayerController);
					if (playerControlReadonlyData != null)
					{
						return playerControlReadonlyData.RoleData?.RoleCs?.Museum?.GlobalData ?? GetFromShareArchiveSaveFile();
					}
				}
				return GetFromShareArchiveSaveFile();
			}
		}

		public bool IsUnlock(ECustomizedKeyUnlockCondition UnlockCondition)
		{
			UnlockConditions.TryGetValue(UnlockCondition, out var value);
			return value?.Invoke() ?? false;
		}

		public void OnShutdown()
		{
			PreProcEvent.UnbindAction();
			PreProcEvent.RemoveFromRoot();
		}

		public bool ReplaceKey(FName MappableName, FName KeyName, out EUIWordID Reason)
		{
			Reason = (EUIWordID)0;
			if (UGSE_UMGFuncLib.GetIsGamepadKey(KeyName))
			{
				return false;
			}
			if (!IsInWhiteList(KeyName))
			{
				Reason = EUIWordID.KEY_NOT_SUPPORT_CUSTOMIZED;
				return false;
			}
			if (base.MappableCustomizedKeyConfigs.TryGetValue(MappableName, out var value))
			{
				if (value.ChangeType == EGSInputChangeType.Gamepad)
				{
					return false;
				}
				if (CurMappableKeyDic.ContainsKey(MappableName))
				{
					CurMappableKeyDic[MappableName] = KeyName;
					return true;
				}
				CurMappableKeyDic.Add(MappableName, KeyName);
				return false;
			}
			return false;
		}

		public void ResumeToDefault()
		{
			CurMappableKeyDic = BGU_DeepCopyUtil.Copy(DefaultMappableKeyDic);
			Apply();
		}

		public void ResumeToUser()
		{
			CurMappableKeyDic = BGU_DeepCopyUtil.Copy(UserMappableKeyDic);
		}

		public FKey GetCurKey(FName MappableName)
		{
			if (CurMappableKeyDic.TryGetValue(MappableName, out var value))
			{
				return UGSE_UMGFuncLib.GetKeyWithName(value);
			}
			return new FKey(EKeys.Invalid);
		}

		private bool IsInWhiteList(FName KeyName)
		{
			return WhiteKeyList.Any((FKey WhiteKey) => WhiteKey.GetFName() == KeyName);
		}

		public bool IsInWhiteList(FKey Key)
		{
			return IsInWhiteList(Key.GetFName());
		}

		public int GetMappableKeyNum(FName KeyName)
		{
			return CurMappableKeyDic.Count((KeyValuePair<FName, FName> pair) => pair.Value == KeyName);
		}

		public bool IsDefault()
		{
			if (DefaultMappableKeyDic.Count != UserMappableKeyDic.Count)
			{
				return false;
			}
			foreach (KeyValuePair<FName, FName> item in DefaultMappableKeyDic)
			{
				FName key = item.Key;
				FName value = item.Value;
				if (UserMappableKeyDic.TryGetValue(key, out var value2))
				{
					if (value != value2)
					{
						return false;
					}
					continue;
				}
				return false;
			}
			return true;
		}

		public EConflictType GetConflictType(FName KeyName)
		{
			bool flag = false;
			bool flag2 = false;
			foreach (KeyValuePair<FName, FName> item in CurMappableKeyDic)
			{
				FName key = item.Key;
				if (!(item.Value == KeyName))
				{
					continue;
				}
				if (base.MappableCustomizedKeyConfigs.TryGetValue(key, out var value))
				{
					if (value.InputTab == EGSInputTab.Comm || value.InputTab == EGSInputTab.Battle)
					{
						flag = true;
					}
					else if (value.InputTab == EGSInputTab.System)
					{
						flag2 = true;
					}
				}
				if (flag && flag2)
				{
					return EConflictType.BothConflict;
				}
			}
			if (flag)
			{
				return EConflictType.BattleConflict;
			}
			if (flag2)
			{
				return EConflictType.SystemConflict;
			}
			return EConflictType.NoConflict;
		}

		public EConflictType GetConflictType(FName KeyName, EGSInputTab InputTab)
		{
			int num = -1;
			foreach (KeyValuePair<FName, FName> item in CurMappableKeyDic)
			{
				FName key = item.Key;
				if (!(item.Value == KeyName) || !base.MappableCustomizedKeyConfigs.TryGetValue(key, out var value))
				{
					continue;
				}
				switch (InputTab)
				{
				case EGSInputTab.Comm:
				case EGSInputTab.Battle:
					if ((value.InputTab == EGSInputTab.Comm || value.InputTab == EGSInputTab.Battle) && ++num > 0)
					{
						return EConflictType.BattleConflict;
					}
					break;
				case EGSInputTab.System:
					if (value.InputTab == EGSInputTab.System && ++num > 0)
					{
						return EConflictType.SystemConflict;
					}
					break;
				}
			}
			return EConflictType.NoConflict;
		}

		public bool CheckAllKeysHasConflict()
		{
			foreach (KeyValuePair<FName, FName> item in CurMappableKeyDic)
			{
				FName key = item.Key;
				FName value = item.Value;
				if (!base.MappableCustomizedKeyConfigs.TryGetValue(key, out var value2))
				{
					continue;
				}
				EGSInputTab inputTab = value2.InputTab;
				foreach (KeyValuePair<FName, FName> item2 in CurMappableKeyDic)
				{
					FName key2 = item2.Key;
					FName value3 = item2.Value;
					if (key2 == key || !base.InputSettingTracker.MappableCustomizedKeyConfigs.TryGetValue(key2, out var value4))
					{
						continue;
					}
					EGSInputTab inputTab2 = value4.InputTab;
					if (value == value3)
					{
						if ((inputTab == EGSInputTab.Battle || inputTab == EGSInputTab.Comm) && (inputTab2 == EGSInputTab.Battle || inputTab2 == EGSInputTab.Comm))
						{
							return true;
						}
						if (inputTab == EGSInputTab.System && inputTab2 == EGSInputTab.System)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		public bool ConfirmReplace()
		{
			if (CheckAllKeysHasConflict())
			{
				return false;
			}
			Apply();
			return true;
		}

		public void Apply()
		{
			foreach (KeyValuePair<FName, FName> item in CurMappableKeyDic)
			{
				FName key = item.Key;
				FName value = item.Value;
				foreach (FCustomizedInputTypeInfo inputMappingContextInfo in base.InputMappingContextInfos)
				{
					if (inputMappingContextInfo.IsSupport(base.InputSettingTracker.SettingMgr.EnhancedInput.CustomizedInputType))
					{
						UGSE_InputFuncLib.CustomizeInputMappingContext(inputMappingContextInfo.DuplicateInputMappingContext, key, value);
					}
				}
			}
			UGSE_InputFuncLib.FlushPressedInput(base.LocalPlayerController);
			base.InputSettingTracker.SettingMgr.EnhancedInput.KeyboardMappableKeys.Clear();
			foreach (KeyValuePair<FName, FName> item2 in CurMappableKeyDic)
			{
				base.InputSettingTracker.SettingMgr.EnhancedInput.KeyboardMappableKeys.Add(new CommB1.MappableKey
				{
					MappableName = item2.Key.PlainName,
					KeyName = item2.Value.PlainName
				});
			}
			base.InputSettingTracker.SettingMgr.WriteSaveCloudData();
			if (UserMappableKeyDic == null)
			{
				UserMappableKeyDic = BGU_DeepCopyUtil.Copy(CurMappableKeyDic);
				return;
			}
			if (GSEUtil.Ensure(UserMappableKeyDic.Count == CurMappableKeyDic.Count, "Enhanced Input: 按键自定义映射前后数量不相等"))
			{
				List<ChangedMappableKey> list = new List<ChangedMappableKey>();
				foreach (KeyValuePair<FName, FName> item3 in UserMappableKeyDic)
				{
					FName key2 = item3.Key;
					FName value2 = item3.Value;
					if (CurMappableKeyDic.TryGetValue(key2, out var value3) && value2 != value3)
					{
						list.Add(new ChangedMappableKey
						{
							MappableName = key2.PlainName,
							OldKeyName = value2.PlainName,
							NewKeyName = value3.PlainName
						});
					}
				}
				if (list.Any())
				{
					ReportEventInputSettingChange reportEventInputSettingChange = new ReportEventInputSettingChange();
					reportEventInputSettingChange.RoleId = base.RoleId;
					reportEventInputSettingChange.ChangedMappableKeys.AddRange(list);
					EventReporter.GetInstance(base.SettingMgr).InputSettingChange(reportEventInputSettingChange);
				}
			}
			UserMappableKeyDic = BGU_DeepCopyUtil.Copy(CurMappableKeyDic);
		}

		public override bool TryDumpFullOssData(InputSettingInfo Data)
		{
			if (base.TryDumpFullOssData(Data))
			{
				foreach (CommB1.MappableKey keyboardMappableKey in base.SettingMgr.EnhancedInput.KeyboardMappableKeys)
				{
					Data.KeyboardMappableKeys.Add(new OssB1.MappableKey
					{
						KeyName = keyboardMappableKey.KeyName,
						MappableName = keyboardMappableKey.MappableName
					});
				}
				return true;
			}
			return false;
		}
	}

	public class FGamepadTracker : FDetailTrackerBase
	{
		private Dictionary<ECustomizedInputType, FGamepadCustomizedInputConfig> GamepadCustomizedInputConfigs { get; }

		private Dictionary<ECustomizedInputType, Dictionary<FName, FName>> DefaultMappableKeyDic { get; }

		private Dictionary<ECustomizedInputType, Dictionary<FName, FName>> CurMappableKeyDic { get; set; }

		public FGamepadTracker(FInputSettingTracker InInputSettingTracker, BGWDataAsset_CustomizedInputSetting CustomizedInputSetting)
			: base(InInputSettingTracker)
		{
			GamepadCustomizedInputConfigs = CustomizedInputSetting.GamepadCustomizedInputConfigs.ToDictionary();
			DefaultMappableKeyDic = new Dictionary<ECustomizedInputType, Dictionary<FName, FName>>();
			foreach (ECustomizedInputType item in Enum.GetValues(typeof(ECustomizedInputType)).Cast<ECustomizedInputType>())
			{
				if (item == ECustomizedInputType.None)
				{
					continue;
				}
				Dictionary<FName, FName> dictionary = new Dictionary<FName, FName>();
				DefaultMappableKeyDic.Add(item, dictionary);
				if (!CustomizedInputSetting.GamepadCustomizedInputConfigs.TryGetValue(item, out var value))
				{
					continue;
				}
				foreach (FGamepadCustomizedInputDetailConfig detailConfig in value.DetailConfigs)
				{
					List<FName> firstMappableNames = detailConfig.FirstMappableNames;
					List<FName> secondMappableNames = detailConfig.SecondMappableNames;
					List<FName> list = BGU_DeepCopyUtil.Copy(firstMappableNames);
					list.AddRange(secondMappableNames);
					foreach (FCustomizedInputTypeInfo inputMappingContextInfo in base.InputMappingContextInfos)
					{
						if (!inputMappingContextInfo.IsSupport(item))
						{
							continue;
						}
						UInputMappingContext duplicateInputMappingContext = inputMappingContextInfo.DuplicateInputMappingContext;
						Dictionary<FName, FKey> mappableKey = UGSE_InputFuncLib.GetMappableKey(duplicateInputMappingContext);
						foreach (FName item2 in list)
						{
							if (!mappableKey.TryGetValue(item2, out var value2))
							{
								continue;
							}
							FName fName = value2.GetFName();
							if (CustomizedInputSetting.Configs.ContainsKey(item2))
							{
								if (dictionary.TryGetValue(item2, out var value3))
								{
									FMessage.OpenDialog($"Enhanced Input: Mappable 设置冲突：InputMappingContext = {duplicateInputMappingContext}, Name = {item2}, Key1 = {value3}, Key2 = {fName}");
								}
							}
							else
							{
								dictionary.Add(item2, fName);
							}
						}
					}
				}
			}
			CurMappableKeyDic = new Dictionary<ECustomizedInputType, Dictionary<FName, FName>>();
			if (base.SettingMgr.EnhancedInput == null)
			{
				base.SettingMgr.EnhancedInput = new EnhancedInputSettingData();
			}
			if (base.SettingMgr.EnhancedInput.CustomizedInputType == ECustomizedInputType.None)
			{
				base.SettingMgr.EnhancedInput.CustomizedInputType = base.InputSettingTracker.DefaultCustomizedInputType;
			}
			if (!base.SettingMgr.EnhancedInput.GamepadMappableKey.Any() || base.SettingMgr.EnhancedInput.GamepadMappableKey.Any((GamepadMappableKey item) => !item.MappableKeys.Any()))
			{
				base.SettingMgr.EnhancedInput.GamepadMappableKey.Clear();
				foreach (KeyValuePair<ECustomizedInputType, Dictionary<FName, FName>> item3 in DefaultMappableKeyDic)
				{
					GamepadMappableKey gamepadMappableKey = new GamepadMappableKey
					{
						CustomizedInputType = item3.Key
					};
					foreach (KeyValuePair<FName, FName> item4 in item3.Value)
					{
						gamepadMappableKey.MappableKeys.Add(new CommB1.MappableKey
						{
							MappableName = item4.Key.PlainName,
							KeyName = item4.Value.PlainName
						});
					}
					base.SettingMgr.EnhancedInput.GamepadMappableKey.Add(gamepadMappableKey);
				}
			}
			foreach (GamepadMappableKey item5 in base.SettingMgr.EnhancedInput.GamepadMappableKey)
			{
				Dictionary<FName, FName> dictionary2 = new Dictionary<FName, FName>();
				CurMappableKeyDic.Add(item5.CustomizedInputType, dictionary2);
				foreach (CommB1.MappableKey mappableKey2 in item5.MappableKeys)
				{
					dictionary2.Add(new FName(mappableKey2.MappableName), new FName(mappableKey2.KeyName));
				}
			}
			Apply();
		}

		public FGamepadSettingDetailInfo GetDetailInfoByIndex(int Index)
		{
			return GetDetailInfos().ElementAtOrDefault(Index);
		}

		public List<FGamepadSettingDetailInfo> GetDetailInfos()
		{
			if (GamepadCustomizedInputConfigs.TryGetValue(base.SettingMgr.EnhancedInput.CustomizedInputType, out var value))
			{
				return value.DetailConfigs.Select((FGamepadCustomizedInputDetailConfig item) => new FGamepadSettingDetailInfo
				{
					AnimationName = item.AnimationName.PlainName,
					UIWord = item.DetailUIWord
				}).ToList();
			}
			return new List<FGamepadSettingDetailInfo>();
		}

		private void Apply()
		{
			base.SettingMgr.EnhancedInput.GamepadMappableKey.Clear();
			foreach (ECustomizedInputType key2 in CurMappableKeyDic.Keys)
			{
				GamepadMappableKey gamepadMappableKey = new GamepadMappableKey();
				base.SettingMgr.EnhancedInput.GamepadMappableKey.Add(gamepadMappableKey);
				gamepadMappableKey.CustomizedInputType = key2;
				foreach (KeyValuePair<FName, FName> item in CurMappableKeyDic[key2])
				{
					FName key = item.Key;
					FName value = item.Value;
					gamepadMappableKey.MappableKeys.Add(new CommB1.MappableKey
					{
						KeyName = value.PlainName,
						MappableName = key.PlainName
					});
					foreach (FCustomizedInputTypeInfo inputMappingContextInfo in base.InputMappingContextInfos)
					{
						if (inputMappingContextInfo.IsSupport(base.SettingMgr.EnhancedInput.CustomizedInputType))
						{
							UGSE_InputFuncLib.CustomizeInputMappingContext(inputMappingContextInfo.DuplicateInputMappingContext, key, value);
						}
					}
				}
			}
			base.InputSettingTracker.SettingMgr.WriteSaveCloudData();
			UGSE_InputFuncLib.FlushPressedInput(base.LocalPlayerController);
		}

		public override bool TryDumpFullOssData(InputSettingInfo Data)
		{
			if (base.TryDumpFullOssData(Data))
			{
				Data.GamepadInputType = base.SettingMgr.EnhancedInput.CustomizedInputType.ToString();
				foreach (GamepadMappableKey item in base.SettingMgr.EnhancedInput.GamepadMappableKey)
				{
					GamepadDetailSettingInfo gamepadDetailSettingInfo = new GamepadDetailSettingInfo();
					gamepadDetailSettingInfo.InputDetailType = item.CustomizedInputType.ToString();
					foreach (CommB1.MappableKey mappableKey in item.MappableKeys)
					{
						gamepadDetailSettingInfo.DetailMappableKeys.Add(new OssB1.MappableKey
						{
							KeyName = mappableKey.KeyName,
							MappableName = mappableKey.MappableName
						});
					}
					Data.GamepadDetailSettingInfo.Add(gamepadDetailSettingInfo);
				}
				return true;
			}
			return false;
		}

		public void ResumeToDefault()
		{
			base.SettingMgr.EnhancedInput.CustomizedInputType = base.InputSettingTracker.DefaultCustomizedInputType;
			CurMappableKeyDic = BGU_DeepCopyUtil.Copy(DefaultMappableKeyDic);
			Apply();
		}

		public void ToggleCustomizedInputType(ECustomizedInputType CustomizedInputType)
		{
			if (base.SettingMgr.EnhancedInput.CustomizedInputType != CustomizedInputType)
			{
				ReportEventInputSettingChange reportEventInputSettingChange = new ReportEventInputSettingChange();
				reportEventInputSettingChange.RoleId = base.RoleId;
				reportEventInputSettingChange.OldGamepadInputType = base.SettingMgr.EnhancedInput.CustomizedInputType.ToString();
				reportEventInputSettingChange.NewGamepadInputType = CustomizedInputType.ToString();
				EventReporter.GetInstance(base.SettingMgr).InputSettingChange(reportEventInputSettingChange);
				base.SettingMgr.EnhancedInput.CustomizedInputType = CustomizedInputType;
				Apply();
			}
		}

		public void ToggleDetailGamepadInput(int Index, bool IsSetToDefault)
		{
			if (IsSetToDefault == IsDetailGamepadInputDefault(Index) || !GamepadCustomizedInputConfigs.TryGetValue(base.SettingMgr.EnhancedInput.CustomizedInputType, out var value) || !CurMappableKeyDic.TryGetValue(base.SettingMgr.EnhancedInput.CustomizedInputType, out var value2))
			{
				return;
			}
			if (value.DetailConfigs.Count <= Index)
			{
				FMessage.OpenDialog($"Enhanced Input: 申请交换的按键的Index[{Index}]超过数组长度");
				return;
			}
			List<FName> firstMappableNames = value.DetailConfigs[Index].FirstMappableNames;
			List<FName> secondMappableNames = value.DetailConfigs[Index].SecondMappableNames;
			if (!firstMappableNames.Any() || !secondMappableNames.Any())
			{
				FMessage.OpenDialog($"Enhanced Input: {base.SettingMgr.EnhancedInput.CustomizedInputType}配置的第{Index}项存在没有Mappable Name的配置");
			}
			else
			{
				if (!value2.TryGetValue(firstMappableNames[0], out var value3) || !value2.TryGetValue(secondMappableNames[0], out var value4))
				{
					return;
				}
				ReportEventInputSettingChange reportEventInputSettingChange = new ReportEventInputSettingChange();
				reportEventInputSettingChange.RoleId = base.RoleId;
				foreach (FName item in firstMappableNames)
				{
					reportEventInputSettingChange.ChangedMappableKeys.Add(new ChangedMappableKey
					{
						MappableName = item.PlainName,
						NewKeyName = value4.PlainName,
						OldKeyName = value3.PlainName
					});
					value2[item] = value4;
				}
				foreach (FName item2 in secondMappableNames)
				{
					reportEventInputSettingChange.ChangedMappableKeys.Add(new ChangedMappableKey
					{
						MappableName = item2.PlainName,
						NewKeyName = value3.PlainName,
						OldKeyName = value4.PlainName
					});
					value2[item2] = value3;
				}
				EventReporter.GetInstance(base.SettingMgr).InputSettingChange(reportEventInputSettingChange);
				Apply();
			}
		}

		public bool IsDefault()
		{
			if (!IsCustomizedInputTypeDefault())
			{
				return false;
			}
			if (GamepadCustomizedInputConfigs.TryGetValue(base.SettingMgr.EnhancedInput.CustomizedInputType, out var value))
			{
				for (int i = 0; i < value.DetailConfigs.Count; i++)
				{
					if (!IsDetailGamepadInputDefault(i))
					{
						return false;
					}
				}
			}
			return true;
		}

		public bool IsCustomizedInputTypeDefault()
		{
			return base.SettingMgr.EnhancedInput.CustomizedInputType == base.InputSettingTracker.DefaultCustomizedInputType;
		}

		public bool IsDetailGamepadInputDefault(int Index)
		{
			if (CurMappableKeyDic.TryGetValue(base.SettingMgr.EnhancedInput.CustomizedInputType, out var value) && DefaultMappableKeyDic.TryGetValue(base.SettingMgr.EnhancedInput.CustomizedInputType, out var value2))
			{
				if (value.Count != value2.Count)
				{
					return false;
				}
				foreach (KeyValuePair<FName, FName> item in value)
				{
					FName key = item.Key;
					FName value3 = item.Value;
					if (!value2.TryGetValue(key, out var value4) || value4 != value3)
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}
	}

	public struct FCustomizedInputTypeInfo
	{
		public UInputMappingContext DuplicateInputMappingContext;

		public bool IsPermanent;

		public ECustomizedInputType CustomizedInputType;

		public bool IsSupport(ECustomizedInputType InCustomizedInputType)
		{
			if (!IsPermanent)
			{
				return CustomizedInputType == InCustomizedInputType;
			}
			return true;
		}
	}

	private BGW_SettingMgrV2 SettingMgr { get; }

	public Dictionary<FName, FCustomizedKeyConfig> MappableCustomizedKeyConfigs { get; }

	public ECustomizedInputType DefaultCustomizedInputType { get; }

	public Dictionary<UInputMappingContext, FCustomizedInputTypeInfo> InputMappingContextInfos { get; }

	public FKeyboardTracker KeyboardSetting { get; set; }

	public FGamepadTracker GamepadSetting { get; set; }

	public FInputSettingTracker(BGW_EnhancedInputMgrV2 InOwner, BGWDataAsset_CustomizedInputSetting CustomizedInputSetting, BGWDataAsset_InputMappingContextConfigV2 InputMappingContextConfig)
	{
		base.Owner = InOwner;
		SettingMgr = BGW_SettingMgrV2.Get(base.Owner);
		MappableCustomizedKeyConfigs = CustomizedInputSetting.Configs.ToDictionary();
		DefaultCustomizedInputType = InputMappingContextConfig.DefaultCustomizedInputType;
		InputMappingContextInfos = new Dictionary<UInputMappingContext, FCustomizedInputTypeInfo>();
		foreach (FInputMappingContextConfigV2 value in InputMappingContextConfig.Configs.Values)
		{
			InputMappingContextInfos.Add(value.InputMappingContext, new FCustomizedInputTypeInfo
			{
				DuplicateInputMappingContext = UObject.DuplicateObject(value.InputMappingContext, base.Owner),
				CustomizedInputType = InputMappingContextConfig.DefaultCustomizedInputType,
				IsPermanent = (value.IsPermanent || !value.CustomizedInputOverrideConfigs.Any())
			});
			foreach (KeyValuePair<ECustomizedInputType, FCustomizedInputOverrideConfig> customizedInputOverrideConfig in value.CustomizedInputOverrideConfigs)
			{
				InputMappingContextInfos.Add(customizedInputOverrideConfig.Value.InputMappingContext, new FCustomizedInputTypeInfo
				{
					DuplicateInputMappingContext = UObject.DuplicateObject(customizedInputOverrideConfig.Value.InputMappingContext, base.Owner),
					CustomizedInputType = customizedInputOverrideConfig.Key,
					IsPermanent = false
				});
			}
		}
		InputMappingContextInfos.Values.ToList().ForEach(delegate(FCustomizedInputTypeInfo Info)
		{
			Info.DuplicateInputMappingContext.AddToRoot();
		});
		KeyboardSetting = new FKeyboardTracker(this, CustomizedInputSetting);
		GamepadSetting = new FGamepadTracker(this, CustomizedInputSetting);
	}

	public override void OnShutdown()
	{
		KeyboardSetting.OnShutdown();
		KeyboardSetting = null;
		InputMappingContextInfos.Values.ToList().ForEach(delegate(FCustomizedInputTypeInfo Info)
		{
			Info.DuplicateInputMappingContext.RemoveFromRoot();
		});
	}

	public void ResumeToDefault()
	{
		KeyboardSetting.ResumeToDefault();
		GamepadSetting.ResumeToDefault();
	}

	public bool TryDumpFullOssData(InputSettingInfo Data)
	{
		if (KeyboardSetting.TryDumpFullOssData(Data))
		{
			return GamepadSetting.TryDumpFullOssData(Data);
		}
		return false;
	}

	public List<FActionKeyMapping> GetActionKeyMappings()
	{
		List<FActionKeyMapping> list = new List<FActionKeyMapping>();
		foreach (FCustomizedInputTypeInfo value in InputMappingContextInfos.Values)
		{
			if (value.IsSupport(SettingMgr.EnhancedInput.CustomizedInputType))
			{
				UGSE_InputFuncLib.GetMappingsInfo(value.DuplicateInputMappingContext, out var Actions, out var Keys, out var ChordActions);
				for (int i = 0; i < Actions.Count; i++)
				{
					list.Add(new FActionKeyMapping(Actions[i], Keys[i], ChordActions[i]));
				}
			}
		}
		return list;
	}

	public List<FKey> QueryKeysByInputAction(UInputAction InputAction)
	{
		List<FKey> list = new List<FKey>();
		foreach (FCustomizedInputTypeInfo value in InputMappingContextInfos.Values)
		{
			if (value.IsSupport(SettingMgr.EnhancedInput.CustomizedInputType))
			{
				list.AddRange(UGSE_InputFuncLib.QueryKeysByInputAction(value.DuplicateInputMappingContext, InputAction));
			}
		}
		return list;
	}
}
