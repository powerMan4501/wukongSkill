using System;

namespace Internal.Cryptography;

internal abstract class BasicSymmetricCipher : IDisposable
{
	public int BlockSizeInBytes { get; private set; }

	protected byte[] IV { get; private set; }

	protected BasicSymmetricCipher(byte[] iv, int blockSizeInBytes)
	{
		IV = iv;
		BlockSizeInBytes = blockSizeInBytes;
	}

	public abstract int Transform(byte[] input, int inputOffset, int count, byte[] output, int outputOffset);

	public abstract byte[] TransformFinal(byte[] input, int inputOffset, int count);

	public virtual void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && IV != null)
		{
			Array.Clear(IV, 0, IV.Length);
			IV = null;
		}
	}
}
