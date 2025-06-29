using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.NavigationSystem;

[UDelegate]
[UMetaPath("/Script/NavigationSystem.OnNavigationPathUpdated__DelegateSignature")]
public class FOnNavigationPathUpdated : FMulticastDelegate<FOnNavigationPathUpdated.Signature>
{
	public delegate void Signature(UNavigationPath AffectedPath, ENavPathEvent PathEvent);

	private static bool OnNavigationPathUpdated__DelegateSignature_IsValid;

	private static IntPtr OnNavigationPathUpdated__DelegateSignature_FunctionAddress;

	private static int OnNavigationPathUpdated__DelegateSignature_ParamsSize;

	private static bool OnNavigationPathUpdated__DelegateSignature_AffectedPath_IsValid;

	private static FFieldAddress OnNavigationPathUpdated__DelegateSignature_AffectedPath_PropertyAddress;

	private static int OnNavigationPathUpdated__DelegateSignature_AffectedPath_Offset;

	private static bool OnNavigationPathUpdated__DelegateSignature_PathEvent_IsValid;

	private static FFieldAddress OnNavigationPathUpdated__DelegateSignature_PathEvent_PropertyAddress;

	private static int OnNavigationPathUpdated__DelegateSignature_PathEvent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnNavigationPathUpdated()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnNavigationPathUpdated__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/NavigationSystem.OnNavigationPathUpdated__DelegateSignature");
		OnNavigationPathUpdated__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNavigationPathUpdated__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnNavigationPathUpdated__DelegateSignature_AffectedPath_PropertyAddress, OnNavigationPathUpdated__DelegateSignature_FunctionAddress, "AffectedPath");
		OnNavigationPathUpdated__DelegateSignature_AffectedPath_Offset = NativeReflectionCached.GetPropertyOffset(OnNavigationPathUpdated__DelegateSignature_FunctionAddress, "AffectedPath");
		OnNavigationPathUpdated__DelegateSignature_AffectedPath_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNavigationPathUpdated__DelegateSignature_FunctionAddress, "AffectedPath", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnNavigationPathUpdated__DelegateSignature_PathEvent_PropertyAddress, OnNavigationPathUpdated__DelegateSignature_FunctionAddress, "PathEvent");
		OnNavigationPathUpdated__DelegateSignature_PathEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnNavigationPathUpdated__DelegateSignature_FunctionAddress, "PathEvent");
		OnNavigationPathUpdated__DelegateSignature_PathEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNavigationPathUpdated__DelegateSignature_FunctionAddress, "PathEvent", Classes.FByteProperty);
		OnNavigationPathUpdated__DelegateSignature_IsValid = OnNavigationPathUpdated__DelegateSignature_FunctionAddress != IntPtr.Zero && OnNavigationPathUpdated__DelegateSignature_AffectedPath_IsValid && OnNavigationPathUpdated__DelegateSignature_PathEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.OnNavigationPathUpdated__DelegateSignature", OnNavigationPathUpdated__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UNavigationPath AffectedPath, ENavPathEvent PathEvent)
	{
		if (!OnNavigationPathUpdated__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.OnNavigationPathUpdated__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnNavigationPathUpdated__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNavigationPathUpdated__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UNavigationPath>.ToNative(IntPtr.Add(intPtr, OnNavigationPathUpdated__DelegateSignature_AffectedPath_Offset), 0, OnNavigationPathUpdated__DelegateSignature_AffectedPath_PropertyAddress.Address, AffectedPath);
			EnumMarshaler<ENavPathEvent>.ToNative(IntPtr.Add(intPtr, OnNavigationPathUpdated__DelegateSignature_PathEvent_Offset), 0, OnNavigationPathUpdated__DelegateSignature_PathEvent_PropertyAddress.Address, PathEvent);
			ProcessDelegate(intPtr);
		}
	}
}
