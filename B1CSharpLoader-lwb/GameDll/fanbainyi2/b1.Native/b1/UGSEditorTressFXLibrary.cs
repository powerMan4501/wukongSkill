using System;
using System.Runtime.CompilerServices;
using b1.Plugins.TressFX;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSEditorTressFXLibrary", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSEditorTressFXLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetNumTressfxOriginalVertexao_IsValid;

	private static IntPtr GetNumTressfxOriginalVertexao_FunctionAddress;

	private static int GetNumTressfxOriginalVertexao_ParamsSize;

	private static bool GetNumTressfxOriginalVertexao_Asset_IsValid;

	private static FFieldAddress GetNumTressfxOriginalVertexao_Asset_PropertyAddress;

	private static int GetNumTressfxOriginalVertexao_Asset_Offset;

	private static bool GetNumTressfxOriginalVertexao_ReturnValue_IsValid;

	private static FFieldAddress GetNumTressfxOriginalVertexao_ReturnValue_PropertyAddress;

	private static int GetNumTressfxOriginalVertexao_ReturnValue_Offset;

	private static bool GetNumTressfxOriginalShadow1_IsValid;

	private static IntPtr GetNumTressfxOriginalShadow1_FunctionAddress;

	private static int GetNumTressfxOriginalShadow1_ParamsSize;

	private static bool GetNumTressfxOriginalShadow1_Asset_IsValid;

	private static FFieldAddress GetNumTressfxOriginalShadow1_Asset_PropertyAddress;

	private static int GetNumTressfxOriginalShadow1_Asset_Offset;

	private static bool GetNumTressfxOriginalShadow1_ReturnValue_IsValid;

	private static FFieldAddress GetNumTressfxOriginalShadow1_ReturnValue_PropertyAddress;

	private static int GetNumTressfxOriginalShadow1_ReturnValue_Offset;

	private static bool GetNumTressfxOriginalShadow0_IsValid;

	private static IntPtr GetNumTressfxOriginalShadow0_FunctionAddress;

	private static int GetNumTressfxOriginalShadow0_ParamsSize;

	private static bool GetNumTressfxOriginalShadow0_Asset_IsValid;

	private static FFieldAddress GetNumTressfxOriginalShadow0_Asset_PropertyAddress;

	private static int GetNumTressfxOriginalShadow0_Asset_Offset;

	private static bool GetNumTressfxOriginalShadow0_ReturnValue_IsValid;

	private static FFieldAddress GetNumTressfxOriginalShadow0_ReturnValue_PropertyAddress;

	private static int GetNumTressfxOriginalShadow0_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorTressFXLibrary:GetNumTressfxOriginalVertexao")]
	public unsafe static int GetNumTressfxOriginalVertexao(UTressFXAsset Asset)
	{
		if (!GetNumTressfxOriginalVertexao_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorTressFXLibrary:GetNumTressfxOriginalVertexao");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumTressfxOriginalVertexao_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumTressfxOriginalVertexao_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTressFXAsset>.ToNative(IntPtr.Add(intPtr, GetNumTressfxOriginalVertexao_Asset_Offset), 0, GetNumTressfxOriginalVertexao_Asset_PropertyAddress.Address, Asset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNumTressfxOriginalVertexao_FunctionAddress, intPtr, GetNumTressfxOriginalVertexao_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumTressfxOriginalVertexao_ReturnValue_Offset), 0, GetNumTressfxOriginalVertexao_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorTressFXLibrary:GetNumTressfxOriginalShadow1")]
	public unsafe static int GetNumTressfxOriginalShadow1(UTressFXAsset Asset)
	{
		if (!GetNumTressfxOriginalShadow1_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorTressFXLibrary:GetNumTressfxOriginalShadow1");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumTressfxOriginalShadow1_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumTressfxOriginalShadow1_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTressFXAsset>.ToNative(IntPtr.Add(intPtr, GetNumTressfxOriginalShadow1_Asset_Offset), 0, GetNumTressfxOriginalShadow1_Asset_PropertyAddress.Address, Asset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNumTressfxOriginalShadow1_FunctionAddress, intPtr, GetNumTressfxOriginalShadow1_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumTressfxOriginalShadow1_ReturnValue_Offset), 0, GetNumTressfxOriginalShadow1_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorTressFXLibrary:GetNumTressfxOriginalShadow0")]
	public unsafe static int GetNumTressfxOriginalShadow0(UTressFXAsset Asset)
	{
		if (!GetNumTressfxOriginalShadow0_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorTressFXLibrary:GetNumTressfxOriginalShadow0");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumTressfxOriginalShadow0_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumTressfxOriginalShadow0_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTressFXAsset>.ToNative(IntPtr.Add(intPtr, GetNumTressfxOriginalShadow0_Asset_Offset), 0, GetNumTressfxOriginalShadow0_Asset_PropertyAddress.Address, Asset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNumTressfxOriginalShadow0_FunctionAddress, intPtr, GetNumTressfxOriginalShadow0_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumTressfxOriginalShadow0_ReturnValue_Offset), 0, GetNumTressfxOriginalShadow0_ReturnValue_PropertyAddress.Address);
	}

	static UGSEditorTressFXLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEditorTressFXLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEditorTressFXLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorTressFXLibrary");
		GetNumTressfxOriginalVertexao_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumTressfxOriginalVertexao");
		GetNumTressfxOriginalVertexao_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumTressfxOriginalVertexao_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumTressfxOriginalVertexao_Asset_PropertyAddress, GetNumTressfxOriginalVertexao_FunctionAddress, "Asset");
		GetNumTressfxOriginalVertexao_Asset_Offset = NativeReflectionCached.GetPropertyOffset(GetNumTressfxOriginalVertexao_FunctionAddress, "Asset");
		GetNumTressfxOriginalVertexao_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumTressfxOriginalVertexao_FunctionAddress, "Asset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumTressfxOriginalVertexao_ReturnValue_PropertyAddress, GetNumTressfxOriginalVertexao_FunctionAddress, "ReturnValue");
		GetNumTressfxOriginalVertexao_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumTressfxOriginalVertexao_FunctionAddress, "ReturnValue");
		GetNumTressfxOriginalVertexao_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumTressfxOriginalVertexao_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumTressfxOriginalVertexao_IsValid = GetNumTressfxOriginalVertexao_FunctionAddress != IntPtr.Zero && GetNumTressfxOriginalVertexao_Asset_IsValid && GetNumTressfxOriginalVertexao_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorTressFXLibrary:GetNumTressfxOriginalVertexao", GetNumTressfxOriginalVertexao_IsValid);
		GetNumTressfxOriginalShadow1_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumTressfxOriginalShadow1");
		GetNumTressfxOriginalShadow1_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumTressfxOriginalShadow1_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumTressfxOriginalShadow1_Asset_PropertyAddress, GetNumTressfxOriginalShadow1_FunctionAddress, "Asset");
		GetNumTressfxOriginalShadow1_Asset_Offset = NativeReflectionCached.GetPropertyOffset(GetNumTressfxOriginalShadow1_FunctionAddress, "Asset");
		GetNumTressfxOriginalShadow1_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumTressfxOriginalShadow1_FunctionAddress, "Asset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumTressfxOriginalShadow1_ReturnValue_PropertyAddress, GetNumTressfxOriginalShadow1_FunctionAddress, "ReturnValue");
		GetNumTressfxOriginalShadow1_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumTressfxOriginalShadow1_FunctionAddress, "ReturnValue");
		GetNumTressfxOriginalShadow1_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumTressfxOriginalShadow1_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumTressfxOriginalShadow1_IsValid = GetNumTressfxOriginalShadow1_FunctionAddress != IntPtr.Zero && GetNumTressfxOriginalShadow1_Asset_IsValid && GetNumTressfxOriginalShadow1_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorTressFXLibrary:GetNumTressfxOriginalShadow1", GetNumTressfxOriginalShadow1_IsValid);
		GetNumTressfxOriginalShadow0_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumTressfxOriginalShadow0");
		GetNumTressfxOriginalShadow0_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumTressfxOriginalShadow0_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumTressfxOriginalShadow0_Asset_PropertyAddress, GetNumTressfxOriginalShadow0_FunctionAddress, "Asset");
		GetNumTressfxOriginalShadow0_Asset_Offset = NativeReflectionCached.GetPropertyOffset(GetNumTressfxOriginalShadow0_FunctionAddress, "Asset");
		GetNumTressfxOriginalShadow0_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumTressfxOriginalShadow0_FunctionAddress, "Asset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumTressfxOriginalShadow0_ReturnValue_PropertyAddress, GetNumTressfxOriginalShadow0_FunctionAddress, "ReturnValue");
		GetNumTressfxOriginalShadow0_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumTressfxOriginalShadow0_FunctionAddress, "ReturnValue");
		GetNumTressfxOriginalShadow0_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumTressfxOriginalShadow0_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumTressfxOriginalShadow0_IsValid = GetNumTressfxOriginalShadow0_FunctionAddress != IntPtr.Zero && GetNumTressfxOriginalShadow0_Asset_IsValid && GetNumTressfxOriginalShadow0_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorTressFXLibrary:GetNumTressfxOriginalShadow0", GetNumTressfxOriginalShadow0_IsValid);
	}
}
