using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[UMetaPath("/Script/JavascriptEditor.JavascriptUICommands", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptUICommands : UObject
{
	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommands:JavascriptExecuteAction__DelegateSignature")]
	public class FJavascriptExecuteAction : FDelegate<FJavascriptExecuteAction.Signature>
	{
		public delegate void Signature(string Id);

		private static bool JavascriptExecuteAction__DelegateSignature_IsValid;

		private static IntPtr JavascriptExecuteAction__DelegateSignature_FunctionAddress;

		private static int JavascriptExecuteAction__DelegateSignature_ParamsSize;

		private static bool JavascriptExecuteAction__DelegateSignature_Id_IsValid;

		private static FFieldAddress JavascriptExecuteAction__DelegateSignature_Id_PropertyAddress;

		private static int JavascriptExecuteAction__DelegateSignature_Id_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FJavascriptExecuteAction()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			JavascriptExecuteAction__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptUICommands:JavascriptExecuteAction__DelegateSignature");
			JavascriptExecuteAction__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(JavascriptExecuteAction__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref JavascriptExecuteAction__DelegateSignature_Id_PropertyAddress, JavascriptExecuteAction__DelegateSignature_FunctionAddress, "Id");
			JavascriptExecuteAction__DelegateSignature_Id_Offset = NativeReflectionCached.GetPropertyOffset(JavascriptExecuteAction__DelegateSignature_FunctionAddress, "Id");
			JavascriptExecuteAction__DelegateSignature_Id_IsValid = NativeReflectionCached.ValidatePropertyClass(JavascriptExecuteAction__DelegateSignature_FunctionAddress, "Id", Classes.FStrProperty);
			JavascriptExecuteAction__DelegateSignature_IsValid = JavascriptExecuteAction__DelegateSignature_FunctionAddress != IntPtr.Zero && JavascriptExecuteAction__DelegateSignature_Id_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptUICommands:JavascriptExecuteAction__DelegateSignature", JavascriptExecuteAction__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(string Id)
		{
			if (!JavascriptExecuteAction__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptUICommands:JavascriptExecuteAction__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(JavascriptExecuteAction__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)JavascriptExecuteAction__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				FStringMarshaler.ToNative(IntPtr.Add(intPtr, JavascriptExecuteAction__DelegateSignature_Id_Offset), 0, JavascriptExecuteAction__DelegateSignature_Id_PropertyAddress.Address, Id);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(JavascriptExecuteAction__DelegateSignature_Id_PropertyAddress.Address, intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommands:JavascriptCanExecuteAction__DelegateSignature")]
	public class FJavascriptCanExecuteAction : FDelegate<FJavascriptCanExecuteAction.Signature>
	{
		public delegate bool Signature(string Id);

		private static bool JavascriptCanExecuteAction__DelegateSignature_IsValid;

		private static IntPtr JavascriptCanExecuteAction__DelegateSignature_FunctionAddress;

		private static int JavascriptCanExecuteAction__DelegateSignature_ParamsSize;

		private static bool JavascriptCanExecuteAction__DelegateSignature_Id_IsValid;

		private static FFieldAddress JavascriptCanExecuteAction__DelegateSignature_Id_PropertyAddress;

		private static int JavascriptCanExecuteAction__DelegateSignature_Id_Offset;

		private static bool JavascriptCanExecuteAction__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress JavascriptCanExecuteAction__DelegateSignature_ReturnValue_PropertyAddress;

		private static int JavascriptCanExecuteAction__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FJavascriptCanExecuteAction()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			JavascriptCanExecuteAction__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptUICommands:JavascriptCanExecuteAction__DelegateSignature");
			JavascriptCanExecuteAction__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(JavascriptCanExecuteAction__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref JavascriptCanExecuteAction__DelegateSignature_Id_PropertyAddress, JavascriptCanExecuteAction__DelegateSignature_FunctionAddress, "Id");
			JavascriptCanExecuteAction__DelegateSignature_Id_Offset = NativeReflectionCached.GetPropertyOffset(JavascriptCanExecuteAction__DelegateSignature_FunctionAddress, "Id");
			JavascriptCanExecuteAction__DelegateSignature_Id_IsValid = NativeReflectionCached.ValidatePropertyClass(JavascriptCanExecuteAction__DelegateSignature_FunctionAddress, "Id", Classes.FStrProperty);
			NativeReflectionCached.GetPropertyRef(ref JavascriptCanExecuteAction__DelegateSignature_ReturnValue_PropertyAddress, JavascriptCanExecuteAction__DelegateSignature_FunctionAddress, "ReturnValue");
			JavascriptCanExecuteAction__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(JavascriptCanExecuteAction__DelegateSignature_FunctionAddress, "ReturnValue");
			JavascriptCanExecuteAction__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(JavascriptCanExecuteAction__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
			JavascriptCanExecuteAction__DelegateSignature_IsValid = JavascriptCanExecuteAction__DelegateSignature_FunctionAddress != IntPtr.Zero && JavascriptCanExecuteAction__DelegateSignature_Id_IsValid && JavascriptCanExecuteAction__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptUICommands:JavascriptCanExecuteAction__DelegateSignature", JavascriptCanExecuteAction__DelegateSignature_IsValid);
		}

		private unsafe bool Invoker(string Id)
		{
			if (!JavascriptCanExecuteAction__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptUICommands:JavascriptCanExecuteAction__DelegateSignature");
				return false;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(JavascriptCanExecuteAction__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)JavascriptCanExecuteAction__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				FStringMarshaler.ToNative(IntPtr.Add(intPtr, JavascriptCanExecuteAction__DelegateSignature_Id_Offset), 0, JavascriptCanExecuteAction__DelegateSignature_Id_PropertyAddress.Address, Id);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(JavascriptCanExecuteAction__DelegateSignature_Id_PropertyAddress.Address, intPtr);
				return BoolMarshaler.FromNative(IntPtr.Add(intPtr, JavascriptCanExecuteAction__DelegateSignature_ReturnValue_Offset), 0, JavascriptCanExecuteAction__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return false;
		}
	}

	private static IntPtr classAddress;

	private static bool Commands_IsValid;

	private static FFieldAddress Commands_PropertyAddress;

	private static int Commands_Offset;

	private TArrayReadWriteMarshaler<FJavascriptUICommand> Commands_MarshalerCached;

	private static bool ContextName_IsValid;

	private static int ContextName_Offset;

	private static bool ContextDesc_IsValid;

	private static int ContextDesc_Offset;

	private FText ContextDesc_TextCached;

	private static bool ContextNameParent_IsValid;

	private static int ContextNameParent_Offset;

	private static bool StyleSetName_IsValid;

	private static int StyleSetName_Offset;

	private static bool TextSubNamespace_IsValid;

	private static int TextSubNamespace_Offset;

	private static bool CommandInfos_IsValid;

	private static FFieldAddress CommandInfos_PropertyAddress;

	private static int CommandInfos_Offset;

	private TArrayReadWriteMarshaler<FJavascriptUICommandInfo> CommandInfos_MarshalerCached;

	private static bool BindingContext_IsValid;

	private static int BindingContext_Offset;

	private static bool Uninitialize_IsValid;

	private static IntPtr Uninitialize_FunctionAddress;

	private static int Uninitialize_ParamsSize;

	private static bool Unbind_IsValid;

	private static IntPtr Unbind_FunctionAddress;

	private static int Unbind_ParamsSize;

	private static bool Unbind_List_IsValid;

	private static FFieldAddress Unbind_List_PropertyAddress;

	private static int Unbind_List_Offset;

	private static bool Refresh_IsValid;

	private static IntPtr Refresh_FunctionAddress;

	private static int Refresh_ParamsSize;

	private static bool Initialize_IsValid;

	private static IntPtr Initialize_FunctionAddress;

	private static int Initialize_ParamsSize;

	private static bool GetAction_IsValid;

	private static IntPtr GetAction_FunctionAddress;

	private static int GetAction_ParamsSize;

	private static bool GetAction_Id_IsValid;

	private static FFieldAddress GetAction_Id_PropertyAddress;

	private static int GetAction_Id_Offset;

	private static bool GetAction_ReturnValue_IsValid;

	private static FFieldAddress GetAction_ReturnValue_PropertyAddress;

	private static int GetAction_ReturnValue_Offset;

	private static bool Discard_IsValid;

	private static IntPtr Discard_FunctionAddress;

	private static int Discard_ParamsSize;

	private static bool Commit_IsValid;

	private static IntPtr Commit_FunctionAddress;

	private static int Commit_ParamsSize;

	private static bool BroadcastCommandsChanged_IsValid;

	private static IntPtr BroadcastCommandsChanged_FunctionAddress;

	private static int BroadcastCommandsChanged_ParamsSize;

	private static bool BroadcastCommandsChanged_InContextName_IsValid;

	private static FFieldAddress BroadcastCommandsChanged_InContextName_PropertyAddress;

	private static int BroadcastCommandsChanged_InContextName_Offset;

	private static bool Bind_IsValid;

	private static IntPtr Bind_FunctionAddress;

	private static int Bind_ParamsSize;

	private static bool Bind_List_IsValid;

	private static FFieldAddress Bind_List_PropertyAddress;

	private static int Bind_List_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommands:Commands")]
	public TArrayReadWrite<FJavascriptUICommand> Commands
	{
		get
		{
			CheckDestroyed();
			if (!Commands_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptUICommands:Commands");
				return null;
			}
			if (Commands_MarshalerCached == null)
			{
				Commands_MarshalerCached = new TArrayReadWriteMarshaler<FJavascriptUICommand>(1, Commands_PropertyAddress, CachedMarshalingDelegates<FJavascriptUICommand, FJavascriptUICommand>.FromNative, CachedMarshalingDelegates<FJavascriptUICommand, FJavascriptUICommand>.ToNative);
			}
			return Commands_MarshalerCached.FromNative(IntPtr.Add(base.Address, Commands_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommands:ContextName")]
	public string ContextName
	{
		get
		{
			CheckDestroyed();
			if (!ContextName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptUICommands:ContextName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, ContextName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ContextName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptUICommands:ContextName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, ContextName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370500uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommands:ContextDesc")]
	public FText ContextDesc
	{
		get
		{
			CheckDestroyed();
			if (!ContextDesc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptUICommands:ContextDesc");
				return null;
			}
			if (ContextDesc_TextCached == null)
			{
				ContextDesc_TextCached = new FText(IntPtr.Add(base.Address, ContextDesc_Offset), createReference: false);
			}
			return ContextDesc_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!ContextDesc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptUICommands:ContextDesc");
				return;
			}
			if (ContextDesc_TextCached == null)
			{
				ContextDesc_TextCached = new FText(IntPtr.Add(base.Address, ContextDesc_Offset), createReference: false);
			}
			ContextDesc_TextCached.CopyFrom(value);
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommands:ContextNameParent")]
	public FName ContextNameParent
	{
		get
		{
			CheckDestroyed();
			if (!ContextNameParent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptUICommands:ContextNameParent");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ContextNameParent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ContextNameParent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptUICommands:ContextNameParent");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ContextNameParent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommands:StyleSetName")]
	public FName StyleSetName
	{
		get
		{
			CheckDestroyed();
			if (!StyleSetName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptUICommands:StyleSetName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, StyleSetName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StyleSetName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptUICommands:StyleSetName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, StyleSetName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommands:TextSubNamespace")]
	public string TextSubNamespace
	{
		get
		{
			CheckDestroyed();
			if (!TextSubNamespace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptUICommands:TextSubNamespace");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, TextSubNamespace_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextSubNamespace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptUICommands:TextSubNamespace");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, TextSubNamespace_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommands:CommandInfos")]
	public TArrayReadWrite<FJavascriptUICommandInfo> CommandInfos
	{
		get
		{
			CheckDestroyed();
			if (!CommandInfos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptUICommands:CommandInfos");
				return null;
			}
			if (CommandInfos_MarshalerCached == null)
			{
				CommandInfos_MarshalerCached = new TArrayReadWriteMarshaler<FJavascriptUICommandInfo>(1, CommandInfos_PropertyAddress, CachedMarshalingDelegates<FJavascriptUICommandInfo, FJavascriptUICommandInfo>.FromNative, CachedMarshalingDelegates<FJavascriptUICommandInfo, FJavascriptUICommandInfo>.ToNative);
			}
			return CommandInfos_MarshalerCached.FromNative(IntPtr.Add(base.Address, CommandInfos_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370500uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommands:BindingContext")]
	public FJavascriptBindingContext BindingContext
	{
		get
		{
			CheckDestroyed();
			if (!BindingContext_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptUICommands:BindingContext");
				return default(FJavascriptBindingContext);
			}
			return FJavascriptBindingContext.FromNative(IntPtr.Add(base.Address, BindingContext_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BindingContext_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptUICommands:BindingContext");
			}
			else
			{
				FJavascriptBindingContext.ToNative(IntPtr.Add(base.Address, BindingContext_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommands:Uninitialize")]
	public unsafe void Uninitialize()
	{
		CheckDestroyed();
		if (!Uninitialize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptUICommands:Uninitialize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Uninitialize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Uninitialize_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Uninitialize_FunctionAddress, argsSize: Uninitialize_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommands:Unbind")]
	public unsafe void Unbind(FJavascriptUICommandList List)
	{
		CheckDestroyed();
		if (!Unbind_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptUICommands:Unbind");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Unbind_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Unbind_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Unbind_List_PropertyAddress.Address, intPtr);
		FJavascriptUICommandList.ToNative(IntPtr.Add(intPtr, Unbind_List_Offset), 0, Unbind_List_PropertyAddress.Address, List);
		NativeReflection.InvokeFunctionOptimized(base.Address, Unbind_FunctionAddress, intPtr, Unbind_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Unbind_List_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommands:Refresh")]
	public unsafe void Refresh()
	{
		CheckDestroyed();
		if (!Refresh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptUICommands:Refresh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Refresh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Refresh_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Refresh_FunctionAddress, argsSize: Refresh_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommands:Initialize")]
	public new unsafe void Initialize()
	{
		CheckDestroyed();
		if (!Initialize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptUICommands:Initialize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Initialize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Initialize_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Initialize_FunctionAddress, argsSize: Initialize_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommands:GetAction")]
	public unsafe FJavascriptUICommandInfo GetAction(string Id)
	{
		CheckDestroyed();
		if (!GetAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptUICommands:GetAction");
			return default(FJavascriptUICommandInfo);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetAction_Id_Offset), 0, GetAction_Id_PropertyAddress.Address, Id);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAction_FunctionAddress, intPtr, GetAction_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAction_Id_PropertyAddress.Address, intPtr);
		FJavascriptUICommandInfo result = FJavascriptUICommandInfo.FromNative(IntPtr.Add(intPtr, GetAction_ReturnValue_Offset), 0, GetAction_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAction_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommands:Discard")]
	public unsafe void Discard()
	{
		CheckDestroyed();
		if (!Discard_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptUICommands:Discard");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Discard_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Discard_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Discard_FunctionAddress, argsSize: Discard_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommands:Commit")]
	public unsafe void Commit()
	{
		CheckDestroyed();
		if (!Commit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptUICommands:Commit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Commit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Commit_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Commit_FunctionAddress, argsSize: Commit_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommands:BroadcastCommandsChanged")]
	public unsafe static void BroadcastCommandsChanged(string InContextName)
	{
		if (!BroadcastCommandsChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptUICommands:BroadcastCommandsChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BroadcastCommandsChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BroadcastCommandsChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BroadcastCommandsChanged_InContextName_Offset), 0, BroadcastCommandsChanged_InContextName_PropertyAddress.Address, InContextName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BroadcastCommandsChanged_FunctionAddress, intPtr, BroadcastCommandsChanged_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BroadcastCommandsChanged_InContextName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommands:Bind")]
	public unsafe void Bind(FJavascriptUICommandList List)
	{
		CheckDestroyed();
		if (!Bind_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptUICommands:Bind");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Bind_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Bind_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Bind_List_PropertyAddress.Address, intPtr);
		FJavascriptUICommandList.ToNative(IntPtr.Add(intPtr, Bind_List_Offset), 0, Bind_List_PropertyAddress.Address, List);
		NativeReflection.InvokeFunctionOptimized(base.Address, Bind_FunctionAddress, intPtr, Bind_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Bind_List_PropertyAddress.Address, intPtr);
	}

	static UJavascriptUICommands()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptUICommands)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptUICommands));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/JavascriptEditor.JavascriptUICommands");
		NativeReflectionCached.GetPropertyRef(ref Commands_PropertyAddress, classAddress, "Commands");
		Commands_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "Commands");
		Commands_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "Commands", Classes.FArrayProperty);
		ContextName_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "ContextName");
		ContextName_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "ContextName", Classes.FStrProperty);
		ContextDesc_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "ContextDesc");
		ContextDesc_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "ContextDesc", Classes.FTextProperty);
		ContextNameParent_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "ContextNameParent");
		ContextNameParent_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "ContextNameParent", Classes.FNameProperty);
		StyleSetName_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "StyleSetName");
		StyleSetName_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "StyleSetName", Classes.FNameProperty);
		TextSubNamespace_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "TextSubNamespace");
		TextSubNamespace_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "TextSubNamespace", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CommandInfos_PropertyAddress, classAddress, "CommandInfos");
		CommandInfos_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "CommandInfos");
		CommandInfos_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "CommandInfos", Classes.FArrayProperty);
		BindingContext_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "BindingContext");
		BindingContext_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "BindingContext", Classes.FStructProperty);
		Uninitialize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Uninitialize");
		Uninitialize_ParamsSize = NativeReflection.GetFunctionParamsSize(Uninitialize_FunctionAddress);
		Uninitialize_IsValid = Uninitialize_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptUICommands:Uninitialize", Uninitialize_IsValid);
		Unbind_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Unbind");
		Unbind_ParamsSize = NativeReflection.GetFunctionParamsSize(Unbind_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Unbind_List_PropertyAddress, Unbind_FunctionAddress, "List");
		Unbind_List_Offset = NativeReflectionCached.GetPropertyOffset(Unbind_FunctionAddress, "List");
		Unbind_List_IsValid = NativeReflectionCached.ValidatePropertyClass(Unbind_FunctionAddress, "List", Classes.FStructProperty);
		Unbind_IsValid = Unbind_FunctionAddress != IntPtr.Zero && Unbind_List_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptUICommands:Unbind", Unbind_IsValid);
		Refresh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Refresh");
		Refresh_ParamsSize = NativeReflection.GetFunctionParamsSize(Refresh_FunctionAddress);
		Refresh_IsValid = Refresh_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptUICommands:Refresh", Refresh_IsValid);
		Initialize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Initialize");
		Initialize_ParamsSize = NativeReflection.GetFunctionParamsSize(Initialize_FunctionAddress);
		Initialize_IsValid = Initialize_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptUICommands:Initialize", Initialize_IsValid);
		GetAction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAction");
		GetAction_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAction_Id_PropertyAddress, GetAction_FunctionAddress, "Id");
		GetAction_Id_Offset = NativeReflectionCached.GetPropertyOffset(GetAction_FunctionAddress, "Id");
		GetAction_Id_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAction_FunctionAddress, "Id", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAction_ReturnValue_PropertyAddress, GetAction_FunctionAddress, "ReturnValue");
		GetAction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAction_FunctionAddress, "ReturnValue");
		GetAction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAction_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetAction_IsValid = GetAction_FunctionAddress != IntPtr.Zero && GetAction_Id_IsValid && GetAction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptUICommands:GetAction", GetAction_IsValid);
		Discard_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Discard");
		Discard_ParamsSize = NativeReflection.GetFunctionParamsSize(Discard_FunctionAddress);
		Discard_IsValid = Discard_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptUICommands:Discard", Discard_IsValid);
		Commit_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Commit");
		Commit_ParamsSize = NativeReflection.GetFunctionParamsSize(Commit_FunctionAddress);
		Commit_IsValid = Commit_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptUICommands:Commit", Commit_IsValid);
		BroadcastCommandsChanged_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BroadcastCommandsChanged");
		BroadcastCommandsChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(BroadcastCommandsChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BroadcastCommandsChanged_InContextName_PropertyAddress, BroadcastCommandsChanged_FunctionAddress, "InContextName");
		BroadcastCommandsChanged_InContextName_Offset = NativeReflectionCached.GetPropertyOffset(BroadcastCommandsChanged_FunctionAddress, "InContextName");
		BroadcastCommandsChanged_InContextName_IsValid = NativeReflectionCached.ValidatePropertyClass(BroadcastCommandsChanged_FunctionAddress, "InContextName", Classes.FStrProperty);
		BroadcastCommandsChanged_IsValid = BroadcastCommandsChanged_FunctionAddress != IntPtr.Zero && BroadcastCommandsChanged_InContextName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptUICommands:BroadcastCommandsChanged", BroadcastCommandsChanged_IsValid);
		Bind_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Bind");
		Bind_ParamsSize = NativeReflection.GetFunctionParamsSize(Bind_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Bind_List_PropertyAddress, Bind_FunctionAddress, "List");
		Bind_List_Offset = NativeReflectionCached.GetPropertyOffset(Bind_FunctionAddress, "List");
		Bind_List_IsValid = NativeReflectionCached.ValidatePropertyClass(Bind_FunctionAddress, "List", Classes.FStructProperty);
		Bind_IsValid = Bind_FunctionAddress != IntPtr.Zero && Bind_List_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptUICommands:Bind", Bind_IsValid);
	}
}
