using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UMG.ButtonSlot", "UMG", UnrealModuleType.Engine)]
public class UButtonSlot : UPanelSlot
{
	private static bool Padding_IsValid;

	private static int Padding_Offset;

	private static bool HorizontalAlignment_IsValid;

	private static FFieldAddress HorizontalAlignment_PropertyAddress;

	private static int HorizontalAlignment_Offset;

	private static bool VerticalAlignment_IsValid;

	private static FFieldAddress VerticalAlignment_PropertyAddress;

	private static int VerticalAlignment_Offset;

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

	private static bool SetHorizontalAlignment_IsValid;

	private static IntPtr SetHorizontalAlignment_FunctionAddress;

	private static int SetHorizontalAlignment_ParamsSize;

	private static bool SetHorizontalAlignment_InHorizontalAlignment_IsValid;

	private static FFieldAddress SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress;

	private static int SetHorizontalAlignment_InHorizontalAlignment_Offset;

	[UProperty(Flags = (PropFlags)4503669420589589uL)]
	[UMetaPath("/Script/UMG.ButtonSlot:Padding")]
	public FMargin Padding
	{
		get
		{
			CheckDestroyed();
			if (!Padding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ButtonSlot:Padding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, Padding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Padding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ButtonSlot:Padding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, Padding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ButtonSlot:HorizontalAlignment")]
	public EHorizontalAlignment HorizontalAlignment
	{
		get
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ButtonSlot:HorizontalAlignment");
				return EHorizontalAlignment.HAlign_Fill;
			}
			return EnumMarshaler<EHorizontalAlignment>.FromNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ButtonSlot:HorizontalAlignment");
			}
			else
			{
				EnumMarshaler<EHorizontalAlignment>.ToNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.ButtonSlot:VerticalAlignment")]
	public EVerticalAlignment VerticalAlignment
	{
		get
		{
			CheckDestroyed();
			if (!VerticalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ButtonSlot:VerticalAlignment");
				return EVerticalAlignment.VAlign_Fill;
			}
			return EnumMarshaler<EVerticalAlignment>.FromNative(IntPtr.Add(base.Address, VerticalAlignment_Offset), 0, VerticalAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VerticalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.ButtonSlot:VerticalAlignment");
			}
			else
			{
				EnumMarshaler<EVerticalAlignment>.ToNative(IntPtr.Add(base.Address, VerticalAlignment_Offset), 0, VerticalAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ButtonSlot:SetVerticalAlignment")]
	public unsafe void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
	{
		CheckDestroyed();
		if (!SetVerticalAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ButtonSlot:SetVerticalAlignment");
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
	[UMetaPath("/Script/UMG.ButtonSlot:SetPadding")]
	public unsafe void SetPadding(FMargin InPadding)
	{
		CheckDestroyed();
		if (!SetPadding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ButtonSlot:SetPadding");
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

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.ButtonSlot:SetHorizontalAlignment")]
	public unsafe void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
	{
		CheckDestroyed();
		if (!SetHorizontalAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.ButtonSlot:SetHorizontalAlignment");
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

	static UButtonSlot()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UButtonSlot)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UButtonSlot));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.ButtonSlot");
		Padding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Padding");
		Padding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Padding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HorizontalAlignment_PropertyAddress, intPtr, "HorizontalAlignment");
		HorizontalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HorizontalAlignment");
		HorizontalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HorizontalAlignment", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref VerticalAlignment_PropertyAddress, intPtr, "VerticalAlignment");
		VerticalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VerticalAlignment");
		VerticalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VerticalAlignment", Classes.FByteProperty);
		SetVerticalAlignment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVerticalAlignment");
		SetVerticalAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVerticalAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVerticalAlignment_InVerticalAlignment_PropertyAddress, SetVerticalAlignment_FunctionAddress, "InVerticalAlignment");
		SetVerticalAlignment_InVerticalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(SetVerticalAlignment_FunctionAddress, "InVerticalAlignment");
		SetVerticalAlignment_InVerticalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVerticalAlignment_FunctionAddress, "InVerticalAlignment", Classes.FByteProperty);
		SetVerticalAlignment_IsValid = SetVerticalAlignment_FunctionAddress != IntPtr.Zero && SetVerticalAlignment_InVerticalAlignment_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ButtonSlot:SetVerticalAlignment", SetVerticalAlignment_IsValid);
		SetPadding_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPadding");
		SetPadding_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPadding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPadding_InPadding_PropertyAddress, SetPadding_FunctionAddress, "InPadding");
		SetPadding_InPadding_Offset = NativeReflectionCached.GetPropertyOffset(SetPadding_FunctionAddress, "InPadding");
		SetPadding_InPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPadding_FunctionAddress, "InPadding", Classes.FStructProperty);
		SetPadding_IsValid = SetPadding_FunctionAddress != IntPtr.Zero && SetPadding_InPadding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ButtonSlot:SetPadding", SetPadding_IsValid);
		SetHorizontalAlignment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHorizontalAlignment");
		SetHorizontalAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHorizontalAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress, SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment");
		SetHorizontalAlignment_InHorizontalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment");
		SetHorizontalAlignment_InHorizontalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment", Classes.FByteProperty);
		SetHorizontalAlignment_IsValid = SetHorizontalAlignment_FunctionAddress != IntPtr.Zero && SetHorizontalAlignment_InHorizontalAlignment_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.ButtonSlot:SetHorizontalAlignment", SetHorizontalAlignment_IsValid);
	}
}
