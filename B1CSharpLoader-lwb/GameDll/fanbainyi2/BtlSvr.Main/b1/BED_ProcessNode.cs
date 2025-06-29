using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Abstract]
[USharpPath("/Script/b1-Managed.BED_ProcessNode")]
public class BED_ProcessNode : BED_CalliopeNodeBae
{
	protected const string MissingIdentityTag = "未找到相关Actor，检查Actor是否存在或关卡是否加载!";

	protected const string MissingNotifyTag = "未配置需要通知的内容!";

	protected const string MissingClass = "Missing class!";

	protected const string NoActorsFound = "No actors found!";

	private static bool IsSupportViewType_IsValid;

	private static IntPtr IsSupportViewType_FunctionAddress;

	private static int IsSupportViewType_ParamsSize;

	private static bool IsSupportViewType_InViewType_IsValid;

	private static int IsSupportViewType_InViewType_Offset;

	private static FFieldAddress IsSupportViewType_InViewType_PropertyAddress;

	private static bool IsSupportViewType_ReturnValue_IsValid;

	private static int IsSupportViewType_ReturnValue_Offset;

	private static FFieldAddress IsSupportViewType_ReturnValue_PropertyAddress;

	public string GetIdentityDescription(string IdentityPath)
	{
		if (!string.IsNullOrEmpty(IdentityPath))
		{
			return string.Join("\n", IdentityPath);
		}
		return "未找到相关Actor，检查Actor是否存在或关卡是否加载!";
	}

	public string GetNotifyTagsDescription(FGameplayTagContainer Tags)
	{
		if (Tags.GameplayTags.Count != 0)
		{
			return string.Join("\n", UGameplayTagLibrary.GetDebugStringFromGameplayTagContainer(Tags));
		}
		return "未配置需要通知的内容!";
	}

	public string GetClassDescription(TSubclassOf<UObject> Class)
	{
		if (!(Class.Value != null))
		{
			return "Missing class!";
		}
		return Class.ToString();
	}

	protected string ConvertSoftObj2NodeData<T>(TSoftObject<T> SoftObj) where T : UObject
	{
		if (!SoftObj.IsNull)
		{
			return SoftObj.LongPackageName;
		}
		return "";
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessNode:IsSupportViewType")]
	protected override bool IsSupportViewType_Implementation(ECalliopeViewType InViewType)
	{
		return InViewType == ECalliopeViewType.Process;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessNode:IsSupportViewType")]
	private static void IsSupportViewType__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessNode bED_ProcessNode = GCHelper.Find<BED_ProcessNode>(obj);
		ECalliopeViewType inViewType = EnumMarshaler<ECalliopeViewType>.FromNative(IntPtr.Add(buffer, IsSupportViewType_InViewType_Offset), 0, IsSupportViewType_InViewType_PropertyAddress.Address);
		bool value = bED_ProcessNode.IsSupportViewType_Implementation(inViewType);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsSupportViewType_ReturnValue_Offset), 0, IsSupportViewType_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessNode");
		IsSupportViewType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsSupportViewType");
		IsSupportViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSupportViewType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_InViewType_PropertyAddress, IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "InViewType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_ReturnValue_PropertyAddress, IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSupportViewType_IsValid = IsSupportViewType_FunctionAddress != IntPtr.Zero && IsSupportViewType_InViewType_IsValid && IsSupportViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessNode:IsSupportViewType", IsSupportViewType_IsValid);
	}

	static BED_ProcessNode()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessNode));
	}
}
