using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.GSWorldCompositionStreamingSourceComponent", "Engine", UnrealModuleType.Engine)]
public class UGSWorldCompositionStreamingSourceComponent : UActorComponent
{
	private static bool IsStreamingSourceEnabled_IsValid;

	private static IntPtr IsStreamingSourceEnabled_FunctionAddress;

	private static int IsStreamingSourceEnabled_ParamsSize;

	private static bool IsStreamingSourceEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsStreamingSourceEnabled_ReturnValue_PropertyAddress;

	private static int IsStreamingSourceEnabled_ReturnValue_Offset;

	private static bool EnableStreamingSource_IsValid;

	private static IntPtr EnableStreamingSource_FunctionAddress;

	private static int EnableStreamingSource_ParamsSize;

	private static bool DisableStreamingSource_IsValid;

	private static IntPtr DisableStreamingSource_FunctionAddress;

	private static int DisableStreamingSource_ParamsSize;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GSWorldCompositionStreamingSourceComponent:IsStreamingSourceEnabled")]
	public unsafe bool IsStreamingSourceEnabled()
	{
		CheckDestroyed();
		if (!IsStreamingSourceEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GSWorldCompositionStreamingSourceComponent:IsStreamingSourceEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsStreamingSourceEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsStreamingSourceEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsStreamingSourceEnabled_FunctionAddress, intPtr, IsStreamingSourceEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsStreamingSourceEnabled_ReturnValue_Offset), 0, IsStreamingSourceEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GSWorldCompositionStreamingSourceComponent:EnableStreamingSource")]
	public unsafe void EnableStreamingSource()
	{
		CheckDestroyed();
		if (!EnableStreamingSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GSWorldCompositionStreamingSourceComponent:EnableStreamingSource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableStreamingSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableStreamingSource_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EnableStreamingSource_FunctionAddress, argsSize: EnableStreamingSource_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GSWorldCompositionStreamingSourceComponent:DisableStreamingSource")]
	public unsafe void DisableStreamingSource()
	{
		CheckDestroyed();
		if (!DisableStreamingSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GSWorldCompositionStreamingSourceComponent:DisableStreamingSource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableStreamingSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableStreamingSource_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DisableStreamingSource_FunctionAddress, argsSize: DisableStreamingSource_ParamsSize);
	}

	static UGSWorldCompositionStreamingSourceComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSWorldCompositionStreamingSourceComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSWorldCompositionStreamingSourceComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.GSWorldCompositionStreamingSourceComponent");
		IsStreamingSourceEnabled_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsStreamingSourceEnabled");
		IsStreamingSourceEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsStreamingSourceEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsStreamingSourceEnabled_ReturnValue_PropertyAddress, IsStreamingSourceEnabled_FunctionAddress, "ReturnValue");
		IsStreamingSourceEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsStreamingSourceEnabled_FunctionAddress, "ReturnValue");
		IsStreamingSourceEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsStreamingSourceEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsStreamingSourceEnabled_IsValid = IsStreamingSourceEnabled_FunctionAddress != IntPtr.Zero && IsStreamingSourceEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GSWorldCompositionStreamingSourceComponent:IsStreamingSourceEnabled", IsStreamingSourceEnabled_IsValid);
		EnableStreamingSource_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EnableStreamingSource");
		EnableStreamingSource_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableStreamingSource_FunctionAddress);
		EnableStreamingSource_IsValid = EnableStreamingSource_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GSWorldCompositionStreamingSourceComponent:EnableStreamingSource", EnableStreamingSource_IsValid);
		DisableStreamingSource_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DisableStreamingSource");
		DisableStreamingSource_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableStreamingSource_FunctionAddress);
		DisableStreamingSource_IsValid = DisableStreamingSource_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GSWorldCompositionStreamingSourceComponent:DisableStreamingSource", DisableStreamingSource_IsValid);
	}
}
