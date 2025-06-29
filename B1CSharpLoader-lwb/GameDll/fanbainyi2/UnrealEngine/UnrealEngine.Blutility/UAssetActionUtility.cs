using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Blutility;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Blutility.AssetActionUtility", "Blutility", UnrealModuleType.Engine)]
public class UAssetActionUtility : UEditorUtilityObject, IEditorUtilityExtension, IInterface
{
	private static bool IsActionForBlueprints_IsValid;

	private IntPtr IsActionForBlueprints_InstanceFunctionAddress;

	private static IntPtr IsActionForBlueprints_FunctionAddress;

	private static int IsActionForBlueprints_ParamsSize;

	private static bool IsActionForBlueprints_ReturnValue_IsValid;

	private static FFieldAddress IsActionForBlueprints_ReturnValue_PropertyAddress;

	private static int IsActionForBlueprints_ReturnValue_Offset;

	private static bool GetSupportedClass_IsValid;

	private IntPtr GetSupportedClass_InstanceFunctionAddress;

	private static IntPtr GetSupportedClass_FunctionAddress;

	private static int GetSupportedClass_ParamsSize;

	private static bool GetSupportedClass_ReturnValue_IsValid;

	private static FFieldAddress GetSupportedClass_ReturnValue_PropertyAddress;

	private static int GetSupportedClass_ReturnValue_Offset;

	[UFunction(Flags = 1543636992u)]
	[UMetaPath("/Script/Blutility.AssetActionUtility:IsActionForBlueprints")]
	public unsafe bool IsActionForBlueprints()
	{
		CheckDestroyed();
		if (!IsActionForBlueprints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.AssetActionUtility:IsActionForBlueprints");
			return false;
		}
		if (IsActionForBlueprints_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsActionForBlueprints_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsActionForBlueprints");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsActionForBlueprints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsActionForBlueprints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsActionForBlueprints_InstanceFunctionAddress, intPtr, IsActionForBlueprints_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsActionForBlueprints_ReturnValue_Offset), 0, IsActionForBlueprints_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IsActionForBlueprints_Implementation()
	{
		CheckDestroyed();
		if (!IsActionForBlueprints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.AssetActionUtility:IsActionForBlueprints");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsActionForBlueprints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsActionForBlueprints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsActionForBlueprints_FunctionAddress, intPtr, IsActionForBlueprints_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsActionForBlueprints_ReturnValue_Offset), 0, IsActionForBlueprints_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1543636992u)]
	[UMetaPath("/Script/Blutility.AssetActionUtility:GetSupportedClass")]
	public unsafe TSubclassOf<UObject> GetSupportedClass()
	{
		CheckDestroyed();
		if (!GetSupportedClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.AssetActionUtility:GetSupportedClass");
			return default(TSubclassOf<UObject>);
		}
		if (GetSupportedClass_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetSupportedClass_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetSupportedClass");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSupportedClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSupportedClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSupportedClass_InstanceFunctionAddress, intPtr, GetSupportedClass_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetSupportedClass_ReturnValue_Offset), 0, GetSupportedClass_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual TSubclassOf<UObject> GetSupportedClass_Implementation()
	{
		CheckDestroyed();
		if (!GetSupportedClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.AssetActionUtility:GetSupportedClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSupportedClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSupportedClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSupportedClass_FunctionAddress, intPtr, GetSupportedClass_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetSupportedClass_ReturnValue_Offset), 0, GetSupportedClass_ReturnValue_PropertyAddress.Address);
	}

	static UAssetActionUtility()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAssetActionUtility)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAssetActionUtility));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Blutility.AssetActionUtility");
		IsActionForBlueprints_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsActionForBlueprints");
		IsActionForBlueprints_ParamsSize = NativeReflection.GetFunctionParamsSize(IsActionForBlueprints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsActionForBlueprints_ReturnValue_PropertyAddress, IsActionForBlueprints_FunctionAddress, "ReturnValue");
		IsActionForBlueprints_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsActionForBlueprints_FunctionAddress, "ReturnValue");
		IsActionForBlueprints_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActionForBlueprints_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsActionForBlueprints_IsValid = IsActionForBlueprints_FunctionAddress != IntPtr.Zero && IsActionForBlueprints_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.AssetActionUtility:IsActionForBlueprints", IsActionForBlueprints_IsValid);
		GetSupportedClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSupportedClass");
		GetSupportedClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSupportedClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSupportedClass_ReturnValue_PropertyAddress, GetSupportedClass_FunctionAddress, "ReturnValue");
		GetSupportedClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSupportedClass_FunctionAddress, "ReturnValue");
		GetSupportedClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSupportedClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetSupportedClass_IsValid = GetSupportedClass_FunctionAddress != IntPtr.Zero && GetSupportedClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.AssetActionUtility:GetSupportedClass", GetSupportedClass_IsValid);
	}
}
