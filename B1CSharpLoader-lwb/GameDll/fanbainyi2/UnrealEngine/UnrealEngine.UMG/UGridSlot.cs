using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UMG.GridSlot", "UMG", UnrealModuleType.Engine)]
public class UGridSlot : UPanelSlot
{
	private static bool Padding_IsValid;

	private static int Padding_Offset;

	private static bool HorizontalAlignment_IsValid;

	private static FFieldAddress HorizontalAlignment_PropertyAddress;

	private static int HorizontalAlignment_Offset;

	private static bool VerticalAlignment_IsValid;

	private static FFieldAddress VerticalAlignment_PropertyAddress;

	private static int VerticalAlignment_Offset;

	private static bool Row_IsValid;

	private static int Row_Offset;

	private static bool RowSpan_IsValid;

	private static int RowSpan_Offset;

	private static bool Column_IsValid;

	private static int Column_Offset;

	private static bool ColumnSpan_IsValid;

	private static int ColumnSpan_Offset;

	private static bool Layer_IsValid;

	private static int Layer_Offset;

	private static bool Nudge_IsValid;

	private static int Nudge_Offset;

	private static bool SetVerticalAlignment_IsValid;

	private static IntPtr SetVerticalAlignment_FunctionAddress;

	private static int SetVerticalAlignment_ParamsSize;

	private static bool SetVerticalAlignment_InVerticalAlignment_IsValid;

	private static FFieldAddress SetVerticalAlignment_InVerticalAlignment_PropertyAddress;

	private static int SetVerticalAlignment_InVerticalAlignment_Offset;

	private static bool SetRowSpan_IsValid;

	private static IntPtr SetRowSpan_FunctionAddress;

	private static int SetRowSpan_ParamsSize;

	private static bool SetRowSpan_InRowSpan_IsValid;

	private static FFieldAddress SetRowSpan_InRowSpan_PropertyAddress;

	private static int SetRowSpan_InRowSpan_Offset;

	private static bool SetRow_IsValid;

	private static IntPtr SetRow_FunctionAddress;

	private static int SetRow_ParamsSize;

	private static bool SetRow_InRow_IsValid;

	private static FFieldAddress SetRow_InRow_PropertyAddress;

	private static int SetRow_InRow_Offset;

	private static bool SetPadding_IsValid;

	private static IntPtr SetPadding_FunctionAddress;

	private static int SetPadding_ParamsSize;

	private static bool SetPadding_InPadding_IsValid;

	private static FFieldAddress SetPadding_InPadding_PropertyAddress;

	private static int SetPadding_InPadding_Offset;

	private static bool SetNudge_IsValid;

	private static IntPtr SetNudge_FunctionAddress;

	private static int SetNudge_ParamsSize;

	private static bool SetNudge_InNudge_IsValid;

	private static FFieldAddress SetNudge_InNudge_PropertyAddress;

	private static int SetNudge_InNudge_Offset;

	private static bool SetLayer_IsValid;

	private static IntPtr SetLayer_FunctionAddress;

	private static int SetLayer_ParamsSize;

	private static bool SetLayer_InLayer_IsValid;

	private static FFieldAddress SetLayer_InLayer_PropertyAddress;

	private static int SetLayer_InLayer_Offset;

	private static bool SetHorizontalAlignment_IsValid;

	private static IntPtr SetHorizontalAlignment_FunctionAddress;

	private static int SetHorizontalAlignment_ParamsSize;

	private static bool SetHorizontalAlignment_InHorizontalAlignment_IsValid;

	private static FFieldAddress SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress;

	private static int SetHorizontalAlignment_InHorizontalAlignment_Offset;

	private static bool SetColumnSpan_IsValid;

	private static IntPtr SetColumnSpan_FunctionAddress;

	private static int SetColumnSpan_ParamsSize;

	private static bool SetColumnSpan_InColumnSpan_IsValid;

	private static FFieldAddress SetColumnSpan_InColumnSpan_PropertyAddress;

	private static int SetColumnSpan_InColumnSpan_Offset;

	private static bool SetColumn_IsValid;

	private static IntPtr SetColumn_FunctionAddress;

	private static int SetColumn_ParamsSize;

	private static bool SetColumn_InColumn_IsValid;

