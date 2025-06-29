using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSGameSettings;

[UClass(Flags = (ClassFlags)1892679844uL, Config = "GameUserSettings")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GSGameSettings.GSGameUserSettings", "GSGameSettings", UnrealModuleType.GamePlugin)]
public class UGSGameUserSettings : UGameUserSettings
{
	private static bool EnableStartupSettings_IsValid;

	private static FFieldAddress EnableStartupSettings_PropertyAddress;

	private static int EnableStartupSettings_Offset;

	private static bool StartLevelName_IsValid;

	private static int StartLevelName_Offset;

	private static bool StartCommandList_IsValid;

	private static FFieldAddress StartCommandList_PropertyAddress;

	private static int StartCommandList_Offset;

	private TArrayReadWriteMarshaler<string> StartCommandList_MarshalerCached;

	private static bool GMCommandList_IsValid;

	private static FFieldAddress GMCommandList_PropertyAddress;

	private static int GMCommandList_Offset;

	private TMapReadWriteMarshaler<byte, string> GMCommandList_MarshalerCached;

	private static bool NeverShowStartupUI_IsValid;

	private static FFieldAddress NeverShowStartupUI_PropertyAddress;

	private static int NeverShowStartupUI_Offset;

	private static bool MainMonitorID_IsValid;

	private static int MainMonitorID_Offset;

	private static bool UISettingData_IsValid;

	private static FFieldAddress UISettingData_PropertyAddress;

	private static int UISettingData_Offset;

	private TMapReadWriteMarshaler<string, string> UISettingData_MarshalerCached;

	private static bool UISettingCustomData_IsValid;

	private static FFieldAddress UISettingCustomData_PropertyAddress;

	private static int UISettingCustomData_Offset;

	private TMapReadWriteMarshaler<string, string> UISettingCustomData_MarshalerCached;

	private static bool SettingpbTag_IsValid;

	private static int SettingpbTag_Offset;

	private static bool PrivacyAgreement_IsValid;

	private static int PrivacyAgreement_Offset;

	private static bool AgreementReaded_IsValid;

	private static int AgreementReaded_Offset;

	private static bool FirstSettingFinish_IsValid;

	private static FFieldAddress FirstSettingFinish_PropertyAddress;

	private static int FirstSettingFinish_Offset;

	private static bool ArchiveMarkFinish_IsValid;

	private static FFieldAddress ArchiveMarkFinish_PropertyAddress;

	private static int ArchiveMarkFinish_Offset;

	private static bool CrashReportAgreement_IsValid;

	private static int CrashReportAgreement_Offset;

	private static bool ShowCrashReportUI_IsValid;

	private static int ShowCrashReportUI_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GSGameSettings.GSGameUserSettings:bEnableStartupSettings")]
	public bool EnableStartupSettings
	{
		get
		{
			CheckDestroyed();
			if (!EnableStartupSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:bEnableStartupSettings");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableStartupSettings_Offset), 0, EnableStartupSettings_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableStartupSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:bEnableStartupSettings");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableStartupSettings_Offset), 0, EnableStartupSettings_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072644uL)]
	[UMetaPath("/Script/GSGameSettings.GSGameUserSettings:StartLevelName")]
	public string StartLevelName
	{
		get
		{
			CheckDestroyed();
			if (!StartLevelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:StartLevelName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, StartLevelName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartLevelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:StartLevelName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, StartLevelName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627387396uL)]
	[UMetaPath("/Script/GSGameSettings.GSGameUserSettings:StartCommandList")]
	public TArrayReadWrite<string> StartCommandList
	{
		get
		{
			CheckDestroyed();
			if (!StartCommandList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:StartCommandList");
				return null;
			}
			if (StartCommandList_MarshalerCached == null)
			{
				StartCommandList_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, StartCommandList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return StartCommandList_MarshalerCached.FromNative(IntPtr.Add(base.Address, StartCommandList_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627386884uL)]
	[UMetaPath("/Script/GSGameSettings.GSGameUserSettings:GMCommandList")]
	public TMapReadWrite<byte, string> GMCommandList
	{
		get
		{
			CheckDestroyed();
			if (!GMCommandList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:GMCommandList");
				return null;
			}
			if (GMCommandList_MarshalerCached == null)
			{
				GMCommandList_MarshalerCached = new TMapReadWriteMarshaler<byte, string>(1, GMCommandList_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return GMCommandList_MarshalerCached.FromNative(IntPtr.Add(base.Address, GMCommandList_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291204uL)]
	[UMetaPath("/Script/GSGameSettings.GSGameUserSettings:bNeverShowStartupUI")]
	public bool NeverShowStartupUI
	{
		get
		{
			CheckDestroyed();
			if (!NeverShowStartupUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:bNeverShowStartupUI");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeverShowStartupUI_Offset), 0, NeverShowStartupUI_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeverShowStartupUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:bNeverShowStartupUI");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeverShowStartupUI_Offset), 0, NeverShowStartupUI_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072644uL)]
	[UMetaPath("/Script/GSGameSettings.GSGameUserSettings:MainMonitorID")]
	public string MainMonitorID
	{
		get
		{
			CheckDestroyed();
			if (!MainMonitorID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:MainMonitorID");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, MainMonitorID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MainMonitorID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:MainMonitorID");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, MainMonitorID_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627386884uL)]
	[UMetaPath("/Script/GSGameSettings.GSGameUserSettings:UISettingData")]
	public TMapReadWrite<string, string> UISettingData
	{
		get
		{
			CheckDestroyed();
			if (!UISettingData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:UISettingData");
				return null;
			}
			if (UISettingData_MarshalerCached == null)
			{
				UISettingData_MarshalerCached = new TMapReadWriteMarshaler<string, string>(1, UISettingData_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return UISettingData_MarshalerCached.FromNative(IntPtr.Add(base.Address, UISettingData_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627386884uL)]
	[UMetaPath("/Script/GSGameSettings.GSGameUserSettings:UISettingCustomData")]
	public TMapReadWrite<string, string> UISettingCustomData
	{
		get
		{
			CheckDestroyed();
			if (!UISettingCustomData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:UISettingCustomData");
				return null;
			}
			if (UISettingCustomData_MarshalerCached == null)
			{
				UISettingCustomData_MarshalerCached = new TMapReadWriteMarshaler<string, string>(1, UISettingCustomData_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return UISettingCustomData_MarshalerCached.FromNative(IntPtr.Add(base.Address, UISettingCustomData_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291204uL)]
	[UMetaPath("/Script/GSGameSettings.GSGameUserSettings:SettingpbTag")]
	public int SettingpbTag
	{
		get
		{
			CheckDestroyed();
			if (!SettingpbTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:SettingpbTag");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SettingpbTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SettingpbTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:SettingpbTag");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SettingpbTag_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291204uL)]
	[UMetaPath("/Script/GSGameSettings.GSGameUserSettings:PrivacyAgreement")]
	public int PrivacyAgreement
	{
		get
		{
			CheckDestroyed();
			if (!PrivacyAgreement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:PrivacyAgreement");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PrivacyAgreement_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PrivacyAgreement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:PrivacyAgreement");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PrivacyAgreement_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291204uL)]
	[UMetaPath("/Script/GSGameSettings.GSGameUserSettings:AgreementReaded")]
	public int AgreementReaded
	{
		get
		{
			CheckDestroyed();
			if (!AgreementReaded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:AgreementReaded");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AgreementReaded_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AgreementReaded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:AgreementReaded");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AgreementReaded_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291204uL)]
	[UMetaPath("/Script/GSGameSettings.GSGameUserSettings:FirstSettingFinish")]
	public bool FirstSettingFinish
	{
		get
		{
			CheckDestroyed();
			if (!FirstSettingFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:FirstSettingFinish");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, FirstSettingFinish_Offset), 0, FirstSettingFinish_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FirstSettingFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:FirstSettingFinish");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, FirstSettingFinish_Offset), 0, FirstSettingFinish_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291204uL)]
	[UMetaPath("/Script/GSGameSettings.GSGameUserSettings:ArchiveMarkFinish")]
	public bool ArchiveMarkFinish
	{
		get
		{
			CheckDestroyed();
			if (!ArchiveMarkFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:ArchiveMarkFinish");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ArchiveMarkFinish_Offset), 0, ArchiveMarkFinish_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ArchiveMarkFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:ArchiveMarkFinish");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ArchiveMarkFinish_Offset), 0, ArchiveMarkFinish_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291204uL)]
	[UMetaPath("/Script/GSGameSettings.GSGameUserSettings:CrashReportAgreement")]
	public int CrashReportAgreement
	{
		get
		{
			CheckDestroyed();
			if (!CrashReportAgreement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:CrashReportAgreement");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CrashReportAgreement_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CrashReportAgreement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:CrashReportAgreement");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CrashReportAgreement_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291204uL)]
	[UMetaPath("/Script/GSGameSettings.GSGameUserSettings:ShowCrashReportUI")]
	public int ShowCrashReportUI
	{
		get
		{
			CheckDestroyed();
			if (!ShowCrashReportUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:ShowCrashReportUI");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ShowCrashReportUI_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShowCrashReportUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSGameSettings.GSGameUserSettings:ShowCrashReportUI");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ShowCrashReportUI_Offset), value);
			}
		}
	}

	static UGSGameUserSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSGameUserSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSGameUserSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/GSGameSettings.GSGameUserSettings");
		NativeReflectionCached.GetPropertyRef(ref EnableStartupSettings_PropertyAddress, unrealStruct, "bEnableStartupSettings");
		EnableStartupSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEnableStartupSettings");
		EnableStartupSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEnableStartupSettings", Classes.FBoolProperty);
		StartLevelName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StartLevelName");
		StartLevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StartLevelName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref StartCommandList_PropertyAddress, unrealStruct, "StartCommandList");
		StartCommandList_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StartCommandList");
		StartCommandList_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StartCommandList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GMCommandList_PropertyAddress, unrealStruct, "GMCommandList");
		GMCommandList_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GMCommandList");
		GMCommandList_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GMCommandList", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref NeverShowStartupUI_PropertyAddress, unrealStruct, "bNeverShowStartupUI");
		NeverShowStartupUI_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bNeverShowStartupUI");
		NeverShowStartupUI_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bNeverShowStartupUI", Classes.FBoolProperty);
		MainMonitorID_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MainMonitorID");
		MainMonitorID_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MainMonitorID", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref UISettingData_PropertyAddress, unrealStruct, "UISettingData");
		UISettingData_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "UISettingData");
		UISettingData_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "UISettingData", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref UISettingCustomData_PropertyAddress, unrealStruct, "UISettingCustomData");
		UISettingCustomData_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "UISettingCustomData");
		UISettingCustomData_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "UISettingCustomData", Classes.FMapProperty);
		SettingpbTag_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SettingpbTag");
		SettingpbTag_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SettingpbTag", Classes.FIntProperty);
		PrivacyAgreement_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PrivacyAgreement");
		PrivacyAgreement_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PrivacyAgreement", Classes.FIntProperty);
		AgreementReaded_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AgreementReaded");
		AgreementReaded_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AgreementReaded", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref FirstSettingFinish_PropertyAddress, unrealStruct, "FirstSettingFinish");
		FirstSettingFinish_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FirstSettingFinish");
		FirstSettingFinish_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FirstSettingFinish", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ArchiveMarkFinish_PropertyAddress, unrealStruct, "ArchiveMarkFinish");
		ArchiveMarkFinish_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ArchiveMarkFinish");
		ArchiveMarkFinish_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ArchiveMarkFinish", Classes.FBoolProperty);
		CrashReportAgreement_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CrashReportAgreement");
		CrashReportAgreement_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CrashReportAgreement", Classes.FIntProperty);
		ShowCrashReportUI_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ShowCrashReportUI");
		ShowCrashReportUI_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ShowCrashReportUI", Classes.FIntProperty);
	}
}
