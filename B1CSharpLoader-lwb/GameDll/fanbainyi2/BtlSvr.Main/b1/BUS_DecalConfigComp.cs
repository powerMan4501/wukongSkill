using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_DecalConfigComp")]
public class BUS_DecalConfigComp : UActorEditCompBase
{
	private static bool FloatCurveList_IsValid;

	private static int FloatCurveList_Offset;

	private static FFieldAddress FloatCurveList_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSFloatCurveToParam> FloatCurveList_Marshaler;

	private static bool LinearColorCurveList_IsValid;

	private static int LinearColorCurveList_Offset;

	private static FFieldAddress LinearColorCurveList_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSLinearColorCurveToParam> LinearColorCurveList_Marshaler;

	[DisplayName("Float参数曲线")]
	[Category("贴花参数配置")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_DecalConfigComp:FloatCurveList")]
	public TArrayReadWrite<FGSFloatCurveToParam> FloatCurveList
	{
		get
		{
			CheckDestroyed();
			if (!FloatCurveList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DecalConfigComp:FloatCurveList");
				return null;
			}
			if (FloatCurveList_Marshaler == null)
			{
				FloatCurveList_Marshaler = new TArrayReadWriteMarshaler<FGSFloatCurveToParam>(1, FloatCurveList_PropertyAddress, CachedMarshalingDelegates<FGSFloatCurveToParam, FGSFloatCurveToParam>.FromNative, CachedMarshalingDelegates<FGSFloatCurveToParam, FGSFloatCurveToParam>.ToNative);
			}
			return FloatCurveList_Marshaler.FromNative(IntPtr.Add(base.Address, FloatCurveList_Offset));
		}
	}

	[UProperty]
	[DisplayName("LinearColor参数曲线")]
	[Category("贴花参数配置")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_DecalConfigComp:LinearColorCurveList")]
	public TArrayReadWrite<FGSLinearColorCurveToParam> LinearColorCurveList
	{
		get
		{
			CheckDestroyed();
			if (!LinearColorCurveList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DecalConfigComp:LinearColorCurveList");
				return null;
			}
			if (LinearColorCurveList_Marshaler == null)
			{
				LinearColorCurveList_Marshaler = new TArrayReadWriteMarshaler<FGSLinearColorCurveToParam>(1, LinearColorCurveList_PropertyAddress, CachedMarshalingDelegates<FGSLinearColorCurveToParam, FGSLinearColorCurveToParam>.FromNative, CachedMarshalingDelegates<FGSLinearColorCurveToParam, FGSLinearColorCurveToParam>.ToNative);
			}
			return LinearColorCurveList_Marshaler.FromNative(IntPtr.Add(base.Address, LinearColorCurveList_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_DecalConfigData bUC_DecalConfigData = RequireWritableData<b1.BUC_DecalConfigData>();
		foreach (FGSFloatCurveToParam floatCurve in FloatCurveList)
		{
			FGSFloatCurveToParam InConfig = floatCurve;
			bUC_DecalConfigData.FloatCurveList.Add(new b1.GSFloatCurveToParam(in InConfig));
		}
		foreach (FGSLinearColorCurveToParam linearColorCurve in LinearColorCurveList)
		{
			FGSLinearColorCurveToParam InConfig2 = linearColorCurve;
			bUC_DecalConfigData.LinearColorCurveList.Add(new b1.GSLinearColorCurveToParam(in InConfig2));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_DecalConfigComp");
		NativeReflection.GetPropertyRef(ref FloatCurveList_PropertyAddress, unrealStruct, "FloatCurveList");
		FloatCurveList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FloatCurveList");
		FloatCurveList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FloatCurveList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref LinearColorCurveList_PropertyAddress, unrealStruct, "LinearColorCurveList");
		LinearColorCurveList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LinearColorCurveList");
		LinearColorCurveList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LinearColorCurveList", Classes.FArrayProperty);
	}

	static BUS_DecalConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_DecalConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_DecalConfigComp));
	}
}
