using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.SkeletalMeshActor", "Engine", UnrealModuleType.Engine)]
public class ASkeletalMeshActor : AActor
{
	private static bool ShouldDoAnimNotifies_IsValid;

	private static FFieldAddress ShouldDoAnimNotifies_PropertyAddress;

	private static int ShouldDoAnimNotifies_Offset;

	private static bool SkeletalMeshComponent_IsValid;

	private static int SkeletalMeshComponent_Offset;

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.SkeletalMeshActor:bShouldDoAnimNotifies")]
	public bool ShouldDoAnimNotifies
	{
		get
		{
			CheckDestroyed();
			if (!ShouldDoAnimNotifies_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMeshActor:bShouldDoAnimNotifies");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShouldDoAnimNotifies_Offset), 0, ShouldDoAnimNotifies_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShouldDoAnimNotifies_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMeshActor:bShouldDoAnimNotifies");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShouldDoAnimNotifies_Offset), 0, ShouldDoAnimNotifies_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.SkeletalMeshActor:SkeletalMeshComponent")]
	public USkeletalMeshComponent SkeletalMeshComponent
	{
		get
		{
			CheckDestroyed();
			if (!SkeletalMeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMeshActor:SkeletalMeshComponent");
				return null;
			}
			return UObjectMarshaler<USkeletalMeshComponent>.FromNative(IntPtr.Add(base.Address, SkeletalMeshComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkeletalMeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMeshActor:SkeletalMeshComponent");
			}
			else
			{
				UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(base.Address, SkeletalMeshComponent_Offset), value);
			}
		}
	}

	static ASkeletalMeshActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ASkeletalMeshActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ASkeletalMeshActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.SkeletalMeshActor");
		NativeReflectionCached.GetPropertyRef(ref ShouldDoAnimNotifies_PropertyAddress, unrealStruct, "bShouldDoAnimNotifies");
		ShouldDoAnimNotifies_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bShouldDoAnimNotifies");
		ShouldDoAnimNotifies_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bShouldDoAnimNotifies", Classes.FBoolProperty);
		SkeletalMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SkeletalMeshComponent");
		SkeletalMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SkeletalMeshComponent", Classes.FObjectProperty);
	}
}
