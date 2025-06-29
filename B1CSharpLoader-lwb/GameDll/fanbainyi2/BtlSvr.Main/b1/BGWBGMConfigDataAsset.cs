using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWBGMConfigDataAsset")]
public class BGWBGMConfigDataAsset : UBGWDataAsset
{
	private static bool DefaultWanderBGMList_IsValid;

	private static int DefaultWanderBGMList_Offset;

	private static FFieldAddress DefaultWanderBGMList_PropertyAddress;

	private TArrayReadWriteMarshaler<FSingleBGMConfig> DefaultWanderBGMList_Marshaler;

	private static bool DefaultMonsterBattleBGMList_IsValid;

	private static int DefaultMonsterBattleBGMList_Offset;

	private static FFieldAddress DefaultMonsterBattleBGMList_PropertyAddress;

	private TArrayReadWriteMarshaler<FSingleBattleBGMConfig> DefaultMonsterBattleBGMList_Marshaler;

	private static bool DefaultEliteBattleBGMList_IsValid;

	private static int DefaultEliteBattleBGMList_Offset;

	private static FFieldAddress DefaultEliteBattleBGMList_PropertyAddress;

	private TArrayReadWriteMarshaler<FSingleBattleBGMConfig> DefaultEliteBattleBGMList_Marshaler;

	private static bool DefaultBossBattleBGMList_IsValid;

	private static int DefaultBossBattleBGMList_Offset;

	private static FFieldAddress DefaultBossBattleBGMList_PropertyAddress;

	private TArrayReadWriteMarshaler<FSingleBattleBGMConfig> DefaultBossBattleBGMList_Marshaler;

	private static bool DefaultSequenceStopBGMEvent_IsValid;

	private static int DefaultSequenceStopBGMEvent_Offset;

	private static bool DefaultShrineBGM_IsValid;

	private static int DefaultShrineBGM_Offset;

	private static bool DefaultRoleBGM_IsValid;

	private static int DefaultRoleBGM_Offset;

	private static bool DisabledBGMTypes_IsValid;

	private static int DisabledBGMTypes_Offset;

	private static FFieldAddress DisabledBGMTypes_PropertyAddress;

