using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.BUActor;

[BlueprintType]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.BGWTeleportNamedPoint")]
public class BGWTeleportNamedPoint : ABGUTeleportPoint
{
	private static bool TeleportID_IsValid;

	private static int TeleportID_Offset;

	private static bool ReceiveEndPlay_IsValid;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("别名")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWTeleportNamedPoint:TeleportID")]
	public FName TeleportID
	{
		get
		{
			CheckDestroyed();
			if (!TeleportID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWTeleportNamedPoint:TeleportID");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, TeleportID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TeleportID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWTeleportNamedPoint:TeleportID");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, TeleportID_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BGWTeleportNamedPoint:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
		FTeleportInfo fTeleportInfo = new FTeleportInfo();
		fTeleportInfo.TeleportID = TeleportID;
		fTeleportInfo.Location = GetActorLocation();
		fTeleportInfo.Rotation = GetActorRotation();
		BGW_EventCollection.Get(this).Evt_RegisterTeleport(fTeleportInfo);
		ULevel level = GetLevel();
		if (level != null && !level.GetFName().ToString().Contains("PersistentLevel"))
		{
			BGW_LogUtil.LogError(GetPathName() + "应该配置在PersistentLevel, 请检查");
		}
	}

	[USharpPath("/Script/b1-Managed.BGWTeleportNamedPoint:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		BGW_EventCollection.Get(this).Evt_UnregisterTeleport(TeleportID);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWTeleportNamedPoint:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWTeleportNamedPoint bGWTeleportNamedPoint = GCHelper.Find<BGWTeleportNamedPoint>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		bGWTeleportNamedPoint.ReceiveEndPlay_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWTeleportNamedPoint:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWTeleportNamedPoint bGWTeleportNamedPoint = GCHelper.Find<BGWTeleportNamedPoint>(obj);
		bGWTeleportNamedPoint.ReceiveBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGWTeleportNamedPoint");
		TeleportID_Offset = NativeReflection.GetPropertyOffset(intPtr, "TeleportID");
		TeleportID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TeleportID", Classes.FNameProperty);
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWTeleportNamedPoint:ReceiveEndPlay", ReceiveEndPlay_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWTeleportNamedPoint:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
	}

	static BGWTeleportNamedPoint()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWTeleportNamedPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWTeleportNamedPoint));
	}
}
