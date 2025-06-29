using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[Tooltip("这个通用版Notify不能处理次要Actor，所以复杂需求建议使用各个项目定制版本的 PlayDBCDataAsset 系列Notify")]
[UClass]
[DisplayName("BAN DispLib Play DBC DataAsset")]
[USharpPath("/Script/b1-Managed.BAN_DispLibPlayDBCDataAsset")]
internal class BAN_DispLibPlayDBCDataAsset : BAN_GSBase
{
	private static bool DataAsset_IsValid;

	private static int DataAsset_Offset;

	private static bool PlayByDispWorld_IsValid;

	private static int PlayByDispWorld_Offset;

	private static FFieldAddress PlayByDispWorld_PropertyAddress;

	private static bool MainSockNameIfDW_IsValid;

	private static int MainSockNameIfDW_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_DispLibPlayDBCDataAsset:DataAsset")]
	public BUC_DispLibDispBaseConfigDataAsset DataAsset
	{
		get
		{
			CheckDestroyed();
			if (!DataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayDBCDataAsset:DataAsset");
				return null;
			}
			return UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.FromNative(IntPtr.Add(base.Address, DataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayDBCDataAsset:DataAsset");
			}
			else
			{
				UObjectMarshaler<BUC_DispLibDispBaseConfigDataAsset>.ToNative(IntPtr.Add(base.Address, DataAsset_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("由 DispWorld 执行")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_DispLibPlayDBCDataAsset:PlayByDispWorld")]
	public bool PlayByDispWorld
	{
		get
		{
			CheckDestroyed();
			if (!PlayByDispWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayDBCDataAsset:PlayByDispWorld");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PlayByDispWorld_Offset), 0, PlayByDispWorld_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PlayByDispWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayDBCDataAsset:PlayByDispWorld");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PlayByDispWorld_Offset), 0, PlayByDispWorld_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("锚定插槽")]
	[UMeta(MDProp.EditCondition, "PlayByDispWorld")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibPlayDBCDataAsset:MainSockNameIfDW")]
	public FName MainSockNameIfDW
	{
		get
		{
			CheckDestroyed();
			if (!MainSockNameIfDW_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayDBCDataAsset:MainSockNameIfDW");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, MainSockNameIfDW_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MainSockNameIfDW_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayDBCDataAsset:MainSockNameIfDW");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, MainSockNameIfDW_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	protected virtual bool ValidateParameters(USkeletalMeshComponent MeshComp)
	{
		if (DataAsset == null)
		{
			return false;
		}
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_DispLibPlayDBCDataAsset:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		if (ValidateParameters(meshComp))
		{
			if (PlayByDispWorld)
			{
				BWS_DispLibEventCollection.Get(DispLibDispWorld.GetInstance(meshComp.GetOwner()))?.Evt_DLDWorld_RequestApplyOneDBCDataAsset(DataAsset, out var _, new DBCTransformParam(meshComp.GetSocketTransform(MainSockNameIfDW)), null, FVector.ZeroVector, DBCSetCallbackParams.Default, GetUniqueID());
			}
			else
			{
				BUS_DispLibEventCollection.Get(meshComp.GetOwner())?.Evt_RequestApplyOneDBCDataAsset(DataAsset, out var _, null, FVector.ZeroVector, DBCTransformParam.Default, DBCSetCallbackParams.Default, GetUniqueID());
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_DispLibPlayDBCDataAsset:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib.BAN_DispLibPlayDBCDataAsset bAN_DispLibPlayDBCDataAsset = GCHelper.Find<GSDispLib.BAN_DispLibPlayDBCDataAsset>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_DispLibPlayDBCDataAsset.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_DispLibPlayDBCDataAsset");
		DataAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "DataAsset");
		DataAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DataAsset", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref PlayByDispWorld_PropertyAddress, intPtr, "PlayByDispWorld");
		PlayByDispWorld_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlayByDispWorld");
		PlayByDispWorld_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlayByDispWorld", Classes.FBoolProperty);
		MainSockNameIfDW_Offset = NativeReflection.GetPropertyOffset(intPtr, "MainSockNameIfDW");
		MainSockNameIfDW_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MainSockNameIfDW", Classes.FNameProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_DispLibPlayDBCDataAsset:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_DispLibPlayDBCDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSDispLib.BAN_DispLibPlayDBCDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSDispLib.BAN_DispLibPlayDBCDataAsset));
	}
}
