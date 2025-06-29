using System;
using System.Collections.Generic;
using b1;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[DisplayName("BAN DispLib Simple Ribbon Trail Array")]
[USharpPath("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray")]
internal class BAN_DispLibSimpleRibbonTrailsArray : BAN_GSBase
{
	private static bool EditorActive_IsValid;

	private static int EditorActive_Offset;

	private static FFieldAddress EditorActive_PropertyAddress;

	private static bool template_IsValid;

	private static int template_Offset;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool DelayTimeAfterStop_IsValid;

	private static int DelayTimeAfterStop_Offset;

	private static bool socketName_IsValid;

	private static int socketName_Offset;

	private static bool locationOffset_IsValid;

	private static int locationOffset_Offset;

	private static bool rotationOffset_IsValid;

	private static int rotationOffset_Offset;

	private static bool scale_IsValid;

	private static int scale_Offset;

	private static bool ignoreRootBoneScale_IsValid;

	private static int ignoreRootBoneScale_Offset;

	private static FFieldAddress ignoreRootBoneScale_PropertyAddress;

	private static bool customParams_IsValid;

	private static int customParams_Offset;

	private static FFieldAddress customParams_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSNiagaraSysParam> customParams_Marshaler;

	private static bool translucentSortPriority_IsValid;

	private static int translucentSortPriority_Offset;

	private static bool CompTag_IsValid;

	private static int CompTag_Offset;

	private static bool GetSoftReferences_IsValid;

	private static IntPtr GetSoftReferences_FunctionAddress;

	private static int GetSoftReferences_ParamsSize;

	private static bool GetSoftReferences_ReturnValue_IsValid;

	private static int GetSoftReferences_ReturnValue_Offset;

	private static FFieldAddress GetSoftReferences_ReturnValue_PropertyAddress;

	[UMeta(MD.ToolTip, "关闭后编辑器下不会播放当前效果，不影响运行时")]
	[DisplayName("Editor Active")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:EditorActive")]
	public bool EditorActive
	{
		get
		{
			CheckDestroyed();
			if (!EditorActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:EditorActive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EditorActive_Offset), 0, EditorActive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EditorActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:EditorActive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EditorActive_Offset), 0, EditorActive_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:template")]
	public TSoftObject<UNiagaraSystem> template
	{
		get
		{
			CheckDestroyed();
			if (!template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:template");
				return default(TSoftObject<UNiagaraSystem>);
			}
			return TSoftObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(base.Address, template_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:template");
			}
			else
			{
				TSoftObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(base.Address, template_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("持续时间")]
	[UMeta(MD.ToolTip, "不大于0的值表示会以 AutoRelease 模式创建并在8s后强制销毁，大于0的值表示会以 ManualRelease 模式创建并由DBC负责按时销毁")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:Duration")]
	public float Duration
	{
		get
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Duration_Offset), value);
			}
		}
	}

	[UMeta(MD.ToolTip, "特效结束时要额外延后多长时间销毁特效，小于等于0会立即销毁，否则会设置特效参数 GS_EfxStop = true 并延后销毁; EndMode 是 AutoRelease 时无效")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("结束表现时间")]
	[UMeta(MDProp.EditCondition, "Duration > 0")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:DelayTimeAfterStop")]
	public float DelayTimeAfterStop
	{
		get
		{
			CheckDestroyed();
			if (!DelayTimeAfterStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:DelayTimeAfterStop");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DelayTimeAfterStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DelayTimeAfterStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:DelayTimeAfterStop");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DelayTimeAfterStop_Offset), value);
			}
		}
	}

