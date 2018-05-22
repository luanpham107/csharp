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

        Opponent opponent;
        Random random = new Random();

        UInt16 numUserGuess;


        public Form1()
        {
            InitializeComponent();
            numUserGuess = 0;

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

            opponent = new Opponent(livingRoom, random);

            livingRoom.Exits = new Location[] { frontYard, diningRoom, upstairsHallway};
            frontYard.Exits = new Location[] { livingRoom, driveWay };
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            kitchen.Exits = new Location[] { diningRoom, backYard };
            backYard.Exits = new Location[] { kitchen, driveWay };
            upstairsHallway.Exits = new Location[] {bedRoomMaster, bedRoomSmall, bathRoom , livingRoom};
            bedRoomMaster.Exits = new Location[] { upstairsHallway };
            bathRoom.Exits = new Location[] { upstairsHallway };
            bedRoomSmall.Exits = new Location[] { upstairsHallway };
            backYard.Exits = new Location[] { garden, kitchen };
            garden.Exits = new Location[] { frontYard, backYard, driveWay};
            frontYard.Exits = new Location[] { garden, livingRoom };
            driveWay.Exits = new Location[] { garden };

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
                    buttonGoThroughTheDoor.Enabled = true;
                else
                    buttonGoThroughTheDoor.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
                    

        }   
        
        private void ResetGame()
        {
            numUserGuess = 0;
            buttonHide.Enabled = true;
            buttonCheck.Enabled = false;
            if (currentLocation is IHidingPlace)
                textBoxShowDescription.Text = "You found your oppnent in " + currentLocation.Name
                    + ", in the" + (currentLocation as IHidingPlace).NameOfHidingPlace;
            else
                textBoxShowDescription.Text = "You found your oppnent is standing in " + currentLocation.Name;                    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonGoHere_Click(object sender, EventArgs e)
        {
            MoveToNewLocation(currentLocation.Exits[comboBoxLocation.SelectedIndex]);
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            numUserGuess++;
            if (opponent.check(currentLocation))
            {
                textBoxShowDescription.AppendText("\r\nYou are right, number of guess: " + numUserGuess);
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
                ResetGame();
                for(int i = 0; i < 5; i++)
                {
                    if(i< 1 )
                        textBoxShowDescription.Text = "Game reset in " + i + " second";
                    else
                        textBoxShowDescription.Text = "Game reset in " + i + " seconds";
                    System.Threading.Thread.Sleep(1000);
                }
                textBoxShowDescription.Text = "Game reset";

            }
            else
                textBoxShowDescription.AppendText("\r\nYou are wrong, try again!");
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 10; i++)
            {
                opponent.Move();
                textBoxShowDescription.Text = i + " ";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            textBoxShowDescription.AppendText("\r\nGame Start!");
            buttonCheck.Enabled = true;
            buttonHide.Enabled = false;


        }
    }
}
