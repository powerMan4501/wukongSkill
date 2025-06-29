using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/JavascriptEditor.JavascriptRawMeshLibrary", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptRawMeshLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SaveRawMesh_IsValid;

	private static IntPtr SaveRawMesh_FunctionAddress;

	private static int SaveRawMesh_ParamsSize;

	private static bool SaveRawMesh_StaticMesh_IsValid;

	private static FFieldAddress SaveRawMesh_StaticMesh_PropertyAddress;

	private static int SaveRawMesh_StaticMesh_Offset;

	private static bool SaveRawMesh_SourceModelIndex_IsValid;

	private static FFieldAddress SaveRawMesh_SourceModelIndex_PropertyAddress;

	private static int SaveRawMesh_SourceModelIndex_Offset;

	private static bool SaveRawMesh_InMesh_IsValid;

	private static FFieldAddress SaveRawMesh_InMesh_PropertyAddress;

	private static int SaveRawMesh_InMesh_Offset;

	private static bool LoadRawMesh_IsValid;

	private static IntPtr LoadRawMesh_FunctionAddress;

	private static int LoadRawMesh_ParamsSize;

	private static bool LoadRawMesh_StaticMesh_IsValid;

	private static FFieldAddress LoadRawMesh_StaticMesh_PropertyAddress;

	private static int LoadRawMesh_StaticMesh_Offset;

	private static bool LoadRawMesh_SourceModelIndex_IsValid;

	private static FFieldAddress LoadRawMesh_SourceModelIndex_PropertyAddress;

	private static int LoadRawMesh_SourceModelIndex_Offset;

	private static bool LoadRawMesh_OutMesh_IsValid;

	private static FFieldAddress LoadRawMesh_OutMesh_PropertyAddress;

	private static int LoadRawMesh_OutMesh_Offset;

	private static bool IsValidOrFixable_IsValid;

	private static IntPtr IsValidOrFixable_FunctionAddress;

	private static int IsValidOrFixable_ParamsSize;

	private static bool IsValidOrFixable_RawMesh_IsValid;

	private static FFieldAddress IsValidOrFixable_RawMesh_PropertyAddress;

	private static int IsValidOrFixable_RawMesh_Offset;

	private static bool IsValidOrFixable_ReturnValue_IsValid;

	private static FFieldAddress IsValidOrFixable_ReturnValue_PropertyAddress;

	private static int IsValidOrFixable_ReturnValue_Offset;

	private static bool IsValid_IsValid;

	private static IntPtr IsValid_FunctionAddress;

	private static int IsValid_ParamsSize;

	private static bool IsValid_RawMesh_IsValid;

	private static FFieldAddress IsValid_RawMesh_PropertyAddress;

	private static int IsValid_RawMesh_Offset;

	private static bool IsValid_ReturnValue_IsValid;

	private static FFieldAddress IsValid_ReturnValue_PropertyAddress;

	private static int IsValid_ReturnValue_Offset;

	private static bool GetWedgePosition_IsValid;

	private static IntPtr GetWedgePosition_FunctionAddress;

	private static int GetWedgePosition_ParamsSize;

	private static bool GetWedgePosition_RawMesh_IsValid;

	private static FFieldAddress GetWedgePosition_RawMesh_PropertyAddress;

	private static int GetWedgePosition_RawMesh_Offset;

	private static bool GetWedgePosition_WedgeIndex_IsValid;

	private static FFieldAddress GetWedgePosition_WedgeIndex_PropertyAddress;

	private static int GetWedgePosition_WedgeIndex_Offset;

	private static bool GetWedgePosition_ReturnValue_IsValid;

	private static FFieldAddress GetWedgePosition_ReturnValue_PropertyAddress;

	private static int GetWedgePosition_ReturnValue_Offset;

	private static bool Empty_IsValid;

	private static IntPtr Empty_FunctionAddress;

	private static int Empty_ParamsSize;

	private static bool Empty_RawMesh_IsValid;

	private static FFieldAddress Empty_RawMesh_PropertyAddress;

	private static int Empty_RawMesh_Offset;

	private static bool CompactMaterialIndices_IsValid;

	private static IntPtr CompactMaterialIndices_FunctionAddress;

	private static int CompactMaterialIndices_ParamsSize;

	private static bool CompactMaterialIndices_RawMesh_IsValid;

	private static FFieldAddress CompactMaterialIndices_RawMesh_PropertyAddress;

	private static int CompactMaterialIndices_RawMesh_Offset;

	private static bool Build_IsValid;

	private static IntPtr Build_FunctionAddress;

	private static int Build_ParamsSize;

	private static bool Build_StaticMesh_IsValid;

	private static FFieldAddress Build_StaticMesh_PropertyAddress;

	private static int Build_StaticMesh_Offset;

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptRawMeshLibrary:SaveRawMesh")]
	public unsafe static void SaveRawMesh(UStaticMesh StaticMesh, int SourceModelIndex, out FJavascriptRawMesh InMesh)
	{
		if (!SaveRawMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptRawMeshLibrary:SaveRawMesh");
			InMesh = default(FJavascriptRawMesh);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveRawMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveRawMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SaveRawMesh_StaticMesh_Offset), 0, SaveRawMesh_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SaveRawMesh_SourceModelIndex_Offset), 0, SaveRawMesh_SourceModelIndex_PropertyAddress.Address, SourceModelIndex);
		NativeReflection.InitializeValue_InContainer(SaveRawMesh_InMesh_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveRawMesh_FunctionAddress, intPtr, SaveRawMesh_ParamsSize);
		InMesh = FJavascriptRawMesh.FromNative(IntPtr.Add(intPtr, SaveRawMesh_InMesh_Offset), 0, SaveRawMesh_InMesh_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SaveRawMesh_InMesh_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptRawMeshLibrary:LoadRawMesh")]
	public unsafe static void LoadRawMesh(UStaticMesh StaticMesh, int SourceModelIndex, out FJavascriptRawMesh OutMesh)
	{
		if (!LoadRawMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptRawMeshLibrary:LoadRawMesh");
			OutMesh = default(FJavascriptRawMesh);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadRawMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadRawMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, LoadRawMesh_StaticMesh_Offset), 0, LoadRawMesh_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, LoadRawMesh_SourceModelIndex_Offset), 0, LoadRawMesh_SourceModelIndex_PropertyAddress.Address, SourceModelIndex);
		NativeReflection.InitializeValue_InContainer(LoadRawMesh_OutMesh_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadRawMesh_FunctionAddress, intPtr, LoadRawMesh_ParamsSize);
		OutMesh = FJavascriptRawMesh.FromNative(IntPtr.Add(intPtr, LoadRawMesh_OutMesh_Offset), 0, LoadRawMesh_OutMesh_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(LoadRawMesh_OutMesh_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptRawMeshLibrary:IsValidOrFixable")]
	public unsafe static bool IsValidOrFixable(FJavascriptRawMesh RawMesh)
	{
		if (!IsValidOrFixable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptRawMeshLibrary:IsValidOrFixable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValidOrFixable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValidOrFixable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsValidOrFixable_RawMesh_PropertyAddress.Address, intPtr);
		FJavascriptRawMesh.ToNative(IntPtr.Add(intPtr, IsValidOrFixable_RawMesh_Offset), 0, IsValidOrFixable_RawMesh_PropertyAddress.Address, RawMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValidOrFixable_FunctionAddress, intPtr, IsValidOrFixable_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsValidOrFixable_RawMesh_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValidOrFixable_ReturnValue_Offset), 0, IsValidOrFixable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptRawMeshLibrary:IsValid")]
	public unsafe static bool IsValid(FJavascriptRawMesh RawMesh)
	{
		if (!IsValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptRawMeshLibrary:IsValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsValid_RawMesh_PropertyAddress.Address, intPtr);
		FJavascriptRawMesh.ToNative(IntPtr.Add(intPtr, IsValid_RawMesh_Offset), 0, IsValid_RawMesh_PropertyAddress.Address, RawMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValid_FunctionAddress, intPtr, IsValid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsValid_RawMesh_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValid_ReturnValue_Offset), 0, IsValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616702977u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptRawMeshLibrary:GetWedgePosition")]
	public unsafe static FVector GetWedgePosition(FJavascriptRawMesh RawMesh, int WedgeIndex)
	{
		if (!GetWedgePosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptRawMeshLibrary:GetWedgePosition");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWedgePosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWedgePosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetWedgePosition_RawMesh_PropertyAddress.Address, intPtr);
		FJavascriptRawMesh.ToNative(IntPtr.Add(intPtr, GetWedgePosition_RawMesh_Offset), 0, GetWedgePosition_RawMesh_PropertyAddress.Address, RawMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetWedgePosition_WedgeIndex_Offset), 0, GetWedgePosition_WedgeIndex_PropertyAddress.Address, WedgeIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWedgePosition_FunctionAddress, intPtr, GetWedgePosition_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetWedgePosition_RawMesh_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetWedgePosition_ReturnValue_Offset), 0, GetWedgePosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptRawMeshLibrary:Empty")]
	public unsafe static void Empty(out FJavascriptRawMesh RawMesh)
	{
		if (!Empty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptRawMeshLibrary:Empty");
			RawMesh = default(FJavascriptRawMesh);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Empty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Empty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Empty_RawMesh_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Empty_FunctionAddress, intPtr, Empty_ParamsSize);
		RawMesh = FJavascriptRawMesh.FromNative(IntPtr.Add(intPtr, Empty_RawMesh_Offset), 0, Empty_RawMesh_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Empty_RawMesh_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptRawMeshLibrary:CompactMaterialIndices")]
	public unsafe static void CompactMaterialIndices(out FJavascriptRawMesh RawMesh)
	{
		if (!CompactMaterialIndices_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptRawMeshLibrary:CompactMaterialIndices");
			RawMesh = default(FJavascriptRawMesh);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CompactMaterialIndices_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CompactMaterialIndices_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CompactMaterialIndices_RawMesh_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CompactMaterialIndices_FunctionAddress, intPtr, CompactMaterialIndices_ParamsSize);
		RawMesh = FJavascriptRawMesh.FromNative(IntPtr.Add(intPtr, CompactMaterialIndices_RawMesh_Offset), 0, CompactMaterialIndices_RawMesh_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CompactMaterialIndices_RawMesh_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptRawMeshLibrary:Build")]
	public unsafe static void Build(UStaticMesh StaticMesh)
	{
		if (!Build_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptRawMeshLibrary:Build");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Build_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Build_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, Build_StaticMesh_Offset), 0, Build_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Build_FunctionAddress, intPtr, Build_ParamsSize);
	}

	static UJavascriptRawMeshLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptRawMeshLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptRawMeshLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/JavascriptEditor.JavascriptRawMeshLibrary");
		SaveRawMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveRawMesh");
		SaveRawMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveRawMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveRawMesh_StaticMesh_PropertyAddress, SaveRawMesh_FunctionAddress, "StaticMesh");
		SaveRawMesh_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SaveRawMesh_FunctionAddress, "StaticMesh");
		SaveRawMesh_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveRawMesh_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveRawMesh_SourceModelIndex_PropertyAddress, SaveRawMesh_FunctionAddress, "SourceModelIndex");
		SaveRawMesh_SourceModelIndex_Offset = NativeReflectionCached.GetPropertyOffset(SaveRawMesh_FunctionAddress, "SourceModelIndex");
		SaveRawMesh_SourceModelIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveRawMesh_FunctionAddress, "SourceModelIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveRawMesh_InMesh_PropertyAddress, SaveRawMesh_FunctionAddress, "InMesh");
		SaveRawMesh_InMesh_Offset = NativeReflectionCached.GetPropertyOffset(SaveRawMesh_FunctionAddress, "InMesh");
		SaveRawMesh_InMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveRawMesh_FunctionAddress, "InMesh", Classes.FStructProperty);
		SaveRawMesh_IsValid = SaveRawMesh_FunctionAddress != IntPtr.Zero && SaveRawMesh_StaticMesh_IsValid && SaveRawMesh_SourceModelIndex_IsValid && SaveRawMesh_InMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptRawMeshLibrary:SaveRawMesh", SaveRawMesh_IsValid);
		LoadRawMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadRawMesh");
		LoadRawMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadRawMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadRawMesh_StaticMesh_PropertyAddress, LoadRawMesh_FunctionAddress, "StaticMesh");
		LoadRawMesh_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(LoadRawMesh_FunctionAddress, "StaticMesh");
		LoadRawMesh_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadRawMesh_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadRawMesh_SourceModelIndex_PropertyAddress, LoadRawMesh_FunctionAddress, "SourceModelIndex");
		LoadRawMesh_SourceModelIndex_Offset = NativeReflectionCached.GetPropertyOffset(LoadRawMesh_FunctionAddress, "SourceModelIndex");
		LoadRawMesh_SourceModelIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadRawMesh_FunctionAddress, "SourceModelIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadRawMesh_OutMesh_PropertyAddress, LoadRawMesh_FunctionAddress, "OutMesh");
		LoadRawMesh_OutMesh_Offset = NativeReflectionCached.GetPropertyOffset(LoadRawMesh_FunctionAddress, "OutMesh");
		LoadRawMesh_OutMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadRawMesh_FunctionAddress, "OutMesh", Classes.FStructProperty);
		LoadRawMesh_IsValid = LoadRawMesh_FunctionAddress != IntPtr.Zero && LoadRawMesh_StaticMesh_IsValid && LoadRawMesh_SourceModelIndex_IsValid && LoadRawMesh_OutMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptRawMeshLibrary:LoadRawMesh", LoadRawMesh_IsValid);
		IsValidOrFixable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValidOrFixable");
		IsValidOrFixable_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValidOrFixable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValidOrFixable_RawMesh_PropertyAddress, IsValidOrFixable_FunctionAddress, "RawMesh");
		IsValidOrFixable_RawMesh_Offset = NativeReflectionCached.GetPropertyOffset(IsValidOrFixable_FunctionAddress, "RawMesh");
		IsValidOrFixable_RawMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidOrFixable_FunctionAddress, "RawMesh", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidOrFixable_ReturnValue_PropertyAddress, IsValidOrFixable_FunctionAddress, "ReturnValue");
		IsValidOrFixable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValidOrFixable_FunctionAddress, "ReturnValue");
		IsValidOrFixable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidOrFixable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValidOrFixable_IsValid = IsValidOrFixable_FunctionAddress != IntPtr.Zero && IsValidOrFixable_RawMesh_IsValid && IsValidOrFixable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptRawMeshLibrary:IsValidOrFixable", IsValidOrFixable_IsValid);
		IsValid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValid");
		IsValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValid_RawMesh_PropertyAddress, IsValid_FunctionAddress, "RawMesh");
		IsValid_RawMesh_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_FunctionAddress, "RawMesh");
		IsValid_RawMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_FunctionAddress, "RawMesh", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValid_ReturnValue_PropertyAddress, IsValid_FunctionAddress, "ReturnValue");
		IsValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_FunctionAddress, "ReturnValue");
		IsValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValid_IsValid = IsValid_FunctionAddress != IntPtr.Zero && IsValid_RawMesh_IsValid && IsValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptRawMeshLibrary:IsValid", IsValid_IsValid);
		GetWedgePosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWedgePosition");
		GetWedgePosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWedgePosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWedgePosition_RawMesh_PropertyAddress, GetWedgePosition_FunctionAddress, "RawMesh");
		GetWedgePosition_RawMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetWedgePosition_FunctionAddress, "RawMesh");
		GetWedgePosition_RawMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWedgePosition_FunctionAddress, "RawMesh", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWedgePosition_WedgeIndex_PropertyAddress, GetWedgePosition_FunctionAddress, "WedgeIndex");
		GetWedgePosition_WedgeIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetWedgePosition_FunctionAddress, "WedgeIndex");
		GetWedgePosition_WedgeIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWedgePosition_FunctionAddress, "WedgeIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWedgePosition_ReturnValue_PropertyAddress, GetWedgePosition_FunctionAddress, "ReturnValue");
		GetWedgePosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWedgePosition_FunctionAddress, "ReturnValue");
		GetWedgePosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWedgePosition_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetWedgePosition_IsValid = GetWedgePosition_FunctionAddress != IntPtr.Zero && GetWedgePosition_RawMesh_IsValid && GetWedgePosition_WedgeIndex_IsValid && GetWedgePosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptRawMeshLibrary:GetWedgePosition", GetWedgePosition_IsValid);
		Empty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Empty");
		Empty_ParamsSize = NativeReflection.GetFunctionParamsSize(Empty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Empty_RawMesh_PropertyAddress, Empty_FunctionAddress, "RawMesh");
		Empty_RawMesh_Offset = NativeReflectionCached.GetPropertyOffset(Empty_FunctionAddress, "RawMesh");
		Empty_RawMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(Empty_FunctionAddress, "RawMesh", Classes.FStructProperty);
		Empty_IsValid = Empty_FunctionAddress != IntPtr.Zero && Empty_RawMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptRawMeshLibrary:Empty", Empty_IsValid);
		CompactMaterialIndices_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CompactMaterialIndices");
		CompactMaterialIndices_ParamsSize = NativeReflection.GetFunctionParamsSize(CompactMaterialIndices_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CompactMaterialIndices_RawMesh_PropertyAddress, CompactMaterialIndices_FunctionAddress, "RawMesh");
		CompactMaterialIndices_RawMesh_Offset = NativeReflectionCached.GetPropertyOffset(CompactMaterialIndices_FunctionAddress, "RawMesh");
		CompactMaterialIndices_RawMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(CompactMaterialIndices_FunctionAddress, "RawMesh", Classes.FStructProperty);
		CompactMaterialIndices_IsValid = CompactMaterialIndices_FunctionAddress != IntPtr.Zero && CompactMaterialIndices_RawMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptRawMeshLibrary:CompactMaterialIndices", CompactMaterialIndices_IsValid);
		Build_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Build");
		Build_ParamsSize = NativeReflection.GetFunctionParamsSize(Build_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Build_StaticMesh_PropertyAddress, Build_FunctionAddress, "StaticMesh");
		Build_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(Build_FunctionAddress, "StaticMesh");
		Build_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(Build_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		Build_IsValid = Build_FunctionAddress != IntPtr.Zero && Build_StaticMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptRawMeshLibrary:Build", Build_IsValid);
	}
}
