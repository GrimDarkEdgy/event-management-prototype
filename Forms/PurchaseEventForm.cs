﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ICT365_Assignment1.Forms
{
    public partial class PurchaseEventForm : ICT365_Assignment1.BaseEventForm
    {
        public PurchaseEventForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public PurchaseEventForm(PictureBox eventIconIn)
        {
            eventIcon = eventIconIn;
            InitializeComponent();
            LatitudeTextBox.Text = eventIcon.Location.X.ToString();
            LongitudeTextBox.Text = eventIcon.Location.Y.ToString();
        }

        private void PurchaseEventForm_Load(object sender, EventArgs e)
        {

        }

        protected virtual void CreateEventButton_Click(object sender, EventArgs e)
        {

            Event newEvent = new EventPurchase();
            EventPurchase cast;

            newEvent.SetID((uint)ManagerSingleton.Instance.IdCount++);
            newEvent.SetDateTime(dateTime.Value);
            newEvent.SetName(NameBox.Text);
            try
            {
                newEvent.SetLocation(new Location(float.Parse(LatitudeTextBox.Text), float.Parse(LongitudeTextBox.Text)));

            }
            catch
            {
                newEvent.SetLocation(new Location(200, 200));
            }

            newEvent.SetEventType(EventType.Purchase);
            cast = (EventPurchase)newEvent;

            try
            {
                cast.SetCost(decimal.Parse(DollarBox.Text + "." + CentsBox.Text));
            }
            catch
            {
                cast.SetCost(0.0m);
            }

            string[] lines = ItemsBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            cast.SetPurchaseList(new List<string>(lines));

            eventCreated = true;

            ManagerSingleton.Instance.Events.AddEvent(newEvent);
            ManagerSingleton.Instance.IconList[eventIcon] = newEvent.GetID();

            Close();
        }
    }
}

