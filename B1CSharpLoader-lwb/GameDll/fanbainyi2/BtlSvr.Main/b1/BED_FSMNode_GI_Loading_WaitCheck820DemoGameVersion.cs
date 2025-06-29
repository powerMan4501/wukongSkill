using System;
using System.Collections.Generic;
using System.Text;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Placeable(true)]
[DisplayName("WaitCheck820DemoGameVersion")]
[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion")]
public class BED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion : BED_FSMNode_GI_LoadingBase
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

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion:AcceptEvents")]
	public TArrayReadWrite<EGI_Loading> AcceptEvents
	{
		get
		{
			CheckDestroyed();
			if (!AcceptEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion:AcceptEvents");
				return null;
			}
			if (AcceptEvents_Marshaler == null)
			{
				AcceptEvents_Marshaler = new TArrayReadWriteMarshaler<EGI_Loading>(1, AcceptEvents_PropertyAddress, CachedMarshalingDelegates<EGI_Loading, EnumMarshaler<EGI_Loading>>.FromNative, CachedMarshalingDelegates<EGI_Loading, EnumMarshaler<EGI_Loading>>.ToNative);
			}
			return AcceptEvents_Marshaler.FromNative(IntPtr.Add(base.Address, AcceptEvents_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return new StringBuilder().ToString();
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		FreshOutPutPins();
		SetNodeCategory("GI_Loading State");
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

	[USharpPath("/Script/b1-Managed.BED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion:PostPropertyChanged")]
	protected override void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		base.PostPropertyChanged_Implementation(MemberName, PropertyName);
		if (PropertyName.Equals("AcceptEvents"))
		{
			FreshOutPutPins();
			ExecuteOnReconstructionRequested();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion bED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion = GCHelper.Find<BED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion bED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion = GCHelper.Find<BED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion>(obj);
		string nodeDescriptionInCS_Implementation = bED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion");
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion:PostPropertyChanged", PostPropertyChanged_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion));
	}
}
