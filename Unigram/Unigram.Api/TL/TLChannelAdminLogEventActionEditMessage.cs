// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLChannelAdminLogEventActionEditMessage : TLChannelAdminLogEventActionBase 
	{
		public TLMessageBase PrevMessage { get; set; }
		public TLMessageBase NewMessage { get; set; }

		public TLChannelAdminLogEventActionEditMessage() { }
		public TLChannelAdminLogEventActionEditMessage(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelAdminLogEventActionEditMessage; } }

		public override void Read(TLBinaryReader from)
		{
			PrevMessage = TLFactory.Read<TLMessageBase>(from);
			NewMessage = TLFactory.Read<TLMessageBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(PrevMessage);
			to.WriteObject(NewMessage);
		}
	}
}