using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)818942113uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundBase", "Engine", UnrealModuleType.Engine)]
public class USoundBase : UObject, IInterface_AssetUserData, IInterface
{
	private static bool SoundClassObject_IsValid;

	private static int SoundClassObject_Offset;

	private static bool OverrideConcurrency_IsValid;

	private static FFieldAddress OverrideConcurrency_PropertyAddress;

	private static int OverrideConcurrency_Offset;

	private static bool EnableBusSends_IsValid;

	private static FFieldAddress EnableBusSends_PropertyAddress;

	private static int EnableBusSends_Offset;

	private static bool BypassVolumeScaleForPriority_IsValid;

	private static FFieldAddress BypassVolumeScaleForPriority_PropertyAddress;

	private static int BypassVolumeScaleForPriority_Offset;

	private static bool VirtualizationMode_IsValid;

	private static FFieldAddress VirtualizationMode_PropertyAddress;

	private static int VirtualizationMode_Offset;

	private static bool ConcurrencySet_IsValid;

	private static FFieldAddress ConcurrencySet_PropertyAddress;

	private static int ConcurrencySet_Offset;

	private TSetReadWriteMarshaler<USoundConcurrency> ConcurrencySet_MarshalerCached;

	private static bool ConcurrencyOverrides_IsValid;

	private static int ConcurrencyOverrides_Offset;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool MaxDistance_IsValid;

	private static int MaxDistance_Offset;

	private static bool TotalSamples_IsValid;

	private static int TotalSamples_Offset;

	private static bool Priority_IsValid;

	private static int Priority_Offset;

	private static bool SoundSubmixObject_IsValid;

	private static int SoundSubmixObject_Offset;

	private static bool SoundSubmixSends_IsValid;

	private static FFieldAddress SoundSubmixSends_PropertyAddress;

	private static int SoundSubmixSends_Offset;

	private TArrayReadWriteMarshaler<FSoundSubmixSendInfo> SoundSubmixSends_MarshalerCached;

	private static bool SourceEffectChain_IsValid;

	private static int SourceEffectChain_Offset;

	private static bool BusSends_IsValid;

	private static FFieldAddress BusSends_PropertyAddress;

	private static int BusSends_Offset;

	private TArrayReadWriteMarshaler<FSoundSourceBusSendInfo> BusSends_MarshalerCached;

	private static bool PreEffectBusSends_IsValid;

	private static FFieldAddress PreEffectBusSends_PropertyAddress;

	private static int PreEffectBusSends_Offset;

	private TArrayReadWriteMarshaler<FSoundSourceBusSendInfo> PreEffectBusSends_MarshalerCached;

