using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_GateStateMachineConfigComp")]
public class BUS_GateStateMachineConfigComp : UActorEditCompBase
{
	private static bool StartWithClosed_IsValid;

	private static int StartWithClosed_Offset;

	private static FFieldAddress StartWithClosed_PropertyAddress;

	private static bool ManualStateControl_IsValid;

	private static int ManualStateControl_Offset;

	private static FFieldAddress ManualStateControl_PropertyAddress;

	private static bool GateStateMachineType_IsValid;

	private static int GateStateMachineType_Offset;

	private static FFieldAddress GateStateMachineType_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("门状态机配置")]
	[DisplayName("默认关闭状态")]
	[USharpPath("/Script/b1-Managed.BUS_GateStateMachineConfigComp:StartWithClosed")]
	public bool StartWithClosed
	{
		get
		{
			CheckDestroyed();
			if (!StartWithClosed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_GateStateMachineConfigComp:StartWithClosed");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, StartWithClosed_Offset), 0, StartWithClosed_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StartWithClosed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_GateStateMachineConfigComp:StartWithClosed");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, StartWithClosed_Offset), 0, StartWithClosed_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("门状态机配置")]
	[UProperty]
	[DisplayName("手动状态控制")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_GateStateMachineConfigComp:ManualStateControl")]
	public bool ManualStateControl
	{
		get
		{
			CheckDestroyed();
			if (!ManualStateControl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_GateStateMachineConfigComp:ManualStateControl");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ManualStateControl_Offset), 0, ManualStateControl_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ManualStateControl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_GateStateMachineConfigComp:ManualStateControl");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ManualStateControl_Offset), 0, ManualStateControl_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("门状态机类型")]
	[Category("门状态机配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_GateStateMachineConfigComp:GateStateMachineType")]
	public EGateStateMachineType GateStateMachineType
	{
		get
		{
			CheckDestroyed();
			if (!GateStateMachineType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_GateStateMachineConfigComp:GateStateMachineType");
				return EGateStateMachineType.None;
			}
			return EnumMarshaler<EGateStateMachineType>.FromNative(IntPtr.Add(base.Address, GateStateMachineType_Offset), 0, GateStateMachineType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GateStateMachineType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_GateStateMachineConfigComp:GateStateMachineType");
			}
			else
			{
				EnumMarshaler<EGateStateMachineType>.ToNative(IntPtr.Add(base.Address, GateStateMachineType_Offset), 0, GateStateMachineType_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_GateStateMachineData bUC_GateStateMachineData = RequireWritableData<b1.BUC_GateStateMachineData>();
		if (bUC_GateStateMachineData != null)
		{
			bUC_GateStateMachineData.StartWithClosed = StartWithClosed;
			bUC_GateStateMachineData.ManualStateControl = ManualStateControl;
			bUC_GateStateMachineData.GateStateMachineType = GateStateMachineType;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_GateStateMachineConfigComp");
		NativeReflection.GetPropertyRef(ref StartWithClosed_PropertyAddress, unrealStruct, "StartWithClosed");
		StartWithClosed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StartWithClosed");
		StartWithClosed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StartWithClosed", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ManualStateControl_PropertyAddress, unrealStruct, "ManualStateControl");
		ManualStateControl_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ManualStateControl");
		ManualStateControl_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ManualStateControl", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref GateStateMachineType_PropertyAddress, unrealStruct, "GateStateMachineType");
		GateStateMachineType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GateStateMachineType");
		GateStateMachineType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GateStateMachineType", Classes.FEnumProperty);
	}

	static BUS_GateStateMachineConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_GateStateMachineConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_GateStateMachineConfigComp));
	}
}
