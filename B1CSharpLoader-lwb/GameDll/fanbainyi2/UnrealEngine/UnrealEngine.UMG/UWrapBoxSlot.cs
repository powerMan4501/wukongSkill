using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UMG.WrapBoxSlot", "UMG", UnrealModuleType.Engine)]
public class UWrapBoxSlot : UPanelSlot
{
	private static bool Padding_IsValid;

	private static int Padding_Offset;

	private static bool FillEmptySpace_IsValid;

	private static FFieldAddress FillEmptySpace_PropertyAddress;

	private static int FillEmptySpace_Offset;

	private static bool FillSpanWhenLessThan_IsValid;

	private static int FillSpanWhenLessThan_Offset;

	private static bool HorizontalAlignment_IsValid;

	private static FFieldAddress HorizontalAlignment_PropertyAddress;

	private static int HorizontalAlignment_Offset;

	private static bool VerticalAlignment_IsValid;

	private static FFieldAddress VerticalAlignment_PropertyAddress;

	private static int VerticalAlignment_Offset;

	private static bool ForceNewLine_IsValid;

	private static FFieldAddress ForceNewLine_PropertyAddress;

	private static int ForceNewLine_Offset;

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

	private static bool SetNewLine_IsValid;

	private static IntPtr SetNewLine_FunctionAddress;

	private static int SetNewLine_ParamsSize;

	private static bool SetNewLine_InForceNewLine_IsValid;

	private static FFieldAddress SetNewLine_InForceNewLine_PropertyAddress;

	private static int SetNewLine_InForceNewLine_Offset;

	private static bool SetHorizontalAlignment_IsValid;

	private static IntPtr SetHorizontalAlignment_FunctionAddress;

	private static int SetHorizontalAlignment_ParamsSize;

	private static bool SetHorizontalAlignment_InHorizontalAlignment_IsValid;

	private static FFieldAddress SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress;

	private static int SetHorizontalAlignment_InHorizontalAlignment_Offset;

	private static bool SetFillSpanWhenLessThan_IsValid;

	private static IntPtr SetFillSpanWhenLessThan_FunctionAddress;

	private static int SetFillSpanWhenLessThan_ParamsSize;

	private static bool SetFillSpanWhenLessThan_InFillSpanWhenLessThan_IsValid;

	private static FFieldAddress SetFillSpanWhenLessThan_InFillSpanWhenLessThan_PropertyAddress;

	private static int SetFillSpanWhenLessThan_InFillSpanWhenLessThan_Offset;

	private static bool SetFillEmptySpace_IsValid;

	private static IntPtr SetFillEmptySpace_FunctionAddress;

	private static int SetFillEmptySpace_ParamsSize;

	private static bool SetFillEmptySpace_InbFillEmptySpace_IsValid;

	private static FFieldAddress SetFillEmptySpace_InbFillEmptySpace_PropertyAddress;

	private static int SetFillEmptySpace_InbFillEmptySpace_Offset;

