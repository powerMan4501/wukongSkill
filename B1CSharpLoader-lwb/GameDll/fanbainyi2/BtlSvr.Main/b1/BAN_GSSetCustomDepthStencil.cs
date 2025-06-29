using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("SetCustomDepthStencil")]
[UClass]
[Tooltip("修改角色的自定义深度模板")]
[USharpPath("/Script/b1-Managed.BAN_GSSetCustomDepthStencil")]
public class BAN_GSSetCustomDepthStencil : BAN_GSBase
{
	private static bool RenderCustomDepth_IsValid;

	private static int RenderCustomDepth_Offset;

	private static FFieldAddress RenderCustomDepth_PropertyAddress;

	private static bool CustomDepthStencilValue_IsValid;

	private static int CustomDepthStencilValue_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Rendering")]
	[USharpPath("/Script/b1-Managed.BAN_GSSetCustomDepthStencil:RenderCustomDepth")]
	public bool RenderCustomDepth
	{
		get
		{
			CheckDestroyed();
			if (!RenderCustomDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetCustomDepthStencil:RenderCustomDepth");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RenderCustomDepth_Offset), 0, RenderCustomDepth_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RenderCustomDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetCustomDepthStencil:RenderCustomDepth");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RenderCustomDepth_Offset), 0, RenderCustomDepth_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Rendering")]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MDProp.ClampMax, 255)]
	[USharpPath("/Script/b1-Managed.BAN_GSSetCustomDepthStencil:CustomDepthStencilValue")]
	public int CustomDepthStencilValue
	{
		get
		{
			CheckDestroyed();
			if (!CustomDepthStencilValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetCustomDepthStencil:CustomDepthStencilValue");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CustomDepthStencilValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomDepthStencilValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetCustomDepthStencil:CustomDepthStencilValue");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CustomDepthStencilValue_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		RenderCustomDepth = true;
		CustomDepthStencilValue = 0;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSSetCustomDepthStencil:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_SetCustomDepthStencilByClass.Invoke(UClass.GetClass<USkeletalMeshComponent>(), RenderCustomDepth, CustomDepthStencilValue);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSSetCustomDepthStencil:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_GSSetCustomDepthStencil bAN_GSSetCustomDepthStencil = GCHelper.Find<BAN_GSSetCustomDepthStencil>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSSetCustomDepthStencil.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSSetCustomDepthStencil");
		NativeReflection.GetPropertyRef(ref RenderCustomDepth_PropertyAddress, intPtr, "RenderCustomDepth");
		RenderCustomDepth_Offset = NativeReflection.GetPropertyOffset(intPtr, "RenderCustomDepth");
		RenderCustomDepth_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RenderCustomDepth", Classes.FBoolProperty);
		CustomDepthStencilValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomDepthStencilValue");
		CustomDepthStencilValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomDepthStencilValue", Classes.FIntProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSSetCustomDepthStencil:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GSSetCustomDepthStencil()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAN_GSSetCustomDepthStencil)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAN_GSSetCustomDepthStencil));
	}
}
