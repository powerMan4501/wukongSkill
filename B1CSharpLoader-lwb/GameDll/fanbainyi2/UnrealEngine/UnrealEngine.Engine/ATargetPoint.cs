using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.TargetPoint", "Engine", UnrealModuleType.Engine)]
public class ATargetPoint : AActor
{
	private static bool SpriteComponent_IsValid;

	private static int SpriteComponent_Offset;

	private static bool ArrowComponent_IsValid;

	private static int ArrowComponent_Offset;

	[UProperty(Flags = (PropFlags)21392202383622685uL)]
	[UMetaPath("/Script/Engine.TargetPoint:SpriteComponent")]
	public UBillboardComponent SpriteComponent
	{
		get
		{
			CheckDestroyed();
			if (!SpriteComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TargetPoint:SpriteComponent");
				return null;
			}
			return UObjectMarshaler<UBillboardComponent>.FromNative(IntPtr.Add(base.Address, SpriteComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpriteComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TargetPoint:SpriteComponent");
			}
			else
			{
				UObjectMarshaler<UBillboardComponent>.ToNative(IntPtr.Add(base.Address, SpriteComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)21392202383622685uL)]
	[UMetaPath("/Script/Engine.TargetPoint:ArrowComponent")]
	public UArrowComponent ArrowComponent
	{
		get
		{
			CheckDestroyed();
			if (!ArrowComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TargetPoint:ArrowComponent");
				return null;
			}
			return UObjectMarshaler<UArrowComponent>.FromNative(IntPtr.Add(base.Address, ArrowComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ArrowComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TargetPoint:ArrowComponent");
			}
			else
			{
				UObjectMarshaler<UArrowComponent>.ToNative(IntPtr.Add(base.Address, ArrowComponent_Offset), value);
			}
		}
	}

	static ATargetPoint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ATargetPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ATargetPoint));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.TargetPoint");
		SpriteComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SpriteComponent");
		SpriteComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SpriteComponent", Classes.FObjectProperty);
		ArrowComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ArrowComponent");
		ArrowComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ArrowComponent", Classes.FObjectProperty);
	}
}
