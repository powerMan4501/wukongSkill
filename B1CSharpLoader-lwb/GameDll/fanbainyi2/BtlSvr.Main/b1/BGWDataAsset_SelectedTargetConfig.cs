using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig")]
public class BGWDataAsset_SelectedTargetConfig : UBGWDataAsset
{
	private static bool SelectedRange_IsValid;

	private static int SelectedRange_Offset;

	private static bool SelectedMaxMoveSpeed_IsValid;

	private static int SelectedMaxMoveSpeed_Offset;

	private static bool SelectedMinMoveSpeed_IsValid;

	private static int SelectedMinMoveSpeed_Offset;

	private static bool SelectFollowMoveSpeed_IsValid;

	private static int SelectFollowMoveSpeed_Offset;

	private static bool GamepadSelectRotateSpeed_IsValid;

	private static int GamepadSelectRotateSpeed_Offset;

	private static bool GamepadFollowRotateSpeed_IsValid;

	private static int GamepadFollowRotateSpeed_Offset;

	private static bool FollowMoveTime_IsValid;

	private static int FollowMoveTime_Offset;

	private static bool MinChangeAngle_IsValid;

	private static int MinChangeAngle_Offset;

	private static bool MeleGamepadSelectedAngle_IsValid;

	private static int MeleGamepadSelectedAngle_Offset;

	private static bool MeleMouseSelectedAngle_IsValid;

	private static int MeleMouseSelectedAngle_Offset;

	private static bool RangedGamepadSelectedAngle_IsValid;

	private static int RangedGamepadSelectedAngle_Offset;

	private static bool RangedMouseSelectedAngle_IsValid;

	private static int RangedMouseSelectedAngle_Offset;

