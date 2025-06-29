using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1;

[StructLayout(LayoutKind.Sequential, Size = 8)]
[UStruct(Flags = 57345)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.GSNotifyEventTimeInfo", "UnrealExtent", UnrealModuleType.Game)]
public struct FGSNotifyEventTimeInfo
{
	private static bool TriggerTime_IsValid;

	private static int TriggerTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.GSNotifyEventTimeInfo:TriggerTime")]
	public float TriggerTime;

	private static bool EndTriggerTime_IsValid;

	private static int EndTriggerTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.GSNotifyEventTimeInfo:EndTriggerTime")]
	public float EndTriggerTime;

	private static int FGSNotifyEventTimeInfo_StructSize;

	public FGSNotifyEventTimeInfo Copy()
	{
		return this;
	}

	static FGSNotifyEventTimeInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSNotifyEventTimeInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSNotifyEventTimeInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/UnrealExtent.GSNotifyEventTimeInfo");
		FGSNotifyEventTimeInfo_StructSize = NativeReflection.GetStructSize(unrealStruct);
		TriggerTime_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TriggerTime");
		TriggerTime_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TriggerTime", Classes.FFloatProperty);
		EndTriggerTime_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EndTriggerTime");
		EndTriggerTime_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EndTriggerTime", Classes.FFloatProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FGSNotifyEventTimeInfo));
	}
}
