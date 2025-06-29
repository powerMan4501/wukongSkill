using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/b1.BGUFuncLibCSSystem", "b1", UnrealModuleType.Game)]
public class UBGUFuncLibCSSystem : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool CSGetReadOnlyData_IsValid;

	private static IntPtr CSGetReadOnlyData_FunctionAddress;

	private static int CSGetReadOnlyData_ParamsSize;

	private static bool CSGetReadOnlyData_OwnerActor_IsValid;

	private static FFieldAddress CSGetReadOnlyData_OwnerActor_PropertyAddress;

	private static int CSGetReadOnlyData_OwnerActor_Offset;

	private static bool CSGetReadOnlyData_Cls_IsValid;

	private static FFieldAddress CSGetReadOnlyData_Cls_PropertyAddress;

	private static int CSGetReadOnlyData_Cls_Offset;

	private static bool CSGetReadOnlyData_ReturnValue_IsValid;

	private static FFieldAddress CSGetReadOnlyData_ReturnValue_PropertyAddress;

	private static int CSGetReadOnlyData_ReturnValue_Offset;

	private static bool CSGetDataByClass_IsValid;

	private static IntPtr CSGetDataByClass_FunctionAddress;

	private static int CSGetDataByClass_ParamsSize;

	private static bool CSGetDataByClass_Comp_IsValid;

	private static FFieldAddress CSGetDataByClass_Comp_PropertyAddress;

	private static int CSGetDataByClass_Comp_Offset;

	private static bool CSGetDataByClass_Cls_IsValid;

	private static FFieldAddress CSGetDataByClass_Cls_PropertyAddress;

	private static int CSGetDataByClass_Cls_Offset;

	private static bool CSGetDataByClass_ReturnValue_IsValid;

	private static FFieldAddress CSGetDataByClass_ReturnValue_PropertyAddress;

	private static int CSGetDataByClass_ReturnValue_Offset;

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.BGUFuncLibCSSystem:CSGetReadOnlyData")]
	public unsafe static UObject CSGetReadOnlyData(AActor OwnerActor, TSubclassOf<UObject> Cls)
	{
		if (!CSGetReadOnlyData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibCSSystem:CSGetReadOnlyData");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CSGetReadOnlyData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CSGetReadOnlyData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, CSGetReadOnlyData_OwnerActor_Offset), 0, CSGetReadOnlyData_OwnerActor_PropertyAddress.Address, OwnerActor);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CSGetReadOnlyData_Cls_Offset), 0, CSGetReadOnlyData_Cls_PropertyAddress.Address, Cls);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CSGetReadOnlyData_FunctionAddress, intPtr, CSGetReadOnlyData_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, CSGetReadOnlyData_ReturnValue_Offset), 0, CSGetReadOnlyData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.BGUFuncLibCSSystem:CSGetDataByClass")]
	public unsafe static UObject CSGetDataByClass(UBaseActorComp Comp, TSubclassOf<UObject> Cls)
	{
		if (!CSGetDataByClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibCSSystem:CSGetDataByClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CSGetDataByClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CSGetDataByClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBaseActorComp>.ToNative(IntPtr.Add(intPtr, CSGetDataByClass_Comp_Offset), 0, CSGetDataByClass_Comp_PropertyAddress.Address, Comp);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CSGetDataByClass_Cls_Offset), 0, CSGetDataByClass_Cls_PropertyAddress.Address, Cls);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CSGetDataByClass_FunctionAddress, intPtr, CSGetDataByClass_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, CSGetDataByClass_ReturnValue_Offset), 0, CSGetDataByClass_ReturnValue_PropertyAddress.Address);
	}

	static UBGUFuncLibCSSystem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUFuncLibCSSystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUFuncLibCSSystem));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGUFuncLibCSSystem");
		CSGetReadOnlyData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CSGetReadOnlyData");
		CSGetReadOnlyData_ParamsSize = NativeReflection.GetFunctionParamsSize(CSGetReadOnlyData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CSGetReadOnlyData_OwnerActor_PropertyAddress, CSGetReadOnlyData_FunctionAddress, "OwnerActor");
		CSGetReadOnlyData_OwnerActor_Offset = NativeReflectionCached.GetPropertyOffset(CSGetReadOnlyData_FunctionAddress, "OwnerActor");
		CSGetReadOnlyData_OwnerActor_IsValid = NativeReflectionCached.ValidatePropertyClass(CSGetReadOnlyData_FunctionAddress, "OwnerActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CSGetReadOnlyData_Cls_PropertyAddress, CSGetReadOnlyData_FunctionAddress, "Cls");
		CSGetReadOnlyData_Cls_Offset = NativeReflectionCached.GetPropertyOffset(CSGetReadOnlyData_FunctionAddress, "Cls");
		CSGetReadOnlyData_Cls_IsValid = NativeReflectionCached.ValidatePropertyClass(CSGetReadOnlyData_FunctionAddress, "Cls", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref CSGetReadOnlyData_ReturnValue_PropertyAddress, CSGetReadOnlyData_FunctionAddress, "ReturnValue");
		CSGetReadOnlyData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CSGetReadOnlyData_FunctionAddress, "ReturnValue");
		CSGetReadOnlyData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CSGetReadOnlyData_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CSGetReadOnlyData_IsValid = CSGetReadOnlyData_FunctionAddress != IntPtr.Zero && CSGetReadOnlyData_OwnerActor_IsValid && CSGetReadOnlyData_Cls_IsValid && CSGetReadOnlyData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibCSSystem:CSGetReadOnlyData", CSGetReadOnlyData_IsValid);
		CSGetDataByClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CSGetDataByClass");
		CSGetDataByClass_ParamsSize = NativeReflection.GetFunctionParamsSize(CSGetDataByClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CSGetDataByClass_Comp_PropertyAddress, CSGetDataByClass_FunctionAddress, "Comp");
		CSGetDataByClass_Comp_Offset = NativeReflectionCached.GetPropertyOffset(CSGetDataByClass_FunctionAddress, "Comp");
		CSGetDataByClass_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(CSGetDataByClass_FunctionAddress, "Comp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CSGetDataByClass_Cls_PropertyAddress, CSGetDataByClass_FunctionAddress, "Cls");
		CSGetDataByClass_Cls_Offset = NativeReflectionCached.GetPropertyOffset(CSGetDataByClass_FunctionAddress, "Cls");
		CSGetDataByClass_Cls_IsValid = NativeReflectionCached.ValidatePropertyClass(CSGetDataByClass_FunctionAddress, "Cls", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref CSGetDataByClass_ReturnValue_PropertyAddress, CSGetDataByClass_FunctionAddress, "ReturnValue");
		CSGetDataByClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CSGetDataByClass_FunctionAddress, "ReturnValue");
		CSGetDataByClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CSGetDataByClass_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CSGetDataByClass_IsValid = CSGetDataByClass_FunctionAddress != IntPtr.Zero && CSGetDataByClass_Comp_IsValid && CSGetDataByClass_Cls_IsValid && CSGetDataByClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibCSSystem:CSGetDataByClass", CSGetDataByClass_IsValid);
	}
}
