using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.PainCausingVolume", "Engine", UnrealModuleType.Engine)]
public class APainCausingVolume : APhysicsVolume
{
	private static bool PainCausing_IsValid;

	private static FFieldAddress PainCausing_PropertyAddress;

	private static int PainCausing_Offset;

	private static bool DamagePerSec_IsValid;

	private static int DamagePerSec_Offset;

	private static bool DamageType_IsValid;

	private static int DamageType_Offset;

	private static bool PainInterval_IsValid;

	private static int PainInterval_Offset;

	private static bool EntryPain_IsValid;

	private static FFieldAddress EntryPain_PropertyAddress;

	private static int EntryPain_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PainCausingVolume:bPainCausing")]
	public bool PainCausing
	{
		get
		{
			CheckDestroyed();
			if (!PainCausing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PainCausingVolume:bPainCausing");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PainCausing_Offset), 0, PainCausing_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PainCausing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PainCausingVolume:bPainCausing");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PainCausing_Offset), 0, PainCausing_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PainCausingVolume:DamagePerSec")]
	public float DamagePerSec
	{
		get
		{
			CheckDestroyed();
			if (!DamagePerSec_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PainCausingVolume:DamagePerSec");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DamagePerSec_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DamagePerSec_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PainCausingVolume:DamagePerSec");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DamagePerSec_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.PainCausingVolume:DamageType")]
	public TSubclassOf<UDamageType> DamageType
	{
		get
		{
			CheckDestroyed();
			if (!DamageType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PainCausingVolume:DamageType");
				return default(TSubclassOf<UDamageType>);
			}
			return TSubclassOfMarshaler<UDamageType>.FromNative(IntPtr.Add(base.Address, DamageType_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DamageType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PainCausingVolume:DamageType");
			}
			else
			{
				TSubclassOfMarshaler<UDamageType>.ToNative(IntPtr.Add(base.Address, DamageType_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PainCausingVolume:PainInterval")]
	public float PainInterval
	{
		get
		{
			CheckDestroyed();
			if (!PainInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PainCausingVolume:PainInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PainInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PainInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PainCausingVolume:PainInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PainInterval_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PainCausingVolume:bEntryPain")]
	public bool EntryPain
	{
		get
		{
			CheckDestroyed();
			if (!EntryPain_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PainCausingVolume:bEntryPain");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EntryPain_Offset), 0, EntryPain_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EntryPain_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PainCausingVolume:bEntryPain");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EntryPain_Offset), 0, EntryPain_PropertyAddress.Address, value);
			}
		}
	}

	static APainCausingVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APainCausingVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APainCausingVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.PainCausingVolume");
		NativeReflectionCached.GetPropertyRef(ref PainCausing_PropertyAddress, unrealStruct, "bPainCausing");
		PainCausing_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bPainCausing");
		PainCausing_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bPainCausing", Classes.FBoolProperty);
		DamagePerSec_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DamagePerSec");
		DamagePerSec_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DamagePerSec", Classes.FFloatProperty);
		DamageType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DamageType");
		DamageType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DamageType", Classes.FClassProperty);
		PainInterval_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PainInterval");
		PainInterval_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PainInterval", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EntryPain_PropertyAddress, unrealStruct, "bEntryPain");
		EntryPain_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEntryPain");
		EntryPain_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEntryPain", Classes.FBoolProperty);
	}
}
