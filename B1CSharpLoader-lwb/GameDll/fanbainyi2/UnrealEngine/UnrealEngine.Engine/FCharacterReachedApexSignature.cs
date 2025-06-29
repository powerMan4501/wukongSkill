using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.CharacterReachedApexSignature__DelegateSignature")]
public class FCharacterReachedApexSignature : FMulticastDelegate<FCharacterReachedApexSignature.Signature>
{
	public delegate void Signature();

	private static bool CharacterReachedApexSignature__DelegateSignature_IsValid;

	private static IntPtr CharacterReachedApexSignature__DelegateSignature_FunctionAddress;

	private static int CharacterReachedApexSignature__DelegateSignature_ParamsSize;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FCharacterReachedApexSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		CharacterReachedApexSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.CharacterReachedApexSignature__DelegateSignature");
		CharacterReachedApexSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(CharacterReachedApexSignature__DelegateSignature_FunctionAddress);
		CharacterReachedApexSignature__DelegateSignature_IsValid = CharacterReachedApexSignature__DelegateSignature_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CharacterReachedApexSignature__DelegateSignature", CharacterReachedApexSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker()
	{
		if (!CharacterReachedApexSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CharacterReachedApexSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(CharacterReachedApexSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CharacterReachedApexSignature__DelegateSignature_ParamsSize);
			IntPtr parameters = new IntPtr(ptr2);
			ProcessDelegate(parameters);
		}
	}
}
