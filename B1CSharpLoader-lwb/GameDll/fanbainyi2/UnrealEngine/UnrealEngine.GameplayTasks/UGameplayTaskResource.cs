using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.GameplayTasks;

[Abstract]
[UClass(Flags = (ClassFlags)877658277uL, Config = "Game")]
[UMetaPath("/Script/GameplayTasks.GameplayTaskResource", "GameplayTasks", UnrealModuleType.Engine)]
public class UGameplayTaskResource : UObject
{
	private static bool ManualResourceID_IsValid;

	private static int ManualResourceID_Offset;

	[UProperty(Flags = (PropFlags)11267864954749461uL)]
	[UMetaPath("/Script/GameplayTasks.GameplayTaskResource:ManualResourceID")]
	protected int ManualResourceID
	{
		get
		{
			CheckDestroyed();
			if (!ManualResourceID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GameplayTasks.GameplayTaskResource:ManualResourceID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ManualResourceID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ManualResourceID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GameplayTasks.GameplayTaskResource:ManualResourceID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ManualResourceID_Offset), value);
			}
		}
	}

	static UGameplayTaskResource()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGameplayTaskResource)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGameplayTaskResource));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/GameplayTasks.GameplayTaskResource");
		ManualResourceID_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ManualResourceID");
		ManualResourceID_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ManualResourceID", Classes.FIntProperty);
	}
}
