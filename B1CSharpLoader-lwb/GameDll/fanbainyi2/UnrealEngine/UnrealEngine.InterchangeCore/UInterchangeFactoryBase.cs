using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.InterchangeCore;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/InterchangeCore.InterchangeFactoryBase", "InterchangeCore", UnrealModuleType.Engine)]
public class UInterchangeFactoryBase : UObject
{
	private static bool GetFactoryClass_IsValid;

	private static IntPtr GetFactoryClass_FunctionAddress;

	private static int GetFactoryClass_ParamsSize;

	private static bool GetFactoryClass_ReturnValue_IsValid;

	private static FFieldAddress GetFactoryClass_ReturnValue_PropertyAddress;

	private static int GetFactoryClass_ReturnValue_Offset;

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeFactoryBase:GetFactoryClass")]
	public unsafe TSubclassOf<UObject> GetFactoryClass()
	{
		CheckDestroyed();
		if (!GetFactoryClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeFactoryBase:GetFactoryClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFactoryClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFactoryClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFactoryClass_FunctionAddress, intPtr, GetFactoryClass_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetFactoryClass_ReturnValue_Offset), 0, GetFactoryClass_ReturnValue_PropertyAddress.Address);
	}

	static UInterchangeFactoryBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangeFactoryBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangeFactoryBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeCore.InterchangeFactoryBase");
		GetFactoryClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFactoryClass");
		GetFactoryClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFactoryClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFactoryClass_ReturnValue_PropertyAddress, GetFactoryClass_FunctionAddress, "ReturnValue");
		GetFactoryClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFactoryClass_FunctionAddress, "ReturnValue");
		GetFactoryClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFactoryClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetFactoryClass_IsValid = GetFactoryClass_FunctionAddress != IntPtr.Zero && GetFactoryClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeFactoryBase:GetFactoryClass", GetFactoryClass_IsValid);
	}
}
