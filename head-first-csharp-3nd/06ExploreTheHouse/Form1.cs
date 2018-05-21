using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06ExploreTheHouse
{
    public partial class Form1 : Form
    {
        Location currentLocation;
        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;

        RoomWithHidingPlace upstairsHallway;

        RoomWithHidingPlace bedRoomMaster;
        RoomWithHidingPlace bedRoomSmall;
        RoomWithHidingPlace bathRoom;

        OutsideWithHidingPlace driveWay;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;

        public Form1()
        {
            InitializeComponent();
           

            CreateObjects();
            MoveToNewLocation(livingRoom);


        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("LivingRoom", " high table", "door to front yard");
            diningRoom = new Room("DiningRoom", "1 table and 8 chairs");
            kitchen = new RoomWithDoor("Kitchen", "2 large sinks", "door to back yard");

            upstairsHallway = new RoomWithHidingPlace("Upstair Hallway", "LED iluminating", "picture of a dog");
            bedRoomMaster = new RoomWithHidingPlace("Large Bedroom", "with master bedroom", "under the bed");
            bedRoomSmall = new RoomWithHidingPlace("Small bedroom", "small bed", "under the bed");
            bathRoom = new RoomWithHidingPlace("Bathroom", "with a sink and a toilet", "in the shower");
            driveWay = new OutsideWithHidingPlace("drive way", false, "garage");

            frontYard = new OutsideWithDoor("front yard", true, "front yard is connected to living room");
            backYard = new OutsideWithDoor("back yard", false, "back yard is connected to Kitchen");
            garden = new OutsideWithHidingPlace("garden", true, " shed");

            livingRoom.Exits = new Location[] { frontYard, backYard, upstairsHallway};
            frontYard.Exits = new Location[] { livingRoom, driveWay };
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            kitchen.Exits = new Location[] { diningRoom, backYard };
            backYard.Exits = new Location[] { kitchen, driveWay };
            upstairsHallway.Exits = new Location[] {bedRoomMaster, bedRoomSmall, bathRoom };
            bedRoomMaster.Exits = new Location[] { upstairsHallway };
            bathRoom.Exits = new Location[] { upstairsHallway };
            bedRoomSmall.Exits = new Location[] { upstairsHallway };

            livingRoom.DoorLocation = frontYard;
            kitchen.DoorLocation = backYard;
            frontYard.DoorLocation = livingRoom;
            backYard.DoorLocation = kitchen;
        }

        private void MoveToNewLocation(Location newLocation)
        {
            comboBoxLocation.Items.Clear();
            currentLocation = newLocation;
            try
            {
                for (int i = 0; i < currentLocation.Exits.Length; i++)
                    comboBoxLocation.Items.Add(currentLocation.Exits[i].Name);
                comboBoxLocation.SelectedIndex = 0;
                textBoxShowDescription.Text = currentLocation.Description;

                if (currentLocation is IHasExteriorDoor)
                    buttonGoThroughTheDoor.Visible = true;
                else
                    buttonGoThroughTheDoor.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
                    

        }       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonGoHere_Click(object sender, EventArgs e)
        {
            MoveToNewLocation(currentLocation.Exits[comboBoxLocation.SelectedIndex]);
        }
    }
}
