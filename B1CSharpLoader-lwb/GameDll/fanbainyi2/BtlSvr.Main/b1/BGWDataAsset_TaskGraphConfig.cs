using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_TaskGraphConfig")]
public class BGWDataAsset_TaskGraphConfig : UBGWDataAsset
{
	private static bool TaskGraphAsset_IsValid;

	private static int TaskGraphAsset_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("任务Root图")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TaskGraphConfig:TaskGraphAsset")]
	public UCalliopeAsset TaskGraphAsset
	{
		get
		{
			CheckDestroyed();
			if (!TaskGraphAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TaskGraphConfig:TaskGraphAsset");
				return null;
			}
			return UObjectMarshaler<UCalliopeAsset>.FromNative(IntPtr.Add(base.Address, TaskGraphAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TaskGraphAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TaskGraphConfig:TaskGraphAsset");
			}
			else
			{
				UObjectMarshaler<UCalliopeAsset>.ToNative(IntPtr.Add(base.Address, TaskGraphAsset_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_TaskGraphConfig");
		TaskGraphAsset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TaskGraphAsset");
		TaskGraphAsset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TaskGraphAsset", Classes.FObjectProperty);
	}

	static BGWDataAsset_TaskGraphConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_TaskGraphConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_TaskGraphConfig));
	}
}
