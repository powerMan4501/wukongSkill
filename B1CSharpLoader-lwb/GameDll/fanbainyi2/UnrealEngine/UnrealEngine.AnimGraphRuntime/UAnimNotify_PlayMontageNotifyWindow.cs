using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UClass(Flags = (ClassFlags)810627232uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AnimGraphRuntime.AnimNotify_PlayMontageNotifyWindow", "AnimGraphRuntime", UnrealModuleType.Engine)]
public class UAnimNotify_PlayMontageNotifyWindow : UAnimNotifyState
{
	private static bool NotifyName_IsValid;

	private static int NotifyName_Offset;

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNotify_PlayMontageNotifyWindow:NotifyName")]
	protected FName NotifyName
	{
		get
		{
			CheckDestroyed();
			if (!NotifyName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimGraphRuntime.AnimNotify_PlayMontageNotifyWindow:NotifyName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, NotifyName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimGraphRuntime.AnimNotify_PlayMontageNotifyWindow:NotifyName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, NotifyName_Offset), value);
			}
		}
	}

	static UAnimNotify_PlayMontageNotifyWindow()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimNotify_PlayMontageNotifyWindow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimNotify_PlayMontageNotifyWindow));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AnimGraphRuntime.AnimNotify_PlayMontageNotifyWindow");
		NotifyName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NotifyName");
		NotifyName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NotifyName", Classes.FNameProperty);
	}
}
