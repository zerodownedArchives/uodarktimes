
////////////////////////////////////////
//                                    //
//      Generated by CEO's YAAAG      //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class MarketStandWineEastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			 {4014, -1, 1, 0}, {2500, 2, 1, 3}, {2501, 1, 1, 0}// 12	13	14	
			, {2500, 0, 1, 3}, {6464, -1, 1, 0}, {2513, -1, 1, 3}// 15	16	17	
			, {2513, 1, 1, 2}, {2513, 0, 1, 2}, {2513, 1, 1, 1}// 18	19	20	
			, {2513, 1, 1, 3}// 21	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MarketStandWineEastAddonDeed();
			}
		}

		[ Constructable ]
		public MarketStandWineEastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( 6792, 0, 1, 0, 0, -1, "market stand" );// 4
			AddComplexComponent( 2958, 0, 1, 1, 0, -1, "market stand" );// 5
			AddComplexComponent( 6792, 2, 1, 0, 0, -1, "market stand" );// 6
			AddComplexComponent( 2958, 2, 1, 1, 0, -1, "market stand" );// 7
			AddComplexComponent( 2958, 1, 1, 1, 0, -1, "market stand" );// 8
			AddComplexComponent( 1448, 2, 1, 5, 0, -1, "market stand" );// 9
			AddComplexComponent( 1448, 0, 1, 5, 0, -1, "market stand" );// 10
			AddComplexComponent( 1448, 1, 1, 5, 0, -1, "market stand" );// 11

		}

		public MarketStandWineEastAddon( Serial serial ) : base( serial )
		{
		}

        public void AddComplexComponent(int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(item, xoffset, yoffset, zoffset, hue, lightsource, null);
        }

        public void AddComplexComponent(int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class MarketStandWineEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MarketStandWineEastAddon();
			}
		}

		[Constructable]
		public MarketStandWineEastAddonDeed()
		{
			Name = "MarketStandWineEast";
		}

		public MarketStandWineEastAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}