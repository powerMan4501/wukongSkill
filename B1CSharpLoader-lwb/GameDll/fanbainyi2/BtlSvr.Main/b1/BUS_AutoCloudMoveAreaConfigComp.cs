using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BUS_AutoCloudMoveAreaConfigComp")]
public class BUS_AutoCloudMoveAreaConfigComp : UActorEditCompBase
{
	private static bool AcceptRadius_IsValid;

	private static int AcceptRadius_Offset;

	private static bool MaxHeightDistance_IsValid;

	private static int MaxHeightDistance_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("自动移动配置")]
	[DisplayName("移动到达判定距离")]
	[Tooltip("离目标点多远视作到达目标点，停止自动移动")]
	[USharpPath("/Script/b1-Managed.BUS_AutoCloudMoveAreaConfigComp:AcceptRadius")]
	public float AcceptRadius
	{
		get
		{
			CheckDestroyed();
			if (!AcceptRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AutoCloudMoveAreaConfigComp:AcceptRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AcceptRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AcceptRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AutoCloudMoveAreaConfigComp:AcceptRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AcceptRadius_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("自动移动配置")]
	[DisplayName("移动目标点与角色最大高度差")]
	[Tooltip("移动目标点与角色最大高度差，若超过最大高度差，则相应调整目标点高度；若填负数，则该配置无效。")]
	[USharpPath("/Script/b1-Managed.BUS_AutoCloudMoveAreaConfigComp:MaxHeightDistance")]
	public float MaxHeightDistance
	{
		get
		{
			CheckDestroyed();
			if (!MaxHeightDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AutoCloudMoveAreaConfigComp:MaxHeightDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxHeightDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxHeightDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AutoCloudMoveAreaConfigComp:MaxHeightDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxHeightDistance_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.IsEditorOnly = false;
		AcceptRadius = 300f;
		MaxHeightDistance = -1f;
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_AutoCloudMoveAreaData bUC_AutoCloudMoveAreaData = RequireWritableData<b1.BUC_AutoCloudMoveAreaData>();
		bUC_AutoCloudMoveAreaData.AcceptRadius = AcceptRadius;
		bUC_AutoCloudMoveAreaData.MaxHeightDistance = MaxHeightDistance;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_AutoCloudMoveAreaConfigComp");
		AcceptRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AcceptRadius");
		AcceptRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AcceptRadius", Classes.FFloatProperty);
		MaxHeightDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxHeightDistance");
		MaxHeightDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxHeightDistance", Classes.FFloatProperty);
	}

	static BUS_AutoCloudMoveAreaConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_AutoCloudMoveAreaConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_AutoCloudMoveAreaConfigComp));
	}
}
