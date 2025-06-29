using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using Microsoft.Runtime.Hosting;

namespace System.Reflection;

[Serializable]
[ComVisible(true)]
public class StrongNameKeyPair : IDeserializationCallback, ISerializable
{
	private bool _keyPairExported;

	private byte[] _keyPairArray;

	private string _keyPairContainer;

	private byte[] _publicKey;

	public byte[] PublicKey
	{
		[SecuritySafeCritical]
		get
		{
			if (_publicKey == null)
			{
				_publicKey = ComputePublicKey();
			}
			byte[] array = new byte[_publicKey.Length];
			Array.Copy(_publicKey, array, _publicKey.Length);
			return array;
		}
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public StrongNameKeyPair(FileStream keyPairFile)
	{
		if (keyPairFile == null)
		{
			throw new ArgumentNullException("keyPairFile");
		}
		int num = (int)keyPairFile.Length;
		_keyPairArray = new byte[num];
		keyPairFile.Read(_keyPairArray, 0, num);
		_keyPairExported = true;
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public StrongNameKeyPair(byte[] keyPairArray)
	{
		if (keyPairArray == null)
		{
			throw new ArgumentNullException("keyPairArray");
		}
		_keyPairArray = new byte[keyPairArray.Length];
		Array.Copy(keyPairArray, _keyPairArray, keyPairArray.Length);
		_keyPairExported = true;
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public StrongNameKeyPair(string keyPairContainer)
	{
		if (keyPairContainer == null)
		{
			throw new ArgumentNullException("keyPairContainer");
		}
		_keyPairContainer = keyPairContainer;
		_keyPairExported = false;
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	protected StrongNameKeyPair(SerializationInfo info, StreamingContext context)
	{
		_keyPairExported = (bool)info.GetValue("_keyPairExported", typeof(bool));
		_keyPairArray = (byte[])info.GetValue("_keyPairArray", typeof(byte[]));
		_keyPairContainer = (string)info.GetValue("_keyPairContainer", typeof(string));
		_publicKey = (byte[])info.GetValue("_publicKey", typeof(byte[]));
	}

	[SecurityCritical]
	private unsafe byte[] ComputePublicKey()
	{
		byte[] array = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			IntPtr ppbPublicKeyBlob = IntPtr.Zero;
			int pcbPublicKeyBlob = 0;
			try
			{
				if (!((!_keyPairExported) ? StrongNameHelpers.StrongNameGetPublicKey(_keyPairContainer, null, 0, out ppbPublicKeyBlob, out pcbPublicKeyBlob) : StrongNameHelpers.StrongNameGetPublicKey(null, _keyPairArray, _keyPairArray.Length, out ppbPublicKeyBlob, out pcbPublicKeyBlob)))
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_StrongNameGetPublicKey"));
				}
				array = new byte[pcbPublicKeyBlob];
				Buffer.Memcpy(array, 0, (byte*)ppbPublicKeyBlob.ToPointer(), 0, pcbPublicKeyBlob);
			}
			finally
			{
				if (ppbPublicKeyBlob != IntPtr.Zero)
				{
					StrongNameHelpers.StrongNameFreeBuffer(ppbPublicKeyBlob);
				}
			}
		}
		return array;
	}

	[SecurityCritical]
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("_keyPairExported", _keyPairExported);
		info.AddValue("_keyPairArray", _keyPairArray);
		info.AddValue("_keyPairContainer", _keyPairContainer);
		info.AddValue("_publicKey", _publicKey);
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
	}

	private bool GetKeyPair(out object arrayOrContainer)
	{
		arrayOrContainer = (_keyPairExported ? ((object)_keyPairArray) : ((object)_keyPairContainer));
		return _keyPairExported;
	}
}
