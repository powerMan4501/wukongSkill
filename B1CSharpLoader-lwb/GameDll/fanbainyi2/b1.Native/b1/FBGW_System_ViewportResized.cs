using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/UnrealExtent.BGW_System_ViewportResized__DelegateSignature")]
public class FBGW_System_ViewportResized : FMulticastDelegate<FBGW_System_ViewportResized.Signature>
{
	public delegate void Signature(FIntPoint NewSize);

	private static bool BGW_System_ViewportResized__DelegateSignature_IsValid;

	private static IntPtr BGW_System_ViewportResized__DelegateSignature_FunctionAddress;

	private static int BGW_System_ViewportResized__DelegateSignature_ParamsSize;

	private static bool BGW_System_ViewportResized__DelegateSignature_NewSize_IsValid;

	private static FFieldAddress BGW_System_ViewportResized__DelegateSignature_NewSize_PropertyAddress;

	private static int BGW_System_ViewportResized__DelegateSignature_NewSize_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FBGW_System_ViewportResized()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		BGW_System_ViewportResized__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UnrealExtent.BGW_System_ViewportResized__DelegateSignature");
		BGW_System_ViewportResized__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BGW_System_ViewportResized__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGW_System_ViewportResized__DelegateSignature_NewSize_PropertyAddress, BGW_System_ViewportResized__DelegateSignature_FunctionAddress, "NewSize");
		BGW_System_ViewportResized__DelegateSignature_NewSize_Offset = NativeReflectionCached.GetPropertyOffset(BGW_System_ViewportResized__DelegateSignature_FunctionAddress, "NewSize");
		BGW_System_ViewportResized__DelegateSignature_NewSize_IsValid = NativeReflectionCached.ValidatePropertyClass(BGW_System_ViewportResized__DelegateSignature_FunctionAddress, "NewSize", Classes.FStructProperty);
		BGW_System_ViewportResized__DelegateSignature_IsValid = BGW_System_ViewportResized__DelegateSignature_FunctionAddress != IntPtr.Zero && BGW_System_ViewportResized__DelegateSignature_NewSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.BGW_System_ViewportResized__DelegateSignature", BGW_System_ViewportResized__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FIntPoint NewSize)
	{
		if (!BGW_System_ViewportResized__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.BGW_System_ViewportResized__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(BGW_System_ViewportResized__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGW_System_ViewportResized__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(intPtr, BGW_System_ViewportResized__DelegateSignature_NewSize_Offset), 0, BGW_System_ViewportResized__DelegateSignature_NewSize_PropertyAddress.Address, NewSize);
			ProcessDelegate(intPtr);
		}
	}
}
