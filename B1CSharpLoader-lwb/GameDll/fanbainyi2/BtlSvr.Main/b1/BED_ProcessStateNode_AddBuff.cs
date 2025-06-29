using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("添加Buff")]
[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_AddBuff")]
internal class BED_ProcessStateNode_AddBuff : BED_ProcessStateNode
{
	private static bool BuffID_IsValid;

	private static int BuffID_Offset;

	private static bool BuffLayer_IsValid;

	private static int BuffLayer_Offset;

	private static bool BuffDuration_IsValid;

	private static int BuffDuration_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("AddBuff")]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_AddBuff:BuffID")]
	public int BuffID
	{
		get
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_AddBuff:BuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_AddBuff:BuffID");
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
	[Category("AddBuff")]
	[UMeta(MDProp.ClampMin, "1")]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_AddBuff:BuffLayer")]
	public int BuffLayer
	{
		get
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_AddBuff:BuffLayer");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffLayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_AddBuff:BuffLayer");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffLayer_Offset), value);
			}
		}
	}

	[Tooltip("-1:不移除 ； 0：读Buff表中配置")]
	[DisplayName("Buff持续时间(毫秒)")]
	[Category("AddBuff")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_AddBuff:BuffDuration")]
	public int BuffDuration
	{
		get
		{
			CheckDestroyed();
			if (!BuffDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_AddBuff:BuffDuration");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_AddBuff:BuffDuration");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffDuration_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		BuffLayer = 1;
	}

	public override string GetNodeName()
	{
		return "Process.State.AddBuff";
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessStateNode_AddBuff");
		BuffID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BuffID");
		BuffID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BuffID", Classes.FIntProperty);
		BuffLayer_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BuffLayer");
		BuffLayer_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BuffLayer", Classes.FIntProperty);
		BuffDuration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BuffDuration");
		BuffDuration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BuffDuration", Classes.FIntProperty);
	}

	static BED_ProcessStateNode_AddBuff()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_ProcessStateNode_AddBuff)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_ProcessStateNode_AddBuff));
	}
}
