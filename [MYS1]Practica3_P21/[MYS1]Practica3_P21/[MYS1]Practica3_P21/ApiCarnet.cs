using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimioAPI;
using SimioAPI.Extensions;

using SimioAPI.Graphics;
using Simio;
using Simio.SimioEnums;

namespace _MYS1_Practica3_P21
{
    class ApiCarnet
    {
        private ISimioProject proyectoApi;
        private string rutabase = "[MYS1]ModeloBase_P21.spfx";
        private string rutafinal = "[MYS1]ModeloFinalCarnet_P21.spfx";
        private string[] warnings;
        private IModel model;
        private IIntelligentObjects intelligentObjects;
        private ILengthUnit lengthunits;
        public ApiCarnet()
        {
            proyectoApi = SimioProjectFactory.LoadProject(rutabase, out warnings);
            model = proyectoApi.Models[1];
            intelligentObjects = model.Facility.IntelligentObjects;
        }

        public void createCarnetModel()
        {
            createDesign();
            SimioProjectFactory.SaveProject(proyectoApi, rutafinal, out warnings);

        }

        public void createDesign()
        {
            Aldair();
            Edgar();
        }

        public void Aldair()
        {
            //2
            createTransferNode(-110, -60);
            updateName("TransferNode1", "T1");
            createTransferNode(-90, -60);
            updateName("TransferNode1", "T2");
            createTransferNode(-90, -40);
            updateName("TransferNode1", "T3");
            createTransferNode(-110, -40);
            updateName("TransferNode1", "T4");
            createTransferNode(-110, -20);
            updateName("TransferNode1", "T5");
            createTransferNode(-90, -20);
            updateName("TransferNode1", "T6");
            createPath(getNodobasico("T1"), getNodobasico("T2"));
            createPath(getNodobasico("T2"), getNodobasico("T3"));
            createPath(getNodobasico("T3"), getNodobasico("T4"));
            createPath(getNodobasico("T4"), getNodobasico("T5"));
            createPath(getNodobasico("T5"), getNodobasico("T6"));

            //0
            createTransferNode(-80, -60);
            updateName("TransferNode1", "T7");
            createTransferNode(-60, -60);
            updateName("TransferNode1", "T8");
            createTransferNode(-60, -20);
            updateName("TransferNode1", "T9");
            createTransferNode(-80, -20);
            updateName("TransferNode1", "T10");
            createPath(getNodobasico("T7"), getNodobasico("T8"));
            createPath(getNodobasico("T8"), getNodobasico("T9"));
            createPath(getNodobasico("T9"), getNodobasico("T10"));
            createPath(getNodobasico("T10"), getNodobasico("T7"));

            //1
            createTransferNode(-50, -50);
            updateName("TransferNode1", "T11");
            createTransferNode(-30, -60);
            updateName("TransferNode1", "T12");
            createTransferNode(-30, -20);
            updateName("TransferNode1", "T13");
            createPath(getNodobasico("T11"), getNodobasico("T12"));
            createPath(getNodobasico("T12"), getNodobasico("T13"));

            //5
            createTransferNode(0, -60);
            updateName("TransferNode1", "T14");
            createTransferNode(-20, -60);
            updateName("TransferNode1", "T15");
            createTransferNode(-20, -40);
            updateName("TransferNode1", "T16");
            createTransferNode(0, -40);
            updateName("TransferNode1", "T17");
            createTransferNode(0, -20);
            updateName("TransferNode1", "T18");
            createTransferNode(-20, -20);
            updateName("TransferNode1", "T19");
            createPath(getNodobasico("T14"), getNodobasico("T15"));
            createPath(getNodobasico("T15"), getNodobasico("T16"));
            createPath(getNodobasico("T16"), getNodobasico("T17"));
            createPath(getNodobasico("T17"), getNodobasico("T18"));
            createPath(getNodobasico("T18"), getNodobasico("T19"));

            //0
            createTransferNode(10, -60);
            updateName("TransferNode1", "T20");
            createTransferNode(30, -60);
            updateName("TransferNode1", "T21");
            createTransferNode(30, -20);
            updateName("TransferNode1", "T22");
            createTransferNode(10, -20);
            updateName("TransferNode1", "T23");
            createPath(getNodobasico("T20"), getNodobasico("T21"));
            createPath(getNodobasico("T21"), getNodobasico("T22"));
            createPath(getNodobasico("T22"), getNodobasico("T23"));
            createPath(getNodobasico("T23"), getNodobasico("T20"));

            //3
            createTransferNode(40, -60);
            updateName("TransferNode1", "T24");
            createTransferNode(60, -60);
            updateName("TransferNode1", "T25");
            createTransferNode(60, -40);
            updateName("TransferNode1", "T26");
            createTransferNode(40, -40);
            updateName("TransferNode1", "T27");
            createTransferNode(60, -20);
            updateName("TransferNode1", "T28");
            createTransferNode(40, -20);
            updateName("TransferNode1", "T29");
            createPath(getNodobasico("T24"), getNodobasico("T25"));
            createPath(getNodobasico("T25"), getNodobasico("T26"));
            createPath(getNodobasico("T26"), getNodobasico("T27"));
            createPath(getNodobasico("T26"), getNodobasico("T28"));
            createPath(getNodobasico("T28"), getNodobasico("T29"));

            //8
            createTransferNode(70, -60);
            updateName("TransferNode1", "T30");
            createTransferNode(90, -60);
            updateName("TransferNode1", "T31");
            createTransferNode(90, -20);
            updateName("TransferNode1", "T32");
            createTransferNode(70, -20);
            updateName("TransferNode1", "T33");
            createTransferNode(70, -40);
            updateName("TransferNode1", "T34");
            createTransferNode(90, -40);
            updateName("TransferNode1", "T35");
            createPath(getNodobasico("T30"), getNodobasico("T31"));
            createPath(getNodobasico("T31"), getNodobasico("T32"));
            createPath(getNodobasico("T32"), getNodobasico("T33"));
            createPath(getNodobasico("T33"), getNodobasico("T30"));
            createPath(getNodobasico("T34"), getNodobasico("T35"));

            //5
            createTransferNode(120, -60);
            updateName("TransferNode1", "T36");
            createTransferNode(100, -60);
            updateName("TransferNode1", "T37");
            createTransferNode(100, -40);
            updateName("TransferNode1", "T38");
            createTransferNode(120, -40);
            updateName("TransferNode1", "T39");
            createTransferNode(120, -20);
            updateName("TransferNode1", "T40");
            createTransferNode(100, -20);
            updateName("TransferNode1", "T41");
            createPath(getNodobasico("T36"), getNodobasico("T37"));
            createPath(getNodobasico("T37"), getNodobasico("T38"));
            createPath(getNodobasico("T38"), getNodobasico("T39"));
            createPath(getNodobasico("T39"), getNodobasico("T40"));
            createPath(getNodobasico("T40"), getNodobasico("T41"));

            //5
            createTransferNode(150, -60);
            updateName("TransferNode1", "T42");
            createTransferNode(130, -60);
            updateName("TransferNode1", "T43");
            createTransferNode(130, -40);
            updateName("TransferNode1", "T44");
            createTransferNode(150, -40);
            updateName("TransferNode1", "T45");
            createTransferNode(150, -20);
            updateName("TransferNode1", "T46");
            createTransferNode(130, -20);
            updateName("TransferNode1", "T47");
            createPath(getNodobasico("T42"), getNodobasico("T43"));
            createPath(getNodobasico("T43"), getNodobasico("T44"));
            createPath(getNodobasico("T44"), getNodobasico("T45"));
            createPath(getNodobasico("T45"), getNodobasico("T46"));
            createPath(getNodobasico("T46"), getNodobasico("T47"));
        }

