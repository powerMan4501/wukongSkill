using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SpecifyRebirthPosAreaConfigComp")]
public class BUS_SpecifyRebirthPosAreaConfigComp : UActorEditCompBase
{
	private static bool BindTuDiMiaoID_IsValid;

	private static int BindTuDiMiaoID_Offset;

	private static bool BindZhaoHunFanID_IsValid;

	private static int BindZhaoHunFanID_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("绑定的土地庙ID")]
	[USharpPath("/Script/b1-Managed.BUS_SpecifyRebirthPosAreaConfigComp:BindTuDiMiaoID")]
	public int BindTuDiMiaoID
	{
		get
		{
			CheckDestroyed();
			if (!BindTuDiMiaoID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpecifyRebirthPosAreaConfigComp:BindTuDiMiaoID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BindTuDiMiaoID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BindTuDiMiaoID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpecifyRebirthPosAreaConfigComp:BindTuDiMiaoID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BindTuDiMiaoID_Offset), value);
			}
		}
	}

	[DisplayName("绑定的招魂幡ID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_SpecifyRebirthPosAreaConfigComp:BindZhaoHunFanID")]
	public int BindZhaoHunFanID
	{
		get
		{
			CheckDestroyed();
			if (!BindZhaoHunFanID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpecifyRebirthPosAreaConfigComp:BindZhaoHunFanID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BindZhaoHunFanID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BindZhaoHunFanID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpecifyRebirthPosAreaConfigComp:BindZhaoHunFanID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BindZhaoHunFanID_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_SpecifyRebirthPosAreaData bUC_SpecifyRebirthPosAreaData = RequireWritableData<BUC_SpecifyRebirthPosAreaData>();
		bUC_SpecifyRebirthPosAreaData.BindTuDiMiaoID = BindTuDiMiaoID;
		bUC_SpecifyRebirthPosAreaData.BindZhaoHunFanID = BindZhaoHunFanID;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_SpecifyRebirthPosAreaConfigComp");
		BindTuDiMiaoID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BindTuDiMiaoID");
		BindTuDiMiaoID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BindTuDiMiaoID", Classes.FIntProperty);
		BindZhaoHunFanID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BindZhaoHunFanID");
		BindZhaoHunFanID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BindZhaoHunFanID", Classes.FIntProperty);
	}

	static BUS_SpecifyRebirthPosAreaConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SpecifyRebirthPosAreaConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SpecifyRebirthPosAreaConfigComp));
	}
}
