using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptEditor;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[UMetaPath("/Script/JavascriptEditor.JavascriptEditorTab", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptEditorTab : UObject
{
	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorTab:SpawnTab__DelegateSignature")]
	public class FSpawnTab : FDelegate<FSpawnTab.Signature>
	{
		public delegate UWidget Signature(UObject Context);

		private static bool SpawnTab__DelegateSignature_IsValid;

		private static IntPtr SpawnTab__DelegateSignature_FunctionAddress;

		private static int SpawnTab__DelegateSignature_ParamsSize;

		private static bool SpawnTab__DelegateSignature_Context_IsValid;

		private static FFieldAddress SpawnTab__DelegateSignature_Context_PropertyAddress;

		private static int SpawnTab__DelegateSignature_Context_Offset;

		private static bool SpawnTab__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress SpawnTab__DelegateSignature_ReturnValue_PropertyAddress;

		private static int SpawnTab__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FSpawnTab()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			SpawnTab__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptEditorTab:SpawnTab__DelegateSignature");
			SpawnTab__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnTab__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref SpawnTab__DelegateSignature_Context_PropertyAddress, SpawnTab__DelegateSignature_FunctionAddress, "Context");
			SpawnTab__DelegateSignature_Context_Offset = NativeReflectionCached.GetPropertyOffset(SpawnTab__DelegateSignature_FunctionAddress, "Context");
			SpawnTab__DelegateSignature_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnTab__DelegateSignature_FunctionAddress, "Context", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref SpawnTab__DelegateSignature_ReturnValue_PropertyAddress, SpawnTab__DelegateSignature_FunctionAddress, "ReturnValue");
			SpawnTab__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnTab__DelegateSignature_FunctionAddress, "ReturnValue");
			SpawnTab__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnTab__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
			SpawnTab__DelegateSignature_IsValid = SpawnTab__DelegateSignature_FunctionAddress != IntPtr.Zero && SpawnTab__DelegateSignature_Context_IsValid && SpawnTab__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorTab:SpawnTab__DelegateSignature", SpawnTab__DelegateSignature_IsValid);
		}

		private unsafe UWidget Invoker(UObject Context)
		{
			if (!SpawnTab__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorTab:SpawnTab__DelegateSignature");
				return null;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(SpawnTab__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnTab__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SpawnTab__DelegateSignature_Context_Offset), 0, SpawnTab__DelegateSignature_Context_PropertyAddress.Address, Context);
				ProcessDelegate(intPtr);
				return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(intPtr, SpawnTab__DelegateSignature_ReturnValue_Offset), 0, SpawnTab__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return null;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorTab:OnTabActivated__DelegateSignature")]
	public class FOnTabActivated : FDelegate<FOnTabActivated.Signature>
	{
		public delegate void Signature(string TabId, EJavasriptTabActivationCause Cause);

		private static bool OnTabActivated__DelegateSignature_IsValid;

		private static IntPtr OnTabActivated__DelegateSignature_FunctionAddress;

		private static int OnTabActivated__DelegateSignature_ParamsSize;

		private static bool OnTabActivated__DelegateSignature_TabId_IsValid;

		private static FFieldAddress OnTabActivated__DelegateSignature_TabId_PropertyAddress;

		private static int OnTabActivated__DelegateSignature_TabId_Offset;

		private static bool OnTabActivated__DelegateSignature_Cause_IsValid;

		private static FFieldAddress OnTabActivated__DelegateSignature_Cause_PropertyAddress;

		private static int OnTabActivated__DelegateSignature_Cause_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnTabActivated()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnTabActivated__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptEditorTab:OnTabActivated__DelegateSignature");
			OnTabActivated__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTabActivated__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnTabActivated__DelegateSignature_TabId_PropertyAddress, OnTabActivated__DelegateSignature_FunctionAddress, "TabId");
			OnTabActivated__DelegateSignature_TabId_Offset = NativeReflectionCached.GetPropertyOffset(OnTabActivated__DelegateSignature_FunctionAddress, "TabId");
			OnTabActivated__DelegateSignature_TabId_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTabActivated__DelegateSignature_FunctionAddress, "TabId", Classes.FStrProperty);
			NativeReflectionCached.GetPropertyRef(ref OnTabActivated__DelegateSignature_Cause_PropertyAddress, OnTabActivated__DelegateSignature_FunctionAddress, "Cause");
			OnTabActivated__DelegateSignature_Cause_Offset = NativeReflectionCached.GetPropertyOffset(OnTabActivated__DelegateSignature_FunctionAddress, "Cause");
			OnTabActivated__DelegateSignature_Cause_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTabActivated__DelegateSignature_FunctionAddress, "Cause", Classes.FByteProperty);
			OnTabActivated__DelegateSignature_IsValid = OnTabActivated__DelegateSignature_FunctionAddress != IntPtr.Zero && OnTabActivated__DelegateSignature_TabId_IsValid && OnTabActivated__DelegateSignature_Cause_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorTab:OnTabActivated__DelegateSignature", OnTabActivated__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(string TabId, EJavasriptTabActivationCause Cause)
		{
			if (!OnTabActivated__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorTab:OnTabActivated__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnTabActivated__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTabActivated__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnTabActivated__DelegateSignature_TabId_Offset), 0, OnTabActivated__DelegateSignature_TabId_PropertyAddress.Address, TabId);
				EnumMarshaler<EJavasriptTabActivationCause>.ToNative(IntPtr.Add(intPtr, OnTabActivated__DelegateSignature_Cause_Offset), 0, OnTabActivated__DelegateSignature_Cause_PropertyAddress.Address, Cause);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(OnTabActivated__DelegateSignature_TabId_PropertyAddress.Address, intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorTab:CloseTab__DelegateSignature")]
	public class FCloseTab : FDelegate<FCloseTab.Signature>
	{
		public delegate void Signature(UWidget Widget);

		private static bool CloseTab__DelegateSignature_IsValid;

		private static IntPtr CloseTab__DelegateSignature_FunctionAddress;

		private static int CloseTab__DelegateSignature_ParamsSize;

		private static bool CloseTab__DelegateSignature_Widget_IsValid;

		private static FFieldAddress CloseTab__DelegateSignature_Widget_PropertyAddress;

		private static int CloseTab__DelegateSignature_Widget_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FCloseTab()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			CloseTab__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptEditorTab:CloseTab__DelegateSignature");
			CloseTab__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(CloseTab__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref CloseTab__DelegateSignature_Widget_PropertyAddress, CloseTab__DelegateSignature_FunctionAddress, "Widget");
			CloseTab__DelegateSignature_Widget_Offset = NativeReflectionCached.GetPropertyOffset(CloseTab__DelegateSignature_FunctionAddress, "Widget");
			CloseTab__DelegateSignature_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(CloseTab__DelegateSignature_FunctionAddress, "Widget", Classes.FObjectProperty);
			CloseTab__DelegateSignature_IsValid = CloseTab__DelegateSignature_FunctionAddress != IntPtr.Zero && CloseTab__DelegateSignature_Widget_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorTab:CloseTab__DelegateSignature", CloseTab__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(UWidget Widget)
		{
			if (!CloseTab__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorTab:CloseTab__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(CloseTab__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CloseTab__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, CloseTab__DelegateSignature_Widget_Offset), 0, CloseTab__DelegateSignature_Widget_PropertyAddress.Address, Widget);
				ProcessDelegate(intPtr);
			}
		}
	}

	private static bool TabId_IsValid;

	private static int TabId_Offset;

	private static bool DisplayName_IsValid;

	private static int DisplayName_Offset;

	private FText DisplayName_TextCached;

	private static bool IsNomad_IsValid;

	private static FFieldAddress IsNomad_PropertyAddress;

	private static int IsNomad_Offset;

	private static bool Role_IsValid;

	private static FFieldAddress Role_PropertyAddress;

	private static int Role_Offset;

	private static bool ForceCommit_IsValid;

	private static IntPtr ForceCommit_FunctionAddress;

	private static int ForceCommit_ParamsSize;

	private static bool Discard_IsValid;

	private static IntPtr Discard_FunctionAddress;

	private static int Discard_ParamsSize;

	private static bool Commit_IsValid;

	private static IntPtr Commit_FunctionAddress;

	private static int Commit_ParamsSize;

	private static bool CloseTab_IsValid;

	private static IntPtr CloseTab_FunctionAddress;

	private static int CloseTab_ParamsSize;

	private static bool CloseTab_Widget_IsValid;

	private static FFieldAddress CloseTab_Widget_PropertyAddress;

	private static int CloseTab_Widget_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorTab:TabId")]
	public FName TabId
	{
		get
		{
			CheckDestroyed();
			if (!TabId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorTab:TabId");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, TabId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TabId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorTab:TabId");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, TabId_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370500uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorTab:DisplayName")]
	public FText DisplayName
	{
		get
		{
			CheckDestroyed();
			if (!DisplayName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorTab:DisplayName");
				return null;
			}
			if (DisplayName_TextCached == null)
			{
				DisplayName_TextCached = new FText(IntPtr.Add(base.Address, DisplayName_Offset), createReference: false);
			}
			return DisplayName_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!DisplayName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorTab:DisplayName");
				return;
			}
			if (DisplayName_TextCached == null)
			{
				DisplayName_TextCached = new FText(IntPtr.Add(base.Address, DisplayName_Offset), createReference: false);
			}
			DisplayName_TextCached.CopyFrom(value);
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorTab:bIsNomad")]
	public bool IsNomad
	{
		get
		{
			CheckDestroyed();
			if (!IsNomad_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorTab:bIsNomad");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsNomad_Offset), 0, IsNomad_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsNomad_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorTab:bIsNomad");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsNomad_Offset), 0, IsNomad_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorTab:Role")]
	public EJavascriptTabRole Role
	{
		get
		{
			CheckDestroyed();
			if (!Role_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorTab:Role");
				return EJavascriptTabRole.MajorTab;
			}
			return EnumMarshaler<EJavascriptTabRole>.FromNative(IntPtr.Add(base.Address, Role_Offset), 0, Role_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Role_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorTab:Role");
			}
			else
			{
				EnumMarshaler<EJavascriptTabRole>.ToNative(IntPtr.Add(base.Address, Role_Offset), 0, Role_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorTab:ForceCommit")]
	public unsafe void ForceCommit()
	{
		CheckDestroyed();
		if (!ForceCommit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorTab:ForceCommit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceCommit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceCommit_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ForceCommit_FunctionAddress, argsSize: ForceCommit_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorTab:Discard")]
	public unsafe void Discard()
	{
		CheckDestroyed();
		if (!Discard_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorTab:Discard");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Discard_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Discard_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Discard_FunctionAddress, argsSize: Discard_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorTab:Commit")]
	public unsafe void Commit()
	{
		CheckDestroyed();
		if (!Commit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorTab:Commit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Commit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Commit_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Commit_FunctionAddress, argsSize: Commit_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorTab:CloseTab")]
	public unsafe void CloseTab(UWidget Widget)
	{
		CheckDestroyed();
		if (!CloseTab_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorTab:CloseTab");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CloseTab_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CloseTab_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, CloseTab_Widget_Offset), 0, CloseTab_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeFunctionOptimized(base.Address, CloseTab_FunctionAddress, intPtr, CloseTab_ParamsSize);
	}

	static UJavascriptEditorTab()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptEditorTab)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptEditorTab));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/JavascriptEditor.JavascriptEditorTab");
		TabId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TabId");
		TabId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TabId", Classes.FNameProperty);
		DisplayName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisplayName");
		DisplayName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisplayName", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref IsNomad_PropertyAddress, intPtr, "bIsNomad");
		IsNomad_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsNomad");
		IsNomad_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsNomad", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Role_PropertyAddress, intPtr, "Role");
		Role_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Role");
		Role_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Role", Classes.FByteProperty);
		ForceCommit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ForceCommit");
		ForceCommit_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceCommit_FunctionAddress);
		ForceCommit_IsValid = ForceCommit_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorTab:ForceCommit", ForceCommit_IsValid);
		Discard_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Discard");
		Discard_ParamsSize = NativeReflection.GetFunctionParamsSize(Discard_FunctionAddress);
		Discard_IsValid = Discard_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorTab:Discard", Discard_IsValid);
		Commit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Commit");
		Commit_ParamsSize = NativeReflection.GetFunctionParamsSize(Commit_FunctionAddress);
		Commit_IsValid = Commit_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorTab:Commit", Commit_IsValid);
		CloseTab_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CloseTab");
		CloseTab_ParamsSize = NativeReflection.GetFunctionParamsSize(CloseTab_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CloseTab_Widget_PropertyAddress, CloseTab_FunctionAddress, "Widget");
		CloseTab_Widget_Offset = NativeReflectionCached.GetPropertyOffset(CloseTab_FunctionAddress, "Widget");
		CloseTab_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(CloseTab_FunctionAddress, "Widget", Classes.FObjectProperty);
		CloseTab_IsValid = CloseTab_FunctionAddress != IntPtr.Zero && CloseTab_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorTab:CloseTab", CloseTab_IsValid);
	}
}
