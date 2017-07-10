// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Auth
{
	public partial class TLAuthCheckedPhone : TLObject 
	{
		public Boolean PhoneRegistered { get; set; }

		public TLAuthCheckedPhone() { }
		public TLAuthCheckedPhone(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AuthCheckedPhone; } }

		public override void Read(TLBinaryReader from)
		{
			PhoneRegistered = from.ReadBoolean();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteBoolean(PhoneRegistered);
		}
	}
}