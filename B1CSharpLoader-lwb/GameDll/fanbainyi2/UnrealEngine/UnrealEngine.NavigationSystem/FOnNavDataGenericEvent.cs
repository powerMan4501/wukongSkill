using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.NavigationSystem;

[UDelegate]
[UMetaPath("/Script/NavigationSystem.OnNavDataGenericEvent__DelegateSignature")]
public class FOnNavDataGenericEvent : FMulticastDelegate<FOnNavDataGenericEvent.Signature>
{
	public delegate void Signature(ANavigationData NavData);

	private static bool OnNavDataGenericEvent__DelegateSignature_IsValid;

	private static IntPtr OnNavDataGenericEvent__DelegateSignature_FunctionAddress;

	private static int OnNavDataGenericEvent__DelegateSignature_ParamsSize;

	private static bool OnNavDataGenericEvent__DelegateSignature_NavData_IsValid;

	private static FFieldAddress OnNavDataGenericEvent__DelegateSignature_NavData_PropertyAddress;

	private static int OnNavDataGenericEvent__DelegateSignature_NavData_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnNavDataGenericEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnNavDataGenericEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/NavigationSystem.OnNavDataGenericEvent__DelegateSignature");
		OnNavDataGenericEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNavDataGenericEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnNavDataGenericEvent__DelegateSignature_NavData_PropertyAddress, OnNavDataGenericEvent__DelegateSignature_FunctionAddress, "NavData");
		OnNavDataGenericEvent__DelegateSignature_NavData_Offset = NativeReflectionCached.GetPropertyOffset(OnNavDataGenericEvent__DelegateSignature_FunctionAddress, "NavData");
		OnNavDataGenericEvent__DelegateSignature_NavData_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNavDataGenericEvent__DelegateSignature_FunctionAddress, "NavData", Classes.FObjectProperty);
		OnNavDataGenericEvent__DelegateSignature_IsValid = OnNavDataGenericEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnNavDataGenericEvent__DelegateSignature_NavData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.OnNavDataGenericEvent__DelegateSignature", OnNavDataGenericEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(ANavigationData NavData)
	{
		if (!OnNavDataGenericEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.OnNavDataGenericEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnNavDataGenericEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNavDataGenericEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<ANavigationData>.ToNative(IntPtr.Add(intPtr, OnNavDataGenericEvent__DelegateSignature_NavData_Offset), 0, OnNavDataGenericEvent__DelegateSignature_NavData_PropertyAddress.Address, NavData);
			ProcessDelegate(intPtr);
		}
	}
}
