using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_FXAnimalEditComp")]
public class BUS_FXAnimalEditComp : UActorEditCompBase
{
	private static bool SpeedType_IsValid;

	private static int SpeedType_Offset;

	private static FFieldAddress SpeedType_PropertyAddress;

	private static bool MoveSpeed_IsValid;

	private static int MoveSpeed_Offset;

	private static bool MoveType_IsValid;

	private static int MoveType_Offset;

	private static FFieldAddress MoveType_PropertyAddress;

	private static bool Time_BeginToDisappear_IsValid;

	private static int Time_BeginToDisappear_Offset;

	private static bool Time_EscapeToDisappear_IsValid;

	private static int Time_EscapeToDisappear_Offset;

	private static bool Time_DisappearToDestory_IsValid;

	private static int Time_DisappearToDestory_Offset;

	[BlueprintReadWrite]
	[DisplayName("速度类型")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_FXAnimalEditComp:SpeedType")]
	public EFXAnimalSpeedType SpeedType
	{
		get
		{
			CheckDestroyed();
			if (!SpeedType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FXAnimalEditComp:SpeedType");
				return EFXAnimalSpeedType.Normal;
			}
			return EnumMarshaler<EFXAnimalSpeedType>.FromNative(IntPtr.Add(base.Address, SpeedType_Offset), 0, SpeedType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpeedType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FXAnimalEditComp:SpeedType");
			}
			else
			{
				EnumMarshaler<EFXAnimalSpeedType>.ToNative(IntPtr.Add(base.Address, SpeedType_Offset), 0, SpeedType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("移动速度")]
	[USharpPath("/Script/b1-Managed.BUS_FXAnimalEditComp:MoveSpeed")]
	public float MoveSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MoveSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FXAnimalEditComp:MoveSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FXAnimalEditComp:MoveSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveSpeed_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("移动类型")]
	[USharpPath("/Script/b1-Managed.BUS_FXAnimalEditComp:MoveType")]
	public EFXAnimalMoveType MoveType
	{
		get
		{
			CheckDestroyed();
			if (!MoveType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FXAnimalEditComp:MoveType");
				return EFXAnimalMoveType.NormalMove;
			}
			return EnumMarshaler<EFXAnimalMoveType>.FromNative(IntPtr.Add(base.Address, MoveType_Offset), 0, MoveType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FXAnimalEditComp:MoveType");
			}
			else
			{
				EnumMarshaler<EFXAnimalMoveType>.ToNative(IntPtr.Add(base.Address, MoveType_Offset), 0, MoveType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("生命时间(开始到消失的时间)")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_FXAnimalEditComp:Time_BeginToDisappear")]
	public float Time_BeginToDisappear
	{
		get
		{
			CheckDestroyed();
			if (!Time_BeginToDisappear_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FXAnimalEditComp:Time_BeginToDisappear");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Time_BeginToDisappear_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Time_BeginToDisappear_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FXAnimalEditComp:Time_BeginToDisappear");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Time_BeginToDisappear_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("四散后到开始消失的时间")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_FXAnimalEditComp:Time_EscapeToDisappear")]
	public float Time_EscapeToDisappear
	{
		get
		{
			CheckDestroyed();
			if (!Time_EscapeToDisappear_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FXAnimalEditComp:Time_EscapeToDisappear");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Time_EscapeToDisappear_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Time_EscapeToDisappear_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FXAnimalEditComp:Time_EscapeToDisappear");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Time_EscapeToDisappear_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("消失到开始销毁的时间")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_FXAnimalEditComp:Time_DisappearToDestory")]
	public float Time_DisappearToDestory
	{
		get
		{
			CheckDestroyed();
			if (!Time_DisappearToDestory_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FXAnimalEditComp:Time_DisappearToDestory");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Time_DisappearToDestory_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Time_DisappearToDestory_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_FXAnimalEditComp:Time_DisappearToDestory");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Time_DisappearToDestory_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		Time_BeginToDisappear = 10f;
		Time_EscapeToDisappear = 8f;
		Time_DisappearToDestory = 5f;
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_FXAnimalCommData bUC_FXAnimalCommData = RequireWritableData<BUC_FXAnimalCommData>();
		bUC_FXAnimalCommData.SpeedType = SpeedType;
		bUC_FXAnimalCommData.MoveSpeed_ByConfig = MoveSpeed;
		bUC_FXAnimalCommData.MoveType = MoveType;
		bUC_FXAnimalCommData.Time_LifeTime = Time_BeginToDisappear;
		bUC_FXAnimalCommData.Time_EscapeToDisappear = Time_EscapeToDisappear;
		bUC_FXAnimalCommData.Time_DisappearToDestory = Time_DisappearToDestory;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_FXAnimalEditComp");
		NativeReflection.GetPropertyRef(ref SpeedType_PropertyAddress, unrealStruct, "SpeedType");
		SpeedType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpeedType");
		SpeedType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpeedType", Classes.FEnumProperty);
		MoveSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveSpeed");
		MoveSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveSpeed", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref MoveType_PropertyAddress, unrealStruct, "MoveType");
		MoveType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveType");
		MoveType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveType", Classes.FEnumProperty);
		Time_BeginToDisappear_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Time_BeginToDisappear");
		Time_BeginToDisappear_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Time_BeginToDisappear", Classes.FFloatProperty);
		Time_EscapeToDisappear_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Time_EscapeToDisappear");
		Time_EscapeToDisappear_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Time_EscapeToDisappear", Classes.FFloatProperty);
		Time_DisappearToDestory_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Time_DisappearToDestory");
		Time_DisappearToDestory_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Time_DisappearToDestory", Classes.FFloatProperty);
	}

	static BUS_FXAnimalEditComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_FXAnimalEditComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_FXAnimalEditComp));
	}
}
