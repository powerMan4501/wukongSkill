using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.GameMode;

[UClass]
[USharpPath("/Script/b1-Managed.BGG_GameModeB1Net")]
public class BGG_GameModeB1Net : BGG_GameModeB1
{
	private static bool PostLoginCS_IsValid;

	private static IntPtr PostLoginCS_FunctionAddress;

	private static int PostLoginCS_ParamsSize;

	private static bool PostLoginCS_NewPlayer_IsValid;

	private static int PostLoginCS_NewPlayer_Offset;

	private static bool BeginPlayCS_IsValid;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	private static bool ReceiveEndPlay_IsValid;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	[USharpPath("/Script/b1-Managed.BGG_GameModeB1Net:PostLoginCS")]
	protected override void PostLoginCS_Implementation(APlayerController NewPlayer)
	{
		base.PostLoginCS_Implementation(NewPlayer);
	}

	[USharpPath("/Script/b1-Managed.BGG_GameModeB1Net:BeginPlayCS")]
	protected override void BeginPlayCS_Implementation()
	{
		base.BeginPlayCS_Implementation();
	}

	[USharpPath("/Script/b1-Managed.BGG_GameModeB1Net:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		base.ReceiveEndPlay_Implementation(EndPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGG_GameModeB1Net:PostLoginCS")]
	private static void PostLoginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGG_GameModeB1Net bGG_GameModeB1Net = GCHelper.Find<BGG_GameModeB1Net>(obj);
		APlayerController newPlayer = UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(buffer, PostLoginCS_NewPlayer_Offset));
		bGG_GameModeB1Net.PostLoginCS_Implementation(newPlayer);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGG_GameModeB1Net:BeginPlayCS")]
	private static void BeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGG_GameModeB1Net bGG_GameModeB1Net = GCHelper.Find<BGG_GameModeB1Net>(obj);
		bGG_GameModeB1Net.BeginPlayCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGG_GameModeB1Net:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGG_GameModeB1Net bGG_GameModeB1Net = GCHelper.Find<BGG_GameModeB1Net>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		bGG_GameModeB1Net.ReceiveEndPlay_Implementation(endPlayReason);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGG_GameModeB1Net");
		PostLoginCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PostLoginCS");
		PostLoginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostLoginCS_FunctionAddress);
		PostLoginCS_NewPlayer_Offset = NativeReflection.GetPropertyOffset(PostLoginCS_FunctionAddress, "NewPlayer");
		PostLoginCS_NewPlayer_IsValid = NativeReflection.ValidatePropertyClass(PostLoginCS_FunctionAddress, "NewPlayer", Classes.FObjectProperty);
		PostLoginCS_IsValid = PostLoginCS_FunctionAddress != IntPtr.Zero && PostLoginCS_NewPlayer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGG_GameModeB1Net:PostLoginCS", PostLoginCS_IsValid);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGG_GameModeB1Net:BeginPlayCS", BeginPlayCS_IsValid);
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGG_GameModeB1Net:ReceiveEndPlay", ReceiveEndPlay_IsValid);
	}

	static BGG_GameModeB1Net()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGG_GameModeB1Net)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGG_GameModeB1Net));
	}
}
