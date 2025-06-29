using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.CameraShakeSourceActor", "Engine", UnrealModuleType.Engine)]
public class ACameraShakeSourceActor : AActor
{
	private static bool CameraShakeSourceComponent_IsValid;

	private static int CameraShakeSourceComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.CameraShakeSourceActor:CameraShakeSourceComponent")]
	public UCameraShakeSourceComponent CameraShakeSourceComponent
	{
		get
		{
			CheckDestroyed();
			if (!CameraShakeSourceComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraShakeSourceActor:CameraShakeSourceComponent");
				return null;
			}
			return UObjectMarshaler<UCameraShakeSourceComponent>.FromNative(IntPtr.Add(base.Address, CameraShakeSourceComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraShakeSourceComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraShakeSourceActor:CameraShakeSourceComponent");
			}
			else
			{
				UObjectMarshaler<UCameraShakeSourceComponent>.ToNative(IntPtr.Add(base.Address, CameraShakeSourceComponent_Offset), value);
			}
		}
	}

	static ACameraShakeSourceActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACameraShakeSourceActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACameraShakeSourceActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.CameraShakeSourceActor");
		CameraShakeSourceComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CameraShakeSourceComponent");
		CameraShakeSourceComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CameraShakeSourceComponent", Classes.FObjectProperty);
	}
}
