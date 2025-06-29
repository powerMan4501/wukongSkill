using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_TriggerProcessControlComp")]
internal class BUS_TriggerProcessControlComp : UActorEditCompBase
{
	private static bool AttachedTriggerObjs_IsValid;

	private static int AttachedTriggerObjs_Offset;

	private static FFieldAddress AttachedTriggerObjs_PropertyAddress;

	private TArrayReadWriteMarshaler<FSceneObjWithState> AttachedTriggerObjs_Marshaler;

	private static bool NeedActivateObjs_IsValid;

	private static int NeedActivateObjs_Offset;

	private static FFieldAddress NeedActivateObjs_PropertyAddress;

	private TArrayReadWriteMarshaler<FSceneObjTriggerEvent> NeedActivateObjs_Marshaler;

	[EditAnywhere]
	[UProperty]
	[Category("Process Config")]
	[USharpPath("/Script/b1-Managed.BUS_TriggerProcessControlComp:AttachedTriggerObjs")]
	public TArrayReadWrite<FSceneObjWithState> AttachedTriggerObjs
	{
		get
		{
			CheckDestroyed();
			if (!AttachedTriggerObjs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerProcessControlComp:AttachedTriggerObjs");
				return null;
			}
			if (AttachedTriggerObjs_Marshaler == null)
			{
				AttachedTriggerObjs_Marshaler = new TArrayReadWriteMarshaler<FSceneObjWithState>(1, AttachedTriggerObjs_PropertyAddress, CachedMarshalingDelegates<FSceneObjWithState, FSceneObjWithState>.FromNative, CachedMarshalingDelegates<FSceneObjWithState, FSceneObjWithState>.ToNative);
			}
			return AttachedTriggerObjs_Marshaler.FromNative(IntPtr.Add(base.Address, AttachedTriggerObjs_Offset));
		}
	}

	[Category("Process Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_TriggerProcessControlComp:NeedActivateObjs")]
	public TArrayReadWrite<FSceneObjTriggerEvent> NeedActivateObjs
	{
		get
		{
			CheckDestroyed();
			if (!NeedActivateObjs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_TriggerProcessControlComp:NeedActivateObjs");
				return null;
			}
			if (NeedActivateObjs_Marshaler == null)
			{
				NeedActivateObjs_Marshaler = new TArrayReadWriteMarshaler<FSceneObjTriggerEvent>(1, NeedActivateObjs_PropertyAddress, CachedMarshalingDelegates<FSceneObjTriggerEvent, FSceneObjTriggerEvent>.FromNative, CachedMarshalingDelegates<FSceneObjTriggerEvent, FSceneObjTriggerEvent>.ToNative);
			}
			return NeedActivateObjs_Marshaler.FromNative(IntPtr.Add(base.Address, NeedActivateObjs_Offset));
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_TriggerProcessControllerData bUC_TriggerProcessControllerData = RequireWritableData<b1.BUC_TriggerProcessControllerData>();
		bUC_TriggerProcessControllerData.AttachedTriggerObjs = AttachedTriggerObjs.ToList();
		bUC_TriggerProcessControllerData.NeedActivateObjs = NeedActivateObjs.ToList();
		bUC_TriggerProcessControllerData.MapObjIndexActiveState = new Dictionary<int, bool>();
		for (int i = 0; i < NeedActivateObjs.Count; i++)
		{
			bUC_TriggerProcessControllerData.MapObjIndexActiveState.Add(i, value: false);
		}
	}

	public void AttachTriggerObj(in FSceneObjWithState TriggerObj)
	{
		bool flag = false;
		for (int i = 0; i < AttachedTriggerObjs.Count; i++)
		{
			if (AttachedTriggerObjs[i].UnitGuid == TriggerObj.UnitGuid)
			{
				AttachedTriggerObjs[i] = TriggerObj;
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			AttachedTriggerObjs.Add(TriggerObj);
		}
	}

	public void AddNeedActivateObj(in FSceneObjTriggerEvent Obj)
	{
		bool flag = false;
		for (int i = 0; i < NeedActivateObjs.Count; i++)
		{
			if (NeedActivateObjs[i].UnitGuid == Obj.UnitGuid)
			{
				NeedActivateObjs[i] = Obj;
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			NeedActivateObjs.Add(Obj);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_TriggerProcessControlComp");
		NativeReflection.GetPropertyRef(ref AttachedTriggerObjs_PropertyAddress, unrealStruct, "AttachedTriggerObjs");
		AttachedTriggerObjs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AttachedTriggerObjs");
		AttachedTriggerObjs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AttachedTriggerObjs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref NeedActivateObjs_PropertyAddress, unrealStruct, "NeedActivateObjs");
		NeedActivateObjs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NeedActivateObjs");
		NeedActivateObjs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NeedActivateObjs", Classes.FArrayProperty);
	}

	static BUS_TriggerProcessControlComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_TriggerProcessControlComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_TriggerProcessControlComp));
	}
}
