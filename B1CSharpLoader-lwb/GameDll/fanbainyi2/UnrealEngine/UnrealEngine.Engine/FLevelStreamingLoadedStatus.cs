using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.LevelStreamingLoadedStatus__DelegateSignature")]
public class FLevelStreamingLoadedStatus : FMulticastDelegate<FLevelStreamingLoadedStatus.Signature>
{
	public delegate void Signature();

	private static bool LevelStreamingLoadedStatus__DelegateSignature_IsValid;

	private static IntPtr LevelStreamingLoadedStatus__DelegateSignature_FunctionAddress;

	private static int LevelStreamingLoadedStatus__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FLevelStreamingLoadedStatus()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		LevelStreamingLoadedStatus__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.LevelStreamingLoadedStatus__DelegateSignature");
		LevelStreamingLoadedStatus__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(LevelStreamingLoadedStatus__DelegateSignature_FunctionAddress);
		LevelStreamingLoadedStatus__DelegateSignature_IsValid = LevelStreamingLoadedStatus__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LevelStreamingLoadedStatus__DelegateSignature", LevelStreamingLoadedStatus__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!LevelStreamingLoadedStatus__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LevelStreamingLoadedStatus__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(LevelStreamingLoadedStatus__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LevelStreamingLoadedStatus__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
