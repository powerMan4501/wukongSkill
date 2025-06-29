using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[UDelegate]
[UMetaPath("/Script/V8.DirectoryWatcherCallback__DelegateSignature")]
public class FDirectoryWatcherCallback : FMulticastDelegate<FDirectoryWatcherCallback.Signature>
{
	public delegate void Signature();

	private static bool DirectoryWatcherCallback__DelegateSignature_IsValid;

	private static IntPtr DirectoryWatcherCallback__DelegateSignature_FunctionAddress;

	private static int DirectoryWatcherCallback__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FDirectoryWatcherCallback()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		DirectoryWatcherCallback__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/V8.DirectoryWatcherCallback__DelegateSignature");
		DirectoryWatcherCallback__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(DirectoryWatcherCallback__DelegateSignature_FunctionAddress);
		DirectoryWatcherCallback__DelegateSignature_IsValid = DirectoryWatcherCallback__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/V8.DirectoryWatcherCallback__DelegateSignature", DirectoryWatcherCallback__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!DirectoryWatcherCallback__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.DirectoryWatcherCallback__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(DirectoryWatcherCallback__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DirectoryWatcherCallback__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
