using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEditorUMG;

[UDelegate]
[UMetaPath("/Script/GSEditorUMG.GSOnPathPicked__DelegateSignature")]
public class FGSOnPathPicked : FMulticastDelegate<FGSOnPathPicked.Signature>
{
	public delegate void Signature(string FilePath);

	private static bool GSOnPathPicked__DelegateSignature_IsValid;

	private static IntPtr GSOnPathPicked__DelegateSignature_FunctionAddress;

	private static int GSOnPathPicked__DelegateSignature_ParamsSize;

	private static bool GSOnPathPicked__DelegateSignature_FilePath_IsValid;

	private static FFieldAddress GSOnPathPicked__DelegateSignature_FilePath_PropertyAddress;

	private static int GSOnPathPicked__DelegateSignature_FilePath_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnPathPicked()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnPathPicked__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSEditorUMG.GSOnPathPicked__DelegateSignature");
		GSOnPathPicked__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnPathPicked__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnPathPicked__DelegateSignature_FilePath_PropertyAddress, GSOnPathPicked__DelegateSignature_FunctionAddress, "FilePath");
		GSOnPathPicked__DelegateSignature_FilePath_Offset = NativeReflectionCached.GetPropertyOffset(GSOnPathPicked__DelegateSignature_FunctionAddress, "FilePath");
		GSOnPathPicked__DelegateSignature_FilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnPathPicked__DelegateSignature_FunctionAddress, "FilePath", Classes.FStrProperty);
		GSOnPathPicked__DelegateSignature_IsValid = GSOnPathPicked__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnPathPicked__DelegateSignature_FilePath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEditorUMG.GSOnPathPicked__DelegateSignature", GSOnPathPicked__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(string FilePath)
	{
		if (!GSOnPathPicked__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEditorUMG.GSOnPathPicked__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnPathPicked__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnPathPicked__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, GSOnPathPicked__DelegateSignature_FilePath_Offset), 0, GSOnPathPicked__DelegateSignature_FilePath_PropertyAddress.Address, FilePath);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(GSOnPathPicked__DelegateSignature_FilePath_PropertyAddress.Address, intPtr);
		}
	}
}
