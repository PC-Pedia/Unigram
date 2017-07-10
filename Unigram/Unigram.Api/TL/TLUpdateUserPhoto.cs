// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLUpdateUserPhoto : TLUpdateBase 
	{
		public Int32 UserId { get; set; }
		public Int32 Date { get; set; }
		public TLUserProfilePhotoBase Photo { get; set; }
		public Boolean Previous { get; set; }

		public TLUpdateUserPhoto() { }
		public TLUpdateUserPhoto(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateUserPhoto; } }

		public override void Read(TLBinaryReader from)
		{
			UserId = from.ReadInt32();
			Date = from.ReadInt32();
			Photo = TLFactory.Read<TLUserProfilePhotoBase>(from);
			Previous = from.ReadBoolean();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(UserId);
			to.WriteInt32(Date);
			to.WriteObject(Photo);
			to.WriteBoolean(Previous);
		}
	}
}