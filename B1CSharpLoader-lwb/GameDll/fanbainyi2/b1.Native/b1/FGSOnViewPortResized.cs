using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/UnrealExtent.GSOnViewPortResized__DelegateSignature")]
public class FGSOnViewPortResized : FMulticastDelegate<FGSOnViewPortResized.Signature>
{
	public delegate void Signature(int NewWidth, int NewHeight);

	private static bool GSOnViewPortResized__DelegateSignature_IsValid;

	private static IntPtr GSOnViewPortResized__DelegateSignature_FunctionAddress;

	private static int GSOnViewPortResized__DelegateSignature_ParamsSize;

	private static bool GSOnViewPortResized__DelegateSignature_NewWidth_IsValid;

	private static FFieldAddress GSOnViewPortResized__DelegateSignature_NewWidth_PropertyAddress;

	private static int GSOnViewPortResized__DelegateSignature_NewWidth_Offset;

	private static bool GSOnViewPortResized__DelegateSignature_NewHeight_IsValid;

	private static FFieldAddress GSOnViewPortResized__DelegateSignature_NewHeight_PropertyAddress;

	private static int GSOnViewPortResized__DelegateSignature_NewHeight_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnViewPortResized()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnViewPortResized__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UnrealExtent.GSOnViewPortResized__DelegateSignature");
		GSOnViewPortResized__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnViewPortResized__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnViewPortResized__DelegateSignature_NewWidth_PropertyAddress, GSOnViewPortResized__DelegateSignature_FunctionAddress, "NewWidth");
		GSOnViewPortResized__DelegateSignature_NewWidth_Offset = NativeReflectionCached.GetPropertyOffset(GSOnViewPortResized__DelegateSignature_FunctionAddress, "NewWidth");
		GSOnViewPortResized__DelegateSignature_NewWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnViewPortResized__DelegateSignature_FunctionAddress, "NewWidth", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GSOnViewPortResized__DelegateSignature_NewHeight_PropertyAddress, GSOnViewPortResized__DelegateSignature_FunctionAddress, "NewHeight");
		GSOnViewPortResized__DelegateSignature_NewHeight_Offset = NativeReflectionCached.GetPropertyOffset(GSOnViewPortResized__DelegateSignature_FunctionAddress, "NewHeight");
		GSOnViewPortResized__DelegateSignature_NewHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnViewPortResized__DelegateSignature_FunctionAddress, "NewHeight", Classes.FIntProperty);
		GSOnViewPortResized__DelegateSignature_IsValid = GSOnViewPortResized__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnViewPortResized__DelegateSignature_NewWidth_IsValid && GSOnViewPortResized__DelegateSignature_NewHeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSOnViewPortResized__DelegateSignature", GSOnViewPortResized__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(int NewWidth, int NewHeight)
	{
		if (!GSOnViewPortResized__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSOnViewPortResized__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnViewPortResized__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnViewPortResized__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GSOnViewPortResized__DelegateSignature_NewWidth_Offset), 0, GSOnViewPortResized__DelegateSignature_NewWidth_PropertyAddress.Address, NewWidth);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GSOnViewPortResized__DelegateSignature_NewHeight_Offset), 0, GSOnViewPortResized__DelegateSignature_NewHeight_PropertyAddress.Address, NewHeight);
			ProcessDelegate(intPtr);
		}
	}
}
