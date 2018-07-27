using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndApp
{
    public partial class AddAttributes : Form
    {
        PlayerRoles.Player Player;

        public AddAttributes(PlayerRoles.Player player)
        {
            InitializeComponent();
            Player = player;
        }


    }
}
