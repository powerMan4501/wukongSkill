using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_AbnormalStateAcc_Box")]
public class BUI_AbnormalStateAcc_Box : BUI_Widget
{
	private static bool MoveUp_Duration_IsValid;

	private static int MoveUp_Duration_Offset;

	private static bool MoveUp_FuncType_IsValid;

	private static int MoveUp_FuncType_Offset;

	private static FFieldAddress MoveUp_FuncType_PropertyAddress;

	private static bool MoveDown_Duration_IsValid;

	private static int MoveDown_Duration_Offset;

	private static bool MoveDown_FuncType_IsValid;

	private static int MoveDown_FuncType_Offset;

	private static FFieldAddress MoveDown_FuncType_PropertyAddress;

	private static bool Hidden_Duration_IsValid;

	private static int Hidden_Duration_Offset;

	[EditDefaultsOnly]
	[UProperty]
	[BlueprintReadWrite]
	[Category("配置")]
	[DisplayName("上移时间")]
	[USharpPath("/Script/b1-Managed.BUI_AbnormalStateAcc_Box:MoveUp_Duration")]
	public float MoveUp_Duration
	{
		get
		{
			CheckDestroyed();
			if (!MoveUp_Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_AbnormalStateAcc_Box:MoveUp_Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveUp_Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveUp_Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_AbnormalStateAcc_Box:MoveUp_Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveUp_Duration_Offset), value);
			}
		}
	}

	[EditDefaultsOnly]
	[DisplayName("上移类型")]
	[Category("配置")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_AbnormalStateAcc_Box:MoveUp_FuncType")]
	public EEasingFunc MoveUp_FuncType
	{
		get
		{
			CheckDestroyed();
			if (!MoveUp_FuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_AbnormalStateAcc_Box:MoveUp_FuncType");
				return EEasingFunc.Linear;
			}
			return EnumMarshaler<EEasingFunc>.FromNative(IntPtr.Add(base.Address, MoveUp_FuncType_Offset), 0, MoveUp_FuncType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveUp_FuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_AbnormalStateAcc_Box:MoveUp_FuncType");
			}
			else
			{
				EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(base.Address, MoveUp_FuncType_Offset), 0, MoveUp_FuncType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("配置")]
	[UProperty]
	[EditDefaultsOnly]
	[BlueprintReadWrite]
	[DisplayName("下移时间")]
	[USharpPath("/Script/b1-Managed.BUI_AbnormalStateAcc_Box:MoveDown_Duration")]
	public float MoveDown_Duration
	{
		get
		{
			CheckDestroyed();
			if (!MoveDown_Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_AbnormalStateAcc_Box:MoveDown_Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveDown_Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveDown_Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_AbnormalStateAcc_Box:MoveDown_Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveDown_Duration_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditDefaultsOnly]
	[Category("配置")]
	[DisplayName("下移类型")]
	[USharpPath("/Script/b1-Managed.BUI_AbnormalStateAcc_Box:MoveDown_FuncType")]
	public EEasingFunc MoveDown_FuncType
	{
		get
		{
			CheckDestroyed();
			if (!MoveDown_FuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_AbnormalStateAcc_Box:MoveDown_FuncType");
				return EEasingFunc.Linear;
			}
			return EnumMarshaler<EEasingFunc>.FromNative(IntPtr.Add(base.Address, MoveDown_FuncType_Offset), 0, MoveDown_FuncType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveDown_FuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_AbnormalStateAcc_Box:MoveDown_FuncType");
			}
			else
			{
				EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(base.Address, MoveDown_FuncType_Offset), 0, MoveDown_FuncType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("配置")]
	[EditDefaultsOnly]
	[BlueprintReadWrite]
	[DisplayName("延迟下移时间")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_AbnormalStateAcc_Box:Hidden_Duration")]
	public float Hidden_Duration
	{
		get
		{
			CheckDestroyed();
			if (!Hidden_Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_AbnormalStateAcc_Box:Hidden_Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Hidden_Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Hidden_Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_AbnormalStateAcc_Box:Hidden_Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Hidden_Duration_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_AbnormalStateAcc_Box");
		MoveUp_Duration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveUp_Duration");
		MoveUp_Duration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveUp_Duration", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref MoveUp_FuncType_PropertyAddress, unrealStruct, "MoveUp_FuncType");
		MoveUp_FuncType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveUp_FuncType");
		MoveUp_FuncType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveUp_FuncType", Classes.FEnumProperty);
		MoveDown_Duration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveDown_Duration");
		MoveDown_Duration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveDown_Duration", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref MoveDown_FuncType_PropertyAddress, unrealStruct, "MoveDown_FuncType");
		MoveDown_FuncType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveDown_FuncType");
		MoveDown_FuncType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveDown_FuncType", Classes.FEnumProperty);
		Hidden_Duration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Hidden_Duration");
		Hidden_Duration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Hidden_Duration", Classes.FFloatProperty);
	}

	static BUI_AbnormalStateAcc_Box()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_AbnormalStateAcc_Box)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_AbnormalStateAcc_Box));
	}
}
