using System;
using System.Collections.Generic;
using b1.BGW;
using b1.Plugins.GSInput;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1;

public class FInputIconTracker : FInputTrackerBase
{
	private const string InteractIconConfigPathRef = "MaterialParameterCollection'/Game/00MainHZ/UIDev/Comm/Interact/MPC_UIInteractConfig.MPC_UIInteractConfig'";

	private const string GlobalConfigPathRef = "MaterialParameterCollection'/Game/00MainHZ/UI/MPC/MPC_UIGlobal.MPC_UIGlobal'";

	private const string ConnectIconPathRef = "/Game/00MainHZ/UIDev/Comm/Interact/IMG_interact_inputconnect.IMG_interact_inputconnect";

	private const string NoneIconPathRef = "/Game/00MainHZ/UI/AlwaysCook/PressKeyIcon/InputIcon_None.InputIcon_None";

	private const string InlineConnectTexturePathRef = "/Game/00MainHZ/UI/AlwaysCook/RichTextIcon/IMG_richtexticon_inputconnect.IMG_richtexticon_inputconnect";

	private BGW_PreloadAssetMgr PreloadAssetMgr { get; }

	private FInputSettingTracker InputSettingTracker { get; }

	private Dictionary<UInputAction, FInputActionIconInfo> InputActionIconInfos { get; }

	private Dictionary<string, FKeyTextureInfo> InputIconTextureInfos { get; }

	private UMaterialParameterCollection InteractIconConfig { get; }

	private UMaterialParameterCollection GlobalConfig { get; }

	private FName InteractIconConfigParameterName { get; } = new FName("HardwareType");

	private UTexture2D ConnectTexture { get; }

	private UTexture2D NoneTexture { get; }

	private UTexture2D InlineConnectTexture { get; }

	public FInputIconTracker(BGW_EnhancedInputMgrV2 InOwner, FInputSettingTracker InInputSettingTracker)
	{
		base.Owner = InOwner;
		PreloadAssetMgr = BGW_PreloadAssetMgr.Get(base.Owner);
		InputSettingTracker = InInputSettingTracker;
		InputActionIconInfos = new Dictionary<UInputAction, FInputActionIconInfo>();
		InputIconTextureInfos = new Dictionary<string, FKeyTextureInfo>();
		InteractIconConfig = PreloadAssetMgr.TryGetCachedResourceObj<UMaterialParameterCollection>("MaterialParameterCollection'/Game/00MainHZ/UIDev/Comm/Interact/MPC_UIInteractConfig.MPC_UIInteractConfig'", ELoadResourceType.SyncLoadAndCache);
		if (BGW_EnhancedInputMgrV2.CheckLoadAssetInvalid(InteractIconConfig, "InteractIconConfig", "MaterialParameterCollection'/Game/00MainHZ/UIDev/Comm/Interact/MPC_UIInteractConfig.MPC_UIInteractConfig'"))
		{
			return;
		}
		InteractIconConfig.AddToRoot();
		GlobalConfig = PreloadAssetMgr.TryGetCachedResourceObj<UMaterialParameterCollection>("MaterialParameterCollection'/Game/00MainHZ/UI/MPC/MPC_UIGlobal.MPC_UIGlobal'", ELoadResourceType.SyncLoadAndCache);
		if (BGW_EnhancedInputMgrV2.CheckLoadAssetInvalid(GlobalConfig, "GlobalConfig", "MaterialParameterCollection'/Game/00MainHZ/UI/MPC/MPC_UIGlobal.MPC_UIGlobal'"))
		{
			return;
		}
		GlobalConfig.AddToRoot();
		ConnectTexture = BGW_PreloadAssetMgr.Get(base.Owner).TryGetCachedResourceObj<UTexture2D>("/Game/00MainHZ/UIDev/Comm/Interact/IMG_interact_inputconnect.IMG_interact_inputconnect", ELoadResourceType.SyncLoadAndCache);
		if (BGW_EnhancedInputMgrV2.CheckLoadAssetInvalid(ConnectTexture, "ConnectTexture", "/Game/00MainHZ/UIDev/Comm/Interact/IMG_interact_inputconnect.IMG_interact_inputconnect"))
		{
			return;
		}
		ConnectTexture.AddToRoot();
		NoneTexture = BGW_PreloadAssetMgr.Get(base.Owner).TryGetCachedResourceObj<UTexture2D>("/Game/00MainHZ/UI/AlwaysCook/PressKeyIcon/InputIcon_None.InputIcon_None", ELoadResourceType.SyncLoadAndCache);
		if (!BGW_EnhancedInputMgrV2.CheckLoadAssetInvalid(NoneTexture, "NoneTexture", "/Game/00MainHZ/UI/AlwaysCook/PressKeyIcon/InputIcon_None.InputIcon_None"))
		{
			NoneTexture.AddToRoot();
			InlineConnectTexture = BGW_PreloadAssetMgr.Get(base.Owner).TryGetCachedResourceObj<UTexture2D>("/Game/00MainHZ/UI/AlwaysCook/RichTextIcon/IMG_richtexticon_inputconnect.IMG_richtexticon_inputconnect", ELoadResourceType.SyncLoadAndCache);
			if (!BGW_EnhancedInputMgrV2.CheckLoadAssetInvalid(InlineConnectTexture, "InlineConnectTexture", "/Game/00MainHZ/UI/AlwaysCook/RichTextIcon/IMG_richtexticon_inputconnect.IMG_richtexticon_inputconnect"))
			{
				InlineConnectTexture.AddToRoot();
				UpdateGlobalSharpValue(FInputTypeTracker.CurInputType);
				RefreshInputIconTextureCache();
				RefreshInputActionIconCache();
			}
		}
	}

