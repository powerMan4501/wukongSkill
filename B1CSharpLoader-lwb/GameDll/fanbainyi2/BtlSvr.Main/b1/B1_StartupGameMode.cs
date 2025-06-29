using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.B1_StartupGameMode")]
public class B1_StartupGameMode : AGameModeBase
{
	private static bool ReceiveEndPlay_IsValid;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	[USharpPath("/Script/b1-Managed.B1_StartupGameMode:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		base.ReceiveEndPlay_Implementation(EndPlayReason);
		if (EndPlayReason == EEndPlayReason.LevelTransition)
		{
			UB1Util.SetStartupConfigEnable(bEnable: true);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.B1_StartupGameMode:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		B1_StartupGameMode b1_StartupGameMode = GCHelper.Find<B1_StartupGameMode>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		b1_StartupGameMode.ReceiveEndPlay_Implementation(endPlayReason);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.B1_StartupGameMode");
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.B1_StartupGameMode:ReceiveEndPlay", ReceiveEndPlay_IsValid);
	}

	static B1_StartupGameMode()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(B1_StartupGameMode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(B1_StartupGameMode));
	}
}
