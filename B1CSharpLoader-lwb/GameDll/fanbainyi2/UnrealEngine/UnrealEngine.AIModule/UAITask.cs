using System;
using UnrealEngine.GameplayTasks;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[Abstract]
[UClass(Flags = (ClassFlags)810549413uL, Config = "Game")]
[BlueprintType]
[UMetaPath("/Script/AIModule.AITask", "AIModule", UnrealModuleType.Engine)]
public class UAITask : UGameplayTask
{
	private static bool OwnerController_IsValid;

	private static int OwnerController_Offset;

	[UProperty(Flags = (PropFlags)12393764861510164uL)]
	[UMetaPath("/Script/AIModule.AITask:OwnerController")]
	protected AIController OwnerController
	{
		get
		{
			CheckDestroyed();
			if (!OwnerController_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AITask:OwnerController");
				return null;
			}
			return UObjectMarshaler<AIController>.FromNative(IntPtr.Add(base.Address, OwnerController_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OwnerController_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AITask:OwnerController");
			}
			else
			{
				UObjectMarshaler<AIController>.ToNative(IntPtr.Add(base.Address, OwnerController_Offset), value);
			}
		}
	}

	static UAITask()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAITask)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAITask));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AIModule.AITask");
		OwnerController_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OwnerController");
		OwnerController_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OwnerController", Classes.FObjectProperty);
	}
}
