using System;
using System.Collections.Generic;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Blueprintable]
[BlueprintType]
[USharpPath("/Script/b1-Managed.B1X2_DispWorld")]
public class B1X2_DispWorld : DispLibEntityBase
{
	protected static Dictionary<UWorld, B1X2_DispWorld> s_instance;

	private static bool ReceiveEndPlay_IsValid;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	public override int ECSArcheType => 12;

	[USharpPath("/Script/b1-Managed.B1X2_DispWorld:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		base.ReceiveEndPlay_Implementation(EndPlayReason);
		if (s_instance.TryGetValue(UEngine.GEngine.GetWorldFromContextObject(this), out var _))
		{
			s_instance.Remove(UEngine.GEngine.GetWorldFromContextObject(this));
		}
	}

	public static B1X2_DispWorld GetInstance(UObject WorldCtx)
	{
		if (WorldCtx.IsNullOrDestroyed())
		{
			return null;
		}
		if (UGameplayStatics.GetGameInstance(WorldCtx) == null)
		{
			return null;
		}
		if (!s_instance.TryGetValue(UEngine.GEngine.GetWorldFromContextObject(WorldCtx), out var value))
		{
			return null;
		}
		if (value.IsNullOrDestroyed())
		{
			s_instance.Remove(UEngine.GEngine.GetWorldFromContextObject(WorldCtx));
			return null;
		}
		return value;
	}

	public static DispLibPlayingEnv GetPlayingEnv()
	{
		if (UGSE_EngineFuncLib.IsEditor())
		{
			if (s_instance == null)
			{
				return DispLibPlayingEnv.EditorCustomScene;
			}
			return DispLibPlayingEnv.EditorGame;
		}
		return DispLibPlayingEnv.Real;
	}

	public static B1X2_DispWorld InstanceInit(UObject WorldContext)
	{
		s_instance.TryGetValue(UEngine.GEngine.GetWorldFromContextObject(WorldContext), out var value);
		if (!value.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("[DispLib] Multi Init DLDWorld");
			BGU_UnrealWorldUtil.DestroyActor(value);
		}
		if (BGW_DispLibGameDB.GameDBDataAsset.IsNullOrDestroyed() || BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.IsNullOrDestroyed() || BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DLDWorld_BP == default(TSubclassOf<DispLibDispWorld>))
		{
			return null;
		}
		B1X2_DispWorld b1X2_DispWorld = BGU_UnrealWorldUtil.SpawnActor<B1X2_DispWorld>(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext));
		if (b1X2_DispWorld != null)
		{
			s_instance[UEngine.GEngine.GetWorldFromContextObject(b1X2_DispWorld)] = b1X2_DispWorld;
		}
		return b1X2_DispWorld;
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.B1X2_DispWorldDataComp>(this, B1GlobalFNames.UBGUDataComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		BGW_ECSWorld bGW_ECSWorld = BGW_ECSWorld.Get(this);
		if (bGW_ECSWorld != null)
		{
			bGW_ECSWorld.SetObject(GetECSEntity(), new BWS_DispLibEventCollection());
			base.ActorCompContainerCS.AddComp(new b1.BWC_B1X2_DispFillLibDataSystem());
			bGW_ECSWorld.GetObject<BWC_DispLibCameraData>(DispLibDispWorld.GetInstance(this).GetECSEntity()).Init(this);
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	static B1X2_DispWorld()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(B1X2_DispWorld)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(B1X2_DispWorld));
		s_instance = new Dictionary<UWorld, B1X2_DispWorld>();
	}

	[UFunctionInvoker("/Script/b1-Managed.B1X2_DispWorld:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		B1X2_DispWorld b1X2_DispWorld = GCHelper.Find<B1X2_DispWorld>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		b1X2_DispWorld.ReceiveEndPlay_Implementation(endPlayReason);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.B1X2_DispWorld");
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.B1X2_DispWorld:ReceiveEndPlay", ReceiveEndPlay_IsValid);
	}
}
