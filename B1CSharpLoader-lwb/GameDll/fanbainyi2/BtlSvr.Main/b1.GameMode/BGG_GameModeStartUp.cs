using System;
using UnrealEngine.Runtime;

namespace b1.GameMode;

[UClass]
[USharpPath("/Script/b1-Managed.BGG_GameModeStartUp")]
public class BGG_GameModeStartUp : BGG_GameMode
{
	private static bool GameDefaultMapID_IsValid;

	private static int GameDefaultMapID_Offset;

	private static bool BeginPlayCS_IsValid;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGG_GameModeStartUp:GameDefaultMapID")]
	public int GameDefaultMapID
	{
		get
		{
			CheckDestroyed();
			if (!GameDefaultMapID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGG_GameModeStartUp:GameDefaultMapID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, GameDefaultMapID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GameDefaultMapID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGG_GameModeStartUp:GameDefaultMapID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, GameDefaultMapID_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize();
		base.ActorCompContainerCS = initializer.CreateDefaultSubobject<UActorCompContainerCS>(this, B1GlobalFNames.ActorCompContainerCS);
		CreateDataContainer(initializer);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BGG_GameModeDataCompStartUp>(this, B1GlobalFNames.GameModeDataCompStartUp);
	}

	[USharpPath("/Script/b1-Managed.BGG_GameModeStartUp:BeginPlayCS")]
	protected override void BeginPlayCS_Implementation()
	{
		base.BeginPlayCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGG_GameModeStartUp:BeginPlayCS")]
	private static void BeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGG_GameModeStartUp bGG_GameModeStartUp = GCHelper.Find<BGG_GameModeStartUp>(obj);
		bGG_GameModeStartUp.BeginPlayCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGG_GameModeStartUp");
		GameDefaultMapID_Offset = NativeReflection.GetPropertyOffset(intPtr, "GameDefaultMapID");
		GameDefaultMapID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GameDefaultMapID", Classes.FIntProperty);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGG_GameModeStartUp:BeginPlayCS", BeginPlayCS_IsValid);
	}

	static BGG_GameModeStartUp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGG_GameModeStartUp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGG_GameModeStartUp));
	}
}
