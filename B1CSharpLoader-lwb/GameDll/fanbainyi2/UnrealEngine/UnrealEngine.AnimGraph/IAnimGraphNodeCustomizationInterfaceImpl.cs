using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraph;

public sealed class IAnimGraphNodeCustomizationInterfaceImpl : IInterfaceImpl, IAnimGraphNodeCustomizationInterface, IInterface
{
	private static bool GetTitleColor_IsValid;

	private IntPtr GetTitleColor_InstanceFunctionAddress;

	private static IntPtr GetTitleColor_FunctionAddress;

	private static int GetTitleColor_ParamsSize;

	private static bool GetTitleColor_ReturnValue_IsValid;

	private static FFieldAddress GetTitleColor_ReturnValue_PropertyAddress;

	private static int GetTitleColor_ReturnValue_Offset;

	[UFunction(Flags = 1216482304u)]
	[UMetaPath("/Script/AnimGraph.AnimGraphNodeCustomizationInterface:GetTitleColor")]
	public unsafe FLinearColor GetTitleColor()
	{
		CheckDestroyed();
		if (!GetTitleColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraph.AnimGraphNodeCustomizationInterface:GetTitleColor");
			return default(FLinearColor);
		}
		if (GetTitleColor_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetTitleColor_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetTitleColor");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTitleColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTitleColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTitleColor_InstanceFunctionAddress, intPtr, GetTitleColor_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetTitleColor_ReturnValue_Offset), 0, GetTitleColor_ReturnValue_PropertyAddress.Address);
	}

	public override void ResetInterface()
	{
		GetTitleColor_InstanceFunctionAddress = IntPtr.Zero;
	}

	static IAnimGraphNodeCustomizationInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IAnimGraphNodeCustomizationInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IAnimGraphNodeCustomizationInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/AnimGraph.AnimGraphNodeCustomizationInterface");
		GetTitleColor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTitleColor");
		GetTitleColor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTitleColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTitleColor_ReturnValue_PropertyAddress, GetTitleColor_FunctionAddress, "ReturnValue");
		GetTitleColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTitleColor_FunctionAddress, "ReturnValue");
		GetTitleColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTitleColor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTitleColor_IsValid = GetTitleColor_FunctionAddress != IntPtr.Zero && GetTitleColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraph.AnimGraphNodeCustomizationInterface:GetTitleColor", GetTitleColor_IsValid);
	}
}