	[UMeta("AnimNotifyBoneName", "true")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:socketName")]
	public FName socketName
	{
		get
		{
			CheckDestroyed();
			if (!socketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:socketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, socketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!socketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:socketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, socketName_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:locationOffset")]
	public FVector locationOffset
	{
		get
		{
			CheckDestroyed();
			if (!locationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:locationOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, locationOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!locationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:locationOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, locationOffset_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:rotationOffset")]
	public FRotator rotationOffset
	{
		get
		{
			CheckDestroyed();
			if (!rotationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:rotationOffset");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, rotationOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!rotationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:rotationOffset");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, rotationOffset_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:scale")]
	public FVector scale
	{
		get
		{
			CheckDestroyed();
			if (!scale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:scale");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, scale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!scale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:scale");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, scale_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "Ignore Root Bone Scale")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:ignoreRootBoneScale")]
	public bool ignoreRootBoneScale
	{
		get
		{
			CheckDestroyed();
			if (!ignoreRootBoneScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:ignoreRootBoneScale");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ignoreRootBoneScale_Offset), 0, ignoreRootBoneScale_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ignoreRootBoneScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:ignoreRootBoneScale");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ignoreRootBoneScale_Offset), 0, ignoreRootBoneScale_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "Set Custom Params ")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:customParams")]
	public TArrayReadWrite<FGSNiagaraSysParam> customParams
	{
		get
		{
			CheckDestroyed();
			if (!customParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:customParams");
				return null;
			}
			if (customParams_Marshaler == null)
			{
				customParams_Marshaler = new TArrayReadWriteMarshaler<FGSNiagaraSysParam>(1, customParams_PropertyAddress, CachedMarshalingDelegates<FGSNiagaraSysParam, FGSNiagaraSysParam>.FromNative, CachedMarshalingDelegates<FGSNiagaraSysParam, FGSNiagaraSysParam>.ToNative);
			}
			return customParams_Marshaler.FromNative(IntPtr.Add(base.Address, customParams_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:translucentSortPriority")]
	public int translucentSortPriority
	{
		get
		{
			CheckDestroyed();
			if (!translucentSortPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:translucentSortPriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, translucentSortPriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!translucentSortPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:translucentSortPriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, translucentSortPriority_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:CompTag")]
	public FName CompTag
	{
		get
		{
			CheckDestroyed();
			if (!CompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:CompTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CompTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:CompTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CompTag_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:GetSoftReferences")]
	protected override List<FSoftObjectPath> GetSoftReferences_Implementation()
	{
		if (!template.IsNull)
		{
			return new List<FSoftObjectPath> { template.ObjectPath };
		}
		return new List<FSoftObjectPath>();
	}

	public override void GetSoftReferencesCS(ref HashSet<FSoftObjectPath> SoftPathSet)
	{
		if (SoftPathSet == null)
		{
			SoftPathSet = new HashSet<FSoftObjectPath>();
		}
		if (!template.IsNull)
		{
			SoftPathSet.Add(template.ObjectPath);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:GetSoftReferences")]
	private static void GetSoftReferences__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib.BAN_DispLibSimpleRibbonTrailsArray bAN_DispLibSimpleRibbonTrailsArray = GCHelper.Find<GSDispLib.BAN_DispLibSimpleRibbonTrailsArray>(obj);
		TArrayCopyMarshaler<FSoftObjectPath> tArrayCopyMarshaler = new TArrayCopyMarshaler<FSoftObjectPath>(1, GetSoftReferences_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative);
		List<FSoftObjectPath> softReferences_Implementation = bAN_DispLibSimpleRibbonTrailsArray.GetSoftReferences_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetSoftReferences_ReturnValue_Offset), softReferences_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray");
		NativeReflection.GetPropertyRef(ref EditorActive_PropertyAddress, intPtr, "EditorActive");
		EditorActive_Offset = NativeReflection.GetPropertyOffset(intPtr, "EditorActive");
		EditorActive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EditorActive", Classes.FBoolProperty);
		template_Offset = NativeReflection.GetPropertyOffset(intPtr, "template");
		template_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "template", Classes.FSoftObjectProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		DelayTimeAfterStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayTimeAfterStop");
		DelayTimeAfterStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayTimeAfterStop", Classes.FFloatProperty);
		socketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "socketName");
		socketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "socketName", Classes.FNameProperty);
		locationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "locationOffset");
		locationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "locationOffset", Classes.FStructProperty);
		rotationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "rotationOffset");
		rotationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "rotationOffset", Classes.FStructProperty);
		scale_Offset = NativeReflection.GetPropertyOffset(intPtr, "scale");
		scale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "scale", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref ignoreRootBoneScale_PropertyAddress, intPtr, "ignoreRootBoneScale");
		ignoreRootBoneScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "ignoreRootBoneScale");
		ignoreRootBoneScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ignoreRootBoneScale", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref customParams_PropertyAddress, intPtr, "customParams");
		customParams_Offset = NativeReflection.GetPropertyOffset(intPtr, "customParams");
		customParams_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "customParams", Classes.FArrayProperty);
		translucentSortPriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "translucentSortPriority");
		translucentSortPriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "translucentSortPriority", Classes.FIntProperty);
		CompTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompTag");
		CompTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompTag", Classes.FNameProperty);
		GetSoftReferences_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSoftReferences");
		GetSoftReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSoftReferences_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetSoftReferences_ReturnValue_PropertyAddress, GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetSoftReferences_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSoftReferences_IsValid = GetSoftReferences_FunctionAddress != IntPtr.Zero && GetSoftReferences_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_DispLibSimpleRibbonTrailsArray:GetSoftReferences", GetSoftReferences_IsValid);
	}

	static BAN_DispLibSimpleRibbonTrailsArray()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSDispLib.BAN_DispLibSimpleRibbonTrailsArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSDispLib.BAN_DispLibSimpleRibbonTrailsArray));
	}
}
