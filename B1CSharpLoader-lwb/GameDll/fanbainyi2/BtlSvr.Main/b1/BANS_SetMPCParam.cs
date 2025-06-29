using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Set MPC Param")]
[USharpPath("/Script/b1-Managed.BANS_SetMPCParam")]
internal class BANS_SetMPCParam : BANS_GSBase
{
	private static bool MPC_IsValid;

	private static int MPC_Offset;

	private static bool FloatParams_IsValid;

	private static int FloatParams_Offset;

	private static FFieldAddress FloatParams_PropertyAddress;

	private TMapReadWriteMarshaler<string, UCurveFloat> FloatParams_Marshaler;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_SetMPCParam:MPC")]
	public UMaterialParameterCollection MPC
	{
		get
		{
			CheckDestroyed();
			if (!MPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SetMPCParam:MPC");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, MPC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SetMPCParam:MPC");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, MPC_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_SetMPCParam:FloatParams")]
	public TMapReadWrite<string, UCurveFloat> FloatParams
	{
		get
		{
			CheckDestroyed();
			if (!FloatParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_SetMPCParam:FloatParams");
				return null;
			}
			if (FloatParams_Marshaler == null)
			{
				FloatParams_Marshaler = new TMapReadWriteMarshaler<string, UCurveFloat>(1, FloatParams_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<UCurveFloat, UObjectMarshaler<UCurveFloat>>.FromNative, CachedMarshalingDelegates<UCurveFloat, UObjectMarshaler<UCurveFloat>>.ToNative);
			}
			return FloatParams_Marshaler.FromNative(IntPtr.Add(base.Address, FloatParams_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_SetMPCParam:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NotifyParam.owner);
		if (!(bUS_GSEventCollection != null))
		{
			return;
		}
		foreach (KeyValuePair<string, UCurveFloat> floatParam in FloatParams)
		{
			string key = floatParam.Key;
			UCurveFloat value = floatParam.Value;
			value.GetTimeRange(out var MinTime, out var MaxTime);
			float floatValue = value.GetFloatValue(MaxTime);
			bUS_GSEventCollection.Evt_TriggerMPCScalarParamTickWithObj.Invoke(MPC, key, value, MaxTime - MinTime, floatValue);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_SetMPCParam:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_SetMPCParam bANS_SetMPCParam = GCHelper.Find<b1.BANS_SetMPCParam>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_SetMPCParam.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_SetMPCParam");
		MPC_Offset = NativeReflection.GetPropertyOffset(intPtr, "MPC");
		MPC_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MPC", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref FloatParams_PropertyAddress, intPtr, "FloatParams");
		FloatParams_Offset = NativeReflection.GetPropertyOffset(intPtr, "FloatParams");
		FloatParams_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FloatParams", Classes.FMapProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_SetMPCParam:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_SetMPCParam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_SetMPCParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_SetMPCParam));
	}
}