        public void Edgar()
        {
            //2
            createTransferNode(-110, 10);
            updateName("TransferNode1", "T48");
            createTransferNode(-90, 10);
            updateName("TransferNode1", "T49");
            createTransferNode(-90, 30);
            updateName("TransferNode1", "T50");
            createTransferNode(-110, 30);
            updateName("TransferNode1", "T51");
            createTransferNode(-110, 50);
            updateName("TransferNode1", "T52");
            createTransferNode(-90, 50);
            updateName("TransferNode1", "T53");
            createPath(getNodobasico("T48"), getNodobasico("T49"));
            createPath(getNodobasico("T49"), getNodobasico("T50"));
            createPath(getNodobasico("T50"), getNodobasico("T51"));
            createPath(getNodobasico("T51"), getNodobasico("T52"));
            createPath(getNodobasico("T52"), getNodobasico("T53"));

            //0
            createTransferNode(-80, 10);
            updateName("TransferNode1", "T54");
            createTransferNode(-60, 10);
            updateName("TransferNode1", "T55");
            createTransferNode(-60, 50);
            updateName("TransferNode1", "T56");
            createTransferNode(-80, 50);
            updateName("TransferNode1", "T57");
            createPath(getNodobasico("T54"), getNodobasico("T55"));
            createPath(getNodobasico("T55"), getNodobasico("T56"));
            createPath(getNodobasico("T56"), getNodobasico("T57"));
            createPath(getNodobasico("T57"), getNodobasico("T54"));

            //1
            createTransferNode(-50, 20);
            updateName("TransferNode1", "T58");
            createTransferNode(-30, 10);
            updateName("TransferNode1", "T59");
            createTransferNode(-30, 50);
            updateName("TransferNode1", "T60");
            createPath(getNodobasico("T58"), getNodobasico("T59"));
            createPath(getNodobasico("T59"), getNodobasico("T60"));

            //5
            createTransferNode(0, 10);
            updateName("TransferNode1", "T61");
            createTransferNode(-20, 10);
            updateName("TransferNode1", "T62");
            createTransferNode(-20, 30);
            updateName("TransferNode1", "T63");
            createTransferNode(0, 30);
            updateName("TransferNode1", "T64");
            createTransferNode(0, 50);
            updateName("TransferNode1", "T65");
            createTransferNode(-20, 50);
            updateName("TransferNode1", "T66");
            createPath(getNodobasico("T61"), getNodobasico("T62"));
            createPath(getNodobasico("T62"), getNodobasico("T63"));
            createPath(getNodobasico("T63"), getNodobasico("T64"));
            createPath(getNodobasico("T64"), getNodobasico("T65"));
            createPath(getNodobasico("T65"), getNodobasico("T66"));

            //2
            createTransferNode(10, 10);
            updateName("TransferNode1", "T67");
            createTransferNode(30, 10);
            updateName("TransferNode1", "T68");
            createTransferNode(30, 30);
            updateName("TransferNode1", "T69");
            createTransferNode(10, 30);
            updateName("TransferNode1", "T70");
            createTransferNode(10, 50);
            updateName("TransferNode1", "T71");
            createTransferNode(30, 50);
            updateName("TransferNode1", "T72");
            createPath(getNodobasico("T67"), getNodobasico("T68"));
            createPath(getNodobasico("T68"), getNodobasico("T69"));
            createPath(getNodobasico("T69"), getNodobasico("T70"));
            createPath(getNodobasico("T70"), getNodobasico("T71"));
            createPath(getNodobasico("T71"), getNodobasico("T72"));

            //0
            createTransferNode(40, 10);
            updateName("TransferNode1", "T73");
            createTransferNode(60, 10);
            updateName("TransferNode1", "T74");
            createTransferNode(60, 50);
            updateName("TransferNode1", "T75");
            createTransferNode(40, 50);
            updateName("TransferNode1", "T76");
            createPath(getNodobasico("T73"), getNodobasico("T74"));
            createPath(getNodobasico("T74"), getNodobasico("T75"));
            createPath(getNodobasico("T75"), getNodobasico("T76"));
            createPath(getNodobasico("T76"), getNodobasico("T73"));

            //4
            createTransferNode(70, 10);
            updateName("TransferNode1", "T77");
            createTransferNode(70, 30);
            updateName("TransferNode1", "T78");
            createTransferNode(90, 30);
            updateName("TransferNode1", "T79");
            createTransferNode(90, 10);
            updateName("TransferNode1", "T80");
            createTransferNode(90, 50);
            updateName("TransferNode1", "T81");
            createPath(getNodobasico("T77"), getNodobasico("T78"));
            createPath(getNodobasico("T78"), getNodobasico("T79"));
            createPath(getNodobasico("T80"), getNodobasico("T81"));

            //9
            createTransferNode(120, 10);
            updateName("TransferNode1", "T82");
            createTransferNode(100, 10);
            updateName("TransferNode1", "T83");
            createTransferNode(100, 30);
            updateName("TransferNode1", "T84");
            createTransferNode(120, 30);
            updateName("TransferNode1", "T85");
            createTransferNode(120, 50);
            updateName("TransferNode1", "T86");
            createTransferNode(100, 50);
            updateName("TransferNode1", "T87");
            createPath(getNodobasico("T82"), getNodobasico("T83"));
            createPath(getNodobasico("T83"), getNodobasico("T84"));
            createPath(getNodobasico("T84"), getNodobasico("T85"));
            createPath(getNodobasico("T82"), getNodobasico("T86"));
            createPath(getNodobasico("T86"), getNodobasico("T87"));

            //8
            createTransferNode(150, 10);
            updateName("TransferNode1", "T88");
            createTransferNode(130, 10);
            updateName("TransferNode1", "T89");
            createTransferNode(130, 30);
            updateName("TransferNode1", "T90");
            createTransferNode(150, 30);
            updateName("TransferNode1", "T91");
            createTransferNode(150, 50);
            updateName("TransferNode1", "T92");
            createTransferNode(130, 50);
            updateName("TransferNode1", "T93");
            createPath(getNodobasico("T88"), getNodobasico("T89"));
            createPath(getNodobasico("T90"), getNodobasico("T91"));
            createPath(getNodobasico("T92"), getNodobasico("T93"));
            createPath(getNodobasico("T88"), getNodobasico("T92"));
            createPath(getNodobasico("T89"), getNodobasico("T93"));          
        }
        public void createTransferNode(int x, int y)
        {
            this.createObject("TransferNode", x, y);
        }

        public void createPath(INodeObject nodo1, INodeObject nodo2)
        {
            this.createLink("Path", nodo1, nodo2);

        }

        public void createObject(String type, int x, int y)
        {
            intelligentObjects.CreateObject(type, new FacilityLocation(x, 0, y));
        }

        public void createLink(String type, INodeObject nodo1, INodeObject nodo2)
        {
            intelligentObjects.CreateLink(type, nodo1, nodo2, null);

        }
        public void updateName(String oldName, String newName)
        {
            model.Facility.IntelligentObjects[oldName].ObjectName = newName;
        }
        //---------------------------------- Obtener Nodo Basicos --------------------------------------//
        public INodeObject getNodobasico(String name)
        {
            return (INodeObject)model.Facility.IntelligentObjects[name];
        }

    }
}
