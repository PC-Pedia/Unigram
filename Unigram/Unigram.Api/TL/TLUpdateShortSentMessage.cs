// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLUpdateShortSentMessage : TLUpdatesBase, ITLMultiPts 
	{
		[Flags]
		public enum Flag : Int32
		{
			Out = (1 << 1),
			Media = (1 << 9),
			Entities = (1 << 7),
		}

		public bool IsOut { get { return Flags.HasFlag(Flag.Out); } set { Flags = value ? (Flags | Flag.Out) : (Flags & ~Flag.Out); } }
		public bool HasMedia { get { return Flags.HasFlag(Flag.Media); } set { Flags = value ? (Flags | Flag.Media) : (Flags & ~Flag.Media); } }
		public bool HasEntities { get { return Flags.HasFlag(Flag.Entities); } set { Flags = value ? (Flags | Flag.Entities) : (Flags & ~Flag.Entities); } }

		public Flag Flags { get; set; }
		public Int32 Id { get; set; }
		public Int32 Pts { get; set; }
		public Int32 PtsCount { get; set; }
		public Int32 Date { get; set; }
		public TLMessageMediaBase Media { get; set; }
		public TLVector<TLMessageEntityBase> Entities { get; set; }

		public TLUpdateShortSentMessage() { }
		public TLUpdateShortSentMessage(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateShortSentMessage; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Id = from.ReadInt32();
			Pts = from.ReadInt32();
			PtsCount = from.ReadInt32();
			Date = from.ReadInt32();
			if (HasMedia) Media = TLFactory.Read<TLMessageMediaBase>(from);
			if (HasEntities) Entities = TLFactory.Read<TLVector<TLMessageEntityBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			to.WriteInt32(Id);
			to.WriteInt32(Pts);
			to.WriteInt32(PtsCount);
			to.WriteInt32(Date);
			if (HasMedia) to.WriteObject(Media);
			if (HasEntities) to.WriteObject(Entities);
		}

		private void UpdateFlags()
		{
			HasMedia = Media != null;
			HasEntities = Entities != null;
		}
	}
}