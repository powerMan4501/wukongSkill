using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.LevelStreamingVisibilityStatus__DelegateSignature")]
public class FLevelStreamingVisibilityStatus : FMulticastDelegate<FLevelStreamingVisibilityStatus.Signature>
{
	public delegate void Signature();

	private static bool LevelStreamingVisibilityStatus__DelegateSignature_IsValid;

	private static IntPtr LevelStreamingVisibilityStatus__DelegateSignature_FunctionAddress;

	private static int LevelStreamingVisibilityStatus__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FLevelStreamingVisibilityStatus()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		LevelStreamingVisibilityStatus__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.LevelStreamingVisibilityStatus__DelegateSignature");
		LevelStreamingVisibilityStatus__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(LevelStreamingVisibilityStatus__DelegateSignature_FunctionAddress);
		LevelStreamingVisibilityStatus__DelegateSignature_IsValid = LevelStreamingVisibilityStatus__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LevelStreamingVisibilityStatus__DelegateSignature", LevelStreamingVisibilityStatus__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!LevelStreamingVisibilityStatus__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelStreamingVisibilityStatus__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(LevelStreamingVisibilityStatus__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LevelStreamingVisibilityStatus__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
