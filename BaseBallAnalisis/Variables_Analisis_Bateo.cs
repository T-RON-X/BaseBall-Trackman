using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBallAnalisis
{
    class Variables_Analisis_Bateo
    {

        public DataTable PeloterosVisitorCatcher()
        {
            //Catcher de Visitor
            DataTable PeloterosVisitorCatcher = new DataTable();
            PeloterosVisitorCatcher.Columns.Add("ID");
            PeloterosVisitorCatcher.Columns.Add("Nombre");

            PeloterosVisitorCatcher.Rows.Add("1", ClaseCompartida.CatcherVisitor);
            PeloterosVisitorCatcher.Rows.Add("2", ClaseCompartida.SubCatcherVisitor);

            return PeloterosVisitorCatcher;
        }
        public DataTable PeloterosHomeCatcher()
        {
            //Catcher de Home
            DataTable PeloterosHomeCatcher = new DataTable();
            PeloterosHomeCatcher.Columns.Add("ID");
            PeloterosHomeCatcher.Columns.Add("Nombre");

            PeloterosHomeCatcher.Rows.Add("1", ClaseCompartida.CatcherHome);
            PeloterosHomeCatcher.Rows.Add("2", ClaseCompartida.SubCatcherHome);

            return PeloterosHomeCatcher;
        }



        public DataTable PeloterosVisitorSegunda()
        {
            //Segunda Base Visitor
            DataTable PeloterosSegundaVisitor = new DataTable();
            PeloterosSegundaVisitor.Columns.Add("ID");
            PeloterosSegundaVisitor.Columns.Add("Nombre");

            PeloterosSegundaVisitor.Rows.Add("1", ClaseCompartida.SegundaVisitor);
            PeloterosSegundaVisitor.Rows.Add("2", ClaseCompartida.SubSegundaVisitor);


            return PeloterosSegundaVisitor;
        }
        public DataTable PeloterosSegundaVisitor()
        {
            //Segunda Base Visitor
            DataTable PeloterosSegundaVisitor = new DataTable();
            PeloterosSegundaVisitor.Columns.Add("ID");
            PeloterosSegundaVisitor.Columns.Add("Nombre");

            PeloterosSegundaVisitor.Rows.Add("1", ClaseCompartida.SegundaVisitor);
            PeloterosSegundaVisitor.Rows.Add("2", ClaseCompartida.SubSegundaVisitor);

            return PeloterosSegundaVisitor;
        }




        public DataTable PeloterosVisitorPrimera()
        {
            //Primera Base Visitor
            DataTable PeloterosPrimeraVisitor = new DataTable();
            PeloterosPrimeraVisitor.Columns.Add("ID");
            PeloterosPrimeraVisitor.Columns.Add("Nombre");

            PeloterosPrimeraVisitor.Rows.Add("1", ClaseCompartida.PrimeraVisitor);
            PeloterosPrimeraVisitor.Rows.Add("2", ClaseCompartida.SubPrimeraVisitor);


            return PeloterosPrimeraVisitor;
        }
        public DataTable PeloterosHomePrimera()
        {
            //Primera Base Home
            DataTable PeloterosPrimeraHome = new DataTable();
            PeloterosPrimeraHome.Columns.Add("ID");
            PeloterosPrimeraHome.Columns.Add("Nombre");

            PeloterosPrimeraHome.Rows.Add("1", ClaseCompartida.PrimeraHome);
            PeloterosPrimeraHome.Rows.Add("2", ClaseCompartida.SubPrimeraHome);

            return PeloterosPrimeraHome;
        }




        public DataTable PeloterosVisitorCenter()
        {
            //CenterField de Visitor
            DataTable PeloterosCenterVisitor = new DataTable();
            PeloterosCenterVisitor.Columns.Add("ID");
            PeloterosCenterVisitor.Columns.Add("Nombre");

            PeloterosCenterVisitor.Rows.Add("1", ClaseCompartida.CenterVisitor);
            PeloterosCenterVisitor.Rows.Add("2", ClaseCompartida.SubCenterVisitor);

            return PeloterosCenterVisitor;
        }
        public DataTable PeloterosHomeCenter()
        {
            //CenterField de Home
            DataTable PeloterosCenterHome = new DataTable();
            PeloterosCenterHome.Columns.Add("ID");
            PeloterosCenterHome.Columns.Add("Nombre");

            PeloterosCenterHome.Rows.Add("1", ClaseCompartida.CenterHome);
            PeloterosCenterHome.Rows.Add("2", ClaseCompartida.SubCenterHome);

            return PeloterosCenterHome;
        }




        public DataTable PeloterosVisitorRight()
        {
            //RightField de Visitor
            DataTable PeloterosRightVisitor = new DataTable();
            PeloterosRightVisitor.Columns.Add("ID");
            PeloterosRightVisitor.Columns.Add("Nombre");

            PeloterosRightVisitor.Rows.Add("1", ClaseCompartida.RightVisitor);
            PeloterosRightVisitor.Rows.Add("2", ClaseCompartida.SubRightVisitor);

            return PeloterosRightVisitor;
        }
        public DataTable PeloterosHomeRight()
        {
            //RightField de Home
            DataTable PeloterosRightHome = new DataTable();
            PeloterosRightHome.Columns.Add("ID");
            PeloterosRightHome.Columns.Add("Nombre");

            PeloterosRightHome.Rows.Add("1", ClaseCompartida.RightHome);
            PeloterosRightHome.Rows.Add("2", ClaseCompartida.SubRightHome);

            return PeloterosRightHome;
        }




        public DataTable PeloterosVisitorLeft()
        {
            //LeftField de Visitor
            DataTable PeloterosLeftVisitor = new DataTable();
            PeloterosLeftVisitor.Columns.Add("ID");
            PeloterosLeftVisitor.Columns.Add("Nombre");

            PeloterosLeftVisitor.Rows.Add("1", ClaseCompartida.LeftVisitor);
            PeloterosLeftVisitor.Rows.Add("2", ClaseCompartida.SubLeftVisitor);

            return PeloterosLeftVisitor;
        }               
        public DataTable PeloterosHomeLeft()
        {
            //LeftField de Home
            DataTable PeloterosLeftHome = new DataTable();
            PeloterosLeftHome.Columns.Add("ID");
            PeloterosLeftHome.Columns.Add("Nombre");

            PeloterosLeftHome.Rows.Add("1", ClaseCompartida.LeftHome);
            PeloterosLeftHome.Rows.Add("2", ClaseCompartida.SubLeftHome);

            return PeloterosLeftHome;
        }




        public DataTable PeloterosVisitorShort()
        {

            //ShortStop Visitor
            DataTable PeloterosShortVisitor = new DataTable();
            PeloterosShortVisitor.Columns.Add("ID");
            PeloterosShortVisitor.Columns.Add("Nombre");

            PeloterosShortVisitor.Rows.Add("1", ClaseCompartida.ShortStopVisitor);
            PeloterosShortVisitor.Rows.Add("2", ClaseCompartida.SubShortStopVisitor);

            return PeloterosShortVisitor;
        }
        public DataTable PeloterosHomeHome()
        {
            //ShortStop Home
            DataTable PeloterosShortHome = new DataTable();
            PeloterosShortHome.Columns.Add("ID");
            PeloterosShortHome.Columns.Add("Nombre");

            PeloterosShortHome.Rows.Add("1", ClaseCompartida.ShortStopHome);
            PeloterosShortHome.Rows.Add("2", ClaseCompartida.SubShortStopHome);

            return PeloterosShortHome;
        }





        public DataTable PeloterosVisitorPitcher()
        {
            //Pitcher Visitor
            DataTable PeloterosPitcherVisitor = new DataTable();
            PeloterosPitcherVisitor.Columns.Add("ID");
            PeloterosPitcherVisitor.Columns.Add("Nombre");

            PeloterosPitcherVisitor.Rows.Add("1", ClaseCompartida.PitcherVisitor);
            PeloterosPitcherVisitor.Rows.Add("2", ClaseCompartida.PitcherCVisitor);
            PeloterosPitcherVisitor.Rows.Add("3", ClaseCompartida.PitcherRVisitor);
            PeloterosPitcherVisitor.Rows.Add("4", ClaseCompartida.PitcherAVisitor);

            return PeloterosPitcherVisitor;
        }
        public DataTable PeloterosHomePitcher()
        {
            //Pitcher Home
            DataTable PeloterosPitcherHome = new DataTable();
            PeloterosPitcherHome.Columns.Add("ID");
            PeloterosPitcherHome.Columns.Add("Nombre");

            PeloterosPitcherHome.Rows.Add("1", ClaseCompartida.PitcherHome);
            PeloterosPitcherHome.Rows.Add("2", ClaseCompartida.PitcherCHome);
            PeloterosPitcherHome.Rows.Add("3", ClaseCompartida.PitcherRHome);
            PeloterosPitcherHome.Rows.Add("4", ClaseCompartida.PitcherAHome);

            return PeloterosPitcherHome;
        }



        public DataTable PeloterosVisitorTercera()
        {
            //Tercera Base Visitor
            DataTable PeloterosTerceraVisitor = new DataTable();
            PeloterosTerceraVisitor.Columns.Add("ID");
            PeloterosTerceraVisitor.Columns.Add("Nombre");

            PeloterosTerceraVisitor.Rows.Add("1", ClaseCompartida.TerceraVisitor);
            PeloterosTerceraVisitor.Rows.Add("2", ClaseCompartida.SubTerceraVisitor);

            return PeloterosTerceraVisitor;
        }
        public DataTable PeloterosHomeTercera()
        {
            //Tercera Base Home
            DataTable PeloterosTerceraHome = new DataTable();
            PeloterosTerceraHome.Columns.Add("ID");
            PeloterosTerceraHome.Columns.Add("Nombre");

            PeloterosTerceraHome.Rows.Add("1", ClaseCompartida.TerceraHome);
            PeloterosTerceraHome.Rows.Add("2", ClaseCompartida.SubTerceraHome);

            return PeloterosTerceraHome;
        }

    }
}
