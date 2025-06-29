using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("移除Buff")]
[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_RemoveBuff")]
internal class BED_ProcessStateNode_RemoveBuff : BED_ProcessStateNode
{
	private static bool BuffID_IsValid;

	private static int BuffID_Offset;

	private static bool BuffLayer_IsValid;

	private static int BuffLayer_Offset;

	private static bool bTriggerRemoveEffect_IsValid;

	private static int bTriggerRemoveEffect_Offset;

	private static FFieldAddress bTriggerRemoveEffect_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_RemoveBuff:BuffID")]
	public int BuffID
	{
		get
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_RemoveBuff:BuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_RemoveBuff:BuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, "1")]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_RemoveBuff:BuffLayer")]
	public int BuffLayer
	{
		get
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_RemoveBuff:BuffLayer");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffLayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_RemoveBuff:BuffLayer");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffLayer_Offset), value);
			}
		}
	}

	[DisplayName("是否触发移除效果")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_RemoveBuff:bTriggerRemoveEffect")]
	public bool bTriggerRemoveEffect
	{
		get
		{
			CheckDestroyed();
			if (!bTriggerRemoveEffect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_RemoveBuff:bTriggerRemoveEffect");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bTriggerRemoveEffect_Offset), 0, bTriggerRemoveEffect_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bTriggerRemoveEffect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_RemoveBuff:bTriggerRemoveEffect");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bTriggerRemoveEffect_Offset), 0, bTriggerRemoveEffect_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		BuffLayer = 1;
		bTriggerRemoveEffect = true;
	}

	public override string GetNodeName()
	{
		return "Process.State.RemoveBuff";
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessStateNode_RemoveBuff");
		BuffID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BuffID");
		BuffID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BuffID", Classes.FIntProperty);
		BuffLayer_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BuffLayer");
		BuffLayer_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BuffLayer", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bTriggerRemoveEffect_PropertyAddress, unrealStruct, "bTriggerRemoveEffect");
		bTriggerRemoveEffect_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bTriggerRemoveEffect");
		bTriggerRemoveEffect_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bTriggerRemoveEffect", Classes.FBoolProperty);
	}

	static BED_ProcessStateNode_RemoveBuff()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_ProcessStateNode_RemoveBuff)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_ProcessStateNode_RemoveBuff));
	}
}
