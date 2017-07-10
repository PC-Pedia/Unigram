// <auto-generated/>
using System;
using Telegram.Api.Native.TL;
using Telegram.Api.TL.Messages;

namespace Telegram.Api.TL
{
	public partial class TLUpdateNewStickerSet : TLUpdateBase 
	{
		public TLMessagesStickerSet StickerSet { get; set; }

		public TLUpdateNewStickerSet() { }
		public TLUpdateNewStickerSet(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateNewStickerSet; } }

		public override void Read(TLBinaryReader from)
		{
			StickerSet = TLFactory.Read<TLMessagesStickerSet>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(StickerSet);
		}
	}
}