// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLInputPhoneCall : TLObject 
	{
		public Int64 Id { get; set; }
		public Int64 AccessHash { get; set; }

		public TLInputPhoneCall() { }
		public TLInputPhoneCall(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputPhoneCall; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadInt64();
			AccessHash = from.ReadInt64();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt64(Id);
			to.WriteInt64(AccessHash);
		}
	}
}