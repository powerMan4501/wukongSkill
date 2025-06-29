using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.GridPanel", "UMG", UnrealModuleType.Engine)]
public class UGridPanel : UPanelWidget
{
	private static bool ColumnFill_IsValid;

	private static FFieldAddress ColumnFill_PropertyAddress;

	private static int ColumnFill_Offset;

	private TArrayReadOnlyMarshaler<float> ColumnFill_MarshalerCached;

	private static bool RowFill_IsValid;

	private static FFieldAddress RowFill_PropertyAddress;

	private static int RowFill_Offset;

	private TArrayReadOnlyMarshaler<float> RowFill_MarshalerCached;

	private static bool SetRowFill_IsValid;

	private static IntPtr SetRowFill_FunctionAddress;

	private static int SetRowFill_ParamsSize;

	private static bool SetRowFill_ColumnIndex_IsValid;

	private static FFieldAddress SetRowFill_ColumnIndex_PropertyAddress;

	private static int SetRowFill_ColumnIndex_Offset;

	private static bool SetRowFill_Coefficient_IsValid;

	private static FFieldAddress SetRowFill_Coefficient_PropertyAddress;

	private static int SetRowFill_Coefficient_Offset;

	private static bool SetColumnFill_IsValid;

	private static IntPtr SetColumnFill_FunctionAddress;

	private static int SetColumnFill_ParamsSize;

	private static bool SetColumnFill_ColumnIndex_IsValid;

	private static FFieldAddress SetColumnFill_ColumnIndex_PropertyAddress;

	private static int SetColumnFill_ColumnIndex_Offset;

	private static bool SetColumnFill_Coefficient_IsValid;

	private static FFieldAddress SetColumnFill_Coefficient_PropertyAddress;

	private static int SetColumnFill_Coefficient_Offset;

	private static bool AddChildToGrid_IsValid;

	private static IntPtr AddChildToGrid_FunctionAddress;

	private static int AddChildToGrid_ParamsSize;

	private static bool AddChildToGrid_Content_IsValid;

	private static FFieldAddress AddChildToGrid_Content_PropertyAddress;

	private static int AddChildToGrid_Content_Offset;

	private static bool AddChildToGrid_InRow_IsValid;

	private static FFieldAddress AddChildToGrid_InRow_PropertyAddress;

	private static int AddChildToGrid_InRow_Offset;

	private static bool AddChildToGrid_InColumn_IsValid;

	private static FFieldAddress AddChildToGrid_InColumn_PropertyAddress;

	private static int AddChildToGrid_InColumn_Offset;

	private static bool AddChildToGrid_ReturnValue_IsValid;

	private static FFieldAddress AddChildToGrid_ReturnValue_PropertyAddress;

