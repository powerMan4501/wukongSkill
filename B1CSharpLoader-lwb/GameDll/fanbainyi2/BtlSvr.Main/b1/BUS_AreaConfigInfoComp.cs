using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_AreaConfigInfoComp")]
public class BUS_AreaConfigInfoComp : UActorEditCompBase
{
	private static bool AreaType_IsValid;

	private static int AreaType_Offset;

	private static FFieldAddress AreaType_PropertyAddress;

	private static bool UnitFilter_IsValid;

	private static int UnitFilter_Offset;

	private static bool IngnorePlayerTrans_IsValid;

	private static int IngnorePlayerTrans_Offset;

	private static FFieldAddress IngnorePlayerTrans_PropertyAddress;

	private static bool bAutoEnableOverlap_IsValid;

	private static int bAutoEnableOverlap_Offset;

	private static FFieldAddress bAutoEnableOverlap_PropertyAddress;

	private static bool bNotifyGraph_IsValid;

	private static int bNotifyGraph_Offset;

	private static FFieldAddress bNotifyGraph_PropertyAddress;

	[UProperty]
	[EditDefaultsOnly]
	[BlueprintReadWrite]
	[Category("区域基础配置")]
	[DisplayName("区域类型")]
	[USharpPath("/Script/b1-Managed.BUS_AreaConfigInfoComp:AreaType")]
	public EAreaType AreaType
	{
		get
		{
			CheckDestroyed();
			if (!AreaType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AreaConfigInfoComp:AreaType");
				return EAreaType.SimpleTrigger;
			}
			return EnumMarshaler<EAreaType>.FromNative(IntPtr.Add(base.Address, AreaType_Offset), 0, AreaType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AreaType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AreaConfigInfoComp:AreaType");
			}
			else
			{
				EnumMarshaler<EAreaType>.ToNative(IntPtr.Add(base.Address, AreaType_Offset), 0, AreaType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("区域基础配置")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_AreaConfigInfoComp:UnitFilter")]
	public FAreaUnitFilter UnitFilter
	{
		get
		{
			CheckDestroyed();
			if (!UnitFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AreaConfigInfoComp:UnitFilter");
				return default(FAreaUnitFilter);
			}
			return FAreaUnitFilter.FromNative(IntPtr.Add(base.Address, UnitFilter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AreaConfigInfoComp:UnitFilter");
			}
			else
			{
				FAreaUnitFilter.ToNative(IntPtr.Add(base.Address, UnitFilter_Offset), value);
			}
		}
	}

	[Category("区域基础配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("忽略玩家变身带来得进入退出")]
	[USharpPath("/Script/b1-Managed.BUS_AreaConfigInfoComp:IngnorePlayerTrans")]
	public bool IngnorePlayerTrans
	{
		get
		{
			CheckDestroyed();
			if (!IngnorePlayerTrans_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AreaConfigInfoComp:IngnorePlayerTrans");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IngnorePlayerTrans_Offset), 0, IngnorePlayerTrans_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IngnorePlayerTrans_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AreaConfigInfoComp:IngnorePlayerTrans");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IngnorePlayerTrans_Offset), 0, IngnorePlayerTrans_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("区域基础配置")]
	[DisplayName("默认下激活Overlap事件")]
	[USharpPath("/Script/b1-Managed.BUS_AreaConfigInfoComp:bAutoEnableOverlap")]
	public bool bAutoEnableOverlap
	{
		get
		{
			CheckDestroyed();
			if (!bAutoEnableOverlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AreaConfigInfoComp:bAutoEnableOverlap");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAutoEnableOverlap_Offset), 0, bAutoEnableOverlap_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAutoEnableOverlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AreaConfigInfoComp:bAutoEnableOverlap");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAutoEnableOverlap_Offset), 0, bAutoEnableOverlap_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("通知Graph")]
	[EditAnywhere]
	[Category("区域基础配置")]
	[USharpPath("/Script/b1-Managed.BUS_AreaConfigInfoComp:bNotifyGraph")]
	public bool bNotifyGraph
	{
		get
		{
			CheckDestroyed();
			if (!bNotifyGraph_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AreaConfigInfoComp:bNotifyGraph");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bNotifyGraph_Offset), 0, bNotifyGraph_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bNotifyGraph_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AreaConfigInfoComp:bNotifyGraph");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bNotifyGraph_Offset), 0, bNotifyGraph_PropertyAddress.Address, value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_AreaBasicData bUC_AreaBasicData = RequireWritableData<BUC_AreaBasicData>();
		if (bUC_AreaBasicData != null)
		{
			bUC_AreaBasicData.AreaType = AreaType;
			bUC_AreaBasicData.UnitFilter = UnitFilter;
			bUC_AreaBasicData.IngnorePlayerTrans = IngnorePlayerTrans;
			bUC_AreaBasicData.bAutoEnableOverlap = bAutoEnableOverlap;
			bUC_AreaBasicData.bNotifyGraph = bNotifyGraph;
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		bAutoEnableOverlap = true;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_AreaConfigInfoComp");
		NativeReflection.GetPropertyRef(ref AreaType_PropertyAddress, unrealStruct, "AreaType");
		AreaType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AreaType");
		AreaType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AreaType", Classes.FEnumProperty);
		UnitFilter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitFilter");
		UnitFilter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitFilter", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref IngnorePlayerTrans_PropertyAddress, unrealStruct, "IngnorePlayerTrans");
		IngnorePlayerTrans_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IngnorePlayerTrans");
		IngnorePlayerTrans_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IngnorePlayerTrans", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bAutoEnableOverlap_PropertyAddress, unrealStruct, "bAutoEnableOverlap");
		bAutoEnableOverlap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bAutoEnableOverlap");
		bAutoEnableOverlap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bAutoEnableOverlap", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bNotifyGraph_PropertyAddress, unrealStruct, "bNotifyGraph");
		bNotifyGraph_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bNotifyGraph");
		bNotifyGraph_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bNotifyGraph", Classes.FBoolProperty);
	}

	static BUS_AreaConfigInfoComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_AreaConfigInfoComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_AreaConfigInfoComp));
	}
}
