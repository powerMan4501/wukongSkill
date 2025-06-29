using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[Placeable(true)]
[DisplayName("AnyState")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_LoadingAnyState")]
public class BED_FSMNode_GI_LoadingAnyState : BED_FSMNode_GI_LoadingBase
{
	private static bool AcceptEvents_IsValid;

	private static int AcceptEvents_Offset;

	private static FFieldAddress AcceptEvents_PropertyAddress;

	private TArrayReadWriteMarshaler<EGI_Loading> AcceptEvents_Marshaler;

	private static bool PostPropertyChanged_IsValid;

	private static IntPtr PostPropertyChanged_FunctionAddress;

	private static int PostPropertyChanged_ParamsSize;

	private static bool PostPropertyChanged_MemberName_IsValid;

	private static int PostPropertyChanged_MemberName_Offset;

	private static FFieldAddress PostPropertyChanged_MemberName_PropertyAddress;

	private static bool PostPropertyChanged_PropertyName_IsValid;

	private static int PostPropertyChanged_PropertyName_Offset;

	private static FFieldAddress PostPropertyChanged_PropertyName_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_LoadingAnyState:AcceptEvents")]
	public TArrayReadWrite<EGI_Loading> AcceptEvents
	{
		get
		{
			CheckDestroyed();
			if (!AcceptEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_FSMNode_GI_LoadingAnyState:AcceptEvents");
				return null;
			}
			if (AcceptEvents_Marshaler == null)
			{
				AcceptEvents_Marshaler = new TArrayReadWriteMarshaler<EGI_Loading>(1, AcceptEvents_PropertyAddress, CachedMarshalingDelegates<EGI_Loading, EnumMarshaler<EGI_Loading>>.FromNative, CachedMarshalingDelegates<EGI_Loading, EnumMarshaler<EGI_Loading>>.ToNative);
			}
			return AcceptEvents_Marshaler.FromNative(IntPtr.Add(base.Address, AcceptEvents_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.InputPins.Clear();
		FreshOutPutPins();
		SetNodeCategory("GI_Loading State");
		SetNodeStyle(ECalliopeNodeStyle.Latent);
	}

	protected void FreshOutPutPins()
	{
		base.OutputPins.Clear();
		List<EGI_Loading> list = new List<EGI_Loading>();
		foreach (EGI_Loading acceptEvent in AcceptEvents)
		{
			if (!list.Contains(acceptEvent))
			{
				base.OutputPins.Add(new FCalliopePin
				{
					PinName = new FName(acceptEvent.ToString())
				});
				list.Add(acceptEvent);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_LoadingAnyState:PostPropertyChanged")]
	protected override void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		base.PostPropertyChanged_Implementation(MemberName, PropertyName);
		if (PropertyName.Equals("AcceptEvents"))
		{
			FreshOutPutPins();
			ExecuteOnReconstructionRequested();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_FSMNode_GI_LoadingAnyState:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_FSMNode_GI_LoadingAnyState bED_FSMNode_GI_LoadingAnyState = GCHelper.Find<BED_FSMNode_GI_LoadingAnyState>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_FSMNode_GI_LoadingAnyState.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_FSMNode_GI_LoadingAnyState");
		NativeReflection.GetPropertyRef(ref AcceptEvents_PropertyAddress, intPtr, "AcceptEvents");
		AcceptEvents_Offset = NativeReflection.GetPropertyOffset(intPtr, "AcceptEvents");
		AcceptEvents_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AcceptEvents", Classes.FArrayProperty);
		PostPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostPropertyChanged");
		PostPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_MemberName_PropertyAddress, PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_PropertyName_PropertyAddress, PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PostPropertyChanged_IsValid = PostPropertyChanged_FunctionAddress != IntPtr.Zero && PostPropertyChanged_MemberName_IsValid && PostPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_FSMNode_GI_LoadingAnyState:PostPropertyChanged", PostPropertyChanged_IsValid);
	}

	static BED_FSMNode_GI_LoadingAnyState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_FSMNode_GI_LoadingAnyState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_FSMNode_GI_LoadingAnyState));
	}
}
