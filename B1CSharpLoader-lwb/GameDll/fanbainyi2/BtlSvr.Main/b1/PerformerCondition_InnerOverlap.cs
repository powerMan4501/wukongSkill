using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("在触发盒内")]
[UClass]
[USharpPath("/Script/b1-Managed.PerformerCondition_InnerOverlap")]
public class PerformerCondition_InnerOverlap : PerformerConditionBase
{
	private static bool OverlapBox_IsValid;

	private static int OverlapBox_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.PerformerCondition_InnerOverlap:OverlapBox")]
	public FGsSmartParam OverlapBox
	{
		get
		{
			CheckDestroyed();
			if (!OverlapBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerCondition_InnerOverlap:OverlapBox");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, OverlapBox_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverlapBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerCondition_InnerOverlap:OverlapBox");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, OverlapBox_Offset), value);
			}
		}
	}

	protected override bool IsSuccess()
	{
		if (base.ControlComp == null)
		{
			return false;
		}
		if (base.ControlComp.IsInnerOverlap(OverlapBox.ConfigGuid, out var bInnerOverlap))
		{
			return bInnerOverlap;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.PerformerCondition_InnerOverlap");
		OverlapBox_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OverlapBox");
		OverlapBox_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OverlapBox", Classes.FStructProperty);
	}

	static PerformerCondition_InnerOverlap()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(PerformerCondition_InnerOverlap)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(PerformerCondition_InnerOverlap));
	}
}
