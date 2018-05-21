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

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;

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

            frontYard = new OutsideWithDoor("front yard", true, "front yard is connected to living room");
            backYard = new OutsideWithDoor("back yard", false, "back yard is connected to Kitchen");
            garden = new Outside("garden", true);

            livingRoom.Exits = new Location[] { frontYard, backYard};
            frontYard.Exits = new Location[] { livingRoom };
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            kitchen.Exits = new Location[] { diningRoom, backYard };
            backYard.Exits = new Location[] { kitchen };

            livingRoom.DoorLocation = frontYard;
            kitchen.DoorLocation = backYard;
            frontYard.DoorLocation = livingRoom;
            backYard.DoorLocation = kitchen;
        }

        private void MoveToNewLocation(Location newLocation)
        {
            comboBoxLocation.Items.Clear();
            currentLocation = newLocation;

            for(int i = 0; i < currentLocation.Exits.Length; i++)            
                comboBoxLocation.Items.Add(currentLocation.Exits[i].Name);
            comboBoxLocation.SelectedIndex = 0;
            textBoxShowDescription.Text = currentLocation.Description;

            if (currentLocation is IHasExteriorDoor)
                buttonGoThroughTheDoor.Visible = true;
            else
                buttonGoThroughTheDoor.Visible = false;
                    

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
