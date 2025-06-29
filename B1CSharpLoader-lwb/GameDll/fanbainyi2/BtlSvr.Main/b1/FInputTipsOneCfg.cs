using System;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.InputTipsOneCfg")]
public struct FInputTipsOneCfg
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.InputTipsOneCfg:InputAction")]
	public UInputAction InputAction;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("描述")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.InputTipsOneCfg:TxtDesc")]
	public FText TxtDesc;

	private static int InputTipsOneCfg_StructSize;

	private static int InputTipsOneCfg_IsValid;

	private static bool InputAction_IsValid;

	private static int InputAction_Offset;

	private static bool TxtDesc_IsValid;

	private static int TxtDesc_Offset;

	public override bool Equals(object obj)
	{
		FInputTipsOneCfg fInputTipsOneCfg = (FInputTipsOneCfg)obj;
		if (fInputTipsOneCfg.InputAction.Equals(InputAction))
		{
			return fInputTipsOneCfg.TxtDesc.Equals(TxtDesc);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public FInputTipsOneCfg Copy()
	{
		return this;
	}

	public static FInputTipsOneCfg FromNative(IntPtr nativeBuffer)
	{
		return new FInputTipsOneCfg(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInputTipsOneCfg value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInputTipsOneCfg FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInputTipsOneCfg(IntPtr.Add(nativeBuffer, arrayIndex * InputTipsOneCfg_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInputTipsOneCfg value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * InputTipsOneCfg_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (InputTipsOneCfg_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InputTipsOneCfg");
			return;
		}
		UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(nativeStruct, InputAction_Offset), InputAction);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, TxtDesc_Offset), TxtDesc);
	}

	public FInputTipsOneCfg(IntPtr nativeStruct)
	{
		if (InputTipsOneCfg_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InputTipsOneCfg");
			InputAction = null;
			TxtDesc = null;
		}
		else
		{
			InputAction = UObjectMarshaler<UInputAction>.FromNative(IntPtr.Add(nativeStruct, InputAction_Offset));
			TxtDesc = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, TxtDesc_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.InputTipsOneCfg");
		InputTipsOneCfg_StructSize = NativeReflection.GetStructSize(intPtr);
		InputAction_Offset = NativeReflection.GetPropertyOffset(intPtr, "InputAction");
		InputAction_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InputAction", Classes.FObjectProperty);
		TxtDesc_Offset = NativeReflection.GetPropertyOffset(intPtr, "TxtDesc");
		TxtDesc_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TxtDesc", Classes.FTextProperty);
		InputTipsOneCfg_IsValid = ((intPtr != IntPtr.Zero && InputAction_IsValid && TxtDesc_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.InputTipsOneCfg", (byte)InputTipsOneCfg_IsValid != 0);
	}

	static FInputTipsOneCfg()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FInputTipsOneCfg)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputTipsOneCfg));
	}
}
