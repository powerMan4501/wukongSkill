using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UMG.UniformGridSlot", "UMG", UnrealModuleType.Engine)]
public class UUniformGridSlot : UPanelSlot
{
	private static bool HorizontalAlignment_IsValid;

	private static FFieldAddress HorizontalAlignment_PropertyAddress;

	private static int HorizontalAlignment_Offset;

	private static bool VerticalAlignment_IsValid;

	private static FFieldAddress VerticalAlignment_PropertyAddress;

	private static int VerticalAlignment_Offset;

	private static bool Row_IsValid;

	private static int Row_Offset;

	private static bool Column_IsValid;

	private static int Column_Offset;

	private static bool SetVerticalAlignment_IsValid;

	private static IntPtr SetVerticalAlignment_FunctionAddress;

	private static int SetVerticalAlignment_ParamsSize;

	private static bool SetVerticalAlignment_InVerticalAlignment_IsValid;

	private static FFieldAddress SetVerticalAlignment_InVerticalAlignment_PropertyAddress;

	private static int SetVerticalAlignment_InVerticalAlignment_Offset;

	private static bool SetRow_IsValid;

	private static IntPtr SetRow_FunctionAddress;

	private static int SetRow_ParamsSize;

	private static bool SetRow_InRow_IsValid;

	private static FFieldAddress SetRow_InRow_PropertyAddress;

	private static int SetRow_InRow_Offset;

	private static bool SetHorizontalAlignment_IsValid;

	private static IntPtr SetHorizontalAlignment_FunctionAddress;

	private static int SetHorizontalAlignment_ParamsSize;

	private static bool SetHorizontalAlignment_InHorizontalAlignment_IsValid;

	private static FFieldAddress SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress;

	private static int SetHorizontalAlignment_InHorizontalAlignment_Offset;

	private static bool SetColumn_IsValid;

	private static IntPtr SetColumn_FunctionAddress;

	private static int SetColumn_ParamsSize;

	private static bool SetColumn_InColumn_IsValid;

	private static FFieldAddress SetColumn_InColumn_PropertyAddress;

