using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.BackgroundBlur", "UMG", UnrealModuleType.Engine)]
public class UBackgroundBlur : UContentWidget
{
	private static bool Padding_IsValid;

	private static int Padding_Offset;

	private static bool HorizontalAlignment_IsValid;

	private static FFieldAddress HorizontalAlignment_PropertyAddress;

	private static int HorizontalAlignment_Offset;

	private static bool VerticalAlignment_IsValid;

	private static FFieldAddress VerticalAlignment_PropertyAddress;

	private static int VerticalAlignment_Offset;

	private static bool ApplyAlphaToBlur_IsValid;

	private static FFieldAddress ApplyAlphaToBlur_PropertyAddress;

	private static int ApplyAlphaToBlur_Offset;

	private static bool BlurStrength_IsValid;

	private static int BlurStrength_Offset;

	private static bool BlurRadius_IsValid;

	private static int BlurRadius_Offset;

	private static bool CornerRadius_IsValid;

	private static int CornerRadius_Offset;

	private static bool LowQualityFallbackBrush_IsValid;

	private static int LowQualityFallbackBrush_Offset;

	private static bool GSBlurMaskBrush_IsValid;

	private static int GSBlurMaskBrush_Offset;

	private static bool SetVerticalAlignment_IsValid;

	private static IntPtr SetVerticalAlignment_FunctionAddress;

	private static int SetVerticalAlignment_ParamsSize;

	private static bool SetVerticalAlignment_InVerticalAlignment_IsValid;

	private static FFieldAddress SetVerticalAlignment_InVerticalAlignment_PropertyAddress;

	private static int SetVerticalAlignment_InVerticalAlignment_Offset;

	private static bool SetPadding_IsValid;

	private static IntPtr SetPadding_FunctionAddress;

	private static int SetPadding_ParamsSize;

	private static bool SetPadding_InPadding_IsValid;

	private static FFieldAddress SetPadding_InPadding_PropertyAddress;

	private static int SetPadding_InPadding_Offset;

	private static bool SetLowQualityFallbackBrush_IsValid;

	private static IntPtr SetLowQualityFallbackBrush_FunctionAddress;

	private static int SetLowQualityFallbackBrush_ParamsSize;

	private static bool SetLowQualityFallbackBrush_InBrush_IsValid;

	private static FFieldAddress SetLowQualityFallbackBrush_InBrush_PropertyAddress;

	private static int SetLowQualityFallbackBrush_InBrush_Offset;

	private static bool SetHorizontalAlignment_IsValid;

	private static IntPtr SetHorizontalAlignment_FunctionAddress;

	private static int SetHorizontalAlignment_ParamsSize;

	private static bool SetHorizontalAlignment_InHorizontalAlignment_IsValid;

	private static FFieldAddress SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress;

	private static int SetHorizontalAlignment_InHorizontalAlignment_Offset;

	private static bool SetGSBlurMaskBrush_IsValid;

	private static IntPtr SetGSBlurMaskBrush_FunctionAddress;

	private static int SetGSBlurMaskBrush_ParamsSize;

	private static bool SetGSBlurMaskBrush_InBrush_IsValid;

	private static FFieldAddress SetGSBlurMaskBrush_InBrush_PropertyAddress;

	private static int SetGSBlurMaskBrush_InBrush_Offset;

	private static bool SetCornerRadius_IsValid;

	private static IntPtr SetCornerRadius_FunctionAddress;

	private static int SetCornerRadius_ParamsSize;

	private static bool SetCornerRadius_InCornerRadius_IsValid;

	private static FFieldAddress SetCornerRadius_InCornerRadius_PropertyAddress;

	private static int SetCornerRadius_InCornerRadius_Offset;

	private static bool SetBlurStrength_IsValid;

	private static IntPtr SetBlurStrength_FunctionAddress;

	private static int SetBlurStrength_ParamsSize;

	private static bool SetBlurStrength_InStrength_IsValid;

	private static FFieldAddress SetBlurStrength_InStrength_PropertyAddress;

	private static int SetBlurStrength_InStrength_Offset;

	private static bool SetBlurRadius_IsValid;

	private static IntPtr SetBlurRadius_FunctionAddress;

	private static int SetBlurRadius_ParamsSize;

	private static bool SetBlurRadius_InBlurRadius_IsValid;

	private static FFieldAddress SetBlurRadius_InBlurRadius_PropertyAddress;

	private static int SetBlurRadius_InBlurRadius_Offset;

	private static bool SetApplyAlphaToBlur_IsValid;

	private static IntPtr SetApplyAlphaToBlur_FunctionAddress;

	private static int SetApplyAlphaToBlur_ParamsSize;