	private static FFieldAddress SetColumn_InColumn_PropertyAddress;

	private static int SetColumn_InColumn_Offset;

	[UProperty(Flags = (PropFlags)4503669420589589uL)]
	[UMetaPath("/Script/UMG.GridSlot:Padding")]
	public FMargin Padding
	{
		get
		{
			CheckDestroyed();
			if (!Padding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.GridSlot:Padding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, Padding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Padding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.GridSlot:Padding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, Padding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.GridSlot:HorizontalAlignment")]
	public EHorizontalAlignment HorizontalAlignment
	{
		get
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.GridSlot:HorizontalAlignment");
				return EHorizontalAlignment.HAlign_Fill;
			}
			return EnumMarshaler<EHorizontalAlignment>.FromNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.GridSlot:HorizontalAlignment");
			}
			else
			{
				EnumMarshaler<EHorizontalAlignment>.ToNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.GridSlot:VerticalAlignment")]
	public EVerticalAlignment VerticalAlignment
	{
		get
		{
			CheckDestroyed();
			if (!VerticalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.GridSlot:VerticalAlignment");
				return EVerticalAlignment.VAlign_Fill;
			}
			return EnumMarshaler<EVerticalAlignment>.FromNative(IntPtr.Add(base.Address, VerticalAlignment_Offset), 0, VerticalAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VerticalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.GridSlot:VerticalAlignment");
			}
			else
			{
				EnumMarshaler<EVerticalAlignment>.ToNative(IntPtr.Add(base.Address, VerticalAlignment_Offset), 0, VerticalAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.GridSlot:Row")]
	public int Row
	{
		get
		{
			CheckDestroyed();
			if (!Row_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.GridSlot:Row");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Row_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Row_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.GridSlot:Row");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Row_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.GridSlot:RowSpan")]
	public int RowSpan
	{
		get
		{
			CheckDestroyed();
			if (!RowSpan_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.GridSlot:RowSpan");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RowSpan_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RowSpan_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.GridSlot:RowSpan");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RowSpan_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.GridSlot:Column")]
	public int Column
	{
		get
		{
			CheckDestroyed();
			if (!Column_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.GridSlot:Column");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Column_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Column_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.GridSlot:Column");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Column_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.GridSlot:ColumnSpan")]
	public int ColumnSpan
	{
		get
		{
			CheckDestroyed();
			if (!ColumnSpan_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.GridSlot:ColumnSpan");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ColumnSpan_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ColumnSpan_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.GridSlot:ColumnSpan");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ColumnSpan_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.GridSlot:Layer")]
	public int Layer
	{
		get
		{
			CheckDestroyed();
			if (!Layer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.GridSlot:Layer");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Layer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Layer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.GridSlot:Layer");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Layer_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.GridSlot:Nudge")]
	public FVector2D Nudge
	{
		get
		{
			CheckDestroyed();
			if (!Nudge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.GridSlot:Nudge");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, Nudge_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Nudge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.GridSlot:Nudge");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, Nudge_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.GridSlot:SetVerticalAlignment")]
	public unsafe void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
	{
		CheckDestroyed();
		if (!SetVerticalAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.GridSlot:SetVerticalAlignment");
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
	[UMetaPath("/Script/UMG.GridSlot:SetRowSpan")]
	public unsafe void SetRowSpan(int InRowSpan)
	{
		CheckDestroyed();
		if (!SetRowSpan_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.GridSlot:SetRowSpan");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRowSpan_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRowSpan_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetRowSpan_InRowSpan_Offset), 0, SetRowSpan_InRowSpan_PropertyAddress.Address, InRowSpan);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRowSpan_FunctionAddress, intPtr, SetRowSpan_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.GridSlot:SetRow")]
	public unsafe void SetRow(int InRow)
	{
		CheckDestroyed();
		if (!SetRow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.GridSlot:SetRow");
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
	[UMetaPath("/Script/UMG.GridSlot:SetPadding")]
	public unsafe void SetPadding(FMargin InPadding)
	{
		CheckDestroyed();
		if (!SetPadding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.GridSlot:SetPadding");
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

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.GridSlot:SetNudge")]
	public unsafe void SetNudge(FVector2D InNudge)
	{
		CheckDestroyed();
		if (!SetNudge_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.GridSlot:SetNudge");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNudge_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNudge_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetNudge_InNudge_Offset), 0, SetNudge_InNudge_PropertyAddress.Address, InNudge);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNudge_FunctionAddress, intPtr, SetNudge_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.GridSlot:SetLayer")]
	public unsafe void SetLayer(int InLayer)
	{
		CheckDestroyed();
		if (!SetLayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.GridSlot:SetLayer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLayer_InLayer_Offset), 0, SetLayer_InLayer_PropertyAddress.Address, InLayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLayer_FunctionAddress, intPtr, SetLayer_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.GridSlot:SetHorizontalAlignment")]
	public unsafe void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
	{
		CheckDestroyed();
		if (!SetHorizontalAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.GridSlot:SetHorizontalAlignment");
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
	[UMetaPath("/Script/UMG.GridSlot:SetColumnSpan")]
	public unsafe void SetColumnSpan(int InColumnSpan)
	{
		CheckDestroyed();
		if (!SetColumnSpan_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.GridSlot:SetColumnSpan");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetColumnSpan_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetColumnSpan_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetColumnSpan_InColumnSpan_Offset), 0, SetColumnSpan_InColumnSpan_PropertyAddress.Address, InColumnSpan);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetColumnSpan_FunctionAddress, intPtr, SetColumnSpan_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.GridSlot:SetColumn")]
	public unsafe void SetColumn(int InColumn)
	{
		CheckDestroyed();
		if (!SetColumn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.GridSlot:SetColumn");
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

	static UGridSlot()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGridSlot)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGridSlot));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.GridSlot");
		Padding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Padding");
		Padding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Padding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HorizontalAlignment_PropertyAddress, intPtr, "HorizontalAlignment");
		HorizontalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HorizontalAlignment");
		HorizontalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HorizontalAlignment", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref VerticalAlignment_PropertyAddress, intPtr, "VerticalAlignment");
		VerticalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VerticalAlignment");
		VerticalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VerticalAlignment", Classes.FByteProperty);
		Row_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Row");
		Row_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Row", Classes.FIntProperty);
		RowSpan_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RowSpan");
		RowSpan_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RowSpan", Classes.FIntProperty);
		Column_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Column");
		Column_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Column", Classes.FIntProperty);
		ColumnSpan_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ColumnSpan");
		ColumnSpan_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ColumnSpan", Classes.FIntProperty);
		Layer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Layer");
		Layer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Layer", Classes.FIntProperty);
		Nudge_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Nudge");
		Nudge_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Nudge", Classes.FStructProperty);
		SetVerticalAlignment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVerticalAlignment");
		SetVerticalAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVerticalAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVerticalAlignment_InVerticalAlignment_PropertyAddress, SetVerticalAlignment_FunctionAddress, "InVerticalAlignment");
		SetVerticalAlignment_InVerticalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(SetVerticalAlignment_FunctionAddress, "InVerticalAlignment");
		SetVerticalAlignment_InVerticalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVerticalAlignment_FunctionAddress, "InVerticalAlignment", Classes.FByteProperty);
		SetVerticalAlignment_IsValid = SetVerticalAlignment_FunctionAddress != IntPtr.Zero && SetVerticalAlignment_InVerticalAlignment_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.GridSlot:SetVerticalAlignment", SetVerticalAlignment_IsValid);
		SetRowSpan_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRowSpan");
		SetRowSpan_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRowSpan_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRowSpan_InRowSpan_PropertyAddress, SetRowSpan_FunctionAddress, "InRowSpan");
		SetRowSpan_InRowSpan_Offset = NativeReflectionCached.GetPropertyOffset(SetRowSpan_FunctionAddress, "InRowSpan");
		SetRowSpan_InRowSpan_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRowSpan_FunctionAddress, "InRowSpan", Classes.FIntProperty);
		SetRowSpan_IsValid = SetRowSpan_FunctionAddress != IntPtr.Zero && SetRowSpan_InRowSpan_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.GridSlot:SetRowSpan", SetRowSpan_IsValid);
		SetRow_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRow");
		SetRow_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRow_InRow_PropertyAddress, SetRow_FunctionAddress, "InRow");
		SetRow_InRow_Offset = NativeReflectionCached.GetPropertyOffset(SetRow_FunctionAddress, "InRow");
		SetRow_InRow_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRow_FunctionAddress, "InRow", Classes.FIntProperty);
		SetRow_IsValid = SetRow_FunctionAddress != IntPtr.Zero && SetRow_InRow_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.GridSlot:SetRow", SetRow_IsValid);
		SetPadding_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPadding");
		SetPadding_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPadding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPadding_InPadding_PropertyAddress, SetPadding_FunctionAddress, "InPadding");
		SetPadding_InPadding_Offset = NativeReflectionCached.GetPropertyOffset(SetPadding_FunctionAddress, "InPadding");
		SetPadding_InPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPadding_FunctionAddress, "InPadding", Classes.FStructProperty);
		SetPadding_IsValid = SetPadding_FunctionAddress != IntPtr.Zero && SetPadding_InPadding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.GridSlot:SetPadding", SetPadding_IsValid);
		SetNudge_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNudge");
		SetNudge_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNudge_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNudge_InNudge_PropertyAddress, SetNudge_FunctionAddress, "InNudge");
		SetNudge_InNudge_Offset = NativeReflectionCached.GetPropertyOffset(SetNudge_FunctionAddress, "InNudge");
		SetNudge_InNudge_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNudge_FunctionAddress, "InNudge", Classes.FStructProperty);
		SetNudge_IsValid = SetNudge_FunctionAddress != IntPtr.Zero && SetNudge_InNudge_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.GridSlot:SetNudge", SetNudge_IsValid);
		SetLayer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLayer");
		SetLayer_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLayer_InLayer_PropertyAddress, SetLayer_FunctionAddress, "InLayer");
		SetLayer_InLayer_Offset = NativeReflectionCached.GetPropertyOffset(SetLayer_FunctionAddress, "InLayer");
		SetLayer_InLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLayer_FunctionAddress, "InLayer", Classes.FIntProperty);
		SetLayer_IsValid = SetLayer_FunctionAddress != IntPtr.Zero && SetLayer_InLayer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.GridSlot:SetLayer", SetLayer_IsValid);
		SetHorizontalAlignment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHorizontalAlignment");
		SetHorizontalAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHorizontalAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress, SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment");
		SetHorizontalAlignment_InHorizontalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment");
		SetHorizontalAlignment_InHorizontalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment", Classes.FByteProperty);
		SetHorizontalAlignment_IsValid = SetHorizontalAlignment_FunctionAddress != IntPtr.Zero && SetHorizontalAlignment_InHorizontalAlignment_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.GridSlot:SetHorizontalAlignment", SetHorizontalAlignment_IsValid);
		SetColumnSpan_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetColumnSpan");
		SetColumnSpan_ParamsSize = NativeReflection.GetFunctionParamsSize(SetColumnSpan_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetColumnSpan_InColumnSpan_PropertyAddress, SetColumnSpan_FunctionAddress, "InColumnSpan");
		SetColumnSpan_InColumnSpan_Offset = NativeReflectionCached.GetPropertyOffset(SetColumnSpan_FunctionAddress, "InColumnSpan");
		SetColumnSpan_InColumnSpan_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColumnSpan_FunctionAddress, "InColumnSpan", Classes.FIntProperty);
		SetColumnSpan_IsValid = SetColumnSpan_FunctionAddress != IntPtr.Zero && SetColumnSpan_InColumnSpan_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.GridSlot:SetColumnSpan", SetColumnSpan_IsValid);
		SetColumn_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetColumn");
		SetColumn_ParamsSize = NativeReflection.GetFunctionParamsSize(SetColumn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetColumn_InColumn_PropertyAddress, SetColumn_FunctionAddress, "InColumn");
		SetColumn_InColumn_Offset = NativeReflectionCached.GetPropertyOffset(SetColumn_FunctionAddress, "InColumn");
		SetColumn_InColumn_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColumn_FunctionAddress, "InColumn", Classes.FIntProperty);
		SetColumn_IsValid = SetColumn_FunctionAddress != IntPtr.Zero && SetColumn_InColumn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.GridSlot:SetColumn", SetColumn_IsValid);
	}
}
