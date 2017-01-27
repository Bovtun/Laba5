using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public InterfaceTable InterfaceTable = new InterfaceTable();
        public RouteTable RouteTable = new RouteTable();
        Route Route = new Route();
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable MatrixInterface = new DataTable("MatrixInterface");
            MatrixInterface.Columns.Add("Name", typeof(String));
            MatrixInterface.Columns.Add("IPAddress", typeof(String));
            MatrixInterface.Columns.Add("Gateway", typeof(String));
            //
            DataTable MatrixRoute = new DataTable("MatrixRoute");
            MatrixRoute.Columns.Add("IPAddress", typeof(String));
            MatrixRoute.Columns.Add("Mask", typeof(String));
            MatrixRoute.Columns.Add("Interface", typeof(String));
            MatrixRoute.Columns.Add("Metric", typeof(String));
            //
            InterfaceTable InterfaceTable = new InterfaceTable();
            RouteTable RouteTable = new RouteTable();
            dataGridInterface.DataSource = MatrixInterface;
            dataGridRoute.DataSource = MatrixRoute;
        }
      
        public Form1()
        {
            InitializeComponent();
        }
        public void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void AddInterface_Click( object sender, EventArgs e)
        {
            Interface Int = Interface.StringToInterface(BoxName.Text, BoxIP.Text, BoxGateway.Text);
            if (Int != null)
            {
                if (!Interface.Search(Int,InterfaceTable))
                {
                    InterfaceTable.Add(Int);
                    Route.ShowInterface(InterfaceTable, (DataTable)dataGridInterface.DataSource);
                    dataGridInterface.Update();
                }
                else
                {
                    resint.Text = "Данный интерфейс уже создан";
                }
            } 
             else
            {
                        resint.Text = "Данные не корректны";
            }                               
        }
        private void AddNotation_Click(object sender, EventArgs e)
        {
            Notation Notation = Notation.StringToNotation(BoxIPNotation.Text, BoxMask.Text, BoxInterface.Text, BoxMetric.Text);
            if(Notation!=null)
            {
                if(!Notation.Search(Notation,RouteTable))
                {
                    RouteTable.Add(Notation);
                    Route.ShowRoute(RouteTable, (DataTable)dataGridRoute.DataSource);
                    dataGridRoute.Update();
                }
                else
                {
                    resroute.Text = "Данный интерфейс уже создан";
                }
            }
            else
            {
                resroute.Text = "Данные не корректны";
            }           
        }
    }
}