	public override void OnShutdown()
	{
		foreach (FKeyTextureInfo value in InputIconTextureInfos.Values)
		{
			value.Texture?.RemoveFromRoot();
			value.InlineTexture?.RemoveFromRoot();
		}
		InteractIconConfig.RemoveFromRoot();
		GlobalConfig.RemoveFromRoot();
		ConnectTexture.RemoveFromRoot();
		NoneTexture.RemoveFromRoot();
		InlineConnectTexture.RemoveFromRoot();
	}

	public void PostLoadMapWithWorld()
	{
		UpdateGlobalSharpValue(FInputTypeTracker.CurInputType);
	}

	public void OnInputTypeChangeTrigger(EGSInputType InputType)
	{
		UpdateGlobalSharpValue(InputType);
	}

	private void UpdateGlobalSharpValue(EGSInputType InputType)
	{
		if (InteractIconConfig != null)
		{
			int interactIconSharpValue = GetInteractIconSharpValue(InputType);
			UMaterialLibrary.SetScalarParameterValue(base.Owner, InteractIconConfig, InteractIconConfigParameterName, interactIconSharpValue);
		}
		if (GlobalConfig != null)
		{
			int interactIconSharpValue2 = GetInteractIconSharpValue(InputType);
			UMaterialLibrary.SetScalarParameterValue(base.Owner, GlobalConfig, InteractIconConfigParameterName, interactIconSharpValue2);
		}
	}

	public void SwitchPlatformIcon()
	{
		RefreshInputIconTextureCache();
		RefreshInputActionIconCache();
		UGSE_InputFuncLib.UpdateAllInputIcon();
	}

