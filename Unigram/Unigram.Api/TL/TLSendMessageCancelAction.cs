// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLSendMessageCancelAction : TLSendMessageActionBase 
	{
		public TLSendMessageCancelAction() { }
		public TLSendMessageCancelAction(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.SendMessageCancelAction; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
		}
	}
}