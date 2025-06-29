using System;
using BtlB1;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN Show Shrine Main")]
[USharpPath("/Script/b1-Managed.BAN_ShowShrineMain")]
internal class BAN_ShowShrineMain : BAN_GSBase
{
	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[USharpPath("/Script/b1-Managed.BAN_ShowShrineMain:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BGURebirthPointBase bGURebirthPointBase = NotifyParam.owner as BGURebirthPointBase;
		if (bGURebirthPointBase == null)
		{
			return;
		}
		IBUC_RebirthPointData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_RebirthPointData>(bGURebirthPointBase);
		if (unPersistentReadOnlyData == null)
		{
			return;
		}
		FUStRebirthPointDesc rebirthPointDesc = BGW_GameDB.GetRebirthPointDesc(unPersistentReadOnlyData.RebirthPointConfigID);
		if (rebirthPointDesc != null)
		{
			LevelDesc levelDesc = GameDBRuntime.GetLevelDesc(rebirthPointDesc.MapID);
			if (levelDesc != null && levelDesc.IsOnlineLevel == YesNoType.No && !BGUFuncLibMap.IsPartyLevel(rebirthPointDesc.MapID, bGURebirthPointBase))
			{
				BGUFunctionLibraryCS.BGUActiveNoSeqUI(bGURebirthPointBase, IsActive: true);
				BGS_EventCollectionCS.Get(bGURebirthPointBase).Evt_BGS_ShowRebirthPointUI.Invoke(unPersistentReadOnlyData.RebirthPointConfigID);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_ShowShrineMain:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_ShowShrineMain bAN_ShowShrineMain = GCHelper.Find<b1.BAN_ShowShrineMain>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_ShowShrineMain.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BAN_ShowShrineMain");
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_ShowShrineMain:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_ShowShrineMain()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_ShowShrineMain)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_ShowShrineMain));
	}
}