	private void RefreshInputIconTextureCache()
	{
		List<EGSInputIconType> supportInputIconTypes = FInputDeviceTracker.GetSupportInputIconTypes();
		foreach (FKeyTextureInfo value in InputIconTextureInfos.Values)
		{
			value.Texture?.RemoveFromRoot();
			value.InlineTexture?.RemoveFromRoot();
		}
		InputIconTextureInfos.Clear();
		foreach (EGSInputIconType item in supportInputIconTypes)
		{
			string inputIconConfigPath = GetInputIconConfigPath(item);
			string inputIconDirPath = GetInputIconDirPath(item);
			BGWDataAsset_InputIconConfig bGWDataAsset_InputIconConfig = PreloadAssetMgr.TryGetCachedResourceObj<BGWDataAsset_InputIconConfig>(inputIconConfigPath, ELoadResourceType.SyncLoadAndCache);
			if (bGWDataAsset_InputIconConfig == null)
			{
				continue;
			}
			string[] array;
			foreach (object value2 in Enum.GetValues(GetIconBgEnumType(item)))
			{
				string text = value2.ToString();
				string rootDir = FPaths.Combine(inputIconDirPath, text);
				int inBgType = (int)value2;
				if (!FPackageName.FindPackagesInDirectory(rootDir, out var packages))
				{
					continue;
				}
				array = packages;
				for (int i = 0; i < array.Length; i++)
				{
					if (!FPackageName.TryConvertFilenameToLongPackageName(array[i], out var packageName))
					{
						continue;
					}
					string shortName = FPackageName.GetShortName(packageName);
					if (!GSEUtil.Ensure(!TryGetIconInfo(shortName, out var _), "Enhanced Input: InputIconTextureInfos has already been added with the same key " + shortName))
					{
						continue;
					}
					UTexture2D uTexture2D = PreloadAssetMgr.TryGetCachedResourceObj<UTexture2D>(packageName + "." + shortName, ELoadResourceType.SyncLoadAndCache);
					if (!(uTexture2D != null))
					{
						continue;
					}
					uTexture2D.AddToRoot();
					float inOffset = 0f;
					foreach (FKeyIconInfo item2 in bGWDataAsset_InputIconConfig.IconInfo)
					{
						FKey key = item2.Key;
						if (StringParseHelper.SafeToLower(key.ToString()) == StringParseHelper.SafeToLower(shortName))
						{
							inOffset = item2.Offset;
							break;
						}
					}
					InputIconTextureInfos.Add(shortName, new FKeyTextureInfo(uTexture2D, inOffset, inBgType));
				}
			}
			FPackageName.FindPackagesInDirectory(GetInlineIconDirPath(item), out var packages2);
			array = packages2;
			for (int i = 0; i < array.Length; i++)
			{
				if (!FPackageName.TryConvertFilenameToLongPackageName(array[i], out var packageName2))
				{
					continue;
				}
				string shortName2 = FPackageName.GetShortName(packageName2);
				if (TryGetIconInfo(shortName2, out var IconInfo2))
				{
					UTexture2D uTexture2D2 = PreloadAssetMgr.TryGetCachedResourceObj<UTexture2D>(packageName2 + "." + shortName2, ELoadResourceType.SyncLoadAndCache);
					if (uTexture2D2 != null)
					{
						uTexture2D2.AddToRoot();
						IconInfo2.InlineTexture = uTexture2D2;
					}
				}
			}
		}
	}

	private bool TryGetIconInfo(FKey Key, out FKeyTextureInfo IconInfo)
	{
		return TryGetIconInfo(Key.ToString(), out IconInfo);
	}

	private bool TryGetIconInfo(string KeyName, out FKeyTextureInfo IconInfo)
	{
		if (InputIconTextureInfos.TryGetValue(KeyName, out IconInfo))
		{
			return true;
		}
		if (InputIconTextureInfos.TryGetValue(StringParseHelper.SafeToLower(KeyName), out IconInfo))
		{
			return true;
		}
		return false;
	}

