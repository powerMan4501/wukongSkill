using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OpacityMicroMapEditor;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/OpacityMicroMapEditor.OMMEditorBlueprintLibrary", "OpacityMicroMapEditor", UnrealModuleType.EnginePlugin)]
public class UOMMEditorBlueprintLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool IsDirty_IsValid;

	private static IntPtr IsDirty_FunctionAddress;

	private static int IsDirty_ParamsSize;

	private static bool IsDirty_StaticMesh_IsValid;

	private static FFieldAddress IsDirty_StaticMesh_PropertyAddress;

	private static int IsDirty_StaticMesh_Offset;

	private static bool IsDirty_ReturnValue_IsValid;

	private static FFieldAddress IsDirty_ReturnValue_PropertyAddress;

	private static int IsDirty_ReturnValue_Offset;

	private static bool CookStaticMeshRetcode_IsValid;

	private static IntPtr CookStaticMeshRetcode_FunctionAddress;

	private static int CookStaticMeshRetcode_ParamsSize;

	private static bool CookStaticMeshRetcode_StaticMesh_IsValid;

	private static FFieldAddress CookStaticMeshRetcode_StaticMesh_PropertyAddress;

	private static int CookStaticMeshRetcode_StaticMesh_Offset;

	private static bool CookStaticMeshRetcode_ReturnValue_IsValid;

	private static FFieldAddress CookStaticMeshRetcode_ReturnValue_PropertyAddress;

	private static int CookStaticMeshRetcode_ReturnValue_Offset;

	private static bool CookSkeletalMeshRetCode_IsValid;

	private static IntPtr CookSkeletalMeshRetCode_FunctionAddress;

	private static int CookSkeletalMeshRetCode_ParamsSize;

	private static bool CookSkeletalMeshRetCode_SkeletalMesh_IsValid;

	private static FFieldAddress CookSkeletalMeshRetCode_SkeletalMesh_PropertyAddress;

	private static int CookSkeletalMeshRetCode_SkeletalMesh_Offset;

	private static bool CookSkeletalMeshRetCode_ReturnValue_IsValid;

	private static FFieldAddress CookSkeletalMeshRetCode_ReturnValue_PropertyAddress;

	private static int CookSkeletalMeshRetCode_ReturnValue_Offset;

	private static bool CookSkeletalMesh_IsValid;

	private static IntPtr CookSkeletalMesh_FunctionAddress;

	private static int CookSkeletalMesh_ParamsSize;

	private static bool CookSkeletalMesh_SkeletalMesh_IsValid;

	private static FFieldAddress CookSkeletalMesh_SkeletalMesh_PropertyAddress;

	private static int CookSkeletalMesh_SkeletalMesh_Offset;

	private static bool CookSkeletalMesh_ReturnValue_IsValid;

	private static FFieldAddress CookSkeletalMesh_ReturnValue_PropertyAddress;

	private static int CookSkeletalMesh_ReturnValue_Offset;

	private static bool Cook_IsValid;

	private static IntPtr Cook_FunctionAddress;

	private static int Cook_ParamsSize;

	private static bool Cook_StaticMesh_IsValid;

	private static FFieldAddress Cook_StaticMesh_PropertyAddress;

	private static int Cook_StaticMesh_Offset;

	private static bool Cook_ReturnValue_IsValid;

	private static FFieldAddress Cook_ReturnValue_PropertyAddress;

	private static int Cook_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/OpacityMicroMapEditor.OMMEditorBlueprintLibrary:IsDirty")]
	public unsafe static bool IsDirty(UStaticMesh StaticMesh)
	{
		if (!IsDirty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OpacityMicroMapEditor.OMMEditorBlueprintLibrary:IsDirty");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDirty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDirty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, IsDirty_StaticMesh_Offset), 0, IsDirty_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsDirty_FunctionAddress, intPtr, IsDirty_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDirty_ReturnValue_Offset), 0, IsDirty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/OpacityMicroMapEditor.OMMEditorBlueprintLibrary:CookStaticMeshRetcode")]
	public unsafe static int CookStaticMeshRetcode(UStaticMesh StaticMesh)
	{
		if (!CookStaticMeshRetcode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OpacityMicroMapEditor.OMMEditorBlueprintLibrary:CookStaticMeshRetcode");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CookStaticMeshRetcode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CookStaticMeshRetcode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, CookStaticMeshRetcode_StaticMesh_Offset), 0, CookStaticMeshRetcode_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CookStaticMeshRetcode_FunctionAddress, intPtr, CookStaticMeshRetcode_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, CookStaticMeshRetcode_ReturnValue_Offset), 0, CookStaticMeshRetcode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/OpacityMicroMapEditor.OMMEditorBlueprintLibrary:CookSkeletalMeshRetCode")]
	public unsafe static int CookSkeletalMeshRetCode(USkeletalMesh SkeletalMesh)
	{
		if (!CookSkeletalMeshRetCode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OpacityMicroMapEditor.OMMEditorBlueprintLibrary:CookSkeletalMeshRetCode");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CookSkeletalMeshRetCode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CookSkeletalMeshRetCode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, CookSkeletalMeshRetCode_SkeletalMesh_Offset), 0, CookSkeletalMeshRetCode_SkeletalMesh_PropertyAddress.Address, SkeletalMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CookSkeletalMeshRetCode_FunctionAddress, intPtr, CookSkeletalMeshRetCode_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, CookSkeletalMeshRetCode_ReturnValue_Offset), 0, CookSkeletalMeshRetCode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/OpacityMicroMapEditor.OMMEditorBlueprintLibrary:CookSkeletalMesh")]
	public unsafe static int CookSkeletalMesh(USkeletalMesh SkeletalMesh)
	{
		if (!CookSkeletalMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OpacityMicroMapEditor.OMMEditorBlueprintLibrary:CookSkeletalMesh");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CookSkeletalMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CookSkeletalMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, CookSkeletalMesh_SkeletalMesh_Offset), 0, CookSkeletalMesh_SkeletalMesh_PropertyAddress.Address, SkeletalMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CookSkeletalMesh_FunctionAddress, intPtr, CookSkeletalMesh_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, CookSkeletalMesh_ReturnValue_Offset), 0, CookSkeletalMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/OpacityMicroMapEditor.OMMEditorBlueprintLibrary:Cook")]
	public unsafe static int Cook(UStaticMesh StaticMesh)
	{
		if (!Cook_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OpacityMicroMapEditor.OMMEditorBlueprintLibrary:Cook");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Cook_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Cook_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, Cook_StaticMesh_Offset), 0, Cook_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Cook_FunctionAddress, intPtr, Cook_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, Cook_ReturnValue_Offset), 0, Cook_ReturnValue_PropertyAddress.Address);
	}

	static UOMMEditorBlueprintLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UOMMEditorBlueprintLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UOMMEditorBlueprintLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/OpacityMicroMapEditor.OMMEditorBlueprintLibrary");
		IsDirty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsDirty");
		IsDirty_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDirty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDirty_StaticMesh_PropertyAddress, IsDirty_FunctionAddress, "StaticMesh");
		IsDirty_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(IsDirty_FunctionAddress, "StaticMesh");
		IsDirty_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirty_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDirty_ReturnValue_PropertyAddress, IsDirty_FunctionAddress, "ReturnValue");
		IsDirty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDirty_FunctionAddress, "ReturnValue");
		IsDirty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDirty_IsValid = IsDirty_FunctionAddress != IntPtr.Zero && IsDirty_StaticMesh_IsValid && IsDirty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OpacityMicroMapEditor.OMMEditorBlueprintLibrary:IsDirty", IsDirty_IsValid);
		CookStaticMeshRetcode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CookStaticMeshRetcode");
		CookStaticMeshRetcode_ParamsSize = NativeReflection.GetFunctionParamsSize(CookStaticMeshRetcode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CookStaticMeshRetcode_StaticMesh_PropertyAddress, CookStaticMeshRetcode_FunctionAddress, "StaticMesh");
		CookStaticMeshRetcode_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(CookStaticMeshRetcode_FunctionAddress, "StaticMesh");
		CookStaticMeshRetcode_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(CookStaticMeshRetcode_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CookStaticMeshRetcode_ReturnValue_PropertyAddress, CookStaticMeshRetcode_FunctionAddress, "ReturnValue");
		CookStaticMeshRetcode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CookStaticMeshRetcode_FunctionAddress, "ReturnValue");
		CookStaticMeshRetcode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CookStaticMeshRetcode_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		CookStaticMeshRetcode_IsValid = CookStaticMeshRetcode_FunctionAddress != IntPtr.Zero && CookStaticMeshRetcode_StaticMesh_IsValid && CookStaticMeshRetcode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OpacityMicroMapEditor.OMMEditorBlueprintLibrary:CookStaticMeshRetcode", CookStaticMeshRetcode_IsValid);
		CookSkeletalMeshRetCode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CookSkeletalMeshRetCode");
		CookSkeletalMeshRetCode_ParamsSize = NativeReflection.GetFunctionParamsSize(CookSkeletalMeshRetCode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CookSkeletalMeshRetCode_SkeletalMesh_PropertyAddress, CookSkeletalMeshRetCode_FunctionAddress, "SkeletalMesh");
		CookSkeletalMeshRetCode_SkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(CookSkeletalMeshRetCode_FunctionAddress, "SkeletalMesh");
		CookSkeletalMeshRetCode_SkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(CookSkeletalMeshRetCode_FunctionAddress, "SkeletalMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CookSkeletalMeshRetCode_ReturnValue_PropertyAddress, CookSkeletalMeshRetCode_FunctionAddress, "ReturnValue");
		CookSkeletalMeshRetCode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CookSkeletalMeshRetCode_FunctionAddress, "ReturnValue");
		CookSkeletalMeshRetCode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CookSkeletalMeshRetCode_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		CookSkeletalMeshRetCode_IsValid = CookSkeletalMeshRetCode_FunctionAddress != IntPtr.Zero && CookSkeletalMeshRetCode_SkeletalMesh_IsValid && CookSkeletalMeshRetCode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OpacityMicroMapEditor.OMMEditorBlueprintLibrary:CookSkeletalMeshRetCode", CookSkeletalMeshRetCode_IsValid);
		CookSkeletalMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CookSkeletalMesh");
		CookSkeletalMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(CookSkeletalMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CookSkeletalMesh_SkeletalMesh_PropertyAddress, CookSkeletalMesh_FunctionAddress, "SkeletalMesh");
		CookSkeletalMesh_SkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(CookSkeletalMesh_FunctionAddress, "SkeletalMesh");
		CookSkeletalMesh_SkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(CookSkeletalMesh_FunctionAddress, "SkeletalMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CookSkeletalMesh_ReturnValue_PropertyAddress, CookSkeletalMesh_FunctionAddress, "ReturnValue");
		CookSkeletalMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CookSkeletalMesh_FunctionAddress, "ReturnValue");
		CookSkeletalMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CookSkeletalMesh_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		CookSkeletalMesh_IsValid = CookSkeletalMesh_FunctionAddress != IntPtr.Zero && CookSkeletalMesh_SkeletalMesh_IsValid && CookSkeletalMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OpacityMicroMapEditor.OMMEditorBlueprintLibrary:CookSkeletalMesh", CookSkeletalMesh_IsValid);
		Cook_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Cook");
		Cook_ParamsSize = NativeReflection.GetFunctionParamsSize(Cook_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Cook_StaticMesh_PropertyAddress, Cook_FunctionAddress, "StaticMesh");
		Cook_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(Cook_FunctionAddress, "StaticMesh");
		Cook_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(Cook_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Cook_ReturnValue_PropertyAddress, Cook_FunctionAddress, "ReturnValue");
		Cook_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Cook_FunctionAddress, "ReturnValue");
		Cook_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Cook_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		Cook_IsValid = Cook_FunctionAddress != IntPtr.Zero && Cook_StaticMesh_IsValid && Cook_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OpacityMicroMapEditor.OMMEditorBlueprintLibrary:Cook", Cook_IsValid);
	}
}