	private static int AddChildToGrid_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/UMG.GridPanel:ColumnFill")]
	public TArrayReadOnly<float> ColumnFill
	{
		get
		{
			CheckDestroyed();
			if (!ColumnFill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.GridPanel:ColumnFill");
				return null;
			}
			if (ColumnFill_MarshalerCached == null)
			{
				ColumnFill_MarshalerCached = new TArrayReadOnlyMarshaler<float>(1, ColumnFill_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return ColumnFill_MarshalerCached.FromNative(IntPtr.Add(base.Address, ColumnFill_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/UMG.GridPanel:RowFill")]
	public TArrayReadOnly<float> RowFill
	{
		get
		{
			CheckDestroyed();
			if (!RowFill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.GridPanel:RowFill");
				return null;
			}
			if (RowFill_MarshalerCached == null)
			{
				RowFill_MarshalerCached = new TArrayReadOnlyMarshaler<float>(1, RowFill_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return RowFill_MarshalerCached.FromNative(IntPtr.Add(base.Address, RowFill_Offset));
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.GridPanel:SetRowFill")]
	public unsafe void SetRowFill(int ColumnIndex, float Coefficient)
	{
		CheckDestroyed();
		if (!SetRowFill_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.GridPanel:SetRowFill");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRowFill_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRowFill_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetRowFill_ColumnIndex_Offset), 0, SetRowFill_ColumnIndex_PropertyAddress.Address, ColumnIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRowFill_Coefficient_Offset), 0, SetRowFill_Coefficient_PropertyAddress.Address, Coefficient);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRowFill_FunctionAddress, intPtr, SetRowFill_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.GridPanel:SetColumnFill")]
	public unsafe void SetColumnFill(int ColumnIndex, float Coefficient)
	{
		CheckDestroyed();
		if (!SetColumnFill_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.GridPanel:SetColumnFill");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetColumnFill_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetColumnFill_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetColumnFill_ColumnIndex_Offset), 0, SetColumnFill_ColumnIndex_PropertyAddress.Address, ColumnIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetColumnFill_Coefficient_Offset), 0, SetColumnFill_Coefficient_PropertyAddress.Address, Coefficient);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetColumnFill_FunctionAddress, intPtr, SetColumnFill_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.GridPanel:AddChildToGrid")]
	public unsafe UGridSlot AddChildToGrid(UWidget Content, int InRow = 0, int InColumn = 0)
	{
		CheckDestroyed();
		if (!AddChildToGrid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.GridPanel:AddChildToGrid");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddChildToGrid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddChildToGrid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, AddChildToGrid_Content_Offset), 0, AddChildToGrid_Content_PropertyAddress.Address, Content);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddChildToGrid_InRow_Offset), 0, AddChildToGrid_InRow_PropertyAddress.Address, InRow);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddChildToGrid_InColumn_Offset), 0, AddChildToGrid_InColumn_PropertyAddress.Address, InColumn);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddChildToGrid_FunctionAddress, intPtr, AddChildToGrid_ParamsSize);
		return UObjectMarshaler<UGridSlot>.FromNative(IntPtr.Add(intPtr, AddChildToGrid_ReturnValue_Offset), 0, AddChildToGrid_ReturnValue_PropertyAddress.Address);
	}

	static UGridPanel()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGridPanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGridPanel));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.GridPanel");
		NativeReflectionCached.GetPropertyRef(ref ColumnFill_PropertyAddress, intPtr, "ColumnFill");
		ColumnFill_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ColumnFill");
		ColumnFill_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ColumnFill", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RowFill_PropertyAddress, intPtr, "RowFill");
		RowFill_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RowFill");
		RowFill_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RowFill", Classes.FArrayProperty);
		SetRowFill_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRowFill");
		SetRowFill_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRowFill_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRowFill_ColumnIndex_PropertyAddress, SetRowFill_FunctionAddress, "ColumnIndex");
		SetRowFill_ColumnIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetRowFill_FunctionAddress, "ColumnIndex");
		SetRowFill_ColumnIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRowFill_FunctionAddress, "ColumnIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRowFill_Coefficient_PropertyAddress, SetRowFill_FunctionAddress, "Coefficient");
		SetRowFill_Coefficient_Offset = NativeReflectionCached.GetPropertyOffset(SetRowFill_FunctionAddress, "Coefficient");
		SetRowFill_Coefficient_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRowFill_FunctionAddress, "Coefficient", Classes.FFloatProperty);
		SetRowFill_IsValid = SetRowFill_FunctionAddress != IntPtr.Zero && SetRowFill_ColumnIndex_IsValid && SetRowFill_Coefficient_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.GridPanel:SetRowFill", SetRowFill_IsValid);
		SetColumnFill_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetColumnFill");
		SetColumnFill_ParamsSize = NativeReflection.GetFunctionParamsSize(SetColumnFill_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetColumnFill_ColumnIndex_PropertyAddress, SetColumnFill_FunctionAddress, "ColumnIndex");
		SetColumnFill_ColumnIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetColumnFill_FunctionAddress, "ColumnIndex");
		SetColumnFill_ColumnIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColumnFill_FunctionAddress, "ColumnIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetColumnFill_Coefficient_PropertyAddress, SetColumnFill_FunctionAddress, "Coefficient");
		SetColumnFill_Coefficient_Offset = NativeReflectionCached.GetPropertyOffset(SetColumnFill_FunctionAddress, "Coefficient");
		SetColumnFill_Coefficient_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColumnFill_FunctionAddress, "Coefficient", Classes.FFloatProperty);
		SetColumnFill_IsValid = SetColumnFill_FunctionAddress != IntPtr.Zero && SetColumnFill_ColumnIndex_IsValid && SetColumnFill_Coefficient_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.GridPanel:SetColumnFill", SetColumnFill_IsValid);
		AddChildToGrid_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddChildToGrid");
		AddChildToGrid_ParamsSize = NativeReflection.GetFunctionParamsSize(AddChildToGrid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddChildToGrid_Content_PropertyAddress, AddChildToGrid_FunctionAddress, "Content");
		AddChildToGrid_Content_Offset = NativeReflectionCached.GetPropertyOffset(AddChildToGrid_FunctionAddress, "Content");
		AddChildToGrid_Content_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildToGrid_FunctionAddress, "Content", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddChildToGrid_InRow_PropertyAddress, AddChildToGrid_FunctionAddress, "InRow");
		AddChildToGrid_InRow_Offset = NativeReflectionCached.GetPropertyOffset(AddChildToGrid_FunctionAddress, "InRow");
		AddChildToGrid_InRow_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildToGrid_FunctionAddress, "InRow", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddChildToGrid_InColumn_PropertyAddress, AddChildToGrid_FunctionAddress, "InColumn");
		AddChildToGrid_InColumn_Offset = NativeReflectionCached.GetPropertyOffset(AddChildToGrid_FunctionAddress, "InColumn");
		AddChildToGrid_InColumn_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildToGrid_FunctionAddress, "InColumn", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddChildToGrid_ReturnValue_PropertyAddress, AddChildToGrid_FunctionAddress, "ReturnValue");
		AddChildToGrid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddChildToGrid_FunctionAddress, "ReturnValue");
		AddChildToGrid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildToGrid_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddChildToGrid_IsValid = AddChildToGrid_FunctionAddress != IntPtr.Zero && AddChildToGrid_Content_IsValid && AddChildToGrid_InRow_IsValid && AddChildToGrid_InColumn_IsValid && AddChildToGrid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.GridPanel:AddChildToGrid", AddChildToGrid_IsValid);
	}
}
