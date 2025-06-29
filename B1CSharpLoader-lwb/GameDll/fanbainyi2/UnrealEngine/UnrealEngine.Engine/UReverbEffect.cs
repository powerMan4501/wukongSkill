using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.ReverbEffect", "Engine", UnrealModuleType.Engine)]
public class UReverbEffect : UObject
{
	private static bool BypassEarlyReflections_IsValid;

	private static FFieldAddress BypassEarlyReflections_PropertyAddress;

	private static int BypassEarlyReflections_Offset;

	private static bool BypassLateReflections_IsValid;

	private static FFieldAddress BypassLateReflections_PropertyAddress;

	private static int BypassLateReflections_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ReverbEffect:bBypassEarlyReflections")]
	public bool BypassEarlyReflections
	{
		get
		{
			CheckDestroyed();
			if (!BypassEarlyReflections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReverbEffect:bBypassEarlyReflections");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BypassEarlyReflections_Offset), 0, BypassEarlyReflections_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BypassEarlyReflections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReverbEffect:bBypassEarlyReflections");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BypassEarlyReflections_Offset), 0, BypassEarlyReflections_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ReverbEffect:bBypassLateReflections")]
	public bool BypassLateReflections
	{
		get
		{
			CheckDestroyed();
			if (!BypassLateReflections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReverbEffect:bBypassLateReflections");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BypassLateReflections_Offset), 0, BypassLateReflections_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BypassLateReflections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReverbEffect:bBypassLateReflections");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BypassLateReflections_Offset), 0, BypassLateReflections_PropertyAddress.Address, value);
			}
		}
	}

	static UReverbEffect()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UReverbEffect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UReverbEffect));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.ReverbEffect");
		NativeReflectionCached.GetPropertyRef(ref BypassEarlyReflections_PropertyAddress, unrealStruct, "bBypassEarlyReflections");
		BypassEarlyReflections_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bBypassEarlyReflections");
		BypassEarlyReflections_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bBypassEarlyReflections", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BypassLateReflections_PropertyAddress, unrealStruct, "bBypassLateReflections");
		BypassLateReflections_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bBypassLateReflections");
		BypassLateReflections_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bBypassLateReflections", Classes.FBoolProperty);
	}
}