	private TArrayReadWriteMarshaler<EBGMDisableType> DisabledBGMTypes_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("DefaultWanderBGM")]
	[DisplayName("默认非战斗BGM")]
	[Tooltip("随机选取")]
	[USharpPath("/Script/b1-Managed.BGWBGMConfigDataAsset:DefaultWanderBGMList")]
	public TArrayReadWrite<FSingleBGMConfig> DefaultWanderBGMList
	{
		get
		{
			CheckDestroyed();
			if (!DefaultWanderBGMList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBGMConfigDataAsset:DefaultWanderBGMList");
				return null;
			}
			if (DefaultWanderBGMList_Marshaler == null)
			{
				DefaultWanderBGMList_Marshaler = new TArrayReadWriteMarshaler<FSingleBGMConfig>(1, DefaultWanderBGMList_PropertyAddress, CachedMarshalingDelegates<FSingleBGMConfig, FSingleBGMConfig>.FromNative, CachedMarshalingDelegates<FSingleBGMConfig, FSingleBGMConfig>.ToNative);
			}
			return DefaultWanderBGMList_Marshaler.FromNative(IntPtr.Add(base.Address, DefaultWanderBGMList_Offset));
		}
	}

	[Tooltip("随机选取")]
	[BlueprintReadWrite]
	[Category("DefaultWanderBGM")]
	[EditAnywhere]
	[DisplayName("默认小怪战斗BGM")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWBGMConfigDataAsset:DefaultMonsterBattleBGMList")]
	public TArrayReadWrite<FSingleBattleBGMConfig> DefaultMonsterBattleBGMList
	{
		get
		{
			CheckDestroyed();
			if (!DefaultMonsterBattleBGMList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBGMConfigDataAsset:DefaultMonsterBattleBGMList");
				return null;
			}
			if (DefaultMonsterBattleBGMList_Marshaler == null)
			{
				DefaultMonsterBattleBGMList_Marshaler = new TArrayReadWriteMarshaler<FSingleBattleBGMConfig>(1, DefaultMonsterBattleBGMList_PropertyAddress, CachedMarshalingDelegates<FSingleBattleBGMConfig, FSingleBattleBGMConfig>.FromNative, CachedMarshalingDelegates<FSingleBattleBGMConfig, FSingleBattleBGMConfig>.ToNative);
			}
			return DefaultMonsterBattleBGMList_Marshaler.FromNative(IntPtr.Add(base.Address, DefaultMonsterBattleBGMList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("DefaultWanderBGM")]
	[DisplayName("默认精英战斗BGM")]
	[Tooltip("随机选取")]
	[USharpPath("/Script/b1-Managed.BGWBGMConfigDataAsset:DefaultEliteBattleBGMList")]
	public TArrayReadWrite<FSingleBattleBGMConfig> DefaultEliteBattleBGMList
	{
		get
		{
			CheckDestroyed();
			if (!DefaultEliteBattleBGMList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBGMConfigDataAsset:DefaultEliteBattleBGMList");
				return null;
			}
			if (DefaultEliteBattleBGMList_Marshaler == null)
			{
				DefaultEliteBattleBGMList_Marshaler = new TArrayReadWriteMarshaler<FSingleBattleBGMConfig>(1, DefaultEliteBattleBGMList_PropertyAddress, CachedMarshalingDelegates<FSingleBattleBGMConfig, FSingleBattleBGMConfig>.FromNative, CachedMarshalingDelegates<FSingleBattleBGMConfig, FSingleBattleBGMConfig>.ToNative);
			}
			return DefaultEliteBattleBGMList_Marshaler.FromNative(IntPtr.Add(base.Address, DefaultEliteBattleBGMList_Offset));
		}
	}

	[Tooltip("随机选取")]
	[Category("DefaultWanderBGM")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("默认Boss战斗BGM")]
	[USharpPath("/Script/b1-Managed.BGWBGMConfigDataAsset:DefaultBossBattleBGMList")]
	public TArrayReadWrite<FSingleBattleBGMConfig> DefaultBossBattleBGMList
	{
		get
		{
			CheckDestroyed();
			if (!DefaultBossBattleBGMList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBGMConfigDataAsset:DefaultBossBattleBGMList");
				return null;
			}
			if (DefaultBossBattleBGMList_Marshaler == null)
			{
				DefaultBossBattleBGMList_Marshaler = new TArrayReadWriteMarshaler<FSingleBattleBGMConfig>(1, DefaultBossBattleBGMList_PropertyAddress, CachedMarshalingDelegates<FSingleBattleBGMConfig, FSingleBattleBGMConfig>.FromNative, CachedMarshalingDelegates<FSingleBattleBGMConfig, FSingleBattleBGMConfig>.ToNative);
			}
			return DefaultBossBattleBGMList_Marshaler.FromNative(IntPtr.Add(base.Address, DefaultBossBattleBGMList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("DefaultWanderBGM")]
	[DisplayName("默认进入Sequence关闭BGM事件")]
	[USharpPath("/Script/b1-Managed.BGWBGMConfigDataAsset:DefaultSequenceStopBGMEvent")]
	public UAkAudioEvent DefaultSequenceStopBGMEvent
	{
		get
		{
			CheckDestroyed();
			if (!DefaultSequenceStopBGMEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBGMConfigDataAsset:DefaultSequenceStopBGMEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, DefaultSequenceStopBGMEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultSequenceStopBGMEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBGMConfigDataAsset:DefaultSequenceStopBGMEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, DefaultSequenceStopBGMEvent_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("DefaultWanderBGM")]
	[DisplayName("默认土地庙BGM")]
	[USharpPath("/Script/b1-Managed.BGWBGMConfigDataAsset:DefaultShrineBGM")]
	public FSingleBGMConfig DefaultShrineBGM
	{
		get
		{
			CheckDestroyed();
			if (!DefaultShrineBGM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBGMConfigDataAsset:DefaultShrineBGM");
				return default(FSingleBGMConfig);
			}
			return FSingleBGMConfig.FromNative(IntPtr.Add(base.Address, DefaultShrineBGM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultShrineBGM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBGMConfigDataAsset:DefaultShrineBGM");
			}
			else
			{
				FSingleBGMConfig.ToNative(IntPtr.Add(base.Address, DefaultShrineBGM_Offset), value);
			}
		}
	}

	[DisplayName("默认角色界面BGM")]
	[Category("DefaultWanderBGM")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWBGMConfigDataAsset:DefaultRoleBGM")]
	public FSingleBGMConfig DefaultRoleBGM
	{
		get
		{
			CheckDestroyed();
			if (!DefaultRoleBGM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBGMConfigDataAsset:DefaultRoleBGM");
				return default(FSingleBGMConfig);
			}
			return FSingleBGMConfig.FromNative(IntPtr.Add(base.Address, DefaultRoleBGM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultRoleBGM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBGMConfigDataAsset:DefaultRoleBGM");
			}
			else
			{
				FSingleBGMConfig.ToNative(IntPtr.Add(base.Address, DefaultRoleBGM_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("DefaultWanderBGM")]
	[DisplayName("屏蔽BGM类型")]
	[USharpPath("/Script/b1-Managed.BGWBGMConfigDataAsset:DisabledBGMTypes")]
	public TArrayReadWrite<EBGMDisableType> DisabledBGMTypes
	{
		get
		{
			CheckDestroyed();
			if (!DisabledBGMTypes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWBGMConfigDataAsset:DisabledBGMTypes");
				return null;
			}
			if (DisabledBGMTypes_Marshaler == null)
			{
				DisabledBGMTypes_Marshaler = new TArrayReadWriteMarshaler<EBGMDisableType>(1, DisabledBGMTypes_PropertyAddress, CachedMarshalingDelegates<EBGMDisableType, EnumMarshaler<EBGMDisableType>>.FromNative, CachedMarshalingDelegates<EBGMDisableType, EnumMarshaler<EBGMDisableType>>.ToNative);
			}
			return DisabledBGMTypes_Marshaler.FromNative(IntPtr.Add(base.Address, DisabledBGMTypes_Offset));
		}
	}

	public BGWBGMConfigInfo GetConfigInfo()
	{
		BGWBGMConfigInfo bGWBGMConfigInfo = new BGWBGMConfigInfo();
		foreach (FSingleBGMConfig defaultWanderBGM in DefaultWanderBGMList)
		{
			bGWBGMConfigInfo.DefaultWanderBGMList.Add(new BGWSingleBGMConfigInfo(defaultWanderBGM));
		}
		foreach (FSingleBattleBGMConfig defaultMonsterBattleBGM in DefaultMonsterBattleBGMList)
		{
			bGWBGMConfigInfo.DefaultMonsterBattleBGMList.Add(new BGWSingleBattleBGMConfigInfo(defaultMonsterBattleBGM));
		}
		foreach (FSingleBattleBGMConfig defaultEliteBattleBGM in DefaultEliteBattleBGMList)
		{
			bGWBGMConfigInfo.DefaultEliteBattleBGMList.Add(new BGWSingleBattleBGMConfigInfo(defaultEliteBattleBGM));
		}
		foreach (FSingleBattleBGMConfig defaultBossBattleBGM in DefaultBossBattleBGMList)
		{
			bGWBGMConfigInfo.DefaultBossBattleBGMList.Add(new BGWSingleBattleBGMConfigInfo(defaultBossBattleBGM));
		}
		bGWBGMConfigInfo.DefaultSequenceStopBGMEvent = DefaultSequenceStopBGMEvent;
		bGWBGMConfigInfo.DefaultShrineBGM = new BGWSingleBGMConfigInfo(DefaultShrineBGM);
		bGWBGMConfigInfo.DefaultRoleBGM = new BGWSingleBGMConfigInfo(DefaultRoleBGM);
		bGWBGMConfigInfo.DisabledBGMTypes = DisabledBGMTypes.ToList();
		return bGWBGMConfigInfo;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWBGMConfigDataAsset");
		NativeReflection.GetPropertyRef(ref DefaultWanderBGMList_PropertyAddress, unrealStruct, "DefaultWanderBGMList");
		DefaultWanderBGMList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DefaultWanderBGMList");
		DefaultWanderBGMList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DefaultWanderBGMList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref DefaultMonsterBattleBGMList_PropertyAddress, unrealStruct, "DefaultMonsterBattleBGMList");
		DefaultMonsterBattleBGMList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DefaultMonsterBattleBGMList");
		DefaultMonsterBattleBGMList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DefaultMonsterBattleBGMList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref DefaultEliteBattleBGMList_PropertyAddress, unrealStruct, "DefaultEliteBattleBGMList");
		DefaultEliteBattleBGMList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DefaultEliteBattleBGMList");
		DefaultEliteBattleBGMList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DefaultEliteBattleBGMList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref DefaultBossBattleBGMList_PropertyAddress, unrealStruct, "DefaultBossBattleBGMList");
		DefaultBossBattleBGMList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DefaultBossBattleBGMList");
		DefaultBossBattleBGMList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DefaultBossBattleBGMList", Classes.FArrayProperty);
		DefaultSequenceStopBGMEvent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DefaultSequenceStopBGMEvent");
		DefaultSequenceStopBGMEvent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DefaultSequenceStopBGMEvent", Classes.FObjectProperty);
		DefaultShrineBGM_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DefaultShrineBGM");
		DefaultShrineBGM_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DefaultShrineBGM", Classes.FStructProperty);
		DefaultRoleBGM_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DefaultRoleBGM");
		DefaultRoleBGM_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DefaultRoleBGM", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref DisabledBGMTypes_PropertyAddress, unrealStruct, "DisabledBGMTypes");
		DisabledBGMTypes_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DisabledBGMTypes");
		DisabledBGMTypes_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DisabledBGMTypes", Classes.FArrayProperty);
	}

	static BGWBGMConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWBGMConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWBGMConfigDataAsset));
	}
}
