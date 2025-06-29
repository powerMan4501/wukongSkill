using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.ScrollBar", "UMG", UnrealModuleType.Engine)]
public class UScrollBar : UWidget
{
	private static bool WidgetStyle_IsValid;

	private static int WidgetStyle_Offset;

	private static bool SetState_IsValid;

	private static IntPtr SetState_FunctionAddress;

	private static int SetState_ParamsSize;

	private static bool SetState_InOffsetFraction_IsValid;

	private static FFieldAddress SetState_InOffsetFraction_PropertyAddress;

	private static int SetState_InOffsetFraction_Offset;

	private static bool SetState_InThumbSizeFraction_IsValid;

	private static FFieldAddress SetState_InThumbSizeFraction_PropertyAddress;

	private static int SetState_InThumbSizeFraction_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UMG.ScrollBar:WidgetStyle")]
	public FScrollBarStyle WidgetStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBar:WidgetStyle");
				return default(FScrollBarStyle);
			}
			return FScrollBarStyle.FromNative(IntPtr.Add(base.Address, WidgetStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ScrollBar:WidgetStyle");
			}
			else
			{
				FScrollBarStyle.ToNative(IntPtr.Add(base.Address, WidgetStyle_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ScrollBar:SetState")]
	public unsafe void SetState(float InOffsetFraction, float InThumbSizeFraction)
	{
		CheckDestroyed();
		if (!SetState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ScrollBar:SetState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetState_InOffsetFraction_Offset), 0, SetState_InOffsetFraction_PropertyAddress.Address, InOffsetFraction);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetState_InThumbSizeFraction_Offset), 0, SetState_InThumbSizeFraction_PropertyAddress.Address, InThumbSizeFraction);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetState_FunctionAddress, intPtr, SetState_ParamsSize);
	}

	static UScrollBar()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UScrollBar)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UScrollBar));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.ScrollBar");
		WidgetStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetStyle");
		WidgetStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetStyle", Classes.FStructProperty);
		SetState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetState");
		SetState_ParamsSize = NativeReflection.GetFunctionParamsSize(SetState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetState_InOffsetFraction_PropertyAddress, SetState_FunctionAddress, "InOffsetFraction");
		SetState_InOffsetFraction_Offset = NativeReflectionCached.GetPropertyOffset(SetState_FunctionAddress, "InOffsetFraction");
		SetState_InOffsetFraction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetState_FunctionAddress, "InOffsetFraction", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetState_InThumbSizeFraction_PropertyAddress, SetState_FunctionAddress, "InThumbSizeFraction");
		SetState_InThumbSizeFraction_Offset = NativeReflectionCached.GetPropertyOffset(SetState_FunctionAddress, "InThumbSizeFraction");
		SetState_InThumbSizeFraction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetState_FunctionAddress, "InThumbSizeFraction", Classes.FFloatProperty);
		SetState_IsValid = SetState_FunctionAddress != IntPtr.Zero && SetState_InOffsetFraction_IsValid && SetState_InThumbSizeFraction_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ScrollBar:SetState", SetState_IsValid);
	}
}
