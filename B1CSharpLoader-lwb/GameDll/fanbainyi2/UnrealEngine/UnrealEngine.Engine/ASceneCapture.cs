using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)818413733uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.SceneCapture", "Engine", UnrealModuleType.Engine)]
public class ASceneCapture : AActor
{
	private static bool SceneComponent_IsValid;

	private static int SceneComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.SceneCapture:SceneComponent")]
	public USceneComponent SceneComponent
	{
		get
		{
			CheckDestroyed();
			if (!SceneComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCapture:SceneComponent");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, SceneComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCapture:SceneComponent");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, SceneComponent_Offset), value);
			}
		}
	}

	static ASceneCapture()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ASceneCapture)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ASceneCapture));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.SceneCapture");
		SceneComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SceneComponent");
		SceneComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SceneComponent", Classes.FObjectProperty);
	}
}