	private static int SetColumn_InColumn_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.UniformGridSlot:HorizontalAlignment")]
	public EHorizontalAlignment HorizontalAlignment
	{
		get
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UniformGridSlot:HorizontalAlignment");
				return EHorizontalAlignment.HAlign_Fill;
			}
			return EnumMarshaler<EHorizontalAlignment>.FromNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UniformGridSlot:HorizontalAlignment");
			}
			else
			{
				EnumMarshaler<EHorizontalAlignment>.ToNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.UniformGridSlot:VerticalAlignment")]
	public EVerticalAlignment VerticalAlignment
	{
		get
		{
			CheckDestroyed();
			if (!VerticalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UniformGridSlot:VerticalAlignment");
				return EVerticalAlignment.VAlign_Fill;
			}
			return EnumMarshaler<EVerticalAlignment>.FromNative(IntPtr.Add(base.Address, VerticalAlignment_Offset), 0, VerticalAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VerticalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UniformGridSlot:VerticalAlignment");
			}
			else
			{
				EnumMarshaler<EVerticalAlignment>.ToNative(IntPtr.Add(base.Address, VerticalAlignment_Offset), 0, VerticalAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.UniformGridSlot:Row")]
	public int Row
	{
		get
		{
			CheckDestroyed();
			if (!Row_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UniformGridSlot:Row");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Row_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Row_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UniformGridSlot:Row");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Row_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.UniformGridSlot:Column")]
	public int Column
	{
		get
		{
			CheckDestroyed();
			if (!Column_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UniformGridSlot:Column");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Column_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Column_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UniformGridSlot:Column");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Column_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.UniformGridSlot:SetVerticalAlignment")]
	public unsafe void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
	{
		CheckDestroyed();
		if (!SetVerticalAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UniformGridSlot:SetVerticalAlignment");
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
	[UMetaPath("/Script/UMG.UniformGridSlot:SetRow")]
	public unsafe void SetRow(int InRow)
	{
		CheckDestroyed();
		if (!SetRow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UniformGridSlot:SetRow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetRow_InRow_Offset), 0, SetRow_InRow_PropertyAddress.Address, InRow);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRow_FunctionAddress, intPtr, SetRow_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.UniformGridSlot:SetHorizontalAlignment")]
	public unsafe void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
	{
		CheckDestroyed();
		if (!SetHorizontalAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UniformGridSlot:SetHorizontalAlignment");
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
	[UMetaPath("/Script/UMG.UniformGridSlot:SetColumn")]
	public unsafe void SetColumn(int InColumn)
	{
		CheckDestroyed();
		if (!SetColumn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UniformGridSlot:SetColumn");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetColumn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetColumn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetColumn_InColumn_Offset), 0, SetColumn_InColumn_PropertyAddress.Address, InColumn);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetColumn_FunctionAddress, intPtr, SetColumn_ParamsSize);
	}

	static UUniformGridSlot()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UUniformGridSlot)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UUniformGridSlot));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.UniformGridSlot");
		NativeReflectionCached.GetPropertyRef(ref HorizontalAlignment_PropertyAddress, intPtr, "HorizontalAlignment");
		HorizontalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HorizontalAlignment");
		HorizontalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HorizontalAlignment", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref VerticalAlignment_PropertyAddress, intPtr, "VerticalAlignment");
		VerticalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VerticalAlignment");
		VerticalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VerticalAlignment", Classes.FByteProperty);
		Row_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Row");
		Row_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Row", Classes.FIntProperty);
		Column_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Column");
		Column_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Column", Classes.FIntProperty);
		SetVerticalAlignment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVerticalAlignment");
		SetVerticalAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVerticalAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVerticalAlignment_InVerticalAlignment_PropertyAddress, SetVerticalAlignment_FunctionAddress, "InVerticalAlignment");
		SetVerticalAlignment_InVerticalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(SetVerticalAlignment_FunctionAddress, "InVerticalAlignment");
		SetVerticalAlignment_InVerticalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVerticalAlignment_FunctionAddress, "InVerticalAlignment", Classes.FByteProperty);
		SetVerticalAlignment_IsValid = SetVerticalAlignment_FunctionAddress != IntPtr.Zero && SetVerticalAlignment_InVerticalAlignment_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UniformGridSlot:SetVerticalAlignment", SetVerticalAlignment_IsValid);
		SetRow_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRow");
		SetRow_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRow_InRow_PropertyAddress, SetRow_FunctionAddress, "InRow");
		SetRow_InRow_Offset = NativeReflectionCached.GetPropertyOffset(SetRow_FunctionAddress, "InRow");
		SetRow_InRow_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRow_FunctionAddress, "InRow", Classes.FIntProperty);
		SetRow_IsValid = SetRow_FunctionAddress != IntPtr.Zero && SetRow_InRow_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UniformGridSlot:SetRow", SetRow_IsValid);
		SetHorizontalAlignment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHorizontalAlignment");
		SetHorizontalAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHorizontalAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress, SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment");
		SetHorizontalAlignment_InHorizontalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment");
		SetHorizontalAlignment_InHorizontalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment", Classes.FByteProperty);
		SetHorizontalAlignment_IsValid = SetHorizontalAlignment_FunctionAddress != IntPtr.Zero && SetHorizontalAlignment_InHorizontalAlignment_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UniformGridSlot:SetHorizontalAlignment", SetHorizontalAlignment_IsValid);
		SetColumn_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetColumn");
		SetColumn_ParamsSize = NativeReflection.GetFunctionParamsSize(SetColumn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetColumn_InColumn_PropertyAddress, SetColumn_FunctionAddress, "InColumn");
		SetColumn_InColumn_Offset = NativeReflectionCached.GetPropertyOffset(SetColumn_FunctionAddress, "InColumn");
		SetColumn_InColumn_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColumn_FunctionAddress, "InColumn", Classes.FIntProperty);
		SetColumn_IsValid = SetColumn_FunctionAddress != IntPtr.Zero && SetColumn_InColumn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UniformGridSlot:SetColumn", SetColumn_IsValid);
	}
}
