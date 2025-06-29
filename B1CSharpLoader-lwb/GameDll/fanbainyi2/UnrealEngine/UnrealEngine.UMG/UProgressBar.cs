using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.ProgressBar", "UMG", UnrealModuleType.Engine)]
public class UProgressBar : UWidget
{
	private static bool WidgetStyle_IsValid;

	private static int WidgetStyle_Offset;

	private static bool Percent_IsValid;

	private static int Percent_Offset;

	private static bool BarFillType_IsValid;

	private static FFieldAddress BarFillType_PropertyAddress;

	private static int BarFillType_Offset;

	private static bool BarFillStyle_IsValid;

	private static FFieldAddress BarFillStyle_PropertyAddress;

	private static int BarFillStyle_Offset;

	private static bool IsMarquee_IsValid;

	private static FFieldAddress IsMarquee_PropertyAddress;

	private static int IsMarquee_Offset;

	private static bool BorderPadding_IsValid;

	private static int BorderPadding_Offset;

	private static bool FillColorAndOpacity_IsValid;

	private static int FillColorAndOpacity_Offset;

	private static bool SetPercent_IsValid;

	private static IntPtr SetPercent_FunctionAddress;

	private static int SetPercent_ParamsSize;

	private static bool SetPercent_InPercent_IsValid;

	private static FFieldAddress SetPercent_InPercent_PropertyAddress;

	private static int SetPercent_InPercent_Offset;

	private static bool SetIsMarquee_IsValid;

	private static IntPtr SetIsMarquee_FunctionAddress;

	private static int SetIsMarquee_ParamsSize;

	private static bool SetIsMarquee_InbIsMarquee_IsValid;

	private static FFieldAddress SetIsMarquee_InbIsMarquee_PropertyAddress;

	private static int SetIsMarquee_InbIsMarquee_Offset;

	private static bool SetFillColorAndOpacity_IsValid;

	private static IntPtr SetFillColorAndOpacity_FunctionAddress;

	private static int SetFillColorAndOpacity_ParamsSize;

	private static bool SetFillColorAndOpacity_InColor_IsValid;

	private static FFieldAddress SetFillColorAndOpacity_InColor_PropertyAddress;