	[UProperty(Flags = (PropFlags)7882468652745237uL)]
	[UMetaPath("/Script/Engine.SoundBase:SoundClassObject")]
	public USoundClass SoundClassObject
	{
		get
		{
			CheckDestroyed();
			if (!SoundClassObject_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:SoundClassObject");
				return null;
			}
			return UObjectMarshaler<USoundClass>.FromNative(IntPtr.Add(base.Address, SoundClassObject_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SoundClassObject_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:SoundClassObject");
			}
			else
			{
				UObjectMarshaler<USoundClass>.ToNative(IntPtr.Add(base.Address, SoundClassObject_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SoundBase:bOverrideConcurrency")]
	public bool OverrideConcurrency
	{
		get
		{
			CheckDestroyed();
			if (!OverrideConcurrency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:bOverrideConcurrency");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideConcurrency_Offset), 0, OverrideConcurrency_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideConcurrency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:bOverrideConcurrency");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideConcurrency_Offset), 0, OverrideConcurrency_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SoundBase:bEnableBusSends")]
	public bool EnableBusSends
	{
		get
		{
			CheckDestroyed();
			if (!EnableBusSends_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:bEnableBusSends");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableBusSends_Offset), 0, EnableBusSends_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableBusSends_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:bEnableBusSends");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableBusSends_Offset), 0, EnableBusSends_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SoundBase:bBypassVolumeScaleForPriority")]
	public bool BypassVolumeScaleForPriority
	{
		get
		{
			CheckDestroyed();
			if (!BypassVolumeScaleForPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:bBypassVolumeScaleForPriority");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BypassVolumeScaleForPriority_Offset), 0, BypassVolumeScaleForPriority_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BypassVolumeScaleForPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:bBypassVolumeScaleForPriority");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BypassVolumeScaleForPriority_Offset), 0, BypassVolumeScaleForPriority_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundBase:VirtualizationMode")]
	public EVirtualizationMode VirtualizationMode
	{
		get
		{
			CheckDestroyed();
			if (!VirtualizationMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:VirtualizationMode");
				return EVirtualizationMode.Disabled;
			}
			return EnumMarshaler<EVirtualizationMode>.FromNative(IntPtr.Add(base.Address, VirtualizationMode_Offset), 0, VirtualizationMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VirtualizationMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:VirtualizationMode");
			}
			else
			{
				EnumMarshaler<EVirtualizationMode>.ToNative(IntPtr.Add(base.Address, VirtualizationMode_Offset), 0, VirtualizationMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5629499534213125uL)]
	[UMetaPath("/Script/Engine.SoundBase:ConcurrencySet")]
	public TSetReadWrite<USoundConcurrency> ConcurrencySet
	{
		get
		{
			CheckDestroyed();
			if (!ConcurrencySet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:ConcurrencySet");
				return null;
			}
			if (ConcurrencySet_MarshalerCached == null)
			{
				ConcurrencySet_MarshalerCached = new TSetReadWriteMarshaler<USoundConcurrency>(1, ConcurrencySet_PropertyAddress, CachedMarshalingDelegates<USoundConcurrency, UObjectMarshaler<USoundConcurrency>>.FromNative, CachedMarshalingDelegates<USoundConcurrency, UObjectMarshaler<USoundConcurrency>>.ToNative);
			}
			return ConcurrencySet_MarshalerCached.FromNative(IntPtr.Add(base.Address, ConcurrencySet_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.SoundBase:ConcurrencyOverrides")]
	public FSoundConcurrencySettings ConcurrencyOverrides
	{
		get
		{
			CheckDestroyed();
			if (!ConcurrencyOverrides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:ConcurrencyOverrides");
				return default(FSoundConcurrencySettings);
			}
			return FSoundConcurrencySettings.FromNative(IntPtr.Add(base.Address, ConcurrencyOverrides_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConcurrencyOverrides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:ConcurrencyOverrides");
			}
			else
			{
				FSoundConcurrencySettings.ToNative(IntPtr.Add(base.Address, ConcurrencyOverrides_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756568746033685uL)]
	[UMetaPath("/Script/Engine.SoundBase:Duration")]
	public float Duration
	{
		get
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Duration_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756568746033685uL)]
	[UMetaPath("/Script/Engine.SoundBase:MaxDistance")]
	public float MaxDistance
	{
		get
		{
			CheckDestroyed();
			if (!MaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:MaxDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:MaxDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756568746033685uL)]
	[UMetaPath("/Script/Engine.SoundBase:TotalSamples")]
	public float TotalSamples
	{
		get
		{
			CheckDestroyed();
			if (!TotalSamples_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:TotalSamples");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TotalSamples_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TotalSamples_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:TotalSamples");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TotalSamples_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundBase:Priority")]
	public float Priority
	{
		get
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:Priority");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Priority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:Priority");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Priority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.SoundBase:SoundSubmixObject")]
	public USoundSubmixBase SoundSubmixObject
	{
		get
		{
			CheckDestroyed();
			if (!SoundSubmixObject_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:SoundSubmixObject");
				return null;
			}
			return UObjectMarshaler<USoundSubmixBase>.FromNative(IntPtr.Add(base.Address, SoundSubmixObject_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SoundSubmixObject_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:SoundSubmixObject");
			}
			else
			{
				UObjectMarshaler<USoundSubmixBase>.ToNative(IntPtr.Add(base.Address, SoundSubmixObject_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.SoundBase:SoundSubmixSends")]
	public TArrayReadWrite<FSoundSubmixSendInfo> SoundSubmixSends
	{
		get
		{
			CheckDestroyed();
			if (!SoundSubmixSends_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:SoundSubmixSends");
				return null;
			}
			if (SoundSubmixSends_MarshalerCached == null)
			{
				SoundSubmixSends_MarshalerCached = new TArrayReadWriteMarshaler<FSoundSubmixSendInfo>(1, SoundSubmixSends_PropertyAddress, CachedMarshalingDelegates<FSoundSubmixSendInfo, FSoundSubmixSendInfo>.FromNative, CachedMarshalingDelegates<FSoundSubmixSendInfo, FSoundSubmixSendInfo>.ToNative);
			}
			return SoundSubmixSends_MarshalerCached.FromNative(IntPtr.Add(base.Address, SoundSubmixSends_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.SoundBase:SourceEffectChain")]
	public USoundEffectSourcePresetChain SourceEffectChain
	{
		get
		{
			CheckDestroyed();
			if (!SourceEffectChain_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:SourceEffectChain");
				return null;
			}
			return UObjectMarshaler<USoundEffectSourcePresetChain>.FromNative(IntPtr.Add(base.Address, SourceEffectChain_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SourceEffectChain_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:SourceEffectChain");
			}
			else
			{
				UObjectMarshaler<USoundEffectSourcePresetChain>.ToNative(IntPtr.Add(base.Address, SourceEffectChain_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.SoundBase:BusSends")]
	public TArrayReadWrite<FSoundSourceBusSendInfo> BusSends
	{
		get
		{
			CheckDestroyed();
			if (!BusSends_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:BusSends");
				return null;
			}
			if (BusSends_MarshalerCached == null)
			{
				BusSends_MarshalerCached = new TArrayReadWriteMarshaler<FSoundSourceBusSendInfo>(1, BusSends_PropertyAddress, CachedMarshalingDelegates<FSoundSourceBusSendInfo, FSoundSourceBusSendInfo>.FromNative, CachedMarshalingDelegates<FSoundSourceBusSendInfo, FSoundSourceBusSendInfo>.ToNative);
			}
			return BusSends_MarshalerCached.FromNative(IntPtr.Add(base.Address, BusSends_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.SoundBase:PreEffectBusSends")]
	public TArrayReadWrite<FSoundSourceBusSendInfo> PreEffectBusSends
	{
		get
		{
			CheckDestroyed();
			if (!PreEffectBusSends_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundBase:PreEffectBusSends");
				return null;
			}
			if (PreEffectBusSends_MarshalerCached == null)
			{
				PreEffectBusSends_MarshalerCached = new TArrayReadWriteMarshaler<FSoundSourceBusSendInfo>(1, PreEffectBusSends_PropertyAddress, CachedMarshalingDelegates<FSoundSourceBusSendInfo, FSoundSourceBusSendInfo>.FromNative, CachedMarshalingDelegates<FSoundSourceBusSendInfo, FSoundSourceBusSendInfo>.ToNative);
			}
			return PreEffectBusSends_MarshalerCached.FromNative(IntPtr.Add(base.Address, PreEffectBusSends_Offset));
		}
	}

	static USoundBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USoundBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USoundBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.SoundBase");
		SoundClassObject_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SoundClassObject");
		SoundClassObject_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SoundClassObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideConcurrency_PropertyAddress, unrealStruct, "bOverrideConcurrency");
		OverrideConcurrency_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bOverrideConcurrency");
		OverrideConcurrency_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bOverrideConcurrency", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableBusSends_PropertyAddress, unrealStruct, "bEnableBusSends");
		EnableBusSends_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEnableBusSends");
		EnableBusSends_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEnableBusSends", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BypassVolumeScaleForPriority_PropertyAddress, unrealStruct, "bBypassVolumeScaleForPriority");
		BypassVolumeScaleForPriority_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bBypassVolumeScaleForPriority");
		BypassVolumeScaleForPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bBypassVolumeScaleForPriority", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref VirtualizationMode_PropertyAddress, unrealStruct, "VirtualizationMode");
		VirtualizationMode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VirtualizationMode");
		VirtualizationMode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VirtualizationMode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ConcurrencySet_PropertyAddress, unrealStruct, "ConcurrencySet");
		ConcurrencySet_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ConcurrencySet");
		ConcurrencySet_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ConcurrencySet", Classes.FSetProperty);
		ConcurrencyOverrides_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ConcurrencyOverrides");
		ConcurrencyOverrides_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ConcurrencyOverrides", Classes.FStructProperty);
		Duration_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Duration");
		Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Duration", Classes.FFloatProperty);
		MaxDistance_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaxDistance");
		MaxDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaxDistance", Classes.FFloatProperty);
		TotalSamples_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TotalSamples");
		TotalSamples_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TotalSamples", Classes.FFloatProperty);
		Priority_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Priority");
		Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Priority", Classes.FFloatProperty);
		SoundSubmixObject_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SoundSubmixObject");
		SoundSubmixObject_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SoundSubmixObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SoundSubmixSends_PropertyAddress, unrealStruct, "SoundSubmixSends");
		SoundSubmixSends_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SoundSubmixSends");
		SoundSubmixSends_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SoundSubmixSends", Classes.FArrayProperty);
		SourceEffectChain_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SourceEffectChain");
		SourceEffectChain_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SourceEffectChain", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BusSends_PropertyAddress, unrealStruct, "BusSends");
		BusSends_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BusSends");
		BusSends_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BusSends", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref PreEffectBusSends_PropertyAddress, unrealStruct, "PreEffectBusSends");
		PreEffectBusSends_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PreEffectBusSends");
		PreEffectBusSends_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PreEffectBusSends", Classes.FArrayProperty);
	}
}
