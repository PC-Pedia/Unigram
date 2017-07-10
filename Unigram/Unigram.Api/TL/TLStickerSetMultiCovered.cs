// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLStickerSetMultiCovered : TLStickerSetCoveredBase 
	{
		public TLVector<TLDocumentBase> Covers { get; set; }

		public TLStickerSetMultiCovered() { }
		public TLStickerSetMultiCovered(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.StickerSetMultiCovered; } }

		public override void Read(TLBinaryReader from)
		{
			Set = TLFactory.Read<TLStickerSet>(from);
			Covers = TLFactory.Read<TLVector<TLDocumentBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Set);
			to.WriteObject(Covers);
		}
	}
}