using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.GameplayTasks;

[UDelegate]
[UMetaPath("/Script/GameplayTasks.GameplayTaskSpawnActorDelegate__DelegateSignature")]
public class FGameplayTaskSpawnActorDelegate : FMulticastDelegate<FGameplayTaskSpawnActorDelegate.Signature>
{
	public delegate void Signature(AActor SpawnedActor);

	private static bool GameplayTaskSpawnActorDelegate__DelegateSignature_IsValid;

	private static IntPtr GameplayTaskSpawnActorDelegate__DelegateSignature_FunctionAddress;

	private static int GameplayTaskSpawnActorDelegate__DelegateSignature_ParamsSize;

	private static bool GameplayTaskSpawnActorDelegate__DelegateSignature_SpawnedActor_IsValid;

	private static FFieldAddress GameplayTaskSpawnActorDelegate__DelegateSignature_SpawnedActor_PropertyAddress;

	private static int GameplayTaskSpawnActorDelegate__DelegateSignature_SpawnedActor_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGameplayTaskSpawnActorDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GameplayTaskSpawnActorDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GameplayTasks.GameplayTaskSpawnActorDelegate__DelegateSignature");
		GameplayTaskSpawnActorDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GameplayTaskSpawnActorDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GameplayTaskSpawnActorDelegate__DelegateSignature_SpawnedActor_PropertyAddress, GameplayTaskSpawnActorDelegate__DelegateSignature_FunctionAddress, "SpawnedActor");
		GameplayTaskSpawnActorDelegate__DelegateSignature_SpawnedActor_Offset = NativeReflectionCached.GetPropertyOffset(GameplayTaskSpawnActorDelegate__DelegateSignature_FunctionAddress, "SpawnedActor");
		GameplayTaskSpawnActorDelegate__DelegateSignature_SpawnedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GameplayTaskSpawnActorDelegate__DelegateSignature_FunctionAddress, "SpawnedActor", Classes.FObjectProperty);
		GameplayTaskSpawnActorDelegate__DelegateSignature_IsValid = GameplayTaskSpawnActorDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && GameplayTaskSpawnActorDelegate__DelegateSignature_SpawnedActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTasks.GameplayTaskSpawnActorDelegate__DelegateSignature", GameplayTaskSpawnActorDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(AActor SpawnedActor)
	{
		if (!GameplayTaskSpawnActorDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTasks.GameplayTaskSpawnActorDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GameplayTaskSpawnActorDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GameplayTaskSpawnActorDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GameplayTaskSpawnActorDelegate__DelegateSignature_SpawnedActor_Offset), 0, GameplayTaskSpawnActorDelegate__DelegateSignature_SpawnedActor_PropertyAddress.Address, SpawnedActor);
			ProcessDelegate(intPtr);
		}
	}
}
