using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Game")]
[BlueprintType]
[UMetaPath("/Script/AIModule.AIPerceptionStimuliSourceComponent", "AIModule", UnrealModuleType.Engine)]
public class UAIPerceptionStimuliSourceComponent : UActorComponent
{
	private static bool AutoRegisterAsSource_IsValid;

	private static FFieldAddress AutoRegisterAsSource_PropertyAddress;

	private static int AutoRegisterAsSource_Offset;

	private static bool RegisterAsSourceForSenses_IsValid;

	private static FFieldAddress RegisterAsSourceForSenses_PropertyAddress;

	private static int RegisterAsSourceForSenses_Offset;

	private TArrayReadOnlyMarshaler<TSubclassOf<UAISense>> RegisterAsSourceForSenses_MarshalerCached;

	private static bool UnregisterFromSense_IsValid;

	private static IntPtr UnregisterFromSense_FunctionAddress;

	private static int UnregisterFromSense_ParamsSize;

	private static bool UnregisterFromSense_SenseClass_IsValid;

	private static FFieldAddress UnregisterFromSense_SenseClass_PropertyAddress;

	private static int UnregisterFromSense_SenseClass_Offset;

	private static bool UnregisterFromPerceptionSystem_IsValid;

	private static IntPtr UnregisterFromPerceptionSystem_FunctionAddress;

	private static int UnregisterFromPerceptionSystem_ParamsSize;

	private static bool RegisterWithPerceptionSystem_IsValid;

	private static IntPtr RegisterWithPerceptionSystem_FunctionAddress;

	private static int RegisterWithPerceptionSystem_ParamsSize;

	private static bool RegisterForSense_IsValid;

	private static IntPtr RegisterForSense_FunctionAddress;

	private static int RegisterForSense_ParamsSize;

	private static bool RegisterForSense_SenseClass_IsValid;

	private static FFieldAddress RegisterForSense_SenseClass_PropertyAddress;

	private static int RegisterForSense_SenseClass_Offset;

