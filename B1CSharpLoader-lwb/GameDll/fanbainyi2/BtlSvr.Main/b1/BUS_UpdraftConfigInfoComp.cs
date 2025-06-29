using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_UpdraftConfigInfoComp")]
public class BUS_UpdraftConfigInfoComp : UActorEditCompBase
{
	private static bool UpVelocity_IsValid;

	private static int UpVelocity_Offset;

	private static bool CD_IsValid;

	private static int CD_Offset;

	private static bool bEnableDebug_IsValid;

	private static int bEnableDebug_Offset;

	private static FFieldAddress bEnableDebug_PropertyAddress;

	[Tooltip("速度方向为上升气流的Z正方向")]
	[DisplayName("附加上升速度值")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("上升气流")]
	[USharpPath("/Script/b1-Managed.BUS_UpdraftConfigInfoComp:UpVelocity")]
	public float UpVelocity
	{
		get
		{
			CheckDestroyed();
			if (!UpVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_UpdraftConfigInfoComp:UpVelocity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UpVelocity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UpVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_UpdraftConfigInfoComp:UpVelocity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UpVelocity_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("上升气流")]
	[DisplayName("冷却时间")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_UpdraftConfigInfoComp:CD")]
	public float CD
	{
		get
		{
			CheckDestroyed();
			if (!CD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_UpdraftConfigInfoComp:CD");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CD_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_UpdraftConfigInfoComp:CD");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CD_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("上升气流")]
	[USharpPath("/Script/b1-Managed.BUS_UpdraftConfigInfoComp:bEnableDebug")]
	public bool bEnableDebug
	{
		get
		{
			CheckDestroyed();
			if (!bEnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_UpdraftConfigInfoComp:bEnableDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableDebug_Offset), 0, bEnableDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_UpdraftConfigInfoComp:bEnableDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableDebug_Offset), 0, bEnableDebug_PropertyAddress.Address, value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_UpdraftLogicData bUC_UpdraftLogicData = RequireWritableData<BUC_UpdraftLogicData>();
		if (bUC_UpdraftLogicData != null)
		{
			bUC_UpdraftLogicData.UpVelocity = UpVelocity;
			bUC_UpdraftLogicData.CD = CD;
			bUC_UpdraftLogicData.bEnableDebug = bEnableDebug;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_UpdraftConfigInfoComp");
		UpVelocity_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UpVelocity");
		UpVelocity_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UpVelocity", Classes.FFloatProperty);
		CD_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CD");
		CD_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CD", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bEnableDebug_PropertyAddress, unrealStruct, "bEnableDebug");
		bEnableDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnableDebug");
		bEnableDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnableDebug", Classes.FBoolProperty);
	}

	static BUS_UpdraftConfigInfoComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_UpdraftConfigInfoComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_UpdraftConfigInfoComp));
	}
}
