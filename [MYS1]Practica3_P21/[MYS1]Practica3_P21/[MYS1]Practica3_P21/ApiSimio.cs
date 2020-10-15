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
    class ApiSimio
    {
        private ISimioProject proyectoApi;
        private string rutabase = "[MYS1]ModeloBase_P21.spfx";
        private string rutafinal = "[MYS1]ModeloFinal_P21.spfx";
        private string[] warnings;
        private IModel model;
        private IIntelligentObjects intelligentObjects;
        private ILengthUnit lengthunits;       
        
        

        public ApiSimio()
        {
            proyectoApi = SimioProjectFactory.LoadProject(rutabase, out warnings);
            model = proyectoApi.Models[1];
            intelligentObjects = model.Facility.IntelligentObjects;                    
        }

        public void createModel()
        {
            createMap();
            SimioProjectFactory.SaveProject(proyectoApi, rutafinal, out warnings);

        }

        public void createMap()
        {
            createOutline();
            createZone();
            createCardinals();
            createAirpot();
        }

        public void createOutline()
        {
            createTransferNode(40, -95);
            updateName("TransferNode1", "TN1");
            createTransferNode(-20, -95);
            updateName("TransferNode1", "TN2");
            createPath(getNodobasico("TN1"), getNodobasico("TN2"));
            updateName("Path1", "Mexico");
            updateProperty("Mexico", "DrawnToScale", "False");
            updateProperty("Mexico", "LogicalLength", "200000");
            createTransferNode(-20, -70);
            updateName("TransferNode1", "TN3");
            createPath(getNodobasico("TN2"), getNodobasico("TN3"));
            updateName("Path1", "Mexico2");
            updateProperty("Mexico2", "DrawnToScale", "False");
            updateProperty("Mexico2", "LogicalLength", "90000");
            createTransferNode(-40, -70);
            updateName("TransferNode1", "TN4");
            createPath(getNodobasico("TN3"), getNodobasico("TN4"));
            updateName("Path1", "Mexico3");
            updateProperty("Mexico3", "DrawnToScale", "False");
            updateProperty("Mexico3", "LogicalLength", "62000");
            createTransferNode(-13, -50);
            updateName("TransferNode1", "TN5");
            createPath(getNodobasico("TN4"), getNodobasico("TN5"));
            updateName("Path1", "Mexico4");
            updateProperty("Mexico4", "DrawnToScale", "False");
            updateProperty("Mexico4", "LogicalLength", "130000");
            createTransferNode(-5, -35);
            updateName("TransferNode1", "TN6");
            createPath(getNodobasico("TN5"), getNodobasico("TN6"));
            updateName("Path1", "Mexico5");
            updateProperty("Mexico5", "DrawnToScale", "False");
            updateProperty("Mexico5", "LogicalLength", "30000");
            createTransferNode(-53, -35);
            updateName("TransferNode1", "TN7");
            createPath(getNodobasico("TN6"), getNodobasico("TN7"));
            updateName("Path1", "Mexico6");
            updateProperty("Mexico6", "DrawnToScale", "False");
            updateProperty("Mexico6", "LogicalLength", "180000");
            createTransferNode(-68, -5);
            updateName("TransferNode1", "TN8");
            createPath(getNodobasico("TN7"), getNodobasico("TN8"));
            updateName("Path1", "Mexico7");
            updateProperty("Mexico7", "DrawnToScale", "False");
            updateProperty("Mexico7", "LogicalLength", "120000");
            createTransferNode(-63, 3);
            updateName("TransferNode1", "TN9");
            createPath(getNodobasico("TN8"), getNodobasico("TN9"));
            updateName("Path1", "Mexico8");
            updateProperty("Mexico8", "DrawnToScale", "False");
            updateProperty("Mexico8", "LogicalLength", "30000");
            createTransferNode(-65, 10);
            updateName("TransferNode1", "TN10");
            createPath(getNodobasico("TN9"), getNodobasico("TN10"));
            updateName("Path1", "Mexico9");
            updateProperty("Mexico9", "DrawnToScale", "False");
            updateProperty("Mexico9", "LogicalLength", "20000");
            createTransferNode(-53, 33);
            updateName("TransferNode1", "TN11");
            createPath(getNodobasico("TN10"), getNodobasico("TN11"));
            updateName("Path1", "Mexico10");
            updateProperty("Mexico10", "DrawnToScale", "False");
            updateProperty("Mexico10", "LogicalLength", "100000");
            createTransferNode(-28, 45);
            updateName("TransferNode1", "TN12");
            createPath(getNodobasico("TN11"), getNodobasico("TN12"));
            updateName("Path1", "Pacifico");
            updateProperty("Pacifico", "DrawnToScale", "False");
            updateProperty("Pacifico", "LogicalLength", "150000");
            createTransferNode(-10, 43);
            updateName("TransferNode1", "TN13");
            createPath(getNodobasico("TN12"), getNodobasico("TN13"));
            updateName("Path1", "Pacifico2");
            updateProperty("Pacifico2", "DrawnToScale", "False");
            updateProperty("Pacifico2", "LogicalLength", "54000");
            createTransferNode(5, 47);
            updateName("TransferNode1", "TN14");
            createPath(getNodobasico("TN13"), getNodobasico("TN14"));
            updateName("Path1", "Pacifico3");
            updateProperty("Pacifico3", "DrawnToScale", "False");
            updateProperty("Pacifico3", "LogicalLength", "50000");
            createTransferNode(28, 35);
            updateName("TransferNode1", "TN15");
            createPath(getNodobasico("TN14"), getNodobasico("TN15"));
            updateName("Path1", "ElSalvador");
            updateProperty("ElSalvador", "DrawnToScale", "False");
            updateProperty("ElSalvador", "LogicalLength", "150000");
            createTransferNode(37, 20);
            updateName("TransferNode1", "TN16");
            createPath(getNodobasico("TN15"), getNodobasico("TN16"));
            updateName("Path1", "ElSalvador2");
            updateProperty("ElSalvador2", "DrawnToScale", "False");
            updateProperty("ElSalvador2", "LogicalLength", "53000");
            createTransferNode(35, 10);
            updateName("TransferNode1", "TN17");
            createPath(getNodobasico("TN16"), getNodobasico("TN17"));
            updateName("Path1", "Honduras");
            updateProperty("Honduras", "DrawnToScale", "False");
            updateProperty("Honduras", "LogicalLength", "20000");
            createTransferNode(42, -3);
            updateName("TransferNode1", "TN18");
            createPath(getNodobasico("TN17"), getNodobasico("TN18"));
            updateName("Path1", "Honduras2");
            updateProperty("Honduras2", "DrawnToScale", "False");
            updateProperty("Honduras2", "LogicalLength", "40000");
            createTransferNode(52, -5);
            updateName("TransferNode1", "TN19");
            createPath(getNodobasico("TN18"), getNodobasico("TN19"));
            updateName("Path1", "Honduras3");
            updateProperty("Honduras3", "DrawnToScale", "False");
            updateProperty("Honduras3", "LogicalLength", "20000");
            createTransferNode(80, -20);
            updateName("TransferNode1", "TN20");
            createPath(getNodobasico("TN19"), getNodobasico("TN20"));
            updateName("Path1", "Honduras4");
            updateProperty("Honduras4", "DrawnToScale", "False");
            updateProperty("Honduras4", "LogicalLength", "176000");
            createTransferNode(75, -30);
            updateName("TransferNode1", "TN21");
            createPath(getNodobasico("TN20"), getNodobasico("TN21"));
            updateName("Path1", "Caribe");
            updateProperty("Caribe", "DrawnToScale", "False");
            updateProperty("Caribe", "LogicalLength", "10000");
            createTransferNode(68, -23);
            updateName("TransferNode1", "TN22");
            createPath(getNodobasico("TN21"), getNodobasico("TN22"));
            updateName("Path1", "Caribe2");
            updateProperty("Caribe2", "DrawnToScale", "False");
            updateProperty("Caribe2", "LogicalLength", "10000");
            createTransferNode(65, -32);
            updateName("TransferNode1", "TN23");
            createPath(getNodobasico("TN22"), getNodobasico("TN23"));
            updateName("Path1", "Caribe3");
            updateProperty("Caribe3", "DrawnToScale", "False");
            updateProperty("Caribe3", "LogicalLength", "10000");
            createTransferNode(55, -20);
            updateName("TransferNode1", "TN24");
            createPath(getNodobasico("TN23"), getNodobasico("TN24"));
            updateName("Path1", "Caribe4");
            updateProperty("Caribe4", "DrawnToScale", "False");
            updateProperty("Caribe4", "LogicalLength", "20000");
            createTransferNode(38, -15);
            updateName("TransferNode1", "TN25");
            createPath(getNodobasico("TN24"), getNodobasico("TN25"));
            updateName("Path1", "Caribe5");
            updateProperty("Caribe5", "DrawnToScale", "False");
            updateProperty("Caribe5", "LogicalLength", "30000");
            createTransferNode(40, -25);
            updateName("TransferNode1", "TN26");
            createPath(getNodobasico("TN25"), getNodobasico("TN26"));
            updateName("Path1", "Caribe6");
            updateProperty("Caribe6", "DrawnToScale", "False");
            updateProperty("Caribe6", "LogicalLength", "15000");
            createTransferNode(60, -35);
            updateName("TransferNode1", "TN27");
            createPath(getNodobasico("TN26"), getNodobasico("TN27"));
            updateName("Path1", "Caribe7");
            updateProperty("Caribe7", "DrawnToScale", "False");
            updateProperty("Caribe7", "LogicalLength", "53000");
            createTransferNode(40, -35);
            updateName("TransferNode1", "TN28");
            createPath(getNodobasico("TN27"), getNodobasico("TN28"));
            updateName("Path1", "Belice");
            updateProperty("Belice", "DrawnToScale", "False");
            updateProperty("Belice", "LogicalLength", "66000");
            createPath(getNodobasico("TN28"), getNodobasico("TN1"));
            updateName("Path1", "Belice2");
            updateProperty("Belice2", "DrawnToScale", "False");
            updateProperty("Belice2", "LogicalLength", "200000");
            
        }

        public void createZone()
        {
            //Server 
            createServer(0, 0);
            updateName("Server1", "Metropolitana");
            model.Facility.IntelligentObjects["Metropolitana"].Properties["ProcessingTime"].Value = "Random.Exponential(4)";
            model.Facility.IntelligentObjects["Output@Metropolitana"].Properties["OutboundLinkRule"].Value = "ByLinkWeight";
            createServer(5, -20);
            updateName("Server1", "Norte");
            model.Facility.IntelligentObjects["Norte"].Properties["ProcessingTime"].Value = "Random.Exponential(5)";
            model.Facility.IntelligentObjects["Output@Norte"].Properties["OutboundLinkRule"].Value = "ByLinkWeight";
            createServer(30, -10);
            updateName("Server1", "NorOriente");
            model.Facility.IntelligentObjects["NorOriente"].Properties["ProcessingTime"].Value = "Random.Exponential(3)";
            model.Facility.IntelligentObjects["Output@NorOriente"].Properties["OutboundLinkRule"].Value = "ByLinkWeight";
            createServer(15, 20);
            updateName("Server1", "SurOriente");
            model.Facility.IntelligentObjects["SurOriente"].Properties["ProcessingTime"].Value = "Random.Exponential(4)";
            model.Facility.IntelligentObjects["Output@SurOriente"].Properties["OutboundLinkRule"].Value = "ByLinkWeight";
            createServer(-15, 20);
            updateName("Server1", "Central");
            model.Facility.IntelligentObjects["Central"].Properties["ProcessingTime"].Value = "Random.Exponential(5)";
            model.Facility.IntelligentObjects["Output@Central"].Properties["OutboundLinkRule"].Value = "ByLinkWeight";
            createServer(-40, 10);
            updateName("Server1", "SurOccidente");
            model.Facility.IntelligentObjects["SurOccidente"].Properties["ProcessingTime"].Value = "Random.Exponential(3)";
            model.Facility.IntelligentObjects["Output@SurOccidente"].Properties["OutboundLinkRule"].Value = "ByLinkWeight";
            createServer(-40, -20);
            updateName("Server1", "NorOccidente");
            model.Facility.IntelligentObjects["NorOccidente"].Properties["ProcessingTime"].Value = "Random.Exponential(6)";
            model.Facility.IntelligentObjects["Output@NorOccidente"].Properties["OutboundLinkRule"].Value = "ByLinkWeight";
            createServer(10, -50);
            updateName("Server1", "Peten");
            model.Facility.IntelligentObjects["Peten"].Properties["ProcessingTime"].Value = "Random.Exponential(4)";
            model.Facility.IntelligentObjects["Output@Peten"].Properties["OutboundLinkRule"].Value = "ByLinkWeight";

        }

        public void createCardinals()
        {
            createTransferNode(0, -100);
            updateName("TransferNode1", "PCNorte");
            createTransferNode(0, 70);
            updateName("TransferNode1", "PCSur");
            createTransferNode(-90, 0);
            updateName("TransferNode1", "PCOeste");
            createTransferNode(90, 0);
            updateName("TransferNode1", "PCEste");
        }

        public void createAirpot() {

            //Peten
            createSource(2, -51);
            updateName("Source1", "TuristasNacionalesPeten");
            model.Facility.IntelligentObjects["TuristasNacionalesPeten"].Properties["InterarrivalTime"].Value = "Random.Poisson(4)";

            createSource(2,-48);
            updateName("Source1", "TuristasInternacionalesPeten");
            model.Facility.IntelligentObjects["TuristasInternacionalesPeten"].Properties["InterarrivalTime"].Value = "Random.Exponential(50)";
            model.Facility.IntelligentObjects["TuristasInternacionalesPeten"].Properties["EntitiesPerArrival"].Value = "40";

            createSink(18, -50);
            updateName("Sink1", "AeropuertoSalidaP");

            createTransferNode(10, -53);
            updateName("TransferNode1", "RetornoPeten");

            createPath(getNodo("TuristasNacionalesPeten", 0), getNodo("Peten", 0));
            updateName("Path1", "NTuristasPeten");

            createPath(getNodo("TuristasInternacionalesPeten", 0), getNodo("Peten", 0));
            updateName("Path1", "ITuristasPeten");

            createPath(getNodo("Peten", 1), getNodobasico("RetornoPeten"));
            updateName("Path1", "RPeten");
            model.Facility.IntelligentObjects["RPeten"].Properties["SelectionWeight"].Value = "0.5";

            createPath(getNodobasico("RetornoPeten"), getNodo("Peten", 0));
            updateName("Path1", "RPeten2");

            createPath(getNodo("Peten",1), getNodo("AeropuertoSalidaP", 0));
            updateName("Path1", "SalidaPeten");


            //Norte
            createSource(-2, -22);
            updateName("Source1", "TuristasNacionalesNorte");
            model.Facility.IntelligentObjects["TuristasNacionalesNorte"].Properties["InterarrivalTime"].Value = "Random.Poisson(8)";
            //source - server
            createPath(getNodo("TuristasNacionalesNorte", 0), getNodo("Norte", 0));
            updateName("Path1", "NTuristasNorte");

            createTransferNode(5, -23);
            updateName("TransferNode1", "RetornoNorte");

            createTransferNode(3, -15);
            updateName("TransferNode1", "ResTNorte");
            
            
            createTransferNode(3, -32);
            updateName("TransferNode1", "SalidaNorteNorOccidente");

            //tranfert - input server
            createPath(getNodobasico("RetornoNorte"), getNodo("Norte", 0));
            updateName("Path1", "RNorte2");
            //output server - transfer
            createPath(getNodo("Norte", 1), getNodobasico("RetornoNorte"));
            updateName("Path1", "RNorte1");
            model.Facility.IntelligentObjects["RNorte1"].Properties["SelectionWeight"].Value = "0.4";

            createPath(getNodobasico("ResTNorte"), getNodo("Norte", 0));
            updateName("Path1", "ResNorte1");

            createPath(getNodo("Norte", 0 ), getNodobasico("SalidaNorteNorOccidente"));
            updateName("Path1", "PSalidaNorteNorOccidente");



            //NorOccidente
            createSource(-48, -22);
            updateName("Source1", "TuristasNacionalesNorOccidente");
            model.Facility.IntelligentObjects["TuristasNacionalesNorOccidente"].Properties["InterarrivalTime"].Value = "Random.Poisson(12)";
            //source -server
            createPath(getNodo("TuristasNacionalesNorOccidente", 0), getNodo("NorOccidente", 0));
            updateName("Path1", "NTuristasNorOccidente");

            createTransferNode(-40, -23);
            updateName("TransferNode1", "RetornoNorOccidente");

            //trasnfer - input server
            createPath(getNodobasico("RetornoNorOccidente"), getNodo("NorOccidente", 0));
            updateName("Path1", "RNorOccidente2");

            //output server -transerf 
            createPath(getNodo("NorOccidente", 1), getNodobasico("RetornoNorOccidente"));
            updateName("Path1", "RNorOccidente");
            model.Facility.IntelligentObjects["RNorOccidente"].Properties["SelectionWeight"].Value = "0.4";



            //NorOriente
            createSource(18, -12);
            updateName("Source1", "TuristasNacionalesNorOriente");
            model.Facility.IntelligentObjects["TuristasNacionalesNorOriente"].Properties["InterarrivalTime"].Value = "Random.Poisson(6)";
            //source - server
            createPath(getNodo("TuristasNacionalesNorOriente", 0), getNodo("NorOriente", 0));
            updateName("Path1", "NTuristasNorOriente");

            createTransferNode(30, -13);
            updateName("TransferNode1", "RetornoNorOriente");

            createTransferNode(16, -10);
            updateName("TransferNode1", "ResNorOriente");

            createTransferNode(31, -15);
            updateName("TransferNode1", "SalidaNorteNorOriente");

            createTransferNode(31, -7);
            updateName("TransferNode1", "SalidaNorOccidenteNorOriente");

            createTransferNode(22, 0);
            updateName("TransferNode1", "RetornoMetropolitanaNorOriente");

            createPath(getNodobasico("RetornoNorOriente"), getNodo("NorOriente", 0));
            updateName("Path1", "RNorOriente2");

            createPath(getNodo("NorOriente", 1), getNodobasico("RetornoNorOriente"));
            updateName("Path1", "RNorOriente");
            model.Facility.IntelligentObjects["RNorOriente"].Properties["SelectionWeight"].Value = "0.20";

            createPath(getNodobasico("ResNorOriente"), getNodo("NorOriente",0));
            updateName("Path1", "ResNorOriente");

            createPath(getNodo("NorOriente", 1), getNodobasico("SalidaNorteNorOriente"));
            updateName("Path1", "PSalidaNorteNorOriente");

            createPath(getNodo("NorOriente", 1), getNodobasico("SalidaNorOccidenteNorOriente"));
            updateName("Path1", "ResNorOccidenteNorOriente");

            
            //SurOriente
            createSource(7, 18);
            updateName("Source1", "TuristasNacionalesSurOriente");
            model.Facility.IntelligentObjects["TuristasNacionalesSurOriente"].Properties["InterarrivalTime"].Value = "Random.Poisson(10)";

            createPath(getNodo("TuristasNacionalesSurOriente", 0), getNodo("SurOriente", 0));
            updateName("Path1", "NTuristasNorOriente");


            createTransferNode(15, 23);
            updateName("TransferNode1", "RetornoSurOriente");

            createTransferNode(13, 14);
            updateName("TransferNode1", "MetroSurOriente");

            createTransferNode(0, 38);
            updateName("TransferNode1", "CentralSurOriente");

            createPath(getNodobasico("RetornoSurOriente"), getNodo("SurOriente", 0));
            updateName("Path1", "RSurOriente2");

            createPath(getNodo("SurOriente", 1), getNodobasico("RetornoSurOriente"));
            updateName("Path1", "RSurOriente");

            createPath(getNodobasico("MetroSurOriente"), getNodo("SurOriente", 0));
            updateName("Path1", "PMetroSurOriente");

            createPath(getNodo("SurOriente",1), getNodobasico("CentralSurOriente"));
            updateName("Path1", "SalidaCentralSurOriente");

            //Central
            createSource(-23, 19);
            updateName("Source1", "TuristasNacionalesCentral");
            model.Facility.IntelligentObjects["TuristasNacionalesCentral"].Properties["InterarrivalTime"].Value = "Random.Poisson(3)";

            createPath(getNodo("TuristasNacionalesCentral", 0), getNodo("Central", 0));
            updateName("Path1", "NTuristasCentral");

            createTransferNode(-15, 23);
            updateName("TransferNode1", "RetornoCentral");

            createTransferNode(-15, 15);
            updateName("TransferNode1", "SalidaSurOccidenteCentral");

            createPath(getNodobasico("RetornoCentral"), getNodo("Central", 0));
            updateName("Path1", "RCentral2");

            createPath(getNodo("Central", 1), getNodobasico("RetornoCentral"));
            updateName("Path1", "RCentral");

            createPath(getNodo("Central", 1), getNodobasico("SalidaSurOccidenteCentral"));
            updateName("Path1", "SalidaSurOccidenteCentral");

            //Sur Occidente

            createSource(-46, 8);
            updateName("Source1", "TuristasNacionalesSurOccidente");
            model.Facility.IntelligentObjects["TuristasNacionalesSurOccidente"].Properties["InterarrivalTime"].Value = "Random.Poisson(4)";

            createSource(-46, 11);
            updateName("Source1", "TuristasInternacionalesSurOccidente");
            model.Facility.IntelligentObjects["TuristasInternacionalesSurOccidente"].Properties["InterarrivalTime"].Value = "Random.Exponential(70)";
            model.Facility.IntelligentObjects["TuristasInternacionalesSurOccidente"].Properties["EntitiesPerArrival"].Value = "30";


            createSink(-32, 8);
            updateName("Sink1", "AeropuertoSalidaSurOccidente");

            createTransferNode(-40, 7);
            updateName("TransferNode1", "RetornoSurOccidente");

            createTransferNode(-41, 15);
            updateName("TransferNode1", "RetornoCentralSurOccidente");

            createPath(getNodo("TuristasNacionalesSurOccidente", 0), getNodo("SurOccidente", 0));
            updateName("Path1", "NTuristasSurOccidente");
            createPath(getNodo("TuristasInternacionalesSurOccidente", 0), getNodo("SurOccidente", 0));
            updateName("Path1", "ITuristasSurOccidente");

            createPath(getNodo("SurOccidente", 1), getNodobasico("RetornoSurOccidente"));
            updateName("Path1", "RSurOccidente");

            createPath(getNodobasico("RetornoSurOccidente"), getNodo("SurOccidente", 0));
            updateName("Path1", "RSurOccidente2");

            createPath(getNodo("SurOccidente", 1), getNodo("AeropuertoSalidaSurOccidente", 0));
            updateName("Path1", "SalidaSurOccidente");

            createPath(getNodobasico("RetornoCentralSurOccidente"), getNodo("SurOccidente", 0));
            updateName("Path1", "PRetornoCentralSurOccidente");


            //Metropolitana

            createSource(-8, -1);
            updateName("Source1", "TuristasNacionalesMetropolitana");
            model.Facility.IntelligentObjects["TuristasNacionalesMetropolitana"].Properties["InterarrivalTime"].Value = "Random.Poisson(2)";
            createSource(-8,1);
            updateName("Source1", "TuristasInternacionalesMetropolitana");
            model.Facility.IntelligentObjects["TuristasInternacionalesMetropolitana"].Properties["InterarrivalTime"].Value = "Random.Exponential(35)";
            model.Facility.IntelligentObjects["TuristasInternacionalesMetropolitana"].Properties["EntitiesPerArrival"].Value = "70";

            createSink(7, -3);
            updateName("Sink1", "AeropuertoSalidaMetropolitana");

            createTransferNode(0, -3);
            updateName("TransferNode1", "RetornoMetropolitana");

            createTransferNode(-1, -7);
            updateName("TransferNode1", "RetornoNorOrienteMetropolitana");

            createTransferNode(-13, 0);
            updateName("TransferNode1", "RetornoCentralMetropolitana");

            createPath(getNodo("TuristasNacionalesMetropolitana", 0), getNodo("Metropolitana", 0));
            updateName("Path1", "NTuristasMetropolitana");
            createPath(getNodo("TuristasInternacionalesMetropolitana", 0), getNodo("Metropolitana", 0));
            updateName("Path1", "ITuristasMetropolitana");

            createPath(getNodo("Metropolitana", 1), getNodobasico("RetornoMetropolitana"));
            updateName("Path1", "RMetropolitana");

            createPath(getNodobasico("RetornoMetropolitana"), getNodo("Metropolitana", 0));
            updateName("Path1", "RMetropolitana2");

            createPath(getNodo("Metropolitana", 1), getNodo("AeropuertoSalidaMetropolitana", 0));
            updateName("Path1", "SalidaMetropolitana");

            createPath(getNodobasico("RetornoNorOrienteMetropolitana"), getNodo("Metropolitana", 0));
            updateName("Path1", "RRetornoNorOrienteMetropolitana2");

            createPath(getNodobasico("RetornoCentralMetropolitana"), getNodo("Metropolitana", 0));
            updateName("Path1", "PRetornoCentralMetropolitana");

            
            //Caminos 

            //Peten
            createPath(getNodo("Peten", 1), getNodo("NorOriente", 0));
            updateName("Path1", "PetenNorOriente");
            model.Facility.IntelligentObjects["PetenNorOriente"].Properties["SelectionWeight"].Value = "0.25";

            createPath(getNodo("Peten", 1), getNodo("Norte", 0));
            updateName("Path1", "PetenNorte");
            model.Facility.IntelligentObjects["PetenNorte"].Properties["SelectionWeight"].Value = "0.25";

            //Norte
            createPath(getNodo("Norte", 1), getNodo("NorOriente", 0));
            updateName("Path1", "NortenNorOriente");
            model.Facility.IntelligentObjects["NortenNorOriente"].Properties["SelectionWeight"].Value = "0.10";

            createPath(getNodobasico("SalidaNorteNorOccidente"), getNodo("NorOccidente", 0));
            updateName("Path1", "NorteNorOccidente");
            model.Facility.IntelligentObjects["NorteNorOccidente"].Properties["SelectionWeight"].Value = "0.10";

            createPath(getNodo("Norte", 1), getNodo("Peten", 0));
            updateName("Path1", "NortePten");
            model.Facility.IntelligentObjects["NortePten"].Properties["SelectionWeight"].Value = "0.4";

            //NorOccidente
            createPath(getNodo("NorOccidente", 1), getNodo("Central", 0));
            updateName("Path1", "NorOccidenteCentral");
            model.Facility.IntelligentObjects["NorOccidenteCentral"].Properties["SelectionWeight"].Value = "0.10";

            createPath(getNodo("NorOccidente", 1), getNodo("SurOccidente", 0));
            updateName("Path1", "NorOccidenteSurOccidente");
            model.Facility.IntelligentObjects["NorOccidenteSurOccidente"].Properties["SelectionWeight"].Value = "0.30";

            createPath(getNodo("NorOccidente", 1), getNodo("Norte", 0));
            updateName("Path1", "NorOccidenteNorte");
            model.Facility.IntelligentObjects["NorOccidenteNorte"].Properties["SelectionWeight"].Value = "0.20";

            //NorOriente
            createPath(getNodobasico("SalidaNorteNorOriente"), getNodobasico("ResTNorte"));
            updateName("Path1", "NorOrienteNorte");
            model.Facility.IntelligentObjects["NorOrienteNorte"].Properties["SelectionWeight"].Value = "0.15";

            createPath(getNodobasico("SalidaNorOccidenteNorOriente"), getNodobasico("RetornoNorOrienteMetropolitana"));
            updateName("Path1", "NorOrienteMetropolitana");
            model.Facility.IntelligentObjects["NorOrienteMetropolitana"].Properties["SelectionWeight"].Value = "0.30";

            createPath(getNodo("NorOriente", 1), getNodo("Peten", 0));
            updateName("Path1", "NorOrientePeten");
            model.Facility.IntelligentObjects["NorOrientePeten"].Properties["SelectionWeight"].Value = "0.30";

            createPath(getNodo("NorOriente", 1), getNodo("SurOriente", 0));
            updateName("Path1", "NorOrienteSurOriente");
            model.Facility.IntelligentObjects["NorOrienteSurOriente"].Properties["SelectionWeight"].Value = "0.05";

            createPath(getNodobasico("RetornoMetropolitanaNorOriente"), getNodo("NorOriente",0));
            updateName("Path1", "NorOrienteMetropolitana");
            model.Facility.IntelligentObjects["NorOrienteMetropolitana"].Properties["SelectionWeight"].Value = "0.20";


            //SurOccidente
            createPath(getNodo("SurOccidente", 1), getNodo("Central", 0));
            updateName("Path1", "SurOccidenteCentral");

            createPath(getNodo("SurOccidente", 1), getNodo("NorOccidente", 0));
            updateName("Path1", "SurOccidenteOccidente");


            //SurOriente
            createPath(getNodo("SurOriente", 1), getNodobasico("ResNorOriente"));
            updateName("Path1", "SurOrienteNorOriente");

            createPath(getNodo("SurOriente", 1), getNodo("Metropolitana",0));
            updateName("Path1", "SurOrienteMetropolitana");

            createPath(getNodobasico("CentralSurOriente"), getNodo("Central",0));
            updateName("Path1", "SurOrienteCentral");

            //Central 
            createPath(getNodobasico("SalidaSurOccidenteCentral"), getNodobasico("RetornoCentralSurOccidente"));
            updateName("Path1", "CentralSurOccidente");

            createPath(getNodo("Central",1), getNodobasico("RetornoCentralMetropolitana"));
            updateName("Path1", "CentralMetropolitana");

            createPath(getNodo("Central", 1), getNodo("SurOriente",0));
            updateName("Path1", "CentralSurOriente");


            //Metropolitana

            createPath(getNodo("Metropolitana", 1), getNodobasico("RetornoMetropolitanaNorOriente"));
            updateName("Path1", "MetropolitanaNorOriente");

            createPath(getNodo("Metropolitana", 1), getNodobasico("MetroSurOriente"));
            updateName("Path1", "MetropolitanaSurOriente");

            createPath(getNodo("Metropolitana", 1), getNodo("Central", 0));
            updateName("Path1", "MetropolitanaCentrall");


            

        }

        //-------------------Objetos-------------------//

        public void createSource(int x, int y)
        {
            this.createObject("Source", x, y);
        }

        public void createServer(int x, int y)
        {
            this.createObject("Server", x, y);
        }

        public void createSink(int x, int y)
        {
            this.createObject("Sink", x, y);
        }

        public void createTransferNode(int x, int y)
        {
            this.createObject("TransferNode", x, y);           
        }

        //----------------------------Enlaces----------------------------//
        public void createPath(INodeObject nodo1, INodeObject nodo2)
        {
            this.createLink("Path", nodo1, nodo2);
            
        }
        /*
        public void createTimePath(INodeObject nodo1, INodeObject nodo2)
        {
            this.createLink("TimePath", nodo1, nodo2);
        }

        public void createConveyor(INodeObject nodo1, INodeObject nodo2)
        {
            this.createLink("Conveyor", nodo1, nodo2);
        }*/


        //---------------------------------- Crear objetos y enlaces ----------------------------------//
        public void createObject(String type, int x, int y)
        {
            intelligentObjects.CreateObject(type, new FacilityLocation(x, 0, y));
        }

        public void createLink(String type, INodeObject nodo1, INodeObject nodo2)
        {
            intelligentObjects.CreateLink(type, nodo1, nodo2, null);
            
            

        }



        //------------------------------------- Modificar propiedades --------------------------------//
        public void updateProperty(String name, String property, String value)
        {
            model.Facility.IntelligentObjects[name].Properties[property].Value = value;
            //model.Facility.IntelligentObjects[name].Properties[property]
        }

        //--------------------------------------- Modificar nombre  -----------------------------------//
        public void updateName(String oldName, String newName)
        {
            model.Facility.IntelligentObjects[oldName].ObjectName = newName;
        }

        //---------------------------------------- Obtener Nodo ----------------------------------------//
        public INodeObject getNodo(String name, int nodo)
        {
            return ((IFixedObject)model.Facility.IntelligentObjects[name]).Nodes[nodo];           
        }

        //---------------------------------- Obtener Nodo Basicos --------------------------------------//
        public INodeObject getNodobasico (String name)
        {
            return (INodeObject)model.Facility.IntelligentObjects[name];
        }

        //prueba 
    }
}