	[UProperty(Flags = (PropFlags)11267863880941589uL)]
	[UMetaPath("/Script/AIModule.AIPerceptionStimuliSourceComponent:bAutoRegisterAsSource")]
	protected bool AutoRegisterAsSource
	{
		get
		{
			CheckDestroyed();
			if (!AutoRegisterAsSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIPerceptionStimuliSourceComponent:bAutoRegisterAsSource");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoRegisterAsSource_Offset), 0, AutoRegisterAsSource_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoRegisterAsSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIPerceptionStimuliSourceComponent:bAutoRegisterAsSource");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoRegisterAsSource_Offset), 0, AutoRegisterAsSource_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)10141895254606357uL)]
	[UMetaPath("/Script/AIModule.AIPerceptionStimuliSourceComponent:RegisterAsSourceForSenses")]
	protected TArrayReadOnly<TSubclassOf<UAISense>> RegisterAsSourceForSenses
	{
		get
		{
			CheckDestroyed();
			if (!RegisterAsSourceForSenses_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIPerceptionStimuliSourceComponent:RegisterAsSourceForSenses");
				return null;
			}
			if (RegisterAsSourceForSenses_MarshalerCached == null)
			{
				RegisterAsSourceForSenses_MarshalerCached = new TArrayReadOnlyMarshaler<TSubclassOf<UAISense>>(1, RegisterAsSourceForSenses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UAISense>, TSubclassOfMarshaler<UAISense>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UAISense>, TSubclassOfMarshaler<UAISense>>.ToNative);
			}
			return RegisterAsSourceForSenses_MarshalerCached.FromNative(IntPtr.Add(base.Address, RegisterAsSourceForSenses_Offset));
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AIModule.AIPerceptionStimuliSourceComponent:UnregisterFromSense")]
	public unsafe void UnregisterFromSense(TSubclassOf<UAISense> SenseClass)
	{
		CheckDestroyed();
		if (!UnregisterFromSense_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIPerceptionStimuliSourceComponent:UnregisterFromSense");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnregisterFromSense_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnregisterFromSense_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UAISense>.ToNative(IntPtr.Add(intPtr, UnregisterFromSense_SenseClass_Offset), 0, UnregisterFromSense_SenseClass_PropertyAddress.Address, SenseClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnregisterFromSense_FunctionAddress, intPtr, UnregisterFromSense_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AIModule.AIPerceptionStimuliSourceComponent:UnregisterFromPerceptionSystem")]
	public unsafe void UnregisterFromPerceptionSystem()
	{
		CheckDestroyed();
		if (!UnregisterFromPerceptionSystem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIPerceptionStimuliSourceComponent:UnregisterFromPerceptionSystem");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnregisterFromPerceptionSystem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnregisterFromPerceptionSystem_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UnregisterFromPerceptionSystem_FunctionAddress, argsSize: UnregisterFromPerceptionSystem_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AIModule.AIPerceptionStimuliSourceComponent:RegisterWithPerceptionSystem")]
	public unsafe void RegisterWithPerceptionSystem()
	{
		CheckDestroyed();
		if (!RegisterWithPerceptionSystem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIPerceptionStimuliSourceComponent:RegisterWithPerceptionSystem");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterWithPerceptionSystem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterWithPerceptionSystem_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RegisterWithPerceptionSystem_FunctionAddress, argsSize: RegisterWithPerceptionSystem_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AIModule.AIPerceptionStimuliSourceComponent:RegisterForSense")]
	public unsafe void RegisterForSense(TSubclassOf<UAISense> SenseClass)
	{
		CheckDestroyed();
		if (!RegisterForSense_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIPerceptionStimuliSourceComponent:RegisterForSense");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterForSense_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterForSense_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UAISense>.ToNative(IntPtr.Add(intPtr, RegisterForSense_SenseClass_Offset), 0, RegisterForSense_SenseClass_PropertyAddress.Address, SenseClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, RegisterForSense_FunctionAddress, intPtr, RegisterForSense_ParamsSize);
	}

	static UAIPerceptionStimuliSourceComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAIPerceptionStimuliSourceComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAIPerceptionStimuliSourceComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AIModule.AIPerceptionStimuliSourceComponent");
		NativeReflectionCached.GetPropertyRef(ref AutoRegisterAsSource_PropertyAddress, intPtr, "bAutoRegisterAsSource");
		AutoRegisterAsSource_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoRegisterAsSource");
		AutoRegisterAsSource_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoRegisterAsSource", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterAsSourceForSenses_PropertyAddress, intPtr, "RegisterAsSourceForSenses");
		RegisterAsSourceForSenses_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RegisterAsSourceForSenses");
		RegisterAsSourceForSenses_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RegisterAsSourceForSenses", Classes.FArrayProperty);
		UnregisterFromSense_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnregisterFromSense");
		UnregisterFromSense_ParamsSize = NativeReflection.GetFunctionParamsSize(UnregisterFromSense_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnregisterFromSense_SenseClass_PropertyAddress, UnregisterFromSense_FunctionAddress, "SenseClass");
		UnregisterFromSense_SenseClass_Offset = NativeReflectionCached.GetPropertyOffset(UnregisterFromSense_FunctionAddress, "SenseClass");
		UnregisterFromSense_SenseClass_IsValid = NativeReflectionCached.ValidatePropertyClass(UnregisterFromSense_FunctionAddress, "SenseClass", Classes.FClassProperty);
		UnregisterFromSense_IsValid = UnregisterFromSense_FunctionAddress != IntPtr.Zero && UnregisterFromSense_SenseClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIPerceptionStimuliSourceComponent:UnregisterFromSense", UnregisterFromSense_IsValid);
		UnregisterFromPerceptionSystem_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnregisterFromPerceptionSystem");
		UnregisterFromPerceptionSystem_ParamsSize = NativeReflection.GetFunctionParamsSize(UnregisterFromPerceptionSystem_FunctionAddress);
		UnregisterFromPerceptionSystem_IsValid = UnregisterFromPerceptionSystem_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIPerceptionStimuliSourceComponent:UnregisterFromPerceptionSystem", UnregisterFromPerceptionSystem_IsValid);
		RegisterWithPerceptionSystem_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RegisterWithPerceptionSystem");
		RegisterWithPerceptionSystem_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterWithPerceptionSystem_FunctionAddress);
		RegisterWithPerceptionSystem_IsValid = RegisterWithPerceptionSystem_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIPerceptionStimuliSourceComponent:RegisterWithPerceptionSystem", RegisterWithPerceptionSystem_IsValid);
		RegisterForSense_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RegisterForSense");
		RegisterForSense_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterForSense_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterForSense_SenseClass_PropertyAddress, RegisterForSense_FunctionAddress, "SenseClass");
		RegisterForSense_SenseClass_Offset = NativeReflectionCached.GetPropertyOffset(RegisterForSense_FunctionAddress, "SenseClass");
		RegisterForSense_SenseClass_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterForSense_FunctionAddress, "SenseClass", Classes.FClassProperty);
		RegisterForSense_IsValid = RegisterForSense_FunctionAddress != IntPtr.Zero && RegisterForSense_SenseClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIPerceptionStimuliSourceComponent:RegisterForSense", RegisterForSense_IsValid);
	}
}
