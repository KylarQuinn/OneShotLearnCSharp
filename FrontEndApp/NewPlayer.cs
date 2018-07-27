using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayerRoles;

namespace FrontEndApp
{
    public partial class NewPlayer : Form
    {
        public NewPlayer()
        {
            InitializeComponent();
            LoadRoles();
        }

        private void LoadRoles()
        {
            cboRoles.Items.Insert(0, RoleNames.POINT_GUARD);
            cboRoles.Items.Insert(1, RoleNames.TWO_GUARD);
            cboRoles.Items.Insert(2, RoleNames.SMALL_FORWARD);
            cboRoles.Items.Insert(3, RoleNames.POWER_FORWARD);
            cboRoles.Items.Insert(4, RoleNames.CENTER);
            cboRoles.Items.Insert(5, RoleNames.WING);
            cboRoles.Items.Insert(6, RoleNames.BIG);
        }

        private void BtnNextPage_OnClick(object sender, EventArgs e)
        {
            Player player = GetNewPlayer();
            AddAttributes addAttributes = new AddAttributes(player);
            addAttributes.Show();
            SelectNextControl(addAttributes, false, false, false, false);
        }

        private Player GetNewPlayer()
        {
            return new Player(Convert.ToInt32(txtPlayerAge.Text), cboRoles.SelectedIndex);
        }
    }
}
