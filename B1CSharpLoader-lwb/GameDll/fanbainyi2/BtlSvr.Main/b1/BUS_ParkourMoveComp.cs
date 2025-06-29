using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ParkourMoveComp")]
public class BUS_ParkourMoveComp : UActorEditCompBase
{
	private static bool CheckParkourStartDistance_IsValid;

	private static int CheckParkourStartDistance_Offset;

	private static bool ParkourMaxHeight_IsValid;

	private static int ParkourMaxHeight_Offset;

	private static bool ParkourMinHeight_IsValid;

	private static int ParkourMinHeight_Offset;

	private static bool RunStrideSpeedRate_IsValid;

	private static int RunStrideSpeedRate_Offset;

	private static bool SprintStrideSpeedRate_IsValid;

	private static int SprintStrideSpeedRate_Offset;

	private static bool bEnableStrideDown_IsValid;

	private static int bEnableStrideDown_Offset;

	private static FFieldAddress bEnableStrideDown_PropertyAddress;

	[UProperty]
	[Category("Parkour Config")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ParkourMoveComp:CheckParkourStartDistance")]
	public float CheckParkourStartDistance
	{
		get
		{
			CheckDestroyed();
			if (!CheckParkourStartDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ParkourMoveComp:CheckParkourStartDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CheckParkourStartDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CheckParkourStartDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ParkourMoveComp:CheckParkourStartDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CheckParkourStartDistance_Offset), value);
			}
		}
	}

	[Category("Parkour Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ParkourMoveComp:ParkourMaxHeight")]
	public float ParkourMaxHeight
	{
		get
		{
			CheckDestroyed();
			if (!ParkourMaxHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ParkourMoveComp:ParkourMaxHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ParkourMaxHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParkourMaxHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ParkourMoveComp:ParkourMaxHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ParkourMaxHeight_Offset), value);
			}
		}
	}

	[Category("Parkour Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ParkourMoveComp:ParkourMinHeight")]
	public float ParkourMinHeight
	{
		get
		{
			CheckDestroyed();
			if (!ParkourMinHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ParkourMoveComp:ParkourMinHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ParkourMinHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParkourMinHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ParkourMoveComp:ParkourMinHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ParkourMinHeight_Offset), value);
			}
		}
	}

	[Category("Parkour Config")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ParkourMoveComp:RunStrideSpeedRate")]
	public float RunStrideSpeedRate
	{
		get
		{
			CheckDestroyed();
			if (!RunStrideSpeedRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ParkourMoveComp:RunStrideSpeedRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RunStrideSpeedRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RunStrideSpeedRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ParkourMoveComp:RunStrideSpeedRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RunStrideSpeedRate_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Parkour Config")]
	[USharpPath("/Script/b1-Managed.BUS_ParkourMoveComp:SprintStrideSpeedRate")]
	public float SprintStrideSpeedRate
	{
		get
		{
			CheckDestroyed();
			if (!SprintStrideSpeedRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ParkourMoveComp:SprintStrideSpeedRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SprintStrideSpeedRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SprintStrideSpeedRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ParkourMoveComp:SprintStrideSpeedRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SprintStrideSpeedRate_Offset), value);
			}
		}
	}

	[Category("Parkour Config")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ParkourMoveComp:bEnableStrideDown")]
	public bool bEnableStrideDown
	{
		get
		{
			CheckDestroyed();
			if (!bEnableStrideDown_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ParkourMoveComp:bEnableStrideDown");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableStrideDown_Offset), 0, bEnableStrideDown_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableStrideDown_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ParkourMoveComp:bEnableStrideDown");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableStrideDown_Offset), 0, bEnableStrideDown_PropertyAddress.Address, value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_ParkourMoveData bUC_ParkourMoveData = RequireWritableData<b1.BUC_ParkourMoveData>();
		bUC_ParkourMoveData.CheckParkourStartDistance = CheckParkourStartDistance;
		bUC_ParkourMoveData.ParkourStartMaxHeight = ParkourMaxHeight;
		bUC_ParkourMoveData.ParkourStartMinHeight = ParkourMinHeight;
		bUC_ParkourMoveData.RunStrideSpeedRate = RunStrideSpeedRate;
		bUC_ParkourMoveData.SprintStrideSpeedRate = SprintStrideSpeedRate;
		bUC_ParkourMoveData.bEnableStrideDown = bEnableStrideDown;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_ParkourMoveComp");
		CheckParkourStartDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CheckParkourStartDistance");
		CheckParkourStartDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CheckParkourStartDistance", Classes.FFloatProperty);
		ParkourMaxHeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ParkourMaxHeight");
		ParkourMaxHeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ParkourMaxHeight", Classes.FFloatProperty);
		ParkourMinHeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ParkourMinHeight");
		ParkourMinHeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ParkourMinHeight", Classes.FFloatProperty);
		RunStrideSpeedRate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RunStrideSpeedRate");
		RunStrideSpeedRate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RunStrideSpeedRate", Classes.FFloatProperty);
		SprintStrideSpeedRate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SprintStrideSpeedRate");
		SprintStrideSpeedRate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SprintStrideSpeedRate", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bEnableStrideDown_PropertyAddress, unrealStruct, "bEnableStrideDown");
		bEnableStrideDown_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnableStrideDown");
		bEnableStrideDown_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnableStrideDown", Classes.FBoolProperty);
	}

	static BUS_ParkourMoveComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ParkourMoveComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ParkourMoveComp));
	}
}
