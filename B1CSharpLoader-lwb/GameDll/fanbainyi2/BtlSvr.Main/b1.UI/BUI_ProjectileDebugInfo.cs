using System;
using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_ProjectileDebugInfo")]
internal class BUI_ProjectileDebugInfo : BUI_Widget
{
	private const string INFONAME_NAME = "InfoName";

	private const string INFONAME_VALUE = "InfoValue";

	protected Dictionary<string, UTextBlock> InfoDic = new Dictionary<string, UTextBlock>();

	private UVerticalBox InfoBox;

	private const string INFOBOX_NAME = "InfoBox";

	private const string INFOCONTENT_0 = "ID";

	private const string INFOCONTENT_1 = "MoveMode";

	private const string INFOCONTENT_9 = "TraceType";

	private const string INFOCONTENT_2 = "剩余生命时间";

	private const string INFOCONTENT_3 = "飞行速度";

	private const string INFOCONTENT_4 = "旋转速度";

	private const string INFOCONTENT_5 = "剩余追踪时长";

	private const string INFOCONTENT_7 = "限制在地面";

	private const string INFOCONTENT_8 = "对齐到地面";

	private BUC_ObjActorMovementData MovementData;

	private BUC_ProjectileLifeData LifeData;

	private static bool InfoTemp_IsValid;

	private static int InfoTemp_Offset;

	private static bool ProjectileSelf_IsValid;

	private static int ProjectileSelf_Offset;

	private static bool OnRegistOwner_IsValid;

	private static IntPtr OnRegistOwner_FunctionAddress;

	private static int OnRegistOwner_ParamsSize;

	private static bool OnRegistOwner_projectileBaseActor_IsValid;