	[UProperty(Flags = (PropFlags)4503669420589589uL)]
	[UMetaPath("/Script/UMG.WrapBoxSlot:Padding")]
	public FMargin Padding
	{
		get
		{
			CheckDestroyed();
			if (!Padding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBoxSlot:Padding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, Padding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Padding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBoxSlot:Padding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, Padding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.WrapBoxSlot:bFillEmptySpace")]
	public bool FillEmptySpace
	{
		get
		{
			CheckDestroyed();
			if (!FillEmptySpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBoxSlot:bFillEmptySpace");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, FillEmptySpace_Offset), 0, FillEmptySpace_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FillEmptySpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBoxSlot:bFillEmptySpace");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, FillEmptySpace_Offset), 0, FillEmptySpace_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.WrapBoxSlot:FillSpanWhenLessThan")]
	public float FillSpanWhenLessThan
	{
		get
		{
			CheckDestroyed();
			if (!FillSpanWhenLessThan_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBoxSlot:FillSpanWhenLessThan");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FillSpanWhenLessThan_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FillSpanWhenLessThan_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBoxSlot:FillSpanWhenLessThan");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FillSpanWhenLessThan_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.WrapBoxSlot:HorizontalAlignment")]
	public EHorizontalAlignment HorizontalAlignment
	{
		get
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBoxSlot:HorizontalAlignment");
				return EHorizontalAlignment.HAlign_Fill;
			}
			return EnumMarshaler<EHorizontalAlignment>.FromNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBoxSlot:HorizontalAlignment");
			}
			else
			{
				EnumMarshaler<EHorizontalAlignment>.ToNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.WrapBoxSlot:VerticalAlignment")]
	public EVerticalAlignment VerticalAlignment
	{
		get
		{
			CheckDestroyed();
			if (!VerticalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBoxSlot:VerticalAlignment");
				return EVerticalAlignment.VAlign_Fill;
			}
			return EnumMarshaler<EVerticalAlignment>.FromNative(IntPtr.Add(base.Address, VerticalAlignment_Offset), 0, VerticalAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VerticalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBoxSlot:VerticalAlignment");
			}
			else
			{
				EnumMarshaler<EVerticalAlignment>.ToNative(IntPtr.Add(base.Address, VerticalAlignment_Offset), 0, VerticalAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.WrapBoxSlot:bForceNewLine")]
	public bool ForceNewLine
	{
		get
		{
			CheckDestroyed();
			if (!ForceNewLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBoxSlot:bForceNewLine");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceNewLine_Offset), 0, ForceNewLine_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceNewLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WrapBoxSlot:bForceNewLine");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceNewLine_Offset), 0, ForceNewLine_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WrapBoxSlot:SetVerticalAlignment")]
	public unsafe void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
	{
		CheckDestroyed();
		if (!SetVerticalAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WrapBoxSlot:SetVerticalAlignment");
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
	[UMetaPath("/Script/UMG.WrapBoxSlot:SetPadding")]
	public unsafe void SetPadding(FMargin InPadding)
	{
		CheckDestroyed();
		if (!SetPadding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WrapBoxSlot:SetPadding");
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
	[UMetaPath("/Script/UMG.WrapBoxSlot:SetNewLine")]
	public unsafe void SetNewLine(bool InForceNewLine)
	{
		CheckDestroyed();
		if (!SetNewLine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WrapBoxSlot:SetNewLine");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNewLine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNewLine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNewLine_InForceNewLine_Offset), 0, SetNewLine_InForceNewLine_PropertyAddress.Address, InForceNewLine);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNewLine_FunctionAddress, intPtr, SetNewLine_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WrapBoxSlot:SetHorizontalAlignment")]
	public unsafe void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
	{
		CheckDestroyed();
		if (!SetHorizontalAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WrapBoxSlot:SetHorizontalAlignment");
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

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WrapBoxSlot:SetFillSpanWhenLessThan")]
	public unsafe void SetFillSpanWhenLessThan(float InFillSpanWhenLessThan)
	{
		CheckDestroyed();
		if (!SetFillSpanWhenLessThan_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WrapBoxSlot:SetFillSpanWhenLessThan");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFillSpanWhenLessThan_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFillSpanWhenLessThan_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFillSpanWhenLessThan_InFillSpanWhenLessThan_Offset), 0, SetFillSpanWhenLessThan_InFillSpanWhenLessThan_PropertyAddress.Address, InFillSpanWhenLessThan);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFillSpanWhenLessThan_FunctionAddress, intPtr, SetFillSpanWhenLessThan_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WrapBoxSlot:SetFillEmptySpace")]
	public unsafe void SetFillEmptySpace(bool InbFillEmptySpace)
	{
		CheckDestroyed();
		if (!SetFillEmptySpace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WrapBoxSlot:SetFillEmptySpace");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFillEmptySpace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFillEmptySpace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetFillEmptySpace_InbFillEmptySpace_Offset), 0, SetFillEmptySpace_InbFillEmptySpace_PropertyAddress.Address, InbFillEmptySpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFillEmptySpace_FunctionAddress, intPtr, SetFillEmptySpace_ParamsSize);
	}

	static UWrapBoxSlot()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UWrapBoxSlot)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UWrapBoxSlot));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.WrapBoxSlot");
		Padding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Padding");
		Padding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Padding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FillEmptySpace_PropertyAddress, intPtr, "bFillEmptySpace");
		FillEmptySpace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFillEmptySpace");
		FillEmptySpace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFillEmptySpace", Classes.FBoolProperty);
		FillSpanWhenLessThan_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FillSpanWhenLessThan");
		FillSpanWhenLessThan_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FillSpanWhenLessThan", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref HorizontalAlignment_PropertyAddress, intPtr, "HorizontalAlignment");
		HorizontalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HorizontalAlignment");
		HorizontalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HorizontalAlignment", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref VerticalAlignment_PropertyAddress, intPtr, "VerticalAlignment");
		VerticalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VerticalAlignment");
		VerticalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VerticalAlignment", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceNewLine_PropertyAddress, intPtr, "bForceNewLine");
		ForceNewLine_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bForceNewLine");
		ForceNewLine_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bForceNewLine", Classes.FBoolProperty);
		SetVerticalAlignment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVerticalAlignment");
		SetVerticalAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVerticalAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVerticalAlignment_InVerticalAlignment_PropertyAddress, SetVerticalAlignment_FunctionAddress, "InVerticalAlignment");
		SetVerticalAlignment_InVerticalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(SetVerticalAlignment_FunctionAddress, "InVerticalAlignment");
		SetVerticalAlignment_InVerticalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVerticalAlignment_FunctionAddress, "InVerticalAlignment", Classes.FByteProperty);
		SetVerticalAlignment_IsValid = SetVerticalAlignment_FunctionAddress != IntPtr.Zero && SetVerticalAlignment_InVerticalAlignment_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WrapBoxSlot:SetVerticalAlignment", SetVerticalAlignment_IsValid);
		SetPadding_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPadding");
		SetPadding_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPadding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPadding_InPadding_PropertyAddress, SetPadding_FunctionAddress, "InPadding");
		SetPadding_InPadding_Offset = NativeReflectionCached.GetPropertyOffset(SetPadding_FunctionAddress, "InPadding");
		SetPadding_InPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPadding_FunctionAddress, "InPadding", Classes.FStructProperty);
		SetPadding_IsValid = SetPadding_FunctionAddress != IntPtr.Zero && SetPadding_InPadding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WrapBoxSlot:SetPadding", SetPadding_IsValid);
		SetNewLine_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNewLine");
		SetNewLine_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNewLine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNewLine_InForceNewLine_PropertyAddress, SetNewLine_FunctionAddress, "InForceNewLine");
		SetNewLine_InForceNewLine_Offset = NativeReflectionCached.GetPropertyOffset(SetNewLine_FunctionAddress, "InForceNewLine");
		SetNewLine_InForceNewLine_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNewLine_FunctionAddress, "InForceNewLine", Classes.FBoolProperty);
		SetNewLine_IsValid = SetNewLine_FunctionAddress != IntPtr.Zero && SetNewLine_InForceNewLine_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WrapBoxSlot:SetNewLine", SetNewLine_IsValid);
		SetHorizontalAlignment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHorizontalAlignment");
		SetHorizontalAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHorizontalAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress, SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment");
		SetHorizontalAlignment_InHorizontalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment");
		SetHorizontalAlignment_InHorizontalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment", Classes.FByteProperty);
		SetHorizontalAlignment_IsValid = SetHorizontalAlignment_FunctionAddress != IntPtr.Zero && SetHorizontalAlignment_InHorizontalAlignment_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WrapBoxSlot:SetHorizontalAlignment", SetHorizontalAlignment_IsValid);
		SetFillSpanWhenLessThan_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFillSpanWhenLessThan");
		SetFillSpanWhenLessThan_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFillSpanWhenLessThan_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFillSpanWhenLessThan_InFillSpanWhenLessThan_PropertyAddress, SetFillSpanWhenLessThan_FunctionAddress, "InFillSpanWhenLessThan");
		SetFillSpanWhenLessThan_InFillSpanWhenLessThan_Offset = NativeReflectionCached.GetPropertyOffset(SetFillSpanWhenLessThan_FunctionAddress, "InFillSpanWhenLessThan");
		SetFillSpanWhenLessThan_InFillSpanWhenLessThan_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFillSpanWhenLessThan_FunctionAddress, "InFillSpanWhenLessThan", Classes.FFloatProperty);
		SetFillSpanWhenLessThan_IsValid = SetFillSpanWhenLessThan_FunctionAddress != IntPtr.Zero && SetFillSpanWhenLessThan_InFillSpanWhenLessThan_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WrapBoxSlot:SetFillSpanWhenLessThan", SetFillSpanWhenLessThan_IsValid);
		SetFillEmptySpace_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFillEmptySpace");
		SetFillEmptySpace_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFillEmptySpace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFillEmptySpace_InbFillEmptySpace_PropertyAddress, SetFillEmptySpace_FunctionAddress, "InbFillEmptySpace");
		SetFillEmptySpace_InbFillEmptySpace_Offset = NativeReflectionCached.GetPropertyOffset(SetFillEmptySpace_FunctionAddress, "InbFillEmptySpace");
		SetFillEmptySpace_InbFillEmptySpace_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFillEmptySpace_FunctionAddress, "InbFillEmptySpace", Classes.FBoolProperty);
		SetFillEmptySpace_IsValid = SetFillEmptySpace_FunctionAddress != IntPtr.Zero && SetFillEmptySpace_InbFillEmptySpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WrapBoxSlot:SetFillEmptySpace", SetFillEmptySpace_IsValid);
	}
}
