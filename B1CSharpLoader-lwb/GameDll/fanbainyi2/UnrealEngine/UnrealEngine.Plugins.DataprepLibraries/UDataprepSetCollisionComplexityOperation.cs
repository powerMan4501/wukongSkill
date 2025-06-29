using System;
using UnrealEngine.PhysicsCore;
using UnrealEngine.Plugins.DataprepCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepLibraries.DataprepSetCollisionComplexityOperation", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public class UDataprepSetCollisionComplexityOperation : UDataprepOperation
{
	private static bool CollisionTraceFlag_IsValid;

	private static FFieldAddress CollisionTraceFlag_PropertyAddress;

	private static int CollisionTraceFlag_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSetCollisionComplexityOperation:CollisionTraceFlag")]
	public ECollisionTraceFlag CollisionTraceFlag
	{
		get
		{
			CheckDestroyed();
			if (!CollisionTraceFlag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetCollisionComplexityOperation:CollisionTraceFlag");
				return ECollisionTraceFlag.CTF_UseDefault;
			}
			return EnumMarshaler<ECollisionTraceFlag>.FromNative(IntPtr.Add(base.Address, CollisionTraceFlag_Offset), 0, CollisionTraceFlag_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CollisionTraceFlag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetCollisionComplexityOperation:CollisionTraceFlag");
			}
			else
			{
				EnumMarshaler<ECollisionTraceFlag>.ToNative(IntPtr.Add(base.Address, CollisionTraceFlag_Offset), 0, CollisionTraceFlag_PropertyAddress.Address, value);
			}
		}
	}

	static UDataprepSetCollisionComplexityOperation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepSetCollisionComplexityOperation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepSetCollisionComplexityOperation));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/DataprepLibraries.DataprepSetCollisionComplexityOperation");
		NativeReflectionCached.GetPropertyRef(ref CollisionTraceFlag_PropertyAddress, unrealStruct, "CollisionTraceFlag");
		CollisionTraceFlag_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CollisionTraceFlag");
		CollisionTraceFlag_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CollisionTraceFlag", Classes.FByteProperty);
	}
}