	private static int OnRegistOwner_projectileBaseActor_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_ProjectileDebugInfo:InfoTemp")]
	public TSubclassOf<UUserWidget> InfoTemp
	{
		get
		{
			CheckDestroyed();
			if (!InfoTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ProjectileDebugInfo:InfoTemp");
				return default(TSubclassOf<UUserWidget>);
			}
			return TSubclassOfMarshaler<UUserWidget>.FromNative(IntPtr.Add(base.Address, InfoTemp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InfoTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ProjectileDebugInfo:InfoTemp");
			}
			else
			{
				TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(base.Address, InfoTemp_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_ProjectileDebugInfo:ProjectileSelf")]
	protected BGUProjectileBaseActor ProjectileSelf
	{
		get
		{
			CheckDestroyed();
			if (!ProjectileSelf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ProjectileDebugInfo:ProjectileSelf");
				return null;
			}
			return UObjectMarshaler<BGUProjectileBaseActor>.FromNative(IntPtr.Add(base.Address, ProjectileSelf_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProjectileSelf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ProjectileDebugInfo:ProjectileSelf");
			}
			else
			{
				UObjectMarshaler<BGUProjectileBaseActor>.ToNative(IntPtr.Add(base.Address, ProjectileSelf_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		InfoBox = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("InfoBox")) as UVerticalBox;
		if (!(InfoBox == null))
		{
			AddInitInfo("ID");
			AddInitInfo("MoveMode");
			AddInitInfo("TraceType");
			AddInitInfo("剩余生命时间");
			AddInitInfo("飞行速度");
			AddInitInfo("旋转速度");
			AddInitInfo("剩余追踪时长");
			AddInitInfo("限制在地面");
			AddInitInfo("对齐到地面");
		}
	}

	protected override void OnUIGSSlowTickImpl(FGeometry MyGeometry, float InDeltaTime)
	{
		UpdateBaseInfo();
	}

	protected void AddInitInfo(string infoname)
	{
		UVerticalBox infoBox = InfoBox;
		if (!(infoBox == null))
		{
			UUserWidget uUserWidget = UGSE_UMGFuncLib.CreateUserWidgetWithClass(this, InfoTemp.Value);
			(UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("InfoName")) as UTextBlock).SetText(FText.FromString(infoname));
			UTextBlock value = UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("InfoValue")) as UTextBlock;
			InfoDic.Add(infoname, value);
			infoBox.AddChild(uUserWidget);
		}
	}

	private void UpdateBaseInfo()
	{
		if (ProjectileSelf == null || ProjectileSelf.IsDead())
		{
			InfoDic["MoveMode"].SetText(FText.FromString(""));
			InfoDic["剩余生命时间"].SetText(FText.FromString(""));
			InfoDic["飞行速度"].SetText(FText.FromString(""));
			InfoDic["旋转速度"].SetText(FText.FromString(""));
			InfoDic["剩余追踪时长"].SetText(FText.FromString(""));
			InfoDic["限制在地面"].SetText(FText.FromString(""));
			InfoDic["对齐到地面"].SetText(FText.FromString(""));
			InfoDic["TraceType"].SetText(FText.FromString(""));
			return;
		}
		InfoDic["ID"].SetText(FText.FromString(ProjectileSelf.GetProjectileID().ToString()));
		if (MovementData != null)
		{
			EBulletOrMagicFieldMoveModeType moveMode = MovementData.MoveMode;
			InfoDic["MoveMode"].SetText(FText.FromString(moveMode.ToString()));
			if (moveMode == EBulletOrMagicFieldMoveModeType.TraceMode)
			{
				InfoDic["TraceType"].SetText(FText.FromString(MovementData.TraceType.ToString()));
			}
			else
			{
				InfoDic["TraceType"].SetText(FText.FromString(""));
			}
			InfoDic["MoveMode"].SetText(FText.FromString(moveMode.ToString()));
			InfoDic["飞行速度"].SetText(FText.FromString(MovementData.CurVelocity.Size().ToString()));
			InfoDic["旋转速度"].SetText(FText.FromString(MovementData.BulletNowRotSpd.ToString()));
			InfoDic["剩余追踪时长"].SetText(FText.FromString(MovementData.TraceTime.ToString()));
			InfoDic["限制在地面"].SetText(FText.FromString(MovementData.MoveClampToLand.ToString()));
			InfoDic["对齐到地面"].SetText(FText.FromString(MovementData.MoveAlignToLand.ToString()));
		}
		if (LifeData != null)
		{
			InfoDic["剩余生命时间"].SetText(FText.FromString(LifeData.ProjectileLifeTimer.ToString()));
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_ProjectileDebugInfo:OnRegistOwner")]
	public virtual void OnRegistOwner(BGUProjectileBaseActor projectileBaseActor)
	{
		ProjectileSelf = projectileBaseActor;
		ProjectileSelf?.EnableDebugMode();
		MovementData = BGU_DataUtil.GetReadOnlyData<BUC_ObjActorMovementData>(ProjectileSelf);
		LifeData = BGU_DataUtil.GetReadOnlyData<BUC_ProjectileLifeData>(ProjectileSelf);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_ProjectileDebugInfo:OnRegistOwner")]
	private static void OnRegistOwner__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_ProjectileDebugInfo bUI_ProjectileDebugInfo = GCHelper.Find<b1.UI.BUI_ProjectileDebugInfo>(obj);
		BGUProjectileBaseActor projectileBaseActor = UObjectMarshaler<BGUProjectileBaseActor>.FromNative(IntPtr.Add(buffer, OnRegistOwner_projectileBaseActor_Offset));
		bUI_ProjectileDebugInfo.OnRegistOwner(projectileBaseActor);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_ProjectileDebugInfo");
		InfoTemp_Offset = NativeReflection.GetPropertyOffset(intPtr, "InfoTemp");
		InfoTemp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InfoTemp", Classes.FClassProperty);
		ProjectileSelf_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProjectileSelf");
		ProjectileSelf_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProjectileSelf", Classes.FObjectProperty);
		OnRegistOwner_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnRegistOwner");
		OnRegistOwner_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRegistOwner_FunctionAddress);
		OnRegistOwner_projectileBaseActor_Offset = NativeReflection.GetPropertyOffset(OnRegistOwner_FunctionAddress, "projectileBaseActor");
		OnRegistOwner_projectileBaseActor_IsValid = NativeReflection.ValidatePropertyClass(OnRegistOwner_FunctionAddress, "projectileBaseActor", Classes.FObjectProperty);
		OnRegistOwner_IsValid = OnRegistOwner_FunctionAddress != IntPtr.Zero && OnRegistOwner_projectileBaseActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_ProjectileDebugInfo:OnRegistOwner", OnRegistOwner_IsValid);
	}

	static BUI_ProjectileDebugInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_ProjectileDebugInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_ProjectileDebugInfo));
	}
}