	public void RefreshInputActionIconCache()
	{
		InputActionIconInfos.Clear();
		List<FActionKeyMapping> actionKeyMappings = InputSettingTracker.GetActionKeyMappings();
		foreach (FActionKeyMapping item in actionKeyMappings)
		{
			FInputActionIconInfo value = default(FInputActionIconInfo);
			if (item.IsChord())
			{
				List<FKey> list = InputSettingTracker.QueryKeysByInputAction(item.ChordAction);
				foreach (FKey item2 in InputSettingTracker.QueryKeysByInputAction(item.InputAction))
				{
					if (value.IsInitAllIconTypes())
					{
						break;
					}
					EGSInputIconType inputIconType = GetInputIconType(item2.ToString());
					if (!TryGetIconInfo(item2, out var IconInfo))
					{
						continue;
					}
					FInputActionIconInfo.FKeyIconInfo iconInfo = new FInputActionIconInfo.FKeyIconInfo(item2, IconInfo);
					if (inputIconType == EGSInputIconType.KeyboardMouse)
					{
						value.AddIconInfo(iconInfo);
						continue;
					}
					foreach (FKey item3 in list)
					{
						if (inputIconType == GetInputIconType(item3.ToString()) && TryGetIconInfo(item3.ToString(), out var IconInfo2))
						{
							FInputActionIconInfo.FKeyIconInfo chordIconInfo = new FInputActionIconInfo.FKeyIconInfo(item3, IconInfo2);
							value.AddChordIconInfo(iconInfo, chordIconInfo);
						}
					}
				}
			}
			if (value.IsValid() && !InputActionIconInfos.ContainsKey(item.InputAction))
			{
				InputActionIconInfos.Add(item.InputAction, value);
			}
		}
		foreach (FActionKeyMapping item4 in actionKeyMappings)
		{
			FInputActionIconInfo fInputActionIconInfo = default(FInputActionIconInfo);
			if (!item4.IsChord())
			{
				foreach (FKey item5 in InputSettingTracker.QueryKeysByInputAction(item4.InputAction))
				{
					if (fInputActionIconInfo.IsInitAllIconTypes())
					{
						break;
					}
					if (TryGetIconInfo(GetNameFromAlias(item5), out var IconInfo3))
					{
						FInputActionIconInfo.FKeyIconInfo iconInfo2 = new FInputActionIconInfo.FKeyIconInfo(item5, IconInfo3);
						fInputActionIconInfo.AddIconInfo(iconInfo2);
					}
				}
			}
			if (fInputActionIconInfo.IsValid())
			{
				if (InputActionIconInfos.TryGetValue(item4.InputAction, out var value2))
				{
					value2.Merge(fInputActionIconInfo);
				}
				else
				{
					InputActionIconInfos.Add(item4.InputAction, fInputActionIconInfo);
				}
			}
		}
		UGSE_InputFuncLib.UpdateAllInputIcon();
	}

	public bool TryGetInlineIcon(string ActionTag, EGSInputRichTextMarkUpType MarkUpType, out UTexture2D InlineTexture, out UTexture2D InlineChordTexture, out UTexture2D OutConnectTexture)
	{
		InlineTexture = null;
		InlineChordTexture = null;
		OutConnectTexture = null;
		switch (MarkUpType)
		{
		case EGSInputRichTextMarkUpType.InputAction:
		{
			string[] array = ActionTag.Trim().Split(',');
			foreach (string value in array)
			{
				foreach (KeyValuePair<UInputAction, FInputActionIconInfo> inputActionIconInfo in InputActionIconInfos)
				{
					if (!inputActionIconInfo.Key.GetName().EndsWith(value))
					{
						continue;
					}
					EGSInputIconType inputIconType = GetInputIconType(FInputTypeTracker.CurInputType);
					if (inputActionIconInfo.Value.TryGetKeyIconInfo(inputIconType, out var IconInfos))
					{
						if (IconInfos.Count == 1)
						{
							InlineTexture = IconInfos[0].InlineTexture;
							return true;
						}
						if (IconInfos.Count == 2)
						{
							InlineTexture = IconInfos[0].InlineTexture;
							InlineChordTexture = IconInfos[1].InlineTexture;
							OutConnectTexture = InlineConnectTexture;
							return true;
						}
					}
				}
			}
			return false;
		}
		case EGSInputRichTextMarkUpType.InputActionAlwaysShow:
			foreach (KeyValuePair<UInputAction, FInputActionIconInfo> inputActionIconInfo2 in InputActionIconInfos)
			{
				if (!inputActionIconInfo2.Key.GetName().EndsWith(ActionTag))
				{
					continue;
				}
				foreach (FInputActionIconInfo.FKeyIconInfo allKeyIconInfo in inputActionIconInfo2.Value.GetAllKeyIconInfos())
				{
					if (allKeyIconInfo.InlineTexture != null)
					{
						InlineTexture = allKeyIconInfo.InlineTexture;
						return true;
					}
				}
			}
			return false;
		case EGSInputRichTextMarkUpType.Keyboard:
			if (FInputTypeTracker.CurInputType != EGSInputType.KeyboardMouse)
			{
				break;
			}
			goto IL_01e3;
		case EGSInputRichTextMarkUpType.Gamepad:
			{
				if (FInputTypeTracker.CurInputType != EGSInputType.Gamepad)
				{
					break;
				}
				goto IL_01e3;
			}
			IL_01e3:
			InlineTexture = LoadRichTextTexture(MarkUpType, ActionTag);
			return InlineTexture != null;
		}
		return false;
	}