	private static bool SetApplyAlphaToBlur_bInApplyAlphaToBlur_IsValid;

	private static FFieldAddress SetApplyAlphaToBlur_bInApplyAlphaToBlur_PropertyAddress;

	private static int SetApplyAlphaToBlur_bInApplyAlphaToBlur_Offset;

	[UProperty(Flags = (PropFlags)4503669420589589uL)]
	[UMetaPath("/Script/UMG.BackgroundBlur:Padding")]
	public FMargin Padding
	{
		get
		{
			CheckDestroyed();
			if (!Padding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.BackgroundBlur:Padding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, Padding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Padding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.BackgroundBlur:Padding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, Padding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.BackgroundBlur:HorizontalAlignment")]
	public EHorizontalAlignment HorizontalAlignment
	{
		get
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.BackgroundBlur:HorizontalAlignment");
				return EHorizontalAlignment.HAlign_Fill;
			}
			return EnumMarshaler<EHorizontalAlignment>.FromNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.BackgroundBlur:HorizontalAlignment");
			}
			else
			{
				EnumMarshaler<EHorizontalAlignment>.ToNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.BackgroundBlur:VerticalAlignment")]
	public EVerticalAlignment VerticalAlignment
	{
		get
		{
			CheckDestroyed();
			if (!VerticalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.BackgroundBlur:VerticalAlignment");
				return EVerticalAlignment.VAlign_Fill;
			}
			return EnumMarshaler<EVerticalAlignment>.FromNative(IntPtr.Add(base.Address, VerticalAlignment_Offset), 0, VerticalAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VerticalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.BackgroundBlur:VerticalAlignment");
			}
			else
			{
				EnumMarshaler<EVerticalAlignment>.ToNative(IntPtr.Add(base.Address, VerticalAlignment_Offset), 0, VerticalAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.BackgroundBlur:bApplyAlphaToBlur")]
	public bool ApplyAlphaToBlur
	{
		get
		{
			CheckDestroyed();
			if (!ApplyAlphaToBlur_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.BackgroundBlur:bApplyAlphaToBlur");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ApplyAlphaToBlur_Offset), 0, ApplyAlphaToBlur_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ApplyAlphaToBlur_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.BackgroundBlur:bApplyAlphaToBlur");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ApplyAlphaToBlur_Offset), 0, ApplyAlphaToBlur_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.BackgroundBlur:BlurStrength")]
	public float BlurStrength
	{
		get
		{
			CheckDestroyed();
			if (!BlurStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.BackgroundBlur:BlurStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlurStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlurStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.BackgroundBlur:BlurStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlurStrength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.BackgroundBlur:BlurRadius")]
	public int BlurRadius
	{
		get
		{
			CheckDestroyed();
			if (!BlurRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.BackgroundBlur:BlurRadius");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BlurRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlurRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.BackgroundBlur:BlurRadius");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BlurRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.BackgroundBlur:CornerRadius")]
	public FVector4 CornerRadius
	{
		get
		{
			CheckDestroyed();
			if (!CornerRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.BackgroundBlur:CornerRadius");
				return default(FVector4);
			}
			return BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(base.Address, CornerRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CornerRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.BackgroundBlur:CornerRadius");
			}
			else
			{
				BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(base.Address, CornerRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UMG.BackgroundBlur:LowQualityFallbackBrush")]
	public FSlateBrush LowQualityFallbackBrush
	{
		get
		{
			CheckDestroyed();
			if (!LowQualityFallbackBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.BackgroundBlur:LowQualityFallbackBrush");
				return default(FSlateBrush);
			}
			return FSlateBrush.FromNative(IntPtr.Add(base.Address, LowQualityFallbackBrush_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LowQualityFallbackBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.BackgroundBlur:LowQualityFallbackBrush");
			}
			else
			{
				FSlateBrush.ToNative(IntPtr.Add(base.Address, LowQualityFallbackBrush_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UMG.BackgroundBlur:GSBlurMaskBrush")]
	public FSlateBrush GSBlurMaskBrush
	{
		get
		{
			CheckDestroyed();
			if (!GSBlurMaskBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.BackgroundBlur:GSBlurMaskBrush");
				return default(FSlateBrush);
			}
			return FSlateBrush.FromNative(IntPtr.Add(base.Address, GSBlurMaskBrush_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSBlurMaskBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.BackgroundBlur:GSBlurMaskBrush");
			}
			else
			{
				FSlateBrush.ToNative(IntPtr.Add(base.Address, GSBlurMaskBrush_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.BackgroundBlur:SetVerticalAlignment")]
	public unsafe void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
	{
		CheckDestroyed();
		if (!SetVerticalAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.BackgroundBlur:SetVerticalAlignment");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVerticalAlignment_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVerticalAlignment_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EVerticalAlignment>.ToNative(IntPtr.Add(intPtr, SetVerticalAlignment_InVerticalAlignment_Offset), 0, SetVerticalAlignment_InVerticalAlignment_PropertyAddress.Address, InVerticalAlignment);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVerticalAlignment_FunctionAddress, intPtr, SetVerticalAlignment_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.BackgroundBlur:SetPadding")]
	public unsafe void SetPadding(FMargin InPadding)
	{
		CheckDestroyed();
		if (!SetPadding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.BackgroundBlur:SetPadding");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPadding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPadding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(intPtr, SetPadding_InPadding_Offset), 0, SetPadding_InPadding_PropertyAddress.Address, InPadding);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPadding_FunctionAddress, intPtr, SetPadding_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UMG.BackgroundBlur:SetLowQualityFallbackBrush")]
	public unsafe void SetLowQualityFallbackBrush(FSlateBrush InBrush)
	{
		CheckDestroyed();
		if (!SetLowQualityFallbackBrush_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.BackgroundBlur:SetLowQualityFallbackBrush");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLowQualityFallbackBrush_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLowQualityFallbackBrush_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetLowQualityFallbackBrush_InBrush_PropertyAddress.Address, intPtr);
		FSlateBrush.ToNative(IntPtr.Add(intPtr, SetLowQualityFallbackBrush_InBrush_Offset), 0, SetLowQualityFallbackBrush_InBrush_PropertyAddress.Address, InBrush);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLowQualityFallbackBrush_FunctionAddress, intPtr, SetLowQualityFallbackBrush_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetLowQualityFallbackBrush_InBrush_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.BackgroundBlur:SetHorizontalAlignment")]
	public unsafe void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
	{
		CheckDestroyed();
		if (!SetHorizontalAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.BackgroundBlur:SetHorizontalAlignment");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHorizontalAlignment_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHorizontalAlignment_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EHorizontalAlignment>.ToNative(IntPtr.Add(intPtr, SetHorizontalAlignment_InHorizontalAlignment_Offset), 0, SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress.Address, InHorizontalAlignment);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHorizontalAlignment_FunctionAddress, intPtr, SetHorizontalAlignment_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UMG.BackgroundBlur:SetGSBlurMaskBrush")]
	public unsafe void SetGSBlurMaskBrush(FSlateBrush InBrush)
	{
		CheckDestroyed();
		if (!SetGSBlurMaskBrush_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.BackgroundBlur:SetGSBlurMaskBrush");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGSBlurMaskBrush_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGSBlurMaskBrush_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetGSBlurMaskBrush_InBrush_PropertyAddress.Address, intPtr);
		FSlateBrush.ToNative(IntPtr.Add(intPtr, SetGSBlurMaskBrush_InBrush_Offset), 0, SetGSBlurMaskBrush_InBrush_PropertyAddress.Address, InBrush);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGSBlurMaskBrush_FunctionAddress, intPtr, SetGSBlurMaskBrush_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetGSBlurMaskBrush_InBrush_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/UMG.BackgroundBlur:SetCornerRadius")]
	public unsafe void SetCornerRadius(FVector4 InCornerRadius)
	{
		CheckDestroyed();
		if (!SetCornerRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.BackgroundBlur:SetCornerRadius");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCornerRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCornerRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(intPtr, SetCornerRadius_InCornerRadius_Offset), 0, SetCornerRadius_InCornerRadius_PropertyAddress.Address, InCornerRadius);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCornerRadius_FunctionAddress, intPtr, SetCornerRadius_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.BackgroundBlur:SetBlurStrength")]
	public unsafe void SetBlurStrength(float InStrength)
	{
		CheckDestroyed();
		if (!SetBlurStrength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.BackgroundBlur:SetBlurStrength");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBlurStrength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBlurStrength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBlurStrength_InStrength_Offset), 0, SetBlurStrength_InStrength_PropertyAddress.Address, InStrength);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBlurStrength_FunctionAddress, intPtr, SetBlurStrength_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.BackgroundBlur:SetBlurRadius")]
	public unsafe void SetBlurRadius(int InBlurRadius)
	{
		CheckDestroyed();
		if (!SetBlurRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.BackgroundBlur:SetBlurRadius");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBlurRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBlurRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetBlurRadius_InBlurRadius_Offset), 0, SetBlurRadius_InBlurRadius_PropertyAddress.Address, InBlurRadius);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBlurRadius_FunctionAddress, intPtr, SetBlurRadius_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.BackgroundBlur:SetApplyAlphaToBlur")]
	public unsafe void SetApplyAlphaToBlur(bool bInApplyAlphaToBlur)
	{
		CheckDestroyed();
		if (!SetApplyAlphaToBlur_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.BackgroundBlur:SetApplyAlphaToBlur");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetApplyAlphaToBlur_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetApplyAlphaToBlur_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetApplyAlphaToBlur_bInApplyAlphaToBlur_Offset), 0, SetApplyAlphaToBlur_bInApplyAlphaToBlur_PropertyAddress.Address, bInApplyAlphaToBlur);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetApplyAlphaToBlur_FunctionAddress, intPtr, SetApplyAlphaToBlur_ParamsSize);
	}

	static UBackgroundBlur()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBackgroundBlur)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBackgroundBlur));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.BackgroundBlur");
		Padding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Padding");
		Padding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Padding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HorizontalAlignment_PropertyAddress, intPtr, "HorizontalAlignment");
		HorizontalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HorizontalAlignment");
		HorizontalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HorizontalAlignment", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref VerticalAlignment_PropertyAddress, intPtr, "VerticalAlignment");
		VerticalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VerticalAlignment");
		VerticalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VerticalAlignment", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyAlphaToBlur_PropertyAddress, intPtr, "bApplyAlphaToBlur");
		ApplyAlphaToBlur_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bApplyAlphaToBlur");
		ApplyAlphaToBlur_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bApplyAlphaToBlur", Classes.FBoolProperty);
		BlurStrength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlurStrength");
		BlurStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlurStrength", Classes.FFloatProperty);
		BlurRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlurRadius");
		BlurRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlurRadius", Classes.FIntProperty);
		CornerRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CornerRadius");
		CornerRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CornerRadius", Classes.FStructProperty);
		LowQualityFallbackBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LowQualityFallbackBrush");
		LowQualityFallbackBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LowQualityFallbackBrush", Classes.FStructProperty);
		GSBlurMaskBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSBlurMaskBrush");
		GSBlurMaskBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSBlurMaskBrush", Classes.FStructProperty);
		SetVerticalAlignment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVerticalAlignment");
		SetVerticalAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVerticalAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVerticalAlignment_InVerticalAlignment_PropertyAddress, SetVerticalAlignment_FunctionAddress, "InVerticalAlignment");
		SetVerticalAlignment_InVerticalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(SetVerticalAlignment_FunctionAddress, "InVerticalAlignment");
		SetVerticalAlignment_InVerticalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVerticalAlignment_FunctionAddress, "InVerticalAlignment", Classes.FByteProperty);
		SetVerticalAlignment_IsValid = SetVerticalAlignment_FunctionAddress != IntPtr.Zero && SetVerticalAlignment_InVerticalAlignment_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.BackgroundBlur:SetVerticalAlignment", SetVerticalAlignment_IsValid);
		SetPadding_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPadding");
		SetPadding_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPadding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPadding_InPadding_PropertyAddress, SetPadding_FunctionAddress, "InPadding");
		SetPadding_InPadding_Offset = NativeReflectionCached.GetPropertyOffset(SetPadding_FunctionAddress, "InPadding");
		SetPadding_InPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPadding_FunctionAddress, "InPadding", Classes.FStructProperty);
		SetPadding_IsValid = SetPadding_FunctionAddress != IntPtr.Zero && SetPadding_InPadding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.BackgroundBlur:SetPadding", SetPadding_IsValid);
		SetLowQualityFallbackBrush_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLowQualityFallbackBrush");
		SetLowQualityFallbackBrush_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLowQualityFallbackBrush_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLowQualityFallbackBrush_InBrush_PropertyAddress, SetLowQualityFallbackBrush_FunctionAddress, "InBrush");
		SetLowQualityFallbackBrush_InBrush_Offset = NativeReflectionCached.GetPropertyOffset(SetLowQualityFallbackBrush_FunctionAddress, "InBrush");
		SetLowQualityFallbackBrush_InBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLowQualityFallbackBrush_FunctionAddress, "InBrush", Classes.FStructProperty);
		SetLowQualityFallbackBrush_IsValid = SetLowQualityFallbackBrush_FunctionAddress != IntPtr.Zero && SetLowQualityFallbackBrush_InBrush_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.BackgroundBlur:SetLowQualityFallbackBrush", SetLowQualityFallbackBrush_IsValid);
		SetHorizontalAlignment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHorizontalAlignment");
		SetHorizontalAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHorizontalAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress, SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment");
		SetHorizontalAlignment_InHorizontalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment");
		SetHorizontalAlignment_InHorizontalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment", Classes.FByteProperty);
		SetHorizontalAlignment_IsValid = SetHorizontalAlignment_FunctionAddress != IntPtr.Zero && SetHorizontalAlignment_InHorizontalAlignment_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.BackgroundBlur:SetHorizontalAlignment", SetHorizontalAlignment_IsValid);
		SetGSBlurMaskBrush_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGSBlurMaskBrush");
		SetGSBlurMaskBrush_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGSBlurMaskBrush_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGSBlurMaskBrush_InBrush_PropertyAddress, SetGSBlurMaskBrush_FunctionAddress, "InBrush");
		SetGSBlurMaskBrush_InBrush_Offset = NativeReflectionCached.GetPropertyOffset(SetGSBlurMaskBrush_FunctionAddress, "InBrush");
		SetGSBlurMaskBrush_InBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGSBlurMaskBrush_FunctionAddress, "InBrush", Classes.FStructProperty);
		SetGSBlurMaskBrush_IsValid = SetGSBlurMaskBrush_FunctionAddress != IntPtr.Zero && SetGSBlurMaskBrush_InBrush_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.BackgroundBlur:SetGSBlurMaskBrush", SetGSBlurMaskBrush_IsValid);
		SetCornerRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCornerRadius");
		SetCornerRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCornerRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCornerRadius_InCornerRadius_PropertyAddress, SetCornerRadius_FunctionAddress, "InCornerRadius");
		SetCornerRadius_InCornerRadius_Offset = NativeReflectionCached.GetPropertyOffset(SetCornerRadius_FunctionAddress, "InCornerRadius");
		SetCornerRadius_InCornerRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCornerRadius_FunctionAddress, "InCornerRadius", Classes.FStructProperty);
		SetCornerRadius_IsValid = SetCornerRadius_FunctionAddress != IntPtr.Zero && SetCornerRadius_InCornerRadius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.BackgroundBlur:SetCornerRadius", SetCornerRadius_IsValid);
		SetBlurStrength_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBlurStrength");
		SetBlurStrength_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBlurStrength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBlurStrength_InStrength_PropertyAddress, SetBlurStrength_FunctionAddress, "InStrength");
		SetBlurStrength_InStrength_Offset = NativeReflectionCached.GetPropertyOffset(SetBlurStrength_FunctionAddress, "InStrength");
		SetBlurStrength_InStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlurStrength_FunctionAddress, "InStrength", Classes.FFloatProperty);
		SetBlurStrength_IsValid = SetBlurStrength_FunctionAddress != IntPtr.Zero && SetBlurStrength_InStrength_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.BackgroundBlur:SetBlurStrength", SetBlurStrength_IsValid);
		SetBlurRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBlurRadius");
		SetBlurRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBlurRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBlurRadius_InBlurRadius_PropertyAddress, SetBlurRadius_FunctionAddress, "InBlurRadius");
		SetBlurRadius_InBlurRadius_Offset = NativeReflectionCached.GetPropertyOffset(SetBlurRadius_FunctionAddress, "InBlurRadius");
		SetBlurRadius_InBlurRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlurRadius_FunctionAddress, "InBlurRadius", Classes.FIntProperty);
		SetBlurRadius_IsValid = SetBlurRadius_FunctionAddress != IntPtr.Zero && SetBlurRadius_InBlurRadius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.BackgroundBlur:SetBlurRadius", SetBlurRadius_IsValid);
		SetApplyAlphaToBlur_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetApplyAlphaToBlur");
		SetApplyAlphaToBlur_ParamsSize = NativeReflection.GetFunctionParamsSize(SetApplyAlphaToBlur_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetApplyAlphaToBlur_bInApplyAlphaToBlur_PropertyAddress, SetApplyAlphaToBlur_FunctionAddress, "bInApplyAlphaToBlur");
		SetApplyAlphaToBlur_bInApplyAlphaToBlur_Offset = NativeReflectionCached.GetPropertyOffset(SetApplyAlphaToBlur_FunctionAddress, "bInApplyAlphaToBlur");
		SetApplyAlphaToBlur_bInApplyAlphaToBlur_IsValid = NativeReflectionCached.ValidatePropertyClass(SetApplyAlphaToBlur_FunctionAddress, "bInApplyAlphaToBlur", Classes.FBoolProperty);
		SetApplyAlphaToBlur_IsValid = SetApplyAlphaToBlur_FunctionAddress != IntPtr.Zero && SetApplyAlphaToBlur_bInApplyAlphaToBlur_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.BackgroundBlur:SetApplyAlphaToBlur", SetApplyAlphaToBlur_IsValid);
	}
}
