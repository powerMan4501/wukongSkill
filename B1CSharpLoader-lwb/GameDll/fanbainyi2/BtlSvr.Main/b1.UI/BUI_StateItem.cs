using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_StateItem")]
public class BUI_StateItem : BUI_Widget
{
	private static bool Padding_Left_IsValid;

	private static int Padding_Left_Offset;

	private static bool Padding_Right_IsValid;

	private static int Padding_Right_Offset;

	private static bool WarningRemaining_IsValid;

	private static int WarningRemaining_Offset;

	private static bool WarnningFlashCurve_IsValid;

	private static int WarnningFlashCurve_Offset;

	private static bool WarningFlashAge_IsValid;

	private static int WarningFlashAge_Offset;

	[EditDefaultsOnly]
	[UProperty]
	[DisplayName("Padding_Left")]
	[Category("配置")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_StateItem:Padding_Left")]
	public float Padding_Left
	{
		get
		{
			CheckDestroyed();
			if (!Padding_Left_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_StateItem:Padding_Left");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Padding_Left_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Padding_Left_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_StateItem:Padding_Left");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Padding_Left_Offset), value);
			}
		}
	}

	[Category("配置")]
	[DisplayName("Padding_Right")]
	[BlueprintReadWrite]
	[EditDefaultsOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_StateItem:Padding_Right")]
	public float Padding_Right
	{
		get
		{
			CheckDestroyed();
			if (!Padding_Right_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_StateItem:Padding_Right");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Padding_Right_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Padding_Right_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_StateItem:Padding_Right");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Padding_Right_Offset), value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[BlueprintReadWrite]
	[Category("配置")]
	[DisplayName("消失警告倒计时")]
	[USharpPath("/Script/b1-Managed.BUI_StateItem:WarningRemaining")]
	public float WarningRemaining
	{
		get
		{
			CheckDestroyed();
			if (!WarningRemaining_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_StateItem:WarningRemaining");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WarningRemaining_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WarningRemaining_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_StateItem:WarningRemaining");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WarningRemaining_Offset), value);
			}
		}
	}

	[Category("配置")]
	[DisplayName("消失警告闪烁曲线")]
	[UProperty]
	[EditDefaultsOnly]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_StateItem:WarnningFlashCurve")]
	public UCurveFloat WarnningFlashCurve
	{
		get
		{
			CheckDestroyed();
			if (!WarnningFlashCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_StateItem:WarnningFlashCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, WarnningFlashCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WarnningFlashCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_StateItem:WarnningFlashCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, WarnningFlashCurve_Offset), value);
			}
		}
	}

	[Category("配置")]
	[DisplayName("闪烁周期")]
	[BlueprintReadWrite]
	[EditDefaultsOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_StateItem:WarningFlashAge")]
	public float WarningFlashAge
	{
		get
		{
			CheckDestroyed();
			if (!WarningFlashAge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_StateItem:WarningFlashAge");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WarningFlashAge_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WarningFlashAge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_StateItem:WarningFlashAge");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WarningFlashAge_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_StateItem");
		Padding_Left_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Padding_Left");
		Padding_Left_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Padding_Left", Classes.FFloatProperty);
		Padding_Right_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Padding_Right");
		Padding_Right_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Padding_Right", Classes.FFloatProperty);
		WarningRemaining_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WarningRemaining");
		WarningRemaining_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WarningRemaining", Classes.FFloatProperty);
		WarnningFlashCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WarnningFlashCurve");
		WarnningFlashCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WarnningFlashCurve", Classes.FObjectProperty);
		WarningFlashAge_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WarningFlashAge");
		WarningFlashAge_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WarningFlashAge", Classes.FFloatProperty);
	}

	static BUI_StateItem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_StateItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_StateItem));
	}
}