	private UTexture2D LoadRichTextTexture(EGSInputRichTextMarkUpType MarkUpType, string Name)
	{
		string text = "/Game/00MainHZ/UI/AlwaysCook/RichTextIcon/";
		string text2 = "";
		switch (MarkUpType)
		{
		case EGSInputRichTextMarkUpType.Keyboard:
			text2 = "KeyBoard/";
			break;
		case EGSInputRichTextMarkUpType.Gamepad:
			text2 = "Gamepad";
			switch (FInputDeviceTracker.GamepadIconType)
			{
			case EGSInputIconType.XSX:
				text2 += "XboxOne/";
				break;
			case EGSInputIconType.PS5:
				text2 += "PS5/";
				break;
			}
			break;
		}
		return PreloadAssetMgr.TryGetCachedResourceObj<UTexture2D>(text + text2 + Name + "." + Name, ELoadResourceType.SyncLoadAndCache);
	}

	public bool TryGetTextureByKey(string KeyName, out UTexture2D Texture)
	{
		Texture = null;
		if (TryGetIconInfo(KeyName, out var IconInfo))
		{
			Texture = IconInfo.Texture;
			return true;
		}
		return false;
	}

	public bool TryGetTextureByAction(UInputAction InputAction, out float Offset, out UTexture2D Texture, out int BgType, out float ChordOffset, out UTexture2D ChordTexture, out UTexture2D ConnectTexture, out UTexture2D NoneTexture)
	{
		Offset = 0f;
		Texture = null;
		BgType = 99;
		ChordOffset = 0f;
		ChordTexture = null;
		ConnectTexture = null;
		NoneTexture = null;
		if (InputAction != null && InputActionIconInfos.TryGetValue(InputAction, out var value))
		{
			EGSInputIconType inputIconType = GetInputIconType(FInputTypeTracker.CurInputType);
			if (value.IsValid() && value.TryGetKeyIconInfo(inputIconType, out var IconInfos))
			{
				if (IconInfos.Count == 1)
				{
					Offset = IconInfos[0].Offset;
					Texture = IconInfos[0].Texture;
					BgType = IconInfos[0].BgType;
					NoneTexture = this.NoneTexture;
					return true;
				}
				if (IconInfos.Count == 2)
				{
					Offset = IconInfos[0].Offset;
					Texture = IconInfos[0].Texture;
					BgType = IconInfos[0].BgType;
					ChordOffset = IconInfos[1].Offset;
					ChordTexture = IconInfos[1].Texture;
					ConnectTexture = this.ConnectTexture;
					NoneTexture = this.NoneTexture;
					return true;
				}
			}
		}
		return false;
	}

	public bool TryGetTextureInfoByName(string Name, out float Offset, out int BgType)
	{
		Offset = 0f;
		BgType = 99;
		return true;
	}

