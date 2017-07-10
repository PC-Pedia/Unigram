// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLUpdateBotInlineSend : TLUpdateBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			Geo = (1 << 0),
			MsgId = (1 << 1),
		}

		public bool HasGeo { get { return Flags.HasFlag(Flag.Geo); } set { Flags = value ? (Flags | Flag.Geo) : (Flags & ~Flag.Geo); } }
		public bool HasMsgId { get { return Flags.HasFlag(Flag.MsgId); } set { Flags = value ? (Flags | Flag.MsgId) : (Flags & ~Flag.MsgId); } }

		public Flag Flags { get; set; }
		public Int32 UserId { get; set; }
		public String Query { get; set; }
		public TLGeoPointBase Geo { get; set; }
		public String Id { get; set; }
		public TLInputBotInlineMessageID MsgId { get; set; }

		public TLUpdateBotInlineSend() { }
		public TLUpdateBotInlineSend(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateBotInlineSend; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			UserId = from.ReadInt32();
			Query = from.ReadString();
			if (HasGeo) Geo = TLFactory.Read<TLGeoPointBase>(from);
			Id = from.ReadString();
			if (HasMsgId) MsgId = TLFactory.Read<TLInputBotInlineMessageID>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			to.WriteInt32(UserId);
			to.WriteString(Query ?? string.Empty);
			if (HasGeo) to.WriteObject(Geo);
			to.WriteString(Id ?? string.Empty);
			if (HasMsgId) to.WriteObject(MsgId);
		}

		private void UpdateFlags()
		{
			HasGeo = Geo != null;
			HasMsgId = MsgId != null;
		}
	}
}