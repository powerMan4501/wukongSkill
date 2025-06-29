using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/UnrealExtent.GSOnButtonCheckStateChanged__DelegateSignature")]
public class FGSOnButtonCheckStateChanged : FMulticastDelegate<FGSOnButtonCheckStateChanged.Signature>
{
	public delegate void Signature(int GSID, bool bIsChecked);

	private static bool GSOnButtonCheckStateChanged__DelegateSignature_IsValid;

	private static IntPtr GSOnButtonCheckStateChanged__DelegateSignature_FunctionAddress;

	private static int GSOnButtonCheckStateChanged__DelegateSignature_ParamsSize;

	private static bool GSOnButtonCheckStateChanged__DelegateSignature_GSID_IsValid;

	private static FFieldAddress GSOnButtonCheckStateChanged__DelegateSignature_GSID_PropertyAddress;

	private static int GSOnButtonCheckStateChanged__DelegateSignature_GSID_Offset;

	private static bool GSOnButtonCheckStateChanged__DelegateSignature_bIsChecked_IsValid;

	private static FFieldAddress GSOnButtonCheckStateChanged__DelegateSignature_bIsChecked_PropertyAddress;

	private static int GSOnButtonCheckStateChanged__DelegateSignature_bIsChecked_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnButtonCheckStateChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnButtonCheckStateChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UnrealExtent.GSOnButtonCheckStateChanged__DelegateSignature");
		GSOnButtonCheckStateChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnButtonCheckStateChanged__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnButtonCheckStateChanged__DelegateSignature_GSID_PropertyAddress, GSOnButtonCheckStateChanged__DelegateSignature_FunctionAddress, "GSID");
		GSOnButtonCheckStateChanged__DelegateSignature_GSID_Offset = NativeReflectionCached.GetPropertyOffset(GSOnButtonCheckStateChanged__DelegateSignature_FunctionAddress, "GSID");
		GSOnButtonCheckStateChanged__DelegateSignature_GSID_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnButtonCheckStateChanged__DelegateSignature_FunctionAddress, "GSID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GSOnButtonCheckStateChanged__DelegateSignature_bIsChecked_PropertyAddress, GSOnButtonCheckStateChanged__DelegateSignature_FunctionAddress, "bIsChecked");
		GSOnButtonCheckStateChanged__DelegateSignature_bIsChecked_Offset = NativeReflectionCached.GetPropertyOffset(GSOnButtonCheckStateChanged__DelegateSignature_FunctionAddress, "bIsChecked");
		GSOnButtonCheckStateChanged__DelegateSignature_bIsChecked_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnButtonCheckStateChanged__DelegateSignature_FunctionAddress, "bIsChecked", Classes.FBoolProperty);
		GSOnButtonCheckStateChanged__DelegateSignature_IsValid = GSOnButtonCheckStateChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnButtonCheckStateChanged__DelegateSignature_GSID_IsValid && GSOnButtonCheckStateChanged__DelegateSignature_bIsChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSOnButtonCheckStateChanged__DelegateSignature", GSOnButtonCheckStateChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(int GSID, bool bIsChecked)
	{
		if (!GSOnButtonCheckStateChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSOnButtonCheckStateChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnButtonCheckStateChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnButtonCheckStateChanged__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GSOnButtonCheckStateChanged__DelegateSignature_GSID_Offset), 0, GSOnButtonCheckStateChanged__DelegateSignature_GSID_PropertyAddress.Address, GSID);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, GSOnButtonCheckStateChanged__DelegateSignature_bIsChecked_Offset), 0, GSOnButtonCheckStateChanged__DelegateSignature_bIsChecked_PropertyAddress.Address, bIsChecked);
			ProcessDelegate(intPtr);
		}
	}
}