	[Category("SSSCircle")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("捕获距离")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:SelectedRange")]
	public float SelectedRange
	{
		get
		{
			CheckDestroyed();
			if (!SelectedRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:SelectedRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SelectedRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SelectedRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:SelectedRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SelectedRange_Offset), value);
			}
		}
	}

	[Category("SSSCircle")]
	[DisplayName("最大移动速度")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:SelectedMaxMoveSpeed")]
	public float SelectedMaxMoveSpeed
	{
		get
		{
			CheckDestroyed();
			if (!SelectedMaxMoveSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:SelectedMaxMoveSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SelectedMaxMoveSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SelectedMaxMoveSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:SelectedMaxMoveSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SelectedMaxMoveSpeed_Offset), value);
			}
		}
	}

	[Category("SSSCircle")]
	[DisplayName("最小移动速度")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:SelectedMinMoveSpeed")]
	public float SelectedMinMoveSpeed
	{
		get
		{
			CheckDestroyed();
			if (!SelectedMinMoveSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:SelectedMinMoveSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SelectedMinMoveSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SelectedMinMoveSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:SelectedMinMoveSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SelectedMinMoveSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("跟随怪物移动速度")]
	[Category("SSSCircle")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:SelectFollowMoveSpeed")]
	public float SelectFollowMoveSpeed
	{
		get
		{
			CheckDestroyed();
			if (!SelectFollowMoveSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:SelectFollowMoveSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SelectFollowMoveSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SelectFollowMoveSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:SelectFollowMoveSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SelectFollowMoveSpeed_Offset), value);
			}
		}
	}

	[DisplayName("手柄旋转速度")]
	[Category("Comm")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:GamepadSelectRotateSpeed")]
	public float GamepadSelectRotateSpeed
	{
		get
		{
			CheckDestroyed();
			if (!GamepadSelectRotateSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:GamepadSelectRotateSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GamepadSelectRotateSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GamepadSelectRotateSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:GamepadSelectRotateSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GamepadSelectRotateSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("手柄跟随旋转速度")]
	[Category("Comm")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:GamepadFollowRotateSpeed")]
	public float GamepadFollowRotateSpeed
	{
		get
		{
			CheckDestroyed();
			if (!GamepadFollowRotateSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:GamepadFollowRotateSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GamepadFollowRotateSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GamepadFollowRotateSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:GamepadFollowRotateSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GamepadFollowRotateSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("移动间隔")]
	[Category("Comm")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:FollowMoveTime")]
	public float FollowMoveTime
	{
		get
		{
			CheckDestroyed();
			if (!FollowMoveTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:FollowMoveTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FollowMoveTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FollowMoveTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:FollowMoveTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FollowMoveTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("变动最小角度")]
	[Category("Comm")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:MinChangeAngle")]
	public float MinChangeAngle
	{
		get
		{
			CheckDestroyed();
			if (!MinChangeAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:MinChangeAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinChangeAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinChangeAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:MinChangeAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinChangeAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("近战手柄捕获角度")]
	[Category("Melee")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:MeleGamepadSelectedAngle")]
	public float MeleGamepadSelectedAngle
	{
		get
		{
			CheckDestroyed();
			if (!MeleGamepadSelectedAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:MeleGamepadSelectedAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MeleGamepadSelectedAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MeleGamepadSelectedAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:MeleGamepadSelectedAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MeleGamepadSelectedAngle_Offset), value);
			}
		}
	}

	[Category("Melee")]
	[DisplayName("近战鼠标捕获角度")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:MeleMouseSelectedAngle")]
	public float MeleMouseSelectedAngle
	{
		get
		{
			CheckDestroyed();
			if (!MeleMouseSelectedAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:MeleMouseSelectedAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MeleMouseSelectedAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MeleMouseSelectedAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:MeleMouseSelectedAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MeleMouseSelectedAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("远程手柄捕获角度")]
	[Category("Ranged")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:RangedGamepadSelectedAngle")]
	public float RangedGamepadSelectedAngle
	{
		get
		{
			CheckDestroyed();
			if (!RangedGamepadSelectedAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:RangedGamepadSelectedAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RangedGamepadSelectedAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RangedGamepadSelectedAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:RangedGamepadSelectedAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RangedGamepadSelectedAngle_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("Ranged")]
	[DisplayName("远程鼠标捕获角度")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:RangedMouseSelectedAngle")]
	public float RangedMouseSelectedAngle
	{
		get
		{
			CheckDestroyed();
			if (!RangedMouseSelectedAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:RangedMouseSelectedAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RangedMouseSelectedAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RangedMouseSelectedAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig:RangedMouseSelectedAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RangedMouseSelectedAngle_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SelectedRange = 200f;
		SelectedMaxMoveSpeed = 100f;
		SelectedMinMoveSpeed = 100f;
		SelectFollowMoveSpeed = 3000f;
		GamepadSelectRotateSpeed = 300f;
		GamepadFollowRotateSpeed = 1000f;
		FollowMoveTime = 0.2f;
		MinChangeAngle = 0.1f;
		MeleGamepadSelectedAngle = 120f;
		MeleMouseSelectedAngle = 120f;
		RangedGamepadSelectedAngle = 30f;
		RangedMouseSelectedAngle = 30f;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_SelectedTargetConfig");
		SelectedRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SelectedRange");
		SelectedRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SelectedRange", Classes.FFloatProperty);
		SelectedMaxMoveSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SelectedMaxMoveSpeed");
		SelectedMaxMoveSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SelectedMaxMoveSpeed", Classes.FFloatProperty);
		SelectedMinMoveSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SelectedMinMoveSpeed");
		SelectedMinMoveSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SelectedMinMoveSpeed", Classes.FFloatProperty);
		SelectFollowMoveSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SelectFollowMoveSpeed");
		SelectFollowMoveSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SelectFollowMoveSpeed", Classes.FFloatProperty);
		GamepadSelectRotateSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GamepadSelectRotateSpeed");
		GamepadSelectRotateSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GamepadSelectRotateSpeed", Classes.FFloatProperty);
		GamepadFollowRotateSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GamepadFollowRotateSpeed");
		GamepadFollowRotateSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GamepadFollowRotateSpeed", Classes.FFloatProperty);
		FollowMoveTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FollowMoveTime");
		FollowMoveTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FollowMoveTime", Classes.FFloatProperty);
		MinChangeAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MinChangeAngle");
		MinChangeAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MinChangeAngle", Classes.FFloatProperty);
		MeleGamepadSelectedAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MeleGamepadSelectedAngle");
		MeleGamepadSelectedAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MeleGamepadSelectedAngle", Classes.FFloatProperty);
		MeleMouseSelectedAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MeleMouseSelectedAngle");
		MeleMouseSelectedAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MeleMouseSelectedAngle", Classes.FFloatProperty);
		RangedGamepadSelectedAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RangedGamepadSelectedAngle");
		RangedGamepadSelectedAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RangedGamepadSelectedAngle", Classes.FFloatProperty);
		RangedMouseSelectedAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RangedMouseSelectedAngle");
		RangedMouseSelectedAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RangedMouseSelectedAngle", Classes.FFloatProperty);
	}

	static BGWDataAsset_SelectedTargetConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_SelectedTargetConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_SelectedTargetConfig));
	}
}
