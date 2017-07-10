// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLChannelAdminLogEventActionToggleInvites : TLChannelAdminLogEventActionBase 
	{
		public Boolean NewValue { get; set; }

		public TLChannelAdminLogEventActionToggleInvites() { }
		public TLChannelAdminLogEventActionToggleInvites(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelAdminLogEventActionToggleInvites; } }

		public override void Read(TLBinaryReader from)
		{
			NewValue = from.ReadBoolean();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteBoolean(NewValue);
		}
	}
}