using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Blend Physic")]
[USharpPath("/Script/b1-Managed.BANS_GSBlendPhysic")]
internal class BANS_GSBlendPhysic : BANS_GSBase
{
	private static bool PhysicBlendInfoArray_IsValid;

	private static int PhysicBlendInfoArray_Offset;

	private static FFieldAddress PhysicBlendInfoArray_PropertyAddress;

	private TArrayReadWriteMarshaler<FPhysicBlendInfo> PhysicBlendInfoArray_Marshaler;

	private static bool EnableSimulate_IsValid;

	private static int EnableSimulate_Offset;

	private static FFieldAddress EnableSimulate_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSBlendPhysic:PhysicBlendInfoArray")]
	public TArrayReadWrite<FPhysicBlendInfo> PhysicBlendInfoArray
	{
		get
		{
			CheckDestroyed();
			if (!PhysicBlendInfoArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSBlendPhysic:PhysicBlendInfoArray");
				return null;
			}
			if (PhysicBlendInfoArray_Marshaler == null)
			{
				PhysicBlendInfoArray_Marshaler = new TArrayReadWriteMarshaler<FPhysicBlendInfo>(1, PhysicBlendInfoArray_PropertyAddress, CachedMarshalingDelegates<FPhysicBlendInfo, FPhysicBlendInfo>.FromNative, CachedMarshalingDelegates<FPhysicBlendInfo, FPhysicBlendInfo>.ToNative);
			}
			return PhysicBlendInfoArray_Marshaler.FromNative(IntPtr.Add(base.Address, PhysicBlendInfoArray_Offset));
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Tooltip("开模拟：BlendWeight从0到1， 反之从1到0")]
	[USharpPath("/Script/b1-Managed.BANS_GSBlendPhysic:EnableSimulate")]
	public bool EnableSimulate
	{
		get
		{
			CheckDestroyed();
			if (!EnableSimulate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSBlendPhysic:EnableSimulate");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableSimulate_Offset), 0, EnableSimulate_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableSimulate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSBlendPhysic:EnableSimulate");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableSimulate_Offset), 0, EnableSimulate_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		EnableSimulate = true;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSBlendPhysic:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		if (owner != null)
		{
			ACharacter aCharacter = owner as ACharacter;
			if (aCharacter != null)
			{
				BUS_EventCollectionCS.Get(aCharacter).Evt_ActivatePhysicBlend.Invoke(PhysicBlendInfoArray.ToList(), EnableSimulate, TotalDuration);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSBlendPhysic:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSBlendPhysic bANS_GSBlendPhysic = GCHelper.Find<b1.BANS_GSBlendPhysic>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSBlendPhysic.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSBlendPhysic");
		NativeReflection.GetPropertyRef(ref PhysicBlendInfoArray_PropertyAddress, intPtr, "PhysicBlendInfoArray");
		PhysicBlendInfoArray_Offset = NativeReflection.GetPropertyOffset(intPtr, "PhysicBlendInfoArray");
		PhysicBlendInfoArray_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PhysicBlendInfoArray", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref EnableSimulate_PropertyAddress, intPtr, "EnableSimulate");
		EnableSimulate_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableSimulate");
		EnableSimulate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableSimulate", Classes.FBoolProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSBlendPhysic:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSBlendPhysic()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSBlendPhysic)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSBlendPhysic));
	}
}