	private static int SetFillColorAndOpacity_InColor_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UMG.ProgressBar:WidgetStyle")]
	public FProgressBarStyle WidgetStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ProgressBar:WidgetStyle");
				return default(FProgressBarStyle);
			}
			return FProgressBarStyle.FromNative(IntPtr.Add(base.Address, WidgetStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ProgressBar:WidgetStyle");
			}
			else
			{
				FProgressBarStyle.ToNative(IntPtr.Add(base.Address, WidgetStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ProgressBar:Percent")]
	public float Percent
	{
		get
		{
			CheckDestroyed();
			if (!Percent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ProgressBar:Percent");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Percent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Percent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ProgressBar:Percent");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Percent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ProgressBar:BarFillType")]
	public EProgressBarFillType BarFillType
	{
		get
		{
			CheckDestroyed();
			if (!BarFillType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ProgressBar:BarFillType");
				return EProgressBarFillType.LeftToRight;
			}
			return EnumMarshaler<EProgressBarFillType>.FromNative(IntPtr.Add(base.Address, BarFillType_Offset), 0, BarFillType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BarFillType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ProgressBar:BarFillType");
			}
			else
			{
				EnumMarshaler<EProgressBarFillType>.ToNative(IntPtr.Add(base.Address, BarFillType_Offset), 0, BarFillType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ProgressBar:BarFillStyle")]
	public EProgressBarFillStyle BarFillStyle
	{
		get
		{
			CheckDestroyed();
			if (!BarFillStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ProgressBar:BarFillStyle");
				return EProgressBarFillStyle.Mask;
			}
			return EnumMarshaler<EProgressBarFillStyle>.FromNative(IntPtr.Add(base.Address, BarFillStyle_Offset), 0, BarFillStyle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BarFillStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ProgressBar:BarFillStyle");
			}
			else
			{
				EnumMarshaler<EProgressBarFillStyle>.ToNative(IntPtr.Add(base.Address, BarFillStyle_Offset), 0, BarFillStyle_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ProgressBar:bIsMarquee")]
	public bool IsMarquee
	{
		get
		{
			CheckDestroyed();
			if (!IsMarquee_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ProgressBar:bIsMarquee");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsMarquee_Offset), 0, IsMarquee_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsMarquee_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ProgressBar:bIsMarquee");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsMarquee_Offset), 0, IsMarquee_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ProgressBar:BorderPadding")]
	public FVector2D BorderPadding
	{
		get
		{
			CheckDestroyed();
			if (!BorderPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ProgressBar:BorderPadding");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, BorderPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BorderPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ProgressBar:BorderPadding");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, BorderPadding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ProgressBar:FillColorAndOpacity")]
	public FLinearColor FillColorAndOpacity
	{
		get
		{
			CheckDestroyed();
			if (!FillColorAndOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ProgressBar:FillColorAndOpacity");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, FillColorAndOpacity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FillColorAndOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ProgressBar:FillColorAndOpacity");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, FillColorAndOpacity_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ProgressBar:SetPercent")]
	public unsafe void SetPercent(float InPercent)
	{
		CheckDestroyed();
		if (!SetPercent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ProgressBar:SetPercent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPercent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPercent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPercent_InPercent_Offset), 0, SetPercent_InPercent_PropertyAddress.Address, InPercent);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPercent_FunctionAddress, intPtr, SetPercent_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ProgressBar:SetIsMarquee")]
	public unsafe void SetIsMarquee(bool InbIsMarquee)
	{
		CheckDestroyed();
		if (!SetIsMarquee_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ProgressBar:SetIsMarquee");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsMarquee_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsMarquee_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsMarquee_InbIsMarquee_Offset), 0, SetIsMarquee_InbIsMarquee_PropertyAddress.Address, InbIsMarquee);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIsMarquee_FunctionAddress, intPtr, SetIsMarquee_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.ProgressBar:SetFillColorAndOpacity")]
	public unsafe void SetFillColorAndOpacity(FLinearColor InColor)
	{
		CheckDestroyed();
		if (!SetFillColorAndOpacity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ProgressBar:SetFillColorAndOpacity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFillColorAndOpacity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFillColorAndOpacity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetFillColorAndOpacity_InColor_Offset), 0, SetFillColorAndOpacity_InColor_PropertyAddress.Address, InColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFillColorAndOpacity_FunctionAddress, intPtr, SetFillColorAndOpacity_ParamsSize);
	}

	static UProgressBar()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UProgressBar)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UProgressBar));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.ProgressBar");
		WidgetStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetStyle");
		WidgetStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetStyle", Classes.FStructProperty);
		Percent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Percent");
		Percent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Percent", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BarFillType_PropertyAddress, intPtr, "BarFillType");
		BarFillType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BarFillType");
		BarFillType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BarFillType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref BarFillStyle_PropertyAddress, intPtr, "BarFillStyle");
		BarFillStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BarFillStyle");
		BarFillStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BarFillStyle", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref IsMarquee_PropertyAddress, intPtr, "bIsMarquee");
		IsMarquee_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsMarquee");
		IsMarquee_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsMarquee", Classes.FBoolProperty);
		BorderPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BorderPadding");
		BorderPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BorderPadding", Classes.FStructProperty);
		FillColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FillColorAndOpacity");
		FillColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FillColorAndOpacity", Classes.FStructProperty);
		SetPercent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPercent");
		SetPercent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPercent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPercent_InPercent_PropertyAddress, SetPercent_FunctionAddress, "InPercent");
		SetPercent_InPercent_Offset = NativeReflectionCached.GetPropertyOffset(SetPercent_FunctionAddress, "InPercent");
		SetPercent_InPercent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPercent_FunctionAddress, "InPercent", Classes.FFloatProperty);
		SetPercent_IsValid = SetPercent_FunctionAddress != IntPtr.Zero && SetPercent_InPercent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ProgressBar:SetPercent", SetPercent_IsValid);
		SetIsMarquee_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIsMarquee");
		SetIsMarquee_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsMarquee_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsMarquee_InbIsMarquee_PropertyAddress, SetIsMarquee_FunctionAddress, "InbIsMarquee");
		SetIsMarquee_InbIsMarquee_Offset = NativeReflectionCached.GetPropertyOffset(SetIsMarquee_FunctionAddress, "InbIsMarquee");
		SetIsMarquee_InbIsMarquee_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsMarquee_FunctionAddress, "InbIsMarquee", Classes.FBoolProperty);
		SetIsMarquee_IsValid = SetIsMarquee_FunctionAddress != IntPtr.Zero && SetIsMarquee_InbIsMarquee_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ProgressBar:SetIsMarquee", SetIsMarquee_IsValid);
		SetFillColorAndOpacity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFillColorAndOpacity");
		SetFillColorAndOpacity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFillColorAndOpacity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFillColorAndOpacity_InColor_PropertyAddress, SetFillColorAndOpacity_FunctionAddress, "InColor");
		SetFillColorAndOpacity_InColor_Offset = NativeReflectionCached.GetPropertyOffset(SetFillColorAndOpacity_FunctionAddress, "InColor");
		SetFillColorAndOpacity_InColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFillColorAndOpacity_FunctionAddress, "InColor", Classes.FStructProperty);
		SetFillColorAndOpacity_IsValid = SetFillColorAndOpacity_FunctionAddress != IntPtr.Zero && SetFillColorAndOpacity_InColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ProgressBar:SetFillColorAndOpacity", SetFillColorAndOpacity_IsValid);
	}
}
