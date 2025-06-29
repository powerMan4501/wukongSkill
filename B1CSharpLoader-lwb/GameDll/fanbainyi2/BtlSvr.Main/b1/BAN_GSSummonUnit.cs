using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN Summon Unit")]
[USharpPath("/Script/b1-Managed.BAN_GSSummonUnit")]
public class BAN_GSSummonUnit : BAN_GSBase
{
	private static bool SummonID_IsValid;

	private static int SummonID_Offset;

	private static bool SummonPointIndex_IsValid;

	private static int SummonPointIndex_Offset;

	private static bool Command_IsValid;

	private static int Command_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSSummonUnit:SummonID")]
	public int SummonID
	{
		get
		{
			CheckDestroyed();
			if (!SummonID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSummonUnit:SummonID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SummonID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SummonID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSummonUnit:SummonID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SummonID_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSSummonUnit:SummonPointIndex")]
	public int SummonPointIndex
	{
		get
		{
			CheckDestroyed();
			if (!SummonPointIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSummonUnit:SummonPointIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SummonPointIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SummonPointIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSummonUnit:SummonPointIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SummonPointIndex_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSSummonUnit:Command")]
	public string Command
	{
		get
		{
			CheckDestroyed();
			if (!Command_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSummonUnit:Command");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Command_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Command_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSummonUnit:Command");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Command_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSSummonUnit:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner == null) && !(BGU_UnrealWorldUtil.GetActorStreamingLevelWorld(owner) == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SummonSkillCast.Invoke(SummonID, SummonPointIndex, owner, default(FEffectInstReq));
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSSummonUnit:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_GSSummonUnit bAN_GSSummonUnit = GCHelper.Find<BAN_GSSummonUnit>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSSummonUnit.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSSummonUnit");
		SummonID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SummonID");
		SummonID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SummonID", Classes.FIntProperty);
		SummonPointIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "SummonPointIndex");
		SummonPointIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SummonPointIndex", Classes.FIntProperty);
		Command_Offset = NativeReflection.GetPropertyOffset(intPtr, "Command");
		Command_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Command", Classes.FStrProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSSummonUnit:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GSSummonUnit()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAN_GSSummonUnit)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAN_GSSummonUnit));
	}
}
