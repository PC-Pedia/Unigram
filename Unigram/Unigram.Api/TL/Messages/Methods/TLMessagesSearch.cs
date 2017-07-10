// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Messages.Methods
{
	/// <summary>
	/// RCP method messages.search.
	/// Returns <see cref="Telegram.Api.TL.TLMessagesMessages"/>
	/// </summary>
	public partial class TLMessagesSearch : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			FromId = (1 << 0),
		}

		public bool HasFromId { get { return Flags.HasFlag(Flag.FromId); } set { Flags = value ? (Flags | Flag.FromId) : (Flags & ~Flag.FromId); } }

		public Flag Flags { get; set; }
		public TLInputPeerBase Peer { get; set; }
		public String Q { get; set; }
		public TLInputUserBase FromId { get; set; }
		public TLMessagesFilterBase Filter { get; set; }
		public Int32 MinDate { get; set; }
		public Int32 MaxDate { get; set; }
		public Int32 Offset { get; set; }
		public Int32 MaxId { get; set; }
		public Int32 Limit { get; set; }

		public TLMessagesSearch() { }
		public TLMessagesSearch(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesSearch; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Peer = TLFactory.Read<TLInputPeerBase>(from);
			Q = from.ReadString();
			if (HasFromId) FromId = TLFactory.Read<TLInputUserBase>(from);
			Filter = TLFactory.Read<TLMessagesFilterBase>(from);
			MinDate = from.ReadInt32();
			MaxDate = from.ReadInt32();
			Offset = from.ReadInt32();
			MaxId = from.ReadInt32();
			Limit = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			to.WriteObject(Peer);
			to.WriteString(Q ?? string.Empty);
			if (HasFromId) to.WriteObject(FromId);
			to.WriteObject(Filter);
			to.WriteInt32(MinDate);
			to.WriteInt32(MaxDate);
			to.WriteInt32(Offset);
			to.WriteInt32(MaxId);
			to.WriteInt32(Limit);
		}

		private void UpdateFlags()
		{
			HasFromId = FromId != null;
		}
	}
}