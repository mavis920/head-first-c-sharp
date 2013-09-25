﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayingCards
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int suitNumber = random.Next(4);
            int valueNumber = random.Next(1, 14);

            Suit suit = (Suit)suitNumber;
            Value value = (Value)valueNumber;

            Card myCard = new Card(suit, value);

            MessageBox.Show(myCard.name);
        }


    }
}