	private string GetNameFromAlias(FKey Key)
	{
		string text = Key.ToString();
		if (text == "Gamepad_LeftTriggerAxis")
		{
			return "Gamepad_LeftTrigger";
		}
		if (text == "Gamepad_RightTriggerAxis")
		{
			return "Gamepad_RightTrigger";
		}
		return text;
	}

	public static string GetInputIconConfigPath(EGSInputIconType InputIconType)
	{
		return InputIconType switch
		{
			EGSInputIconType.KeyboardMouse => "/Game/00MainHZ/UI/AlwaysCook/PressKeyIcon/KeyBoard/DA_KeyboardMouse_InputIconConfig.DA_KeyboardMouse_InputIconConfig", 
			EGSInputIconType.XSX => "/Game/00MainHZ/UI/AlwaysCook/PressKeyIcon/GamePadXboxOne/DA_XboxOne_InputIconConfig.DA_XboxOne_InputIconConfig", 
			EGSInputIconType.PS5 => "/Game/00MainHZ/UI/AlwaysCook/PressKeyIcon/GamePadPS5/DA_PS5_InputIconConfig.DA_PS5_InputIconConfig", 
			_ => string.Empty, 
		};
	}

	public static string GetInputIconDirPath(EGSInputIconType InputIconType)
	{
		return InputIconType switch
		{
			EGSInputIconType.KeyboardMouse => "/Game/00MainHZ/UI/AlwaysCook/PressKeyIcon/KeyBoard", 
			EGSInputIconType.XSX => "/Game/00MainHZ/UI/AlwaysCook/PressKeyIcon/GamePadXboxOne", 
			EGSInputIconType.PS5 => "/Game/00MainHZ/UI/AlwaysCook/PressKeyIcon/GamePadPS5", 
			_ => string.Empty, 
		};
	}

	public static string GetInlineIconDirPath(EGSInputIconType InputIconType)
	{
		return InputIconType switch
		{
			EGSInputIconType.KeyboardMouse => "/Game/00MainHZ/UI/AlwaysCook/RichTextIcon/KeyBoard", 
			EGSInputIconType.XSX => "/Game/00MainHZ/UI/AlwaysCook/RichTextIcon/GamePadXboxOne", 
			EGSInputIconType.PS5 => "/Game/00MainHZ/UI/AlwaysCook/RichTextIcon/GamePadPS5", 
			_ => null, 
		};
	}

	public static Type GetIconBgEnumType(EGSInputIconType InputIconType)
	{
		return InputIconType switch
		{
			EGSInputIconType.KeyboardMouse => typeof(EGSKeyboardBgType), 
			EGSInputIconType.XSX => typeof(EGSXboxOneBgType), 
			EGSInputIconType.PS5 => typeof(EGSPS5BgType), 
			_ => null, 
		};
	}

	public static EGSInputType GetInputType(EGSInputIconType InputIconType)
	{
		return InputIconType switch
		{
			EGSInputIconType.KeyboardMouse => EGSInputType.KeyboardMouse, 
			EGSInputIconType.XSX => EGSInputType.Gamepad, 
			EGSInputIconType.PS5 => EGSInputType.Gamepad, 
			_ => EGSInputType.None, 
		};
	}

	public static EGSInputIconType GetInputIconType(EGSInputType InputType)
	{
		if (InputType == EGSInputType.KeyboardMouse)
		{
			return EGSInputIconType.KeyboardMouse;
		}
		return FInputDeviceTracker.GamepadIconType;
	}

	public static int GetInteractIconSharpValue(EGSInputType InputType)
	{
		return GetInputIconType(InputType) switch
		{
			EGSInputIconType.KeyboardMouse => 0, 
			EGSInputIconType.XSX => 1, 
			EGSInputIconType.PS5 => 2, 
			_ => 0, 
		};
	}

	public static EGSInputIconType GetInputIconType(string KeyName)
	{
		if (!KeyName.Contains("Gamepad"))
		{
			return EGSInputIconType.KeyboardMouse;
		}
		return FInputDeviceTracker.GamepadIconType;
	}
}
