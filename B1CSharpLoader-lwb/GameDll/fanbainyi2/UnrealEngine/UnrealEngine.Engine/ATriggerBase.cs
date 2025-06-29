using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)818413733uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.TriggerBase", "Engine", UnrealModuleType.Engine)]
public class ATriggerBase : AActor
{
	private static bool CollisionComponent_IsValid;

	private static int CollisionComponent_Offset;

	private static bool SpriteComponent_IsValid;

	private static int SpriteComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.TriggerBase:CollisionComponent")]
	public UShapeComponent CollisionComponent
	{
		get
		{
			CheckDestroyed();
			if (!CollisionComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TriggerBase:CollisionComponent");
				return null;
			}
			return UObjectMarshaler<UShapeComponent>.FromNative(IntPtr.Add(base.Address, CollisionComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollisionComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TriggerBase:CollisionComponent");
			}
			else
			{
				UObjectMarshaler<UShapeComponent>.ToNative(IntPtr.Add(base.Address, CollisionComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)21392202383491612uL)]
	[UMetaPath("/Script/Engine.TriggerBase:SpriteComponent")]
	public UBillboardComponent SpriteComponent
	{
		get
		{
			CheckDestroyed();
			if (!SpriteComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TriggerBase:SpriteComponent");
				return null;
			}
			return UObjectMarshaler<UBillboardComponent>.FromNative(IntPtr.Add(base.Address, SpriteComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpriteComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TriggerBase:SpriteComponent");
			}
			else
			{
				UObjectMarshaler<UBillboardComponent>.ToNative(IntPtr.Add(base.Address, SpriteComponent_Offset), value);
			}
		}
	}

	static ATriggerBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ATriggerBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ATriggerBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.TriggerBase");
		CollisionComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CollisionComponent");
		CollisionComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CollisionComponent", Classes.FObjectProperty);
		SpriteComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SpriteComponent");
		SpriteComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SpriteComponent", Classes.FObjectProperty);
	}
}
