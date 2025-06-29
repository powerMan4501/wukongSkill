using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Blutility;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Blutility.ActorActionUtility", "Blutility", UnrealModuleType.Engine)]
public class UActorActionUtility : UEditorUtilityObject, IEditorUtilityExtension, IInterface
{
	private static bool GetSupportedClass_IsValid;

	private IntPtr GetSupportedClass_InstanceFunctionAddress;

	private static IntPtr GetSupportedClass_FunctionAddress;

	private static int GetSupportedClass_ParamsSize;

	private static bool GetSupportedClass_ReturnValue_IsValid;

	private static FFieldAddress GetSupportedClass_ReturnValue_PropertyAddress;

	private static int GetSupportedClass_ReturnValue_Offset;

	[UFunction(Flags = 1543636992u)]
	[UMetaPath("/Script/Blutility.ActorActionUtility:GetSupportedClass")]
	public unsafe TSubclassOf<UObject> GetSupportedClass()
	{
		CheckDestroyed();
		if (!GetSupportedClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.ActorActionUtility:GetSupportedClass");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.ActorActionUtility:GetSupportedClass");
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

	static UActorActionUtility()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UActorActionUtility)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UActorActionUtility));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Blutility.ActorActionUtility");
		GetSupportedClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSupportedClass");
		GetSupportedClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSupportedClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSupportedClass_ReturnValue_PropertyAddress, GetSupportedClass_FunctionAddress, "ReturnValue");
		GetSupportedClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSupportedClass_FunctionAddress, "ReturnValue");
		GetSupportedClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSupportedClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetSupportedClass_IsValid = GetSupportedClass_FunctionAddress != IntPtr.Zero && GetSupportedClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.ActorActionUtility:GetSupportedClass", GetSupportedClass_IsValid);
	}
}
