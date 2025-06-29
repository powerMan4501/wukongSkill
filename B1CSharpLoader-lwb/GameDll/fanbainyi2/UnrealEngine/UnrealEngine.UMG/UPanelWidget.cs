using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[Abstract]
[UClass(Flags = (ClassFlags)821035169uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.PanelWidget", "UMG", UnrealModuleType.Engine)]
public class UPanelWidget : UWidget
{
	private static bool RemoveChildAt_IsValid;

	private static IntPtr RemoveChildAt_FunctionAddress;

	private static int RemoveChildAt_ParamsSize;

	private static bool RemoveChildAt_Index_IsValid;

	private static FFieldAddress RemoveChildAt_Index_PropertyAddress;

	private static int RemoveChildAt_Index_Offset;

	private static bool RemoveChildAt_ReturnValue_IsValid;

	private static FFieldAddress RemoveChildAt_ReturnValue_PropertyAddress;

	private static int RemoveChildAt_ReturnValue_Offset;

	private static bool RemoveChild_IsValid;

	private static IntPtr RemoveChild_FunctionAddress;

	private static int RemoveChild_ParamsSize;

	private static bool RemoveChild_Content_IsValid;

	private static FFieldAddress RemoveChild_Content_PropertyAddress;

	private static int RemoveChild_Content_Offset;

	private static bool RemoveChild_ReturnValue_IsValid;

	private static FFieldAddress RemoveChild_ReturnValue_PropertyAddress;

	private static int RemoveChild_ReturnValue_Offset;

	private static bool HasChild_IsValid;

	private static IntPtr HasChild_FunctionAddress;

	private static int HasChild_ParamsSize;

	private static bool HasChild_Content_IsValid;

	private static FFieldAddress HasChild_Content_PropertyAddress;

	private static int HasChild_Content_Offset;

	private static bool HasChild_ReturnValue_IsValid;

	private static FFieldAddress HasChild_ReturnValue_PropertyAddress;

	private static int HasChild_ReturnValue_Offset;

	private static bool HasAnyChildren_IsValid;

	private static IntPtr HasAnyChildren_FunctionAddress;

	private static int HasAnyChildren_ParamsSize;

	private static bool HasAnyChildren_ReturnValue_IsValid;

	private static FFieldAddress HasAnyChildren_ReturnValue_PropertyAddress;

	private static int HasAnyChildren_ReturnValue_Offset;

	private static bool GetChildrenCount_IsValid;

	private static IntPtr GetChildrenCount_FunctionAddress;

	private static int GetChildrenCount_ParamsSize;

	private static bool GetChildrenCount_ReturnValue_IsValid;

	private static FFieldAddress GetChildrenCount_ReturnValue_PropertyAddress;

	private static int GetChildrenCount_ReturnValue_Offset;

	private static bool GetChildIndex_IsValid;

	private static IntPtr GetChildIndex_FunctionAddress;

	private static int GetChildIndex_ParamsSize;

	private static bool GetChildIndex_Content_IsValid;

	private static FFieldAddress GetChildIndex_Content_PropertyAddress;

	private static int GetChildIndex_Content_Offset;

	private static bool GetChildIndex_ReturnValue_IsValid;

	private static FFieldAddress GetChildIndex_ReturnValue_PropertyAddress;

	private static int GetChildIndex_ReturnValue_Offset;

	private static bool GetChildAt_IsValid;

	private static IntPtr GetChildAt_FunctionAddress;

	private static int GetChildAt_ParamsSize;

	private static bool GetChildAt_Index_IsValid;

	private static FFieldAddress GetChildAt_Index_PropertyAddress;

	private static int GetChildAt_Index_Offset;

	private static bool GetChildAt_ReturnValue_IsValid;

	private static FFieldAddress GetChildAt_ReturnValue_PropertyAddress;

	private static int GetChildAt_ReturnValue_Offset;

	private static bool GetAllChildren_IsValid;

	private static IntPtr GetAllChildren_FunctionAddress;

	private static int GetAllChildren_ParamsSize;

	private static bool GetAllChildren_ReturnValue_IsValid;

	private static FFieldAddress GetAllChildren_ReturnValue_PropertyAddress;

	private static int GetAllChildren_ReturnValue_Offset;

	private static bool ClearChildren_IsValid;

	private static IntPtr ClearChildren_FunctionAddress;

	private static int ClearChildren_ParamsSize;

	private static bool AddChild_IsValid;

	private static IntPtr AddChild_FunctionAddress;

	private static int AddChild_ParamsSize;

	private static bool AddChild_Content_IsValid;

	private static FFieldAddress AddChild_Content_PropertyAddress;

	private static int AddChild_Content_Offset;

	private static bool AddChild_ReturnValue_IsValid;

	private static FFieldAddress AddChild_ReturnValue_PropertyAddress;

	private static int AddChild_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.PanelWidget:RemoveChildAt")]
	public unsafe bool RemoveChildAt(int Index)
	{
		CheckDestroyed();
		if (!RemoveChildAt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.PanelWidget:RemoveChildAt");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveChildAt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveChildAt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RemoveChildAt_Index_Offset), 0, RemoveChildAt_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveChildAt_FunctionAddress, intPtr, RemoveChildAt_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveChildAt_ReturnValue_Offset), 0, RemoveChildAt_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.PanelWidget:RemoveChild")]
	public unsafe bool RemoveChild(UWidget Content)
	{
		CheckDestroyed();
		if (!RemoveChild_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.PanelWidget:RemoveChild");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveChild_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveChild_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, RemoveChild_Content_Offset), 0, RemoveChild_Content_PropertyAddress.Address, Content);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveChild_FunctionAddress, intPtr, RemoveChild_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveChild_ReturnValue_Offset), 0, RemoveChild_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.PanelWidget:HasChild")]
	public unsafe bool HasChild(UWidget Content)
	{
		CheckDestroyed();
		if (!HasChild_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.PanelWidget:HasChild");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasChild_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasChild_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, HasChild_Content_Offset), 0, HasChild_Content_PropertyAddress.Address, Content);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasChild_FunctionAddress, intPtr, HasChild_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasChild_ReturnValue_Offset), 0, HasChild_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.PanelWidget:HasAnyChildren")]
	public unsafe bool HasAnyChildren()
	{
		CheckDestroyed();
		if (!HasAnyChildren_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.PanelWidget:HasAnyChildren");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasAnyChildren_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasAnyChildren_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasAnyChildren_FunctionAddress, intPtr, HasAnyChildren_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasAnyChildren_ReturnValue_Offset), 0, HasAnyChildren_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.PanelWidget:GetChildrenCount")]
	public unsafe int GetChildrenCount()
	{
		CheckDestroyed();
		if (!GetChildrenCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.PanelWidget:GetChildrenCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChildrenCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChildrenCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetChildrenCount_FunctionAddress, intPtr, GetChildrenCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetChildrenCount_ReturnValue_Offset), 0, GetChildrenCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.PanelWidget:GetChildIndex")]
	public unsafe int GetChildIndex(UWidget Content)
	{
		CheckDestroyed();
		if (!GetChildIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.PanelWidget:GetChildIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChildIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChildIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, GetChildIndex_Content_Offset), 0, GetChildIndex_Content_PropertyAddress.Address, Content);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetChildIndex_FunctionAddress, intPtr, GetChildIndex_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetChildIndex_ReturnValue_Offset), 0, GetChildIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.PanelWidget:GetChildAt")]
	public unsafe UWidget GetChildAt(int Index)
	{
		CheckDestroyed();
		if (!GetChildAt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.PanelWidget:GetChildAt");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChildAt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChildAt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetChildAt_Index_Offset), 0, GetChildAt_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetChildAt_FunctionAddress, intPtr, GetChildAt_ParamsSize);
		return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(intPtr, GetChildAt_ReturnValue_Offset), 0, GetChildAt_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.PanelWidget:GetAllChildren")]
	public unsafe List<UWidget> GetAllChildren()
	{
		CheckDestroyed();
		if (!GetAllChildren_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.PanelWidget:GetAllChildren");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllChildren_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllChildren_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllChildren_FunctionAddress, intPtr, GetAllChildren_ParamsSize);
		List<UWidget> result = new TArrayCopyMarshaler<UWidget>(1, GetAllChildren_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UWidget, UObjectMarshaler<UWidget>>.FromNative, CachedMarshalingDelegates<UWidget, UObjectMarshaler<UWidget>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllChildren_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllChildren_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.PanelWidget:ClearChildren")]
	public unsafe void ClearChildren()
	{
		CheckDestroyed();
		if (!ClearChildren_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.PanelWidget:ClearChildren");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearChildren_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearChildren_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearChildren_FunctionAddress, argsSize: ClearChildren_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.PanelWidget:AddChild")]
	public unsafe UPanelSlot AddChild(UWidget Content)
	{
		CheckDestroyed();
		if (!AddChild_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.PanelWidget:AddChild");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddChild_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddChild_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, AddChild_Content_Offset), 0, AddChild_Content_PropertyAddress.Address, Content);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddChild_FunctionAddress, intPtr, AddChild_ParamsSize);
		return UObjectMarshaler<UPanelSlot>.FromNative(IntPtr.Add(intPtr, AddChild_ReturnValue_Offset), 0, AddChild_ReturnValue_PropertyAddress.Address);
	}

	static UPanelWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPanelWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPanelWidget));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UMG.PanelWidget");
		RemoveChildAt_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveChildAt");
		RemoveChildAt_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveChildAt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveChildAt_Index_PropertyAddress, RemoveChildAt_FunctionAddress, "Index");
		RemoveChildAt_Index_Offset = NativeReflectionCached.GetPropertyOffset(RemoveChildAt_FunctionAddress, "Index");
		RemoveChildAt_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveChildAt_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveChildAt_ReturnValue_PropertyAddress, RemoveChildAt_FunctionAddress, "ReturnValue");
		RemoveChildAt_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveChildAt_FunctionAddress, "ReturnValue");
		RemoveChildAt_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveChildAt_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveChildAt_IsValid = RemoveChildAt_FunctionAddress != IntPtr.Zero && RemoveChildAt_Index_IsValid && RemoveChildAt_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.PanelWidget:RemoveChildAt", RemoveChildAt_IsValid);
		RemoveChild_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveChild");
		RemoveChild_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveChild_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveChild_Content_PropertyAddress, RemoveChild_FunctionAddress, "Content");
		RemoveChild_Content_Offset = NativeReflectionCached.GetPropertyOffset(RemoveChild_FunctionAddress, "Content");
		RemoveChild_Content_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveChild_FunctionAddress, "Content", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveChild_ReturnValue_PropertyAddress, RemoveChild_FunctionAddress, "ReturnValue");
		RemoveChild_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveChild_FunctionAddress, "ReturnValue");
		RemoveChild_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveChild_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveChild_IsValid = RemoveChild_FunctionAddress != IntPtr.Zero && RemoveChild_Content_IsValid && RemoveChild_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.PanelWidget:RemoveChild", RemoveChild_IsValid);
		HasChild_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasChild");
		HasChild_ParamsSize = NativeReflection.GetFunctionParamsSize(HasChild_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasChild_Content_PropertyAddress, HasChild_FunctionAddress, "Content");
		HasChild_Content_Offset = NativeReflectionCached.GetPropertyOffset(HasChild_FunctionAddress, "Content");
		HasChild_Content_IsValid = NativeReflectionCached.ValidatePropertyClass(HasChild_FunctionAddress, "Content", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref HasChild_ReturnValue_PropertyAddress, HasChild_FunctionAddress, "ReturnValue");
		HasChild_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasChild_FunctionAddress, "ReturnValue");
		HasChild_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasChild_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasChild_IsValid = HasChild_FunctionAddress != IntPtr.Zero && HasChild_Content_IsValid && HasChild_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.PanelWidget:HasChild", HasChild_IsValid);
		HasAnyChildren_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasAnyChildren");
		HasAnyChildren_ParamsSize = NativeReflection.GetFunctionParamsSize(HasAnyChildren_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasAnyChildren_ReturnValue_PropertyAddress, HasAnyChildren_FunctionAddress, "ReturnValue");
		HasAnyChildren_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasAnyChildren_FunctionAddress, "ReturnValue");
		HasAnyChildren_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAnyChildren_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasAnyChildren_IsValid = HasAnyChildren_FunctionAddress != IntPtr.Zero && HasAnyChildren_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.PanelWidget:HasAnyChildren", HasAnyChildren_IsValid);
		GetChildrenCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetChildrenCount");
		GetChildrenCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChildrenCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChildrenCount_ReturnValue_PropertyAddress, GetChildrenCount_FunctionAddress, "ReturnValue");
		GetChildrenCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetChildrenCount_FunctionAddress, "ReturnValue");
		GetChildrenCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildrenCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetChildrenCount_IsValid = GetChildrenCount_FunctionAddress != IntPtr.Zero && GetChildrenCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.PanelWidget:GetChildrenCount", GetChildrenCount_IsValid);
		GetChildIndex_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetChildIndex");
		GetChildIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChildIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChildIndex_Content_PropertyAddress, GetChildIndex_FunctionAddress, "Content");
		GetChildIndex_Content_Offset = NativeReflectionCached.GetPropertyOffset(GetChildIndex_FunctionAddress, "Content");
		GetChildIndex_Content_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildIndex_FunctionAddress, "Content", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChildIndex_ReturnValue_PropertyAddress, GetChildIndex_FunctionAddress, "ReturnValue");
		GetChildIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetChildIndex_FunctionAddress, "ReturnValue");
		GetChildIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetChildIndex_IsValid = GetChildIndex_FunctionAddress != IntPtr.Zero && GetChildIndex_Content_IsValid && GetChildIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.PanelWidget:GetChildIndex", GetChildIndex_IsValid);
		GetChildAt_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetChildAt");
		GetChildAt_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChildAt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChildAt_Index_PropertyAddress, GetChildAt_FunctionAddress, "Index");
		GetChildAt_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetChildAt_FunctionAddress, "Index");
		GetChildAt_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildAt_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChildAt_ReturnValue_PropertyAddress, GetChildAt_FunctionAddress, "ReturnValue");
		GetChildAt_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetChildAt_FunctionAddress, "ReturnValue");
		GetChildAt_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildAt_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetChildAt_IsValid = GetChildAt_FunctionAddress != IntPtr.Zero && GetChildAt_Index_IsValid && GetChildAt_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.PanelWidget:GetChildAt", GetChildAt_IsValid);
		GetAllChildren_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAllChildren");
		GetAllChildren_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllChildren_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllChildren_ReturnValue_PropertyAddress, GetAllChildren_FunctionAddress, "ReturnValue");
		GetAllChildren_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllChildren_FunctionAddress, "ReturnValue");
		GetAllChildren_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllChildren_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllChildren_IsValid = GetAllChildren_FunctionAddress != IntPtr.Zero && GetAllChildren_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.PanelWidget:GetAllChildren", GetAllChildren_IsValid);
		ClearChildren_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ClearChildren");
		ClearChildren_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearChildren_FunctionAddress);
		ClearChildren_IsValid = ClearChildren_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.PanelWidget:ClearChildren", ClearChildren_IsValid);
		AddChild_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddChild");
		AddChild_ParamsSize = NativeReflection.GetFunctionParamsSize(AddChild_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddChild_Content_PropertyAddress, AddChild_FunctionAddress, "Content");
		AddChild_Content_Offset = NativeReflectionCached.GetPropertyOffset(AddChild_FunctionAddress, "Content");
		AddChild_Content_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChild_FunctionAddress, "Content", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddChild_ReturnValue_PropertyAddress, AddChild_FunctionAddress, "ReturnValue");
		AddChild_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddChild_FunctionAddress, "ReturnValue");
		AddChild_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChild_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddChild_IsValid = AddChild_FunctionAddress != IntPtr.Zero && AddChild_Content_IsValid && AddChild_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.PanelWidget:AddChild", AddChild_IsValid);
	}
}
